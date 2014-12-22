using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class EmployeePositionTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnPositionID;
        private DataColumn _columnJobID;

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

            _columnPositionID = new DataColumn("PositionID", typeof(string));
            _columnPositionID.AllowDBNull = true;
            _columnPositionID.Caption = "Position ID";
            _columnPositionID.MaxLength = 50;
            _columnPositionID.Unique = false;
            _columnPositionID.DefaultValue = Convert.DBNull;
            _columnPositionID.ExtendedProperties.Add("IsKey", "false");
            _columnPositionID.ExtendedProperties.Add("ReadOnly", "false");
            _columnPositionID.ExtendedProperties.Add("Description", "Position ID");
            _columnPositionID.ExtendedProperties.Add("Length", "50");
            _columnPositionID.ExtendedProperties.Add("Decimals", "0");
            _columnPositionID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPositionID);

            _columnJobID = new DataColumn("JobID", typeof(string));
            _columnJobID.AllowDBNull = true;
            _columnJobID.Caption = "Job ID";
            _columnJobID.MaxLength = 50;
            _columnJobID.Unique = false;
            _columnJobID.DefaultValue = Convert.DBNull;
            _columnJobID.ExtendedProperties.Add("IsKey", "false");
            _columnJobID.ExtendedProperties.Add("ReadOnly", "false");
            _columnJobID.ExtendedProperties.Add("Description", "Job ID");
            _columnJobID.ExtendedProperties.Add("Length", "50");
            _columnJobID.ExtendedProperties.Add("Decimals", "0");
            _columnJobID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnJobID);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public EmployeePositionTable()
            : base("EmployeePosition")
        {
            this.InitClass();
        }
        public EmployeePositionTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeePosition_GetContent", Connection.GetConnection());
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
        public static EmployeePositionTable GetContentTable()
        {
            EmployeePositionTable employeePositionTable = new EmployeePositionTable();
            employeePositionTable.GetContent();
            return employeePositionTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeePosition_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@PositionID", SqlDbType.VarChar, 50, "PositionID");
            sqlCommand.Parameters.Add("@JobID", SqlDbType.VarChar, 50, "JobID");

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
            SqlCommand sqlCommand = new SqlCommand("EmployeePosition_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@PositionID", SqlDbType.VarChar, 50, "PositionID");
            sqlCommand.Parameters.Add("@JobID", SqlDbType.VarChar, 50, "JobID");

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
            SqlCommand sqlCommand = new SqlCommand("EmployeePosition_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");

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
        public bool Delete(int employeeID, DateTime fromDate)
        {
            bool retVal;

            EmployeePositionRow row = FindByPrimaryKey(employeeID, fromDate);
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
        public DataColumn PositionIDColumn
        {
            get
            {
                return _columnPositionID;
            }
        }
        public DataColumn JobIDColumn
        {
            get
            {
                return _columnJobID;
            }
        }
        public EmployeePositionRow this[int index]
        {
            get
            {
                return ((EmployeePositionRow)(this.Rows[index]));
            }
        }
        public void AddEmployeePositionRow(EmployeePositionRow row)
        {
            this.Rows.Add(row);
        }
        public EmployeePositionRow AddEmployeePositionRow(int employeeID, DateTime fromDate, DateTime toDate, string positionID, string jobID)
        {
            EmployeePositionRow rowEmployeePositionRow = ((EmployeePositionRow)(this.NewRow()));
            rowEmployeePositionRow["EmployeeID"] = employeeID;
            rowEmployeePositionRow["FromDate"] = fromDate;
            rowEmployeePositionRow["ToDate"] = toDate;
            rowEmployeePositionRow["PositionID"] = positionID;
            rowEmployeePositionRow["JobID"] = jobID;
            this.Rows.Add(rowEmployeePositionRow);
            return rowEmployeePositionRow;
        }
        public EmployeePositionRow FindByPrimaryKey(int employeeID, DateTime fromDate)
        {
            return (EmployeePositionRow)(Rows.Find(new object[] { employeeID, fromDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new EmployeePositionRow(builder);
        }
        public void GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeePosition_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
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
        public bool Insert(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeePosition_Insert", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@PositionID", SqlDbType.VarChar, 50, "PositionID");
            sqlCommand.Parameters.Add("@JobID", SqlDbType.VarChar, 50, "JobID");

            sqlDataAdapter.InsertCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
            }
            return retVal;
        }
        #endregion
    }

    public class EmployeePositionRow : DataRow
    {
        private EmployeePositionTable _tableEmployeePosition;

        internal EmployeePositionRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableEmployeePosition = ((EmployeePositionTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableEmployeePosition.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeePosition.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableEmployeePosition.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableEmployeePosition.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployeePosition.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeePosition.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableEmployeePosition.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableEmployeePosition.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployeePosition.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeePosition.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableEmployeePosition.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableEmployeePosition.ToDateColumn] = Convert.DBNull;
        }
        public string PositionID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployeePosition.PositionIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PositionID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeePosition.PositionIDColumn] = value;
            }
        }
        public bool IsPositionIDNull()
        {
            return this.IsNull(_tableEmployeePosition.PositionIDColumn);
        }
        public void SetPositionIDNull()
        {
            this[_tableEmployeePosition.PositionIDColumn] = Convert.DBNull;
        }
        public string JobID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployeePosition.JobIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value JobID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeePosition.JobIDColumn] = value;
            }
        }
        public bool IsJobIDNull()
        {
            return this.IsNull(_tableEmployeePosition.JobIDColumn);
        }
        public void SetJobIDNull()
        {
            this[_tableEmployeePosition.JobIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
