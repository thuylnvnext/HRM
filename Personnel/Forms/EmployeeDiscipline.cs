using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Personnel.Forms
{
    public partial class EmployeeDiscipline : Form
    {
        public EmployeeDiscipline()
        {
            InitializeComponent();
        }

        private void ConfigureReport()
        {
            Reports.EmployeeDiscipline employeeDiscipline = new Personnel.Reports.EmployeeDiscipline();
            Reports.ReportData.EmployeeDisciplineDataTable _employeeDiscipline = new Reports.ReportData.EmployeeDisciplineDataTable();
            _employeeDiscipline.GetTotal(dedFromDate.DateTime, dedToDate.DateTime);
            employeeDiscipline.SetDataSource((DataTable)_employeeDiscipline);
            Report.SetTextObject(employeeDiscipline, "EmployeeDiscipline");
            Report.SetParameters(employeeDiscipline, new string[] { "@FromDate", "@ToDate", "@TabMan", "@DateOfIssue" }, new object[] { dedFromDate.DateTime, dedToDate.DateTime, txtTabMan.Text, dedDateOfIssue.DateTime });
            crvEmployeeDiscipline.ReportSource = employeeDiscipline;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ConfigureReport();
        }

        private void EmployeeDiscipline_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;
            dedFromDate.DateTime = DateTime.Today;
            dedToDate.DateTime = DateTime.Today;
            dedDateOfIssue.DateTime = DateTime.Today;
        }
    }
}
