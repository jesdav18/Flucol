﻿namespace Core.Controles.Dashboards
{
    partial class ctlPromedioAtencion
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
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPromedioAtencion = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
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
            this.lblTituloDashboard.Location = new System.Drawing.Point(0, 0);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(188, 34);
            this.lblTituloDashboard.TabIndex = 1;
            this.lblTituloDashboard.Text = "PROMEDIO DE ATENCION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 4);
            this.panel1.TabIndex = 6;
            // 
            // lblPromedioAtencion
            // 
            this.lblPromedioAtencion.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioAtencion.Appearance.Options.UseFont = true;
            this.lblPromedioAtencion.Appearance.Options.UseTextOptions = true;
            this.lblPromedioAtencion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPromedioAtencion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblPromedioAtencion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPromedioAtencion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPromedioAtencion.Location = new System.Drawing.Point(0, 38);
            this.lblPromedioAtencion.Name = "lblPromedioAtencion";
            this.lblPromedioAtencion.Size = new System.Drawing.Size(188, 185);
            this.lblPromedioAtencion.TabIndex = 7;
            this.lblPromedioAtencion.Text = "99 DIAS,       25 HORAS,    25 MINUTOS Y 33 SEGUNDOS";
            // 
            // ctlPromedioAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPromedioAtencion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.MaximumSize = new System.Drawing.Size(190, 225);
            this.MinimumSize = new System.Drawing.Size(190, 225);
            this.Name = "ctlPromedioAtencion";
            this.Size = new System.Drawing.Size(188, 223);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblPromedioAtencion;
    }
}
