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

        #region ENUMERACIONES

        public enum OPCIONES_MENU
        {
            NINGUNO = 0,
            DASHBOARDS = 1,
            MANTENIMIENTO_TASA_CAMBIO = 2,
            ASIGNACION_POSICIONES = 3,
            MANTENIMIENTO_EMPLEADOS = 4,
            CONFIGURACION = 5
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public string Pro_Usuario { get; set; }
        public OPCIONES_MENU Pro_OpcionSeleccionada { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_ClienteServicio, 
                                     string pUsuario,
                                     string pNombreEmpleado)
        {
            picLogoInstitucion.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            lblNombreUsuario.Text = pNombreEmpleado;

            
        }

        #endregion

        #region EVENTOS CONTROLES
  
        private void ctlAgenciasDisponiblesParaDashboards1_OnSeleccionaAgencia(int pID_Agencia, string pNombreSucursal)
        {

            switch (Pro_OpcionSeleccionada)
            {
                case OPCIONES_MENU.DASHBOARDS:
                    NavigationPrincipal.SelectedPage = PageDashboardPrincipal;
                    ctlContenedorDashboards1.ConstruirControl(Pro_Conexion,
                                                              Pro_ID_ClienteServicio,
                                                              pID_Agencia,
                                                              pNombreSucursal
                                                             );
                    break;
                case OPCIONES_MENU.ASIGNACION_POSICIONES:
                    NavigationPrincipal.SelectedPage = PageAsignacionPosiciones;
                    ctlAsignacionPosiciones1.ConstruirControl(Pro_Conexion,
                                                              pID_Agencia,
                                                              Pro_ID_ClienteServicio,
                                                              Pro_Usuario,
                                                              pNombreSucursal);
                    break;
                case OPCIONES_MENU.MANTENIMIENTO_EMPLEADOS:
                    NavigationPrincipal.SelectedPage = PageMantenimientoEmpleados;
                    ctlMantenimientoUsuarios1.ConstruirControl(Pro_Conexion,
                                                               pID_Agencia,
                                                               Pro_ID_ClienteServicio,
                                                               Pro_Usuario,
                                                               pNombreSucursal);
                    break;
                
            }

            
        }

        private void CmdDashboards_Click(object sender, EventArgs e)
        {
            Pro_OpcionSeleccionada = OPCIONES_MENU.DASHBOARDS;
            ctlAgenciasDisponiblesParaDashboards1.ConstruirControl(Pro_Conexion,
                                                                   Pro_ID_ClienteServicio,
                                                                   Pro_OpcionSeleccionada);
            NavigationPrincipal.SelectedPage = PageAgenciasDisponibles;
        }

        private void ctlContenedorDashboards1_OnIrAtras(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageAgenciasDisponibles;
        }

        private void PicTasasCambio_Click(object sender, EventArgs e)
        {
            Pro_OpcionSeleccionada = OPCIONES_MENU.MANTENIMIENTO_TASA_CAMBIO;
            NavigationPrincipal.SelectedPage = PageTasaCambio;
            ctlMantenimientoTasaCambio1.ConstruirControl(Pro_Conexion,Pro_Usuario);
        }

        private void PicAsignarPosiciones_Click(object sender, EventArgs e)
        {
            Pro_OpcionSeleccionada = OPCIONES_MENU.ASIGNACION_POSICIONES;
            ctlAgenciasDisponiblesParaDashboards1.ConstruirControl(Pro_Conexion,
                                                                   Pro_ID_ClienteServicio,
                                                                   Pro_OpcionSeleccionada);
            NavigationPrincipal.SelectedPage = PageAgenciasDisponibles;           
        }

        private void PicMantenimiento_Click(object sender, EventArgs e)
        {
            Pro_OpcionSeleccionada = OPCIONES_MENU.MANTENIMIENTO_EMPLEADOS;
            ctlAgenciasDisponiblesParaDashboards1.ConstruirControl(Pro_Conexion,
                                                                    Pro_ID_ClienteServicio,
                                                                    Pro_OpcionSeleccionada);
            NavigationPrincipal.SelectedPage = PageAgenciasDisponibles;
            
        }

        #endregion

    }
}
    