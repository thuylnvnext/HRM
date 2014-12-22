using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterDayOffGroupTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnDayOffGroupID;

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
            _columnToDate.AllowDBNull = false;
            _columnToDate.Caption = "To Date";
            _columnToDate.Unique = false;
            _columnToDate.DefaultValue = Convert.DBNull;
            _columnToDate.ExtendedProperties.Add("IsKey", "false");
            _columnToDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnToDate.ExtendedProperties.Add("Description", "To Date");
            _columnToDate.ExtendedProperties.Add("Decimals", "0");
            _columnToDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnToDate);

            _columnDayOffGroupID = new DataColumn("DayOffGroupID", typeof(string));
            _columnDayOffGroupID.AllowDBNull = false;
            _columnDayOffGroupID.Caption = "Day Off Group ID";
            _columnDayOffGroupID.MaxLength = 10;
            _columnDayOffGroupID.Unique = false;
            _columnDayOffGroupID.DefaultValue = Convert.DBNull;
            _columnDayOffGroupID.ExtendedProperties.Add("IsKey", "true");
            _columnDayOffGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDayOffGroupID.ExtendedProperties.Add("Description", "Day Off Group ID");
            _columnDayOffGroupID.ExtendedProperties.Add("Length", "10");
            _columnDayOffGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnDayOffGroupID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnDayOffGroupID);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"], this.Columns["DayOffGroupID"] };
        }
        #endregion

        #region Constructors
        public RegisterDayOffGroupTable()
            : base("RegisterDayOffGroup")
        {
            this.InitClass();
        }
        public RegisterDayOffGroupTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_GetContent", Connection.GetConnection());
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
        public static RegisterDayOffGroupTable GetContentTable()
        {
            RegisterDayOffGroupTable registerDayOffGroupTable = new RegisterDayOffGroupTable();
            registerDayOffGroupTable.GetContent();
            return registerDayOffGroupTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10, "DayOffGroupID");

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
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalDayOffGroupID", SqlDbType.VarChar, 10, "DayOffGroupID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10, "DayOffGroupID");

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
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10, "DayOffGroupID");

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
        public bool Delete(int employeeID, DateTime fromDate, string dayOffGroupID)
        {
            bool retVal;

            RegisterDayOffGroupRow row = FindByPrimaryKey(employeeID, fromDate, dayOffGroupID);
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
        public DataColumn DayOffGroupIDColumn
        {
            get
            {
                return _columnDayOffGroupID;
            }
        }
        public RegisterDayOffGroupRow this[int index]
        {
            get
            {
                return ((RegisterDayOffGroupRow)(this.Rows[index]));
            }
        }
        public void AddRegisterDayOffGroupRow(RegisterDayOffGroupRow row)
        {
            this.Rows.Add(row);
        }
        public RegisterDayOffGroupRow AddRegisterDayOffGroupRow(int employeeID, DateTime fromDate, DateTime toDate, string dayOffGroupID)
        {
            RegisterDayOffGroupRow rowRegisterDayOffGroupRow = ((RegisterDayOffGroupRow)(this.NewRow()));
            rowRegisterDayOffGroupRow["EmployeeID"] = employeeID;
            rowRegisterDayOffGroupRow["FromDate"] = fromDate;
            rowRegisterDayOffGroupRow["ToDate"] = toDate;
            rowRegisterDayOffGroupRow["DayOffGroupID"] = dayOffGroupID;
            this.Rows.Add(rowRegisterDayOffGroupRow);
            return rowRegisterDayOffGroupRow;
        }
        public RegisterDayOffGroupRow FindByPrimaryKey(int employeeID, DateTime fromDate, string dayOffGroupID)
        {
            return (RegisterDayOffGroupRow)(Rows.Find(new object[] { employeeID, fromDate, dayOffGroupID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterDayOffGroupRow(builder);
        }
        public int GetListByEmployeeID(string employeeIDList, int count)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_GetListByEmployeeID", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
            sqlCommand.Parameters.Add("@Count", SqlDbType.Int, 4).Value = count;

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
        public bool InsertValue(int employeeID, DateTime fromDate, DateTime toDate, string dayOffGroupID)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_Insert", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10).Value = dayOffGroupID;

            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public bool EditValue(DateTime originalFromDate, string originalDayOffGroupID, int employeeID, DateTime fromDate, DateTime toDate, string dayOffGroupID)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_EditValue", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8).Value = originalFromDate;
            sqlCommand.Parameters.Add("@OriginalDayOffGroupID", SqlDbType.VarChar, 10).Value = originalDayOffGroupID;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10).Value = dayOffGroupID;

            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public static bool DeleteValue(int employeeID, DateTime fromDate, string dayOffGroupID)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("RegisterDayOffGroup_Delete", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10).Value = dayOffGroupID;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        #endregion
    }

    public class RegisterDayOffGroupRow : DataRow
    {
        private RegisterDayOffGroupTable _tableRegisterDayOffGroup;

        internal RegisterDayOffGroupRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterDayOffGroup = ((RegisterDayOffGroupTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterDayOffGroup.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterDayOffGroup.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableRegisterDayOffGroup.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableRegisterDayOffGroup.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterDayOffGroup.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterDayOffGroup.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableRegisterDayOffGroup.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableRegisterDayOffGroup.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterDayOffGroup.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterDayOffGroup.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableRegisterDayOffGroup.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableRegisterDayOffGroup.ToDateColumn] = Convert.DBNull;
        }
        public string DayOffGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterDayOffGroup.DayOffGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DayOffGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterDayOffGroup.DayOffGroupIDColumn] = value;
            }
        }
        public bool IsDayOffGroupIDNull()
        {
            return this.IsNull(_tableRegisterDayOffGroup.DayOffGroupIDColumn);
        }
        public void SetDayOffGroupIDNull()
        {
            this[_tableRegisterDayOffGroup.DayOffGroupIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
