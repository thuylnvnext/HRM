using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ModifiedDataTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnValue;
        private DataColumn _columnEnrollNumber;
        private DataColumn _columnSwipedDate;
        private DataColumn _columnStatus;
        private DataColumn _columnUserName;

        private void InitClass()
        {
            _columnEmployeeID = new DataColumn("EmployeeID", typeof(int));
            _columnEmployeeID.AllowDBNull = false;
            _columnEmployeeID.Caption = "Employee ID";
            _columnEmployeeID.Unique = false;
            _columnEmployeeID.DefaultValue = Convert.DBNull;
            _columnEmployeeID.ExtendedProperties.Add("IsKey", "false");
            _columnEmployeeID.ExtendedProperties.Add("ReadOnly", "false");
            _columnEmployeeID.ExtendedProperties.Add("Description", "Employee ID");
            _columnEmployeeID.ExtendedProperties.Add("Decimals", "0");
            _columnEmployeeID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnEmployeeID);

            _columnValue = new DataColumn("Value", typeof(DateTime));
            _columnValue.AllowDBNull = false;
            _columnValue.Caption = "Value";
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnValue);

            _columnEnrollNumber = new DataColumn("EnrollNumber", typeof(int));
            _columnEnrollNumber.AllowDBNull = false;
            _columnEnrollNumber.Caption = "Enroll Number";
            _columnEnrollNumber.Unique = false;
            _columnEnrollNumber.DefaultValue = Convert.DBNull;
            _columnEnrollNumber.ExtendedProperties.Add("IsKey", "true");
            _columnEnrollNumber.ExtendedProperties.Add("ReadOnly", "false");
            _columnEnrollNumber.ExtendedProperties.Add("Description", "Enroll Number");
            _columnEnrollNumber.ExtendedProperties.Add("Decimals", "0");
            _columnEnrollNumber.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnEnrollNumber);

            _columnSwipedDate = new DataColumn("SwipedDate", typeof(DateTime));
            _columnSwipedDate.AllowDBNull = false;
            _columnSwipedDate.Caption = "Swiped Date";
            _columnSwipedDate.Unique = false;
            _columnSwipedDate.DefaultValue = Convert.DBNull;
            _columnSwipedDate.ExtendedProperties.Add("IsKey", "true");
            _columnSwipedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnSwipedDate.ExtendedProperties.Add("Description", "Swiped Date");
            _columnSwipedDate.ExtendedProperties.Add("Decimals", "0");
            _columnSwipedDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnSwipedDate);

            _columnStatus = new DataColumn("Status", typeof(byte));
            _columnStatus.AllowDBNull = true;
            _columnStatus.Caption = "Status";
            _columnStatus.Unique = false;
            _columnStatus.DefaultValue = Convert.DBNull;
            _columnStatus.ExtendedProperties.Add("IsKey", "false");
            _columnStatus.ExtendedProperties.Add("ReadOnly", "false");
            _columnStatus.ExtendedProperties.Add("Description", "Status");
            _columnStatus.ExtendedProperties.Add("Decimals", "0");
            _columnStatus.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnStatus);

            _columnUserName = new DataColumn("UserName", typeof(string));
            _columnUserName.AllowDBNull = true;
            _columnUserName.Caption = "User Name";
            _columnUserName.MaxLength = 15;
            _columnUserName.Unique = false;
            _columnUserName.DefaultValue = Convert.DBNull;
            _columnUserName.ExtendedProperties.Add("IsKey", "false");
            _columnUserName.ExtendedProperties.Add("ReadOnly", "false");
            _columnUserName.ExtendedProperties.Add("Description", "User Name");
            _columnUserName.ExtendedProperties.Add("Length", "15");
            _columnUserName.ExtendedProperties.Add("Decimals", "0");
            _columnUserName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnUserName);

            this.PrimaryKey = new DataColumn[] { this.Columns["EnrollNumber"], this.Columns["SwipedDate"] };
        }
        #endregion

        #region Constructors
        public ModifiedDataTable()
            : base("ModifiedData")
        {
            this.InitClass();
        }
        public ModifiedDataTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("ModifiedData_GetContent", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
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
        }
        public static ModifiedDataTable GetContentTable()
        {
            ModifiedDataTable modifiedDataTable = new ModifiedDataTable();
            modifiedDataTable.GetContent();
            return modifiedDataTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("ModifiedData_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.DateTime, 8, "Value");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8, "SwipedDate");
            sqlCommand.Parameters.Add("@Status", SqlDbType.TinyInt, 1, "Status");
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15, "UserName");

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
            SqlCommand sqlCommand = new SqlCommand("ModifiedData_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEnrollNumber", SqlDbType.Int, 4, "EnrollNumber").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalSwipedDate", SqlDbType.DateTime, 8, "SwipedDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Value", SqlDbType.DateTime, 8, "Value");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8, "SwipedDate");
            sqlCommand.Parameters.Add("@Status", SqlDbType.TinyInt, 1, "Status");
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15, "UserName");

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
            SqlCommand sqlCommand = new SqlCommand("ModifiedData_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8, "SwipedDate");

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
        public bool Delete(int enrollNumber, DateTime swipedDate)
        {
            bool retVal;

            ModifiedDataRow row = FindByPrimaryKey(enrollNumber, swipedDate);
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
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
            }
        }
        public DataColumn EnrollNumberColumn
        {
            get
            {
                return _columnEnrollNumber;
            }
        }
        public DataColumn SwipedDateColumn
        {
            get
            {
                return _columnSwipedDate;
            }
        }
        public DataColumn StatusColumn
        {
            get
            {
                return _columnStatus;
            }
        }
        public DataColumn UserNameColumn
        {
            get
            {
                return _columnUserName;
            }
        }
        public ModifiedDataRow this[int index]
        {
            get
            {
                return ((ModifiedDataRow)(this.Rows[index]));
            }
        }
        public void AddModifiedDataRow(ModifiedDataRow row)
        {
            this.Rows.Add(row);
        }
        public ModifiedDataRow AddModifiedDataRow(int employeeID, DateTime value, int enrollNumber, DateTime swipedDate, byte status, string userName)
        {
            ModifiedDataRow rowModifiedDataRow = ((ModifiedDataRow)(this.NewRow()));
            rowModifiedDataRow["EmployeeID"] = employeeID;
            rowModifiedDataRow["Value"] = value;
            rowModifiedDataRow["EnrollNumber"] = enrollNumber;
            rowModifiedDataRow["SwipedDate"] = swipedDate;
            rowModifiedDataRow["Status"] = status;
            rowModifiedDataRow["UserName"] = userName;
            this.Rows.Add(rowModifiedDataRow);
            return rowModifiedDataRow;
        }
        public ModifiedDataRow FindByPrimaryKey(int enrollNumber, DateTime swipedDate)
        {
            return (ModifiedDataRow)(Rows.Find(new object[] { enrollNumber, swipedDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ModifiedDataRow(builder);
        }
        public ModifiedDataRow GetInfoByEmployeeID(int employeeID, DateTime value)
        {
            foreach (ModifiedDataRow mdr in this)
            {
                if (mdr.EmployeeID == employeeID && mdr.Value == value) return mdr;
            }
            return null;
        }
        #endregion
    }

    public class ModifiedDataRow : DataRow
    {
        private ModifiedDataTable _tableModifiedData;

        internal ModifiedDataRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableModifiedData = ((ModifiedDataTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableModifiedData.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableModifiedData.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableModifiedData.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableModifiedData.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime Value
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableModifiedData.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableModifiedData.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableModifiedData.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableModifiedData.ValueColumn] = Convert.DBNull;
        }
        public int EnrollNumber
        {
            get
            {
                try
                {
                    return ((int)(this[_tableModifiedData.EnrollNumberColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EnrollNumber because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableModifiedData.EnrollNumberColumn] = value;
            }
        }
        public bool IsEnrollNumberNull()
        {
            return this.IsNull(_tableModifiedData.EnrollNumberColumn);
        }
        public void SetEnrollNumberNull()
        {
            this[_tableModifiedData.EnrollNumberColumn] = Convert.DBNull;
        }
        public DateTime SwipedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableModifiedData.SwipedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SwipedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableModifiedData.SwipedDateColumn] = value;
            }
        }
        public bool IsSwipedDateNull()
        {
            return this.IsNull(_tableModifiedData.SwipedDateColumn);
        }
        public void SetSwipedDateNull()
        {
            this[_tableModifiedData.SwipedDateColumn] = Convert.DBNull;
        }
        public byte Status
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableModifiedData.StatusColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Status because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableModifiedData.StatusColumn] = value;
            }
        }
        public bool IsStatusNull()
        {
            return this.IsNull(_tableModifiedData.StatusColumn);
        }
        public void SetStatusNull()
        {
            this[_tableModifiedData.StatusColumn] = Convert.DBNull;
        }
        public string UserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableModifiedData.UserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value UserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableModifiedData.UserNameColumn] = value;
            }
        }
        public bool IsUserNameNull()
        {
            return this.IsNull(_tableModifiedData.UserNameColumn);
        }
        public void SetUserNameNull()
        {
            this[_tableModifiedData.UserNameColumn] = Convert.DBNull;
        }
        #endregion
    }
}