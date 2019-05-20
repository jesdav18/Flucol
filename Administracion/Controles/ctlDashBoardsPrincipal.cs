using System;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Configuration;


namespace Administracion.Controles
{
    public partial class ctlDashBoardsPrincipal : UserControl
    {
        #region INICIALIZADOR

        public ctlDashBoardsPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Agencia_Servicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pID_ClienteServicio,
                                     int pID_AgenciaServicio)
        {
            picLogoCliente.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

            Pro_Conexion = pConexion;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
            Pro_ID_Agencia_Servicio = pID_AgenciaServicio;         
        }

        private void CargarDatos()
        {
            ssmDashboardsPrincipal.ShowWaitForm();

            ctlEmpleadoConMasTicketsAtendidos1.ConstruirControl(Pro_Conexion,
                                                                5,
                                                                Pro_ID_Agencia_Servicio,
                                                                Pro_ID_Cliente_Servicio);

            ctlTicketsAtendidos_TicketsNoAtendidos1.ConstruirControl(Pro_Conexion,
                                                                     Pro_ID_Cliente_Servicio,
                                                                     Pro_ID_Agencia_Servicio,
                                                                     5);
            ctlVisitasSegunPrioridadServicio1.ConstruirControl(Pro_Conexion,
                                                               Pro_ID_Cliente_Servicio,
                                                               Pro_ID_Agencia_Servicio,
                                                               5);
            ctlPromedioAtencion1.ConstruirControl(Pro_Conexion,
                                                  5,
                                                  Pro_ID_Agencia_Servicio,
                                                  Pro_ID_Cliente_Servicio);
            ctlTraficoClientes1.ConstruirControl(Pro_Conexion,
                                                 5,
                                                 Pro_ID_Agencia_Servicio,
                                                 Pro_ID_Cliente_Servicio);

            ctlPromedioEspera1.ConstruirControl(Pro_Conexion,
                                                5,
                                                Pro_ID_Agencia_Servicio,
                                                Pro_ID_Cliente_Servicio);

            ctlVisitasSegunCanalDeServicio1.ConstruirControl(Pro_Conexion,
                                                            Pro_ID_Cliente_Servicio,
                                                            Pro_ID_Agencia_Servicio,
                                                            5);
            
            navegacionDasboards.SelectedPage = pageDashBoardsPrincipal;
            ssmDashboardsPrincipal.CloseWaitForm();
        }

        private void cmdDashboards_Click(object sender, EventArgs e)
        {
            CargarDatos();        
        }

        #endregion
  
    }
}
