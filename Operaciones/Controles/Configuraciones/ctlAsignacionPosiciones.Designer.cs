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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcEmpleadosDisponiblesAsignacion = new DevExpress.XtraGrid.GridControl();
            this.dsConfiguraciones1 = new Operaciones.Controles.Configuraciones.DataSets.dsConfiguraciones();
            this.gvEmpleadosDisponiblesAsignacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposicion_asignada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargar_posiciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCargarPosiciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coltipo_ticket_prioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAsignarPrioridadAtencion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldescripcion_tipo_ticket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdGuardaraCambios = new DevExpress.XtraEditors.SimpleButton();
            this.popupTipoTickets = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.ctlTipoTicketServicio1 = new Core.Controles.Popups.ctlTipoTicketServicio();
            this.popupPosicionesDisponibles = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.ctlPosicionesDisponibles1 = new Core.Controles.Popups.ctlPosicionesDisponibles();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Operaciones.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleadosDisponiblesAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadosDisponiblesAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargarPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPrioridadAtencion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupTipoTickets)).BeginInit();
            this.popupTipoTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupPosicionesDisponibles)).BeginInit();
            this.popupPosicionesDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcEmpleadosDisponiblesAsignacion
            // 
            this.gcEmpleadosDisponiblesAsignacion.DataMember = "dtAsignacionPosiciones";
            this.gcEmpleadosDisponiblesAsignacion.DataSource = this.dsConfiguraciones1;
            this.gcEmpleadosDisponiblesAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpleadosDisponiblesAsignacion.Location = new System.Drawing.Point(0, 0);
            this.gcEmpleadosDisponiblesAsignacion.MainView = this.gvEmpleadosDisponiblesAsignacion;
            this.gcEmpleadosDisponiblesAsignacion.Name = "gcEmpleadosDisponiblesAsignacion";
            this.gcEmpleadosDisponiblesAsignacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdCargarPosiciones,
            this.cmdAsignarPrioridadAtencion});
            this.gcEmpleadosDisponiblesAsignacion.Size = new System.Drawing.Size(1057, 405);
            this.gcEmpleadosDisponiblesAsignacion.TabIndex = 0;
            this.gcEmpleadosDisponiblesAsignacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleadosDisponiblesAsignacion});
            // 
            // dsConfiguraciones1
            // 
            this.dsConfiguraciones1.DataSetName = "dsConfiguraciones";
            this.dsConfiguraciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEmpleadosDisponiblesAsignacion
            // 
            this.gvEmpleadosDisponiblesAsignacion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmpleadosDisponiblesAsignacion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEmpleadosDisponiblesAsignacion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmpleadosDisponiblesAsignacion.Appearance.Row.Options.UseFont = true;
            this.gvEmpleadosDisponiblesAsignacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusuario,
            this.colcodigo_empleado,
            this.colnombre_empleado,
            this.colposicion_asignada,
            this.colcargo_empleado,
            this.colcargar_posiciones,
            this.coltipo_ticket_prioridad,
            this.coldescripcion_tipo_ticket});
            this.gvEmpleadosDisponiblesAsignacion.GridControl = this.gcEmpleadosDisponiblesAsignacion;
            this.gvEmpleadosDisponiblesAsignacion.Name = "gvEmpleadosDisponiblesAsignacion";
            this.gvEmpleadosDisponiblesAsignacion.OptionsCustomization.AllowGroup = false;
            this.gvEmpleadosDisponiblesAsignacion.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.gvEmpleadosDisponiblesAsignacion.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvEmpleadosDisponiblesAsignacion.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvEmpleadosDisponiblesAsignacion.OptionsView.ShowGroupPanel = false;
            this.gvEmpleadosDisponiblesAsignacion.OptionsView.ShowIndicator = false;
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.OptionsColumn.AllowFocus = false;
            this.colusuario.OptionsColumn.ReadOnly = true;
            // 
            // colcodigo_empleado
            // 
            this.colcodigo_empleado.Caption = "CÓDIGO";
            this.colcodigo_empleado.FieldName = "codigo_empleado";
            this.colcodigo_empleado.Name = "colcodigo_empleado";
            this.colcodigo_empleado.OptionsColumn.AllowEdit = false;
            this.colcodigo_empleado.OptionsColumn.AllowFocus = false;
            this.colcodigo_empleado.OptionsColumn.ReadOnly = true;
            this.colcodigo_empleado.Visible = true;
            this.colcodigo_empleado.VisibleIndex = 0;
            this.colcodigo_empleado.Width = 129;
            // 
            // colnombre_empleado
            // 
            this.colnombre_empleado.Caption = "NOMBRE EMPLEADO";
            this.colnombre_empleado.FieldName = "nombre_empleado";
            this.colnombre_empleado.Name = "colnombre_empleado";
            this.colnombre_empleado.OptionsColumn.AllowEdit = false;
            this.colnombre_empleado.OptionsColumn.AllowFocus = false;
            this.colnombre_empleado.OptionsColumn.ReadOnly = true;
            this.colnombre_empleado.Visible = true;
            this.colnombre_empleado.VisibleIndex = 1;
            this.colnombre_empleado.Width = 253;
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
            this.colposicion_asignada.OptionsColumn.AllowEdit = false;
            this.colposicion_asignada.OptionsColumn.AllowFocus = false;
            this.colposicion_asignada.OptionsColumn.ReadOnly = true;
            this.colposicion_asignada.Visible = true;
            this.colposicion_asignada.VisibleIndex = 3;
            this.colposicion_asignada.Width = 102;
            // 
            // colcargo_empleado
            // 
            this.colcargo_empleado.Caption = "CARGO";
            this.colcargo_empleado.FieldName = "cargo_empleado";
            this.colcargo_empleado.Name = "colcargo_empleado";
            this.colcargo_empleado.OptionsColumn.AllowEdit = false;
            this.colcargo_empleado.OptionsColumn.AllowFocus = false;
            this.colcargo_empleado.OptionsColumn.ReadOnly = true;
            this.colcargo_empleado.Visible = true;
            this.colcargo_empleado.VisibleIndex = 2;
            this.colcargo_empleado.Width = 201;
            // 
            // colcargar_posiciones
            // 
            this.colcargar_posiciones.AppearanceHeader.Options.UseTextOptions = true;
            this.colcargar_posiciones.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcargar_posiciones.Caption = " ASIGNAR POSICION";
            this.colcargar_posiciones.ColumnEdit = this.cmdCargarPosiciones;
            this.colcargar_posiciones.FieldName = "cargar_posiciones";
            this.colcargar_posiciones.Name = "colcargar_posiciones";
            this.colcargar_posiciones.Visible = true;
            this.colcargar_posiciones.VisibleIndex = 5;
            this.colcargar_posiciones.Width = 111;
            // 
            // cmdCargarPosiciones
            // 
            this.cmdCargarPosiciones.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCargarPosiciones.Appearance.Options.UseBackColor = true;
            this.cmdCargarPosiciones.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Operaciones.Properties.Resources.icon_asignar_32;
            this.cmdCargarPosiciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdCargarPosiciones.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdCargarPosiciones.Name = "cmdCargarPosiciones";
            this.cmdCargarPosiciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdCargarPosiciones.Click += new System.EventHandler(this.cmdCargarPosiciones_Click);
            // 
            // coltipo_ticket_prioridad
            // 
            this.coltipo_ticket_prioridad.AppearanceHeader.Options.UseTextOptions = true;
            this.coltipo_ticket_prioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltipo_ticket_prioridad.Caption = "ASIGNAR PRIORIDAD TICKETS";
            this.coltipo_ticket_prioridad.ColumnEdit = this.cmdAsignarPrioridadAtencion;
            this.coltipo_ticket_prioridad.FieldName = "tipo_ticket_prioridad";
            this.coltipo_ticket_prioridad.Name = "coltipo_ticket_prioridad";
            this.coltipo_ticket_prioridad.Visible = true;
            this.coltipo_ticket_prioridad.VisibleIndex = 6;
            this.coltipo_ticket_prioridad.Width = 102;
            // 
            // cmdAsignarPrioridadAtencion
            // 
            this.cmdAsignarPrioridadAtencion.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdAsignarPrioridadAtencion.Appearance.Options.UseBackColor = true;
            this.cmdAsignarPrioridadAtencion.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Operaciones.Properties.Resources.icon_prioridad_32;
            this.cmdAsignarPrioridadAtencion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAsignarPrioridadAtencion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdAsignarPrioridadAtencion.Name = "cmdAsignarPrioridadAtencion";
            this.cmdAsignarPrioridadAtencion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAsignarPrioridadAtencion.Click += new System.EventHandler(this.cmdAsignarPrioridadAtencion_Click);
            // 
            // coldescripcion_tipo_ticket
            // 
            this.coldescripcion_tipo_ticket.Caption = "PRIORIDAD TICKETS";
            this.coldescripcion_tipo_ticket.FieldName = "descripcion_tipo_ticket";
            this.coldescripcion_tipo_ticket.Name = "coldescripcion_tipo_ticket";
            this.coldescripcion_tipo_ticket.OptionsColumn.AllowEdit = false;
            this.coldescripcion_tipo_ticket.OptionsColumn.AllowFocus = false;
            this.coldescripcion_tipo_ticket.OptionsColumn.ReadOnly = true;
            this.coldescripcion_tipo_ticket.Visible = true;
            this.coldescripcion_tipo_ticket.VisibleIndex = 4;
            this.coldescripcion_tipo_ticket.Width = 157;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridSplitContainer1);
            this.panel1.Controls.Add(this.cmdGuardaraCambios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 468);
            this.panel1.TabIndex = 2;
            // 
            // cmdGuardaraCambios
            // 
            this.cmdGuardaraCambios.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardaraCambios.Appearance.Options.UseFont = true;
            this.cmdGuardaraCambios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdGuardaraCambios.Location = new System.Drawing.Point(0, 405);
            this.cmdGuardaraCambios.Name = "cmdGuardaraCambios";
            this.cmdGuardaraCambios.Size = new System.Drawing.Size(1057, 63);
            this.cmdGuardaraCambios.TabIndex = 1;
            this.cmdGuardaraCambios.Text = "GUARDAR ASIGNACIONES";
            this.cmdGuardaraCambios.Click += new System.EventHandler(this.cmdGuardaraCambios_Click);
            // 
            // popupTipoTickets
            // 
            this.popupTipoTickets.Appearance.BackColor = System.Drawing.Color.White;
            this.popupTipoTickets.Appearance.Options.UseBackColor = true;
            this.popupTipoTickets.Controls.Add(this.flyoutPanelControl2);
            this.popupTipoTickets.Location = new System.Drawing.Point(1063, 461);
            this.popupTipoTickets.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupTipoTickets.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupTipoTickets.Name = "popupTipoTickets";
            this.popupTipoTickets.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.popupTipoTickets.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupTipoTickets.Options.CloseOnOuterClick = true;
            this.popupTipoTickets.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupTipoTickets.OwnerControl = this;
            this.popupTipoTickets.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.popupTipoTickets.Size = new System.Drawing.Size(506, 295);
            this.popupTipoTickets.TabIndex = 2;
            // 
            // flyoutPanelControl2
            // 
            this.flyoutPanelControl2.Controls.Add(this.ctlTipoTicketServicio1);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl2.FlyoutPanel = this.popupTipoTickets;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(5, 0);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(496, 295);
            this.flyoutPanelControl2.TabIndex = 0;
            // 
            // ctlTipoTicketServicio1
            // 
            this.ctlTipoTicketServicio1.BackColor = System.Drawing.Color.White;
            this.ctlTipoTicketServicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTipoTicketServicio1.Location = new System.Drawing.Point(3, 3);
            this.ctlTipoTicketServicio1.Name = "ctlTipoTicketServicio1";
            this.ctlTipoTicketServicio1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlTipoTicketServicio1.Pro_Conexion = null;
            this.ctlTipoTicketServicio1.Size = new System.Drawing.Size(490, 289);
            this.ctlTipoTicketServicio1.TabIndex = 0;
            // 
            // popupPosicionesDisponibles
            // 
            this.popupPosicionesDisponibles.Appearance.BackColor = System.Drawing.Color.White;
            this.popupPosicionesDisponibles.Appearance.Options.UseBackColor = true;
            this.popupPosicionesDisponibles.Controls.Add(this.flyoutPanelControl1);
            this.popupPosicionesDisponibles.Location = new System.Drawing.Point(1063, 151);
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
            this.ctlPosicionesDisponibles1.Pro_Conexion = null;
            this.ctlPosicionesDisponibles1.Pro_ID_AgenciaServicio = 0;
            this.ctlPosicionesDisponibles1.Pro_ID_ClienteServicio = 0;
            this.ctlPosicionesDisponibles1.Size = new System.Drawing.Size(527, 298);
            this.ctlPosicionesDisponibles1.TabIndex = 0;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gcEmpleadosDisponiblesAsignacion;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcEmpleadosDisponiblesAsignacion);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1057, 405);
            this.gridSplitContainer1.TabIndex = 2;
            // 
            // ctlAsignacionPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.popupTipoTickets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.popupPosicionesDisponibles);
            this.Name = "ctlAsignacionPosiciones";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1067, 478);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleadosDisponiblesAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguraciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadosDisponiblesAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargarPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarPrioridadAtencion)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupTipoTickets)).EndInit();
            this.popupTipoTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupPosicionesDisponibles)).EndInit();
            this.popupPosicionesDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmpleadosDisponiblesAsignacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleadosDisponiblesAsignacion;
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
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_ticket_prioridad;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAsignarPrioridadAtencion;
        private DevExpress.Utils.FlyoutPanel popupTipoTickets;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
        private Core.Controles.Popups.ctlTipoTicketServicio ctlTipoTicketServicio1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_tipo_ticket;
        private DevExpress.XtraEditors.SimpleButton cmdGuardaraCambios;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}
