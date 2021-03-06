namespace Attendance.Reports
{
    partial class LateComingEarlyReturning
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrpPageNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrlFromDateToDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlFooter = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 0;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrpPageNumber
            // 
            this.xrpPageNumber.Location = new System.Drawing.Point(1091, 0);
            this.xrpPageNumber.Name = "xrpPageNumber";
            this.xrpPageNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrpPageNumber.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
            this.xrpPageNumber.Size = new System.Drawing.Size(28, 25);
            this.xrpPageNumber.StylePriority.UseTextAlignment = false;
            this.xrpPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlFromDateToDate
            // 
            this.xrlFromDateToDate.CanShrink = true;
            this.xrlFromDateToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrlFromDateToDate.Location = new System.Drawing.Point(341, 98);
            this.xrlFromDateToDate.Name = "xrlFromDateToDate";
            this.xrlFromDateToDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlFromDateToDate.Size = new System.Drawing.Size(442, 25);
            this.xrlFromDateToDate.StylePriority.UseFont = false;
            this.xrlFromDateToDate.StylePriority.UsePadding = false;
            this.xrlFromDateToDate.StylePriority.UseTextAlignment = false;
            this.xrlFromDateToDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrlTitle
            // 
            this.xrlTitle.CanShrink = true;
            this.xrlTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlTitle.Location = new System.Drawing.Point(250, 58);
            this.xrlTitle.Name = "xrlTitle";
            this.xrlTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlTitle.Size = new System.Drawing.Size(620, 40);
            this.xrlTitle.StylePriority.UseFont = false;
            this.xrlTitle.StylePriority.UseForeColor = false;
            this.xrlTitle.StylePriority.UsePadding = false;
            this.xrlTitle.StylePriority.UseTextAlignment = false;
            this.xrlTitle.Text = "BÁO CÁO NHÂN LỰC ĐI MUỘN, VỀ SỚM THEO NGÀY/TUẦN";
            this.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrlHeader
            // 
            this.xrlHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlHeader.Location = new System.Drawing.Point(0, 0);
            this.xrlHeader.Multiline = true;
            this.xrlHeader.Name = "xrlHeader";
            this.xrlHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrlHeader.Size = new System.Drawing.Size(1119, 25);
            this.xrlHeader.StylePriority.UseFont = false;
            this.xrlHeader.StylePriority.UsePadding = false;
            this.xrlHeader.StylePriority.UseTextAlignment = false;
            this.xrlHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrlHeader.PreviewDoubleClick += new DevExpress.XtraReports.UI.PreviewMouseEventHandler(this.xRLabel_PreviewDoubleClick);
            this.xrlHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xRLabel_BeforePrint);
            // 
            // xrlFooter
            // 
            this.xrlFooter.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrlFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlFooter.Location = new System.Drawing.Point(0, 80);
            this.xrlFooter.Name = "xrlFooter";
            this.xrlFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlFooter.Size = new System.Drawing.Size(1119, 25);
            this.xrlFooter.StylePriority.UseBorders = false;
            this.xrlFooter.StylePriority.UseFont = false;
            this.xrlFooter.StylePriority.UsePadding = false;
            this.xrlFooter.StylePriority.UseTextAlignment = false;
            this.xrlFooter.Text = "Người lập báo cáo";
            this.xrlFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrlFooter.PreviewDoubleClick += new DevExpress.XtraReports.UI.PreviewMouseEventHandler(this.xRLabel_PreviewDoubleClick);
            this.xrlFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xRLabel_BeforePrint);
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrpPageNumber});
            this.BottomMargin.Height = 25;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlHeader,
            this.xrlTitle,
            this.xrlFromDateToDate});
            this.ReportHeader.Height = 135;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 0;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlFooter});
            this.ReportFooter.Height = 105;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // LateComingEarlyReturning
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnapToGrid = false;
            this.Version = "9.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.LateComingEarlyReturning_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRLabel xrlTitle;
        private DevExpress.XtraReports.UI.XRLabel xrlFromDateToDate;
        private DevExpress.XtraReports.UI.XRLabel xrlFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrpPageNumber;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    }
}
