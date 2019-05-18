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

namespace Core.Controles.Dashboards
{
    public partial class ctlPromedioAtencion : UserControl
    {

        #region INICIALIZADOR

        public ctlPromedioAtencion()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES


        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;

            
        }



        #endregion
    }
}
