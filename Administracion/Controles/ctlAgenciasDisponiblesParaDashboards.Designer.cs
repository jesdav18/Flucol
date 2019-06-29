namespace Administracion.Controles
{
    partial class ctlAgenciasDisponiblesParaDashboards
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCore1 = new Core.DataSets.dsCore();
            this.gvSucursalesDisponibles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_agencia_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_agencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoNombreAgencia = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoDireccion = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colimg_ver_dashboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDashboard = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_cliente_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSucursalesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNombreAgencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 42);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(734, 42);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "AGENCIAS DISPONIBLES";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtAgenciasDisponibles";
            this.gridControl1.DataSource = this.dsCore1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(5, 47);
            this.gridControl1.MainView = this.gvSucursalesDisponibles;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDashboard,
            this.memoDireccion,
            this.memoNombreAgencia});
            this.gridControl1.Size = new System.Drawing.Size(734, 417);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSucursalesDisponibles});
            // 
            // dsCore1
            // 
            this.dsCore1.DataSetName = "dsCore";
            this.dsCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSucursalesDisponibles
            // 
            this.gvSucursalesDisponibles.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSucursalesDisponibles.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSucursalesDisponibles.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSucursalesDisponibles.Appearance.Row.Options.UseFont = true;
            this.gvSucursalesDisponibles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_agencia_servicio,
            this.colnombre_agencia,
            this.coldireccion,
            this.colimg_ver_dashboard,
            this.colid_cliente_servicio});
            this.gvSucursalesDisponibles.GridControl = this.gridControl1;
            this.gvSucursalesDisponibles.Name = "gvSucursalesDisponibles";
            this.gvSucursalesDisponibles.OptionsView.ShowGroupPanel = false;
            this.gvSucursalesDisponibles.OptionsView.ShowIndicator = false;
            // 
            // colid_agencia_servicio
            // 
            this.colid_agencia_servicio.AppearanceCell.Options.UseTextOptions = true;
            this.colid_agencia_servicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_agencia_servicio.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_agencia_servicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_agencia_servicio.Caption = "CODIGO";
            this.colid_agencia_servicio.FieldName = "id_agencia_servicio";
            this.colid_agencia_servicio.MaxWidth = 100;
            this.colid_agencia_servicio.MinWidth = 100;
            this.colid_agencia_servicio.Name = "colid_agencia_servicio";
            this.colid_agencia_servicio.OptionsColumn.AllowEdit = false;
            this.colid_agencia_servicio.OptionsColumn.AllowFocus = false;
            this.colid_agencia_servicio.Visible = true;
            this.colid_agencia_servicio.VisibleIndex = 0;
            this.colid_agencia_servicio.Width = 100;
            // 
            // colnombre_agencia
            // 
            this.colnombre_agencia.Caption = "NOMBRE DE AGENCIA";
            this.colnombre_agencia.ColumnEdit = this.memoNombreAgencia;
            this.colnombre_agencia.FieldName = "nombre_agencia";
            this.colnombre_agencia.Name = "colnombre_agencia";
            this.colnombre_agencia.OptionsColumn.AllowEdit = false;
            this.colnombre_agencia.OptionsColumn.AllowFocus = false;
            this.colnombre_agencia.Visible = true;
            this.colnombre_agencia.VisibleIndex = 1;
            this.colnombre_agencia.Width = 296;
            // 
            // memoNombreAgencia
            // 
            this.memoNombreAgencia.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoNombreAgencia.Appearance.Options.UseFont = true;
            this.memoNombreAgencia.Name = "memoNombreAgencia";
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "DIRECCIÓN";
            this.coldireccion.ColumnEdit = this.memoDireccion;
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.OptionsColumn.AllowFocus = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 2;
            this.coldireccion.Width = 286;
            // 
            // memoDireccion
            // 
            this.memoDireccion.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoDireccion.Appearance.Options.UseFont = true;
            this.memoDireccion.Name = "memoDireccion";
            // 
            // colimg_ver_dashboard
            // 
            this.colimg_ver_dashboard.Caption = " ";
            this.colimg_ver_dashboard.ColumnEdit = this.cmdVerDashboard;
            this.colimg_ver_dashboard.FieldName = "img_ver_dashboard";
            this.colimg_ver_dashboard.MaxWidth = 50;
            this.colimg_ver_dashboard.MinWidth = 50;
            this.colimg_ver_dashboard.Name = "colimg_ver_dashboard";
            this.colimg_ver_dashboard.Visible = true;
            this.colimg_ver_dashboard.VisibleIndex = 3;
            this.colimg_ver_dashboard.Width = 50;
            // 
            // cmdVerDashboard
            // 
            this.cmdVerDashboard.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Administracion.Properties.Resources.iconBusqueda_32;
            this.cmdVerDashboard.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDashboard.Name = "cmdVerDashboard";
            this.cmdVerDashboard.NullText = " ";
            this.cmdVerDashboard.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerDashboard.Click += new System.EventHandler(this.cmdVerDashboard_Click);
            // 
            // colid_cliente_servicio
            // 
            this.colid_cliente_servicio.FieldName = "id_cliente_servicio";
            this.colid_cliente_servicio.Name = "colid_cliente_servicio";
            // 
            // ctlAgenciasDisponiblesParaDashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ctlAgenciasDisponiblesParaDashboards";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(744, 469);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSucursalesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNombreAgencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSucursalesDisponibles;
        private Core.DataSets.dsCore dsCore1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_agencia_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_agencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoNombreAgencia;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colimg_ver_dashboard;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDashboard;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente_servicio;
    }
}
