namespace Personnel.Reports
{
    partial class LimitLabourContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimitLabourContract));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.grhEmployeeID = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrtContent = new DevExpress.XtraReports.UI.XRRichText();
            this.grfEmployeeID = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrpPageNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrtContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 0;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // grhEmployeeID
            // 
            this.grhEmployeeID.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtContent});
            this.grhEmployeeID.Height = 25;
            this.grhEmployeeID.Name = "grhEmployeeID";
            // 
            // xrtContent
            // 
            this.xrtContent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrtContent.Location = new System.Drawing.Point(45, 0);
            this.xrtContent.Name = "xrtContent";
            this.xrtContent.SerializableRtfString = resources.GetString("xrtContent.SerializableRtfString");
            this.xrtContent.Size = new System.Drawing.Size(600, 25);
            this.xrtContent.StylePriority.UseFont = false;
            this.xrtContent.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrtContent_BeforePrint);
            // 
            // grfEmployeeID
            // 
            this.grfEmployeeID.Height = 0;
            this.grfEmployeeID.Name = "grfEmployeeID";
            this.grfEmployeeID.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.PageHeader.Height = 115;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.Location = new System.Drawing.Point(491, 0);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.Size = new System.Drawing.Size(198, 103);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrpPageNumber,
            this.xrRichText5,
            this.xrRichText4,
            this.xrPictureBox2});
            this.PageFooter.Height = 138;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrpPageNumber
            // 
            this.xrpPageNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrpPageNumber.Location = new System.Drawing.Point(330, 115);
            this.xrpPageNumber.Name = "xrpPageNumber";
            this.xrpPageNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrpPageNumber.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
            this.xrpPageNumber.Size = new System.Drawing.Size(28, 23);
            this.xrpPageNumber.StylePriority.UseFont = false;
            this.xrpPageNumber.StylePriority.UseTextAlignment = false;
            this.xrpPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText5
            // 
            this.xrRichText5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText5.ForeColor = System.Drawing.Color.White;
            this.xrRichText5.Location = new System.Drawing.Point(325, 35);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.Size = new System.Drawing.Size(364, 80);
            this.xrRichText5.StylePriority.UseFont = false;
            this.xrRichText5.StylePriority.UseForeColor = false;
            this.xrRichText5.StylePriority.UsePadding = false;
            // 
            // xrRichText4
            // 
            this.xrRichText4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText4.ForeColor = System.Drawing.Color.White;
            this.xrRichText4.Location = new System.Drawing.Point(0, 35);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.Size = new System.Drawing.Size(325, 80);
            this.xrRichText4.StylePriority.UseFont = false;
            this.xrRichText4.StylePriority.UseForeColor = false;
            this.xrRichText4.StylePriority.UsePadding = false;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.Location = new System.Drawing.Point(0, 35);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.Size = new System.Drawing.Size(689, 80);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // LimitLabourContract
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.grhEmployeeID,
            this.grfEmployeeID,
            this.PageHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(79, 59, 59, 16);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnapToGrid = false;
            this.Version = "9.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrtContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand grhEmployeeID;
        private DevExpress.XtraReports.UI.GroupFooterBand grfEmployeeID;
        private DevExpress.XtraReports.UI.XRRichText xrtContent;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrpPageNumber;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText4;
        private DevExpress.XtraReports.UI.XRRichText xrRichText5;
    }
}
