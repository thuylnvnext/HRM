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
    public partial class AddUser : XtraForm
    {
        private UserTable user = new UserTable();

        public AddUser()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void Execute()
        {
            if (txtPassword.Text != txtRetypePassword.Text)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PASSWORD_NOT_MATCH", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.AddUserRow(txtName.Text, Security.EncryptData(txtPassword.Text), txtFullName.Text, dedBirthDate.EditValue != null ? dedBirthDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), txtIDNumber.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, chkActive.Checked, chkVirtualData.Checked, Convert.ToByte(lueMemberOf.EditValue));
            if (!user.Insert())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("USER_CREATE_ERRORS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((UserDetails)Owner).ShowUser();
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("USER_CREATE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);

            lueMemberOf.Properties.DataSource = UserGroupTable.GetContentTable();
            lueMemberOf.Properties.DisplayMember = "Name";
            lueMemberOf.Properties.ValueMember = "ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}