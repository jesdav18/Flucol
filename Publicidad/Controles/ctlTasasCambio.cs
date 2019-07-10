using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Publicidad.Controles
{
    public partial class ctlTasasCambio : UserControl
    {

        #region INICIALIZADOR

        public ctlTasasCambio()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;
            CargarDatos();
        } 

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM area_servicio.ft_view_ultima_tasa_cambio();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    lblVenta.Text = pgDr.GetString("venta");
                    lblCompra.Text = pgDr.GetString("compra");
                }

                pgDr.Close();
                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar la tasa de cambio. " + Exc.Message);
            }

        }

        #endregion
  
    }
}
