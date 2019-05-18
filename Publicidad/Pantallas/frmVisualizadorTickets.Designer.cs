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
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            this.ctlNoticias1 = new Publicidad.Controles.ctlNoticias();
            this.pnlTasasCambio = new System.Windows.Forms.Panel();
            this.ctlTasasCambio1 = new Publicidad.Controles.ctlTasasCambio();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.ctlTicketsPosiciones1 = new Publicidad.Controles.CtlTicketsPosiciones();
            this.ctlPublicidad1 = new Publicidad.Controles.CtlPublicidad();
            this.pnlTitulo = new DevExpress.XtraEditors.PanelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblAgencia = new DevExpress.XtraEditors.LabelControl();
            this.pnlInferior.SuspendLayout();
            this.pnlNoticias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            this.pnlTasasCambio.SuspendLayout();
            this.pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.pnlNoticias);
            this.pnlInferior.Controls.Add(this.pnlTasasCambio);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(5, 444);
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
            // pnlTasasCambio
            // 
            this.pnlTasasCambio.Controls.Add(this.ctlTasasCambio1);
            this.pnlTasasCambio.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTasasCambio.Location = new System.Drawing.Point(673, 0);
            this.pnlTasasCambio.Name = "pnlTasasCambio";
            this.pnlTasasCambio.Size = new System.Drawing.Size(218, 91);
            this.pnlTasasCambio.TabIndex = 0;
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
            // pnlTickets
            // 
            this.pnlTickets.Controls.Add(this.ctlTicketsPosiciones1);
            this.pnlTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTickets.Location = new System.Drawing.Point(5, 99);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(539, 345);
            this.pnlTickets.TabIndex = 4;
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
            this.ctlTicketsPosiciones1.Size = new System.Drawing.Size(539, 345);
            this.ctlTicketsPosiciones1.TabIndex = 1;
            // 
            // ctlPublicidad1
            // 
            this.ctlPublicidad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPublicidad1.Location = new System.Drawing.Point(544, 99);
            this.ctlPublicidad1.Name = "ctlPublicidad1";
            this.ctlPublicidad1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ctlPublicidad1.Pro_Cliente = 0;
            this.ctlPublicidad1.Pro_Conexion = null;
            this.ctlPublicidad1.Pro_Sucursal = 0;
            this.ctlPublicidad1.Size = new System.Drawing.Size(352, 345);
            this.ctlPublicidad1.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.lblAgencia);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(5, 5);
            this.pnlTitulo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlTitulo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(891, 94);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Appearance.Options.UseBackColor = true;
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseForeColor = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(885, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // lblAgencia
            // 
            this.lblAgencia.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAgencia.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAgencia.Appearance.Options.UseBackColor = true;
            this.lblAgencia.Appearance.Options.UseFont = true;
            this.lblAgencia.Appearance.Options.UseForeColor = true;
            this.lblAgencia.Appearance.Options.UseTextOptions = true;
            this.lblAgencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAgencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAgencia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAgencia.Location = new System.Drawing.Point(3, 48);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(885, 43);
            this.lblAgencia.TabIndex = 1;
            this.lblAgencia.Text = "BIENVENIDO";
            // 
            // frmVisualizadorTickets
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 540);
            this.Controls.Add(this.ctlPublicidad1);
            this.Controls.Add(this.pnlTickets);
            this.Controls.Add(this.pnlTitulo);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            this.pnlTasasCambio.ResumeLayout(false);
            this.pnlTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
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
        private DevExpress.XtraEditors.PanelControl pnlTitulo;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.LabelControl lblAgencia;
    }
}