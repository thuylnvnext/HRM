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
    public partial class LateComingEarlyReturning : XtraForm, IShowData
    {
        private RegisterLateEarlyTable registerLateEarly = new RegisterLateEarlyTable();
        private int total = 0;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        public LateComingEarlyReturning()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "LATECOMINGEARLYRETURNING_PAGE" }, new string[] { TitleTable.GetValue("LATECOMINGEARLYRETURNING_PAGE", Constant.language) });
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
            bgvLateComingEarlyReturning.BeginDataUpdate();
            if (check)
                registerLateEarly.DailyStatistic(departmentIDList, dedFromDate.DateTime, dedToDate.DateTime);
            else
                registerLateEarly.DeleteByDepartmentID(departmentIDList);
            grdLateComingEarlyReturning.DataSource = registerLateEarly;
            bgvLateComingEarlyReturning.EndDataUpdate();
            bgvLateComingEarlyReturning.ExpandAllGroups();
            waitDialog.Close();
        }

        private void LateComingEarlyReturning_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = DateTime.Today;
            dedToDate.DateTime = DateTime.Today;

            bgvLateComingEarlyReturning.RestoreLayout(Constant.language);
            ShowData(Constant.departmentIDList, true);

            AddPageCategory();
        }

        private void bbiToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void bbiSaveLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bgvLateComingEarlyReturning.SaveLayout(Constant.language))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bbiPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reports.LateComingEarlyReturning lateComingEarlyReturning = new Reports.LateComingEarlyReturning(bgvLateComingEarlyReturning, dedFromDate.DateTime, dedToDate.DateTime);
            lateComingEarlyReturning.DataSource = registerLateEarly;
            lateComingEarlyReturning.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            lateComingEarlyReturning.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            lateComingEarlyReturning.PrintingSystem.PreviewFormEx.Owner = this;
            lateComingEarlyReturning.ShowPreviewDialog();
        }

        private void LateComingEarlyReturning_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void dateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                registerLateEarly.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bgvLateComingEarlyReturning_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.IsTotalSummary)
            {
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start) total = 0;
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate && !Utility.IsNumeric(bgvLateComingEarlyReturning.GetRowCellValue(e.RowHandle, "No"))) total += Convert.ToInt32(e.FieldValue);
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize) e.TotalValue = total;
            }
        }

        private void bgvLateComingEarlyReturning_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle > -1 && bgvLateComingEarlyReturning.GetRowCellValue(e.RowHandle, "No").ToString() != string.Empty && !Utility.IsNumeric(bgvLateComingEarlyReturning.GetRowCellValue(e.RowHandle, "No"))) e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
    }
}
