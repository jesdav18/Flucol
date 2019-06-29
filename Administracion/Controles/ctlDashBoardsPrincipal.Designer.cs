namespace Administracion.Controles
{
    partial class ctlDashBoardsPrincipal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.cmdDashboards = new DevExpress.XtraEditors.PictureEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.navegacionDasboards = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageDashBoardsPrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlContenedorDashboardsPrincipal = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlPromedioAtencion1 = new Core.Controles.Dashboards.ctlPromedioAtencion();
            this.ctlEmpleadoConMasTicketsAtendidos1 = new Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos();
            this.ctlPromedioEspera1 = new Core.Controles.Dashboards.ctlPromedioEspera();
            this.ctlTicketsAtendidos_TicketsNoAtendidos1 = new Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos();
            this.ctlVisitasSegunPrioridadServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunPrioridadServicio();
            this.ctlTraficoClientes1 = new Core.Controles.Dashboards.ctlTraficoClientes();
            this.ctlVisitasSegunCanalDeServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunCanalDeServicio();
            this.pnlEncabezadoDashboards = new System.Windows.Forms.Panel();
            this.picAtrasDashboardPrincipal = new DevExpress.XtraEditors.PictureEdit();
            this.lblTituloDashboardPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.pageAgenciasDisponibles = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlAgenciasDisponiblesParaDashboards1 = new Administracion.Controles.ctlAgenciasDisponiblesParaDashboards();
            this.pageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ssmDashboardsPrincipal = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Administracion.Pantallas.frmEsperaDashboards), true, true, typeof(System.Windows.Forms.UserControl));
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.dateHasta = new DevExpress.XtraEditors.DateEdit();
            this.cmdBusqueda = new DevExpress.XtraEditors.PictureEdit();
            this.pnlOpciones.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegacionDasboards)).BeginInit();
            this.navegacionDasboards.SuspendLayout();
            this.pageDashBoardsPrincipal.SuspendLayout();
            this.pnlContenedorDashboardsPrincipal.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlEncabezadoDashboards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtrasDashboardPrincipal.Properties)).BeginInit();
            this.pageAgenciasDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBusqueda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpciones.Controls.Add(this.pnlBotones);
            this.pnlOpciones.Controls.Add(this.picLogoCliente);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(5, 5);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(92, 644);
            this.pnlOpciones.TabIndex = 1;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.cmdDashboards);
            this.pnlBotones.Controls.Add(this.flowLayoutPanel1);
            this.pnlBotones.Controls.Add(this.panel2);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(0, 89);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(90, 553);
            this.pnlBotones.TabIndex = 5;
            // 
            // cmdDashboards
            // 
            this.cmdDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdDashboards.EditValue = global::Administracion.Properties.Resources.iconDashboard_64;
            this.cmdDashboards.Location = new System.Drawing.Point(21, 0);
            this.cmdDashboards.Name = "cmdDashboards";
            this.cmdDashboards.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdDashboards.Properties.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cmdDashboards.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdDashboards.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdDashboards.Size = new System.Drawing.Size(48, 53);
            this.cmdDashboards.TabIndex = 4;
            this.cmdDashboards.ToolTip = "Dashboards";
            this.cmdDashboards.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdDashboards.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdDashboards.ToolTipTitle = "FLUCOL";
            this.cmdDashboards.Click += new System.EventHandler(this.cmdDashboards_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(21, 551);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(69, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 551);
            this.panel2.TabIndex = 2;
            // 
            // picLogoCliente
            // 
            this.picLogoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoCliente.Location = new System.Drawing.Point(0, 0);
            this.picLogoCliente.Name = "picLogoCliente";
            this.picLogoCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoCliente.Properties.NullText = " ";
            this.picLogoCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogoCliente.Size = new System.Drawing.Size(90, 89);
            this.picLogoCliente.TabIndex = 0;
            // 
            // navegacionDasboards
            // 
            this.navegacionDasboards.Controls.Add(this.pageDashBoardsPrincipal);
            this.navegacionDasboards.Controls.Add(this.pageAgenciasDisponibles);
            this.navegacionDasboards.Controls.Add(this.pageInicial);
            this.navegacionDasboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegacionDasboards.Location = new System.Drawing.Point(97, 5);
            this.navegacionDasboards.Name = "navegacionDasboards";
            this.navegacionDasboards.Padding = new System.Windows.Forms.Padding(5);
            this.navegacionDasboards.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageDashBoardsPrincipal,
            this.pageAgenciasDisponibles,
            this.pageInicial});
            this.navegacionDasboards.SelectedPage = this.pageInicial;
            this.navegacionDasboards.Size = new System.Drawing.Size(642, 644);
            this.navegacionDasboards.TabIndex = 2;
            this.navegacionDasboards.Text = "navigationFrame1";
            this.navegacionDasboards.TransitionAnimationProperties.FrameCount = 500;
            this.navegacionDasboards.TransitionAnimationProperties.FrameInterval = 500;
            this.navegacionDasboards.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // pageDashBoardsPrincipal
            // 
            this.pageDashBoardsPrincipal.Caption = "pageDashBoardsPrincipal";
            this.pageDashBoardsPrincipal.Controls.Add(this.pnlContenedorDashboardsPrincipal);
            this.pageDashBoardsPrincipal.Controls.Add(this.pnlEncabezadoDashboards);
            this.pageDashBoardsPrincipal.Name = "pageDashBoardsPrincipal";
            this.pageDashBoardsPrincipal.Size = new System.Drawing.Size(642, 644);
            // 
            // pnlContenedorDashboardsPrincipal
            // 
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.cmdBusqueda);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.dateHasta);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.dtDesde);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.labelControl2);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.labelControl1);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.flowLayoutPanel2);
            this.pnlContenedorDashboardsPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDashboardsPrincipal.Location = new System.Drawing.Point(0, 45);
            this.pnlContenedorDashboardsPrincipal.Name = "pnlContenedorDashboardsPrincipal";
            this.pnlContenedorDashboardsPrincipal.Size = new System.Drawing.Size(642, 599);
            this.pnlContenedorDashboardsPrincipal.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ctlPromedioAtencion1);
            this.flowLayoutPanel2.Controls.Add(this.ctlEmpleadoConMasTicketsAtendidos1);
            this.flowLayoutPanel2.Controls.Add(this.ctlPromedioEspera1);
            this.flowLayoutPanel2.Controls.Add(this.ctlTicketsAtendidos_TicketsNoAtendidos1);
            this.flowLayoutPanel2.Controls.Add(this.ctlVisitasSegunPrioridadServicio1);
            this.flowLayoutPanel2.Controls.Add(this.ctlTraficoClientes1);
            this.flowLayoutPanel2.Controls.Add(this.ctlVisitasSegunCanalDeServicio1);
            this.flowLayoutPanel2.Controls.Add(this.schedulerControl1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(642, 480);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // ctlPromedioAtencion1
            // 
            this.ctlPromedioAtencion1.BackColor = System.Drawing.Color.White;
            this.ctlPromedioAtencion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlPromedioAtencion1.Location = new System.Drawing.Point(3, 3);
            this.ctlPromedioAtencion1.MaximumSize = new System.Drawing.Size(190, 225);
            this.ctlPromedioAtencion1.MinimumSize = new System.Drawing.Size(190, 225);
            this.ctlPromedioAtencion1.Name = "ctlPromedioAtencion1";
            this.ctlPromedioAtencion1.Pro_Conexion = null;
            this.ctlPromedioAtencion1.Pro_ID_AgenciaServicio = 0;
            this.ctlPromedioAtencion1.Pro_ID_ClienteServicio = 0;
            this.ctlPromedioAtencion1.Size = new System.Drawing.Size(190, 225);
            this.ctlPromedioAtencion1.TabIndex = 6;
            // 
            // ctlEmpleadoConMasTicketsAtendidos1
            // 
            this.ctlEmpleadoConMasTicketsAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlEmpleadoConMasTicketsAtendidos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlEmpleadoConMasTicketsAtendidos1.Location = new System.Drawing.Point(199, 3);
            this.ctlEmpleadoConMasTicketsAtendidos1.MaximumSize = new System.Drawing.Size(190, 225);
            this.ctlEmpleadoConMasTicketsAtendidos1.MinimumSize = new System.Drawing.Size(190, 225);
            this.ctlEmpleadoConMasTicketsAtendidos1.Name = "ctlEmpleadoConMasTicketsAtendidos1";
            this.ctlEmpleadoConMasTicketsAtendidos1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_Conexion = null;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_ID_Agencia_Servicio = 0;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_ID_Cliente_Servicio = 0;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_TituloDashBoard = null;
            this.ctlEmpleadoConMasTicketsAtendidos1.Size = new System.Drawing.Size(190, 225);
            this.ctlEmpleadoConMasTicketsAtendidos1.TabIndex = 5;
            // 
            // ctlPromedioEspera1
            // 
            this.ctlPromedioEspera1.BackColor = System.Drawing.Color.White;
            this.ctlPromedioEspera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlPromedioEspera1.Location = new System.Drawing.Point(395, 3);
            this.ctlPromedioEspera1.MaximumSize = new System.Drawing.Size(190, 225);
            this.ctlPromedioEspera1.MinimumSize = new System.Drawing.Size(190, 225);
            this.ctlPromedioEspera1.Name = "ctlPromedioEspera1";
            this.ctlPromedioEspera1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlPromedioEspera1.Pro_Conexion = null;
            this.ctlPromedioEspera1.Pro_ID_AgenciaServicio = 0;
            this.ctlPromedioEspera1.Pro_ID_ClienteServicio = 0;
            this.ctlPromedioEspera1.Size = new System.Drawing.Size(190, 225);
            this.ctlPromedioEspera1.TabIndex = 8;
            // 
            // ctlTicketsAtendidos_TicketsNoAtendidos1
            // 
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Location = new System.Drawing.Point(3, 234);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.MaximumSize = new System.Drawing.Size(385, 150);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.MinimumSize = new System.Drawing.Size(385, 150);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Name = "ctlTicketsAtendidos_TicketsNoAtendidos1";
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Agencia_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Cliente_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Conexion = null;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Size = new System.Drawing.Size(385, 150);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.TabIndex = 10;
            // 
            // ctlVisitasSegunPrioridadServicio1
            // 
            this.ctlVisitasSegunPrioridadServicio1.BackColor = System.Drawing.Color.White;
            this.ctlVisitasSegunPrioridadServicio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlVisitasSegunPrioridadServicio1.Location = new System.Drawing.Point(3, 390);
            this.ctlVisitasSegunPrioridadServicio1.MaximumSize = new System.Drawing.Size(385, 150);
            this.ctlVisitasSegunPrioridadServicio1.MinimumSize = new System.Drawing.Size(385, 150);
            this.ctlVisitasSegunPrioridadServicio1.Name = "ctlVisitasSegunPrioridadServicio1";
            this.ctlVisitasSegunPrioridadServicio1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlVisitasSegunPrioridadServicio1.Pro_Conexion = null;
            this.ctlVisitasSegunPrioridadServicio1.Pro_ID_Agencia_Servicio = 0;
            this.ctlVisitasSegunPrioridadServicio1.Pro_ID_Cliente_Servicio = 0;
            this.ctlVisitasSegunPrioridadServicio1.Size = new System.Drawing.Size(385, 150);
            this.ctlVisitasSegunPrioridadServicio1.TabIndex = 11;
            // 
            // ctlTraficoClientes1
            // 
            this.ctlTraficoClientes1.BackColor = System.Drawing.Color.White;
            this.ctlTraficoClientes1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlTraficoClientes1.Location = new System.Drawing.Point(3, 546);
            this.ctlTraficoClientes1.MaximumSize = new System.Drawing.Size(385, 312);
            this.ctlTraficoClientes1.MinimumSize = new System.Drawing.Size(385, 312);
            this.ctlTraficoClientes1.Name = "ctlTraficoClientes1";
            this.ctlTraficoClientes1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTraficoClientes1.Pro_Conexion = null;
            this.ctlTraficoClientes1.Pro_ID_AgenciaServicio = 0;
            this.ctlTraficoClientes1.Pro_ID_ClienteServicio = 0;
            this.ctlTraficoClientes1.Size = new System.Drawing.Size(385, 312);
            this.ctlTraficoClientes1.TabIndex = 12;
            // 
            // ctlVisitasSegunCanalDeServicio1
            // 
            this.ctlVisitasSegunCanalDeServicio1.BackColor = System.Drawing.Color.White;
            this.ctlVisitasSegunCanalDeServicio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlVisitasSegunCanalDeServicio1.Location = new System.Drawing.Point(3, 864);
            this.ctlVisitasSegunCanalDeServicio1.MaximumSize = new System.Drawing.Size(385, 312);
            this.ctlVisitasSegunCanalDeServicio1.MinimumSize = new System.Drawing.Size(385, 312);
            this.ctlVisitasSegunCanalDeServicio1.Name = "ctlVisitasSegunCanalDeServicio1";
            this.ctlVisitasSegunCanalDeServicio1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlVisitasSegunCanalDeServicio1.Pro_Conexion = null;
            this.ctlVisitasSegunCanalDeServicio1.Pro_ID_Agencia_Servicio = 0;
            this.ctlVisitasSegunCanalDeServicio1.Pro_ID_Cliente_Servicio = 0;
            this.ctlVisitasSegunCanalDeServicio1.Size = new System.Drawing.Size(385, 312);
            this.ctlVisitasSegunCanalDeServicio1.TabIndex = 13;
            // 
            // pnlEncabezadoDashboards
            // 
            this.pnlEncabezadoDashboards.Controls.Add(this.picAtrasDashboardPrincipal);
            this.pnlEncabezadoDashboards.Controls.Add(this.lblTituloDashboardPrincipal);
            this.pnlEncabezadoDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoDashboards.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoDashboards.Name = "pnlEncabezadoDashboards";
            this.pnlEncabezadoDashboards.Size = new System.Drawing.Size(642, 45);
            this.pnlEncabezadoDashboards.TabIndex = 0;
            // 
            // picAtrasDashboardPrincipal
            // 
            this.picAtrasDashboardPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAtrasDashboardPrincipal.EditValue = global::Administracion.Properties.Resources.icon_atras_64;
            this.picAtrasDashboardPrincipal.Location = new System.Drawing.Point(0, 0);
            this.picAtrasDashboardPrincipal.Name = "picAtrasDashboardPrincipal";
            this.picAtrasDashboardPrincipal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAtrasDashboardPrincipal.Properties.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.picAtrasDashboardPrincipal.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAtrasDashboardPrincipal.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAtrasDashboardPrincipal.Size = new System.Drawing.Size(57, 45);
            this.picAtrasDashboardPrincipal.TabIndex = 5;
            this.picAtrasDashboardPrincipal.ToolTip = "Dashboards";
            this.picAtrasDashboardPrincipal.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picAtrasDashboardPrincipal.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picAtrasDashboardPrincipal.ToolTipTitle = "FLUCOL";
            this.picAtrasDashboardPrincipal.Click += new System.EventHandler(this.picAtrasDashboardPrincipal_Click);
            // 
            // lblTituloDashboardPrincipal
            // 
            this.lblTituloDashboardPrincipal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDashboardPrincipal.Appearance.Options.UseFont = true;
            this.lblTituloDashboardPrincipal.Appearance.Options.UseTextOptions = true;
            this.lblTituloDashboardPrincipal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloDashboardPrincipal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTituloDashboardPrincipal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloDashboardPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloDashboardPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lblTituloDashboardPrincipal.Name = "lblTituloDashboardPrincipal";
            this.lblTituloDashboardPrincipal.Size = new System.Drawing.Size(642, 45);
            this.lblTituloDashboardPrincipal.TabIndex = 1;
            this.lblTituloDashboardPrincipal.Text = "DASHBOARDS PRINCIPAL";
            // 
            // pageAgenciasDisponibles
            // 
            this.pageAgenciasDisponibles.Caption = "pageAgenciasDisponibles";
            this.pageAgenciasDisponibles.Controls.Add(this.ctlAgenciasDisponiblesParaDashboards1);
            this.pageAgenciasDisponibles.Name = "pageAgenciasDisponibles";
            this.pageAgenciasDisponibles.Size = new System.Drawing.Size(642, 644);
            // 
            // ctlAgenciasDisponiblesParaDashboards1
            // 
            this.ctlAgenciasDisponiblesParaDashboards1.BackColor = System.Drawing.Color.White;
            this.ctlAgenciasDisponiblesParaDashboards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlAgenciasDisponiblesParaDashboards1.Location = new System.Drawing.Point(0, 0);
            this.ctlAgenciasDisponiblesParaDashboards1.Name = "ctlAgenciasDisponiblesParaDashboards1";
            this.ctlAgenciasDisponiblesParaDashboards1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlAgenciasDisponiblesParaDashboards1.Pro_Conexion = null;
            this.ctlAgenciasDisponiblesParaDashboards1.Pro_ID_ClienteServicio = 0;
            this.ctlAgenciasDisponiblesParaDashboards1.Size = new System.Drawing.Size(642, 644);
            this.ctlAgenciasDisponiblesParaDashboards1.TabIndex = 0;
            // 
            // pageInicial
            // 
            this.pageInicial.Caption = "pageInicial";
            this.pageInicial.Name = "pageInicial";
            this.pageInicial.Size = new System.Drawing.Size(642, 644);
            // 
            // ssmDashboardsPrincipal
            // 
            this.ssmDashboardsPrincipal.ClosingDelay = 500;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Location = new System.Drawing.Point(3, 1182);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(400, 200);
            this.schedulerControl1.Start = new System.DateTime(2019, 6, 23, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 14;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(24, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 26);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "DESDE:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(24, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 26);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "HASTA:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(111, 57);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(196, 20);
            this.dtDesde.TabIndex = 8;
            // 
            // dateHasta
            // 
            this.dateHasta.EditValue = null;
            this.dateHasta.Location = new System.Drawing.Point(111, 93);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Size = new System.Drawing.Size(196, 20);
            this.dateHasta.TabIndex = 9;
            // 
            // cmdBusqueda
            // 
            this.cmdBusqueda.EditValue = global::Administracion.Properties.Resources.iconBusqueda_32;
            this.cmdBusqueda.Location = new System.Drawing.Point(395, 32);
            this.cmdBusqueda.Name = "cmdBusqueda";
            this.cmdBusqueda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdBusqueda.Properties.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cmdBusqueda.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdBusqueda.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdBusqueda.Size = new System.Drawing.Size(57, 45);
            this.cmdBusqueda.TabIndex = 10;
            this.cmdBusqueda.ToolTip = "Dashboards";
            this.cmdBusqueda.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdBusqueda.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdBusqueda.ToolTipTitle = "FLUCOL";
            this.cmdBusqueda.Click += new System.EventHandler(this.cmdBusqueda_Click);
            // 
            // ctlDashBoardsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navegacionDasboards);
            this.Controls.Add(this.pnlOpciones);
            this.Name = "ctlDashBoardsPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(744, 654);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegacionDasboards)).EndInit();
            this.navegacionDasboards.ResumeLayout(false);
            this.pageDashBoardsPrincipal.ResumeLayout(false);
            this.pnlContenedorDashboardsPrincipal.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlEncabezadoDashboards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtrasDashboardPrincipal.Properties)).EndInit();
            this.pageAgenciasDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBusqueda.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel pnlOpciones;
        private DevExpress.XtraEditors.PictureEdit picLogoCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit cmdDashboards;
        private DevExpress.XtraBars.Navigation.NavigationFrame navegacionDasboards;
        private DevExpress.XtraBars.Navigation.NavigationPage pageDashBoardsPrincipal;
        private System.Windows.Forms.Panel pnlEncabezadoDashboards;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAgenciasDisponibles;
        private System.Windows.Forms.Panel pnlContenedorDashboardsPrincipal;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboardPrincipal;      
        private DevExpress.XtraBars.Navigation.NavigationPage pageInicial;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Core.Controles.Dashboards.ctlPromedioAtencion ctlPromedioAtencion1;
        private Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos ctlEmpleadoConMasTicketsAtendidos1;
        private Core.Controles.Dashboards.ctlPromedioEspera ctlPromedioEspera1;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmDashboardsPrincipal;
        private Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos ctlTicketsAtendidos_TicketsNoAtendidos1;
        private Core.Controles.Dashboards.ctlVisitasSegunPrioridadServicio ctlVisitasSegunPrioridadServicio1;
        private Core.Controles.Dashboards.ctlTraficoClientes ctlTraficoClientes1;
        private Core.Controles.Dashboards.ctlVisitasSegunCanalDeServicio ctlVisitasSegunCanalDeServicio1;
        private ctlAgenciasDisponiblesParaDashboards ctlAgenciasDisponiblesParaDashboards1;
        private DevExpress.XtraEditors.PictureEdit picAtrasDashboardPrincipal;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraEditors.PictureEdit cmdBusqueda;
        private DevExpress.XtraEditors.DateEdit dateHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
