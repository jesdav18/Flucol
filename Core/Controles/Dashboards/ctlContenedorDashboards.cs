using System;
using System.Drawing;
using System.Windows.Forms;
using Core.Clases;
using Devart.Data.PostgreSql;

namespace Core.Controles.Dashboards
{
    public partial class ctlContenedorDashboards : UserControl
    {

        #region INICIALIZADOR
    
        public ctlContenedorDashboards()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnIrAtras;

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Agencia { get; set; }
        public string Pro_NombreAgencia { get; set; }
        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_ClienteServicio,
                                     int pID_AgenciaServicio,
                                     string pNombreAgencia
                                     )
        {
            
            Pro_Conexion = pConexion;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
            Pro_ID_Agencia = pID_AgenciaServicio;
            Pro_NombreAgencia = pNombreAgencia;

            Utilidades v_utilidades = new Utilidades();
            DateTime v_fecha = v_utilidades.ObtenerHoraServidor(Pro_Conexion);

            var v_primer_dia_mes = new DateTime(v_fecha.Year, v_fecha.Month, 1);
            var v_ultimo_dia_mes = v_primer_dia_mes.AddMonths(1).AddDays(-1);

            dtDesde.EditValue = v_primer_dia_mes;
            dtHasta.EditValue = v_ultimo_dia_mes;

            CargarDatos();
        }

        private void CargarDatos()
        {

            ssmEsperaDashboard.ShowWaitForm();

            ctlEmpleadoConMasTicketsAtendidos1.ConstruirControl(Pro_Conexion,
                                                                Pro_ID_Agencia,
                                                                Pro_ID_Cliente_Servicio,
                                                                (DateTime)dtDesde.EditValue,
                                                                (DateTime)dtHasta.EditValue
                                                                );

            /*ctlTicketsAtendidos_TicketsNoAtendidos1.ConstruirControl(Pro_Conexion,
                                                                        Pro_ID_Cliente_Servicio,
                                                                        Pro_ID_Agencia,
                                                                        v_numero_mes_actual);
            ctlVisitasSegunPrioridadServicio1.ConstruirControl(Pro_Conexion,
                                                                Pro_ID_Cliente_Servicio,
                                                                pID_AgenciaServicio,
                                                                v_numero_mes_actual);*/

            ctlPromedioAtencion1.ConstruirControl(Pro_Conexion,                                                   
                                                  Pro_ID_Agencia,
                                                  Pro_ID_Cliente_Servicio,
                                                  (DateTime)dtDesde.EditValue,
                                                  (DateTime)dtHasta.EditValue);

           /* ctlTraficoClientes1.ConstruirControl(Pro_Conexion,
                                                    v_numero_mes_actual,
                                                    pID_AgenciaServicio,
                                                    Pro_ID_Cliente_Servicio);*/

            ctlPromedioEspera1.ConstruirControl(Pro_Conexion,
                                                Pro_ID_Agencia,
                                                Pro_ID_Cliente_Servicio,
                                                (DateTime)dtDesde.EditValue,
                                                  (DateTime)dtHasta.EditValue);

           /* ctlVisitasSegunCanalDeServicio1.ConstruirControl(Pro_Conexion,
                                                            Pro_ID_Cliente_Servicio,
                                                            pID_AgenciaServicio,
                                                            v_numero_mes_actual);*/

           
            ssmEsperaDashboard.CloseWaitForm();


            CambiarTituloDashboard((DateTime)dtDesde.EditValue, (DateTime)dtHasta.EditValue);

        }

        private void CambiarTituloDashboard(DateTime pDesde, DateTime pHasta)
        {

            lblTiuloDashboard.Text = "INDICADORES AGENCIA " + Pro_NombreAgencia;
            lblIntervalo.Text = "DESDE " + string.Format("{0:dd/MM/yyyy}", pDesde) + " HASTA: " + string.Format("{0:dd/MM/yyyy}", pHasta);
        }


        #endregion

        #region EVENTOS CONTROLES

        private void CmdIrAtras_Click(object sender, EventArgs e)
        {
            OnIrAtras?.Invoke(sender, e);
        }

        private void CmdAbrirFiltros_Click(object sender, EventArgs e)
        {
            popupFiltros.ShowPopup();
            pnlFiltro.Size = new Size(popupFiltros.Size.Width, popupFiltros.Size.Height);          
        }

        private void CmdFiltro_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void PopupFiltros_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            pnlFiltro.Size = new Size(1213, 10);
            this.BringToFront();
            this.Select();
        }

        #endregion

    }
}
