namespace Core.Controles.Popups
{
    partial class ctlTipoTicketServicio
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gcTipoTicket = new DevExpress.XtraGrid.GridControl();
            this.dsCore1 = new Core.DataSets.dsCore();
            this.gvTipoTicketServicio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_tipo_ticket_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar_tipo_ticket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colid_prioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_prioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoTicketServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.labelControl1);
            this.pnlSuperior.Controls.Add(this.pictureEdit1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(5, 5);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(596, 44);
            this.pnlSuperior.TabIndex = 2;
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
            this.labelControl1.Size = new System.Drawing.Size(546, 44);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "TIPOS DE TICKETS";
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
            // gcTipoTicket
            // 
            this.gcTipoTicket.DataMember = "dtTipoTickets";
            this.gcTipoTicket.DataSource = this.dsCore1;
            this.gcTipoTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTipoTicket.Location = new System.Drawing.Point(5, 49);
            this.gcTipoTicket.MainView = this.gvTipoTicketServicio;
            this.gcTipoTicket.Name = "gcTipoTicket";
            this.gcTipoTicket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gcTipoTicket.Size = new System.Drawing.Size(596, 377);
            this.gcTipoTicket.TabIndex = 3;
            this.gcTipoTicket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoTicketServicio});
            // 
            // dsCore1
            // 
            this.dsCore1.DataSetName = "dsCore";
            this.dsCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTipoTicketServicio
            // 
            this.gvTipoTicketServicio.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTipoTicketServicio.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTipoTicketServicio.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTipoTicketServicio.Appearance.Row.Options.UseFont = true;
            this.gvTipoTicketServicio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tipo_ticket_servicio,
            this.coldescripcion,
            this.colseleccionar_tipo_ticket,
            this.colid_prioridad,
            this.coldescripcion_prioridad});
            this.gvTipoTicketServicio.GridControl = this.gcTipoTicket;
            this.gvTipoTicketServicio.Name = "gvTipoTicketServicio";
            this.gvTipoTicketServicio.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvTipoTicketServicio.OptionsView.ShowGroupPanel = false;
            this.gvTipoTicketServicio.OptionsView.ShowIndicator = false;
            // 
            // colid_tipo_ticket_servicio
            // 
            this.colid_tipo_ticket_servicio.FieldName = "id_tipo_ticket_servicio";
            this.colid_tipo_ticket_servicio.Name = "colid_tipo_ticket_servicio";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "DESCRIPCION";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colseleccionar_tipo_ticket
            // 
            this.colseleccionar_tipo_ticket.AppearanceHeader.Options.UseTextOptions = true;
            this.colseleccionar_tipo_ticket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colseleccionar_tipo_ticket.Caption = "SELECCIONAR";
            this.colseleccionar_tipo_ticket.ColumnEdit = this.chkSeleccionar;
            this.colseleccionar_tipo_ticket.FieldName = "seleccionar_tipo_ticket";
            this.colseleccionar_tipo_ticket.Name = "colseleccionar_tipo_ticket";
            this.colseleccionar_tipo_ticket.Visible = true;
            this.colseleccionar_tipo_ticket.VisibleIndex = 2;
            this.colseleccionar_tipo_ticket.Width = 137;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkSeleccionar.ImageOptions.ImageChecked = global::Core.Properties.Resources.icon_check_32;
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.chkSeleccionar_EditValueChanging);
            // 
            // colid_prioridad
            // 
            this.colid_prioridad.FieldName = "id_prioridad";
            this.colid_prioridad.Name = "colid_prioridad";
            // 
            // coldescripcion_prioridad
            // 
            this.coldescripcion_prioridad.Caption = "PRIORIDAD";
            this.coldescripcion_prioridad.FieldName = "descripcion_prioridad";
            this.coldescripcion_prioridad.Name = "coldescripcion_prioridad";
            this.coldescripcion_prioridad.Visible = true;
            this.coldescripcion_prioridad.VisibleIndex = 1;
            // 
            // ctlTipoTicketServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gcTipoTicket);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "ctlTipoTicketServicio";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(606, 431);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoTicketServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl gcTipoTicket;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoTicketServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_ticket_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar_tipo_ticket;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_prioridad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_prioridad;
        public DataSets.dsCore dsCore1;
    }
}
