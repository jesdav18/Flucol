namespace Constructor.Pantallas
{
    partial class frmConstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConstructor));
            this.ctlBienvenida1 = new Constructor.Controles.CtlBienvenida();
            this.SuspendLayout();
            // 
            // ctlBienvenida1
            // 
            this.ctlBienvenida1.BackColor = System.Drawing.Color.White;
            this.ctlBienvenida1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlBienvenida1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBienvenida1.Location = new System.Drawing.Point(0, 0);
            this.ctlBienvenida1.Name = "ctlBienvenida1";
            this.ctlBienvenida1.Size = new System.Drawing.Size(633, 358);
            this.ctlBienvenida1.TabIndex = 0;
            this.ctlBienvenida1.OnTerminaTiempoBienvenida += new System.EventHandler(this.ctlBienvenida1_OnTerminaTiempoBienvenida);
            // 
            // frmConstructor
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.ctlBienvenida1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConstructor";
            this.Text = "FLUCOL | CONSTRUCTOR";
            this.ResumeLayout(false);

        }


        #endregion

        private Controles.CtlBienvenida ctlBienvenida1;
    }
}