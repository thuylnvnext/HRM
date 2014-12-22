using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using Database;
using Common;
using DevExpress.XtraEditors;

namespace HRMplus.Forms
{
    public partial class UserGroupDetails : XtraForm
    {
        private UserGroupTable userGroup = new UserGroupTable();
        private bool isEdit = false;

        private void FillData()
        {
            userGroup.GetContent();
            grdUserGroupDetails.DataSource = userGroup;
            grvUserGroupDetails.BestFitColumns();
        }

        private void DeleteUserGroup()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_USER_GROUP", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                userGroup.Delete(Convert.ToByte(grvUserGroupDetails.GetFocusedRowCellValue("ID")));
            }
        }

        public UserGroupDetails()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private byte GetNewID()
        {
            byte newID = 1;

            for (int i = 0; i < grvUserGroupDetails.RowCount; i++)
            {
                if (Convert.ToByte(grvUserGroupDetails.GetRowCellValue(i, "ID")) > newID) break;
                newID++;
            }

            return newID;
        }

        private void UserGroupDetails_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);
            FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userGroup.Insert();
            userGroup.Update();
        }

        private void grvUserGroupDetails_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle) e.Value = e.RowHandle + 1;
        }

        private void grvUserGroupDetails_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvUserGroupDetails.SetRowCellValue(e.RowHandle, "ID", GetNewID());
            grvUserGroupDetails.SetRowCellValue(e.RowHandle, "No", grvUserGroupDetails.RowCount);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void grvUserGroupDetails_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                btnSave.Enabled = true;
                btnUndo.Enabled = true;
                isEdit = true;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            FillData();
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            isEdit = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUserGroup();
        }

        private void grdUserGroupDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteUserGroup();
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            new Permission(Convert.ToByte(grvUserGroupDetails.GetFocusedRowCellValue("ID"))).ShowDialog();
        }

        private void grvUserGroupDetails_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnPermission.Enabled = !(e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle);
        }

    }
}