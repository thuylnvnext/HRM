using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Attendance.Forms
{    
    public partial class ImportFromExcel : Form
    {
        private ApplicationClass applicationClass;
        private Workbooks workBooks;
        private Workbook workbook;
        private Worksheet worksheet;
        private Sheets sheets;
        private string departmentID;
        private DateTime _beginDate, _endDate;

        public ImportFromExcel()
        {
            InitializeComponent();
        }

        public ImportFromExcel(string departmentID, DateTime beginDate, DateTime endDate)
        {
            InitializeComponent();
            this.departmentID = departmentID;
            this._beginDate = beginDate;
            this._endDate = endDate;
        }

        private int DaysInDuration(DateTime beginDate, DateTime endDate)
        {
            DateTime b = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day);
            DateTime e = new DateTime(endDate.Year, endDate.Month, endDate.Day);
            TimeSpan diffDate = e.Subtract(b);

            return diffDate.Days + 1;
        }

        private void OpenExcelFile()
        {
            applicationClass = new ApplicationClass();
            workBooks = applicationClass.Workbooks;
            workbook = workBooks.Open(txtExcelFile.Text, 2, false, 5, null, null, true, XlPlatform.xlWindows, null, true, true, null, false, true, null);
            sheets = workbook.Sheets;

            btnOK.Enabled = true;
        }

        private string GetColumnNameFromIndex(int index)
        {
            string endColumn = string.Empty;
            int f, s;

            f = (int)(index / 26) + 64;
            s = index % 26 + 64;

            if (f > 64) endColumn = ((char)f).ToString();
            endColumn += ((char)s).ToString();

            return endColumn;
        }

        private void FillData()
        {
            int r = 9, year, month, day;
            DateTime timeIn, timeOut;
            bool endData = false;
            Range workingDayRange;
            int employeeID, currentEmployeeID = 0;
            string workingDay;
            
            worksheet = (Worksheet)sheets[1];            
            do
            { 
                workingDayRange = (Range)worksheet.Cells[r, 5];
                if (workingDayRange.Value2 != null)
                {
                    employeeID = Convert.ToInt32(((Range)worksheet.Cells[r, 2]).Value2);
                    if (employeeID == 0) employeeID = currentEmployeeID;
                    workingDay = workingDayRange.get_Value(Missing.Value).ToString();
                    timeIn = Convert.ToDateTime(((Range)worksheet.Cells[r, 9]).Text);
                    timeOut = Convert.ToDateTime(((Range)worksheet.Cells[r, 10]).Text);
                    year = Convert.ToInt32(workingDay.Substring(6, 4));
                    month = Convert.ToInt32(workingDay.Substring(3, 2));
                    day = Convert.ToInt32(workingDay.Substring(0, 2));
                    TimeInTimeOutTable.DeleteValue(employeeID, new DateTime(year, month, day), string.Empty);
                    RawDataTable.InsertValue(employeeID, new DateTime(year, month, day, timeIn.Hour, timeIn.Minute, timeIn.Second), new DateTime(year, month, day, timeIn.Hour, timeIn.Minute, timeIn.Second), true, true);
                    RawDataTable.InsertValue(employeeID, new DateTime(year, month, day, timeOut.Hour, timeOut.Minute, timeOut.Second), new DateTime(year, month, day, timeOut.Hour, timeOut.Minute, timeOut.Second), false, true);
                    currentEmployeeID = employeeID;
                }
                else
                {
                    endData = true;
                }
                r++;
            } while (!endData);

            workbook.Close(false, null, null);
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            Marshal.ReleaseComObject(workBooks);
            workBooks = null;
            applicationClass.Quit();
            Marshal.ReleaseComObject(applicationClass);
            applicationClass = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void FillData1()
        {
            //WorkingTimeTable workingTime = new WorkingTimeTable();
            //WorkingTimeRow wtr = null;
            //EmployeeWorkTable employeeWork = new EmployeeWorkTable();
            //S_ParameterEmployeeTable s_ParameterEmployee = new S_ParameterEmployeeTable();
            //EmployeeHolidayTable employeeHoliday = new EmployeeHolidayTable();
            //string s = string.Empty;
            ////try
            //{
            //    string subject = workbook.Subject, workingCycle = subject.Substring(0, 17), value = string.Empty, prefix = string.Empty;
            //    DateTime beginDate = new DateTime(Convert.ToInt32(workingCycle.Substring(4, 4)), Convert.ToInt32(workingCycle.Substring(0, 2)), Convert.ToInt32(workingCycle.Substring(2, 2)));
            //    DateTime endDate = new DateTime(Convert.ToInt32(workingCycle.Substring(13, 4)), Convert.ToInt32(workingCycle.Substring(9, 2)), Convert.ToInt32(workingCycle.Substring(11, 2)));
            //    if (subject.Substring(17) != departmentID || (beginDate != _beginDate && endDate != _endDate)) throw new Exception();
            //    int r = 9, daysInCycle, d, days;
            //    decimal normalWork, dayOffWork, normalOverTime, dayOffOverTime, holidayOverTime, nightWork, holidayWork, annualLeave;
            //    object code, cellValue;
            //    object[,] values, values_OverTime, values_NightShift;
            //    string[] val;
            //    bool endData = false;
            //    Guid employeeID;
            //    Range codeRange, valueRange, valueRange_OverTime, valueRange_NightShift;

            //    worksheet = (Worksheet)sheets[1];
            //    worksheet_OverTime = (Worksheet)sheets[2];
            //    worksheet_NightShift = (Worksheet)sheets[3];
                                                
            //    daysInCycle = DaysInDuration(beginDate, endDate);
            //    do
            //    {
            //        codeRange = (Range)worksheet.Cells[r, 2];
            //        code = codeRange.Value2;
            //        if (code != null)
            //        {
            //            valueRange = worksheet.get_Range("E" + r.ToString(), GetColumnNameFromIndex(daysInCycle + 4) + r.ToString());
            //            values = (object[,])valueRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            //            valueRange_OverTime = worksheet_OverTime.get_Range("E" + r.ToString(), GetColumnNameFromIndex(daysInCycle + 4) + r.ToString());
            //            values_OverTime = (object[,])valueRange_OverTime.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            //            valueRange_NightShift = worksheet_NightShift.get_Range("E" + r.ToString(), GetColumnNameFromIndex(daysInCycle + 4) + r.ToString());
            //            values_NightShift = (object[,])valueRange_NightShift.get_Value(XlRangeValueDataType.xlRangeValueDefault);

            //            employeeID = EmployeeTable.GetIDByCode(code.ToString());
            //            s_ParameterEmployee.GetListByEmployeeID(employeeID, departmentID, beginDate, endDate);
            //            foreach (S_ParameterEmployeeRow per in s_ParameterEmployee)
            //            {
            //                days = DaysInDuration(beginDate, per.BeginDate);
            //                d = days + DaysInDuration(per.BeginDate, per.EndDate);
            //                normalWork = 0;
            //                dayOffWork = 0;
            //                normalOverTime = 0;
            //                dayOffOverTime = 0;
            //                holidayOverTime = 0;
            //                nightWork = 0;
            //                holidayWork = 0;
            //                for (int i = days; i < d; i++)
            //                {
            //                    annualLeave = 0;
            //                    //Công thường
            //                    cellValue = values.GetValue(1, i);
            //                    if (cellValue != null)
            //                    {
            //                        val = cellValue.ToString().Split('/');
            //                        value = val[0];
            //                        switch (value.ToUpper())
            //                        {
            //                            case "1":                                        
            //                            case "CL":
            //                            case "BT":
            //                            case "ML":
            //                            case "FC":
            //                                normalWork += (val.Length == 1 ? 1 : 0.5m);
            //                                break;
            //                            case "AL":
            //                                normalWork += (val.Length == 1 ? 1 : 0.5m);
            //                                annualLeave = (val.Length == 1 ? 1 : 0.5m);
            //                                break;
            //                            case "1CL":
            //                            case "1BT":
            //                            case "1ML":
            //                            case "1FC":                                        
            //                                normalWork += 1;
            //                                break;
            //                            case "1AL":
            //                                normalWork += 1;
            //                                annualLeave = 0.5m;
            //                                break;
            //                            case "3":
            //                                dayOffWork += (val.Length == 1 ? 1 : 0.5m);
            //                                break;
            //                            case "2":
            //                                normalWork += (val.Length == 1 ? 1 : 0.5m);
            //                                nightWork += (val.Length == 1 ? 8 : 4);                                            
            //                                break;
            //                            case "4":
            //                                nightWork += (val.Length == 1 ? 8 : 4);
            //                                dayOffWork += (val.Length == 1 ? 1 : 0.5m);
            //                                break;
            //                            case "6":
            //                                holidayWork += (val.Length == 1 ? 1 : 0.5m);
            //                                break;
            //                            case "7":                                            
            //                                holidayWork += (val.Length == 1 ? 1 : 0.5m);
            //                                nightWork += (val.Length == 1 ? 8 : 4);
            //                                break;                                        
            //                        }
            //                        if (val.Length == 2)
            //                        {
            //                            switch (val[1])
            //                            {
            //                                case "3":
            //                                    dayOffWork += 0.5m;
            //                                    break;
            //                                case "4":
            //                                    nightWork += 4;
            //                                    dayOffWork += 0.5m;
            //                                    break;
            //                            }
            //                        }
            //                    }
            //                    //s = code.ToString() + " " + per.BeginDate.AddDays(i - days).ToString() + " " + cellValue.ToString();
            //                    //if (cellValue.ToString().Length > 10)
            //                    //{
            //                    //    MessageBox.Show(cellValue.ToString() + " " + code.ToString() + " " + i.ToString());
            //                    //}
            //                    //else
            //                    //{
            //                        wtr = workingTime.AddWorkingTimeRow(Guid.NewGuid(), employeeID, departmentID, per.BeginDate.AddDays(i - days), cellValue == null ? string.Empty : cellValue.ToString().ToUpper(), 0, 0, 1, DateTime.Today, DateTime.Today);
            //                    //}
            //                    //Giờ làm thêm
            //                    cellValue = values_OverTime.GetValue(1, i);
            //                    if (cellValue != null)
            //                    {
            //                        if ((cellValue.ToString().Trim().Length == 1) || (cellValue.ToString().Trim().Length == 3))
            //                        {
            //                            if (Utility.IsNumeric(cellValue))
            //                            {
            //                                normalOverTime += Convert.ToDecimal(cellValue);
            //                                wtr.NormalOverTimeNotation = Convert.ToDecimal(cellValue);
            //                            }
            //                        }
            //                        else
            //                        {
            //                            prefix = cellValue.ToString().Substring(0, 1);
            //                            switch (prefix)
            //                            {
            //                                case "1":
            //                                    if (Utility.IsNumeric(cellValue))
            //                                    {
            //                                        normalOverTime += Convert.ToDecimal(cellValue.ToString().Substring(1));
            //                                        wtr.NormalOverTimeNotation = Convert.ToDecimal(cellValue);
            //                                    }
            //                                    break;
            //                                case "3":
            //                                    if (Utility.IsNumeric(cellValue))
            //                                    {
            //                                        dayOffOverTime += Convert.ToDecimal(cellValue.ToString().Substring(1));
            //                                        wtr.NormalOverTimeNotation = Convert.ToDecimal(cellValue);
            //                                    }
            //                                    break;
            //                                case "6":
            //                                    if (Utility.IsNumeric(cellValue))
            //                                    {
            //                                        holidayOverTime += Convert.ToDecimal(cellValue.ToString().Substring(1));
            //                                        wtr.NormalOverTimeNotation = Convert.ToDecimal(cellValue);
            //                                    }
            //                                    break;
            //                            }
            //                        }
            //                    }
            //                    //Giờ ca đêm
            //                    cellValue = values_NightShift.GetValue(1, i);
            //                    if (cellValue != null)
            //                    {                                    
            //                        if (Utility.IsNumeric(cellValue))
            //                        {
            //                            nightWork += Convert.ToDecimal(cellValue);
            //                            wtr.NightOverTimeNotation = Convert.ToDecimal(cellValue);
            //                        }
            //                    }
            //                    //Ngày nghỉ phép
            //                    if (annualLeave > 0)
            //                    {
            //                        employeeHoliday.AddEmployeeHolidayRow(employeeID, per.BeginDate.AddDays(i - days).ToString("MM/dd/yyyy"), annualLeave, "Nghỉ phép");
            //                    }
            //                }
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P011", normalWork);
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P012", dayOffWork);
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P020", holidayWork);
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P015", normalOverTime);
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P024", dayOffOverTime);
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P025", holidayOverTime);
            //                employeeWork.AddEmployeeWorkRow(Guid.NewGuid(), per.BeginDate, per.EndDate, employeeID, "P018", nightWork);                       
                            
            //            }
            //            days = 1;
            //            Marshal.ReleaseComObject(valueRange);
            //            valueRange = null;
            //            Marshal.ReleaseComObject(valueRange_OverTime);
            //            valueRange_OverTime = null;
            //            Marshal.ReleaseComObject(valueRange_NightShift);
            //            valueRange_NightShift = null;
            //        }
            //        else
            //        {
            //            codeRange = (Range)worksheet.Cells[r + 3, 2];
            //            code = codeRange.Value2;
            //            if (code == null)
            //            {
            //                endData = true;
            //            }
            //            else
            //            {
            //                r += 4;
            //            }
            //            Marshal.ReleaseComObject(codeRange);
            //            codeRange = null;
            //        }
            //        r++;

            //        if (codeRange != null)
            //        {
            //            Marshal.ReleaseComObject(codeRange);
            //            codeRange = null;
            //        }
            //    } while (!endData);

            //    workingTime.Insert();
            //    employeeWork.Insert();
            //    employeeHoliday.Insert();

            //    MessageBox.Show(Properties.Resources.IMPORT_EXCEL_SUCCESS, Properties.Resources.MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    DialogResult = DialogResult.OK;
            //}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show(ex.Message + Properties.Resources.IMPORT_EXCEL_ERROR, Properties.Resources.MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    DialogResult = DialogResult.Cancel;
            ////}
            ////finally
            //{
            //    if (worksheet != null)
            //    {
            //        Marshal.ReleaseComObject(worksheet);
            //        worksheet = null;
            //    }
            //    if (worksheet != null)
            //    {
            //        Marshal.ReleaseComObject(worksheet_OverTime);
            //        worksheet_OverTime = null;
            //    }
            //    if (worksheet != null)
            //    {
            //        Marshal.ReleaseComObject(worksheet_NightShift);
            //        worksheet_NightShift = null;
            //    }
            //    if (worksheet != null)
            //    {
            //        Marshal.ReleaseComObject(sheets);
            //        sheets = null;
            //    }
            //    workbook.Close(false, null, null);
            //    Marshal.ReleaseComObject(workbook);
            //    workbook = null;
            //    Marshal.ReleaseComObject(workBooks);
            //    workBooks = null;
            //    applicationClass.Quit();
            //    Marshal.ReleaseComObject(applicationClass);
            //    applicationClass = null;

            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //}
        }

        private void btnOpenExcelFile_Click(object sender, EventArgs e)
        {           
            ofdExcelFile.ShowDialog();
            if (ofdExcelFile.FileName != string.Empty)
            {
                txtExcelFile.Text = ofdExcelFile.FileName;
                OpenExcelFile();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FillData();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImportFromExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
        }          
    }   
}