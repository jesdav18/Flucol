namespace Core.Controles.Configuraciones
{
    partial class ctlMantenimientoNoticias
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
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.memoNoticia = new DevExpress.XtraEditors.MemoEdit();
            this.cmdGuardarNoticia = new DevExpress.XtraEditors.SimpleButton();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageAgregarNoticia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageVisualizacion = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsConfiguraciones1 = new Core.Controles.Configuraciones.DataSets.dsConfiguraciones();
            this.gvNoticias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_noticia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltexto_noticia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoNoticias = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colimg_borrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdBorrarNoticia = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAgregarNoticia = new DevExpress.XtraEditors.PictureEdit();
            this.cmdVisualizarNoticias = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoticia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.PageAgregarNoticia.SuspendLayout();
            this.PageVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoticias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoticias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrarNoticia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarNoticia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVisualizarNoticias.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(776, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MANTENIMIENTO DE NOTICIAS";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Appearance.BackColor = System.Drawing.Color.White;
            this.lblNombreEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Appearance.Options.UseBackColor = true;
            this.lblNombreEmpleado.Appearance.Options.UseFont = true;
            this.lblNombreEmpleado.Appearance.Options.UseTextOptions = true;
            this.lblNombreEmpleado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblNombreEmpleado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNombreEmpleado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(15, 17);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(295, 30);
            this.lblNombreEmpleado.TabIndex = 22;
            this.lblNombreEmpleado.Text = "INGRESE TEXTO PARA VISUALIZACION";
            // 
            // memoNoticia
            // 
            this.memoNoticia.Location = new System.Drawing.Point(15, 53);
            this.memoNoticia.Name = "memoNoticia";
            this.memoNoticia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoNoticia.Properties.Appearance.Options.UseFont = true;
            this.memoNoticia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.memoNoticia.Size = new System.Drawing.Size(746, 230);
            this.memoNoticia.TabIndex = 23;
            // 
            // cmdGuardarNoticia
            // 
            this.cmdGuardarNoticia.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarNoticia.Appearance.Options.UseFont = true;
            this.cmdGuardarNoticia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdGuardarNoticia.Location = new System.Drawing.Point(0, 289);
            this.cmdGuardarNoticia.Name = "cmdGuardarNoticia";
            this.cmdGuardarNoticia.Size = new System.Drawing.Size(776, 61);
            this.cmdGuardarNoticia.TabIndex = 24;
            this.cmdGuardarNoticia.Text = "GUARDAR NOTICIA";
            this.cmdGuardarNoticia.Click += new System.EventHandler(this.CmdGuardarNoticia_Click);
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.Controls.Add(this.PageAgregarNoticia);
            this.NavigationPrincipal.Controls.Add(this.PageInicial);
            this.NavigationPrincipal.Controls.Add(this.PageVisualizacion);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(5, 98);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageInicial,
            this.PageAgregarNoticia,
            this.PageVisualizacion});
            this.NavigationPrincipal.SelectedPage = this.PageVisualizacion;
            this.NavigationPrincipal.Size = new System.Drawing.Size(776, 350);
            this.NavigationPrincipal.TabIndex = 25;
            this.NavigationPrincipal.Text = "navigationFrame1";
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageAgregarNoticia
            // 
            this.PageAgregarNoticia.Caption = "PageAgregarNoticia";
            this.PageAgregarNoticia.Controls.Add(this.lblNombreEmpleado);
            this.PageAgregarNoticia.Controls.Add(this.cmdGuardarNoticia);
            this.PageAgregarNoticia.Controls.Add(this.memoNoticia);
            this.PageAgregarNoticia.Name = "PageAgregarNoticia";
            this.PageAgregarNoticia.Size = new System.Drawing.Size(776, 350);
            // 
            // PageInicial
            // 
            this.PageInicial.Caption = "PageInicial";
            this.PageInicial.Name = "PageInicial";
            this.PageInicial.Size = new System.Drawing.Size(776, 350);
            // 
            // PageVisualizacion
            // 
            this.PageVisualizacion.Caption = "PageVisualizacion";
            this.PageVisualizacion.Controls.Add(this.gridControl1);
            this.PageVisualizacion.Name = "PageVisualizacion";
            this.PageVisualizacion.Size = new System.Drawing.Size(776, 350);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtNoticias";
            this.gridControl1.DataSource = this.dsConfiguraciones1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvNoticias;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdBorrarNoticia,
            this.memoNoticias});
            this.gridControl1.Size = new System.Drawing.Size(776, 350);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNoticias});
            // 
            // dsConfiguraciones1
            // 
            this.dsConfiguraciones1.DataSetName = "dsConfiguraciones";
            this.dsConfiguraciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvNoticias
            // 
            this.gvNoticias.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNoticias.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNoticias.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNoticias.Appearance.Row.Options.UseFont = true;
            this.gvNoticias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_noticia,
            this.coltexto_noticia,
            this.colimg_borrar});
            this.gvNoticias.GridControl = this.gridControl1;
            this.gvNoticias.Name = "gvNoticias";
            this.gvNoticias.OptionsView.ShowGroupPanel = false;
            this.gvNoticias.OptionsView.ShowIndicator = false;
            // 
            // colid_noticia
            // 
            this.colid_noticia.FieldName = "id_noticia";
            this.colid_noticia.Name = "colid_noticia";
            this.colid_noticia.OptionsColumn.ReadOnly = true;
            // 
            // coltexto_noticia
            // 
            this.coltexto_noticia.AppearanceHeader.Options.UseTextOptions = true;
            this.coltexto_noticia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltexto_noticia.Caption = "NOTICIA";
            this.coltexto_noticia.ColumnEdit = this.memoNoticias;
            this.coltexto_noticia.FieldName = "texto_noticia";
            this.coltexto_noticia.Name = "coltexto_noticia";
            this.coltexto_noticia.OptionsColumn.AllowEdit = false;
            this.coltexto_noticia.OptionsColumn.ReadOnly = true;
            this.coltexto_noticia.Visible = true;
            this.coltexto_noticia.VisibleIndex = 0;
            // 
            // memoNoticias
            // 
            this.memoNoticias.Name = "memoNoticias";
            // 
            // colimg_borrar
            // 
            this.colimg_borrar.Caption = "BORRAR";
            this.colimg_borrar.ColumnEdit = this.cmdBorrarNoticia;
            this.colimg_borrar.FieldName = "img_borrar";
            this.colimg_borrar.MaxWidth = 80;
            this.colimg_borrar.MinWidth = 80;
            this.colimg_borrar.Name = "colimg_borrar";
            this.colimg_borrar.Visible = true;
            this.colimg_borrar.VisibleIndex = 1;
            this.colimg_borrar.Width = 80;
            // 
            // cmdBorrarNoticia
            // 
            this.cmdBorrarNoticia.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Core.Properties.Resources.iconBorrar_32;
            this.cmdBorrarNoticia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdBorrarNoticia.Name = "cmdBorrarNoticia";
            this.cmdBorrarNoticia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdBorrarNoticia.Click += new System.EventHandler(this.CmdBorrarNoticia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picAgregarNoticia);
            this.panel1.Controls.Add(this.cmdVisualizarNoticias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 59);
            this.panel1.TabIndex = 26;
            // 
            // picAgregarNoticia
            // 
            this.picAgregarNoticia.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAgregarNoticia.EditValue = global::Core.Properties.Resources.icon_agregar_64;
            this.picAgregarNoticia.Location = new System.Drawing.Point(65, 0);
            this.picAgregarNoticia.Name = "picAgregarNoticia";
            this.picAgregarNoticia.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.picAgregarNoticia.Properties.AllowFocused = false;
            this.picAgregarNoticia.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picAgregarNoticia.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picAgregarNoticia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAgregarNoticia.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.picAgregarNoticia.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAgregarNoticia.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAgregarNoticia.Size = new System.Drawing.Size(65, 59);
            this.picAgregarNoticia.TabIndex = 4;
            this.picAgregarNoticia.ToolTip = "Agregar Noticia";
            this.picAgregarNoticia.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picAgregarNoticia.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picAgregarNoticia.ToolTipTitle = "FLUCOL";
            this.picAgregarNoticia.Click += new System.EventHandler(this.PicAgregarNoticia_Click);
            // 
            // cmdVisualizarNoticias
            // 
            this.cmdVisualizarNoticias.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdVisualizarNoticias.EditValue = global::Core.Properties.Resources.icon_visualizar_64;
            this.cmdVisualizarNoticias.Location = new System.Drawing.Point(0, 0);
            this.cmdVisualizarNoticias.Name = "cmdVisualizarNoticias";
            this.cmdVisualizarNoticias.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.cmdVisualizarNoticias.Properties.AllowFocused = false;
            this.cmdVisualizarNoticias.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdVisualizarNoticias.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdVisualizarNoticias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdVisualizarNoticias.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.cmdVisualizarNoticias.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdVisualizarNoticias.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdVisualizarNoticias.Size = new System.Drawing.Size(65, 59);
            this.cmdVisualizarNoticias.TabIndex = 3;
            this.cmdVisualizarNoticias.ToolTip = "Visualización de Noticias";
            this.cmdVisualizarNoticias.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdVisualizarNoticias.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdVisualizarNoticias.ToolTipTitle = "FLUCOL";
            this.cmdVisualizarNoticias.Click += new System.EventHandler(this.CmdVisualizarNoticias_Click);
            // 
            // ctlMantenimientoNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ctlMantenimientoNoticias";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(786, 453);
            ((System.ComponentModel.ISupportInitialize)(this.memoNoticia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.PageAgregarNoticia.ResumeLayout(false);
            this.PageVisualizacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoticias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoticias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrarNoticia)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarNoticia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVisualizarNoticias.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.LabelControl lblNombreEmpleado;
        private DevExpress.XtraEditors.MemoEdit memoNoticia;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarNoticia;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageInicial;
        private DevExpress.XtraBars.Navigation.NavigationPage PageAgregarNoticia;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picAgregarNoticia;
        private DevExpress.XtraEditors.PictureEdit cmdVisualizarNoticias;
        private DevExpress.XtraBars.Navigation.NavigationPage PageVisualizacion;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DataSets.dsConfiguraciones dsConfiguraciones1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNoticias;
        private DevExpress.XtraGrid.Columns.GridColumn colid_noticia;
        private DevExpress.XtraGrid.Columns.GridColumn coltexto_noticia;
        private DevExpress.XtraGrid.Columns.GridColumn colimg_borrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdBorrarNoticia;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoNoticias;
    }
}
