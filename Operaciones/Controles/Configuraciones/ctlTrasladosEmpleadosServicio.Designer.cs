namespace Operaciones.Controles.Configuraciones
{
    partial class ctlTrasladosEmpleadosServicio
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
            this.NavigationTraslados = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageAgenciasServicio = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsConfiguraciones1 = new Operaciones.Controles.Configuraciones.DataSets.dsConfiguraciones();
            this.gvAgenciasServicio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_agencia_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_agencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion_agencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar_agencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionarAgenciaServicio = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.txtBusquedaAgencia = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.pageEmpleadosServicio = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcEmpleadosServicio = new DevExpress.XtraGrid.GridControl();
            this.gvEmpleadosServicio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmdGuardarTraslado = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusquedaColaborador = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lblAgenciaServicio = new DevExpress.XtraEditors.LabelControl();
            this.pnlEncabezadoEmpleados = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdIrAtras = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationTraslados)).BeginInit();
            this.NavigationTraslados.SuspendLayout();
            this.pageAgenciasServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgenciasServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarAgenciaServicio)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaAgencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pageEmpleadosServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleadosServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadosServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaColaborador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.pnlEncabezadoEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtras.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationTraslados
            // 
            this.NavigationTraslados.Controls.Add(this.pageAgenciasServicio);
            this.NavigationTraslados.Controls.Add(this.pageEmpleadosServicio);
            this.NavigationTraslados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationTraslados.Location = new System.Drawing.Point(5, 5);
            this.NavigationTraslados.Name = "NavigationTraslados";
            this.NavigationTraslados.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageAgenciasServicio,
            this.pageEmpleadosServicio});
            this.NavigationTraslados.SelectedPage = this.pageAgenciasServicio;
            this.NavigationTraslados.Size = new System.Drawing.Size(747, 435);
            this.NavigationTraslados.TabIndex = 0;
            this.NavigationTraslados.Text = "navigationFrame1";
            this.NavigationTraslados.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationTraslados.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pageAgenciasServicio
            // 
            this.pageAgenciasServicio.Caption = "pageAgenciasServicio";
            this.pageAgenciasServicio.Controls.Add(this.gridControl1);
            this.pageAgenciasServicio.Controls.Add(this.pnlBusqueda);
            this.pageAgenciasServicio.Controls.Add(this.pnlEncabezado);
            this.pageAgenciasServicio.Name = "pageAgenciasServicio";
            this.pageAgenciasServicio.Size = new System.Drawing.Size(747, 435);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtAgenciasServicio";
            this.gridControl1.DataSource = this.dsConfiguraciones1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gvAgenciasServicio;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionarAgenciaServicio});
            this.gridControl1.Size = new System.Drawing.Size(747, 349);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAgenciasServicio});
            // 
            // dsConfiguraciones1
            // 
            this.dsConfiguraciones1.DataSetName = "dsConfiguraciones";
            this.dsConfiguraciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAgenciasServicio
            // 
            this.gvAgenciasServicio.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAgenciasServicio.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAgenciasServicio.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAgenciasServicio.Appearance.Row.Options.UseFont = true;
            this.gvAgenciasServicio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_agencia_servicio,
            this.colid_cliente_servicio,
            this.colnombre_agencia,
            this.coldireccion_agencia,
            this.colseleccionar_agencia});
            this.gvAgenciasServicio.GridControl = this.gridControl1;
            this.gvAgenciasServicio.Name = "gvAgenciasServicio";
            this.gvAgenciasServicio.OptionsCustomization.AllowGroup = false;
            this.gvAgenciasServicio.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvAgenciasServicio.OptionsView.ShowGroupPanel = false;
            this.gvAgenciasServicio.OptionsView.ShowIndicator = false;
            // 
            // colid_agencia_servicio
            // 
            this.colid_agencia_servicio.FieldName = "id_agencia_servicio";
            this.colid_agencia_servicio.Name = "colid_agencia_servicio";
            // 
            // colid_cliente_servicio
            // 
            this.colid_cliente_servicio.FieldName = "id_cliente_servicio";
            this.colid_cliente_servicio.Name = "colid_cliente_servicio";
            // 
            // colnombre_agencia
            // 
            this.colnombre_agencia.Caption = "AGENCIA";
            this.colnombre_agencia.FieldName = "nombre_agencia";
            this.colnombre_agencia.Name = "colnombre_agencia";
            this.colnombre_agencia.OptionsColumn.AllowEdit = false;
            this.colnombre_agencia.OptionsColumn.AllowFocus = false;
            this.colnombre_agencia.OptionsColumn.ReadOnly = true;
            this.colnombre_agencia.Visible = true;
            this.colnombre_agencia.VisibleIndex = 0;
            this.colnombre_agencia.Width = 297;
            // 
            // coldireccion_agencia
            // 
            this.coldireccion_agencia.Caption = "DIRECCION";
            this.coldireccion_agencia.FieldName = "direccion_agencia";
            this.coldireccion_agencia.Name = "coldireccion_agencia";
            this.coldireccion_agencia.OptionsColumn.AllowEdit = false;
            this.coldireccion_agencia.OptionsColumn.AllowFocus = false;
            this.coldireccion_agencia.OptionsColumn.ReadOnly = true;
            this.coldireccion_agencia.Visible = true;
            this.coldireccion_agencia.VisibleIndex = 1;
            this.coldireccion_agencia.Width = 337;
            // 
            // colseleccionar_agencia
            // 
            this.colseleccionar_agencia.AppearanceHeader.Options.UseTextOptions = true;
            this.colseleccionar_agencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colseleccionar_agencia.Caption = "SELECCIONAR";
            this.colseleccionar_agencia.ColumnEdit = this.chkSeleccionarAgenciaServicio;
            this.colseleccionar_agencia.FieldName = "seleccionar_agencia";
            this.colseleccionar_agencia.Name = "colseleccionar_agencia";
            this.colseleccionar_agencia.Visible = true;
            this.colseleccionar_agencia.VisibleIndex = 2;
            this.colseleccionar_agencia.Width = 111;
            // 
            // chkSeleccionarAgenciaServicio
            // 
            this.chkSeleccionarAgenciaServicio.AutoHeight = false;
            this.chkSeleccionarAgenciaServicio.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkSeleccionarAgenciaServicio.ImageOptions.ImageChecked = global::Operaciones.Properties.Resources.icon_check_32;
            this.chkSeleccionarAgenciaServicio.Name = "chkSeleccionarAgenciaServicio";
            this.chkSeleccionarAgenciaServicio.EditValueChanged += new System.EventHandler(this.chkSeleccionarAgenciaServicio_EditValueChanged);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtBusquedaAgencia);
            this.pnlBusqueda.Controls.Add(this.pictureEdit1);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 45);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlBusqueda.Size = new System.Drawing.Size(747, 41);
            this.pnlBusqueda.TabIndex = 2;
            // 
            // txtBusquedaAgencia
            // 
            this.txtBusquedaAgencia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBusquedaAgencia.Location = new System.Drawing.Point(52, 1);
            this.txtBusquedaAgencia.Name = "txtBusquedaAgencia";
            this.txtBusquedaAgencia.Properties.AutoHeight = false;
            this.txtBusquedaAgencia.Size = new System.Drawing.Size(695, 35);
            this.txtBusquedaAgencia.TabIndex = 0;
            this.txtBusquedaAgencia.TextChanged += new System.EventHandler(this.txtBusquedaAgencia_TextChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = global::Operaciones.Properties.Resources.iconBusqueda_32;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(52, 31);
            this.pictureEdit1.TabIndex = 1;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(747, 45);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Appearance.Options.UseFont = true;
            this.lblEncabezado.Appearance.Options.UseTextOptions = true;
            this.lblEncabezado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEncabezado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(747, 45);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "SELECCIONE AGENCIA ORIGEN DEL COLABORADOR";
            // 
            // pageEmpleadosServicio
            // 
            this.pageEmpleadosServicio.Caption = "pageEmpleadosServicio";
            this.pageEmpleadosServicio.Controls.Add(this.gcEmpleadosServicio);
            this.pageEmpleadosServicio.Controls.Add(this.cmdGuardarTraslado);
            this.pageEmpleadosServicio.Controls.Add(this.panel1);
            this.pageEmpleadosServicio.Controls.Add(this.pnlEncabezadoEmpleados);
            this.pageEmpleadosServicio.Name = "pageEmpleadosServicio";
            this.pageEmpleadosServicio.Size = new System.Drawing.Size(747, 435);
            // 
            // gcEmpleadosServicio
            // 
            this.gcEmpleadosServicio.DataMember = "dtEmpleadosServicio";
            this.gcEmpleadosServicio.DataSource = this.dsConfiguraciones1;
            this.gcEmpleadosServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpleadosServicio.Location = new System.Drawing.Point(0, 132);
            this.gcEmpleadosServicio.MainView = this.gvEmpleadosServicio;
            this.gcEmpleadosServicio.Name = "gcEmpleadosServicio";
            this.gcEmpleadosServicio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gcEmpleadosServicio.Size = new System.Drawing.Size(747, 254);
            this.gcEmpleadosServicio.TabIndex = 4;
            this.gcEmpleadosServicio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleadosServicio});
            // 
            // gvEmpleadosServicio
            // 
            this.gvEmpleadosServicio.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmpleadosServicio.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEmpleadosServicio.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmpleadosServicio.Appearance.Row.Options.UseFont = true;
            this.gvEmpleadosServicio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo_empleado,
            this.colusuario,
            this.colnombre_empleado,
            this.colcargo,
            this.colseleccionar_empleado});
            this.gvEmpleadosServicio.GridControl = this.gcEmpleadosServicio;
            this.gvEmpleadosServicio.Name = "gvEmpleadosServicio";
            this.gvEmpleadosServicio.OptionsCustomization.AllowGroup = false;
            this.gvEmpleadosServicio.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvEmpleadosServicio.OptionsView.ShowGroupPanel = false;
            this.gvEmpleadosServicio.OptionsView.ShowIndicator = false;
            // 
            // colcodigo_empleado
            // 
            this.colcodigo_empleado.Caption = "CODIGO";
            this.colcodigo_empleado.FieldName = "codigo_empleado";
            this.colcodigo_empleado.Name = "colcodigo_empleado";
            this.colcodigo_empleado.Visible = true;
            this.colcodigo_empleado.VisibleIndex = 0;
            this.colcodigo_empleado.Width = 142;
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            // 
            // colnombre_empleado
            // 
            this.colnombre_empleado.Caption = "NOMBRE ";
            this.colnombre_empleado.FieldName = "nombre_empleado";
            this.colnombre_empleado.Name = "colnombre_empleado";
            this.colnombre_empleado.OptionsColumn.AllowEdit = false;
            this.colnombre_empleado.OptionsColumn.AllowFocus = false;
            this.colnombre_empleado.OptionsColumn.ReadOnly = true;
            this.colnombre_empleado.Visible = true;
            this.colnombre_empleado.VisibleIndex = 1;
            this.colnombre_empleado.Width = 315;
            // 
            // colcargo
            // 
            this.colcargo.Caption = "CARGO";
            this.colcargo.FieldName = "cargo";
            this.colcargo.Name = "colcargo";
            this.colcargo.OptionsColumn.AllowEdit = false;
            this.colcargo.OptionsColumn.AllowFocus = false;
            this.colcargo.OptionsColumn.ReadOnly = true;
            this.colcargo.Visible = true;
            this.colcargo.VisibleIndex = 2;
            this.colcargo.Width = 174;
            // 
            // colseleccionar_empleado
            // 
            this.colseleccionar_empleado.Caption = "SELECCIONAR";
            this.colseleccionar_empleado.ColumnEdit = this.chkSeleccionar;
            this.colseleccionar_empleado.FieldName = "seleccionar_empleado";
            this.colseleccionar_empleado.Name = "colseleccionar_empleado";
            this.colseleccionar_empleado.Visible = true;
            this.colseleccionar_empleado.VisibleIndex = 3;
            this.colseleccionar_empleado.Width = 114;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkSeleccionar.ImageOptions.ImageChecked = global::Operaciones.Properties.Resources.icon_check_32;
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.EditValueChanged += new System.EventHandler(this.chkSeleccionar_EditValueChanged);
            // 
            // cmdGuardarTraslado
            // 
            this.cmdGuardarTraslado.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarTraslado.Appearance.Options.UseFont = true;
            this.cmdGuardarTraslado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdGuardarTraslado.Location = new System.Drawing.Point(0, 386);
            this.cmdGuardarTraslado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdGuardarTraslado.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdGuardarTraslado.Name = "cmdGuardarTraslado";
            this.cmdGuardarTraslado.Size = new System.Drawing.Size(747, 49);
            this.cmdGuardarTraslado.TabIndex = 5;
            this.cmdGuardarTraslado.Text = "GUARDAR TRASLADO";
            this.cmdGuardarTraslado.Click += new System.EventHandler(this.cmdGuardarTraslado_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBusquedaColaborador);
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Controls.Add(this.lblAgenciaServicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(747, 87);
            this.panel1.TabIndex = 3;
            // 
            // txtBusquedaColaborador
            // 
            this.txtBusquedaColaborador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBusquedaColaborador.Location = new System.Drawing.Point(52, 47);
            this.txtBusquedaColaborador.Name = "txtBusquedaColaborador";
            this.txtBusquedaColaborador.Properties.AutoHeight = false;
            this.txtBusquedaColaborador.Size = new System.Drawing.Size(695, 35);
            this.txtBusquedaColaborador.TabIndex = 0;
            this.txtBusquedaColaborador.TextChanged += new System.EventHandler(this.txtBusquedaColaborador_TextChanged);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit2.EditValue = global::Operaciones.Properties.Resources.iconBusqueda_32;
            this.pictureEdit2.Location = new System.Drawing.Point(0, 38);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(52, 44);
            this.pictureEdit2.TabIndex = 1;
            // 
            // lblAgenciaServicio
            // 
            this.lblAgenciaServicio.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenciaServicio.Appearance.Options.UseFont = true;
            this.lblAgenciaServicio.Appearance.Options.UseTextOptions = true;
            this.lblAgenciaServicio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAgenciaServicio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAgenciaServicio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblAgenciaServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAgenciaServicio.Location = new System.Drawing.Point(0, 5);
            this.lblAgenciaServicio.Name = "lblAgenciaServicio";
            this.lblAgenciaServicio.Size = new System.Drawing.Size(747, 33);
            this.lblAgenciaServicio.TabIndex = 2;
            this.lblAgenciaServicio.Text = "AGENCIA SERVICIO";
            // 
            // pnlEncabezadoEmpleados
            // 
            this.pnlEncabezadoEmpleados.Controls.Add(this.labelControl1);
            this.pnlEncabezadoEmpleados.Controls.Add(this.cmdIrAtras);
            this.pnlEncabezadoEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoEmpleados.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoEmpleados.Name = "pnlEncabezadoEmpleados";
            this.pnlEncabezadoEmpleados.Size = new System.Drawing.Size(747, 45);
            this.pnlEncabezadoEmpleados.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(52, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(695, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SELECCIONE COLABORADOR";
            // 
            // cmdIrAtras
            // 
            this.cmdIrAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdIrAtras.EditValue = global::Operaciones.Properties.Resources.iconIrAtras;
            this.cmdIrAtras.Location = new System.Drawing.Point(0, 0);
            this.cmdIrAtras.Name = "cmdIrAtras";
            this.cmdIrAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIrAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIrAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdIrAtras.Size = new System.Drawing.Size(52, 45);
            this.cmdIrAtras.TabIndex = 2;
            this.cmdIrAtras.Click += new System.EventHandler(this.cmdIrAtras_Click);
            // 
            // ctlTrasladosEmpleadosServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationTraslados);
            this.Name = "ctlTrasladosEmpleadosServicio";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(757, 445);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationTraslados)).EndInit();
            this.NavigationTraslados.ResumeLayout(false);
            this.pageAgenciasServicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgenciasServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarAgenciaServicio)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaAgencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pageEmpleadosServicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleadosServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadosServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaColaborador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.pnlEncabezadoEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtras.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationTraslados;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAgenciasServicio;
        private System.Windows.Forms.Panel pnlBusqueda;
        private DevExpress.XtraEditors.TextEdit txtBusquedaAgencia;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgenciasServicio;
        private DevExpress.XtraBars.Navigation.NavigationPage pageEmpleadosServicio;
        private DataSets.dsConfiguraciones dsConfiguraciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_agencia_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_agencia;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion_agencia;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar_agencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionarAgenciaServicio;
        private System.Windows.Forms.Panel pnlEncabezadoEmpleados;
        private DevExpress.XtraEditors.PictureEdit cmdIrAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcEmpleadosServicio;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleadosServicio;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtBusquedaColaborador;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl lblAgenciaServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar_empleado;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarTraslado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
    }
}
