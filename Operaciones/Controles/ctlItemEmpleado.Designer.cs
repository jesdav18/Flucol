namespace Operaciones.Controles
{
    partial class ctlItemEmpleado
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
            this.lblEmpleadoAsignado = new DevExpress.XtraEditors.LabelControl();
            this.picPosicion = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picPosicion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleadoAsignado
            // 
            this.lblEmpleadoAsignado.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoAsignado.Appearance.Options.UseFont = true;
            this.lblEmpleadoAsignado.Appearance.Options.UseTextOptions = true;
            this.lblEmpleadoAsignado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEmpleadoAsignado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEmpleadoAsignado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmpleadoAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpleadoAsignado.Location = new System.Drawing.Point(75, 5);
            this.lblEmpleadoAsignado.Name = "lblEmpleadoAsignado";
            this.lblEmpleadoAsignado.Size = new System.Drawing.Size(195, 61);
            this.lblEmpleadoAsignado.TabIndex = 3;
            this.lblEmpleadoAsignado.Text = "PABLO ESCOBAR";
            // 
            // picPosicion
            // 
            this.picPosicion.Dock = System.Windows.Forms.DockStyle.Left;
            this.picPosicion.EditValue = global::Operaciones.Properties.Resources.iconUsuario;
            this.picPosicion.Location = new System.Drawing.Point(5, 5);
            this.picPosicion.Name = "picPosicion";
            this.picPosicion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picPosicion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPosicion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picPosicion.Size = new System.Drawing.Size(70, 61);
            this.picPosicion.TabIndex = 4;
            // 
            // ctlItemEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEmpleadoAsignado);
            this.Controls.Add(this.picPosicion);
            this.Name = "ctlItemEmpleado";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(275, 71);
            ((System.ComponentModel.ISupportInitialize)(this.picPosicion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblEmpleadoAsignado;
        private DevExpress.XtraEditors.PictureEdit picPosicion;
    }
}
