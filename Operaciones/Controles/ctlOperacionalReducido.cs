using System;
using System.Windows.Forms;

namespace Operaciones.Controles
{
    public partial class ctlOperacionalReducido : UserControl
    {
        #region INICIALIZADOR

        public ctlOperacionalReducido()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        public event EventHandler On_LlamarCliente;
        public event EventHandler On_IniciarTicket;
        public event EventHandler On_CerrarTicket;
        public event EventHandler On_RellamarTicket;
        public event EventHandler On_ClienteNoAtendioLlamado;

        #endregion

        #region FUNCIONES CONTROLES

        private void cmdLlamarCliente_Click(object sender, EventArgs e)
        {
            On_LlamarCliente?.Invoke(sender,e);
        }

        private void cmdIniciarTicket_Click(object sender, EventArgs e)
        {
            On_IniciarTicket?.Invoke(sender,e);
        }

        private void cmdCerrarTicket_Click(object sender, EventArgs e)
        {
            On_CerrarTicket?.Invoke(sender,e);
        }

        private void cmdRellamar_Click(object sender, EventArgs e)
        {
            On_RellamarTicket?.Invoke(sender,e);
        }

        private void cmdClienteNoAtendioLlamado_Click(object sender, EventArgs e)
        {
            On_ClienteNoAtendioLlamado?.Invoke(sender,e);
        }

        #endregion
    }
}
