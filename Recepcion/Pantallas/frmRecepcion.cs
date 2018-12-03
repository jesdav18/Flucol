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

namespace Recepcion.Pantallas
{
    public partial class frmRecepcion : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR

        public frmRecepcion() 
        {
            InitializeComponent();
                    
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_Sucursal { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirFormulario(PgSqlConnection pConexion, int pSucursal,int pID_ClienteServicio)
        {
            Pro_Sucursal = pSucursal;
            Pro_Conexion = pConexion;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            ctlSeleccionTransaccion1.ConstruirControl(Pro_Conexion,Pro_Sucursal,Pro_ID_ClienteServicio);
        }

        

        #endregion
    }
}