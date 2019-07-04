using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Core.Controles.Dashboards
{
    public partial class ctlVisitasSegunPrioridadServicio : UserControl
    {

        #region INICIALIZADOR

        public ctlVisitasSegunPrioridadServicio()
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_Agencia_Servicio,
                                     int pID_Cliente_Servicio,
                                     DateTime pDesde,
                                     DateTime pHasta
                                     )
        {
            Pro_Conexion = pConexion;
            Pro_ID_Agencia_Servicio = pID_Agencia_Servicio;
            Pro_ID_Cliente_Servicio = pID_Cliente_Servicio;
            Pro_Desde = pDesde;
            Pro_Hasta = pHasta;
            CargarDatos();
        }

        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();


            string sentencia = @"SELECT * FROM area_servicio.ft_view_dashboard_visitas_segun_prioridad_servicio(
                                                                                                                :p_id_cliente_servicio,
                                                                                                                :p_id_agencia_servicio,
                                                                                                                :p_desde,
                                                                                                                :p_hasta);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia,v_conexion_temporal);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_Agencia_Servicio;
            pgComando.Parameters.Add("p_desde", PgSqlType.Date).Value = Pro_Desde;
            pgComando.Parameters.Add("p_hasta", PgSqlType.Date).Value = Pro_Hasta;

            try
            {
                dsDashboards1.dtVisitasSegunPrioridadServicio.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsDashboards1.dtVisitasSegunPrioridadServicio);

                chartControl1.Show();
                chartControl1.RefreshData();

                sentencia = null;
                pgComando.Dispose();
                v_conexion_temporal.Close();
                v_conexion_temporal = null;

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar dashboard \"VISITAS SEGUN PRIORIDAD DE SERVICIO\". " + Exc.Message);
            }
        }

        #endregion

        #region VARIABLES GLOBALES

        int v_mes_evaluar;

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Agencia_Servicio { get; set; }
        public DateTime Pro_Desde { get; set; }
        public DateTime Pro_Hasta { get; set; }

        #endregion
    }
}
