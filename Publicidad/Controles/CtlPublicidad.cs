
using System.Configuration;
using System.Windows.Forms;
using Devart.Data.PostgreSql;



namespace Publicidad.Controles
{
    public partial class CtlPublicidad : DevExpress.XtraEditors.XtraUserControl
    {

        #region INICIALIZADOR

        public CtlPublicidad()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;

            axWindowsMediaPlayer1.Width = 10 * 2;
            axWindowsMediaPlayer1.Height = 10 * 2;







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
            try
            {
                if (!bgReproductor.IsBusy)
                {
                    bgReproductor.RunWorkerAsync();
                }
            }
            catch (System.Exception Exc)
            {
                MessageBox.Show("Algo salió mal en la carga de Multimedia. " + Exc.Message);
            }
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_Cliente { get; set; }
        public int Pro_Sucursal { get; set; }



        #endregion

        #region EVENTOS CONTROLES
       
        private void bgReproductor_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            axWindowsMediaPlayer1.URL = ConfigurationSettings.AppSettings["RUTA_PUBLICIDAD"];
            

            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        #endregion
    }
}
