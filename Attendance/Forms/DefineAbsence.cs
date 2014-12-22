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
    public partial class DefineAbsence : Form
    {
        private AbsenceTable absence = new AbsenceTable();
        private bool isEdit = false;

        public DefineAbsence()
        {
            InitializeComponent();
        }

        private void FillAbsence()
        {
            absence.GetContent();
            grdAbsence.DataSource = absence;
            bgvAbsence.BestFitColumns();
        }

        private void DeleteAbsence()
        {
            DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_ABSENCE", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                absence.Delete(bgvAbsence.GetFocusedRowCellValue("ID").ToString());
            }
        }

        private void DefineAbsence_Load(object sender, EventArgs e)
        {
            FillAbsence();
        }

        private void bgvAbsence_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            absence.Insert();
            absence.Update();

            btnSave.Enabled = false;
            btnUndo.Enabled = false;
        }

        private void bgvAbsence_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
            FillAbsence();
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            isEdit = false;
        }

        private void grdAbsence_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteAbsence();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAbsence();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}