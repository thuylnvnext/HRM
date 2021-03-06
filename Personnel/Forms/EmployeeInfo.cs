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
    public partial class EmployeeInfo : XtraForm, IShowData
    {
        private EmployeeTable employee = new EmployeeTable();
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;
        private bool textChanged = true;
        private BarButtonItem bbiLabourContract;
        private GridHitInfo hitInfo = null;

        public EmployeeInfo()
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
            pageCategory.AddPage(new string[] { "EMPLOYEEINFO_PAGE" }, new string[] { TitleTable.GetValue("EMPLOYEEINFO_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "EMPLOYEEINFO_PAGEGROUP"/*, "LABOURCONTRACT_PAGEGROUP"*/, "TRANSFER_PAGEGROUP", "EXPORT_PAGEGROUP", "OPTION_PAGEGROUP" }, new string[] { TitleTable.GetValue("EMPLOYEEINFO_PAGEGROUP", Constant.language)/*, TitleTable.GetValue("LABOURCONTRACT_PAGEGROUP", Constant.language)*/, TitleTable.GetValue("TRANSFER_PAGEGROUP", Constant.language), TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "ADD_EMPLOYEE", imlFunction.Images[0], TitleTable.GetValue("ADD_EMPLOYEE", Constant.language), new ItemClickEventHandler(bbiAddEmployee_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "IMPORT", imlFunction.Images[1], TitleTable.GetValue("IMPORT", Constant.language), new ItemClickEventHandler(bbiImport_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "ADVANDCED_SEARCH", imlFunction.Images[2], TitleTable.GetValue("ADVANDCED_SEARCH", Constant.language), new ItemClickEventHandler(bbiAdvancedSearch_ItemClick));
            //bbiLabourContract = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "CONTRACT_FORM", imlFunction.Images[3], TitleTable.GetValue("CONTRACT_FORM", Constant.language), null);
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "LABOURCONTRACT_PREVIEW", imlFunction.Images[4], TitleTable.GetValue("LABOURCONTRACT_PREVIEW", Constant.language), new ItemClickEventHandler(bbiLabourContractPreview_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "LIMITLABOURCONTRACT_PREVIEW", imlFunction.Images[5], TitleTable.GetValue("LIMITLABOURCONTRACT_PREVIEW", Constant.language), new ItemClickEventHandler(bbiLimitLabourContractPreview_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "PERMANENTLABOURCONTRACT_PREVIEW", imlFunction.Images[6], TitleTable.GetValue("PERMANENTLABOURCONTRACT_PREVIEW", Constant.language), new ItemClickEventHandler(bbiPermanentLabourContractPreview_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "TRANSFER_DEPARTMENT", imlFunction.Images[7], TitleTable.GetValue("TRANSFER_DEPARTMENT", Constant.language), new ItemClickEventHandler(bbiTransferDepartment_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[2], "EXPORT", imlFunction.Images[8], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[3], "OPTION", imlFunction.Images[9], TitleTable.GetValue("OPTION", Constant.language), new ItemClickEventHandler(bbiDisplayOptions_ItemClick));
            IMdiParent mdiParent = (IMdiParent)MdiParent;
            ribbon = mdiParent.GetRibbonControl;
            //bbiLabourContract.ButtonStyle = BarButtonStyle.DropDown;
            //bbiLabourContract.DropDownControl = CreatePopupMenu();
            ribbon.PageCategories.Add(pageCategory);
            selectedPage = ribbon.SelectedPage;
            ribbon.SelectedPage = pageCategory.Pages[0];
        }

        private void RemovePageCategory()
        {
            ribbon.PageCategories.Remove(pageCategory);
            ribbon.SelectedPage = selectedPage;
        }

        public PopupMenu CreatePopupMenu()
        {
            PopupMenu popupMenu = new PopupMenu(ribbon.Manager);
            BarButtonItem[] bbiForm = new BarButtonItem[] { new BarButtonItem(), new BarButtonItem(), new BarButtonItem() };

            bbiForm[0].Caption = TitleTable.GetValue("LABOURCONTRACT_FORM", Constant.language);
            bbiForm[0].Id = 0;
            bbiForm[0].ItemClick += new ItemClickEventHandler(bbiForm_ItemClick);
            bbiForm[1].Caption = TitleTable.GetValue("LIMITLABOURCONTRACT_FORM", Constant.language);
            bbiForm[1].Id = 1;
            bbiForm[1].ItemClick += new ItemClickEventHandler(bbiForm_ItemClick);
            bbiForm[2].Caption = TitleTable.GetValue("PERMANENTLABOURCONTRACT_FORM", Constant.language);
            bbiForm[2].Id = 2;
            bbiForm[2].ItemClick += new ItemClickEventHandler(bbiForm_ItemClick);
            popupMenu.AddItems(bbiForm);

            return popupMenu;
        }

        private void InitFieldList()
        {
            EmployeeInfoListTable employeeInfoList = new EmployeeInfoListTable();
            GridColumn col;
            employeeInfoList.GetContent();
            foreach (EmployeeInfoListRow eilr in employeeInfoList)
            {
                if (eilr.VisibleIndex > -1)
                {
                    col = new GridColumn();
                    col.Name = "col" + eilr.FieldName;
                    col.FieldName = eilr.FieldName;
                    col.Caption = eilr.Caption;
                    col.VisibleIndex = eilr.VisibleIndex;
                    col.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
                    col.OptionsColumn.AllowEdit = false;
                    col.OptionsColumn.ReadOnly = true;
                    col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                    if (eilr.DataType == "DateTime")
                    {
                        col.DisplayFormat.FormatString = "dd/MM/yyyy";
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    }
                    if (eilr.FieldName == "Type")
                    {
                        col.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                    }
                    col.AppearanceCell.Options.UseTextOptions = true;
                    switch (eilr.Alignment)
                    {
                        case 1:
                            col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                            break;
                        case 2:
                            col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                            break;
                        case 3:
                            col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                            break;
                    }
                    if (eilr.FieldName == "FullName")
                    {
                        col.AppearanceCell.Options.UseFont = true;
                        col.AppearanceCell.Font = new Font(col.AppearanceCell.Font, FontStyle.Bold);
                        col.AppearanceCell.Options.UseForeColor = true;
                        col.AppearanceCell.ForeColor = SystemColors.HotTrack;
                    }
                    col.AppearanceHeader.Options.UseFont = true;
                    col.AppearanceHeader.Font = new Font(col.AppearanceHeader.Font, FontStyle.Bold);
                    col.AppearanceHeader.Options.UseTextOptions = true;
                    col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    col.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    grvEmployeeInfo.Columns.Add(col);
                }
            }
            col = new GridColumn();
            col.Name = "colResignation";
            col.FieldName = "Resignation";
            col.VisibleIndex = -1;
            col.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            col.OptionsColumn.AllowEdit = false;
            col.OptionsColumn.ReadOnly = true;
            col.AppearanceCell.Options.UseTextOptions = true;
            col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            col.AppearanceHeader.Options.UseFont = true;
            col.AppearanceHeader.Font = new Font(col.AppearanceHeader.Font, FontStyle.Bold);
            col.AppearanceHeader.Options.UseTextOptions = true;
            col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            grvEmployeeInfo.Columns.Add(col);
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
                if (txtCode.Text != string.Empty || txtFullName.Text != string.Empty) employee.Clear();
                employee.GetListByDepartmentID(departmentIDList, DateTime.Today, EmployeeTable.GetIDByCode(txtCode.Text), Constant.currentUser.Name);
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

        private void DeleteEmployee()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_EMPLOYEE", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (retVal == DialogResult.OK)
            {
                retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("MOVE_RESIGNATION", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int[] selectedRows = grvEmployeeInfo.GetSelectedRows();
                if (retVal == DialogResult.Yes)
                {
                    string employeeIDList = string.Empty;
                    string departmentIDList = string.Empty;
                    string postionIDList = string.Empty;
                    foreach (int r in selectedRows)
                    {
                        employeeIDList += (employeeIDList == string.Empty ? "[" : ",[") + grvEmployeeInfo.GetRowCellValue(r, "ID").ToString() + "]";
                        departmentIDList += (departmentIDList == string.Empty ? "[" : ",[") + grvEmployeeInfo.GetRowCellValue(r, "DepartmentID").ToString() + "]";
                        postionIDList += (postionIDList == string.Empty ? "[" : ",[") + grvEmployeeInfo.GetRowCellValue(r, "PositionID").ToString() + "]";
                    }
                    new Resignation(employeeIDList, departmentIDList, postionIDList, this).ShowDialog();
                }
                else
                {
                    if (selectedRows != null)
                    {
                        int[] employeeIDs = new int[selectedRows.Length];
                        for (int i = 0; i < employeeIDs.Length; i++)
                        {
                            employeeIDs[i] = Convert.ToInt32(grvEmployeeInfo.GetRowCellValue(selectedRows[i], "ID"));
                        }
                        foreach (int employeeID in employeeIDs)
                        {
                            employee.Delete(employeeID);
                        }
                        employee.Delete();
                    }
                }
            }
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            InitFieldList();
            txtCode.Text = TitleTable.GetValue("FINDCODE", Constant.language);
            txtFullName.Text = TitleTable.GetValue("FINDFULLNAME", Constant.language);

            grdEmployeeInfo.DataSource = employee;
            ShowData(Constant.departmentIDList, true);

            AddPageCategory();
            //Utility.SetPermission(this);
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
            if (e.Column.FieldName == "Photograph" && e.IsGetData && !employee.FindByPrimaryKey(Convert.ToInt32(grvEmployeeInfo.GetRowCellValue(e.RowHandle, "ID"))).IsPhotoNull())
            {
                try
                {
                    e.Value = new Bitmap(employee.FindByPrimaryKey(Convert.ToInt32(grvEmployeeInfo.GetRowCellValue(e.RowHandle, "ID"))).Photo);
                }
                catch
                {
                }
            }
        }

        private void grvEmployeeInfo_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;

            if (view == null) return;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

            if ((e.Button & MouseButtons.Left) != 0 && hitInfo.InRowCell)
                if (hitInfo.Column.FieldName == "FullName")
                {
                    if (grvEmployeeInfo.GetRowCellValue(hitInfo.RowHandle, "ID") != null) new InfoDetails(this, employee, Convert.ToInt32(grvEmployeeInfo.GetRowCellValue(hitInfo.RowHandle, "ID"))).ShowDialog();
                }
        }

        private void mitDelete_Click(object sender, EventArgs e)
        {
            if (grvEmployeeInfo.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle) DeleteEmployee();
        }

        private void grvEmployeeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && grvEmployeeInfo.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle) DeleteEmployee();
        }

        private void mitTransferDepartment_Click(object sender, EventArgs e)
        {
            EmployeeTable selectedEmployees = new EmployeeTable();
            EmployeeRow er, _er;
            int[] selectRows = grvEmployeeInfo.GetSelectedRows();
            selectedEmployees.Columns.AddRange(new DataColumn[] { new DataColumn("DepartmentID", typeof(string)), new DataColumn("FromDate", typeof(string)), new DataColumn("PositionID", typeof(string)) });
            foreach (int i in selectRows)
            {
                er = (EmployeeRow)selectedEmployees.NewRow();
                _er = (EmployeeRow)grvEmployeeInfo.GetDataRow(i);
                er.ID = _er.ID;
                er.FullName = _er.FullName;
                er.Type = _er.Type;
                er["DepartmentID"] = _er["DepartmentID"];
                er["FromDate"] = _er["FromDate"];
                er["PositionID"] = _er["PositionID"];
                selectedEmployees.AddEmployeeRow(er);
                //selectedEmployees.ImportRow(grvEmployeeInfo.GetDataRow(i));
            }
            new TransferDepartmentByEmployee(selectedEmployees, string.Empty).ShowDialog();
        }

        private void grvEmployeeInfo_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;

                if (view == null) return;

                GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

                if (hitInfo.InRowCell && hitInfo.Column.FieldName == "FullName")
                    Cursor = Cursors.Hand;
                else
                    Cursor = Cursors.Default;
            }
            catch
            {

            }
        }

        private void cmsEmployee_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                cmsEmployee.Items["mitTransferDepartment"].Enabled = cmsEmployee.Items["mitDelete"].Enabled = (grvEmployeeInfo.GetSelectedRows().Length != 0);
                if (grvEmployeeInfo.GetSelectedRows().Length != 0)
                {
                    if (grvEmployeeInfo.GetSelectedRows().Length == 1)
                    {
                        int[] arrIndex = grvEmployeeInfo.GetSelectedRows();
                        int Type = Convert.ToInt16(grvEmployeeInfo.GetRowCellValue(arrIndex[0], "Type"));
                        cmsEmployee.Items["mitChangeType"].Enabled = Type == 0 ? true : false;
                    }
                    else
                        cmsEmployee.Items["mitChangeType"].Enabled = false;
                }
                else
                    cmsEmployee.Items["mitChangeType"].Enabled = false;
            }
            catch
            {

            }
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

        private void EmployeeInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
            //((Common.Main)MdiParent).SetBarItem("bbiLabourContract", false);
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
            TextBrick title = e.Graph.DrawString("DANH SÁCH NHÂN VIÊN", SystemColors.ControlText, new RectangleF(0, 25, e.Graph.ClientPageSize.Width, 50), DevExpress.XtraPrinting.BorderSide.None);
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

        private void bbiAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new AddEmployee(this).Show(this);
        }

        private void bbiAdvancedSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new AdvancedSearch(this).ShowDialog();
        }

        private void bbiTransferDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new TransferDepartment().ShowDialog();
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prsEmployeeInfo.Links[0].CreateDocument();
            prsEmployeeInfo.PreviewFormEx.Owner = this;
            prsEmployeeInfo.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            prsEmployeeInfo.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            prsEmployeeInfo.PreviewFormEx.ShowDialog();
        }

        private void bbiDisplayOptions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new DisplayOptions().ShowDialog();
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == TitleTable.GetValue("FINDCODE", Constant.language))
            {
                txtCode.Font = new Font(txtCode.Font, FontStyle.Regular);
                textChanged = false;
                txtCode.Text = string.Empty;
                textChanged = true;
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == string.Empty)
            {
                txtCode.Font = new Font(txtCode.Font, FontStyle.Italic);
                textChanged = false;
                txtCode.Text = TitleTable.GetValue("FINDCODE", Constant.language);
                textChanged = true;
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == TitleTable.GetValue("FINDFULLNAME", Constant.language))
            {
                txtFullName.Font = new Font(txtFullName.Font, FontStyle.Regular);
                textChanged = false;
                txtFullName.Text = string.Empty;
                textChanged = true;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == string.Empty)
            {
                txtFullName.Font = new Font(txtFullName.Font, FontStyle.Italic);
                textChanged = false;
                txtFullName.Text = TitleTable.GetValue("FINDFULLNAME", Constant.language);
                textChanged = true;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string editValue = (sender as TextEdit).Text;
            if (editValue.Length == Convert.ToInt32(ConstantTable.GetValueByName("CodeLength")) || editValue.Length == 0)
            {
                employee.Clear();
                employee.GetListByDepartmentID(Constant.departmentIDList, DateTime.Today, EmployeeTable.GetIDByCode(editValue), Constant.currentUser.Name);
                grvEmployeeInfo.BestFitColumns();
                if (grvEmployeeInfo.DataRowCount > 0) grdEmployeeInfo.Focus();
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (textChanged)
            {
                employee.FindByFullName(txtFullName.Text, DateTime.Today, Constant.currentUser.Name);
                grvEmployeeInfo.BestFitColumns();
            }
        }

        private void bbiLabourContractPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string employeeIDList = GetSelectedEmployeeIDList();
            EmployeeTable labourContract = new EmployeeTable();

            labourContract.LabourContract(employeeIDList);
            if (labourContract.Count > 0)
            {
                Reports.LabourContract _labourContract = new Reports.LabourContract();
                _labourContract.DataSource = labourContract;
                _labourContract.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
                _labourContract.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
                _labourContract.PrintingSystem.PreviewFormEx.Owner = this;
                _labourContract.ShowPreview();
            }
        }

        private void bbiLimitLabourContractPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string employeeIDList = GetSelectedEmployeeIDList();
            EmployeeTable labourContract = new EmployeeTable();

            labourContract.LimitLabourContract(employeeIDList);
            Reports.LimitLabourContract limitLabourContract = new Reports.LimitLabourContract();
            limitLabourContract.DataSource = labourContract;
            limitLabourContract.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            limitLabourContract.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            limitLabourContract.PrintingSystem.PreviewFormEx.Owner = this;
            limitLabourContract.ShowPreview();
        }

        private void bbiPermanentLabourContractPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string employeeIDList = GetSelectedEmployeeIDList();
            EmployeeTable labourContract = new EmployeeTable();

            labourContract.LimitLabourContract(employeeIDList);
            Reports.PermanentLabourContract permanentLabourContract = new Reports.PermanentLabourContract();
            permanentLabourContract.DataSource = labourContract;
            permanentLabourContract.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            permanentLabourContract.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            permanentLabourContract.PrintingSystem.PreviewFormEx.Owner = this;
            permanentLabourContract.ShowPreview();
        }

        private void bbiForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarButtonItem bbi = (BarButtonItem)e.Item;

            switch (bbi.Id)
            {
                case 0:
                    new ContractForm("LabourContract").ShowDialog();
                    break;
                case 1:
                    new ContractForm("LimitLabourContract").ShowDialog();
                    break;
                case 2:
                    new ContractForm("PermanentLabourContract").ShowDialog();
                    break;
            }
        }

        private void bbiImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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

        private void grdEmployeeInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (hitInfo == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle dragRect = new Rectangle(new Point(hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2, hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                EmployeeTable selectedEmployees = new EmployeeTable();
                EmployeeRow er, _er;
                int[] selectRows = grvEmployeeInfo.GetSelectedRows();
                selectedEmployees.Columns.AddRange(new DataColumn[] { new DataColumn("DepartmentID", typeof(string)), new DataColumn("FromDate", typeof(string)), new DataColumn("PositionID", typeof(string)) });
                foreach (int i in selectRows)
                {
                    er = (EmployeeRow)selectedEmployees.NewRow();
                    _er = (EmployeeRow)grvEmployeeInfo.GetDataRow(i);
                    er.ID = _er.ID;
                    er.FullName = _er.FullName;
                    er["DepartmentID"] = _er["DepartmentID"];
                    er["FromDate"] = _er["FromDate"];
                    er["PositionID"] = _er["PositionID"];
                    selectedEmployees.AddEmployeeRow(er);
                    //selectedEmployees.ImportRow(grvEmployeeInfo.GetDataRow(i));
                }
                grdEmployeeInfo.DoDragDrop(selectedEmployees, DragDropEffects.Copy);
            }
        }

        private void grdEmployeeInfo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void grvEmployeeInfo_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Type" && e.RowHandle > -1)
                    e.DisplayText = Convert.ToInt16(e.Value) == 0 ? "Thử việc" : "Chính thức";
            }
            catch
            {

            }

        }

        private void mitChangeType_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arrIndex = grvEmployeeInfo.GetSelectedRows();
                String FullName = Convert.ToString(grvEmployeeInfo.GetRowCellValue(arrIndex[0], "FullName"));
                int ID = Convert.ToInt32(grvEmployeeInfo.GetRowCellValue(arrIndex[0], "ID"));
                DialogResult retVal = XtraMessageBox.Show(LookAndFeel, "Bạn có chắc chắn muốn chuyển nhân viên " + FullName + " thành nhân viên chính thức không?", TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (retVal == DialogResult.OK)
                {
                    bool chk  = EmployeeTable.ChangeType(ID);
                    if (chk)
                        ShowData(Constant.departmentIDList, true);

                    grvEmployeeInfo.FocusedRowHandle = arrIndex[0];
                }
            }
            catch
            { 
            
            }
        }
    }
}
