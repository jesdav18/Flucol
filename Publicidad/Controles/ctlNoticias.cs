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
using System.Collections;
using System.Threading;
using System.Configuration;

namespace Publicidad.Controles
{
    public partial class ctlNoticias : UserControl
    {

        #region INICIALIZADOR

        public ctlNoticias()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

        ArrayList v_lista_noticias;

        #endregion

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        bool v_mostrar_presentacion;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_ClienteServicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;

            v_lista_noticias = new ArrayList();
            CargarDatos();
            IniciarPresentacion();
        }

        public void CargarDatos()
        {
            v_lista_noticias.Clear();

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_noticias_cliente (:p_id_cliente_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                while (pgDr.Read())
                {
                    v_lista_noticias.Add(pgDr.GetString("texto_noticia"));
                }

                pgDr.Close();
                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de obtener lista de noticias. " + Exc.Message);
            }
        }

        public void IniciarPresentacion()
        {
            if (!bgMostrarPresentacion.IsBusy)
            {
                bgMostrarPresentacion.RunWorkerAsync();
            }
        }

        public void FinalizarPresentacion()
        {
            v_mostrar_presentacion = false;
        }

        #endregion

        #region EVENTOS CONTROLES

        private void bgMostrarPresentacion_DoWork(object sender, DoWorkEventArgs e)
        {
            v_mostrar_presentacion = true;

            do
            {
                for (int i = 0; i < v_lista_noticias.Count; i++)
                {
                    memoNoticias.Text = v_lista_noticias[i].ToString();
                    Thread.Sleep(int.Parse(ConfigurationSettings.AppSettings["TIEMPO_PRESENTACION_POR_NOTICIA"]));
                }
            } while (v_mostrar_presentacion);
        }

        #endregion

    }
}
