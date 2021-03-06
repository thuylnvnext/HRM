using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using Database;
using Common;
using DevExpress.XtraCharts;

namespace Attendance.Reports
{
    public partial class DailyAttending : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime workingDay;
        private ViewType viewType;
        private int groupCount = 0, reportCount = 0, absent = 0;
        private string departmentName = string.Empty;

        public DailyAttending()
        {
            InitializeComponent();
        }

        public DailyAttending(DateTime workingDay, ViewType viewType)
        {
            InitializeComponent();
            this.workingDay = workingDay;
            this.viewType = viewType;
        }

        private XRLabel CreateLabel(Band band, Point location, Size size, string text, Font font, TextAlignment textAlignment)
        {
            XRLabel xrl = new XRLabel();
            xrl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrl.Size = size;
            xrl.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrl.Location = location;
            xrl.Borders = BorderSide.All;
            xrl.Multiline = true;
            xrl.Text = text;
            xrl.Font = font;
            xrl.TextAlignment = textAlignment;
            band.Controls.Add(xrl);

            return xrl;
        }

        private XRLabel CreateLabel(Band band, Point location, Size size, Font font, TextAlignment textAlignment, string fieldName)
        {
            XRLabel xrl = new XRLabel();
            xrl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrl.Size = size;
            xrl.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrl.Location = location;
            xrl.DataBindings.Add("Text", null, fieldName);
            xrl.Font = font;
            xrl.TextAlignment = textAlignment;
            band.Controls.Add(xrl);

            return xrl;
        }

        private void DailyAttending_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            grhDepartmentName.GroupFields.Add(new GroupField("DepartmentName", XRColumnSortOrder.Ascending));
            XRSummary no = new XRSummary();
            no.Func = SummaryFunc.RecordNumber;
            no.Running = SummaryRunning.Group;
            xrlNo.Summary = no;

            xrlEmployeeCode.DataBindings.Add(new XRBinding("Text", null, "EmployeeCode"));
            xrlFirstName.DataBindings.Add(new XRBinding("Text", null, "FirstName"));
            xrlLastName.DataBindings.Add(new XRBinding("Text", null, "LastName"));
            xrlShiftName.DataBindings.Add(new XRBinding("Text", null, "ShiftName", "{0:#,##0.#;;0}"));
            xrlAttending.DataBindings.Add(new XRBinding("Text", null, "Attending", "{0:#,##0.#;;0}"));

            xrlGroupCount.DataBindings.Add(new XRBinding("Text", null, "Attending"));
            XRSummary groupCount = new XRSummary();
            groupCount.Func = SummaryFunc.Custom;
            groupCount.FormatString = "{0:#,##0.#;;0}";
            groupCount.Running = SummaryRunning.Group;
            xrlGroupCount.Summary = groupCount;

            xrlReportCount.DataBindings.Add(new XRBinding("Text", null, "Attending"));
            XRSummary reportCount = new XRSummary();
            reportCount.Func = SummaryFunc.Custom;
            reportCount.FormatString = "{0:#,##0.#;;0}";
            reportCount.Running = SummaryRunning.Report;
            xrlReportCount.Summary = reportCount;

            xrcDailyAttending.Series[0].ChangeView(viewType);
            xrcDailyAttending.Series[1].ChangeView(viewType);
        }

        private void xrlAttending_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((bool)GetCurrentColumnValue("Attending"))
                xrlAttending.Text = "X";
            else
                xrlAttending.Text = string.Empty;
        }

        private void xrlGroupCount_SummaryReset(object sender, EventArgs e)
        {
            groupCount = 0;
            absent = 0;
            departmentName = string.Empty;
        }

        private void xrlGroupCount_SummaryRowChanged(object sender, EventArgs e)
        {
            if ((bool)GetCurrentColumnValue("Attending"))
                groupCount++;
            else
                absent++;
            departmentName = GetCurrentColumnValue("DepartmentName").ToString();
        }

        private void xrlGroupCount_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            xrcDailyAttending.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint(departmentName, groupCount));
            xrcDailyAttending.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint(departmentName, absent));
            e.Result = groupCount;
            e.Handled = true;
        }

        private void xrlReportCount_SummaryReset(object sender, EventArgs e)
        {
            reportCount = 0;
        }

        private void xrlReportCount_SummaryRowChanged(object sender, EventArgs e)
        {
            if ((bool)GetCurrentColumnValue("Attending")) reportCount++;
        }

        private void xrlReportCount_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = reportCount;
            e.Handled = true;
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlCompanyName.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language) + "\r\n" + TitleTable.GetValue("ADDRESS", Constant.language) + "\r\n" + TitleTable.GetValue("TEL", Constant.language);
            xrlTitle.Text = TitleTable.GetValue("DailyAttending.xrlTitle", Constant.language);
            xrlTitle.CanShrink = false;
            xrlWorkingDay.Text = string.Format(TitleTable.GetValue("WorkingDay", Constant.language), workingDay.ToString("dd/MM/yyyy"));
        }
    }
}
