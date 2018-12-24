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
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.uTilePanelPosiciones = new Infragistics.Win.Misc.UltraTilePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ultraTile1 = new Infragistics.Win.Misc.UltraTile();
            ((System.ComponentModel.ISupportInitialize)(this.uTilePanelPosiciones)).BeginInit();
            this.uTilePanelPosiciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // uTilePanelPosiciones
            // 
            this.uTilePanelPosiciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.uTilePanelPosiciones.Location = new System.Drawing.Point(510, 0);
            this.uTilePanelPosiciones.Name = "uTilePanelPosiciones";
            this.uTilePanelPosiciones.NormalModeDimensions = new System.Drawing.Size(1, 1);
            this.uTilePanelPosiciones.Size = new System.Drawing.Size(480, 495);
            this.uTilePanelPosiciones.TabIndex = 0;
            this.uTilePanelPosiciones.Tiles.Add(this.ultraTile1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // ultraTile1
            // 
            this.ultraTile1.Caption = "button2";
            this.ultraTile1.Name = "ultraTile1";
            this.ultraTile1.PositionInNormalMode = new System.Drawing.Point(0, 0);
            this.ultraTile1.TabIndex = 0;
            // 
            // ctlAdministracionPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uTilePanelPosiciones);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctlAdministracionPosiciones";
            this.Size = new System.Drawing.Size(990, 495);
            ((System.ComponentModel.ISupportInitialize)(this.uTilePanelPosiciones)).EndInit();
            this.uTilePanelPosiciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private Infragistics.Win.Misc.UltraTilePanel uTilePanelPosiciones;
        private Infragistics.Win.Misc.UltraTile ultraTile1;
        private System.Windows.Forms.Button button1;
    }
}
