using System;
using DevExpress.XtraWaitForm;

namespace Recepcion.Controles
{
    public partial class frmCargandoConexion : WaitForm
    {
        public frmCargandoConexion()
        {
            InitializeComponent();
          
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
          
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
           
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}