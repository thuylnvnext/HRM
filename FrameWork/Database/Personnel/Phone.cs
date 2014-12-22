using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class PhoneTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnPhoneTypeID;
        private DataColumn _columnNumber;

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

            _columnPhoneTypeID = new DataColumn("PhoneTypeID", typeof(string));
            _columnPhoneTypeID.AllowDBNull = false;
            _columnPhoneTypeID.Caption = "Phone Type ID";
            _columnPhoneTypeID.MaxLength = 10;
            _columnPhoneTypeID.Unique = false;
            _columnPhoneTypeID.DefaultValue = Convert.DBNull;
            _columnPhoneTypeID.ExtendedProperties.Add("IsKey", "true");
            _columnPhoneTypeID.ExtendedProperties.Add("ReadOnly", "false");
            _columnPhoneTypeID.ExtendedProperties.Add("Description", "Phone Type ID");
            _columnPhoneTypeID.ExtendedProperties.Add("Length", "10");
            _columnPhoneTypeID.ExtendedProperties.Add("Decimals", "0");
            _columnPhoneTypeID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnPhoneTypeID);

            _columnNumber = new DataColumn("Number", typeof(string));
            _columnNumber.AllowDBNull = true;
            _columnNumber.Caption = "Number";
            _columnNumber.MaxLength = 15;
            _columnNumber.Unique = false;
            _columnNumber.DefaultValue = Convert.DBNull;
            _columnNumber.ExtendedProperties.Add("IsKey", "false");
            _columnNumber.ExtendedProperties.Add("ReadOnly", "false");
            _columnNumber.ExtendedProperties.Add("Description", "Number");
            _columnNumber.ExtendedProperties.Add("Length", "15");
            _columnNumber.ExtendedProperties.Add("Decimals", "0");
            _columnNumber.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNumber);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["PhoneTypeID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public PhoneTable()
            : base("Phone")
        {
            this.InitClass();
        }
        public PhoneTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Phone_GetContent", Connection.GetConnection());
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
        public static PhoneTable GetContentTable()
        {
            PhoneTable phoneTable = new PhoneTable();
            phoneTable.GetContent();
            return phoneTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Phone_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@PhoneTypeID", SqlDbType.VarChar, 10, "PhoneTypeID");
            sqlCommand.Parameters.Add("@Number", SqlDbType.VarChar, 15, "Number");

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
            SqlCommand sqlCommand = new SqlCommand("Phone_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalPhoneTypeID", SqlDbType.VarChar, 10, "PhoneTypeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@PhoneTypeID", SqlDbType.VarChar, 10, "PhoneTypeID");
            sqlCommand.Parameters.Add("@Number", SqlDbType.VarChar, 15, "Number");

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
            SqlCommand sqlCommand = new SqlCommand("Phone_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@PhoneTypeID", SqlDbType.VarChar, 10, "PhoneTypeID");

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
        public bool Delete(int employeeID, string phoneTypeID)
        {
            bool retVal;

            PhoneRow row = FindByPrimaryKey(employeeID, phoneTypeID);
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
        public DataColumn PhoneTypeIDColumn
        {
            get
            {
                return _columnPhoneTypeID;
            }
        }
        public DataColumn NumberColumn
        {
            get
            {
                return _columnNumber;
            }
        }
        public PhoneRow this[int index]
        {
            get
            {
                return ((PhoneRow)(this.Rows[index]));
            }
        }
        public void AddPhoneRow(PhoneRow row)
        {
            this.Rows.Add(row);
        }
        public PhoneRow AddPhoneRow(int employeeID, string phoneTypeID, string number)
        {
            PhoneRow rowPhoneRow = ((PhoneRow)(this.NewRow()));
            rowPhoneRow["EmployeeID"] = employeeID;
            rowPhoneRow["PhoneTypeID"] = phoneTypeID;
            rowPhoneRow["Number"] = number;
            this.Rows.Add(rowPhoneRow);
            return rowPhoneRow;
        }
        public PhoneRow FindByPrimaryKey(int employeeID, string phoneTypeID)
        {
            return (PhoneRow)(Rows.Find(new object[] { employeeID, phoneTypeID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new PhoneRow(builder);
        }
        public void GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("Phone_GetListByEmployeeID", Connection.GetConnection());
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
        public static PhoneRow GetListByEmployeeIDAndType(int employeeID, string type)
        {
            PhoneTable phone = new PhoneTable();
            SqlCommand sqlCommand = new SqlCommand("Phone_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(phone);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            return phone.FindByPrimaryKey(employeeID, type);
        }
        #endregion
    }

    public class PhoneRow : DataRow
    {
        private PhoneTable _tablePhone;

        internal PhoneRow(DataRowBuilder rb)
            : base(rb)
        {
            _tablePhone = ((PhoneTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tablePhone.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePhone.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tablePhone.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tablePhone.EmployeeIDColumn] = Convert.DBNull;
        }
        public string PhoneTypeID
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePhone.PhoneTypeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PhoneTypeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePhone.PhoneTypeIDColumn] = value;
            }
        }
        public bool IsPhoneTypeIDNull()
        {
            return this.IsNull(_tablePhone.PhoneTypeIDColumn);
        }
        public void SetPhoneTypeIDNull()
        {
            this[_tablePhone.PhoneTypeIDColumn] = Convert.DBNull;
        }
        public string Number
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePhone.NumberColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Number because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePhone.NumberColumn] = value;
            }
        }
        public bool IsNumberNull()
        {
            return this.IsNull(_tablePhone.NumberColumn);
        }
        public void SetNumberNull()
        {
            this[_tablePhone.NumberColumn] = Convert.DBNull;
        }
        #endregion
    }
}
