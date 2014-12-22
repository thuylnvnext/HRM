using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterAttendanceItemTable : RegisterItemT
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnAttendanceItemID;
        private DataColumn _columnValue;
        private DataColumn _columnNotes;
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
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "9");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            _columnNotes = new DataColumn("Notes", typeof(string));
            _columnNotes.AllowDBNull = true;
            _columnNotes.Caption = "Notes";
            _columnNotes.MaxLength = 250;
            _columnNotes.Unique = false;
            _columnNotes.DefaultValue = Convert.DBNull;
            _columnNotes.ExtendedProperties.Add("IsKey", "false");
            _columnNotes.ExtendedProperties.Add("ReadOnly", "false");
            _columnNotes.ExtendedProperties.Add("Description", "Notes");
            _columnNotes.ExtendedProperties.Add("Length", "250");
            _columnNotes.ExtendedProperties.Add("Decimals", "0");
            _columnNotes.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNotes);

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

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"], this.Columns["AttendanceItemID"] };
        }
        #endregion

        #region Constructors
        public RegisterAttendanceItemTable()
            : base("RegisterAttendanceItem")
        {
            this.InitClass();
        }
        public RegisterAttendanceItemTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAttendanceItem_GetContent", Connection.GetConnection());
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
        public static RegisterAttendanceItemTable GetContentTable()
        {
            RegisterAttendanceItemTable registerAttendanceItemTable = new RegisterAttendanceItemTable();
            registerAttendanceItemTable.GetContent();
            return registerAttendanceItemTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAttendanceItem_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 250, "Notes");
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
            SqlCommand sqlCommand = new SqlCommand("RegisterAttendanceItem_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalAttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@AttendanceItemID", SqlDbType.VarChar, 10, "AttendanceItemID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal, 9, "Value");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 250, "Notes");
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
            SqlCommand sqlCommand = new SqlCommand("RegisterAttendanceItem_Delete", Connection.GetConnection());
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
        public bool Delete(int employeeID, DateTime fromDate, string salaryItemID)
        {
            bool retVal;

            RegisterAttendanceItemRow row = FindByPrimaryKey(employeeID, fromDate, salaryItemID);
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
        public DataColumn NotesColumn
        {
            get
            {
                return _columnNotes;
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
        public void AddRegisterAttendanceItemRow(RegisterAttendanceItemRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddRegisterItemRow(RegisterItemR r)
        {
            this.Rows.Add(r);
        }
        public RegisterAttendanceItemRow AddRegisterAttendanceItemRow(int employeeID, DateTime fromDate, DateTime toDate, string salaryItemID, decimal value, string notes, string createdUserName, DateTime createdDate, string modifiedUserName, DateTime modifiedDate)
        {
            RegisterAttendanceItemRow rowRegisterAttendanceItemRow = ((RegisterAttendanceItemRow)(this.NewRow()));
            rowRegisterAttendanceItemRow["EmployeeID"] = employeeID;
            rowRegisterAttendanceItemRow["FromDate"] = fromDate;
            rowRegisterAttendanceItemRow["ToDate"] = toDate;
            rowRegisterAttendanceItemRow["AttendanceItemID"] = salaryItemID;
            rowRegisterAttendanceItemRow["Value"] = value;
            rowRegisterAttendanceItemRow["CreatedUserName"] = createdUserName;
            rowRegisterAttendanceItemRow["CreatedDate"] = createdDate;
            rowRegisterAttendanceItemRow["ModifiedUserName"] = modifiedUserName;
            rowRegisterAttendanceItemRow["ModifiedDate"] = modifiedDate;
            this.Rows.Add(rowRegisterAttendanceItemRow);
            return rowRegisterAttendanceItemRow;
        }
        public RegisterAttendanceItemRow FindByPrimaryKey(int employeeID, DateTime fromDate, string salaryItemID)
        {
            return (RegisterAttendanceItemRow)(Rows.Find(new object[] { employeeID, fromDate, salaryItemID }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterAttendanceItemRow(builder);
        }
        public override int GetListByEmployeeID(string employeeIDList, int count)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAttendanceItem_GetListByEmployeeID", Connection.GetConnection());

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
        public int GetListByDuration(DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAttendanceItem_GetListByDuration", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
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
        public override DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class RegisterAttendanceItemRow : RegisterItemR
    {
        private RegisterAttendanceItemTable _tableRegisterAttendanceItem;

        internal RegisterAttendanceItemRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterAttendanceItem = ((RegisterAttendanceItemTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterAttendanceItem.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableRegisterAttendanceItem.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAttendanceItem.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableRegisterAttendanceItem.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAttendanceItem.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableRegisterAttendanceItem.ToDateColumn] = Convert.DBNull;
        }
        public string AttendanceItemID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAttendanceItem.AttendanceItemIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AttendanceItemID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.AttendanceItemIDColumn] = value;
            }
        }
        public bool IsAttendanceItemIDNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.AttendanceItemIDColumn);
        }
        public void SetAttendanceItemIDNull()
        {
            this[_tableRegisterAttendanceItem.AttendanceItemIDColumn] = Convert.DBNull;
        }
        public decimal Value
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableRegisterAttendanceItem.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableRegisterAttendanceItem.ValueColumn] = Convert.DBNull;
        }
        public string Notes
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAttendanceItem.NotesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Notes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.NotesColumn] = value;
            }
        }
        public bool IsNotesNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.NotesColumn);
        }
        public void SetNotesNull()
        {
            this[_tableRegisterAttendanceItem.NotesColumn] = Convert.DBNull;
        }
        public string CreatedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAttendanceItem.CreatedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.CreatedUserNameColumn] = value;
            }
        }
        public bool IsCreatedUserNameNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.CreatedUserNameColumn);
        }
        public void SetCreatedUserNameNull()
        {
            this[_tableRegisterAttendanceItem.CreatedUserNameColumn] = Convert.DBNull;
        }
        public DateTime CreatedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAttendanceItem.CreatedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.CreatedDateColumn] = value;
            }
        }
        public bool IsCreatedDateNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.CreatedDateColumn);
        }
        public void SetCreatedDateNull()
        {
            this[_tableRegisterAttendanceItem.CreatedDateColumn] = Convert.DBNull;
        }
        public string ModifiedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAttendanceItem.ModifiedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.ModifiedUserNameColumn] = value;
            }
        }
        public bool IsModifiedUserNameNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.ModifiedUserNameColumn);
        }
        public void SetModifiedUserNameNull()
        {
            this[_tableRegisterAttendanceItem.ModifiedUserNameColumn] = Convert.DBNull;
        }
        public DateTime ModifiedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAttendanceItem.ModifiedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAttendanceItem.ModifiedDateColumn] = value;
            }
        }
        public bool IsModifiedDateNull()
        {
            return this.IsNull(_tableRegisterAttendanceItem.ModifiedDateColumn);
        }
        public void SetModifiedDateNull()
        {
            this[_tableRegisterAttendanceItem.ModifiedDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
