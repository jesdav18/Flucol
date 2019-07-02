namespace Recepcion.Controles
{
    partial class CtlSeleccionTransaccion
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
            this.components = new System.ComponentModel.Container();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Recepcion.Controles.frmEsperaRecepcion), true, true, typeof(System.Windows.Forms.UserControl));
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.pnlTitulo = new DevExpress.XtraEditors.PanelControl();
            this.lblAgencia = new DevExpress.XtraEditors.LabelControl();
            this.pic_LogoInstitucion = new DevExpress.XtraEditors.PictureEdit();
            this.navFrameMenuInicial = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageTipoTransaccion = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblNegocios = new DevExpress.XtraEditors.LabelControl();
            this.cmdNegocios = new DevExpress.XtraEditors.PictureEdit();
            this.lblTransacciones = new DevExpress.XtraEditors.LabelControl();
            this.lblServicioAlCliente = new DevExpress.XtraEditors.LabelControl();
            this.cmdTransacciones = new DevExpress.XtraEditors.PictureEdit();
            this.cmdServicioAlCliente = new DevExpress.XtraEditors.PictureEdit();
            this.navPageTicket = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.NavPagePrioridades = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlInferior = new DevExpress.XtraEditors.PanelControl();
            this.cmdIrSeleccionTransacciones = new DevExpress.XtraEditors.PictureEdit();
            this.cmdTerceraEdad = new DevExpress.XtraEditors.PictureEdit();
            this.lblEsperaGeneral = new DevExpress.XtraEditors.LabelControl();
            this.lblCondicionesEspeciales = new DevExpress.XtraEditors.LabelControl();
            this.lblTerceraEdad = new DevExpress.XtraEditors.LabelControl();
            this.cmdCondicionesEspeciales01 = new DevExpress.XtraEditors.PictureEdit();
            this.cmdEsperaGeneral = new DevExpress.XtraEditors.PictureEdit();
            this.cmdCondicionesEspeciales = new DevExpress.XtraEditors.PictureEdit();
            this.tmrTiempoVisualizacionTicket = new System.Windows.Forms.Timer(this.components);
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Recepcion.Controles.frmCargandoConexion), true, true, typeof(System.Windows.Forms.UserControl));
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navFrameMenuInicial)).BeginInit();
            this.navFrameMenuInicial.SuspendLayout();
            this.navPageTipoTransaccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNegocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTransacciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdServicioAlCliente.Properties)).BeginInit();
            this.navPageTicket.SuspendLayout();
            this.NavPagePrioridades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).BeginInit();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrSeleccionTransacciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTerceraEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEsperaGeneral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Appearance.Options.UseBackColor = true;
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseForeColor = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Location = new System.Drawing.Point(215, 3);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1102, 98);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.lblAgencia);
            this.pnlTitulo.Controls.Add(this.pic_LogoInstitucion);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(7, 6);
            this.pnlTitulo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlTitulo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1320, 194);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblAgencia
            // 
            this.lblAgencia.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAgencia.Appearance.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAgencia.Appearance.Options.UseBackColor = true;
            this.lblAgencia.Appearance.Options.UseFont = true;
            this.lblAgencia.Appearance.Options.UseForeColor = true;
            this.lblAgencia.Appearance.Options.UseTextOptions = true;
            this.lblAgencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAgencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAgencia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAgencia.Location = new System.Drawing.Point(215, 101);
            this.lblAgencia.Margin = new System.Windows.Forms.Padding(4);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(1102, 90);
            this.lblAgencia.TabIndex = 1;
            this.lblAgencia.Text = "BIENVENIDO";
            // 
            // pic_LogoInstitucion
            // 
            this.pic_LogoInstitucion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_LogoInstitucion.Location = new System.Drawing.Point(3, 3);
            this.pic_LogoInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.pic_LogoInstitucion.Name = "pic_LogoInstitucion";
            this.pic_LogoInstitucion.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.pic_LogoInstitucion.Properties.AllowFocused = false;
            this.pic_LogoInstitucion.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.pic_LogoInstitucion.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pic_LogoInstitucion.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pic_LogoInstitucion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_LogoInstitucion.Properties.NullText = " ";
            this.pic_LogoInstitucion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_LogoInstitucion.Properties.ShowMenu = false;
            this.pic_LogoInstitucion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pic_LogoInstitucion.Size = new System.Drawing.Size(212, 188);
            this.pic_LogoInstitucion.TabIndex = 9;
            // 
            // navFrameMenuInicial
            // 
            this.navFrameMenuInicial.Controls.Add(this.navPageTipoTransaccion);
            this.navFrameMenuInicial.Controls.Add(this.navPageTicket);
            this.navFrameMenuInicial.Controls.Add(this.NavPagePrioridades);
            this.navFrameMenuInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrameMenuInicial.Location = new System.Drawing.Point(7, 200);
            this.navFrameMenuInicial.Margin = new System.Windows.Forms.Padding(4);
            this.navFrameMenuInicial.Name = "navFrameMenuInicial";
            this.navFrameMenuInicial.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.NavPagePrioridades,
            this.navPageTipoTransaccion,
            this.navPageTicket});
            this.navFrameMenuInicial.SelectedPage = this.navPageTipoTransaccion;
            this.navFrameMenuInicial.Size = new System.Drawing.Size(1320, 436);
            this.navFrameMenuInicial.TabIndex = 2;
            this.navFrameMenuInicial.Text = "navMenuPrioridades";
            this.navFrameMenuInicial.TransitionAnimationProperties.FrameCount = 50;
            this.navFrameMenuInicial.TransitionAnimationProperties.FrameInterval = 50;
            this.navFrameMenuInicial.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // navPageTipoTransaccion
            // 
            this.navPageTipoTransaccion.Caption = "navPageTipoTransaccion";
            this.navPageTipoTransaccion.Controls.Add(this.lblNegocios);
            this.navPageTipoTransaccion.Controls.Add(this.cmdNegocios);
            this.navPageTipoTransaccion.Controls.Add(this.lblTransacciones);
            this.navPageTipoTransaccion.Controls.Add(this.lblServicioAlCliente);
            this.navPageTipoTransaccion.Controls.Add(this.cmdTransacciones);
            this.navPageTipoTransaccion.Controls.Add(this.cmdServicioAlCliente);
            this.navPageTipoTransaccion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPageTipoTransaccion.Margin = new System.Windows.Forms.Padding(4);
            this.navPageTipoTransaccion.Name = "navPageTipoTransaccion";
            this.navPageTipoTransaccion.Size = new System.Drawing.Size(1320, 436);
            // 
            // lblNegocios
            // 
            this.lblNegocios.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNegocios.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegocios.Appearance.Options.UseFont = true;
            this.lblNegocios.Appearance.Options.UseTextOptions = true;
            this.lblNegocios.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNegocios.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNegocios.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNegocios.Location = new System.Drawing.Point(834, 226);
            this.lblNegocios.Margin = new System.Windows.Forms.Padding(4);
            this.lblNegocios.Name = "lblNegocios";
            this.lblNegocios.Size = new System.Drawing.Size(329, 119);
            this.lblNegocios.TabIndex = 10;
            this.lblNegocios.Text = "NEGOCIOS";
            this.lblNegocios.Click += new System.EventHandler(this.cmdNegocios_Click);
            // 
            // cmdNegocios
            // 
            this.cmdNegocios.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdNegocios.EditValue = global::Recepcion.Properties.Resources.icon_Negocios_Negro;
            this.cmdNegocios.Location = new System.Drawing.Point(931, 76);
            this.cmdNegocios.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNegocios.Name = "cmdNegocios";
            this.cmdNegocios.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdNegocios.Properties.AllowFocused = false;
            this.cmdNegocios.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdNegocios.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdNegocios.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdNegocios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdNegocios.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdNegocios.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdNegocios.Size = new System.Drawing.Size(153, 112);
            this.cmdNegocios.TabIndex = 9;
            this.cmdNegocios.Click += new System.EventHandler(this.cmdNegocios_Click);
            // 
            // lblTransacciones
            // 
            this.lblTransacciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTransacciones.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacciones.Appearance.Options.UseFont = true;
            this.lblTransacciones.Appearance.Options.UseTextOptions = true;
            this.lblTransacciones.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTransacciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTransacciones.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTransacciones.Location = new System.Drawing.Point(437, 226);
            this.lblTransacciones.Margin = new System.Windows.Forms.Padding(4);
            this.lblTransacciones.Name = "lblTransacciones";
            this.lblTransacciones.Size = new System.Drawing.Size(329, 119);
            this.lblTransacciones.TabIndex = 6;
            this.lblTransacciones.Text = "TRANSACCIONES EN CAJA";
            this.lblTransacciones.Click += new System.EventHandler(this.cmdTransacciones_Click);
            // 
            // lblServicioAlCliente
            // 
            this.lblServicioAlCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServicioAlCliente.Appearance.BackColor = System.Drawing.Color.White;
            this.lblServicioAlCliente.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioAlCliente.Appearance.Options.UseBackColor = true;
            this.lblServicioAlCliente.Appearance.Options.UseFont = true;
            this.lblServicioAlCliente.Appearance.Options.UseTextOptions = true;
            this.lblServicioAlCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblServicioAlCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblServicioAlCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblServicioAlCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblServicioAlCliente.Location = new System.Drawing.Point(102, 226);
            this.lblServicioAlCliente.Margin = new System.Windows.Forms.Padding(4);
            this.lblServicioAlCliente.Name = "lblServicioAlCliente";
            this.lblServicioAlCliente.Size = new System.Drawing.Size(281, 119);
            this.lblServicioAlCliente.TabIndex = 5;
            this.lblServicioAlCliente.Text = "SERVICIO AL CLIENTE";
            this.lblServicioAlCliente.Click += new System.EventHandler(this.cmdServicioAlCliente_Click);
            // 
            // cmdTransacciones
            // 
            this.cmdTransacciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdTransacciones.EditValue = global::Recepcion.Properties.Resources.iconTransaccionesCaja;
            this.cmdTransacciones.Location = new System.Drawing.Point(531, 76);
            this.cmdTransacciones.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTransacciones.Name = "cmdTransacciones";
            this.cmdTransacciones.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTransacciones.Properties.AllowFocused = false;
            this.cmdTransacciones.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTransacciones.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTransacciones.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTransacciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdTransacciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdTransacciones.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdTransacciones.Size = new System.Drawing.Size(153, 112);
            this.cmdTransacciones.TabIndex = 4;
            this.cmdTransacciones.Click += new System.EventHandler(this.cmdTransacciones_Click);
            // 
            // cmdServicioAlCliente
            // 
            this.cmdServicioAlCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdServicioAlCliente.EditValue = global::Recepcion.Properties.Resources.iconServicioAlCliente;
            this.cmdServicioAlCliente.Location = new System.Drawing.Point(169, 76);
            this.cmdServicioAlCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdServicioAlCliente.Name = "cmdServicioAlCliente";
            this.cmdServicioAlCliente.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdServicioAlCliente.Properties.AllowFocused = false;
            this.cmdServicioAlCliente.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdServicioAlCliente.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdServicioAlCliente.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdServicioAlCliente.Properties.Appearance.Image = global::Recepcion.Properties.Resources.iconServicioAlCliente;
            this.cmdServicioAlCliente.Properties.Appearance.Options.UseImage = true;
            this.cmdServicioAlCliente.Properties.AppearanceFocused.Image = global::Recepcion.Properties.Resources.iconServicioAlClienteVerde;
            this.cmdServicioAlCliente.Properties.AppearanceFocused.Options.UseImage = true;
            this.cmdServicioAlCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdServicioAlCliente.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdServicioAlCliente.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdServicioAlCliente.Properties.NullText = " ";
            this.cmdServicioAlCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdServicioAlCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdServicioAlCliente.Size = new System.Drawing.Size(153, 112);
            this.cmdServicioAlCliente.TabIndex = 3;
            this.cmdServicioAlCliente.Click += new System.EventHandler(this.cmdServicioAlCliente_Click);
            // 
            // navPageTicket
            // 
            this.navPageTicket.Caption = "navPageTicket";
            this.navPageTicket.Controls.Add(this.documentViewer1);
            this.navPageTicket.Margin = new System.Windows.Forms.Padding(4);
            this.navPageTicket.Name = "navPageTicket";
            this.navPageTicket.Size = new System.Drawing.Size(1320, 436);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.LookAndFeel.SkinName = "Office 2013";
            this.documentViewer1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.documentViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.PageBorderColor = System.Drawing.Color.White;
            this.documentViewer1.SelectedPageBorderColor = System.Drawing.Color.White;
            this.documentViewer1.ShowPageMargins = false;
            this.documentViewer1.Size = new System.Drawing.Size(1320, 436);
            this.documentViewer1.TabIndex = 0;
            // 
            // NavPagePrioridades
            // 
            this.NavPagePrioridades.Caption = "NavPagePrioridades";
            this.NavPagePrioridades.Controls.Add(this.pnlInferior);
            this.NavPagePrioridades.Controls.Add(this.cmdTerceraEdad);
            this.NavPagePrioridades.Controls.Add(this.lblEsperaGeneral);
            this.NavPagePrioridades.Controls.Add(this.lblCondicionesEspeciales);
            this.NavPagePrioridades.Controls.Add(this.lblTerceraEdad);
            this.NavPagePrioridades.Controls.Add(this.cmdCondicionesEspeciales01);
            this.NavPagePrioridades.Controls.Add(this.cmdEsperaGeneral);
            this.NavPagePrioridades.Controls.Add(this.cmdCondicionesEspeciales);
            this.NavPagePrioridades.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavPagePrioridades.Margin = new System.Windows.Forms.Padding(4);
            this.NavPagePrioridades.Name = "NavPagePrioridades";
            this.NavPagePrioridades.Size = new System.Drawing.Size(1320, 436);
            // 
            // pnlInferior
            // 
            this.pnlInferior.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlInferior.Appearance.Options.UseBackColor = true;
            this.pnlInferior.Controls.Add(this.cmdIrSeleccionTransacciones);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 325);
            this.pnlInferior.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlInferior.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1320, 111);
            this.pnlInferior.TabIndex = 9;
            // 
            // cmdIrSeleccionTransacciones
            // 
            this.cmdIrSeleccionTransacciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdIrSeleccionTransacciones.EditValue = global::Recepcion.Properties.Resources.iconIrAtras;
            this.cmdIrSeleccionTransacciones.Location = new System.Drawing.Point(3, 3);
            this.cmdIrSeleccionTransacciones.Margin = new System.Windows.Forms.Padding(4);
            this.cmdIrSeleccionTransacciones.Name = "cmdIrSeleccionTransacciones";
            this.cmdIrSeleccionTransacciones.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIrSeleccionTransacciones.Properties.AllowFocused = false;
            this.cmdIrSeleccionTransacciones.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIrSeleccionTransacciones.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIrSeleccionTransacciones.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIrSeleccionTransacciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIrSeleccionTransacciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIrSeleccionTransacciones.Size = new System.Drawing.Size(148, 105);
            this.cmdIrSeleccionTransacciones.TabIndex = 8;
            this.cmdIrSeleccionTransacciones.Click += new System.EventHandler(this.cmdIrSeleccionTransacciones_Click);
            // 
            // cmdTerceraEdad
            // 
            this.cmdTerceraEdad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdTerceraEdad.EditValue = global::Recepcion.Properties.Resources.iconAncianos;
            this.cmdTerceraEdad.Location = new System.Drawing.Point(230, 37);
            this.cmdTerceraEdad.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTerceraEdad.Name = "cmdTerceraEdad";
            this.cmdTerceraEdad.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTerceraEdad.Properties.AllowFocused = false;
            this.cmdTerceraEdad.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTerceraEdad.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTerceraEdad.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdTerceraEdad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdTerceraEdad.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdTerceraEdad.Properties.ShowMenu = false;
            this.cmdTerceraEdad.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdTerceraEdad.Size = new System.Drawing.Size(180, 129);
            this.cmdTerceraEdad.TabIndex = 8;
            this.cmdTerceraEdad.Click += new System.EventHandler(this.cmdTerceraEdad_Click);
            // 
            // lblEsperaGeneral
            // 
            this.lblEsperaGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEsperaGeneral.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaGeneral.Appearance.Options.UseFont = true;
            this.lblEsperaGeneral.Appearance.Options.UseTextOptions = true;
            this.lblEsperaGeneral.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEsperaGeneral.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEsperaGeneral.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEsperaGeneral.Location = new System.Drawing.Point(895, 174);
            this.lblEsperaGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.lblEsperaGeneral.Name = "lblEsperaGeneral";
            this.lblEsperaGeneral.Size = new System.Drawing.Size(260, 119);
            this.lblEsperaGeneral.TabIndex = 7;
            this.lblEsperaGeneral.Text = "ESPERA GENERAL";
            this.lblEsperaGeneral.Click += new System.EventHandler(this.cmdEsperaGeneral_Click);
            // 
            // lblCondicionesEspeciales
            // 
            this.lblCondicionesEspeciales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCondicionesEspeciales.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionesEspeciales.Appearance.Options.UseFont = true;
            this.lblCondicionesEspeciales.Appearance.Options.UseTextOptions = true;
            this.lblCondicionesEspeciales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCondicionesEspeciales.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCondicionesEspeciales.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCondicionesEspeciales.Location = new System.Drawing.Point(558, 174);
            this.lblCondicionesEspeciales.Margin = new System.Windows.Forms.Padding(4);
            this.lblCondicionesEspeciales.Name = "lblCondicionesEspeciales";
            this.lblCondicionesEspeciales.Size = new System.Drawing.Size(260, 119);
            this.lblCondicionesEspeciales.TabIndex = 3;
            this.lblCondicionesEspeciales.Text = "CONDICIONES ESPECIALES";
            this.lblCondicionesEspeciales.Click += new System.EventHandler(this.cmdCondicionesEspeciales_Click);
            // 
            // lblTerceraEdad
            // 
            this.lblTerceraEdad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTerceraEdad.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceraEdad.Appearance.Options.UseFont = true;
            this.lblTerceraEdad.Appearance.Options.UseTextOptions = true;
            this.lblTerceraEdad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTerceraEdad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTerceraEdad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTerceraEdad.Location = new System.Drawing.Point(211, 181);
            this.lblTerceraEdad.Margin = new System.Windows.Forms.Padding(4);
            this.lblTerceraEdad.Name = "lblTerceraEdad";
            this.lblTerceraEdad.Size = new System.Drawing.Size(199, 105);
            this.lblTerceraEdad.TabIndex = 1;
            this.lblTerceraEdad.Text = "TERCERA EDAD";
            this.lblTerceraEdad.Click += new System.EventHandler(this.cmdTerceraEdad_Click);
            // 
            // cmdCondicionesEspeciales01
            // 
            this.cmdCondicionesEspeciales01.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdCondicionesEspeciales01.EditValue = global::Recepcion.Properties.Resources.iconDiscapacidad;
            this.cmdCondicionesEspeciales01.Location = new System.Drawing.Point(679, 37);
            this.cmdCondicionesEspeciales01.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCondicionesEspeciales01.Name = "cmdCondicionesEspeciales01";
            this.cmdCondicionesEspeciales01.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales01.Properties.AllowFocused = false;
            this.cmdCondicionesEspeciales01.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales01.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales01.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales01.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCondicionesEspeciales01.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCondicionesEspeciales01.Properties.ShowMenu = false;
            this.cmdCondicionesEspeciales01.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCondicionesEspeciales01.Size = new System.Drawing.Size(180, 123);
            this.cmdCondicionesEspeciales01.TabIndex = 6;
            this.cmdCondicionesEspeciales01.Click += new System.EventHandler(this.cmdCondicionesEspeciales_Click);
            // 
            // cmdEsperaGeneral
            // 
            this.cmdEsperaGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdEsperaGeneral.EditValue = global::Recepcion.Properties.Resources.iconEsperaGeneral;
            this.cmdEsperaGeneral.Location = new System.Drawing.Point(945, 37);
            this.cmdEsperaGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEsperaGeneral.Name = "cmdEsperaGeneral";
            this.cmdEsperaGeneral.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdEsperaGeneral.Properties.AllowFocused = false;
            this.cmdEsperaGeneral.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdEsperaGeneral.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdEsperaGeneral.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdEsperaGeneral.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdEsperaGeneral.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdEsperaGeneral.Properties.ShowMenu = false;
            this.cmdEsperaGeneral.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdEsperaGeneral.Size = new System.Drawing.Size(159, 123);
            this.cmdEsperaGeneral.TabIndex = 4;
            this.cmdEsperaGeneral.Click += new System.EventHandler(this.cmdEsperaGeneral_Click);
            // 
            // cmdCondicionesEspeciales
            // 
            this.cmdCondicionesEspeciales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdCondicionesEspeciales.EditValue = global::Recepcion.Properties.Resources.iconEmbarazada;
            this.cmdCondicionesEspeciales.Location = new System.Drawing.Point(510, 37);
            this.cmdCondicionesEspeciales.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCondicionesEspeciales.Name = "cmdCondicionesEspeciales";
            this.cmdCondicionesEspeciales.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales.Properties.AllowFocused = false;
            this.cmdCondicionesEspeciales.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCondicionesEspeciales.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCondicionesEspeciales.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCondicionesEspeciales.Properties.ShowMenu = false;
            this.cmdCondicionesEspeciales.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCondicionesEspeciales.Size = new System.Drawing.Size(180, 123);
            this.cmdCondicionesEspeciales.TabIndex = 2;
            this.cmdCondicionesEspeciales.Click += new System.EventHandler(this.cmdCondicionesEspeciales_Click);
            // 
            // tmrTiempoVisualizacionTicket
            // 
            this.tmrTiempoVisualizacionTicket.Interval = 2000;
            this.tmrTiempoVisualizacionTicket.Tick += new System.EventHandler(this.tmrTiempoVisualizacionTicket_Tick);
            // 
            // splashScreenManager2
            // 
            this.splashScreenManager2.ClosingDelay = 500;
            // 
            // CtlSeleccionTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navFrameMenuInicial);
            this.Controls.Add(this.pnlTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CtlSeleccionTransaccion";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(1334, 642);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navFrameMenuInicial)).EndInit();
            this.navFrameMenuInicial.ResumeLayout(false);
            this.navPageTipoTransaccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdNegocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTransacciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdServicioAlCliente.Properties)).EndInit();
            this.navPageTicket.ResumeLayout(false);
            this.NavPagePrioridades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrSeleccionTransacciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTerceraEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEsperaGeneral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.PanelControl pnlTitulo;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrameMenuInicial;
        private DevExpress.XtraBars.Navigation.NavigationPage NavPagePrioridades;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageTipoTransaccion;
        private DevExpress.XtraEditors.LabelControl lblEsperaGeneral;
        private DevExpress.XtraEditors.PictureEdit cmdCondicionesEspeciales01;
        private DevExpress.XtraEditors.PictureEdit cmdEsperaGeneral;
        private DevExpress.XtraEditors.LabelControl lblCondicionesEspeciales;
        private DevExpress.XtraEditors.PictureEdit cmdCondicionesEspeciales;
        private DevExpress.XtraEditors.LabelControl lblTerceraEdad;
        private DevExpress.XtraEditors.PictureEdit cmdTerceraEdad;
        private DevExpress.XtraEditors.LabelControl lblTransacciones;
        private DevExpress.XtraEditors.LabelControl lblServicioAlCliente;
        private DevExpress.XtraEditors.PictureEdit cmdTransacciones;
        private DevExpress.XtraEditors.PictureEdit cmdServicioAlCliente;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageTicket;
        private System.Windows.Forms.Timer tmrTiempoVisualizacionTicket;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraEditors.LabelControl lblNegocios;
        private DevExpress.XtraEditors.PictureEdit cmdNegocios;
        private DevExpress.XtraEditors.LabelControl lblAgencia;
        private DevExpress.XtraEditors.PictureEdit pic_LogoInstitucion;
        private DevExpress.XtraEditors.PanelControl pnlInferior;
        private DevExpress.XtraEditors.PictureEdit cmdIrSeleccionTransacciones;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
    }
}
