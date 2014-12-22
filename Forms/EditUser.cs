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

namespace HRMplus.Forms
{
    public partial class EditUser : XtraForm
    {
        private string userName;
        private UserTable user = new UserTable();

        public EditUser()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public EditUser(string userName)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.userName = userName;
        }

        private void Execute()
        {
            if (txtPassword.Text != txtRetypePassword.Text)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PASSWORD_NOT_MATCH", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserRow ur = user.FindByPrimaryKey(userName);
            ur.Name = txtName.Text;
            ur.Password = Security.EncryptData(txtPassword.Text);
            ur.GroupID = Convert.ToByte(lueMemberOf.EditValue);
            ur.Permission = chkActive.Checked;
            ur.VirtualData = chkVirtualData.Checked;
            ur.FullName = txtFullName.Text;
            ur.BirthDate = dedBirthDate.EditValue != null ? dedBirthDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            ur.IDNumber = txtIDNumber.Text;
            ur.Address = txtAddress.Text;
            ur.Phone = txtPhone.Text;
            ur.Email = txtEmail.Text;

            if (!user.Update())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("USER_EDIT_ERRORS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((UserDetails)Owner).ShowUser();
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("USER_EDIT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);

            lueMemberOf.Properties.DataSource = UserGroupTable.GetContentTable();
            lueMemberOf.Properties.DisplayMember = "Name";
            lueMemberOf.Properties.ValueMember = "ID";

            user.GetContent();
            UserRow ur = user.FindByPrimaryKey(userName);
            txtName.Text = ur.Name;
            txtPassword.Text = txtRetypePassword.Text = Security.DecryptData(ur.Password);
            lueMemberOf.EditValue = ur.GroupID;
            if (!ur.IsPermissionNull()) chkActive.Checked = ur.Permission;
            if (!ur.IsVirtualDataNull()) chkVirtualData.Checked = ur.VirtualData;
            if (!ur.IsFullNameNull()) txtFullName.Text = ur.FullName;
            if (ur.BirthDate.ToString("dd/MM/yyyy") != "31/12/9999") dedBirthDate.DateTime = ur.BirthDate;
            if (!ur.IsIDNumberNull()) txtIDNumber.Text = ur.IDNumber;
            if (!ur.IsAddressNull()) txtAddress.Text = ur.Address;
            if (!ur.IsPhoneNull()) txtPhone.Text = ur.Phone;
            if (!ur.IsEmailNull()) txtEmail.Text = ur.Email;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}