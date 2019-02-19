using System;


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

        public void CargarDatos(string pNumeroTicket)
        {
            Pro_NumeroTicket = pNumeroTicket;
           

            if (!string.IsNullOrEmpty(Pro_NumeroTicket) )
            {
                lblNumeroTicket.Text = Pro_NumeroTicket;
                lblHora.Text = string.Format("{0:hh:mm tt}", DateTime.Now);
                lblFecha.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            }

            
        }

        #endregion

    }


}
