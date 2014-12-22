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
    public partial class ChangeDepartment : Form
    {
        public ChangeDepartment()
        {
            InitializeComponent();
        }

        private void ConfigureReport()
        {
            Reports.ChangeDepartment changeDepartment = new Personnel.Reports.ChangeDepartment();
            Reports.ReportData.ChangeDepartmentDataTable _changeDepartment = new Reports.ReportData.ChangeDepartmentDataTable();
            _changeDepartment.GetTotal(dedFromDate.DateTime, dedToDate.DateTime);
            changeDepartment.SetDataSource((DataTable)_changeDepartment);
            Report.SetTextObject(changeDepartment, "ChangeDepartment");
            Report.SetParameters(changeDepartment, new string[] { "@FromDate", "@ToDate", "@TabMan", "@DateOfIssue" }, new object[] { dedFromDate.DateTime, dedToDate.DateTime, txtTabMan.Text, dedDateOfIssue.DateTime });
            crvChangeDepartment.ReportSource = changeDepartment;
        }

        private void ChangeDepartment_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = DateTime.Today;
            dedToDate.DateTime = DateTime.Today;
            dedDateOfIssue.DateTime = DateTime.Today;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ConfigureReport();
        }
    }
}
