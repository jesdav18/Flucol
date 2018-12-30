﻿using System;
using System.Configuration.Assemblies;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Speech.Synthesis;
using Core.Reportes;
using DevExpress.XtraReports.UI;
using Recepcion.Pantallas;
using Publicidad.Pantallas;
using Operaciones.Pantallas;
using Devart.Data.PostgreSql;
using Flucol.Controles;

namespace Flucol.Pantallas
{
    public partial class frmConstructor : DevExpress.XtraEditors.XtraForm
    {

        #region INICIALIZADOR
  
        public frmConstructor()
        {
            InitializeComponent();
            ctlBienvenida= new CtlBienvenida();
            pgConexion.Open();

        }

        #endregion

        #region PROPIEDADES

        public int Pro_Modulo {
            get
            {
                return Convert.ToInt32 (ConfigurationSettings.AppSettings["MODULO"]);
            }
        }

        public int Pro_Sucursal {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["AGENCIA"]);
            }
        }

        public int Pro_ID_ClienteServicio {
            get
            {
                return Convert.ToInt32(ConfigurationSettings.AppSettings["CLIENTE"]);
            }

        }
        
        
        #endregion

        #region ENUMERACIONES

        public enum PERFILES
        {
            RECEPCION = 1,
            VISUALIZADOR = 2,
            OPERACIONES = 3,
            SUPERVISOR = 4
        }



        #endregion

        #region FUNCIONES

        private void ReestablecerFormConstructor()
        {
            try
            {
               
                this.Hide();
                ctlBienvenida.Dispose();
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;             
                this.Show();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIÓ MAL EN EL MOMENTO DE REESTABLECER FORMULARIO CONSTRUCTOR: " + Exc.Message, "FLUCOL");
            }
        }

        private void Construir_Control_SeleccionTransaccion() { 


            
            frmRecepcion f_Recepcion = new frmRecepcion();
            f_Recepcion.MdiParent = this;
            f_Recepcion.ConstruirFormulario(pgConexion,Pro_Sucursal,Pro_ID_ClienteServicio);
            f_Recepcion.Show();
            ReestablecerFormConstructor();

        }

      
        private void Construir_Control_Publicidad()
        {
            frmVisualizadorTickets f_Visualizador = new frmVisualizadorTickets();
            f_Visualizador.MdiParent = this;
            f_Visualizador.ConstruirFormulario(pgConexion,Pro_Sucursal,Pro_ID_ClienteServicio);
            f_Visualizador.Show();
            ReestablecerFormConstructor();
            
        }

        private void Construir_Acceso_Para_Operaciones()
        {
            frmLogin f_LoginOperaciones = new frmLogin(pgConexion,Pro_Sucursal,Pro_ID_ClienteServicio);
            f_LoginOperaciones.ShowDialog();
            this.Hide();
        }





        #endregion

        #region VARIABLES GLOBALES

        PgSqlConnection pgConexion = new PgSqlConnection("User Id=admin; Password=Soporte+23;Host=localhost;Port=5433;Database=flucol_db;Persist Security Info=False");
        CtlBienvenida ctlBienvenida;

        #endregion

        #region EVENTOS CONTROLES

        private void ctlBienvenida_OnTerminaTiempoBienvenida(object sender, EventArgs e)
        {

            
            switch (Pro_Modulo)
            {
                case 1:
                    Construir_Control_SeleccionTransaccion();
                    break;
                case 2:
                    Construir_Control_Publicidad();
                    break;
                case 3:
                    Construir_Acceso_Para_Operaciones();
                    break;
            }

           
        }

        private void f_Recepcion_OnCerrarFormulario(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConstructor_Shown(object sender, EventArgs e)
        {
            
        }

    
        private void frmConstructor_Load(object sender, EventArgs e)
        {
           
           
            ctlBienvenida.OnTerminaTiempoBienvenida += new EventHandler(ctlBienvenida_OnTerminaTiempoBienvenida);
            this.Controls.Add(ctlBienvenida);
            ctlBienvenida.Dock = DockStyle.Fill;
            ctlBienvenida.ConstruirControl();
            
        }

        #endregion
    }
}