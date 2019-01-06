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
using Core.Clases;

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
        public int Pro_Sucursal { get; set; }
        public int Pro_Cliente { get; set; }
        public int Pro_Posicion { get; set; }
        public int Pro_Prioridad_Atencion { get; set; } //A qué tipo de Ticket dará prioridad la posicion asignada.
        public int Pro_ID_NivelAccesoEmpleado { get; set; }
        public string Pro_DescripcionNivelAcceso { get; set; }
        public string Pro_Cargo { get; set; }
        public string Pro_NombreEmpleado { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Ticket_Servicio { get; set; }

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
            Pro_Sucursal = pID_AgenciaServicio;
            Pro_Cliente = pID_ClienteServicio;
            Pro_ID_NivelAccesoEmpleado = pID_NivelAccesoEmpleado;
            Pro_DescripcionNivelAcceso = Pro_DescripcionNivelAcceso;
            Pro_Cargo = pCargoEmpleado;
            Pro_NombreEmpleado = pNombreEmpleado;
            Pro_Usuario = pUsuarioEmpleado;

            lblNombreUsuario.Text = Pro_NombreEmpleado;

        }

        private void CargarDatosTicketPosicion()
        {
            

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            try
            {
                string sentencia = @"SELECT * FROM operaciones.ft_proc_asigna_devuelve_ticket_posicion (
                                                                                                        :p_usuario, 
                                                                                                        :p_agencia,
                                                                                                        :p_cliente
                                                                                                       );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia,Pro_Conexion);
                pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
                pgComando.Parameters.Add("p_agencia", PgSqlType.Int).Value = Pro_Sucursal;
                pgComando.Parameters.Add("p_cliente", PgSqlType.Int).Value = Pro_Cliente;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    lblPosicion.Text = pgDr.GetString("posicion");
                    lblNumeroTicket.Text = pgDr.GetString("ticket");
                }

                pgDr.Close();
                pgDr = null;
                pgComando.Dispose();

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
            CargarDatosTicketPosicion();
            Tiempos cl_tiempos = new Tiempos();
            cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                              (int)ESTADOS_TICKETS.EN_ATENCION,
                                              Pro_Sucursal,
                                              Pro_Cliente,
                                              Pro_Ticket_Servicio);
            tmrTiempoAtencion.Start();

        }

        private void CerrarTicket()
        {
            tmrTiempoAtencion.Stop();
            Tiempos cl_tiempos = new Tiempos();
            cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                              (int)ESTADOS_TICKETS.CERRADO,
                                              Pro_Sucursal,
                                              Pro_Cliente,
                                              Pro_Ticket_Servicio);
            ReinicioVariablesTiempo();

        }

        public void MarcarClienteNoRespondioLlamado()
        {
            Tiempos cl_tiempos = new Tiempos();
            cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                              (int)ESTADOS_TICKETS.NO_ATENDIO_LLAMADO,
                                              Pro_Sucursal,
                                              Pro_Cliente,
                                              Pro_Ticket_Servicio);
        }

        private void LlamarSiguienteCliente()
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            try
            {
                string sentencia = "";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                


                Tiempos cl_tiempos = new Tiempos();
                cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                                  (int)ESTADOS_TICKETS.LLAMADO,
                                                  Pro_Sucursal,
                                                  Pro_Cliente,
                                                  Pro_Ticket_Servicio);

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
            
        }

        public void PresionarF6_MarcarClienteNoRespondio(object sender)
        {
            ReinicioImagenesIcono();
            cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamadoVerde;
            
        }

        #endregion

        #region EVENTOS CONTROLES

        private void cmdIniciarTicket_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicketVerde;
            IniciarTicket();
        }

        private void cmdCerrarTicket_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicketVerde;
            CerrarTicket();    
        }

        private void cmdTiempoPersonal_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdTiempoPersonal.Image = Properties.Resources.IconPausaPersonalVerde;
            MarcarParoTiempoPersonal();
        }

        private void cmdAlmuerzo_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdAlmuerzo.Image = Properties.Resources.iconAlmuerzoVerde;
            MarcarParoTiempoAlmuerzo();
        }

        private void cmdLlamarCliente_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdLlamarCliente.Image = Properties.Resources.IconLlamarSiguienteClienteVerde;
            LlamarSiguienteCliente();
        }

        private void cmdClienteNoAtendioLlamado_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamadoVerde;
            MarcarClienteNoRespondioLlamado();
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

       
    }
}
