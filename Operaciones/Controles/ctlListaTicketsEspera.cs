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
using Operaciones.DataSets;

namespace Operaciones.Controles
{
    public partial class ctlListaTicketsEspera : UserControl
    {

        #region INICIALIZADOR
   
        public ctlListaTicketsEspera()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region VARIABLES GLOBALES
        ArrayList v_lista;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int p_ID_AgenciaServicio,
                                     int p_ID_ClienteServicio,
                                     string p_usuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = p_ID_AgenciaServicio;
            Pro_ID_ClienteServicio = p_ID_ClienteServicio;
            Pro_Usuario = p_usuario;
            CargarListaTicketsEnEspera();
            tmrCargarColaTicketsEspera.Start();
            ArrayList v_lista = new ArrayList();
        }

        private void CargarListaTicketsEnEspera()
        {


            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_devuelve_cola_tickets_en_espera(:p_id_cliente_servicio,
                                                                                                     :p_id_agencia_servicio,
                                                                                                     :p_usuario);";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;

            try
            {
                dsTickets1.dtTickets.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsTickets1.dtTickets);

                sentencia = null;
                pgComando.Dispose();
               
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de Cargar la lista de Tickets en espera.", "FLUCOL");
            }
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnSeleccionaTicket;

        #endregion

        #region EVENTOS CONTROLES

        private void OnTicketSeleccionado(object sender, EventArgs e)
        {
            OnSeleccionaTicket?.Invoke(sender, e);
        }

        private void tmrCargarColaTicketsEspera_Tick(object sender, EventArgs e)
        {
            CargarListaTicketsEnEspera();
        }

        #endregion
    }
}
