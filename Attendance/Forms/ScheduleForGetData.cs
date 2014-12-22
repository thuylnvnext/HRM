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
    public partial class ScheduleForGetData : XtraForm
    {
        private ScheduleForGetDataTable scheduleForGetData = new ScheduleForGetDataTable();
        private bool isEdit = false;

        public ScheduleForGetData()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void DeleteScheduleForGetData()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_SCHEDULEFORGETDATA", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes) scheduleForGetData.Delete((DateTime)grvScheduleForGetData.GetFocusedRowCellValue("Time"));
        }

        private void ScheduleForGetData_Load(object sender, EventArgs e)
        {
            scheduleForGetData.GetContent();
            grdScheduleForGetData.DataSource = scheduleForGetData;
            grvScheduleForGetData.BestFitColumns();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (scheduleForGetData.Insert() && scheduleForGetData.Update())
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SCHEDULEFORGETDATA_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SCHEDULEFORGETDATA_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void grvScheduleForGetData_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                btnSave.Enabled = true;
                isEdit = true;
            }
        }

        private void grvScheduleForGetData_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle) e.Value = e.RowHandle + 1;
        }

        private void grdScheduleForGetData_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteScheduleForGetData();
        }

        private void grvScheduleForGetData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvScheduleForGetData.SetRowCellValue(e.RowHandle, "Time", DateTime.Now);
        }        
    }
}
