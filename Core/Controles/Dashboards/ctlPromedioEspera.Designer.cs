namespace Core.Controles.Dashboards
{
    partial class ctlPromedioEspera
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.lblPromedioEspera = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 4);
            this.panel1.TabIndex = 8;
            // 
            // lblTituloDashboard
            // 
            this.lblTituloDashboard.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDashboard.Appearance.Options.UseFont = true;
            this.lblTituloDashboard.Appearance.Options.UseTextOptions = true;
            this.lblTituloDashboard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloDashboard.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTituloDashboard.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloDashboard.Location = new System.Drawing.Point(5, 5);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(178, 34);
            this.lblTituloDashboard.TabIndex = 7;
            this.lblTituloDashboard.Text = "PROMEDIO DE ESPERA";
            // 
            // lblPromedioEspera
            // 
            this.lblPromedioEspera.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioEspera.Appearance.Options.UseFont = true;
            this.lblPromedioEspera.Appearance.Options.UseTextOptions = true;
            this.lblPromedioEspera.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPromedioEspera.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblPromedioEspera.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPromedioEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPromedioEspera.Location = new System.Drawing.Point(5, 43);
            this.lblPromedioEspera.Name = "lblPromedioEspera";
            this.lblPromedioEspera.Size = new System.Drawing.Size(178, 185);
            this.lblPromedioEspera.TabIndex = 9;
            this.lblPromedioEspera.Text = "99 DIAS,       25 HORAS,    25 MINUTOS Y 33 SEGUNDOS";
            // 
            // ctlPromedioEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPromedioEspera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.MaximumSize = new System.Drawing.Size(190, 225);
            this.MinimumSize = new System.Drawing.Size(190, 225);
            this.Name = "ctlPromedioEspera";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(188, 223);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
        private DevExpress.XtraEditors.LabelControl lblPromedioEspera;
    }
}
