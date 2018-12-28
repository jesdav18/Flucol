namespace Flucol.Controles
{
    partial class CtlBienvenida
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
            this.lblBienvenido = new DevExpress.XtraEditors.LabelControl();
            this.tmrBienvenida = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Appearance.Options.UseFont = true;
            this.lblBienvenido.Appearance.Options.UseTextOptions = true;
            this.lblBienvenido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBienvenido.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblBienvenido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBienvenido.Location = new System.Drawing.Point(84, 85);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(429, 200);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "¡BUENOS DIAS! ¡BIENVENIDO!";
            // 
            // tmrBienvenida
            // 
            this.tmrBienvenida.Interval = 500;
            this.tmrBienvenida.Tick += new System.EventHandler(this.tmrBienvenida_Tick);
            // 
            // CtlBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBienvenido);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtlBienvenida";
            this.Size = new System.Drawing.Size(609, 392);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBienvenido;
        private System.Windows.Forms.Timer tmrBienvenida;
    }
}
