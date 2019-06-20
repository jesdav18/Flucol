using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Reportes;
using DevExpress.XtraReports.UI;
using System.Configuration;
using System.Drawing;
using Core.Clases;
using System.Data;

namespace Recepcion.Controles
{
    public partial class CtlSeleccionTransaccion : UserControl
    {

        #region INICIALIZADOR
  
        public CtlSeleccionTransaccion()
        {
            InitializeComponent();
           // DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Tipo_Ticket_Servicio { get; set; }
        public int Pro_ID_Operacion_Servicio { get; set; }
        public string Pro_Ticket_Generado { get; set; }
        public string Pro_NombreAgenciaServicio { get; set; }
        public string Pro_IP_Host { get; set; }

        #endregion

        #region VARIABLES GLOBALES / CONSTANTES / OBJETOS

        rptTicket rpt = null;

        #endregion

        #region ENUMERACIONES

        enum Tipo_Ticket_Servicio
        {
            TERCERA_EDAD = 1,
            ATENCION_ESPECIAL = 2,
            FILA_GENERAL = 4
        }

        enum Tipo_Operaciones_Servicio
        {
            OPERACIONES_CAJA = 1,
            SERVICIO_AL_CLIENTE = 2,
            NEGOCIOS = 3
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pSucursal, 
                                     int pID_ClienteServicio,
                                     string pNombreAgenciaServicio,
                                     string pIP_Host)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pSucursal;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
            Pro_NombreAgenciaServicio = pNombreAgenciaServicio;
            Pro_IP_Host = pIP_Host;
            lblAgencia.Text = pNombreAgenciaServicio;
            pic_LogoInstitucion.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);
        }

        private void IrAPaginaTransacciones()
        {
            navFrameMenuInicial.SelectedPage = navPageTipoTransaccion;
        }

        private void IrAPaginaPrioridades()
        {
            navFrameMenuInicial.SelectedPage = NavPagePrioridades;
        }
      
        private void IrAPaginaTicket()
        {
            navFrameMenuInicial.SelectedPage = navPageTicket;
             
            rpt = new rptTicket();
            rpt.CargarDatos(Pro_Ticket_Generado,Pro_Conexion);
            rpt.pic_Logo.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);
            rpt.lblNombreAgencia.Text = Pro_NombreAgenciaServicio;
            

