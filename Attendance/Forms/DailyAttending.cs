using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.Data;
using Common;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace Attendance.Forms
{
    public partial class DailyAttending : XtraForm, IShowData
    {
        private Reports.ReportData.DailyAttendingDataTable dailyAttending = new Reports.ReportData.DailyAttendingDataTable();
        private Reports.DailyAttending _dailyAttending;
        private int groupCount, totalCount, absent = 0;
        private string departmentName = string.Empty;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        public DailyAttending()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public void ShowData(string departmentIDList, bool check)
        {
            WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
            waitDialog.Show();
            //cctDailyAttending.Series[0].Points.Clear();
            //cctDailyAttending.Series[1].Points.Clear();
            bgvDailyAttending.BeginDataUpdate();
            if (check)
                dailyAttending.GetList(departmentIDList, dedWorkingDay.DateTime);
            else
                dailyAttending.DeleteByDepartmentID(departmentIDList);
            bgvDailyAttending.EndDataUpdate();
            bgvDailyAttending.ExpandAllGroups();
            bgvDailyAttending.BestFitColumns();
            waitDialog.Close();
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "DAILYATTENDING_PAGE" }, new string[] { TitleTable.GetValue("DAILYATTENDING_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "PREVIEW_PAGEGROUP", "OPTION_PAGEGROUP" }, new string[] { TitleTable.GetValue("PREVIEW_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "PREVIEW", imlFunction.Images[0], TitleTable.GetValue("PREVIEW", Constant.language), new ItemClickEventHandler(bbiPreview_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "OPTION", imlFunction.Images[1], TitleTable.GetValue("OPTION", Constant.language), new ItemClickEventHandler(bbiOption_ItemClick));
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

        private void InitStartValue()
        {
            groupCount = 0;
            totalCount = 0;
            absent = 0;
            departmentName = string.Empty;
        }

        private void DailyAttending_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);
            Title.SetTitle(this, bgvDailyAttending);
            AddPageCategory();

            DepartmentTable department = new DepartmentTable();
            department.GetContent();
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.Name, dr.Name, 0));
            }

            grdDailyAttending.DataSource = dailyAttending;
            dedWorkingDay.DateTime = DateTime.Today;

            SetPermissionPage(pageCategory);
        }

        private void SetPermissionPage(PageCategory pcg)
        {
            if (pcg == null)
                return;
            if (pcg.Pages[0] == null)
                return;
            if (pcg.Pages[0].Groups.Count == 0)
                return;

            for (int i = 0; i < pcg.Pages[0].Groups.Count; i++)
            {
                Utility.SetPermission(pcg.Pages[0].Groups[i], this.Name);
            }

        }

        private void bgvDailyAttending_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData)
            {
                if (e.RowHandle > 0)
                {
                    if (e.RowHandle == bgvDailyAttending.GetDataRowHandleByGroupRowHandle(bgvDailyAttending.GetParentRowHandle(e.RowHandle)))
                        e.Value = 1;
                    else
                        e.Value = Convert.ToInt32(bgvDailyAttending.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void bgvDailyAttending_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                InitStartValue();
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                if ((bool)bgvDailyAttending.GetRowCellValue(e.RowHandle, "Attending"))
                {
                    if (e.IsGroupSummary)
                    {
                        groupCount++;
                        departmentName = bgvDailyAttending.GetRowCellValue(e.RowHandle, "DepartmentName").ToString();
                    }
                    if (e.IsTotalSummary) totalCount++;
                }
                else
                    absent++;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                if (e.IsGroupSummary)
                {
                    e.TotalValue = groupCount;
                    if (departmentName != string.Empty)
                    {
                        //cctDailyAttending.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint(departmentName, groupCount));
                        //cctDailyAttending.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint(departmentName, absent));
                    }
                }
                if (e.IsTotalSummary)
                    e.TotalValue = totalCount;
            }
        }

        private void bbiPreview_ItemClick(object sender, EventArgs e)
        {
            //_dailyAttending = new Reports.DailyAttending(dedWorkingDay.DateTime, SeriesViewFactory.GetViewType(cctDailyAttending.Series[0].View));
            //_dailyAttending.DataSource = dailyAttending;
            //_dailyAttending.PrintingSystem.PreviewFormEx.Owner = this;
            //_dailyAttending.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            //_dailyAttending.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            //_dailyAttending.ShowPreview();
        }

        private void dedWorkingDay_EditValueChanged(object sender, EventArgs e)
        {
            dailyAttending.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void bbiOption_ItemClick(object sender, EventArgs e)
        {
            //DevExpress.XtraCharts.Wizard.ChartWizard chartWizard = new DevExpress.XtraCharts.Wizard.ChartWizard(cctDailyAttending);
            //chartWizard.ShowDialog(LookAndFeel);
        }

        private void DailyAttending_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }
    }
}
