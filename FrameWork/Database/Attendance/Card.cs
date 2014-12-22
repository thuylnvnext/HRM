using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class CardTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnID;
        private DataColumn _columnEnrollNumber;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;

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

            _columnID = new DataColumn("ID", typeof(string));
            _columnID.AllowDBNull = true;
            _columnID.Caption = "ID";
            _columnID.MaxLength = 20;
            _columnID.Unique = false;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "false");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
            _columnID.ExtendedProperties.Add("Length", "20");
            _columnID.ExtendedProperties.Add("Decimals", "0");
            _columnID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnID);

            _columnEnrollNumber = new DataColumn("EnrollNumber", typeof(int));
            _columnEnrollNumber.AllowDBNull = true;
            _columnEnrollNumber.Caption = "Enroll Number";
            _columnEnrollNumber.Unique = false;
            _columnEnrollNumber.DefaultValue = Convert.DBNull;
            _columnEnrollNumber.ExtendedProperties.Add("IsKey", "false");
            _columnEnrollNumber.ExtendedProperties.Add("ReadOnly", "false");
            _columnEnrollNumber.ExtendedProperties.Add("Description", "Enroll Number");
            _columnEnrollNumber.ExtendedProperties.Add("Decimals", "0");
            _columnEnrollNumber.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnEnrollNumber);

            _columnFromDate = new DataColumn("FromDate", typeof(DateTime));
            _columnFromDate.AllowDBNull = false;
            _columnFromDate.Caption = "From Date";
            _columnFromDate.Unique = false;
            _columnFromDate.DefaultValue = Convert.DBNull;
            _columnFromDate.ExtendedProperties.Add("IsKey", "true");
            _columnFromDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnFromDate.ExtendedProperties.Add("Description", "From Date");
            _columnFromDate.ExtendedProperties.Add("Decimals", "0");
            _columnFromDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFromDate);

            _columnToDate = new DataColumn("ToDate", typeof(DateTime));
            _columnToDate.AllowDBNull = true;
            _columnToDate.Caption = "To Date";
            _columnToDate.Unique = false;
            _columnToDate.DefaultValue = Convert.DBNull;
            _columnToDate.ExtendedProperties.Add("IsKey", "false");
            _columnToDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnToDate.ExtendedProperties.Add("Description", "To Date");
            _columnToDate.ExtendedProperties.Add("Decimals", "0");
            _columnToDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnToDate);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public CardTable()
            : base("Card")
        {
            this.InitClass();
        }
        public CardTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Card_GetContent", Connection.GetConnection());
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
        public static CardTable GetContentTable()
        {
            CardTable cardTable = new CardTable();
            cardTable.GetContent();
            return cardTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Card_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");

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
            SqlCommand sqlCommand = new SqlCommand("Card_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");

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
            SqlCommand sqlCommand = new SqlCommand("Card_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");

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
        public bool Delete(SqlConnection conn, SqlTransaction tran, int employeeID, DateTime fromDate)
        {
            bool retVal;

            CardRow row = FindByPrimaryKey(employeeID, fromDate);
            if (row != null)
            {
                row.Delete();
                retVal = Delete(conn, tran);
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
        public DataColumn IDColumn
        {
            get
            {
                return _columnID;
            }
        }
        public DataColumn EnrollNumberColumn
        {
            get
            {
                return _columnEnrollNumber;
            }
        }
        public DataColumn FromDateColumn
        {
            get
            {
                return _columnFromDate;
            }
        }
        public DataColumn ToDateColumn
        {
            get
            {
                return _columnToDate;
            }
        }
        public CardRow this[int index]
        {
            get
            {
                return ((CardRow)(this.Rows[index]));
            }
        }
        public void AddCardRow(CardRow row)
        {
            this.Rows.Add(row);
        }
        public CardRow AddCardRow(int employeeID, string iD, int enrollNumber, DateTime fromDate, DateTime toDate)
        {
            CardRow rowCardRow = ((CardRow)(this.NewRow()));
            rowCardRow["EmployeeID"] = employeeID;
            rowCardRow["ID"] = iD;
            rowCardRow["EnrollNumber"] = enrollNumber;
            rowCardRow["FromDate"] = fromDate;
            rowCardRow["ToDate"] = toDate;
            this.Rows.Add(rowCardRow);
            return rowCardRow;
        }
        public CardRow FindByPrimaryKey(int employeeID, DateTime fromDate)
        {
            return (CardRow)(Rows.Find(new object[] { employeeID, fromDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new CardRow(builder);
        }
        public int GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;

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
        public static bool CheckExist(string iD, DateTime fromDate)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_CheckExist", Connection.GetConnection());
            bool retVal = false;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = iD;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;

            try
            {
                Connection.Open();
                retVal = Convert.ToBoolean(sqlCommand.ExecuteScalar());
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
        public static int GetNewEnrollNumber(DateTime fromDate)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_GetNewEnrollNumber", Connection.GetConnection());
            int retVal = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;

            try
            {
                Connection.Open();
                retVal = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = 0;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public bool Insert(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_Insert", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");

            sqlDataAdapter.InsertCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
            }
            return retVal;
        }
        public bool Update(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_Update", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalCardID", SqlDbType.VarChar, 20, "CardID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@CardID", SqlDbType.VarChar, 20, "CardID");
            sqlCommand.Parameters.Add("@EnrollNumber", SqlDbType.Int, 4, "EnrollNumber");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");

            sqlDataAdapter.UpdateCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
            }
            return retVal;
        }
        private bool Delete(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_Delete", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");

            sqlDataAdapter.DeleteCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
            }
            return retVal;
        }
        public static string GetInfoByEmployeeID(int employeeID, DateTime workingDay)
        {
            string cardID = string.Empty;
            SqlCommand sqlCommand = new SqlCommand("Card_GetInfoByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;

            try
            {
                Connection.Open();
                cardID = sqlCommand.ExecuteScalar().ToString();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return cardID;
        }
        public static int GetEnrollNumberByEmployeeID(int employeeID, DateTime workingDay)
        {
            SqlCommand sqlCommand = new SqlCommand("Card_GetEnrollNumberByEmployeeID", Connection.GetConnection());
            int retVal = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;

            try
            {
                Connection.Open();
                retVal = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = 0;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        #endregion
    }

    public class CardRow : DataRow
    {
        private CardTable _tableCard;

        internal CardRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableCard = ((CardTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableCard.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCard.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableCard.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableCard.EmployeeIDColumn] = Convert.DBNull;
        }
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableCard.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCard.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableCard.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableCard.IDColumn] = Convert.DBNull;
        }
        public int EnrollNumber
        {
            get
            {
                try
                {
                    return ((int)(this[_tableCard.EnrollNumberColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EnrollNumber because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCard.EnrollNumberColumn] = value;
            }
        }
        public bool IsEnrollNumberNull()
        {
            return this.IsNull(_tableCard.EnrollNumberColumn);
        }
        public void SetEnrollNumberNull()
        {
            this[_tableCard.EnrollNumberColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableCard.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCard.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableCard.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableCard.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableCard.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableCard.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableCard.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableCard.ToDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
