namespace Operaciones.Controles
{
    partial class ctlOperacionesSupervisor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdCerrarSesion = new DevExpress.XtraEditors.PictureEdit();
            this.cmdMantenimientoEmpleados = new DevExpress.XtraEditors.PictureEdit();
            this.cmdAsignarPosiciones = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageAsignacionesTraslados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.NavigationAsignacionesTraslados = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageTraslados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlTrasladosEmpleadosServicio1 = new Operaciones.Controles.Configuraciones.ctlTrasladosEmpleadosServicio();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pageAsignaciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlContenedorAsignaciones = new System.Windows.Forms.Panel();
            this.ctlAsignacionPosiciones1 = new Operaciones.Controles.Configuraciones.ctlAsignacionPosiciones();
            this.lblTituloDashboardPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.cmdTrasladarEmpleados = new DevExpress.XtraEditors.PictureEdit();
            this.cmdAsignarPosicionesEmpleados = new DevExpress.XtraEditors.PictureEdit();
            this.pageConfiguraciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageMantenimientoEmpleados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlMantenimientoUsuarios1 = new Operaciones.Controles.Configuraciones.ctlMantenimientoUsuarios();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Operaciones.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.lblAgencia = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNombreEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarSesion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMantenimientoEmpleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPosiciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.pageAsignacionesTraslados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationAsignacionesTraslados)).BeginInit();
            this.NavigationAsignacionesTraslados.SuspendLayout();
            this.pageTraslados.SuspendLayout();
            this.pageAsignaciones.SuspendLayout();
            this.pnlContenedorAsignaciones.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTrasladarEmpleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPosicionesEmpleados.Properties)).BeginInit();
            this.PageMantenimientoEmpleados.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picLogoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(115, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdCerrarSesion);
            this.panel2.Controls.Add(this.cmdMantenimientoEmpleados);
            this.panel2.Controls.Add(this.cmdAsignarPosiciones);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 396);
            this.panel2.TabIndex = 1;
            // 
            // cmdCerrarSesion
            // 
            this.cmdCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdCerrarSesion.EditValue = global::Operaciones.Properties.Resources.icon_cerrar_sesion_64;
            this.cmdCerrarSesion.Location = new System.Drawing.Point(19, 327);
            this.cmdCerrarSesion.Name = "cmdCerrarSesion";
            this.cmdCerrarSesion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCerrarSesion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCerrarSesion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCerrarSesion.Size = new System.Drawing.Size(65, 69);
            this.cmdCerrarSesion.TabIndex = 4;
            this.cmdCerrarSesion.ToolTip = "Cerrar Sesion\r\n";
            this.cmdCerrarSesion.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdCerrarSesion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdCerrarSesion.ToolTipTitle = "FLUCOL";
            this.cmdCerrarSesion.Click += new System.EventHandler(this.cmdCerrarSesion_Click);
            // 
            // cmdMantenimientoEmpleados
            // 
            this.cmdMantenimientoEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdMantenimientoEmpleados.EditValue = global::Operaciones.Properties.Resources.iconUsuario;
            this.cmdMantenimientoEmpleados.Location = new System.Drawing.Point(19, 69);
            this.cmdMantenimientoEmpleados.Name = "cmdMantenimientoEmpleados";
            this.cmdMantenimientoEmpleados.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdMantenimientoEmpleados.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdMantenimientoEmpleados.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdMantenimientoEmpleados.Size = new System.Drawing.Size(65, 69);
            this.cmdMantenimientoEmpleados.TabIndex = 3;
            this.cmdMantenimientoEmpleados.ToolTip = "Mantenimiento de Empleados\r\n";
            this.cmdMantenimientoEmpleados.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdMantenimientoEmpleados.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdMantenimientoEmpleados.ToolTipTitle = "FLUCOL";
            this.cmdMantenimientoEmpleados.Click += new System.EventHandler(this.cmdMantenimientoEmpleados_Click);
            // 
            // cmdAsignarPosiciones
            // 
            this.cmdAsignarPosiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdAsignarPosiciones.EditValue = global::Operaciones.Properties.Resources.icon_posiciones64;
            this.cmdAsignarPosiciones.Location = new System.Drawing.Point(19, 0);
            this.cmdAsignarPosiciones.Name = "cmdAsignarPosiciones";
            this.cmdAsignarPosiciones.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdAsignarPosiciones.Properties.AllowFocused = false;
            this.cmdAsignarPosiciones.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdAsignarPosiciones.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdAsignarPosiciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAsignarPosiciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAsignarPosiciones.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAsignarPosiciones.Size = new System.Drawing.Size(65, 69);
            this.cmdAsignarPosiciones.TabIndex = 2;
            this.cmdAsignarPosiciones.ToolTip = "Mantenimiento Posiciones en Agencia\r\n";
            this.cmdAsignarPosiciones.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdAsignarPosiciones.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdAsignarPosiciones.ToolTipTitle = "FLUCOL";
            this.cmdAsignarPosiciones.Click += new System.EventHandler(this.cmdAsignarPosiciones_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(84, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 396);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 396);
            this.panel3.TabIndex = 0;
            // 
            // picLogoCliente
            // 
            this.picLogoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoCliente.Location = new System.Drawing.Point(5, 5);
            this.picLogoCliente.Name = "picLogoCliente";
            this.picLogoCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoCliente.Properties.NullText = " ";
            this.picLogoCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogoCliente.Size = new System.Drawing.Size(103, 96);
            this.picLogoCliente.TabIndex = 0;
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.Appearance.BackColor = System.Drawing.Color.White;
            this.NavigationPrincipal.Appearance.Options.UseBackColor = true;
            this.NavigationPrincipal.Controls.Add(this.pageAsignacionesTraslados);
            this.NavigationPrincipal.Controls.Add(this.pageConfiguraciones);
            this.NavigationPrincipal.Controls.Add(this.PageMantenimientoEmpleados);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(120, 47);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageAsignacionesTraslados,
            this.pageConfiguraciones,
            this.PageMantenimientoEmpleados});
            this.NavigationPrincipal.SelectedPage = this.pageConfiguraciones;
            this.NavigationPrincipal.Size = new System.Drawing.Size(992, 462);
            this.NavigationPrincipal.TabIndex = 1;
            this.NavigationPrincipal.Text = "navigationFrame1";
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pageAsignacionesTraslados
            // 
            this.pageAsignacionesTraslados.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pageAsignacionesTraslados.Caption = "pageAsignacionesTraslados";
            this.pageAsignacionesTraslados.Controls.Add(this.NavigationAsignacionesTraslados);
            this.pageAsignacionesTraslados.Controls.Add(this.pnlAcciones);
            this.pageAsignacionesTraslados.Name = "pageAsignacionesTraslados";
            this.pageAsignacionesTraslados.Size = new System.Drawing.Size(992, 462);
            // 
            // NavigationAsignacionesTraslados
            // 
            this.NavigationAsignacionesTraslados.Appearance.BackColor = System.Drawing.Color.White;
            this.NavigationAsignacionesTraslados.Appearance.Options.UseBackColor = true;
            this.NavigationAsignacionesTraslados.Controls.Add(this.pageTraslados);
            this.NavigationAsignacionesTraslados.Controls.Add(this.pageAsignaciones);
            this.NavigationAsignacionesTraslados.Controls.Add(this.navigationPage1);
            this.NavigationAsignacionesTraslados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationAsignacionesTraslados.Location = new System.Drawing.Point(0, 46);
            this.NavigationAsignacionesTraslados.Name = "NavigationAsignacionesTraslados";
            this.NavigationAsignacionesTraslados.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageAsignaciones,
            this.pageTraslados,
            this.navigationPage1});
            this.NavigationAsignacionesTraslados.SelectedPage = this.navigationPage1;
            this.NavigationAsignacionesTraslados.Size = new System.Drawing.Size(992, 416);
            this.NavigationAsignacionesTraslados.TabIndex = 0;
            this.NavigationAsignacionesTraslados.Text = "navigationFrame1";
            this.NavigationAsignacionesTraslados.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationAsignacionesTraslados.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pageTraslados
            // 
            this.pageTraslados.Caption = "pageTraslados";
            this.pageTraslados.Controls.Add(this.ctlTrasladosEmpleadosServicio1);
            this.pageTraslados.Controls.Add(this.labelControl1);
            this.pageTraslados.Name = "pageTraslados";
            this.pageTraslados.Size = new System.Drawing.Size(992, 416);
            // 
            // ctlTrasladosEmpleadosServicio1
            // 
            this.ctlTrasladosEmpleadosServicio1.BackColor = System.Drawing.Color.White;
            this.ctlTrasladosEmpleadosServicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTrasladosEmpleadosServicio1.Location = new System.Drawing.Point(0, 31);
            this.ctlTrasladosEmpleadosServicio1.Name = "ctlTrasladosEmpleadosServicio1";
            this.ctlTrasladosEmpleadosServicio1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTrasladosEmpleadosServicio1.Pro_CodigoEmpleadoSelecciondo = null;
            this.ctlTrasladosEmpleadosServicio1.Pro_Conexion = null;
            this.ctlTrasladosEmpleadosServicio1.Pro_ID_AgenciaServicio = 0;
            this.ctlTrasladosEmpleadosServicio1.Pro_ID_AgenciaServicioSeleccionado = 0;
            this.ctlTrasladosEmpleadosServicio1.Pro_ID_ClienteServicio = 0;
            this.ctlTrasladosEmpleadosServicio1.Pro_Usuario = null;
            this.ctlTrasladosEmpleadosServicio1.Size = new System.Drawing.Size(992, 385);
            this.ctlTrasladosEmpleadosServicio1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(992, 31);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "TRASLADOS";
            // 
            // pageAsignaciones
            // 
            this.pageAsignaciones.Caption = "pageAsignaciones";
            this.pageAsignaciones.Controls.Add(this.pnlContenedorAsignaciones);
            this.pageAsignaciones.Controls.Add(this.lblTituloDashboardPrincipal);
            this.pageAsignaciones.Name = "pageAsignaciones";
            this.pageAsignaciones.Size = new System.Drawing.Size(992, 416);
            // 
            // pnlContenedorAsignaciones
            // 
            this.pnlContenedorAsignaciones.BackColor = System.Drawing.Color.White;
            this.pnlContenedorAsignaciones.Controls.Add(this.ctlAsignacionPosiciones1);
            this.pnlContenedorAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorAsignaciones.Location = new System.Drawing.Point(0, 31);
            this.pnlContenedorAsignaciones.Name = "pnlContenedorAsignaciones";
            this.pnlContenedorAsignaciones.Size = new System.Drawing.Size(992, 385);
            this.pnlContenedorAsignaciones.TabIndex = 5;
            // 
            // ctlAsignacionPosiciones1
            // 
            this.ctlAsignacionPosiciones1.BackColor = System.Drawing.Color.White;
            this.ctlAsignacionPosiciones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlAsignacionPosiciones1.Location = new System.Drawing.Point(0, 0);
            this.ctlAsignacionPosiciones1.Name = "ctlAsignacionPosiciones1";
            this.ctlAsignacionPosiciones1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlAsignacionPosiciones1.Pro_Conexion = null;
            this.ctlAsignacionPosiciones1.Pro_ID_Agencia_Servicio = 0;
            this.ctlAsignacionPosiciones1.Pro_ID_Cliente_Servicio = 0;
            this.ctlAsignacionPosiciones1.Pro_Usuario = null;
            this.ctlAsignacionPosiciones1.Pro_UsuarioSeleccionado = null;
            this.ctlAsignacionPosiciones1.Size = new System.Drawing.Size(992, 385);
            this.ctlAsignacionPosiciones1.TabIndex = 0;
            // 
            // lblTituloDashboardPrincipal
            // 
            this.lblTituloDashboardPrincipal.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTituloDashboardPrincipal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDashboardPrincipal.Appearance.Options.UseBackColor = true;
            this.lblTituloDashboardPrincipal.Appearance.Options.UseFont = true;
            this.lblTituloDashboardPrincipal.Appearance.Options.UseTextOptions = true;
            this.lblTituloDashboardPrincipal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloDashboardPrincipal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTituloDashboardPrincipal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloDashboardPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloDashboardPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lblTituloDashboardPrincipal.Name = "lblTituloDashboardPrincipal";
            this.lblTituloDashboardPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.lblTituloDashboardPrincipal.Size = new System.Drawing.Size(992, 31);
            this.lblTituloDashboardPrincipal.TabIndex = 3;
            this.lblTituloDashboardPrincipal.Text = "ASIGNACION DE POSICIONES";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(992, 416);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.White;
            this.pnlAcciones.Controls.Add(this.cmdTrasladarEmpleados);
            this.pnlAcciones.Controls.Add(this.cmdAsignarPosicionesEmpleados);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAcciones.Size = new System.Drawing.Size(992, 46);
            this.pnlAcciones.TabIndex = 3;
            // 
            // cmdTrasladarEmpleados
            // 
            this.cmdTrasladarEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdTrasladarEmpleados.EditValue = global::Operaciones.Properties.Resources.icon_traslados_64;
            this.cmdTrasladarEmpleados.Location = new System.Drawing.Point(69, 5);
            this.cmdTrasladarEmpleados.Name = "cmdTrasladarEmpleados";
            this.cmdTrasladarEmpleados.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdTrasladarEmpleados.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdTrasladarEmpleados.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdTrasladarEmpleados.Size = new System.Drawing.Size(64, 36);
            this.cmdTrasladarEmpleados.TabIndex = 4;
            this.cmdTrasladarEmpleados.ToolTip = "Traslado de Empleados a esta Sucursal";
            this.cmdTrasladarEmpleados.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdTrasladarEmpleados.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdTrasladarEmpleados.ToolTipTitle = "FLUCOL";
            this.cmdTrasladarEmpleados.Click += new System.EventHandler(this.cmdTrasladarEmpleados_Click);
            // 
            // cmdAsignarPosicionesEmpleados
            // 
            this.cmdAsignarPosicionesEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAsignarPosicionesEmpleados.EditValue = global::Operaciones.Properties.Resources.icon_asignar_posiciones_64;
            this.cmdAsignarPosicionesEmpleados.Location = new System.Drawing.Point(5, 5);
            this.cmdAsignarPosicionesEmpleados.Name = "cmdAsignarPosicionesEmpleados";
            this.cmdAsignarPosicionesEmpleados.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAsignarPosicionesEmpleados.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAsignarPosicionesEmpleados.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAsignarPosicionesEmpleados.Size = new System.Drawing.Size(64, 36);
            this.cmdAsignarPosicionesEmpleados.TabIndex = 3;
            this.cmdAsignarPosicionesEmpleados.ToolTip = "Asignar posiciones a empleados\r\n";
            this.cmdAsignarPosicionesEmpleados.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdAsignarPosicionesEmpleados.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdAsignarPosicionesEmpleados.ToolTipTitle = "FLUCOL";
            this.cmdAsignarPosicionesEmpleados.Click += new System.EventHandler(this.cmdAsignarPosicionesEmpleados_Click);
            // 
            // pageConfiguraciones
            // 
            this.pageConfiguraciones.Caption = "pageConfiguraciones";
            this.pageConfiguraciones.Name = "pageConfiguraciones";
            this.pageConfiguraciones.Size = new System.Drawing.Size(992, 462);
            // 
            // PageMantenimientoEmpleados
            // 
            this.PageMantenimientoEmpleados.Caption = "PageMantenimientoEmpleados";
            this.PageMantenimientoEmpleados.Controls.Add(this.ctlMantenimientoUsuarios1);
            this.PageMantenimientoEmpleados.Name = "PageMantenimientoEmpleados";
            this.PageMantenimientoEmpleados.Size = new System.Drawing.Size(992, 462);
            // 
            // ctlMantenimientoUsuarios1
            // 
            this.ctlMantenimientoUsuarios1.BackColor = System.Drawing.Color.White;
            this.ctlMantenimientoUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMantenimientoUsuarios1.Location = new System.Drawing.Point(0, 0);
            this.ctlMantenimientoUsuarios1.Name = "ctlMantenimientoUsuarios1";
            this.ctlMantenimientoUsuarios1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlMantenimientoUsuarios1.Pro_Conexion = null;
            this.ctlMantenimientoUsuarios1.Pro_ID_AgenciaServicio = 0;
            this.ctlMantenimientoUsuarios1.Pro_ID_ClienteServicio = 0;
            this.ctlMantenimientoUsuarios1.Pro_Usuario = null;
            this.ctlMantenimientoUsuarios1.Size = new System.Drawing.Size(992, 462);
            this.ctlMantenimientoUsuarios1.TabIndex = 0;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
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
            this.lblAgencia.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAgencia.Location = new System.Drawing.Point(488, 5);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(497, 30);
            this.lblAgencia.TabIndex = 20;
            this.lblAgencia.Text = "NOMBRE SUCURSAL";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblNombreEmpleado);
            this.panel5.Controls.Add(this.lblAgencia);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(120, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(992, 42);
            this.panel5.TabIndex = 21;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Appearance.BackColor = System.Drawing.Color.White;
            this.lblNombreEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Appearance.Options.UseBackColor = true;
            this.lblNombreEmpleado.Appearance.Options.UseFont = true;
            this.lblNombreEmpleado.Appearance.Options.UseTextOptions = true;
            this.lblNombreEmpleado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblNombreEmpleado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNombreEmpleado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(5, 5);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(483, 30);
            this.lblNombreEmpleado.TabIndex = 21;
            this.lblNombreEmpleado.Text = "NOMBRE EMPLEADO";
            // 
            // ctlOperacionesSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "ctlOperacionesSupervisor";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1117, 514);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarSesion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMantenimientoEmpleados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPosiciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.pageAsignacionesTraslados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationAsignacionesTraslados)).EndInit();
            this.NavigationAsignacionesTraslados.ResumeLayout(false);
            this.pageTraslados.ResumeLayout(false);
            this.pageAsignaciones.ResumeLayout(false);
            this.pnlContenedorAsignaciones.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdTrasladarEmpleados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPosicionesEmpleados.Properties)).EndInit();
            this.PageMantenimientoEmpleados.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picLogoCliente;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit cmdAsignarPosiciones;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAsignacionesTraslados;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationAsignacionesTraslados;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAsignaciones;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboardPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage pageTraslados;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageConfiguraciones;
        private System.Windows.Forms.Panel pnlContenedorAsignaciones;
        private Configuraciones.ctlAsignacionPosiciones ctlAsignacionPosiciones1;
        private System.Windows.Forms.Panel pnlAcciones;
        private Configuraciones.ctlTrasladosEmpleadosServicio ctlTrasladosEmpleadosServicio1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.PictureEdit cmdMantenimientoEmpleados;
        private DevExpress.XtraBars.Navigation.NavigationPage PageMantenimientoEmpleados;
        private Configuraciones.ctlMantenimientoUsuarios ctlMantenimientoUsuarios1;
        private DevExpress.XtraEditors.PictureEdit cmdCerrarSesion;
        private DevExpress.XtraEditors.PictureEdit cmdAsignarPosicionesEmpleados;
        private DevExpress.XtraEditors.PictureEdit cmdTrasladarEmpleados;
        private DevExpress.XtraEditors.LabelControl lblAgencia;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.LabelControl lblNombreEmpleado;
    }
}
