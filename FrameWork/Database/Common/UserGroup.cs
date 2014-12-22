using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class UserGroupTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnDescription;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(byte));
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
            _columnName.AllowDBNull = true;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 15;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "15");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            _columnDescription = new DataColumn("Description", typeof(string));
            _columnDescription.AllowDBNull = true;
            _columnDescription.Caption = "Description";
            _columnDescription.MaxLength = 100;
            _columnDescription.Unique = false;
            _columnDescription.DefaultValue = Convert.DBNull;
            _columnDescription.ExtendedProperties.Add("IsKey", "false");
            _columnDescription.ExtendedProperties.Add("ReadOnly", "false");
            _columnDescription.ExtendedProperties.Add("Description", "Description");
            _columnDescription.ExtendedProperties.Add("Length", "100");
            _columnDescription.ExtendedProperties.Add("Decimals", "0");
            _columnDescription.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDescription);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        #endregion

        #region Constructors
        public UserGroupTable()
            : base("UserGroup")
        {
            this.InitClass();
        }
        public UserGroupTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("UserGroup_GetContent", Connection.GetConnection());
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
        public static UserGroupTable GetContentTable()
        {
            UserGroupTable userGroupTable = new UserGroupTable();
            userGroupTable.GetContent();
            return userGroupTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("UserGroup_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.TinyInt, 1, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 15, "Name");
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 100, "Description");

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
            SqlCommand sqlCommand = new SqlCommand("UserGroup_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.TinyInt, 1, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.TinyInt, 1, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 15, "Name");
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 100, "Description");

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
            SqlCommand sqlCommand = new SqlCommand("UserGroup_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.TinyInt, 1, "ID");

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
        public bool Delete(byte iD)
        {
            bool retVal;

            UserGroupRow row = FindByPrimaryKey(iD);
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
        public DataColumn DescriptionColumn
        {
            get
            {
                return _columnDescription;
            }
        }
        public UserGroupRow this[int index]
        {
            get
            {
                return ((UserGroupRow)(this.Rows[index]));
            }
        }
        public void AddUserGroupRow(UserGroupRow row)
        {
            this.Rows.Add(row);
        }
        public UserGroupRow AddUserGroupRow(byte iD, string name, string description)
        {
            UserGroupRow rowUserGroupRow = ((UserGroupRow)(this.NewRow()));
            rowUserGroupRow["ID"] = iD;
            rowUserGroupRow["Name"] = name;
            rowUserGroupRow["Description"] = description;
            this.Rows.Add(rowUserGroupRow);
            return rowUserGroupRow;
        }
        public UserGroupRow FindByPrimaryKey(byte iD)
        {
            return (UserGroupRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new UserGroupRow(builder);
        }
        public int GetInfoByUserName(string userName)
        {
            SqlCommand sqlCommand = new SqlCommand("UserGroup_GetInfoByUserName", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = userName;

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

    public class UserGroupRow : DataRow
    {
        private UserGroupTable _tableUserGroup;

        internal UserGroupRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableUserGroup = ((UserGroupTable)(this.Table));
        }

        #region Properties
        public byte ID
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableUserGroup.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUserGroup.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableUserGroup.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableUserGroup.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUserGroup.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUserGroup.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableUserGroup.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableUserGroup.NameColumn] = Convert.DBNull;
        }
        public string Description
        {
            get
            {
                try
                {
                    return ((string)(this[_tableUserGroup.DescriptionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Description because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableUserGroup.DescriptionColumn] = value;
            }
        }
        public bool IsDescriptionNull()
        {
            return this.IsNull(_tableUserGroup.DescriptionColumn);
        }
        public void SetDescriptionNull()
        {
            this[_tableUserGroup.DescriptionColumn] = Convert.DBNull;
        }
        #endregion
    }
}
