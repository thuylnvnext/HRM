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
    public partial class DefineVacation : XtraForm
    {
        private VacationTable vacation = new VacationTable();
        private bool isEdit = false;

        public DefineVacation()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void FillVacation()
        {
            vacation.GetContent();
            grdVacation.DataSource = vacation;
            bgvVacation.BestFitColumns();
        }

        private void DeleteVacation()
        {
            DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_VACATION", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                vacation.Delete(Convert.ToDateTime(bgvVacation.GetFocusedRowCellValue("ID")));
            }
        }

        private void DefineVacation_Load(object sender, EventArgs e)
        {
            FillVacation();
        }

        private void bgvVacation_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vacation.Insert();
            vacation.Update();

            btnSave.Enabled = false;
            btnUndo.Enabled = false;
        }

        private void bgvVacation_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
            FillVacation();
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            isEdit = false;
        }

        private void grdVacation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteVacation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteVacation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}