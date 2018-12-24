using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones.Controles
{
    public partial class ctlAdministracionPosiciones : UserControl
    {
        public ctlAdministracionPosiciones()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Location = new Point(e.X, e.Y);
        }
    }
}
