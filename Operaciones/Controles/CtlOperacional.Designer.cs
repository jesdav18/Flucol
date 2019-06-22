namespace Operaciones.Controles
{
    partial class CtlOperacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlOperacional));
            this.pnlEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.lblAgencia = new DevExpress.XtraEditors.LabelControl();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.pnlDetalleResumen = new System.Windows.Forms.Panel();
            this.pnlEncabezadoResumen = new System.Windows.Forms.Panel();
            this.picUsuario = new DevExpress.XtraEditors.PictureEdit();
            this.pnlControlesDeCola = new System.Windows.Forms.Panel();
            this.lblRellamar = new DevExpress.XtraEditors.LabelControl();
            this.cmdRellamar = new DevExpress.XtraEditors.PictureEdit();
            this.lblMarcarComoNoRespondioLlamado = new DevExpress.XtraEditors.LabelControl();
            this.cmdClienteNoAtendioLlamado = new DevExpress.XtraEditors.PictureEdit();
            this.lblLlamarCliente = new DevExpress.XtraEditors.LabelControl();
            this.cmdLlamarCliente = new DevExpress.XtraEditors.PictureEdit();
            this.lblCerrarTicket = new DevExpress.XtraEditors.LabelControl();
            this.lblIniciarTicket = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrarTicket = new DevExpress.XtraEditors.PictureEdit();
            this.cmdIniciarTicket = new DevExpress.XtraEditors.PictureEdit();
            this.pnlInformacionTickets = new System.Windows.Forms.Panel();
            this.lblTiempoAtencion = new DevExpress.XtraEditors.LabelControl();
            this.lblNumeroTicket = new DevExpress.XtraEditors.LabelControl();
            this.tmrTiempoAtencion = new System.Windows.Forms.Timer(this.components);
            this.tmrParoTiempo = new System.Windows.Forms.Timer(this.components);
            this.Navigation = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pagePrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlListaTickets = new System.Windows.Forms.Panel();
            this.ctlListaTicketsEspera1 = new Operaciones.Controles.ctlListaTicketsEspera();
            this.PagePopups = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.popupResumen = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.cmdCerrarSesion = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalidaAlmuerzo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPersonalTiempo = new DevExpress.XtraEditors.SimpleButton();
            this.lblPosicion = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreUsuario = new DevExpress.XtraEditors.LabelControl();
            this.PageOperacionalReducido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlOperacionalReducido1 = new Operaciones.Controles.ctlOperacionalReducido();
            this.tmrAlerta = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.pnlEncabezadoResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario.Properties)).BeginInit();
            this.pnlControlesDeCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRellamar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClienteNoAtendioLlamado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLlamarCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIniciarTicket.Properties)).BeginInit();
            this.pnlInformacionTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigation)).BeginInit();
            this.Navigation.SuspendLayout();
            this.pagePrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlListaTickets.SuspendLayout();
            this.PagePopups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupResumen)).BeginInit();
            this.popupResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.PageOperacionalReducido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlEncabezado.Appearance.Options.UseBackColor = true;
            this.pnlEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEncabezado.Controls.Add(this.lblAgencia);
            this.pnlEncabezado.Controls.Add(this.pnlResumen);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlEncabezado.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1106, 37);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblAgencia
            // 
            this.lblAgencia.Appearance.BackColor = System.Drawing.Color.White;
            this.lblAgencia.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Appearance.Options.UseBackColor = true;
            this.lblAgencia.Appearance.Options.UseFont = true;
            this.lblAgencia.Appearance.Options.UseTextOptions = true;
            this.lblAgencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblAgencia.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblAgencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAgencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgencia.Location = new System.Drawing.Point(0, 0);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(894, 37);
            this.lblAgencia.TabIndex = 19;
            this.lblAgencia.Text = "NOMBRE SUCURSAL";
            // 
            // pnlResumen
            // 
            this.pnlResumen.Controls.Add(this.pnlDetalleResumen);
            this.pnlResumen.Controls.Add(this.pnlEncabezadoResumen);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlResumen.Location = new System.Drawing.Point(894, 0);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(212, 37);
            this.pnlResumen.TabIndex = 5;
            // 
            // pnlDetalleResumen
            // 
            this.pnlDetalleResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalleResumen.Location = new System.Drawing.Point(0, 29);
            this.pnlDetalleResumen.Name = "pnlDetalleResumen";
            this.pnlDetalleResumen.Size = new System.Drawing.Size(212, 8);
            this.pnlDetalleResumen.TabIndex = 6;
            // 
            // pnlEncabezadoResumen
            // 
            this.pnlEncabezadoResumen.Controls.Add(this.picUsuario);
            this.pnlEncabezadoResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoResumen.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoResumen.Name = "pnlEncabezadoResumen";
            this.pnlEncabezadoResumen.Size = new System.Drawing.Size(212, 29);
            this.pnlEncabezadoResumen.TabIndex = 5;
            // 
            // picUsuario
            // 
            this.picUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.picUsuario.EditValue = ((object)(resources.GetObject("picUsuario.EditValue")));
            this.picUsuario.Location = new System.Drawing.Point(170, 0);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.picUsuario.Properties.AllowFocused = false;
            this.picUsuario.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.picUsuario.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picUsuario.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picUsuario.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.picUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.picUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUsuario.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picUsuario.Properties.ReadOnly = true;
            this.picUsuario.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picUsuario.Properties.ShowMenu = false;
            this.picUsuario.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picUsuario.Size = new System.Drawing.Size(42, 29);
            this.picUsuario.TabIndex = 4;
            this.picUsuario.Click += new System.EventHandler(this.picUsuario_Click);
            // 
            // pnlControlesDeCola
            // 
            this.pnlControlesDeCola.BackColor = System.Drawing.Color.White;
            this.pnlControlesDeCola.Controls.Add(this.lblRellamar);
            this.pnlControlesDeCola.Controls.Add(this.cmdRellamar);
            this.pnlControlesDeCola.Controls.Add(this.lblMarcarComoNoRespondioLlamado);
            this.pnlControlesDeCola.Controls.Add(this.cmdClienteNoAtendioLlamado);
            this.pnlControlesDeCola.Controls.Add(this.lblLlamarCliente);
            this.pnlControlesDeCola.Controls.Add(this.cmdLlamarCliente);
            this.pnlControlesDeCola.Controls.Add(this.lblCerrarTicket);
            this.pnlControlesDeCola.Controls.Add(this.lblIniciarTicket);
            this.pnlControlesDeCola.Controls.Add(this.cmdCerrarTicket);
            this.pnlControlesDeCola.Controls.Add(this.cmdIniciarTicket);
            this.pnlControlesDeCola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesDeCola.Location = new System.Drawing.Point(0, 266);
            this.pnlControlesDeCola.Name = "pnlControlesDeCola";
            this.pnlControlesDeCola.Size = new System.Drawing.Size(933, 138);
            this.pnlControlesDeCola.TabIndex = 1;
            // 
            // lblRellamar
            // 
            this.lblRellamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRellamar.Appearance.BackColor = System.Drawing.Color.White;
            this.lblRellamar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRellamar.Appearance.Options.UseBackColor = true;
            this.lblRellamar.Appearance.Options.UseFont = true;
            this.lblRellamar.Appearance.Options.UseTextOptions = true;
            this.lblRellamar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRellamar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblRellamar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRellamar.Location = new System.Drawing.Point(544, 77);
            this.lblRellamar.Name = "lblRellamar";
            this.lblRellamar.Size = new System.Drawing.Size(171, 54);
            this.lblRellamar.TabIndex = 18;
            this.lblRellamar.Text = "RELLAMAR";
            this.lblRellamar.Click += new System.EventHandler(this.cmdRellamar_Click);
            // 
            // cmdRellamar
            // 
            this.cmdRellamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdRellamar.EditValue = global::Operaciones.Properties.Resources.icon_rellamar_negro_64;
            this.cmdRellamar.Location = new System.Drawing.Point(599, 15);
            this.cmdRellamar.Name = "cmdRellamar";
            this.cmdRellamar.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdRellamar.Properties.AllowFocused = false;
            this.cmdRellamar.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdRellamar.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdRellamar.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdRellamar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdRellamar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdRellamar.Properties.ShowMenu = false;
            this.cmdRellamar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdRellamar.Size = new System.Drawing.Size(65, 56);
            this.cmdRellamar.TabIndex = 17;
            this.cmdRellamar.Click += new System.EventHandler(this.cmdRellamar_Click);
            // 
            // lblMarcarComoNoRespondioLlamado
            // 
            this.lblMarcarComoNoRespondioLlamado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMarcarComoNoRespondioLlamado.Appearance.BackColor = System.Drawing.Color.White;
            this.lblMarcarComoNoRespondioLlamado.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcarComoNoRespondioLlamado.Appearance.Options.UseBackColor = true;
            this.lblMarcarComoNoRespondioLlamado.Appearance.Options.UseFont = true;
            this.lblMarcarComoNoRespondioLlamado.Appearance.Options.UseTextOptions = true;
            this.lblMarcarComoNoRespondioLlamado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMarcarComoNoRespondioLlamado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMarcarComoNoRespondioLlamado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMarcarComoNoRespondioLlamado.Location = new System.Drawing.Point(737, 77);
            this.lblMarcarComoNoRespondioLlamado.Name = "lblMarcarComoNoRespondioLlamado";
            this.lblMarcarComoNoRespondioLlamado.Size = new System.Drawing.Size(171, 54);
            this.lblMarcarComoNoRespondioLlamado.TabIndex = 16;
            this.lblMarcarComoNoRespondioLlamado.Text = "CLIENTE NO ATENDIO LLAMADO (F6)";
            this.lblMarcarComoNoRespondioLlamado.Click += new System.EventHandler(this.cmdClienteNoAtendioLlamado_Click);
            // 
            // cmdClienteNoAtendioLlamado
            // 
            this.cmdClienteNoAtendioLlamado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdClienteNoAtendioLlamado.EditValue = global::Operaciones.Properties.Resources.iconNoRespondioLlamado;
            this.cmdClienteNoAtendioLlamado.Location = new System.Drawing.Point(795, 15);
            this.cmdClienteNoAtendioLlamado.Name = "cmdClienteNoAtendioLlamado";
            this.cmdClienteNoAtendioLlamado.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdClienteNoAtendioLlamado.Properties.AllowFocused = false;
            this.cmdClienteNoAtendioLlamado.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdClienteNoAtendioLlamado.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdClienteNoAtendioLlamado.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdClienteNoAtendioLlamado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdClienteNoAtendioLlamado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdClienteNoAtendioLlamado.Properties.ShowMenu = false;
            this.cmdClienteNoAtendioLlamado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdClienteNoAtendioLlamado.Size = new System.Drawing.Size(65, 56);
            this.cmdClienteNoAtendioLlamado.TabIndex = 15;
            this.cmdClienteNoAtendioLlamado.Click += new System.EventHandler(this.cmdClienteNoAtendioLlamado_Click);
            // 
            // lblLlamarCliente
            // 
            this.lblLlamarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLlamarCliente.Appearance.BackColor = System.Drawing.Color.White;
            this.lblLlamarCliente.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamarCliente.Appearance.Options.UseBackColor = true;
            this.lblLlamarCliente.Appearance.Options.UseFont = true;
            this.lblLlamarCliente.Appearance.Options.UseTextOptions = true;
            this.lblLlamarCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLlamarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblLlamarCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLlamarCliente.Location = new System.Drawing.Point(50, 77);
            this.lblLlamarCliente.Name = "lblLlamarCliente";
            this.lblLlamarCliente.Size = new System.Drawing.Size(130, 54);
            this.lblLlamarCliente.TabIndex = 14;
            this.lblLlamarCliente.Text = "LLAMAR CLIENTE (F5)";
            this.lblLlamarCliente.Click += new System.EventHandler(this.cmdLlamarCliente_Click);
            // 
            // cmdLlamarCliente
            // 
            this.cmdLlamarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdLlamarCliente.EditValue = global::Operaciones.Properties.Resources.icon_llamar_siguiente_cliente;
            this.cmdLlamarCliente.Location = new System.Drawing.Point(86, 15);
            this.cmdLlamarCliente.Name = "cmdLlamarCliente";
            this.cmdLlamarCliente.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdLlamarCliente.Properties.AllowFocused = false;
            this.cmdLlamarCliente.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdLlamarCliente.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdLlamarCliente.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdLlamarCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdLlamarCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdLlamarCliente.Properties.ShowMenu = false;
            this.cmdLlamarCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdLlamarCliente.Size = new System.Drawing.Size(65, 56);
            this.cmdLlamarCliente.TabIndex = 13;
            this.cmdLlamarCliente.Click += new System.EventHandler(this.cmdLlamarCliente_Click);
            // 
            // lblCerrarTicket
            // 
            this.lblCerrarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCerrarTicket.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCerrarTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarTicket.Appearance.Options.UseBackColor = true;
            this.lblCerrarTicket.Appearance.Options.UseFont = true;
            this.lblCerrarTicket.Appearance.Options.UseTextOptions = true;
            this.lblCerrarTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCerrarTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCerrarTicket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCerrarTicket.Location = new System.Drawing.Point(393, 80);
            this.lblCerrarTicket.Name = "lblCerrarTicket";
            this.lblCerrarTicket.Size = new System.Drawing.Size(130, 54);
            this.lblCerrarTicket.TabIndex = 12;
            this.lblCerrarTicket.Text = "CERRAR TICKET (F2)";
            this.lblCerrarTicket.Click += new System.EventHandler(this.cmdCerrarTicket_Click);
            // 
            // lblIniciarTicket
            // 
            this.lblIniciarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIniciarTicket.Appearance.BackColor = System.Drawing.Color.White;
            this.lblIniciarTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarTicket.Appearance.Options.UseBackColor = true;
            this.lblIniciarTicket.Appearance.Options.UseFont = true;
            this.lblIniciarTicket.Appearance.Options.UseTextOptions = true;
            this.lblIniciarTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIniciarTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblIniciarTicket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIniciarTicket.Location = new System.Drawing.Point(225, 77);
            this.lblIniciarTicket.Name = "lblIniciarTicket";
            this.lblIniciarTicket.Size = new System.Drawing.Size(130, 54);
            this.lblIniciarTicket.TabIndex = 11;
            this.lblIniciarTicket.Text = "INICIAR ATENCIÓN (F1)";
            this.lblIniciarTicket.Click += new System.EventHandler(this.cmdIniciarTicket_Click);
            // 
            // cmdCerrarTicket
            // 
            this.cmdCerrarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCerrarTicket.EditValue = global::Operaciones.Properties.Resources.iconDetenerTicket;
            this.cmdCerrarTicket.Location = new System.Drawing.Point(428, 15);
            this.cmdCerrarTicket.Name = "cmdCerrarTicket";
            this.cmdCerrarTicket.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCerrarTicket.Properties.AllowFocused = false;
            this.cmdCerrarTicket.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCerrarTicket.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCerrarTicket.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCerrarTicket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCerrarTicket.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCerrarTicket.Properties.ShowMenu = false;
            this.cmdCerrarTicket.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCerrarTicket.Size = new System.Drawing.Size(65, 56);
            this.cmdCerrarTicket.TabIndex = 9;
            this.cmdCerrarTicket.Click += new System.EventHandler(this.cmdCerrarTicket_Click);
            // 
            // cmdIniciarTicket
            // 
            this.cmdIniciarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdIniciarTicket.EditValue = global::Operaciones.Properties.Resources.iconIniciarTicket;
            this.cmdIniciarTicket.Location = new System.Drawing.Point(256, 15);
            this.cmdIniciarTicket.Name = "cmdIniciarTicket";
            this.cmdIniciarTicket.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIniciarTicket.Properties.AllowFocused = false;
            this.cmdIniciarTicket.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIniciarTicket.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIniciarTicket.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdIniciarTicket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIniciarTicket.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIniciarTicket.Properties.ShowMenu = false;
            this.cmdIniciarTicket.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdIniciarTicket.Size = new System.Drawing.Size(65, 56);
            this.cmdIniciarTicket.TabIndex = 8;
            this.cmdIniciarTicket.Click += new System.EventHandler(this.cmdIniciarTicket_Click);
            // 
            // pnlInformacionTickets
            // 
            this.pnlInformacionTickets.Controls.Add(this.lblTiempoAtencion);
            this.pnlInformacionTickets.Controls.Add(this.lblNumeroTicket);
            this.pnlInformacionTickets.Controls.Add(this.pnlControlesDeCola);
            this.pnlInformacionTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacionTickets.Location = new System.Drawing.Point(173, 0);
            this.pnlInformacionTickets.Name = "pnlInformacionTickets";
            this.pnlInformacionTickets.Size = new System.Drawing.Size(933, 404);
            this.pnlInformacionTickets.TabIndex = 2;
            // 
            // lblTiempoAtencion
            // 
            this.lblTiempoAtencion.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTiempoAtencion.Appearance.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoAtencion.Appearance.Options.UseBackColor = true;
            this.lblTiempoAtencion.Appearance.Options.UseFont = true;
            this.lblTiempoAtencion.Appearance.Options.UseTextOptions = true;
            this.lblTiempoAtencion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTiempoAtencion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTiempoAtencion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblTiempoAtencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiempoAtencion.Location = new System.Drawing.Point(0, 103);
            this.lblTiempoAtencion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.lblTiempoAtencion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblTiempoAtencion.Name = "lblTiempoAtencion";
            this.lblTiempoAtencion.Size = new System.Drawing.Size(933, 163);
            this.lblTiempoAtencion.TabIndex = 2;
            this.lblTiempoAtencion.Text = "00:00:00";
            // 
            // lblNumeroTicket
            // 
            this.lblNumeroTicket.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNumeroTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTicket.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblNumeroTicket.Appearance.Options.UseBackColor = true;
            this.lblNumeroTicket.Appearance.Options.UseFont = true;
            this.lblNumeroTicket.Appearance.Options.UseForeColor = true;
            this.lblNumeroTicket.Appearance.Options.UseTextOptions = true;
            this.lblNumeroTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNumeroTicket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNumeroTicket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblNumeroTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumeroTicket.Location = new System.Drawing.Point(0, 0);
            this.lblNumeroTicket.Name = "lblNumeroTicket";
            this.lblNumeroTicket.Size = new System.Drawing.Size(933, 103);
            this.lblNumeroTicket.TabIndex = 1;
            this.lblNumeroTicket.Text = "N° TICKET";
            // 
            // tmrTiempoAtencion
            // 
            this.tmrTiempoAtencion.Interval = 1000;
            this.tmrTiempoAtencion.Tick += new System.EventHandler(this.tmrTiempoAtencion_Tick);
            // 
            // tmrParoTiempo
            // 
            this.tmrParoTiempo.Interval = 1000;
            // 
            // Navigation
            // 
            this.Navigation.Appearance.BackColor = System.Drawing.Color.White;
            this.Navigation.Appearance.Options.UseBackColor = true;
            this.Navigation.Controls.Add(this.pagePrincipal);
            this.Navigation.Controls.Add(this.PagePopups);
            this.Navigation.Controls.Add(this.PageOperacionalReducido);
            this.Navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigation.Location = new System.Drawing.Point(5, 5);
            this.Navigation.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Navigation.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Navigation.Name = "Navigation";
            this.Navigation.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pagePrincipal,
            this.PagePopups,
            this.PageOperacionalReducido});
            this.Navigation.SelectedPage = this.pagePrincipal;
            this.Navigation.Size = new System.Drawing.Size(1106, 441);
            this.Navigation.TabIndex = 3;
            this.Navigation.Text = "navigationFrame1";
            this.Navigation.TransitionAnimationProperties.FrameCount = 200;
            this.Navigation.TransitionAnimationProperties.FrameInterval = 200;
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Caption = "pagePrincipal";
            this.pagePrincipal.Controls.Add(this.panel1);
            this.pagePrincipal.Controls.Add(this.pnlEncabezado);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.Size = new System.Drawing.Size(1106, 441);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlInformacionTickets);
            this.panel1.Controls.Add(this.pnlListaTickets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 404);
            this.panel1.TabIndex = 4;
            // 
            // pnlListaTickets
            // 
            this.pnlListaTickets.BackColor = System.Drawing.Color.White;
            this.pnlListaTickets.Controls.Add(this.ctlListaTicketsEspera1);
            this.pnlListaTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListaTickets.Location = new System.Drawing.Point(0, 0);
            this.pnlListaTickets.Name = "pnlListaTickets";
            this.pnlListaTickets.Size = new System.Drawing.Size(173, 404);
            this.pnlListaTickets.TabIndex = 3;
            // 
            // ctlListaTicketsEspera1
            // 
            this.ctlListaTicketsEspera1.BackColor = System.Drawing.Color.White;
            this.ctlListaTicketsEspera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlListaTicketsEspera1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctlListaTicketsEspera1.Location = new System.Drawing.Point(0, 0);
            this.ctlListaTicketsEspera1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlListaTicketsEspera1.Name = "ctlListaTicketsEspera1";
            this.ctlListaTicketsEspera1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlListaTicketsEspera1.Pro_CargarLista = false;
            this.ctlListaTicketsEspera1.Pro_Conexion = null;
            this.ctlListaTicketsEspera1.Pro_ConteoTicketsEspera = 0;
            this.ctlListaTicketsEspera1.Pro_ID_AgenciaServicio = 0;
            this.ctlListaTicketsEspera1.Pro_ID_ClienteServicio = 0;
            this.ctlListaTicketsEspera1.Pro_Usuario = null;
            this.ctlListaTicketsEspera1.Size = new System.Drawing.Size(173, 404);
            this.ctlListaTicketsEspera1.TabIndex = 0;
            // 
            // PagePopups
            // 
            this.PagePopups.Caption = "PagePopups";
            this.PagePopups.Controls.Add(this.popupResumen);
            this.PagePopups.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.PagePopups.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PagePopups.Name = "PagePopups";
            this.PagePopups.Size = new System.Drawing.Size(1106, 441);
            // 
            // popupResumen
            // 
            this.popupResumen.AnimationRate = 100;
            this.popupResumen.Appearance.BackColor = System.Drawing.Color.White;
            this.popupResumen.Appearance.Options.UseBackColor = true;
            this.popupResumen.Controls.Add(this.flyoutPanelControl1);
            this.popupResumen.Location = new System.Drawing.Point(21, 17);
            this.popupResumen.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupResumen.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupResumen.Name = "popupResumen";
            this.popupResumen.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupResumen.Options.CloseOnOuterClick = true;
            this.popupResumen.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupResumen.OwnerControl = this.pnlDetalleResumen;
            this.popupResumen.Size = new System.Drawing.Size(349, 199);
            this.popupResumen.TabIndex = 0;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.pnlBotones);
            this.flyoutPanelControl1.Controls.Add(this.lblPosicion);
            this.flyoutPanelControl1.Controls.Add(this.lblNombreUsuario);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupResumen;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(349, 199);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.cmdCerrarSesion);
            this.pnlBotones.Controls.Add(this.cmdSalidaAlmuerzo);
            this.pnlBotones.Controls.Add(this.cmdPersonalTiempo);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(3, 71);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(343, 125);
            this.pnlBotones.TabIndex = 3;
            // 
            // cmdCerrarSesion
            // 
            this.cmdCerrarSesion.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCerrarSesion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrarSesion.Appearance.Options.UseBackColor = true;
            this.cmdCerrarSesion.Appearance.Options.UseFont = true;
            this.cmdCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdCerrarSesion.Location = new System.Drawing.Point(0, 80);
            this.cmdCerrarSesion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdCerrarSesion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdCerrarSesion.Name = "cmdCerrarSesion";
            this.cmdCerrarSesion.Size = new System.Drawing.Size(343, 40);
            this.cmdCerrarSesion.TabIndex = 2;
            this.cmdCerrarSesion.Text = "CERRAR SESIÓN";
            this.cmdCerrarSesion.Click += new System.EventHandler(this.cmdCerrarSesion_Click);
            // 
            // cmdSalidaAlmuerzo
            // 
            this.cmdSalidaAlmuerzo.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdSalidaAlmuerzo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalidaAlmuerzo.Appearance.Options.UseBackColor = true;
            this.cmdSalidaAlmuerzo.Appearance.Options.UseFont = true;
            this.cmdSalidaAlmuerzo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdSalidaAlmuerzo.Location = new System.Drawing.Point(0, 40);
            this.cmdSalidaAlmuerzo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdSalidaAlmuerzo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdSalidaAlmuerzo.Name = "cmdSalidaAlmuerzo";
            this.cmdSalidaAlmuerzo.Size = new System.Drawing.Size(343, 40);
            this.cmdSalidaAlmuerzo.TabIndex = 1;
            this.cmdSalidaAlmuerzo.Text = "SALIDA ALMUERZO";
            this.cmdSalidaAlmuerzo.Click += new System.EventHandler(this.cmdSalidaAlmuerzo_Click);
            // 
            // cmdPersonalTiempo
            // 
            this.cmdPersonalTiempo.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdPersonalTiempo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPersonalTiempo.Appearance.Options.UseBackColor = true;
            this.cmdPersonalTiempo.Appearance.Options.UseFont = true;
            this.cmdPersonalTiempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdPersonalTiempo.Location = new System.Drawing.Point(0, 0);
            this.cmdPersonalTiempo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdPersonalTiempo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdPersonalTiempo.Name = "cmdPersonalTiempo";
            this.cmdPersonalTiempo.Size = new System.Drawing.Size(343, 40);
            this.cmdPersonalTiempo.TabIndex = 0;
            this.cmdPersonalTiempo.Text = "SALIDA POR TIEMPO PERSONAL";
            this.cmdPersonalTiempo.Click += new System.EventHandler(this.cmdPersonalTiempo_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Appearance.Options.UseFont = true;
            this.lblPosicion.Appearance.Options.UseTextOptions = true;
            this.lblPosicion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPosicion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPosicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPosicion.Location = new System.Drawing.Point(3, 37);
            this.lblPosicion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.lblPosicion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPosicion.Size = new System.Drawing.Size(343, 34);
            this.lblPosicion.TabIndex = 2;
            this.lblPosicion.Text = "NOMBRE DE USUARIO";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Appearance.Options.UseFont = true;
            this.lblNombreUsuario.Appearance.Options.UseTextOptions = true;
            this.lblNombreUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNombreUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Location = new System.Drawing.Point(3, 3);
            this.lblNombreUsuario.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.lblNombreUsuario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(343, 34);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "NOMBRE DE USUARIO";
            // 
            // PageOperacionalReducido
            // 
            this.PageOperacionalReducido.Caption = "PageOperacionalReducido";
            this.PageOperacionalReducido.Controls.Add(this.ctlOperacionalReducido1);
            this.PageOperacionalReducido.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.PageOperacionalReducido.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PageOperacionalReducido.Name = "PageOperacionalReducido";
            this.PageOperacionalReducido.Size = new System.Drawing.Size(1106, 441);
            // 
            // ctlOperacionalReducido1
            // 
            this.ctlOperacionalReducido1.BackColor = System.Drawing.Color.White;
            this.ctlOperacionalReducido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlOperacionalReducido1.Location = new System.Drawing.Point(0, 0);
            this.ctlOperacionalReducido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlOperacionalReducido1.Name = "ctlOperacionalReducido1";
            this.ctlOperacionalReducido1.Padding = new System.Windows.Forms.Padding(3);
            this.ctlOperacionalReducido1.Size = new System.Drawing.Size(1106, 441);
            this.ctlOperacionalReducido1.TabIndex = 0;
            // 
            // tmrAlerta
            // 
            this.tmrAlerta.Interval = 300;
            this.tmrAlerta.Tick += new System.EventHandler(this.tmrAlerta_Tick);
            // 
            // CtlOperacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Navigation);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtlOperacional";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1116, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlResumen.ResumeLayout(false);
            this.pnlEncabezadoResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario.Properties)).EndInit();
            this.pnlControlesDeCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdRellamar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClienteNoAtendioLlamado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLlamarCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIniciarTicket.Properties)).EndInit();
            this.pnlInformacionTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Navigation)).EndInit();
            this.Navigation.ResumeLayout(false);
            this.pagePrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlListaTickets.ResumeLayout(false);
            this.PagePopups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupResumen)).EndInit();
            this.popupResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.PageOperacionalReducido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PictureEdit picUsuario;
        private DevExpress.XtraEditors.PanelControl pnlEncabezado;
        private System.Windows.Forms.Panel pnlControlesDeCola;
        private System.Windows.Forms.Panel pnlInformacionTickets;
        private DevExpress.XtraEditors.LabelControl lblCerrarTicket;
        private DevExpress.XtraEditors.LabelControl lblIniciarTicket;
        private DevExpress.XtraEditors.PictureEdit cmdCerrarTicket;
        private DevExpress.XtraEditors.PictureEdit cmdIniciarTicket;
        private System.Windows.Forms.Timer tmrTiempoAtencion;
        private System.Windows.Forms.Timer tmrParoTiempo;
        private DevExpress.XtraEditors.LabelControl lblLlamarCliente;
        private DevExpress.XtraEditors.PictureEdit cmdLlamarCliente;
        private DevExpress.XtraEditors.LabelControl lblMarcarComoNoRespondioLlamado;
        private DevExpress.XtraEditors.PictureEdit cmdClienteNoAtendioLlamado;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Panel pnlEncabezadoResumen;
        private DevExpress.XtraBars.Navigation.NavigationPage PagePopups;
        private DevExpress.Utils.FlyoutPanel popupResumen;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private System.Windows.Forms.Panel pnlBotones;
        private DevExpress.XtraEditors.SimpleButton cmdCerrarSesion;
        private DevExpress.XtraEditors.SimpleButton cmdSalidaAlmuerzo;
        private DevExpress.XtraEditors.SimpleButton cmdPersonalTiempo;
        private DevExpress.XtraEditors.LabelControl lblPosicion;
        private DevExpress.XtraEditors.LabelControl lblNombreUsuario;
        private DevExpress.XtraEditors.LabelControl lblRellamar;
        private DevExpress.XtraEditors.PictureEdit cmdRellamar;
        private System.Windows.Forms.Panel pnlDetalleResumen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlListaTickets;
        public ctlOperacionalReducido ctlOperacionalReducido1;
        public DevExpress.XtraBars.Navigation.NavigationFrame Navigation;
        public DevExpress.XtraBars.Navigation.NavigationPage PageOperacionalReducido;
        public DevExpress.XtraBars.Navigation.NavigationPage pagePrincipal;
        public ctlListaTicketsEspera ctlListaTicketsEspera1;
        private DevExpress.XtraEditors.LabelControl lblAgencia;
        public DevExpress.XtraEditors.LabelControl lblNumeroTicket;
        public DevExpress.XtraEditors.LabelControl lblTiempoAtencion;
        private System.Windows.Forms.Timer tmrAlerta;
    }
}
