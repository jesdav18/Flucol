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
using Core.Clases;
using Core.DataSets;

namespace Administracion.Controles
{
    public partial class ctlAgenciasDisponiblesParaDashboards : UserControl
    {

        #region INCIALIZADOR

        public ctlAgenciasDisponiblesParaDashboards()
        {
            InitializeComponent();

        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_ClienteServicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_ClienteServicio = pID_ClienteServicio;

            CargarDatos();
        }
         
        
        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM area_servicio.ft_view_agencias_servicio_disponibles_para_dashboards(:p_id_cliente);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente", PgSqlType.Int).Value = Pro_ID_ClienteServicio;

            try
            {
                dsCore1.dtAgenciasDisponibles.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCore1.dtAgenciasDisponibles);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "CargarDatos()");
                v_depurador = null;
                MessageBox.Show("Algo salió mal mientras se cargan Agencias Disponibles. ", "FLUCOL");

            }

        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }

        #endregion

        #region EVENTOS

        public event EventHandler OnSeleccionaAgencia;

        #endregion

        private void cmdVerDashboard_Click(object sender, EventArgs e)
        {
            var v_fila = (dsCore.dtAgenciasDisponiblesRow)gvSucursalesDisponibles.GetFocusedDataRow();

            if (v_fila != null)
            {
                OnSeleccionaAgencia?.Invoke(v_fila.id_agencia_servicio, e);
            }
        }
    }
}
