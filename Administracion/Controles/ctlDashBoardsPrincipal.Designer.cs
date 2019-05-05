namespace Administracion.Controles
{
    partial class ctlDashBoardsPrincipal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsDashboards1 = new Administracion.DataSet.dsDashboards();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoCliente = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDashboards1
            // 
            this.dsDashboards1.DataSetName = "dsDashboards";
            this.dsDashboards1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pictureEdit1);
            this.pnlOpciones.Controls.Add(this.flowLayoutPanel1);
            this.pnlOpciones.Controls.Add(this.panel2);
            this.pnlOpciones.Controls.Add(this.panel1);
            this.pnlOpciones.Controls.Add(this.picLogoCliente);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(5, 5);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(92, 453);
            this.pnlOpciones.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::Administracion.Properties.Resources.iconDashboard_64;
            this.pictureEdit1.Location = new System.Drawing.Point(21, 93);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(52, 53);
            this.pictureEdit1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(21, 360);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(73, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 360);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 4);
            this.panel1.TabIndex = 1;
            // 
            // picLogoCliente
            // 
            this.picLogoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoCliente.Location = new System.Drawing.Point(0, 0);
            this.picLogoCliente.Name = "picLogoCliente";
            this.picLogoCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoCliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoCliente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogoCliente.Size = new System.Drawing.Size(92, 89);
            this.picLogoCliente.TabIndex = 0;
            // 
            // ctlDashBoardsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlOpciones);
            this.Name = "ctlDashBoardsPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(681, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCliente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet.dsDashboards dsDashboards1;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picLogoCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
