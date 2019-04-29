namespace Publicidad.Controles
{
    partial class ctlNoticias
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
            this.memoNoticias = new DevExpress.XtraEditors.MemoEdit();
            this.bgMostrarPresentacion = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoticias.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoNoticias
            // 
            this.memoNoticias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoNoticias.EditValue = "ESTO ES UN TEXTO DE PRUEBA PARA PODER APROXIMAR TAMAÑO DE LETRA";
            this.memoNoticias.Location = new System.Drawing.Point(0, 0);
            this.memoNoticias.Name = "memoNoticias";
            this.memoNoticias.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoNoticias.Properties.Appearance.Options.UseFont = true;
            this.memoNoticias.Properties.Appearance.Options.UseTextOptions = true;
            this.memoNoticias.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.memoNoticias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.memoNoticias.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoNoticias.Size = new System.Drawing.Size(488, 93);
            this.memoNoticias.TabIndex = 0;
            // 
            // bgMostrarPresentacion
            // 
            this.bgMostrarPresentacion.WorkerSupportsCancellation = true;
            this.bgMostrarPresentacion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMostrarPresentacion_DoWork);
            // 
            // ctlNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.memoNoticias);
            this.Name = "ctlNoticias";
            this.Size = new System.Drawing.Size(488, 93);
            ((System.ComponentModel.ISupportInitialize)(this.memoNoticias.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoNoticias;
        private System.ComponentModel.BackgroundWorker bgMostrarPresentacion;
    }
}
