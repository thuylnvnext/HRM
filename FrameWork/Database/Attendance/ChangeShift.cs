using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ChangeShiftTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnDepartmentID;
        private DataColumn _columnChangeDate;
        private DataColumn _columnShiftID;

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
            _columnDepartmentID.MaxLength = 10;
            _columnDepartmentID.Unique = false;
            _columnDepartmentID.DefaultValue = Convert.DBNull;
            _columnDepartmentID.ExtendedProperties.Add("IsKey", "false");
            _columnDepartmentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDepartmentID.ExtendedProperties.Add("Description", "Department ID");
            _columnDepartmentID.ExtendedProperties.Add("Length", "10");
            _columnDepartmentID.ExtendedProperties.Add("Decimals", "0");
            _columnDepartmentID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDepartmentID);

            _columnChangeDate = new DataColumn("ChangeDate", typeof(DateTime));
            _columnChangeDate.AllowDBNull = false;
            _columnChangeDate.Caption = "Change Date";
            _columnChangeDate.Unique = false;
            _columnChangeDate.DefaultValue = Convert.DBNull;
            _columnChangeDate.ExtendedProperties.Add("IsKey", "true");
            _columnChangeDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnChangeDate.ExtendedProperties.Add("Description", "Change Date");
            _columnChangeDate.ExtendedProperties.Add("Decimals", "0");
            _columnChangeDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnChangeDate);

            _columnShiftID = new DataColumn("ShiftID", typeof(string));
            _columnShiftID.AllowDBNull = false;
            _columnShiftID.Caption = "Shift ID";
            _columnShiftID.MaxLength = 10;
            _columnShiftID.Unique = false;
            _columnShiftID.DefaultValue = Convert.DBNull;
            _columnShiftID.ExtendedProperties.Add("IsKey", "true");
            _columnShiftID.ExtendedProperties.Add("ReadOnly", "false");
            _columnShiftID.ExtendedProperties.Add("Description", "Shift ID");
            _columnShiftID.ExtendedProperties.Add("Length", "10");
            _columnShiftID.ExtendedProperties.Add("Decimals", "0");
            _columnShiftID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnShiftID);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["ChangeDate"], this.Columns["ShiftID"] };
        }
        #endregion

        #region Constructors
        public ChangeShiftTable()
            : base("ChangeShift")
        {
            this.InitClass();
        }
        public ChangeShiftTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("ChangeShift_GetContent", Connection.GetConnection());
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
        public static ChangeShiftTable GetContentTable()
        {
            ChangeShiftTable changeShiftTable = new ChangeShiftTable();
            changeShiftTable.GetContent();
            return changeShiftTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("ChangeShift_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@ChangeDate", SqlDbType.DateTime, 8, "ChangeDate");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");

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
            SqlCommand sqlCommand = new SqlCommand("ChangeShift_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalChangeDate", SqlDbType.DateTime, 8, "ChangeDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalShiftID", SqlDbType.VarChar, 10, "ShiftID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 10, "DepartmentID");
            sqlCommand.Parameters.Add("@ChangeDate", SqlDbType.DateTime, 8, "ChangeDate");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");

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
            SqlCommand sqlCommand = new SqlCommand("ChangeShift_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@ChangeDate", SqlDbType.DateTime, 8, "ChangeDate");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");

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
        public bool Delete(int employeeID, DateTime changeDate, string shiftID)
        {
            bool retVal;

            ChangeShiftRow row = FindByPrimaryKey(employeeID, changeDate, shiftID);
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
        public DataColumn ChangeDateColumn
        {
            get
            {
                return _columnChangeDate;
            }
        }
        public DataColumn ShiftIDColumn
        {
            get
            {
                return _columnShiftID;
            }
        }
        public ChangeShiftRow this[int index]
        {
            get
            {
                return ((ChangeShiftRow)(this.Rows[index]));
            }
        }
        public void AddChangeShiftRow(ChangeShiftRow row)
        {
            this.Rows.Add(row);
        }
        public ChangeShiftRow AddChangeShiftRow(int employeeID, string departmentID, DateTime changeDate, string shiftID)
        {
            ChangeShiftRow rowChangeShiftRow = ((ChangeShiftRow)(this.NewRow()));
            rowChangeShiftRow["EmployeeID"] = employeeID;
            rowChangeShiftRow["DepartmentID"] = departmentID;
            rowChangeShiftRow["ChangeDate"] = changeDate;
            rowChangeShiftRow["ShiftID"] = shiftID;
            this.Rows.Add(rowChangeShiftRow);
            return rowChangeShiftRow;
        }
        public ChangeShiftRow FindByPrimaryKey(int employeeID, DateTime changeDate, string shiftID)
        {
            return (ChangeShiftRow)(Rows.Find(new object[] { employeeID, changeDate, shiftID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ChangeShiftRow(builder);
        }
        public int GetListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("ChangeShift_GetListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //Clear();
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
            foreach (ChangeShiftRow csr in this)
            {
                if (departmentIDList.IndexOf(csr.DepartmentID) >= 0) csr.Delete();
            }
            AcceptChanges();
        }
        public int GetHListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("ChangeShift_GetHListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
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
        public ChangeShiftRow GetInfoByValues(int employeeID, DateTime changeDate)
        {
            ChangeShiftRow c = null;

            foreach (ChangeShiftRow csr in this)
            {
                if (csr.EmployeeID == employeeID && csr.ChangeDate == changeDate) c = csr;
            }

            return c;
        }
        #endregion
    }

    public class ChangeShiftRow : DataRow
    {
        private ChangeShiftTable _tableChangeShift;

        internal ChangeShiftRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableChangeShift = ((ChangeShiftTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableChangeShift.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableChangeShift.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableChangeShift.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableChangeShift.EmployeeIDColumn] = Convert.DBNull;
        }
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableChangeShift.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableChangeShift.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableChangeShift.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableChangeShift.DepartmentIDColumn] = Convert.DBNull;
        }
        public DateTime ChangeDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableChangeShift.ChangeDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ChangeDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableChangeShift.ChangeDateColumn] = value;
            }
        }
        public bool IsChangeDateNull()
        {
            return this.IsNull(_tableChangeShift.ChangeDateColumn);
        }
        public void SetChangeDateNull()
        {
            this[_tableChangeShift.ChangeDateColumn] = Convert.DBNull;
        }
        public string ShiftID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableChangeShift.ShiftIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ShiftID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableChangeShift.ShiftIDColumn] = value;
            }
        }
        public bool IsShiftIDNull()
        {
            return this.IsNull(_tableChangeShift.ShiftIDColumn);
        }
        public void SetShiftIDNull()
        {
            this[_tableChangeShift.ShiftIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
