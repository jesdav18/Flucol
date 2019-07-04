namespace Administracion.Controles.Configuraciones
{
    partial class ctlMantenimientoTasaCambio
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompra = new DevExpress.XtraEditors.TextEdit();
            this.txtVenta = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardarCambios = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVenta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(738, 52);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "MANTENIMIENTO TASA DE CAMBIO";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(117, 125);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(175, 52);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "COMPRA:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(117, 185);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(175, 52);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "VENTA:";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(275, 134);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompra.Properties.Appearance.Options.UseFont = true;
            this.txtCompra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCompra.Size = new System.Drawing.Size(257, 40);
            this.txtCompra.TabIndex = 4;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(275, 194);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenta.Properties.Appearance.Options.UseFont = true;
            this.txtVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtVenta.Size = new System.Drawing.Size(257, 40);
            this.txtVenta.TabIndex = 5;
            // 
            // cmdGuardarCambios
            // 
            this.cmdGuardarCambios.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdGuardarCambios.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarCambios.Appearance.Options.UseBackColor = true;
            this.cmdGuardarCambios.Appearance.Options.UseFont = true;
            this.cmdGuardarCambios.Location = new System.Drawing.Point(71, 305);
            this.cmdGuardarCambios.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdGuardarCambios.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdGuardarCambios.Name = "cmdGuardarCambios";
            this.cmdGuardarCambios.Size = new System.Drawing.Size(593, 69);
            this.cmdGuardarCambios.TabIndex = 6;
            this.cmdGuardarCambios.Text = "GUARDAR CAMBIOS";
            this.cmdGuardarCambios.Click += new System.EventHandler(this.CmdGuardarCambios_Click);
            // 
            // ctlMantenimientoTasaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmdGuardarCambios);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ctlMantenimientoTasaCambio";
            this.Size = new System.Drawing.Size(738, 411);
            ((System.ComponentModel.ISupportInitialize)(this.txtCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVenta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCompra;
        private DevExpress.XtraEditors.TextEdit txtVenta;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarCambios;
    }
}
