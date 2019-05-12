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
    public partial class ctlOperacionesSupervisor : UserControl
    {
        public ctlOperacionesSupervisor()
        {
            InitializeComponent();
        }

        private void cmdAsignaciones_Click(object sender, EventArgs e)
        {
            NavigationAsignacionesTraslados.SelectedPage = pageAsignaciones;
        }

        private void cmdTraslados_Click(object sender, EventArgs e)
        {
            NavigationAsignacionesTraslados.SelectedPage = pageTraslados;

        }

        private void cmdAsignarPosiciones_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageAsignacionesTraslados;
        }
    }
}
