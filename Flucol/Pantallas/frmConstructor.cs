using System;
using System.Windows.Forms;
using Recepcion.Pantallas;
using Publicidad.Pantallas;
using Operaciones.Pantallas;
using Devart.Data.PostgreSql;
using Flucol.Controles;
using Core.Clases;
using System.Drawing;
using Administracion.Pantallas;

namespace Flucol.Pantallas
{
    public partial class frmConstructor : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR
  
        public frmConstructor()
        {
            InitializeComponent();

            ctlBienvenida = new CtlBienvenida();
            Pro_AnchoDefecto = this.Width;
              
        }

        #endregion

        #region PROPIEDADES

        public int Pro_Modulo { get; set; }
        public string Pro_IP_Host { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_NombreAgenciaServicio { get; set; }
        public MODULOS Pro_ModuloActivo { get; set; }
        public int Pro_AnchoDefecto { get; set; }
        public int Pro_AltoDefecto { get; set; }

        #endregion

        #region ENUMERACIONES

        public enum MODULOS
        {
            RECEPCION = 1,
            PUBLICIDAD = 2,
            OPERACIONES = 3,
            ADMINISTRACION = 4,
            OPERACIONES_SUPERVISOR = 5
        }

        public enum NIVELES_ACCESO
        {
            ADMINISTRACION = 1,
            OPERACIONAL = 2,
            SUPERVISOR = 3,
            INVITADO = 4
        }

        #endregion

        #region FUNCIONES

        private void ReestablecerFormConstructor()
        {
            try
            {       
                this.Hide();
                ctlBienvenida.Dispose();
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;             
                this.Show();
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "ReestablecerFormConstructor()");
                v_depurador = null;
                MessageBox.Show("ALGO SALIO MAL EN EL MOMENTO DE REESTABLECER FORMULARIO CONSTRUCTOR: ", "FLUCOL");
            }
        }

        private void Construir_Control_SeleccionTransaccion() {

            try
            {
                f_Recepcion = new frmRecepcion();
                f_Recepcion.MdiParent = this;
                f_Recepcion.StartPosition = FormStartPosition.CenterScreen;
                f_Recepcion.ConstruirFormulario(Pro_Conexion, 
                                                Pro_ID_AgenciaServicio, 
                                                Pro_ID_ClienteServicio, 
                                                Pro_NombreAgenciaServicio,
                                                Pro_IP_Host);
                f_Recepcion.Show();
                Pro_ModuloActivo = MODULOS.RECEPCION;
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "Construir_Control_SeleccionTransaccion()");
                v_depurador = null;
                MessageBox.Show("ALGO SALIO MIENTRAS SE CARGABA PANTALLA DE RECEPCION. POR FAVOR INTENTE NUEVAMENTE. ","FLUCOL");
            }

