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
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.pnlTitulo = new DevExpress.XtraEditors.PanelControl();
            this.navFrameMenuInicial = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.NavPagePrioridades = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdTerceraEdad = new DevExpress.XtraEditors.PictureEdit();
            this.lblEsperaGeneral = new DevExpress.XtraEditors.LabelControl();
            this.lblCondicionesEspeciales = new DevExpress.XtraEditors.LabelControl();
            this.lblTerceraEdad = new DevExpress.XtraEditors.LabelControl();
            this.cmdCondicionesEspeciales01 = new DevExpress.XtraEditors.PictureEdit();
            this.cmdEsperaGeneral = new DevExpress.XtraEditors.PictureEdit();
            this.cmdCondicionesEspeciales = new DevExpress.XtraEditors.PictureEdit();
            this.navPageTipoTransaccion = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlInferior = new DevExpress.XtraEditors.PanelControl();
            this.cmdIrAPrioridades = new DevExpress.XtraEditors.PictureEdit();
            this.lblTransacciones = new DevExpress.XtraEditors.LabelControl();
            this.lblServicioAlCliente = new DevExpress.XtraEditors.LabelControl();
            this.cmdTransacciones = new DevExpress.XtraEditors.PictureEdit();
            this.cmdServicioAlCliente = new DevExpress.XtraEditors.PictureEdit();
            this.navPageTicket = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.tmrTiempoEspera = new System.Windows.Forms.Timer();
            this.tmrTiempoVisualizacionTicket = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFrameMenuInicial)).BeginInit();
            this.navFrameMenuInicial.SuspendLayout();
            this.NavPagePrioridades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTerceraEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEsperaGeneral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales.Properties)).BeginInit();
            this.navPageTipoTransaccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).BeginInit();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAPrioridades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTransacciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdServicioAlCliente.Properties)).BeginInit();
            this.navPageTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Appearance.Options.UseBackColor = true;
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseForeColor = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(870, 71);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlTitulo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(876, 77);
            this.pnlTitulo.TabIndex = 1;
            // 
            // navFrameMenuInicial
            // 
            this.navFrameMenuInicial.Controls.Add(this.NavPagePrioridades);
            this.navFrameMenuInicial.Controls.Add(this.navPageTipoTransaccion);
            this.navFrameMenuInicial.Controls.Add(this.navPageTicket);
            this.navFrameMenuInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrameMenuInicial.Location = new System.Drawing.Point(0, 77);
            this.navFrameMenuInicial.Name = "navFrameMenuInicial";
            this.navFrameMenuInicial.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.NavPagePrioridades,
            this.navPageTipoTransaccion,
            this.navPageTicket});
            this.navFrameMenuInicial.SelectedPage = this.NavPagePrioridades;
            this.navFrameMenuInicial.Size = new System.Drawing.Size(876, 445);
            this.navFrameMenuInicial.TabIndex = 2;
            this.navFrameMenuInicial.Text = "navMenuPrioridades";
            this.navFrameMenuInicial.TransitionAnimationProperties.FrameCount = 50;
            this.navFrameMenuInicial.TransitionAnimationProperties.FrameInterval = 50;
            this.navFrameMenuInicial.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // NavPagePrioridades
            // 
            this.NavPagePrioridades.Caption = "navigationPage1";
            this.NavPagePrioridades.Controls.Add(this.cmdTerceraEdad);
            this.NavPagePrioridades.Controls.Add(this.lblEsperaGeneral);
            this.NavPagePrioridades.Controls.Add(this.lblCondicionesEspeciales);
            this.NavPagePrioridades.Controls.Add(this.lblTerceraEdad);
            this.NavPagePrioridades.Controls.Add(this.cmdCondicionesEspeciales01);
            this.NavPagePrioridades.Controls.Add(this.cmdEsperaGeneral);
            this.NavPagePrioridades.Controls.Add(this.cmdCondicionesEspeciales);
            this.NavPagePrioridades.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavPagePrioridades.Name = "NavPagePrioridades";
            this.NavPagePrioridades.Size = new System.Drawing.Size(876, 445);
            // 
            // cmdTerceraEdad
            // 
            this.cmdTerceraEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdTerceraEdad.EditValue = global::Recepcion.Properties.Resources.iconAncianos;
            this.cmdTerceraEdad.Location = new System.Drawing.Point(101, 110);
            this.cmdTerceraEdad.Name = "cmdTerceraEdad";
            this.cmdTerceraEdad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdTerceraEdad.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdTerceraEdad.Properties.ShowMenu = false;
            this.cmdTerceraEdad.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdTerceraEdad.Size = new System.Drawing.Size(99, 91);
            this.cmdTerceraEdad.TabIndex = 8;
            this.cmdTerceraEdad.Click += new System.EventHandler(this.cmdTerceraEdad_Click);
            // 
            // lblEsperaGeneral
            // 
            this.lblEsperaGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEsperaGeneral.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaGeneral.Appearance.Options.UseFont = true;
            this.lblEsperaGeneral.Appearance.Options.UseTextOptions = true;
            this.lblEsperaGeneral.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEsperaGeneral.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEsperaGeneral.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEsperaGeneral.Location = new System.Drawing.Point(594, 212);
            this.lblEsperaGeneral.Name = "lblEsperaGeneral";
            this.lblEsperaGeneral.Size = new System.Drawing.Size(195, 97);
            this.lblEsperaGeneral.TabIndex = 7;
            this.lblEsperaGeneral.Text = "ESPERA GENERAL";
            this.lblEsperaGeneral.Click += new System.EventHandler(this.cmdEsperaGeneral_Click);
            // 
            // lblCondicionesEspeciales
            // 
            this.lblCondicionesEspeciales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCondicionesEspeciales.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionesEspeciales.Appearance.Options.UseFont = true;
            this.lblCondicionesEspeciales.Appearance.Options.UseTextOptions = true;
            this.lblCondicionesEspeciales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCondicionesEspeciales.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCondicionesEspeciales.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCondicionesEspeciales.Location = new System.Drawing.Point(328, 212);
            this.lblCondicionesEspeciales.Name = "lblCondicionesEspeciales";
            this.lblCondicionesEspeciales.Size = new System.Drawing.Size(195, 97);
            this.lblCondicionesEspeciales.TabIndex = 3;
            this.lblCondicionesEspeciales.Text = "CONDICIONES ESPECIALES";
            this.lblCondicionesEspeciales.Click += new System.EventHandler(this.cmdCondicionesEspeciales_Click);
            // 
            // lblTerceraEdad
            // 
            this.lblTerceraEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTerceraEdad.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceraEdad.Appearance.Options.UseFont = true;
            this.lblTerceraEdad.Appearance.Options.UseTextOptions = true;
            this.lblTerceraEdad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTerceraEdad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTerceraEdad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTerceraEdad.Location = new System.Drawing.Point(73, 218);
            this.lblTerceraEdad.Name = "lblTerceraEdad";
            this.lblTerceraEdad.Size = new System.Drawing.Size(149, 85);
            this.lblTerceraEdad.TabIndex = 1;
            this.lblTerceraEdad.Text = "TERCERA EDAD";
            this.lblTerceraEdad.Click += new System.EventHandler(this.cmdTerceraEdad_Click);
            // 
            // cmdCondicionesEspeciales01
            // 
            this.cmdCondicionesEspeciales01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCondicionesEspeciales01.EditValue = global::Recepcion.Properties.Resources.iconDiscapacidad;
            this.cmdCondicionesEspeciales01.Location = new System.Drawing.Point(424, 110);
            this.cmdCondicionesEspeciales01.Name = "cmdCondicionesEspeciales01";
            this.cmdCondicionesEspeciales01.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCondicionesEspeciales01.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCondicionesEspeciales01.Properties.ShowMenu = false;
            this.cmdCondicionesEspeciales01.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCondicionesEspeciales01.Size = new System.Drawing.Size(99, 91);
            this.cmdCondicionesEspeciales01.TabIndex = 6;
            this.cmdCondicionesEspeciales01.Click += new System.EventHandler(this.cmdCondicionesEspeciales01_Click);
            // 
            // cmdEsperaGeneral
            // 
            this.cmdEsperaGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdEsperaGeneral.EditValue = global::Recepcion.Properties.Resources.iconEsperaGeneral;
            this.cmdEsperaGeneral.Location = new System.Drawing.Point(641, 110);
            this.cmdEsperaGeneral.Name = "cmdEsperaGeneral";
            this.cmdEsperaGeneral.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdEsperaGeneral.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdEsperaGeneral.Properties.ShowMenu = false;
            this.cmdEsperaGeneral.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdEsperaGeneral.Size = new System.Drawing.Size(99, 91);
            this.cmdEsperaGeneral.TabIndex = 4;
            this.cmdEsperaGeneral.Click += new System.EventHandler(this.cmdEsperaGeneral_Click);
            // 
            // cmdCondicionesEspeciales
            // 
            this.cmdCondicionesEspeciales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCondicionesEspeciales.EditValue = global::Recepcion.Properties.Resources.iconEmbarazada;
            this.cmdCondicionesEspeciales.Location = new System.Drawing.Point(318, 110);
            this.cmdCondicionesEspeciales.Name = "cmdCondicionesEspeciales";
            this.cmdCondicionesEspeciales.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCondicionesEspeciales.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCondicionesEspeciales.Properties.ShowMenu = false;
            this.cmdCondicionesEspeciales.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCondicionesEspeciales.Size = new System.Drawing.Size(99, 91);
            this.cmdCondicionesEspeciales.TabIndex = 2;
            this.cmdCondicionesEspeciales.Click += new System.EventHandler(this.cmdCondicionesEspeciales_Click);
            // 
            // navPageTipoTransaccion
            // 
            this.navPageTipoTransaccion.Caption = "navigationPage2";
            this.navPageTipoTransaccion.Controls.Add(this.pnlInferior);
            this.navPageTipoTransaccion.Controls.Add(this.lblTransacciones);
            this.navPageTipoTransaccion.Controls.Add(this.lblServicioAlCliente);
            this.navPageTipoTransaccion.Controls.Add(this.cmdTransacciones);
            this.navPageTipoTransaccion.Controls.Add(this.cmdServicioAlCliente);
            this.navPageTipoTransaccion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPageTipoTransaccion.Name = "navPageTipoTransaccion";
            this.navPageTipoTransaccion.Size = new System.Drawing.Size(876, 445);
            // 
            // pnlInferior
            // 
            this.pnlInferior.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlInferior.Appearance.Options.UseBackColor = true;
            this.pnlInferior.Controls.Add(this.cmdIrAPrioridades);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 355);
            this.pnlInferior.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlInferior.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(876, 90);
            this.pnlInferior.TabIndex = 8;
            // 
            // cmdIrAPrioridades
            // 
            this.cmdIrAPrioridades.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdIrAPrioridades.EditValue = global::Recepcion.Properties.Resources.iconIrAtras;
            this.cmdIrAPrioridades.Location = new System.Drawing.Point(3, 3);
            this.cmdIrAPrioridades.Name = "cmdIrAPrioridades";
            this.cmdIrAPrioridades.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIrAPrioridades.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIrAPrioridades.Size = new System.Drawing.Size(111, 84);
            this.cmdIrAPrioridades.TabIndex = 7;
            this.cmdIrAPrioridades.Click += new System.EventHandler(this.cmdIrAPrioridades_Click);
            // 
            // lblTransacciones
            // 
            this.lblTransacciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransacciones.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacciones.Appearance.Options.UseFont = true;
            this.lblTransacciones.Appearance.Options.UseTextOptions = true;
            this.lblTransacciones.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTransacciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTransacciones.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTransacciones.Location = new System.Drawing.Point(443, 177);
            this.lblTransacciones.Name = "lblTransacciones";
            this.lblTransacciones.Size = new System.Drawing.Size(231, 97);
            this.lblTransacciones.TabIndex = 6;
            this.lblTransacciones.Text = "TRANSACCIONES EN CAJA";
            // 
            // lblServicioAlCliente
            // 
            this.lblServicioAlCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicioAlCliente.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioAlCliente.Appearance.Options.UseFont = true;
            this.lblServicioAlCliente.Appearance.Options.UseTextOptions = true;
            this.lblServicioAlCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblServicioAlCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblServicioAlCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblServicioAlCliente.Location = new System.Drawing.Point(184, 177);
            this.lblServicioAlCliente.Name = "lblServicioAlCliente";
            this.lblServicioAlCliente.Size = new System.Drawing.Size(195, 97);
            this.lblServicioAlCliente.TabIndex = 5;
            this.lblServicioAlCliente.Text = "SERVICIO AL CLIENTE";
            // 
            // cmdTransacciones
            // 
            this.cmdTransacciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdTransacciones.EditValue = global::Recepcion.Properties.Resources.iconTransaccionesCaja;
            this.cmdTransacciones.Location = new System.Drawing.Point(514, 55);
            this.cmdTransacciones.Name = "cmdTransacciones";
            this.cmdTransacciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdTransacciones.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdTransacciones.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdTransacciones.Size = new System.Drawing.Size(99, 91);
            this.cmdTransacciones.TabIndex = 4;
            this.cmdTransacciones.Click += new System.EventHandler(this.cmdTransacciones_Click);
            // 
            // cmdServicioAlCliente
            // 
            this.cmdServicioAlCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdServicioAlCliente.EditValue = global::Recepcion.Properties.Resources.iconServicioAlCliente;
            this.cmdServicioAlCliente.Location = new System.Drawing.Point(234, 55);
            this.cmdServicioAlCliente.Name = "cmdServicioAlCliente";
            this.cmdServicioAlCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdServicioAlCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdServicioAlCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdServicioAlCliente.Size = new System.Drawing.Size(99, 91);
            this.cmdServicioAlCliente.TabIndex = 3;
            this.cmdServicioAlCliente.Click += new System.EventHandler(this.cmdServicioAlCliente_Click);
            // 
            // navPageTicket
            // 
            this.navPageTicket.Caption = "navPageTicket";
            this.navPageTicket.Controls.Add(this.documentViewer1);
            this.navPageTicket.Name = "navPageTicket";
            this.navPageTicket.Size = new System.Drawing.Size(876, 445);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.LookAndFeel.SkinName = "Office 2013";
            this.documentViewer1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.PageBorderColor = System.Drawing.Color.White;
            this.documentViewer1.SelectedPageBorderColor = System.Drawing.Color.White;
            this.documentViewer1.ShowPageMargins = false;
            this.documentViewer1.Size = new System.Drawing.Size(876, 445);
            this.documentViewer1.TabIndex = 0;
            // 
            // tmrTiempoVisualizacionTicket
            // 
            this.tmrTiempoVisualizacionTicket.Interval = 2000;
            this.tmrTiempoVisualizacionTicket.Tick += new System.EventHandler(this.tmrTiempoVisualizacionTicket_Tick);
            // 
            // CtlSeleccionTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navFrameMenuInicial);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "CtlSeleccionTransaccion";
            this.Size = new System.Drawing.Size(876, 522);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navFrameMenuInicial)).EndInit();
            this.navFrameMenuInicial.ResumeLayout(false);
            this.NavPagePrioridades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdTerceraEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEsperaGeneral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCondicionesEspeciales.Properties)).EndInit();
            this.navPageTipoTransaccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAPrioridades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTransacciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdServicioAlCliente.Properties)).EndInit();
            this.navPageTicket.ResumeLayout(false);
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
        private System.Windows.Forms.Timer tmrTiempoEspera;
        private DevExpress.XtraEditors.PanelControl pnlInferior;
        private DevExpress.XtraEditors.PictureEdit cmdIrAPrioridades;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageTicket;
        private System.Windows.Forms.Timer tmrTiempoVisualizacionTicket;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}
