using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AttendanceItemTable : ItemT
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnAttendanceItemGroupID;
        private DataColumn _columnName;
        private DataColumn _columnDataType;
        private DataColumn _columnValue;
        private DataColumn _columnRounding;
        private DataColumn _columnType;
        private DataColumn _columnDisplay;
        private DataColumn _columnStatus;
        private DataColumn _columnSortOrder;

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

            _columnAttendanceItemGroupID = new DataColumn("AttendanceItemGroupID", typeof(string));
            _columnAttendanceItemGroupID.AllowDBNull = false;
            _columnAttendanceItemGroupID.Caption = "Attendance Item Group ID";
            _columnAttendanceItemGroupID.MaxLength = 10;
            _columnAttendanceItemGroupID.Unique = false;
            _columnAttendanceItemGroupID.DefaultValue = Convert.DBNull;
            _columnAttendanceItemGroupID.ExtendedProperties.Add("IsKey", "false");
            _columnAttendanceItemGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnAttendanceItemGroupID.ExtendedProperties.Add("Description", "Attendance Item Group ID");
            _columnAttendanceItemGroupID.ExtendedProperties.Add("Length", "10");
            _columnAttendanceItemGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnAttendanceItemGroupID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnAttendanceItemGroupID);

            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = true;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 250;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "250");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            _columnDataType = new DataColumn("DataType", typeof(string));
            _columnDataType.AllowDBNull = true;
            _columnDataType.Caption = "Data Type";
            _columnDataType.MaxLength = 20;
            _columnDataType.Unique = false;
            _columnDataType.DefaultValue = Convert.DBNull;
            _columnDataType.ExtendedProperties.Add("IsKey", "false");
            _columnDataType.ExtendedProperties.Add("ReadOnly", "false");
            _columnDataType.ExtendedProperties.Add("Description", "Data Type");
            _columnDataType.ExtendedProperties.Add("Length", "20");
            _columnDataType.ExtendedProperties.Add("Decimals", "0");
            _columnDataType.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDataType);

            _columnValue = new DataColumn("Value", typeof(string));
            _columnValue.AllowDBNull = true;
            _columnValue.Caption = "Value";
            _columnValue.MaxLength = 2000;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "2000");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            _columnRounding = new DataColumn("Rounding", typeof(int));
            _columnRounding.AllowDBNull = true;
            _columnRounding.Caption = "Rounding";
            _columnRounding.Unique = false;
            _columnRounding.DefaultValue = Convert.DBNull;
            _columnRounding.ExtendedProperties.Add("IsKey", "false");
            _columnRounding.ExtendedProperties.Add("ReadOnly", "false");
            _columnRounding.ExtendedProperties.Add("Description", "Rounding");
            _columnRounding.ExtendedProperties.Add("Decimals", "0");
            _columnRounding.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnRounding);

            _columnType = new DataColumn("Type", typeof(byte));
            _columnType.AllowDBNull = true;
            _columnType.Caption = "Type";
            _columnType.Unique = false;
            _columnType.DefaultValue = Convert.DBNull;
            _columnType.ExtendedProperties.Add("IsKey", "false");
            _columnType.ExtendedProperties.Add("ReadOnly", "false");
            _columnType.ExtendedProperties.Add("Description", "Type");
            _columnType.ExtendedProperties.Add("Decimals", "0");
            _columnType.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnType);

            _columnDisplay = new DataColumn("Display", typeof(bool));
            _columnDisplay.AllowDBNull = true;
            _columnDisplay.Caption = "Display";
            _columnDisplay.Unique = false;
            _columnDisplay.DefaultValue = Convert.DBNull;
            _columnDisplay.ExtendedProperties.Add("IsKey", "false");
            _columnDisplay.ExtendedProperties.Add("ReadOnly", "false");
            _columnDisplay.ExtendedProperties.Add("Description", "Display");
            _columnDisplay.ExtendedProperties.Add("Decimals", "0");
            _columnDisplay.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDisplay);

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

            _columnSortOrder = new DataColumn("SortOrder", typeof(int));
            _columnSortOrder.AllowDBNull = true;
            _columnSortOrder.Caption = "Sort Order";
            _columnSortOrder.Unique = false;
            _columnSortOrder.DefaultValue = Convert.DBNull;
            _columnSortOrder.ExtendedProperties.Add("IsKey", "false");
            _columnSortOrder.ExtendedProperties.Add("ReadOnly", "false");
            _columnSortOrder.ExtendedProperties.Add("Description", "Sort Order");
            _columnSortOrder.ExtendedProperties.Add("Decimals", "0");
            _columnSortOrder.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSortOrder);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public AttendanceItemTable()
            : base("AttendanceItem")
        {
            this.InitClass();
        }
        public AttendanceItemTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public override void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_GetContent", Connection.GetConnection());
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
        public static AttendanceItemTable GetContentTable()
        {
            AttendanceItemTable attendanceItemTable = new AttendanceItemTable();
            attendanceItemTable.GetContent();
            return attendanceItemTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@AttendanceItemGroupID", SqlDbType.VarChar, 10, "AttendanceItemGroupID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 250, "Name");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@Value", SqlDbType.VarChar, 2000, "Value");
            sqlCommand.Parameters.Add("@Rounding", SqlDbType.Int, 4, "Rounding");
            sqlCommand.Parameters.Add("@Type", SqlDbType.TinyInt, 1, "Type");
            sqlCommand.Parameters.Add("@Display", SqlDbType.Bit, 1, "Display");
            sqlCommand.Parameters.Add("@Status", SqlDbType.Bit, 1, "Status");
            sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");

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
        public override bool Update()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@AttendanceItemGroupID", SqlDbType.VarChar, 10, "AttendanceItemGroupID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 250, "Name");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@Value", SqlDbType.VarChar, 2000, "Value");
            sqlCommand.Parameters.Add("@Rounding", SqlDbType.Int, 4, "Rounding");
            sqlCommand.Parameters.Add("@Type", SqlDbType.TinyInt, 1, "Type");
            sqlCommand.Parameters.Add("@Display", SqlDbType.Bit, 1, "Display");
            sqlCommand.Parameters.Add("@Status", SqlDbType.Bit, 1, "Status");
            sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");

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
        public override bool Delete()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_Delete", Connection.GetConnection());
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

            AttendanceItemRow row = FindByPrimaryKey(iD);
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
        public DataColumn AttendanceItemGroupIDColumn
        {
            get
            {
                return _columnAttendanceItemGroupID;
            }
        }
        public DataColumn NameColumn
        {
            get
            {
                return _columnName;
            }
        }
        public DataColumn DataTypeColumn
        {
            get
            {
                return _columnDataType;
            }
        }
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
            }
        }
        public DataColumn RoundingColumn
        {
            get
            {
                return _columnRounding;
            }
        }
        public DataColumn TypeColumn
        {
            get
            {
                return _columnType;
            }
        }
        public DataColumn DisplayColumn
        {
            get
            {
                return _columnDisplay;
            }
        }
        public DataColumn StatusColumn
        {
            get
            {
                return _columnStatus;
            }
        }
        public DataColumn SortOrderColumn
        {
            get
            {
                return _columnSortOrder;
            }
        }
        public override ItemR this[int index]
        {
            get
            {
                return ((ItemR)(this.Rows[index]));
            }
        }
        public override string ItemGroupID
        {
            get
            {
                return _columnAttendanceItemGroupID.ColumnName;
            }
        }
        public void AddAttendanceItemRow(AttendanceItemRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddItemRow(ItemR r)
        {
            this.Rows.Add(r);
        }
        public AttendanceItemRow AddAttendanceItemRow(string iD, string attendanceItemGroupID, string name, string dataType, string value, int rounding, byte type, bool display, bool status, int sortOrder)
        {
            AttendanceItemRow rowAttendanceItemRow = ((AttendanceItemRow)(this.NewRow()));
            rowAttendanceItemRow["ID"] = iD;
            rowAttendanceItemRow["AttendanceItemGroupID"] = attendanceItemGroupID;
            rowAttendanceItemRow["Name"] = name;
            rowAttendanceItemRow["DataType"] = dataType;
            rowAttendanceItemRow["Value"] = value;
            rowAttendanceItemRow["Rounding"] = rounding;
            rowAttendanceItemRow["Type"] = type;
            rowAttendanceItemRow["Display"] = display;
            rowAttendanceItemRow["Status"] = status;
            rowAttendanceItemRow["SortOrder"] = sortOrder;
            this.Rows.Add(rowAttendanceItemRow);
            return rowAttendanceItemRow;
        }
        public AttendanceItemRow FindByPrimaryKey(string iD)
        {
            return (AttendanceItemRow)(Rows.Find(new object[] { iD }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AttendanceItemRow(builder);
        }
        public override int GetListByItemGroupID(string itemGroupIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_GetListByAttendanceItemGroupID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@AttendanceItemGroupIDList", SqlDbType.VarChar, 500).Value = itemGroupIDList;

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
        public override string GetNewID()
        {
            string retVal = string.Empty;
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_GetNewID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                Connection.Open();
                retVal = sqlCommand.ExecuteScalar().ToString();
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
        public override int GetListIsNull()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_GetListIsNull", Connection.GetConnection());
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

            return Count;
        }
        public static AttendanceItemTable GetListByMonthAttendance(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID)
        {
            AttendanceItemTable attendanceItem = new AttendanceItemTable();

            SqlCommand sqlCommand = new SqlCommand("AttendanceItem_GetListByMonthAttendance", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(attendanceItem);
            }
            finally
            {
                Connection.Close();
            }
            return attendanceItem;
        }
        public override DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class AttendanceItemRow : ItemR
    {
        private AttendanceItemTable _tableAttendanceItem;

        internal AttendanceItemRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAttendanceItem = ((AttendanceItemTable)(this.Table));
        }

        #region Properties
        public override string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItem.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableAttendanceItem.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableAttendanceItem.IDColumn] = Convert.DBNull;
        }
        public string AttendanceItemGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItem.AttendanceItemGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AttendanceItemGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.AttendanceItemGroupIDColumn] = value;
            }
        }
        public override string ItemGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItem.AttendanceItemGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ItemGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.AttendanceItemGroupIDColumn] = value;
            }
        }
        public bool IsAttendanceItemGroupIDNull()
        {
            return this.IsNull(_tableAttendanceItem.AttendanceItemGroupIDColumn);
        }
        public void SetAttendanceItemGroupIDNull()
        {
            this[_tableAttendanceItem.AttendanceItemGroupIDColumn] = Convert.DBNull;
        }
        public override string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItem.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableAttendanceItem.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableAttendanceItem.NameColumn] = Convert.DBNull;
        }
        public override string DataType
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItem.DataTypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DataType because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.DataTypeColumn] = value;
            }
        }
        public bool IsDataTypeNull()
        {
            return this.IsNull(_tableAttendanceItem.DataTypeColumn);
        }
        public void SetDataTypeNull()
        {
            this[_tableAttendanceItem.DataTypeColumn] = Convert.DBNull;
        }
        public override string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItem.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.ValueColumn] = value;
            }
        }
        public override bool IsValueNull()
        {
            return this.IsNull(_tableAttendanceItem.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableAttendanceItem.ValueColumn] = Convert.DBNull;
        }
        public override int Rounding
        {
            get
            {
                try
                {
                    return ((int)(this[_tableAttendanceItem.RoundingColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Rounding because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.RoundingColumn] = value;
            }
        }
        public bool IsRoundingNull()
        {
            return this.IsNull(_tableAttendanceItem.RoundingColumn);
        }
        public void SetRoundingNull()
        {
            this[_tableAttendanceItem.RoundingColumn] = Convert.DBNull;
        }
        public byte Type
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableAttendanceItem.TypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Type because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.TypeColumn] = value;
            }
        }
        public bool IsTypeNull()
        {
            return this.IsNull(_tableAttendanceItem.TypeColumn);
        }
        public void SetTypeNull()
        {
            this[_tableAttendanceItem.TypeColumn] = Convert.DBNull;
        }
        public bool Display
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableAttendanceItem.DisplayColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Display because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.DisplayColumn] = value;
            }
        }
        public bool IsDisplayNull()
        {
            return this.IsNull(_tableAttendanceItem.DisplayColumn);
        }
        public void SetDisplayNull()
        {
            this[_tableAttendanceItem.DisplayColumn] = Convert.DBNull;
        }
        public bool Status
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableAttendanceItem.StatusColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Status because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.StatusColumn] = value;
            }
        }
        public bool IsStatusNull()
        {
            return this.IsNull(_tableAttendanceItem.StatusColumn);
        }
        public void SetStatusNull()
        {
            this[_tableAttendanceItem.StatusColumn] = Convert.DBNull;
        }
        public int SortOrder
        {
            get
            {
                try
                {
                    return ((int)(this[_tableAttendanceItem.SortOrderColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SortOrder because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItem.SortOrderColumn] = value;
            }
        }
        public bool IsSortOrderNull()
        {
            return this.IsNull(_tableAttendanceItem.SortOrderColumn);
        }
        public void SetSortOrderNull()
        {
            this[_tableAttendanceItem.SortOrderColumn] = Convert.DBNull;
        }
        #endregion
    }
}