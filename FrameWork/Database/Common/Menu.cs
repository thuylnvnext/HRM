using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class MenuTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnOwner;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(string));
            _columnID.AllowDBNull = false;
            _columnID.Caption = "ID";
            _columnID.MaxLength = 50;
            _columnID.Unique = true;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "true");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
            _columnID.ExtendedProperties.Add("Length", "50");
            _columnID.ExtendedProperties.Add("Decimals", "0");
            _columnID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnID);

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

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        #endregion

        #region Constructors
        public MenuTable()
            : base("Menu")
        {
            this.InitClass();
        }
        public MenuTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Menu_GetContent", Connection.GetConnection());
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
        public static MenuTable GetContentTable()
        {
            MenuTable menuTable = new MenuTable();
            menuTable.GetContent();
            return menuTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Menu_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 50, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            sqlCommand.Parameters.Add("@Owner", SqlDbType.VarChar, 50, "Owner");

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
            SqlCommand sqlCommand = new SqlCommand("Menu_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 50, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 50, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            sqlCommand.Parameters.Add("@Owner", SqlDbType.VarChar, 50, "Owner");

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
            SqlCommand sqlCommand = new SqlCommand("Menu_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 50, "ID");

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
        public bool Delete(string iD)
        {
            bool retVal;

            MenuRow row = FindByPrimaryKey(iD);
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
        public MenuRow this[int index]
        {
            get
            {
                return ((MenuRow)(this.Rows[index]));
            }
        }
        public void AddMenuRow(MenuRow row)
        {
            this.Rows.Add(row);
        }
        public MenuRow AddMenuRow(string iD, string name, string owner)
        {
            MenuRow rowMenuRow = ((MenuRow)(this.NewRow()));
            rowMenuRow["ID"] = iD;
            rowMenuRow["Name"] = name;
            rowMenuRow["Owner"] = owner;
            this.Rows.Add(rowMenuRow);
            return rowMenuRow;
        }
        public MenuRow FindByPrimaryKey(string iD)
        {
            return (MenuRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new MenuRow(builder);
        }
        #endregion
    }

    public class MenuRow : DataRow
    {
        private MenuTable _tableMenu;

        internal MenuRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableMenu = ((MenuTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMenu.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMenu.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableMenu.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableMenu.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMenu.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMenu.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableMenu.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableMenu.NameColumn] = Convert.DBNull;
        }
        public string Owner
        {
            get
            {
                try
                {
                    return ((string)(this[_tableMenu.OwnerColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Owner because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableMenu.OwnerColumn] = value;
            }
        }
        public bool IsOwnerNull()
        {
            return this.IsNull(_tableMenu.OwnerColumn);
        }
        public void SetOwnerNull()
        {
            this[_tableMenu.OwnerColumn] = Convert.DBNull;
        }
        #endregion
    }
}
