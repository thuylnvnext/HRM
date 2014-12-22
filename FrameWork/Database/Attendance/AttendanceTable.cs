using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AttendanceTableTable : ItemT
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnAttendanceTableGroupID;
        private DataColumn _columnName;
        private DataColumn _columnDataType;
        private DataColumn _columnValue;
        private DataColumn _columnType;
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

            _columnAttendanceTableGroupID = new DataColumn("AttendanceTableGroupID", typeof(string));
            _columnAttendanceTableGroupID.AllowDBNull = false;
            _columnAttendanceTableGroupID.Caption = "Attendance Table Group ID";
            _columnAttendanceTableGroupID.MaxLength = 10;
            _columnAttendanceTableGroupID.Unique = false;
            _columnAttendanceTableGroupID.DefaultValue = Convert.DBNull;
            _columnAttendanceTableGroupID.ExtendedProperties.Add("IsKey", "false");
            _columnAttendanceTableGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnAttendanceTableGroupID.ExtendedProperties.Add("Description", "Attendance Table Group ID");
            _columnAttendanceTableGroupID.ExtendedProperties.Add("Length", "10");
            _columnAttendanceTableGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnAttendanceTableGroupID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnAttendanceTableGroupID);

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
            _columnValue.MaxLength = 500;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "500");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            _columnType = new DataColumn("Type", typeof(byte));
            _columnType.AllowDBNull = true;
            _columnType.Caption = "Type";
            _columnType.Unique = false;
            _columnType.DefaultValue = Convert.DBNull;
            _columnType.ExtendedProperties.Add("IsKey", "false");
            _columnType.ExtendedProperties.Add("ReadOnly", "false");
            _columnType.ExtendedProperties.Add("Description", "Status");
            _columnType.ExtendedProperties.Add("Decimals", "0");
            _columnType.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnType);

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
        public AttendanceTableTable()
            : base("AttendanceTable")
        {
            this.InitClass();
        }
        public AttendanceTableTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public override void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_GetContent", Connection.GetConnection());
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
        public static AttendanceTableTable GetContentTable()
        {
            AttendanceTableTable attendanceTableTable = new AttendanceTableTable();
            attendanceTableTable.GetContent();
            return attendanceTableTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@AttendanceTableGroupID", SqlDbType.VarChar, 10, "AttendanceTableGroupID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 250, "Name");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@Value", SqlDbType.VarChar, 500, "Value");
            sqlCommand.Parameters.Add("@Type", SqlDbType.TinyInt, 1, "Type");
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
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@AttendanceTableGroupID", SqlDbType.VarChar, 10, "AttendanceTableGroupID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 250, "Name");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@Value", SqlDbType.VarChar, 500, "Value");
            sqlCommand.Parameters.Add("@Type", SqlDbType.TinyInt, 1, "Type");
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
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_Delete", Connection.GetConnection());
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

            AttendanceTableRow row = FindByPrimaryKey(iD);
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
        public DataColumn AttendanceTableGroupIDColumn
        {
            get
            {
                return _columnAttendanceTableGroupID;
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
        public DataColumn TypeColumn
        {
            get
            {
                return _columnType;
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
                return _columnAttendanceTableGroupID.ColumnName;
            }
        }
        public void AddAttendanceTableRow(AttendanceTableRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddItemRow(ItemR r)
        {
            this.Rows.Add(r);
        }
        public AttendanceTableRow AddAttendanceTableRow(string iD, string attendanceTableGroupID, string name, string dataType, string value, byte type, bool status, int sortOrder)
        {
            AttendanceTableRow rowAttendanceTableRow = ((AttendanceTableRow)(this.NewRow()));
            rowAttendanceTableRow["ID"] = iD;
            rowAttendanceTableRow["AttendanceTableGroupID"] = attendanceTableGroupID;
            rowAttendanceTableRow["Name"] = name;
            rowAttendanceTableRow["DataType"] = dataType;
            rowAttendanceTableRow["Value"] = value;
            rowAttendanceTableRow["Type"] = type;
            rowAttendanceTableRow["Status"] = status;
            rowAttendanceTableRow["SortOrder"] = sortOrder;
            this.Rows.Add(rowAttendanceTableRow);
            return rowAttendanceTableRow;
        }
        public AttendanceTableRow FindByPrimaryKey(string iD)
        {
            return (AttendanceTableRow)(Rows.Find(new object[] { iD }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AttendanceTableRow(builder);
        }
        public override int GetListByItemGroupID(string itemGroupIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_GetListByAttendanceItemGroupID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@AttendanceTableGroupIDList", SqlDbType.VarChar, 500).Value = itemGroupIDList;

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
        public int GetListByID(string iDList)
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_GetListByID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@IDList", SqlDbType.VarChar, 500).Value = iDList;

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
            SqlCommand sqlCommand = new SqlCommand("AttendanceTable_GetNewID", Connection.GetConnection());
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
        public override DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class AttendanceTableRow : ItemR
    {
        private AttendanceTableTable _tableAttendanceTable;

        internal AttendanceTableRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAttendanceTable = ((AttendanceTableTable)(this.Table));
        }

        #region Properties
        public override string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceTable.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableAttendanceTable.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableAttendanceTable.IDColumn] = Convert.DBNull;
        }
        public string AttendanceTableGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceTable.AttendanceTableGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AttendanceTableGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.AttendanceTableGroupIDColumn] = value;
            }
        }
        public override string ItemGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceTable.AttendanceTableGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AttendanceTableGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.AttendanceTableGroupIDColumn] = value;
            }
        }
        public bool IsAttendanceTableGroupIDNull()
        {
            return this.IsNull(_tableAttendanceTable.AttendanceTableGroupIDColumn);
        }
        public void SetAttendanceTableGroupIDNull()
        {
            this[_tableAttendanceTable.AttendanceTableGroupIDColumn] = Convert.DBNull;
        }
        public override string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceTable.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableAttendanceTable.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableAttendanceTable.NameColumn] = Convert.DBNull;
        }
        public override string DataType
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceTable.DataTypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Data Type because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.DataTypeColumn] = value;
            }
        }
        public bool IsDataTypeNull()
        {
            return this.IsNull(_tableAttendanceTable.DataTypeColumn);
        }
        public void SetDataTypeNull()
        {
            this[_tableAttendanceTable.DataTypeColumn] = Convert.DBNull;
        }
        public override string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceTable.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.ValueColumn] = value;
            }
        }
        public override bool IsValueNull()
        {
            return this.IsNull(_tableAttendanceTable.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableAttendanceTable.ValueColumn] = Convert.DBNull;
        }
        public override int Rounding
        {
            get
            {
                return 4;
            }
            set
            {
            }
        }
        public byte Type
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableAttendanceTable.TypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Type because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.TypeColumn] = value;
            }
        }
        public bool IsTypeNull()
        {
            return this.IsNull(_tableAttendanceTable.TypeColumn);
        }
        public void SetTypeNull()
        {
            this[_tableAttendanceTable.TypeColumn] = Convert.DBNull;
        }
        public bool Status
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableAttendanceTable.StatusColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Status because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.StatusColumn] = value;
            }
        }
        public bool IsStatusNull()
        {
            return this.IsNull(_tableAttendanceTable.StatusColumn);
        }
        public void SetStatusNull()
        {
            this[_tableAttendanceTable.StatusColumn] = Convert.DBNull;
        }
        public int SortOrder
        {
            get
            {
                try
                {
                    return ((int)(this[_tableAttendanceTable.SortOrderColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SortOrder because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceTable.SortOrderColumn] = value;
            }
        }
        public bool IsSortOrderNull()
        {
            return this.IsNull(_tableAttendanceTable.SortOrderColumn);
        }
        public void SetSortOrderNull()
        {
            this[_tableAttendanceTable.SortOrderColumn] = Convert.DBNull;
        }
        #endregion
    }
}
