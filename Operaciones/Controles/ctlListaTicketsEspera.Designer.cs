namespace Operaciones.Controles
{
    partial class ctlListaTicketsEspera
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
            this.tmrCargarColaTicketsEspera = new System.Windows.Forms.Timer();
            this.dsTickets1 = new Operaciones.DataSets.dsTickets();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colticket_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrCargarColaTicketsEspera
            // 
            this.tmrCargarColaTicketsEspera.Interval = 500;
            this.tmrCargarColaTicketsEspera.Tick += new System.EventHandler(this.tmrCargarColaTicketsEspera_Tick);
            // 
            // dsTickets1
            // 
            this.dsTickets1.DataSetName = "dsTickets";
            this.dsTickets1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtTickets";
            this.gridControl1.DataSource = this.dsTickets1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(103, 189);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colticket_servicio});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colticket_servicio
            // 
            this.colticket_servicio.FieldName = "ticket_servicio";
            this.colticket_servicio.Name = "colticket_servicio";
            this.colticket_servicio.OptionsColumn.AllowEdit = false;
            this.colticket_servicio.OptionsColumn.AllowFocus = false;
            this.colticket_servicio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colticket_servicio.OptionsColumn.AllowIncrementalSearch = false;
            this.colticket_servicio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colticket_servicio.OptionsColumn.AllowMove = false;
            this.colticket_servicio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colticket_servicio.OptionsColumn.ReadOnly = true;
            this.colticket_servicio.Visible = true;
            this.colticket_servicio.VisibleIndex = 0;
            // 
            // ctlListaTicketsEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Name = "ctlListaTicketsEspera";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(113, 199);
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrCargarColaTicketsEspera;
        private DataSets.dsTickets dsTickets1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colticket_servicio;
    }
}
