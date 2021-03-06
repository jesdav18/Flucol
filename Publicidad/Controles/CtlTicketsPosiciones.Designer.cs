﻿namespace Publicidad.Controles
{
    partial class CtlTicketsPosiciones
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTituloPosiciones = new DevExpress.XtraEditors.LabelControl();
            this.lblTituloTickets = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblPosicion = new DevExpress.XtraEditors.LabelControl();
            this.lblTicket = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcTicket = new DevExpress.XtraGrid.GridControl();
            this.dsTicketsPosiciones1 = new Publicidad.DataSets.dsTicketsPosiciones();
            this.gvTicket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colticket1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gcPosicion = new DevExpress.XtraGrid.GridControl();
            this.gvPosicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tmrColaTickets = new System.Windows.Forms.Timer(this.components);
            this.tmrLlamadoTickets = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTicketsPosiciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPosicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lblTituloPosiciones);
            this.panelControl1.Controls.Add(this.lblTituloTickets);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(607, 76);
            this.panelControl1.TabIndex = 0;
            // 
            // lblTituloPosiciones
            // 
            this.lblTituloPosiciones.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTituloPosiciones.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPosiciones.Appearance.Options.UseBackColor = true;
            this.lblTituloPosiciones.Appearance.Options.UseFont = true;
            this.lblTituloPosiciones.Appearance.Options.UseTextOptions = true;
            this.lblTituloPosiciones.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloPosiciones.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloPosiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloPosiciones.Location = new System.Drawing.Point(300, 3);
            this.lblTituloPosiciones.Name = "lblTituloPosiciones";
            this.lblTituloPosiciones.Size = new System.Drawing.Size(304, 70);
            this.lblTituloPosiciones.TabIndex = 1;
            this.lblTituloPosiciones.Text = "POSICIÓN";
            // 
            // lblTituloTickets
            // 
            this.lblTituloTickets.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTickets.Appearance.Options.UseFont = true;
            this.lblTituloTickets.Appearance.Options.UseTextOptions = true;
            this.lblTituloTickets.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloTickets.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloTickets.Location = new System.Drawing.Point(3, 3);
            this.lblTituloTickets.Name = "lblTituloTickets";
            this.lblTituloTickets.Size = new System.Drawing.Size(297, 70);
            this.lblTituloTickets.TabIndex = 0;
            this.lblTituloTickets.Text = "TICKET";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.lblPosicion);
            this.panelControl2.Controls.Add(this.lblTicket);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 76);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(607, 134);
            this.panelControl2.TabIndex = 1;
            // 
            // lblPosicion
            // 
            this.lblPosicion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPosicion.Appearance.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPosicion.Appearance.Options.UseBackColor = true;
            this.lblPosicion.Appearance.Options.UseFont = true;
            this.lblPosicion.Appearance.Options.UseForeColor = true;
            this.lblPosicion.Appearance.Options.UseTextOptions = true;
            this.lblPosicion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPosicion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPosicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosicion.Location = new System.Drawing.Point(300, 3);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(304, 128);
            this.lblPosicion.TabIndex = 2;
            this.lblPosicion.Text = "POS.";
            // 
            // lblTicket
            // 
            this.lblTicket.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTicket.Appearance.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTicket.Appearance.Options.UseBackColor = true;
            this.lblTicket.Appearance.Options.UseFont = true;
            this.lblTicket.Appearance.Options.UseForeColor = true;
            this.lblTicket.Appearance.Options.UseTextOptions = true;
            this.lblTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTicket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTicket.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTicket.Location = new System.Drawing.Point(3, 3);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(297, 128);
            this.lblTicket.TabIndex = 1;
            this.lblTicket.Text = "TICKET";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.gcTicket);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 210);
            this.panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(300, 283);
            this.panelControl3.TabIndex = 2;
            // 
            // gcTicket
            // 
            this.gcTicket.DataMember = "dtTicketsPosiciones";
            this.gcTicket.DataSource = this.dsTicketsPosiciones1;
            this.gcTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcTicket.Location = new System.Drawing.Point(3, 3);
            this.gcTicket.MainView = this.gvTicket;
            this.gcTicket.Name = "gcTicket";
            this.gcTicket.Size = new System.Drawing.Size(294, 277);
            this.gcTicket.TabIndex = 0;
            this.gcTicket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTicket});
            // 
            // dsTicketsPosiciones1
            // 
            this.dsTicketsPosiciones1.DataSetName = "dsTicketsPosiciones";
            this.dsTicketsPosiciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTicket
            // 
            this.gvTicket.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTicket.Appearance.Row.Options.UseFont = true;
            this.gvTicket.Appearance.Row.Options.UseTextOptions = true;
            this.gvTicket.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvTicket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvTicket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colticket1});
            this.gvTicket.GridControl = this.gcTicket;
            this.gvTicket.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvTicket.Name = "gvTicket";
            this.gvTicket.OptionsBehavior.SmartVertScrollBar = false;
            this.gvTicket.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTicket.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvTicket.OptionsView.ShowColumnHeaders = false;
            this.gvTicket.OptionsView.ShowGroupPanel = false;
            this.gvTicket.OptionsView.ShowIndicator = false;
            this.gvTicket.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvTicket.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvTicket_InvalidRowException);
            // 
            // colticket1
            // 
            this.colticket1.FieldName = "ticket";
            this.colticket1.Name = "colticket1";
            this.colticket1.OptionsColumn.AllowEdit = false;
            this.colticket1.OptionsColumn.AllowFocus = false;
            this.colticket1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colticket1.OptionsColumn.AllowMove = false;
            this.colticket1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colticket1.OptionsColumn.ReadOnly = true;
            this.colticket1.OptionsFilter.AllowAutoFilter = false;
            this.colticket1.OptionsFilter.AllowFilter = false;
            this.colticket1.Visible = true;
            this.colticket1.VisibleIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Controls.Add(this.gcPosicion);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(300, 210);
            this.panelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(307, 283);
            this.panelControl4.TabIndex = 3;
            // 
            // gcPosicion
            // 
            this.gcPosicion.DataMember = "dtTicketsPosiciones";
            this.gcPosicion.DataSource = this.dsTicketsPosiciones1;
            this.gcPosicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPosicion.Location = new System.Drawing.Point(3, 3);
            this.gcPosicion.MainView = this.gvPosicion;
            this.gcPosicion.Name = "gcPosicion";
            this.gcPosicion.Size = new System.Drawing.Size(301, 277);
            this.gcPosicion.TabIndex = 1;
            this.gcPosicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPosicion});
            // 
            // gvPosicion
            // 
            this.gvPosicion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPosicion.Appearance.Row.Options.UseFont = true;
            this.gvPosicion.Appearance.Row.Options.UseTextOptions = true;
            this.gvPosicion.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvPosicion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPosicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposicion});
            this.gvPosicion.GridControl = this.gcPosicion;
            this.gvPosicion.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvPosicion.Name = "gvPosicion";
            this.gvPosicion.OptionsBehavior.AllowPartialRedrawOnScrolling = false;
            this.gvPosicion.OptionsBehavior.SmartVertScrollBar = false;
            this.gvPosicion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPosicion.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvPosicion.OptionsView.ShowColumnHeaders = false;
            this.gvPosicion.OptionsView.ShowGroupPanel = false;
            this.gvPosicion.OptionsView.ShowIndicator = false;
            this.gvPosicion.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvPosicion.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvPosicion_InvalidRowException);
            // 
            // colposicion
            // 
            this.colposicion.FieldName = "posicion";
            this.colposicion.Name = "colposicion";
            this.colposicion.OptionsColumn.AllowEdit = false;
            this.colposicion.OptionsColumn.AllowFocus = false;
            this.colposicion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colposicion.OptionsColumn.AllowMove = false;
            this.colposicion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colposicion.OptionsColumn.ReadOnly = true;
            this.colposicion.Visible = true;
            this.colposicion.VisibleIndex = 0;
            // 
            // tmrColaTickets
            // 
            this.tmrColaTickets.Interval = 1000;
            this.tmrColaTickets.Tick += new System.EventHandler(this.tmrColaTickets_Tick);
            // 
            // tmrLlamadoTickets
            // 
            this.tmrLlamadoTickets.Interval = 800;
            this.tmrLlamadoTickets.Tick += new System.EventHandler(this.tmrLlamadoTickets_Tick);
            // 
            // CtlTicketsPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtlTicketsPosiciones";
            this.Size = new System.Drawing.Size(607, 493);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTicketsPosiciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPosicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPosicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTituloPosiciones;
        private DevExpress.XtraEditors.LabelControl lblTituloTickets;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblPosicion;
        private DevExpress.XtraEditors.LabelControl lblTicket;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DataSets.dsTicketsPosiciones dsTicketsPosiciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colticket1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colposicion;
        public DevExpress.XtraGrid.GridControl gcTicket;
        public DevExpress.XtraGrid.GridControl gcPosicion;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTicket;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPosicion;
        private System.Windows.Forms.Timer tmrColaTickets;
        private System.Windows.Forms.Timer tmrLlamadoTickets;
    }
}
