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

namespace Attendance.Forms
{
    public partial class RawDataView : XtraForm
    {
        private RawDataTable rawDataView = new RawDataTable();
        private int employeeID;
        private DateTime fromDate, toDate;
        private bool isEdit = false;

        public RawDataView(int employeeID, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.fromDate = fromDate;
            this.toDate = toDate;
            Utility.SetSkin(this);
        }

        private void FillRawDataView()
        {
            rawDataView.GetListByEmployeeID(employeeID, fromDate, toDate);
            grdRawDataView.DataSource = rawDataView;
            grvRawDataView.BestFitColumns();
        }

        private void DeleteRawDataView()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_RAWDATAVIEW", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes) rawDataView.Delete((int)grvRawDataView.GetFocusedRowCellValue("EnrollNumber"), Convert.ToDateTime(grvRawDataView.GetFocusedRowCellValue("SwipedDate")));
        }

        private void RawDataView_Load(object sender, EventArgs e)
        {
            if (Constant.currentUser.GroupID == 1)
            {
                grvRawDataView.Columns["SwipedDate"].OptionsColumn.AllowEdit = true;
                grvRawDataView.Columns["SwipedDate"].OptionsColumn.ReadOnly = false;
                btnSave.Visible = true;
                btnDelete.Visible = true;
                btnUndo.Visible = true;
                btnClose.Left = 360;
            }
            FillRawDataView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            grvRawDataView.UpdateCurrentRow();
            retVal1 = rawDataView.Insert();
            retVal2 = rawDataView.Update();
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_RAWDATAVIEW_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_RAWDATAVIEW_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            isEdit = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void grvRawDataView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void grdRawDataView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteRawDataView();
        }

        private void grvRawDataView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvRawDataView.SetRowCellValue(e.RowHandle, "ReaderID", 0);
            grvRawDataView.SetRowCellValue(e.RowHandle, "EnrollNumber", CardTable.GetEnrollNumberByEmployeeID(employeeID, (DateTime)grvRawDataView.ActiveEditor.EditValue));
            grvRawDataView.SetRowCellValue(e.RowHandle, "Status", false);
            grvRawDataView.SetRowCellValue(e.RowHandle, "Used", true);
        }

        private void grvRawDataView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                btnSave.Enabled = true;
                btnUndo.Enabled = true;
                isEdit = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRawDataView();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            FillRawDataView();
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            isEdit = false;
        }
    }
}
