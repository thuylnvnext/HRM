using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;
using Common;
using DevExpress.XtraEditors;
using Microsoft.Win32;

namespace Attendance.Forms
{
    public partial class DefineShift : XtraForm
    {
        private ShiftTable shift = new ShiftTable();
        private ShiftDetailTable shiftDetail = new ShiftDetailTable();
        private bool isEdit = false, isDetailEdit = false;

        public DefineShift()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void FillShift()
        {
            shift.GetContent();
            grdShift.DataSource = shift;
            grvShift.BestFitColumns();
        }

        private void FillShiftDetail(string shiftID)
        {
            shiftDetail.GetInfoByShiftID(shiftID);
            grdShiftDetail.DataSource = shiftDetail;
            bgvShiftDetail.BestFitColumns();
        }

        private void DeleteShift()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_SHIFT", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                shift.Delete(grvShift.GetFocusedRowCellValue("ID").ToString());
            }
        }

        private void DeleteShiftDetail()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_SHIFTDETAIL", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                shiftDetail.Delete(bgvShiftDetail.GetFocusedRowCellValue("ShiftID").ToString(), Convert.ToDateTime(bgvShiftDetail.GetFocusedRowCellValue("FromDate")));
            }
        }

        private void DefineShift_Load(object sender, EventArgs e)
        {            
            FillShift();
        }

        private void grvShift_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void bgvShiftDetail_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void grvShift_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grvShift.GetFocusedRowCellValue("ID") != null)
            {
                btnDelete.Enabled = true;
                FillShiftDetail(grvShift.GetFocusedRowCellValue("ID").ToString());
                grcShiftDetail.Text = TitleTable.GetValue("DefineShift.grbShiftDetail", Constant.language) + " '" + grvShift.GetFocusedRowCellValue("Name").ToString() + "'";
                grdShiftDetail.Enabled = true;
                btnDetailSave.Enabled = false;
                btnDetailDelete.Enabled = true;
                btnDetailUndo.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = false;
                shiftDetail.Clear();
                grdShiftDetail.Enabled = false;
                btnDetailSave.Enabled = false;
                btnDetailDelete.Enabled = false;
                btnDetailUndo.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;            
            retVal1 = shift.Insert();
            retVal2 = shift.Update();
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SHIFT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SHIFT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            isEdit = false;
        }

        private void grvShift_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
            FillShift();
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            isEdit = false;
        }

        private void grdShift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteShift();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteShift();
        }

        private void bgvShiftDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            bgvShiftDetail.SetRowCellValue(e.RowHandle, "ToDate", new DateTime(9999, 12, 31));
            bgvShiftDetail.SetRowCellValue(e.RowHandle, "ShiftID", grvShift.GetFocusedRowCellValue("ID"));
        }

        private void bgvShiftDetail_CustomDrawBandHeader(object sender, DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs e)
        {
            Brush brush = null;
            switch (e.Band.Name)
            {
                case "grbNormalDay":
                case "grbNormalTimeIn":
                case "grbNormalTimeOut":
                case "grbNormalBreak":
                case "grbNormalBreakOut":
                case "grbNormalBreakIn":
                case "grbNormalTotal":
                    brush = e.Cache.GetGradientBrush(e.Bounds, Color.Silver, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                    break;
                case "grbSaturday":
                case "grbSaturdayTimeIn":
                case "grbSaturdayTimeOut":
                case "grbSaturdayBreak":
                case "grbSaturdayBreakOut":
                case "grbSaturdayBreakIn":
                case "grbSaturdayTotal":
                    brush = e.Cache.GetGradientBrush(e.Bounds, Color.DodgerBlue, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                    break;
                case "grbSunday":
                case "grbSundayTimeIn":
                case "grbSundayTimeOut":
                case "grbSundayBreak":
                case "grbSundayBreakOut":
                case "grbSundayBreakIn":
                case "grbSundayTotal":
                    brush = e.Cache.GetGradientBrush(e.Bounds, Color.Red, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);                    
                    break;                
            }
            if (brush != null)
            {
                Rectangle r = e.Bounds;
                ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
                r.Inflate(-1, -1);
                e.Graphics.FillRectangle(brush, r);
                r.Inflate(-2, 0);
                e.Appearance.DrawString(e.Cache, e.Info.Caption, r);
                e.Handled = true;
            }
        }

        private void btnDetailUndo_Click(object sender, EventArgs e)
        {
            FillShiftDetail(grvShift.GetFocusedRowCellValue("ID").ToString());
            btnDetailUndo.Enabled = false;
            btnDetailSave.Enabled = false;
            isDetailEdit = false;
        }

        private void bgvShiftDetail_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isDetailEdit)
            {
                btnDetailSave.Enabled = true;
                btnDetailUndo.Enabled = true;
                isDetailEdit = true;
            }
        }

        private void grdShiftDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteShiftDetail();
        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            DeleteShiftDetail();
        }

        private void btnDetailSave_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            retVal1 = shiftDetail.Insert();
            retVal2 = shiftDetail.Update();
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SHIFT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SHIFT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnDetailSave.Enabled = false;
            btnDetailUndo.Enabled = false;
            isDetailEdit = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void irgIsDefault_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                for (int r = 0; r < grvShift.DataRowCount; r++)
                {
                    if (r != grvShift.FocusedRowHandle) grvShift.SetRowCellValue(r, "IsDefault", false);
                }
                grvShift.SetRowCellValue(grvShift.FocusedRowHandle, "IsDefault", true);
            }
        }

        private void grvShift_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void bgvShiftDetail_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void grvShift_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (grvShift.GetRowCellValue(e.RowHandle, grvShift.Columns["ID"]).ToString() == string.Empty)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SHIFTID_NOTEMPTY", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1 && shift.FindByPrimaryKey(grvShift.GetRowCellValue(e.RowHandle, grvShift.Columns["ID"]).ToString()) != null)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SHIFTID_EXIST", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (grvShift.GetRowCellValue(e.RowHandle, grvShift.Columns["Name"]).ToString() == string.Empty)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SHIFTNAME_NOTEMPTY", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgvShiftDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (bgvShiftDetail.GetRowCellValue(e.RowHandle, bgvShiftDetail.Columns["FromDate"]).ToString() == string.Empty)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SHIFTDETAIL_NOTEMPTY", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1 && shiftDetail.FindByPrimaryKey(bgvShiftDetail.GetRowCellValue(e.RowHandle, bgvShiftDetail.Columns["ShiftID"]).ToString(), Convert.ToDateTime(bgvShiftDetail.GetRowCellValue(e.RowHandle, bgvShiftDetail.Columns["FromDate"]))) != null)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SHIFTDETAIL_EXIST", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bgvShiftDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1)
            {
                btnDetailDelete.Enabled = false;
                bgvShiftDetail.SetRowCellValue(e.FocusedRowHandle, "FromDate", DateTime.Today);
            }
            else
                btnDetailDelete.Enabled = true;
        }

        private void bgvShiftDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1 && e.Value != DBNull.Value)
            {
                if (shiftDetail.Columns[e.Column.FieldName].DataType.Name == "DateTime" && e.Column.FieldName != "FromDate" && e.Column.FieldName != "ToDate")
                {
                    DateTime d = Convert.ToDateTime(e.Value);
                    if (d.Hour == 0 && d.Minute == 0 && d.Second == 0) bgvShiftDetail.SetRowCellValue(e.RowHandle, e.Column, null);
                }
                //else if (shiftDetail.Columns[e.Column.FieldName].DataType.Name == "Int32")
                //{
                //    if (Convert.ToInt32(e.Value) == 0) bgvShiftDetail.SetRowCellValue(e.RowHandle, e.Column, null);
                //}
            }
        }

        private void bgvShiftDetail_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ToDate" && e.CellValue != DBNull.Value && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
        }
    }
}