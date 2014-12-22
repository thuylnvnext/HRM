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
using DevExpress.XtraBars; 

namespace Attendance.Forms
{
    public partial class RegisterAbsence : Common.Forms.RegisterItem
    {
        public RegisterAbsence()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void InitLookUp()
        {
            DataTable unit = new DataTable();
            unit.Columns.Add("ID", typeof(decimal));
            unit.Columns.Add("Name", typeof(string));
            unit.Rows.Add(new object[] { 1, "Cả ngày" });
            unit.Rows.Add(new object[] { 0.5, "Buổi sáng" });
            unit.Rows.Add(new object[] { -0.5, "Buổi chiều" });
            //unit.Rows.Add(new object[] { 0.0625, "0.0625" });
            //unit.Rows.Add(new object[] { 0.125, "0.125" });
            //unit.Rows.Add(new object[] { 0.1875, "0.1875" });
            //unit.Rows.Add(new object[] { 0.25, "0.25" });
            //unit.Rows.Add(new object[] { 0.3125, "0.3125" });
            //unit.Rows.Add(new object[] { 0.375, "0.375" });
            //unit.Rows.Add(new object[] { 0.4375, "0.4375" });
            //unit.Rows.Add(new object[] { 0.5625, "0.5625" });
            //unit.Rows.Add(new object[] { 0.625, "0.625" });
            //unit.Rows.Add(new object[] { 0.6875, "0.6875" });
            //unit.Rows.Add(new object[] { 0.75, "0.75" });
            //unit.Rows.Add(new object[] { 0.875, "0.875" });

            RepositoryItemLookUpEdit ileUnit = new RepositoryItemLookUpEdit();
            ileUnit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileUnit.ShowHeader = false;
            ileUnit.NullText = string.Empty;
            ileUnit.DataSource = unit;
            ileUnit.ValueMember = "ID";
            ileUnit.DisplayMember = "Name";
            ileUnit.BestFit();
            grvRegisterItem.Columns["Unit"].ColumnEdit = ileUnit;

            AbsenceTable absence = new AbsenceTable();
            absence.GetContent();
            RepositoryItemLookUpEdit ileAbsence = new RepositoryItemLookUpEdit();
            ileAbsence.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileAbsence.ShowHeader = false;
            ileAbsence.NullText = string.Empty;
            ileAbsence.DataSource = absence;
            ileAbsence.ValueMember = "ID";
            ileAbsence.DisplayMember = "Name";
            ileAbsence.BestFit();
            grvRegisterItem.Columns["AbsenceID"].ColumnEdit = ileAbsence;
        }

        private void RegisterAbsence_Load(object sender, EventArgs e)
        {
            RegisterAbsenceTable registerAbsence = new RegisterAbsenceTable();
            registerItem = registerAbsence;
            InitItem("grvRegisterAbsence", true);
            InitLookUp();
            grvRegisterItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(grvRegisterItem_CellValueChanged);
            ShowData(Constant.departmentIDList, true);
        }

        private void grvRegisterItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate" && e.Value != DBNull.Value && grvRegisterItem.GetRowCellValue(e.RowHandle, "ToDate") == DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", Convert.ToDateTime(e.Value));
        }
    }
}
