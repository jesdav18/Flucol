using System;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Configuration;

namespace Core.Controles.Configuraciones
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

        #region EVENTOS

        public event EventHandler OnCerrarSesionSupervisor;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio,
                                     string pUsuario,
                                     string pNombreAgencia,
                                     string pNombreEmpleado)
        {

            splashScreenManager1.ShowWaitForm();

            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;

            lblNombreEmpleado.Text = pNombreEmpleado;
            lblAgencia.Text = pNombreAgencia;

            picLogoCliente.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

            splashScreenManager1.CloseWaitForm();
        }

        private void ReinicioImagenes()
        {
            cmdTrasladarEmpleados.Image = Properties.Resources.icon_traslados_64;
            cmdAsignarPosicionesEmpleados.Image = Properties.Resources.icon_asignar_posiciones_64;
            cmdCerrarSesion.Image = Properties.Resources.icon_cerrar_sesion_64;
            cmdMantenimientoEmpleados.Image = Properties.Resources.iconUsuario;
            cmdAsignarPosiciones.Image = Properties.Resources.icon_posiciones64;
        }

        #endregion

        #region EVENTOS CONTROLES


        private void cmdMantenimientoEmpleados_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ReinicioImagenes();
            cmdMantenimientoEmpleados.Image = Properties.Resources.icon_usuario_verde_64;
            ctlMantenimientoUsuarios1.ConstruirControl(Pro_Conexion,
                                                       Pro_ID_AgenciaServicio,
                                                       Pro_ID_ClienteServicio,
                                                       Pro_Usuario);
            NavigationPrincipal.SelectedPage = PageMantenimientoEmpleados;
            splashScreenManager1.CloseWaitForm();
        }

        private void cmdTrasladarEmpleados_Click(object sender, EventArgs e)
        {

            if ( ! ctlAsignacionPosiciones1.ValidarSiHayCambiosSinGuardar())
            {
                splashScreenManager1.ShowWaitForm();
                ReinicioImagenes();
                cmdTrasladarEmpleados.Image = Properties.Resources.icon_traslados_verde;




                NavigationAsignacionesTraslados.SelectedPage = pageTraslados;
                ctlTrasladosEmpleadosServicio1.ConstruirControl(Pro_Conexion,
                                                                Pro_ID_AgenciaServicio,
                                                                Pro_ID_ClienteServicio,
                                                                Pro_Usuario);
                splashScreenManager1.CloseWaitForm();
            }
            else
            {
                MessageBox.Show("HAY REGISTROS QUE NO HAN SIDO GUARDADOS EN LA ASIGNACION DE POSICIONES. ¿DESEA CONTINUAR?", "FLUCOL", MessageBoxButtons.YesNo);
            }
 
        }

        private void cmdAsignarPosicionesEmpleados_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ReinicioImagenes();
            cmdAsignarPosicionesEmpleados.Image = Properties.Resources.icon_asignar_posiciones_verde_64;
            ctlAsignacionPosiciones1.ConstruirControl(Pro_Conexion,
                                                     Pro_ID_AgenciaServicio,
                                                     Pro_ID_ClienteServicio,
                                                     Pro_Usuario);
            NavigationAsignacionesTraslados.SelectedPage = pageAsignaciones;
            splashScreenManager1.CloseWaitForm();
        }

        private void cmdCerrarSesion_Click(object sender, EventArgs e)
        {
            ReinicioImagenes();
            cmdCerrarSesion.Image = Properties.Resources.icon_cerrar_sesion_verde_64;
            OnCerrarSesionSupervisor?.Invoke(sender, e);
        }

        private void cmdAsignarPosiciones_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ReinicioImagenes();
            cmdAsignarPosiciones.Image = Properties.Resources.icon_posiciones_verde_64;
           
            NavigationPrincipal.SelectedPage = pageAsignacionesTraslados;
           
            splashScreenManager1.CloseWaitForm();
        }

        #endregion
    }
}
