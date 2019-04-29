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
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlNoticias = new System.Windows.Forms.Panel();
            this.pnlTasasCambio = new System.Windows.Forms.Panel();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.ctlPublicidad1 = new Publicidad.Controles.CtlPublicidad();
            this.ctlTicketsPosiciones1 = new Publicidad.Controles.CtlTicketsPosiciones();
            this.ctlNoticias1 = new Publicidad.Controles.ctlNoticias();
            this.ctlTasasCambio1 = new Publicidad.Controles.ctlTasasCambio();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.pnlInferior.SuspendLayout();
            this.pnlNoticias.SuspendLayout();
            this.pnlTasasCambio.SuspendLayout();
            this.pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.pnlNoticias);
            this.pnlInferior.Controls.Add(this.pnlTasasCambio);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(5, 413);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(891, 91);
            this.pnlInferior.TabIndex = 2;
            // 
            // pnlNoticias
            // 
            this.pnlNoticias.Controls.Add(this.picLogoCliente);
            this.pnlNoticias.Controls.Add(this.ctlNoticias1);
            this.pnlNoticias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoticias.Location = new System.Drawing.Point(0, 0);
            this.pnlNoticias.Name = "pnlNoticias";
            this.pnlNoticias.Size = new System.Drawing.Size(673, 91);
            this.pnlNoticias.TabIndex = 1;
            // 
            // pnlTasasCambio
            // 
            this.pnlTasasCambio.Controls.Add(this.ctlTasasCambio1);
            this.pnlTasasCambio.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTasasCambio.Location = new System.Drawing.Point(673, 0);
            this.pnlTasasCambio.Name = "pnlTasasCambio";
            this.pnlTasasCambio.Size = new System.Drawing.Size(218, 91);
            this.pnlTasasCambio.TabIndex = 0;
            // 
            // pnlTickets
            // 
            this.pnlTickets.Controls.Add(this.ctlTicketsPosiciones1);
            this.pnlTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTickets.Location = new System.Drawing.Point(5, 5);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(539, 408);
            this.pnlTickets.TabIndex = 4;
            // 
            // ctlPublicidad1
            // 
            this.ctlPublicidad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPublicidad1.Location = new System.Drawing.Point(544, 5);
            this.ctlPublicidad1.Name = "ctlPublicidad1";
            this.ctlPublicidad1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ctlPublicidad1.Pro_Cliente = 0;
            this.ctlPublicidad1.Pro_Conexion = null;
            this.ctlPublicidad1.Pro_Sucursal = 0;
            this.ctlPublicidad1.Size = new System.Drawing.Size(352, 408);
            this.ctlPublicidad1.TabIndex = 0;
            // 
            // ctlTicketsPosiciones1
            // 
            this.ctlTicketsPosiciones1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsPosiciones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTicketsPosiciones1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlTicketsPosiciones1.Location = new System.Drawing.Point(0, 0);
            this.ctlTicketsPosiciones1.Name = "ctlTicketsPosiciones1";
            this.ctlTicketsPosiciones1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ctlTicketsPosiciones1.Pro_Conexion = null;
            this.ctlTicketsPosiciones1.Pro_ID_Cliente = 0;
            this.ctlTicketsPosiciones1.Pro_Sucursal = 0;
            this.ctlTicketsPosiciones1.Pro_Texto_Descriptivo = null;
            this.ctlTicketsPosiciones1.Pro_Voz = null;
            this.ctlTicketsPosiciones1.Size = new System.Drawing.Size(539, 408);
            this.ctlTicketsPosiciones1.TabIndex = 1;
            // 
            // ctlNoticias1
            // 
            this.ctlNoticias1.BackColor = System.Drawing.Color.White;
            this.ctlNoticias1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctlNoticias1.Location = new System.Drawing.Point(126, 0);
            this.ctlNoticias1.Name = "ctlNoticias1";
            this.ctlNoticias1.Pro_Conexion = null;
            this.ctlNoticias1.Pro_ID_Cliente_Servicio = 0;
            this.ctlNoticias1.Size = new System.Drawing.Size(547, 91);
            this.ctlNoticias1.TabIndex = 0;
            // 
            // ctlTasasCambio1
            // 
            this.ctlTasasCambio1.BackColor = System.Drawing.Color.White;
            this.ctlTasasCambio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlTasasCambio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTasasCambio1.Location = new System.Drawing.Point(0, 0);
            this.ctlTasasCambio1.Name = "ctlTasasCambio1";
            this.ctlTasasCambio1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTasasCambio1.Pro_Conexion = null;
            this.ctlTasasCambio1.Size = new System.Drawing.Size(218, 91);
            this.ctlTasasCambio1.TabIndex = 0;
            // 
            // picLogoCliente
            // 
            this.picLogoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogoCliente.Location = new System.Drawing.Point(0, 0);
            this.picLogoCliente.Name = "picLogoCliente";
            this.picLogoCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.picLogoCliente.Properties.NullText = " ";
            this.picLogoCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogoCliente.Size = new System.Drawing.Size(126, 91);
            this.picLogoCliente.TabIndex = 1;
            // 
            // frmVisualizadorTickets
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 509);
            this.Controls.Add(this.ctlPublicidad1);
            this.Controls.Add(this.pnlTickets);
            this.Controls.Add(this.pnlInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizadorTickets";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLUCOL | VISUALIZADOR TICKETS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlInferior.ResumeLayout(false);
            this.pnlNoticias.ResumeLayout(false);
            this.pnlTasasCambio.ResumeLayout(false);
            this.pnlTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Controles.CtlTicketsPosiciones ctlTicketsPosiciones1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlNoticias;
        private Controles.ctlNoticias ctlNoticias1;
        private System.Windows.Forms.Panel pnlTasasCambio;
        private System.Windows.Forms.Panel pnlTickets;
        private Controles.ctlTasasCambio ctlTasasCambio1;
        private Controles.CtlPublicidad ctlPublicidad1;
        private DevExpress.XtraEditors.PictureEdit picLogoCliente;
    }
}