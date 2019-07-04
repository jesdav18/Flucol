namespace Core.Controles.Dashboards
{
    partial class ctlTicketsAtendidos_TicketsNoAtendidos
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.dtTicketsAtendidosNoAtendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDashboards = new Core.Controles.Dashboards.DataSet.dsDashboards();
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chrt_TicketsAtendidos_NoAtendidos = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtTicketsAtendidosNoAtendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_TicketsAtendidos_NoAtendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTicketsAtendidosNoAtendidosBindingSource
            // 
            this.dtTicketsAtendidosNoAtendidosBindingSource.DataMember = "dtTicketsAtendidos_NoAtendidos";
            this.dtTicketsAtendidosNoAtendidosBindingSource.DataSource = this.dsDashboards;
            // 
            // dsDashboards
            // 
            this.dsDashboards.DataSetName = "dsDashboards";
            this.dsDashboards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTituloDashboard
            // 
            this.lblTituloDashboard.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDashboard.Appearance.Options.UseFont = true;
            this.lblTituloDashboard.Appearance.Options.UseTextOptions = true;
            this.lblTituloDashboard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloDashboard.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTituloDashboard.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloDashboard.Location = new System.Drawing.Point(7, 6);
            this.lblTituloDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.lblTituloDashboard.MaximumSize = new System.Drawing.Size(480, 42);
            this.lblTituloDashboard.MinimumSize = new System.Drawing.Size(480, 42);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(480, 42);
            this.lblTituloDashboard.TabIndex = 1;
            this.lblTituloDashboard.Text = "TICKETS ATENDIDOS Y NO ATENDIDOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 5);
            this.panel1.TabIndex = 6;
            // 
            // chrt_TicketsAtendidos_NoAtendidos
            // 
            this.chrt_TicketsAtendidos_NoAtendidos.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chrt_TicketsAtendidos_NoAtendidos.DataSource = this.dtTicketsAtendidosNoAtendidosBindingSource;
            this.chrt_TicketsAtendidos_NoAtendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrt_TicketsAtendidos_NoAtendidos.Legend.Name = "Default Legend";
            this.chrt_TicketsAtendidos_NoAtendidos.Location = new System.Drawing.Point(7, 53);
            this.chrt_TicketsAtendidos_NoAtendidos.Margin = new System.Windows.Forms.Padding(4);
            this.chrt_TicketsAtendidos_NoAtendidos.Name = "chrt_TicketsAtendidos_NoAtendidos";
            series1.ArgumentDataMember = "descripcion";
            series1.DataSource = this.dtTicketsAtendidosNoAtendidosBindingSource;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Serie1";
            series1.ValueDataMembersSerializable = "conteo_tickets";
            series1.View = pieSeriesView1;
            this.chrt_TicketsAtendidos_NoAtendidos.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chrt_TicketsAtendidos_NoAtendidos.SeriesTemplate.SeriesColorizer = null;
            this.chrt_TicketsAtendidos_NoAtendidos.Size = new System.Drawing.Size(497, 123);
            this.chrt_TicketsAtendidos_NoAtendidos.TabIndex = 7;
            // 
            // ctlTicketsAtendidos_TicketsNoAtendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chrt_TicketsAtendidos_NoAtendidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(513, 184);
            this.MinimumSize = new System.Drawing.Size(513, 184);
            this.Name = "ctlTicketsAtendidos_TicketsNoAtendidos";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(511, 182);
            ((System.ComponentModel.ISupportInitialize)(this.dtTicketsAtendidosNoAtendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_TicketsAtendidos_NoAtendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
        private System.Windows.Forms.Panel panel1;
        private DataSet.dsDashboards dsDashboards;
        private DevExpress.XtraCharts.ChartControl chrt_TicketsAtendidos_NoAtendidos;
        private System.Windows.Forms.BindingSource dtTicketsAtendidosNoAtendidosBindingSource;
    }
}
