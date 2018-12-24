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
            this.lblNombreUsuario = new DevExpress.XtraEditors.LabelControl();
            this.pnlEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.lblPosicion = new DevExpress.XtraEditors.LabelControl();
            this.picPosicion = new DevExpress.XtraEditors.PictureEdit();
            this.picUsuario = new DevExpress.XtraEditors.PictureEdit();
            this.pnlControlesDeCola = new System.Windows.Forms.Panel();
            this.lblCerrarTicket = new DevExpress.XtraEditors.LabelControl();
            this.lblIniciarTicket = new DevExpress.XtraEditors.LabelControl();
            this.lblTiempoPersonal = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrarTicket = new DevExpress.XtraEditors.PictureEdit();
            this.cmdIniciarTicket = new DevExpress.XtraEditors.PictureEdit();
            this.cmdTiempoPersonal = new DevExpress.XtraEditors.PictureEdit();
            this.lblSalidadAlmuerzo = new DevExpress.XtraEditors.LabelControl();
            this.cmdAlmuerzo = new DevExpress.XtraEditors.PictureEdit();
            this.pnlInformacionTickets = new System.Windows.Forms.Panel();
            this.lblTiempoAtencion = new DevExpress.XtraEditors.LabelControl();
            this.lblNumeroTicket = new DevExpress.XtraEditors.LabelControl();
            this.tmrTiempoAtencion = new System.Windows.Forms.Timer(this.components);
            this.tmrParoTiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPosicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario.Properties)).BeginInit();
            this.pnlControlesDeCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIniciarTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTiempoPersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAlmuerzo.Properties)).BeginInit();
            this.pnlInformacionTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Appearance.Options.UseFont = true;
            this.lblNombreUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreUsuario.Location = new System.Drawing.Point(157, 32);
            this.lblNombreUsuario.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.lblNombreUsuario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(232, 34);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "NOMBRE DE USUARIO";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblPosicion);
            this.pnlEncabezado.Controls.Add(this.picPosicion);
            this.pnlEncabezado.Controls.Add(this.picUsuario);
            this.pnlEncabezado.Controls.Add(this.lblNombreUsuario);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlEncabezado.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(852, 114);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblPosicion
            // 
            this.lblPosicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosicion.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Appearance.Options.UseFont = true;
            this.lblPosicion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPosicion.Location = new System.Drawing.Point(634, 32);
            this.lblPosicion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.lblPosicion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(161, 34);
            this.lblPosicion.TabIndex = 6;
            this.lblPosicion.Text = "POSICIÓN";
            // 
            // picPosicion
            // 
            this.picPosicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPosicion.EditValue = global::Operaciones.Properties.Resources.iconPosicion;
            this.picPosicion.Location = new System.Drawing.Point(539, 16);
            this.picPosicion.Name = "picPosicion";
            this.picPosicion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picPosicion.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picPosicion.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picPosicion.Properties.ReadOnly = true;
            this.picPosicion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPosicion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picPosicion.Size = new System.Drawing.Size(76, 83);
            this.picPosicion.TabIndex = 5;
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUsuario.EditValue = ((object)(resources.GetObject("picUsuario.EditValue")));
            this.picUsuario.Location = new System.Drawing.Point(63, 16);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUsuario.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picUsuario.Properties.ReadOnly = true;
            this.picUsuario.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picUsuario.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picUsuario.Size = new System.Drawing.Size(76, 74);
            this.picUsuario.TabIndex = 4;
            // 
            // pnlControlesDeCola
            // 
            this.pnlControlesDeCola.Controls.Add(this.lblCerrarTicket);
            this.pnlControlesDeCola.Controls.Add(this.lblIniciarTicket);
            this.pnlControlesDeCola.Controls.Add(this.lblTiempoPersonal);
            this.pnlControlesDeCola.Controls.Add(this.cmdCerrarTicket);
            this.pnlControlesDeCola.Controls.Add(this.cmdIniciarTicket);
            this.pnlControlesDeCola.Controls.Add(this.cmdTiempoPersonal);
            this.pnlControlesDeCola.Controls.Add(this.lblSalidadAlmuerzo);
            this.pnlControlesDeCola.Controls.Add(this.cmdAlmuerzo);
            this.pnlControlesDeCola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesDeCola.Location = new System.Drawing.Point(0, 308);
            this.pnlControlesDeCola.Name = "pnlControlesDeCola";
            this.pnlControlesDeCola.Size = new System.Drawing.Size(852, 143);
            this.pnlControlesDeCola.TabIndex = 1;
            // 
            // lblCerrarTicket
            // 
            this.lblCerrarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCerrarTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarTicket.Appearance.Options.UseFont = true;
            this.lblCerrarTicket.Appearance.Options.UseTextOptions = true;
            this.lblCerrarTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCerrarTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCerrarTicket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCerrarTicket.Location = new System.Drawing.Point(690, 81);
            this.lblCerrarTicket.Name = "lblCerrarTicket";
            this.lblCerrarTicket.Size = new System.Drawing.Size(130, 54);
            this.lblCerrarTicket.TabIndex = 12;
            this.lblCerrarTicket.Text = "CERRAR TICKET (F2)";
            // 
            // lblIniciarTicket
            // 
            this.lblIniciarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIniciarTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarTicket.Appearance.Options.UseFont = true;
            this.lblIniciarTicket.Appearance.Options.UseTextOptions = true;
            this.lblIniciarTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIniciarTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblIniciarTicket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIniciarTicket.Location = new System.Drawing.Point(494, 81);
            this.lblIniciarTicket.Name = "lblIniciarTicket";
            this.lblIniciarTicket.Size = new System.Drawing.Size(130, 54);
            this.lblIniciarTicket.TabIndex = 11;
            this.lblIniciarTicket.Text = "INICIAR TICKET (F1)";
            // 
            // lblTiempoPersonal
            // 
            this.lblTiempoPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTiempoPersonal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPersonal.Appearance.Options.UseFont = true;
            this.lblTiempoPersonal.Appearance.Options.UseTextOptions = true;
            this.lblTiempoPersonal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTiempoPersonal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTiempoPersonal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTiempoPersonal.Location = new System.Drawing.Point(211, 81);
            this.lblTiempoPersonal.Name = "lblTiempoPersonal";
            this.lblTiempoPersonal.Size = new System.Drawing.Size(142, 54);
            this.lblTiempoPersonal.TabIndex = 10;
            this.lblTiempoPersonal.Text = "TIEMPO PERSONAL (F12)";
            // 
            // cmdCerrarTicket
            // 
            this.cmdCerrarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCerrarTicket.EditValue = global::Operaciones.Properties.Resources.iconDetenerTicket;
            this.cmdCerrarTicket.Location = new System.Drawing.Point(721, 19);
            this.cmdCerrarTicket.Name = "cmdCerrarTicket";
            this.cmdCerrarTicket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCerrarTicket.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCerrarTicket.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCerrarTicket.Size = new System.Drawing.Size(65, 56);
            this.cmdCerrarTicket.TabIndex = 9;
            this.cmdCerrarTicket.Click += new System.EventHandler(this.cmdCerrarTicket_Click);
            // 
            // cmdIniciarTicket
            // 
            this.cmdIniciarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdIniciarTicket.EditValue = global::Operaciones.Properties.Resources.iconIniciarTicket;
            this.cmdIniciarTicket.Location = new System.Drawing.Point(526, 19);
            this.cmdIniciarTicket.Name = "cmdIniciarTicket";
            this.cmdIniciarTicket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIniciarTicket.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIniciarTicket.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdIniciarTicket.Size = new System.Drawing.Size(65, 56);
            this.cmdIniciarTicket.TabIndex = 8;
            this.cmdIniciarTicket.Click += new System.EventHandler(this.cmdIniciarTicket_Click);
            // 
            // cmdTiempoPersonal
            // 
            this.cmdTiempoPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdTiempoPersonal.EditValue = global::Operaciones.Properties.Resources.iconPausaPersonal;
            this.cmdTiempoPersonal.Location = new System.Drawing.Point(249, 19);
            this.cmdTiempoPersonal.Name = "cmdTiempoPersonal";
            this.cmdTiempoPersonal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdTiempoPersonal.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdTiempoPersonal.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdTiempoPersonal.Size = new System.Drawing.Size(65, 56);
            this.cmdTiempoPersonal.TabIndex = 7;
            this.cmdTiempoPersonal.Click += new System.EventHandler(this.cmdTiempoPersonal_Click);
            // 
            // lblSalidadAlmuerzo
            // 
            this.lblSalidadAlmuerzo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalidadAlmuerzo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalidadAlmuerzo.Appearance.Options.UseFont = true;
            this.lblSalidadAlmuerzo.Appearance.Options.UseTextOptions = true;
            this.lblSalidadAlmuerzo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSalidadAlmuerzo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblSalidadAlmuerzo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSalidadAlmuerzo.Location = new System.Drawing.Point(39, 81);
            this.lblSalidadAlmuerzo.Name = "lblSalidadAlmuerzo";
            this.lblSalidadAlmuerzo.Size = new System.Drawing.Size(142, 54);
            this.lblSalidadAlmuerzo.TabIndex = 6;
            this.lblSalidadAlmuerzo.Text = "SALIDA ALMUERZO (F11)";
            // 
            // cmdAlmuerzo
            // 
            this.cmdAlmuerzo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdAlmuerzo.EditValue = global::Operaciones.Properties.Resources.iconAlmuerzo;
            this.cmdAlmuerzo.Location = new System.Drawing.Point(79, 19);
            this.cmdAlmuerzo.Name = "cmdAlmuerzo";
            this.cmdAlmuerzo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAlmuerzo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAlmuerzo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAlmuerzo.Size = new System.Drawing.Size(65, 56);
            this.cmdAlmuerzo.TabIndex = 5;
            this.cmdAlmuerzo.Click += new System.EventHandler(this.cmdAlmuerzo_Click);
            // 
            // pnlInformacionTickets
            // 
            this.pnlInformacionTickets.Controls.Add(this.lblTiempoAtencion);
            this.pnlInformacionTickets.Controls.Add(this.lblNumeroTicket);
            this.pnlInformacionTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacionTickets.Location = new System.Drawing.Point(0, 114);
            this.pnlInformacionTickets.Name = "pnlInformacionTickets";
            this.pnlInformacionTickets.Size = new System.Drawing.Size(852, 194);
            this.pnlInformacionTickets.TabIndex = 2;
            // 
            // lblTiempoAtencion
            // 
            this.lblTiempoAtencion.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoAtencion.Appearance.Options.UseFont = true;
            this.lblTiempoAtencion.Appearance.Options.UseTextOptions = true;
            this.lblTiempoAtencion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTiempoAtencion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTiempoAtencion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblTiempoAtencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiempoAtencion.Location = new System.Drawing.Point(0, 73);
            this.lblTiempoAtencion.Name = "lblTiempoAtencion";
            this.lblTiempoAtencion.Size = new System.Drawing.Size(852, 121);
            this.lblTiempoAtencion.TabIndex = 2;
            this.lblTiempoAtencion.Text = "00:00:00";
            // 
            // lblNumeroTicket
            // 
            this.lblNumeroTicket.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNumeroTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblNumeroTicket.Size = new System.Drawing.Size(852, 73);
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
            this.tmrParoTiempo.Tick += new System.EventHandler(this.tmrParoTiempo_Tick);
            // 
            // CtlOperacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlInformacionTickets);
            this.Controls.Add(this.pnlControlesDeCola);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtlOperacional";
            this.Size = new System.Drawing.Size(852, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPosicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario.Properties)).EndInit();
            this.pnlControlesDeCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIniciarTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTiempoPersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAlmuerzo.Properties)).EndInit();
            this.pnlInformacionTickets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNombreUsuario;
        private DevExpress.XtraEditors.PictureEdit picUsuario;
        private DevExpress.XtraEditors.PictureEdit picPosicion;
        private DevExpress.XtraEditors.PanelControl pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblPosicion;
        private System.Windows.Forms.Panel pnlControlesDeCola;
        private DevExpress.XtraEditors.LabelControl lblSalidadAlmuerzo;
        private DevExpress.XtraEditors.PictureEdit cmdAlmuerzo;
        private System.Windows.Forms.Panel pnlInformacionTickets;
        private DevExpress.XtraEditors.PictureEdit cmdTiempoPersonal;
        private DevExpress.XtraEditors.LabelControl lblCerrarTicket;
        private DevExpress.XtraEditors.LabelControl lblIniciarTicket;
        private DevExpress.XtraEditors.LabelControl lblTiempoPersonal;
        private DevExpress.XtraEditors.PictureEdit cmdCerrarTicket;
        private DevExpress.XtraEditors.PictureEdit cmdIniciarTicket;
        private DevExpress.XtraEditors.LabelControl lblTiempoAtencion;
        private DevExpress.XtraEditors.LabelControl lblNumeroTicket;
        private System.Windows.Forms.Timer tmrTiempoAtencion;
        private System.Windows.Forms.Timer tmrParoTiempo;
    }
}
