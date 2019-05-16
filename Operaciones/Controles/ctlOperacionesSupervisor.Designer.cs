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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageAsignacionesTraslados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.NavigationAsignacionesTraslados = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageAsignaciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlContenedorAsignaciones = new System.Windows.Forms.Panel();
            this.lblTituloDashboardPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.pageTraslados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.cmdTraslados = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdAsignaciones = new DevExpress.XtraEditors.SimpleButton();
            this.pageConfiguraciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlTrasladosEmpleadosServicio1 = new Operaciones.Controles.Configuraciones.ctlTrasladosEmpleadosServicio();
            this.ctlAsignacionPosiciones1 = new Operaciones.Controles.Configuraciones.ctlAsignacionPosiciones();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Operaciones.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.cmdAsignarPosiciones = new DevExpress.XtraEditors.PictureEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.pageAsignacionesTraslados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationAsignacionesTraslados)).BeginInit();
            this.NavigationAsignacionesTraslados.SuspendLayout();
            this.pageAsignaciones.SuspendLayout();
            this.pnlContenedorAsignaciones.SuspendLayout();
            this.pageTraslados.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPosiciones.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picLogoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdAsignarPosiciones);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 408);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(96, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 408);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 408);
            this.panel3.TabIndex = 0;
            // 
            // picLogoCliente
            // 
            this.picLogoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoCliente.Location = new System.Drawing.Point(0, 0);
            this.picLogoCliente.Name = "picLogoCliente";
            this.picLogoCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogoCliente.Size = new System.Drawing.Size(115, 96);
            this.picLogoCliente.TabIndex = 0;
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.Controls.Add(this.pageAsignacionesTraslados);
            this.NavigationPrincipal.Controls.Add(this.pageConfiguraciones);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(120, 5);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageAsignacionesTraslados,
            this.pageConfiguraciones});
            this.NavigationPrincipal.SelectedPage = this.pageConfiguraciones;
            this.NavigationPrincipal.Size = new System.Drawing.Size(992, 504);
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
            this.pageAsignacionesTraslados.Size = new System.Drawing.Size(992, 504);
            // 
            // NavigationAsignacionesTraslados
            // 
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
            this.NavigationAsignacionesTraslados.Size = new System.Drawing.Size(992, 458);
            this.NavigationAsignacionesTraslados.TabIndex = 0;
            this.NavigationAsignacionesTraslados.Text = "navigationFrame1";
            this.NavigationAsignacionesTraslados.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationAsignacionesTraslados.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pageAsignaciones
            // 
            this.pageAsignaciones.Caption = "pageAsignaciones";
            this.pageAsignaciones.Controls.Add(this.pnlContenedorAsignaciones);
            this.pageAsignaciones.Controls.Add(this.lblTituloDashboardPrincipal);
            this.pageAsignaciones.Name = "pageAsignaciones";
            this.pageAsignaciones.Size = new System.Drawing.Size(992, 458);
            // 
            // pnlContenedorAsignaciones
            // 
            this.pnlContenedorAsignaciones.Controls.Add(this.ctlAsignacionPosiciones1);
            this.pnlContenedorAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorAsignaciones.Location = new System.Drawing.Point(0, 31);
            this.pnlContenedorAsignaciones.Name = "pnlContenedorAsignaciones";
            this.pnlContenedorAsignaciones.Size = new System.Drawing.Size(992, 427);
            this.pnlContenedorAsignaciones.TabIndex = 5;
            // 
            // lblTituloDashboardPrincipal
            // 
            this.lblTituloDashboardPrincipal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // pageTraslados
            // 
            this.pageTraslados.Caption = "pageTraslados";
            this.pageTraslados.Controls.Add(this.ctlTrasladosEmpleadosServicio1);
            this.pageTraslados.Controls.Add(this.labelControl1);
            this.pageTraslados.Name = "pageTraslados";
            this.pageTraslados.Size = new System.Drawing.Size(992, 458);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.cmdTraslados);
            this.pnlAcciones.Controls.Add(this.panel5);
            this.pnlAcciones.Controls.Add(this.cmdAsignaciones);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAcciones.Size = new System.Drawing.Size(992, 46);
            this.pnlAcciones.TabIndex = 3;
            // 
            // cmdTraslados
            // 
            this.cmdTraslados.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdTraslados.Location = new System.Drawing.Point(154, 5);
            this.cmdTraslados.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdTraslados.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdTraslados.Name = "cmdTraslados";
            this.cmdTraslados.Padding = new System.Windows.Forms.Padding(5);
            this.cmdTraslados.Size = new System.Drawing.Size(153, 36);
            this.cmdTraslados.TabIndex = 2;
            this.cmdTraslados.Text = "TRASLADOS";
            this.cmdTraslados.Click += new System.EventHandler(this.cmdTraslados_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(144, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 36);
            this.panel5.TabIndex = 3;
            // 
            // cmdAsignaciones
            // 
            this.cmdAsignaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAsignaciones.Location = new System.Drawing.Point(5, 5);
            this.cmdAsignaciones.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdAsignaciones.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdAsignaciones.Name = "cmdAsignaciones";
            this.cmdAsignaciones.Padding = new System.Windows.Forms.Padding(5);
            this.cmdAsignaciones.Size = new System.Drawing.Size(139, 36);
            this.cmdAsignaciones.TabIndex = 1;
            this.cmdAsignaciones.Text = "ASIGNAR POSICIONES";
            this.cmdAsignaciones.Click += new System.EventHandler(this.cmdAsignaciones_Click);
            // 
            // pageConfiguraciones
            // 
            this.pageConfiguraciones.Caption = "pageConfiguraciones";
            this.pageConfiguraciones.Name = "pageConfiguraciones";
            this.pageConfiguraciones.Size = new System.Drawing.Size(992, 504);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(992, 458);
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
            this.ctlTrasladosEmpleadosServicio1.Size = new System.Drawing.Size(992, 427);
            this.ctlTrasladosEmpleadosServicio1.TabIndex = 4;
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
            this.ctlAsignacionPosiciones1.Size = new System.Drawing.Size(992, 427);
            this.ctlAsignacionPosiciones1.TabIndex = 0;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // cmdAsignarPosiciones
            // 
            this.cmdAsignarPosiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdAsignarPosiciones.EditValue = global::Operaciones.Properties.Resources.iconPosicion;
            this.cmdAsignarPosiciones.Location = new System.Drawing.Point(19, 0);
            this.cmdAsignarPosiciones.Name = "cmdAsignarPosiciones";
            this.cmdAsignarPosiciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAsignarPosiciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAsignarPosiciones.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAsignarPosiciones.Size = new System.Drawing.Size(77, 69);
            this.cmdAsignarPosiciones.TabIndex = 2;
            this.cmdAsignarPosiciones.Click += new System.EventHandler(this.cmdAsignarPosiciones_Click);
            // 
            // ctlOperacionesSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "ctlOperacionesSupervisor";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1117, 514);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.pageAsignacionesTraslados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationAsignacionesTraslados)).EndInit();
            this.NavigationAsignacionesTraslados.ResumeLayout(false);
            this.pageAsignaciones.ResumeLayout(false);
            this.pnlContenedorAsignaciones.ResumeLayout(false);
            this.pageTraslados.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPosiciones.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton cmdTraslados;
        private DevExpress.XtraEditors.SimpleButton cmdAsignaciones;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationAsignacionesTraslados;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAsignaciones;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboardPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage pageTraslados;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageConfiguraciones;
        private System.Windows.Forms.Panel pnlContenedorAsignaciones;
        private Configuraciones.ctlAsignacionPosiciones ctlAsignacionPosiciones1;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel panel5;
        private Configuraciones.ctlTrasladosEmpleadosServicio ctlTrasladosEmpleadosServicio1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
