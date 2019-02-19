using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Recepcion.Pantallas;
using Publicidad.Pantallas;
using Operaciones.Pantallas;
using Devart.Data.PostgreSql;
using Flucol.Controles;

namespace Flucol.Pantallas
{
    public partial class frmConstructor : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR
  
        public frmConstructor()
        {
            InitializeComponent();
            
            
               ctlBienvenida = new CtlBienvenida();
                CrearConexion();
                ObtenerNombreSucursal();
            
        
            
        }

        #endregion

        #region PROPIEDADES

        private int Pro_Modulo {
            get
            {
                return Convert.ToInt32 (ConfigurationSettings.AppSettings["MODULO"]);
            }
        }

        private int Pro_ID_AgenciaServicio {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["AGENCIA"]);
            }
        }

        private int Pro_ID_ClienteServicio {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["CLIENTE"]);
            }

        }

        private string Pro_BaseDatos
        {
            get
            {
                return ConfigurationSettings.AppSettings["DATABASE"];
            }
        }

        private string Pro_Hostname
        {
            get
            {
                return ConfigurationSettings.AppSettings["HOSTNAME"];
            }
        }

        private string Pro_Usuario
        {
            get
            {
                return ConfigurationSettings.AppSettings["USUARIO"];
            }
        }

        private string Pro_Password
        {
            get
            {
                return ConfigurationSettings.AppSettings["CONFIGURACION"];
            }
        }

        private string Pro_Puerto
        {
            get
            {
                return ConfigurationSettings.AppSettings["PUERTO"];
            }
        }

        public string Pro_NombreAgenciaServicio { get; set; }

        #endregion

        #region ENUMERACIONES

        public enum PERFILES
        {
            RECEPCION = 1,
            VISUALIZADOR = 2,
            OPERACIONES = 3,
            SUPERVISOR = 4
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
                MessageBox.Show("ALGO SALIÓ MAL EN EL MOMENTO DE REESTABLECER FORMULARIO CONSTRUCTOR: " + Exc.Message, "FLUCOL");
            }
        }

        private void Construir_Control_SeleccionTransaccion() {

            try
            {
                frmRecepcion f_Recepcion = new frmRecepcion();
                f_Recepcion.MdiParent = this;
                f_Recepcion.StartPosition = FormStartPosition.CenterScreen;
                f_Recepcion.ConstruirFormulario(pgConexion, Pro_ID_AgenciaServicio, Pro_ID_ClienteServicio, Pro_NombreAgenciaServicio);
                f_Recepcion.Show();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIÓ MAL. " + Exc.Message,"FLUCOL");
            }

            ReestablecerFormConstructor();
        }
     
        private void Construir_Control_Publicidad()
        {
            try
            {
                frmVisualizadorTickets f_Visualizador = new frmVisualizadorTickets();
                f_Visualizador.MdiParent = this;
                f_Visualizador.StartPosition = FormStartPosition.CenterScreen;
                f_Visualizador.ConstruirFormulario(pgConexion, Pro_ID_AgenciaServicio, Pro_ID_ClienteServicio);
                f_Visualizador.Show();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIÓ MAL. " + Exc.Message, "FLUCOL");
            }

            ReestablecerFormConstructor();
            
        }

        private void Construir_Acceso_Para_Operaciones()
        {

            try
            {
                frmLogin f_LoginOperaciones = new frmLogin(pgConexion,Pro_ID_AgenciaServicio,Pro_ID_ClienteServicio);
                ReestablecerFormConstructor();
                f_LoginOperaciones.MdiParent = this;
                f_LoginOperaciones.StartPosition = FormStartPosition.CenterScreen;
                f_LoginOperaciones.Show();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIÓ MAL. " + Exc.Message, "FLUCOL");
            }   
        }

        private void CrearConexion()
        {
            StringBuilder v_cadena_conexion = new StringBuilder();
            v_cadena_conexion.Append("User Id=");
            v_cadena_conexion.Append(Pro_Usuario);
            v_cadena_conexion.Append(";Password=");
            v_cadena_conexion.Append(Pro_Password);
            v_cadena_conexion.Append(";Host=");
            v_cadena_conexion.Append(Pro_Hostname);
            v_cadena_conexion.Append(";Database=");
            v_cadena_conexion.Append(Pro_BaseDatos);
            v_cadena_conexion.Append(";Port=");
            v_cadena_conexion.Append(Pro_Puerto);

            string v_cadena = v_cadena_conexion.ToString();

            pgConexion = new PgSqlConnection(v_cadena);

            try
            {
                pgConexion.Open();
                if (pgConexion.State != ConnectionState.Open)
                {
                    pgConexion.Open();
                }
            }
            catch (Exception Exc)
            {
               
               
            }
           
        }

        private void ObtenerNombreSucursal()
        {
            if (pgConexion.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    pgConexion.Open();
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message, "FLUCOL");
                    return;
                }
            }

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_proc_obtiene_nombre_agencia_servicio (
                                                                                                          :p_id_agencia_servicio,
                                                                                                          :p_id_cliente_servicio
                                                                                                        ) ;";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, pgConexion);
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    Pro_NombreAgenciaServicio = pgDr.GetString("nombre_agencia");
                }

                pgDr.Close();
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
        }

        #endregion

        #region VARIABLES GLOBALES

        PgSqlConnection pgConexion;
        CtlBienvenida ctlBienvenida;

        #endregion

        #region EVENTOS CONTROLES

        private void ctlBienvenida_OnTerminaTiempoBienvenida(object sender, EventArgs e)
        {

          
            
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
            }

           
        }

        private void f_Recepcion_OnCerrarFormulario(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void frmConstructor_Load(object sender, EventArgs e)
        {
           
           
            ctlBienvenida.OnTerminaTiempoBienvenida += new EventHandler(ctlBienvenida_OnTerminaTiempoBienvenida);
            this.Controls.Add(ctlBienvenida);
            ctlBienvenida.Dock = DockStyle.Fill;
            ctlBienvenida.ConstruirControl(Pro_Modulo);
            
        }

        #endregion

    }
}