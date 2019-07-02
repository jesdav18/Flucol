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
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.cmdDashboards = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoInstitucion = new DevExpress.XtraEditors.PictureEdit();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageDashboardPrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageAgenciasDisponibles = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlContenedorDashboards1 = new Core.Controles.Dashboards.ctlContenedorDashboards();
            this.ctlAgenciasDisponiblesParaDashboards1 = new Administracion.Controles.ctlAgenciasDisponiblesParaDashboards();
            this.PageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.PageDashboardPrincipal.SuspendLayout();
            this.PageAgenciasDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.pictureEdit2);
            this.pnlIzquierdo.Controls.Add(this.cmdDashboards);
            this.pnlIzquierdo.Controls.Add(this.panel3);
            this.pnlIzquierdo.Controls.Add(this.panel2);
            this.pnlIzquierdo.Controls.Add(this.panel1);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(5, 5);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(197, 651);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit2.Location = new System.Drawing.Point(40, 263);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.NullText = " ";
            this.pictureEdit2.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(117, 103);
            this.pictureEdit2.TabIndex = 4;
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
            this.cmdDashboards.Click += new System.EventHandler(this.CmdDashboards_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(157, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 491);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 491);
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
            this.NavigationPrincipal.Controls.Add(this.PageDashboardPrincipal);
            this.NavigationPrincipal.Controls.Add(this.PageAgenciasDisponibles);
            this.NavigationPrincipal.Controls.Add(this.PageInicial);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(202, 5);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageDashboardPrincipal,
            this.PageAgenciasDisponibles,
            this.PageInicial});
            this.NavigationPrincipal.SelectedPage = this.PageInicial;
            this.NavigationPrincipal.Size = new System.Drawing.Size(936, 651);
            this.NavigationPrincipal.TabIndex = 1;
            this.NavigationPrincipal.Text = "navigationFrame1";
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageDashboardPrincipal
            // 
            this.PageDashboardPrincipal.Controls.Add(this.ctlContenedorDashboards1);
            this.PageDashboardPrincipal.Name = "PageDashboardPrincipal";
            this.PageDashboardPrincipal.Size = new System.Drawing.Size(936, 651);
            // 
            // PageAgenciasDisponibles
            // 
            this.PageAgenciasDisponibles.Controls.Add(this.ctlAgenciasDisponiblesParaDashboards1);
            this.PageAgenciasDisponibles.Name = "PageAgenciasDisponibles";
            this.PageAgenciasDisponibles.Size = new System.Drawing.Size(936, 651);
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
            this.ctlContenedorDashboards1.Size = new System.Drawing.Size(936, 651);
            this.ctlContenedorDashboards1.TabIndex = 0;
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
            this.ctlAgenciasDisponiblesParaDashboards1.Size = new System.Drawing.Size(936, 651);
            this.ctlAgenciasDisponiblesParaDashboards1.TabIndex = 0;
            // 
            // PageInicial
            // 
            this.PageInicial.Name = "PageInicial";
            this.PageInicial.Size = new System.Drawing.Size(936, 651);
            // 
            // ctlAdministracionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.pnlIzquierdo);
            this.Name = "ctlAdministracionPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1143, 661);
            this.pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDashboards.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.PageDashboardPrincipal.ResumeLayout(false);
            this.PageAgenciasDisponibles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
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
    }
}
