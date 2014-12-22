using Database;
using System;
using System.Data.SqlClient;
using System.Data;
using Common;

namespace Attendance.Reports
{
    public partial class ReportData {
        partial class DailyAttendingDataTable
        {
            public int GetList(string departmentIDList, DateTime workingDay)
            {
                SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_DailyAttending", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
                sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                try
                {
                    Connection.Open();
                    sqlDataAdapter.Fill(this);
                }
                catch
                {
                }
                finally
                {
                    Connection.Close();
                }
                return Count;
            }
            public void DeleteByDepartmentID(string departmentIDList)
            {
                foreach (DailyAttendingRow dar in this)
                {
                    if (departmentIDList.IndexOf("[" + dar.DepartmentID + "]") >= 0) dar.Delete();
                }
                AcceptChanges();
            }
        }

        public int GetMonthOTByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate, string employeeIDList, bool check)
        {
            
            try
            {
                if (check)
                {
                    SqlCommand sqlCommand = new SqlCommand("MonthOT_GetListByDepartmentID", Connection.GetConnection());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
                    sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                    sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                    sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                    sqlCommand.CommandTimeout = 0;

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    Connection.Open();
                    sqlDataAdapter.Fill(tableMonthOT);
                }
                else
                {
                    foreach (DataRow row  in tableMonthOT)
                    {
                        if (departmentIDList.IndexOf("[" + row["DepartmentID"] + "]") >= 0) row.Delete();
                    }
                    tableMonthOT.AcceptChanges();
                }
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return tableMonthOT.Rows.Count;
        }

        public int GetListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate, string employeeIDList, bool errorDays, bool allDays, bool check)
        {
            try
            {
                if (check)
                {
                    SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_GetListByDepartmentID", Connection.GetConnection());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
                    sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                    sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                    sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                    sqlCommand.Parameters.Add("@AllDays", SqlDbType.Bit, 1).Value = allDays;
                    sqlCommand.CommandTimeout = 0;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    Connection.Open();
                    sqlDataAdapter.Fill(tableTimeInTimeOut);

                    sqlCommand = new SqlCommand("BreakOutBreakIn_GetListByDepartmentID", Connection.GetConnection());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
                    sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                    sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                    sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                    sqlCommand.CommandTimeout = 0;
                    sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    Connection.Open();
                    sqlDataAdapter.Fill(tableBreakOutBreakIn);
                }
                else
                {
                    foreach (TimeInTimeOutRow tito in tableTimeInTimeOut)
                    {
                        if (departmentIDList.IndexOf("[" + tito.DepartmentID + "]") >= 0) tito.Delete();
                    }
                    tableTimeInTimeOut.AcceptChanges();
                    tableBreakOutBreakIn.AcceptChanges();
                }
                if (!Relations.Contains("TimeInTimeOut_BreakOutBreakIn") && ConstantTable.GetValueByName("BreakOutBreakIn") != "0")
                {
                    Relations.Add("TimeInTimeOut_BreakOutBreakIn", new DataColumn[] { tableTimeInTimeOut.EmployeeIDColumn, tableTimeInTimeOut.WorkingDayColumn }, new DataColumn[] { tableBreakOutBreakIn.EmployeeIDColumn, tableBreakOutBreakIn.WorkingDayColumn });
                }
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return tableTimeInTimeOut.Rows.Count;
        }


        public int GetListByDepartmentIDFix(string departmentIDList, DateTime fromDate, DateTime toDate, string employeeIDList, bool errorDays, bool allDays, bool check)
        {
            try
            {
                if (check)
                {
                    SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_GetListByDepartmentIDFix", Connection.GetConnection());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
                    sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                    sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                    sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                    sqlCommand.Parameters.Add("@AllDays", SqlDbType.Bit, 1).Value = allDays;
                    sqlCommand.CommandTimeout = 0;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    Connection.Open();
                    sqlDataAdapter.Fill(tableTimeInTimeOut);

                    sqlCommand = new SqlCommand("BreakOutBreakIn_GetListByDepartmentID", Connection.GetConnection());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
                    sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                    sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                    sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                    sqlCommand.CommandTimeout = 0;
                    sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    Connection.Open();
                    sqlDataAdapter.Fill(tableBreakOutBreakIn);
                }
                else
                {
                    foreach (TimeInTimeOutRow tito in tableTimeInTimeOut)
                    {
                        if (departmentIDList.IndexOf("[" + tito.DepartmentID + "]") >= 0) tito.Delete();
                    }
                    tableTimeInTimeOut.AcceptChanges();
                    tableBreakOutBreakIn.AcceptChanges();
                }
                if (!Relations.Contains("TimeInTimeOut_BreakOutBreakIn") && ConstantTable.GetValueByName("BreakOutBreakIn") != "0")
                {
                    Relations.Add("TimeInTimeOut_BreakOutBreakIn", new DataColumn[] { tableTimeInTimeOut.EmployeeIDColumn, tableTimeInTimeOut.WorkingDayColumn }, new DataColumn[] { tableBreakOutBreakIn.EmployeeIDColumn, tableBreakOutBreakIn.WorkingDayColumn });
                }
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return tableTimeInTimeOut.Rows.Count;
        }
        public int GetListByDepartmentID_Virtual(string departmentIDList, DateTime fromDate, DateTime toDate, string employeeIDList, bool check)
        {
            if (check)
            {
                SqlCommand sqlCommand = new SqlCommand("VirtualTimeInTimeOut_GetListByDepartmentID", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Connection.Open();
                sqlDataAdapter.Fill(tableTimeInTimeOut);

                sqlCommand = new SqlCommand("VirtualBreakOutBreakIn_GetListByDepartmentID", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Connection.Open();
                sqlDataAdapter.Fill(tableBreakOutBreakIn);
            }
            else
            {
                foreach (TimeInTimeOutRow tito in tableTimeInTimeOut)
                {
                    if (departmentIDList.IndexOf("[" + tito.DepartmentID + "]") >= 0) tito.Delete();
                }
                tableTimeInTimeOut.AcceptChanges();
                tableBreakOutBreakIn.AcceptChanges();
            }
            if (!Relations.Contains("TimeInTimeOut_BreakOutBreakIn") && ConstantTable.GetValueByName("BreakOutBreakIn") != "0")
            {
                Relations.Add("TimeInTimeOut_BreakOutBreakIn", new DataColumn[] { tableTimeInTimeOut.EmployeeIDColumn, tableTimeInTimeOut.WorkingDayColumn }, new DataColumn[] { tableBreakOutBreakIn.EmployeeIDColumn, tableBreakOutBreakIn.WorkingDayColumn });
            }
            Connection.Close();

            return tableTimeInTimeOut.Rows.Count;
        }

        public bool ResetTimeInTimeOut(Int32 EmployeeID, DateTime WorkingDay)
        {
            return RawDataTable.ProcessReset(EmployeeID, WorkingDay);
        }

        public bool ResetTimeInTimeOut(int employeeID, DateTime fromDate, DateTime toDate)
        {
            string employeeIDList = string.Empty;
            EmployeeTable employee = new EmployeeTable();

            if (employeeID != 0)
                employeeIDList = "[" + employeeID + "]";
            else
            {
                int _employeeID;
                employee.GetListByDepartmentIDAndDuration(Constant.departmentIDList, fromDate, string.Empty);
                foreach (EmployeeRow er in employee)
                {
                    _employeeID = er.ID;
                    employeeIDList += "[" + _employeeID + "]";
                }
            }
            return RawDataTable.Reset(employeeIDList, fromDate, toDate);
        }

        partial class TimeInTimeOutDataTable
        {

        }
    
        partial class AuthorizedAbsenceDataTable
        {
            public int GetListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID)
            {
                SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_GetListByDepartmentID", Connection.GetConnection());

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.VarChar, 15).Value = employeeID;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //try
                {
                    Connection.Open();
                    sqlDataAdapter.Fill(this);
                }
                //catch
                {
                }
                //finally
                {
                    Connection.Close();
                }

                return Count;
            }
            public void DeleteByDepartmentID(string departmentIDList)
            {
                foreach (AuthorizedAbsenceRow aar in this)
                {
                    if (departmentIDList.IndexOf("[" + aar.DepartmentID + "]") >= 0) aar.Delete();
                }
                AcceptChanges();
            }
        }
    }
}
