namespace Operaciones.Controles.Configuraciones
{
    partial class ctlAsignacionPosiciones
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsConfiguraciones1 = new Operaciones.Controles.Configuraciones.DataSets.dsConfiguraciones();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposicion_asignada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargar_posiciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCargarPosiciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.popupPosicionesDisponibles = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.ctlPosicionesDisponibles1 = new Core.Controles.Popups.ctlPosicionesDisponibles();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargarPosiciones)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupPosicionesDisponibles)).BeginInit();
            this.popupPosicionesDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtAsignacionPosiciones";
            this.gridControl1.DataSource = this.dsConfiguraciones1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdCargarPosiciones});
            this.gridControl1.Size = new System.Drawing.Size(924, 468);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsConfiguraciones1
            // 
            this.dsConfiguraciones1.DataSetName = "dsConfiguraciones";
            this.dsConfiguraciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusuario,
            this.colcodigo_empleado,
            this.colnombre_empleado,
            this.colposicion_asignada,
            this.colcargo_empleado,
            this.colcargar_posiciones});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            // 
            // colcodigo_empleado
            // 
            this.colcodigo_empleado.Caption = "CÓDIGO";
            this.colcodigo_empleado.FieldName = "codigo_empleado";
            this.colcodigo_empleado.Name = "colcodigo_empleado";
            this.colcodigo_empleado.Visible = true;
            this.colcodigo_empleado.VisibleIndex = 0;
            this.colcodigo_empleado.Width = 132;
            // 
            // colnombre_empleado
            // 
            this.colnombre_empleado.Caption = "NOMBRE EMPLEADO";
            this.colnombre_empleado.FieldName = "nombre_empleado";
            this.colnombre_empleado.Name = "colnombre_empleado";
            this.colnombre_empleado.Visible = true;
            this.colnombre_empleado.VisibleIndex = 1;
            this.colnombre_empleado.Width = 383;
            // 
            // colposicion_asignada
            // 
            this.colposicion_asignada.AppearanceCell.Options.UseTextOptions = true;
            this.colposicion_asignada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposicion_asignada.AppearanceHeader.Options.UseTextOptions = true;
            this.colposicion_asignada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposicion_asignada.Caption = "POSICION ASIGNADA";
            this.colposicion_asignada.FieldName = "posicion_asignada";
            this.colposicion_asignada.Name = "colposicion_asignada";
            this.colposicion_asignada.Visible = true;
            this.colposicion_asignada.VisibleIndex = 3;
            this.colposicion_asignada.Width = 129;
            // 
            // colcargo_empleado
            // 
            this.colcargo_empleado.Caption = "CARGO";
            this.colcargo_empleado.FieldName = "cargo_empleado";
            this.colcargo_empleado.Name = "colcargo_empleado";
            this.colcargo_empleado.Visible = true;
            this.colcargo_empleado.VisibleIndex = 2;
            this.colcargo_empleado.Width = 201;
            // 
            // colcargar_posiciones
            // 
            this.colcargar_posiciones.Caption = " ";
            this.colcargar_posiciones.ColumnEdit = this.cmdCargarPosiciones;
            this.colcargar_posiciones.FieldName = "cargar_posiciones";
            this.colcargar_posiciones.Name = "colcargar_posiciones";
            this.colcargar_posiciones.Visible = true;
            this.colcargar_posiciones.VisibleIndex = 4;
            this.colcargar_posiciones.Width = 77;
            // 
            // cmdCargarPosiciones
            // 
            this.cmdCargarPosiciones.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Operaciones.Properties.Resources.icon_asignar_32;
            this.cmdCargarPosiciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdCargarPosiciones.Name = "cmdCargarPosiciones";
            this.cmdCargarPosiciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.popupPosicionesDisponibles);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 468);
            this.panel1.TabIndex = 2;
            // 
            // popupPosicionesDisponibles
            // 
            this.popupPosicionesDisponibles.Appearance.BackColor = System.Drawing.Color.White;
            this.popupPosicionesDisponibles.Appearance.Options.UseBackColor = true;
            this.popupPosicionesDisponibles.Controls.Add(this.flyoutPanelControl1);
            this.popupPosicionesDisponibles.Location = new System.Drawing.Point(157, 121);
            this.popupPosicionesDisponibles.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupPosicionesDisponibles.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupPosicionesDisponibles.Name = "popupPosicionesDisponibles";
            this.popupPosicionesDisponibles.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.popupPosicionesDisponibles.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupPosicionesDisponibles.Options.CloseOnOuterClick = true;
            this.popupPosicionesDisponibles.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupPosicionesDisponibles.OwnerControl = this;
            this.popupPosicionesDisponibles.Size = new System.Drawing.Size(533, 304);
            this.popupPosicionesDisponibles.TabIndex = 1;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.ctlPosicionesDisponibles1);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupPosicionesDisponibles;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(533, 304);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // ctlPosicionesDisponibles1
            // 
            this.ctlPosicionesDisponibles1.BackColor = System.Drawing.Color.White;
            this.ctlPosicionesDisponibles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPosicionesDisponibles1.Location = new System.Drawing.Point(3, 3);
            this.ctlPosicionesDisponibles1.Name = "ctlPosicionesDisponibles1";
            this.ctlPosicionesDisponibles1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlPosicionesDisponibles1.Size = new System.Drawing.Size(527, 298);
            this.ctlPosicionesDisponibles1.TabIndex = 0;
            // 
            // ctlAsignacionPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ctlAsignacionPosiciones";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(934, 478);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargarPosiciones)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupPosicionesDisponibles)).EndInit();
            this.popupPosicionesDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DataSets.dsConfiguraciones dsConfiguraciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcargar_posiciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdCargarPosiciones;
        private DevExpress.XtraGrid.Columns.GridColumn colposicion_asignada;
        private DevExpress.Utils.FlyoutPanel popupPosicionesDisponibles;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private Core.Controles.Popups.ctlPosicionesDisponibles ctlPosicionesDisponibles1;
    }
}