            ReestablecerFormConstructor();
        }
     
        private void Construir_Control_Publicidad()
        {
            try
            {
                f_Visualizador = new frmVisualizadorTickets();
                f_Visualizador.MdiParent = this;
                f_Visualizador.StartPosition = FormStartPosition.CenterScreen;
                f_Visualizador.ConstruirFormulario(Pro_Conexion, 
                                                   Pro_ID_AgenciaServicio, 
                                                   Pro_ID_ClienteServicio,
                                                   Pro_NombreAgenciaServicio);
                f_Visualizador.Show();
                Pro_ModuloActivo = MODULOS.PUBLICIDAD;
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "Construir_Control_Publicidad()");
                v_depurador = null;
                MessageBox.Show("ALGO SALIO MAL MIENTRAS SE CARGABA PANTALLA DE PUBLICIDAD. POR FAVOR INTENTE NUEVAMENTE.", "FLUCOL");
            }

            ReestablecerFormConstructor();
            
        }


        private void Construir_Acceso_Para_Operaciones()
        {

            try
            {
                f_LoginOperaciones = new frmLogin(Pro_Conexion,
                                                           Pro_ID_AgenciaServicio,
                                                           Pro_ID_ClienteServicio);
                f_LoginOperaciones.OnUsuarioLogueadoCorrectamente += f_LoginOperaciones_UsuarioLogueado;
                ReestablecerFormConstructor();
                f_LoginOperaciones.MdiParent = this;
                f_LoginOperaciones.StartPosition = FormStartPosition.CenterScreen;
                f_LoginOperaciones.Show();
               

            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  " Construir_Acceso_Para_Operaciones()");
                v_depurador = null;
                MessageBox.Show("ALGO SALIO MAL MIENTRAS SE CARGABA PANTALLA DE AUTENTICACION. POR FAVOR INTENTE NUEVAMENTE. ", "FLUCOL");
            }   
        }

 
        

        private void ObtenerNombreSucursal()
        {
            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
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
                                                      "ObtenerNombreSucursal()");
                    v_depurador = null;
    
                }
            }

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_view_nombre_agencia_servicio (
                                                                                                    :p_id_agencia_servicio,
                                                                                                    :p_id_cliente_servicio
                                                                                                 );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    Pro_NombreAgenciaServicio = pgDr.GetString("nombre_agencia");
                }

                pgDr.Close();
                pgComando.Dispose();
                sentencia = null;
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "ObtenerNombreSucursal()");
                v_depurador = null;
            }
        }

        private void LimpiarTickets()
        {
            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    Pro_Conexion.Open();
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message, "FLUCOL");
                    return;
                }
            }

            string sentencia = @"SELECT * FROM configuracion.ft_proc_limpiar_tickets_temporal(:p_id_cliente_servicio,
                                                                                              :p_id_agencia_servicio
                                                                                              );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;

            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "LimpiarTickets()");
                v_depurador = null;

            }

        }

        private void RedireccionSegunNivelAcceso(Usuario pUsuario)
        {

            if (f_LoginOperaciones != null)
            {
                f_LoginOperaciones.Dispose();
                f_LoginOperaciones = null;
            }
         
            try
            {
                switch ((NIVELES_ACCESO)pUsuario.Pro_ID_NivelAcceso)
                {
                    case NIVELES_ACCESO.ADMINISTRACION:

                        frmAdministracion = new frmAdministracion();
                        frmAdministracion.ConstruirAdministracion(Pro_Conexion,
                                                                   Pro_ID_ClienteServicio,                                                              
                                                                   pUsuario.Pro_Usuario,
                                                                   pUsuario.Pro_NombreEmpleado);
                        frmAdministracion.OnCerrarSesion += frmAdministracion_OnCerrarSesion;
                        frmAdministracion.MdiParent = this;
                        frmAdministracion.StartPosition = FormStartPosition.CenterScreen;                    
                        frmAdministracion.Show();
                      
                        Pro_ModuloActivo = MODULOS.ADMINISTRACION;

                        break;
                    case NIVELES_ACCESO.OPERACIONAL:

                        frmOperacional = new frmOperaciones(Pro_Conexion,
                                                            Pro_ID_AgenciaServicio,
                                                            Pro_ID_ClienteServicio,
                                                            pUsuario.Pro_ID_NivelAcceso,
                                                            pUsuario.Pro_NombreEmpleado,
                                                            pUsuario.Pro_Usuario,
                                                            pUsuario.Pro_Descripcion_NivelAcceso,
                                                            pUsuario.Pro_CargoEmpleado,
                                                            pUsuario.Pro_CodigoEmpleado,
                                                            Pro_NombreAgenciaServicio);
                        frmOperacional.OnCerrarSesion += frmOperacional_OnCerrarSesion;
                        frmOperacional.MdiParent = this;
                        frmOperacional.StartPosition = FormStartPosition.CenterScreen;
                        frmOperacional.Show();

                        
                        Pro_ModuloActivo = MODULOS.OPERACIONES;

                        break;
                    case NIVELES_ACCESO.SUPERVISOR:
                        frmSupervisor = new frmSupervisor(Pro_Conexion,
                                                          Pro_ID_AgenciaServicio,
                                                          Pro_ID_ClienteServicio,
                                                          pUsuario.Pro_Usuario,
                                                          Pro_NombreAgenciaServicio,
                                                          pUsuario.Pro_NombreEmpleado);
                        frmSupervisor.OnCierraSesionSupervisor += frmSupervisor_OnCerrarSesion;
                        frmSupervisor.MdiParent = this;
                        frmSupervisor.StartPosition = FormStartPosition.CenterScreen;                      
                        frmSupervisor.Show();
                        Pro_ModuloActivo = MODULOS.OPERACIONES_SUPERVISOR;
                        break;

                    case NIVELES_ACCESO.INVITADO:
                        break;
                }
            }

            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "RedireccionSegunNivelAcceso(Usuario pUsuario)");
                v_depurador = null;

                MessageBox.Show("ALGO SALIO MAL MIENTRAS SE VALIDABA EL NIVEL DE ACCESO. " ,"FLUCOL");
            }
        }

        private void frmAdministracion_OnCerrarSesion(object sender, EventArgs e)
        {
            frmAdministracion.Dispose();
            Construir_Acceso_Para_Operaciones();
        }



        #endregion

        #region VARIABLES GLOBALES

        CtlBienvenida ctlBienvenida;
        frmOperaciones frmOperacional;
        frmSupervisor frmSupervisor;
        frmLogin f_LoginOperaciones;
        frmAdministracion frmAdministracion;
        frmVisualizadorTickets f_Visualizador;
        frmRecepcion f_Recepcion;

        #endregion

        #region EVENTOS CONTROLES

        private void ctlBienvenida_OnTerminaTiempoBienvenida(object sender, EventArgs e)
        {

            Pro_Modulo = ctlBienvenida.Pro_Modulo;
            Pro_ID_AgenciaServicio = ctlBienvenida.Pro_ID_AgenciaServicio;
            Pro_ID_ClienteServicio = ctlBienvenida.Pro_ID_ClienteServicio;
            Pro_Conexion = ctlBienvenida.pgConexion;
            Pro_IP_Host = new Utilidades().ObtenerIP_Host();

            ObtenerNombreSucursal();
            LimpiarTickets();

            switch (Pro_Modulo)
            {
                case 1:                   
                    Construir_Control_SeleccionTransaccion();
                    break;
                case 2:                   
                    Construir_Control_Publicidad();
                    break;
                case 3:
                    Construir_Acceso_Para_Operaciones();
                    break;
                case 4:
                    Construir_Acceso_Para_Operaciones();
                    break;
            }
      
        }

        private void f_Recepcion_OnCerrarFormulario(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f_LoginOperaciones_UsuarioLogueado(object sender, EventArgs e)
        {
            Usuario c_usuario = new Usuario();
            c_usuario = (Usuario)sender;

            RedireccionSegunNivelAcceso(c_usuario);
            c_usuario = null;       
        }

        private void frmConstructor_Load(object sender, EventArgs e)
        {

            if (ctlBienvenida != null)
            {
                ctlBienvenida.OnTerminaTiempoBienvenida += new EventHandler(ctlBienvenida_OnTerminaTiempoBienvenida);
                this.Controls.Add(ctlBienvenida);
                ctlBienvenida.Dock = DockStyle.Fill;
                ctlBienvenida.ConstruirControl();
            }         
        }


        private void frmConstructor_ClientSizeChanged(object sender, EventArgs e)
        {

            try
            {
                if (Pro_ModuloActivo == MODULOS.OPERACIONES)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {

                        if (frmOperacional != null)
                        {
                            frmOperacional.ctlOperacional1.Navigation.SelectedPage = frmOperacional.ctlOperacional1.pagePrincipal;

                        }
                        this.Size = new Size(this.MinimumSize.Width, this.MinimumSize.Height);


                    }
                    else if (this.WindowState == FormWindowState.Normal)
                    {
                        if (frmOperacional != null)
                        {
                            frmOperacional.ctlOperacional1.Navigation.SelectedPage = frmOperacional.ctlOperacional1.PageOperacionalReducido;
                            frmOperacional.ctlOperacional1.ctlOperacionalReducido1.lblNumeroTicket.Text = frmOperacional.ctlOperacional1.lblNumeroTicket.Text;
                            frmOperacional.ctlOperacional1.ctlOperacionalReducido1.lblTiempoAtencion.Text = frmOperacional.ctlOperacional1.lblTiempoAtencion.Text;
                            frmOperacional.ctlOperacional1.Pro_Esta_En_ModoReducido = true;
                        }
                        this.Size = new Size(this.MinimumSize.Width, this.MinimumSize.Height);
                    }
                    else
                    {
                        frmOperacional.ctlOperacional1.Navigation.SelectedPage = frmOperacional.ctlOperacional1.pagePrincipal;
                        frmOperacional.ctlOperacional1.Pro_Esta_En_ModoReducido = false;
                    }
                }
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "frmConstructor_ClientSizeChanged(object sender, EventArgs e)");
                v_depurador = null;
            }        
        }

        private void frmConstructor_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (Pro_ModuloActivo == MODULOS.OPERACIONES)
                {
                    if (frmOperacional.ctlOperacional1.Pro_Esta_En_Atencion)
                    {
                        e.Cancel = true;
                        MessageBox.Show("DEBE CERRAR EL TICKET PARA PODER CERRAR LA SESION.", "FLUCOL");
                    }
                }
            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "frmConstructor_FormClosing(object sender, FormClosingEventArgs e)");
                v_depurador = null;
            }      
        }

        private void frmOperacional_OnCerrarSesion(object sender, EventArgs e)
        {
            frmOperacional.Dispose();
            Construir_Acceso_Para_Operaciones();
        }

        private void frmSupervisor_OnCerrarSesion(object sender, EventArgs e)
        {
            frmSupervisor.Dispose();
            Construir_Acceso_Para_Operaciones();
        }

        #endregion
    }
}