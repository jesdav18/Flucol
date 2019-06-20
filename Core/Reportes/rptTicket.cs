using Core.Clases;
using Devart.Data.PostgreSql;



namespace Core.Reportes
{
    public partial class rptTicket : DevExpress.XtraReports.UI.XtraReport
    {

        #region INICIALIZADOR
      
        public rptTicket()
        {
            InitializeComponent();
          
        }

        #endregion

        #region PROPIEDADES

        public string Pro_NumeroTicket { get; set; }

        #endregion

        #region FUNCIONES

        public void CargarDatos(string pNumeroTicket,PgSqlConnection pConexion)
        {
            Pro_NumeroTicket = pNumeroTicket;
            Utilidades cl_util = new Utilidades();

            if (!string.IsNullOrEmpty(Pro_NumeroTicket) )
            {
                lblNumeroTicket.Text = Pro_NumeroTicket;
                lblHora.Text = string.Format("{0:hh:mm tt}", cl_util.ObtenerHoraServidor(pConexion));
                lblFecha.Text = string.Format("{0:dd/MM/yyyy}",cl_util.ObtenerHoraServidor(pConexion));
            }

            cl_util = null;
        }

        #endregion

    }
}
