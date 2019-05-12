using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Devart.Data.PostgreSql;

namespace Operaciones.Pantallas
{
    public partial class frmSupervisor : DevExpress.XtraEditors.XtraForm
    {
        public frmSupervisor(PgSqlConnection pConexion,
                            int pID_AgenciaServicio,
                            int pID_ClienteServicio)
        {
            InitializeComponent();

            ctlOperacionesSupervisor1.ConstruirControl(pConexion,
                                                       pID_AgenciaServicio,
                                                       pID_ClienteServicio);

        }
    }
}