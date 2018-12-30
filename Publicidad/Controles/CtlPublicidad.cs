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

namespace Publicidad.Controles
{
    public partial class CtlPublicidad : UserControl
    {

        #region INICIALIZADOR
       
        public CtlPublicidad()
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Agencia_Servicio, int pID_Cliente_Servicio)
        {
            Pro_Conexion = pConexion;
            Pro_Sucursal = pID_Agencia_Servicio;
            Pro_Cliente = pID_Cliente_Servicio;
            CargarMultimedia();

        }

        private void CargarMultimedia()
        {
           
            vlcControl1.SetMedia(new System.IO.FileInfo(@"C:\Users\Bart\Downloads\bongo.mp4"));
            vlcControl1.Play();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_Cliente { get; set; }
        public int Pro_Sucursal { get; set; }

        #endregion


    }
}
