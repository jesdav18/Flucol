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
    public partial class ctlTicketsAtendidos_TicketsNoAtendidos : UserControl
    {

        #region INICIALIZADOR

        public ctlTicketsAtendidos_TicketsNoAtendidos()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_Cliente_Servicio { get; set; }
        public int Pro_Agencia_Servicio { get; set; }
        public DateTime Pro_Desde { get; set; }
        public DateTime Pro_Hasta { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        int v_mes_a_evaluar;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pAgencia_Servicio,
                                     int pCliente_Servicio,                                  
                                     DateTime pDesde,
                                     DateTime pHasta)
        {

            Pro_Conexion = pConexion;
            Pro_Agencia_Servicio = pAgencia_Servicio;
            Pro_Cliente_Servicio = pCliente_Servicio;
            Pro_Desde = pDesde;
            Pro_Hasta = pHasta;
        
            CargarDatos();
        }

      
        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_dashboard_tickets_atendidos_no_atendidos(
                                                                                                              :p_id_cliente_servicio,
                                                                                                              :p_id_agencia_servicio,
                                                                                                              :p_desde,
                                                                                                              :p_hasta
                                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion_temporal);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_Cliente_Servicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_Agencia_Servicio;
            pgComando.Parameters.Add("p_desde", PgSqlType.Date).Value = Pro_Desde;
            pgComando.Parameters.Add("p_hasta", PgSqlType.Date).Value = Pro_Hasta;


            try
            {
                dsDashboards.dtTicketsAtendidos_NoAtendidos.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsDashboards.dtTicketsAtendidos_NoAtendidos);
                
                chrt_TicketsAtendidos_NoAtendidos.Show();
                chrt_TicketsAtendidos_NoAtendidos.RefreshData();

                sentencia = null;
                pgComando.Dispose();
                v_conexion_temporal.Close();
                v_conexion_temporal.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar el dashboard \"TICKETS ATENDIDOS Y NO ATENDIDOS\". " + Exc.Message);
            }

        }

        #endregion


    }
}
