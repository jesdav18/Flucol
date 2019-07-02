using System;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Configuration;

namespace Administracion.Controles
{
    public partial class ctlAdministracionPrincipal : UserControl
    {

        #region INICIALIZADOR

        public ctlAdministracionPrincipal()
        {
            InitializeComponent();
            ctlAgenciasDisponiblesParaDashboards1.OnSeleccionaAgencia += ctlAgenciasDisponiblesParaDashboards1_OnSeleccionaAgencia;
            ctlContenedorDashboards1.OnIrAtras += ctlContenedorDashboards1_OnIrAtras;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,int pID_ClienteServicio)
        {
            picLogoInstitucion.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Conexion = pConexion;

            ctlAgenciasDisponiblesParaDashboards1.ConstruirControl(Pro_Conexion,
                                                                   Pro_ID_ClienteServicio);
        }

        #endregion

        #region EVENTOS CONTROLES

        
        private void ctlAgenciasDisponiblesParaDashboards1_OnSeleccionaAgencia(int pID_Agencia, string pNombreSucursal)
        {
            NavigationPrincipal.SelectedPage = PageDashboardPrincipal;
            ctlContenedorDashboards1.ConstruirControl(Pro_Conexion,
                                                      Pro_ID_ClienteServicio,
                                                      pID_Agencia,
                                                      pNombreSucursal
                                                     );
        }

        private void CmdDashboards_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageAgenciasDisponibles;
        }

        private void ctlContenedorDashboards1_OnIrAtras(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageAgenciasDisponibles;
        }


        #endregion

    }
}
    