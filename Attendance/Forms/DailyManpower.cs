using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Preview;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Common;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;

namespace Attendance.Forms
{
    public partial class DailyManpower : XtraForm, IShowData
    {
        private DepartmentTable department = new DepartmentTable();
        private int total = 0;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        public DailyManpower()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "DAILYMANPOWER_PAGE" }, new string[] { TitleTable.GetValue("DAILYMANPOWER_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "EXPORT_PAGEGROUP", "OPTION_PAGEGROUP" }, new string[] { TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "PREVIEW", imlFunction.Images[0], TitleTable.GetValue("PREVIEW", Constant.language), new ItemClickEventHandler(bbiPreview_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "TO_EXCEL", imlFunction.Images[1], TitleTable.GetValue("TO_EXCEL", Constant.language), new ItemClickEventHandler(bbiToExcel_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "SAVE_LAYOUT", imlFunction.Images[2], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            IMdiParent mdiParent = (IMdiParent)MdiParent;
            ribbon = mdiParent.GetRibbonControl;
            ribbon.PageCategories.Add(pageCategory);
            selectedPage = ribbon.SelectedPage;
            ribbon.SelectedPage = pageCategory.Pages[0];
        }

        private void RemovePageCategory()
        {
            ribbon.PageCategories.Remove(pageCategory);
            ribbon.SelectedPage = selectedPage;
        }

        public void ShowData(string departmentIDList, bool check)
        {
            WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
            waitDialog.Show();
            Application.DoEvents();
            bgvDailyManpower.BeginDataUpdate();
            if (check)
                department.DailyManpower(departmentIDList, dedFromDate.DateTime, dedToDate.DateTime, Convert.ToByte(cboForm.SelectedIndex));
            else
                department.DeleteByDepartmentID(departmentIDList);
            grdDailyManpower.DataSource = department;
            bgvDailyManpower.EndDataUpdate();
            bgvDailyManpower.ExpandAllGroups();
            waitDialog.Close();
        }

        private void DailyManpower_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = DateTime.Today;
            dedToDate.DateTime = DateTime.Today;
            cboForm.SelectedIndex = 0;

            //ShowData(Constant.departmentIDList, true);

            AddPageCategory();
        }

        private void bbiToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void bbiSaveLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bgvDailyManpower.SaveLayout(Constant.language))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bbiPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reports.DailyManpower dailyManpower = new Reports.DailyManpower(bgvDailyManpower, dedFromDate.DateTime, dedToDate.DateTime);
            dailyManpower.DataSource = department;
            dailyManpower.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            dailyManpower.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            dailyManpower.PrintingSystem.PreviewFormEx.Owner = this;
            dailyManpower.ShowPreviewDialog();
        }

        private void DailyManpower_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void dateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                department.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bgvDailyManpower_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.IsTotalSummary)
            {
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start) total = 0;
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate && bgvDailyManpower.GetRowCellValue(e.RowHandle, "No").ToString() != string.Empty && !Utility.IsNumeric(bgvDailyManpower.GetRowCellValue(e.RowHandle, "No"))) total += Convert.ToInt32(e.FieldValue);
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize) e.TotalValue = total;
            }
        }

        private void cboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgvDailyManpower.Name = "bgvDailyManpower" + cboForm.SelectedIndex.ToString();
            bgvDailyManpower.RestoreLayout(Constant.language);
            department.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void bgvDailyManpower_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle > -1 && bgvDailyManpower.GetRowCellValue(e.RowHandle, "No").ToString() != string.Empty && !Utility.IsNumeric(bgvDailyManpower.GetRowCellValue(e.RowHandle, "No"))) e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
    }
}
