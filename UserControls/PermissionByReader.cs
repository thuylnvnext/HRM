using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Database;
using Common;

namespace HRMplus.UserControls
{
    public partial class PermissionByReader : XtraUserControl
    {
        private RightOfGroupTable rightOfGroup;
        private byte groupID;

        public PermissionByReader()
        {
            InitializeComponent();
        }        

        private void ShowReader()
        {
            ReaderTable reader = new ReaderTable();
            reader.GetContent();
            reader.Columns.Add("Right", typeof(bool));
            foreach (ReaderRow rr in reader)
            {
                rr["Right"] = (rightOfGroup.FindByPrimaryKey(groupID, rr.ID.ToString(), 3) != null);
            }
            grdReader.DataSource = reader;
            grvReader.BestFitColumns();
        }

        private void Permission()
        {
            for (int r = 0; r < grvReader.DataRowCount; r++)
            {
                if ((bool)grvReader.GetRowCellValue(r, "Right"))
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, grvReader.GetRowCellValue(r, "ID").ToString(), 3) == null)
                    {
                        rightOfGroup.AddRightOfGroupRow(groupID, grvReader.GetRowCellValue(r, "ID").ToString(), 3);
                        rightOfGroup.Insert();
                    }
                }
                else
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, grvReader.GetRowCellValue(r, "ID").ToString(), 3) != null)
                    {
                        rightOfGroup.Delete(groupID, grvReader.GetRowCellValue(r, "ID").ToString(), 3);
                        rightOfGroup.Delete();
                    }
                }
            }
        }

        private void PermissionByReader_Load(object sender, EventArgs e)
        {
            try
            {
                rightOfGroup = ((Forms.Permission)ParentForm).RightOfGroup;
                groupID = ((Forms.Permission)ParentForm).GroupID;
            }
            catch 
            {
            }

            ShowReader();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Permission();
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PERMISSION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grvReader_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData) e.Value = e.RowHandle + 1;
        }

        private void grvReader_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle > -1 && !(bool)grvReader.GetRowCellValue(e.RowHandle, "Used"))
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.BackColor2 = Color.Red;
            }
        }

        private void grvReader_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (!(bool)grvReader.GetRowCellValue(grvReader.FocusedRowHandle, "Used")) e.Cancel = true;
        }
    }
}