            try
            {

                splashScreenManager1.ShowWaitForm();
                rpt.CreateDocument();
                documentViewer1.DocumentSource = rpt;

                splashScreenManager1.CloseWaitForm();


                tmrTiempoVisualizacionTicket.Start();
                ReportPrintTool v_print_tool = new ReportPrintTool(rpt);
                v_print_tool.Print(ConfigurationSettings.AppSettings["IMPRESORA_TICKETS"]);

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }  
        }

        
        private void GenerarTicket()
        {

            ValidarConexion();

            splashScreenManager1.ShowWaitForm();
            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();

            string sentencia = @"SELECT * FROM configuracion.sp_proc_genera_correlativos_ticket (
                                                                                                :p_id_agencia_servicio,
                                                                                                :p_id_cliente_servicio,
                                                                                                :p_id_tipo_ticket_servicio,
                                                                                                :p_id_operacion_servicio,
                                                                                                :p_direccion_ip
                                                                                            );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
            pgComando.Parameters.Add("p_id_tipo_ticket_servicio", PgSqlType.Int).Value = Pro_ID_Tipo_Ticket_Servicio;
            pgComando.Parameters.Add("p_id_operacion_servicio", PgSqlType.Int).Value = Pro_ID_Operacion_Servicio;
            pgComando.Parameters.Add("p_direccion_ip", PgSqlType.VarChar).Value = Pro_IP_Host;

            try
            {
               
                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    Pro_Ticket_Generado = pgDr.GetString("numero_ticket");
                }

               
                pgTrans.Commit();
                pgDr.Close();
                pgComando.Dispose();
                sentencia = null;

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception Exc)
            {
                splashScreenManager1.CloseWaitForm();
                pgTrans.Rollback();
                Pro_Ticket_Generado = null;
                MessageBox.Show(Exc.Message,"FLUCOL");                
            }          
        }

        private void ReinicioImagenesIcono()
        {

            if(splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }

            splashScreenManager1.ShowWaitForm();

            cmdTerceraEdad.Image = Properties.Resources.iconAncianos;
            cmdCondicionesEspeciales.Image = Properties.Resources.iconEmbarazada;
            cmdCondicionesEspeciales01.Image = Properties.Resources.iconDiscapacidad;
            cmdEsperaGeneral.Image = Properties.Resources.iconEsperaGeneral;
            cmdTransacciones.Image = Properties.Resources.iconTransaccionesCaja;
            cmdServicioAlCliente.Image = Properties.Resources.iconServicioAlCliente;
            cmdIrSeleccionTransacciones.Image = Properties.Resources.iconIrAtras;
            cmdNegocios.Image = Properties.Resources.icon_Negocios_Negro;

            splashScreenManager1.CloseWaitForm();
        }

        private void ValidarConexion()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                try
                {
                    splashScreenManager2.ShowWaitForm();

                    Pro_Conexion.Open();

                    splashScreenManager2.CloseWaitForm();
                }
                catch (Exception Exc)
                {
                    splashScreenManager2.ShowWaitForm();
                    DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                    v_depurador.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ValidarConexion()");
                    v_depurador = null;

                    PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
                    v_conexion.Password = Pro_Conexion.Password;
                    Pro_Conexion = v_conexion;
                    Pro_Conexion.Open();
                    v_conexion = null;

                    splashScreenManager2.CloseWaitForm();
                }
            }
        }

        #endregion

        #region EVENTOS CONTROLES   

        private void cmdServicioAlCliente_Click(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

          
            ReinicioImagenesIcono();
            cmdServicioAlCliente.Image = Properties.Resources.iconServicioAlClienteVerde;
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaciones_Servicio.SERVICIO_AL_CLIENTE;
            IrAPaginaPrioridades();

            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }       
        }

        private void cmdTransacciones_Click(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

           
            ReinicioImagenesIcono();
            cmdTransacciones.Image = Properties.Resources.IconTransaccionesCajaVerde;
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaciones_Servicio.OPERACIONES_CAJA;
            IrAPaginaPrioridades();splashScreenManager1.ShowWaitForm();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

       
        private void cmdTerceraEdad_Click(object sender, EventArgs e)
        {

            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }
          
            ReinicioImagenesIcono();
            cmdTerceraEdad.Image = Properties.Resources.iconAncianosVerde;         
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.TERCERA_EDAD;
            GenerarTicket();
            IrAPaginaTicket();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }


        private void cmdCondicionesEspeciales_Click(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

           
            ReinicioImagenesIcono();
            cmdCondicionesEspeciales.Image = Properties.Resources.iconEmbarazadaVerde;
            cmdCondicionesEspeciales01.Image = Properties.Resources.iconDiscapacidadVerde;
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.ATENCION_ESPECIAL;
            GenerarTicket();
            IrAPaginaTicket();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void cmdEsperaGeneral_Click(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }
          
            ReinicioImagenesIcono();
            cmdEsperaGeneral.Image = Properties.Resources.iconEsperaGeneralVerde;
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.FILA_GENERAL;
            GenerarTicket();
            IrAPaginaTicket();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void tmrTiempoVisualizacionTicket_Tick(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

          
            tmrTiempoVisualizacionTicket.Stop();
            ReinicioImagenesIcono();
            IrAPaginaTransacciones();
            rpt.Dispose();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void cmdNegocios_Click(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

         
            ReinicioImagenesIcono();
            cmdNegocios.Image = Properties.Resources.icon_Negocios_Verde;
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaciones_Servicio.NEGOCIOS;
            IrAPaginaPrioridades();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void cmdIrSeleccionTransacciones_Click(object sender, EventArgs e)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

          
            ReinicioImagenesIcono();
            cmdIrSeleccionTransacciones.Image = Properties.Resources.iconIrAtrasVerde;
            IrAPaginaTransacciones();
            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        #endregion

    }
}
