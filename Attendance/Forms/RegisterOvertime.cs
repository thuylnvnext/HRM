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
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace Attendance.Forms
{
    public partial class RegisterOvertime : Common.Forms.RegisterItem
    {
        public RegisterOvertime()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void InitTextEdit()
        {
            grvRegisterItem.Columns["Value"].DisplayFormat.FormatString = "#,##0.#;;-";
            grvRegisterItem.Columns["Value"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            RepositoryItemTextEdit iteValue = new RepositoryItemTextEdit();
            iteValue.Mask.EditMask = "N1";
            iteValue.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            grvRegisterItem.Columns["Value"].ColumnEdit = iteValue;
        }

        private void RegisterOvertime_Load(object sender, EventArgs e)
        {
            RegisterOvertimeTable registerOvertime = new RegisterOvertimeTable();
            registerItem = registerOvertime;
            InitItem("grvRegisterShift", true);
            InitTextEdit();
            grvRegisterItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(grvRegisterItem_CellValueChanged);
            grvRegisterItem.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grvRegisterItem_ValidateRow);
            ShowData(Constant.departmentIDList, true);
        }

        private void grvRegisterItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (grvRegisterItem.GetFocusedRowCellValue("ToDate") == DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", new DateTime(9999, 12, 31));
        }

        private void grvRegisterItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate" && e.Value != DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", Convert.ToDateTime(e.Value));
        }
    }
}
