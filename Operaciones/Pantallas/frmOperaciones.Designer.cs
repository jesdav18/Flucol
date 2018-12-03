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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOperaciones";
            this.Text = "FLUCOL | OPERACIONES";

            this.ResumeLayout(false);

        }

        #endregion

        private Controles.CtlOperacional ctlOperacional1;
    }
}