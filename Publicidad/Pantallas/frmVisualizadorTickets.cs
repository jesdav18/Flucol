
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
        public int Pro_ID_Agencia_Servicio { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirFormulario(PgSqlConnection pConexion, int pID_Agencia_Servicio, int pID_Cliente_Servicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Agencia_Servicio = pID_Agencia_Servicio;
            Pro_ID_Cliente_Servicio = pID_Cliente_Servicio;

            ctlTicketsPosiciones1.ConstruirControl(Pro_Conexion, Pro_ID_Agencia_Servicio, Pro_ID_Cliente_Servicio);
            ctlPublicidad1.ConstruirControl(Pro_Conexion, Pro_ID_Agencia_Servicio, Pro_ID_Cliente_Servicio);

        }


        #endregion

        
    }
}