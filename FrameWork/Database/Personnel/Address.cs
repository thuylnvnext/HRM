using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AddressTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnAddressTypeID;
        private DataColumn _columnName;

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

            _columnAddressTypeID = new DataColumn("AddressTypeID", typeof(string));
            _columnAddressTypeID.AllowDBNull = false;
            _columnAddressTypeID.Caption = "Address Type ID";
            _columnAddressTypeID.MaxLength = 10;
            _columnAddressTypeID.Unique = false;
            _columnAddressTypeID.DefaultValue = Convert.DBNull;
            _columnAddressTypeID.ExtendedProperties.Add("IsKey", "true");
            _columnAddressTypeID.ExtendedProperties.Add("ReadOnly", "false");
            _columnAddressTypeID.ExtendedProperties.Add("Description", "Address Type ID");
            _columnAddressTypeID.ExtendedProperties.Add("Length", "10");
            _columnAddressTypeID.ExtendedProperties.Add("Decimals", "0");
            _columnAddressTypeID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnAddressTypeID);

            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = true;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 100;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "100");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["AddressTypeID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public AddressTable()
            : base("Address")
        {
            this.InitClass();
        }
        public AddressTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Address_GetContent", Connection.GetConnection());
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
        public static AddressTable GetContentTable()
        {
            AddressTable addressTable = new AddressTable();
            addressTable.GetContent();
            return addressTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Address_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@AddressTypeID", SqlDbType.VarChar, 10, "AddressTypeID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");

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
            SqlCommand sqlCommand = new SqlCommand("Address_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalAddressTypeID", SqlDbType.VarChar, 10, "AddressTypeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@AddressTypeID", SqlDbType.VarChar, 10, "AddressTypeID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");

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
            SqlCommand sqlCommand = new SqlCommand("Address_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@AddressTypeID", SqlDbType.VarChar, 10, "AddressTypeID");

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
        public bool Delete(int employeeID, string addressTypeID)
        {
            bool retVal;

            AddressRow row = FindByPrimaryKey(employeeID, addressTypeID);
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
        public DataColumn AddressTypeIDColumn
        {
            get
            {
                return _columnAddressTypeID;
            }
        }
        public DataColumn NameColumn
        {
            get
            {
                return _columnName;
            }
        }
        public AddressRow this[int index]
        {
            get
            {
                return ((AddressRow)(this.Rows[index]));
            }
        }
        public void AddAddressRow(AddressRow row)
        {
            this.Rows.Add(row);
        }
        public AddressRow AddAddressRow(int employeeID, string addressTypeID, string name)
        {
            AddressRow rowAddressRow = ((AddressRow)(this.NewRow()));
            rowAddressRow["EmployeeID"] = employeeID;
            rowAddressRow["AddressTypeID"] = addressTypeID;
            rowAddressRow["Name"] = name;
            this.Rows.Add(rowAddressRow);
            return rowAddressRow;
        }
        public AddressRow FindByPrimaryKey(int employeeID, string addressTypeID)
        {
            return (AddressRow)(Rows.Find(new object[] { employeeID, addressTypeID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AddressRow(builder);
        }
        public void GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("Address_GetListByEmployeeID", Connection.GetConnection());
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
        public static AddressRow GetListByEmployeeIDAndType(int employeeID, string type)
        {
            AddressTable address = new AddressTable();
            SqlCommand sqlCommand = new SqlCommand("Address_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(address);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            return address.FindByPrimaryKey(employeeID, type);
        }
        #endregion
    }

    public class AddressRow : DataRow
    {
        private AddressTable _tableAddress;

        internal AddressRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAddress = ((AddressTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableAddress.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAddress.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableAddress.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableAddress.EmployeeIDColumn] = Convert.DBNull;
        }
        public string AddressTypeID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAddress.AddressTypeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AddressTypeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAddress.AddressTypeIDColumn] = value;
            }
        }
        public bool IsAddressTypeIDNull()
        {
            return this.IsNull(_tableAddress.AddressTypeIDColumn);
        }
        public void SetAddressTypeIDNull()
        {
            this[_tableAddress.AddressTypeIDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAddress.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAddress.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableAddress.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableAddress.NameColumn] = Convert.DBNull;
        }
        #endregion
    }
}
