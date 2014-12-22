using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class TimeInTimeOutTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnWorkingDay;
        private DataColumn _columnShiftID;
        private DataColumn _columnTimeIn;
        private DataColumn _columnTimeOut;
        private DataColumn _columnNotes;

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

            _columnTimeIn = new DataColumn("TimeIn", typeof(DateTime));
            _columnTimeIn.AllowDBNull = true;
            _columnTimeIn.Caption = "Time In";
            _columnTimeIn.Unique = false;
            _columnTimeIn.DefaultValue = Convert.DBNull;
            _columnTimeIn.ExtendedProperties.Add("IsKey", "false");
            _columnTimeIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnTimeIn.ExtendedProperties.Add("Description", "Time In");
            _columnTimeIn.ExtendedProperties.Add("Decimals", "0");
            _columnTimeIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnTimeIn);

            _columnTimeOut = new DataColumn("TimeOut", typeof(DateTime));
            _columnTimeOut.AllowDBNull = true;
            _columnTimeOut.Caption = "Time Out";
            _columnTimeOut.Unique = false;
            _columnTimeOut.DefaultValue = Convert.DBNull;
            _columnTimeOut.ExtendedProperties.Add("IsKey", "false");
            _columnTimeOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnTimeOut.ExtendedProperties.Add("Description", "Time Out");
            _columnTimeOut.ExtendedProperties.Add("Decimals", "0");
            _columnTimeOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnTimeOut);

            _columnNotes = new DataColumn("Notes", typeof(string));
            _columnNotes.AllowDBNull = true;
            _columnNotes.Caption = "Notes";
            _columnNotes.MaxLength = 100;
            _columnNotes.Unique = false;
            _columnNotes.DefaultValue = Convert.DBNull;
            _columnNotes.ExtendedProperties.Add("IsKey", "false");
            _columnNotes.ExtendedProperties.Add("ReadOnly", "false");
            _columnNotes.ExtendedProperties.Add("Description", "Notes");
            _columnNotes.ExtendedProperties.Add("Length", "100");
            _columnNotes.ExtendedProperties.Add("Decimals", "0");
            _columnNotes.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNotes);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["WorkingDay"], this.Columns["ShiftID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public TimeInTimeOutTable()
            : base("TimeInTimeOut")
        {
            this.InitClass();
        }
        public TimeInTimeOutTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_GetContent", Connection.GetConnection());
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
        public static TimeInTimeOutTable GetContentTable()
        {
            TimeInTimeOutTable timeInTimeOutTable = new TimeInTimeOutTable();
            timeInTimeOutTable.GetContent();
            return timeInTimeOutTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@TimeIn", SqlDbType.DateTime, 8, "TimeIn");
            sqlCommand.Parameters.Add("@TimeOut", SqlDbType.DateTime, 8, "TimeOut");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 100, "Notes");

            sqlDataAdapter.InsertCommand = sqlCommand;
            //try
            {
                Connection.Open();
                sqlDataAdapter.Update(this);
            }
            //catch
            {
                retVal = false;
            }
            //finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public bool Update()
        {
            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalWorkingDay", SqlDbType.DateTime, 8, "WorkingDay").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalShiftID", SqlDbType.VarChar, 10, "ShiftID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@TimeIn", SqlDbType.DateTime, 8, "TimeIn");
            sqlCommand.Parameters.Add("@TimeOut", SqlDbType.DateTime, 8, "TimeOut");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 500, "Notes");

            sqlDataAdapter.UpdateCommand = sqlCommand;
            //try
            {
                Connection.Open();
                sqlDataAdapter.Update(this);
            }
            //catch
            {
                retVal = false;
            }
            //finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public bool Delete()
        {
            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8, "WorkingDay");
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");

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
        public bool Delete(int employeeID, DateTime workingDay, string shiftID)
        {
            bool retVal;

            TimeInTimeOutRow row = FindByPrimaryKey(employeeID, workingDay, shiftID);
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
        public DataColumn TimeInColumn
        {
            get
            {
                return _columnTimeIn;
            }
        }
        public DataColumn TimeOutColumn
        {
            get
            {
                return _columnTimeOut;
            }
        }
        public DataColumn NotesColumn
        {
            get
            {
                return _columnNotes;
            }
        }
        public TimeInTimeOutRow this[int index]
        {
            get
            {
                return ((TimeInTimeOutRow)(this.Rows[index]));
            }
        }
        public void AddTimeInTimeOutRow(TimeInTimeOutRow row)
        {
            this.Rows.Add(row);
        }
        public TimeInTimeOutRow AddTimeInTimeOutRow(int employeeID, DateTime workingDay, string shiftID, DateTime timeIn, DateTime timeOut, string notes)
        {
            TimeInTimeOutRow rowTimeInTimeOutRow = ((TimeInTimeOutRow)(this.NewRow()));
            rowTimeInTimeOutRow["EmployeeID"] = employeeID;
            rowTimeInTimeOutRow["WorkingDay"] = workingDay;
            rowTimeInTimeOutRow["ShiftID"] = shiftID;
            rowTimeInTimeOutRow["TimeIn"] = timeIn;
            rowTimeInTimeOutRow["TimeOut"] = timeOut;
            rowTimeInTimeOutRow["Notes"] = notes;
            this.Rows.Add(rowTimeInTimeOutRow);
            return rowTimeInTimeOutRow;
        }
        public TimeInTimeOutRow FindByPrimaryKey(int employeeID, DateTime workingDay, string shiftID)
        {
            return (TimeInTimeOutRow)(Rows.Find(new object[] { employeeID, workingDay, shiftID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new TimeInTimeOutRow(builder);
        }        
        public static bool DeleteValue(int employeeID, DateTime workingDay, string shiftID)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_Delete", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
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
        public static bool SetVirtualData(string departmentIDList, DateTime fromDate, DateTime toDate)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_SetVirtualData", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.CommandTimeout = 0;
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
        public static DateTime GetTime(int employeeID, DateTime workingDay, bool _in)
        {
            DateTime retVal = DateTime.MaxValue;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_GetTime", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@In", SqlDbType.Bit).Value = _in;
            try
            {
                Connection.Open();
                retVal = (DateTime)sqlCommand.ExecuteScalar();
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
        public static bool SetStatus(int employeeID, DateTime workingDay, string shiftID, byte status)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_SetStatus", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@Status", SqlDbType.TinyInt, 1).Value = status;
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
        public static bool UpdateNotes(int employeeID, DateTime workingDay, string shiftID, string notes)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_UpdateNotes", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 100).Value = notes;
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
        public static bool InsertNotes(int employeeID, DateTime workingDay, string shiftID, string notes)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_InsertNotes", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 100).Value = notes;
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
        public static bool Insert(int employeeID, DateTime workingDay, string shiftID, DateTime timeIn, DateTime timeOut, byte status)
        {
            bool retVal = true;

            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_Insert", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@TimeIn", SqlDbType.DateTime, 8).Value = timeIn;
            sqlCommand.Parameters.Add("@TimeOut", SqlDbType.DateTime, 8).Value = timeOut;
            sqlCommand.Parameters.Add("@Status", SqlDbType.TinyInt, 1).Value = status;
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
        public static bool Update(int employeeID, DateTime workingDay, string shiftID, DateTime timeIn, DateTime timeOut, byte status)
        {
            SqlCommand sqlCommand = new SqlCommand("TimeInTimeOut_Update", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@OriginalWorkingDay", SqlDbType.DateTime, 8).Value = workingDay;
            sqlCommand.Parameters.Add("@OriginalShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@TimeIn", SqlDbType.DateTime, 8).Value = timeIn;
            sqlCommand.Parameters.Add("@TimeOut", SqlDbType.DateTime, 8).Value = timeOut;
            sqlCommand.Parameters.Add("@Status", SqlDbType.TinyInt, 1).Value = status;

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
        #endregion
    }

    public class TimeInTimeOutRow : DataRow
    {
        private TimeInTimeOutTable _tableTimeInTimeOut;

        internal TimeInTimeOutRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableTimeInTimeOut = ((TimeInTimeOutTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableTimeInTimeOut.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTimeInTimeOut.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableTimeInTimeOut.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableTimeInTimeOut.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime WorkingDay
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableTimeInTimeOut.WorkingDayColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value WorkingDay because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTimeInTimeOut.WorkingDayColumn] = value;
            }
        }
        public bool IsWorkingDayNull()
        {
            return this.IsNull(_tableTimeInTimeOut.WorkingDayColumn);
        }
        public void SetWorkingDayNull()
        {
            this[_tableTimeInTimeOut.WorkingDayColumn] = Convert.DBNull;
        }
        public string ShiftID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableTimeInTimeOut.ShiftIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ShiftID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTimeInTimeOut.ShiftIDColumn] = value;
            }
        }
        public bool IsShiftIDNull()
        {
            return this.IsNull(_tableTimeInTimeOut.ShiftIDColumn);
        }
        public void SetShiftIDNull()
        {
            this[_tableTimeInTimeOut.ShiftIDColumn] = Convert.DBNull;
        }
        public DateTime TimeIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableTimeInTimeOut.TimeInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value TimeIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTimeInTimeOut.TimeInColumn] = value;
            }
        }
        public bool IsTimeInNull()
        {
            return this.IsNull(_tableTimeInTimeOut.TimeInColumn);
        }
        public void SetTimeInNull()
        {
            this[_tableTimeInTimeOut.TimeInColumn] = Convert.DBNull;
        }
        public DateTime TimeOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableTimeInTimeOut.TimeOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value TimeOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTimeInTimeOut.TimeOutColumn] = value;
            }
        }
        public bool IsTimeOutNull()
        {
            return this.IsNull(_tableTimeInTimeOut.TimeOutColumn);
        }
        public void SetTimeOutNull()
        {
            this[_tableTimeInTimeOut.TimeOutColumn] = Convert.DBNull;
        }
        public string Notes
        {
            get
            {
                try
                {
                    return ((string)(this[_tableTimeInTimeOut.NotesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Notes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTimeInTimeOut.NotesColumn] = value;
            }
        }
        public bool IsNotesNull()
        {
            return this.IsNull(_tableTimeInTimeOut.NotesColumn);
        }
        public void SetNotesNull()
        {
            this[_tableTimeInTimeOut.NotesColumn] = Convert.DBNull;
        }
        #endregion
    }
}
