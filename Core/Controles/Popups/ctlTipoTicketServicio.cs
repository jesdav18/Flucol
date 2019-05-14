using System;
using System.Windows.Forms;
using Core.DataSets;
using Devart.Data.PostgreSql;

namespace Core.Controles.Popups
{
    public partial class ctlTipoTicketServicio : UserControl
    {
        #region INICIALIZADOR

        public ctlTipoTicketServicio()
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
            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM area_servicio.ft_view_tipo_tickets_servicio();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsCore1.dtTipoTickets.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCore1.dtTipoTickets);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salio mal en la carga de Tipos de Ticket. " + Exc.Message);
            }
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnSeleccionaTipoTicketServicio;

        #endregion

        #region EVENTO CONTROLES

        private void chkSeleccionar_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var v_fila = (dsCore.dtTipoTicketsRow) gvTipoTicketServicio.GetFocusedDataRow();

            if (v_fila != null)
            {
                foreach (dsCore.dtTipoTicketsRow iterador in dsCore1.dtTipoTickets)
                {
                    if (v_fila.id_tipo_ticket_servicio != iterador.id_tipo_ticket_servicio)
                    {
                        iterador.seleccionar_tipo_ticket = false;
                    }
                }

                OnSeleccionaTipoTicketServicio?.Invoke(v_fila, e);
            }
        }

        #endregion
    }
}
