
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Operaciones.Pantallas
{
    public partial class frmOperaciones : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR

        public frmOperaciones(PgSqlConnection pConexion,
                              int pID_Agencia_Servicio,
                              int pID_Cliente_Servicio,
                              int pID_Nivel_Acceso,
                              string pNombre_Empleado,
                              string pUsuario,
                              string pDescripcionNivelAcceso,
                              string pCargo,
                              string pCodigoEmpleado)
        {
            InitializeComponent();
            ctlOperacional1.ConstruirControl(pConexion, 
                                             pID_Agencia_Servicio, 
                                             pID_Cliente_Servicio,
                                             pID_Nivel_Acceso,
                                             pDescripcionNivelAcceso,
                                             pCargo,
                                             pNombre_Empleado,
                                             pUsuario,
                                             pCodigoEmpleado
                                             );
            
           
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

        #endregion

        #region EVENTOS CONTROLES

        private void frmOperaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ctlOperacional1.PresionaF1_IniciarTicket(sender);
            }
            if (e.KeyCode == Keys.F2)
            {
                ctlOperacional1.PresionaF2_CerrarTicket(sender);
            }
            if (e.KeyCode == Keys.F5)
            {
                ctlOperacional1.PresionaF5_LlamarCliente(sender);
            }
            if (e.KeyCode == Keys.F6)
            {
                ctlOperacional1.PresionarF6_MarcarClienteNoRespondio(sender);
            }

        }

        #endregion

    }
}