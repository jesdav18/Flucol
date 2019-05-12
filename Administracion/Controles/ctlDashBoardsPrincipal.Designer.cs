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
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.cmdDashboards = new DevExpress.XtraEditors.PictureEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.navegacionDasboards = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageDashBoardsPrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlContenedorDashboardsPrincipal = new System.Windows.Forms.Panel();
            this.pnlDashboardsInferior = new System.Windows.Forms.Panel();
            this.ctlEmpleadoConMasTicketsAtendidos1 = new Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos();
            this.pnlDashboardsMedio = new System.Windows.Forms.Panel();
            this.ctlVisitasSegunPrioridadServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunPrioridadServicio();
            this.pnlDashboardsSuperior = new System.Windows.Forms.Panel();
            this.ctlTicketsAtendidos_TicketsNoAtendidos1 = new Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos();
            this.pnlEncabezadoDashboards = new System.Windows.Forms.Panel();
            this.lblTituloDashboardPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.page2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.bgCargaDashboards = new System.ComponentModel.BackgroundWorker();
            this.ssmDashboardsPrincipal = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Administracion.Pantallas.frmEsperaDashboards), true, true, typeof(System.Windows.Forms.UserControl));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlOpciones.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegacionDasboards)).BeginInit();
            this.navegacionDasboards.SuspendLayout();
            this.pageDashBoardsPrincipal.SuspendLayout();
            this.pnlContenedorDashboardsPrincipal.SuspendLayout();
            this.pnlDashboardsInferior.SuspendLayout();
            this.pnlDashboardsMedio.SuspendLayout();
            this.pnlDashboardsSuperior.SuspendLayout();
            this.pnlEncabezadoDashboards.SuspendLayout();
            this.pageInicial.SuspendLayout();
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
            this.pnlOpciones.Size = new System.Drawing.Size(92, 453);
            this.pnlOpciones.TabIndex = 1;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.simpleButton1);
            this.pnlBotones.Controls.Add(this.cmdDashboards);
            this.pnlBotones.Controls.Add(this.flowLayoutPanel1);
            this.pnlBotones.Controls.Add(this.panel2);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(0, 89);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(90, 362);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(21, 360);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(69, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 360);
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
            this.navegacionDasboards.Controls.Add(this.page2);
            this.navegacionDasboards.Controls.Add(this.pageInicial);
            this.navegacionDasboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegacionDasboards.Location = new System.Drawing.Point(97, 5);
            this.navegacionDasboards.Name = "navegacionDasboards";
            this.navegacionDasboards.Padding = new System.Windows.Forms.Padding(5);
            this.navegacionDasboards.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageDashBoardsPrincipal,
            this.page2,
            this.pageInicial});
            this.navegacionDasboards.SelectedPage = this.pageInicial;
            this.navegacionDasboards.Size = new System.Drawing.Size(642, 453);
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
            this.pageDashBoardsPrincipal.Size = new System.Drawing.Size(642, 453);
            // 
            // pnlContenedorDashboardsPrincipal
            // 
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.pnlDashboardsInferior);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.pnlDashboardsMedio);
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.pnlDashboardsSuperior);
            this.pnlContenedorDashboardsPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDashboardsPrincipal.Location = new System.Drawing.Point(0, 31);
            this.pnlContenedorDashboardsPrincipal.Name = "pnlContenedorDashboardsPrincipal";
            this.pnlContenedorDashboardsPrincipal.Size = new System.Drawing.Size(642, 422);
            this.pnlContenedorDashboardsPrincipal.TabIndex = 1;
            // 
            // pnlDashboardsInferior
            // 
            this.pnlDashboardsInferior.Controls.Add(this.ctlEmpleadoConMasTicketsAtendidos1);
            this.pnlDashboardsInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardsInferior.Location = new System.Drawing.Point(0, 323);
            this.pnlDashboardsInferior.Name = "pnlDashboardsInferior";
            this.pnlDashboardsInferior.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDashboardsInferior.Size = new System.Drawing.Size(642, 99);
            this.pnlDashboardsInferior.TabIndex = 2;
            // 
            // ctlEmpleadoConMasTicketsAtendidos1
            // 
            this.ctlEmpleadoConMasTicketsAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlEmpleadoConMasTicketsAtendidos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlEmpleadoConMasTicketsAtendidos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctlEmpleadoConMasTicketsAtendidos1.Location = new System.Drawing.Point(5, 5);
            this.ctlEmpleadoConMasTicketsAtendidos1.MaximumSize = new System.Drawing.Size(190, 225);
            this.ctlEmpleadoConMasTicketsAtendidos1.MinimumSize = new System.Drawing.Size(190, 225);
            this.ctlEmpleadoConMasTicketsAtendidos1.Name = "ctlEmpleadoConMasTicketsAtendidos1";
            this.ctlEmpleadoConMasTicketsAtendidos1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_Conexion = null;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_ID_Agencia_Servicio = 0;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_ID_Cliente_Servicio = 0;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_TituloDashBoard = null;
            this.ctlEmpleadoConMasTicketsAtendidos1.Size = new System.Drawing.Size(190, 225);
            this.ctlEmpleadoConMasTicketsAtendidos1.TabIndex = 0;
            // 
            // pnlDashboardsMedio
            // 
            this.pnlDashboardsMedio.Controls.Add(this.ctlVisitasSegunPrioridadServicio1);
            this.pnlDashboardsMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardsMedio.Location = new System.Drawing.Point(0, 162);
            this.pnlDashboardsMedio.Name = "pnlDashboardsMedio";
            this.pnlDashboardsMedio.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDashboardsMedio.Size = new System.Drawing.Size(642, 161);
            this.pnlDashboardsMedio.TabIndex = 1;
            // 
            // ctlVisitasSegunPrioridadServicio1
            // 
            this.ctlVisitasSegunPrioridadServicio1.BackColor = System.Drawing.Color.White;
            this.ctlVisitasSegunPrioridadServicio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlVisitasSegunPrioridadServicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlVisitasSegunPrioridadServicio1.Location = new System.Drawing.Point(5, 5);
            this.ctlVisitasSegunPrioridadServicio1.MaximumSize = new System.Drawing.Size(370, 150);
            this.ctlVisitasSegunPrioridadServicio1.MinimumSize = new System.Drawing.Size(370, 150);
            this.ctlVisitasSegunPrioridadServicio1.Name = "ctlVisitasSegunPrioridadServicio1";
            this.ctlVisitasSegunPrioridadServicio1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlVisitasSegunPrioridadServicio1.Pro_Conexion = null;
            this.ctlVisitasSegunPrioridadServicio1.Pro_ID_Agencia_Servicio = 0;
            this.ctlVisitasSegunPrioridadServicio1.Pro_ID_Cliente_Servicio = 0;
            this.ctlVisitasSegunPrioridadServicio1.Size = new System.Drawing.Size(370, 150);
            this.ctlVisitasSegunPrioridadServicio1.TabIndex = 0;
            // 
            // pnlDashboardsSuperior
            // 
            this.pnlDashboardsSuperior.Controls.Add(this.ctlTicketsAtendidos_TicketsNoAtendidos1);
            this.pnlDashboardsSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardsSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardsSuperior.Name = "pnlDashboardsSuperior";
            this.pnlDashboardsSuperior.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDashboardsSuperior.Size = new System.Drawing.Size(642, 162);
            this.pnlDashboardsSuperior.TabIndex = 0;
            // 
            // ctlTicketsAtendidos_TicketsNoAtendidos1
            // 
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Location = new System.Drawing.Point(5, 5);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.MaximumSize = new System.Drawing.Size(370, 150);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.MinimumSize = new System.Drawing.Size(370, 150);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Name = "ctlTicketsAtendidos_TicketsNoAtendidos1";
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Agencia_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Cliente_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Conexion = null;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Size = new System.Drawing.Size(370, 150);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.TabIndex = 0;
            // 
            // pnlEncabezadoDashboards
            // 
            this.pnlEncabezadoDashboards.Controls.Add(this.lblTituloDashboardPrincipal);
            this.pnlEncabezadoDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoDashboards.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoDashboards.Name = "pnlEncabezadoDashboards";
            this.pnlEncabezadoDashboards.Size = new System.Drawing.Size(642, 31);
            this.pnlEncabezadoDashboards.TabIndex = 0;
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
            this.lblTituloDashboardPrincipal.Size = new System.Drawing.Size(642, 31);
            this.lblTituloDashboardPrincipal.TabIndex = 1;
            this.lblTituloDashboardPrincipal.Text = "DASHBOARDS PRINCIPAL";
            // 
            // page2
            // 
            this.page2.Caption = "page2";
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(642, 453);
            // 
            // pageInicial
            // 
            this.pageInicial.Caption = "pageInicial";
            this.pageInicial.Controls.Add(this.listBox1);
            this.pageInicial.Name = "pageInicial";
            this.pageInicial.Size = new System.Drawing.Size(642, 453);
            // 
            // bgCargaDashboards
            // 
            this.bgCargaDashboards.WorkerSupportsCancellation = true;
            this.bgCargaDashboards.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgCargaDashboards_DoWork);
            // 
            // ssmDashboardsPrincipal
            // 
            this.ssmDashboardsPrincipal.ClosingDelay = 500;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(27, 59);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 121);
            this.listBox1.TabIndex = 0;
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
            this.Size = new System.Drawing.Size(744, 463);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegacionDasboards)).EndInit();
            this.navegacionDasboards.ResumeLayout(false);
            this.pageDashBoardsPrincipal.ResumeLayout(false);
            this.pnlContenedorDashboardsPrincipal.ResumeLayout(false);
            this.pnlDashboardsInferior.ResumeLayout(false);
            this.pnlDashboardsMedio.ResumeLayout(false);
            this.pnlDashboardsSuperior.ResumeLayout(false);
            this.pnlEncabezadoDashboards.ResumeLayout(false);
            this.pageInicial.ResumeLayout(false);
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
        private DevExpress.XtraBars.Navigation.NavigationPage page2;
        private System.Windows.Forms.Panel pnlContenedorDashboardsPrincipal;
        private System.Windows.Forms.Panel pnlDashboardsInferior;
        private System.Windows.Forms.Panel pnlDashboardsMedio;
        private System.Windows.Forms.Panel pnlDashboardsSuperior;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboardPrincipal;

        private System.ComponentModel.BackgroundWorker bgCargaDashboards;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmDashboardsPrincipal;
        private Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos ctlEmpleadoConMasTicketsAtendidos1;
        private Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos ctlTicketsAtendidos_TicketsNoAtendidos1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageInicial;
        private System.Windows.Forms.Panel pnlBotones;
        private Core.Controles.Dashboards.ctlVisitasSegunPrioridadServicio ctlVisitasSegunPrioridadServicio1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
