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
    public partial class UserDetails : XtraForm
    {
        private UserGroupTable userGroup = new UserGroupTable();
        private RightOfGroupTable rightOfGroup = new RightOfGroupTable();
        private UserTable user = new UserTable();

        private void ShowMemberOf()
        {
            try
            {
                lblGroup.Text = userGroup.FindByPrimaryKey(user.FindByPrimaryKey(lbcAvailableUsers.Text).GroupID).Name;
            }
            catch { }
        }

        public void ShowUser()
        {
            user.GetContent();
            lbcAvailableUsers.DataSource = user;
            lbcAvailableUsers.DisplayMember = "Name";
            lbcAvailableUsers.ValueMember = "Name";

            ShowMemberOf();
        }

        public UserDetails()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog(this);
        }

        private void User_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);

            userGroup.GetContent();
            ShowUser();
        }

        private void lbcAvailableUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMemberOf();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new EditUser(lbcAvailableUsers.Text).ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_USER", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                user.Delete(lbcAvailableUsers.Text);
            }
        }
    }
}