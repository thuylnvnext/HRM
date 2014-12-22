using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Common;
using DevExpress.XtraEditors;

namespace Personnel.Forms
{
    public partial class TransferDepartment : XtraForm
    {
        private EmployeeTable availableEmployee = new EmployeeTable();
        private EmployeeTable selectedEmployee = new EmployeeTable();
        private int availableCheckedItems = 0, selectedCheckedItems = 0;
        private bool init;

        public TransferDepartment()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddColumn()
        {
            availableEmployee.Columns.Add("Check", typeof(bool));
            selectedEmployee.Columns.Add("Check", typeof(bool));
        }

        private void InitComboBox()
        {
            init = false;
            DepartmentTable department = new DepartmentTable();
            department.GetFullPath(Constant.currentUser.Name);
            lueFrom.Properties.DataSource = department;
            lueFrom.Properties.ValueMember = "ID";
            lueFrom.Properties.DisplayMember = "FullPath";
            init = true;
            if (Constant.departmentIDList != string.Empty)
                lueFrom.EditValue = Constant.departmentIDList.Substring(1, Constant.departmentIDList.Length - 2);
            else
                lueFrom.EditValue = null;

            lueTo.Properties.DataSource = department;
            lueTo.Properties.ValueMember = "ID";
            lueTo.Properties.DisplayMember = "FullPath";            
        }

        private void ShowAvailableEmployee()
        {
            if (lueFrom.EditValue != null)
            {
                availableEmployee.Clear();
                availableEmployee.GetListByDepartmentID("[" + lueFrom.EditValue.ToString() + "]", DateTime.Today, 0, Constant.currentUser.Name);
            }
            else
            {
                availableEmployee.Clear();
                availableEmployee.GetListByDepartmentID(string.Empty, DateTime.Today, 0, Constant.currentUser.Name);
            }
            foreach (EmployeeRow er in availableEmployee)
            {
                er["Check"] = false;
            }
            availableEmployee.AcceptChanges();
            grdAvailableEmployee.DataSource = availableEmployee;
            bgvAvailableEmployee.BestFitColumns();
            bgvAvailableEmployee.Bands["grbCheck"].ImageIndex = 1;
            btnForward.Enabled = false;
            btnBackward.Enabled = false;
        }

        private void AddSelectedEmployee()
        {
            foreach (EmployeeRow er in availableEmployee)
            {
                if (er.RowState != DataRowState.Deleted)
                {
                    if (Convert.ToBoolean(er["Check"]))
                    {
                        EmployeeRow _er = (EmployeeRow)selectedEmployee.NewRow();
                        _er.ID = er.ID;
                        _er.FullName = er.FullName;
                        _er["Check"] = false;
                        _er["Type"] = er.Type;
                        selectedEmployee.AddEmployeeRow(_er);
                        er.Delete();
                        availableCheckedItems -= 1;
                    }
                }
            }
            selectedEmployee.AcceptChanges();
            if (availableCheckedItems == 0) bgvAvailableEmployee.Bands["grbCheck"].ImageIndex = 1;
            bgvSelectedEmployee.BestFitColumns();
            btnForward.Enabled = false;
            btnOK.Enabled = (selectedEmployee.Count > 0 && lueTo.EditValue != null);
        }

        private void AddSelectedEmployee(EmployeeRow er)
        {
            EmployeeRow _er = (EmployeeRow)selectedEmployee.NewRow();
            _er.ID = er.ID;
            _er.FullName = er.FullName;
            _er["Check"] = false;
            _er["Type"] = er.Type;
            selectedEmployee.AddEmployeeRow(_er);
            er.Delete();

            selectedEmployee.AcceptChanges();
            bgvSelectedEmployee.BestFitColumns();
            btnOK.Enabled = (selectedEmployee.Count > 0 && lueTo.EditValue != null);
        }

        private void UndoAvailableEmployee()
        {
            foreach (EmployeeRow er in selectedEmployee.Rows)
            {
                if (Convert.ToBoolean(er["Check"]))
                {
                    for (int r = 0; r < availableEmployee.Count; r++)
                    {
                        if (availableEmployee[r].RowState == DataRowState.Deleted)
                        {
                            availableEmployee[r].RejectChanges();
                            if (Convert.ToInt32(availableEmployee[r]["ID"]) != er.ID) availableEmployee[r].Delete();
                        }
                    }
                    er.Delete();
                    selectedCheckedItems -= 1;
                }
            }
            if (selectedCheckedItems == 0) bgvSelectedEmployee.Bands["grbSelectedCheck"].ImageIndex = 1;
            selectedEmployee.AcceptChanges();
            btnBackward.Enabled = false;
            btnOK.Enabled = selectedEmployee.Count > 0;
        }

        private void UndoAvailableEmployee(EmployeeRow er)
        {
            for (int r = 0; r < availableEmployee.Count; r++)
            {
                if (availableEmployee[r].RowState == DataRowState.Deleted)
                {
                    availableEmployee[r].RejectChanges();
                    if (Convert.ToInt32(availableEmployee[r]["ID"]) != er.ID) availableEmployee[r].Delete();
                }
            }
            er.Delete();
            selectedEmployee.AcceptChanges();
            btnOK.Enabled = selectedEmployee.Count > 0;
        }
        private void TransferDepartment_Load(object sender, EventArgs e)
        {
            AddColumn();
            InitComboBox();

            grdSelectedEmployee.DataSource = selectedEmployee;
            bgvSelectedEmployee.BestFitColumns();

            dedFromDate.DateTime = DateTime.Today;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            AddSelectedEmployee();
        }

