using Devart.Data.PostgreSql;


namespace Administracion.Pantallas
{
    public partial class frmAdministracion : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR
    
        public frmAdministracion()
        {
            InitializeComponent();
            
        }

        #endregion

        #region FUNCIONES

        public void ConstruirAdministracion(PgSqlConnection pConexion,
                                            int pID_Cliente_Servicio,                                           
                                            string pUsuario)
        {
            ctlAdministracionPrincipal1.ConstruirControl(pConexion,
                                                         pID_Cliente_Servicio,
                                                         pUsuario
                                                        );
        }


        #endregion

    }
}