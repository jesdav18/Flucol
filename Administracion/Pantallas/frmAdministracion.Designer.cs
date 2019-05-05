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
            this.ctlDashBoards1 = new Administracion.Controles.ctlDashBoardsPrincipal();
            this.SuspendLayout();
            // 
            // ctlDashBoards1
            // 
            this.ctlDashBoards1.BackColor = System.Drawing.Color.White;
            this.ctlDashBoards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDashBoards1.Location = new System.Drawing.Point(0, 0);
            this.ctlDashBoards1.Name = "ctlDashBoards1";
            this.ctlDashBoards1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlDashBoards1.Size = new System.Drawing.Size(699, 398);
            this.ctlDashBoards1.TabIndex = 0;
            // 
            // frmAdministracion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 398);
            this.Controls.Add(this.ctlDashBoards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministracion";
            this.Text = "frmAdministracion";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctlDashBoardsPrincipal ctlDashBoards1;
    }
}