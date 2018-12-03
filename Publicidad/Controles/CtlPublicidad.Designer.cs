namespace Publicidad.Controles
{
    partial class CtlPublicidad
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
            this.picInicial = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picInicial
            // 
            this.picInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picInicial.EditValue = global::Publicidad.Properties.Resources.en_construccion;
            this.picInicial.Location = new System.Drawing.Point(0, 0);
            this.picInicial.Name = "picInicial";
            this.picInicial.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picInicial.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picInicial.Size = new System.Drawing.Size(466, 236);
            this.picInicial.TabIndex = 0;
            // 
            // CtlPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picInicial);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtlPublicidad";
            this.Size = new System.Drawing.Size(466, 236);
            ((System.ComponentModel.ISupportInitialize)(this.picInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picInicial;
    }
}
