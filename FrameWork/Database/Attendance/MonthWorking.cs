using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class MonthWorkingTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnDepartmentID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnAttendanceItemID;
        private DataColumn _columnValue;

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

            _columnDepartmentID = new DataColumn("DepartmentID", typeof(string));
            _columnDepartmentID.AllowDBNull = true;
            _columnDepartmentID.Caption = "Department ID";
            _columnDepartmentID.MaxLength = 20;
            _columnDepartmentID.Unique = false;
            _columnDepartmentID.DefaultValue = Convert.DBNull;
            _columnDepartmentID.ExtendedProperties.Add("IsKey", "false");
            _columnDepartmentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDepartmentID.ExtendedProperties.Add("Description", "Department ID");
            _columnDepartmentID.ExtendedProperties.Add("Length", "20");
            _columnDepartmentID.ExtendedProperties.Add("Decimals", "0");
            _columnDepartmentID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDepartmentID);

            _columnFromDate = new DataColumn("FromDate", typeof(DateTime));
            _columnFromDate.AllowDBNull = false;
            _columnFromDate.Caption = "From Date";
            _columnFromDate.Unique = false;
            _columnFromDate.DefaultValue = Convert.DBNull;
            _columnFromDate.ExtendedProperties.Add("IsKey", "true");
            _columnFromDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnFromDate.ExtendedProperties.Add("Description", "From Date");
            _columnFromDate.ExtendedProperties.Add("Decimals", "0");
            _columnFromDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFromDate);

            _columnToDate = new DataColumn("ToDate", typeof(DateTime));
            _columnToDate.AllowDBNull = true;
            _columnToDate.Caption = "To Date";
            _columnToDate.Unique = false;
            _columnToDate.DefaultValue = Convert.DBNull;
            _columnToDate.ExtendedProperties.Add("IsKey", "false");
            _columnToDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnToDate.ExtendedProperties.Add("Description", "To Date");
            _columnToDate.ExtendedProperties.Add("Decimals", "0");
            _columnToDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnToDate);

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

            _columnValue = new DataColumn("Value", typeof(decimal));
            _columnValue.AllowDBNull = true;
            _columnValue.Caption = "Value";
            _columnValue.MaxLength = 9;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "9");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"], this.Columns["AttendanceItemID"] };
        }
        #endregion

        #region Constructors
        public MonthWorkingTable()
            : base("MonthWorking")
        {
            this.InitClass();
        }
        public MonthWorkingTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("MonthWorking_GetContent", Connection.GetConnection());
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
        public static MonthWorkingTable GetContentTable()
        {
            MonthWorkingTable monthWorkingTable = new MonthWorkingTable();
            monthWorkingTable.GetContent();
            return monthWorkingTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("MonthWorking_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");

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
            SqlCommand sqlCommand = new SqlCommand("MonthWorking_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalAttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");

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
            SqlCommand sqlCommand = new SqlCommand("MonthWorking_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
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
        public bool Delete(int employeeID, DateTime fromDate, string attendanceItemID)
        {
            bool retVal;

            MonthWorkingRow row = FindByPrimaryKey(employeeID, fromDate, attendanceItemID);
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
        public DataColumn DepartmentIDColumn
        {
            get
            {
                return _columnDepartmentID;
            }
        }
        public DataColumn FromDateColumn
        {
            get
            {
                return _columnFromDate;
            }
        }
        public DataColumn ToDateColumn
        {
            get
            {
                return _columnToDate;
            }
        }
        public DataColumn AttendanceItemIDColumn
        {
            get
            {
                return _columnAttendanceItemID;
            }
        }
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
            }
        }
        public MonthWorkingRow this[int index]
        {
            get
            {
                return ((MonthWorkingRow)(this.Rows[index]));
            }
        }
        public void AddMonthWorkingRow(MonthWorkingRow row)
        {
            this.Rows.Add(row);
        }
        public MonthWorkingRow AddMonthWorkingRow(int employeeID, string departmentID, DateTime fromDate, DateTime toDate, string attendanceItemID, decimal value)
        {
            MonthWorkingRow rowMonthWorkingRow = ((MonthWorkingRow)(this.NewRow()));
            rowMonthWorkingRow["EmployeeID"] = employeeID;
            rowMonthWorkingRow["DepartmentID"] = departmentID;
            rowMonthWorkingRow["FromDate"] = fromDate;
            rowMonthWorkingRow["ToDate"] = toDate;
            rowMonthWorkingRow["AttendanceItemID"] = attendanceItemID;
            rowMonthWorkingRow["Value"] = value;
            this.Rows.Add(rowMonthWorkingRow);
            return rowMonthWorkingRow;
        }
        public MonthWorkingRow FindByPrimaryKey(int employeeID, DateTime fromDate, string attendanceItemID)
        {
            return (MonthWorkingRow)(Rows.Find(new object[] { employeeID, fromDate, attendanceItemID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new MonthWorkingRow(builder);
        }
        public static void TransferToEmployeeParameter(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("MonthWorking_TransferToEmployeeParameter", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.CommandTimeout = 0;
            //try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            //catch
            {
            }
            //finally
            {
                Connection.Close();
            }
        }
        #endregion
    }

    public class MonthWorkingRow : DataRow
    {
        private MonthWorkingTable _tableMonthWorking;

        internal MonthWorkingRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableMonthWorking = ((MonthWorkingTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableMonthWorking.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthWorking.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableMonthWorking.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableMonthWorking.EmployeeIDColumn] = Convert.DBNull;
        }
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMonthWorking.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthWorking.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableMonthWorking.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableMonthWorking.DepartmentIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableMonthWorking.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthWorking.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableMonthWorking.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableMonthWorking.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableMonthWorking.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthWorking.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableMonthWorking.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableMonthWorking.ToDateColumn] = Convert.DBNull;
        }
        public string AttendanceItemID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMonthWorking.AttendanceItemIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AttendanceItemID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthWorking.AttendanceItemIDColumn] = value;
            }
        }
        public bool IsAttendanceItemIDNull()
        {
            return this.IsNull(_tableMonthWorking.AttendanceItemIDColumn);
        }
        public void SetAttendanceItemIDNull()
        {
            this[_tableMonthWorking.AttendanceItemIDColumn] = Convert.DBNull;
        }
        public decimal Value
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableMonthWorking.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMonthWorking.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableMonthWorking.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableMonthWorking.ValueColumn] = Convert.DBNull;
        }
        #endregion
    }
}
