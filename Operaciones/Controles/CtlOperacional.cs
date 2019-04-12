using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Configuration;

namespace Operaciones.Controles
{
    public partial class CtlOperacional : UserControl
    {

        #region INICIALIZADOR
      
        public CtlOperacional()
        {
            InitializeComponent();
        }

        #endregion

        #region VARIABLES GLOBALES

        int v_segundos;
        int v_minutos;
        int v_hora;
        string v_tiempo;
        string v_temporal_ticket;

        #endregion

        #region ENUMERACIONES

       public enum ESTADOS_TICKETS
       {
            EN_ESPERA = 1,
            LLAMADO = 2,
            NO_ATENDIO_LLAMADO = 3, 
            EN_ATENCION = 4,
            CERRADO = 5
       }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_Posicion { get; set; }
        public int Pro_Prioridad_Atencion { get; set; } //A qué tipo de Ticket dará prioridad la posicion asignada.
        public int Pro_ID_NivelAccesoEmpleado { get; set; }
        public string Pro_DescripcionNivelAcceso { get; set; }
        public string Pro_Cargo { get; set; }
        public string Pro_NombreEmpleado { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Ticket_Servicio { get; set; }
        public bool Pro_Esta_En_Atencion { get; set; }
        

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pID_AgenciaServicio, 
                                     int pID_ClienteServicio,
                                     int pID_NivelAccesoEmpleado,
                                     string pDescripcionNivelAccesoEmpleado,
                                     string pCargoEmpleado,
                                     string pNombreEmpleado,
                                     string pUsuarioEmpleado)
        {

            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_ID_NivelAccesoEmpleado = pID_NivelAccesoEmpleado;
            Pro_DescripcionNivelAcceso = Pro_DescripcionNivelAcceso;
            Pro_Cargo = pCargoEmpleado;
            Pro_NombreEmpleado = pNombreEmpleado;
            Pro_Usuario = pUsuarioEmpleado;
            Pro_Esta_En_Atencion = false;
            lblNombreUsuario.Text = Pro_NombreEmpleado;
            lblNumeroTicket.Text = "";
            CargarDatosTicketPosicion();

        }

        private void CargarDatosTicketPosicion()
        {
            

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_devuelve_posicion_asignada (
                                                                                                    :p_usuario, 
                                                                                                    :p_agencia,
                                                                                                    :p_cliente
                                                                                                  );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_agencia", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_cliente", PgSqlType.Int).Value = Pro_ID_ClienteServicio;

            try
            {
                

                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    lblPosicion.Text = ConfigurationSettings.AppSettings["TEXTO_DESCRIPTIVO"] + " " + pgDr.GetString("posicion");
                   
                }

