namespace Core.Controles.Configuraciones
{
    partial class ctlMantenimientoUsuarios
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdModicarUsuarios = new DevExpress.XtraEditors.PictureEdit();
            this.cmdCrearUsuarios = new DevExpress.XtraEditors.PictureEdit();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageCrearUsuarios = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.NavigationEmpleados = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pagePrimeraPagina = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.picIrAtras = new DevExpress.XtraEditors.PictureEdit();
            this.gridAgencias = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsAgenciasServicio = new System.Windows.Forms.BindingSource(this.components);
            this.dsConfiguraciones1 = new Core.Controles.Configuraciones.DataSets.dsConfiguraciones();
            this.gluAgencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_agencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_agencia_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCargos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsCargosEmpleados = new System.Windows.Forms.BindingSource(this.components);
            this.gluCargos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtContraseniaTemporal = new DevExpress.XtraEditors.TextEdit();
            this.lblContraseniaTemporal = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdentidadEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtSegundoApellido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrimerApellido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSegundoNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrimerNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdRegistrarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.pageConfiguracionUsuarios = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcListaEmpleados = new DevExpress.XtraGrid.GridControl();
            this.gvListaEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigoempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagencia_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimg_habilitar_deshabilitar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkHabilitar_Deshabilitar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colhabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimg_edicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditarEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pnlPopup = new System.Windows.Forms.Panel();
            this.popupBusquedaEmpleados = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.txtBusquedaEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblListaEmpleados = new DevExpress.XtraEditors.LabelControl();
            this.picBusquedaEmpleado = new DevExpress.XtraEditors.PictureEdit();
            this.pageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.epProveedorErrores = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdModicarUsuarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCrearUsuarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.pageCrearUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationEmpleados)).BeginInit();
            this.NavigationEmpleados.SuspendLayout();
            this.pagePrimeraPagina.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIrAtras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgencias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgenciasServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluAgencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCargosEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseniaTemporal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentidadEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegundoApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegundoNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoEmpleado.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.pageConfiguracionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHabilitar_Deshabilitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarEmpleado)).BeginInit();
            this.pnlPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupBusquedaEmpleados)).BeginInit();
            this.popupBusquedaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaEmpleado.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBusquedaEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProveedorErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdModicarUsuarios);
            this.panel1.Controls.Add(this.cmdCrearUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 55);
            this.panel1.TabIndex = 0;
            // 
            // cmdModicarUsuarios
            // 
            this.cmdModicarUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdModicarUsuarios.EditValue = global::Core.Properties.Resources.icon_usuario_configuracion_negro_64;
            this.cmdModicarUsuarios.Location = new System.Drawing.Point(51, 0);
            this.cmdModicarUsuarios.Name = "cmdModicarUsuarios";
            this.cmdModicarUsuarios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdModicarUsuarios.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdModicarUsuarios.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdModicarUsuarios.Size = new System.Drawing.Size(51, 55);
            this.cmdModicarUsuarios.TabIndex = 4;
            this.cmdModicarUsuarios.ToolTip = "Configuración de Empleados";
            this.cmdModicarUsuarios.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdModicarUsuarios.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdModicarUsuarios.ToolTipTitle = "FLUCOL";
            this.cmdModicarUsuarios.Click += new System.EventHandler(this.cmdModicarUsuarios_Click);
            // 
            // cmdCrearUsuarios
            // 
            this.cmdCrearUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdCrearUsuarios.EditValue = global::Core.Properties.Resources.icon_nuevo_usuario_negro_64;
            this.cmdCrearUsuarios.Location = new System.Drawing.Point(0, 0);
            this.cmdCrearUsuarios.Name = "cmdCrearUsuarios";
            this.cmdCrearUsuarios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCrearUsuarios.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCrearUsuarios.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCrearUsuarios.Size = new System.Drawing.Size(51, 55);
            this.cmdCrearUsuarios.TabIndex = 3;
            this.cmdCrearUsuarios.ToolTip = "Nuevo Empleado";
            this.cmdCrearUsuarios.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdCrearUsuarios.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdCrearUsuarios.ToolTipTitle = "FLUCOL";
            this.cmdCrearUsuarios.Click += new System.EventHandler(this.cmdCrearUsuarios_Click);
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavigationPrincipal.Appearance.BackColor = System.Drawing.Color.White;
            this.NavigationPrincipal.Appearance.Options.UseBackColor = true;
            this.NavigationPrincipal.Controls.Add(this.pageCrearUsuarios);
            this.NavigationPrincipal.Controls.Add(this.pageConfiguracionUsuarios);
            this.NavigationPrincipal.Controls.Add(this.pageInicial);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(5, 60);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageCrearUsuarios,
            this.pageConfiguracionUsuarios,
            this.pageInicial});
            this.NavigationPrincipal.SelectedPage = this.pageInicial;
            this.NavigationPrincipal.Size = new System.Drawing.Size(808, 534);
            this.NavigationPrincipal.TabIndex = 1;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pageCrearUsuarios
            // 
            this.pageCrearUsuarios.Caption = "pageCrearUsuarios";
            this.pageCrearUsuarios.Controls.Add(this.NavigationEmpleados);
            this.pageCrearUsuarios.Name = "pageCrearUsuarios";
            this.pageCrearUsuarios.Size = new System.Drawing.Size(808, 534);
            // 
            // NavigationEmpleados
            // 
            this.NavigationEmpleados.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavigationEmpleados.Appearance.BackColor = System.Drawing.Color.White;
            this.NavigationEmpleados.Appearance.Options.UseBackColor = true;
            this.NavigationEmpleados.Controls.Add(this.pagePrimeraPagina);
            this.NavigationEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationEmpleados.Location = new System.Drawing.Point(0, 0);
            this.NavigationEmpleados.Name = "NavigationEmpleados";
            this.NavigationEmpleados.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pagePrimeraPagina});
            this.NavigationEmpleados.SelectedPage = this.pagePrimeraPagina;
            this.NavigationEmpleados.Size = new System.Drawing.Size(808, 534);
            this.NavigationEmpleados.TabIndex = 0;
            this.NavigationEmpleados.Text = "navigationFrame1";
            this.NavigationEmpleados.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationEmpleados.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pagePrimeraPagina
            // 
            this.pagePrimeraPagina.Caption = "pagePrimeraPagina";
            this.pagePrimeraPagina.Controls.Add(this.panel4);
            this.pagePrimeraPagina.Controls.Add(this.gridAgencias);
            this.pagePrimeraPagina.Controls.Add(this.gridCargos);
            this.pagePrimeraPagina.Controls.Add(this.txtContraseniaTemporal);
            this.pagePrimeraPagina.Controls.Add(this.lblContraseniaTemporal);
            this.pagePrimeraPagina.Controls.Add(this.txtUsuario);
            this.pagePrimeraPagina.Controls.Add(this.lblUsuario);
            this.pagePrimeraPagina.Controls.Add(this.labelControl9);
            this.pagePrimeraPagina.Controls.Add(this.labelControl10);
            this.pagePrimeraPagina.Controls.Add(this.txtIdentidadEmpleado);
            this.pagePrimeraPagina.Controls.Add(this.labelControl11);
            this.pagePrimeraPagina.Controls.Add(this.txtSegundoApellido);
            this.pagePrimeraPagina.Controls.Add(this.labelControl5);
            this.pagePrimeraPagina.Controls.Add(this.txtPrimerApellido);
            this.pagePrimeraPagina.Controls.Add(this.labelControl4);
            this.pagePrimeraPagina.Controls.Add(this.txtSegundoNombre);
            this.pagePrimeraPagina.Controls.Add(this.labelControl3);
            this.pagePrimeraPagina.Controls.Add(this.txtPrimerNombre);
            this.pagePrimeraPagina.Controls.Add(this.labelControl2);
            this.pagePrimeraPagina.Controls.Add(this.txtCodigoEmpleado);
            this.pagePrimeraPagina.Controls.Add(this.labelControl1);
            this.pagePrimeraPagina.Controls.Add(this.panel2);
            this.pagePrimeraPagina.Name = "pagePrimeraPagina";
            this.pagePrimeraPagina.Size = new System.Drawing.Size(808, 534);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picIrAtras);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(808, 32);
            this.panel4.TabIndex = 52;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Location = new System.Drawing.Point(51, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(757, 32);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "CREACION DE NUEVO EMPLEADO";
            // 
            // picIrAtras
            // 
            this.picIrAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIrAtras.EditValue = global::Core.Properties.Resources.icon_atras_64;
            this.picIrAtras.Location = new System.Drawing.Point(0, 0);
            this.picIrAtras.Name = "picIrAtras";
            this.picIrAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picIrAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picIrAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picIrAtras.Size = new System.Drawing.Size(51, 32);
            this.picIrAtras.TabIndex = 52;
            this.picIrAtras.ToolTip = "Nuevo Empleado";
            this.picIrAtras.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picIrAtras.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picIrAtras.ToolTipTitle = "FLUCOL";
            this.picIrAtras.Visible = false;
            this.picIrAtras.Click += new System.EventHandler(this.PicIrAtras_Click);
            // 
            // gridAgencias
            // 
            this.gridAgencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAgencias.EditValue = "";
            this.gridAgencias.Location = new System.Drawing.Point(419, 239);
            this.gridAgencias.Name = "gridAgencias";
            this.gridAgencias.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAgencias.Properties.Appearance.Options.UseFont = true;
            this.gridAgencias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridAgencias.Properties.DataSource = this.bsAgenciasServicio;
            this.gridAgencias.Properties.DisplayMember = "nombre_agencia";
            this.gridAgencias.Properties.PopupView = this.gluAgencias;
            this.gridAgencias.Properties.ValueMember = "id_agencia_servicio";
            this.gridAgencias.Size = new System.Drawing.Size(285, 32);
            this.gridAgencias.TabIndex = 50;
            // 
            // bsAgenciasServicio
            // 
            this.bsAgenciasServicio.DataMember = "dtAgenciasServicio";
            this.bsAgenciasServicio.DataSource = this.dsConfiguraciones1;
            // 
            // dsConfiguraciones1
            // 
            this.dsConfiguraciones1.DataSetName = "dsConfiguraciones";
            this.dsConfiguraciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gluAgencias
            // 
            this.gluAgencias.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gluAgencias.Appearance.Row.Options.UseFont = true;
            this.gluAgencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_agencia,
            this.colid_agencia_servicio});
            this.gluAgencias.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gluAgencias.Name = "gluAgencias";
            this.gluAgencias.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gluAgencias.OptionsView.ShowColumnHeaders = false;
            this.gluAgencias.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_agencia
            // 
            this.colnombre_agencia.Caption = "AGENCIA";
            this.colnombre_agencia.FieldName = "nombre_agencia";
            this.colnombre_agencia.Name = "colnombre_agencia";
            this.colnombre_agencia.Visible = true;
            this.colnombre_agencia.VisibleIndex = 0;
            // 
            // colid_agencia_servicio
            // 
            this.colid_agencia_servicio.FieldName = "id_agencia_servicio";
            this.colid_agencia_servicio.Name = "colid_agencia_servicio";
            // 
            // gridCargos
            // 
            this.gridCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCargos.EditValue = "";
            this.gridCargos.Location = new System.Drawing.Point(419, 167);
            this.gridCargos.Name = "gridCargos";
            this.gridCargos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCargos.Properties.Appearance.Options.UseFont = true;
            this.gridCargos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridCargos.Properties.DataSource = this.bsCargosEmpleados;
            this.gridCargos.Properties.DisplayMember = "descripcion";
            this.gridCargos.Properties.PopupView = this.gluCargos;
            this.gridCargos.Properties.ValueMember = "id_cargo";
            this.gridCargos.Size = new System.Drawing.Size(285, 32);
            this.gridCargos.TabIndex = 49;
            // 
            // bsCargosEmpleados
            // 
            this.bsCargosEmpleados.DataMember = "dtCargosEmpleados";
            this.bsCargosEmpleados.DataSource = this.dsConfiguraciones1;
            // 
            // gluCargos
            // 
            this.gluCargos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gluCargos.Appearance.Row.Options.UseFont = true;
            this.gluCargos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colid_cargo});
            this.gluCargos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gluCargos.Name = "gluCargos";
            this.gluCargos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gluCargos.OptionsView.ShowColumnHeaders = false;
            this.gluCargos.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "CARGO";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colid_cargo
            // 
            this.colid_cargo.FieldName = "id_cargo";
            this.colid_cargo.Name = "colid_cargo";
            // 
            // txtContraseniaTemporal
            // 
            this.txtContraseniaTemporal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseniaTemporal.Location = new System.Drawing.Point(419, 384);
            this.txtContraseniaTemporal.Name = "txtContraseniaTemporal";
            this.txtContraseniaTemporal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaTemporal.Properties.Appearance.Options.UseFont = true;
            this.txtContraseniaTemporal.Size = new System.Drawing.Size(285, 28);
            this.txtContraseniaTemporal.TabIndex = 48;
            // 
            // lblContraseniaTemporal
            // 
            this.lblContraseniaTemporal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseniaTemporal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaTemporal.Appearance.Options.UseFont = true;
            this.lblContraseniaTemporal.Location = new System.Drawing.Point(419, 357);
            this.lblContraseniaTemporal.Name = "lblContraseniaTemporal";
            this.lblContraseniaTemporal.Size = new System.Drawing.Size(187, 21);
            this.lblContraseniaTemporal.TabIndex = 47;
            this.lblContraseniaTemporal.Text = "CONTRASEÑA TEMPORAL:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(419, 311);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(285, 28);
            this.txtUsuario.TabIndex = 46;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(419, 284);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 21);
            this.lblUsuario.TabIndex = 45;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(419, 212);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(174, 21);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "ASIGNAR A LA AGENCIA:";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(419, 140);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 21);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "CARGO:";
            // 
            // txtIdentidadEmpleado
            // 
            this.txtIdentidadEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentidadEmpleado.Location = new System.Drawing.Point(419, 99);
            this.txtIdentidadEmpleado.Name = "txtIdentidadEmpleado";
            this.txtIdentidadEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidadEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtIdentidadEmpleado.Size = new System.Drawing.Size(285, 28);
            this.txtIdentidadEmpleado.TabIndex = 42;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(419, 72);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(82, 21);
            this.labelControl11.TabIndex = 41;
            this.labelControl11.Text = "IDENTIDAD:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(52, 384);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Properties.Appearance.Options.UseFont = true;
            this.txtSegundoApellido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSegundoApellido.Size = new System.Drawing.Size(311, 28);
            this.txtSegundoApellido.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(52, 358);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(151, 21);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "SEGUNDO APELLIDO:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(52, 311);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Properties.Appearance.Options.UseFont = true;
            this.txtPrimerApellido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrimerApellido.Size = new System.Drawing.Size(311, 28);
            this.txtPrimerApellido.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(52, 284);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 21);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "PRIMER APELLIDO:";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(52, 240);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Properties.Appearance.Options.UseFont = true;
            this.txtSegundoNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSegundoNombre.Size = new System.Drawing.Size(311, 28);
            this.txtSegundoNombre.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(52, 212);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(146, 21);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "SEGUNDO NOMBRE:";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(52, 167);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Properties.Appearance.Options.UseFont = true;
            this.txtPrimerNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrimerNombre.Size = new System.Drawing.Size(311, 28);
            this.txtPrimerNombre.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(52, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 21);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "PRIMER NOMBRE:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(52, 99);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(311, 28);
            this.txtCodigoEmpleado.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 21);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "CODIGO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmdRegistrarEmpleado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 46);
            this.panel2.TabIndex = 28;
            // 
            // cmdRegistrarEmpleado
            // 
            this.cmdRegistrarEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarEmpleado.Appearance.Options.UseFont = true;
            this.cmdRegistrarEmpleado.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdRegistrarEmpleado.Location = new System.Drawing.Point(592, 0);
            this.cmdRegistrarEmpleado.Name = "cmdRegistrarEmpleado";
            this.cmdRegistrarEmpleado.Size = new System.Drawing.Size(216, 46);
            this.cmdRegistrarEmpleado.TabIndex = 1;
            this.cmdRegistrarEmpleado.Text = "REGISTRAR EMPLEADO";
            this.cmdRegistrarEmpleado.Click += new System.EventHandler(this.cmdRegistrarEmpleado_Click);
            // 
            // pageConfiguracionUsuarios
            // 
            this.pageConfiguracionUsuarios.Caption = "pageConfiguracionUsuarios";
            this.pageConfiguracionUsuarios.Controls.Add(this.gcListaEmpleados);
            this.pageConfiguracionUsuarios.Controls.Add(this.pnlPopup);
            this.pageConfiguracionUsuarios.Controls.Add(this.panel3);
            this.pageConfiguracionUsuarios.Name = "pageConfiguracionUsuarios";
            this.pageConfiguracionUsuarios.Size = new System.Drawing.Size(808, 534);
            // 
            // gcListaEmpleados
            // 
            this.gcListaEmpleados.DataMember = "dtListaEmpleados";
            this.gcListaEmpleados.DataSource = this.dsConfiguraciones1;
            this.gcListaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListaEmpleados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcListaEmpleados.Location = new System.Drawing.Point(0, 43);
            this.gcListaEmpleados.MainView = this.gvListaEmpleados;
            this.gcListaEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.gcListaEmpleados.Name = "gcListaEmpleados";
            this.gcListaEmpleados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditarEmpleado,
            this.chkHabilitar_Deshabilitar});
            this.gcListaEmpleados.Size = new System.Drawing.Size(808, 491);
            this.gcListaEmpleados.TabIndex = 53;
            this.gcListaEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListaEmpleados});
            // 
            // gvListaEmpleados
            // 
            this.gvListaEmpleados.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListaEmpleados.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListaEmpleados.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListaEmpleados.Appearance.Row.Options.UseFont = true;
            this.gvListaEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigoempleado,
            this.colnombre_empleado,
            this.colagencia_servicio,
            this.colcargo,
            this.colimg_habilitar_deshabilitar,
            this.colhabilitado,
            this.colimg_edicion});
            this.gvListaEmpleados.DetailHeight = 284;
            this.gvListaEmpleados.GridControl = this.gcListaEmpleados;
            this.gvListaEmpleados.Name = "gvListaEmpleados";
            this.gvListaEmpleados.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvListaEmpleados.OptionsView.ShowGroupPanel = false;
            this.gvListaEmpleados.OptionsView.ShowIndicator = false;
            // 
            // colcodigoempleado
            // 
            this.colcodigoempleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colcodigoempleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcodigoempleado.Caption = "CODIGO";
            this.colcodigoempleado.FieldName = "codigoempleado";
            this.colcodigoempleado.MinWidth = 19;
            this.colcodigoempleado.Name = "colcodigoempleado";
            this.colcodigoempleado.OptionsColumn.AllowEdit = false;
            this.colcodigoempleado.OptionsColumn.AllowFocus = false;
            this.colcodigoempleado.Visible = true;
            this.colcodigoempleado.VisibleIndex = 0;
            this.colcodigoempleado.Width = 97;
            // 
            // colnombre_empleado
            // 
            this.colnombre_empleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colnombre_empleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnombre_empleado.Caption = "NOMBRE";
            this.colnombre_empleado.FieldName = "nombre_empleado";
            this.colnombre_empleado.MinWidth = 19;
            this.colnombre_empleado.Name = "colnombre_empleado";
            this.colnombre_empleado.OptionsColumn.AllowEdit = false;
            this.colnombre_empleado.OptionsColumn.AllowFocus = false;
            this.colnombre_empleado.Visible = true;
            this.colnombre_empleado.VisibleIndex = 1;
            this.colnombre_empleado.Width = 209;
            // 
            // colagencia_servicio
            // 
            this.colagencia_servicio.AppearanceHeader.Options.UseTextOptions = true;
            this.colagencia_servicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colagencia_servicio.Caption = "AGENCIA";
            this.colagencia_servicio.FieldName = "agencia_servicio";
            this.colagencia_servicio.MinWidth = 19;
            this.colagencia_servicio.Name = "colagencia_servicio";
            this.colagencia_servicio.Width = 191;
            // 
            // colcargo
            // 
            this.colcargo.AppearanceHeader.Options.UseTextOptions = true;
            this.colcargo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcargo.Caption = "CARGO";
            this.colcargo.FieldName = "cargo";
            this.colcargo.MinWidth = 19;
            this.colcargo.Name = "colcargo";
            this.colcargo.OptionsColumn.AllowEdit = false;
            this.colcargo.OptionsColumn.AllowFocus = false;
            this.colcargo.Visible = true;
            this.colcargo.VisibleIndex = 2;
            this.colcargo.Width = 137;
            // 
            // colimg_habilitar_deshabilitar
            // 
            this.colimg_habilitar_deshabilitar.AppearanceHeader.Options.UseTextOptions = true;
            this.colimg_habilitar_deshabilitar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimg_habilitar_deshabilitar.Caption = "HABILITAR / DESHABILITAR";
            this.colimg_habilitar_deshabilitar.ColumnEdit = this.chkHabilitar_Deshabilitar;
            this.colimg_habilitar_deshabilitar.FieldName = "img_habilitar_deshabilitar";
            this.colimg_habilitar_deshabilitar.MinWidth = 19;
            this.colimg_habilitar_deshabilitar.Name = "colimg_habilitar_deshabilitar";
            this.colimg_habilitar_deshabilitar.Width = 112;
            // 
            // chkHabilitar_Deshabilitar
            // 
            this.chkHabilitar_Deshabilitar.AutoHeight = false;
            this.chkHabilitar_Deshabilitar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkHabilitar_Deshabilitar.ImageOptions.ImageChecked = global::Core.Properties.Resources.icon_encedido_32;
            this.chkHabilitar_Deshabilitar.ImageOptions.ImageGrayed = global::Core.Properties.Resources.icon_apagado_32;
            this.chkHabilitar_Deshabilitar.ImageOptions.ImageUnchecked = global::Core.Properties.Resources.icon_apagado_32;
            this.chkHabilitar_Deshabilitar.Name = "chkHabilitar_Deshabilitar";
            this.chkHabilitar_Deshabilitar.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ChkHabilitar_Deshabilitar_EditValueChanging);
            // 
            // colhabilitado
            // 
            this.colhabilitado.AppearanceHeader.Options.UseTextOptions = true;
            this.colhabilitado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhabilitado.Caption = "HABILITAR / DESHABILITAR";
            this.colhabilitado.ColumnEdit = this.chkHabilitar_Deshabilitar;
            this.colhabilitado.FieldName = "habilitado";
            this.colhabilitado.MaxWidth = 109;
            this.colhabilitado.MinWidth = 109;
            this.colhabilitado.Name = "colhabilitado";
            this.colhabilitado.Visible = true;
            this.colhabilitado.VisibleIndex = 4;
            this.colhabilitado.Width = 109;
            // 
            // colimg_edicion
            // 
            this.colimg_edicion.AppearanceHeader.Options.UseTextOptions = true;
            this.colimg_edicion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimg_edicion.Caption = "EDITAR";
            this.colimg_edicion.ColumnEdit = this.cmdEditarEmpleado;
            this.colimg_edicion.FieldName = "img_edicion";
            this.colimg_edicion.MaxWidth = 67;
            this.colimg_edicion.MinWidth = 67;
            this.colimg_edicion.Name = "colimg_edicion";
            this.colimg_edicion.Visible = true;
            this.colimg_edicion.VisibleIndex = 3;
            this.colimg_edicion.Width = 67;
            // 
            // cmdEditarEmpleado
            // 
            this.cmdEditarEmpleado.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Core.Properties.Resources.iconEditar_32;
            this.cmdEditarEmpleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditarEmpleado.Name = "cmdEditarEmpleado";
            this.cmdEditarEmpleado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditarEmpleado.Click += new System.EventHandler(this.CmdEditarEmpleado_Click);
            // 
            // pnlPopup
            // 
            this.pnlPopup.Controls.Add(this.popupBusquedaEmpleados);
            this.pnlPopup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPopup.Location = new System.Drawing.Point(0, 39);
            this.pnlPopup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPopup.Name = "pnlPopup";
            this.pnlPopup.Size = new System.Drawing.Size(808, 4);
            this.pnlPopup.TabIndex = 55;
            // 
            // popupBusquedaEmpleados
            // 
            this.popupBusquedaEmpleados.Appearance.BackColor = System.Drawing.Color.White;
            this.popupBusquedaEmpleados.Appearance.Options.UseBackColor = true;
            this.popupBusquedaEmpleados.Controls.Add(this.flyoutPanelControl1);
            this.popupBusquedaEmpleados.Location = new System.Drawing.Point(33, 6);
            this.popupBusquedaEmpleados.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupBusquedaEmpleados.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupBusquedaEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.popupBusquedaEmpleados.Name = "popupBusquedaEmpleados";
            this.popupBusquedaEmpleados.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupBusquedaEmpleados.Options.CloseOnOuterClick = true;
            this.popupBusquedaEmpleados.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupBusquedaEmpleados.OptionsButtonPanel.ButtonPanelHeight = 24;
            this.popupBusquedaEmpleados.OwnerControl = this.pnlPopup;
            this.popupBusquedaEmpleados.Size = new System.Drawing.Size(738, 63);
            this.popupBusquedaEmpleados.TabIndex = 0;
            this.popupBusquedaEmpleados.Hidden += new DevExpress.Utils.FlyoutPanelEventHandler(this.PopupBusquedaEmpleados_Hidden);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.txtBusquedaEmpleado);
            this.flyoutPanelControl1.Controls.Add(this.labelControl12);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupBusquedaEmpleados;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(738, 63);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // txtBusquedaEmpleado
            // 
            this.txtBusquedaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaEmpleado.Location = new System.Drawing.Point(159, 15);
            this.txtBusquedaEmpleado.Name = "txtBusquedaEmpleado";
            this.txtBusquedaEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtBusquedaEmpleado.Size = new System.Drawing.Size(557, 30);
            this.txtBusquedaEmpleado.TabIndex = 20;
            this.txtBusquedaEmpleado.TextChanged += new System.EventHandler(this.TxtBusquedaEmpleado_TextChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(13, 21);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(139, 21);
            this.labelControl12.TabIndex = 19;
            this.labelControl12.Text = "BUSQUEDA RAPIDA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblListaEmpleados);
            this.panel3.Controls.Add(this.picBusquedaEmpleado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 39);
            this.panel3.TabIndex = 54;
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEmpleados.Appearance.Options.UseFont = true;
            this.lblListaEmpleados.Appearance.Options.UseTextOptions = true;
            this.lblListaEmpleados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblListaEmpleados.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblListaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListaEmpleados.Location = new System.Drawing.Point(0, 0);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(735, 39);
            this.lblListaEmpleados.TabIndex = 52;
            this.lblListaEmpleados.Text = "LISTA EMPLEADOS EN AGENCIAS";
            // 
            // picBusquedaEmpleado
            // 
            this.picBusquedaEmpleado.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBusquedaEmpleado.EditValue = global::Core.Properties.Resources.iconBusqueda_32;
            this.picBusquedaEmpleado.Location = new System.Drawing.Point(735, 0);
            this.picBusquedaEmpleado.Name = "picBusquedaEmpleado";
            this.picBusquedaEmpleado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picBusquedaEmpleado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picBusquedaEmpleado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picBusquedaEmpleado.Size = new System.Drawing.Size(73, 39);
            this.picBusquedaEmpleado.TabIndex = 53;
            this.picBusquedaEmpleado.ToolTip = "Configuración de Empleados";
            this.picBusquedaEmpleado.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picBusquedaEmpleado.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picBusquedaEmpleado.ToolTipTitle = "FLUCOL";
            this.picBusquedaEmpleado.Click += new System.EventHandler(this.PicBusquedaEmpleado_Click);
            // 
            // pageInicial
            // 
            this.pageInicial.Caption = "pageInicial";
            this.pageInicial.Name = "pageInicial";
            this.pageInicial.Size = new System.Drawing.Size(808, 534);
            // 
            // epProveedorErrores
            // 
            this.epProveedorErrores.ContainerControl = this;
            // 
            // ctlMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "ctlMantenimientoUsuarios";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(818, 599);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdModicarUsuarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCrearUsuarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.pageCrearUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationEmpleados)).EndInit();
            this.NavigationEmpleados.ResumeLayout(false);
            this.pagePrimeraPagina.ResumeLayout(false);
            this.pagePrimeraPagina.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIrAtras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgencias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgenciasServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluAgencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCargosEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseniaTemporal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentidadEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegundoApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegundoNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoEmpleado.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pageConfiguracionUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHabilitar_Deshabilitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarEmpleado)).EndInit();
            this.pnlPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupBusquedaEmpleados)).EndInit();
            this.popupBusquedaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.flyoutPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaEmpleado.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBusquedaEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProveedorErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit cmdModicarUsuarios;
        private DevExpress.XtraEditors.PictureEdit cmdCrearUsuarios;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage pageCrearUsuarios;
        private DevExpress.XtraBars.Navigation.NavigationPage pageConfiguracionUsuarios;
        private DevExpress.XtraBars.Navigation.NavigationPage pageInicial;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationEmpleados;
        private DevExpress.XtraBars.Navigation.NavigationPage pagePrimeraPagina;
        private DevExpress.XtraEditors.TextEdit txtSegundoApellido;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPrimerApellido;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSegundoNombre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPrimerNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodigoEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DataSets.dsConfiguraciones dsConfiguraciones1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider epProveedorErrores;
        private System.Windows.Forms.BindingSource bsAgenciasServicio;
        private System.Windows.Forms.BindingSource bsCargosEmpleados;
        private DevExpress.XtraEditors.GridLookUpEdit gridAgencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gluAgencias;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_agencia;
        private DevExpress.XtraGrid.Columns.GridColumn colid_agencia_servicio;
        private DevExpress.XtraEditors.GridLookUpEdit gridCargos;
        private DevExpress.XtraGrid.Views.Grid.GridView gluCargos;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cargo;
        private DevExpress.XtraEditors.TextEdit txtContraseniaTemporal;
        private DevExpress.XtraEditors.LabelControl lblContraseniaTemporal;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtIdentidadEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton cmdRegistrarEmpleado;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraGrid.GridControl gcListaEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListaEmpleados;
        private DevExpress.XtraEditors.LabelControl lblListaEmpleados;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PictureEdit picBusquedaEmpleado;
        private System.Windows.Forms.Panel pnlPopup;
        private DevExpress.Utils.FlyoutPanel popupBusquedaEmpleados;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.TextEdit txtBusquedaEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colagencia_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo;
        private DevExpress.XtraGrid.Columns.GridColumn colimg_habilitar_deshabilitar;
        private DevExpress.XtraGrid.Columns.GridColumn colimg_edicion;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkHabilitar_Deshabilitar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditarEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitado;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit picIrAtras;
    }
}
