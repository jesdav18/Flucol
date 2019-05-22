using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;


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
        public bool Pro_CargarLista { get; set; }

        #endregion

        #region FUNCIONES

        public async void  ConstruirControl(PgSqlConnection pConexion,
                                     int p_ID_AgenciaServicio,
                                     int p_ID_ClienteServicio,
                                     string p_usuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = p_ID_AgenciaServicio;
            Pro_ID_ClienteServicio = p_ID_ClienteServicio;
            Pro_Usuario = p_usuario;
            Pro_CargarLista = true;

           await this.ListaTicketsAsincrono();
        }

        private void ValidarConexion()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                try
                {
                    Pro_Conexion.Open();
                }
                catch (Exception Exc)
                {
                    DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                    v_depurador.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ValidarConexion()");
                    v_depurador = null;

                    PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
                    v_conexion.Password = Pro_Conexion.Password;
                    Pro_Conexion = v_conexion;
                    Pro_Conexion.Open();
                    v_conexion = null;
                }
            }
        }

        private async Task ListaTicketsAsincrono()
        {
            while (true)
            {
                ValidarConexion();

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
                    DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                    v_depurador.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ListaTicketsAsincrono()");
                    v_depurador = null;

                    MessageBox.Show("ALGO SALIÓ MAL EN EL MOMENTO DE CARGAR LA LISTA DE TICKETS EN ESPERA.", "FLUCOL");
                }

                await Task.Delay(200);
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

        #endregion
    }
}
