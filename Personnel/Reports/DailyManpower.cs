using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Database;
using Common;

namespace Personnel.Reports
{
    public partial class DailyManpower : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime workingDay, dateOfIssue;
        private string tabMan;

        public DailyManpower()
        {
            InitializeComponent();
        }

        public DailyManpower(DateTime workingDay, string tabMan, DateTime dateOfIssue)
        {
            InitializeComponent();
            this.workingDay = workingDay;
            this.dateOfIssue = dateOfIssue;
            this.tabMan = tabMan;
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlCompanyName.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language) + "\n" + TitleTable.GetValue("ADDRESS", Constant.language) + "\n" + TitleTable.GetValue("TEL", Constant.language);
            //xrlTitle.Text = TitleTable.GetValue("DailyManpower.xrlTitle", Constant.language);
            xrlTitle.CanShrink = false;
            xrlWorkingDay.Text = string.Format(TitleTable.GetValue("WORKINGDAY", Constant.language), workingDay.ToString("dd/MM/yyyy"));
        }

        private void DailyManpower_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRSummary no = new XRSummary();
            no.Func = SummaryFunc.RecordNumber;
            no.Running = SummaryRunning.Report;
            xrlNo.Summary = no;

            xrlDepartmentName.DataBindings.Add(new XRBinding("Text", null, "DepartmentName"));
            xrlTotal.DataBindings.Add(new XRBinding("Text", null, "Total"));
            xrlMaternityLeave.DataBindings.Add(new XRBinding("Text", null, "MaternityLeave"));
            xrlAuthorizedLeave.DataBindings.Add(new XRBinding("Text", null, "AuthorizedLeave"));
            xrlUnauthorizedLeave.DataBindings.Add(new XRBinding("Text", null, "UnauthorizedLeave"));
            CalculatedField calField = new CalculatedField();
            CalculatedFields.Add(calField);
            calField.DataSource = DataSource;
            calField.DataMember = DataMember;
            calField.FieldType = FieldType.Decimal;
            calField.Name = "TotalAbsence";
            calField.Expression = "Iif(IsNull([MaternityLeave]), 0, [MaternityLeave]) + Iif(IsNull([AuthorizedLeave]), 0, [AuthorizedLeave]) + Iif(IsNull([UnauthorizedLeave]), 0, [UnauthorizedLeave])";
            xrlTotalAbsence.DataBindings.Add(new XRBinding("Text", null, "TotalAbsence", "{0:#,##0.#;;}"));
            calField = new CalculatedField();
            CalculatedFields.Add(calField);
            calField.DataSource = DataSource;
            calField.DataMember = DataMember;
            calField.FieldType = FieldType.Decimal;
            calField.Name = "TotalWorking";
            calField.Expression = "Iif(IsNull([Total]), 0, [Total]) - Iif(IsNull([MaternityLeave]), 0, [MaternityLeave]) - Iif(IsNull([AuthorizedLeave]), 0, [AuthorizedLeave]) - Iif(IsNull([UnauthorizedLeave]), 0, [UnauthorizedLeave])";
            xrlTotalWorking.DataBindings.Add(new XRBinding("Text", null, "TotalWorking", "{0:#,##0.#;;}"));

            xrlGrandTotal.DataBindings.Add(new XRBinding("Text", null, "Total"));
            xrlTotalMaternityLeave.DataBindings.Add(new XRBinding("Text", null, "MaternityLeave"));
            xrlTotalUnauthorizedLeave.DataBindings.Add(new XRBinding("Text", null, "UnauthorizedLeave"));
            xrlTotalAuthorizedLeave.DataBindings.Add(new XRBinding("Text", null, "AuthorizedLeave"));
            xrlGrandTotalAbsence.DataBindings.Add(new XRBinding("Text", null, "TotalAbsence"));
            xrlGrandTotalWorking.DataBindings.Add(new XRBinding("Text", null, "TotalWorking"));
            XRSummary total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.Running = SummaryRunning.Report;
            xrlGrandTotal.Summary = total;
            total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.Running = SummaryRunning.Report;
            xrlTotalMaternityLeave.Summary = total;
            total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.Running = SummaryRunning.Report;
            xrlTotalUnauthorizedLeave.Summary = total;
            total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.Running = SummaryRunning.Report;
            xrlTotalAuthorizedLeave.Summary = total;
            total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.Running = SummaryRunning.Report;
            xrlGrandTotalAbsence.Summary = total;
            total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.Running = SummaryRunning.Report;
            xrlGrandTotalWorking.Summary = total;

            xrlDateOfIssue.Text = string.Format(TitleTable.GetValue("DayMonthYear", Constant.language) + "\nPrepared by", dateOfIssue.Day, dateOfIssue.Month, dateOfIssue.Year);
            xrlTabMan.Text = tabMan;
        }
    }
}
