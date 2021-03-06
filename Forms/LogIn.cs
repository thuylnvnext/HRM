using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraEditors;

namespace HRMplus.Forms
{
    public partial class LogIn : XtraForm
    {
        private string logOff = string.Empty;

        public LogIn()
        {
            InitializeComponent();            
            Utility.SetSkin(this);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserTable user = new UserTable();

            user.GetInfoByName(txtUserName.Text);
            if (user.Count > 0)
            {
                if (txtPassword.Text == Security.DecryptData(user[0].Password))
                {
                    Constant.currentUser = user[0];
                    if (chkRememberPassword.Checked)
                    {
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Remember", "Y");
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "UserName", txtUserName.Text);
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Password", user[0].Password);
                    }
                    else
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Remember", "N");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("INVALID_PASSWORD", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("INVALID_USER", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Remember", null) != null)
            {
                if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Remember", "Y") == "Y")
                {
                    logOff = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\LogOff", "LogOff", "F");
                    if (logOff == null) logOff = "F";
                    if (logOff == "F")
                    {
                        txtUserName.Text = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Username", string.Empty);
                        txtPassword.Text = Security.DecryptData((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\UserName", "Password", string.Empty));
                    }
                    else
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\LogOff", "LogOff", "F");
                    chkRememberPassword.Checked = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose(true);
        }
    }
}