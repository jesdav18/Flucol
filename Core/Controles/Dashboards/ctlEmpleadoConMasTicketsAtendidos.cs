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
    public partial class ctlEmpleadoConMasTicketsAtendidos : UserControl
    {

        #region INICIALIZADOR

        public ctlEmpleadoConMasTicketsAtendidos()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        #region PROPIEDADES

        public string Pro_TituloDashBoard { get; set; }
        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Agencia_Servicio { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        int v_mes_a_evaluar;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pMes_A_Evaluar,
                                     int pID_Agencia_Servicio,
                                     int pID_Cliente_Servicio)
        {
            Pro_Conexion = pConexion;
            v_mes_a_evaluar = pMes_A_Evaluar;
            Pro_ID_Agencia_Servicio = pID_Agencia_Servicio;
            Pro_ID_Cliente_Servicio = pID_Cliente_Servicio;
            CargarDatos();
        }

        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_dashboard_empleados_con_mas_tickets_atendidos(:p_mes_evaluar,
                                                                                                                   :p_id_cliente_servicio,
                                                                                                                   :p_id_agencia_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia,v_conexion_temporal);
            pgComando.Parameters.Add("p_mes_evaluar",PgSqlType.Int).Value = v_mes_a_evaluar;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_Agencia_Servicio;

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    lblNumeroTicketsAtendidos.Text = pgDr.GetString("numero_tickets_atendidos");
                    lblNombreEmpleado.Text = pgDr.GetString("nombre_empleado");
                    lblSucursalEmpleado.Text = pgDr.GetString("agencia_servicio");
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
                MessageBox.Show("Algo salió mal en el momento de cargar Dashboard \"EMPLEADO CON MAS TICKETS ATENDIDOS\"." + Exc.Message);
            }

        }

        #endregion
    }
}
