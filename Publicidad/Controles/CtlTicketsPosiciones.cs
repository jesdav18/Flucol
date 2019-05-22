﻿using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Speech.Synthesis;
using System.Configuration;
using DevExpress.XtraEditors.Controls;

namespace Publicidad.Controles
{
    public partial class CtlTicketsPosiciones : UserControl
    {

        #region INICIALIZADOR
    
        public CtlTicketsPosiciones()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                    int pSucursal, 
                                    int pCliente)
        {
            Pro_Conexion = pConexion;
            Pro_Sucursal = pSucursal;
            Pro_ID_Cliente = pCliente;


            Pro_Texto_Descriptivo = ConfigurationSettings.AppSettings["TEXTO_DESCRIPTIVO"];
            Pro_Voz = ConfigurationSettings.AppSettings["VOZ"];


            tmrConsultaCola.Start();
            tmrConsultaLlamadoTickets.Start();
        }

        private void CargarColaTickets()
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_obtener_cola_tickets (
                                                                                            :p_cliente_servicio,
                                                                                            :p_agencia_servicio
                                                                                            );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;
            pgComando.Parameters.Add("p_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;

            try
            {
                dsTicketsPosiciones1.dtTicketsPosiciones.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsTicketsPosiciones1.dtTicketsPosiciones);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
        }

        private void ValidarConexion()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                try
                {
                    Pro_Conexion.Open();
                }
                catch (Exception)
                {
                    PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
                    v_conexion.Password = Pro_Conexion.Password;
                    Pro_Conexion = v_conexion;
                    Pro_Conexion.Open();
                    v_conexion = null;
                }
            }
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente { get; set; }
        public int Pro_Sucursal { get; set; }
        public string Pro_Voz { get; set; }
        public string Pro_Texto_Descriptivo { get; set; }


        #endregion

        #region EVENTOS CONTROLES

        private void tmrConsultaLlamadoTickets_Tick(object sender, EventArgs e)
        {
            if (!bgLlamadoTickets.IsBusy)
            {
                bgLlamadoTickets.RunWorkerAsync();
            }
        }

        private void bgLlamadoTickets_DoWork(object sender, DoWorkEventArgs e)
        {

            SpeechSynthesizer v_voz = null;

            PgSqlConnection vConexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            vConexion.Password = Pro_Conexion.Password;
            vConexion.Open();

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_consulta_llamados_tickets (
                                                                                                :p_agencia_servicio,
                                                                                                :p_cliente_servicio
                                                                                               )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, vConexion);
            pgComando.Parameters.Add("p_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;
            pgComando.Parameters.Add("p_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;

            try
            {
               
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    string v_primera_letra;
                    string v_segunda_letra;
                    string v_tercera_letra;
                    string v_cuarta_letra;
                    string v_quinta_letra;
                    string v_sexta_letra;
                    int v_tipo_ticket;

                    v_voz = new SpeechSynthesizer();
                    lblTicket.Text = pgDr.GetString("ticket");
                    lblPosicion.Text = pgDr.GetString("posicion");
                    v_tipo_ticket = pgDr.GetInt32("tipo_ticket");
                    v_primera_letra = pgDr.GetString("primera_letra");
                    v_segunda_letra = pgDr.GetString("segunda_letra");
                    v_tercera_letra = pgDr.GetString("tercera_letra");
                    v_cuarta_letra = pgDr.GetString("cuarta_letra");
                    v_quinta_letra = pgDr.GetString("quinta_letra");
                    v_sexta_letra = pgDr.GetString("sexta_letra");

                    if (lblTicket.Text != "")
                    {
                        //v_voz.SelectVoice("Vocalizer Expressive Angelica Harpo 22kHz");

                        if (v_tipo_ticket == 1)
                        {
                            v_voz.SelectVoice(Pro_Voz);
                            v_voz.SetOutputToDefaultAudioDevice();
                            v_voz.Speak(v_primera_letra + "," + v_segunda_letra + "," + v_tercera_letra +
                                        v_cuarta_letra + ", " +
                                        v_quinta_letra + v_sexta_letra + ", " +
                                        Pro_Texto_Descriptivo + lblPosicion.Text);

                            v_voz.Dispose();
                        }
                        else
                        {
                            v_voz.SelectVoice(Pro_Voz);
                            v_voz.SetOutputToDefaultAudioDevice();
                            v_voz.Speak(v_primera_letra + "," + v_segunda_letra + ", " + 
                                        v_tercera_letra + ", " +
                                        v_cuarta_letra + v_quinta_letra + ", " +
                                        Pro_Texto_Descriptivo + lblPosicion.Text);

                            v_voz.Dispose();
                        }

                    }

                    v_primera_letra = null;
                    v_segunda_letra = null;
                    v_tercera_letra = null;
                    v_cuarta_letra = null;
                    v_quinta_letra = null;
                    v_sexta_letra = null;
                }
       
                pgDr.Close();
                pgDr = null;
                pgComando.Dispose();
                vConexion.Close();
                vConexion.Dispose();
                sentencia = null;

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
        }

        private void tmrConsultaCola_Tick(object sender, EventArgs e)
        {
            CargarColaTickets();
        }

        private void gvTicket_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvPosicion_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        #endregion

    }
}
