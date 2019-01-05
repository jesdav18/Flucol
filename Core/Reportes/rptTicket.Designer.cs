namespace Core.Reportes
{
    partial class rptTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptTicket));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblNombreAgencia = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNumeroTicket = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.lblHora = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNombreAgencia,
            this.lblNumeroTicket});
            this.Detail.HeightF = 85F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderColor = false;
            this.Detail.StylePriority.UseBorderDashStyle = false;
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblNombreAgencia
            // 
            this.lblNombreAgencia.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAgencia.LocationFloat = new DevExpress.Utils.PointFloat(15.5767F, 56.62297F);
            this.lblNombreAgencia.Name = "lblNombreAgencia";
            this.lblNombreAgencia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNombreAgencia.SizeF = new System.Drawing.SizeF(201.6709F, 23.77665F);
            this.lblNombreAgencia.StylePriority.UseFont = false;
            this.lblNombreAgencia.StylePriority.UseTextAlignment = false;
            this.lblNombreAgencia.Text = "AGN JARDINES DEL VALLE";
            this.lblNombreAgencia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNumeroTicket
            // 
            this.lblNumeroTicket.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTicket.LocationFloat = new DevExpress.Utils.PointFloat(15.16F, 1.099146F);
            this.lblNumeroTicket.Name = "lblNumeroTicket";
            this.lblNumeroTicket.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumeroTicket.SizeF = new System.Drawing.SizeF(202.0876F, 50.2316F);
            this.lblNumeroTicket.StylePriority.UseFont = false;
            this.lblNumeroTicket.StylePriority.UseTextAlignment = false;
            this.lblNumeroTicket.Text = "AAA-00";
            this.lblNumeroTicket.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 2F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 13F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.PageHeader.HeightF = 85F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFecha,
            this.lblHora});
            this.PageFooter.HeightF = 28F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.StylePriority.UseBorderColor = false;
            this.PageFooter.StylePriority.UseBorderDashStyle = false;
            this.PageFooter.StylePriority.UseBorders = false;
            this.PageFooter.StylePriority.UseBorderWidth = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.LocationFloat = new DevExpress.Utils.PointFloat(15.33963F, 2.482487F);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFecha.SizeF = new System.Drawing.SizeF(102.4901F, 23.00001F);
            this.lblFecha.StylePriority.UseFont = false;
            this.lblFecha.StylePriority.UseTextAlignment = false;
            this.lblFecha.Text = "00-00-0000";
            this.lblFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.LocationFloat = new DevExpress.Utils.PointFloat(142.6694F, 3.578969F);
            this.lblHora.Name = "lblHora";
            this.lblHora.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHora.SizeF = new System.Drawing.SizeF(74.57816F, 21.90352F);
            this.lblHora.StylePriority.UseFont = false;
            this.lblHora.StylePriority.UseTextAlignment = false;
            this.lblHora.Text = "00:00AM";
            this.lblHora.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(13.86334F, 2.149655F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(203.3842F, 77.97217F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // rptTicket
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.BorderWidth = 0F;
            this.DisplayName = "Ticket";
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 2, 13);
            this.PageHeight = 255;
            this.PageWidth = 255;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.ShowPrintStatusDialog = false;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private DevExpress.XtraReports.UI.XRLabel lblNumeroTicket;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lblFecha;
        private DevExpress.XtraReports.UI.XRLabel lblHora;
        private DevExpress.XtraReports.UI.XRLabel lblNombreAgencia;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    }
}
