using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Common;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using System.IO;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils.Drawing;

namespace Attendance.Forms
{
    public partial class TimeInTimeOutFix : XtraForm, IShowData, IBandedGridViewParent
    {
        private Reports.ReportData reportData = new Reports.ReportData();
        private EmployeeTable employee = new EmployeeTable();
        private Reports.TimeInTimeOut _timeInTimeOut;
        private ModifiedDataTable modifiedData = new ModifiedDataTable();
        private VacationTable vacation = new VacationTable();
        private string employeeIDList = string.Empty;
        private bool change = false, isEdit = false;
        private SetGridBand setGridBand;
        private GridBand band;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;
        private BarButtonItem saveLayout, loadLayout;
        private ToolTipControlInfo lastInfo = null;
        private int lastRowHandle = -1;
        private BandedGridColumn lastColumn = null;

        public TimeInTimeOutFix()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "TIMEINTIMEOUT_PAGE" }, new string[] { TitleTable.GetValue("TIMEINTIMEOUT_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "EXPORT_PAGEGROUP", "OPTION_PAGEGROUP" }, new string[] {TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "SAVE", imlFunction.Images[0], TitleTable.GetValue("SAVE", Constant.language), new ItemClickEventHandler(bbiSave_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "INPUT", imlFunction.Images[1], TitleTable.GetValue("INPUT", Constant.language), new ItemClickEventHandler(bbiInput_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "RESET", imlFunction.Images[2], TitleTable.GetValue("RESET", Constant.language), new ItemClickEventHandler(bbiReset_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "APPROVE", imlFunction.Images[3], TitleTable.GetValue("APPROVE", Constant.language), new ItemClickEventHandler(bbiApprove_ItemClick));
            //pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "PREVIEW", imlFunction.Images[4], TitleTable.GetValue("PREVIEW", Constant.language), new ItemClickEventHandler(bbiPreview_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "EXPORT", imlFunction.Images[5], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));
            saveLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "SAVE_LAYOUT", imlFunction.Images[6], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            loadLayout = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "LOAD_LAYOUT", imlFunction.Images[7], TitleTable.GetValue("LOAD_LAYOUT", Constant.language), Utility.CreatePopupControl(), new ItemClickEventHandler(bbiLoadLayout_ItemClick));

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
                if (band.Index + 1 < bgvTimeInTimeOutFix.Bands.Count)
                {
                    band = bgvTimeInTimeOutFix.Bands[band.Index + 1];
                    setGridBand.FillData(band);
                }
            }
        }

        private void InitGridView()
        {
            bgvTimeInTimeOutFix.Data = reportData.TimeInTimeOut;
            bgvTimeInTimeOutFix.GroupTable = AttendanceItemGroupTable.GetContentTable();
            AttendanceItemTable attendanceItem = new AttendanceItemTable();
            attendanceItem.GetContent();

            foreach (AttendanceItemRow air in attendanceItem)
            {
                if (air.Display && bgvTimeInTimeOutFix.Columns[air.ID] == null) bgvTimeInTimeOutFix.AddColumn(air, false);
            }
            //bgvTimeInTimeOut.AddColumn("AbsenceName", "Nghỉ", bgvTimeInTimeOut.Bands);
        }

        public void ShowData(string departmentIDList, bool check)
        {
            WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
            waitDialog.Show();
            Application.DoEvents();
            bgvTimeInTimeOutFix.BeginDataUpdate();
            reportData.GetListByDepartmentID(departmentIDList, dedFromDate.DateTime, dedToDate.DateTime, employeeIDList, chkErrorDays.Checked, chkAllDays.Checked, check);
            bgvTimeInTimeOutFix.EndDataUpdate();
            bgvTimeInTimeOutFix.ExpandAllGroups();
            bgvTimeInTimeOutFix.RestoreLayout(Constant.language);
            //bgvTimeInTimeOut.Columns["P001"].OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            //bgvTimeInTimeOut.Columns["FirstName"].BestFit();
            //bgvTimeInTimeOut.Columns["LastName"].BestFit();
            waitDialog.Close();
        }

        private void InitLookUp()
        {
            ileReason.DataSource = LeaveTable.GetContentTable();
            ileReason.ValueMember = "ID";
            ileReason.DisplayMember = "Name";
            ileReason.BestFit();

            ShiftTable shift = new ShiftTable();
            shift.AddShiftRow(string.Empty, string.Empty, false, false);
            shift.GetContent();
            ileShift.DataSource = shift;
            ileShift.ValueMember = "ID";
            ileShift.DisplayMember = "Name";
            ileShift.BestFit();
        }

        private void TimeInTimeOut_Load(object sender, EventArgs e)
        {
            DepartmentTable department = new DepartmentTable();
            department.GetFullPath(Constant.currentUser.Name);
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr["FullPath"].ToString(), dr["FullPath"], 0));
            }

            modifiedData.GetContent();
            vacation.GetContent();
            InitGridView();
            InitLookUp();

            grdTimeInTimeOut.DataSource = reportData.TimeInTimeOut;

            dedFromDate.DateTime = DateTime.Today;
            change = true;
            dedToDate.DateTime = DateTime.Today;

            AddPageCategory();
            //foreach (RibbonPageGroup rpg in pageCategory.Pages[0].Groups)
            //{
            //    Utility.SetPermission(rpg, "TimeInTimeOut");
            //}
            SetPermissionPage(pageCategory);
            //Load
            ShowData(Constant.departmentIDList, true);
            //
            //grvBreakOutBreakIn.BestFitColumns();
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

        private void grvBreakOutBreakIn_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView grvBreakOutBreakIn = (GridView)sender;
            grvBreakOutBreakIn.SetRowCellValue(e.RowHandle, "IOTimes", grvBreakOutBreakIn.RowCount);
            grvBreakOutBreakIn.SetRowCellValue(e.RowHandle, "ShiftID", bgvTimeInTimeOutFix.GetRowCellValue(bgvTimeInTimeOutFix.FocusedRowHandle, "ShiftID"));
        }

        private void bbiSave_ItemClick(object sender, EventArgs e)
        {
            bool change, noError = true;
            byte status = 0;
            Reports.ReportData.BreakOutBreakInRow[] bobi = null;
            DateTime timeIn = DateTime.MaxValue, timeOut = DateTime.MaxValue, originalTimeIn = DateTime.MaxValue, originalTimeOut = DateTime.MaxValue;
            int enrollNumber;
            ModifiedDataRow mdr;

            modifiedData.GetContent();
            bgvTimeInTimeOutFix.UpdateCurrentRow();
            foreach (Reports.ReportData.TimeInTimeOutRow titor in reportData.TimeInTimeOut)
            {
                change = false;
                bobi = (Reports.ReportData.BreakOutBreakInRow[])titor.GetChildRows("TimeInTimeOut_BreakOutBreakIn");
                if (titor.RowState != DataRowState.Unchanged)
                    change = true;
                else
                {
                    foreach (Reports.ReportData.BreakOutBreakInRow bobir in bobi)
                    {
                        if (bobir.RowState != DataRowState.Unchanged)
                        {
                            change = true;
                            break;
                        }
                    }
                }
                if (change)
                {
                    status = titor.Status;
                    if (!titor.IsTimeInNull())
                    {
                        timeIn = new DateTime(titor.WorkingDay.Year, titor.WorkingDay.Month, titor.WorkingDay.Day, titor.TimeIn.Hour, titor.TimeIn.Minute, titor.TimeIn.Second);
                        if (titor.HasVersion(DataRowVersion.Original) && titor["TimeIn", DataRowVersion.Original] != DBNull.Value)
                        {
                            if (titor.TimeIn != Convert.ToDateTime(titor["TimeIn", DataRowVersion.Original]))
                            {
                                if ((status & 2) == 2)
                                    status |= 2;
                                else
                                    status |= 1;
                                if (timeIn.Hour == 0 && timeIn.Minute == 0)
                                    TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, DateTime.MinValue, new DateTime(9999, 12, 31), 0);
                                else
                                    TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, timeIn, new DateTime(9999, 12, 31), status);
                            }
                            originalTimeIn = Convert.ToDateTime(titor["TimeIn", DataRowVersion.Original]);
                        }
                        else
                        {
                            originalTimeIn = new DateTime(9999, 12, 31);
                            status |= 2;
                            if (!titor.IsShiftIDNull() && titor.ShiftID != string.Empty)
                            {
                                if (titor["TimeOut", DataRowVersion.Original] == DBNull.Value)
                                    TimeInTimeOutTable.Insert(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, timeIn, titor.TimeOut, status);
                                else
                                    TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, timeIn, new DateTime(9999, 12, 31), status);
                            }
                        }
                    }
                    if (!titor.IsTimeOutNull())
                    {
                        timeOut = new DateTime(titor.WorkingDay.Year, titor.WorkingDay.Month, titor.WorkingDay.Day, titor.TimeOut.Hour, titor.TimeOut.Minute, titor.TimeOut.Second);
                        if ((timeOut.Hour != 0 || timeOut.Minute != 0) && 60 * titor.TimeOut.Hour + titor.TimeOut.Minute < 60 * titor.TimeIn.Hour + titor.TimeIn.Minute)
                        {
                            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, string.Format(TitleTable.GetValue("OVERNIGHT", Constant.language), titor.WorkingDay.ToString("dd/MM/yyyy"), titor.EmployeeCode), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (retVal == DialogResult.Yes) timeOut = timeOut.AddDays(1);
                        }
                        if (titor.HasVersion(DataRowVersion.Original) && titor["TimeOut", DataRowVersion.Original] != DBNull.Value)
                        {
                            if (titor.TimeOut != Convert.ToDateTime(titor["TimeOut", DataRowVersion.Original]))
                            {
                                if ((status & 8) == 8)
                                    status |= 8;
                                else
                                    status |= 4;
                                if (timeOut.Hour == 0 && timeOut.Minute == 0)
                                    TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, new DateTime(9999, 12, 31), DateTime.MinValue, 0);
                                else
                                    TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, new DateTime(9999, 12, 31), timeOut, status);
                            }
                            originalTimeOut = Convert.ToDateTime(titor["TimeOut", DataRowVersion.Original]);
                        }
                        else
                        {
                            originalTimeOut = new DateTime(9999, 12, 31);
                            status |= 8;
                            if (!titor.IsShiftIDNull() && titor.ShiftID != string.Empty) TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, new DateTime(9999, 12, 31), timeOut, status);
                        }
                    }
                    enrollNumber = CardTable.GetEnrollNumberByEmployeeID(titor.EmployeeID, titor.WorkingDay);
                    if ((status | 5) == 5)
                        status = 1;
                    else
                        status = 2;
                    if (timeIn != DateTime.MaxValue && timeIn != originalTimeIn)
                    {
                        if (originalTimeIn != new DateTime(9999, 12, 31))
                        {
                            mdr = modifiedData.GetInfoByEmployeeID(titor.EmployeeID, originalTimeIn);
                            if (mdr == null)
                            {
                                mdr = (ModifiedDataRow)modifiedData.NewRow();
                                mdr.EmployeeID = titor.EmployeeID;
                                mdr.Value = timeIn;
                                mdr.EnrollNumber = enrollNumber;
                                mdr.SwipedDate = originalTimeIn;
                                mdr.Status = status;
                                mdr.UserName = Constant.currentUser.Name;
                                modifiedData.AddModifiedDataRow(mdr);
                                noError = modifiedData.Insert();
                            }
                            else
                            {
                                if (timeIn.Hour == 0 && timeIn.Minute == 0)
                                {
                                    mdr.Delete();
                                    noError = modifiedData.Delete();
                                }
                                else
                                {
                                    mdr.Value = timeIn;
                                    if (mdr.SwipedDate == originalTimeIn) mdr.SwipedDate = timeIn;
                                    noError = modifiedData.Update();
                                }
                            }
                        }
                        else
                        {
                            mdr = (ModifiedDataRow)modifiedData.NewRow();
                            mdr.EmployeeID = titor.EmployeeID;
                            mdr.Value = timeIn;
                            mdr.EnrollNumber = enrollNumber;
                            mdr.SwipedDate = timeIn;
                            mdr.Status = status;
                            mdr.UserName = Constant.currentUser.Name;
                            modifiedData.AddModifiedDataRow(mdr);
                            noError = modifiedData.Insert();
                        }
                    }
                    if (timeOut != DateTime.MaxValue && timeOut != originalTimeOut)
                    {
                        if (originalTimeOut != new DateTime(9999, 12, 31))
                        {
                            mdr = modifiedData.GetInfoByEmployeeID(titor.EmployeeID, originalTimeOut);
                            if (mdr == null)
                            {
                                mdr = (ModifiedDataRow)modifiedData.NewRow();
                                mdr.EmployeeID = titor.EmployeeID;
                                mdr.Value = timeOut;
                                mdr.EnrollNumber = enrollNumber;
                                mdr.SwipedDate = originalTimeOut;
                                mdr.Status = status;
                                mdr.UserName = Constant.currentUser.Name;
                                modifiedData.AddModifiedDataRow(mdr);
                                noError = modifiedData.Insert();
                            }
                            else
                            {
                                if (timeOut.Hour == 0 && timeOut.Minute == 0)
                                {
                                    mdr.Delete();
                                    noError = modifiedData.Delete();
                                }
                                else
                                {
                                    mdr.Value = timeOut;
                                    if (mdr.SwipedDate == originalTimeOut) mdr.SwipedDate = timeOut;
                                    noError = modifiedData.Update();
                                }
                            }
                        }
                        else
                        {
                            mdr = (ModifiedDataRow)modifiedData.NewRow();
                            mdr.EmployeeID = titor.EmployeeID;
                            mdr.Value = timeOut;
                            mdr.EnrollNumber = enrollNumber;
                            mdr.SwipedDate = timeOut;
                            mdr.Status = status;
                            mdr.UserName = Constant.currentUser.Name;
                            modifiedData.AddModifiedDataRow(mdr);
                            noError = modifiedData.Insert();
                        }
                    }
                }
                if (noError)
                {
                    titor.AcceptChanges();
                    timeIn = DateTime.MaxValue;
                    timeOut = DateTime.MaxValue;
                }
                else
                    break;
            }

            if (noError)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TIMEINTIMEOUT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData(Constant.departmentIDList, true);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TIMEINTIMEOUT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            isEdit = false;
        }

        private void grvBreakOutBreakIn_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit) isEdit = true;
        }

        private void bbiExport_ItemClick(object sender, EventArgs e)
        {
            sfdExportToExcel.ShowDialog();
            if (sfdExportToExcel.FileName != string.Empty)
            {
                WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                waitDialog.Show();
                Application.DoEvents();
                string[] departments = Constant.departmentIDList.Split(new char[] { ',' });
                //bgvTimeInTimeOut.BeginUpdate();
                bgvTimeInTimeOutFix.Bands["grbOriginalTimeIn"].Visible = true;
                bgvTimeInTimeOutFix.Bands["grbOriginalTimeOut"].Visible = true;
                bgvTimeInTimeOutFix.Columns["OriginalTimeIn"].Visible = true;
                bgvTimeInTimeOutFix.Columns["OriginalTimeOut"].Visible = true;
                Classes.TimeInTimeOut timeInTimeOut = new Classes.TimeInTimeOut(sfdExportToExcel.FileName, "KL-CTVR", "Times New Roman", bgvTimeInTimeOutFix, departments.Length, dedFromDate.DateTime, dedToDate.DateTime);
                timeInTimeOut.FillData(1);
                waitDialog.Close();
                bgvTimeInTimeOutFix.Bands["grbOriginalTimeIn"].Visible = false;
                bgvTimeInTimeOutFix.Bands["grbOriginalTimeOut"].Visible = false;
                //bgvTimeInTimeOut.EndUpdate();
                //bgvTimeInTimeOut.Columns["DepartmentName"].GroupIndex = -1;
                //bgvTimeInTimeOut.Bands["grbDepartmentName"].Visible = true;
                //bgvTimeInTimeOut.Columns["DepartmentName"].Visible = true;
                //bgvTimeInTimeOut.ExportToXls(sfdExportToExcel.FileName, new DevExpress.XtraPrinting.XlsExportOptions(true, true));
                //bgvTimeInTimeOut.Columns["DepartmentName"].GroupIndex = 0;
                //bgvTimeInTimeOut.Bands["grbDepartmentName"].Visible = false;
            }
        }

        private void bbiPreview_ItemClick(object sender, EventArgs e)
        {
            _timeInTimeOut = new Reports.TimeInTimeOut(bgvTimeInTimeOutFix, dedFromDate.DateTime, dedToDate.DateTime);
            DataView dataView = reportData.TimeInTimeOut.DefaultView;
            if (!ReferenceEquals(bgvTimeInTimeOutFix.ActiveFilterCriteria, null)) dataView.RowFilter = bgvTimeInTimeOutFix.ActiveFilterCriteria.LegacyToString();
            //if (chkLateComingEarlyReturning.Checked) dataView.RowFilter = "P001 IS NOT NULL OR P002 IS NOT NULL";
            //if (chkAdjustedTime.Checked) dataView.RowFilter = "Updated <> -1";
            _timeInTimeOut.DataSource = reportData;
            _timeInTimeOut.DataMember = "TimeInTimeOut";
            _timeInTimeOut.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            _timeInTimeOut.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            _timeInTimeOut.PrintingSystem.PreviewFormEx.Owner = this;
            _timeInTimeOut.ShowPreviewDialog();
            dataView.RowFilter = string.Empty;
        }

        private void bgvTimeInTimeOut_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            if (bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "ShiftID").ToString() == string.Empty && bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "TimeIn").ToString() == string.Empty && bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "TimeOut").ToString() == string.Empty)
                e.Allow = false;
            else
                e.Allow = true;
        }

        private void bgvTimeInTimeOut_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                if (!isEdit)
                {
                    isEdit = true;
                }
                if (e.Column.FieldName == "ShiftID")
                {
                    int employeeID;
                    string shiftID;
                    DateTime workingDay, breakOut, breakIn;
                    employeeID = Convert.ToInt32(bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "EmployeeID"));
                    shiftID = e.Value.ToString();
                    workingDay = (DateTime)bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "WorkingDay");
                    Reports.ReportData.TimeInTimeOutRow titor = reportData.TimeInTimeOut.FindByEmployeeIDWorkingDay(employeeID, workingDay);
                    if (shiftID != string.Empty)
                    {
                        ShiftDetailRow sdr = ShiftDetailTable.GetListByShiftID(shiftID, workingDay);
                        breakOut = (sdr["BreakOut"] != DBNull.Value) ? (DateTime)sdr["BreakOut"] : DateTime.Today;
                        breakIn = (sdr["BreakIn"] != DBNull.Value) ? (DateTime)sdr["BreakIn"] : DateTime.Today;
                        if (sdr != null)
                        {
                            //titor.Interval = ((DateTime)sdr["TimeIn"]).ToString("HH:mm") + "-" + ((DateTime)sdr["TimeOut"]).ToString("HH:mm") + " " + (breakIn.Hour * 60 + breakIn.Minute - breakOut.Hour * 60 - breakOut.Minute).ToString();
                            bgvTimeInTimeOutFix.SetRowCellValue(e.RowHandle, "TimeIn", sdr["TimeIn"]);
                            bgvTimeInTimeOutFix.SetRowCellValue(e.RowHandle, "TimeOut", sdr["TimeOut"]);
                        }
                        else
                        {
                            bgvTimeInTimeOutFix.SetRowCellValue(e.RowHandle, "TimeIn", null);
                            bgvTimeInTimeOutFix.SetRowCellValue(e.RowHandle, "TimeOut", null);
                        }

                    }
                    else
                    {
                        bgvTimeInTimeOutFix.SetRowCellValue(e.RowHandle, "TimeIn", null);
                        bgvTimeInTimeOutFix.SetRowCellValue(e.RowHandle, "TimeOut", null);
                    }
                }
            }
        }

        private void bbiReset_ItemClick(object sender, EventArgs e)
        {
            if (reportData.ResetTimeInTimeOut(EmployeeTable.GetIDByCode(txtEmployeeCode.Text), dedFromDate.DateTime, dedToDate.DateTime))
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("RESET_TIMEINTIMEOUT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Reports.ReportData.TimeInTimeOutRow titor in reportData.TimeInTimeOut)
                {
                    titor.Delete();
                }
                reportData.TimeInTimeOut.AcceptChanges();
                reportData.BreakOutBreakIn.AcceptChanges();
                ShowData(Constant.departmentIDList, true);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("RESET_TIMEINTIMEOUT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == Convert.ToInt32(ConstantTable.GetValueByName("CodeLength")))
            {
                employeeIDList = "[" + EmployeeTable.GetIDByCode(txtEmployeeCode.Text).ToString() + "]";
                if (reportData.Tables.Contains("TimeInTimeOut"))
                {
                    reportData.BreakOutBreakIn.Clear();
                    reportData.TimeInTimeOut.Clear();
                }
                ShowData(Constant.departmentIDList, true);
            }
            if (txtEmployeeCode.Text.Length == 0)
            {
                employeeIDList = string.Empty;
                if (Constant.departmentIDList == string.Empty)
                {
                    if (reportData.Tables.Contains("TimeInTimeOut"))
                    {
                        reportData.BreakOutBreakIn.Clear();
                        reportData.TimeInTimeOut.Clear();
                    }
                }
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bgvTimeInTimeOut_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle > -1) e.Value = e.RowHandle + 1;
            if (e.Column.FieldName == "Duration" && e.IsGetData)
            {
                Reports.ReportData.TimeInTimeOutRow titor = reportData.TimeInTimeOut.FindByEmployeeIDWorkingDay(Convert.ToInt32(((BandedGridView)sender).GetRowCellValue(e.RowHandle, "EmployeeID")), (DateTime)((BandedGridView)sender).GetRowCellValue(e.RowHandle, "WorkingDay"));
                if (titor != null && !titor.IsIntervalNull() && titor.Interval != string.Empty)
                    e.Value = titor.Interval.Substring(0, titor.Interval.IndexOf(" "));
                else
                    e.Value = null;
            }
            if (e.Column.FieldName == "Rest" && e.IsGetData)
            {
                Reports.ReportData.TimeInTimeOutRow titor = reportData.TimeInTimeOut.FindByEmployeeIDWorkingDay(Convert.ToInt32(((BandedGridView)sender).GetRowCellValue(e.RowHandle, "EmployeeID")), (DateTime)((BandedGridView)sender).GetRowCellValue(e.RowHandle, "WorkingDay"));
                if (titor != null && !titor.IsIntervalNull() && titor.Interval != string.Empty)
                {
                    UInt16 rest = Convert.ToUInt16(titor.Interval.Substring(titor.Interval.IndexOf(" ") + 1));
                    e.Value = ((UInt16)(rest / 60)).ToString("00") + ":" + (rest % 60).ToString("00");
                }
                else
                    e.Value = null;
            }
        }

        private void grvBreakOutBreakIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_BREAKOUTBREAKIN", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (retVal == DialogResult.OK)
                {
                    GridView breakOutBreakIn = (GridView)sender;
                    Reports.ReportData.BreakOutBreakInRow bobir = (Reports.ReportData.BreakOutBreakInRow)breakOutBreakIn.GetDataRow(breakOutBreakIn.FocusedRowHandle);
                    BreakOutBreakInTable.DeleteValue(bobir.EmployeeID, bobir.WorkingDay, bobir.ShiftID, bobir.IOTimes);
                    if (!bobir.IsBreakOutNull()) RawDataTable.Delete(bobir.EmployeeID, bobir.BreakOut, false);
                    if (!bobir.IsBreakInNull()) RawDataTable.Delete(bobir.EmployeeID, bobir.BreakIn, false);
                    breakOutBreakIn.DeleteRow(breakOutBreakIn.FocusedRowHandle);
                }
            }
        }

        private void TimeInTimeOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void bbiInput_ItemClick(object sender, EventArgs e)
        {
            //int i = 0;
            //int[] selectedRows = bgvTimeInTimeOut.GetSelectedRows(), employeeIDs = new int[selectedRows.Length];
            //foreach (int r in selectedRows)
            //{
            //    employeeIDs[i++] = Convert.ToInt32(bgvTimeInTimeOut.GetRowCellValue(r, "EmployeeID"));
            //}
            //new Attendance.Forms.TimeInTimeOutFix(employeeIDs, dedFromDate.DateTime, dedToDate.DateTime, this).ShowDialog();
        }

        private void bbiApprove_ItemClick(object sender, EventArgs e)
        {
            bool noError = true;
            DateTime timeIn = DateTime.MaxValue, timeOut = DateTime.MaxValue;

            modifiedData.Clear();
            modifiedData.GetContent();
            bgvTimeInTimeOutFix.UpdateCurrentRow();
            foreach (Reports.ReportData.TimeInTimeOutRow titor in reportData.TimeInTimeOut)
            {
                if (titor.Updated == 1)
                {
                    if (titor.Status == 16)
                    {
                        TimeInTimeOutTable.DeleteValue(titor.EmployeeID, titor.WorkingDay, titor.ShiftID);
                        noError = RawDataTable.Delete(titor.EmployeeID, titor.WorkingDay, true);
                    }
                    else
                    {
                        timeIn = new DateTime(titor.WorkingDay.Year, titor.WorkingDay.Month, titor.WorkingDay.Day, titor.TimeIn.Hour, titor.TimeIn.Minute, titor.TimeIn.Second);
                        //if ((titor.Status & 1) == 1) noError = RawDataTable.InsertValue(titor.EmployeeID, timeInTimeOutVersion.FindByPrimaryKey(titor.EmployeeID, titor.WorkingDay).TimeIn, timeIn, true, true);
                        if ((titor.Status & 2) == 2)
                        {
                            TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, new DateTime(9999, 12, 31), titor.TimeOut, titor.Status);
                            noError = RawDataTable.InsertValue(titor.EmployeeID, DateTime.MaxValue, timeIn, true, true);
                        }
                        timeOut = 60 * titor.TimeOut.Hour + titor.TimeOut.Minute < 60 * titor.TimeIn.Hour + titor.TimeIn.Minute ? new DateTime(titor.WorkingDay.Year, titor.WorkingDay.Month, titor.WorkingDay.Day, titor.TimeOut.Hour, titor.TimeOut.Minute, titor.TimeOut.Second).AddDays(1) : new DateTime(titor.WorkingDay.Year, titor.WorkingDay.Month, titor.WorkingDay.Day, titor.TimeOut.Hour, titor.TimeOut.Minute, titor.TimeOut.Second);
                        //if ((titor.Status & 4) == 4) noError = RawDataTable.InsertValue(titor.EmployeeID, timeInTimeOutVersion.FindByPrimaryKey(titor.EmployeeID, titor.WorkingDay).TimeOut, timeOut, false, true);
                        if ((titor.Status & 8) == 8)
                        {
                            TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, titor.TimeIn, new DateTime(9999, 12, 31), titor.Status);
                            noError = RawDataTable.InsertValue(titor.EmployeeID, DateTime.MaxValue, timeOut, false, true);
                        }

                        TimeInTimeOutTable.DeleteValue(titor.EmployeeID, titor.WorkingDay, titor.ShiftID);
                        RawDataTable.GetTimeInTimeOut(titor.EmployeeID, timeIn, true);
                        RawDataTable.GetTimeInTimeOut(titor.EmployeeID, timeOut, false);
                    }
                }
                if (titor.Updated == 0)
                {
                    if (titor.Status == 16)
                        TimeInTimeOutTable.SetStatus(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, 0);
                    else
                    {
                        //if ((titor.Status | 1) == 1) TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, timeInTimeOutVersion.FindByPrimaryKey(titor.EmployeeID, titor.WorkingDay).TimeIn, titor.TimeOut, titor.Status);
                        if ((titor.Status | 2) == 2) TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, new DateTime(9999, 12, 31), titor.TimeOut, titor.Status);
                        //if ((titor.Status | 4) == 4) TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, titor.TimeIn, timeInTimeOutVersion.FindByPrimaryKey(titor.EmployeeID, titor.WorkingDay).TimeOut, titor.Status);
                        if ((titor.Status | 8) == 8) TimeInTimeOutTable.Update(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, titor.TimeIn, new DateTime(9999, 12, 31), titor.Status);
                        if ((titor.Status | 10) == 10) TimeInTimeOutTable.DeleteValue(titor.EmployeeID, titor.WorkingDay, titor.ShiftID);
                        TimeInTimeOutTable.SetStatus(titor.EmployeeID, titor.WorkingDay, titor.ShiftID, 0);
                    }
                }
                if (!noError) break;
            }

            if (noError)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TIMEINTIMEOUT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData(Constant.departmentIDList, true);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TIMEINTIMEOUT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            isEdit = false;
        }

        private void bgvTimeInTimeOut_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bgvTimeInTimeOutFix.FocusedColumn.FieldName == "Updated" && Convert.ToInt32(bgvTimeInTimeOutFix.GetFocusedValue()) == -1) e.Cancel = true;
            //if ((bgvTimeInTimeOut.FocusedColumn.FieldName == "ShiftID" || bgvTimeInTimeOut.FocusedColumn.FieldName == "TimeIn" || bgvTimeInTimeOut.FocusedColumn.FieldName == "TimeOut") && Convert.ToInt32(bgvTimeInTimeOut.GetRowCellValue(bgvTimeInTimeOut.FocusedRowHandle, "Status")) != 0) e.Cancel = true;
        }

        private void ttcEditInfo_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info == null && e.SelectedControl == grdTimeInTimeOut)
            {
                BandedGridView view = grdTimeInTimeOut.FocusedView as BandedGridView;
                if (view != null)
                {
                    GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                    byte status = Convert.ToByte(bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "Status"));
                    ModifiedDataRow mdr;
                    string text = string.Empty;
                    if (info.RowHandle >= 0 && info.InRowCell && ((info.Column.FieldName == "TimeIn") || (info.Column.FieldName == "TimeOut")))
                    {
                        if (lastRowHandle != info.RowHandle || lastColumn != info.Column)
                        {
                            lastColumn = (BandedGridColumn)info.Column;
                            lastRowHandle = info.RowHandle;
                            if (info.Column.FieldName == "TimeIn" && bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "TimeIn") != DBNull.Value)
                            {
                                mdr = modifiedData.GetInfoByEmployeeID((int)bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "EmployeeID"), (DateTime)bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "TimeIn"));
                                if (mdr != null)
                                {
                                    if ((status & 1) == 1) text = string.Format("Giờ gốc: {0}\nNgười sửa: {1}", mdr.SwipedDate.ToString("HH:mm"), mdr.UserName);
                                    if ((status & 2) == 2) text = string.Format("Người sửa: {0}", mdr.UserName);
                                }
                            }
                            if (info.Column.FieldName == "TimeOut" && bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "TimeOut") != DBNull.Value)
                            {
                                mdr = modifiedData.GetInfoByEmployeeID((int)bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "EmployeeID"), (DateTime)bgvTimeInTimeOutFix.GetRowCellValue(info.RowHandle, "TimeOut"));
                                if (mdr != null)
                                {
                                    if ((status & 4) == 4) text = string.Format("Giờ gốc: {0}\nNgười sửa: {1}", mdr.SwipedDate.ToString("HH:mm"), mdr.UserName);
                                    if ((status & 8) == 8) text = string.Format("Người sửa: {0}", mdr.UserName);
                                }
                            }
                            lastInfo = new ToolTipControlInfo(new GridToolTipInfo(view, new CellToolTipInfo(info.RowHandle, info.Column, "Text")), text);
                        }
                        e.Info = lastInfo;
                    }
                }
            }
        }

        private void bbiSaveLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)saveLayout.DropDownControl;
            if (bgvTimeInTimeOutFix.SaveLayout(popupControl.Controls["cboLanguage"].Text))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkEdit_CheckedChanged(object sender, EventArgs e)
        {
            reportData.BreakOutBreakIn.Clear();
            reportData.TimeInTimeOut.Clear();
            ShowData(Constant.departmentIDList, true);
        }

        private void bgvTimeInTimeOut_DoubleClick(object sender, EventArgs e)
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

        private void bbiLoadLayout_ItemClick(object sender, EventArgs e)
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = (PopupControlContainer)loadLayout.DropDownControl;
            bgvTimeInTimeOutFix.RestoreLayout(popupControl.Controls["cboLanguage"].Text);
        }

        private void TimeInTimeOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                reportData.BreakOutBreakIn.Clear();
                reportData.TimeInTimeOut.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bgvTimeInTimeOut_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                DateTime d = Convert.ToDateTime(bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "WorkingDay"));
                if (d.DayOfWeek == DayOfWeek.Sunday || vacation.FindByPrimaryKey(d) != null)
                {
                    e.Appearance.BackColor = Color.Orange;
                    e.Appearance.BackColor2 = Color.Orange;
                }
                byte status = Convert.ToByte(bgvTimeInTimeOutFix.GetRowCellValue(e.RowHandle, "Status"));
                if (e.Column.FieldName == "TimeIn")
                {
                    if ((status & 1) == 1) e.Appearance.BackColor = Color.Red;
                    if ((status & 2) == 2) e.Appearance.BackColor = Color.Yellow;
                    if ((status & 16) == 16) e.Appearance.BackColor = Color.Blue;
                }
                if (e.Column.FieldName == "TimeOut")
                {
                    if ((status & 4) == 4) e.Appearance.BackColor = Color.Red;
                    if ((status & 8) == 8) e.Appearance.BackColor = Color.Yellow;
                    if ((status & 16) == 16) e.Appearance.BackColor = Color.Blue;
                }
            }
        }

        private void mitDataRawView_Click(object sender, EventArgs e)
        {
            new RawDataView((int)bgvTimeInTimeOutFix.GetFocusedRowCellValue("EmployeeID"), dedFromDate.DateTime, dedToDate.DateTime).ShowDialog();
        }

        private void chkLateComingEarlyReturning_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLateComingEarlyReturning.Checked)
                bgvTimeInTimeOutFix.ActiveFilterString = "P001 IS NOT NULL OR P002 IS NOT NULL";
            else
                bgvTimeInTimeOutFix.ActiveFilterString = string.Empty;
        }

        private void chkAdjustedTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdjustedTime.Checked)
                bgvTimeInTimeOutFix.ActiveFilterString = "Updated != -1";
            else
                bgvTimeInTimeOutFix.ActiveFilterString = string.Empty;
        }

        private void mnuDataFilter_Click(object sender, EventArgs e)
        {
            bgvTimeInTimeOutFix.FocusedColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            bgvTimeInTimeOutFix.ShowFilterPopup(bgvTimeInTimeOutFix.FocusedColumn);
        }

        private void bgvTimeInTimeOut_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            if (e.Band.HasChildren) return;
            for (int i = 0; i < e.Info.InnerElements.Count; i++)
            {
                if (e.Info.InnerElements[i].ElementInfo is DevExpress.XtraEditors.Drawing.GridFilterButtonInfoArgs) return;
            }

            GridSmartSkinFilterButtonPainter painter = new GridSmartSkinFilterButtonPainter(LookAndFeel);
            GridFilterButtonInfoArgs filterButtonInfo = new GridFilterButtonInfoArgs();
            filterButtonInfo.Cache = e.Cache;
            filterButtonInfo.Graphics = e.Graphics;

            DrawElementInfo elementInfo = e.Info.InnerElements.Add(painter, filterButtonInfo);
            elementInfo.RequireTotalBounds = true;
            e.Info.InnerElements.CalcBounds(e.Info, e.Cache, e.Painter.GetObjectClientRectangle(e.Info), e.Bounds);

            Rectangle captionRect = e.Info.CaptionRect;
            captionRect.Width -= elementInfo.ElementInfo.Bounds.Width;
            e.Info.CaptionRect = captionRect;
        }

        private void bgvTimeInTimeOut_MouseDown(object sender, MouseEventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hitInfo;
            if (view == null) return;
            if ((e.Button & MouseButtons.Left) != 0)
            {
                hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                GridBand band = hitInfo.Band;
                if (band != null && hitInfo.InBandPanel)
                {
                    BandedGridViewInfo viewInfo = (BandedGridViewInfo)view.GetViewInfo();
                    DevExpress.Utils.Drawing.DrawElementInfo elementInfo = viewInfo.BandsInfo.FindBand(band).InnerElements.Find(typeof(GridFilterButtonInfoArgs));
                    if (elementInfo != null)
                    {
                        GridFilterButtonInfoArgs filterButtonInfo = (GridFilterButtonInfoArgs)elementInfo.ElementInfo;
                        if (filterButtonInfo != null && filterButtonInfo.Bounds.Contains(e.Location))
                        {
                            if (band.Columns.Count == 1)
                            {
                                band.Columns[0].OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
                                view.ShowFilterPopup(band.Columns[0]);
                            }
                            else
                            {
                                view.FocusedColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
                                view.ShowFilterPopup(view.FocusedColumn);
                            }
                            DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        }
                    }
                }
            }
        }

        private void dateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Application.DoEvents();
                if (reportData.Tables.Contains("TimeInTimeOut"))
                {
                    reportData.BreakOutBreakIn.Clear();
                    reportData.TimeInTimeOut.Clear();
                }
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void bgvTimeInTimeOut_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "LastName")
            //{
            //    BandedGridView view = sender as BandedGridView;
            //    BandedGridViewInfo viewInfo = view.GetViewInfo() as BandedGridViewInfo;
            //    GridRowInfo rowInfo = viewInfo.GetGridRowInfo(e.RowHandle);
            //    GridCellInfo cellInfo = viewInfo.GetGridCellInfo(e.RowHandle, e.Column.AbsoluteIndex);
            //    foreach (DevExpress.XtraGrid.Views.Base.ViewInfo.IndentInfo indentInfo in cellInfo.Bounds.
                //for (int i = rowInfo.Lines.Count - 1; i >= 0; i--)
                //{
                //    DevExpress.XtraGrid.Views.Base.ViewInfo.IndentInfo indentInfo = rowInfo.Lines[i];
                //    if ((indentInfo.Bounds.Width > 1 && indentInfo.Bounds.Y < rowInfo.Bounds.Bottom - 1))
                //    rowInfo.Lines.RemoveAt(i);
                //}
            //}
        }
    }
}
