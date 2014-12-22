using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class PositionTable : DataTable, IEnumerable, IListTable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnNameE;

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
            _columnName.MaxLength = 50;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "50");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            _columnNameE = new DataColumn("NameE", typeof(string));
            _columnNameE.AllowDBNull = true;
            _columnNameE.Caption = "Name E";
            _columnNameE.MaxLength = 50;
            _columnNameE.Unique = false;
            _columnNameE.DefaultValue = Convert.DBNull;
            _columnNameE.ExtendedProperties.Add("IsKey", "false");
            _columnNameE.ExtendedProperties.Add("ReadOnly", "false");
            _columnNameE.ExtendedProperties.Add("Description", "Name E");
            _columnNameE.ExtendedProperties.Add("Length", "50");
            _columnNameE.ExtendedProperties.Add("Decimals", "0");
            _columnNameE.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNameE);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public PositionTable()
            : base("Position")
        {
            this.InitClass();
        }
        public PositionTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Position_GetContent", Connection.GetConnection());
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
        public static PositionTable GetContentTable(bool blank)
        {
            PositionTable positionTable = new PositionTable();
            if (blank) positionTable.AddPositionRow("-1", string.Empty, string.Empty);
            positionTable.GetContent();
            return positionTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Position_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@NameE", SqlDbType.NVarChar, 50, "NameE");

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
            SqlCommand sqlCommand = new SqlCommand("Position_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 50, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 50, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@NameE", SqlDbType.NVarChar, 50, "NameE");

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
            SqlCommand sqlCommand = new SqlCommand("Position_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
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

            PositionRow row = FindByPrimaryKey(iD);
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
        public DataColumn NameEColumn
        {
            get
            {
                return _columnName;
            }
        }
        public PositionRow this[int index]
        {
            get
            {
                return ((PositionRow)(this.Rows[index]));
            }
        }
        public void AddPositionRow(PositionRow row)
        {
            this.Rows.Add(row);
        }
        public PositionRow AddPositionRow(string iD, string name, string nameE)
        {
            PositionRow rowPositionRow = ((PositionRow)(this.NewRow()));
            rowPositionRow["ID"] = iD;
            rowPositionRow["Name"] = name;
            rowPositionRow["NameE"] = nameE;
            this.Rows.Add(rowPositionRow);
            return rowPositionRow;
        }
        public PositionRow FindByPrimaryKey(string iD)
        {
            return (PositionRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new PositionRow(builder);
        }
        public DataColumnCollection GetColumns()
        {
            return Columns;
        }
        public static string GetIDByName(string name)
        {
            SqlCommand sqlCommand = new SqlCommand("Position_GetIDByName", Connection.GetConnection());
            string retVal = string.Empty;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = name;

            try
            {
                Connection.Open();
                retVal = Convert.ToString(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = string.Empty;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        #endregion
    }

    public class PositionRow : DataRow
    {
        private PositionTable _tablePosition;

        internal PositionRow(DataRowBuilder rb)
            : base(rb)
        {
            _tablePosition = ((PositionTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePosition.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePosition.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tablePosition.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tablePosition.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePosition.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePosition.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tablePosition.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tablePosition.NameColumn] = Convert.DBNull;
        }
        public string NameE
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePosition.NameEColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name E because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePosition.NameEColumn] = value;
            }
        }
        public bool IsNameENull()
        {
            return this.IsNull(_tablePosition.NameColumn);
        }
        public void SetNameENull()
        {
            this[_tablePosition.NameEColumn] = Convert.DBNull;
        }
        #endregion
    }
}
