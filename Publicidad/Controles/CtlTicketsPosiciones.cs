using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Speech.Synthesis;
using System.Configuration;
using DevExpress.XtraEditors.Controls;
using Core.Clases;


namespace Publicidad.Controles
{
    public partial class CtlTicketsPosiciones : UserControl
    {

        #region INICIALIZADOR
    
        public CtlTicketsPosiciones()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
        }

        #endregion

        #region FUNCIONES

        public  void ConstruirControl(PgSqlConnection pConexion, 
                                            int pSucursal, 
                                            int pCliente)
        {
            Pro_Conexion = pConexion;
            Pro_Sucursal = pSucursal;
            Pro_ID_Cliente = pCliente;
            Pro_LlamadoTicketsActivo = true;
            Pro_CargarColaTicketsActivo = true;

            lblTicket.Text = "";
            lblPosicion.Text = "";

            Pro_Texto_Descriptivo = ConfigurationSettings.AppSettings["TEXTO_DESCRIPTIVO"];
            Pro_Voz = ConfigurationSettings.AppSettings["VOZ"];

            CargarColaTickets();

            tmrColaTickets.Start();
            tmrLlamadoTickets.Start();
                     
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

        private void CargarColaTickets()
        {
            ValidarConexion();

            PgSqlConnection vConexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            vConexion.Password = Pro_Conexion.Password;
            vConexion.Open();


            string sentencia = @"SELECT * FROM area_servicio.ft_view_cola_tickets (
                                                                                    :p_cliente_servicio,
                                                                                    :p_agencia_servicio
                                                                                    );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, vConexion);
            pgComando.Parameters.Add("p_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;
            pgComando.Parameters.Add("p_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;

            try
            {

                dsTicketsPosiciones1.dtTicketsPosiciones.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsTicketsPosiciones1.dtTicketsPosiciones);

                sentencia = null;
                pgComando.Dispose();
                vConexion.Close();
                vConexion.Dispose();
            }
            catch (Exception Exc)
            {
               
               
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "CargarColaTickets()");
                v_depurador = null;

            }
        }

        private void LlamadoTickets()
        {
            
            ValidarConexion();
            
            PgSqlConnection vConexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            vConexion.Password = Pro_Conexion.Password;
            vConexion.Open();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_consulta_llamados_tickets (
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
                    
                    v_ticket = pgDr.GetString("ticket");
                    v_posicion = pgDr.GetString("posicion");                   
                    v_tipo_ticket = pgDr.GetInt32("tipo_ticket");
                    v_primera_letra = pgDr.GetString("primera_letra");
                    v_segunda_letra = pgDr.GetString("segunda_letra");
                    v_tercera_letra = pgDr.GetString("tercera_letra");
                    v_cuarta_letra = pgDr.GetString("cuarta_letra");
                    v_quinta_letra = pgDr.GetString("quinta_letra");
                    v_sexta_letra = pgDr.GetString("sexta_letra");
                    v_longitud_ticket = pgDr.GetInt32("longitud_ticket");

                    ReproducirAudioLlamadoTicket();

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
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                    this.Name,
                                                    "LlamadoTickets()");
                v_depurador = null;                  
            }  
        }

        private void ReproducirAudioLlamadoTicket()
        {
            v_voz = new SpeechSynthesizer();

            lblTicket.Text = v_ticket;
            lblPosicion.Text = v_posicion;

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

                    if (v_longitud_ticket > 5)
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
            }

            v_primera_letra = null;
            v_segunda_letra = null;
            v_tercera_letra = null;
            v_cuarta_letra = null;
            v_quinta_letra = null;
            v_sexta_letra = null;
            v_ticket = null;
            v_posicion = null;

        }

        #endregion

        #region VARIABLES GLOBALES

        string v_primera_letra;
        string v_segunda_letra;
        string v_tercera_letra;
        string v_cuarta_letra;
        string v_quinta_letra;
        string v_sexta_letra;
        string v_ticket;
        string v_posicion;
        int v_tipo_ticket;
        int v_longitud_ticket;
        SpeechSynthesizer v_voz = null;

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente { get; set; }
        public int Pro_Sucursal { get; set; }
        public string Pro_Voz { get; set; }
        public string Pro_Texto_Descriptivo { get; set; }
        public bool Pro_LlamadoTicketsActivo { get; set; }
        public bool Pro_CargarColaTicketsActivo { get; set; }


        #endregion

        #region EVENTOS CONTROLES

        private void gvTicket_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvPosicion_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
 
        private void tmrColaTickets_Tick(object sender, EventArgs e)
        {
            CargarColaTickets();
        }

        private void tmrLlamadoTickets_Tick(object sender, EventArgs e)
        {
            LlamadoTickets();
            
        }

        #endregion

    }
}
