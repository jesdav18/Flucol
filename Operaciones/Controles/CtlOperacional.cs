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
            CheckForIllegalCrossThreadCalls = false;
            ctlOperacionalReducido1.On_CerrarTicket += ctlOperacionalReducido1_CerrarTicket;
            ctlOperacionalReducido1.On_IniciarTicket += ctlOperacionalReducido1_IniciarTicket;
            ctlOperacionalReducido1.On_LlamarCliente += ctlOperacionalReducido1_LlamarCliente;
            ctlOperacionalReducido1.On_RellamarTicket += ctlOperacionalReducido1_RellamarTicket;
            ctlOperacionalReducido1.On_ClienteNoAtendioLlamado += ctlOperacionalReducido1_ClienteNoAtendioLlamado;
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
            NO_HA_SIDO_LLAMADO = 0,
            EN_ESPERA = 1,
            LLAMADO = 2,
            NO_ATENDIO_LLAMADO = 3, 
            EN_ATENCION = 4,
            CERRADO = 5
       }

        public enum MOTIVOS_PARO_TIEMPO
        {
            ALMUERZO = 1,
            PERMISO_OTORGADO = 2,
            FALLA_EN_SISTEMA = 3,
            OTROS_MOTIVOS = 4,
            SALIDA_SANITARIO = 5
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
        public string Pro_CodigoEmpleado { get; set; }
        public bool Pro_Esta_En_ModoReducido { get; set; }
      
        #endregion

        #region EVENTOS

        public event EventHandler OnCerrarSesion;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pID_AgenciaServicio, 
                                     int pID_ClienteServicio,
                                     int pID_NivelAccesoEmpleado,
                                     string pDescripcionNivelAccesoEmpleado,
                                     string pCargoEmpleado,
                                     string pNombreEmpleado,
                                     string pUsuarioEmpleado,
                                     string pCodigoEmpleado,
                                     string pNombreAgencia
                                     )
        {

            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_ID_NivelAccesoEmpleado = pID_NivelAccesoEmpleado;
            Pro_DescripcionNivelAcceso = Pro_DescripcionNivelAcceso;
            Pro_Cargo = pCargoEmpleado;
            Pro_NombreEmpleado = pNombreEmpleado;
            Pro_Usuario = pUsuarioEmpleado;
            Pro_CodigoEmpleado = pCodigoEmpleado;
            Pro_Esta_En_Atencion = false;
            Pro_Esta_En_ModoReducido = false;
            lblNombreUsuario.Text = Pro_NombreEmpleado;
            lblNumeroTicket.Text = "";
            lblAgencia.Text = pNombreAgencia;

                        
            ctlListaTicketsEspera1.ConstruirControl(Pro_Conexion,
                                                    Pro_ID_AgenciaServicio,
                                                    Pro_ID_ClienteServicio,
                                                    Pro_Usuario);

          
        }
        
        private bool CargarDatosTicketPosicion()
        {
            ValidarConexion();

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
                    lblPosicion.Text = null;
                    lblPosicion.Text = ConfigurationSettings.AppSettings["TEXTO_DESCRIPTIVO"] + " " + 
                                       pgDr.GetString("posicion");                  
                }


                pgDr.Close();
                pgDr = null;
                pgComando.Dispose();
                sentencia = null;

                if (string.IsNullOrEmpty(lblPosicion.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "CargarDatosTicketPosicion()");
                v_depurador = null;
                MessageBox.Show(Exc.Message, "FLUCOL");
                return false;
            }
        }

        private void ReinicioImagenesIcono()
        {
            try
            {
                cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicket;
                cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicket;
                cmdLlamarCliente.Image = Properties.Resources.icon_llamar_siguiente_cliente;
                cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamado;
                cmdRellamar.Image = Properties.Resources.icon_rellamar_negro_64; ;
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "ReinicioImagenesIcono()");
                v_depurador = null;
            }
       
        }

        private void ReinicioVariablesTiempo()
        {
            v_segundos = 0;
            v_minutos = 0;
            v_hora = 0;
            lblTiempoAtencion.Text = "00:00:00";
            ctlOperacionalReducido1.lblTiempoAtencion.Text = "00:00:00";
        }

        private void IniciarTicket()
        {

            try
            {
                Tiempos cl_tiempos = new Tiempos();
                if (cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                                  (int)ESTADOS_TICKETS.EN_ATENCION,
                                                  Pro_ID_AgenciaServicio,
                                                  Pro_ID_ClienteServicio,
                                                  Pro_Ticket_Servicio,
                                                  Pro_Usuario))
                {
                    tmrTiempoAtencion.Start();
                }

                cl_tiempos = null;
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "IniciarTicket()");
                v_depurador = null;

            }
        
        }

        private void CerrarTicket()
        {

            try
            {
                tmrTiempoAtencion.Stop();
                Tiempos cl_tiempos = new Tiempos();
                if (cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                                  (int)ESTADOS_TICKETS.CERRADO,
                                                  Pro_ID_AgenciaServicio,
                                                  Pro_ID_ClienteServicio,
                                                  Pro_Ticket_Servicio,
                                                  Pro_Usuario))
                {
                    ReinicioVariablesTiempo();
                }

                cl_tiempos = null;
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "CerrarTicket()");
                v_depurador = null;

            }     
        }

        public void MarcarClienteNoRespondioLlamado()
        {

            try
            {
                Tiempos cl_tiempos = new Tiempos();
                cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                                  (int)ESTADOS_TICKETS.NO_ATENDIO_LLAMADO,
                                                  Pro_ID_AgenciaServicio,
                                                  Pro_ID_ClienteServicio,
                                                  Pro_Ticket_Servicio,
                                                  Pro_Usuario);

                cl_tiempos = null;

            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "MarcarClienteNoRespondioLlamado()");
                v_depurador = null;
            }
        }


        private void LlamarSiguienteCliente(bool p_es_rellamada = false)
        {

            ValidarConexion();

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
                    if (Pro_Esta_En_ModoReducido)
                    {
                        ctlOperacionalReducido1.lblNumeroTicket.Text = pgDr.GetString(0);
                    }

                    Pro_Ticket_Servicio = pgDr.GetString(0);
                    lblNumeroTicket.Text = Pro_Ticket_Servicio;

                }

                if (! p_es_rellamada)
                {
                    Tiempos cl_tiempos = new Tiempos();
                    cl_tiempos.ActualizarEstadoTicket(Pro_Conexion,
                                                      (int)ESTADOS_TICKETS.LLAMADO,
                                                      Pro_ID_AgenciaServicio,
                                                      Pro_ID_ClienteServicio,
                                                      Pro_Ticket_Servicio,
                                                      Pro_Usuario
                                                      );
                    cl_tiempos = null;
                }
                               
                pgDr.Close();
                pgComando.Dispose();
                sentencia = null;
                pgDr = null;

            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "LlamarSiguienteCliente(bool p_es_rellamada = false)");
                v_depurador = null;
                MessageBox.Show(Exc.Message, "FLUCOL");
            }         
        }

        public void MarcarParoTiempo(MOTIVOS_PARO_TIEMPO pMotivo)
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_registra_paros_tiempo (
                                                                                              :p_codigoempleado,
                                                                                              :p_id_cliente_servicio,
                                                                                              :p_id_agencia_servicio,
                                                                                              :p_id_motivo,
                                                                                              :p_observaciones
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_codigoempleado", PgSqlType.VarChar).Value = Pro_CodigoEmpleado;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_motivo", PgSqlType.Int).Value = pMotivo;
            pgComando.Parameters.Add("p_observaciones", PgSqlType.VarChar).Value = DBNull.Value;

            try
            {
                pgComando.ExecuteNonQuery();
                pgComando.Dispose();
                sentencia = null;

                MessageBox.Show("EL PARO DE TIEMPO FUE REGISTRADO, YA PUEDE CERRAR SU SESIÓN. ", "FLUCOL");
                this.BringToFront();
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "MarcarParoTiempo(MOTIVOS_PARO_TIEMPO pMotivo)");
                v_depurador = null;
                MessageBox.Show("ALGO SALIÓ MAL EN EL MOMENTO DE MARCAR EL PARO DE TIEMPO. " + Exc.Message, "FLUCOL");
            }            
        }

        private int ObtenerEstadoTicket()
        {
            ValidarConexion();

            int v_estado_ticket = 0;
            string sentencia = @"SELECT * FROM area_servicio.ft_proc_devuelve_estado_ticket (
                                                                                        :p_id_ticket_servicio,
                                                                                        :p_id_cliente_servicio,
                                                                                        :p_id_agencia_servicio
                                                                                    )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_ticket_servicio",PgSqlType.VarChar).Value = Pro_Ticket_Servicio;
            pgComando.Parameters.Add("p_id_cliente_servicio",PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            
            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    v_estado_ticket = pgDr.GetInt32("estado");
                }

                pgDr.Close();
                sentencia = null;
                pgComando.Dispose();
                pgDr = null;

                return v_estado_ticket;
            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIÓ MAL EN EL MOMENTO DE OBTENER ESTADO DEL TICKET. " + Exc.Message);

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "ObtenerEstadoTicket()");
                v_depurador = null;

                return v_estado_ticket;
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
                catch (Exception Exc)
                {
                    DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                    v_depurador.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ValidarConexion()");
                    v_depurador = null;

                    PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
                    v_conexion.Password = Pro_Conexion.Password;
                    Pro_Conexion = v_conexion;
                    Pro_Conexion.Open();
                    v_conexion = null;
                }
            }
        }

        
        #endregion

        #region EVENTOS GLOBALES

        public void PresionaF1_IniciarTicket(object sender)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ReinicioImagenesIcono();
                cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicketVerde;
                IniciarTicket();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "PresionaF1_IniciarTicket(object sender)");
                v_depurador = null;

            }
        }

        public void PresionaF2_CerrarTicket(object sender)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ReinicioImagenesIcono();
                cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicketVerde;
                CerrarTicket();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "PresionaF2_CerrarTicket(object sender)");
                v_depurador = null;

            }
        }

        public void PresionaF5_LlamarCliente(object sender)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ReinicioImagenesIcono();
                cmdLlamarCliente.Image = Properties.Resources.IconLlamarSiguienteClienteVerde;
                LlamarSiguienteCliente();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "PresionaF5_LlamarCliente(object sender)");
                v_depurador = null;
            }  
        }

        public void PresionarF6_MarcarClienteNoRespondio(object sender)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ReinicioImagenesIcono();
                cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamadoVerde;
                MarcarClienteNoRespondioLlamado();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "PresionarF6_MarcarClienteNoRespondio(object sender)");
                v_depurador = null;
            }
    
        }

        #endregion

        #region EVENTOS CONTROLES

        private void cmdIniciarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblNumeroTicket.Text != "" && lblNumeroTicket.Text != "NO HAY TICKETS EN COLA")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    int v_estado_ticket;

                    ReinicioImagenesIcono();

                    cmdIniciarTicket.Image = Properties.Resources.iconIniciarTicketVerde;

                    v_estado_ticket = ObtenerEstadoTicket();

                    switch ((ESTADOS_TICKETS)v_estado_ticket)
                    {
                        case ESTADOS_TICKETS.EN_ESPERA:
                            MessageBox.Show("EL TICKET ESTA EN ESPERA.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.LLAMADO:
                            IniciarTicket();
                            Pro_Esta_En_Atencion = true;
                            break;
                        case ESTADOS_TICKETS.NO_ATENDIO_LLAMADO:
                            MessageBox.Show("EL TICKET FUE MARCADO COMO \"NO ATENDIO LLAMADO\".", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.EN_ATENCION:
                            MessageBox.Show("EL TICKET YA ESTA SIENDO ATENDIDO.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.CERRADO:
                            MessageBox.Show("EL TICKET YA FUE CERRADO.", "FLUCOL");
                            break;
                      
                    }

                    Cursor.Current = Cursors.Arrow;
                }
                else
                {
                    MessageBox.Show("NO SE HA LLAMADO NINGUN CLIENTE.", "FLUCOL");
                }
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdIniciarTicket_Click(object sender, EventArgs e)");
                v_depurador = null;
            }     
        }

        private void cmdCerrarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblNumeroTicket.Text != "")
                {
                    int v_estado_ticket;

                    Cursor.Current = Cursors.WaitCursor;
                    ReinicioImagenesIcono();

                    cmdCerrarTicket.Image = Properties.Resources.iconDetenerTicketVerde;

                    v_estado_ticket = ObtenerEstadoTicket();

                    if (ctlListaTicketsEspera1.Pro_ConteoTicketsEspera == 0 && (v_estado_ticket == (int)ESTADOS_TICKETS.CERRADO || v_estado_ticket == (int)ESTADOS_TICKETS.NO_ATENDIO_LLAMADO))
                    {
                        lblNumeroTicket.Text = "NO HAY TICKETS EN COLA";
                    }



                    if (v_estado_ticket == (int)ESTADOS_TICKETS.NO_HA_SIDO_LLAMADO)
                    {
                        MessageBox.Show("NO HA SIDO LLAMADO NINGUN TICKET O NO HAY TICKETS EN ESPERA.", "FLUCOL");
                    }

                    else if (v_estado_ticket != (int)ESTADOS_TICKETS.EN_ATENCION)
                    {
                        MessageBox.Show("NO PUEDE CERRARSE EL TICKET PORQUE AUN NO HA SIDO ATENDIDO.", "FLUCOL");
                    }
                    else
                    {
                        CerrarTicket();
                        Pro_Esta_En_Atencion = false;
                        lblNumeroTicket.Text = "";
                        ctlOperacionalReducido1.lblNumeroTicket.Text = "";
                    }

                    Cursor.Current = Cursors.Arrow;
                }
                else
                {
                    MessageBox.Show("NO SE HA INICIADO NINGUN TICKET.", "FLUCOL");
                }
            }
            catch (Exception Exc)
            {

                Cursor.Current = Cursors.Arrow;
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdCerrarTicket_Click(object sender, EventArgs e)");
                v_depurador = null;
            }
   
        }     

        private void cmdLlamarCliente_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (!Pro_Esta_En_Atencion)
                {

                    Cursor.Current = Cursors.WaitCursor;
                    int v_estado_ticket;

                    v_estado_ticket = ObtenerEstadoTicket();

                    if (v_estado_ticket != 0)
                    {

                        if (v_estado_ticket == (int)ESTADOS_TICKETS.CERRADO ||
                            v_estado_ticket == (int)ESTADOS_TICKETS.NO_ATENDIO_LLAMADO
                          )
                        {

                            ReinicioImagenesIcono();
                            cmdLlamarCliente.Image = Properties.Resources.IconLlamarSiguienteClienteVerde;

                            LlamarSiguienteCliente();

                        }
                        else
                        {
                            MessageBox.Show(@"NO SE PUEDE LLAMAR A SIGUIENTE TICKET MIENTRAS NO CIERRE O MARQUE COMO ATENDIDO EL ACTUAL TICKET.", "FLUCOL");
                        }
                    }
                    else
                    {
                        ReinicioImagenesIcono();
                        cmdLlamarCliente.Image = Properties.Resources.IconLlamarSiguienteClienteVerde;

                        LlamarSiguienteCliente();
                    }

                    v_temporal_ticket = lblNumeroTicket.Text;

                    
                    Cursor.Current = Cursors.Arrow;
                    
                }
                else
                {
                    MessageBox.Show("NO PUEDE LLAMAR A OTRO CLIENTE MIENTRAS NO CIERRE EL TICKET ACTUAL. ", "FLUCOL");
                }

              

            }
            catch (Exception Exc)
            {

                Cursor.Current = Cursors.Arrow;

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdLlamarCliente_Click(object sender, EventArgs e)");
                v_depurador = null;
            }           
        }

        private void cmdClienteNoAtendioLlamado_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Pro_Esta_En_Atencion)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    int v_estado_ticket;

                    ReinicioImagenesIcono();

                    cmdClienteNoAtendioLlamado.Image = Properties.Resources.iconNoRespondioLlamadoVerde;

                    v_estado_ticket = ObtenerEstadoTicket();

                    switch ((ESTADOS_TICKETS)v_estado_ticket)
                    {
                        case ESTADOS_TICKETS.EN_ESPERA:
                            MessageBox.Show("EL TICKET ESTA EN ESPERA.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.LLAMADO:
                            MarcarClienteNoRespondioLlamado();
                            Pro_Esta_En_Atencion = false;
                            lblNumeroTicket.Text = "";
                            ctlOperacionalReducido1.lblNumeroTicket.Text = "";
                            break;
                        case ESTADOS_TICKETS.NO_ATENDIO_LLAMADO:
                            MessageBox.Show("EL TICKET FUE MARCADO COMO \"NO ATENDIO LLAMADO\".", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.EN_ATENCION:
                            MessageBox.Show("EL TICKET YA ESTA SIENDO ATENDIDO.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.CERRADO:
                            MessageBox.Show("EL TICKET YA FUE CERRADO.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.NO_HA_SIDO_LLAMADO:
                            MessageBox.Show("NO SE HA LLAMADO NINGUN CLIENTE.", "FLUCOL");
                            break;
                        
                    }

                    Cursor.Current = Cursors.Arrow;

                }
                else
                {
                    MessageBox.Show("AUN NO HA FINALIZADO EL TICKET. ", "FLUCOL");
                }
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdClienteNoAtendioLlamado_Click(object sender, EventArgs e)");
                v_depurador = null;

            }         
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
            ctlOperacionalReducido1.lblTiempoAtencion.Text = v_tiempo;

        }
  
        private void cmdPersonalTiempo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Pro_Esta_En_Atencion)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    MarcarParoTiempo(MOTIVOS_PARO_TIEMPO.SALIDA_SANITARIO);
                    Pro_Esta_En_Atencion = false;

                    Cursor.Current = Cursors.WaitCursor;
                }
                else
                {
                    MessageBox.Show("EL TICKET AUN NO HA SIDO CERRADO.", "FLUCOL");
                }
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdPersonalTiempo_Click(object sender, EventArgs e)");
                v_depurador = null;

            }
        }

        private void cmdSalidaAlmuerzo_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Pro_Esta_En_Atencion)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    MarcarParoTiempo(MOTIVOS_PARO_TIEMPO.ALMUERZO);
                    Pro_Esta_En_Atencion = false;

                    Cursor.Current = Cursors.Arrow;
                }
                else
                {
                    MessageBox.Show("NO PUEDE SALIR A SU ALMUERZO PORQUE EL TICKET NO HA SIDO CERRADO. ", "FLUCOL");
                }
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdSalidaAlmuerzo_Click(object sender, EventArgs e)");
                v_depurador = null;

            }    
        }

        public void cmdCerrarSesion_Click(object sender, EventArgs e)
        {

            if (Pro_Esta_En_Atencion)
            {
                MessageBox.Show("DEBE CERRAR EL TICKET PARA PODER CERRAR LA SESION.");
            }
            else
            {
                ctlListaTicketsEspera1.Pro_CargarLista = false;
                OnCerrarSesion?.Invoke(sender, e);
            }
        }

      
        private void cmdRellamar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblNumeroTicket.Text != "" && lblNumeroTicket.Text != "NO HAY TICKETS EN COLA")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    int v_estado_ticket;

                    ReinicioImagenesIcono();
                    cmdRellamar.Image = Properties.Resources.icon_rellamar_verde_64;

                    v_estado_ticket = ObtenerEstadoTicket();

                    switch ((ESTADOS_TICKETS)v_estado_ticket)
                    {
                        case ESTADOS_TICKETS.EN_ESPERA:
                            MessageBox.Show("EL TICKET ESTA EN ESPERA.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.LLAMADO:
                            LlamarSiguienteCliente(true);
                            break;
                        case ESTADOS_TICKETS.NO_ATENDIO_LLAMADO:
                            MessageBox.Show("EL TICKET FUE MARCADO COMO \"NO ATENDIO LLAMADO\".", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.EN_ATENCION:
                            MessageBox.Show("EL TICKET YA ESTA SIENDO ATENDIDO.", "FLUCOL");
                            break;
                        case ESTADOS_TICKETS.CERRADO:
                            MessageBox.Show("EL TICKET YA FUE CERRADO.", "FLUCOL");
                            break;
                       
                    }

                    Cursor.Current = Cursors.Arrow;

                }
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "cmdRellamar_Click(object sender, EventArgs e)");
                v_depurador = null;
            }
        }

        private void picUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                popupResumen.ShowPopup();
                CargarDatosTicketPosicion();
                lblNombreUsuario.Text = Pro_NombreEmpleado;

                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception Exc)
            {
                Cursor.Current = Cursors.Arrow;

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "picUsuario_Click(object sender, EventArgs e)");
                v_depurador = null;
            }     
        }

        private void ctlOperacionalReducido1_ClienteNoAtendioLlamado(object sender, EventArgs e)
        {
            cmdClienteNoAtendioLlamado_Click(sender, e);
        }

        private void ctlOperacionalReducido1_RellamarTicket(object sender, EventArgs e)
        {
            cmdRellamar_Click(sender, e);
        }

        private void ctlOperacionalReducido1_LlamarCliente(object sender, EventArgs e)
        {
            cmdLlamarCliente_Click(sender, e);
        }

        private void ctlOperacionalReducido1_IniciarTicket(object sender, EventArgs e)
        {
            cmdIniciarTicket_Click(sender, e);
        }

        private void ctlOperacionalReducido1_CerrarTicket(object sender, EventArgs e)
        {
            cmdCerrarTicket_Click(sender, e);
        }

        #endregion

    }
}
