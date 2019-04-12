namespace Publicidad.Pantallas
{
    partial class frmVisualizadorTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizadorTickets));
            this.ctlPublicidad1 = new Publicidad.Controles.CtlPublicidad();
            this.ctlTicketsPosiciones1 = new Publicidad.Controles.CtlTicketsPosiciones();
            this.SuspendLayout();
            // 
            // ctlPublicidad1
            // 
            this.ctlPublicidad1.BackColor = System.Drawing.Color.White;
            this.ctlPublicidad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPublicidad1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPublicidad1.Location = new System.Drawing.Point(5, 5);
            this.ctlPublicidad1.Name = "ctlPublicidad1";
            this.ctlPublicidad1.Pro_Cliente = 0;
            this.ctlPublicidad1.Pro_Conexion = null;
            this.ctlPublicidad1.Pro_Sucursal = 0;
            this.ctlPublicidad1.Size = new System.Drawing.Size(1064, 473);
            this.ctlPublicidad1.TabIndex = 0;
            // 
            // ctlTicketsPosiciones1
            // 
            this.ctlTicketsPosiciones1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsPosiciones1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctlTicketsPosiciones1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlTicketsPosiciones1.Location = new System.Drawing.Point(492, 5);
            this.ctlTicketsPosiciones1.Name = "ctlTicketsPosiciones1";
            this.ctlTicketsPosiciones1.Pro_Conexion = null;
            this.ctlTicketsPosiciones1.Pro_ID_Cliente = 0;
            this.ctlTicketsPosiciones1.Pro_Sucursal = 0;
            this.ctlTicketsPosiciones1.Pro_Texto_Descriptivo = null;
            this.ctlTicketsPosiciones1.Pro_Voz = null;
            this.ctlTicketsPosiciones1.Size = new System.Drawing.Size(577, 473);
            this.ctlTicketsPosiciones1.TabIndex = 1;
            // 
            // frmVisualizadorTickets
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 483);
            this.Controls.Add(this.ctlTicketsPosiciones1);
            this.Controls.Add(this.ctlPublicidad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizadorTickets";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLUCOL | VISUALIZADOR TICKETS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }


        #endregion

        private Controles.CtlPublicidad ctlPublicidad1;
        private Controles.CtlTicketsPosiciones ctlTicketsPosiciones1;
    }
}