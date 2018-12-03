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

namespace Publicidad.Pantallas
{
    public partial class frmVisualizadorTickets : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR

        public frmVisualizadorTickets()
        {
            InitializeComponent();
            
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirFormulario(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }
        }

        #endregion


    }
}