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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Attendance.Classes
{
    class MonthAttendance : ExportToExcel
    {
        private BandedGridView bgv;
        private RegisterAttendanceItemTable registerAttendanceItem;
        private RegisterAbsenceTable registerAbsence;
        private int departmentCount, month, year, maxLevel;
        private string fileName;
        private float rate = 10f;
        private float rowHeight = 35.2f;

        public MonthAttendance(string fileName, string sheetName, string fontName, BandedGridView bgv, RegisterAttendanceItemTable registerAttendanceItem, int departmentCount, byte month, Int16 year)
            : base(sheetName, fontName)
        {
            this.bgv = bgv;
            this.registerAttendanceItem = registerAttendanceItem;
            this.departmentCount = departmentCount;
            this.month = month;
            this.year = year;
            this.fileName = fileName;
        }

        public MonthAttendance(string fileName, string sheetName, string fontName, BandedGridView bgv, RegisterAttendanceItemTable registerAttendanceItem, RegisterAbsenceTable registerAbsence, int departmentCount, byte month, Int16 year)
            : base(sheetName, fontName)
        {
            this.bgv = bgv;
            this.registerAttendanceItem = registerAttendanceItem;
            this.registerAbsence = registerAbsence;
            this.departmentCount = departmentCount;
            this.month = month;
            this.year = year;
            this.fileName = fileName;
        }

        private bool IsDecimal(String NumIn, out Decimal NumOut)
        {
            return Decimal.TryParse(NumIn, out NumOut);
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
                if (band.Visible)
                {
                    SetText(GetColumnNameFromIndex(x1) + y.ToString(), GetColumnNameFromIndex(w) + y.ToString(), 0, true, 10, true, Color.FromArgb(153, 204, 255), XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, band.Caption);
                }
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
                            //FormatCells(col + (row + 1).ToString(), col + (row + bgv.RowCount + 10).ToString(), bgc.Width / rate, formatString, horizontal, XlVAlign.xlVAlignCenter, 10);
                            FormatCells(col + (row + 1).ToString(), col + (row + bgv.RowCount + 10).ToString(), 6.86f, formatString, horizontal, XlVAlign.xlVAlignCenter, 10);
                        else
                            //FormatCells(col + (row + 1).ToString(), col + (row + bgv.RowCount + 10).ToString(), bgc.Width / rate, formatString, band.AppearanceHeader.BackColor, horizontal, XlVAlign.xlVAlignCenter, 10);
                            FormatCells(col + (row + 1).ToString(), col + (row + bgv.RowCount + 10).ToString(), 6.86f, formatString, band.AppearanceHeader.BackColor, horizontal, XlVAlign.xlVAlignCenter, 10);
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
            object[] color = new object[bgv.VisibleColumns.Count];

            int no = 1, x = 0, y = 1, w = 0, group = 0, index = 0;
            string[] summaryItems = new string[bgv.VisibleColumns.Count];

            col = GetColumnNameFromIndex(bgv.VisibleColumns.Count);
            //30.75
            SetText("A1", "P1", 0, false, 14, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthAttendance.CompanyName", Constant.language));
            //SetText("A2", "N2", 0, false, 12, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthAttendance.CompanyName", "Tiếng Trung"));
            //SetText("A3", col + "3", 0, false, 10, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignLeft, XlVAlign.xlVAlignCenter, TitleTable.GetValue("TEL", Constant.language));
            SetText("A4", col + "4", 0, false, 14, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, TitleTable.GetValue("MonthAttendance.xrlTitle", Constant.language));
            SetText("A5", col + "5", 0, false, 14, true, true, XlColorIndex.xlColorIndexNone, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, string.Format(TitleTable.GetValue("MonthYear", Constant.language), month.ToString(), year.ToString()));

            y = 7;
            this.maxLevel = maxLevel;
            for (int i = 0; i < bgv.Bands.Count; i++)
            {
                CreateHeader(bgv.Bands[i], ref x, y, ref w);
            }
            SetBorders("A" + y.ToString(), GetColumnNameFromIndex(w) + (y + maxLevel).ToString(), false);
            SetRowHeight("A" + y.ToString(), GetColumnNameFromIndex(w) + (y).ToString(), 57f);

            y = y + maxLevel;
            for (int r = 0; r < bgv.DataRowCount; r++)
            {
                for (int i = 0; i < bgv.VisibleColumns.Count; i++)
                {
                    value.SetValue(bgv.GetRowCellValue(r, bgv.VisibleColumns[i]), i);
                    Color clor = Color.FromArgb(255, 255, 255);
                    if (i < System.DateTime.DaysInMonth(year, month))
                    {
                        int EmployeeID = Convert.ToInt32(bgv.GetRowCellValue(r, "EmployeeID"));
                        if (EmployeeID > 0)
                        {
                            String TexValue = bgv.GetRowCellValue(r, "W" + (i + 1).ToString()).ToString();
                            switch (TexValue)
                            {
                                case "NS":
                                    clor = Color.FromArgb(192, 192, 192);
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
                                    clor = Color.FromArgb(255, 153, 204);
                                    break;
                                default:
                                    break;
                            }
                            //Other
                            Decimal outValue = 0M;
                            if (IsDecimal(TexValue, out outValue))
                            {
                                if (registerAbsence.FindByPrimaryKey(EmployeeID, new DateTime(year, month, Convert.ToInt32((i + 1).ToString())), "PN") != null)
                                {
                                    clor = Color.FromArgb(255, 153, 204);
                                }
                                if (registerAbsence.FindByPrimaryKey(EmployeeID, new DateTime(year, month, Convert.ToInt32((i + 1).ToString())), "NP") != null)
                                {
                                    clor = Color.FromArgb(255, 255, 0);
                                }
                            }
                        }
                    }
                    color.SetValue(clor, i);
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
                                        SetText(col + y.ToString(), "Bold", Color.Transparent, "=COUNTA(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 33f);
                                        summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                                        break;
                                    case DevExpress.Data.SummaryItemType.Sum:
                                        SetText(col + y.ToString(), "Bold", Color.Transparent, "=SUM(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 33f);
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
                SetText("A" + y.ToString(), GetColumnNameFromIndex(value.Length) + y.ToString(), color, value, rowHeight, 4);
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
                            SetText(col + (y + 1).ToString(), "Bold", Color.FromArgb(255, 255, 255), bgv.Columns[i].SummaryItem.GetDisplayText(null, true), 33f);
                            break;
                        case DevExpress.Data.SummaryItemType.Count:
                            FormatCells(col + y.ToString(), col + (y + 1).ToString(), "General", XlHAlign.xlHAlignRight, XlVAlign.xlVAlignCenter, 10, true);
                            SetText(col + y.ToString(), "Bold", Color.Transparent, "=COUNTA(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 33f);
                            summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                            formula = "=SUM(" + summaryItems[index - 1] + ")";
                            SetText(col + (y + 1).ToString(), "Bold", Color.FromArgb(255, 255, 255), formula, 33f);
                            break;
                        case DevExpress.Data.SummaryItemType.Sum:
                            SetText(col + y.ToString(), "Bold", Color.Transparent, "=SUM(" + col + (group + 1).ToString() + ":" + col + (y - 1).ToString() + ")", 33f);
                            summaryItems[index - 1] += (summaryItems[index - 1] == null) ? (col + y.ToString()) : "," + (col + y.ToString());
                            formula = "=SUM(" + summaryItems[index - 1] + ")";
                            SetText(col + (y + 1).ToString(), "Bold", Color.FromArgb(255, 255, 255), formula, 33f);
                            break;
                    }
                }
                else
                {
                    col = GetColumnNameFromIndex(index);
                    SetText(col + (y + 1).ToString(), col + (y + 1).ToString(), true, Color.FromArgb(255, 255, 255), XlHAlign.xlHAlignCenter, string.Empty, 33f);
                }
            }
            Range range = null;
            string address = string.Empty;
            foreach (RegisterAttendanceItemRow rair in registerAttendanceItem)
            {
                range = worksheet.get_Range("B7", "B" + y.ToString()).Find(rair["EmployeeCode"], Missing.Value, Microsoft.Office.Interop.Excel.XlFindLookIn.xlValues, Microsoft.Office.Interop.Excel.XlLookAt.xlWhole, Microsoft.Office.Interop.Excel.XlSearchOrder.xlByColumns, Microsoft.Office.Interop.Excel.XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
                if (range != null)
                {
                    address = range.get_Address(false, false, Microsoft.Office.Interop.Excel.XlReferenceStyle.xlA1, Missing.Value, Missing.Value);
                    range = ((Range)worksheet.Cells[address.Substring(1), rair.FromDate.Day + 5]);
                    range.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                    range.AddComment(rair.Notes);
                }
            }
            //SetText(GetColumnNameFromIndex(endSummary + 1).ToString() + (group + no).ToString(), GetColumnNameFromIndex(w).ToString() + (group + no).ToString(), true, Color.FromArgb(153, 204, 255), XlHAlign.xlHAlignCenter, string.Empty);
            SetBorders("A" + y.ToString(), GetColumnNameFromIndex(w) + y.ToString(), false);
            SetBorders("A" + (group + 1).ToString(), GetColumnNameFromIndex(w) + (y - 1).ToString(), XlLineStyle.xlDashDot);
            SetBorders("A" + (y + 1).ToString(), GetColumnNameFromIndex(w) + (y + 1).ToString(), false);

            //y += 5;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "Ký hiệu 符號");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Ngừng việc: N");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Hội nghị, học tập: H");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "X Ngày công 上辦日");
            //SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Người duyệt");
            //SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Phòng HCNS");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "NP: Nghỉ có phép 有請假");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ mát: M");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ Tết: NT");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "1/2: Đi làm nửa ngày 上班天");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ không lương: Ro");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ lễ: NL");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "KP: Nghỉ không phép 曠職");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "O: Nghỉ ốm 病假");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "KH: Nghỉ kết hôn 婚假");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "PN: Phép năm 年假");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "NL: Nghỉ lễ  国定");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "TS: Thai sản 產假");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "NTT: Tử tuất 尚假");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "CO: Con ốm 孩子生病");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            //y++;
            //SetText("C" + y.ToString(), "Regular", true, Color.Transparent, "KL : Không lương");
            ////SetText("O" + y.ToString(), "O" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Nghỉ bù: B");
            ////SetText("AA" + y.ToString(), "AA" + y.ToString(), false, Color.Transparent, XlHAlign.xlHAlignLeft, "Làm 1/2 ngày: X/2");
            ////y += 2;
            ////SetText("AA" + y.ToString(), "Italic", Color.Transparent, string.Format("Hà nội, ngày {0} tháng {1} năm {2}", DateTime.DaysInMonth(year, month), month, year));
            ////y++;
            ////SetText("C" + y.ToString(), "Bold", Color.Transparent, "Người lập bảng");
            ////SetText("O" + y.ToString(), "Bold", Color.Transparent, "Phụ trách phòng");
            ////SetText("AA" + y.ToString(), "Bold", Color.Transparent, "Xác nhận của bộ phận nhân sự");

            application.ActiveWindow.SplitColumn = 4;
            application.ActiveWindow.SplitRow = 7 + maxLevel;
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