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
            this.ctlAdministracionPrincipal1 = new Administracion.Controles.ctlAdministracionPrincipal();
            this.SuspendLayout();
            // 
            // ctlAdministracionPrincipal1
            // 
            this.ctlAdministracionPrincipal1.BackColor = System.Drawing.Color.White;
            this.ctlAdministracionPrincipal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlAdministracionPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.ctlAdministracionPrincipal1.Name = "ctlAdministracionPrincipal1";
            this.ctlAdministracionPrincipal1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlAdministracionPrincipal1.Size = new System.Drawing.Size(951, 509);
            this.ctlAdministracionPrincipal1.TabIndex = 0;
            // 
            // frmAdministracion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.ctlAdministracionPrincipal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdministracion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }




        #endregion

        private Controles.ctlAdministracionPrincipal ctlAdministracionPrincipal1;
    }
}