using System;
using Devart.Data.PostgreSql;
using System.Configuration;


namespace Operaciones.Pantallas
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR

        public frmLogin(PgSqlConnection pConexion,  int pSucursal, int pCliente)
        {
            InitializeComponent();
            ctlLoginOperacional1.ConstruirControl(pConexion, pSucursal, pCliente);
            this.Hide();
        }


        #endregion

        #region VARIABLES GLOBALES

        #endregion

        #region PROPIEDADES

        private int Pro_Modulo
        {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["MODULO"]);
            }
        }

        private int Pro_Sucursal
        {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["AGENCIA"]);
            }
        }

        private int Pro_ID_ClienteServicio
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

        #region FUNCIONES

        #endregion

        #region EVENTOS CONTROLES

        private void ctlLoginOperacional1_OnUsuarioLogueado(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}