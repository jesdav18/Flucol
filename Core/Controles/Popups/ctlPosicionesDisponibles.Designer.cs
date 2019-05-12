﻿namespace Core.Controles.Popups
{
    partial class ctlPosicionesDisponibles
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCore1 = new Core.DataSets.dsCore();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_operacion_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar_posicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_operacion_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtPosicionesDisponibles";
            this.gridControl1.DataSource = this.dsCore1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(5, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gridControl1.Size = new System.Drawing.Size(586, 319);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCore1
            // 
            this.dsCore1.DataSetName = "dsCore";
            this.dsCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_registro,
            this.colposicion,
            this.colid_operacion_servicio,
            this.colseleccionar_posicion,
            this.coldescripcion_operacion_servicio});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colid_registro
            // 
            this.colid_registro.FieldName = "id_registro";
            this.colid_registro.Name = "colid_registro";
            // 
            // colposicion
            // 
            this.colposicion.AppearanceCell.Options.UseTextOptions = true;
            this.colposicion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposicion.Caption = "POSICION";
            this.colposicion.FieldName = "posicion";
            this.colposicion.Name = "colposicion";
            this.colposicion.Visible = true;
            this.colposicion.VisibleIndex = 0;
            // 
            // colid_operacion_servicio
            // 
            this.colid_operacion_servicio.FieldName = "id_operacion_servicio";
            this.colid_operacion_servicio.Name = "colid_operacion_servicio";
            // 
            // colseleccionar_posicion
            // 
            this.colseleccionar_posicion.Caption = " ";
            this.colseleccionar_posicion.ColumnEdit = this.chkSeleccionar;
            this.colseleccionar_posicion.FieldName = "seleccionar_posicion";
            this.colseleccionar_posicion.Name = "colseleccionar_posicion";
            this.colseleccionar_posicion.Visible = true;
            this.colseleccionar_posicion.VisibleIndex = 2;
            this.colseleccionar_posicion.Width = 98;
            // 
            // coldescripcion_operacion_servicio
            // 
            this.coldescripcion_operacion_servicio.Caption = "OPERACION ASIGNADA";
            this.coldescripcion_operacion_servicio.FieldName = "descripcion_operacion_servicio";
            this.coldescripcion_operacion_servicio.Name = "coldescripcion_operacion_servicio";
            this.coldescripcion_operacion_servicio.Visible = true;
            this.coldescripcion_operacion_servicio.VisibleIndex = 1;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkSeleccionar.ImageOptions.ImageChecked = global::Core.Properties.Resources.icon_check_32;
            this.chkSeleccionar.Name = "chkSeleccionar";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.labelControl1);
            this.pnlSuperior.Controls.Add(this.pictureEdit1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(5, 5);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(586, 44);
            this.pnlSuperior.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(50, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(536, 44);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "POSICIONES DISPONIBLES";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = global::Core.Properties.Resources.icon_mover_32;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 44);
            this.pictureEdit1.TabIndex = 0;
            // 
            // ctlPosicionesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "ctlPosicionesDisponibles";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(596, 373);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnlSuperior;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DataSets.dsCore dsCore1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colposicion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_operacion_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar_posicion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_operacion_servicio;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
    }
}