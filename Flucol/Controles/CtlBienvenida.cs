using Core.Clases;
using Devart.Data.PostgreSql;
using System;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace Flucol.Controles
{
    public partial class CtlBienvenida : UserControl
    {

        #region INICIALIZADOR
        public CtlBienvenida()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnTerminaTiempoBienvenida;

        #endregion

        #region PROPIEDADES

       
        public int Pro_Modulo
        {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["MODULO"]);
            }
        }

        public int Pro_ID_AgenciaServicio
        {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["AGENCIA"]);
            }
        }

        public int Pro_ID_ClienteServicio
        {
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


        #endregion

        #region VARIABLES GLOBALES

        public PgSqlConnection pgConexion;

        #endregion

        #region FUNCIONES

        public void ConstruirControl()
        {
            
            //tmrBienvenida.Start();
            System.Reflection.Assembly v_ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo obj_archivo_informacion = new System.IO.FileInfo(v_ensamblado.Location);
            DateTime v_ultima_actualizacion = obj_archivo_informacion.LastWriteTime;
            lblUltimaActualizacion.Text = "" + v_ultima_actualizacion.ToShortDateString() + ", " + v_ultima_actualizacion.ToShortTimeString();
            lblVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString() ;

            switch (Pro_Modulo)
            {
                case 1:
                    lblModulo.Text = "RECEPCIÓN";
                    break;
                case 2:
                    lblModulo.Text = "PUBLICIDAD";
                    break;
                case 3:
                    lblModulo.Text = "OPERACIONES";
                    break;
                case 4:
                    lblModulo.Text = "ADMINISTRACIÓN";
                    break;
            }


            obj_archivo_informacion = null;
            v_ensamblado = null;

            tmrCrearConexion.Start();
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
                tmrCrearConexion.Stop();
                //tmrBienvenida.Stop();
                //splashScreenManager1.ShowWaitForm();
                if (pgConexion.State != ConnectionState.Open)
                {                   
                    pgConexion.Open();                    
                }

                
                //splashScreenManager1.CloseWaitForm();

            }
            catch (Exception Exc)
            {

                if (Exc.Message == "Timeout expired.")
                {
                    progressPanel1.Visible = false;
                   // tmrBienvenida.Stop();
                    if (MessageBox.Show("NO PUDO ESTABLECERSE LA CONEXION." + Environment.NewLine +
                                        "PRESIONE SI PARA REINTENTARLO, O PRESIONE NO PARA CANCELAR EL INICIO DE FLUCOL. ", "FLUCOL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        progressPanel1.Visible = true;
                       // tmrBienvenida.Start();
                        CrearConexion();
                    }
                    else
                    {

                        Application.Exit();
                    }

                }
                else
                {
                    DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                    v_depurador.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "CrearConexion()");

                    v_depurador = null;
                }

            }

        }

        #endregion

        #region EVENTOS CONTROLES

        private void tmrBienvenida_Tick(object sender, EventArgs e)
        {
            tmrBienvenida.Stop();
            OnTerminaTiempoBienvenida?.Invoke(sender, e);   
        }

        #endregion

        private void tmrCrearConexion_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CrearConexion();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            OnTerminaTiempoBienvenida?.Invoke(new object(), new EventArgs());
        }
    }
}
