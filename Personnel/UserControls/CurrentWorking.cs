using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using Common;
using DevExpress.XtraEditors;

namespace Personnel.UserControls
{
    public partial class CurrentWorking : XtraUserControl
    {
        private int employeeID = 0;
        private Forms.EmployeeInfo parentForm;
        private EmployeeDepartmentTable employeeDepartment = new EmployeeDepartmentTable();
        private EmployeePositionTable employeePosition = new EmployeePositionTable();
        private WorkingInitializationTable workingInitialization = new WorkingInitializationTable();

        public CurrentWorking()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public CurrentWorking(int employeeID, Forms.EmployeeInfo parentForm)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeID = employeeID;
            this.parentForm = parentForm;
        }

        private void DeleteEmployeeDepartment()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_INFODETAILS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                grvEmployeeDepartment.DeleteRow(grvEmployeeDepartment.FocusedRowHandle);
                employeeDepartment.Delete();
            }
        }

        private void DeleteEmployeePosition()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_INFODETAILS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                grvEmployeeDepartment.DeleteRow(grvEmployeePosition.FocusedRowHandle);
                employeePosition.Delete();
            }
        }

        private void InitDate()
        {
            dedInitialDate.EditValue = null;
            dedSigningDate.EditValue = null;
        }

        private void InitLookUp()
        {
            DepartmentTable department = new DepartmentTable();
            department.GetFullPath(Constant.currentUser.Name);
            ileDepartment.DataSource = department;
            ileDepartment.ValueMember = "ID";
            ileDepartment.DisplayMember = "FullPath";
            ileDepartment.BestFit();
            ilePosition.DataSource = PositionTable.GetContentTable(false);
            ilePosition.ValueMember = "ID";
            ilePosition.DisplayMember = "Name";
            ilePosition.BestFit();
            ileJob.DataSource = JobTable.GetContentTable(false);
            ileJob.ValueMember = "ID";
            ileJob.DisplayMember = "Name";
            ileJob.BestFit();
        }

        private void FillData()
        {
            employeeDepartment.GetListByEmployeeID(employeeID);
            grdEmployeeDepartment.DataSource = employeeDepartment;
            grvEmployeeDepartment.BestFitColumns();

            employeePosition.GetListByEmployeeID(employeeID);
            grdEmployeePosition.DataSource = employeePosition;
            grvEmployeePosition.BestFitColumns();

            workingInitialization.GetListByEmployeeID(employeeID);
            if (workingInitialization.Count == 1)
            {
                WorkingInitializationRow wir = workingInitialization[0];
                if (!wir.IsInitialDateNull()) dedInitialDate.DateTime = wir.InitialDate;
                if (!wir.IsSigningDateNull()) dedSigningDate.DateTime = wir.SigningDate;
                if (!wir.IsBySourceNull()) txtBySource.Text = wir.BySource;
                if (!wir.IsPresentPersonNull()) txtPresentPerson.Text = wir.PresentPerson;
                if (!wir.IsInterviewerNull()) txtInterviewer.Text = wir.Interviewer;
                if (!wir.IsRecruitingOfficerNull()) txtRecruitingOfficer.Text = wir.RecruitingOfficer;
                if (!wir.IsHasHealthInsNull()) chkHasHealthIns.Checked = wir.HasHealthIns;
            }
        }

        private void CurrentWorking_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;
            
            InitDate();
            InitLookUp();            
            FillData();
        }

        private void btnSaveEmployeeDepartment_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            grvEmployeeDepartment.UpdateCurrentRow();
            retVal1 = employeeDepartment.Insert();
            retVal2 = employeeDepartment.Update();
            if (retVal1 && retVal2)
            {
                parentForm.ShowData(Constant.departmentIDList, true);
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void grvCurrentWorking_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnSaveInitialInfo_Click(object sender, EventArgs e)
        {
            if (workingInitialization.Count == 1)
            {
                WorkingInitializationRow wir = workingInitialization[0];
                if (dedInitialDate.EditValue != null) wir.InitialDate = dedInitialDate.DateTime;
                if (dedSigningDate.EditValue != null) wir.SigningDate = dedSigningDate.DateTime;
                wir.BySource = txtBySource.Text;
                wir.PresentPerson = txtPresentPerson.Text;
                wir.Interviewer = txtInterviewer.Text;
                wir.RecruitingOfficer = txtRecruitingOfficer.Text;
                wir.HasHealthIns = chkHasHealthIns.Checked;
                if (workingInitialization.Update())
                {
                    parentForm.ShowData(Constant.departmentIDList, true);
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_WORKINGINITIALIZATION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_WORKINGINITIALIZATION_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WorkingInitializationRow wir = (WorkingInitializationRow)workingInitialization.NewRow();
                wir.EmployeeID = employeeID;
                if (dedInitialDate.EditValue != null) wir.InitialDate = dedInitialDate.DateTime;
                if (dedSigningDate.EditValue != null) wir.SigningDate = dedSigningDate.DateTime;
                wir.BySource = txtBySource.Text;
                wir.PresentPerson = txtPresentPerson.Text;
                wir.Interviewer = txtInterviewer.Text;
                wir.RecruitingOfficer = txtRecruitingOfficer.Text;
                wir.HasHealthIns = chkHasHealthIns.Checked;
                workingInitialization.AddWorkingInitializationRow(wir);
                if (workingInitialization.Insert())
                {
                    parentForm.ShowData(Constant.departmentIDList, true);
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_WORKINGINITIALIZATION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_WORKINGINITIALIZATION_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvCurrentWorking_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ToDate" && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
        }

        private void btnDeleteEmployeeDepartment_Click(object sender, EventArgs e)
        {
            DeleteEmployeeDepartment();
        }

        private void grvCurrentWorking_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            (sender as GridView).SetRowCellValue(e.RowHandle, "EmployeeID", employeeID);
            (sender as GridView).SetRowCellValue(e.RowHandle, "ToDate", new DateTime(9999, 12, 31));
        }

        private void grvCurrentWorking_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == 0 && e.Column.FieldName == "FromDate") dedInitialDate.EditValue = e.Value;
        }

        private void grvCurrentWorking_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (((DataRowView)e.Row)["FromDate"] == DBNull.Value)
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("FROMDATE_INFODETAILS_EXIST", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void grvCurrentWorking_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((sender as GridView).FocusedColumn.FieldName == "FromDate")
            {
                if (e.Value == null)
                {
                    e.ErrorText = "'Từ ngày' không được rỗng";
                    e.Valid = false;
                }
            }
            if ((sender as GridView).FocusedColumn.FieldName == "ToDate")
            {
                if (e.Value != null && Convert.ToDateTime(e.Value) < Convert.ToDateTime((sender as GridView).GetFocusedRowCellValue("FromDate")))
                {
                    e.ErrorText = "'Đến ngày' phải nhỏ hơn hoặc bằng 'Từ ngày'";
                    e.Valid = false;
                }
            }
        }

        private void grvCurrentWorking_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int r;
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                r = (sender as GridView).RowCount - 2;
            else
                r = e.RowHandle - 1;
            if (r > -1)
            {
                DataRowView dr = (DataRowView)e.Row;
                (sender as GridView).SetRowCellValue(r, "ToDate", Convert.ToDateTime(dr["FromDate"]).AddDays(-1));
            }
            if ((sender as GridView).GetFocusedRowCellValue("ToDate") == DBNull.Value) (sender as GridView).SetRowCellValue(e.RowHandle, "ToDate", new DateTime(9999, 12, 31));
        }

        private void btnSaveEmployeePosition_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            grvEmployeePosition.UpdateCurrentRow();
            retVal1 = employeePosition.Insert();
            retVal2 = employeePosition.Update();
            if (retVal1 && retVal2)
            {
                parentForm.ShowData(Constant.departmentIDList, true);
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteEmployeePosition_Click(object sender, EventArgs e)
        {
            DeleteEmployeePosition();
        }
    }
}
