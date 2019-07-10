namespace Core.Controles.Dashboards
{
    partial class ctlVisitasSegunPrioridadServicio
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.lblTituloDashboard = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsDashboards1 = new Core.Controles.Dashboards.DataSet.dsDashboards();
            this.dsDashboards1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
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
            this.lblTituloDashboard.Location = new System.Drawing.Point(7, 6);
            this.lblTituloDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(497, 42);
            this.lblTituloDashboard.TabIndex = 1;
            this.lblTituloDashboard.Text = "VISITAS SEGÚN PRIORIDAD DE SERVICIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 5);
            this.panel1.TabIndex = 6;
            // 
            // dsDashboards1
            // 
            this.dsDashboards1.DataSetName = "dsDashboards";
            this.dsDashboards1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDashboards1BindingSource
            // 
            this.dsDashboards1BindingSource.DataSource = this.dsDashboards1;
            this.dsDashboards1BindingSource.Position = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.dsDashboards1BindingSource;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(7, 53);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "dtVisitasSegunPrioridadServicio.prioridad_servicio";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendName = "Default Legend";
            series1.Name = "srVisitasSegunPrioridad";
            series1.ValueDataMembersSerializable = "dtVisitasSegunPrioridadServicio.conteo_visitas";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.SeriesColorizer = null;
            this.chartControl1.Size = new System.Drawing.Size(497, 215);
            this.chartControl1.TabIndex = 7;
            // 
            // ctlVisitasSegunPrioridadServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(513, 276);
            this.MinimumSize = new System.Drawing.Size(513, 276);
            this.Name = "ctlVisitasSegunPrioridadServicio";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(511, 276);
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashboards1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
        private System.Windows.Forms.Panel panel1;
        private DataSet.dsDashboards dsDashboards1;
        private System.Windows.Forms.BindingSource dsDashboards1BindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
