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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlPromedioAtencion1 = new Core.Controles.Dashboards.ctlPromedioAtencion();
            this.ctlEmpleadoConMasTicketsAtendidos1 = new Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos();
            this.ctlPromedioEspera1 = new Core.Controles.Dashboards.ctlPromedioEspera();
            this.pnlEncabezadoDashboards = new System.Windows.Forms.Panel();
            this.lblTituloDashboardPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.page2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ssmDashboardsPrincipal = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Administracion.Pantallas.frmEsperaDashboards), true, true, typeof(System.Windows.Forms.UserControl));
            this.ctlTicketsAtendidos_TicketsNoAtendidos1 = new Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos();
            this.ctlVisitasSegunPrioridadServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunPrioridadServicio();
            this.ctlTraficoClientes1 = new Core.Controles.Dashboards.ctlTraficoClientes();
            this.ctlVisitasSegunCanalDeServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunCanalDeServicio();
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
            this.pnlContenedorDashboardsPrincipal.Controls.Add(this.flowLayoutPanel2);
            this.pnlContenedorDashboardsPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDashboardsPrincipal.Location = new System.Drawing.Point(0, 31);
            this.pnlContenedorDashboardsPrincipal.Name = "pnlContenedorDashboardsPrincipal";
            this.pnlContenedorDashboardsPrincipal.Size = new System.Drawing.Size(642, 613);
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
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(642, 613);
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
            this.page2.Size = new System.Drawing.Size(642, 644);
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
    }
}
