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

namespace Administracion.Pantallas
{
    public partial class frmAdministracion : DevExpress.XtraEditors.XtraForm
    {
        public frmAdministracion()
        {
            InitializeComponent();
            
        }
        public void ConstruirAdministracion(PgSqlConnection pConexion,int pID_Cliente_Servicio)
        {
            ctlDashBoards1.ConstruirControl(pConexion, pID_Cliente_Servicio);
        }
    }
}