using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls; 

namespace Attendance.Forms
{
    public partial class RegisterAttendanceItem : Common.Forms.RegisterItem
    {
        public RegisterAttendanceItem()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void InitLookUp()
        {
            AttendanceItemTable attendanceItem = new AttendanceItemTable();
            RepositoryItemLookUpEdit ileAttendanceItem = new RepositoryItemLookUpEdit();
            LookUpColumnInfo lciID = new LookUpColumnInfo(), lciName = new LookUpColumnInfo();
            lciID.Alignment = DevExpress.Utils.HorzAlignment.Near;
            lciID.Caption = "Mã";
            lciID.FieldName = "ID";
            lciName.Alignment = DevExpress.Utils.HorzAlignment.Near;
            lciName.Caption = "Tên";
            lciName.FieldName = "Name";
            ileAttendanceItem.Columns.AddRange(new LookUpColumnInfo[] { lciID, lciName });
            ileAttendanceItem.AppearanceDropDownHeader.Options.UseTextOptions = true;
            ileAttendanceItem.AppearanceDropDownHeader.Font = new Font(ileAttendanceItem.AppearanceDropDownHeader.Font, FontStyle.Bold);
            ileAttendanceItem.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ileAttendanceItem.NullText = string.Empty;
            attendanceItem.GetContent();
            attendanceItem.DefaultView.RowFilter = "ID = 'X'";
            ileAttendanceItem.DataSource = attendanceItem;
            ileAttendanceItem.ValueMember = "ID";
            ileAttendanceItem.DisplayMember = "Name";
            ileAttendanceItem.BestFit();
            grvRegisterItem.Columns["AttendanceItemID"].ColumnEdit = ileAttendanceItem;

            grvRegisterItem.Columns["Value"].DisplayFormat.FormatString = "#,##0.#;;-";
            grvRegisterItem.Columns["Value"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            RepositoryItemTextEdit iteValue = new RepositoryItemTextEdit();            
            iteValue.Mask.EditMask = "N1";
            iteValue.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            grvRegisterItem.Columns["Value"].ColumnEdit = iteValue;
        }

        private void RegisterAttendanceItem_Load(object sender, EventArgs e)
        {
            RegisterAttendanceItemTable registerAttendanceItem = new RegisterAttendanceItemTable();
            registerItem = registerAttendanceItem;
            InitItem("grvRegisterAttendanceItem", true);
            InitLookUp();
            grvRegisterItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(grvRegisterItem_CellValueChanged);
            //grvRegisterItem.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grvRegisterItem_ValidateRow);
            grvRegisterItem.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(grvRegisterItem_InitNewRow);
            ShowData(Constant.departmentIDList, true);
        }

        private void grvRegisterItem_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvRegisterItem.SetRowCellValue(e.RowHandle, "AttendanceItemID", "X");
        }

        //private void grvRegisterItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        //{
        //    int r;
        //    if (e.RowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
        //        r = grvRegisterItem.RowCount - 2;
        //    else
        //        r = e.RowHandle - 1;
        //    if (r > -1)
        //    {
        //        DataRowView dr = (DataRowView)e.Row;
        //        grvRegisterItem.SetRowCellValue(r, "ToDate", Convert.ToDateTime(dr["FromDate"]).AddDays(-1));
        //    }
        //    if (grvRegisterItem.GetFocusedRowCellValue("ToDate") == DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", new DateTime(9999, 12, 31));
        //}

        private void grvRegisterItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate" && e.Value != DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", Convert.ToDateTime(e.Value));
        }
    }
}
