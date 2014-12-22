using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Data;
using Database;
using DevExpress.XtraGrid;
using System.Runtime.InteropServices;
using Common;
using System.Drawing;
using System.Reflection;

namespace Attendance.Classes
{
    class MonthWorking : ExportToExcel
    {
        private BandedGridView bgv;
        private int departmentCount, month, year, maxLevel;
        private string fileName;
        private float rate = 8f;
        private int splitColumn = 5;
        private int fixRow = 7;

        public MonthWorking(string fileName, string sheetName, string fontName, BandedGridView bgv, int departmentCount, byte month, Int16 year)
            : base(sheetName, fontName)
        {
            this.bgv = bgv;
            this.departmentCount = departmentCount;
            this.month = month;
            this.year = year;
            this.fileName = fileName;
        }

        private void CreateHeader(GridBand band, ref int x, int y, ref int w)
        {
            if (band.HasChildren)
            {
                int x1 = x + 1;
                foreach (GridBand b in band.Children)
                {
                    if (b.Visible) CreateHeader(b, ref x, y + 1, ref w);
                }
                if (band.Visible) SetText(GetColumnNameFromIndex(x1) + y.ToString(), GetColumnNameFromIndex(w) + y.ToString(), 0, true, 10, true, Color.FromArgb(153, 204, 255), XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, band.Caption);
            }
            else
            {
                if (band.Visible)
                {
                    int row = y + maxLevel - band.BandLevel, w1 = 0, p1, p2 = 0, p3 = 0;
                    string col, formatString = "@", fs;
                    XlHAlign horizontal = XlHAlign.xlHAlignGeneral;
                    BandedGridColumn bgc;
                    for (int i = 0; i < band.Columns.Count; i++)
                    {
                        bgc = band.Columns[i];
                        w1++;
                        col = GetColumnNameFromIndex(x + w1);
                        if (!bgc.ColumnType.Equals(typeof(string)))
                        {
                            //formatString = bgc.DisplayFormat.FormatString;
                            //p1 = formatString.IndexOf('.');
                            //if (p1 >= 0) p2 = formatString.IndexOf(';', p1);
                            //if (p1 >= 0 && p2 >= 0)
                            //{
                            //    fs = formatString.Substring(p1 + 1, p2 - p1 - 1);
                            //    if (fs == string.Empty)
                            //    {
                            //        formatString = formatString.Remove(p1, 1);
                            //        p3 = formatString.IndexOf(';', p2);
                            //        if (p3 >= 0 && p3 == formatString.Length - 1) formatString = formatString.Insert(p3 + 1, "0");
                            //    }
                            //    else
                            //    {
                            //        formatString = formatString.Remove(p1 + 1, fs.Length);
                            //        formatString = formatString.Insert(p1 + 1, new string('0', fs.Length));
                            //        p3 = formatString.IndexOf(';', p2 + 1);
                            //        if (p3 >= 0 && p3 == formatString.Length - 1) formatString = formatString.Insert(p3 + 1, "0");
                            //    }                                
                            //}
                            formatString = "General";
                        }
                        switch (bgc.AppearanceCell.HAlignment)
                        {
                            case DevExpress.Utils.HorzAlignment.Center:
                                horizontal = XlHAlign.xlHAlignCenter;
                                break;
                            case DevExpress.Utils.HorzAlignment.Far:
                                horizontal = XlHAlign.xlHAlignRight;
                                break;
                            case DevExpress.Utils.HorzAlignment.Near:
                                horizontal = XlHAlign.xlHAlignLeft;
                                break;
                        }
                        if (band.AppearanceHeader.BackColor.IsEmpty)
                            FormatCells(col + (row + 1).ToString(), col + (row + bgv.RowCount + 10).ToString(), 7.57f, formatString, horizontal, XlVAlign.xlVAlignCenter, 10);
                        else
                            FormatCells(col + (row + 1).ToString(), col + (row + bgv.RowCount + 10).ToString(), 7.57f, formatString, band.AppearanceHeader.BackColor, horizontal, XlVAlign.xlVAlignCenter, 10);
                    }
                    w += w1;
                    if (band.AppearanceHeader.BackColor.IsEmpty)
                        SetText(GetColumnNameFromIndex(x + 1) + y.ToString(), GetColumnNameFromIndex(w) + row.ToString(), 0, true, 10, true, Color.FromArgb(153, 204, 255), XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, band.Caption);
                    else
                        SetText(GetColumnNameFromIndex(x + 1) + y.ToString(), GetColumnNameFromIndex(w) + row.ToString(), 0, true, 10, true, band.AppearanceHeader.BackColor, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, band.Caption);
                    x += w1;
                }
            }
        }
        public void FillData(int maxLevel)
        {
            string departmentName = string.Empty, currentDepartmentName = string.Empty, col, formula;
            object[] value = new object[bgv.VisibleColumns.Count];
            int x = 0, y = 1, w = 0, group = 0, index = 0;
            string[] summaryItems = new string[bgv.VisibleColumns.Count];

            col = GetColumnNameFromIndex(bgv.VisibleColumns.Count);
            //SetText("A1", col + "1", 0, false, 8, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignLeft, XlVAlign.xlVAlignCenter, TitleTable.GetValue("COMPANY_NAME", Constant.language));
            //SetText("A2", col + "2", 0, false, 8, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignLeft, XlVAlign.xlVAlignCenter, TitleTable.GetValue("ADDRESS", Constant.language));
            //SetText("A3", col + "3", 0, false, 8, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignLeft, XlVAlign.xlVAlignCenter, TitleTable.GetValue("TEL", Constant.language));
            //SetText("A4", col + "4", 0, false, 18, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthOvertime.xrlTitle", Constant.language));
            //SetText("A5", col + "5", 0, false, 8, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, string.Format(TitleTable.GetValue("MonthYear", Constant.language), month.ToString(), year.ToString()));
            SetText("A1", "P1", 0, false, 14, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthAttendance.CompanyName", Constant.language));
            SetText("A2", "N2", 0, false, 12, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthAttendance.CompanyName", "Tiếng Trung"));
            
            SetText("A4", col + "4", 0, false, 14, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthOvertime.xrlTitle", Constant.language));
            
            SetText("A5", col + "5", 0, false, 14, true, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, string.Format(TitleTable.GetValue("MonthYear", Constant.language), month.ToString(), year.ToString()));

            y = fixRow;
            this.maxLevel = maxLevel;
            for (int i = 0; i < bgv.Bands.Count; i++)
            {
                CreateHeader(bgv.Bands[i], ref x, y, ref w);
            }
            SetBorders("A" + y.ToString(), GetColumnNameFromIndex(w) + (y + maxLevel).ToString(), false);

            SetRowHeight("A" + (y + 1).ToString(), GetColumnNameFromIndex(w) + (y + 1).ToString(), 72.75f);
            SetRowHeight("A" + (y + 2).ToString(), GetColumnNameFromIndex(w) + (y + 2).ToString(), 56.25f);

            y = y + maxLevel;

            for (int r = 0; r < bgv.DataRowCount; r++)
            {
                for (int i = 0; i < bgv.VisibleColumns.Count; i++)
                {
                    value.SetValue(bgv.GetRowCellValue(r, bgv.VisibleColumns[i]), i);
                }
                currentDepartmentName = bgv.GetGroupRowValue(r).ToString();
                if (departmentName != currentDepartmentName)
                {
                    if (departmentName != string.Empty)
                    {
                        index = 0;
                        for (int i = 0; i < bgv.VisibleColumns.Count; i++)
                        {
                            index++;
                            if (bgv.VisibleColumns[i].SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
                            {
                                col = GetColumnNameFromIndex(index);
                                switch (bgv.VisibleColumns[i].SummaryItem.SummaryType)
                                {
                                    case DevExpress.Data.SummaryItemType.Count:
                                        FormatCells(col + y.ToString(), col + y.ToString(), "General", XlHAlign.xlHAlignRight, XlVAlign.xlVAlignCenter, 10, true);
                                        SetText(col + y.ToString(), "Bold", Color.Transparent, "=COUNTA(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 42f);
                                        summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                                        break;
                                    case DevExpress.Data.SummaryItemType.Sum:
                                        SetText(col + y.ToString(), "Bold", Color.Transparent, "=SUM(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 42f);
                                        summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                                        break;
                                }
                            }
                        }
                        SetBorders("A" + y.ToString(), GetColumnNameFromIndex(w) + y.ToString(), false);
                        SetBorders("A" + (group + 1).ToString(), GetColumnNameFromIndex(w) + (y - 1).ToString(), XlLineStyle.xlDashDot);
                    }
                    y++;
                    departmentName = currentDepartmentName;
                    SetText("C" + y.ToString(), 0, false, 10, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignLeft, XlVAlign.xlVAlignCenter, departmentName, 36.75f);
                    //SetBorders("A" + y.ToString(), GetColumnNameFromIndex(w) + y.ToString(), false);
                    group = y;
                    y++;
                    
                }                
                SetText("A" + y.ToString(), GetColumnNameFromIndex(value.Length) + y.ToString(), value, 32f);
                y++;
            }

            index = 0;
            for (int i = 0; i < bgv.VisibleColumns.Count; i++)
            {
                index++;
                if (bgv.VisibleColumns[i].SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
                {
                    col = GetColumnNameFromIndex(index);
                    switch (bgv.VisibleColumns[i].SummaryItem.SummaryType)
                    {
                        case DevExpress.Data.SummaryItemType.Custom:
                            SetText(col + (y + 1).ToString(), "Bold", Color.FromArgb(255, 255, 255), bgv.Columns[i].SummaryItem.GetDisplayText(null, true));
                            break;
                        case DevExpress.Data.SummaryItemType.Count:
                            FormatCells(col + y.ToString(), col + (y + 1).ToString(), "General", XlHAlign.xlHAlignRight, XlVAlign.xlVAlignCenter, 10, true);
                            SetText(col + y.ToString(), "Bold", Color.Transparent, "=COUNTA(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 42f);
                            summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                            formula = "=SUM(" + summaryItems[index - 1] + ")";
                            SetText(col + (y + 1).ToString(), "Bold", Color.FromArgb(255, 255, 255), formula);
                            break;
                        case DevExpress.Data.SummaryItemType.Sum:
                            SetText(col + y.ToString(), "Bold", Color.Transparent, "=SUM(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 42f);
                            summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                            formula = "=SUM(" + summaryItems[index - 1] + ")";
                            SetText(col + (y + 1).ToString(), "Bold", Color.FromArgb(255, 255, 255), formula);
                            break;
                    }
                }
                else
                {
                    col = GetColumnNameFromIndex(index);
                    SetText(col + (y + 1).ToString(), col + (y + 1).ToString(), true, Color.FromArgb(255, 255, 255), XlHAlign.xlHAlignCenter, string.Empty, 42f);
                }
            }


            //Style
            SetBorders("A" + y.ToString(), GetColumnNameFromIndex(w) + y.ToString(), false);
            SetBorders("A" + (group + 1).ToString(), GetColumnNameFromIndex(w) + (y - 1).ToString(), XlLineStyle.xlDashDot);
            SetBorders("A" + (y + 1).ToString(), GetColumnNameFromIndex(w) + (y + 1).ToString(), false);


            //FreezePanes
            application.ActiveWindow.SplitColumn = splitColumn;
            application.ActiveWindow.SplitRow = fixRow + maxLevel;
            application.ActiveWindow.FreezePanes = true;

            workbook.SaveAs(fileName, XlFileFormat.xlWorkbookNormal, null, null, false, false, XlSaveAsAccessMode.xlExclusive, false, false, false, false, false);
            if (worksheet != null)
            {
                Marshal.ReleaseComObject(worksheet);
                worksheet = null;
            }
            workbook.Close(false, null, null);
            application.Quit();
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            Marshal.ReleaseComObject(workbooks);
            workbooks = null;

            Marshal.ReleaseComObject(application);
            application = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}