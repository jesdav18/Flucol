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
            this.dsDashboards1 = new Administracion.DataSet.dsDashboards();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.navegacionDasboards = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageDashBoardsPrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlContenedorDashboardsPrincipal = new System.Windows.Forms.Panel();
            this.pnlDashboardsInferior = new System.Windows.Forms.Panel();
            this.ctlEmpleadoConMasTicketsAtendidos1 = new Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos();
            this.pnlDashboardsMedio = new System.Windows.Forms.Panel();
            this.pnlDashboardsSuperior = new System.Windows.Forms.Panel();
            this.ctlTicketsAtendidos_TicketsNoAtendidos1 = new Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos();
            this.pnlEncabezadoDashboards = new System.Windows.Forms.Panel();
            this.lblTituloDashboardPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.page2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.bgCargaDashboards = new System.ComponentModel.BackgroundWorker();
            this.ssmDashboardsPrincipal = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Administracion.Pantallas.frmEsperaDashboards), true, true, typeof(System.Windows.Forms.UserControl));
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegacionDasboards)).BeginInit();
            this.navegacionDasboards.SuspendLayout();
            this.pageDashBoardsPrincipal.SuspendLayout();
            this.pnlContenedorDashboardsPrincipal.SuspendLayout();
            this.pnlDashboardsInferior.SuspendLayout();
            this.pnlDashboardsSuperior.SuspendLayout();
            this.pnlEncabezadoDashboards.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsDashboards1
            // 
            this.dsDashboards1.DataSetName = "dsDashboards";
            this.dsDashboards1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pictureEdit1);
            this.pnlOpciones.Controls.Add(this.flowLayoutPanel1);
            this.pnlOpciones.Controls.Add(this.panel2);
            this.pnlOpciones.Controls.Add(this.panel1);
            this.pnlOpciones.Controls.Add(this.picLogoCliente);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(5, 5);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(92, 453);
            this.pnlOpciones.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::Administracion.Properties.Resources.iconDashboard_64;
            this.pictureEdit1.Location = new System.Drawing.Point(21, 93);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(52, 53);
            this.pictureEdit1.TabIndex = 4;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(21, 360);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(73, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 360);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 4);
            this.panel1.TabIndex = 1;
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
            this.picLogoCliente.Size = new System.Drawing.Size(92, 89);
            this.picLogoCliente.TabIndex = 0;
            // 
            // navegacionDasboards
            // 
            this.navegacionDasboards.Controls.Add(this.pageDashBoardsPrincipal);
            this.navegacionDasboards.Controls.Add(this.page2);
            this.navegacionDasboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegacionDasboards.Location = new System.Drawing.Point(97, 5);
            this.navegacionDasboards.Name = "navegacionDasboards";
            this.navegacionDasboards.Padding = new System.Windows.Forms.Padding(5);
            this.navegacionDasboards.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageDashBoardsPrincipal,
            this.page2});
            this.navegacionDasboards.SelectedPage = this.pageDashBoardsPrincipal;
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
            this.pnlDashboardsInferior.Location = new System.Drawing.Point(0, 446);
            this.pnlDashboardsInferior.Name = "pnlDashboardsInferior";
            this.pnlDashboardsInferior.Size = new System.Drawing.Size(642, 0);
            this.pnlDashboardsInferior.TabIndex = 2;
            // 
            // ctlEmpleadoConMasTicketsAtendidos1
            // 
            this.ctlEmpleadoConMasTicketsAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlEmpleadoConMasTicketsAtendidos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctlEmpleadoConMasTicketsAtendidos1.Location = new System.Drawing.Point(0, 0);
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
            this.pnlDashboardsMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardsMedio.Location = new System.Drawing.Point(0, 236);
            this.pnlDashboardsMedio.Name = "pnlDashboardsMedio";
            this.pnlDashboardsMedio.Size = new System.Drawing.Size(642, 210);
            this.pnlDashboardsMedio.TabIndex = 1;
            // 
            // pnlDashboardsSuperior
            // 
            this.pnlDashboardsSuperior.Controls.Add(this.ctlTicketsAtendidos_TicketsNoAtendidos1);
            this.pnlDashboardsSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardsSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardsSuperior.Name = "pnlDashboardsSuperior";
            this.pnlDashboardsSuperior.Size = new System.Drawing.Size(642, 236);
            this.pnlDashboardsSuperior.TabIndex = 0;
            // 
            // ctlTicketsAtendidos_TicketsNoAtendidos1
            // 
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Location = new System.Drawing.Point(0, 0);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Name = "ctlTicketsAtendidos_TicketsNoAtendidos1";
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Agencia_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Cliente_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Conexion = null;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Size = new System.Drawing.Size(268, 236);
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
            // bgCargaDashboards
            // 
            this.bgCargaDashboards.WorkerSupportsCancellation = true;
            this.bgCargaDashboards.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgCargaDashboards_DoWork);
            // 
            // ssmDashboardsPrincipal
            // 
            this.ssmDashboardsPrincipal.ClosingDelay = 500;
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
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegacionDasboards)).EndInit();
            this.navegacionDasboards.ResumeLayout(false);
            this.pageDashBoardsPrincipal.ResumeLayout(false);
            this.pnlContenedorDashboardsPrincipal.ResumeLayout(false);
            this.pnlDashboardsInferior.ResumeLayout(false);
            this.pnlDashboardsSuperior.ResumeLayout(false);
            this.pnlEncabezadoDashboards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet.dsDashboards dsDashboards1;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picLogoCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
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
    }
}
