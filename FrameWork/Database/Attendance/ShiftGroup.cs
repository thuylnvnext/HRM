using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ShiftGroupTable : DataTable, IEnumerable, IListTable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(string));
            _columnID.AllowDBNull = false;
            _columnID.Caption = "ID";
            _columnID.MaxLength = 10;
            _columnID.Unique = true;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "true");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
            _columnID.ExtendedProperties.Add("Length", "10");
            _columnID.ExtendedProperties.Add("Decimals", "0");
            _columnID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnID);

            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = true;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 20;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "20");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public ShiftGroupTable()
            : base("ShiftGroup")
        {
            this.InitClass();
        }
        public ShiftGroupTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("ShiftGroup_GetContent", Connection.GetConnection());
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
        public static ShiftGroupTable GetContentTable()
        {
            ShiftGroupTable shiftGroupTable = new ShiftGroupTable();
            shiftGroupTable.GetContent();
            return shiftGroupTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("ShiftGroup_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 20, "Name");

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
            SqlCommand sqlCommand = new SqlCommand("ShiftGroup_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 20, "Name");

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
            SqlCommand sqlCommand = new SqlCommand("ShiftGroup_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");

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

            ShiftGroupRow row = FindByPrimaryKey(iD);
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
        public ShiftGroupRow this[int index]
        {
            get
            {
                return ((ShiftGroupRow)(this.Rows[index]));
            }
        }
        public void AddShiftGroupRow(ShiftGroupRow row)
        {
            this.Rows.Add(row);
        }
        public ShiftGroupRow AddShiftGroupRow(string iD, string name)
        {
            ShiftGroupRow rowShiftGroupRow = ((ShiftGroupRow)(this.NewRow()));
            rowShiftGroupRow["ID"] = iD;
            rowShiftGroupRow["Name"] = name;
            this.Rows.Add(rowShiftGroupRow);
            return rowShiftGroupRow;
        }
        public ShiftGroupRow FindByPrimaryKey(string iD)
        {
            return (ShiftGroupRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ShiftGroupRow(builder);
        }
        public DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class ShiftGroupRow : DataRow
    {
        private ShiftGroupTable _tableShiftGroup;

        internal ShiftGroupRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableShiftGroup = ((ShiftGroupTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableShiftGroup.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftGroup.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableShiftGroup.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableShiftGroup.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableShiftGroup.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftGroup.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableShiftGroup.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableShiftGroup.NameColumn] = Convert.DBNull;
        }
        #endregion
    }
}