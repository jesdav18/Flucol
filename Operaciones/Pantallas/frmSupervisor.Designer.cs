namespace Operaciones.Pantallas
{
    partial class frmSupervisor
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
            this.ctlOperacionesSupervisor1 = new Core.Controles.Configuraciones.ctlOperacionesSupervisor();
            this.SuspendLayout();
            // 
            // ctlOperacionesSupervisor1
            // 
            this.ctlOperacionesSupervisor1.BackColor = System.Drawing.Color.White;
            this.ctlOperacionesSupervisor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlOperacionesSupervisor1.Location = new System.Drawing.Point(0, 0);
            this.ctlOperacionesSupervisor1.Name = "ctlOperacionesSupervisor1";
            this.ctlOperacionesSupervisor1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlOperacionesSupervisor1.Pro_Conexion = null;
            this.ctlOperacionesSupervisor1.Pro_ID_AgenciaServicio = 0;
            this.ctlOperacionesSupervisor1.Pro_ID_ClienteServicio = 0;
            this.ctlOperacionesSupervisor1.Pro_Usuario = null;
            this.ctlOperacionesSupervisor1.Size = new System.Drawing.Size(933, 539);
            this.ctlOperacionesSupervisor1.TabIndex = 0;
            // 
            // frmSupervisor
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 539);
            this.Controls.Add(this.ctlOperacionesSupervisor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmSupervisor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupervisor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Controles.Configuraciones.ctlOperacionesSupervisor ctlOperacionesSupervisor1;
    }
}