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
            this.lblBienvenido = new DevExpress.XtraEditors.LabelControl();
            this.tmrBienvenida = new System.Windows.Forms.Timer();
            this.lblNombrePrograma = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Appearance.Options.UseFont = true;
            this.lblBienvenido.Appearance.Options.UseTextOptions = true;
            this.lblBienvenido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBienvenido.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblBienvenido.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblBienvenido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBienvenido.Location = new System.Drawing.Point(0, 134);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(551, 79);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "¡BIENVENIDO!";
            // 
            // tmrBienvenida
            // 
            this.tmrBienvenida.Interval = 500;
            this.tmrBienvenida.Tick += new System.EventHandler(this.tmrBienvenida_Tick);
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePrograma.Appearance.Options.UseFont = true;
            this.lblNombrePrograma.Appearance.Options.UseTextOptions = true;
            this.lblNombrePrograma.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNombrePrograma.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNombrePrograma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombrePrograma.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombrePrograma.Location = new System.Drawing.Point(0, 0);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(122, 43);
            this.lblNombrePrograma.TabIndex = 1;
            this.lblNombrePrograma.Text = "FLUCOL";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaActualizacion.Appearance.Options.UseFont = true;
            this.lblUltimaActualizacion.Appearance.Options.UseTextOptions = true;
            this.lblUltimaActualizacion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblUltimaActualizacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblUltimaActualizacion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUltimaActualizacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(237, 0);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(314, 43);
            this.lblUltimaActualizacion.TabIndex = 2;
            this.lblUltimaActualizacion.Text = "FECHA ÚLTIMA ACTUALIZACIÓN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombrePrograma);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 43);
            this.panel1.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::Flucol.Properties.Resources.img_Flucol;
            this.pictureEdit1.Location = new System.Drawing.Point(200, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(151, 134);
            this.pictureEdit1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 134);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(351, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 134);
            this.panel3.TabIndex = 6;
            // 
            // CtlBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtlBienvenida";
            this.Size = new System.Drawing.Size(551, 256);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBienvenido;
        private System.Windows.Forms.Timer tmrBienvenida;
        private DevExpress.XtraEditors.LabelControl lblNombrePrograma;
        private DevExpress.XtraEditors.LabelControl lblUltimaActualizacion;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
