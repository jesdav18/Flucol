namespace Operaciones.Pantallas
{
    partial class frmOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaciones));
            this.ctlOperacional1 = new Operaciones.Controles.CtlOperacional();
            this.SuspendLayout();
            // 
            // ctlOperacional1
            // 
            this.ctlOperacional1.BackColor = System.Drawing.Color.White;
            this.ctlOperacional1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlOperacional1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlOperacional1.Location = new System.Drawing.Point(0, 0);
            this.ctlOperacional1.Name = "ctlOperacional1";
            this.ctlOperacional1.Pro_Cargo = null;
            this.ctlOperacional1.Pro_ID_ClienteServicio = 0;
            this.ctlOperacional1.Pro_Conexion = null;
            this.ctlOperacional1.Pro_DescripcionNivelAcceso = null;
            this.ctlOperacional1.Pro_ID_NivelAccesoEmpleado = 0;
            this.ctlOperacional1.Pro_NombreEmpleado = null;
            this.ctlOperacional1.Pro_Posicion = 0;
            this.ctlOperacional1.Pro_Prioridad_Atencion = 0;
            this.ctlOperacional1.Pro_ID_AgenciaServicio = 0;
            this.ctlOperacional1.Pro_Ticket_Servicio = null;
            this.ctlOperacional1.Pro_Usuario = null;
            this.ctlOperacional1.Size = new System.Drawing.Size(951, 509);
            this.ctlOperacional1.TabIndex = 0;
            // 
            // frmOperaciones
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.ctlOperacional1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmOperaciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLUCOL | OPERACIONES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOperaciones_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.CtlOperacional ctlOperacional1;
    }
}