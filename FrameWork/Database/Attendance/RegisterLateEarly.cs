using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterLateEarlyTable : RegisterItemT
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnType;
        private DataColumn _columnReason;
        private DataColumn _columnValid;
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

            _columnType = new DataColumn("Type", typeof(bool));
            _columnType.AllowDBNull = false;
            _columnType.Caption = "Type";
            _columnType.Unique = false;
            _columnType.DefaultValue = Convert.DBNull;
            _columnType.ExtendedProperties.Add("IsKey", "true");
            _columnType.ExtendedProperties.Add("ReadOnly", "false");
            _columnType.ExtendedProperties.Add("Description", "Type");
            _columnType.ExtendedProperties.Add("Decimals", "0");
            _columnType.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnType);

            _columnReason = new DataColumn("Reason", typeof(string));
            _columnReason.AllowDBNull = true;
            _columnReason.Caption = "Reason";
            _columnReason.MaxLength = 250;
            _columnReason.Unique = false;
            _columnReason.DefaultValue = Convert.DBNull;
            _columnReason.ExtendedProperties.Add("IsKey", "false");
            _columnReason.ExtendedProperties.Add("ReadOnly", "false");
            _columnReason.ExtendedProperties.Add("Description", "Reason");
            _columnReason.ExtendedProperties.Add("Length", "250");
            _columnReason.ExtendedProperties.Add("Decimals", "0");
            _columnReason.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnReason);

            _columnValid = new DataColumn("Valid", typeof(bool));
            _columnValid.AllowDBNull = true;
            _columnValid.Caption = "Valid";
            _columnValid.Unique = false;
            _columnValid.DefaultValue = Convert.DBNull;
            _columnValid.ExtendedProperties.Add("IsKey", "false");
            _columnValid.ExtendedProperties.Add("ReadOnly", "false");
            _columnValid.ExtendedProperties.Add("Description", "Valid");
            _columnValid.ExtendedProperties.Add("Decimals", "0");
            _columnValid.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValid);

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

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"], this.Columns["Type"] };
        }
        #endregion

        #region Constructors
        public RegisterLateEarlyTable()
            : base("RegisterLateEarly")
        {
            this.InitClass();
        }
        public RegisterLateEarlyTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_GetContent", Connection.GetConnection());
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
        public static RegisterLateEarlyTable GetContentTable()
        {
            RegisterLateEarlyTable registerLateEarlyTable = new RegisterLateEarlyTable();
            registerLateEarlyTable.GetContent();
            return registerLateEarlyTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Type", SqlDbType.Bit, 1, "Type");
            sqlCommand.Parameters.Add("@Reason", SqlDbType.NVarChar, 250, "Reason");
            sqlCommand.Parameters.Add("@Valid", SqlDbType.Bit, 1, "Valid");
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
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalType", SqlDbType.Bit, 1, "Type").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Type", SqlDbType.Bit, 1, "Type");
            sqlCommand.Parameters.Add("@Reason", SqlDbType.NVarChar, 250, "Reason");
            sqlCommand.Parameters.Add("@Valid", SqlDbType.Bit, 1, "Valid");
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
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@Type", SqlDbType.Bit, 1, "Type");

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
        public bool Delete(int employeeID, DateTime fromDate, bool type)
        {
            bool retVal;

            RegisterLateEarlyRow row = FindByPrimaryKey(employeeID, fromDate, type);
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
        public DataColumn TypeColumn
        {
            get
            {
                return _columnType;
            }
        }
        public DataColumn ReasonColumn
        {
            get
            {
                return _columnReason;
            }
        }
        public DataColumn ValidColumn
        {
            get
            {
                return _columnValid;
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
        public void AddRegisterLateEarlyRow(RegisterLateEarlyRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddRegisterItemRow(RegisterItemR r)
        {
            this.Rows.Add(r);
        }
        public RegisterLateEarlyRow AddRegisterLateEarlyRow(int employeeID, DateTime fromDate, DateTime toDate, bool type, string reason, bool valid, string createdUserName, DateTime createdDate, string modifiedUserName, DateTime modifiedDate)
        {
            RegisterLateEarlyRow rowRegisterLateEarlyRow = ((RegisterLateEarlyRow)(this.NewRow()));
            rowRegisterLateEarlyRow["EmployeeID"] = employeeID;
            rowRegisterLateEarlyRow["FromDate"] = fromDate;
            rowRegisterLateEarlyRow["ToDate"] = toDate;
            rowRegisterLateEarlyRow["Type"] = type;
            rowRegisterLateEarlyRow["Reason"] = reason;
            rowRegisterLateEarlyRow["Valid"] = valid;
            rowRegisterLateEarlyRow["CreatedUserName"] = createdUserName;
            rowRegisterLateEarlyRow["CreatedDate"] = createdDate;
            rowRegisterLateEarlyRow["ModifiedUserName"] = modifiedUserName;
            rowRegisterLateEarlyRow["ModifiedDate"] = modifiedDate;
            this.Rows.Add(rowRegisterLateEarlyRow);
            return rowRegisterLateEarlyRow;
        }
        public RegisterLateEarlyRow FindByPrimaryKey(int employeeID, DateTime fromDate, bool type)
        {
            return (RegisterLateEarlyRow)(Rows.Find(new object[] { employeeID, fromDate, type }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterLateEarlyRow(builder);
        }
        public override int GetListByEmployeeID(string employeeIDList, int count)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_GetListByEmployeeID", Connection.GetConnection());

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
        public override DataColumnCollection GetColumns()
        {
            return Columns;
        }
        public int DailyStatistic(string departmentIDList, DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_DailyStatistic", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 1000).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;

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

            return Count;
        }
        public int ViolationHandling(string departmentIDList, DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterLateEarly_ViolationHandling", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 1000).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
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

            return Count;
        }
        public void DeleteByDepartmentID(string departmentIDList)
        {
            foreach (RegisterLateEarlyRow rler in this)
            {
                if (departmentIDList.IndexOf("[" + rler["ID"].ToString() + "]") >= 0 || departmentIDList.IndexOf("[" + rler["DepartmentID"].ToString() + "]") >= 0) rler.Delete();
            }
            AcceptChanges();
        }
        #endregion
    }

    public class RegisterLateEarlyRow : RegisterItemR
    {
        private RegisterLateEarlyTable _tableRegisterLateEarly;

        internal RegisterLateEarlyRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterLateEarly = ((RegisterLateEarlyTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterLateEarly.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableRegisterLateEarly.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableRegisterLateEarly.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterLateEarly.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableRegisterLateEarly.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableRegisterLateEarly.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterLateEarly.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableRegisterLateEarly.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableRegisterLateEarly.ToDateColumn] = Convert.DBNull;
        }
        public bool Type
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableRegisterLateEarly.TypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Type because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.TypeColumn] = value;
            }
        }
        public bool IsTypeNull()
        {
            return this.IsNull(_tableRegisterLateEarly.TypeColumn);
        }
        public void SetTypeNull()
        {
            this[_tableRegisterLateEarly.TypeColumn] = Convert.DBNull;
        }
        public string Reason
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterLateEarly.ReasonColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Reason because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.ReasonColumn] = value;
            }
        }
        public bool IsReasonNull()
        {
            return this.IsNull(_tableRegisterLateEarly.ReasonColumn);
        }
        public void SetReasonNull()
        {
            this[_tableRegisterLateEarly.ReasonColumn] = Convert.DBNull;
        }
        public bool Valid
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableRegisterLateEarly.ValidColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Valid because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.ValidColumn] = value;
            }
        }
        public bool IsValidNull()
        {
            return this.IsNull(_tableRegisterLateEarly.ValidColumn);
        }
        public void SetValidNull()
        {
            this[_tableRegisterLateEarly.ValidColumn] = Convert.DBNull;
        }
        public string CreatedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterLateEarly.CreatedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.CreatedUserNameColumn] = value;
            }
        }
        public bool IsCreatedUserNameNull()
        {
            return this.IsNull(_tableRegisterLateEarly.CreatedUserNameColumn);
        }
        public void SetCreatedUserNameNull()
        {
            this[_tableRegisterLateEarly.CreatedUserNameColumn] = Convert.DBNull;
        }
        public DateTime CreatedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterLateEarly.CreatedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.CreatedDateColumn] = value;
            }
        }
        public bool IsCreatedDateNull()
        {
            return this.IsNull(_tableRegisterLateEarly.CreatedDateColumn);
        }
        public void SetCreatedDateNull()
        {
            this[_tableRegisterLateEarly.CreatedDateColumn] = Convert.DBNull;
        }
        public string ModifiedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterLateEarly.ModifiedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.ModifiedUserNameColumn] = value;
            }
        }
        public bool IsModifiedUserNameNull()
        {
            return this.IsNull(_tableRegisterLateEarly.ModifiedUserNameColumn);
        }
        public void SetModifiedUserNameNull()
        {
            this[_tableRegisterLateEarly.ModifiedUserNameColumn] = Convert.DBNull;
        }
        public DateTime ModifiedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterLateEarly.ModifiedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterLateEarly.ModifiedDateColumn] = value;
            }
        }
        public bool IsModifiedDateNull()
        {
            return this.IsNull(_tableRegisterLateEarly.ModifiedDateColumn);
        }
        public void SetModifiedDateNull()
        {
            this[_tableRegisterLateEarly.ModifiedDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
