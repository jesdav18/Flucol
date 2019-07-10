using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using Core.DataSets;
using static Administracion.Controles.ctlAdministracionPrincipal;

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

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pID_ClienteServicio,
                                     OPCIONES_MENU pOpcionMenu)
        {
            Pro_Conexion = pConexion;
            Pro_ID_ClienteServicio = pID_ClienteServicio;

            switch (pOpcionMenu)
            {
                
                case OPCIONES_MENU.DASHBOARDS:
                    lblTitulo.Text = "AGENCIAS DISPONIBLES PARA VISUALIZACIÓN DE DASHBOARDS.";
                    break;
                case OPCIONES_MENU.ASIGNACION_POSICIONES:
                    lblTitulo.Text = "AGENCIAS DISPONIBLES PARA ASIGNAR POSICIONES.";
                    break;
                case OPCIONES_MENU.MANTENIMIENTO_EMPLEADOS:
                    lblTitulo.Text = "AGENCIAS DISPONIBLES PARA MANTENIMIENTO DE EMPLEADOS";
                    break;
                
            }

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

        public delegate void SeleccionaAgencia(int pID_Agencia, string pNombreSucursal);
        public event SeleccionaAgencia OnSeleccionaAgencia;

        #endregion

        private void cmdVerDashboard_Click(object sender, EventArgs e)
        {
            var v_fila = (dsCore.dtAgenciasDisponiblesRow)gvSucursalesDisponibles.GetFocusedDataRow();

            if (v_fila != null)
            {
                OnSeleccionaAgencia?.Invoke(v_fila.id_agencia_servicio, v_fila.nombre_agencia);
            }
        }
    }
}
