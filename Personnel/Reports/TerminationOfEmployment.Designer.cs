namespace Personnel.Reports
{
    partial class TerminationOfEmployment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminationOfEmployment));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.grhEmployeeID = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlDecision = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrtContent = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.xrtContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 0;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // grhEmployeeID
            // 
            this.grhEmployeeID.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtContent,
            this.xrLabel2,
            this.xrLabel1,
            this.xrlDecision,
            this.xrlCompany,
            this.xrLabel3});
            this.grhEmployeeID.Height = 953;
            this.grhEmployeeID.Name = "grhEmployeeID";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.Location = new System.Drawing.Point(370, 745);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel3.Size = new System.Drawing.Size(360, 208);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "CÔNG TY TNHH CÔNG NGHỆ\r\nCHÍNH XÁC AMTEK (HÀ NỘI)\r\nGIÁM ĐỐC ĐIỀU HÀNH\r\n\r\n\r\n\r\n\r\n\r\n\r" +
                "\nCHOO AH LAM\r\n";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrlCompany
            // 
            this.xrlCompany.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrlCompany.CanShrink = true;
            this.xrlCompany.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlCompany.Location = new System.Drawing.Point(0, 0);
            this.xrlCompany.Multiline = true;
            this.xrlCompany.Name = "xrlCompany";
            this.xrlCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlCompany.Size = new System.Drawing.Size(350, 25);
            this.xrlCompany.StylePriority.UseBorderColor = false;
            this.xrlCompany.StylePriority.UseBorders = false;
            this.xrlCompany.StylePriority.UseFont = false;
            this.xrlCompany.StylePriority.UsePadding = false;
            this.xrlCompany.StylePriority.UseTextAlignment = false;
            this.xrlCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrlCompany.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrlCompany_BeforePrint);
            // 
            // xrlDecision
            // 
            this.xrlDecision.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrlDecision.CanShrink = true;
            this.xrlDecision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrlDecision.Location = new System.Drawing.Point(0, 25);
            this.xrlDecision.Multiline = true;
            this.xrlDecision.Name = "xrlDecision";
            this.xrlDecision.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlDecision.Size = new System.Drawing.Size(350, 25);
            this.xrlDecision.StylePriority.UseBorderColor = false;
            this.xrlDecision.StylePriority.UseBorders = false;
            this.xrlDecision.StylePriority.UseFont = false;
            this.xrlDecision.StylePriority.UsePadding = false;
            this.xrlDecision.StylePriority.UseTextAlignment = false;
            this.xrlDecision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrlDecision.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrlDecision_BeforePrint);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.Location = new System.Drawing.Point(413, 0);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(364, 50);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\r\nĐộc lập - Tự do - Hạnh phúc\r\n********";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.CanShrink = true;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.xrLabel2.Location = new System.Drawing.Point(48, 745);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(144, 82);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Nơi nhận: \r\n     -     Lưu VP\r\n     -     Nhân sự\r\n     -     Kế toán\r\n";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrtContent
            // 
            this.xrtContent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrtContent.Location = new System.Drawing.Point(48, 120);
            this.xrtContent.Name = "xrtContent";
            this.xrtContent.SerializableRtfString = resources.GetString("xrtContent.SerializableRtfString");
            this.xrtContent.Size = new System.Drawing.Size(682, 586);
            this.xrtContent.StylePriority.UseFont = false;
            this.xrtContent.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrtContent_BeforePrint);
            // 
            // TerminationOfEmployment
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageFooter,
            this.grhEmployeeID});
            this.Margins = new System.Drawing.Printing.Margins(25, 25, 75, 25);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnapToGrid = false;
            this.Version = "9.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrtContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand grhEmployeeID;
        private DevExpress.XtraReports.UI.XRRichText xrtContent;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrlDecision;
        private DevExpress.XtraReports.UI.XRLabel xrlCompany;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
