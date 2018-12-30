using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Speech.Synthesis;

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

        public void ConstruirControl(PgSqlConnection pConexion, int pSucursal, int pCliente)
        {
            Pro_Conexion = pConexion;
            Pro_Sucursal = pSucursal;
            Pro_ID_Cliente = pCliente;

            
            tmrConsultaCola.Start();
            tmrConsultaLlamadoTickets.Start();
        }

        private void CargarColaTickets()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_proc_obtener_cola_tickets (
                                                                                                  :p_cliente_servicio,
                                                                                                  :p_agencia_servicio
                                                                                              );";

                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_cliente_servicio",PgSqlType.Int).Value = Pro_ID_Cliente;
                pgComando.Parameters.Add("p_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;

                dsTicketsPosiciones1.dtTicketsPosiciones.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsTicketsPosiciones1.dtTicketsPosiciones);


              
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
        }

        
        

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente { get; set; }
        public int Pro_Sucursal { get; set; }



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
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            SpeechSynthesizer v_voz = null;
            PgSqlConnection vConexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            vConexion.Password = Pro_Conexion.Password;
            vConexion.Open();

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_proc_consulta_llamados_tickets (
                                                                                                      :p_agencia_servicio,
                                                                                                      :p_cliente_servicio
                                                                                                    )";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, vConexion);
                pgComando.Parameters.Add("p_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;
                pgComando.Parameters.Add("p_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    v_voz = new SpeechSynthesizer();
                    lblTicket.Text = pgDr.GetString("ticket");
                    lblPosicion.Text = pgDr.GetString("posicion");

                    
                    v_voz.SelectVoice("Microsoft Server Speech Text to Speech Voice (es-ES, Helena)");
                    v_voz.SetOutputToDefaultAudioDevice();
                    v_voz.Speak(lblTicket.Text + ", Posisión " + lblPosicion.Text); //Escribí posición con S , para que la palabra se escuche en versión latina.
                }

                pgDr.Close();
                pgComando.Dispose();
                vConexion.Close();
                vConexion.Dispose();
                v_voz.Dispose();

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

        #endregion
    }
}