        private void bgvAvailableEmployee_MouseDown(object sender, MouseEventArgs e)
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
                    if (band.Name == "grbCheck" && bgvAvailableEmployee.RowCount > 0)
                    {
                        if (band.ImageIndex == 0)
                        {
                            foreach (EmployeeRow er in availableEmployee)
                            {
                                if (er.RowState != DataRowState.Deleted)
                                {
                                    er["Check"] = false;
                                    availableCheckedItems -= 1;
                                }
                            }                            
                            band.ImageIndex = 1;
                            btnForward.Enabled = false;
                        }
                        else
                        {
                            foreach (EmployeeRow er in availableEmployee)
                            {
                                if (er.RowState != DataRowState.Deleted)
                                {
                                    er["Check"] = true;
                                    availableCheckedItems += 1;
                                }
                            }                            
                            band.ImageIndex = 0;
                            btnForward.Enabled = true;
                        }
                    }
                }
            }
            if (e.Clicks == 2 && ((e.Button & MouseButtons.Left) != 0))
            {
                hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                if (hitInfo.InRow)
                {
                    AddSelectedEmployee(availableEmployee.FindByPrimaryKey(Convert.ToInt32(bgvAvailableEmployee.GetFocusedRowCellValue("ID"))));
                }
            }
        }

        private void bgvAvailableEmployee_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void bgvAvailableEmployee_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Check")
            {
                if (Convert.ToBoolean(e.Value))
                {
                    EmployeeRow er = availableEmployee.FindByPrimaryKey(Convert.ToInt32(bgvAvailableEmployee.GetFocusedRowCellValue("ID")));
                    er["Check"] = true;
                    availableCheckedItems += 1;
                }
                else
                {
                    EmployeeRow er = availableEmployee.FindByPrimaryKey(Convert.ToInt32(bgvAvailableEmployee.GetFocusedRowCellValue("ID")));
                    er["Check"] = false;
                    availableCheckedItems -= 1;
                }
                btnForward.Enabled = (availableCheckedItems > 0);
            }
        }

        private void bgvSelectedEmployee_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            UndoAvailableEmployee();
        }

        private void bgvSelectedEmployee_MouseDown(object sender, MouseEventArgs e)
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
                    if (band.Name == "grbSelectedCheck" && bgvSelectedEmployee.RowCount > 0)
                    {
                        if (band.ImageIndex == 0)
                        {
                            foreach (EmployeeRow er in selectedEmployee)
                            {
                                if (er.RowState != DataRowState.Deleted)
                                {
                                    er["Check"] = false;
                                    selectedCheckedItems -= 1;
                                }
                            }                            
                            band.ImageIndex = 1;
                            btnBackward.Enabled = false;
                        }
                        else
                        {
                            foreach (EmployeeRow er in selectedEmployee)
                            {
                                if (er.RowState != DataRowState.Deleted)
                                {
                                    er["Check"] = true;
                                    selectedCheckedItems += 1;
                                }
                            }                            
                            band.ImageIndex = 0;
                            btnBackward.Enabled = true;
                        }
                    }
                }
            }
            if (e.Clicks == 2 && ((e.Button & MouseButtons.Left) != 0))
            {
                hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                if (hitInfo.InRow)
                {
                    UndoAvailableEmployee(selectedEmployee.FindByPrimaryKey(Convert.ToInt32(bgvSelectedEmployee.GetFocusedRowCellValue("ID"))));
                }
            }
        }

        private void bgvSelectedEmployee_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Check")
            {
                if (Convert.ToBoolean(e.Value))
                {
                    EmployeeRow er = selectedEmployee.FindByPrimaryKey(Convert.ToInt32(bgvSelectedEmployee.GetFocusedRowCellValue("ID")));
                    er["Check"] = true;
                    selectedCheckedItems += 1;
                }
                else
                {
                    EmployeeRow er = selectedEmployee.FindByPrimaryKey(Convert.ToInt32(bgvSelectedEmployee.GetFocusedRowCellValue("ID")));
                    er["Check"] = false;
                    selectedCheckedItems -= 1;
                }
                btnBackward.Enabled = (selectedCheckedItems > 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool retVal1 = false, retVal2 = false;
            EmployeeDepartmentTable employeeDepartment = new EmployeeDepartmentTable();
            EmployeeDepartmentRow edr, _edr;
            foreach (EmployeeRow er in selectedEmployee.Rows)
            {
                edr = employeeDepartment.GetMaxDuration(er.ID);
                edr.ToDate = dedFromDate.DateTime.AddDays(-1);
                retVal1 = employeeDepartment.Update();
                if (!retVal1) break;
                _edr = (EmployeeDepartmentRow)employeeDepartment.NewRow();
                _edr.EmployeeID = er.ID;
                _edr.FromDate = dedFromDate.DateTime;
                _edr.ToDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
                _edr.DepartmentID = lueTo.EditValue.ToString();
                employeeDepartment.AddEmployeeDepartmentRow(_edr);
                retVal2 = employeeDepartment.Insert();
                if (!retVal2) break;
            }
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("TRANSFER_DEPARTMENT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("UPDATE_EMPLOYEE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }       

        private void lueTo_EditValueChanged(object sender, EventArgs e)
        {
            if (lueTo.EditValue != null && lueFrom.EditValue != null)
            {
                if (lueTo.EditValue.ToString() == lueFrom.EditValue.ToString())
                {
                    if (init) XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DUPLICATION_DEPARTMENT", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lueTo.EditValue = null;
                    if (btnOK.Enabled) btnOK.Enabled = false;
                }
                else
                    if (bgvSelectedEmployee.RowCount > 0) btnOK.Enabled = true;
            }
        }

        private void lueFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (init) ShowAvailableEmployee();
        }
    }
}