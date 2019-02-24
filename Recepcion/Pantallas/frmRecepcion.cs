
using System.Data;
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
        public int Pro_ID_AgenciaServicio { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public string Pro_NombreAgenciaServicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirFormulario(PgSqlConnection pConexion, 
                                        int pAgenciaServicio,
                                        int pID_ClienteServicio, 
                                        string pNombreAgenciaServicio,
                                        string pIP_Host)
        {
            Pro_ID_AgenciaServicio = pAgenciaServicio;
            Pro_Conexion = pConexion;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_NombreAgenciaServicio = pNombreAgenciaServicio;
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            ctlSeleccionTransaccion1.ConstruirControl(Pro_Conexion,
                                                      Pro_ID_AgenciaServicio,
                                                      Pro_ID_ClienteServicio,
                                                      Pro_NombreAgenciaServicio,
                                                      pIP_Host);
        }

        #endregion     
    }
}