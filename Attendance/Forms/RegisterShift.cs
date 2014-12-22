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

namespace Attendance.Forms
{
    public partial class RegisterShift : Common.Forms.RegisterItem
    {
        public RegisterShift()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void InitCheckedCombo()
        {
            ShiftTable shift = new ShiftTable();
            shift.GetContent();
            foreach (ShiftRow sr in shift)
            {
                sr.ID = "[" + sr.ID + "]";
            }
            DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit iccShiftID = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            iccShiftID.AutoHeight = false;
            //iccShiftID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            iccShiftID.Name = "iccShiftID";
            iccShiftID.SelectAllItemCaption = "(Chọn tất cả)";
            iccShiftID.DataSource = shift;
            iccShiftID.ValueMember = "ID";
            iccShiftID.DisplayMember = "Name";
            grvRegisterItem.Columns["ShiftID"].ColumnEdit = iccShiftID;
        }

        private void RegisterShift_Load(object sender, EventArgs e)
        {
            RegisterShiftTable registerShift = new RegisterShiftTable();
            registerItem = registerShift;
            InitItem("grvRegisterShift", true);
            InitCheckedCombo();
            grvRegisterItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(grvRegisterItem_CellValueChanged);
            ShowData(Constant.departmentIDList, true);
        }

        private void grvRegisterItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate" && e.Value != DBNull.Value && grvRegisterItem.GetRowCellValue(e.RowHandle, "ToDate") == DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", Convert.ToDateTime(e.Value));
        }
    }
}
