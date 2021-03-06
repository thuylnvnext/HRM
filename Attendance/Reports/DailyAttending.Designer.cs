namespace Attendance.Reports
{
    partial class DailyAttending
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrlAttending = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlShiftName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlLastName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlFirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlEmployeeCode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrpPageNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.grhDepartmentName = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlDepartmentName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlWorkingDay = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.grfDepartmentName = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlGroupCount = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrcDailyAttending = new DevExpress.XtraReports.UI.XRChart();
            this.xrlReportCount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrcDailyAttending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlAttending,
            this.xrlShiftName,
            this.xrlLastName,
            this.xrlFirstName,
            this.xrlNo,
            this.xrlEmployeeCode});
            this.Detail.Height = 25;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrlAttending
            // 
            this.xrlAttending.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrlAttending.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlAttending.Location = new System.Drawing.Point(569, 0);
            this.xrlAttending.Name = "xrlAttending";
            this.xrlAttending.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlAttending.Size = new System.Drawing.Size(90, 25);
            this.xrlAttending.StylePriority.UseBorders = false;
            this.xrlAttending.StylePriority.UseFont = false;
            this.xrlAttending.StylePriority.UsePadding = false;
            this.xrlAttending.StylePriority.UseTextAlignment = false;
            this.xrlAttending.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrlAttending.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrlAttending_BeforePrint);
            // 
            // xrlShiftName
            // 
            this.xrlShiftName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrlShiftName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlShiftName.Location = new System.Drawing.Point(419, 0);
            this.xrlShiftName.Name = "xrlShiftName";
            this.xrlShiftName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrlShiftName.Size = new System.Drawing.Size(150, 25);
            this.xrlShiftName.StylePriority.UseBorders = false;
            this.xrlShiftName.StylePriority.UseFont = false;
            this.xrlShiftName.StylePriority.UsePadding = false;
            this.xrlShiftName.StylePriority.UseTextAlignment = false;
            this.xrlShiftName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlLastName
            // 
            this.xrlLastName.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrlLastName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlLastName.Location = new System.Drawing.Point(349, 0);
            this.xrlLastName.Name = "xrlLastName";
            this.xrlLastName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrlLastName.Size = new System.Drawing.Size(70, 25);
            this.xrlLastName.StylePriority.UseBorders = false;
            this.xrlLastName.StylePriority.UseFont = false;
            this.xrlLastName.StylePriority.UsePadding = false;
            this.xrlLastName.StylePriority.UseTextAlignment = false;
            this.xrlLastName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlFirstName
            // 
            this.xrlFirstName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrlFirstName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlFirstName.Location = new System.Drawing.Point(219, 0);
            this.xrlFirstName.Name = "xrlFirstName";
            this.xrlFirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrlFirstName.Size = new System.Drawing.Size(130, 25);
            this.xrlFirstName.StylePriority.UseBorders = false;
            this.xrlFirstName.StylePriority.UseFont = false;
            this.xrlFirstName.StylePriority.UsePadding = false;
            this.xrlFirstName.StylePriority.UseTextAlignment = false;
            this.xrlFirstName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlNo
            // 
            this.xrlNo.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrlNo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlNo.Location = new System.Drawing.Point(119, 0);
            this.xrlNo.Name = "xrlNo";
            this.xrlNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlNo.Size = new System.Drawing.Size(40, 25);
            this.xrlNo.StylePriority.UseBorders = false;
            this.xrlNo.StylePriority.UseFont = false;
            this.xrlNo.StylePriority.UsePadding = false;
            this.xrlNo.StylePriority.UseTextAlignment = false;
            this.xrlNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlEmployeeCode
            // 
            this.xrlEmployeeCode.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrlEmployeeCode.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrlEmployeeCode.Location = new System.Drawing.Point(159, 0);
            this.xrlEmployeeCode.Name = "xrlEmployeeCode";
            this.xrlEmployeeCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlEmployeeCode.Size = new System.Drawing.Size(60, 25);
            this.xrlEmployeeCode.StylePriority.UseBorders = false;
            this.xrlEmployeeCode.StylePriority.UseFont = false;
            this.xrlEmployeeCode.StylePriority.UsePadding = false;
            this.xrlEmployeeCode.StylePriority.UseTextAlignment = false;
            this.xrlEmployeeCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrpPageNumber
            // 
            this.xrpPageNumber.Location = new System.Drawing.Point(749, 0);
            this.xrpPageNumber.Name = "xrpPageNumber";
            this.xrpPageNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrpPageNumber.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
            this.xrpPageNumber.Size = new System.Drawing.Size(28, 23);
            this.xrpPageNumber.StylePriority.UseTextAlignment = false;
            this.xrpPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // grhDepartmentName
            // 
            this.grhDepartmentName.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrlDepartmentName});
            this.grhDepartmentName.Height = 60;
            this.grhDepartmentName.Name = "grhDepartmentName";
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xrLabel13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.Location = new System.Drawing.Point(569, 35);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel13.Size = new System.Drawing.Size(90, 25);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Đi làm";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.Location = new System.Drawing.Point(419, 35);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel8.Size = new System.Drawing.Size(150, 25);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Ca làm việc";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.Location = new System.Drawing.Point(219, 35);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel7.Size = new System.Drawing.Size(200, 25);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Họ và tên";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel6.BorderWidth = 1;
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.Location = new System.Drawing.Point(159, 35);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel6.Size = new System.Drawing.Size(60, 25);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Mã NV";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.Location = new System.Drawing.Point(119, 35);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel5.Size = new System.Drawing.Size(40, 25);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "STT";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlDepartmentName
            // 
            this.xrlDepartmentName.CanShrink = true;
            this.xrlDepartmentName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlDepartmentName.Location = new System.Drawing.Point(119, 0);
            this.xrlDepartmentName.Name = "xrlDepartmentName";
            this.xrlDepartmentName.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlDepartmentName.Size = new System.Drawing.Size(290, 35);
            this.xrlDepartmentName.StylePriority.UseFont = false;
            this.xrlDepartmentName.StylePriority.UsePadding = false;
            this.xrlDepartmentName.StylePriority.UseTextAlignment = false;
            this.xrlDepartmentName.Text = "Bộ phận: ";
            this.xrlDepartmentName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlWorkingDay
            // 
            this.xrlWorkingDay.CanShrink = true;
            this.xrlWorkingDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrlWorkingDay.Location = new System.Drawing.Point(169, 105);
            this.xrlWorkingDay.Name = "xrlWorkingDay";
            this.xrlWorkingDay.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlWorkingDay.Size = new System.Drawing.Size(442, 30);
            this.xrlWorkingDay.StylePriority.UseFont = false;
            this.xrlWorkingDay.StylePriority.UsePadding = false;
            this.xrlWorkingDay.StylePriority.UseTextAlignment = false;
            this.xrlWorkingDay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrlTitle
            // 
            this.xrlTitle.CanShrink = true;
            this.xrlTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.xrlTitle.Location = new System.Drawing.Point(169, 50);
            this.xrlTitle.Name = "xrlTitle";
            this.xrlTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrlTitle.Size = new System.Drawing.Size(442, 55);
            this.xrlTitle.StylePriority.UseFont = false;
            this.xrlTitle.StylePriority.UseForeColor = false;
            this.xrlTitle.StylePriority.UsePadding = false;
            this.xrlTitle.StylePriority.UseTextAlignment = false;
            this.xrlTitle.Text = "NHÂN VIÊN ĐI LÀM TRONG NGÀY";
            this.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrlCompanyName
            // 
            this.xrlCompanyName.CanShrink = true;
            this.xrlCompanyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlCompanyName.Location = new System.Drawing.Point(1, 0);
            this.xrlCompanyName.Multiline = true;
            this.xrlCompanyName.Name = "xrlCompanyName";
            this.xrlCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100F);
            this.xrlCompanyName.Size = new System.Drawing.Size(776, 50);
            this.xrlCompanyName.StylePriority.UseFont = false;
            this.xrlCompanyName.StylePriority.UsePadding = false;
            this.xrlCompanyName.StylePriority.UseTextAlignment = false;
            this.xrlCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grfDepartmentName
            // 
            this.grfDepartmentName.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18,
            this.xrlGroupCount});
            this.grfDepartmentName.Height = 41;
            this.grfDepartmentName.Name = "grfDepartmentName";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.Location = new System.Drawing.Point(119, 0);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 50, 0, 0, 100F);
            this.xrLabel18.Size = new System.Drawing.Size(450, 25);
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Số nhân viên đi làm:";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrlGroupCount
            // 
            this.xrlGroupCount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrlGroupCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlGroupCount.Location = new System.Drawing.Point(569, 0);
            this.xrlGroupCount.Name = "xrlGroupCount";
            this.xrlGroupCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrlGroupCount.Size = new System.Drawing.Size(90, 25);
            this.xrlGroupCount.StylePriority.UseBorders = false;
            this.xrlGroupCount.StylePriority.UseFont = false;
            this.xrlGroupCount.StylePriority.UsePadding = false;
            this.xrlGroupCount.StylePriority.UseTextAlignment = false;
            this.xrlGroupCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrlGroupCount.SummaryReset += new System.EventHandler(this.xrlGroupCount_SummaryReset);
            this.xrlGroupCount.SummaryRowChanged += new System.EventHandler(this.xrlGroupCount_SummaryRowChanged);
            this.xrlGroupCount.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrlGroupCount_SummaryGetResult);
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrcDailyAttending,
            this.xrlReportCount,
            this.xrLabel1});
            this.ReportFooter.Height = 400;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrcDailyAttending
            // 
            this.xrcDailyAttending.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrcDailyAttending.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.xrcDailyAttending.Diagram = xyDiagram1;
            this.xrcDailyAttending.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.xrcDailyAttending.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.xrcDailyAttending.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.xrcDailyAttending.Location = new System.Drawing.Point(0, 33);
            this.xrcDailyAttending.Name = "xrcDailyAttending";
            sideBySideBarSeriesLabel1.LineVisible = true;
            //sideBySideBarSeriesLabel1.OverlappingOptionsTypeName = "OverlappingOptions";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LegendText = "Số nhân viên đi làm";
            series1.Name = "Series 1";
            sideBySideBarSeriesLabel2.LineVisible = true;
            //sideBySideBarSeriesLabel2.OverlappingOptionsTypeName = "OverlappingOptions";
            series2.Label = sideBySideBarSeriesLabel2;
            series2.LegendText = "Số nhân viên không đi làm";
            series2.Name = "Series 2";
            this.xrcDailyAttending.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pie3DSeriesLabel1.LineVisible = true;
            //pie3DSeriesLabel1.OverlappingOptionsTypeName = "OverlappingOptions";
            this.xrcDailyAttending.SeriesTemplate.Label = pie3DSeriesLabel1;
            this.xrcDailyAttending.SeriesTemplate.View = pie3DSeriesView1;
            this.xrcDailyAttending.Size = new System.Drawing.Size(776, 367);
            // 
            // xrlReportCount
            // 
            this.xrlReportCount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrlReportCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrlReportCount.Location = new System.Drawing.Point(568, 0);
            this.xrlReportCount.Name = "xrlReportCount";
            this.xrlReportCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrlReportCount.Size = new System.Drawing.Size(90, 25);
            this.xrlReportCount.StylePriority.UseBorders = false;
            this.xrlReportCount.StylePriority.UseFont = false;
            this.xrlReportCount.StylePriority.UsePadding = false;
            this.xrlReportCount.StylePriority.UseTextAlignment = false;
            this.xrlReportCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrlReportCount.SummaryReset += new System.EventHandler(this.xrlReportCount_SummaryReset);
            this.xrlReportCount.SummaryRowChanged += new System.EventHandler(this.xrlReportCount_SummaryRowChanged);
            this.xrlReportCount.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrlReportCount_SummaryGetResult);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.Location = new System.Drawing.Point(118, 0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 50, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(450, 25);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Tổng số nhân viên đi làm:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrpPageNumber});
            this.BottomMargin.Height = 23;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlTitle,
            this.xrlWorkingDay,
            this.xrlCompanyName});
            this.ReportHeader.Height = 135;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportHeader_BeforePrint);
            // 
            // DailyAttending
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.grhDepartmentName,
            this.grfDepartmentName,
            this.ReportFooter,
            this.BottomMargin,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 23);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnapToGrid = false;
            this.Version = "9.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DailyAttending_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrcDailyAttending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand grhDepartmentName;
        private DevExpress.XtraReports.UI.XRLabel xrlCompanyName;
        private DevExpress.XtraReports.UI.XRLabel xrlTitle;
        private DevExpress.XtraReports.UI.XRLabel xrlDepartmentName;
        private DevExpress.XtraReports.UI.XRLabel xrlWorkingDay;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrlNo;
        private DevExpress.XtraReports.UI.XRLabel xrlEmployeeCode;
        private DevExpress.XtraReports.UI.GroupFooterBand grfDepartmentName;
        private DevExpress.XtraReports.UI.XRLabel xrlLastName;
        private DevExpress.XtraReports.UI.XRLabel xrlFirstName;
        private DevExpress.XtraReports.UI.XRLabel xrlShiftName;
        private DevExpress.XtraReports.UI.XRLabel xrlAttending;
        private DevExpress.XtraReports.UI.XRLabel xrlGroupCount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRPageInfo xrpPageNumber;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrlReportCount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRChart xrcDailyAttending;
    }
}
