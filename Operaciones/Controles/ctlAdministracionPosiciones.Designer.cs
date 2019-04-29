namespace Operaciones.Controles
{
    partial class ctlAdministracionPosiciones
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
            this.flpPosiciones = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEmpleados = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPosiciones
            // 
            this.flpPosiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpPosiciones.Location = new System.Drawing.Point(5, 5);
            this.flpPosiciones.Name = "flpPosiciones";
            this.flpPosiciones.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flpPosiciones.Size = new System.Drawing.Size(698, 232);
            this.flpPosiciones.TabIndex = 0;
            // 
            // flpEmpleados
            // 
            this.flpEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEmpleados.Location = new System.Drawing.Point(5, 237);
            this.flpEmpleados.Name = "flpEmpleados";
            this.flpEmpleados.Size = new System.Drawing.Size(698, 235);
            this.flpEmpleados.TabIndex = 1;
            // 
            // ctlAdministracionPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpEmpleados);
            this.Controls.Add(this.flpPosiciones);
            this.Name = "ctlAdministracionPosiciones";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(708, 477);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPosiciones;
        private System.Windows.Forms.FlowLayoutPanel flpEmpleados;
    }
}
