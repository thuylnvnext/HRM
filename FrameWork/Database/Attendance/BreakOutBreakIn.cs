using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class BreakOutBreakInTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnWorkingDay;
        private DataColumn _columnShiftID;
        private DataColumn _columnIOTimes;
        private DataColumn _columnBreakOut;
        private DataColumn _columnBreakIn;
        private DataColumn _columnReasonID;

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

            _columnWorkingDay = new DataColumn("WorkingDay", typeof(DateTime));
            _columnWorkingDay.AllowDBNull = false;
            _columnWorkingDay.Caption = "Working Day";
            _columnWorkingDay.Unique = false;
            _columnWorkingDay.DefaultValue = Convert.DBNull;
            _columnWorkingDay.ExtendedProperties.Add("IsKey", "true");
            _columnWorkingDay.ExtendedProperties.Add("ReadOnly", "false");
            _columnWorkingDay.ExtendedProperties.Add("Description", "Working Day");
            _columnWorkingDay.ExtendedProperties.Add("Decimals", "0");
            _columnWorkingDay.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnWorkingDay);

            _columnShiftID = new DataColumn("ShiftID", typeof(string));
            _columnShiftID.AllowDBNull = false;
            _columnShiftID.Caption = "Shift ID";
            _columnShiftID.MaxLength = 10;
            _columnShiftID.Unique = false;
            _columnShiftID.DefaultValue = Convert.DBNull;
            _columnShiftID.ExtendedProperties.Add("IsKey", "true");
            _columnShiftID.ExtendedProperties.Add("ReadOnly", "false");
            _columnShiftID.ExtendedProperties.Add("Description", "Shift ID");
            _columnShiftID.ExtendedProperties.Add("Length", "10");
            _columnShiftID.ExtendedProperties.Add("Decimals", "0");
            _columnShiftID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnShiftID);

            _columnIOTimes = new DataColumn("IOTimes", typeof(byte));
            _columnIOTimes.AllowDBNull = false;
            _columnIOTimes.Caption = "I O Times";
            _columnIOTimes.Unique = false;
            _columnIOTimes.DefaultValue = Convert.DBNull;
            _columnIOTimes.ExtendedProperties.Add("IsKey", "true");
            _columnIOTimes.ExtendedProperties.Add("ReadOnly", "false");
            _columnIOTimes.ExtendedProperties.Add("Description", "I O Times");
            _columnIOTimes.ExtendedProperties.Add("Decimals", "0");
            _columnIOTimes.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnIOTimes);

            _columnBreakOut = new DataColumn("BreakOut", typeof(DateTime));
            _columnBreakOut.AllowDBNull = true;
            _columnBreakOut.Caption = "Break Out";
            _columnBreakOut.Unique = false;
            _columnBreakOut.DefaultValue = Convert.DBNull;
            _columnBreakOut.ExtendedProperties.Add("IsKey", "false");
            _columnBreakOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnBreakOut.ExtendedProperties.Add("Description", "Break Out");
            _columnBreakOut.ExtendedProperties.Add("Decimals", "0");
            _columnBreakOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnBreakOut);

            _columnBreakIn = new DataColumn("BreakIn", typeof(DateTime));
            _columnBreakIn.AllowDBNull = true;
            _columnBreakIn.Caption = "Break In";
            _columnBreakIn.Unique = false;
            _columnBreakIn.DefaultValue = Convert.DBNull;
            _columnBreakIn.ExtendedProperties.Add("IsKey", "false");
            _columnBreakIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnBreakIn.ExtendedProperties.Add("Description", "Break In");
            _columnBreakIn.ExtendedProperties.Add("Decimals", "0");
            _columnBreakIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnBreakIn);

            _columnReasonID = new DataColumn("ReasonID", typeof(string));
            _columnReasonID.AllowDBNull = true;
            _columnReasonID.Caption = "Reason ID";
            _columnReasonID.MaxLength = 10;
            _columnReasonID.Unique = false;
            _columnReasonID.DefaultValue = Convert.DBNull;
            _columnReasonID.ExtendedProperties.Add("IsKey", "false");
            _columnReasonID.ExtendedProperties.Add("ReadOnly", "false");
            _columnReasonID.ExtendedProperties.Add("Description", "Reason ID");
            _columnReasonID.ExtendedProperties.Add("Length", "10");
            _columnReasonID.ExtendedProperties.Add("Decimals", "0");
            _columnReasonID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnReasonID);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["WorkingDay"], this.Columns["ShiftID"], this.Columns["IOTimes"] };
        }
        #endregion

        #region Constructors
        public BreakOutBreakInTable()
            : base("BreakOutBreakIn")
        {
            this.InitClass();
        }
        public BreakOutBreakInTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("BreakOutBreakIn_GetContent", Connection.GetConnection());
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
        public static BreakOutBreakInTable GetContentTable()
        {
            BreakOutBreakInTable breakOutBreakInTable = new BreakOutBreakInTable();
            breakOutBreakInTable.GetContent();
            return breakOutBreakInTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("BreakOutBreakIn_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@IOTimes", SqlDbType.TinyInt, 1, "IOTimes");
            sqlCommand.Parameters.Add("@BreakOut", SqlDbType.DateTime, 8, "BreakOut");
            sqlCommand.Parameters.Add("@BreakIn", SqlDbType.DateTime, 8, "BreakIn");
            sqlCommand.Parameters.Add("@ReasonID", SqlDbType.VarChar, 10, "ReasonID");

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
            SqlCommand sqlCommand = new SqlCommand("BreakOutBreakIn_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalWorkingDay", SqlDbType.DateTime, 8, "WorkingDay").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalShiftID", SqlDbType.VarChar, 10, "ShiftID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalIOTimes", SqlDbType.TinyInt, 1, "IOTimes").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@IOTimes", SqlDbType.TinyInt, 1, "IOTimes");
            sqlCommand.Parameters.Add("@BreakOut", SqlDbType.DateTime, 8, "BreakOut");
            sqlCommand.Parameters.Add("@BreakIn", SqlDbType.DateTime, 8, "BreakIn");
            sqlCommand.Parameters.Add("@ReasonID", SqlDbType.VarChar, 10, "ReasonID");

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
            SqlCommand sqlCommand = new SqlCommand("BreakOutBreakIn_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@IOTimes", SqlDbType.TinyInt, 1, "IOTimes");

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
        public bool Delete(int employeeID, DateTime workingDay, string shiftID, byte iOTimes)
        {
            bool retVal;

            BreakOutBreakInRow row = FindByPrimaryKey(employeeID, workingDay, shiftID, iOTimes);
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
        public DataColumn EmployeeIDColumn
        {
            get
            {
                return _columnEmployeeID;
            }
        }
        public DataColumn WorkingDayColumn
        {
            get
            {
                return _columnWorkingDay;
            }
        }
        public DataColumn ShiftIDColumn
        {
            get
            {
                return _columnShiftID;
            }
        }
        public DataColumn IOTimesColumn
        {
            get
            {
                return _columnIOTimes;
            }
        }
        public DataColumn BreakOutColumn
        {
            get
            {
                return _columnBreakOut;
            }
        }
        public DataColumn BreakInColumn
        {
            get
            {
                return _columnBreakIn;
            }
        }
        public DataColumn ReasonIDColumn
        {
            get
            {
                return _columnReasonID;
            }
        }
        public BreakOutBreakInRow this[int index]
        {
            get
            {
                return ((BreakOutBreakInRow)(this.Rows[index]));
            }
        }
        public void AddBreakOutBreakInRow(BreakOutBreakInRow row)
        {
            this.Rows.Add(row);
        }
        public BreakOutBreakInRow AddBreakOutBreakInRow(int employeeID, DateTime workingDay, string shiftID, byte iOTimes, DateTime breakOut, DateTime breakIn, string reasonID)
        {
            BreakOutBreakInRow rowBreakOutBreakInRow = ((BreakOutBreakInRow)(this.NewRow()));
            rowBreakOutBreakInRow["EmployeeID"] = employeeID;
            rowBreakOutBreakInRow["WorkingDay"] = workingDay;
            rowBreakOutBreakInRow["ShiftID"] = shiftID;
            rowBreakOutBreakInRow["IOTimes"] = iOTimes;
            rowBreakOutBreakInRow["BreakOut"] = breakOut;
            rowBreakOutBreakInRow["BreakIn"] = breakIn;
            rowBreakOutBreakInRow["ReasonID"] = reasonID;
            this.Rows.Add(rowBreakOutBreakInRow);
            return rowBreakOutBreakInRow;
        }
        public BreakOutBreakInRow FindByPrimaryKey(int employeeID, DateTime workingDay, string shiftID, byte iOTimes)
        {
            return (BreakOutBreakInRow)(Rows.Find(new object[] { employeeID, workingDay, shiftID, iOTimes }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new BreakOutBreakInRow(builder);
        }
        public static bool DeleteValue(int employeeID, DateTime workingDay, string shiftID, byte iOTimes)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("BreakOutBreakIn_Delete", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@IOTimes", SqlDbType.TinyInt, 1).Value = iOTimes;
            //try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            //catch
            {
            }
            //finally
            {
                Connection.Close();
            }
            return retVal;
        }
        #endregion
    }

    public class BreakOutBreakInRow : DataRow
    {
        private BreakOutBreakInTable _tableBreakOutBreakIn;

        internal BreakOutBreakInRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableBreakOutBreakIn = ((BreakOutBreakInTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableBreakOutBreakIn.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableBreakOutBreakIn.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime WorkingDay
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableBreakOutBreakIn.WorkingDayColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value WorkingDay because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.WorkingDayColumn] = value;
            }
        }
        public bool IsWorkingDayNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.WorkingDayColumn);
        }
        public void SetWorkingDayNull()
        {
            this[_tableBreakOutBreakIn.WorkingDayColumn] = Convert.DBNull;
        }
        public string ShiftID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableBreakOutBreakIn.ShiftIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ShiftID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.ShiftIDColumn] = value;
            }
        }
        public bool IsShiftIDNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.ShiftIDColumn);
        }
        public void SetShiftIDNull()
        {
            this[_tableBreakOutBreakIn.ShiftIDColumn] = Convert.DBNull;
        }
        public byte IOTimes
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableBreakOutBreakIn.IOTimesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IOTimes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.IOTimesColumn] = value;
            }
        }
        public bool IsIOTimesNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.IOTimesColumn);
        }
        public void SetIOTimesNull()
        {
            this[_tableBreakOutBreakIn.IOTimesColumn] = Convert.DBNull;
        }
        public DateTime BreakOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableBreakOutBreakIn.BreakOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BreakOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.BreakOutColumn] = value;
            }
        }
        public bool IsBreakOutNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.BreakOutColumn);
        }
        public void SetBreakOutNull()
        {
            this[_tableBreakOutBreakIn.BreakOutColumn] = Convert.DBNull;
        }
        public DateTime BreakIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableBreakOutBreakIn.BreakInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BreakIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.BreakInColumn] = value;
            }
        }
        public bool IsBreakInNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.BreakInColumn);
        }
        public void SetBreakInNull()
        {
            this[_tableBreakOutBreakIn.BreakInColumn] = Convert.DBNull;
        }
        public string ReasonID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableBreakOutBreakIn.ReasonIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ReasonID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableBreakOutBreakIn.ReasonIDColumn] = value;
            }
        }
        public bool IsReasonIDNull()
        {
            return this.IsNull(_tableBreakOutBreakIn.ReasonIDColumn);
        }
        public void SetReasonIDNull()
        {
            this[_tableBreakOutBreakIn.ReasonIDColumn] = Convert.DBNull;
        }
        #endregion
    }
}
