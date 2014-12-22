using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ShiftDetailTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnShiftID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnNormalTimeIn;
        private DataColumn _columnNormalBreakOut;
        private DataColumn _columnNormalBreakIn;
        private DataColumn _columnNormalTimeOut;
        private DataColumn _columnNormalTotal;
        private DataColumn _columnSaturdayTimeIn;
        private DataColumn _columnSaturdayBreakOut;
        private DataColumn _columnSaturdayBreakIn;
        private DataColumn _columnSaturdayTimeOut;
        private DataColumn _columnSaturdayTotal;
        private DataColumn _columnSundayTimeIn;
        private DataColumn _columnSundayBreakOut;
        private DataColumn _columnSundayBreakIn;
        private DataColumn _columnSundayTimeOut;
        private DataColumn _columnSundayTotal;
        private DataColumn _columnLateComing;
        private DataColumn _columnEarlyReturning;
        private DataColumn _columnPreviousOverTime;
        private DataColumn _columnNextOverTime;

        private void InitClass()
        {
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

            _columnFromDate = new DataColumn("FromDate", typeof(DateTime));
            _columnFromDate.AllowDBNull = false;
            _columnFromDate.Caption = "Change Date";
            _columnFromDate.Unique = false;
            _columnFromDate.DefaultValue = Convert.DBNull;
            _columnFromDate.ExtendedProperties.Add("IsKey", "true");
            _columnFromDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnFromDate.ExtendedProperties.Add("Description", "Change Date");
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

            _columnNormalTimeIn = new DataColumn("NormalTimeIn", typeof(DateTime));
            _columnNormalTimeIn.AllowDBNull = true;
            _columnNormalTimeIn.Caption = "Normal Time In";
            _columnNormalTimeIn.Unique = false;
            _columnNormalTimeIn.DefaultValue = Convert.DBNull;
            _columnNormalTimeIn.ExtendedProperties.Add("IsKey", "false");
            _columnNormalTimeIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnNormalTimeIn.ExtendedProperties.Add("Description", "Normal Time In");
            _columnNormalTimeIn.ExtendedProperties.Add("Decimals", "0");
            _columnNormalTimeIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNormalTimeIn);

            _columnNormalBreakOut = new DataColumn("NormalBreakOut", typeof(DateTime));
            _columnNormalBreakOut.AllowDBNull = true;
            _columnNormalBreakOut.Caption = "Normal Break Out";
            _columnNormalBreakOut.Unique = false;
            _columnNormalBreakOut.DefaultValue = Convert.DBNull;
            _columnNormalBreakOut.ExtendedProperties.Add("IsKey", "false");
            _columnNormalBreakOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnNormalBreakOut.ExtendedProperties.Add("Description", "Normal Break Out");
            _columnNormalBreakOut.ExtendedProperties.Add("Decimals", "0");
            _columnNormalBreakOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNormalBreakOut);

            _columnNormalBreakIn = new DataColumn("NormalBreakIn", typeof(DateTime));
            _columnNormalBreakIn.AllowDBNull = true;
            _columnNormalBreakIn.Caption = "Normal Break In";
            _columnNormalBreakIn.Unique = false;
            _columnNormalBreakIn.DefaultValue = Convert.DBNull;
            _columnNormalBreakIn.ExtendedProperties.Add("IsKey", "false");
            _columnNormalBreakIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnNormalBreakIn.ExtendedProperties.Add("Description", "Normal Break In");
            _columnNormalBreakIn.ExtendedProperties.Add("Decimals", "0");
            _columnNormalBreakIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNormalBreakIn);

            _columnNormalTimeOut = new DataColumn("NormalTimeOut", typeof(DateTime));
            _columnNormalTimeOut.AllowDBNull = true;
            _columnNormalTimeOut.Caption = "Normal Time Out";
            _columnNormalTimeOut.Unique = false;
            _columnNormalTimeOut.DefaultValue = Convert.DBNull;
            _columnNormalTimeOut.ExtendedProperties.Add("IsKey", "false");
            _columnNormalTimeOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnNormalTimeOut.ExtendedProperties.Add("Description", "Normal Time Out");
            _columnNormalTimeOut.ExtendedProperties.Add("Decimals", "0");
            _columnNormalTimeOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNormalTimeOut);

            _columnNormalTotal = new DataColumn("NormalTotal", typeof(int));
            _columnNormalTotal.AllowDBNull = true;
            _columnNormalTotal.Caption = "Normal Total";
            _columnNormalTotal.Unique = false;
            _columnNormalTotal.DefaultValue = Convert.DBNull;
            _columnNormalTotal.ExtendedProperties.Add("IsKey", "false");
            _columnNormalTotal.ExtendedProperties.Add("ReadOnly", "false");
            _columnNormalTotal.ExtendedProperties.Add("Description", "Normal Total");
            _columnNormalTotal.ExtendedProperties.Add("Decimals", "0");
            _columnNormalTotal.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNormalTotal);

            _columnSaturdayTimeIn = new DataColumn("SaturdayTimeIn", typeof(DateTime));
            _columnSaturdayTimeIn.AllowDBNull = true;
            _columnSaturdayTimeIn.Caption = "Saturday Time In";
            _columnSaturdayTimeIn.Unique = false;
            _columnSaturdayTimeIn.DefaultValue = Convert.DBNull;
            _columnSaturdayTimeIn.ExtendedProperties.Add("IsKey", "false");
            _columnSaturdayTimeIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnSaturdayTimeIn.ExtendedProperties.Add("Description", "Saturday Time In");
            _columnSaturdayTimeIn.ExtendedProperties.Add("Decimals", "0");
            _columnSaturdayTimeIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSaturdayTimeIn);

            _columnSaturdayBreakOut = new DataColumn("SaturdayBreakOut", typeof(DateTime));
            _columnSaturdayBreakOut.AllowDBNull = true;
            _columnSaturdayBreakOut.Caption = "Saturday Break Out";
            _columnSaturdayBreakOut.Unique = false;
            _columnSaturdayBreakOut.DefaultValue = Convert.DBNull;
            _columnSaturdayBreakOut.ExtendedProperties.Add("IsKey", "false");
            _columnSaturdayBreakOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnSaturdayBreakOut.ExtendedProperties.Add("Description", "Saturday Break Out");
            _columnSaturdayBreakOut.ExtendedProperties.Add("Decimals", "0");
            _columnSaturdayBreakOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSaturdayBreakOut);

            _columnSaturdayBreakIn = new DataColumn("SaturdayBreakIn", typeof(DateTime));
            _columnSaturdayBreakIn.AllowDBNull = true;
            _columnSaturdayBreakIn.Caption = "Saturday Break In";
            _columnSaturdayBreakIn.Unique = false;
            _columnSaturdayBreakIn.DefaultValue = Convert.DBNull;
            _columnSaturdayBreakIn.ExtendedProperties.Add("IsKey", "false");
            _columnSaturdayBreakIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnSaturdayBreakIn.ExtendedProperties.Add("Description", "Saturday Break In");
            _columnSaturdayBreakIn.ExtendedProperties.Add("Decimals", "0");
            _columnSaturdayBreakIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSaturdayBreakIn);

            _columnSaturdayTimeOut = new DataColumn("SaturdayTimeOut", typeof(DateTime));
            _columnSaturdayTimeOut.AllowDBNull = true;
            _columnSaturdayTimeOut.Caption = "Saturday Time Out";
            _columnSaturdayTimeOut.Unique = false;
            _columnSaturdayTimeOut.DefaultValue = Convert.DBNull;
            _columnSaturdayTimeOut.ExtendedProperties.Add("IsKey", "false");
            _columnSaturdayTimeOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnSaturdayTimeOut.ExtendedProperties.Add("Description", "Saturday Time Out");
            _columnSaturdayTimeOut.ExtendedProperties.Add("Decimals", "0");
            _columnSaturdayTimeOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSaturdayTimeOut);

            _columnSaturdayTotal = new DataColumn("SaturdayTotal", typeof(int));
            _columnSaturdayTotal.AllowDBNull = true;
            _columnSaturdayTotal.Caption = "Saturday Total";
            _columnSaturdayTotal.Unique = false;
            _columnSaturdayTotal.DefaultValue = Convert.DBNull;
            _columnSaturdayTotal.ExtendedProperties.Add("IsKey", "false");
            _columnSaturdayTotal.ExtendedProperties.Add("ReadOnly", "false");
            _columnSaturdayTotal.ExtendedProperties.Add("Description", "Saturday Total");
            _columnSaturdayTotal.ExtendedProperties.Add("Decimals", "0");
            _columnSaturdayTotal.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSaturdayTotal);

            _columnSundayTimeIn = new DataColumn("SundayTimeIn", typeof(DateTime));
            _columnSundayTimeIn.AllowDBNull = true;
            _columnSundayTimeIn.Caption = "Sunday Time In";
            _columnSundayTimeIn.Unique = false;
            _columnSundayTimeIn.DefaultValue = Convert.DBNull;
            _columnSundayTimeIn.ExtendedProperties.Add("IsKey", "false");
            _columnSundayTimeIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnSundayTimeIn.ExtendedProperties.Add("Description", "Sunday Time In");
            _columnSundayTimeIn.ExtendedProperties.Add("Decimals", "0");
            _columnSundayTimeIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSundayTimeIn);

            _columnSundayBreakOut = new DataColumn("SundayBreakOut", typeof(DateTime));
            _columnSundayBreakOut.AllowDBNull = true;
            _columnSundayBreakOut.Caption = "Sunday Break Out";
            _columnSundayBreakOut.Unique = false;
            _columnSundayBreakOut.DefaultValue = Convert.DBNull;
            _columnSundayBreakOut.ExtendedProperties.Add("IsKey", "false");
            _columnSundayBreakOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnSundayBreakOut.ExtendedProperties.Add("Description", "Sunday Break Out");
            _columnSundayBreakOut.ExtendedProperties.Add("Decimals", "0");
            _columnSundayBreakOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSundayBreakOut);

            _columnSundayBreakIn = new DataColumn("SundayBreakIn", typeof(DateTime));
            _columnSundayBreakIn.AllowDBNull = true;
            _columnSundayBreakIn.Caption = "Sunday Break In";
            _columnSundayBreakIn.Unique = false;
            _columnSundayBreakIn.DefaultValue = Convert.DBNull;
            _columnSundayBreakIn.ExtendedProperties.Add("IsKey", "false");
            _columnSundayBreakIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnSundayBreakIn.ExtendedProperties.Add("Description", "Sunday Break In");
            _columnSundayBreakIn.ExtendedProperties.Add("Decimals", "0");
            _columnSundayBreakIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSundayBreakIn);

            _columnSundayTimeOut = new DataColumn("SundayTimeOut", typeof(DateTime));
            _columnSundayTimeOut.AllowDBNull = true;
            _columnSundayTimeOut.Caption = "Sunday Time Out";
            _columnSundayTimeOut.Unique = false;
            _columnSundayTimeOut.DefaultValue = Convert.DBNull;
            _columnSundayTimeOut.ExtendedProperties.Add("IsKey", "false");
            _columnSundayTimeOut.ExtendedProperties.Add("ReadOnly", "false");
            _columnSundayTimeOut.ExtendedProperties.Add("Description", "Sunday Time Out");
            _columnSundayTimeOut.ExtendedProperties.Add("Decimals", "0");
            _columnSundayTimeOut.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSundayTimeOut);

            _columnSundayTotal = new DataColumn("SundayTotal", typeof(int));
            _columnSundayTotal.AllowDBNull = true;
            _columnSundayTotal.Caption = "Sunday Total";
            _columnSundayTotal.Unique = false;
            _columnSundayTotal.DefaultValue = Convert.DBNull;
            _columnSundayTotal.ExtendedProperties.Add("IsKey", "false");
            _columnSundayTotal.ExtendedProperties.Add("ReadOnly", "false");
            _columnSundayTotal.ExtendedProperties.Add("Description", "Sunday Total");
            _columnSundayTotal.ExtendedProperties.Add("Decimals", "0");
            _columnSundayTotal.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSundayTotal);

            _columnLateComing = new DataColumn("LateComing", typeof(int));
            _columnLateComing.AllowDBNull = true;
            _columnLateComing.Caption = "Late Coming";
            _columnLateComing.Unique = false;
            _columnLateComing.DefaultValue = Convert.DBNull;
            _columnLateComing.ExtendedProperties.Add("IsKey", "false");
            _columnLateComing.ExtendedProperties.Add("ReadOnly", "false");
            _columnLateComing.ExtendedProperties.Add("Description", "Late Coming");
            _columnLateComing.ExtendedProperties.Add("Decimals", "0");
            _columnLateComing.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnLateComing);

            _columnEarlyReturning = new DataColumn("EarlyReturning", typeof(int));
            _columnEarlyReturning.AllowDBNull = true;
            _columnEarlyReturning.Caption = "Early Returning";
            _columnEarlyReturning.Unique = false;
            _columnEarlyReturning.DefaultValue = Convert.DBNull;
            _columnEarlyReturning.ExtendedProperties.Add("IsKey", "false");
            _columnEarlyReturning.ExtendedProperties.Add("ReadOnly", "false");
            _columnEarlyReturning.ExtendedProperties.Add("Description", "Early Returning");
            _columnEarlyReturning.ExtendedProperties.Add("Decimals", "0");
            _columnEarlyReturning.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnEarlyReturning);

            _columnPreviousOverTime = new DataColumn("PreviousOverTime", typeof(int));
            _columnPreviousOverTime.AllowDBNull = true;
            _columnPreviousOverTime.Caption = "Previous Over Time";
            _columnPreviousOverTime.Unique = false;
            _columnPreviousOverTime.DefaultValue = Convert.DBNull;
            _columnPreviousOverTime.ExtendedProperties.Add("IsKey", "false");
            _columnPreviousOverTime.ExtendedProperties.Add("ReadOnly", "false");
            _columnPreviousOverTime.ExtendedProperties.Add("Description", "Previous Over Time");
            _columnPreviousOverTime.ExtendedProperties.Add("Decimals", "0");
            _columnPreviousOverTime.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPreviousOverTime);

            _columnNextOverTime = new DataColumn("NextOverTime", typeof(int));
            _columnNextOverTime.AllowDBNull = true;
            _columnNextOverTime.Caption = "Next Over Time";
            _columnNextOverTime.Unique = false;
            _columnNextOverTime.DefaultValue = Convert.DBNull;
            _columnNextOverTime.ExtendedProperties.Add("IsKey", "false");
            _columnNextOverTime.ExtendedProperties.Add("ReadOnly", "false");
            _columnNextOverTime.ExtendedProperties.Add("Description", "Next Over Time");
            _columnNextOverTime.ExtendedProperties.Add("Decimals", "0");
            _columnNextOverTime.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNextOverTime);

            this.PrimaryKey = new DataColumn[] { this.Columns["ShiftID"], this.Columns["FromDate"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public ShiftDetailTable()
            : base("ShiftDetail")
        {
            this.InitClass();
        }
        public ShiftDetailTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("ShiftDetail_GetContent", Connection.GetConnection());
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
        public static ShiftDetailTable GetContentTable()
        {
            ShiftDetailTable shiftDetailTable = new ShiftDetailTable();
            shiftDetailTable.GetContent();
            return shiftDetailTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("ShiftDetail_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@NormalTimeIn", SqlDbType.DateTime, 8, "NormalTimeIn");
            sqlCommand.Parameters.Add("@NormalBreakOut", SqlDbType.DateTime, 8, "NormalBreakOut");
            sqlCommand.Parameters.Add("@NormalBreakIn", SqlDbType.DateTime, 8, "NormalBreakIn");
            sqlCommand.Parameters.Add("@NormalTimeOut", SqlDbType.DateTime, 8, "NormalTimeOut");
            sqlCommand.Parameters.Add("@NormalTotal", SqlDbType.Int, 4, "NormalTotal");
            sqlCommand.Parameters.Add("@SaturdayTimeIn", SqlDbType.DateTime, 8, "SaturdayTimeIn");
            sqlCommand.Parameters.Add("@SaturdayBreakOut", SqlDbType.DateTime, 8, "SaturdayBreakOut");
            sqlCommand.Parameters.Add("@SaturdayBreakIn", SqlDbType.DateTime, 8, "SaturdayBreakIn");
            sqlCommand.Parameters.Add("@SaturdayTimeOut", SqlDbType.DateTime, 8, "SaturdayTimeOut");
            sqlCommand.Parameters.Add("@SaturdayTotal", SqlDbType.Int, 4, "SaturdayTotal");
            sqlCommand.Parameters.Add("@SundayTimeIn", SqlDbType.DateTime, 8, "SundayTimeIn");
            sqlCommand.Parameters.Add("@SundayBreakOut", SqlDbType.DateTime, 8, "SundayBreakOut");
            sqlCommand.Parameters.Add("@SundayBreakIn", SqlDbType.DateTime, 8, "SundayBreakIn");
            sqlCommand.Parameters.Add("@SundayTimeOut", SqlDbType.DateTime, 8, "SundayTimeOut");
            sqlCommand.Parameters.Add("@SundayTotal", SqlDbType.Int, 4, "SundayTotal");
            sqlCommand.Parameters.Add("@LateComing", SqlDbType.Int, 4, "LateComing");
            sqlCommand.Parameters.Add("@EarlyReturning", SqlDbType.Int, 4, "EarlyReturning");
            sqlCommand.Parameters.Add("@PreviousOverTime", SqlDbType.Int, 4, "PreviousOverTime");
            sqlCommand.Parameters.Add("@NextOverTime", SqlDbType.Int, 4, "NextOverTime");

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
            SqlCommand sqlCommand = new SqlCommand("ShiftDetail_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalShiftID", SqlDbType.VarChar, 10, "ShiftID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@NormalTimeIn", SqlDbType.DateTime, 8, "NormalTimeIn");
            sqlCommand.Parameters.Add("@NormalBreakOut", SqlDbType.DateTime, 8, "NormalBreakOut");
            sqlCommand.Parameters.Add("@NormalBreakIn", SqlDbType.DateTime, 8, "NormalBreakIn");
            sqlCommand.Parameters.Add("@NormalTimeOut", SqlDbType.DateTime, 8, "NormalTimeOut");
            sqlCommand.Parameters.Add("@NormalTotal", SqlDbType.Int, 4, "NormalTotal");
            sqlCommand.Parameters.Add("@SaturdayTimeIn", SqlDbType.DateTime, 8, "SaturdayTimeIn");
            sqlCommand.Parameters.Add("@SaturdayBreakOut", SqlDbType.DateTime, 8, "SaturdayBreakOut");
            sqlCommand.Parameters.Add("@SaturdayBreakIn", SqlDbType.DateTime, 8, "SaturdayBreakIn");
            sqlCommand.Parameters.Add("@SaturdayTimeOut", SqlDbType.DateTime, 8, "SaturdayTimeOut");
            sqlCommand.Parameters.Add("@SaturdayTotal", SqlDbType.Int, 4, "SaturdayTotal");
            sqlCommand.Parameters.Add("@SundayTimeIn", SqlDbType.DateTime, 8, "SundayTimeIn");
            sqlCommand.Parameters.Add("@SundayBreakOut", SqlDbType.DateTime, 8, "SundayBreakOut");
            sqlCommand.Parameters.Add("@SundayBreakIn", SqlDbType.DateTime, 8, "SundayBreakIn");
            sqlCommand.Parameters.Add("@SundayTimeOut", SqlDbType.DateTime, 8, "SundayTimeOut");
            sqlCommand.Parameters.Add("@SundayTotal", SqlDbType.Int, 4, "SundayTotal");
            sqlCommand.Parameters.Add("@LateComing", SqlDbType.Int, 4, "LateComing");
            sqlCommand.Parameters.Add("@EarlyReturning", SqlDbType.Int, 4, "EarlyReturning");
            sqlCommand.Parameters.Add("@PreviousOverTime", SqlDbType.Int, 4, "PreviousOverTime");
            sqlCommand.Parameters.Add("@NextOverTime", SqlDbType.Int, 4, "NextOverTime");

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
            SqlCommand sqlCommand = new SqlCommand("ShiftDetail_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10, "ShiftID");
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
        public bool Delete(string shiftID, DateTime fromDate)
        {
            bool retVal;

            ShiftDetailRow row = FindByPrimaryKey(shiftID, fromDate);
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
        public DataColumn ShiftIDColumn
        {
            get
            {
                return _columnShiftID;
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
        public DataColumn NormalTimeInColumn
        {
            get
            {
                return _columnNormalTimeIn;
            }
        }
        public DataColumn NormalBreakOutColumn
        {
            get
            {
                return _columnNormalBreakOut;
            }
        }
        public DataColumn NormalBreakInColumn
        {
            get
            {
                return _columnNormalBreakIn;
            }
        }
        public DataColumn NormalTimeOutColumn
        {
            get
            {
                return _columnNormalTimeOut;
            }
        }
        public DataColumn NormalTotalColumn
        {
            get
            {
                return _columnNormalTotal;
            }
        }
        public DataColumn SaturdayTimeInColumn
        {
            get
            {
                return _columnSaturdayTimeIn;
            }
        }
        public DataColumn SaturdayBreakOutColumn
        {
            get
            {
                return _columnSaturdayBreakOut;
            }
        }
        public DataColumn SaturdayBreakInColumn
        {
            get
            {
                return _columnSaturdayBreakIn;
            }
        }
        public DataColumn SaturdayTimeOutColumn
        {
            get
            {
                return _columnSaturdayTimeOut;
            }
        }
        public DataColumn SaturdayTotalColumn
        {
            get
            {
                return _columnSaturdayTotal;
            }
        }
        public DataColumn SundayTimeInColumn
        {
            get
            {
                return _columnSundayTimeIn;
            }
        }
        public DataColumn SundayBreakOutColumn
        {
            get
            {
                return _columnSundayBreakOut;
            }
        }
        public DataColumn SundayBreakInColumn
        {
            get
            {
                return _columnSundayBreakIn;
            }
        }
        public DataColumn SundayTimeOutColumn
        {
            get
            {
                return _columnSundayTimeOut;
            }
        }
        public DataColumn SundayTotalColumn
        {
            get
            {
                return _columnSundayTotal;
            }
        }
        public DataColumn LateComingColumn
        {
            get
            {
                return _columnLateComing;
            }
        }
        public DataColumn EarlyReturningColumn
        {
            get
            {
                return _columnEarlyReturning;
            }
        }
        public DataColumn PreviousOverTimeColumn
        {
            get
            {
                return _columnPreviousOverTime;
            }
        }
        public DataColumn NextOverTimeColumn
        {
            get
            {
                return _columnNextOverTime;
            }
        }
        public ShiftDetailRow this[int index]
        {
            get
            {
                return ((ShiftDetailRow)(this.Rows[index]));
            }
        }
        public void AddShiftDetailRow(ShiftDetailRow row)
        {
            this.Rows.Add(row);
        }
        public ShiftDetailRow AddShiftDetailRow(string shiftID, DateTime fromDate, DateTime toDate, DateTime normalTimeIn, DateTime normalBreakOut, DateTime normalBreakIn, DateTime normalTimeOut, int normalTotal, DateTime saturdayTimeIn, DateTime saturdayBreakOut, DateTime saturdayBreakIn, DateTime saturdayTimeOut, int saturdayTotal, DateTime sundayTimeIn, DateTime sundayBreakOut, DateTime sundayBreakIn, DateTime sundayTimeOut, int sundayTotal, int lateComing, int earlyReturning, int previousOverTime, int nextOverTime)
        {
            ShiftDetailRow rowShiftDetailRow = ((ShiftDetailRow)(this.NewRow()));
            rowShiftDetailRow["ShiftID"] = shiftID;
            rowShiftDetailRow["FromDate"] = fromDate;
            rowShiftDetailRow["ToDate"] = toDate;
            rowShiftDetailRow["NormalTimeIn"] = normalTimeIn;
            rowShiftDetailRow["NormalBreakOut"] = normalBreakOut;
            rowShiftDetailRow["NormalBreakIn"] = normalBreakIn;
            rowShiftDetailRow["NormalTimeOut"] = normalTimeOut;
            rowShiftDetailRow["NormalTotal"] = normalTotal;
            rowShiftDetailRow["SaturdayTimeIn"] = saturdayTimeIn;
            rowShiftDetailRow["SaturdayBreakOut"] = saturdayBreakOut;
            rowShiftDetailRow["SaturdayBreakIn"] = saturdayBreakIn;
            rowShiftDetailRow["SaturdayTimeOut"] = saturdayTimeOut;
            rowShiftDetailRow["SaturdayTotal"] = saturdayTotal;
            rowShiftDetailRow["SundayTimeIn"] = sundayTimeIn;
            rowShiftDetailRow["SundayBreakOut"] = sundayBreakOut;
            rowShiftDetailRow["SundayBreakIn"] = sundayBreakIn;
            rowShiftDetailRow["SundayTimeOut"] = sundayTimeOut;
            rowShiftDetailRow["SundayTotal"] = sundayTotal;
            rowShiftDetailRow["LateComing"] = lateComing;
            rowShiftDetailRow["EarlyReturning"] = earlyReturning;
            rowShiftDetailRow["PreviousOverTime"] = previousOverTime;
            rowShiftDetailRow["NextOverTime"] = nextOverTime;
            this.Rows.Add(rowShiftDetailRow);
            return rowShiftDetailRow;
        }
        public ShiftDetailRow FindByPrimaryKey(string shiftID, DateTime fromDate)
        {
            return (ShiftDetailRow)(Rows.Find(new object[] { shiftID, fromDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ShiftDetailRow(builder);
        }
        public int GetInfoByShiftID(string shiftID)
        {
            SqlCommand sqlCommand = new SqlCommand("ShiftDetail_GetInfoByShiftID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;

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
        public static ShiftDetailRow GetListByShiftID(string shiftID, DateTime workingDay)
        {
            ShiftDetailTable shiftDetail = new ShiftDetailTable();
            SqlCommand sqlCommand = new SqlCommand("ShiftDetail_GetListByShiftID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ShiftID", SqlDbType.VarChar, 10).Value = shiftID;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(shiftDetail);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            if (shiftDetail.Count > 0)
                return shiftDetail[0];
            else
                return null;
        }
        #endregion
    }

    public class ShiftDetailRow : DataRow
    {
        private ShiftDetailTable _tableShiftDetail;

        internal ShiftDetailRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableShiftDetail = ((ShiftDetailTable)(this.Table));
        }

        #region Properties
        public string ShiftID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableShiftDetail.ShiftIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ShiftID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.ShiftIDColumn] = value;
            }
        }
        public bool IsShiftIDNull()
        {
            return this.IsNull(_tableShiftDetail.ShiftIDColumn);
        }
        public void SetShiftIDNull()
        {
            this[_tableShiftDetail.ShiftIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableShiftDetail.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableShiftDetail.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableShiftDetail.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableShiftDetail.ToDateColumn] = Convert.DBNull;
        }
        public DateTime NormalTimeIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.NormalTimeInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NormalTimeIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.NormalTimeInColumn] = value;
            }
        }
        public bool IsNormalTimeInNull()
        {
            return this.IsNull(_tableShiftDetail.NormalTimeInColumn);
        }
        public void SetNormalTimeInNull()
        {
            this[_tableShiftDetail.NormalTimeInColumn] = Convert.DBNull;
        }
        public DateTime NormalBreakOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.NormalBreakOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NormalBreakOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.NormalBreakOutColumn] = value;
            }
        }
        public bool IsNormalBreakOutNull()
        {
            return this.IsNull(_tableShiftDetail.NormalBreakOutColumn);
        }
        public void SetNormalBreakOutNull()
        {
            this[_tableShiftDetail.NormalBreakOutColumn] = Convert.DBNull;
        }
        public DateTime NormalBreakIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.NormalBreakInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NormalBreakIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.NormalBreakInColumn] = value;
            }
        }
        public bool IsNormalBreakInNull()
        {
            return this.IsNull(_tableShiftDetail.NormalBreakInColumn);
        }
        public void SetNormalBreakInNull()
        {
            this[_tableShiftDetail.NormalBreakInColumn] = Convert.DBNull;
        }
        public DateTime NormalTimeOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.NormalTimeOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NormalTimeOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.NormalTimeOutColumn] = value;
            }
        }
        public bool IsNormalTimeOutNull()
        {
            return this.IsNull(_tableShiftDetail.NormalTimeOutColumn);
        }
        public void SetNormalTimeOutNull()
        {
            this[_tableShiftDetail.NormalTimeOutColumn] = Convert.DBNull;
        }
        public int NormalTotal
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.NormalTotalColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NormalTotal because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.NormalTotalColumn] = value;
            }
        }
        public bool IsNormalTotalNull()
        {
            return this.IsNull(_tableShiftDetail.NormalTotalColumn);
        }
        public void SetNormalTotalNull()
        {
            this[_tableShiftDetail.NormalTotalColumn] = Convert.DBNull;
        }
        public DateTime SaturdayTimeIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SaturdayTimeInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SaturdayTimeIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SaturdayTimeInColumn] = value;
            }
        }
        public bool IsSaturdayTimeInNull()
        {
            return this.IsNull(_tableShiftDetail.SaturdayTimeInColumn);
        }
        public void SetSaturdayTimeInNull()
        {
            this[_tableShiftDetail.SaturdayTimeInColumn] = Convert.DBNull;
        }
        public DateTime SaturdayBreakOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SaturdayBreakOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SaturdayBreakOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SaturdayBreakOutColumn] = value;
            }
        }
        public bool IsSaturdayBreakOutNull()
        {
            return this.IsNull(_tableShiftDetail.SaturdayBreakOutColumn);
        }
        public void SetSaturdayBreakOutNull()
        {
            this[_tableShiftDetail.SaturdayBreakOutColumn] = Convert.DBNull;
        }
        public DateTime SaturdayBreakIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SaturdayBreakInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SaturdayBreakIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SaturdayBreakInColumn] = value;
            }
        }
        public bool IsSaturdayBreakInNull()
        {
            return this.IsNull(_tableShiftDetail.SaturdayBreakInColumn);
        }
        public void SetSaturdayBreakInNull()
        {
            this[_tableShiftDetail.SaturdayBreakInColumn] = Convert.DBNull;
        }
        public DateTime SaturdayTimeOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SaturdayTimeOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SaturdayTimeOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SaturdayTimeOutColumn] = value;
            }
        }
        public bool IsSaturdayTimeOutNull()
        {
            return this.IsNull(_tableShiftDetail.SaturdayTimeOutColumn);
        }
        public void SetSaturdayTimeOutNull()
        {
            this[_tableShiftDetail.SaturdayTimeOutColumn] = Convert.DBNull;
        }
        public int SaturdayTotal
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.SaturdayTotalColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SaturdayTotal because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SaturdayTotalColumn] = value;
            }
        }
        public bool IsSaturdayTotalNull()
        {
            return this.IsNull(_tableShiftDetail.SaturdayTotalColumn);
        }
        public void SetSaturdayTotalNull()
        {
            this[_tableShiftDetail.SaturdayTotalColumn] = Convert.DBNull;
        }
        public DateTime SundayTimeIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SundayTimeInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SundayTimeIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SundayTimeInColumn] = value;
            }
        }
        public bool IsSundayTimeInNull()
        {
            return this.IsNull(_tableShiftDetail.SundayTimeInColumn);
        }
        public void SetSundayTimeInNull()
        {
            this[_tableShiftDetail.SundayTimeInColumn] = Convert.DBNull;
        }
        public DateTime SundayBreakOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SundayBreakOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SundayBreakOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SundayBreakOutColumn] = value;
            }
        }
        public bool IsSundayBreakOutNull()
        {
            return this.IsNull(_tableShiftDetail.SundayBreakOutColumn);
        }
        public void SetSundayBreakOutNull()
        {
            this[_tableShiftDetail.SundayBreakOutColumn] = Convert.DBNull;
        }
        public DateTime SundayBreakIn
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SundayBreakInColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SundayBreakIn because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SundayBreakInColumn] = value;
            }
        }
        public bool IsSundayBreakInNull()
        {
            return this.IsNull(_tableShiftDetail.SundayBreakInColumn);
        }
        public void SetSundayBreakInNull()
        {
            this[_tableShiftDetail.SundayBreakInColumn] = Convert.DBNull;
        }
        public DateTime SundayTimeOut
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableShiftDetail.SundayTimeOutColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SundayTimeOut because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SundayTimeOutColumn] = value;
            }
        }
        public bool IsSundayTimeOutNull()
        {
            return this.IsNull(_tableShiftDetail.SundayTimeOutColumn);
        }
        public void SetSundayTimeOutNull()
        {
            this[_tableShiftDetail.SundayTimeOutColumn] = Convert.DBNull;
        }
        public int SundayTotal
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.SundayTotalColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SundayTotal because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.SundayTotalColumn] = value;
            }
        }
        public bool IsSundayTotalNull()
        {
            return this.IsNull(_tableShiftDetail.SundayTotalColumn);
        }
        public void SetSundayTotalNull()
        {
            this[_tableShiftDetail.SundayTotalColumn] = Convert.DBNull;
        }
        public int LateComing
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.LateComingColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value LateComing because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.LateComingColumn] = value;
            }
        }
        public bool IsLateComingNull()
        {
            return this.IsNull(_tableShiftDetail.LateComingColumn);
        }
        public void SetLateComingNull()
        {
            this[_tableShiftDetail.LateComingColumn] = Convert.DBNull;
        }
        public int EarlyReturning
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.EarlyReturningColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EarlyReturning because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.EarlyReturningColumn] = value;
            }
        }
        public bool IsEarlyReturningNull()
        {
            return this.IsNull(_tableShiftDetail.EarlyReturningColumn);
        }
        public void SetEarlyReturningNull()
        {
            this[_tableShiftDetail.EarlyReturningColumn] = Convert.DBNull;
        }
        public int PreviousOverTime
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.PreviousOverTimeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PreviousOverTime because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.PreviousOverTimeColumn] = value;
            }
        }
        public bool IsPreviousOverTimeNull()
        {
            return this.IsNull(_tableShiftDetail.PreviousOverTimeColumn);
        }
        public void SetPreviousOverTimeNull()
        {
            this[_tableShiftDetail.PreviousOverTimeColumn] = Convert.DBNull;
        }
        public int NextOverTime
        {
            get
            {
                try
                {
                    return ((int)(this[_tableShiftDetail.NextOverTimeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NextOverTime because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShiftDetail.NextOverTimeColumn] = value;
            }
        }
        public bool IsNextOverTimeNull()
        {
            return this.IsNull(_tableShiftDetail.NextOverTimeColumn);
        }
        public void SetNextOverTimeNull()
        {
            this[_tableShiftDetail.NextOverTimeColumn] = Convert.DBNull;
        }
        #endregion
    }
}
