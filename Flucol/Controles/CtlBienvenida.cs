using System;
using System.Windows.Forms;


namespace Flucol.Controles
{
    public partial class CtlBienvenida : UserControl
    {

        #region INICIALIZADOR
        public CtlBienvenida()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

       

        #endregion

        #region VARIABLES GLOBALES

        

        #endregion

        #region EVENTOS

        public event EventHandler OnTerminaTiempoBienvenida;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(int pModulo)
        {
            
            tmrBienvenida.Start();
            System.Reflection.Assembly v_ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo obj_archivo_informacion = new System.IO.FileInfo(v_ensamblado.Location);
            DateTime v_ultima_actualizacion = obj_archivo_informacion.LastWriteTime;
            lblUltimaActualizacion.Text = "" + v_ultima_actualizacion.ToShortDateString() + ", " + v_ultima_actualizacion.ToShortTimeString();

            switch (pModulo)
            {
                case 1:
                    lblModulo.Text = "RECEPCIÓN";
                    break;
                case 2:
                    lblModulo.Text = "VISUALIZACIÓN";
                    break;
                case 3:
                    lblModulo.Text = "OPERACIONES";
                    break;
            }


            obj_archivo_informacion = null;
            v_ensamblado = null;
            
        }

        #endregion

        #region EVENTOS CONTROLES

        private void tmrBienvenida_Tick(object sender, EventArgs e)
        {
            tmrBienvenida.Stop();
            OnTerminaTiempoBienvenida?.Invoke(sender, e);   
        }

        #endregion

    }
}
