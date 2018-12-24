namespace Flucol.Reportes
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
            this.lblNumeroTicket = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblHora = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.picLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblNombreAgencia = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNombreAgencia,
            this.lblNumeroTicket});
            this.Detail.HeightF = 110.2083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderColor = false;
            this.Detail.StylePriority.UseBorderDashStyle = false;
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblNumeroTicket
            // 
            this.lblNumeroTicket.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTicket.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.lblNumeroTicket.Name = "lblNumeroTicket";
            this.lblNumeroTicket.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumeroTicket.SizeF = new System.Drawing.SizeF(213.3862F, 58.95831F);
            this.lblNumeroTicket.StylePriority.UseFont = false;
            this.lblNumeroTicket.StylePriority.UseTextAlignment = false;
            this.lblNumeroTicket.Text = "AAA-00";
            this.lblNumeroTicket.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 3.708331F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 7F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picLogo});
            this.PageHeader.HeightF = 75F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFecha,
            this.lblHora});
            this.PageFooter.HeightF = 35.41667F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.StylePriority.UseBorderColor = false;
            this.PageFooter.StylePriority.UseBorderDashStyle = false;
            this.PageFooter.StylePriority.UseBorders = false;
            this.PageFooter.StylePriority.UseBorderWidth = false;
            // 
            // lblHora
            // 
            this.lblHora.LocationFloat = new DevExpress.Utils.PointFloat(144.2196F, 2.416674F);
            this.lblHora.Name = "lblHora";
            this.lblHora.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHora.SizeF = new System.Drawing.SizeF(79.16666F, 23F);
            this.lblHora.StylePriority.UseTextAlignment = false;
            this.lblHora.Text = "00:00AM";
            this.lblHora.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 2.416674F);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFecha.SizeF = new System.Drawing.SizeF(108.3333F, 23F);
            this.lblFecha.StylePriority.UseFont = false;
            this.lblFecha.StylePriority.UseTextAlignment = false;
            this.lblFecha.Text = "00-00-0000";
            this.lblFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.picLogo.Name = "picLogo";
            this.picLogo.SizeF = new System.Drawing.SizeF(213.3862F, 53.25697F);
            this.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.picLogo.StylePriority.UseBorderDashStyle = false;
            // 
            // lblNombreAgencia
            // 
            this.lblNombreAgencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAgencia.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 77.70834F);
            this.lblNombreAgencia.Name = "lblNombreAgencia";
            this.lblNombreAgencia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNombreAgencia.SizeF = new System.Drawing.SizeF(213.3862F, 27.70831F);
            this.lblNombreAgencia.StylePriority.UseFont = false;
            this.lblNombreAgencia.StylePriority.UseTextAlignment = false;
            this.lblNombreAgencia.Text = "AGN JARDINES DEL VALLE";
            this.lblNombreAgencia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 4, 7);
            this.PageHeight = 281;
            this.PageWidth = 240;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None;
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
        private DevExpress.XtraReports.UI.XRPictureBox picLogo;
    }
}
