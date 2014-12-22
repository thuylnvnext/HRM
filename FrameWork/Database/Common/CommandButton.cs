using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class CommandButtonTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnOwner;
        private DataColumn _columnText;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(Guid));
            _columnID.AllowDBNull = false;
            _columnID.Caption = "ID";
            _columnID.Unique = true;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "true");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
            _columnID.ExtendedProperties.Add("Decimals", "0");
            _columnID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnID);

            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = false;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 50;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "50");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnName);

            _columnOwner = new DataColumn("Owner", typeof(string));
            _columnOwner.AllowDBNull = true;
            _columnOwner.Caption = "Owner";
            _columnOwner.MaxLength = 50;
            _columnOwner.Unique = false;
            _columnOwner.DefaultValue = Convert.DBNull;
            _columnOwner.ExtendedProperties.Add("IsKey", "false");
            _columnOwner.ExtendedProperties.Add("ReadOnly", "false");
            _columnOwner.ExtendedProperties.Add("Description", "Owner");
            _columnOwner.ExtendedProperties.Add("Length", "50");
            _columnOwner.ExtendedProperties.Add("Decimals", "0");
            _columnOwner.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnOwner);

            _columnText = new DataColumn("Text", typeof(string));
            _columnText.AllowDBNull = true;
            _columnText.Caption = "Text";
            _columnText.MaxLength = 100;
            _columnText.Unique = false;
            _columnText.DefaultValue = Convert.DBNull;
            _columnText.ExtendedProperties.Add("IsKey", "false");
            _columnText.ExtendedProperties.Add("ReadOnly", "false");
            _columnText.ExtendedProperties.Add("Description", "Text");
            _columnText.ExtendedProperties.Add("Length", "100");
            _columnText.ExtendedProperties.Add("Decimals", "0");
            _columnText.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnText);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        #endregion

        #region Constructors
        public CommandButtonTable()
            : base("CommandButton")
        {
            this.InitClass();
        }
        public CommandButtonTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("CommandButton_GetContent", Connection.GetConnection());
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
        public static CommandButtonTable GetContentTable()
        {
            CommandButtonTable commandButtonTable = new CommandButtonTable();
            commandButtonTable.GetContent();
            return commandButtonTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("CommandButton_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.UniqueIdentifier, 16, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Owner", SqlDbType.VarChar, 50, "Owner");
            sqlCommand.Parameters.Add("@Text", SqlDbType.NVarChar, 100, "Text");

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
            SqlCommand sqlCommand = new SqlCommand("CommandButton_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.UniqueIdentifier, 16, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.UniqueIdentifier, 16, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Owner", SqlDbType.VarChar, 50, "Owner");
            sqlCommand.Parameters.Add("@Text", SqlDbType.NVarChar, 100, "Text");

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
            SqlCommand sqlCommand = new SqlCommand("CommandButton_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.UniqueIdentifier, 16, "ID");

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
        public bool Delete(Guid iD)
        {
            bool retVal;

            CommandButtonRow row = FindByPrimaryKey(iD);
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
        public DataColumn IDColumn
        {
            get
            {
                return _columnID;
            }
        }
        public DataColumn NameColumn
        {
            get
            {
                return _columnName;
            }
        }
        public DataColumn OwnerColumn
        {
            get
            {
                return _columnOwner;
            }
        }
        public DataColumn TextColumn
        {
            get
            {
                return _columnText;
            }
        }
        public CommandButtonRow this[int index]
        {
            get
            {
                return ((CommandButtonRow)(this.Rows[index]));
            }
        }
        public void AddCommandButtonRow(CommandButtonRow row)
        {
            this.Rows.Add(row);
        }
        public CommandButtonRow AddCommandButtonRow(Guid iD, string name, string owner, string text)
        {
            CommandButtonRow rowCommandButtonRow = ((CommandButtonRow)(this.NewRow()));
            rowCommandButtonRow["ID"] = iD;
            rowCommandButtonRow["Name"] = name;
            rowCommandButtonRow["Owner"] = owner;
            rowCommandButtonRow["Text"] = text;
            this.Rows.Add(rowCommandButtonRow);
            return rowCommandButtonRow;
        }
        public CommandButtonRow FindByPrimaryKey(Guid iD)
        {
            return (CommandButtonRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new CommandButtonRow(builder);
        }
        public CommandButtonRow GetInfoByOwner(string owner)
        {
            CommandButtonRow cbr;
            SqlCommand sqlCommand = new SqlCommand("CommandButton_GetInfoByOwner", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Owner", SqlDbType.VarChar, 50).Value = owner;
            try
            {
                Connection.Open();
                cbr = (CommandButtonRow)(Rows.Find(sqlCommand.ExecuteScalar()));
            }
            catch
            {
                cbr = null;
            }
            finally
            {
                Connection.Close();
            }
            return cbr;
        }
        #endregion
    }

    public class CommandButtonRow : DataRow
    {
        private CommandButtonTable _tableCommandButton;

        internal CommandButtonRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableCommandButton = ((CommandButtonTable)(this.Table));
        }

        #region Properties
        public Guid ID
        {
            get
            {
                try
                {
                    return ((Guid)(this[_tableCommandButton.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCommandButton.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableCommandButton.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableCommandButton.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableCommandButton.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCommandButton.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableCommandButton.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableCommandButton.NameColumn] = Convert.DBNull;
        }
        public string Owner
        {
            get
            {
                try
                {
                    return ((string)(this[_tableCommandButton.OwnerColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Owner because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCommandButton.OwnerColumn] = value;
            }
        }
        public bool IsOwnerNull()
        {
            return this.IsNull(_tableCommandButton.OwnerColumn);
        }
        public void SetOwnerNull()
        {
            this[_tableCommandButton.OwnerColumn] = Convert.DBNull;
        }
        public string Text
        {
            get
            {
                try
                {
                    return ((string)(this[_tableCommandButton.TextColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Text because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCommandButton.TextColumn] = value;
            }
        }
        public bool IsTextNull()
        {
            return this.IsNull(_tableCommandButton.TextColumn);
        }
        public void SetTextNull()
        {
            this[_tableCommandButton.TextColumn] = Convert.DBNull;
        }
        #endregion
    }
}
