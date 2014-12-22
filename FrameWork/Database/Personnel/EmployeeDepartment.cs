using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class EmployeeDepartmentTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnDepartmentID;

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

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public EmployeeDepartmentTable()
            : base("EmployeeDepartment")
        {
            this.InitClass();
        }
        public EmployeeDepartmentTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_GetContent", Connection.GetConnection());
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
        public static EmployeeDepartmentTable GetContentTable()
        {
            EmployeeDepartmentTable employeeDepartmentTable = new EmployeeDepartmentTable();
            employeeDepartmentTable.GetContent();
            return employeeDepartmentTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");

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
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");

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
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_Delete", Connection.GetConnection());
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

            EmployeeDepartmentRow row = FindByPrimaryKey(employeeID, fromDate);
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
        public DataColumn DepartmentIDColumn
        {
            get
            {
                return _columnDepartmentID;
            }
        }
        public EmployeeDepartmentRow this[int index]
        {
            get
            {
                return ((EmployeeDepartmentRow)(this.Rows[index]));
            }
        }
        public void AddEmployeeDepartmentRow(EmployeeDepartmentRow row)
        {
            this.Rows.Add(row);
        }
        public EmployeeDepartmentRow AddEmployeeDepartmentRow(int employeeID, DateTime fromDate, DateTime toDate, string departmentID)
        {
            EmployeeDepartmentRow rowEmployeeDepartmentRow = ((EmployeeDepartmentRow)(this.NewRow()));
            rowEmployeeDepartmentRow["EmployeeID"] = employeeID;
            rowEmployeeDepartmentRow["FromDate"] = fromDate;
            rowEmployeeDepartmentRow["ToDate"] = toDate;
            rowEmployeeDepartmentRow["DepartmentID"] = departmentID;
            this.Rows.Add(rowEmployeeDepartmentRow);
            return rowEmployeeDepartmentRow;
        }
        public EmployeeDepartmentRow FindByPrimaryKey(int employeeID, DateTime fromDate)
        {
            return (EmployeeDepartmentRow)(Rows.Find(new object[] { employeeID, fromDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new EmployeeDepartmentRow(builder);
        }
        public void GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_GetListByEmployeeID", Connection.GetConnection());
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
        public EmployeeDepartmentRow GetMaxDuration(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_GetMaxDuration", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
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
        public bool Insert(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeDepartment_Insert", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");

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

    public class EmployeeDepartmentRow : DataRow
    {
        private EmployeeDepartmentTable _tableEmployeeDepartment;

        internal EmployeeDepartmentRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableEmployeeDepartment = ((EmployeeDepartmentTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableEmployeeDepartment.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeDepartment.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableEmployeeDepartment.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableEmployeeDepartment.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployeeDepartment.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeDepartment.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableEmployeeDepartment.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableEmployeeDepartment.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployeeDepartment.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeDepartment.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableEmployeeDepartment.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableEmployeeDepartment.ToDateColumn] = Convert.DBNull;
        }
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployeeDepartment.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeDepartment.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableEmployeeDepartment.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableEmployeeDepartment.DepartmentIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
