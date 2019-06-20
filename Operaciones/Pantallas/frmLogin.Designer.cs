namespace Operaciones.Pantallas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ctlLoginOperacional1 = new Operaciones.Controles.ctlLoginOperacional();
            this.SuspendLayout();
            // 
            // ctlLoginOperacional1
            // 
            this.ctlLoginOperacional1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlLoginOperacional1.BackColor = System.Drawing.Color.White;
            this.ctlLoginOperacional1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlLoginOperacional1.Location = new System.Drawing.Point(228, 82);
            this.ctlLoginOperacional1.MaximumSize = new System.Drawing.Size(439, 405);
            this.ctlLoginOperacional1.MinimumSize = new System.Drawing.Size(439, 405);
            this.ctlLoginOperacional1.Name = "ctlLoginOperacional1";
            this.ctlLoginOperacional1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlLoginOperacional1.Pro_CargoEmpleado = null;
            this.ctlLoginOperacional1.Pro_Cliente = 0;
            this.ctlLoginOperacional1.Pro_CodigoEmpleado = null;
            this.ctlLoginOperacional1.Pro_Conexion = null;
            this.ctlLoginOperacional1.Pro_DescripcionNivelAcceso = null;
            this.ctlLoginOperacional1.Pro_ID_NivelAcceso = 0;
            this.ctlLoginOperacional1.Pro_NombreEmpleado = null;
            this.ctlLoginOperacional1.Pro_Sucursal = 0;
            this.ctlLoginOperacional1.Pro_UsuarioEmpleado = null;
            this.ctlLoginOperacional1.Size = new System.Drawing.Size(439, 405);
            this.ctlLoginOperacional1.TabIndex = 0;
            this.ctlLoginOperacional1.OnUsuarioLogueado += new System.EventHandler(this.ctlLoginOperacional1_OnUsuarioLogueado);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 611);
            this.Controls.Add(this.ctlLoginOperacional1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLUCOL ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctlLoginOperacional ctlLoginOperacional1;
    }
}