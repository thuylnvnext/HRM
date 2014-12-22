using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AnnualLeaveTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnMonth;
        private DataColumn _columnYear;
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

            _columnYear = new DataColumn("Year", typeof(short));
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

            _columnValue = new DataColumn("Value", typeof(decimal));
            _columnValue.AllowDBNull = true;
            _columnValue.Caption = "Value";
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["Month"], this.Columns["Year"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public AnnualLeaveTable()
            : base("AnnualLeave")
        {
            this.InitClass();
        }
        public AnnualLeaveTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_GetContent", Connection.GetConnection());
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
        public static AnnualLeaveTable GetContentTable()
        {
            AnnualLeaveTable annualLeaveTable = new AnnualLeaveTable();
            annualLeaveTable.GetContent();
            return annualLeaveTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
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
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalMonth", SqlDbType.TinyInt, 1, "Month").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalYear", SqlDbType.SmallInt, 2, "Year").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
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
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
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
        public bool Delete(int employeeID, byte month, short year)
        {
            bool retVal;

            AnnualLeaveRow row = FindByPrimaryKey(employeeID, month, year);
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
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
            }
        }
        public AnnualLeaveRow this[int index]
        {
            get
            {
                return ((AnnualLeaveRow)(this.Rows[index]));
            }
        }
        public void AddAnnualLeaveRow(AnnualLeaveRow row)
        {
            this.Rows.Add(row);
        }
        public AnnualLeaveRow AddAnnualLeaveRow(int employeeID, byte month, short year, decimal value)
        {
            AnnualLeaveRow rowAnnualLeaveRow = ((AnnualLeaveRow)(this.NewRow()));
            rowAnnualLeaveRow["EmployeeID"] = employeeID;
            rowAnnualLeaveRow["Month"] = month;
            rowAnnualLeaveRow["Year"] = year;
            rowAnnualLeaveRow["Value"] = value;
            this.Rows.Add(rowAnnualLeaveRow);
            return rowAnnualLeaveRow;
        }
        public AnnualLeaveRow FindByPrimaryKey(int employeeID, byte month, short year)
        {
            return (AnnualLeaveRow)(Rows.Find(new object[] { employeeID, month, year }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AnnualLeaveRow(builder);
        }
        public int GetDaysByYear(short year)
        {
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_GetDaysByYear", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt).Value = year;

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
        public AnnualLeaveRow GetInfoByValues(int employeeID, byte month, short year)
        {
            AnnualLeaveRow alr = null;

            foreach (AnnualLeaveRow _alr in this)
            {
                if (_alr.RowState != DataRowState.Deleted)
                {
                    if (_alr.Month == month && _alr.Year == year && _alr.EmployeeID == employeeID)
                    {
                        alr = _alr;
                        break;
                    }
                }
            }
            return alr;
        }
        public static void GetDaysOfMonth(string departmentIDList, byte month, short year)
        {
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_GetDaysOfMonth", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt).Value = month;
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt).Value = year;
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
        public static void GetDaysOfYear(string departmentIDList, short year)
        {
            SqlCommand sqlCommand = new SqlCommand("AnnualLeave_GetDaysOfYear", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt).Value = year;
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
            foreach (AnnualLeaveRow anr in this)
            {
                if (departmentIDList.IndexOf("[" + anr["DepartmentID"].ToString() + "]") >= 0) anr.Delete();
            }
            AcceptChanges();
        }
        #endregion
    }

    public class AnnualLeaveRow : DataRow
    {
        private AnnualLeaveTable _tableAnnualLeave;

        internal AnnualLeaveRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAnnualLeave = ((AnnualLeaveTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableAnnualLeave.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAnnualLeave.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableAnnualLeave.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableAnnualLeave.EmployeeIDColumn] = Convert.DBNull;
        }
        public byte Month
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableAnnualLeave.MonthColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Month because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAnnualLeave.MonthColumn] = value;
            }
        }
        public bool IsMonthNull()
        {
            return this.IsNull(_tableAnnualLeave.MonthColumn);
        }
        public void SetMonthNull()
        {
            this[_tableAnnualLeave.MonthColumn] = Convert.DBNull;
        }
        public short Year
        {
            get
            {
                try
                {
                    return ((short)(this[_tableAnnualLeave.YearColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Year because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAnnualLeave.YearColumn] = value;
            }
        }
        public bool IsYearNull()
        {
            return this.IsNull(_tableAnnualLeave.YearColumn);
        }
        public void SetYearNull()
        {
            this[_tableAnnualLeave.YearColumn] = Convert.DBNull;
        }
        public decimal Value
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableAnnualLeave.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAnnualLeave.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableAnnualLeave.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableAnnualLeave.ValueColumn] = Convert.DBNull;
        }
        #endregion
    }
}
