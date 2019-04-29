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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlOperacionesSupervisor));
            this.pnlOpcionesSupervisor = new System.Windows.Forms.Panel();
            this.cmdAdministracionPosiciones = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.popupOpcionesSupervisor = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.NavOpcionesSupervisor = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageAdministracionPosiciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageOperaciones = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAdministracionPosiciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupOpcionesSupervisor)).BeginInit();
            this.popupOpcionesSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavOpcionesSupervisor)).BeginInit();
            this.NavOpcionesSupervisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpcionesSupervisor
            // 
            this.pnlOpcionesSupervisor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpcionesSupervisor.Location = new System.Drawing.Point(5, 5);
            this.pnlOpcionesSupervisor.Name = "pnlOpcionesSupervisor";
            this.pnlOpcionesSupervisor.Size = new System.Drawing.Size(5, 416);
            this.pnlOpcionesSupervisor.TabIndex = 0;
            // 
            // cmdAdministracionPosiciones
            // 
            this.cmdAdministracionPosiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdAdministracionPosiciones.EditValue = ((object)(resources.GetObject("cmdAdministracionPosiciones.EditValue")));
            this.cmdAdministracionPosiciones.Location = new System.Drawing.Point(3, 3);
            this.cmdAdministracionPosiciones.Name = "cmdAdministracionPosiciones";
            this.cmdAdministracionPosiciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAdministracionPosiciones.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmdAdministracionPosiciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAdministracionPosiciones.Size = new System.Drawing.Size(75, 77);
            this.cmdAdministracionPosiciones.TabIndex = 0;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(3, 80);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(75, 77);
            this.pictureEdit2.TabIndex = 1;
            // 
            // popupOpcionesSupervisor
            // 
            this.popupOpcionesSupervisor.Appearance.BackColor = System.Drawing.Color.White;
            this.popupOpcionesSupervisor.Appearance.Options.UseBackColor = true;
            this.popupOpcionesSupervisor.Controls.Add(this.flyoutPanelControl1);
            this.popupOpcionesSupervisor.Location = new System.Drawing.Point(717, 55);
            this.popupOpcionesSupervisor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupOpcionesSupervisor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupOpcionesSupervisor.Name = "popupOpcionesSupervisor";
            this.popupOpcionesSupervisor.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left;
            this.popupOpcionesSupervisor.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupOpcionesSupervisor.Options.CloseOnOuterClick = true;
            this.popupOpcionesSupervisor.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupOpcionesSupervisor.OwnerControl = this.pnlOpcionesSupervisor;
            this.popupOpcionesSupervisor.Size = new System.Drawing.Size(81, 239);
            this.popupOpcionesSupervisor.TabIndex = 2;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.pictureEdit2);
            this.flyoutPanelControl1.Controls.Add(this.cmdAdministracionPosiciones);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupOpcionesSupervisor;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(81, 239);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // NavOpcionesSupervisor
            // 
            this.NavOpcionesSupervisor.Controls.Add(this.pageAdministracionPosiciones);
            this.NavOpcionesSupervisor.Controls.Add(this.PageOperaciones);
            this.NavOpcionesSupervisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavOpcionesSupervisor.Location = new System.Drawing.Point(10, 5);
            this.NavOpcionesSupervisor.Name = "NavOpcionesSupervisor";
            this.NavOpcionesSupervisor.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageAdministracionPosiciones,
            this.PageOperaciones});
            this.NavOpcionesSupervisor.SelectedPage = this.PageOperaciones;
            this.NavOpcionesSupervisor.Size = new System.Drawing.Size(701, 416);
            this.NavOpcionesSupervisor.TabIndex = 3;
            this.NavOpcionesSupervisor.Text = "navigationFrame1";
            // 
            // pageAdministracionPosiciones
            // 
            this.pageAdministracionPosiciones.Name = "pageAdministracionPosiciones";
            this.pageAdministracionPosiciones.Size = new System.Drawing.Size(701, 416);
            // 
            // PageOperaciones
            // 
            this.PageOperaciones.Name = "PageOperaciones";
            this.PageOperaciones.Size = new System.Drawing.Size(701, 416);
            // 
            // ctlOperacionesSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavOpcionesSupervisor);
            this.Controls.Add(this.popupOpcionesSupervisor);
            this.Controls.Add(this.pnlOpcionesSupervisor);
            this.Name = "ctlOperacionesSupervisor";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(716, 426);
            ((System.ComponentModel.ISupportInitialize)(this.cmdAdministracionPosiciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupOpcionesSupervisor)).EndInit();
            this.popupOpcionesSupervisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavOpcionesSupervisor)).EndInit();
            this.NavOpcionesSupervisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpcionesSupervisor;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit cmdAdministracionPosiciones;
        private DevExpress.Utils.FlyoutPanel popupOpcionesSupervisor;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavOpcionesSupervisor;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAdministracionPosiciones;
        private DevExpress.XtraBars.Navigation.NavigationPage PageOperaciones;
    }
}
