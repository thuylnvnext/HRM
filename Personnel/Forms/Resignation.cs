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
    public partial class Resignation : XtraForm
    {
        private string employeeIDList, departmentIDList, positionIDList;
        private ResignationTable resignation = new ResignationTable();
        private EmployeeInfo employeeInfo;

        public Resignation()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public Resignation(string employeeIDList, string departmentIDList, string positionIDList, EmployeeInfo employeeInfo)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeIDList = employeeIDList;
            this.departmentIDList = departmentIDList;
            this.positionIDList = positionIDList;
            this.employeeInfo = employeeInfo;
        }

        private void InitComboBox()
        {
            lueResignationReason.Properties.DataSource = ResignationReasonTable.GetContentTable();
            lueResignationReason.Properties.ValueMember = "ID";
            lueResignationReason.Properties.DisplayMember = "Name";

            lueResignationReason.EditValue = lueResignationReason.Properties.GetDataSourceValue(lueResignationReason.Properties.ValueMember, 0);
        }

        private void Resignation_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = DateTime.Today;
            dedToDate.EditValue = null;
            InitComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResignationRow rr;
            string[] employeeIDs = employeeIDList.Split(new char[] { ',' }), departmentIDs = departmentIDList.Split(new char[] { ',' }), positionIDs = positionIDList.Split(new char[] { ',' });
            for (int i = 0; i < employeeIDs.Length; i++)
            {
                rr = (ResignationRow)resignation.NewRow();
                rr.EmployeeID = Convert.ToInt32(employeeIDs[i].Substring(1, employeeIDs[i].Length - 2));
                rr.DepartmentID = departmentIDs[i].Substring(1, departmentIDs[i].Length - 2);
                rr.PositionID = positionIDs[i].Substring(1, positionIDs[i].Length - 2);
                rr.FromDate = dedFromDate.DateTime;
                rr.ToDate = dedToDate.EditValue == null ? Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")) : dedToDate.DateTime;
                rr.ResignationReasonID = lueResignationReason.EditValue.ToString();
                if (Utility.IsNumeric(txtAllowance.Text)) rr.Allowance = Convert.ToDecimal(txtAllowance.Text);
                if (Utility.IsNumeric(txtContractIndemnity.Text)) rr.ContractIndemnity = Convert.ToDecimal(txtContractIndemnity.Text);
                if (Utility.IsNumeric(txtOther.Text)) rr.Other = Convert.ToDecimal(txtOther.Text);
                rr.ReturnHealthIns = chkReturnHealthIns.Checked;
                rr.Notes = mmeNotes.Text;
                resignation.AddResignationRow(rr);
            }
            if (resignation.Insert())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_RESIGNATION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                employeeInfo.ShowData(Constant.departmentIDList, true);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_RESIGNATION_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}