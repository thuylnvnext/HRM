using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraEditors;

namespace Personnel.Forms
{
    public partial class TransferDepartmentByEmployee : XtraForm
    {
        private EmployeeTable employee;
        private string departmentID;

        public TransferDepartmentByEmployee()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public TransferDepartmentByEmployee(EmployeeTable employee, string departmentID)
        {
            InitializeComponent();
            this.employee = employee;
            this.departmentID = departmentID;
            Utility.SetSkin(this);
        }

        private void InitComboBox()
        {
            DepartmentTable department = new DepartmentTable();
            department.GetFullPath(Constant.currentUser.Name);
            lueCurrentDepartment.Properties.DataSource = department;
            lueCurrentDepartment.Properties.ValueMember = "ID";
            lueCurrentDepartment.Properties.DisplayMember = "FullPath";

            lueCurrentPosition.Properties.DataSource = PositionTable.GetContentTable(false);
            lueCurrentPosition.Properties.ValueMember = "ID";
            lueCurrentPosition.Properties.DisplayMember = "Name";

            lueNewDepartment.Properties.DataSource = department;
            lueNewDepartment.Properties.ValueMember = "ID";
            lueNewDepartment.Properties.DisplayMember = "Name";

            lueNewPosition.Properties.DataSource = PositionTable.GetContentTable(false);
            lueNewPosition.Properties.ValueMember = "ID";
            lueNewPosition.Properties.DisplayMember = "Name";
        }

        private void TransferDepartmentByEmployee_Load(object sender, EventArgs e)
        {
            InitComboBox();
            if (employee.Count == 1)
            {
                lueCurrentDepartment.EditValue = employee[0]["DepartmentID"].ToString();
                dedCurrentDate.EditValue = employee[0]["FromDate"];
                if (employee[0]["PositionID"].ToString() != string.Empty)
                {
                    lueCurrentPosition.EditValue = employee[0]["PositionID"].ToString();
                    lueNewPosition.EditValue = employee[0]["PositionID"].ToString();
                }
                else
                    lueCurrentPosition.EditValue = null;
            }
            else
                lueNewPosition.EditValue = employee[0]["PositionID"].ToString();
            lueNewDepartment.EditValue = departmentID;
            dedNewDate.DateTime = DateTime.Today;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            EmployeeDepartmentTable employeeDepartment = new EmployeeDepartmentTable();
            EmployeeDepartmentRow edr, _edr;
            employeeDepartment.GetContent();
            foreach (EmployeeRow er in employee)
            {
                edr = employeeDepartment.GetMaxDuration(er.ID);
                _edr = employeeDepartment.FindByPrimaryKey(er.ID, edr.FromDate);
                _edr.ToDate = dedNewDate.DateTime.AddDays(-1);
                _edr = (EmployeeDepartmentRow)employeeDepartment.NewRow();
                _edr.EmployeeID = er.ID;
                _edr.FromDate = dedNewDate.DateTime;
                _edr.ToDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
                _edr.DepartmentID = lueNewDepartment.EditValue.ToString();
                employeeDepartment.AddEmployeeDepartmentRow(_edr);
            }
            retVal1 = employeeDepartment.Insert();
            retVal2 = employeeDepartment.Update();            
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("TRANSFER_DEPARTMENT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("UPDATE_EMPLOYEE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) new Common.Forms.SetTitle(sender, Name).ShowDialog();
        }
    }
}