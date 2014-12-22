using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterShiftTable : RegisterItemT
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnShiftID;
        private DataColumn _columnCreatedUserName;
        private DataColumn _columnCreatedDate;
        private DataColumn _columnModifiedUserName;
        private DataColumn _columnModifiedDate;

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

            _columnShiftID = new DataColumn("ShiftID", typeof(string));
            _columnShiftID.AllowDBNull = true;
            _columnShiftID.Caption = "Shift ID";
            _columnShiftID.MaxLength = 100;
            _columnShiftID.Unique = false;
            _columnShiftID.DefaultValue = Convert.DBNull;
            _columnShiftID.ExtendedProperties.Add("IsKey", "false");
            _columnShiftID.ExtendedProperties.Add("ReadOnly", "false");
            _columnShiftID.ExtendedProperties.Add("Description", "Shift ID");
            _columnShiftID.ExtendedProperties.Add("Length", "100");
            _columnShiftID.ExtendedProperties.Add("Decimals", "0");
            _columnShiftID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnShiftID);

            _columnCreatedUserName = new DataColumn("CreatedUserName", typeof(string));
            _columnCreatedUserName.AllowDBNull = true;
            _columnCreatedUserName.Caption = "Created User Name";
            _columnCreatedUserName.MaxLength = 15;
            _columnCreatedUserName.Unique = false;
            _columnCreatedUserName.DefaultValue = Convert.DBNull;
            _columnCreatedUserName.ExtendedProperties.Add("IsKey", "false");
            _columnCreatedUserName.ExtendedProperties.Add("ReadOnly", "false");
            _columnCreatedUserName.ExtendedProperties.Add("Description", "Created User Name");
            _columnCreatedUserName.ExtendedProperties.Add("Length", "15");
            _columnCreatedUserName.ExtendedProperties.Add("Decimals", "0");
            _columnCreatedUserName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCreatedUserName);

            _columnCreatedDate = new DataColumn("CreatedDate", typeof(DateTime));
            _columnCreatedDate.AllowDBNull = true;
            _columnCreatedDate.Caption = "Created Date";
            _columnCreatedDate.Unique = false;
            _columnCreatedDate.DefaultValue = Convert.DBNull;
            _columnCreatedDate.ExtendedProperties.Add("IsKey", "false");
            _columnCreatedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnCreatedDate.ExtendedProperties.Add("Description", "Created Date");
            _columnCreatedDate.ExtendedProperties.Add("Decimals", "0");
            _columnCreatedDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCreatedDate);

            _columnModifiedUserName = new DataColumn("ModifiedUserName", typeof(string));
            _columnModifiedUserName.AllowDBNull = true;
            _columnModifiedUserName.Caption = "Modified User Name";
            _columnModifiedUserName.MaxLength = 15;
            _columnModifiedUserName.Unique = false;
            _columnModifiedUserName.DefaultValue = Convert.DBNull;
            _columnModifiedUserName.ExtendedProperties.Add("IsKey", "false");
            _columnModifiedUserName.ExtendedProperties.Add("ReadOnly", "false");
            _columnModifiedUserName.ExtendedProperties.Add("Description", "Modified User Name");
            _columnModifiedUserName.ExtendedProperties.Add("Length", "15");
            _columnModifiedUserName.ExtendedProperties.Add("Decimals", "0");
            _columnModifiedUserName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnModifiedUserName);

            _columnModifiedDate = new DataColumn("ModifiedDate", typeof(DateTime));
            _columnModifiedDate.AllowDBNull = true;
            _columnModifiedDate.Caption = "Modified Date";
            _columnModifiedDate.Unique = false;
            _columnModifiedDate.DefaultValue = Convert.DBNull;
            _columnModifiedDate.ExtendedProperties.Add("IsKey", "false");
            _columnModifiedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnModifiedDate.ExtendedProperties.Add("Description", "Modified Date");
            _columnModifiedDate.ExtendedProperties.Add("Decimals", "0");
            _columnModifiedDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnModifiedDate);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"] };
        }
        #endregion

        #region Constructors
        public RegisterShiftTable()
            : base("RegisterShiftByDuration")
        {
            this.InitClass();
        }
        public RegisterShiftTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterShift_GetContent", Connection.GetConnection());
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
        public static RegisterShiftTable GetContentTable()
        {
            RegisterShiftTable registerShiftTable = new RegisterShiftTable();
            registerShiftTable.GetContent();
            return registerShiftTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterShift_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 100, "ShiftID");
            sqlCommand.Parameters.Add("@CreatedUserName", SqlDbType.NVarChar, 15, "CreatedUserName");
            sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime, 8, "CreatedDate");
            sqlCommand.Parameters.Add("@ModifiedUserName", SqlDbType.NVarChar, 15, "ModifiedUserName");
            sqlCommand.Parameters.Add("@ModifiedDate", SqlDbType.DateTime, 8, "ModifiedDate");

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
        public override bool Update()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterShift_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 100, "ShiftID");
            sqlCommand.Parameters.Add("@CreatedUserName", SqlDbType.NVarChar, 15, "CreatedUserName");
            sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime, 8, "CreatedDate");
            sqlCommand.Parameters.Add("@ModifiedUserName", SqlDbType.NVarChar, 15, "ModifiedUserName");
            sqlCommand.Parameters.Add("@ModifiedDate", SqlDbType.DateTime, 8, "ModifiedDate");

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
        public override bool Delete()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterShift_Delete", Connection.GetConnection());
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

            RegisterShiftRow row = FindByPrimaryKey(employeeID, fromDate);
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
        public DataColumn ShiftIDColumn
        {
            get
            {
                return _columnShiftID;
            }
        }
        public DataColumn CreatedUserNameColumn
        {
            get
            {
                return _columnCreatedUserName;
            }
        }
        public DataColumn CreatedDateColumn
        {
            get
            {
                return _columnCreatedDate;
            }
        }
        public DataColumn ModifiedUserNameColumn
        {
            get
            {
                return _columnModifiedUserName;
            }
        }
        public DataColumn ModifiedDateColumn
        {
            get
            {
                return _columnModifiedDate;
            }
        }
        public override RegisterItemR this[int index]
        {
            get
            {
                return ((RegisterItemR)(this.Rows[index]));
            }
        }
        public void AddRegisterShiftRow(RegisterShiftRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddRegisterItemRow(RegisterItemR r)
        {
            this.Rows.Add(r);
        }
        public RegisterShiftRow AddRegisterShiftRow(int employeeID, DateTime fromDate, DateTime toDate, string shiftID, string createdUserName, DateTime createdDate, string modifiedUserName, DateTime modifiedDate)
        {
            RegisterShiftRow rowRegisterShiftRow = ((RegisterShiftRow)(this.NewRow()));
            rowRegisterShiftRow["EmployeeID"] = employeeID;
            rowRegisterShiftRow["FromDate"] = fromDate;
            rowRegisterShiftRow["ToDate"] = toDate;
            rowRegisterShiftRow["ShiftID"] = shiftID;
            rowRegisterShiftRow["CreatedUserName"] = createdUserName;
            rowRegisterShiftRow["CreatedDate"] = createdDate;
            rowRegisterShiftRow["ModifiedUserName"] = modifiedUserName;
            rowRegisterShiftRow["ModifiedDate"] = modifiedDate;
            this.Rows.Add(rowRegisterShiftRow);
            return rowRegisterShiftRow;
        }
        public RegisterShiftRow FindByPrimaryKey(int employeeID, DateTime fromDate)
        {
            return (RegisterShiftRow)(Rows.Find(new object[] { employeeID, fromDate }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterShiftRow(builder);
        }
        public override int GetListByEmployeeID(string employeeIDList, int count)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterShift_GetListByEmployeeID", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
            sqlCommand.Parameters.Add("@Count", SqlDbType.Int, 4).Value = count;

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
        public override DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class RegisterShiftRow : RegisterItemR
    {
        private RegisterShiftTable _tableRegisterShift;

        internal RegisterShiftRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterShift = ((RegisterShiftTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterShift.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableRegisterShift.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableRegisterShift.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterShift.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableRegisterShift.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableRegisterShift.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterShift.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableRegisterShift.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableRegisterShift.ToDateColumn] = Convert.DBNull;
        }
        public string ShiftID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterShift.ShiftIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ShiftID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.ShiftIDColumn] = value;
            }
        }
        public bool IsShiftIDNull()
        {
            return this.IsNull(_tableRegisterShift.ShiftIDColumn);
        }
        public void SetShiftIDNull()
        {
            this[_tableRegisterShift.ShiftIDColumn] = Convert.DBNull;
        }
        public string CreatedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterShift.CreatedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.CreatedUserNameColumn] = value;
            }
        }
        public bool IsCreatedUserNameNull()
        {
            return this.IsNull(_tableRegisterShift.CreatedUserNameColumn);
        }
        public void SetCreatedUserNameNull()
        {
            this[_tableRegisterShift.CreatedUserNameColumn] = Convert.DBNull;
        }
        public DateTime CreatedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterShift.CreatedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.CreatedDateColumn] = value;
            }
        }
        public bool IsCreatedDateNull()
        {
            return this.IsNull(_tableRegisterShift.CreatedDateColumn);
        }
        public void SetCreatedDateNull()
        {
            this[_tableRegisterShift.CreatedDateColumn] = Convert.DBNull;
        }
        public string ModifiedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterShift.ModifiedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.ModifiedUserNameColumn] = value;
            }
        }
        public bool IsModifiedUserNameNull()
        {
            return this.IsNull(_tableRegisterShift.ModifiedUserNameColumn);
        }
        public void SetModifiedUserNameNull()
        {
            this[_tableRegisterShift.ModifiedUserNameColumn] = Convert.DBNull;
        }
        public DateTime ModifiedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterShift.ModifiedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterShift.ModifiedDateColumn] = value;
            }
        }
        public bool IsModifiedDateNull()
        {
            return this.IsNull(_tableRegisterShift.ModifiedDateColumn);
        }
        public void SetModifiedDateNull()
        {
            this[_tableRegisterShift.ModifiedDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
