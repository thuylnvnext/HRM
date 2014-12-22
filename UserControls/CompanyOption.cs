using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Database;
using Common;

namespace HRMplus.UserControls
{
    public partial class CompanyOption : XtraUserControl
    {
        private CompanyTable company = new CompanyTable();
        private bool isEdit = false;

        public CompanyOption()
        {
            InitializeComponent();
        }

        private void DeleteCompany()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_COMPANY", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                company.Delete(grvCompany.GetFocusedRowCellValue("ID").ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (company.Update())
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("COMPANY_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("COMPANY_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Company_Load(object sender, EventArgs e)
        {
            company.GetContent();
            grdCompany.DataSource = company;
            grvCompany.ExpandAllGroups();
            grvCompany.BestFitColumns();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCompany();
        }

        private void grvCompany_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                btnSave.Enabled = true;
                isEdit = true;
            }
        }

        private void grvCompany_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle) e.Value = e.RowHandle + 1;
        }

        private void grvCompany_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvCompany.SetRowCellValue(e.RowHandle, "CompanyTypeID", 1);
        }

        private void grdCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteCompany();
        }
    }
}
