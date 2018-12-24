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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR

        public frmLogin(PgSqlConnection pConexion, int pSucursal, int pCliente)
        {
            InitializeComponent();
            ctlLoginOperacional1.ConstruirControl(pConexion, pSucursal, pCliente);
            this.Hide();
        }


        #endregion

        #region PROPIEDADES


        #endregion

        #region FUNCIONES



        #endregion

        #region EVENTOS CONTROLES

        private void ctlLoginOperacional1_OnUsuarioLogueado(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}