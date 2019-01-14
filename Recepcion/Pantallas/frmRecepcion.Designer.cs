namespace Recepcion.Pantallas
{
    partial class frmRecepcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcion));
            this.ctlSeleccionTransaccion1 = new Recepcion.Controles.CtlSeleccionTransaccion();
            this.SuspendLayout();
            // 
            // ctlSeleccionTransaccion1
            // 
            this.ctlSeleccionTransaccion1.BackColor = System.Drawing.Color.White;
            this.ctlSeleccionTransaccion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSeleccionTransaccion1.Location = new System.Drawing.Point(0, 0);
            this.ctlSeleccionTransaccion1.Name = "ctlSeleccionTransaccion1";
            this.ctlSeleccionTransaccion1.Pro_Conexion = null;
            this.ctlSeleccionTransaccion1.Pro_ID_Cliente_Servicio = 0;
            this.ctlSeleccionTransaccion1.Pro_ID_Operacion_Servicio = 0;
            this.ctlSeleccionTransaccion1.Pro_ID_Tipo_Ticket_Servicio = 0;
            this.ctlSeleccionTransaccion1.Pro_ID_AgenciaServicio = 0;
            this.ctlSeleccionTransaccion1.Pro_Ticket_Generado = null;
            this.ctlSeleccionTransaccion1.Size = new System.Drawing.Size(926, 457);
            this.ctlSeleccionTransaccion1.TabIndex = 0;
            // 
            // frmRecepcion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 457);
            this.Controls.Add(this.ctlSeleccionTransaccion1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Name = "frmRecepcion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLUCOL | RECEPCIÓN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.CtlSeleccionTransaccion ctlSeleccionTransaccion1;
    }
}