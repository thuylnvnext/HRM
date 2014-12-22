using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class BankAccountTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnBankID;
        private DataColumn _columnAccountNumber;
        private DataColumn _columnNote;

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

            _columnBankID = new DataColumn("BankID", typeof(string));
            _columnBankID.AllowDBNull = false;
            _columnBankID.Caption = "Bank ID";
            _columnBankID.MaxLength = 50;
            _columnBankID.Unique = false;
            _columnBankID.DefaultValue = Convert.DBNull;
            _columnBankID.ExtendedProperties.Add("IsKey", "true");
            _columnBankID.ExtendedProperties.Add("ReadOnly", "false");
            _columnBankID.ExtendedProperties.Add("Description", "Bank Name");
            _columnBankID.ExtendedProperties.Add("Length", "50");
            _columnBankID.ExtendedProperties.Add("Decimals", "0");
            _columnBankID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnBankID);

            _columnAccountNumber = new DataColumn("AccountNumber", typeof(string));
            _columnAccountNumber.AllowDBNull = true;
            _columnAccountNumber.Caption = "Account Number";
            _columnAccountNumber.MaxLength = 30;
            _columnAccountNumber.Unique = false;
            _columnAccountNumber.DefaultValue = Convert.DBNull;
            _columnAccountNumber.ExtendedProperties.Add("IsKey", "false");
            _columnAccountNumber.ExtendedProperties.Add("ReadOnly", "false");
            _columnAccountNumber.ExtendedProperties.Add("Description", "Account Number");
            _columnAccountNumber.ExtendedProperties.Add("Length", "30");
            _columnAccountNumber.ExtendedProperties.Add("Decimals", "0");
            _columnAccountNumber.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnAccountNumber);

            _columnNote = new DataColumn("Note", typeof(string));
            _columnNote.AllowDBNull = true;
            _columnNote.Caption = "Note";
            _columnNote.MaxLength = 250;
            _columnNote.Unique = false;
            _columnNote.DefaultValue = Convert.DBNull;
            _columnNote.ExtendedProperties.Add("IsKey", "false");
            _columnNote.ExtendedProperties.Add("ReadOnly", "false");
            _columnNote.ExtendedProperties.Add("Description", "Note");
            _columnNote.ExtendedProperties.Add("Length", "250");
            _columnNote.ExtendedProperties.Add("Decimals", "0");
            _columnNote.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNote);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["BankID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public BankAccountTable()
            : base("BankAccount")
        {
            this.InitClass();
        }
        public BankAccountTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("BankAccount_GetContent", Connection.GetConnection());
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
        public static BankAccountTable GetContentTable()
        {
            BankAccountTable bankAccountTable = new BankAccountTable();
            bankAccountTable.GetContent();
            return bankAccountTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("BankAccount_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@BankID", SqlDbType.NVarChar, 50, "BankID");
            sqlCommand.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 30, "AccountNumber");
            sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250, "Note");

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
            SqlCommand sqlCommand = new SqlCommand("BankAccount_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalBankID", SqlDbType.NVarChar, 50, "BankID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@BankID", SqlDbType.NVarChar, 50, "BankID");
            sqlCommand.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 30, "AccountNumber");
            sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250, "Note");

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
            SqlCommand sqlCommand = new SqlCommand("BankAccount_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@BankID", SqlDbType.NVarChar, 50, "BankID");

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
        public bool Delete(int employeeID, string bankID)
        {
            bool retVal;

            BankAccountRow row = FindByPrimaryKey(employeeID, bankID);
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
        public DataColumn BankIDColumn
        {
            get
            {
                return _columnBankID;
            }
        }
        public DataColumn AccountNumberColumn
        {
            get
            {
                return _columnAccountNumber;
            }
        }
        public DataColumn NoteColumn
        {
            get
            {
                return _columnNote;
            }
        }
        public BankAccountRow this[int index]
        {
            get
            {
                return ((BankAccountRow)(this.Rows[index]));
            }
        }
        public void AddBankAccountRow(BankAccountRow row)
        {
            this.Rows.Add(row);
        }
        public BankAccountRow AddBankAccountRow(int employeeID, string bankID, string accountNumber, string note)
        {
            BankAccountRow rowBankAccountRow = ((BankAccountRow)(this.NewRow()));
            rowBankAccountRow["EmployeeID"] = employeeID;
            rowBankAccountRow["BankID"] = bankID;
            rowBankAccountRow["AccountNumber"] = accountNumber;
            rowBankAccountRow["Note"] = note;
            this.Rows.Add(rowBankAccountRow);
            return rowBankAccountRow;
        }
        public BankAccountRow FindByPrimaryKey(int employeeID, string bankID)
        {
            return (BankAccountRow)(Rows.Find(new object[] { employeeID, bankID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new BankAccountRow(builder);
        }
        public void GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("BankAccount_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
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
        }
        #endregion
    }

    public class BankAccountRow : DataRow
    {
        private BankAccountTable _tableBankAccount;

        internal BankAccountRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableBankAccount = ((BankAccountTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableBankAccount.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBankAccount.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableBankAccount.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableBankAccount.EmployeeIDColumn] = Convert.DBNull;
        }
        public string BankID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableBankAccount.BankIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BankID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBankAccount.BankIDColumn] = value;
            }
        }
        public bool IsBankIDNull()
        {
            return this.IsNull(_tableBankAccount.BankIDColumn);
        }
        public void SetBankIDNull()
        {
            this[_tableBankAccount.BankIDColumn] = Convert.DBNull;
        }
        public string AccountNumber
        {
            get
            {
                try
                {
                    return ((string)(this[_tableBankAccount.AccountNumberColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AccountNumber because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBankAccount.AccountNumberColumn] = value;
            }
        }
        public bool IsAccountNumberNull()
        {
            return this.IsNull(_tableBankAccount.AccountNumberColumn);
        }
        public void SetAccountNumberNull()
        {
            this[_tableBankAccount.AccountNumberColumn] = Convert.DBNull;
        }
        public string Note
        {
            get
            {
                try
                {
                    return ((string)(this[_tableBankAccount.NoteColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Note because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBankAccount.NoteColumn] = value;
            }
        }
        public bool IsNoteNull()
        {
            return this.IsNull(_tableBankAccount.NoteColumn);
        }
        public void SetNoteNull()
        {
            this[_tableBankAccount.NoteColumn] = Convert.DBNull;
        }
        #endregion
    }
}
