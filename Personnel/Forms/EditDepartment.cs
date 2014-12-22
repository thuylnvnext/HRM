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
    public partial class EditDepartment : XtraForm
    {
        private TreeNode selectedNode;
        private DepartmentTable department = new DepartmentTable();
        private DepartmentRow dr;

        public EditDepartment()
        {
            InitializeComponent();
        }

        public EditDepartment(TreeNode selectedNode)
        {
            InitializeComponent();
            this.selectedNode = selectedNode;
            Utility.SetSkin(this);
        }

        private void FillData()
        {
            dr = department.FindByPrimaryKey(selectedNode.Name);
            txtDepartmentID.Text = dr.ID;
            txtDepartmentName.Text = dr.Name;
            lueCompanyName.EditValue = dr.CompanyID;
            if (!dr.IsPhoneNull()) txtPhone.Text = dr.Phone;
            if (!dr.IsFaxNull()) txtFax.Text = dr.Fax;
            if (!dr.IsNotesNull()) txtNotes.Text = dr.Notes;
            chkActive.Checked = dr.Active;
            if (!dr.IsSortOrderNull()) txtSortOrder.Text = dr.SortOrder.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dr.ID = txtDepartmentID.Text;
            dr.Name = txtDepartmentName.Text;
            dr.CompanyID = lueCompanyName.EditValue.ToString();
            dr.Phone = txtPhone.Text;
            dr.Fax = txtFax.Text;
            dr.Notes = txtNotes.Text;
            dr.Active = chkActive.Checked;
            if (Utility.IsNumeric(txtSortOrder.Text)) dr.SortOrder = Convert.ToByte(txtSortOrder.Text);
            if (department.Update())
            {
                if (selectedNode.Text != txtDepartmentName.Text) selectedNode.Text = txtDepartmentName.Text;
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DEPARTMENT_EDIT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DEPARTMENT_EDIT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {
            lueCompanyName.Properties.DataSource = CompanyTable.GetContentTable();
            lueCompanyName.Properties.ValueMember = "ID";
            lueCompanyName.Properties.DisplayMember = "Name";
            department.GetContent();
            FillData();
        }

        private void txtDepartmentID_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtDepartmentID.Text != string.Empty && txtDepartmentID.Text != dr.ID);
        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtDepartmentName.Text != string.Empty && txtDepartmentName.Text != dr.Name);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtPhone.Text != dr.Phone);
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtFax.Text != dr.Fax);
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtNotes.Text != dr.Notes);
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (chkActive.Checked != dr.Active);
        }

        private void txtSortOrder_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtSortOrder.Text != dr.SortOrder.ToString());
        }
    }
}