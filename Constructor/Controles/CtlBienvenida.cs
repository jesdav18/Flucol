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

namespace Constructor.Controles
{
    public partial class CtlBienvenida : UserControl
    {

        #region INICIALIZADOR
        public CtlBienvenida()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        private int Pro_Segundos { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        const int MAXIMO_SEGUNDOS_BIENVENIDA = 3;

        #endregion

        #region EVENTOS

        public event EventHandler OnTerminaTiempoBienvenida;

        #endregion

        #region FUNCIONES

        public void ConstruirControl()
        {
            Pro_Segundos = 0;
            tmrBienvenida.Start();

        }

        #endregion

        #region EVENTOS CONTROLES

        private void tmrBienvenida_Tick(object sender, EventArgs e)
        {
            if (Pro_Segundos <= MAXIMO_SEGUNDOS_BIENVENIDA)
            {
                Pro_Segundos++;
            }
            else
            {
                tmrBienvenida.Stop();
                OnTerminaTiempoBienvenida?.Invoke(sender, e);

            }

        }

        #endregion

    }
}
