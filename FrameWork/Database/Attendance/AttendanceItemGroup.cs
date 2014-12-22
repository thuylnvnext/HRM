using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AttendanceItemGroupTable : ItemGroupT
    {
        #region Private
        private DataColumn _columnParentID;
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnSortOrder;

        private void InitClass()
        {
            _columnParentID = new DataColumn("ParentID", typeof(string));
            _columnParentID.AllowDBNull = true;
            _columnParentID.Caption = "Parent ID";
            _columnParentID.MaxLength = 10;
            _columnParentID.Unique = false;
            _columnParentID.DefaultValue = Convert.DBNull;
            _columnParentID.ExtendedProperties.Add("IsKey", "false");
            _columnParentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnParentID.ExtendedProperties.Add("Description", "Parent ID");
            _columnParentID.ExtendedProperties.Add("Length", "10");
            _columnParentID.ExtendedProperties.Add("Decimals", "0");
            _columnParentID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnParentID);

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
            _columnName.MaxLength = 150;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "150");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

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
        #endregion

        #region Constructors
        public AttendanceItemGroupTable()
            : base("AttendanceItemGroup")
        {
            this.InitClass();
        }
        public AttendanceItemGroupTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public override void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItemGroup_GetContent", Connection.GetConnection());
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
        public static AttendanceItemGroupTable GetContentTable()
        {
            AttendanceItemGroupTable attendanceItemGroupTable = new AttendanceItemGroupTable();
            attendanceItemGroupTable.GetContent();
            return attendanceItemGroupTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("AttendanceItemGroup_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ParentID", SqlDbType.VarChar, 10, "ParentID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 150, "Name");
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
            SqlCommand sqlCommand = new SqlCommand("AttendanceItemGroup_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ParentID", SqlDbType.VarChar, 10, "ParentID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 150, "Name");
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
            SqlCommand sqlCommand = new SqlCommand("AttendanceItemGroup_Delete", Connection.GetConnection());
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
        public override bool Delete(string iD)
        {
            bool retVal;

            AttendanceItemGroupRow row = FindByPrimaryKey(iD);
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
        public DataColumn ParentIDColumn
        {
            get
            {
                return _columnParentID;
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
        public DataColumn SortOrderColumn
        {
            get
            {
                return _columnSortOrder;
            }
        }
        public override ItemGroupR this[int index]
        {
            get
            {
                return ((ItemGroupR)(this.Rows[index]));
            }
        }
        public void AddAttendanceItemGroupRow(AttendanceItemGroupRow row)
        {
            this.Rows.Add(row);
        }
        public AttendanceItemGroupRow AddAttendanceItemGroupRow(string parentID, string iD, string name, int sortOrder)
        {
            AttendanceItemGroupRow rowAttendanceItemGroupRow = ((AttendanceItemGroupRow)(this.NewRow()));
            rowAttendanceItemGroupRow["ParentID"] = parentID;
            rowAttendanceItemGroupRow["ID"] = iD;
            rowAttendanceItemGroupRow["Name"] = name;
            rowAttendanceItemGroupRow["SortOrder"] = sortOrder;
            this.Rows.Add(rowAttendanceItemGroupRow);
            return rowAttendanceItemGroupRow;
        }
        public override void AddItemGroupRow(ItemGroupR r)
        {
            this.Rows.Add(r);
        }
        public AttendanceItemGroupRow FindByPrimaryKey(string iD)
        {
            return (AttendanceItemGroupRow)(Rows.Find(new object[] { iD }));
        }
        public override ItemGroupR FindByID(string iD)
        {
            return (ItemGroupR)(Rows.Find(new object[] { iD }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AttendanceItemGroupRow(builder);
        }
        #endregion
    }

    public class AttendanceItemGroupRow : ItemGroupR
    {
        private AttendanceItemGroupTable _tableAttendanceItemGroup;

        internal AttendanceItemGroupRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAttendanceItemGroup = ((AttendanceItemGroupTable)(this.Table));
        }

        #region Properties
        public override string ParentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItemGroup.ParentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ParentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItemGroup.ParentIDColumn] = value;
            }
        }
        public override bool IsParentIDNull()
        {
            return this.IsNull(_tableAttendanceItemGroup.ParentIDColumn);
        }
        public void SetParentIDNull()
        {
            this[_tableAttendanceItemGroup.ParentIDColumn] = Convert.DBNull;
        }
        public override string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItemGroup.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItemGroup.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableAttendanceItemGroup.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableAttendanceItemGroup.IDColumn] = Convert.DBNull;
        }
        public override string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAttendanceItemGroup.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItemGroup.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableAttendanceItemGroup.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableAttendanceItemGroup.NameColumn] = Convert.DBNull;
        }
        public override int SortOrder
        {
            get
            {
                try
                {
                    return ((int)(this[_tableAttendanceItemGroup.SortOrderColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SortOrder because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAttendanceItemGroup.SortOrderColumn] = value;
            }
        }
        public override bool IsSortOrderNull()
        {
            return this.IsNull(_tableAttendanceItemGroup.SortOrderColumn);
        }
        public void SetSortOrderNull()
        {
            this[_tableAttendanceItemGroup.SortOrderColumn] = Convert.DBNull;
        }
        #endregion
    }
}
