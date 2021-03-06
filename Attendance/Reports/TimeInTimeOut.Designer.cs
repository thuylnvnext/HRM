namespace Attendance.Reports
{
    partial class TimeInTimeOut
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
            this.grhDepartmentName = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrlDepartmentName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlFromDateToDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.grfDepartmentName = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlBreakIn = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlBreakOut = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 0;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
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
            // grhDepartmentName
            // 
            this.grhDepartmentName.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlDepartmentName,
            this.xrlFromDateToDate,
            this.xrlTitle,
            this.xrlCompanyName});
            this.grhDepartmentName.Height = 148;
            this.grhDepartmentName.Name = "grhDepartmentName";
            this.grhDepartmentName.RepeatEveryPage = true;
            this.grhDepartmentName.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.grhDepartmentName_BeforePrint);
            // 
            // xrlDepartmentName
            // 
            this.xrlDepartmentName.CanShrink = true;
            this.xrlDepartmentName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlDepartmentName.Location = new System.Drawing.Point(0, 123);
            this.xrlDepartmentName.Name = "xrlDepartmentName";
            this.xrlDepartmentName.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlDepartmentName.Size = new System.Drawing.Size(290, 25);
            this.xrlDepartmentName.StylePriority.UseFont = false;
            this.xrlDepartmentName.StylePriority.UsePadding = false;
            this.xrlDepartmentName.StylePriority.UseTextAlignment = false;
            this.xrlDepartmentName.Text = "Bộ phận: ";
            this.xrlDepartmentName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlFromDateToDate
            // 
            this.xrlFromDateToDate.CanShrink = true;
            this.xrlFromDateToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrlFromDateToDate.Location = new System.Drawing.Point(339, 98);
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
            this.xrlTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.xrlTitle.Location = new System.Drawing.Point(339, 58);
            this.xrlTitle.Name = "xrlTitle";
            this.xrlTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlTitle.Size = new System.Drawing.Size(442, 40);
            this.xrlTitle.StylePriority.UseFont = false;
            this.xrlTitle.StylePriority.UseForeColor = false;
            this.xrlTitle.StylePriority.UsePadding = false;
            this.xrlTitle.StylePriority.UseTextAlignment = false;
            this.xrlTitle.Text = "THỜI GIAN VÀO RA CHI TIẾT";
            this.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrlCompanyName
            // 
            this.xrlCompanyName.CanShrink = true;
            this.xrlCompanyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlCompanyName.Location = new System.Drawing.Point(0, 8);
            this.xrlCompanyName.Multiline = true;
            this.xrlCompanyName.Name = "xrlCompanyName";
            this.xrlCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrlCompanyName.Size = new System.Drawing.Size(776, 50);
            this.xrlCompanyName.StylePriority.UseFont = false;
            this.xrlCompanyName.StylePriority.UsePadding = false;
            this.xrlCompanyName.StylePriority.UseTextAlignment = false;
            this.xrlCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // grfDepartmentName
            // 
            this.grfDepartmentName.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20});
            this.grfDepartmentName.Height = 91;
            this.grfDepartmentName.Name = "grfDepartmentName";
            this.grfDepartmentName.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.Location = new System.Drawing.Point(0, 66);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel20.Size = new System.Drawing.Size(777, 25);
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "\tKế toán lương\t\t\tKế toán trưởng\t\tGiám đốc";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel20.Visible = false;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.BackColor = System.Drawing.Color.Transparent;
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel48,
            this.xrLabel47,
            this.xrLabel46,
            this.xrLabel45,
            this.xrLabel44,
            this.xrLabel43,
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel35,
            this.xrlBreakIn,
            this.xrlBreakOut});
            this.Detail1.Height = 25;
            this.Detail1.Name = "Detail1";
            this.Detail1.PrintOnEmptyDataSource = false;
            this.Detail1.StylePriority.UseBackColor = false;
            this.Detail1.Visible = false;
            // 
            // xrLabel48
            // 
            this.xrLabel48.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel48.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel48.Location = new System.Drawing.Point(580, 0);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel48.Size = new System.Drawing.Size(70, 25);
            this.xrLabel48.StylePriority.UseBorders = false;
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UsePadding = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel47
            // 
            this.xrLabel47.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel47.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel47.Location = new System.Drawing.Point(1050, 0);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel47.Size = new System.Drawing.Size(69, 25);
            this.xrLabel47.StylePriority.UseBorders = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UsePadding = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel46.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel46.Location = new System.Drawing.Point(1000, 0);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel46.Size = new System.Drawing.Size(50, 25);
            this.xrLabel46.StylePriority.UseBorders = false;
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UsePadding = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel45.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel45.Location = new System.Drawing.Point(950, 0);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel45.Size = new System.Drawing.Size(50, 25);
            this.xrLabel45.StylePriority.UseBorders = false;
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UsePadding = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel44
            // 
            this.xrLabel44.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel44.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel44.Location = new System.Drawing.Point(900, 0);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel44.Size = new System.Drawing.Size(50, 25);
            this.xrLabel44.StylePriority.UseBorders = false;
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UsePadding = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel43
            // 
            this.xrLabel43.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel43.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel43.Location = new System.Drawing.Point(800, 0);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel43.Size = new System.Drawing.Size(50, 25);
            this.xrLabel43.StylePriority.UseBorders = false;
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UsePadding = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel42.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel42.Location = new System.Drawing.Point(750, 0);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel42.Size = new System.Drawing.Size(50, 25);
            this.xrLabel42.StylePriority.UseBorders = false;
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UsePadding = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel41
            // 
            this.xrLabel41.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel41.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel41.Location = new System.Drawing.Point(850, 0);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel41.Size = new System.Drawing.Size(50, 25);
            this.xrLabel41.StylePriority.UseBorders = false;
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UsePadding = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel40
            // 
            this.xrLabel40.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel40.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel40.Location = new System.Drawing.Point(470, 0);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel40.Size = new System.Drawing.Size(110, 25);
            this.xrLabel40.StylePriority.UseBorders = false;
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UsePadding = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel39
            // 
            this.xrLabel39.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel39.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel39.Location = new System.Drawing.Point(360, 0);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel39.Size = new System.Drawing.Size(110, 25);
            this.xrLabel39.StylePriority.UseBorders = false;
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UsePadding = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel38.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel38.Location = new System.Drawing.Point(270, 0);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel38.Size = new System.Drawing.Size(90, 25);
            this.xrLabel38.StylePriority.UseBorders = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UsePadding = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel37
            // 
            this.xrLabel37.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel37.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel37.Location = new System.Drawing.Point(100, 0);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrLabel37.Size = new System.Drawing.Size(170, 25);
            this.xrLabel37.StylePriority.UseBorders = false;
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UsePadding = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel36
            // 
            this.xrLabel36.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel36.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel36.Location = new System.Drawing.Point(40, 0);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel36.Size = new System.Drawing.Size(60, 25);
            this.xrLabel36.StylePriority.UseBorders = false;
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UsePadding = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel35.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel35.Location = new System.Drawing.Point(0, 0);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel35.Size = new System.Drawing.Size(40, 25);
            this.xrLabel35.StylePriority.UseBorders = false;
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UsePadding = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlBreakIn
            // 
            this.xrlBreakIn.BackColor = System.Drawing.Color.Gold;
            this.xrlBreakIn.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrlBreakIn.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlBreakIn.Location = new System.Drawing.Point(700, 0);
            this.xrlBreakIn.Name = "xrlBreakIn";
            this.xrlBreakIn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlBreakIn.Size = new System.Drawing.Size(50, 25);
            this.xrlBreakIn.StylePriority.UseBackColor = false;
            this.xrlBreakIn.StylePriority.UseBorders = false;
            this.xrlBreakIn.StylePriority.UseFont = false;
            this.xrlBreakIn.StylePriority.UseTextAlignment = false;
            this.xrlBreakIn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlBreakOut
            // 
            this.xrlBreakOut.BackColor = System.Drawing.Color.Gold;
            this.xrlBreakOut.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrlBreakOut.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlBreakOut.Location = new System.Drawing.Point(650, 0);
            this.xrlBreakOut.Name = "xrlBreakOut";
            this.xrlBreakOut.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlBreakOut.Size = new System.Drawing.Size(50, 25);
            this.xrlBreakOut.StylePriority.UseBackColor = false;
            this.xrlBreakOut.StylePriority.UseBorders = false;
            this.xrlBreakOut.StylePriority.UseFont = false;
            this.xrlBreakOut.StylePriority.UseTextAlignment = false;
            this.xrlBreakOut.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrpPageNumber});
            this.BottomMargin.Height = 25;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // TimeInTimeOut
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.grhDepartmentName,
            this.grfDepartmentName,
            this.DetailReport,
            this.BottomMargin});
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnapToGrid = false;
            this.Version = "9.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TimeInTimeOut_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand grhDepartmentName;
        private DevExpress.XtraReports.UI.XRLabel xrlCompanyName;
        private DevExpress.XtraReports.UI.XRLabel xrlTitle;
        private DevExpress.XtraReports.UI.XRLabel xrlDepartmentName;
        private DevExpress.XtraReports.UI.XRLabel xrlFromDateToDate;
        private DevExpress.XtraReports.UI.GroupFooterBand grfDepartmentName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRPageInfo xrpPageNumber;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLabel xrlBreakOut;
        private DevExpress.XtraReports.UI.XRLabel xrlBreakIn;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLabel xrLabel43;
        private DevExpress.XtraReports.UI.XRLabel xrLabel42;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel38;
        private DevExpress.XtraReports.UI.XRLabel xrLabel37;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel48;
        private DevExpress.XtraReports.UI.XRLabel xrLabel47;
        private DevExpress.XtraReports.UI.XRLabel xrLabel46;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    }
}
