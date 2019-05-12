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
using Operaciones.Controles.Configuraciones.DataSets;

namespace Operaciones.Controles.Configuraciones
{
    public partial class ctlAsignacionPosiciones : UserControl
    {

        #region INICIALIZADOR

        public ctlAsignacionPosiciones()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Agencia_Servicio { get; set; }
        public int Pro_ID_Cliente_Servicio{ get; set; }


        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Agencia_Servicio = pID_AgenciaServicio;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;

            CargarDatos();

        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_empleados_disponibles_para_asignacion_posiciones(:p_id_agencia_servicio,
                                                                                                                      :p_id_cliente_servicio)";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia,Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio",PgSqlType.Int).Value = Pro_ID_Agencia_Servicio;
            pgComando.Parameters.Add("p_id_cliente_servicio",PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;

            try
            {
                dsConfiguraciones1.dtAsignacionPosiciones.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtAsignacionPosiciones);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en la carga de empleados disponibles. " + Exc.Message);
            }
        }

        #endregion

        #region VARIABLES GLOBALES

        #endregion

        #region EVENTOS CONTROLES

        private void cmdCargarPosiciones_Click(object sender, EventArgs e)
        {
            dsConfiguraciones.dtAsignacionPosicionesRow v_fila = (dsConfiguraciones.dtAsignacionPosicionesRow) gvEmpleadosDisponiblesAsignacion.GetFocusedDataRow();
            if (v_fila != null)
            {
                popupPosicionesDisponibles.ShowPopup();
                ctlPosicionesDisponibles1.ConstruirControl(Pro_Conexion,
                                                           Pro_ID_Agencia_Servicio,
                                                           Pro_ID_Cliente_Servicio);
            }
        }

        #endregion
    }
}