                pgDr.Close();
                pgDr = null;
                pgComando.Dispose();
                sentencia = null;

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }

        }

        
        private void ReinicioImagenesIcono()
        {
            cmdAlmuerzo.Image = Properties.Resources.iconAlmuerzo;
            cmdTiempoPersonal.Image = Properties.Resources.iconPausaPersonal;
            cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicket;
            cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicket;
            cmdLlamarCliente.Image = Properties.Resources.icon_llamar_siguiente_cliente;
            cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamado;
            cmdCerrarPrograma.Image = Properties.Resources.iconSalida;
        }
        

        private void ReinicioVariablesTiempo()
        {
            v_segundos = 0;
            v_minutos = 0;
            v_hora = 0;
            lblTiempoAtencion.Text = "00:00:00";
        }

        private void IniciarTicket()
        {
            
            Tiempos cl_tiempos = new Tiempos();
            cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                              (int)ESTADOS_TICKETS.EN_ATENCION,
                                              Pro_ID_AgenciaServicio,
                                              Pro_ID_ClienteServicio,
                                              Pro_Ticket_Servicio,
                                              Pro_Usuario);
            tmrTiempoAtencion.Start();

        }

        private void CerrarTicket()
        {
            tmrTiempoAtencion.Stop();
            Tiempos cl_tiempos = new Tiempos();
            cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                              (int)ESTADOS_TICKETS.CERRADO,
                                              Pro_ID_AgenciaServicio,
                                              Pro_ID_ClienteServicio,
                                              Pro_Ticket_Servicio,
                                              Pro_Usuario);
            ReinicioVariablesTiempo();

        }

        public void MarcarClienteNoRespondioLlamado()
        {
            Tiempos cl_tiempos = new Tiempos();
            cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                              (int)ESTADOS_TICKETS.NO_ATENDIO_LLAMADO,
                                              Pro_ID_AgenciaServicio,
                                              Pro_ID_ClienteServicio,
                                              Pro_Ticket_Servicio,
                                              Pro_Usuario);
        }

        private void LlamarSiguienteCliente(bool p_es_rellamada = false)
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_llama_siguiente_ticket (
                                                                                                :p_id_agencia_servicio,
                                                                                                :p_id_cliente_servicio,
                                                                                                :p_usuario,
                                                                                                :p_es_rellamada,
                                                                                                :p_id_ticket_servicio
                                                                                              )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_es_rellamada", PgSqlType.Boolean).Value = p_es_rellamada;
            pgComando.Parameters.Add("p_id_ticket_servicio", PgSqlType.VarChar).Value = lblNumeroTicket.Text;

            try
            {
               
                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    Pro_Ticket_Servicio = pgDr.GetString(0);
                    lblNumeroTicket.Text = Pro_Ticket_Servicio;
                }

                
                Tiempos cl_tiempos = new Tiempos();
                cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                                  (int)ESTADOS_TICKETS.LLAMADO,
                                                  Pro_ID_AgenciaServicio,
                                                  Pro_ID_ClienteServicio,
                                                  Pro_Ticket_Servicio,
                                                  Pro_Usuario
                                                  );

                cl_tiempos = null;
                pgDr.Close();
                pgComando.Dispose();
                sentencia = null;


            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }

           
        }

        public void MarcarParoTiempoAlmuerzo()
        {
            if (tmrParoTiempo.Enabled)
            {
                tmrParoTiempo.Stop();
                //Sentencias SQL que registren marcas.
            }
            else
            {
                tmrParoTiempo.Start();
                //Sentencias SQL que registren marcas.
            }


        }


        private void MarcarParoTiempoPersonal()
        {
            if (tmrParoTiempo.Enabled)
            {
                tmrParoTiempo.Stop();
                //Sentencias SQL que registren marcas.
            }
            else
            {
                tmrParoTiempo.Start();
                //Sentencias SQL que registren marcas.
            }
        }

     
        #endregion

        #region EVENTOS

        #endregion

        #region EVENTOS GLOBALES

        public void PresionaF11_SalidaAlmuerzo(object sender)
        {
            ReinicioImagenesIcono();
            cmdAlmuerzo.Image = Properties.Resources.iconAlmuerzoVerde;
            MarcarParoTiempoAlmuerzo();
        }

        public void PresionaF12_ParoTiempoPersonal(object sender)
        {
            ReinicioImagenesIcono();
            cmdTiempoPersonal.Image = Properties.Resources.IconPausaPersonalVerde;
            MarcarParoTiempoPersonal();
        } 

        public void PresionaF1_IniciarTicket(object sender)
        {
            ReinicioImagenesIcono();
            cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicketVerde;
            IniciarTicket();
        }

        public void PresionaF2_CerrarTicket(object sender)
        {
            ReinicioImagenesIcono();
            cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicketVerde;
            CerrarTicket();
        }

        public void PresionaF5_LlamarCliente(object sender)
        {
            ReinicioImagenesIcono();
            cmdLlamarCliente.Image = Properties.Resources.IconLlamarSiguienteClienteVerde;
            LlamarSiguienteCliente();
        }

        public void PresionarF6_MarcarClienteNoRespondio(object sender)
        {
            ReinicioImagenesIcono();
            cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamadoVerde;
            MarcarClienteNoRespondioLlamado();
            
        }

        public void PresionaF8_CerrarPrograma(object sender)
        {
            cmdCerrarPrograma_Click(sender,new EventArgs());
        }

        #endregion

        #region EVENTOS CONTROLES

        private void cmdIniciarTicket_Click(object sender, EventArgs e)
        {
            if (lblNumeroTicket.Text != "" && lblNumeroTicket.Text != "NO HAY TICKETS EN COLA")
            {
                ReinicioImagenesIcono();
                cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicketVerde;
                IniciarTicket();
                Pro_Esta_En_Atencion = true;
            }
            else
            {
                MessageBox.Show("No se ha llamado ningun cliente.","FLUCOL");
            }
            
        }

        private void cmdCerrarTicket_Click(object sender, EventArgs e)
        {
            if (lblNumeroTicket.Text != "")
            {
                ReinicioImagenesIcono();
                cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicketVerde;
                CerrarTicket();
                Pro_Esta_En_Atencion = false;
            }
            else
            {
                MessageBox.Show("No se ha iniciado ningun ticket.","FLUCOL");
            }
            
        }

        private void cmdTiempoPersonal_Click(object sender, EventArgs e)
        {
            if (!Pro_Esta_En_Atencion)
            {
                ReinicioImagenesIcono();
                cmdTiempoPersonal.Image = Properties.Resources.IconPausaPersonalVerde;
                MarcarParoTiempoPersonal();
                Pro_Esta_En_Atencion = false;
            }
            else
            {
                MessageBox.Show("El ticket aun no ha sido cerrado.","FLUCOL");
            }
          
        }

        private void cmdAlmuerzo_Click(object sender, EventArgs e)
        {
            if (!Pro_Esta_En_Atencion)
            {
                ReinicioImagenesIcono();
                cmdAlmuerzo.Image = Properties.Resources.iconAlmuerzoVerde;
                MarcarParoTiempoAlmuerzo();
                Pro_Esta_En_Atencion = false;
            }
            else
            {
                MessageBox.Show("No puede salir a su almuerzo porque el ticket no ha sido cerrado. ","FLUCOL");
            }
            
        }

        private void cmdLlamarCliente_Click(object sender, EventArgs e)
        {
           
            if ( !Pro_Esta_En_Atencion)
            {

                cmdLlamarCliente.Image = Properties.Resources.IconLlamarSiguienteClienteVerde;

                ReinicioImagenesIcono();
                LlamarSiguienteCliente();

                v_temporal_ticket = lblNumeroTicket.Text;
               
            }
            else
            {
                MessageBox.Show("No puede llamar a otro cliente mientras no cierre el ticket Actual. ","FLUCOL");
            }
            
        }

        private void cmdClienteNoAtendioLlamado_Click(object sender, EventArgs e)
        {

            if (!Pro_Esta_En_Atencion)
            {
                ReinicioImagenesIcono();
                cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamadoVerde;
                MarcarClienteNoRespondioLlamado();
                Pro_Esta_En_Atencion = false;
            }
            else
            {
                MessageBox.Show("Aun no ha finalizado el ticket! ","FLUCOL");
            }
            
        }

        private void cmdCerrarPrograma_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdCerrarPrograma.Image = Properties.Resources.iconSalidaVerde;
            Application.Exit();
        }

        private void tmrTiempoAtencion_Tick(object sender, EventArgs e)
        {
            v_segundos++;
            v_tiempo = "";


            if (v_minutos == 60)
            {
                v_minutos = 0;
                v_hora++;
                v_tiempo += "0" + v_hora;
            }
            else
            {
                if (v_hora < 10)
                {
                    v_tiempo += "0" + v_hora;
                }
                else
                {
                    v_tiempo += v_hora;
                }
            }

            v_tiempo += ":";

             
            if (v_segundos == 60)
            {
                v_segundos = 0;
                v_minutos++;
                v_tiempo += "0" + v_minutos;
            }
            else
            {
                if (v_minutos < 10)
                {
                    v_tiempo += "0" + v_minutos;
                }
                else
                {
                    v_tiempo += v_minutos;
                }
            }
                
            v_tiempo += ":";

        
            if (v_segundos < 10)
            {
                v_tiempo += "0" + v_segundos;
            }
            else
            {
                v_tiempo += v_segundos;
            }
               
            lblTiempoAtencion.Text = v_tiempo;

        }


        #endregion

        private void lblNumeroTicket_Click(object sender, EventArgs e)
        {
            if (lblNumeroTicket.Text != "" && lblNumeroTicket.Text != "NO HAY TICKETS EN COLA")
            {
                ReinicioImagenesIcono();
                LlamarSiguienteCliente(true);
            }
        }
    }
}
