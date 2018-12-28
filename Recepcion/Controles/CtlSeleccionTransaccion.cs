using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using DevExpress.XtraCharts.Native;
using Core.Clases;
using Core.Reportes;

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
        public int Pro_Sucursal { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Tipo_Ticket_Servicio { get; set; }
        public int Pro_ID_Operacion_Servicio { get; set; }
        public string Pro_Ticket_Generado { get; set; }

        #endregion

        #region VARIABLES GLOBALES / CONSTANTES

        const int TIEMPO_MAXIMO_VISUALIZAR_TICKET = 100;
        int v_SegundosVisualizacionTicket = 0;

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

        public void ConstruirControl(PgSqlConnection pConexion,int pSucursal, int pID_ClienteServicio)
        {
            Pro_Conexion = pConexion;
            Pro_Sucursal = pSucursal;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
                 
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
            rptTicket rpt = new rptTicket();

            rpt.CargarDatos(Pro_Ticket_Generado);
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
            v_SegundosVisualizacionTicket = 0;
            tmrTiempoVisualizacionTicket.Start();
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
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
                pgComando.Parameters.Add("p_id_tipo_ticket_servicio", PgSqlType.Int).Value = Pro_ID_Tipo_Ticket_Servicio;
                pgComando.Parameters.Add("p_id_operacion_servicio", PgSqlType.Int).Value = Pro_ID_Operacion_Servicio;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    Pro_Ticket_Generado = pgDr.GetString("numero_ticket");
                }

                pgTrans.Commit();

                


            }
            catch (Exception Exc)
            {
                pgTrans.Rollback();
                Pro_Ticket_Generado = null;
                MessageBox.Show(Exc.Message,"FLUCOL");
                
            }
        }

        private void RegistrarInicioTiempoEspera()
        {
            Core.Clases.Tiempos objTemporizador = new Core.Clases.Tiempos();
            objTemporizador.Registrar_Inicio_Tiempo_Espera(DateTime.Now, Pro_Conexion);
            objTemporizador = null;
        }

        #endregion

        #region EVENTOS CONTROLES   

        private void cmdServicioAlCliente_Click(object sender, EventArgs e)
        {
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaiones_Servicio.SERVICIO_AL_CLIENTE;
            GenerarTicket();
            IrAPaginaTicket();
        }

        private void cmdTransacciones_Click(object sender, EventArgs e)
        {
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaiones_Servicio.OPERACIONES_CAJA;
            GenerarTicket();
            IrAPaginaTicket();
        }

       
        private void cmdTerceraEdad_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.TERCERA_EDAD;
        }

        private void lblTerceraEdad_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.TERCERA_EDAD;
        }

        private void cmdCondicionesEspeciales_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.ATENCION_ESPECIAL;
        }

        private void cmdCondicionesEspeciales01_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.ATENCION_ESPECIAL;
        }

        private void lblCondicionesEspeciales_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.ATENCION_ESPECIAL;
        }

        private void cmdEsperaGeneral_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.FILA_GENERAL;
        }

        private void lblEsperaGeneral_Click(object sender, EventArgs e)
        {
            IrAPaginaTransacciones();
            Pro_ID_Tipo_Ticket_Servicio = (int)Tipo_Ticket_Servicio.FILA_GENERAL;
        }

        private void cmdIrAPrioridades_Click(object sender, EventArgs e)
        {
            IrAPaginaPrioridades();
        }

     
        private void lblTransacciones_Click(object sender, EventArgs e)
        {
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaiones_Servicio.OPERACIONES_CAJA;
            GenerarTicket();
            IrAPaginaTicket();
        }

        private void lblServicioAlCliente_Click(object sender, EventArgs e)
        {
            Pro_ID_Operacion_Servicio = (int)Tipo_Operaiones_Servicio.SERVICIO_AL_CLIENTE;
            GenerarTicket();
            IrAPaginaTicket();
        }

        private void tmrTiempoVisualizacionTicket_Tick(object sender, EventArgs e)
        {
            if (v_SegundosVisualizacionTicket <= TIEMPO_MAXIMO_VISUALIZAR_TICKET)
            {
                v_SegundosVisualizacionTicket++;
            }
            else
            {
                tmrTiempoVisualizacionTicket.Stop();
                IrAPaginaPrioridades();
            }
        }

        #endregion
    }
}
