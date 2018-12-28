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

        public void ConstruirControl()
        {
            
            tmrBienvenida.Start();
            System.Reflection.Assembly v_ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo obj_archivo_informacion = new System.IO.FileInfo(v_ensamblado.Location);
            DateTime v_ultima_actualizacion = obj_archivo_informacion.LastWriteTime;
            lblUltimaActualizacion.Text = "" + v_ultima_actualizacion.ToShortDateString() + ", " + v_ultima_actualizacion.ToShortTimeString();

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
