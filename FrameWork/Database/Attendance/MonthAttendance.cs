using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class MonthAttendanceTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnWorkingDay;
        private DataColumn _columnDepartmentID;
        private DataColumn _columnValue;
        private DataColumn _columnAttendanceItemID;
        private DataColumn _columnAbsenceID;

        private void InitClass()
        {
            _columnEmployeeID = new DataColumn("EmployeeID", typeof(int));
            _columnEmployeeID.AllowDBNull = false;
            _columnEmployeeID.Caption = "Employee ID";
            _columnEmployeeID.Unique = false;
            _columnEmployeeID.DefaultValue = Convert.DBNull;
            _columnEmployeeID.ExtendedProperties.Add("IsKey", "true");
            _columnEmployeeID.ExtendedProperties.Add("ReadOnly", "false");
            _columnEmployeeID.ExtendedProperties.Add("Description", "Employee ID");
            _columnEmployeeID.ExtendedProperties.Add("Decimals", "0");
            _columnEmployeeID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnEmployeeID);

            _columnWorkingDay = new DataColumn("WorkingDay", typeof(DateTime));
            _columnWorkingDay.AllowDBNull = false;
            _columnWorkingDay.Caption = "Working Day";
            _columnWorkingDay.Unique = false;
            _columnWorkingDay.DefaultValue = Convert.DBNull;
            _columnWorkingDay.ExtendedProperties.Add("IsKey", "true");
            _columnWorkingDay.ExtendedProperties.Add("ReadOnly", "false");
            _columnWorkingDay.ExtendedProperties.Add("Description", "Working Day");
            _columnWorkingDay.ExtendedProperties.Add("Decimals", "0");
            _columnWorkingDay.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnWorkingDay);

            _columnDepartmentID = new DataColumn("DepartmentID", typeof(string));
            _columnDepartmentID.AllowDBNull = false;
            _columnDepartmentID.Caption = "Department ID";
            _columnDepartmentID.MaxLength = 20;
            _columnDepartmentID.Unique = false;
            _columnDepartmentID.DefaultValue = Convert.DBNull;
            _columnDepartmentID.ExtendedProperties.Add("IsKey", "false");
            _columnDepartmentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDepartmentID.ExtendedProperties.Add("Description", "Department ID");
            _columnDepartmentID.ExtendedProperties.Add("Length", "20");
            _columnDepartmentID.ExtendedProperties.Add("Decimals", "0");
            _columnDepartmentID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnDepartmentID);

            _columnValue = new DataColumn("Value", typeof(decimal));
            _columnValue.AllowDBNull = true;
            _columnValue.Caption = "Value";
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "9");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            _columnAttendanceItemID = new DataColumn("AttendanceItemID", typeof(string));
            _columnAttendanceItemID.AllowDBNull = false;
            _columnAttendanceItemID.Caption = "Attendance Item ID";
            _columnAttendanceItemID.MaxLength = 10;
            _columnAttendanceItemID.Unique = false;
            _columnAttendanceItemID.DefaultValue = Convert.DBNull;
            _columnAttendanceItemID.ExtendedProperties.Add("IsKey", "true");
            _columnAttendanceItemID.ExtendedProperties.Add("ReadOnly", "false");
            _columnAttendanceItemID.ExtendedProperties.Add("Description", "Attendance Item ID");
            _columnAttendanceItemID.ExtendedProperties.Add("Length", "10");
            _columnAttendanceItemID.ExtendedProperties.Add("Decimals", "0");
            _columnAttendanceItemID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnAttendanceItemID);

            _columnAbsenceID = new DataColumn("AbsenceID", typeof(string));
            _columnAbsenceID.AllowDBNull = true;
            _columnAbsenceID.Caption = "Absence ID";
            _columnAbsenceID.MaxLength = 10;
            _columnAbsenceID.Unique = false;
            _columnAbsenceID.DefaultValue = Convert.DBNull;
            _columnAbsenceID.ExtendedProperties.Add("IsKey", "false");
            _columnAbsenceID.ExtendedProperties.Add("ReadOnly", "false");
            _columnAbsenceID.ExtendedProperties.Add("Description", "Absence ID");
            _columnAbsenceID.ExtendedProperties.Add("Length", "10");
            _columnAbsenceID.ExtendedProperties.Add("Decimals", "0");
            _columnAbsenceID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnAbsenceID);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["WorkingDay"], this.Columns["AttendanceItemID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public MonthAttendanceTable()
            : base("MonthAttendance")
        {
            this.InitClass();
        }
        public MonthAttendanceTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_GetContent", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
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
        }
        public static MonthAttendanceTable GetContentTable()
        {
            MonthAttendanceTable monthAttendanceTable = new MonthAttendanceTable();
            monthAttendanceTable.GetContent();
            return monthAttendanceTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");
            sqlCommand.Parameters.Add("@AbsenceID", SqlDbType.VarChar, 10, "AbsenceID");

            sqlDataAdapter.InsertCommand = sqlCommand;
            try
            {
                Connection.Open();
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public bool Update()
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalWorkingDay", SqlDbType.DateTime, 8, "WorkingDay").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalAttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");
            sqlCommand.Parameters.Add("@AbsenceID", SqlDbType.VarChar, 10, "AbsenceID");

            sqlDataAdapter.UpdateCommand = sqlCommand;
            try
            {
                Connection.Open();
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public bool Delete()
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");

            sqlDataAdapter.DeleteCommand = sqlCommand;
            try
            {
                Connection.Open();
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public bool Delete(int employeeID, DateTime workingDay, string attendanceItemID)
        {
            bool retVal;

            MonthAttendanceRow row = FindByPrimaryKey(employeeID, workingDay, attendanceItemID);
            if (row != null)
            {
                row.Delete();
                retVal = Delete();
            }
            else
            {
                retVal = false;
            }
            return retVal;
        }
        public int Count
        {
            get
            {
                return Rows.Count;
            }
        }
        public DataColumn EmployeeIDColumn
        {
            get
            {
                return _columnEmployeeID;
            }
        }
        public DataColumn WorkingDayColumn
        {
            get
            {
                return _columnWorkingDay;
            }
        }
        public DataColumn DepartmentIDColumn
        {
            get
            {
                return _columnDepartmentID;
            }
        }
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
            }
        }
        public DataColumn AttendanceItemIDColumn
        {
            get
            {
                return _columnAttendanceItemID;
            }
        }
        public DataColumn AbsenceIDColumn
        {
            get
            {
                return _columnAbsenceID;
            }
        }
        public MonthAttendanceRow this[int index]
        {
            get
            {
                return ((MonthAttendanceRow)(this.Rows[index]));
            }
        }
        public void AddMonthAttendanceRow(MonthAttendanceRow row)
        {
            this.Rows.Add(row);
        }
        public MonthAttendanceRow AddMonthAttendanceRow(int employeeID, DateTime workingDay, string departmentID, decimal value, string attendanceItemID, string absenceID)
        {
            MonthAttendanceRow rowMonthAttendanceRow = ((MonthAttendanceRow)(this.NewRow()));
            rowMonthAttendanceRow["EmployeeID"] = employeeID;
            rowMonthAttendanceRow["WorkingDay"] = workingDay;
            rowMonthAttendanceRow["DepartmentID"] = departmentID;
            rowMonthAttendanceRow["Value"] = value;
            rowMonthAttendanceRow["AttendanceItemID"] = attendanceItemID;
            rowMonthAttendanceRow["AbsenceID"] = absenceID;
            this.Rows.Add(rowMonthAttendanceRow);
            return rowMonthAttendanceRow;
        }
        public MonthAttendanceRow FindByPrimaryKey(int employeeID, DateTime workingDay, string attendanceItemID)
        {
            return (MonthAttendanceRow)(Rows.Find(new object[] { employeeID, workingDay, attendanceItemID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new MonthAttendanceRow(builder);
        }
        public static void CollectWork(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_CollectWork", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.CommandTimeout = 0;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
        }
        public int GetListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID, bool resignation)
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_GetListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@Resignation", SqlDbType.TinyInt, 1).Value = resignation;
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

            return Rows.Count;
        }
        public int GetWorkingListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID, string iDList, string groupIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("MonthAttendance_GetWorkingListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@IDList", SqlDbType.VarChar, 500).Value = iDList;
            sqlCommand.Parameters.Add("@GroupIDList", SqlDbType.VarChar, 500).Value = groupIDList;
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

            return Rows.Count;
        }
        public void DeleteByDepartmentID(string departmentIDList)
        {
            foreach (MonthAttendanceRow mar in this)
            {
                if (departmentIDList.IndexOf("[" + mar.DepartmentID + "]") >= 0) mar.Delete();
            }
            AcceptChanges();
        }        
        #endregion
    }

    public class MonthAttendanceRow : DataRow
    {
        private MonthAttendanceTable _tableMonthAttendance;

        internal MonthAttendanceRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableMonthAttendance = ((MonthAttendanceTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableMonthAttendance.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthAttendance.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableMonthAttendance.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableMonthAttendance.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime WorkingDay
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableMonthAttendance.WorkingDayColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value WorkingDay because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthAttendance.WorkingDayColumn] = value;
            }
        }
        public bool IsWorkingDayNull()
        {
            return this.IsNull(_tableMonthAttendance.WorkingDayColumn);
        }
        public void SetWorkingDayNull()
        {
            this[_tableMonthAttendance.WorkingDayColumn] = Convert.DBNull;
        }
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMonthAttendance.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthAttendance.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableMonthAttendance.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableMonthAttendance.DepartmentIDColumn] = Convert.DBNull;
        }
        public decimal Value
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableMonthAttendance.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthAttendance.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableMonthAttendance.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableMonthAttendance.ValueColumn] = Convert.DBNull;
        }
        public string AttendanceItemID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMonthAttendance.AttendanceItemIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AttendanceItemID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthAttendance.AttendanceItemIDColumn] = value;
            }
        }
        public bool IsAttendanceItemIDNull()
        {
            return this.IsNull(_tableMonthAttendance.AttendanceItemIDColumn);
        }
        public void SetAttendanceItemIDNull()
        {
            this[_tableMonthAttendance.AttendanceItemIDColumn] = Convert.DBNull;
        }
        public string AbsenceID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMonthAttendance.AbsenceIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AbsenceID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthAttendance.AbsenceIDColumn] = value;
            }
        }
        public bool IsAbsenceIDNull()
        {
            return this.IsNull(_tableMonthAttendance.AbsenceIDColumn);
        }
        public void SetAbsenceIDNull()
        {
            this[_tableMonthAttendance.AbsenceIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
