using System;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Configuration;

namespace Operaciones.Controles
{
    public partial class ctlOperacionesSupervisor : UserControl
    {

        #region INICIALIZADOR

        public ctlOperacionesSupervisor()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public int Pro_ID_AgenciaServicio { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio,
                                     string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;

            picLogoCliente.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

        }

        #endregion

        #region EVENTOS CONTROLES
    
        private void cmdAsignaciones_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavigationAsignacionesTraslados.SelectedPage = pageAsignaciones;
            ctlAsignacionPosiciones1.ConstruirControl(Pro_Conexion,
                                                      Pro_ID_AgenciaServicio,
                                                      Pro_ID_ClienteServicio,
                                                      Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void cmdTraslados_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavigationAsignacionesTraslados.SelectedPage = pageTraslados;
            ctlTrasladosEmpleadosServicio1.ConstruirControl(Pro_Conexion,
                                                            Pro_ID_AgenciaServicio,
                                                            Pro_ID_ClienteServicio,
                                                            Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void cmdAsignarPosiciones_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageAsignacionesTraslados;
        }

        #endregion

    }
}
