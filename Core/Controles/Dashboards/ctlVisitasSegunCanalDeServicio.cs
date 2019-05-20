using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Core.Controles.Dashboards
{
    public partial class ctlVisitasSegunCanalDeServicio : UserControl
    {
        #region INICIALIZADOR

        public ctlVisitasSegunCanalDeServicio()
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                    int pID_Cliente_Servicio,
                                    int pID_Agencia_Servicio,
                                    int pMes_Evaluar)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Agencia_Servicio = pID_Agencia_Servicio;
            Pro_ID_Cliente_Servicio = pID_Cliente_Servicio;
            v_mes_evaluar = pMes_Evaluar;
            CargarDatos();
        }

        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();


            string sentencia = @"SELECT * FROM area_servicio.ft_view_dashboard_visitas_segun_canal_servicio(:p_mes_evaluar,
                                                                                                            :p_id_cliente_servicio,
                                                                                                            :p_id_agencia_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion_temporal);
            pgComando.Parameters.Add("p_mes_evaluar", PgSqlType.Int).Value = v_mes_evaluar;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_Agencia_Servicio;

            try
            {
                dsDashboards1.dtVisitasSegunCanalServicio.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsDashboards1.dtVisitasSegunCanalServicio);

                chartControl1.Show();
                chartControl1.RefreshData();

                sentencia = null;
                pgComando.Dispose();
                v_conexion_temporal.Close();
                v_conexion_temporal = null;

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar dashboard \"VISITAS SEGUN CANAL DE SERVICIO\". " + Exc.Message);
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

        #endregion
    }
}
