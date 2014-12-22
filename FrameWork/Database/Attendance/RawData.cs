using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RawDataTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnReaderID;
        private DataColumn _columnEnrollNumber;
        private DataColumn _columnSwipedDate;
        private DataColumn _columnStatus;
        private DataColumn _columnUsed;

        private void InitClass()
        {
            _columnReaderID = new DataColumn("ReaderID", typeof(string));
            _columnReaderID.AllowDBNull = true;
            _columnReaderID.Caption = "Reader ID";
            _columnReaderID.MaxLength = 15;
            _columnReaderID.Unique = false;
            _columnReaderID.DefaultValue = Convert.DBNull;
            _columnReaderID.ExtendedProperties.Add("IsKey", "false");
            _columnReaderID.ExtendedProperties.Add("ReadOnly", "false");
            _columnReaderID.ExtendedProperties.Add("Description", "Reader ID");
            _columnReaderID.ExtendedProperties.Add("Length", "15");
            _columnReaderID.ExtendedProperties.Add("Decimals", "0");
            _columnReaderID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnReaderID);

            _columnEnrollNumber = new DataColumn("EnrollNumber", typeof(int));
            _columnEnrollNumber.AllowDBNull = false;
            _columnEnrollNumber.Caption = "Enroll Number";
            _columnEnrollNumber.Unique = false;
            _columnEnrollNumber.DefaultValue = Convert.DBNull;
            _columnEnrollNumber.ExtendedProperties.Add("IsKey", "true");
            _columnEnrollNumber.ExtendedProperties.Add("ReadOnly", "false");
            _columnEnrollNumber.ExtendedProperties.Add("Description", "Enroll Number");
            _columnEnrollNumber.ExtendedProperties.Add("Decimals", "0");
            _columnEnrollNumber.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnEnrollNumber);

            _columnSwipedDate = new DataColumn("SwipedDate", typeof(DateTime));
            _columnSwipedDate.AllowDBNull = false;
            _columnSwipedDate.Caption = "Swiped Date";
            _columnSwipedDate.Unique = false;
            _columnSwipedDate.DefaultValue = Convert.DBNull;
            _columnSwipedDate.ExtendedProperties.Add("IsKey", "true");
            _columnSwipedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnSwipedDate.ExtendedProperties.Add("Description", "Swiped Date");
            _columnSwipedDate.ExtendedProperties.Add("Decimals", "0");
            _columnSwipedDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnSwipedDate);

            _columnStatus = new DataColumn("Status", typeof(bool));
            _columnStatus.AllowDBNull = true;
            _columnStatus.Caption = "Status";
            _columnStatus.Unique = false;
            _columnStatus.DefaultValue = Convert.DBNull;
            _columnStatus.ExtendedProperties.Add("IsKey", "false");
            _columnStatus.ExtendedProperties.Add("ReadOnly", "false");
            _columnStatus.ExtendedProperties.Add("Description", "Status");
            _columnStatus.ExtendedProperties.Add("Decimals", "0");
            _columnStatus.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnStatus);

            _columnUsed = new DataColumn("Used", typeof(bool));
            _columnUsed.AllowDBNull = true;
            _columnUsed.Caption = "Used";
            _columnUsed.Unique = false;
            _columnUsed.DefaultValue = Convert.DBNull;
            _columnUsed.ExtendedProperties.Add("IsKey", "false");
            _columnUsed.ExtendedProperties.Add("ReadOnly", "false");
            _columnUsed.ExtendedProperties.Add("Description", "Used");
            _columnUsed.ExtendedProperties.Add("Decimals", "0");
            _columnUsed.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnUsed);

            this.PrimaryKey = new DataColumn[] { this.Columns["EnrollNumber"], this.Columns["SwipedDate"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public RawDataTable()
            : base("RawData")
        {
            this.InitClass();
        }
        public RawDataTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RawData_GetContent", Connection.GetConnection());
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
        public static RawDataTable GetContentTable()
        {
            RawDataTable rawDataTable = new RawDataTable();
            rawDataTable.GetContent();
            return rawDataTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RawData_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ReaderID", SqlDbType.VarChar, 15, "ReaderID");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8, "SwipedDate");
            sqlCommand.Parameters.Add("@Status", SqlDbType.Bit, 1, "Status");
            sqlCommand.Parameters.Add("@Used", SqlDbType.Bit, 1, "Used");

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
            SqlCommand sqlCommand = new SqlCommand("RawData_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEnrollNumber", SqlDbType.Int, 4, "EnrollNumber").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalSwipedDate", SqlDbType.DateTime, 8, "SwipedDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ReaderID", SqlDbType.VarChar, 15, "ReaderID");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8, "SwipedDate");
            sqlCommand.Parameters.Add("@Status", SqlDbType.Bit, 1, "Status");
            sqlCommand.Parameters.Add("@Used", SqlDbType.Bit, 1, "Used");

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
            SqlCommand sqlCommand = new SqlCommand("RawData_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8, "SwipedDate");

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
        public bool Delete(int enrollNumber, DateTime swipedDate)
        {
            bool retVal;

            RawDataRow row = FindByPrimaryKey(enrollNumber, swipedDate);
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
        public DataColumn ReaderIDColumn
        {
            get
            {
                return _columnReaderID;
            }
        }
        public DataColumn EnrollNumberColumn
        {
            get
            {
                return _columnEnrollNumber;
            }
        }
        public DataColumn SwipedDateColumn
        {
            get
            {
                return _columnSwipedDate;
            }
        }
        public DataColumn StatusColumn
        {
            get
            {
                return _columnStatus;
            }
        }
        public DataColumn UsedColumn
        {
            get
            {
                return _columnUsed;
            }
        }
        public RawDataRow this[int index]
        {
            get
            {
                return ((RawDataRow)(this.Rows[index]));
            }
        }
        public void AddRawDataRow(RawDataRow row)
        {
            this.Rows.Add(row);
        }
        public RawDataRow AddRawDataRow(string readerID, int enrollNumber, DateTime swipedDate, bool status, bool used)
        {
            RawDataRow rowRawDataRow = ((RawDataRow)(this.NewRow()));
            rowRawDataRow["ReaderID"] = readerID;
            rowRawDataRow["EnrollNumber"] = enrollNumber;
            rowRawDataRow["SwipedDate"] = swipedDate;
            rowRawDataRow["Status"] = status;
            rowRawDataRow["Used"] = used;
            this.Rows.Add(rowRawDataRow);
            return rowRawDataRow;
        }
        public RawDataRow FindByPrimaryKey(int enrollNumber, DateTime swipedDate)
        {
            return (RawDataRow)(Rows.Find(new object[] { enrollNumber, swipedDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RawDataRow(builder);
        }
        public static bool InsertValue(int employeeID, DateTime originalSwipedDate, DateTime swipedDate, bool status, bool used)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("RawData_InsertValue", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@OriginalSwipedDate", SqlDbType.DateTime, 8).Value = originalSwipedDate;
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8).Value = swipedDate;
            sqlCommand.Parameters.Add("@Status", SqlDbType.Bit, 1).Value = status;
            sqlCommand.Parameters.Add("@Used", SqlDbType.Bit, 1).Value = used;

            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public static bool Delete(int employeeID, DateTime workingDay, bool all)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("RawData_Delete", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@All", SqlDbType.Bit).Value = all;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public static bool GetTimeInTimeOut(int employeeID, DateTime swipedDate, bool in_)
        {
            bool retVal = true;
            int enrollNumber = CardTable.GetEnrollNumberByEmployeeID(employeeID, swipedDate);
            SqlCommand sqlCommand = new SqlCommand("RawData_GetTimeInTimeOut", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4).Value = enrollNumber;
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime, 8).Value = swipedDate;
            sqlCommand.CommandTimeout = 0;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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

        public static bool ProcessReset(Int32 EmployeeID, DateTime WorkingDay)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("RawData_ProcessReset", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeID;
            sqlCommand.Parameters.Add("@SwipedDate", SqlDbType.DateTime).Value = WorkingDay;
            sqlCommand.CommandTimeout = 0;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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

        public static bool Reset(string employeeListID, DateTime fromDate, DateTime toDate)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("RawData_Reset", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeListID;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.CommandTimeout = 0;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public int GetListByEmployeeID(int employeeID, DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("RawData_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.CommandTimeout = 0;
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
            return Count;
        }
        #endregion
    }

    public class RawDataRow : DataRow
    {
        private RawDataTable _tableRawData;

        internal RawDataRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRawData = ((RawDataTable)(this.Table));
        }

        #region Properties
        public string ReaderID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRawData.ReaderIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ReaderID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRawData.ReaderIDColumn] = value;
            }
        }
        public bool IsReaderIDNull()
        {
            return this.IsNull(_tableRawData.ReaderIDColumn);
        }
        public void SetReaderIDNull()
        {
            this[_tableRawData.ReaderIDColumn] = Convert.DBNull;
        }
        public int EnrollNumber
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRawData.EnrollNumberColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EnrollNumber because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRawData.EnrollNumberColumn] = value;
            }
        }
        public bool IsEnrollNumberNull()
        {
            return this.IsNull(_tableRawData.EnrollNumberColumn);
        }
        public void SetEnrollNumberNull()
        {
            this[_tableRawData.EnrollNumberColumn] = Convert.DBNull;
        }
        public DateTime SwipedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRawData.SwipedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SwipedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRawData.SwipedDateColumn] = value;
            }
        }
        public bool IsSwipedDateNull()
        {
            return this.IsNull(_tableRawData.SwipedDateColumn);
        }
        public void SetSwipedDateNull()
        {
            this[_tableRawData.SwipedDateColumn] = Convert.DBNull;
        }
        public bool Status
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableRawData.StatusColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Status because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRawData.StatusColumn] = value;
            }
        }
        public bool IsStatusNull()
        {
            return this.IsNull(_tableRawData.StatusColumn);
        }
        public void SetStatusNull()
        {
            this[_tableRawData.StatusColumn] = Convert.DBNull;
        }
        public bool Used
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableRawData.UsedColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Used because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRawData.UsedColumn] = value;
            }
        }
        public bool IsUsedNull()
        {
            return this.IsNull(_tableRawData.UsedColumn);
        }
        public void SetUsedNull()
        {
            this[_tableRawData.UsedColumn] = Convert.DBNull;
        }
        #endregion
    }
}
