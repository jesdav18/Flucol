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
using Core.DataSets;

namespace Core.Controles.Popups
{
    public partial class ctlPosicionesDisponibles : UserControl
    {

        #region INICIADOR

        public ctlPosicionesDisponibles()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_Agencia_Servicio,
                                     int pID_Cliente_Servicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_Agencia_Servicio;
            Pro_ID_ClienteServicio = pID_Cliente_Servicio;

            CargarDatos();
        }

        public void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_posiciones_disponibles_para_asignacion(:p_id_agencia_servicio,
                                                                                                            :p_id_cliente_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;

            try
            {
                dsCore1.dtPosicionesDisponibles.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCore1.dtPosicionesDisponibles);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar las posiciones disponibles. " + Exc.Message);
            }
        }

        #endregion

        private void chkSeleccionar_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var v_fila = gvPosicionesDisponibles.GetFocusedDataRow() as dsCore.dtPosicionesDisponiblesRow;

            if (v_fila != null)
            {
                foreach (dsCore.dtPosicionesDisponiblesRow iterador in dsCore1.dtPosicionesDisponibles)
                {
                    if (v_fila.posicion != iterador.posicion)
                    {
                        iterador.seleccionar_posicion = false;
                    }
                }
            }

        }
    }
}
