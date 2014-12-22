using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Database;
using Common;

namespace Personnel.Reports
{
    public partial class Resignation : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime fromDate, toDate, dateOfIssue;
        private string tabMan;

        public Resignation()
        {
            InitializeComponent();
        }

        public Resignation(DateTime fromDate, DateTime toDate, string tabMan, DateTime dateOfIssue)
        {
            InitializeComponent();
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.dateOfIssue = dateOfIssue;
            this.tabMan = tabMan;
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlCompanyName.Text = TitleTable.GetValue(CompanyTable.GetDefaultInfo().ID, Constant.language) + "\r\n" + TitleTable.GetValue("ADDRESS", Constant.language) + "\r\n" + TitleTable.GetValue("TEL", Constant.language);
            xrlTitle.Text = TitleTable.GetValue("Resignation.xrlTitle", Constant.language);
            xrlTitle.CanShrink = false;
            xrlFromDateToDate.Text = string.Format(TitleTable.GetValue("FromDateToDate", Constant.language), fromDate.ToString("dd/MM/yyyy"), toDate.ToString("dd/MM/yyyy"));
        }

        private void Resignation_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRSummary no = new XRSummary();
            no.Func = SummaryFunc.RecordNumber;
            no.Running = SummaryRunning.Report;
            xrlNo.Summary = no;

            xrlEmployeeCode.DataBindings.Add(new XRBinding("Text", null, "EmployeeCode"));
            xrlFirstName.DataBindings.Add(new XRBinding("Text", null, "FirstName"));
            xrlLastName.DataBindings.Add(new XRBinding("Text", null, "LastName"));
            xrlBirthDate.DataBindings.Add(new XRBinding("Text", null, "BirthDate", "{0:dd/MM/yyyy}"));
            xrlDepartmentName.DataBindings.Add(new XRBinding("Text", null, "DepartmentName"));
            xrlInitialDate.DataBindings.Add(new XRBinding("Text", null, "InitialDate", "{0:dd/MM/yyyy}"));
            xrlFromDate.DataBindings.Add(new XRBinding("Text", null, "FromDate", "{0:dd/MM/yyyy}"));
            xrlReasonName.DataBindings.Add(new XRBinding("Text", null, "ReasonName"));
            xrlNotes.DataBindings.Add(new XRBinding("Text", null, "Notes"));

            xrlDateOfIssue.Text = string.Format(TitleTable.GetValue("DayMonthYear", Constant.language), dateOfIssue.Day, dateOfIssue.Month, dateOfIssue.Year);
            xrlTabMan.Text = tabMan;
        }
    }
}
