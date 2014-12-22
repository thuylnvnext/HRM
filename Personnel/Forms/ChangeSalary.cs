using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Personnel.Forms
{
    public partial class ChangeSalary : Form
    {
        public ChangeSalary()
        {
            InitializeComponent();
        }

        private void ConfigureReport()
        {
            Reports.ChangeSalary changeSalary = new Personnel.Reports.ChangeSalary();
            Reports.ReportData.ChangeSalaryDataTable _changeSalary = new Personnel.Reports.ReportData.ChangeSalaryDataTable();
            _changeSalary.GetList(dedFromDate.DateTime, dedToDate.DateTime);
            changeSalary.SetDataSource((DataTable)_changeSalary);
            Report.SetTextObject(changeSalary, "ChangeSalary");
            Report.SetParameters(changeSalary, new string[] { "@FromDate", "@ToDate", "@TabMan", "@DateOfIssue", "@PersonnelManager", "@Director" }, new object[] { dedFromDate.DateTime, dedToDate.DateTime, txtTabMan.Text, dedDateOfIssue.DateTime, txtPersonnelManager.Text, txtDirector.Text });
            crvChangeSalary.ReportSource = changeSalary;
        }

        private void ChangeSalary_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dedToDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            dedDateOfIssue.DateTime = DateTime.Today;
            txtTabMan.Text = "Nguyễn Thị Thu Hằng";
            txtPersonnelManager.Text = "Trần Thị Thúy Nga";
            txtDirector.Text = "Lee Young Bae";
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            ConfigureReport();
        }
    }
}
