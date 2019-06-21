using System.Configuration;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlPublicidad));           
            this.picPublicidad = new DevExpress.XtraEditors.PictureEdit();
            this.bgCargaPublicidad = new System.ComponentModel.BackgroundWorker();           
            ((System.ComponentModel.ISupportInitialize)(this.picPublicidad.Properties)).BeginInit();
            this.SuspendLayout();            
            // 
            // picPublicidad
            // 
            this.picPublicidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPublicidad.Location = new System.Drawing.Point(0, 0);
            this.picPublicidad.Name = "picPublicidad";
            this.picPublicidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.picPublicidad.Properties.NullText = " ";
            this.picPublicidad.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPublicidad.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picPublicidad.Size = new System.Drawing.Size(218, 236);
            this.picPublicidad.TabIndex = 1;
            this.picPublicidad.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bgCargaPublicidad
            // 
            this.bgCargaPublicidad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgCargaPublicidad_DoWork);
            // 
            // CtlPublicidad
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPublicidad);         
            this.Name = "CtlPublicidad";
            this.Size = new System.Drawing.Size(218, 236);          
            ((System.ComponentModel.ISupportInitialize)(this.picPublicidad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      
        private DevExpress.XtraEditors.PictureEdit picPublicidad;
        private System.ComponentModel.BackgroundWorker bgCargaPublicidad;
    }
}
