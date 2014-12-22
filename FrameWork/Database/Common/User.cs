using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class UserTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnName;
        private DataColumn _columnPassword;
        private DataColumn _columnFullName;
        private DataColumn _columnBirthDate;
        private DataColumn _columnIDNumber;
        private DataColumn _columnAddress;
        private DataColumn _columnPhone;
        private DataColumn _columnEmail;
        private DataColumn _columnPermission;
        private DataColumn _columnVirtualData;
        private DataColumn _columnGroupID;

        private void InitClass()
        {
            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = false;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 15;
            _columnName.Unique = true;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "true");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "15");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnName);

            _columnPassword = new DataColumn("Password", typeof(string));
            _columnPassword.AllowDBNull = true;
            _columnPassword.Caption = "Password";
            _columnPassword.MaxLength = 128;
            _columnPassword.Unique = false;
            _columnPassword.DefaultValue = Convert.DBNull;
            _columnPassword.ExtendedProperties.Add("IsKey", "false");
            _columnPassword.ExtendedProperties.Add("ReadOnly", "false");
            _columnPassword.ExtendedProperties.Add("Description", "Password");
            _columnPassword.ExtendedProperties.Add("Length", "128");
            _columnPassword.ExtendedProperties.Add("Decimals", "0");
            _columnPassword.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPassword);

            _columnFullName = new DataColumn("FullName", typeof(string));
            _columnFullName.AllowDBNull = true;
            _columnFullName.Caption = "Full Name";
            _columnFullName.MaxLength = 30;
            _columnFullName.Unique = false;
            _columnFullName.DefaultValue = Convert.DBNull;
            _columnFullName.ExtendedProperties.Add("IsKey", "false");
            _columnFullName.ExtendedProperties.Add("ReadOnly", "false");
            _columnFullName.ExtendedProperties.Add("Description", "Full Name");
            _columnFullName.ExtendedProperties.Add("Length", "30");
            _columnFullName.ExtendedProperties.Add("Decimals", "0");
            _columnFullName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnFullName);

            _columnBirthDate = new DataColumn("BirthDate", typeof(DateTime));
            _columnBirthDate.AllowDBNull = true;
            _columnBirthDate.Caption = "Birth Date";
            _columnBirthDate.Unique = false;
            _columnBirthDate.DefaultValue = Convert.DBNull;
            _columnBirthDate.ExtendedProperties.Add("IsKey", "false");
            _columnBirthDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnBirthDate.ExtendedProperties.Add("Description", "Birth Date");
            _columnBirthDate.ExtendedProperties.Add("Decimals", "0");
            _columnBirthDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnBirthDate);

            _columnIDNumber = new DataColumn("IDNumber", typeof(string));
            _columnIDNumber.AllowDBNull = true;
            _columnIDNumber.Caption = "I D Number";
            _columnIDNumber.MaxLength = 50;
            _columnIDNumber.Unique = false;
            _columnIDNumber.DefaultValue = Convert.DBNull;
            _columnIDNumber.ExtendedProperties.Add("IsKey", "false");
            _columnIDNumber.ExtendedProperties.Add("ReadOnly", "false");
            _columnIDNumber.ExtendedProperties.Add("Description", "I D Number");
            _columnIDNumber.ExtendedProperties.Add("Length", "50");
            _columnIDNumber.ExtendedProperties.Add("Decimals", "0");
            _columnIDNumber.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnIDNumber);

            _columnAddress = new DataColumn("Address", typeof(string));
            _columnAddress.AllowDBNull = true;
            _columnAddress.Caption = "Address";
            _columnAddress.MaxLength = 200;
            _columnAddress.Unique = false;
            _columnAddress.DefaultValue = Convert.DBNull;
            _columnAddress.ExtendedProperties.Add("IsKey", "false");
            _columnAddress.ExtendedProperties.Add("ReadOnly", "false");
            _columnAddress.ExtendedProperties.Add("Description", "Address");
            _columnAddress.ExtendedProperties.Add("Length", "200");
            _columnAddress.ExtendedProperties.Add("Decimals", "0");
            _columnAddress.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnAddress);

            _columnPhone = new DataColumn("Phone", typeof(string));
            _columnPhone.AllowDBNull = true;
            _columnPhone.Caption = "Phone";
            _columnPhone.MaxLength = 50;
            _columnPhone.Unique = false;
            _columnPhone.DefaultValue = Convert.DBNull;
            _columnPhone.ExtendedProperties.Add("IsKey", "false");
            _columnPhone.ExtendedProperties.Add("ReadOnly", "false");
            _columnPhone.ExtendedProperties.Add("Description", "Phone");
            _columnPhone.ExtendedProperties.Add("Length", "50");
            _columnPhone.ExtendedProperties.Add("Decimals", "0");
            _columnPhone.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPhone);

            _columnEmail = new DataColumn("Email", typeof(string));
            _columnEmail.AllowDBNull = true;
            _columnEmail.Caption = "Email";
            _columnEmail.MaxLength = 200;
            _columnEmail.Unique = false;
            _columnEmail.DefaultValue = Convert.DBNull;
            _columnEmail.ExtendedProperties.Add("IsKey", "false");
            _columnEmail.ExtendedProperties.Add("ReadOnly", "false");
            _columnEmail.ExtendedProperties.Add("Description", "Email");
            _columnEmail.ExtendedProperties.Add("Length", "200");
            _columnEmail.ExtendedProperties.Add("Decimals", "0");
            _columnEmail.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnEmail);

            _columnPermission = new DataColumn("Permission", typeof(bool));
            _columnPermission.AllowDBNull = true;
            _columnPermission.Caption = "Permission";
            _columnPermission.Unique = false;
            _columnPermission.DefaultValue = Convert.DBNull;
            _columnPermission.ExtendedProperties.Add("IsKey", "false");
            _columnPermission.ExtendedProperties.Add("ReadOnly", "false");
            _columnPermission.ExtendedProperties.Add("Description", "Permission");
            _columnPermission.ExtendedProperties.Add("Decimals", "0");
            _columnPermission.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPermission);

            _columnVirtualData = new DataColumn("VirtualData", typeof(bool));
            _columnVirtualData.AllowDBNull = true;
            _columnVirtualData.Caption = "Virtual Data";
            _columnVirtualData.Unique = false;
            _columnVirtualData.DefaultValue = Convert.DBNull;
            _columnVirtualData.ExtendedProperties.Add("IsKey", "false");
            _columnVirtualData.ExtendedProperties.Add("ReadOnly", "false");
            _columnVirtualData.ExtendedProperties.Add("Description", "Virtual Data");
            _columnVirtualData.ExtendedProperties.Add("Decimals", "0");
            _columnVirtualData.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnVirtualData);

            _columnGroupID = new DataColumn("GroupID", typeof(byte));
            _columnGroupID.AllowDBNull = true;
            _columnGroupID.Caption = "Group ID";
            _columnGroupID.Unique = false;
            _columnGroupID.DefaultValue = Convert.DBNull;
            _columnGroupID.ExtendedProperties.Add("IsKey", "false");
            _columnGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnGroupID.ExtendedProperties.Add("Description", "Group ID");
            _columnGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnGroupID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnGroupID);

            this.PrimaryKey = new DataColumn[] { this.Columns["Name"] };
        }
        #endregion

        #region Constructors
        public UserTable()
            : base("User")
        {
            this.InitClass();
        }
        public UserTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("User_GetContent", Connection.GetConnection());
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
        public static UserTable GetContentTable()
        {
            UserTable userTable = new UserTable();
            userTable.GetContent();
            return userTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("User_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 15, "Name");
            sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 128, "Password");
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 30, "FullName");
            sqlCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8, "BirthDate");
            sqlCommand.Parameters.Add("@IDNumber", SqlDbType.VarChar, 50, "IDNumber");
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 200, "Address");
            sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50, "Phone");
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 200, "Email");
            sqlCommand.Parameters.Add("@Permission", SqlDbType.Bit, 1, "Permission");
            sqlCommand.Parameters.Add("@VirtualData", SqlDbType.Bit, 1, "VirtualData");
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt, 1, "GroupID");

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
            SqlCommand sqlCommand = new SqlCommand("User_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalName", SqlDbType.NVarChar, 15, "Name").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 15, "Name");
            sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 128, "Password");
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 30, "FullName");
            sqlCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8, "BirthDate");
            sqlCommand.Parameters.Add("@IDNumber", SqlDbType.VarChar, 50, "IDNumber");
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 200, "Address");
            sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50, "Phone");
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 200, "Email");
            sqlCommand.Parameters.Add("@Permission", SqlDbType.Bit, 1, "Permission");
            sqlCommand.Parameters.Add("@VirtualData", SqlDbType.Bit, 1, "VirtualData");
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt, 1, "GroupID");

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
            SqlCommand sqlCommand = new SqlCommand("User_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 15, "Name");

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
        public bool Delete(string name)
        {
            bool retVal;

            UserRow row = FindByPrimaryKey(name);
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
        public DataColumn NameColumn
        {
            get
            {
                return _columnName;
            }
        }
        public DataColumn PasswordColumn
        {
            get
            {
                return _columnPassword;
            }
        }
        public DataColumn FullNameColumn
        {
            get
            {
                return _columnFullName;
            }
        }
        public DataColumn BirthDateColumn
        {
            get
            {
                return _columnBirthDate;
            }
        }
        public DataColumn IDNumberColumn
        {
            get
            {
                return _columnIDNumber;
            }
        }
        public DataColumn AddressColumn
        {
            get
            {
                return _columnAddress;
            }
        }
        public DataColumn PhoneColumn
        {
            get
            {
                return _columnPhone;
            }
        }
        public DataColumn EmailColumn
        {
            get
            {
                return _columnEmail;
            }
        }
        public DataColumn PermissionColumn
        {
            get
            {
                return _columnPermission;
            }
        }
        public DataColumn VirtualDataColumn
        {
            get
            {
                return _columnVirtualData;
            }
        }
        public DataColumn GroupIDColumn
        {
            get
            {
                return _columnGroupID;
            }
        }
        public UserRow this[int index]
        {
            get
            {
                return ((UserRow)(this.Rows[index]));
            }
        }
        public void AddUserRow(UserRow row)
        {
            this.Rows.Add(row);
        }
        public UserRow AddUserRow(string name, string password, string fullName, DateTime birthDate, string iDNumber, string address, string phone, string email, bool permission, bool virtualData, byte groupID)
        {
            UserRow rowUserRow = ((UserRow)(this.NewRow()));
            rowUserRow["Name"] = name;
            rowUserRow["Password"] = password;
            rowUserRow["FullName"] = fullName;
            rowUserRow["BirthDate"] = birthDate;
            rowUserRow["IDNumber"] = iDNumber;
            rowUserRow["Address"] = address;
            rowUserRow["Phone"] = phone;
            rowUserRow["Email"] = email;
            rowUserRow["Permission"] = permission;
            rowUserRow["VirtualData"] = virtualData;
            rowUserRow["GroupID"] = groupID;
            this.Rows.Add(rowUserRow);
            return rowUserRow;
        }
        public UserRow FindByPrimaryKey(string name)
        {
            return (UserRow)(Rows.Find(new object[] { name }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new UserRow(builder);
        }
        public int GetInfoByName(string name)
        {
            SqlCommand sqlCommand = new SqlCommand("User_GetInfoByName", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 15).Value = name;

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
        #endregion
    }

    public class UserRow : DataRow
    {
        private UserTable _tableUser;

        internal UserRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableUser = ((UserTable)(this.Table));
        }

        #region Properties
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableUser.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableUser.NameColumn] = Convert.DBNull;
        }
        public string Password
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.PasswordColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Password because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.PasswordColumn] = value;
            }
        }
        public bool IsPasswordNull()
        {
            return this.IsNull(_tableUser.PasswordColumn);
        }
        public void SetPasswordNull()
        {
            this[_tableUser.PasswordColumn] = Convert.DBNull;
        }
        public string FullName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.FullNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FullName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.FullNameColumn] = value;
            }
        }
        public bool IsFullNameNull()
        {
            return this.IsNull(_tableUser.FullNameColumn);
        }
        public void SetFullNameNull()
        {
            this[_tableUser.FullNameColumn] = Convert.DBNull;
        }
        public DateTime BirthDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableUser.BirthDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BirthDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.BirthDateColumn] = value;
            }
        }
        public bool IsBirthDateNull()
        {
            return this.IsNull(_tableUser.BirthDateColumn);
        }
        public void SetBirthDateNull()
        {
            this[_tableUser.BirthDateColumn] = Convert.DBNull;
        }
        public string IDNumber
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.IDNumberColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IDNumber because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.IDNumberColumn] = value;
            }
        }
        public bool IsIDNumberNull()
        {
            return this.IsNull(_tableUser.IDNumberColumn);
        }
        public void SetIDNumberNull()
        {
            this[_tableUser.IDNumberColumn] = Convert.DBNull;
        }
        public string Address
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.AddressColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Address because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.AddressColumn] = value;
            }
        }
        public bool IsAddressNull()
        {
            return this.IsNull(_tableUser.AddressColumn);
        }
        public void SetAddressNull()
        {
            this[_tableUser.AddressColumn] = Convert.DBNull;
        }
        public string Phone
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.PhoneColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Phone because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.PhoneColumn] = value;
            }
        }
        public bool IsPhoneNull()
        {
            return this.IsNull(_tableUser.PhoneColumn);
        }
        public void SetPhoneNull()
        {
            this[_tableUser.PhoneColumn] = Convert.DBNull;
        }
        public string Email
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUser.EmailColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Email because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.EmailColumn] = value;
            }
        }
        public bool IsEmailNull()
        {
            return this.IsNull(_tableUser.EmailColumn);
        }
        public void SetEmailNull()
        {
            this[_tableUser.EmailColumn] = Convert.DBNull;
        }
        public bool Permission
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableUser.PermissionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Permission because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.PermissionColumn] = value;
            }
        }
        public bool IsPermissionNull()
        {
            return this.IsNull(_tableUser.PermissionColumn);
        }
        public void SetPermissionNull()
        {
            this[_tableUser.PermissionColumn] = Convert.DBNull;
        }
        public bool VirtualData
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableUser.VirtualDataColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value VirtualData because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.VirtualDataColumn] = value;
            }
        }
        public bool IsVirtualDataNull()
        {
            return this.IsNull(_tableUser.VirtualDataColumn);
        }
        public void SetVirtualDataNull()
        {
            this[_tableUser.VirtualDataColumn] = Convert.DBNull;
        }
        public byte GroupID
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableUser.GroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value GroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUser.GroupIDColumn] = value;
            }
        }
        public bool IsGroupIDNull()
        {
            return this.IsNull(_tableUser.GroupIDColumn);
        }
        public void SetGroupIDNull()
        {
            this[_tableUser.GroupIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
