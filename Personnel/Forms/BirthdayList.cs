using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace Personnel.Forms
{
    public partial class BirthdayList : XtraForm, IShowData
    {
        private EmployeeTable employee = new EmployeeTable();
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        public BirthdayList()
        {
            InitializeComponent();
            Title.SetTitle(this);
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "BIRTHDAYLIST_PAGE" }, new string[] { TitleTable.GetValue("BIRTHDAYLIST_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "EXPORT", imlFunction.Images[8], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));
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

        private void Init()
        {
            cmbMonth.EditValue = DateTime.Now.Month;
        }

        private void SetFilter()
        {
            if (chkResignation.Checked)
                grvEmployeeInfo.Columns["Resignation"].ClearFilter();
            else
                grvEmployeeInfo.Columns["Resignation"].FilterInfo = new ColumnFilterInfo("Resignation = 0");
        }

        public void ShowData(string departmentIDList, bool check)
        {
            grvEmployeeInfo.BeginDataUpdate();
            if (check)
            {
                employee.GetListBirthdayByDepartmentID(departmentIDList, DateTime.Today, Convert.ToInt16(cmbMonth.EditValue));
            }
            else
                employee.DeleteByDepartmentID(departmentIDList);
            SetFilter();
            grvEmployeeInfo.EndDataUpdate();
            grvEmployeeInfo.BestFitColumns();
            grdEmployeeInfo.Focus();
        }

        public void ShowEmployee(string criteria, DateTime workingDay)
        {
            grvEmployeeInfo.BeginDataUpdate();
            employee.Clear();
            employee.AdvancedSearch(criteria, workingDay);
            SetFilter();
            grvEmployeeInfo.EndDataUpdate();
            grvEmployeeInfo.BestFitColumns();
        }

        private string GetSelectedEmployeeIDList()
        {
            int[] selectedRows = grvEmployeeInfo.GetSelectedRows();
            if (selectedRows != null)
            {
                string employeeIDList = string.Empty;
                int employeeID;
                for (int i = 0; i < selectedRows.Length; i++)
                {
                    employeeID = Convert.ToInt32(grvEmployeeInfo.GetRowCellValue(selectedRows[i], "ID"));
                    employeeIDList += employeeIDList == string.Empty ? "[" + employeeID + "]" : ",[" + employeeID + "]";
                }
                return employeeIDList;
            }
            else
            {
                return string.Empty;
            }
        }

        private void BirthdayList_Load(object sender, EventArgs e)
        {
            Init();

            grdEmployeeInfo.DataSource = employee;
            ShowData(Constant.departmentIDList, true);

            AddPageCategory();
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

        private void grvEmployeeInfo_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void grvEmployeeInfo_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.ColumnType == Type.GetType("System.DateTime") && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
            }
            catch
            {
            }
        }

        private void BirthdayList_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void grvEmployeeInfo_ColumnPositionChanged(object sender, EventArgs e)
        {
            EmployeeInfoListTable displayOptions = new EmployeeInfoListTable();
            EmployeeInfoListRow eilr;
            displayOptions.GetContent();
            for (int i = 0; i < grvEmployeeInfo.Columns.Count; i++)
            {
                eilr = displayOptions.FindByPrimaryKey(grvEmployeeInfo.Columns[i].FieldName);
                if (eilr != null)
                {
                    eilr.VisibleIndex = (short)grvEmployeeInfo.Columns[i].VisibleIndex;
                }
            }
            displayOptions.Update();
        }

        private void pclEmployeeInfo_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            TextBrick company = e.Graph.DrawString(TitleTable.GetValue(CompanyTable.GetDefaultInfo().ID, Constant.language), SystemColors.ControlText, new RectangleF(0, 0, 500, 25), BorderSide.None);
            company.VertAlignment = DevExpress.Utils.VertAlignment.Center;
            company.Font = new Font(company.Font, FontStyle.Bold);
            TextBrick title = e.Graph.DrawString("DANH SÁCH NHÂN VIÊN SINH NHẬT THÁNG " + cmbMonth.EditValue, SystemColors.ControlText, new RectangleF(0, 25, e.Graph.ClientPageSize.Width, 50), DevExpress.XtraPrinting.BorderSide.None);
            title.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            title.VertAlignment = DevExpress.Utils.VertAlignment.Center;
            title.Font = new Font(title.Font.FontFamily, 18, FontStyle.Bold);
        }

        private void pclEmployeeInfo_CreateMarginalFooterArea(object sender, CreateAreaEventArgs e)
        {
            PageInfoBrick page = e.Graph.DrawPageInfo(PageInfo.Number, "{0}", Color.Black, new RectangleF(0, 0, 0, e.Graph.Font.Height), BorderSide.None);
            page.Alignment = BrickAlignment.Far;
            page.AutoWidth = true;
        }

        private void grvEmployeeInfo_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && (int)grvEmployeeInfo.GetRowCellValue(e.RowHandle, "Resignation") == 1) e.Appearance.BackColor = Color.FromArgb(191, 191, 191);
        }

        private void chkResignation_CheckedChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prsEmployeeInfo.Links[0].CreateDocument();
            prsEmployeeInfo.PreviewFormEx.Owner = this;
            prsEmployeeInfo.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            prsEmployeeInfo.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            prsEmployeeInfo.PreviewFormEx.ShowDialog();
        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right) new Common.Forms.SetTitle(sender, Name).ShowDialog();
            }
            catch
            { 
            
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                employee.Clear();
                employee.GetListBirthdayByDepartmentID(Constant.departmentIDList, DateTime.Today, Convert.ToInt16(cmbMonth.EditValue));
                grvEmployeeInfo.BestFitColumns();
            }
            catch
            { 
            
            }
        }
    }
}
