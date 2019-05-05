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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsDashboards = new Core.Controles.Dashboards.DataSet.dsDashboards();
            this.chrt_TicketsAtendidos_NoAtendidos = new DevExpress.XtraCharts.ChartControl();
            this.dtTicketsAtendidosNoAtendidosBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_TicketsAtendidos_NoAtendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTicketsAtendidosNoAtendidosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.lblTituloDashboard.Location = new System.Drawing.Point(5, 5);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(362, 34);
            this.lblTituloDashboard.TabIndex = 1;
            this.lblTituloDashboard.Text = "TICKETS ATENDIDOS Y NO ATENDIDOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 4);
            this.panel1.TabIndex = 6;
            // 
            // dsDashboards
            // 
            this.dsDashboards.DataSetName = "dsDashboards";
            this.dsDashboards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chrt_TicketsAtendidos_NoAtendidos
            // 
            this.chrt_TicketsAtendidos_NoAtendidos.DataSource = this.dtTicketsAtendidosNoAtendidosBindingSource;
            this.chrt_TicketsAtendidos_NoAtendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrt_TicketsAtendidos_NoAtendidos.Legend.Name = "Default Legend";
            this.chrt_TicketsAtendidos_NoAtendidos.Location = new System.Drawing.Point(5, 43);
            this.chrt_TicketsAtendidos_NoAtendidos.Name = "chrt_TicketsAtendidos_NoAtendidos";
            series1.ArgumentDataMember = "descripcion";
            series1.DataSource = this.dtTicketsAtendidosNoAtendidosBindingSource;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Serie1";
            series1.ValueDataMembersSerializable = "conteo_tickets";
            series1.View = pieSeriesView1;
            this.chrt_TicketsAtendidos_NoAtendidos.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chrt_TicketsAtendidos_NoAtendidos.Size = new System.Drawing.Size(362, 234);
            this.chrt_TicketsAtendidos_NoAtendidos.TabIndex = 7;
            // 
            // dtTicketsAtendidosNoAtendidosBindingSource
            // 
            this.dtTicketsAtendidosNoAtendidosBindingSource.DataMember = "dtTicketsAtendidos_NoAtendidos";
            this.dtTicketsAtendidosNoAtendidosBindingSource.DataSource = this.dsDashboards;
            // 
            // ctlTicketsAtendidos_TicketsNoAtendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chrt_TicketsAtendidos_NoAtendidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.Name = "ctlTicketsAtendidos_TicketsNoAtendidos";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(372, 282);
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_TicketsAtendidos_NoAtendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTicketsAtendidosNoAtendidosBindingSource)).EndInit();
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
