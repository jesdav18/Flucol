﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Devart.Data.PostgreSql;

namespace Flucol.Reportes
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
            }

            
        }

        #endregion

    }


}
