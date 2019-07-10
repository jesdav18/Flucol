namespace Core.Controles.Dashboards
{
    partial class ctlContenedorDashboards
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTiuloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.lblIntervalo = new DevExpress.XtraEditors.LabelControl();
            this.cmdAbrirFiltros = new DevExpress.XtraEditors.PictureEdit();
            this.cmdIrAtras = new DevExpress.XtraEditors.PictureEdit();
            this.flpPanelDashboards = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlPromedioEspera1 = new Core.Controles.Dashboards.ctlPromedioEspera();
            this.ctlEmpleadoConMasTicketsAtendidos1 = new Core.Controles.Dashboards.ctlEmpleadoConMasTicketsAtendidos();
            this.ctlPromedioAtencion1 = new Core.Controles.Dashboards.ctlPromedioAtencion();
            this.ctlTraficoClientes1 = new Core.Controles.Dashboards.ctlTraficoClientes();
            this.ctlVisitasSegunCanalDeServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunCanalDeServicio();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.popupFiltros = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.cmdFiltro = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.ssmEsperaDashboard = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Pantallas.frmEsperaDashboard), true, true, typeof(System.Windows.Forms.UserControl));
            this.ctlVisitasSegunPrioridadServicio1 = new Core.Controles.Dashboards.ctlVisitasSegunPrioridadServicio();
            this.ctlTicketsAtendidos_TicketsNoAtendidos1 = new Core.Controles.Dashboards.ctlTicketsAtendidos_TicketsNoAtendidos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAbrirFiltros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtras.Properties)).BeginInit();
            this.flpPanelDashboards.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupFiltros)).BeginInit();
            this.popupFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTiuloDashboard);
            this.panel1.Controls.Add(this.lblIntervalo);
            this.panel1.Controls.Add(this.cmdAbrirFiltros);
            this.panel1.Controls.Add(this.cmdIrAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 87);
            this.panel1.TabIndex = 0;
            // 
            // lblTiuloDashboard
            // 
            this.lblTiuloDashboard.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiuloDashboard.Appearance.Options.UseFont = true;
            this.lblTiuloDashboard.Appearance.Options.UseTextOptions = true;
            this.lblTiuloDashboard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTiuloDashboard.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTiuloDashboard.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTiuloDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiuloDashboard.Location = new System.Drawing.Point(82, 0);
            this.lblTiuloDashboard.Name = "lblTiuloDashboard";
            this.lblTiuloDashboard.Size = new System.Drawing.Size(1135, 55);
            this.lblTiuloDashboard.TabIndex = 1;
            this.lblTiuloDashboard.Text = "DASHBOARD PRINCIPAL AGENCIA XXXXXX";
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalo.Appearance.Options.UseFont = true;
            this.lblIntervalo.Appearance.Options.UseTextOptions = true;
            this.lblIntervalo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIntervalo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblIntervalo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblIntervalo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIntervalo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblIntervalo.Location = new System.Drawing.Point(82, 55);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(1135, 32);
            this.lblIntervalo.TabIndex = 3;
            this.lblIntervalo.Text = "DESDE - HASTA";
            // 
            // cmdAbrirFiltros
            // 
            this.cmdAbrirFiltros.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdAbrirFiltros.EditValue = global::Core.Properties.Resources.iconFiltro_64;
            this.cmdAbrirFiltros.Location = new System.Drawing.Point(1217, 0);
            this.cmdAbrirFiltros.Name = "cmdAbrirFiltros";
            this.cmdAbrirFiltros.Properties.AllowFocused = false;
            this.cmdAbrirFiltros.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAbrirFiltros.Properties.NullText = " ";
            this.cmdAbrirFiltros.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAbrirFiltros.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAbrirFiltros.Size = new System.Drawing.Size(82, 87);
            this.cmdAbrirFiltros.TabIndex = 2;
            this.cmdAbrirFiltros.Click += new System.EventHandler(this.CmdAbrirFiltros_Click);
            // 
            // cmdIrAtras
            // 
            this.cmdIrAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdIrAtras.EditValue = global::Core.Properties.Resources.iconIrAtras;
            this.cmdIrAtras.Location = new System.Drawing.Point(0, 0);
            this.cmdIrAtras.Name = "cmdIrAtras";
            this.cmdIrAtras.Properties.AllowFocused = false;
            this.cmdIrAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIrAtras.Properties.NullText = " ";
            this.cmdIrAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIrAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdIrAtras.Size = new System.Drawing.Size(82, 87);
            this.cmdIrAtras.TabIndex = 0;
            this.cmdIrAtras.Click += new System.EventHandler(this.CmdIrAtras_Click);
            // 
            // flpPanelDashboards
            // 
            this.flpPanelDashboards.Controls.Add(this.ctlVisitasSegunPrioridadServicio1);
            this.flpPanelDashboards.Controls.Add(this.ctlTicketsAtendidos_TicketsNoAtendidos1);
            this.flpPanelDashboards.Controls.Add(this.ctlPromedioEspera1);
            this.flpPanelDashboards.Controls.Add(this.ctlEmpleadoConMasTicketsAtendidos1);
            this.flpPanelDashboards.Controls.Add(this.ctlPromedioAtencion1);
            this.flpPanelDashboards.Controls.Add(this.ctlVisitasSegunCanalDeServicio1);
            this.flpPanelDashboards.Controls.Add(this.ctlTraficoClientes1);
            this.flpPanelDashboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPanelDashboards.Location = new System.Drawing.Point(5, 102);
            this.flpPanelDashboards.Name = "flpPanelDashboards";
            this.flpPanelDashboards.Size = new System.Drawing.Size(1299, 748);
            this.flpPanelDashboards.TabIndex = 1;
            // 
            // ctlPromedioEspera1
            // 
            this.ctlPromedioEspera1.BackColor = System.Drawing.Color.White;
            this.ctlPromedioEspera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlPromedioEspera1.Location = new System.Drawing.Point(4, 288);
            this.ctlPromedioEspera1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlPromedioEspera1.MaximumSize = new System.Drawing.Size(253, 276);
            this.ctlPromedioEspera1.MinimumSize = new System.Drawing.Size(253, 276);
            this.ctlPromedioEspera1.Name = "ctlPromedioEspera1";
            this.ctlPromedioEspera1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlPromedioEspera1.Pro_Conexion = null;
            this.ctlPromedioEspera1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlPromedioEspera1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlPromedioEspera1.Pro_ID_AgenciaServicio = 0;
            this.ctlPromedioEspera1.Pro_ID_ClienteServicio = 0;
            this.ctlPromedioEspera1.Size = new System.Drawing.Size(253, 276);
            this.ctlPromedioEspera1.TabIndex = 2;
            // 
            // ctlEmpleadoConMasTicketsAtendidos1
            // 
            this.ctlEmpleadoConMasTicketsAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlEmpleadoConMasTicketsAtendidos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlEmpleadoConMasTicketsAtendidos1.Location = new System.Drawing.Point(265, 288);
            this.ctlEmpleadoConMasTicketsAtendidos1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlEmpleadoConMasTicketsAtendidos1.MaximumSize = new System.Drawing.Size(253, 276);
            this.ctlEmpleadoConMasTicketsAtendidos1.MinimumSize = new System.Drawing.Size(253, 276);
            this.ctlEmpleadoConMasTicketsAtendidos1.Name = "ctlEmpleadoConMasTicketsAtendidos1";
            this.ctlEmpleadoConMasTicketsAtendidos1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_Conexion = null;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_ID_Agencia_Servicio = 0;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_ID_Cliente_Servicio = 0;
            this.ctlEmpleadoConMasTicketsAtendidos1.Pro_TituloDashBoard = null;
            this.ctlEmpleadoConMasTicketsAtendidos1.Size = new System.Drawing.Size(253, 276);
            this.ctlEmpleadoConMasTicketsAtendidos1.TabIndex = 0;
            // 
            // ctlPromedioAtencion1
            // 
            this.ctlPromedioAtencion1.BackColor = System.Drawing.Color.White;
            this.ctlPromedioAtencion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlPromedioAtencion1.Location = new System.Drawing.Point(526, 288);
            this.ctlPromedioAtencion1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlPromedioAtencion1.MaximumSize = new System.Drawing.Size(253, 276);
            this.ctlPromedioAtencion1.MinimumSize = new System.Drawing.Size(253, 276);
            this.ctlPromedioAtencion1.Name = "ctlPromedioAtencion1";
            this.ctlPromedioAtencion1.Pro_Conexion = null;
            this.ctlPromedioAtencion1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlPromedioAtencion1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlPromedioAtencion1.Pro_ID_AgenciaServicio = 0;
            this.ctlPromedioAtencion1.Pro_ID_ClienteServicio = 0;
            this.ctlPromedioAtencion1.Size = new System.Drawing.Size(253, 276);
            this.ctlPromedioAtencion1.TabIndex = 1;
            // 
            // ctlTraficoClientes1
            // 
            this.ctlTraficoClientes1.BackColor = System.Drawing.Color.White;
            this.ctlTraficoClientes1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlTraficoClientes1.Location = new System.Drawing.Point(525, 572);
            this.ctlTraficoClientes1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlTraficoClientes1.MaximumSize = new System.Drawing.Size(513, 384);
            this.ctlTraficoClientes1.MinimumSize = new System.Drawing.Size(513, 384);
            this.ctlTraficoClientes1.Name = "ctlTraficoClientes1";
            this.ctlTraficoClientes1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlTraficoClientes1.Pro_Conexion = null;
            this.ctlTraficoClientes1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlTraficoClientes1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlTraficoClientes1.Pro_ID_AgenciaServicio = 0;
            this.ctlTraficoClientes1.Pro_ID_ClienteServicio = 0;
            this.ctlTraficoClientes1.Size = new System.Drawing.Size(513, 384);
            this.ctlTraficoClientes1.TabIndex = 4;
            // 
            // ctlVisitasSegunCanalDeServicio1
            // 
            this.ctlVisitasSegunCanalDeServicio1.BackColor = System.Drawing.Color.White;
            this.ctlVisitasSegunCanalDeServicio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlVisitasSegunCanalDeServicio1.Location = new System.Drawing.Point(4, 572);
            this.ctlVisitasSegunCanalDeServicio1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVisitasSegunCanalDeServicio1.MaximumSize = new System.Drawing.Size(513, 384);
            this.ctlVisitasSegunCanalDeServicio1.MinimumSize = new System.Drawing.Size(513, 384);
            this.ctlVisitasSegunCanalDeServicio1.Name = "ctlVisitasSegunCanalDeServicio1";
            this.ctlVisitasSegunCanalDeServicio1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlVisitasSegunCanalDeServicio1.Pro_Conexion = null;
            this.ctlVisitasSegunCanalDeServicio1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlVisitasSegunCanalDeServicio1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlVisitasSegunCanalDeServicio1.Pro_ID_Agencia_Servicio = 0;
            this.ctlVisitasSegunCanalDeServicio1.Pro_ID_Cliente_Servicio = 0;
            this.ctlVisitasSegunCanalDeServicio1.Size = new System.Drawing.Size(513, 384);
            this.ctlVisitasSegunCanalDeServicio1.TabIndex = 5;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.popupFiltros);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(5, 92);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(1299, 10);
            this.pnlFiltro.TabIndex = 2;
            // 
            // popupFiltros
            // 
            this.popupFiltros.Appearance.BackColor = System.Drawing.Color.White;
            this.popupFiltros.Appearance.Options.UseBackColor = true;
            this.popupFiltros.Controls.Add(this.flyoutPanelControl1);
            this.popupFiltros.Location = new System.Drawing.Point(3, 6);
            this.popupFiltros.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupFiltros.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupFiltros.Name = "popupFiltros";
            this.popupFiltros.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupFiltros.Options.CloseOnOuterClick = true;
            this.popupFiltros.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupFiltros.OwnerControl = this.pnlFiltro;
            this.popupFiltros.Size = new System.Drawing.Size(690, 113);
            this.popupFiltros.TabIndex = 0;
            this.popupFiltros.Hidden += new DevExpress.Utils.FlyoutPanelEventHandler(this.PopupFiltros_Hidden);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.cmdFiltro);
            this.flyoutPanelControl1.Controls.Add(this.labelControl3);
            this.flyoutPanelControl1.Controls.Add(this.labelControl2);
            this.flyoutPanelControl1.Controls.Add(this.dtHasta);
            this.flyoutPanelControl1.Controls.Add(this.dtDesde);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupFiltros;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(690, 113);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // cmdFiltro
            // 
            this.cmdFiltro.EditValue = global::Core.Properties.Resources.iconFiltro_64;
            this.cmdFiltro.Location = new System.Drawing.Point(387, 17);
            this.cmdFiltro.Name = "cmdFiltro";
            this.cmdFiltro.Properties.AllowFocused = false;
            this.cmdFiltro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdFiltro.Properties.NullText = " ";
            this.cmdFiltro.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdFiltro.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdFiltro.Size = new System.Drawing.Size(82, 74);
            this.cmdFiltro.TabIndex = 6;
            this.cmdFiltro.Click += new System.EventHandler(this.CmdFiltro_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(16, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 32);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "HASTA:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(16, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 32);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "DESDE:";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(124, 55);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(220, 36);
            this.dtHasta.TabIndex = 1;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(124, 13);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(220, 36);
            this.dtDesde.TabIndex = 0;
            // 
            // ssmEsperaDashboard
            // 
            this.ssmEsperaDashboard.ClosingDelay = 500;
            // 
            // ctlVisitasSegunPrioridadServicio1
            // 
            this.ctlVisitasSegunPrioridadServicio1.BackColor = System.Drawing.Color.White;
            this.ctlVisitasSegunPrioridadServicio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlVisitasSegunPrioridadServicio1.Location = new System.Drawing.Point(4, 4);
            this.ctlVisitasSegunPrioridadServicio1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVisitasSegunPrioridadServicio1.MaximumSize = new System.Drawing.Size(513, 276);
            this.ctlVisitasSegunPrioridadServicio1.MinimumSize = new System.Drawing.Size(513, 276);
            this.ctlVisitasSegunPrioridadServicio1.Name = "ctlVisitasSegunPrioridadServicio1";
            this.ctlVisitasSegunPrioridadServicio1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlVisitasSegunPrioridadServicio1.Pro_Conexion = null;
            this.ctlVisitasSegunPrioridadServicio1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlVisitasSegunPrioridadServicio1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlVisitasSegunPrioridadServicio1.Pro_ID_Agencia_Servicio = 0;
            this.ctlVisitasSegunPrioridadServicio1.Pro_ID_Cliente_Servicio = 0;
            this.ctlVisitasSegunPrioridadServicio1.Size = new System.Drawing.Size(513, 276);
            this.ctlVisitasSegunPrioridadServicio1.TabIndex = 6;
            // 
            // ctlTicketsAtendidos_TicketsNoAtendidos1
            // 
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Location = new System.Drawing.Point(525, 4);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.MaximumSize = new System.Drawing.Size(513, 276);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.MinimumSize = new System.Drawing.Size(513, 276);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Name = "ctlTicketsAtendidos_TicketsNoAtendidos1";
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Agencia_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Cliente_Servicio = 0;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Conexion = null;
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Desde = new System.DateTime(((long)(0)));
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Pro_Hasta = new System.DateTime(((long)(0)));
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.Size = new System.Drawing.Size(513, 276);
            this.ctlTicketsAtendidos_TicketsNoAtendidos1.TabIndex = 7;
            // 
            // ctlContenedorDashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpPanelDashboards);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.panel1);
            this.Name = "ctlContenedorDashboards";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1309, 855);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdAbrirFiltros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtras.Properties)).EndInit();
            this.flpPanelDashboards.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupFiltros)).EndInit();
            this.popupFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit cmdIrAtras;
        private DevExpress.XtraEditors.LabelControl lblTiuloDashboard;
        private DevExpress.XtraEditors.PictureEdit cmdAbrirFiltros;
        private DevExpress.XtraEditors.LabelControl lblIntervalo;
        private System.Windows.Forms.FlowLayoutPanel flpPanelDashboards;
        private System.Windows.Forms.Panel pnlFiltro;
        private DevExpress.Utils.FlyoutPanel popupFiltros;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.PictureEdit cmdFiltro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private ctlPromedioEspera ctlPromedioEspera1;
        private ctlEmpleadoConMasTicketsAtendidos ctlEmpleadoConMasTicketsAtendidos1;
        private ctlPromedioAtencion ctlPromedioAtencion1;
        private ctlTraficoClientes ctlTraficoClientes1;
        private ctlVisitasSegunCanalDeServicio ctlVisitasSegunCanalDeServicio1;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmEsperaDashboard;
        private ctlVisitasSegunPrioridadServicio ctlVisitasSegunPrioridadServicio1;
        private ctlTicketsAtendidos_TicketsNoAtendidos ctlTicketsAtendidos_TicketsNoAtendidos1;
    }
}
