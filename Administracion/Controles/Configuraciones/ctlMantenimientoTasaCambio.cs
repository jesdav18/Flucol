using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Administracion.Controles.Configuraciones
{
    public partial class ctlMantenimientoTasaCambio : UserControl
    {

        #region INICIALIZADOR

        public ctlMantenimientoTasaCambio()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            txtCompra.Focus();
        }

        private void GuardarCambiosTasaCambio()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_registra_tasa_cambio(:p_venta,
                                                                                    :p_compra,
                                                                                    :p_usuario);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_venta", PgSqlType.Numeric).Value = Convert.ToDecimal(txtVenta.Text);
            pgComando.Parameters.Add("p_compra", PgSqlType.Numeric).Value = Convert.ToDecimal(txtCompra.Text);
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;

            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();
                pgComando = null;
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Gurdar cambios en la tasa de cambio. ");
            }
        }

        #endregion


        #region EVENTOS CONTROLES

        private void CmdGuardarCambios_Click(object sender, EventArgs e)
        {
            GuardarCambiosTasaCambio();
        }

        #endregion
    }
}
