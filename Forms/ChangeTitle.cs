using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.Grid;
using Common;
using DevExpress.XtraEditors;

namespace HRMplus.Forms
{
    public partial class ChangeTitle : XtraForm
    {
        private DataSet title = new DataSet();

        public ChangeTitle()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void ChangeTitle_Load(object sender, EventArgs e)
        {
            grdChangeTitle.DataSource = title.Item;
            title.GetList();            
            grvItem.BestFitColumns();
        }

        private void grvItem_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = true;
            DataSet.LanguageRow[] lrs;
            foreach (DataSet.ItemRow ir in title.Item)
            {
                if (ir.RowState == DataRowState.Modified)
                {
                    success = TitleTable.EditItem(ir["ID", DataRowVersion.Original].ToString(), ir.ID, ir.IsDescriptionNull() ? string.Empty : ir.Description);
                    if (!success) break;
                }
                lrs = (DataSet.LanguageRow[])ir.GetChildRows("Item_Language");
                foreach (DataSet.LanguageRow lr in lrs)
                {
                    if (lr.RowState == DataRowState.Modified)
                    {
                        success = TitleTable.EditValue(lr.ItemID, lr["ID", DataRowVersion.Original].ToString(), lr.ID, lr.Value);
                        if (!success) break;
                    }
                    if (lr.RowState == DataRowState.Added)
                    {
                        success = TitleTable.Insert(lr.ItemID, lr.ID, lr.Value, ir.IsDescriptionNull() ? string.Empty : ir.Description);
                        if (!success) break;
                    }
                }
            }
            if (success)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_LANGUAGE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_LANGUAGE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void grvItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_ITEM", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (retVal == DialogResult.OK)
                {
                    GridView item = (GridView)sender;
                    int[] selectedRows = item.GetSelectedRows();
                    foreach (int i in selectedRows)
                    {
                        TitleTable.DeleteItem(item.GetRowCellValue(i, "ID").ToString());
                    }
                    item.DeleteSelectedRows();
                }
            }
        }

        private void grvLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_LANGUAGE", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (retVal == DialogResult.OK)
                {
                    GridView language = (GridView)sender;
                    int[] selectedRows = language.GetSelectedRows();
                    foreach (int i in selectedRows)
                    {
                        TitleTable.DeleteLanguage(language.GetRowCellValue(i, "ItemID").ToString(), language.GetRowCellValue(i, "ID").ToString());
                    }
                    language.DeleteSelectedRows();
                }
            }
        }
    }
}
