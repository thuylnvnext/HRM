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
    public partial class MonthWorking : XtraForm, IShowData, IBandedGridViewParent
    {
        private EmployeeTable employee = new EmployeeTable();
        private DepartmentTable department = new DepartmentTable();
        private WorkingCycleTable workingCycle = new WorkingCycleTable();
        private WorkingCycleRow wcr;
        private Reports.MonthWorking monthWorking;
        private MonthAttendanceTable _monthAttendance = new MonthAttendanceTable();
        protected AttendanceTableGroupTable attendanceTableGroup = new AttendanceTableGroupTable();
        private AttendanceTableTable attendanceTable1 = new AttendanceTableTable(), attendanceTable2 = new AttendanceTableTable();
        private bool setFieldName = true, change = false;
        protected string iDList, groupIDList, pageCategoryText;
        private SetGridBand setGridBand;
        private GridBand band;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        private BarButtonItem saveLayout, loadLayout;

        public MonthWorking()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            //pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { TitleTable.GetValue("MONTHWORKING_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] {TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "PREVIEW", imlFunction.Images[1], TitleTable.GetValue("PREVIEW", Constant.language), new ItemClickEventHandler(bbiPreview_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "EXPORT", imlFunction.Images[2], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[2], "SAVE_LAYOUT", imlFunction.Images[3], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            saveLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "SAVE_LAYOUT", imageList.Images[6], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            loadLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "LOAD_LAYOUT", imageList.Images[7], TitleTable.GetValue("LOAD_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiLoadLayout_ItemClick));

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
                if (band.Index + 1 < bgvMonthWorking.Bands.Count)
                {
                    band = bgvMonthWorking.Bands[band.Index + 1];
                    setGridBand.FillData(band);
                }
            }
        }

        public void ShowData(string departmentIDList, bool check)
        {
            //WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
            //waitDialog.Show();
            //Application.DoEvents();
            wcr = workingCycle.GetInfo(Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
            //if (setFieldName) SetFieldName(wcr);
            bgvMonthWorking.BeginDataUpdate();
            if (check)
                _monthAttendance.GetWorkingListByDepartmentID(departmentIDList, wcr.FromDate, wcr.ToDate, EmployeeTable.GetIDByCode(txtEmployeeCode.Text), iDList, groupIDList);
            else
                _monthAttendance.DeleteByDepartmentID(departmentIDList);
            bgvMonthWorking.EndDataUpdate();
            bgvMonthWorking.ExpandAllGroups();
            //bgvMonthWorking.UpdateSummary();
            if (setFieldName)
            {
                bgvMonthWorking.RestoreLayout(0, 0, Constant.language);
                //SetColumn(wcr.Days);
            }
            //waitDialog.Close();
        }

        protected void InitGridView(string name, string iDList, string groupIDList, string pageCategoryText)
        {
            bgvMonthWorking.Name = name;
            this.iDList = iDList;
            this.groupIDList = groupIDList;
            this.pageCategoryText = pageCategoryText;


            //AddPageCategory();
            Utility.SetSkin(this);

            //attendanceTableGroup.GetContent();
            //attendanceTable1.GetListByID(iDList);
            //AddBand("grbDaysInWorkingCycle", attendanceTableGroup.FindByPrimaryKey("1").Name, string.Empty, 1, DevExpress.XtraGrid.Columns.FixedStyle.None, bgvMonthWorking.Bands);
            //for (int d = 1; d <= 31; d++)
            //{
            //    AddBand("grb" + d.ToString(), string.Empty, string.Empty, 2, DevExpress.XtraGrid.Columns.FixedStyle.None, bgvMonthWorking.Bands["grbDaysInWorkingCycle"].Children);
            //    foreach (AttendanceTableRow atr in attendanceTable1)
            //    {
            //        AddColumn(atr.ID + d.ToString(), atr.Name, bgvMonthWorking.Bands["grbDaysInWorkingCycle"].Children["grb" + d.ToString()]);
            //    }
            //}

            bgvMonthWorking.Data = _monthAttendance;
            //bgvMonthWorking.GroupTable = attendanceTableGroup;
            //attendanceTable2.GetListByItemGroupID(groupIDList);
            //foreach (AttendanceTableRow atr in attendanceTable2)
            //{
            //    bgvMonthWorking.AddColumn(atr, false);
            //}
            grdMonthWorking.DataSource = _monthAttendance;
            setFieldName = true;
            ShowData(Constant.departmentIDList, true);
            setFieldName = false;
            //
            FormatColum();
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

        private void SetFieldName(WorkingCycleRow wc)
        {
            int days = wc.Days;
            DateTime d = wc.FromDate;
            GridBandCollection gbc = bgvMonthWorking.Bands["grbDaysInWorkingCycle"].Children;
            BandedGridColumn column = null;
            string iD;
            for (int i = 0; i < days; i++)
            {
                gbc[i].Caption = d.Day.ToString() + '\n' + Utility.GetWeekDay(d);
                foreach (AttendanceTableRow atr in attendanceTable1)
                {
                    iD = atr.ID + d.Day.ToString();
                    column = gbc[i].Columns[0];
                    column.FieldName = iD;
                    if (atr.DataType == "Number")
                    {
                        if (_monthAttendance.Columns[iD] == null) _monthAttendance.Columns.Add(new DataColumn(iD, Type.GetType("System.Decimal")));
                        column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        column.DisplayFormat.FormatString = "#,##0." + new string('#', atr.Rounding > 0 ? atr.Rounding : 0) + ";; ";
                        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        column.SummaryItem.FieldName = iD;
                        column.SummaryItem.DisplayFormat = "{0:#,##0." + new string('#', atr.Rounding > 0 ? atr.Rounding : 0) + ";; }";
                        GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                        summaryItem.ShowInGroupColumnFooter = column;
                        summaryItem.FieldName = iD;
                        summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        summaryItem.DisplayFormat = "{0:#,##0." + new string('#', atr.Rounding > 0 ? atr.Rounding : 0) + ";; }";
                        summaryItem.Tag = iD;
                        bgvMonthWorking.GroupSummary.Remove(bgvMonthWorking.GroupSummary[iD]);
                        bgvMonthWorking.GroupSummary.Add(summaryItem);
                    }
                }
                if (d.DayOfWeek == DayOfWeek.Sunday)
                {
                    foreach (AttendanceTableRow atr in attendanceTable1)
                    {
                        gbc[i].Columns[0].AppearanceCell.Options.UseBackColor = true;
                        gbc[i].Columns[0].AppearanceCell.BackColor = Color.Red;
                    }
                }
                else
                    foreach (AttendanceTableRow atr in attendanceTable1)
                    {
                        gbc[i].Columns[0].AppearanceCell.BackColor = Color.Empty;
                    }

                d = d.AddDays(1);
            }
        }

        private void SetColumn(int days)
        {
            bool stop = false;
            for (int i = days; i < 31; i++)
            {
                bgvMonthWorking.Bands["grbDaysInWorkingCycle"].Children[i].Visible = false;
            }

            int d = days - 1;
            while (!stop)
            {
                if (!bgvMonthWorking.Bands["grbDaysInWorkingCycle"].Children[d].Visible)
                {
                    bgvMonthWorking.Bands["grbDaysInWorkingCycle"].Children[d].Visible = true;
                    d--;
                }
                else
                {
                    stop = true;
                }
            }
        }

        private void MonthWorking_Load(object sender, EventArgs e)
        {
            workingCycle.GetContent();

            for (int i = 2008; i <= 2020; i++)
            {
                cboYear.Properties.Items.Add(i);
            }

            //department.GetContent();
            //foreach (DepartmentRow dr in department)
            //{
            //    icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.Name, dr.SortOrder.ToString("000") + dr.Name, 0));
            //}
            department.GetFullPath(Constant.currentUser.Name);
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr["FullPath"].ToString(), dr["FullPath"], 0));
            }

            try
            {
                //Utility.SetPermission(this);

                cboMonth.SelectedIndex = DateTime.Today.Month - 1;

                change = true;

                cboYear.SelectedIndex = DateTime.Today.Year - 2008;

                AddPageCategory();

                SetPermissionPage(pageCategory);
            }
            catch
            {
            }
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
            //if (bgvMonthWorking.Columns.Count > 5)
            //{
            if (change)
            {
                setFieldName = true;
                _monthAttendance.Clear();
                ShowData(Constant.departmentIDList, true);
                setFieldName = false;
            }
            //}
        }

        private void bgvMonthWorking_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData)
            {
                if (e.RowHandle > 0)
                {
                    if (bgvMonthWorking.GetRowCellValue(e.RowHandle, "EmployeeID").ToString() == bgvMonthWorking.GetRowCellValue(e.RowHandle - 1, "EmployeeID").ToString())
                    {
                        e.Value = bgvMonthWorking.GetRowCellValue(e.RowHandle - 1, "No");
                    }
                    else
                    {
                        if (e.RowHandle == bgvMonthWorking.GetDataRowHandleByGroupRowHandle(bgvMonthWorking.GetParentRowHandle(e.RowHandle)))
                            e.Value = 1;
                        else
                            e.Value = Convert.ToInt32(bgvMonthWorking.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                    }
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void bgvMonthWorking_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            //GridBand gridBand = e.Band;

            //if (gridBand.Caption.IndexOf("CN") > 0 || (gridBand.ParentBand != null && gridBand.ParentBand.Caption.IndexOf("CN") > 0))
            //{
            //    Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Red, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            //    Rectangle r = e.Bounds;
            //    ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            //    r.Inflate(0, -1);
            //    e.Graphics.FillRectangle(brush, r);
            //    r.Inflate(0, 0);
            //    e.Appearance.DrawString(e.Cache, e.Info.Caption, r);
            //    e.Handled = true;
            //}
        }

        private void bbiPreview_ItemClick(object sender, EventArgs e)
        {
            monthWorking = new Reports.MonthWorking(bgvMonthWorking, Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
            GridSummaryItem xx =  bcoOTNT00.SummaryItem;
            monthWorking.DataSource = _monthAttendance;
            monthWorking.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            monthWorking.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            monthWorking.PrintingSystem.PreviewFormEx.Owner = this;
            monthWorking.ShowPreview();
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == Convert.ToInt32(ConstantTable.GetValueByName("CodeLength")) || txtEmployeeCode.Text.Length == 0)
            {
                _monthAttendance.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bbiExport_ItemClick(object sender, EventArgs e)
        {
            //if (sfdExportToExcel.ShowDialog() == DialogResult.OK)
            //{
            //    //bgvMonthWorking.ExportToXls(sfdExportToExcel.FileName, new DevExpress.XtraPrinting.XlsExportOptions(TextExportMode.Text, true));
            //    WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Program.language));
            //    waitDialog.Show();
            //    Application.DoEvents();
            //    string[] departments = Constant.departmentIDList.Split(new char[] { ',' });
            //    Classes.MonthAttendance monthAttendance = new HRMplus.Classes.MonthAttendance(sfdExportToExcel.FileName, "Bảng chấm công", "Times New Roman", bgvMonthAttendance, departments.Length, Convert.ToInt32(cboMonth.Text), Convert.ToInt32(cboYear.Text));
            //    monthAttendance.FillData();
            //    waitDialog.Close();
            //}


            if (sfdExportToExcel.ShowDialog() == DialogResult.OK)
            {
                WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                waitDialog.Show();
                Application.DoEvents();
                string[] departments = Constant.departmentIDList.Split(new char[] { ',' });
                Classes.MonthWorking monthWorking = new Classes.MonthWorking(sfdExportToExcel.FileName, String.Format("LT出勤表T{0}-{1}", cboMonth.Text, cboYear.Text), "Times New Roman", bgvMonthWorking, departments.Length, Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                //monthWorking.FillData(maxLevel + 1);
                monthWorking.FillData(3);
                waitDialog.Close();
            }    
        }

        private void chkResignation_CheckedChanged(object sender, EventArgs e)
        {
            _monthAttendance.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void MonthWorking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) ShowData(Constant.departmentIDList, true);
        }

        private void MonthWorking_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        //private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        //{
        //    if (bgvMonthWorking.SaveLayout(wcr.Month, wcr.Year, Constant.language))
        //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    else
        //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}


        private void bbiLoadLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)loadLayout.DropDownControl;
            bgvMonthWorking.RestoreLayout(popupControl.Controls["cboLanguage"].Text);
        }

        private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)saveLayout.DropDownControl;
            if (bgvMonthWorking.SaveLayout(popupControl.Controls["cboLanguage"].Text))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bgvMonthWorking_DoubleClick(object sender, EventArgs e)
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
            //bgvMonthWorking.FocusedColumn.BestFit();
            bgvMonthWorking.BestFitColumns();
        }
        private void FormatColum()
        {
            bcoOTNT00.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNT00.SummaryItem.FieldName = "OTNT00";
            bcoOTNT00.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNT10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNT10.SummaryItem.FieldName = "OTNT10";
            bcoOTNT10.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNL0.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNL0.SummaryItem.FieldName = "OTNL0";
            bcoOTNL0.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNL1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNL1.SummaryItem.FieldName = "OTNL1";
            bcoOTNL1.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";


            bcoOTNT01.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNT01.SummaryItem.FieldName = "OTNT01";
            bcoOTNT01.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";


            bcoOTNT11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNT11.SummaryItem.FieldName = "OTNT11";
            bcoOTNT11.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNN10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNN10.SummaryItem.FieldName = "OTNN10";
            bcoOTNN10.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNN00.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNN00.SummaryItem.FieldName = "OTNN00";
            bcoOTNN00.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNN11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNN11.SummaryItem.FieldName = "OTNN11";
            bcoOTNN11.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";

            bcoOTNN01.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bcoOTNN01.SummaryItem.FieldName = "OTNN01";
            bcoOTNN01.SummaryItem.DisplayFormat = "{0:#,##0.#;-#,##0;0}";
        }
        private void smiFormat_Click(object sender, EventArgs e)
        {
            //BandedGridColumn column;
            //int days = wcr.Days;
            //DateTime d = wcr.FromDate;
            //string iD;
            //for (int i = 0; i < days; i++)
            //{
            //    foreach (AttendanceTableRow atr in attendanceTable1)
            //    {
            //        if (atr.DataType == "Number")
            //        {
            //            iD = atr.ID + d.Day.ToString();
            //            column = bgvMonthWorking.Columns.ColumnByFieldName(iD);
            //            if (column != null)
            //            {
            //                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //                column.SummaryItem.FieldName = iD;
            //                column.SummaryItem.DisplayFormat = "{0:#,##0." + new string('#', atr.Rounding > 0 ? atr.Rounding : 0) + ";; }";
            //            }
            //        }
            //    }
            //    d = d.AddDays(1);
            //}
            //foreach (AttendanceTableRow atr in attendanceTable2)
            //{
            //    column = bgvMonthWorking.Columns.ColumnByFieldName(atr.ID);
            //    if (column != null)
            //    {
            //        bgvMonthWorking.FormatColumn(column, atr);
            //        foreach (GridGroupSummaryItem summaryItem in bgvMonthWorking.GroupSummary)
            //        {
            //            if (summaryItem.FieldName == atr.ID && summaryItem.ShowInGroupColumnFooter == null)
            //            {
            //                bgvMonthWorking.GroupSummary.Remove(summaryItem);
            //                break;
            //            }
            //        }
            //    }
            //}
        }
    }
}
