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

namespace Administracion.Controles
{
    public partial class ctlDashBoards : UserControl
    {
        #region INICIALIZADOR

        public ctlDashBoards()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente { get; set; }

        #endregion

        public void ConstruirControl(PgSqlConnection pConexion, int pID_ClienteServicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Cliente = pID_ClienteServicio;
            CargarDatosPromedioAtencion();
        }

        private void CargarDatosPromedioAtencion()
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_devuelve_promedio_atencion (
                                                                                            :p_id_cliente_servicio
                                                                                            
                                                                                          );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia,Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;

            try
            {
                dsDashboards1.dtPromedioAtencion.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsDashboards1.dtPromedioAtencion);
                chartControl1.RefreshData();

               
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de cargar promedio de atencion. ", "FLUCOL");
                
            }
        }

    }
}
