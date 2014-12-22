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
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace Personnel.Forms
{
    public partial class ResignationList : XtraForm, IShowData
    {
        private ResignationTable _resignation = new ResignationTable();
        private Reports.Resignation resignation = new Reports.Resignation();
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;
        private EmployeeInfo employeeInfo;
        private bool isEdit = false;
        private BarButtonItem saveLayout, loadLayout;

        public ResignationList()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public ResignationList(EmployeeInfo employeeInfo)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeInfo = employeeInfo;
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "RESIGNATIONLIST_PAGE" }, new string[] { TitleTable.GetValue("RESIGNATIONLIST_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "UPDATE_PAGEGROUP", "EXPORT_PAGEGROUP", "OPTION_PAGEGROUP" }, new string[] { TitleTable.GetValue("UPDATE_PAGEGROUP", Constant.language), TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "SAVE", imlFunction.Images[0], TitleTable.GetValue("SAVE", Constant.language), new ItemClickEventHandler(bbiSave_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "RESTORE", imlFunction.Images[1], TitleTable.GetValue("RESTORE", Constant.language), new ItemClickEventHandler(bbiRestore_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "RETURN", imlFunction.Images[2], TitleTable.GetValue("RETURN", Constant.language), new ItemClickEventHandler(bbiReturn_ItemClick));

            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "PREVIEW", imlFunction.Images[3], TitleTable.GetValue("PREVIEW", Constant.language), new ItemClickEventHandler(bbiPreview_ItemClick));

            saveLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[2], "SAVE_LAYOUT", imlFunction.Images[4], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            loadLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[2], "LOAD_LAYOUT", imlFunction.Images[5], TitleTable.GetValue("LOAD_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiLoadLayout_ItemClick));

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

        private void bbiLoadLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)loadLayout.DropDownControl;
            bgvResignationList.RestoreLayout(popupControl.Controls["cboLanguage"].Text);
        }

        private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)saveLayout.DropDownControl;
            if (bgvResignationList.SaveLayout(popupControl.Controls["cboLanguage"].Text))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowData(string departmentIDList, bool check)
        {
            if (check)
                _resignation.GetListByDepartmentID(departmentIDList, dedFromDate.DateTime, dedToDate.DateTime, EmployeeTable.GetIDByCode(txtEmployeeCode.Text));
            else
                _resignation.DeleteByDepartmentID(departmentIDList);
            grdResignationList.DataSource = _resignation;
            bgvResignationList.BestFitColumns();
            isEdit = false;
        }

        private void ResignationList_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dedToDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

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

        private void bbiSave_ItemClick(object sender, EventArgs e)
        {
            _resignation.Update();
            isEdit = false;
        }

        private void bbiRestore_ItemClick(object sender, EventArgs e)
        {
            if (bgvResignationList.FocusedRowHandle < 0) return;
            _resignation.Delete((int)bgvResignationList.GetFocusedRowCellValue("EmployeeID"), (DateTime)bgvResignationList.GetFocusedRowCellValue("FromDate"));
        }

        private void bbiReturn_ItemClick(object sender, EventArgs e)
        {
            if (bgvResignationList.FocusedRowHandle < 0) return;
            new ReturnToWork((int)bgvResignationList.GetRowCellValue(bgvResignationList.FocusedRowHandle, "EmployeeID")).ShowDialog();
        }


        private void bbiPreview_ItemClick(object sender, EventArgs e)
        {
            resignation = new Reports.Resignation(dedFromDate.DateTime, dedToDate.DateTime, Constant.currentUser.FullName, DateTime.Today);
            resignation.DataSource = _resignation;
            resignation.PrintingSystem.PreviewFormEx.Owner = this;
            resignation.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            Utility.SetSkin(resignation.PrintingSystem.PreviewFormEx);
            resignation.ShowPreview();
        }
        private void bgvResignationList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                isEdit = true;
            }
        }

        private void bgvResignationList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (bgvResignationList.RowCount == 0)
            {
                isEdit = false;
            }
        }

        private void bgvResignationList_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData) e.Value = e.RowHandle + 1;
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            _resignation.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void bgvResignationList_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ToDate" && e.CellValue != DBNull.Value && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == 8 || txtEmployeeCode.Text.Length == 0)
            {
                _resignation.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void ResignationList_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}