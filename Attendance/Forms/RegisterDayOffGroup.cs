using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Common;
using DevExpress.XtraEditors; 

namespace Attendance.Forms
{
    public partial class RegisterDayOffGroup : XtraForm, IShowData
    {
        private EmployeeTable employee = new EmployeeTable();
        private RegisterDayOffGroupTable registerDayOffGroup = new RegisterDayOffGroupTable();
        private ArrayList checkedRows = new ArrayList();
        private string checkedItems = string.Empty;

        public RegisterDayOffGroup()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public void ShowData(string departmentIDList, bool check)
        {
            if (check)
                employee.GetListByDepartmentIDAndDuration(departmentIDList, DateTime.Today, checkedItems);
            else
                employee.DeleteByDepartmentID(departmentIDList);            
            foreach (EmployeeRow er in employee) er["Check"] = false;
            employee.AcceptChanges();
            grdEmployee.DataSource = employee;
            bgvEmployee.ExpandAllGroups();
            bgvEmployee.BestFitColumns();

            if (employee.Count == 0)
            {
                registerDayOffGroup.Clear();
                checkedRows.Clear();
            }
            else
                bgvEmployee.FocusedRowHandle = 0;
        }

        private void InitGroup()
        {
            DepartmentTable department = new DepartmentTable();
            department.GetContent();
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.Name, dr.Name, 0));
            }
        }

        private void InitLookUp()
        {
            DayOffGroupTable dayOffGroup = new DayOffGroupTable();
            dayOffGroup.GetContent();
            ileDayOffGroupID.DataSource = dayOffGroup;
            ileDayOffGroupID.ValueMember = "ID";
            ileDayOffGroupID.DisplayMember = "Name";
            ileDayOffGroupID.BestFit();
        }

        private void AddColumn()
        {
            employee.Columns.Add("Check", typeof(bool));
        }

        private void DeleteDayOffGroup()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_REGISTERDAYOFFGROUP", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (retVal == DialogResult.OK)
            {
                int[] selectedDayOffGroupRows = grvRegisterDayOffGroup.GetSelectedRows();
                DateTime fromDate;
                string absenceID;
                if (checkedRows.Count == 0) checkedRows.Add(bgvEmployee.GetFocusedRowCellValue("ID"));
                foreach (int i in selectedDayOffGroupRows)
                {
                    fromDate = Convert.ToDateTime(grvRegisterDayOffGroup.GetRowCellValue(i, "FromDate"));
                    absenceID = grvRegisterDayOffGroup.GetRowCellValue(i, "DayOffGroupID").ToString();
                    foreach (int employeeID in checkedRows)
                    {
                        RegisterDayOffGroupTable.DeleteValue(employeeID, fromDate, absenceID);
                    }
                    grvRegisterDayOffGroup.DeleteRow(i);
                }
                checkedRows.Clear();
            }
        }

        private void RegisterDayOffGroup_Load(object sender, EventArgs e)
        {
            InitGroup();
            InitLookUp();
            AddColumn();
            
            grdRegisterDayOffGroup.DataSource = registerDayOffGroup;
            ShowData(Constant.departmentIDList, true);
        }

        private void bgvEmployee_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                if (e.RowHandle > 0)
                {
                    if (bgvEmployee.GetRowCellValue(e.RowHandle - 1, "ID") != null && bgvEmployee.GetRowCellValue(e.RowHandle, "ID").ToString() == bgvEmployee.GetRowCellValue(e.RowHandle - 1, "ID").ToString())
                    {
                        e.Value = bgvEmployee.GetRowCellValue(e.RowHandle - 1, "No");
                    }
                    else
                    {
                        if (e.RowHandle == bgvEmployee.GetDataRowHandleByGroupRowHandle(bgvEmployee.GetParentRowHandle(e.RowHandle)))
                            e.Value = 1;
                        else
                            e.Value = Convert.ToInt32(bgvEmployee.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                    }
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void bgvEmployee_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Check" && e.Value != null && bgvEmployee.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                if ((bool)e.Value)
                    checkedRows.Add(bgvEmployee.GetRowCellValue(e.RowHandle, "ID"));
                else
                    checkedRows.Remove(bgvEmployee.GetRowCellValue(e.RowHandle, "ID"));
                string employeeIDList = string.Empty;

                foreach (int employeeID in checkedRows)
                {
                    employeeIDList += employeeIDList == string.Empty ? "[" + employeeID + "]" : ",[" + employeeID + "]";
                }
                registerDayOffGroup.GetListByEmployeeID(employeeIDList, checkedRows.Count);                
                grvRegisterDayOffGroup.BestFitColumns();
            }
        }

        private void grvRegisterDayOffGroup_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btnDelete.Enabled = (grvRegisterDayOffGroup.SelectedRowsCount != 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDayOffGroup();    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (checkedRows.Count == 0) checkedRows.Add(bgvEmployee.GetFocusedRowCellValue("ID"));
            foreach (RegisterDayOffGroupRow rar in registerDayOffGroup)
            {
                if (rar.RowState == DataRowState.Added)
                {
                    foreach (int employeeID in checkedRows)
                    {
                        success = registerDayOffGroup.InsertValue(employeeID, rar.FromDate, rar.ToDate, rar.DayOffGroupID);
                        if (!success) break;
                    }
                }
                if (!success) break;
                if (rar.RowState == DataRowState.Modified)
                {
                    foreach (int employeeID in checkedRows)
                    {
                        success = registerDayOffGroup.EditValue((DateTime)rar["FromDate", DataRowVersion.Original], rar["DayOffGroupID", DataRowVersion.Original].ToString(), employeeID, rar.FromDate, rar.ToDate, rar.DayOffGroupID);
                        if (!success) break;
                    }
                }
                if (!success) break;
            }
            if (success)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_REGISTERDAYOFFGROUP_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (EmployeeRow er in employee)
                {
                    er["Check"] = false;
                }
                bgvEmployee.Bands["grbCheck"].ImageIndex = 1;
                checkedRows.Clear();
                registerDayOffGroup.Clear();
            }
            else
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_REGISTERDAYOFFGROUP_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void grvRegisterDayOffGroup_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvRegisterDayOffGroup.SetRowCellValue(e.RowHandle, "EmployeeID", 0);
        }

        private void grvRegisterDayOffGroup_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ToDate" && e.CellValue != DBNull.Value && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
        }

        private void grvRegisterDayOffGroup_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (grvRegisterDayOffGroup.GetRowCellValue(e.RowHandle, "FromDate") == DBNull.Value)
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("FROMDATE_REGISTERDAYOFFGROUP_EXIST", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (grvRegisterDayOffGroup.GetRowCellValue(e.RowHandle, "DayOffGroupID") == DBNull.Value)
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PARAMETER_REGISTERDAYOFFGROUP_EXIST", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvRegisterDayOffGroup_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (grvRegisterDayOffGroup.FocusedColumn.FieldName == "FromDate")
            {
                if (e.Value == null)
                {
                    e.ErrorText = "'Từ ngày' không được rỗng";
                    e.Valid = false;
                }
            }
            if (grvRegisterDayOffGroup.FocusedColumn.FieldName == "ToDate")
            {
                if (e.Value != null && Convert.ToDateTime(e.Value) < Convert.ToDateTime(grvRegisterDayOffGroup.GetFocusedRowCellValue("FromDate")))
                {
                    e.ErrorText = "'Đến ngày' phải nhỏ hơn hoặc bằng 'Từ ngày'";
                    e.Valid = false;
                }
            }
        }

        private void grvRegisterDayOffGroup_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle) e.Value = e.RowHandle + 1;
        }

        private void bgvEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hitInfo;
            if (view == null) return;
            if ((e.Button & MouseButtons.Left) != 0)
            {
                hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                GridBand band = hitInfo.Band;
                if (band != null && hitInfo.InBandPanel)
                {
                    if (band.Name == "grbCheck" && bgvEmployee.RowCount > 0)
                    {
                        string employeeIDList = string.Empty;
                        checkedRows.Clear();
                        if (band.ImageIndex == 0)
                        {
                            foreach (EmployeeRow er in employee)
                            {
                                er["Check"] = false;
                            }
                            band.ImageIndex = 1;
                        }
                        else
                        {
                            foreach (EmployeeRow er in employee)
                            {
                                er["Check"] = true;
                                checkedRows.Add(er.ID);
                                employeeIDList += employeeIDList == string.Empty ? "[" + er.ID + "]" : ",[" + er.ID + "]";
                            }
                            band.ImageIndex = 0;
                        }
                        registerDayOffGroup.GetListByEmployeeID(employeeIDList, checkedRows.Count);
                        grdRegisterDayOffGroup.DataSource = registerDayOffGroup;
                        grvRegisterDayOffGroup.BestFitColumns();
                    }
                }
            }
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == Convert.ToInt32(ConstantTable.GetValueByName("CodeLength")) || txtEmployeeCode.Text.Length == 0)
            {
                employee.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bgvEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (employee.Count > 0 && checkedRows.Count == 0 && e.FocusedRowHandle >= 0)
            {
                registerDayOffGroup.GetListByEmployeeID("[" + bgvEmployee.GetFocusedRowCellValue("ID").ToString() + "]", 1);
                grvRegisterDayOffGroup.BestFitColumns();
            }
        }

        private void grvRegisterDayOffGroup_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate" && e.Value != DBNull.Value) grvRegisterDayOffGroup.SetRowCellValue(e.RowHandle, "ToDate", new DateTime(Convert.ToDateTime(e.Value).Year, 12, 31));
        }

        private void grvRegisterDayOffGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteDayOffGroup();
        }

        private void GroupCalendar_Click(object sender, EventArgs e)
        {
            new DayOff().ShowDialog();
        }
    }
}
