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
    public partial class ReaderOption : XtraUserControl
    {
        private ReaderTable reader = new ReaderTable();
        private bool isEdit = false;

        public ReaderOption()
        {
            InitializeComponent();
        }

        private void DeleteReader()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_COMPANY", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                reader.Delete((byte)grvReader.GetFocusedRowCellValue("ID"));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (reader.Insert() && reader.Update())
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_READER_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_READER_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            reader.GetContent();
            grdReader.DataSource = reader;
            grvReader.BestFitColumns();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteReader();
        }

        private void grvReader_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                btnSave.Enabled = true;
                isEdit = true;
            }
        }

        private void grvReader_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle) e.Value = e.RowHandle + 1;
        }

        private void grvReader_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvReader.SetRowCellValue(e.RowHandle, "ID", ReaderTable.GetNewID());
            grvReader.SetRowCellValue(e.RowHandle, "ReaderTypeID", 1);
            grvReader.SetRowCellValue(e.RowHandle, "In", true);
            grvReader.SetRowCellValue(e.RowHandle, "Used", true);
        }

        private void grdReader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteReader();
        }

        private void btnScheduleForGetData_Click(object sender, EventArgs e)
        {
            new Attendance.Forms.ScheduleForGetData().ShowDialog();
        }
    }
}
