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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Attendance.Forms
{
    public partial class TimeInDM : XtraForm, IShowData, IBandedGridViewParent
    {
        private EmployeeTable employee = new EmployeeTable();
        private DepartmentTable department = new DepartmentTable();
        private WorkingCycleTable workingCycle = new WorkingCycleTable();
        private WorkingCycleRow wcr;

        private Reports.ReportData reportData = new Reports.ReportData();

        private bool change = false, setFieldName = false;
        private SetGridBand setGridBand;
        private GridBand band;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;
        private const int fixBrand = 5;

        private BarButtonItem saveLayout, loadLayout;
        private string employeeIDList = string.Empty;

        public TimeInDM()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "MONTHOT_PAGE" }, new string[] { TitleTable.GetValue("MONTHOT_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "EXPORT", imlFunction.Images[3], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));

            saveLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "SAVE_LAYOUT", imageListEx.Images[2], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            loadLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "LOAD_LAYOUT", imageListEx.Images[3], TitleTable.GetValue("LOAD_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiLoadLayout_ItemClick));

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

        public void NextGridBand()
        {
            if (band.ParentBand != null)
            {
                if (band.Index + 1 < band.ParentBand.Children.Count)
                {
                    band = band.ParentBand.Children[band.Index + 1];
                    setGridBand.FillData(band);
                }
            }
            else
            {
                if (band.Index + 1 < bgvMonthOT.Bands.Count)
                {
                    band = bgvMonthOT.Bands[band.Index + 1];
                    setGridBand.FillData(band);
                }
            }
        }

        public void ShowData(string departmentIDList, bool check)
        {            
            WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
            waitDialog.Show();
            Application.DoEvents();
            if (setFieldName) SetFieldName();
            bgvMonthOT.BeginDataUpdate();
            reportData.GetMonthOTByDepartmentID(departmentIDList, wcr.FromDate, wcr.ToDate, employeeIDList, check);
            bgvMonthOT.EndDataUpdate();
            bgvMonthOT.ExpandAllGroups();
            if (setFieldName)
            {
                bgvMonthOT.RestoreLayout(0, 0, Constant.language);
                SetColumn(wcr.Days);
            }
            smiFormat_Click(null, null);
            bgvMonthOT.BestFitColumns();
            waitDialog.Close();
        }

        private void InitGridView(DevExpress.XtraEditors.Repository.RepositoryItem editor)
        {
            for (int d = 1; d <= 31; d++)
            {
                GridBand gb = AddBand("grb" + d.ToString(), string.Empty, string.Empty, 2, DevExpress.XtraGrid.Columns.FixedStyle.None, bgvMonthOT.Bands);
                AddColumnOT("TimeOut" + d, String.Format("[C{0}]", d), gb.Children);
                //AddColumnOT("T" + d, "Số\ngiờ", gb.Children);
            }
            
            //
            //GridBand gridBand = AddBand("grbTotal", "TOTAL", "TOTAL", 2, DevExpress.XtraGrid.Columns.FixedStyle.None, bgvMonthOT.Bands);
            //AddColumnOT("OT30", "30%", "TOT30", gridBand.Children);
            //AddColumnOT("OT150", "150%", "TOT150", gridBand.Children);
            //AddColumnOT("OT195", "195%", "TOT195", gridBand.Children);
            //AddColumnOT("OT200", "200%", "TOT200", gridBand.Children);
            //AddColumnOT("OT260", "260%", "TOT260", gridBand.Children);
            //AddColumnOT("OT300", "300%", "TOT300", gridBand.Children);

            bgvMonthOT.Data = reportData.MonthOT;
            grdMonthOT.DataSource = reportData.MonthOT;
        }

        private GridBand AddBand(string name, string caption, string toolTip, int rowCount, DevExpress.XtraGrid.Columns.FixedStyle _fixed, GridBandCollection gbc)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.ToolTip = toolTip;
            gridBand.Width = 50;
            gridBand.RowCount = rowCount;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;            
            gridBand.AppearanceHeader.Options.UseFont = true;
            gridBand.AppearanceHeader.Font = new Font(gridBand.AppearanceHeader.Font, FontStyle.Bold);            
            gridBand.Fixed = _fixed;
            gbc.Add(gridBand);
            return gridBand;
        }

        private BandedGridColumn AddColumnOT(string name, string caption, string fieldname, GridBandCollection gbc)
        {
            GridBand gridBand = AddBand("grb" + name, caption, string.Empty, 2, DevExpress.XtraGrid.Columns.FixedStyle.None, gbc);
            BandedGridColumn column = new BandedGridColumn();
            column.Name = "bco" + name;
            column.Caption = caption;
            column.FieldName = fieldname;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = gridBand;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            column.DisplayFormat.FormatType = FormatType.Custom;
            column.DisplayFormat.FormatString = "{0:#,##0.#;;}";

            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.FieldName = fieldname;
            column.SummaryItem.DisplayFormat = "{0:#,##0.#;;}";

            GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
            summaryItem.ShowInGroupColumnFooter = column;
            summaryItem.FieldName = fieldname;
            summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            summaryItem.DisplayFormat = "{0:#,##0.#;;}";
            summaryItem.Tag = fieldname;
            bgvMonthOT.GroupSummary.Remove(bgvMonthOT.GroupSummary[fieldname]);
            bgvMonthOT.GroupSummary.Add(summaryItem);

            return column;
        }

        private BandedGridColumn AddColumnOT(string name, string caption, GridBandCollection gbc)
        {
            GridBand gridBand = AddBand("grb" + name, caption, string.Empty, 2, DevExpress.XtraGrid.Columns.FixedStyle.None, gbc);
            BandedGridColumn column = new BandedGridColumn();
            column.Name = "bco" + name;
            column.Caption = caption;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = gridBand;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            return column;
        }

        private BandedGridColumn AddColumn(string name, string caption, GridBandCollection gbc)
        {
            GridBand gridBand = AddBand("grb" + name, caption, string.Empty, 1, DevExpress.XtraGrid.Columns.FixedStyle.None, gbc);
            BandedGridColumn column = new BandedGridColumn();
            column.Name = "bco" + name;
            column.Caption = caption;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = gridBand;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;            

            return column;
        }

        private BandedGridColumn AddColumn(string name, string caption, GridBand grb)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Name = "bco" + name;
            column.Caption = caption;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = grb;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            return column;
        }

        private void SetFieldName()
        {
            int days = wcr.Days;
            DateTime d = wcr.FromDate;
            GridBandCollection gbc = bgvMonthOT.Bands;
            BandedGridColumn column = null;
            int indexIn = 0, indexOut = 1, indexCol = 0;
            for (int i = 0; i < days; i++)
            {
                gbc[i + fixBrand].Caption = d.Day.ToString() + '-' + Utility.ToShortMonthName(d);
                column = gbc[i + fixBrand].Children[indexIn].Columns[indexCol];
                column.FieldName = "TimeOut" + d.Day.ToString();
                column.DisplayFormat.FormatType = FormatType.Custom;
                column.DisplayFormat.FormatString = "HH:mm";
                //column = gbc[i + fixBrand].Children[indexOut].Columns[indexCol];
                //column.FieldName = "T" + d.Day.ToString();
                //column.DisplayFormat.FormatType = FormatType.Custom;
                //column.DisplayFormat.FormatString = "{0:#,##0.#;;}";

                //GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                //summaryItem.ShowInGroupColumnFooter = column;
                //summaryItem.FieldName = "T" + d.Day.ToString();
                //summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //summaryItem.DisplayFormat = "{0:#,##0.#;;}";
                //summaryItem.Tag = "T" + d.Day.ToString();
                //bgvMonthOT.GroupSummary.Remove(bgvMonthOT.GroupSummary["T" + d.Day.ToString()]);
                //bgvMonthOT.GroupSummary.Add(summaryItem);

                d = d.AddDays(1);
            }
        }

        private void SetColumn(int days)
        {
            bool stop = false;
            for (int i = days; i < 31; i++)
            {
                bgvMonthOT.Bands[i + fixBrand].Visible = false;
            }

            int d = days + fixBrand - 1;
            while (!stop)
            {
                if (!bgvMonthOT.Bands[d].Visible)
                {
                    bgvMonthOT.Bands[d].Visible = true;
                    d--;
                }
                else
                {
                    stop = true;
                }
            }
        }

        private void MonthOT_Load(object sender, EventArgs e)
        {
            workingCycle.GetContent();

            for (int i = 2008; i <= 2020; i++)
            {
                cboYear.Properties.Items.Add(i);    
            }

            department.GetFullPath(Constant.currentUser.Name);
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr["FullPath"].ToString(), dr["FullPath"], 0));
            }

            InitGridView(null);

            cboMonth.SelectedIndex = DateTime.Today.Month - 1;
            change = true;
            cboYear.SelectedIndex = DateTime.Today.Year - 2008;

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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change)
            {
                wcr = workingCycle.GetInfo(Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                setFieldName = true;
                reportData.MonthOT.Clear();
                ShowData(Constant.departmentIDList, true);
                setFieldName = false;
            }
        }

        private void bgvMonthOT_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData)
            {
                if (e.RowHandle > 0)
                {
                    if (bgvMonthOT.GetRowCellValue(e.RowHandle, "EmployeeID").ToString() == bgvMonthOT.GetRowCellValue(e.RowHandle - 1, "EmployeeID").ToString())
                    {
                        e.Value = bgvMonthOT.GetRowCellValue(e.RowHandle - 1, "No");
                    }
                    else
                    {
                        if (e.RowHandle == bgvMonthOT.GetDataRowHandleByGroupRowHandle(bgvMonthOT.GetParentRowHandle(e.RowHandle)))
                            e.Value = 1;
                        else
                            e.Value = Convert.ToInt32(bgvMonthOT.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                    }
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void bgvMonthOT_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            GridBand gridBand = e.Band;
            if (gridBand.Caption.IndexOf("CN") > 0 || (gridBand.ParentBand != null && gridBand.ParentBand.Caption.IndexOf("CN") > 0))
            {
                Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.FromArgb(0, 255, 255), Color.FromArgb(0, 255, 255), System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
                Rectangle r = e.Bounds;
                ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
                r.Inflate(0, -1);
                e.Graphics.FillRectangle(brush, r);
                r.Inflate(0, 0);
                e.Appearance.DrawString(e.Cache, e.Info.Caption, r);
                e.Handled = true;
            }
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == Convert.ToInt32(ConstantTable.GetValueByName("CodeLength")) || txtEmployeeCode.Text.Length == 0)
            {
                reportData.MonthOT.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bbiExport_ItemClick(object sender, EventArgs e)
        {
            if (sfdExportToExcel.ShowDialog() == DialogResult.OK)
            {
                WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                waitDialog.Show();
                Application.DoEvents();
                string[] departments = Constant.departmentIDList.Split(new char[] { ',' });
                wcr = workingCycle.GetInfo(Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                SetColumn(wcr.Days);
                Classes.TimeInTimeOut timeInTimeOut = new Classes.TimeInTimeOut(sfdExportToExcel.FileName, String.Format("OT-{0}-{1}", cboMonth.Text, cboYear.Text), "Times New Roman", bgvMonthOT, departments.Length, wcr.FromDate, wcr.ToDate, Convert.ToInt16(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                timeInTimeOut.FillDataMonthOT(1);
                waitDialog.Close();
            }          
        }

        private void chkResignation_CheckedChanged(object sender, EventArgs e)
        {
            reportData.MonthOT.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void MonthOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                reportData.MonthOT.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void MonthOT_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)saveLayout.DropDownControl;
            if (bgvMonthOT.SaveLayout(popupControl.Controls["cboLanguage"].Text))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bbiLoadLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)loadLayout.DropDownControl;
            bgvMonthOT.RestoreLayout(popupControl.Controls["cboLanguage"].Text);
        }

        private void bgvMonthOT_DoubleClick(object sender, EventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hitInfo;
            if (view == null) return;
            Point point = view.GridControl.PointToClient(Control.MousePosition);
            hitInfo = view.CalcHitInfo(new Point(point.X, point.Y));
            band = hitInfo.Band;
            if (band != null && hitInfo.InBandPanel)
            {
                setGridBand = new SetGridBand(band, this);
                setGridBand.ShowDialog();
            }
        }

        private void smiBestFit_Click(object sender, EventArgs e)
        {
            bgvMonthOT.BestFitColumns();
        }

        private void smiFormat_Click(object sender, EventArgs e)
        {
            int days = wcr.Days;
            DateTime d = wcr.FromDate;
            GridBandCollection gbc = bgvMonthOT.Bands;
            BandedGridColumn column = null;
            int indexIn = 0, indexOut = 1, indexCol = 0;
            for (int i = 0; i < days; i++)
            {
                column = gbc[i + fixBrand].Children[indexIn].Columns[indexCol];
                column.DisplayFormat.FormatType = FormatType.Custom;
                column.DisplayFormat.FormatString = "HH:mm";
                
                //column = gbc[i + fixBrand].Children[indexOut].Columns[indexCol];
                //column.DisplayFormat.FormatType = FormatType.Custom;
                //column.DisplayFormat.FormatString = "{0:#,##0.#;;}";

                //column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //column.SummaryItem.FieldName = "T" + d.Day.ToString();
                //column.SummaryItem.DisplayFormat = "{0:#,##0.#;;}";
                d = d.AddDays(1);
            }
        }
    }
}
