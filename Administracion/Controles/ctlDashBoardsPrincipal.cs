using System;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Configuration;
using Core.Clases;
using System.Globalization;
using DevExpress.XtraScheduler;

namespace Administracion.Controles
{
    public partial class ctlDashBoardsPrincipal : UserControl
    {
        #region INICIALIZADOR

        public ctlDashBoardsPrincipal()
        {
            InitializeComponent();
            ctlAgenciasDisponiblesParaDashboards1.OnSeleccionaAgencia += ctlAgenciasDisponiblesParaDashboards1_OnSeleccionaAgencia;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pID_ClienteServicio
                                     )
        {
            picLogoCliente.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

            Pro_Conexion = pConexion;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;

            
                 
        }

        private void CargarDatos(int pID_AgenciaServicio, bool pFiltrarIntervalo = false)
        {
            int v_numero_mes_actual;
            Utilidades v_utilidades = new Utilidades();
            v_numero_mes_actual =  v_utilidades.ObtenerNumeroMes(Pro_Conexion);


            DateTimeFormatInfo v_data_info = new CultureInfo("es-ES", false).DateTimeFormat;
            lblTituloDashboardPrincipal.Text = "DASHBOARD " + v_data_info.GetMonthName(v_numero_mes_actual).ToUpper();
            

            ssmDashboardsPrincipal.ShowWaitForm();

            ctlEmpleadoConMasTicketsAtendidos1.ConstruirControl(Pro_Conexion,
                                                                v_numero_mes_actual,
                                                                pID_AgenciaServicio,
                                                                Pro_ID_Cliente_Servicio);

            ctlTicketsAtendidos_TicketsNoAtendidos1.ConstruirControl(Pro_Conexion,
                                                                     Pro_ID_Cliente_Servicio,
                                                                     pID_AgenciaServicio,
                                                                     v_numero_mes_actual);
            ctlVisitasSegunPrioridadServicio1.ConstruirControl(Pro_Conexion,
                                                               Pro_ID_Cliente_Servicio,
                                                               pID_AgenciaServicio,
                                                               v_numero_mes_actual);
            ctlPromedioAtencion1.ConstruirControl(Pro_Conexion,
                                                  v_numero_mes_actual,
                                                  pID_AgenciaServicio,
                                                  Pro_ID_Cliente_Servicio);
            ctlTraficoClientes1.ConstruirControl(Pro_Conexion,
                                                 v_numero_mes_actual,
                                                 pID_AgenciaServicio,
                                                 Pro_ID_Cliente_Servicio);

            ctlPromedioEspera1.ConstruirControl(Pro_Conexion,
                                                v_numero_mes_actual,
                                                pID_AgenciaServicio,
                                                Pro_ID_Cliente_Servicio);

            ctlVisitasSegunCanalDeServicio1.ConstruirControl(Pro_Conexion,
                                                            Pro_ID_Cliente_Servicio,
                                                            pID_AgenciaServicio,
                                                            v_numero_mes_actual);
            
            navegacionDasboards.SelectedPage = pageDashBoardsPrincipal;
            ssmDashboardsPrincipal.CloseWaitForm();
        }

        private void cmdDashboards_Click(object sender, EventArgs e)
        {
            navegacionDasboards.SelectedPage = pageAgenciasDisponibles;
            ctlAgenciasDisponiblesParaDashboards1.ConstruirControl(Pro_Conexion, Pro_ID_Cliente_Servicio);
        }

        private void ctlAgenciasDisponiblesParaDashboards1_OnSeleccionaAgencia(object sender, EventArgs e)
        {
            int v_id_agencia = (int)sender;

            navegacionDasboards.SelectedPage = pageDashBoardsPrincipal;
            CargarDatos(v_id_agencia);

        }

        #endregion

        private void picAtrasDashboardPrincipal_Click(object sender, EventArgs e)
        {
            navegacionDasboards.SelectedPage = pageAgenciasDisponibles;
        }

        private void cmdBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
