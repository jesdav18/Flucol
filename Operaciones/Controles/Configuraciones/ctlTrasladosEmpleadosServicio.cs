using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Operaciones.Controles.Configuraciones.DataSets;

namespace Operaciones.Controles.Configuraciones
{
    public partial class ctlTrasladosEmpleadosServicio : UserControl
    {

        #region INICIALIZADOR

        public ctlTrasladosEmpleadosServicio()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public string Pro_CodigoEmpleadoSelecciondo { get; set; }
        public int Pro_ID_AgenciaServicioSeleccionado { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio,
                                     string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;

            CargarDatosAgenciasServicio();
        }

        private void CargarDatosAgenciasServicio()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_agencias_servicio_disponibles(:p_id_cliente_servicio,
                                                                                                   :p_id_agencia_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            try
            {
                dsConfiguraciones1.dtAgenciasServicio.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtAgenciasServicio);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
               
                MessageBox.Show("Algo salió mal en la carga de agencia servicio. " + Exc.Message);
            }

        }

        private void CargarDatosEmpleadosServicio()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_empleados_servicio_disponibles(:p_id_cliente_servicio,
                                                                                                    :p_id_agencia_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicioSeleccionado;

            try
            {
                dsConfiguraciones1.dtEmpleadosServicio.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtEmpleadosServicio);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en la carga de empleados de servicio. " + Exc.Message);
            }
        }

        private void TrasladarEmpleado()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_trasladar_empleado_a_sucursal(:p_id_cliente_servicio,
                                                                                                   :p_id_agencia_servicio_destino,                                                                             
                                                                                                   :p_codigoempleado,
                                                                                                   :p_usuario);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio_destino", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_codigoempleado", PgSqlType.VarChar).Value = Pro_CodigoEmpleadoSelecciondo;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;

            try
            {
                pgComando.ExecuteNonQuery();
              

                sentencia = null;
                pgComando.Dispose();

                MessageBox.Show("El traslado se completó de manera correcta.");
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el traslado del empleado. " + Exc.Message);
            }
        }

        #endregion

        #region EVENTOS CONTROLES

        private void chkSeleccionarAgenciaServicio_EditValueChanged(object sender, EventArgs e)
        {

            dsConfiguraciones.dtAgenciasServicioRow v_fila = (dsConfiguraciones.dtAgenciasServicioRow) gvAgenciasServicio.GetFocusedDataRow();

            if (v_fila != null)
            {
                Pro_ID_AgenciaServicioSeleccionado = v_fila.id_agencia_servicio;
                lblAgenciaServicio.Text = v_fila.nombre_agencia;
                CargarDatosEmpleadosServicio();
                
                NavigationTraslados.SelectedPage = pageEmpleadosServicio;
            }      
        }

        private void cmdIrAtras_Click(object sender, EventArgs e)
        {
            NavigationTraslados.SelectedPage = pageAgenciasServicio;
        }

        private void cmdGuardarTraslado_Click(object sender, EventArgs e)
        {
            TrasladarEmpleado();
        }

        #endregion

        private void chkSeleccionar_EditValueChanged(object sender, EventArgs e)
        {
            dsConfiguraciones.dtEmpleadosServicioRow v_fila = (dsConfiguraciones.dtEmpleadosServicioRow)gvEmpleadosServicio.GetFocusedDataRow();


            if (v_fila != null)
            {
                Pro_CodigoEmpleadoSelecciondo = v_fila.codigo_empleado;
            }
            
        }

        private void txtBusquedaAgencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaColaborador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
