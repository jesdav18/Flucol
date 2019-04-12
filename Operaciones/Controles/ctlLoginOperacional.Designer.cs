namespace Operaciones.Controles
{
    partial class ctlLoginOperacional
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
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblContrasenia = new DevExpress.XtraEditors.LabelControl();
            this.lblEtiqueta = new DevExpress.XtraEditors.LabelControl();
            this.cmdIngresar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(161, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.AutoHeight = false;
            this.txtUsuario.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtUsuario.Properties.PasswordChar = '*';
            this.txtUsuario.Size = new System.Drawing.Size(239, 30);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasenia.Location = new System.Drawing.Point(161, 117);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Properties.Appearance.Options.UseFont = true;
            this.txtContrasenia.Properties.AutoHeight = false;
            this.txtContrasenia.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtContrasenia.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtContrasenia.Properties.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(239, 30);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(73, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasenia.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Appearance.Options.UseFont = true;
            this.lblContrasenia.Location = new System.Drawing.Point(40, 127);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(97, 20);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "CONTRASEÑA";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEtiqueta.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEtiqueta.Appearance.Options.UseBackColor = true;
            this.lblEtiqueta.Appearance.Options.UseFont = true;
            this.lblEtiqueta.Appearance.Options.UseForeColor = true;
            this.lblEtiqueta.Appearance.Options.UseTextOptions = true;
            this.lblEtiqueta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEtiqueta.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEtiqueta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblEtiqueta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEtiqueta.Location = new System.Drawing.Point(0, 0);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(442, 41);
            this.lblEtiqueta.TabIndex = 4;
            this.lblEtiqueta.Text = "ACCESO DE USUARIO";
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdIngresar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdIngresar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresar.Appearance.Options.UseBackColor = true;
            this.cmdIngresar.Appearance.Options.UseFont = true;
            this.cmdIngresar.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdIngresar.AppearancePressed.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresar.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.cmdIngresar.AppearancePressed.Options.UseBackColor = true;
            this.cmdIngresar.AppearancePressed.Options.UseFont = true;
            this.cmdIngresar.AppearancePressed.Options.UseForeColor = true;
            this.cmdIngresar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdIngresar.Location = new System.Drawing.Point(40, 177);
            this.cmdIngresar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdIngresar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(177, 45);
            this.cmdIngresar.TabIndex = 5;
            this.cmdIngresar.Text = "INGRESAR";
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            this.cmdIngresar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdIngresar_KeyDown);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdCerrar.AppearancePressed.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.cmdCerrar.AppearancePressed.Options.UseBackColor = true;
            this.cmdCerrar.AppearancePressed.Options.UseFont = true;
            this.cmdCerrar.AppearancePressed.Options.UseForeColor = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdCerrar.Location = new System.Drawing.Point(233, 177);
            this.cmdCerrar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdCerrar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(167, 45);
            this.cmdCerrar.TabIndex = 6;
            this.cmdCerrar.Text = "CERRAR";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            this.cmdCerrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCerrar_KeyDown);
            // 
            // ctlLoginOperacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdIngresar);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctlLoginOperacional";
            this.Size = new System.Drawing.Size(442, 249);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtContrasenia;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.LabelControl lblContrasenia;
        private DevExpress.XtraEditors.LabelControl lblEtiqueta;
        private DevExpress.XtraEditors.SimpleButton cmdIngresar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}
