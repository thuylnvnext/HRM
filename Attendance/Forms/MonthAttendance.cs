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
    public partial class MonthAttendance : XtraForm, IShowData, IBandedGridViewParent
    {
        private EmployeeTable employee = new EmployeeTable();
        private DepartmentTable department = new DepartmentTable();
        private WorkingCycleTable workingCycle = new WorkingCycleTable();
        private WorkingCycleRow wcr;
        private Reports.MonthAttendance monthAttendance;
        private MonthAttendanceTable _monthAttendance = new MonthAttendanceTable();
        private AttendanceTableGroupTable attendanceTableGroup = new AttendanceTableGroupTable();
        private AttendanceTableTable attendanceTable1 = new AttendanceTableTable(), attendanceTable2 = new AttendanceTableTable();
        private RegisterAttendanceItemTable registerAttendanceItem = new RegisterAttendanceItemTable();
        //Đăng ký nghỉ
        private RegisterAbsenceTable registerAbsence = new RegisterAbsenceTable();
        private bool change = false, setFieldName = false;
        private int maxLevel = 0, level = 0;
        private ToolTipControlInfo lastInfo = null;
        private int lastRowHandle = -1;
        private BandedGridColumn lastColumn = null;
        private SetGridBand setGridBand;
        private GridBand band;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        private BarButtonItem saveLayout, loadLayout;

        public MonthAttendance()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "MONTHATTENDANCE_PAGE" }, new string[] { TitleTable.GetValue("MONTHATTENDANCE_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { TitleTable.GetValue("COLLECT_PAGEGROUP", Constant.language), TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "COLLECT", imlFunction.Images[0], TitleTable.GetValue("COLLECT", Constant.language), new ItemClickEventHandler(bbiCollect_ItemClick));
            
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "EXPORT", imlFunction.Images[3], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));

            saveLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[2], "SAVE_LAYOUT", imageListEx.Images[2], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            loadLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[2], "LOAD_LAYOUT", imageListEx.Images[3], TitleTable.GetValue("LOAD_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiLoadLayout_ItemClick));

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
                if (band.Index + 1 < bgvMonthAttendance.Bands.Count)
                {
                    band = bgvMonthAttendance.Bands[band.Index + 1];
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
            bgvMonthAttendance.BeginDataUpdate();
            if (check)
            {
                registerAttendanceItem.GetListByDuration(wcr.FromDate, wcr.ToDate);
                registerAbsence.GetListByDuration(wcr.FromDate, wcr.ToDate);
                _monthAttendance.GetListByDepartmentID(departmentIDList, wcr.FromDate, wcr.ToDate, EmployeeTable.GetIDByCode(txtEmployeeCode.Text), chkResignation.Checked);
            }
            else
                _monthAttendance.DeleteByDepartmentID(departmentIDList);
            //bgvMonthAttendance.Bands["grbNotes"].Visible = chkResignation.Checked;
            bgvMonthAttendance.EndDataUpdate();
            bgvMonthAttendance.ExpandAllGroups();
            if (setFieldName)
            {
                bgvMonthAttendance.RestoreLayout(0, 0, Constant.language);
                SetColumn(wcr.Days);
            }
            //bgvMonthAttendance.BestFitColumns();
            smiFormat_Click(null, null);
            waitDialog.Close();
        }

        private void InitGridView(DevExpress.XtraEditors.Repository.RepositoryItem editor)
        {
            attendanceTableGroup.GetContent();
            attendanceTable1.GetListByItemGroupID("[1]");
            AddBand("grbDaysInWorkingCycle", attendanceTableGroup.FindByPrimaryKey("1").Name, string.Empty, 1, DevExpress.XtraGrid.Columns.FixedStyle.None, bgvMonthAttendance.Bands);
            int count = attendanceTable1.Count;        
            for (int d = 1; d <= 31; d++)
            {
                AddBand("grb" + d.ToString(), string.Empty, string.Empty, 2, DevExpress.XtraGrid.Columns.FixedStyle.None, bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children);
                foreach (AttendanceTableRow atr in attendanceTable1)
                {
                    if (atr.Status)
                    {
                        if (count > 1)
                            AddColumn(atr.ID + d.ToString(), atr.Name, bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children["grb" + d.ToString()].Children);
                        else
                            AddColumn(atr.ID + d.ToString(), atr.Name, bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children["grb" + d.ToString()]);
                    }    
                }
            }

            bgvMonthAttendance.Data = _monthAttendance;
            bgvMonthAttendance.GroupTable = attendanceTableGroup;
            attendanceTable2.GetContent();
            foreach (AttendanceTableRow atr in attendanceTable2)
            {
                if (atr.AttendanceTableGroupID != "1" && atr.Status)
                {
                    level = bgvMonthAttendance.AddColumn(atr, false);
                    if (level > maxLevel) maxLevel = level;
                }
            }
            grdMonthAttendance.DataSource = _monthAttendance;
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
            GridBandCollection gbc = bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children;
            BandedGridColumn column = null;
            string iD;
            for (int i = 0; i < days; i++)
            {
                gbc[i].Caption = d.Day.ToString() + '\n' + Utility.GetWeekDay(d);
                foreach (AttendanceTableRow atr in attendanceTable1)
                {
                    iD = atr.ID + d.Day.ToString();
                    if (atr.Status)
                    {
                        if (gbc[i].HasChildren)
                        {
                            column = gbc[i].Children["grb" + atr.ID + (i + 1).ToString()].Columns[0];
                            column.FieldName = iD;
                        }
                        else
                        {
                            column = gbc[i].Columns[0];
                            column.FieldName = iD;
                        }
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
                            bgvMonthAttendance.GroupSummary.Remove(bgvMonthAttendance.GroupSummary[iD]);
                            bgvMonthAttendance.GroupSummary.Add(summaryItem);
                        }
                    }
                }
                if (d.DayOfWeek == DayOfWeek.Sunday)
                {
                    foreach (AttendanceTableRow atr in attendanceTable1)
                    {
                        if (atr.Status)
                        {
                            if (gbc[i].HasChildren)
                            {
                                gbc[i].Children["grb" + atr.ID + (i + 1).ToString()].Columns[0].AppearanceCell.Options.UseBackColor = true;
                                gbc[i].Children["grb" + atr.ID + (i + 1).ToString()].Columns[0].AppearanceCell.BackColor = Color.FromArgb(0, 255, 255);
                            }
                            else
                            {
                                gbc[i].Columns[0].AppearanceCell.Options.UseBackColor = true;
                                gbc[i].Columns[0].AppearanceCell.BackColor = Color.FromArgb(0, 255, 255);
                            }
                        }
                    }
                }
                else
                {
                    foreach (AttendanceTableRow atr in attendanceTable1)
                    {
                        if (atr.Status)
                        {
                            if (gbc[i].HasChildren)
                                gbc[i].Children["grb" + atr.ID + (i + 1).ToString()].Columns[0].AppearanceCell.BackColor = Color.Empty;
                            else
                                gbc[i].Columns[0].AppearanceCell.BackColor = Color.Empty;
                        }
                    }
                }
                d = d.AddDays(1);
            }
        }

        private void SetColumn(int days)
        {
            bool stop = false;
            int count = attendanceTable1.Count;
            for (int i = days; i < 31; i++)
            {
                bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children[i].Visible = false;
                if (count > 1)
                {
                    for (int col = 0; col < count; col++)
                    {
                        if (col < bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children[i].Children.Count) bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children[i].Children[col].Columns[0].FieldName = string.Empty;
                    }
                }   
                else
                    bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children[i].Columns[0].FieldName = string.Empty;
            }

            int d = days - 1;
            while (!stop)
            {
                if (!bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children[d].Visible)
                {
                    bgvMonthAttendance.Bands["grbDaysInWorkingCycle"].Children[d].Visible = true;
                    d--;
                }
                else
                {
                    stop = true;
                }
            }
        }

        private void CollectWork()
        {
            //if (DateTime.Today < new DateTime(2012, 5, 5))
            {
                WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                waitDialog.Show();
                Application.DoEvents();
                _monthAttendance.Clear();
                MonthAttendanceTable.CollectWork(Constant.departmentIDList, wcr.FromDate, wcr.ToDate, EmployeeTable.GetIDByCode(txtEmployeeCode.Text));
                waitDialog.Close();
                ShowData(Constant.departmentIDList, true);
            }
            //else
            //{
            //    XtraMessageBox.Show(LookAndFeel, "Bạn đã hết hạn dùng thử. Xin liên hệ nhà cung cấp", TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void MonthAttendance_Load(object sender, EventArgs e)
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
                _monthAttendance.Clear();
                ShowData(Constant.departmentIDList, true);
                setFieldName = false;
            }
        }

        private void bgvMonthAttendance_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData)
            {
                if (e.RowHandle > 0)
                {
                    if (bgvMonthAttendance.GetRowCellValue(e.RowHandle, "EmployeeID").ToString() == bgvMonthAttendance.GetRowCellValue(e.RowHandle - 1, "EmployeeID").ToString())
                    {
                        e.Value = bgvMonthAttendance.GetRowCellValue(e.RowHandle - 1, "No");
                    }
                    else
                    {
                        if (e.RowHandle == bgvMonthAttendance.GetDataRowHandleByGroupRowHandle(bgvMonthAttendance.GetParentRowHandle(e.RowHandle)))
                            e.Value = 1;
                        else
                            e.Value = Convert.ToInt32(bgvMonthAttendance.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                    }
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void bgvMonthAttendance_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
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

        private void bbiCollect_ItemClick(object sender, EventArgs e)
        {
            CollectWork();
        }

        private void bbiPreview_ItemClick(object sender, EventArgs e)
        {
            monthAttendance = new Reports.MonthAttendance(bgvMonthAttendance, Convert.ToByte(cboMonth.Text), Convert.ToInt32(cboYear.Text));
            monthAttendance.DataSource = _monthAttendance;
            monthAttendance.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            monthAttendance.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            monthAttendance.PrintingSystem.PreviewFormEx.Owner = this;
            monthAttendance.ShowPreview();
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
            if (sfdExportToExcel.ShowDialog() == DialogResult.OK)
            {
                WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                waitDialog.Show();
                Application.DoEvents();
                string[] departments = Constant.departmentIDList.Split(new char[] { ',' });
                Classes.MonthAttendance monthAttendance = new Classes.MonthAttendance(sfdExportToExcel.FileName, String.Format("BCC-{0}-{1}", cboMonth.Text, cboYear.Text), "Times New Roman", bgvMonthAttendance, registerAttendanceItem, registerAbsence, departments.Length, Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                monthAttendance.FillData(maxLevel + 1);
                waitDialog.Close();
            }          
        }

        private void chkResignation_CheckedChanged(object sender, EventArgs e)
        {
            _monthAttendance.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void MonthAttendance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                _monthAttendance.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void MonthAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        //private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        //{
        //    if (bgvMonthAttendance.SaveLayout(wcr.Month, wcr.Year, Constant.language))
        //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    else
        //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        private void bbiLoadLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)loadLayout.DropDownControl;
            bgvMonthAttendance.RestoreLayout(popupControl.Controls["cboLanguage"].Text);
        }

        private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)saveLayout.DropDownControl;
            if (bgvMonthAttendance.SaveLayout(popupControl.Controls["cboLanguage"].Text))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bgvMonthAttendance_DoubleClick(object sender, EventArgs e)
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
            bgvMonthAttendance.BestFitColumns();
            //bgvMonthAttendance.FocusedColumn.BestFit();
        }

        private void smiFormat_Click(object sender, EventArgs e)
        {
            BandedGridColumn column;
            int days = wcr.Days;
            DateTime d = wcr.FromDate;
            string iD;
            for (int i = 0; i < days; i++)
            {
                foreach (AttendanceTableRow atr in attendanceTable1)
                {
                    if (atr.DataType == "Number")
                    {
                        iD = atr.ID + d.Day.ToString();
                        column = bgvMonthAttendance.Columns.ColumnByFieldName(iD);
                        if (column != null)
                        {
                            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                            column.SummaryItem.FieldName = iD;
                            column.SummaryItem.DisplayFormat = "{0:#,##0." + new string('#', atr.Rounding > 0 ? atr.Rounding : 0) + ";; }";
                        }
                    }
                }
                d = d.AddDays(1);
            }
            foreach (AttendanceTableRow atr in attendanceTable2)
            {
                column = bgvMonthAttendance.Columns.ColumnByFieldName(atr.ID);
                if (column != null)
                {
                    bgvMonthAttendance.FormatColumn(column, atr);
                    foreach (GridGroupSummaryItem summaryItem in bgvMonthAttendance.GroupSummary)
                    {
                        if (summaryItem.FieldName == atr.ID && summaryItem.ShowInGroupColumnFooter == null)
                        {
                            bgvMonthAttendance.GroupSummary.Remove(summaryItem);
                            break;
                        }
                    }
                }
            }
        }
        
        private bool IsDecimal(String NumIn, out Decimal NumOut)
        {
            return Decimal.TryParse(NumIn, out NumOut);
        }
        private void bgvMonthAttendance_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0 && ((BandedGridColumn)e.Column).OwnerBand.ParentBand != null && ((BandedGridColumn)e.Column).OwnerBand.ParentBand.Name == "grbDaysInWorkingCycle")
                {
                    int EmployeeID = Convert.ToInt32(bgvMonthAttendance.GetRowCellValue(e.RowHandle, "EmployeeID"));
                    if (EmployeeID == 0) return;
                    for (int i = 0; i < System.DateTime.DaysInMonth(wcr.Year, wcr.Month); i++)
                    {
                        String TexValue = bgvMonthAttendance.GetRowCellValue(e.RowHandle, "W" + (i + 1).ToString()).ToString();
                        switch (TexValue)
                        { 
                            case "NS":
                                if (e.Column.FieldName == "W" + (i + 1).ToString())
                                    e.Appearance.BackColor = Color.FromArgb(192, 192, 192);
                                break;
                            case "CDL":
                            case "CT":
                            case "KH":
                            case "KKH":
                            case "KT":
                            case "NB":
                            case "NV":
                            case "NVQS":
                            case "P":
                            case "TL":
                            case "VS":
                            case "NL":
                                if (e.Column.FieldName == "W" + (i + 1).ToString())
                                    e.Appearance.BackColor = Color.FromArgb(255, 153, 204);
                                break;
                            default:
                                break;
                        }
                        //Other
                        Decimal outValue = 0M;
                        if (IsDecimal(TexValue, out outValue))
                        {
                            if (registerAbsence.FindByPrimaryKey(EmployeeID, new DateTime(wcr.Year, wcr.Month, Convert.ToInt32((i + 1).ToString())), "PN") != null)
                            {
                                if (e.Column.FieldName == "W" + (i + 1).ToString())
                                    e.Appearance.BackColor = Color.FromArgb(255, 153, 204);
                            }
                            if (registerAbsence.FindByPrimaryKey(EmployeeID, new DateTime(wcr.Year, wcr.Month, Convert.ToInt32((i + 1).ToString())), "NP") != null)
                            {
                                if (e.Column.FieldName == "W" + (i + 1).ToString())
                                    e.Appearance.BackColor = Color.FromArgb(255, 255, 0);
                            }
                        }
                        
                    }

                }
            }
            catch
            { 
            
            }
        }

        private void ttcNotes_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info == null && e.SelectedControl == grdMonthAttendance)
            {
                BandedGridView view = grdMonthAttendance.FocusedView as BandedGridView;
                if (view != null)
                {
                    GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                    RegisterAttendanceItemRow rair;
                    string text = string.Empty;
                    if (info.RowHandle >= 0 && info.InRowCell && ((BandedGridColumn)info.Column).OwnerBand.ParentBand != null && ((BandedGridColumn)info.Column).OwnerBand.ParentBand.Name == "grbDaysInWorkingCycle")
                    {
                        if (lastRowHandle != info.RowHandle || lastColumn != info.Column)
                        {
                            lastColumn = (BandedGridColumn)info.Column;
                            lastRowHandle = info.RowHandle;
                            rair = registerAttendanceItem.FindByPrimaryKey(Convert.ToInt32(bgvMonthAttendance.GetRowCellValue(info.RowHandle, "EmployeeID")), new DateTime(wcr.Year, wcr.Month, Convert.ToInt32(info.Column.FieldName.Substring(1))), "X");
                            if (rair != null) text = rair.Notes;
                            lastInfo = new ToolTipControlInfo(new GridToolTipInfo(view, new CellToolTipInfo(info.RowHandle, info.Column, "Text")), text);
                        }
                        e.Info = lastInfo;
                    }
                }
            }
        }
    }
}
