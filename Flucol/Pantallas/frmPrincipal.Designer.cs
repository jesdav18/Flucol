namespace Flucol.Pantallas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ctlPublicidad1 = new Flucol.Controles.CtlPublicidad();
            this.dsTicketsPosiciones1 = new Flucol.DataSets.dsTicketsPosiciones();
            this.ctlTicketsPosiciones1 = new Flucol.Controles.CtlTicketsPosiciones();
            ((System.ComponentModel.ISupportInitialize)(this.dsTicketsPosiciones1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlPublicidad1
            // 
            this.ctlPublicidad1.BackColor = System.Drawing.Color.White;
            this.ctlPublicidad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPublicidad1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPublicidad1.Location = new System.Drawing.Point(0, 0);
            this.ctlPublicidad1.Name = "ctlPublicidad1";
            this.ctlPublicidad1.Size = new System.Drawing.Size(564, 509);
            this.ctlPublicidad1.TabIndex = 0;
            // 
            // dsTicketsPosiciones1
            // 
            this.dsTicketsPosiciones1.DataSetName = "dsTicketsPosiciones";
            this.dsTicketsPosiciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctlTicketsPosiciones1
            // 
            this.ctlTicketsPosiciones1.BackColor = System.Drawing.Color.White;
            this.ctlTicketsPosiciones1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctlTicketsPosiciones1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlTicketsPosiciones1.Location = new System.Drawing.Point(564, 0);
            this.ctlTicketsPosiciones1.Name = "ctlTicketsPosiciones1";
            this.ctlTicketsPosiciones1.Size = new System.Drawing.Size(549, 509);
            this.ctlTicketsPosiciones1.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 509);
            this.Controls.Add(this.ctlPublicidad1);
            this.Controls.Add(this.ctlTicketsPosiciones1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "FLUCOL | PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)(this.dsTicketsPosiciones1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.CtlPublicidad ctlPublicidad1;
        private DataSets.dsTicketsPosiciones dsTicketsPosiciones1;
        private Controles.CtlTicketsPosiciones ctlTicketsPosiciones1;
    }
}