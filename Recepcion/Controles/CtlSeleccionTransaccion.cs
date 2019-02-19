﻿using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Reportes;
using DevExpress.XtraReports.UI;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace Recepcion.Controles
{
    public partial class CtlSeleccionTransaccion : UserControl
    {

        #region INICIALIZADOR
  
        public CtlSeleccionTransaccion()
        {
            InitializeComponent();
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

        #endregion

        #region VARIABLES GLOBALES / CONSTANTES / OBJETOS

        rptTicket rpt = null;

        #endregion

        #region EVENTOS

        #endregion

        #region ENUMERACIONES

        enum Tipo_Ticket_Servicio
        {
            TERCERA_EDAD = 1,
            ATENCION_ESPECIAL = 2,
            FILA_GENERAL = 4
        }

        enum Tipo_Operaiones_Servicio
        {
            OPERACIONES_CAJA = 1,
            SERVICIO_AL_CLIENTE = 2
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,int pSucursal, int pID_ClienteServicio,string pNombreAgenciaServicio)
        {
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pSucursal;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
            Pro_NombreAgenciaServicio = pNombreAgenciaServicio;
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
            rpt.CargarDatos(Pro_Ticket_Generado);
            rpt.pic_Logo.Image = Image.FromFile(Path.Combine(Application.StartupPath, "logo_cliente.png"));
            rpt.lblNombreAgencia.Text = Pro_NombreAgenciaServicio;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
            tmrTiempoVisualizacionTicket.Start();

            try
            {
               
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
            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();
            try
            {
                string sentencia = @"SELECT * FROM configuracion.sp_proc_genera_correlativos_ticket (
                                                                                                      :p_id_agencia_servicio,
                                                                                                      :p_id_cliente_servicio,
                                                                                                      :p_id_tipo_ticket_servicio,
                                                                                                      :p_id_operacion_servicio
                                                                                                    );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
                pgComando.Parameters.Add("p_id_tipo_ticket_servicio", PgSqlType.Int).Value = Pro_ID_Tipo_Ticket_Servicio;
                pgComando.Parameters.Add("p_id_operacion_servicio", PgSqlType.Int).Value = Pro_ID_Operacion_Servicio;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    Pro_Ticket_Generado = pgDr.GetString("numero_ticket");
                }

               
                pgTrans.Commit();

                pgDr.Close();
                pgComando.Dispose();


            }
            catch (Exception Exc)
            {
                pgTrans.Rollback();
                Pro_Ticket_Generado = null;
                MessageBox.Show(Exc.Message,"FLUCOL");
                
            }
        }

        private void ReinicioImagenesIcono()
        {
            cmdCondicionesEspeciales.Image = Properties.Resources.iconAncianos;
            cmdCondicionesEspeciales.Image = Properties.Resources.iconEmbarazada;
            cmdCondicionesEspeciales01.Image = Properties.Resources.iconDiscapacidad;
            cmdEsperaGeneral.Image = Properties.Resources.iconEsperaGeneral;
            cmdTransacciones.Image = Properties.Resources.iconTransaccionesCaja;
            cmdServicioAlCliente.Image = Properties.Resources.iconServicioAlCliente;
            cmdIrAPrioridades.Image = Properties.Resources.iconIrAtras;
        }

        private void RegistrarInicioTiempoEspera()
        {
           
        }

        #endregion

        #region EVENTOS CONTROLES   

        private void cmdServicioAlCliente_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdServicioAlCliente.Image = Properties.Resources.iconServicioAlClienteVerde;
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaiones_Servicio.SERVICIO_AL_CLIENTE;
            GenerarTicket();
            IrAPaginaTicket();
        }

        private void cmdTransacciones_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdTransacciones.Image = Properties.Resources.IconTransaccionesCajaVerde;
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaiones_Servicio.OPERACIONES_CAJA;
            GenerarTicket();
            IrAPaginaTicket();
        }

       
        private void cmdTerceraEdad_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdTerceraEdad.Image = Properties.Resources.iconAncianosVerde;
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.TERCERA_EDAD;
        }

    
        private void cmdCondicionesEspeciales_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdCondicionesEspeciales.Image = Properties.Resources.iconEmbarazadaVerde;
            cmdCondicionesEspeciales01.Image = Properties.Resources.iconDiscapacidadVerde;
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.ATENCION_ESPECIAL;
        }

        private void cmdCondicionesEspeciales01_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdCondicionesEspeciales.Image = Properties.Resources.iconEmbarazadaVerde;
            cmdCondicionesEspeciales01.Image = Properties.Resources.iconDiscapacidadVerde;
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.ATENCION_ESPECIAL;
        }

        private void cmdEsperaGeneral_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdEsperaGeneral.Image = Properties.Resources.iconEsperaGeneralVerde;
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.FILA_GENERAL;
        }

       
        private void cmdIrAPrioridades_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdIrAPrioridades.Image = Properties.Resources.iconIrAtrasVerde;
            IrAPaginaPrioridades();
        }

     
        private void tmrTiempoVisualizacionTicket_Tick(object sender, EventArgs e)
        {
           
            tmrTiempoVisualizacionTicket.Stop();
            IrAPaginaPrioridades();
            rpt.Dispose();
        }

        #endregion

    }
}
