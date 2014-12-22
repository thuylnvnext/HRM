using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ScheduleForGetDataTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnTime;

        private void InitClass()
        {
            _columnTime = new DataColumn("Time", typeof(DateTime));
            _columnTime.AllowDBNull = false;
            _columnTime.Caption = "Time";
            _columnTime.Unique = true;
            _columnTime.DefaultValue = Convert.DBNull;
            _columnTime.ExtendedProperties.Add("IsKey", "true");
            _columnTime.ExtendedProperties.Add("ReadOnly", "false");
            _columnTime.ExtendedProperties.Add("Description", "Time");
            _columnTime.ExtendedProperties.Add("Decimals", "0");
            _columnTime.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnTime);

            this.PrimaryKey = new DataColumn[] { this.Columns["Time"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public ScheduleForGetDataTable()
            : base("ScheduleForGetData")
        {
            this.InitClass();
        }
        public ScheduleForGetDataTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("ScheduleForGetData_GetContent", Connection.GetConnection());
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
        public static ScheduleForGetDataTable GetContentTable()
        {
            ScheduleForGetDataTable scheduleForGetDataTable = new ScheduleForGetDataTable();
            scheduleForGetDataTable.GetContent();
            return scheduleForGetDataTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("ScheduleForGetData_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Time", SqlDbType.DateTime, 8, "Time");

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
            SqlCommand sqlCommand = new SqlCommand("ScheduleForGetData_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalTime", SqlDbType.DateTime, 8, "Time").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@Time", SqlDbType.DateTime, 8, "Time");

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
            SqlCommand sqlCommand = new SqlCommand("ScheduleForGetData_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Time", SqlDbType.DateTime, 8, "Time");

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
        public bool Delete(DateTime time)
        {
            bool retVal;

            ScheduleForGetDataRow row = FindByPrimaryKey(time);
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
        public DataColumn TimeColumn
        {
            get
            {
                return _columnTime;
            }
        }
        public ScheduleForGetDataRow this[int index]
        {
            get
            {
                return ((ScheduleForGetDataRow)(this.Rows[index]));
            }
        }
        public void AddScheduleForGetDataRow(ScheduleForGetDataRow row)
        {
            this.Rows.Add(row);
        }
        public ScheduleForGetDataRow AddScheduleForGetDataRow(DateTime time)
        {
            ScheduleForGetDataRow rowScheduleForGetDataRow = ((ScheduleForGetDataRow)(this.NewRow()));
            rowScheduleForGetDataRow["Time"] = time;
            this.Rows.Add(rowScheduleForGetDataRow);
            return rowScheduleForGetDataRow;
        }
        public ScheduleForGetDataRow FindByPrimaryKey(DateTime time)
        {
            return (ScheduleForGetDataRow)(Rows.Find(new object[] { time }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ScheduleForGetDataRow(builder);
        }
        #endregion
    }

    public class ScheduleForGetDataRow : DataRow
    {
        private ScheduleForGetDataTable _tableScheduleForGetData;

        internal ScheduleForGetDataRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableScheduleForGetData = ((ScheduleForGetDataTable)(this.Table));
        }

        #region Properties
        public DateTime Time
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableScheduleForGetData.TimeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Time because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableScheduleForGetData.TimeColumn] = value;
            }
        }
        public bool IsTimeNull()
        {
            return this.IsNull(_tableScheduleForGetData.TimeColumn);
        }
        public void SetTimeNull()
        {
            this[_tableScheduleForGetData.TimeColumn] = Convert.DBNull;
        }
        #endregion
    }
}
