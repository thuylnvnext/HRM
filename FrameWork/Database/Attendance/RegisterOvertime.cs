using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterOvertimeTable : RegisterItemT
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnValue;
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
        public RegisterOvertimeTable()
            : base("RegisterOvertime")
        {
            this.InitClass();
        }
        public RegisterOvertimeTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterOvertime_GetContent", Connection.GetConnection());
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
        public static RegisterOvertimeTable GetContentTable()
        {
            RegisterOvertimeTable registerOvertimeTable = new RegisterOvertimeTable();
            registerOvertimeTable.GetContent();
            return registerOvertimeTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterOvertime_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");
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
            SqlCommand sqlCommand = new SqlCommand("RegisterOvertime_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");
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
            SqlCommand sqlCommand = new SqlCommand("RegisterOvertime_Delete", Connection.GetConnection());
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

            RegisterOvertimeRow row = FindByPrimaryKey(employeeID, fromDate);
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
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
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
        public void AddRegisterOvertimeRow(RegisterOvertimeRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddRegisterItemRow(RegisterItemR r)
        {
            this.Rows.Add(r);
        }
        public RegisterOvertimeRow AddRegisterOvertimeRow(int employeeID, DateTime fromDate, DateTime toDate, decimal value)
        {
            RegisterOvertimeRow rowRegisterOvertimeRow = ((RegisterOvertimeRow)(this.NewRow()));
            rowRegisterOvertimeRow["EmployeeID"] = employeeID;
            rowRegisterOvertimeRow["FromDate"] = fromDate;
            rowRegisterOvertimeRow["ToDate"] = toDate;
            rowRegisterOvertimeRow["Value"] = value;
            this.Rows.Add(rowRegisterOvertimeRow);
            return rowRegisterOvertimeRow;
        }
        public RegisterOvertimeRow FindByPrimaryKey(int employeeID, DateTime fromDate)
        {
            return (RegisterOvertimeRow)(Rows.Find(new object[] { employeeID, fromDate }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterOvertimeRow(builder);
        }
        public override int GetListByEmployeeID(string employeeIDList, int count)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterOvertime_GetListByEmployeeID", Connection.GetConnection());

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

    public class RegisterOvertimeRow : RegisterItemR
    {
        private RegisterOvertimeTable _tableRegisterOvertime;

        internal RegisterOvertimeRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterOvertime = ((RegisterOvertimeTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterOvertime.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableRegisterOvertime.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableRegisterOvertime.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterOvertime.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableRegisterOvertime.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableRegisterOvertime.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterOvertime.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableRegisterOvertime.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableRegisterOvertime.ToDateColumn] = Convert.DBNull;
        }
        public decimal Value
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableRegisterOvertime.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableRegisterOvertime.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableRegisterOvertime.ValueColumn] = Convert.DBNull;
        }
        public string CreatedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterOvertime.CreatedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.CreatedUserNameColumn] = value;
            }
        }
        public bool IsCreatedUserNameNull()
        {
            return this.IsNull(_tableRegisterOvertime.CreatedUserNameColumn);
        }
        public void SetCreatedUserNameNull()
        {
            this[_tableRegisterOvertime.CreatedUserNameColumn] = Convert.DBNull;
        }
        public DateTime CreatedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterOvertime.CreatedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.CreatedDateColumn] = value;
            }
        }
        public bool IsCreatedDateNull()
        {
            return this.IsNull(_tableRegisterOvertime.CreatedDateColumn);
        }
        public void SetCreatedDateNull()
        {
            this[_tableRegisterOvertime.CreatedDateColumn] = Convert.DBNull;
        }
        public string ModifiedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterOvertime.ModifiedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.ModifiedUserNameColumn] = value;
            }
        }
        public bool IsModifiedUserNameNull()
        {
            return this.IsNull(_tableRegisterOvertime.ModifiedUserNameColumn);
        }
        public void SetModifiedUserNameNull()
        {
            this[_tableRegisterOvertime.ModifiedUserNameColumn] = Convert.DBNull;
        }
        public DateTime ModifiedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterOvertime.ModifiedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterOvertime.ModifiedDateColumn] = value;
            }
        }
        public bool IsModifiedDateNull()
        {
            return this.IsNull(_tableRegisterOvertime.ModifiedDateColumn);
        }
        public void SetModifiedDateNull()
        {
            this[_tableRegisterOvertime.ModifiedDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
