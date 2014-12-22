using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;

namespace Attendance.Forms
{
    public partial class DefineLeave: Form
    {
        private LeaveTable leave = new LeaveTable();
        private bool isEdit = false;

        public DefineLeave()
        {
            InitializeComponent();
        }

        private void FillLeave()
        {
            leave.GetContent();
            grdLeave.DataSource = leave;
            bgvLeave.BestFitColumns();
        }

        private void DeleteLeave()
        {
            DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_LEAVE", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                leave.Delete(bgvLeave.GetFocusedRowCellValue("ID").ToString());
            }
        }

        private void DefineLeave_Load(object sender, EventArgs e)
        {
            FillLeave();
        }

        private void bgvLeave_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            leave.Insert();
            leave.Update();

            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            isEdit = false;
        }

        private void bgvLeave_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
            FillLeave();
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            isEdit = false;
        }

        private void grdLeave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteLeave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteLeave();
        }
    }
}