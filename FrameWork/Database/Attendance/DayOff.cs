using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class DayOffTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnDayOffGroupID;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(DateTime));
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

            _columnDayOffGroupID = new DataColumn("DayOffGroupID", typeof(string));
            _columnDayOffGroupID.AllowDBNull = true;
            _columnDayOffGroupID.Caption = "Day Off Group ID";
            _columnDayOffGroupID.MaxLength = 10;
            _columnDayOffGroupID.Unique = false;
            _columnDayOffGroupID.DefaultValue = Convert.DBNull;
            _columnDayOffGroupID.ExtendedProperties.Add("IsKey", "false");
            _columnDayOffGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDayOffGroupID.ExtendedProperties.Add("Description", "Day Off Group ID");
            _columnDayOffGroupID.ExtendedProperties.Add("Length", "10");
            _columnDayOffGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnDayOffGroupID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDayOffGroupID);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public DayOffTable()
            : base("DayOff")
        {
            this.InitClass();
        }
        public DayOffTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("DayOff_GetContent", Connection.GetConnection());
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
        public static DayOffTable GetContentTable()
        {
            DayOffTable dayOffTable = new DayOffTable();
            dayOffTable.GetContent();
            return dayOffTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("DayOff_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.DateTime, 8, "ID");
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10, "DayOffGroupID");

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
            SqlCommand sqlCommand = new SqlCommand("DayOff_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.DateTime, 8, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.DateTime, 8, "ID");
            sqlCommand.Parameters.Add("@DayOffGroupID", SqlDbType.VarChar, 10, "DayOffGroupID");

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
            SqlCommand sqlCommand = new SqlCommand("DayOff_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.DateTime, 8, "ID");

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
        public bool Delete(DateTime iD)
        {
            bool retVal;

            DayOffRow row = FindByPrimaryKey(iD);
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
        public DataColumn DayOffGroupIDColumn
        {
            get
            {
                return _columnDayOffGroupID;
            }
        }
        public DayOffRow this[int index]
        {
            get
            {
                return ((DayOffRow)(this.Rows[index]));
            }
        }
        public void AddDayOffRow(DayOffRow row)
        {
            this.Rows.Add(row);
        }
        public DayOffRow AddDayOffRow(DateTime iD, string dayOffGroupID)
        {
            DayOffRow rowDayOffRow = ((DayOffRow)(this.NewRow()));
            rowDayOffRow["ID"] = iD;
            rowDayOffRow["DayOffGroupID"] = dayOffGroupID;
            this.Rows.Add(rowDayOffRow);
            return rowDayOffRow;
        }
        public DayOffRow FindByPrimaryKey(DateTime iD)
        {
            return (DayOffRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new DayOffRow(builder);
        }
        #endregion
    }

    public class DayOffRow : DataRow
    {
        private DayOffTable _tableDayOff;

        internal DayOffRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableDayOff = ((DayOffTable)(this.Table));
        }

        #region Properties
        public DateTime ID
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableDayOff.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDayOff.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableDayOff.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableDayOff.IDColumn] = Convert.DBNull;
        }
        public string DayOffGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDayOff.DayOffGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DayOffGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDayOff.DayOffGroupIDColumn] = value;
            }
        }
        public bool IsDayOffGroupIDNull()
        {
            return this.IsNull(_tableDayOff.DayOffGroupIDColumn);
        }
        public void SetDayOffGroupIDNull()
        {
            this[_tableDayOff.DayOffGroupIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
