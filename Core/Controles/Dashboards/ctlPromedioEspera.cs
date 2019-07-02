using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Core.Controles.Dashboards
{
    public partial class ctlPromedioEspera : UserControl
    {
        #region INICIALIZADOR

        public ctlPromedioEspera()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public DateTime Pro_Desde { get; set; }
        public DateTime Pro_Hasta { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
             
                                     int pID_Agencia_Servicio,
                                     int pID_Cliente_Servicio,
                                     DateTime pDesde,
                                     DateTime pHasta)
        {


            LimpiarDatos();

            Pro_Conexion = pConexion;       
            Pro_ID_AgenciaServicio = pID_Agencia_Servicio;
            Pro_ID_ClienteServicio = pID_Cliente_Servicio;
            Pro_Desde = pDesde;
            Pro_Hasta = pHasta;

            CargarDatos();
        }

        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_dashboard_promedio_espera(
                                                                                               :p_id_cliente_servicio,
                                                                                               :p_id_agencia_servicio,
                                                                                               :p_desde,
                                                                                               :p_hasta);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion_temporal);      
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_desde", PgSqlType.Date).Value = Pro_Desde;
            pgComando.Parameters.Add("p_hasta", PgSqlType.Date).Value = Pro_Hasta;

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    lblPromedioEspera.Text = pgDr.GetString("promedio_espera");
                }

                pgDr.Close();
                pgDr = null;
                sentencia = null;
                pgComando.Dispose();
                v_conexion_temporal.Close();
                v_conexion_temporal.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar Dashboard \"PROMEDIO DE ESPERA\"." + Exc.Message);
            }
        }

        private void LimpiarDatos()
        {
            lblPromedioEspera.Text = "";
        }

        #endregion

        #region VARIABLES GLOBALES

        int v_mes_a_evaluar;

        #endregion
    }
}
