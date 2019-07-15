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
using Core.Controles.Configuraciones.DataSets;

namespace Core.Controles.Configuraciones
{
    public partial class ctlCreacionAgenciasServicio : UserControl
    {
        public ctlCreacionAgenciasServicio()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public int Pro_ID_Cliente { get; set; }
        public bool Pro_Habilitar { get; private set; }

        public void ConstruirControl(PgSqlConnection pConexion, string pUsuario, int pID_ClienteServicio)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_ID_Cliente = pID_ClienteServicio;
        }

        private void CargarDatos()
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_agencias_servicio_por_cliente (:p_id_cliente_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;

            try
            {

                dsConfiguraciones1.dtAgenciasServicio.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtAgenciasServicio);


                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Cargar Noticias. " + Exc.Message, "FLUCOL");
            }
        }

        private void LimpiarCajasTexto()
        {
            memoDireccionAgencia.Text = "";
            txtCantidadPosiciones.Text = "";
            txtNombreAgencia.Text = "";
        }

        private void RegistrarAgenciaServicio()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_registrar_sucursal_servicio (
                                                                                                  :p_id_cliente_servicio,
                                                                                                  :p_usuario,
                                                                                                  :p_direccion,
                                                                                                  :p_nombre_agencia,
                                                                                                  :p_cantidad_posiciones
                                                                                                );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_direccion", PgSqlType.VarChar).Value = memoDireccionAgencia.Text;
            pgComando.Parameters.Add("p_nombre_agencia", PgSqlType.VarChar).Value = txtNombreAgencia.Text;
            pgComando.Parameters.Add("p_cantidad_posiciones", PgSqlType.Int).Value = Convert.ToInt32(txtCantidadPosiciones.Text);

            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();

                LimpiarCajasTexto();

                MessageBox.Show("La agencia se registro correctamente. ", "FLUCOL");
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Ingresar esta agencia. " + Exc.Message, "FLUCOL");
            }
        }

        private void TxtCantidadPosiciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CmdGuardarAgencia_Click(object sender, EventArgs e)
        {
            RegistrarAgenciaServicio();
        }

        private void CmdVisualizarAgenciasServico_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageVisualizacionAgencias;
            CargarDatos();
        }

        private void CmdAgregarAgenciaServicio_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageAgregarAgencia;
        }

        private void ChkHbailitado_Deshabilitado_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var v_fila = (dsConfiguraciones.dtAgenciasServicioRow)gvAgencias.GetFocusedDataRow();

            Pro_Habilitar = !v_fila.habilitada;

            foreach (dsConfiguraciones.dtAgenciasServicioRow iterador in dsConfiguraciones1.dtAgenciasServicio)
            {
                if (iterador.id_agencia_servicio == v_fila.id_agencia_servicio)
                {
                    iterador.habilitada = Pro_Habilitar;
                    iterador.AcceptChanges();
                    break;
                }


            }

            HabilitarDeshabilitarAgencia(v_fila.id_agencia_servicio, Pro_Habilitar);
        }

        private void HabilitarDeshabilitarAgencia(int p_id_agencia, bool p_habilitar)
        {
            string sentencia = @"SELECT * FROM area_servicio.ft_mant_habilitar_deshabilitar_agencia_servicio(:pCodigoEmpleado,
                                                                                                             :pHabilitar);";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("pCodigoEmpleado", PgSqlType.VarChar).Value = p_id_agencia;
            pgComando.Parameters.Add("pHabilitar", PgSqlType.Boolean).Value = p_habilitar;


            try
            {
                pgComando.ExecuteNonQuery();

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIO EN EL MOMENTO DE HACER EL MANTENIMIENTO EN LA AGENCIA. " + Exc.Message, "FLUCOL");
            }
        }
    }
}