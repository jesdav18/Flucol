using System;
using Devart.Data.PostgreSql;

namespace Operaciones.Pantallas
{
    public partial class frmSupervisor : DevExpress.XtraEditors.XtraForm
    {
        public frmSupervisor(PgSqlConnection pConexion,
                            int pID_AgenciaServicio,
                            int pID_ClienteServicio,
                            string pUsuario,
                            string pNombreAgencia,
                            string pNombreEmpleado)
        {
            InitializeComponent();

            ctlOperacionesSupervisor1.OnCerrarSesionSupervisor += OnCerrarSesionSupervisor;

            ctlOperacionesSupervisor1.ConstruirControl(pConexion,
                                                       pID_AgenciaServicio,
                                                       pID_ClienteServicio,
                                                       pUsuario,
                                                       pNombreAgencia,
                                                       pNombreEmpleado);

        }

        public event EventHandler OnCierraSesionSupervisor;

        private void OnCerrarSesionSupervisor(object sender, EventArgs e)
        {
            OnCierraSesionSupervisor?.Invoke(sender, e);
        }
    }
}