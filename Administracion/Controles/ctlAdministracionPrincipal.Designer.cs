namespace Administracion.Controles
{
    partial class ctlAdministracionPrincipal
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
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.picConfiguracion = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.picMantenimiento = new DevExpress.XtraEditors.PictureEdit();
            this.picAsignarPosiciones = new DevExpress.XtraEditors.PictureEdit();
            this.picTasasCambio = new DevExpress.XtraEditors.PictureEdit();
            this.cmdDashboards = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoInstitucion = new DevExpress.XtraEditors.PictureEdit();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageDashboardPrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlContenedorDashboards1 = new Core.Controles.Dashboards.ctlContenedorDashboards();
            this.PageAgenciasDisponibles = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageTasaCambio = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageAsignacionPosiciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlAsignacionPosiciones1 = new Core.Controles.Configuraciones.ctlAsignacionPosiciones();
            this.PageMantenimientoEmpleados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlMantenimientoUsuarios1 = new Core.Controles.Configuraciones.ctlMantenimientoUsuarios();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new DevExpress.XtraEditors.LabelControl();
            this.ctlAgenciasDisponiblesParaDashboards1 = new Administracion.Controles.ctlAgenciasDisponiblesParaDashboards();
            this.ctlMantenimientoTasaCambio1 = new Administracion.Controles.Configuraciones.ctlMantenimientoTasaCambio();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfiguracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMantenimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsignarPosiciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTasasCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.PageDashboardPrincipal.SuspendLayout();
            this.PageAgenciasDisponibles.SuspendLayout();
            this.PageTasaCambio.SuspendLayout();
            this.PageAsignacionPosiciones.SuspendLayout();
            this.PageMantenimientoEmpleados.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.picConfiguracion);
            this.pnlIzquierdo.Controls.Add(this.pictureEdit3);
            this.pnlIzquierdo.Controls.Add(this.picMantenimiento);
            this.pnlIzquierdo.Controls.Add(this.picAsignarPosiciones);
            this.pnlIzquierdo.Controls.Add(this.picTasasCambio);
            this.pnlIzquierdo.Controls.Add(this.cmdDashboards);
            this.pnlIzquierdo.Controls.Add(this.panel3);
            this.pnlIzquierdo.Controls.Add(this.panel2);
            this.pnlIzquierdo.Controls.Add(this.panel1);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(5, 5);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(197, 865);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // picConfiguracion
            // 
            this.picConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.picConfiguracion.EditValue = global::Administracion.Properties.Resources.icon_configuracion_64;
            this.picConfiguracion.Location = new System.Drawing.Point(40, 565);
            this.picConfiguracion.Name = "picConfiguracion";
            this.picConfiguracion.Properties.AllowFocused = false;
            this.picConfiguracion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picConfiguracion.Properties.NullText = " ";
            this.picConfiguracion.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.picConfiguracion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picConfiguracion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picConfiguracion.Size = new System.Drawing.Size(117, 96);
            this.picConfiguracion.TabIndex = 8;
            this.picConfiguracion.ToolTip = "Mantenimiento de Empleados";
            this.picConfiguracion.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picConfiguracion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picConfiguracion.ToolTipTitle = "FLUCOL";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureEdit3.EditValue = global::Administracion.Properties.Resources.icon_cerrar_sesion_64;
            this.pictureEdit3.Location = new System.Drawing.Point(40, 769);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.AllowFocused = false;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.NullText = " ";
            this.pictureEdit3.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit3.Size = new System.Drawing.Size(117, 96);
            this.pictureEdit3.TabIndex = 7;
            this.pictureEdit3.ToolTip = "Mantenimiento de Empleados";
            this.pictureEdit3.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.pictureEdit3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.pictureEdit3.ToolTipTitle = "FLUCOL";
            // 
            // picMantenimiento
            // 
            this.picMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.picMantenimiento.EditValue = global::Administracion.Properties.Resources.iconUsuario;
            this.picMantenimiento.Location = new System.Drawing.Point(40, 469);
            this.picMantenimiento.Name = "picMantenimiento";
            this.picMantenimiento.Properties.AllowFocused = false;
            this.picMantenimiento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picMantenimiento.Properties.NullText = " ";
            this.picMantenimiento.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.picMantenimiento.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picMantenimiento.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picMantenimiento.Size = new System.Drawing.Size(117, 96);
            this.picMantenimiento.TabIndex = 6;
            this.picMantenimiento.ToolTip = "Mantenimiento de Empleados";
            this.picMantenimiento.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picMantenimiento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picMantenimiento.ToolTipTitle = "FLUCOL";
            this.picMantenimiento.Click += new System.EventHandler(this.PicMantenimiento_Click);
            // 
            // picAsignarPosiciones
            // 
            this.picAsignarPosiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAsignarPosiciones.EditValue = global::Administracion.Properties.Resources.icon_posiciones64;
            this.picAsignarPosiciones.Location = new System.Drawing.Point(40, 366);
            this.picAsignarPosiciones.Name = "picAsignarPosiciones";
            this.picAsignarPosiciones.Properties.AllowFocused = false;
            this.picAsignarPosiciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAsignarPosiciones.Properties.NullText = " ";
            this.picAsignarPosiciones.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.picAsignarPosiciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAsignarPosiciones.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAsignarPosiciones.Size = new System.Drawing.Size(117, 103);
            this.picAsignarPosiciones.TabIndex = 5;
            this.picAsignarPosiciones.ToolTip = "Asignar Posiciones";
            this.picAsignarPosiciones.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picAsignarPosiciones.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picAsignarPosiciones.ToolTipTitle = "FLUCOL";
            this.picAsignarPosiciones.Click += new System.EventHandler(this.PicAsignarPosiciones_Click);
            // 
            // picTasasCambio
            // 
            this.picTasasCambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.picTasasCambio.EditValue = global::Administracion.Properties.Resources.icon_tasa_cambio_64;
            this.picTasasCambio.Location = new System.Drawing.Point(40, 263);
            this.picTasasCambio.Name = "picTasasCambio";
            this.picTasasCambio.Properties.AllowFocused = false;
            this.picTasasCambio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTasasCambio.Properties.NullText = " ";
            this.picTasasCambio.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.picTasasCambio.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picTasasCambio.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picTasasCambio.Size = new System.Drawing.Size(117, 103);
            this.picTasasCambio.TabIndex = 4;
            this.picTasasCambio.ToolTip = "Tasa de Cambio\r\n";
            this.picTasasCambio.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picTasasCambio.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picTasasCambio.ToolTipTitle = "FLUCOL";
            this.picTasasCambio.Click += new System.EventHandler(this.PicTasasCambio_Click);
            // 
            // cmdDashboards
            // 
            this.cmdDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdDashboards.EditValue = global::Administracion.Properties.Resources.icon_dashboard_64;
            this.cmdDashboards.Location = new System.Drawing.Point(40, 160);
            this.cmdDashboards.Name = "cmdDashboards";
            this.cmdDashboards.Properties.AllowFocused = false;
            this.cmdDashboards.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdDashboards.Properties.NullText = " ";
            this.cmdDashboards.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmdDashboards.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdDashboards.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdDashboards.Size = new System.Drawing.Size(117, 103);
            this.cmdDashboards.TabIndex = 3;
            this.cmdDashboards.ToolTip = "Dashboards\r\n";
            this.cmdDashboards.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdDashboards.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdDashboards.ToolTipTitle = "FLUCOL";
            this.cmdDashboards.Click += new System.EventHandler(this.CmdDashboards_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(157, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 705);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 705);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLogoInstitucion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 160);
            this.panel1.TabIndex = 0;
            // 
            // picLogoInstitucion
            // 
            this.picLogoInstitucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogoInstitucion.Location = new System.Drawing.Point(0, 0);
            this.picLogoInstitucion.Name = "picLogoInstitucion";
            this.picLogoInstitucion.Properties.AllowFocused = false;
            this.picLogoInstitucion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoInstitucion.Properties.NullText = " ";
            this.picLogoInstitucion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoInstitucion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogoInstitucion.Size = new System.Drawing.Size(197, 160);
            this.picLogoInstitucion.TabIndex = 0;
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavigationPrincipal.Controls.Add(this.PageDashboardPrincipal);
            this.NavigationPrincipal.Controls.Add(this.PageAgenciasDisponibles);
            this.NavigationPrincipal.Controls.Add(this.PageInicial);
            this.NavigationPrincipal.Controls.Add(this.PageTasaCambio);
            this.NavigationPrincipal.Controls.Add(this.PageAsignacionPosiciones);
            this.NavigationPrincipal.Controls.Add(this.PageMantenimientoEmpleados);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(202, 42);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageDashboardPrincipal,
            this.PageAgenciasDisponibles,
            this.PageInicial,
            this.PageTasaCambio,
            this.PageAsignacionPosiciones,
            this.PageMantenimientoEmpleados});
            this.NavigationPrincipal.SelectedPage = this.PageInicial;
            this.NavigationPrincipal.Size = new System.Drawing.Size(936, 828);
            this.NavigationPrincipal.TabIndex = 1;
            this.NavigationPrincipal.Text = "navigationFrame1";
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageDashboardPrincipal
            // 
            this.PageDashboardPrincipal.Caption = "PageDashboardPrincipal";
            this.PageDashboardPrincipal.Controls.Add(this.ctlContenedorDashboards1);
            this.PageDashboardPrincipal.Name = "PageDashboardPrincipal";
            this.PageDashboardPrincipal.Size = new System.Drawing.Size(936, 828);
            // 
            // ctlContenedorDashboards1
            // 
            this.ctlContenedorDashboards1.BackColor = System.Drawing.Color.White;
            this.ctlContenedorDashboards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlContenedorDashboards1.Location = new System.Drawing.Point(0, 0);
            this.ctlContenedorDashboards1.Name = "ctlContenedorDashboards1";
            this.ctlContenedorDashboards1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlContenedorDashboards1.Pro_Conexion = null;
            this.ctlContenedorDashboards1.Pro_ID_Agencia = 0;
            this.ctlContenedorDashboards1.Pro_ID_Cliente_Servicio = 0;
            this.ctlContenedorDashboards1.Pro_NombreAgencia = null;
            this.ctlContenedorDashboards1.Size = new System.Drawing.Size(936, 828);
            this.ctlContenedorDashboards1.TabIndex = 0;
            // 
            // PageAgenciasDisponibles
            // 
            this.PageAgenciasDisponibles.Caption = "PageAgenciasDisponibles";
            this.PageAgenciasDisponibles.Controls.Add(this.ctlAgenciasDisponiblesParaDashboards1);
            this.PageAgenciasDisponibles.Name = "PageAgenciasDisponibles";
            this.PageAgenciasDisponibles.Size = new System.Drawing.Size(936, 828);
            // 
            // PageInicial
            // 
            this.PageInicial.Caption = "PageInicial";
            this.PageInicial.Name = "PageInicial";
            this.PageInicial.Size = new System.Drawing.Size(936, 828);
            // 
            // PageTasaCambio
            // 
            this.PageTasaCambio.Caption = "PageTasaCambio";
            this.PageTasaCambio.Controls.Add(this.ctlMantenimientoTasaCambio1);
            this.PageTasaCambio.Name = "PageTasaCambio";
            this.PageTasaCambio.Size = new System.Drawing.Size(936, 828);
            // 
            // PageAsignacionPosiciones
            // 
            this.PageAsignacionPosiciones.Caption = "PageAsignacionPosiciones";
            this.PageAsignacionPosiciones.Controls.Add(this.ctlAsignacionPosiciones1);
            this.PageAsignacionPosiciones.Name = "PageAsignacionPosiciones";
            this.PageAsignacionPosiciones.Size = new System.Drawing.Size(936, 828);
            // 
            // ctlAsignacionPosiciones1
            // 
            this.ctlAsignacionPosiciones1.BackColor = System.Drawing.Color.White;
            this.ctlAsignacionPosiciones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlAsignacionPosiciones1.Location = new System.Drawing.Point(0, 0);
            this.ctlAsignacionPosiciones1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlAsignacionPosiciones1.Name = "ctlAsignacionPosiciones1";
            this.ctlAsignacionPosiciones1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlAsignacionPosiciones1.Pro_Conexion = null;
            this.ctlAsignacionPosiciones1.Pro_ID_Agencia_Servicio = 0;
            this.ctlAsignacionPosiciones1.Pro_ID_Cliente_Servicio = 0;
            this.ctlAsignacionPosiciones1.Pro_Usuario = null;
            this.ctlAsignacionPosiciones1.Pro_UsuarioSeleccionado = null;
            this.ctlAsignacionPosiciones1.Size = new System.Drawing.Size(936, 828);
            this.ctlAsignacionPosiciones1.TabIndex = 0;
            // 
            // PageMantenimientoEmpleados
            // 
            this.PageMantenimientoEmpleados.Caption = "PageMantenimientoEmpleados";
            this.PageMantenimientoEmpleados.Controls.Add(this.ctlMantenimientoUsuarios1);
            this.PageMantenimientoEmpleados.Name = "PageMantenimientoEmpleados";
            this.PageMantenimientoEmpleados.Size = new System.Drawing.Size(936, 828);
            // 
            // ctlMantenimientoUsuarios1
            // 
            this.ctlMantenimientoUsuarios1.BackColor = System.Drawing.Color.White;
            this.ctlMantenimientoUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMantenimientoUsuarios1.Location = new System.Drawing.Point(0, 0);
            this.ctlMantenimientoUsuarios1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMantenimientoUsuarios1.Name = "ctlMantenimientoUsuarios1";
            this.ctlMantenimientoUsuarios1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlMantenimientoUsuarios1.Pro_Conexion = null;
            this.ctlMantenimientoUsuarios1.Pro_ID_AgenciaServicio = 0;
            this.ctlMantenimientoUsuarios1.Pro_ID_ClienteServicio = 0;
            this.ctlMantenimientoUsuarios1.Pro_Usuario = null;
            this.ctlMantenimientoUsuarios1.Size = new System.Drawing.Size(936, 828);
            this.ctlMantenimientoUsuarios1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblNombreUsuario);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(202, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(936, 37);
            this.panel4.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Appearance.Options.UseFont = true;
            this.lblNombreUsuario.Appearance.Options.UseTextOptions = true;
            this.lblNombreUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblNombreUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(931, 37);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "NOMBRE DE USUARIO";
            // 
            // ctlAgenciasDisponiblesParaDashboards1
            // 
            this.ctlAgenciasDisponiblesParaDashboards1.BackColor = System.Drawing.Color.White;
            this.ctlAgenciasDisponiblesParaDashboards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlAgenciasDisponiblesParaDashboards1.Location = new System.Drawing.Point(0, 0);
            this.ctlAgenciasDisponiblesParaDashboards1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlAgenciasDisponiblesParaDashboards1.Name = "ctlAgenciasDisponiblesParaDashboards1";
            this.ctlAgenciasDisponiblesParaDashboards1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctlAgenciasDisponiblesParaDashboards1.Pro_Conexion = null;
            this.ctlAgenciasDisponiblesParaDashboards1.Pro_ID_ClienteServicio = 0;
            this.ctlAgenciasDisponiblesParaDashboards1.Size = new System.Drawing.Size(936, 828);
            this.ctlAgenciasDisponiblesParaDashboards1.TabIndex = 0;
            // 
            // ctlMantenimientoTasaCambio1
            // 
            this.ctlMantenimientoTasaCambio1.BackColor = System.Drawing.Color.White;
            this.ctlMantenimientoTasaCambio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMantenimientoTasaCambio1.Location = new System.Drawing.Point(0, 0);
            this.ctlMantenimientoTasaCambio1.Name = "ctlMantenimientoTasaCambio1";
            this.ctlMantenimientoTasaCambio1.Pro_Conexion = null;
            this.ctlMantenimientoTasaCambio1.Pro_Usuario = null;
            this.ctlMantenimientoTasaCambio1.Size = new System.Drawing.Size(936, 828);
            this.ctlMantenimientoTasaCambio1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(931, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 37);
            this.panel5.TabIndex = 4;
            // 
            // ctlAdministracionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlIzquierdo);
            this.Name = "ctlAdministracionPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1143, 875);
            this.pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picConfiguracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMantenimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsignarPosiciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTasasCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.PageDashboardPrincipal.ResumeLayout(false);
            this.PageAgenciasDisponibles.ResumeLayout(false);
            this.PageTasaCambio.ResumeLayout(false);
            this.PageAsignacionPosiciones.ResumeLayout(false);
            this.PageMantenimientoEmpleados.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private DevExpress.XtraEditors.PictureEdit picTasasCambio;
        private DevExpress.XtraEditors.PictureEdit cmdDashboards;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picLogoInstitucion;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDashboardPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageAgenciasDisponibles;
        private Core.Controles.Dashboards.ctlContenedorDashboards ctlContenedorDashboards1;
        private ctlAgenciasDisponiblesParaDashboards ctlAgenciasDisponiblesParaDashboards1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageInicial;
        private DevExpress.XtraBars.Navigation.NavigationPage PageTasaCambio;
        private Configuraciones.ctlMantenimientoTasaCambio ctlMantenimientoTasaCambio1;
        private DevExpress.XtraEditors.PictureEdit picAsignarPosiciones;
        private DevExpress.XtraEditors.PictureEdit picMantenimiento;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit picConfiguracion;
        private DevExpress.XtraBars.Navigation.NavigationPage PageAsignacionPosiciones;
        private DevExpress.XtraBars.Navigation.NavigationPage PageMantenimientoEmpleados;
        private Core.Controles.Configuraciones.ctlMantenimientoUsuarios ctlMantenimientoUsuarios1;
        private Core.Controles.Configuraciones.ctlAsignacionPosiciones ctlAsignacionPosiciones1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblNombreUsuario;
        private System.Windows.Forms.Panel panel5;
    }
}
