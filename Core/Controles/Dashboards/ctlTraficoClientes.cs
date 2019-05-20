using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Core.Controles.Dashboards
{
    public partial class ctlTraficoClientes : UserControl
    {
        #region INICIALIZADOR

        public ctlTraficoClientes()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pMes_A_Evaluar,
                                     int pID_Agencia_Servicio,
                                     int pID_Cliente_Servicio)
        {
            Pro_Conexion = pConexion;
            v_mes_a_evaluar = pMes_A_Evaluar;
            Pro_ID_AgenciaServicio = pID_Agencia_Servicio;
            Pro_ID_ClienteServicio = pID_Cliente_Servicio;
            CargarDatos();
        }

        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_dashboard_trafico_clientes(:p_mes_a_evaluar,
                                                                                                :p_id_cliente_servicio,
                                                                                                :p_id_agencia_servicio)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion_temporal);
            pgComando.Parameters.Add("p_mes_a_evaluar", PgSqlType.Int).Value = v_mes_a_evaluar;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;

            try
            {
                dsDashboards1.dtTraficoClientes.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsDashboards1.dtTraficoClientes);

                chrTraficoClientes.Show();
                chrTraficoClientes.RefreshData();

                sentencia = null;
                pgComando.Dispose();
                v_conexion_temporal.Close();
                v_conexion_temporal.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar el dashboard \"TRAFICO DE CLIENTES\". " + Exc.Message);
            }

        }

        #endregion

        #region VARIABLES GLOBALES

        int v_mes_a_evaluar;

        #endregion
    }
}
