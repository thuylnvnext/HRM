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
    public partial class AddDepartment : XtraForm
    {
        private TreeNode parentNode;
        private DepartmentTable department;
        private UserGroupTable userGroup = new UserGroupTable();
        private RightOfGroupTable rightOfGroup = new RightOfGroupTable();

        public AddDepartment()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public AddDepartment(TreeNode parentNode, DepartmentTable department)
        {
            InitializeComponent();            
            this.parentNode = parentNode;
            this.department = department;
            Utility.SetSkin(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            department.AddDepartmentRow(parentNode.Parent == null ? string.Empty : parentNode.Name, txtDepartmentID.Text, txtDepartmentName.Text, lueCompanyName.EditValue.ToString(), txtPhone.Text, txtFax.Text, txtNotes.Text, Utility.IsNumeric(txtSortOrder.Text) ? Convert.ToByte(txtSortOrder.Text) : Convert.ToByte(0), chkActive.Checked);
            if (department.Insert())
            {
                parentNode.Nodes.Add(txtDepartmentID.Text, txtDepartmentName.Text, 1, 1);
                string[] checkedItems = ccbUserGroup.Properties.GetCheckedItems().ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in checkedItems)
                {
                    rightOfGroup.AddRightOfGroupRow(Convert.ToByte(item), txtDepartmentID.Text, 0);
                }
                rightOfGroup.Insert();
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DEPARTMENT_ADD_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DEPARTMENT_ADD_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtDepartmentID_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtDepartmentID.Text != string.Empty);
        }

        private void txtDepartmentID_Leave(object sender, EventArgs e)
        {
            if (department.FindByPrimaryKey(txtDepartmentID.Text) != null)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DEPARTMENT_EXSIT", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            lueCompanyName.Properties.DataSource = CompanyTable.GetContentTable();
            lueCompanyName.Properties.ValueMember = "ID";
            lueCompanyName.Properties.DisplayMember = "Name";

            chkActive.Checked = true;
            txtSortOrder.Text = "0";

            UserGroupTable userGroup = new UserGroupTable();
            userGroup.GetInfoByUserName(Constant.currentUser.Name);
            ccbUserGroup.Properties.DataSource = userGroup;
            ccbUserGroup.Properties.ValueMember = "ID";
            ccbUserGroup.Properties.DisplayMember = "Name";
            ccbUserGroup.Properties.GetItems();
            string selected = string.Empty;
            foreach (UserGroupRow ugr in userGroup)
            {
                selected += selected == string.Empty ? ugr.ID.ToString() : "," + ugr.ID.ToString();
            }
            ccbUserGroup.SetEditValue(selected);
        }
    }
}