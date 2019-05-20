namespace Core.Controles.Dashboards
{
    partial class ctlVisitasSegunCanalDeServicio
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
            DevExpress.XtraCharts.FunnelSeriesView funnelSeriesView1 = new DevExpress.XtraCharts.FunnelSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.dsDashboards1 = new Core.Controles.Dashboards.DataSet.dsDashboards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.dsDashboards1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(5, 43);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "dtVisitasSegunCanalServicio.canal_servicio";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendName = "Default Legend";
            series1.Name = "Serie1";
            series1.ValueDataMembersSerializable = "dtVisitasSegunCanalServicio.conteo_visitas";
            series1.View = funnelSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(373, 262);
            this.chartControl1.TabIndex = 0;
            // 
            // dsDashboards1
            // 
            this.dsDashboards1.DataSetName = "dsDashboards";
            this.dsDashboards1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 4);
            this.panel1.TabIndex = 9;
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
            this.lblTituloDashboard.Size = new System.Drawing.Size(373, 34);
            this.lblTituloDashboard.TabIndex = 8;
            this.lblTituloDashboard.Text = "VISITAS SEGUN CANAL DE SERVICIO";
            // 
            // ctlVisitasSegunCanalDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.MaximumSize = new System.Drawing.Size(385, 312);
            this.MinimumSize = new System.Drawing.Size(385, 312);
            this.Name = "ctlVisitasSegunCanalDeServicio";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(385, 312);
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DataSet.dsDashboards dsDashboards1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
    }
}
