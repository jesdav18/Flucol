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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView1 = new DevExpress.XtraCharts.BubbleSeriesView();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView2 = new DevExpress.XtraCharts.BubbleSeriesView();
            this.dsDashboards1 = new Core.Controles.Dashboards.DataSet.dsDashboards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView2)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(7, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 5);
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
            this.lblTituloDashboard.Location = new System.Drawing.Point(7, 6);
            this.lblTituloDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(497, 42);
            this.lblTituloDashboard.TabIndex = 8;
            this.lblTituloDashboard.Text = "VISITAS SEGUN CANAL DE SERVICIO";
            // 
            // chartControl2
            // 
            this.chartControl2.DataSource = this.dsDashboards1;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(7, 53);
            this.chartControl2.Name = "chartControl2";
            series1.ArgumentDataMember = "dtVisitasSegunCanalServicio.canal_servicio";
            series1.Name = "Serie1";
            series1.ValueDataMembersSerializable = "dtVisitasSegunCanalServicio.conteo_visitas;dtVisitasSegunCanalServicio.conteo_vis" +
    "itas";
            series1.View = bubbleSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl2.SeriesTemplate.SeriesColorizer = null;
            this.chartControl2.SeriesTemplate.View = bubbleSeriesView2;
            this.chartControl2.Size = new System.Drawing.Size(497, 323);
            this.chartControl2.TabIndex = 10;
            // 
            // ctlVisitasSegunCanalDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(513, 384);
            this.MinimumSize = new System.Drawing.Size(513, 384);
            this.Name = "ctlVisitasSegunCanalDeServicio";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(511, 382);
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet.dsDashboards dsDashboards1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}
