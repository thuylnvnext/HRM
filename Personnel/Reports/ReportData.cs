using System.Data.SqlClient;
using System.Data;
using Database;
using System;

namespace Personnel.Reports
{

    public partial class ReportData {
        partial class ResignationDataTable
        {
            public int GetTotal(DateTime fromDate, DateTime toDate)
            {
                SqlCommand sqlCommand = new SqlCommand("Resignation_GetListByDuration", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
        }
    
        partial class LabourContractDataTable
        {
            public int Print(string iD)
            {
                SqlCommand sqlCommand = new SqlCommand("LabourContract_Print", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 4).Value = iD;
                sqlCommand.CommandTimeout = 0;

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
        }
    
        partial class AllowanceDataTable
        {
            public int Print(int employeeID, string labourContractID)
            {
                SqlCommand sqlCommand = new SqlCommand("Allowance_Print", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
                sqlCommand.Parameters.Add("@LabourContractID", SqlDbType.VarChar, 4).Value = labourContractID;
                sqlCommand.CommandTimeout = 0;

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
        }
    
        partial class EmployeeDisciplineDataTable
        {
            public int GetTotal(DateTime fromDate, DateTime toDate)
            {
                SqlCommand sqlCommand = new SqlCommand("Discipline_GetListByDuration", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
        }
    
        partial class AbsenceDataTable
        {
            public int GetTotal(DateTime workingDay)
            {
                SqlCommand sqlCommand = new SqlCommand("Employee_GetListByAbsenceReason", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
        }        
    
        partial class NumberOfEmployeesByGenderDataTable
        {
            public int GetTotal(DateTime workingDay)
            {
                SqlCommand sqlCommand = new SqlCommand("Employee_GetNumberOfEmployeesByGender", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
        }
    
        partial class ChangeDepartmentDataTable
        {
            public int GetTotal(DateTime fromDate, DateTime toDate)
            {
                SqlCommand sqlCommand = new SqlCommand("Employee_GetListChangeDepartment", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
        }
    
        partial class ChangeSalaryDataTable
        {
            public int GetList(DateTime fromDate, DateTime toDate)
            {
                SqlCommand sqlCommand = new SqlCommand("Employee_ChangeSalary", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
                sqlCommand.Parameters.Add("@ToDate", SqlDbType.VarChar).Value = toDate;

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
        }
    
        partial class NewContractDataTable
        {
            public int GetList(string employeeIDList)
            {
                SqlCommand sqlCommand = new SqlCommand("Employee_NewContract", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
                sqlCommand.CommandTimeout = 0;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
        }
    
        partial class AnnualLeaveDataTable
        {
            public int GetListByDepartmentID(string departmentIDList, byte month, short year)
            {
                SqlCommand sqlCommand = new SqlCommand("AnnualLeave_GetListByDepartmentID", Connection.GetConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
                sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt).Value = month;
                sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt).Value = year;
                sqlCommand.CommandTimeout = 0;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                Clear();
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
                foreach (AnnualLeaveRow anr in this)
                {
                    if (departmentIDList.IndexOf("[" + anr.DepartmentID + "]") >= 0) anr.Delete();
                }
                AcceptChanges();
            }
        }
    }
}
