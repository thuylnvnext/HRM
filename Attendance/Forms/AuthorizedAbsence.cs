using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;

namespace Attendance.Forms
{
    public partial class AuthorizedAbsence : Form, IShowData
    {
        private DepartmentTable department = new DepartmentTable();
        private Reports.ReportData.AuthorizedAbsenceDataTable authorizedAbsence = new Reports.ReportData.AuthorizedAbsenceDataTable();
        private bool change = false, preview = true;

        public void ShowData(string departmentIDList, bool check)
        {
            bgvAuthorizedAbsence.BeginDataUpdate();
            if (check)
                authorizedAbsence.GetListByDepartmentID(departmentIDList, dedFromDate.DateTime, dedToDate.DateTime, EmployeeTable.GetIDByCode(txtEmployeeCode.Text));
            else
                authorizedAbsence.DeleteByDepartmentID(departmentIDList);
            bgvAuthorizedAbsence.EndDataUpdate();
            bgvAuthorizedAbsence.ExpandAllGroups();
            bgvAuthorizedAbsence.BestFitColumns();
        }
        
        public AuthorizedAbsence()
        {
            InitializeComponent();
        }

        private void ConfigureReport()
        {
            Reports.AuthorizedAbsence _authorizedAbsence = new Reports.AuthorizedAbsence();
            _authorizedAbsence.SetDataSource((DataTable)authorizedAbsence);
            Report.SetTextObject(_authorizedAbsence, "AuthorizedAbsence");
            Report.SetParameters(_authorizedAbsence, new string[] { "@FromDate", "@ToDate", "@TabMan", "@DateOfIssue" }, new object[] { dedFromDate.DateTime, dedToDate.DateTime, txtTabMan.Text, dedDateOfIssue.DateTime });
            crvAuthorizedAbsence.ReportSource = _authorizedAbsence;
        }

        private void AuthorizedAbsence_Load(object sender, EventArgs e)
        {
            department.GetContent();
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.Name, dr.Name, 0));
            }
            grdAuthorizedAbsence.DataSource = authorizedAbsence;
            dedFromDate.EditValue = DateTime.Today;
            change = true;
            dedToDate.EditValue = DateTime.Today;
        }

        private void bgvAuthorizedAbsence_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData)
            {
                if (e.RowHandle > 0)
                {
                    if (e.RowHandle == bgvAuthorizedAbsence.GetDataRowHandleByGroupRowHandle(bgvAuthorizedAbsence.GetParentRowHandle(e.RowHandle)))
                        e.Value = 1;
                    else
                        e.Value = Convert.ToInt32(bgvAuthorizedAbsence.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (change)
            {
                authorizedAbsence.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == 0 || txtEmployeeCode.Text.Length == 4)
            {
                authorizedAbsence.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (preview)
            {
                grdAuthorizedAbsence.Visible = false;
                crvAuthorizedAbsence.Visible = true;
                ConfigureReport();
                btnPreview.Text = TitleTable.GetValue("CLOSE_REPORT", Constant.language);
                preview = false;
            }
            else
            {
                grdAuthorizedAbsence.Visible = true;
                crvAuthorizedAbsence.Visible = false;
                btnPreview.Text = TitleTable.GetValue("OPEN_REPORT", Constant.language);
                preview = true;
            }
        }
    }
}
