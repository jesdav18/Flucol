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
    public partial class ctlMantenimientoNoticias : UserControl
    {
        public ctlMantenimientoNoticias()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente { get; set; }
        public string Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Cliente, string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Cliente = pID_Cliente;
            Pro_Usuario = pUsuario;

        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_noticias_cliente (:p_id_cliente_servicio);";                                                                                      
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;

            try
            {

                dsConfiguraciones1.dtNoticias.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtNoticias);


                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Cargar Noticias. " + Exc.Message, "FLUCOL");
            }
        }

        private void GuardarNotica()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_registrar_noticias_cliente_servicio (
                                                                                                          :p_id_cliente_servicio,
                                                                                                          :p_usuario_posteo,
                                                                                                          :p_texto_noticia
                                                                                                        );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente;
            pgComando.Parameters.Add("p_usuario_posteo", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_texto_noticia", PgSqlType.VarChar).Value = memoNoticia.Text;

            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();

                memoNoticia.Text = "";

                MessageBox.Show("La noticia se registro correctamente. ", "FLUCOL");
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Ingresar esta noticia. " + Exc.Message,"FLUCOL");
            }

        }

        private void BorrarNoticia(int pID_Cliente_Noticia)
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_inactivar_noticia (:p_id_cliente_noticia)";
                                                                                                        
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_noticia", PgSqlType.Int).Value = pID_Cliente_Noticia;
            

            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();

                memoNoticia.Text = "";

                CargarDatos();


            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Eliminar esta noticia. " + Exc.Message, "FLUCOL");
            }
        }

        private void CmdGuardarNoticia_Click(object sender, EventArgs e)
        {
            GuardarNotica();
        }

        private void PicAgregarNoticia_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageAgregarNoticia;
        }

        private void CmdVisualizarNoticias_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageVisualizacion;
            CargarDatos();
        }

        private void CmdBorrarNoticia_Click(object sender, EventArgs e)
        {
            var v_fila = (dsConfiguraciones.dtNoticiasRow)gvNoticias.GetFocusedDataRow();
            if (v_fila != null)
            {
                BorrarNoticia(v_fila.id_noticia);
            }
        }
    }
}
