using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class DayOffGroupTable : DataTable, IEnumerable, IListTable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnCode;
        private DataColumn _columnColor;

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

            _columnCode = new DataColumn("Code", typeof(string));
            _columnCode.AllowDBNull = true;
            _columnCode.Caption = "Code";
            _columnCode.MaxLength = 10;
            _columnCode.Unique = false;
            _columnCode.DefaultValue = Convert.DBNull;
            _columnCode.ExtendedProperties.Add("IsKey", "false");
            _columnCode.ExtendedProperties.Add("ReadOnly", "false");
            _columnCode.ExtendedProperties.Add("Description", "Code");
            _columnCode.ExtendedProperties.Add("Length", "10");
            _columnCode.ExtendedProperties.Add("Decimals", "0");
            _columnCode.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCode);

            _columnColor = new DataColumn("Color", typeof(int));
            _columnColor.AllowDBNull = true;
            _columnColor.Caption = "Color";
            _columnColor.Unique = false;
            _columnColor.DefaultValue = Convert.DBNull;
            _columnColor.ExtendedProperties.Add("IsKey", "false");
            _columnColor.ExtendedProperties.Add("ReadOnly", "false");
            _columnColor.ExtendedProperties.Add("Description", "Color");
            _columnColor.ExtendedProperties.Add("Decimals", "0");
            _columnColor.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnColor);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public DayOffGroupTable()
            : base("DayOffGroup")
        {
            this.InitClass();
        }
        public DayOffGroupTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("DayOffGroup_GetContent", Connection.GetConnection());
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
        public static DayOffGroupTable GetContentTable()
        {
            DayOffGroupTable dayOffGroupTable = new DayOffGroupTable();
            dayOffGroupTable.GetContent();
            return dayOffGroupTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("DayOffGroup_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Code", SqlDbType.VarChar, 10, "Code");
            sqlCommand.Parameters.Add("@Color", SqlDbType.Int, 4, "Color");

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
            SqlCommand sqlCommand = new SqlCommand("DayOffGroup_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Code", SqlDbType.VarChar, 10, "Code");
            sqlCommand.Parameters.Add("@Color", SqlDbType.Int, 4, "Color");

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
            SqlCommand sqlCommand = new SqlCommand("DayOffGroup_Delete", Connection.GetConnection());
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

            DayOffGroupRow row = FindByPrimaryKey(iD);
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
        public DataColumn CodeColumn
        {
            get
            {
                return _columnCode;
            }
        }
        public DataColumn ColorColumn
        {
            get
            {
                return _columnColor;
            }
        }
        public DayOffGroupRow this[int index]
        {
            get
            {
                return ((DayOffGroupRow)(this.Rows[index]));
            }
        }
        public void AddDayOffGroupRow(DayOffGroupRow row)
        {
            this.Rows.Add(row);
        }
        public DayOffGroupRow AddDayOffGroupRow(string iD, string name, string code, int color)
        {
            DayOffGroupRow rowDayOffGroupRow = ((DayOffGroupRow)(this.NewRow()));
            rowDayOffGroupRow["ID"] = iD;
            rowDayOffGroupRow["Name"] = name;
            rowDayOffGroupRow["Code"] = code;
            rowDayOffGroupRow["Color"] = color;
            this.Rows.Add(rowDayOffGroupRow);
            return rowDayOffGroupRow;
        }
        public DayOffGroupRow FindByPrimaryKey(string iD)
        {
            return (DayOffGroupRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new DayOffGroupRow(builder);
        }
        public DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class DayOffGroupRow : DataRow
    {
        private DayOffGroupTable _tableDayOffGroup;

        internal DayOffGroupRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableDayOffGroup = ((DayOffGroupTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDayOffGroup.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDayOffGroup.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableDayOffGroup.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableDayOffGroup.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDayOffGroup.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDayOffGroup.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableDayOffGroup.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableDayOffGroup.NameColumn] = Convert.DBNull;
        }
        public string Code
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDayOffGroup.CodeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Code because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDayOffGroup.CodeColumn] = value;
            }
        }
        public bool IsCodeNull()
        {
            return this.IsNull(_tableDayOffGroup.CodeColumn);
        }
        public void SetCodeNull()
        {
            this[_tableDayOffGroup.CodeColumn] = Convert.DBNull;
        }
        public int Color
        {
            get
            {
                try
                {
                    return ((int)(this[_tableDayOffGroup.ColorColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Color because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDayOffGroup.ColorColumn] = value;
            }
        }
        public bool IsColorNull()
        {
            return this.IsNull(_tableDayOffGroup.ColorColumn);
        }
        public void SetColorNull()
        {
            this[_tableDayOffGroup.ColorColumn] = Convert.DBNull;
        }
        #endregion
    }
}
