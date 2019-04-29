namespace Operaciones.Controles
{
    partial class ctlItemPosicion
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
            this.picPosicion = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPosicion = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpleadoAsignado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picPosicion.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPosicion
            // 
            this.picPosicion.Dock = System.Windows.Forms.DockStyle.Left;
            this.picPosicion.EditValue = global::Operaciones.Properties.Resources.iconPosicion;
            this.picPosicion.Location = new System.Drawing.Point(0, 0);
            this.picPosicion.Name = "picPosicion";
            this.picPosicion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picPosicion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPosicion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picPosicion.Size = new System.Drawing.Size(82, 74);
            this.picPosicion.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPosicion);
            this.panel1.Controls.Add(this.picPosicion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 74);
            this.panel1.TabIndex = 1;
            // 
            // lblPosicion
            // 
            this.lblPosicion.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Appearance.Options.UseFont = true;
            this.lblPosicion.Appearance.Options.UseTextOptions = true;
            this.lblPosicion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPosicion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblPosicion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPosicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosicion.Location = new System.Drawing.Point(82, 0);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(165, 74);
            this.lblPosicion.TabIndex = 1;
            this.lblPosicion.Text = "POSICION 99";
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
            this.lblEmpleadoAsignado.Location = new System.Drawing.Point(5, 79);
            this.lblEmpleadoAsignado.Name = "lblEmpleadoAsignado";
            this.lblEmpleadoAsignado.Size = new System.Drawing.Size(247, 42);
            this.lblEmpleadoAsignado.TabIndex = 2;
            this.lblEmpleadoAsignado.Text = "PABLO ESCOBAR";
            // 
            // ctlItemPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEmpleadoAsignado);
            this.Controls.Add(this.panel1);
            this.Name = "ctlItemPosicion";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(257, 126);
            ((System.ComponentModel.ISupportInitialize)(this.picPosicion.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picPosicion;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblPosicion;
        private DevExpress.XtraEditors.LabelControl lblEmpleadoAsignado;
    }
}
