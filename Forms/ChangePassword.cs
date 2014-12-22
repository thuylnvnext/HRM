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
    public partial class ChangePassword : XtraForm
    {
        private UserTable user = new UserTable();

        public ChangePassword()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void Execute()
        {
            if (Security.DecryptData(Constant.currentUser.Password) != txtCurrentPassword.Text)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("CURRENT_PASSWORD_INVALID", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNewPassword.Text != txtRetypePassword.Text)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PASSWORD_NOT_MATCH", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserRow ur = user.FindByPrimaryKey(Constant.currentUser.Name);
                ur.Password = Security.EncryptData(txtNewPassword.Text);
                if (user.Update())
                {
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PASSWORD_EDIT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PASSWORD_EDIT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Execute(); 
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            user.GetContent();
        }

        private void ChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) Execute();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}