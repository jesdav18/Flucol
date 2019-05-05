namespace Administracion.Pantallas
{
    partial class frmAdministracion
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
            this.ctlDashBoardsPrincipal1 = new Administracion.Controles.ctlDashBoardsPrincipal();
            this.SuspendLayout();
            // 
            // ctlDashBoardsPrincipal1
            // 
            this.ctlDashBoardsPrincipal1.BackColor = System.Drawing.Color.White;
            this.ctlDashBoardsPrincipal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDashBoardsPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.ctlDashBoardsPrincipal1.Name = "ctlDashBoardsPrincipal1";
            this.ctlDashBoardsPrincipal1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlDashBoardsPrincipal1.Pro_Conexion = null;
            this.ctlDashBoardsPrincipal1.Pro_ID_Cliente_Servicio = 0;
            this.ctlDashBoardsPrincipal1.Size = new System.Drawing.Size(699, 398);
            this.ctlDashBoardsPrincipal1.TabIndex = 0;
            // 
            // frmAdministracion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 398);
            this.Controls.Add(this.ctlDashBoardsPrincipal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }


        #endregion

        private Controles.ctlDashBoardsPrincipal ctlDashBoardsPrincipal1;
    }
}