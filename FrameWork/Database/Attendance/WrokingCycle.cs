using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class WorkingCycleTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnDepartmentID;
        private DataColumn _columnMonth;
        private DataColumn _columnYear;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;

        private void InitClass()
        {
            _columnDepartmentID = new DataColumn("DepartmentID", typeof(string));
            _columnDepartmentID.AllowDBNull = false;
            _columnDepartmentID.Caption = "Department ID";
            _columnDepartmentID.MaxLength = 10;
            _columnDepartmentID.Unique = false;
            _columnDepartmentID.DefaultValue = Convert.DBNull;
            _columnDepartmentID.ExtendedProperties.Add("IsKey", "true");
            _columnDepartmentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDepartmentID.ExtendedProperties.Add("Description", "Department ID");
            _columnDepartmentID.ExtendedProperties.Add("Length", "10");
            _columnDepartmentID.ExtendedProperties.Add("Decimals", "0");
            _columnDepartmentID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnDepartmentID);

            _columnMonth = new DataColumn("Month", typeof(byte));
            _columnMonth.AllowDBNull = false;
            _columnMonth.Caption = "Month";
            _columnMonth.Unique = false;
            _columnMonth.DefaultValue = Convert.DBNull;
            _columnMonth.ExtendedProperties.Add("IsKey", "true");
            _columnMonth.ExtendedProperties.Add("ReadOnly", "false");
            _columnMonth.ExtendedProperties.Add("Description", "Month");
            _columnMonth.ExtendedProperties.Add("Decimals", "0");
            _columnMonth.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnMonth);

            _columnYear = new DataColumn("Year", typeof(Int16));
            _columnYear.AllowDBNull = false;
            _columnYear.Caption = "Year";
            _columnYear.Unique = false;
            _columnYear.DefaultValue = Convert.DBNull;
            _columnYear.ExtendedProperties.Add("IsKey", "true");
            _columnYear.ExtendedProperties.Add("ReadOnly", "false");
            _columnYear.ExtendedProperties.Add("Description", "Year");
            _columnYear.ExtendedProperties.Add("Decimals", "0");
            _columnYear.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnYear);

            _columnFromDate = new DataColumn("FromDate", typeof(DateTime));
            _columnFromDate.AllowDBNull = true;
            _columnFromDate.Caption = "From Date";
            _columnFromDate.Unique = false;
            _columnFromDate.DefaultValue = Convert.DBNull;
            _columnFromDate.ExtendedProperties.Add("IsKey", "false");
            _columnFromDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnFromDate.ExtendedProperties.Add("Description", "From Date");
            _columnFromDate.ExtendedProperties.Add("Decimals", "0");
            _columnFromDate.ExtendedProperties.Add("AllowDBNulls", "true");
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

            this.PrimaryKey = new DataColumn[] { this.Columns["DepartmentID"], this.Columns["Month"], this.Columns["Year"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public WorkingCycleTable()
            : base("WorkingCycle")
        {
            this.InitClass();
        }
        public WorkingCycleTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingCycle_GetContent", Connection.GetConnection());
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
        public static WorkingCycleTable GetContentTable()
        {
            WorkingCycleTable workingCycleTable = new WorkingCycleTable();
            workingCycleTable.GetContent();
            return workingCycleTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingCycle_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");

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
            SqlCommand sqlCommand = new SqlCommand("WorkingCycle_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalDepartmentID", SqlDbType.VarChar, 10, "DepartmentID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalMonth", SqlDbType.TinyInt, 1, "Month").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalYear", SqlDbType.SmallInt, 2, "Year").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");

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
            SqlCommand sqlCommand = new SqlCommand("WorkingCycle_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");

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
        public bool Delete(string departmentID, int month, int year)
        {
            bool retVal;

            WorkingCycleRow row = FindByPrimaryKey(departmentID, month, year);
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
        public DataColumn DepartmentIDColumn
        {
            get
            {
                return _columnDepartmentID;
            }
        }
        public DataColumn MonthColumn
        {
            get
            {
                return _columnMonth;
            }
        }
        public DataColumn YearColumn
        {
            get
            {
                return _columnYear;
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
        public WorkingCycleRow this[int index]
        {
            get
            {
                return ((WorkingCycleRow)(this.Rows[index]));
            }
        }
        public void AddWorkingCycleRow(WorkingCycleRow row)
        {
            this.Rows.Add(row);
        }
        public WorkingCycleRow AddWorkingCycleRow(string departmentID, byte month, Int16 year, DateTime fromDate, DateTime toDate)
        {
            WorkingCycleRow rowWorkingCycleRow = ((WorkingCycleRow)(this.NewRow()));
            rowWorkingCycleRow["DepartmentID"] = departmentID;
            rowWorkingCycleRow["Month"] = month;
            rowWorkingCycleRow["Year"] = year;
            rowWorkingCycleRow["FromDate"] = fromDate;
            rowWorkingCycleRow["ToDate"] = toDate;
            this.Rows.Add(rowWorkingCycleRow);
            return rowWorkingCycleRow;
        }
        public WorkingCycleRow FindByPrimaryKey(string departmentID, int month, int year)
        {
            return (WorkingCycleRow)(Rows.Find(new object[] { departmentID, month, year }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new WorkingCycleRow(builder);
        }
        public int GetListByDepartmentID(string departmentIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingCycle_GetListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;

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
        public WorkingCycleRow GetInfo(byte month, Int16 year)
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingCycle_GetInfo", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1).Value = month;
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2).Value = year;

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

            return this[0];
        }
        #endregion
    }

    public class WorkingCycleRow : DataRow
    {
        private WorkingCycleTable _tableWorkingCycle;

        internal WorkingCycleRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableWorkingCycle = ((WorkingCycleTable)(this.Table));
        }

        #region Properties
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableWorkingCycle.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingCycle.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableWorkingCycle.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableWorkingCycle.DepartmentIDColumn] = Convert.DBNull;
        }
        public byte Month
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableWorkingCycle.MonthColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Month because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingCycle.MonthColumn] = value;
            }
        }
        public bool IsMonthNull()
        {
            return this.IsNull(_tableWorkingCycle.MonthColumn);
        }
        public void SetMonthNull()
        {
            this[_tableWorkingCycle.MonthColumn] = Convert.DBNull;
        }
        public Int16 Year
        {
            get
            {
                try
                {
                    return ((Int16)(this[_tableWorkingCycle.YearColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Year because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingCycle.YearColumn] = value;
            }
        }
        public bool IsYearNull()
        {
            return this.IsNull(_tableWorkingCycle.YearColumn);
        }
        public void SetYearNull()
        {
            this[_tableWorkingCycle.YearColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableWorkingCycle.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingCycle.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableWorkingCycle.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableWorkingCycle.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableWorkingCycle.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingCycle.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableWorkingCycle.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableWorkingCycle.ToDateColumn] = Convert.DBNull;
        }
        public int Days
        {
            get
            {
                return ((TimeSpan)ToDate.Subtract(FromDate)).Days + 1;
            }
        }
        #endregion
    }
}
