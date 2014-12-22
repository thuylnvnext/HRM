using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RightOfGroupTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnGroupID;
        private DataColumn _columnFunctionID;
        private DataColumn _columnFunctionType;

        private void InitClass()
        {
            _columnGroupID = new DataColumn("GroupID", typeof(byte));
            _columnGroupID.AllowDBNull = false;
            _columnGroupID.Caption = "Group ID";
            _columnGroupID.Unique = false;
            _columnGroupID.DefaultValue = Convert.DBNull;
            _columnGroupID.ExtendedProperties.Add("IsKey", "true");
            _columnGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnGroupID.ExtendedProperties.Add("Description", "Group ID");
            _columnGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnGroupID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnGroupID);

            _columnFunctionID = new DataColumn("FunctionID", typeof(string));
            _columnFunctionID.AllowDBNull = false;
            _columnFunctionID.Caption = "Function ID";
            _columnFunctionID.MaxLength = 100;
            _columnFunctionID.Unique = false;
            _columnFunctionID.DefaultValue = Convert.DBNull;
            _columnFunctionID.ExtendedProperties.Add("IsKey", "true");
            _columnFunctionID.ExtendedProperties.Add("ReadOnly", "false");
            _columnFunctionID.ExtendedProperties.Add("Description", "Function ID");
            _columnFunctionID.ExtendedProperties.Add("Length", "100");
            _columnFunctionID.ExtendedProperties.Add("Decimals", "0");
            _columnFunctionID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFunctionID);

            _columnFunctionType = new DataColumn("FunctionType", typeof(byte));
            _columnFunctionType.AllowDBNull = false;
            _columnFunctionType.Caption = "Function Type";
            _columnFunctionType.Unique = false;
            _columnFunctionType.DefaultValue = Convert.DBNull;
            _columnFunctionType.ExtendedProperties.Add("IsKey", "true");
            _columnFunctionType.ExtendedProperties.Add("ReadOnly", "false");
            _columnFunctionType.ExtendedProperties.Add("Description", "Function Type");
            _columnFunctionType.ExtendedProperties.Add("Decimals", "0");
            _columnFunctionType.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFunctionType);

            this.PrimaryKey = new DataColumn[] { this.Columns["GroupID"], this.Columns["FunctionID"], this.Columns["FunctionType"] };
        }
        #endregion

        #region Constructors
        public RightOfGroupTable()
            : base("RightOfGroup")
        {
            this.InitClass();
        }
        public RightOfGroupTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RightOfGroup_GetContent", Connection.GetConnection());
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
        public static RightOfGroupTable GetContentTable()
        {
            RightOfGroupTable rightOfGroupTable = new RightOfGroupTable();
            rightOfGroupTable.GetContent();
            return rightOfGroupTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RightOfGroup_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt, 1, "GroupID");
            sqlCommand.Parameters.Add("@FunctionID", SqlDbType.VarChar, 100, "FunctionID");
            sqlCommand.Parameters.Add("@FunctionType", SqlDbType.TinyInt, 1, "FunctionType");

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
            SqlCommand sqlCommand = new SqlCommand("RightOfGroup_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalGroupID", SqlDbType.TinyInt, 1, "GroupID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFunctionID", SqlDbType.VarChar, 100, "FunctionID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFunctionType", SqlDbType.TinyInt, 1, "FunctionType").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt, 1, "GroupID");
            sqlCommand.Parameters.Add("@FunctionID", SqlDbType.VarChar, 100, "FunctionID");
            sqlCommand.Parameters.Add("@FunctionType", SqlDbType.TinyInt, 1, "FunctionType");

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
            SqlCommand sqlCommand = new SqlCommand("RightOfGroup_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt, 1, "GroupID");
            sqlCommand.Parameters.Add("@FunctionID", SqlDbType.VarChar, 100, "FunctionID");
            sqlCommand.Parameters.Add("@FunctionType", SqlDbType.TinyInt, 1, "FunctionType");

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
        public bool Delete(byte groupID, string functionID, byte functionType)
        {
            bool retVal;

            RightOfGroupRow row = FindByPrimaryKey(groupID, functionID, functionType);
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
        public DataColumn GroupIDColumn
        {
            get
            {
                return _columnGroupID;
            }
        }
        public DataColumn FunctionIDColumn
        {
            get
            {
                return _columnFunctionID;
            }
        }
        public DataColumn FunctionTypeColumn
        {
            get
            {
                return _columnFunctionType;
            }
        }
        public RightOfGroupRow this[int index]
        {
            get
            {
                return ((RightOfGroupRow)(this.Rows[index]));
            }
        }
        public void AddRightOfGroupRow(RightOfGroupRow row)
        {
            this.Rows.Add(row);
        }
        public RightOfGroupRow AddRightOfGroupRow(byte groupID, string functionID, byte functionType)
        {
            RightOfGroupRow rowRightOfGroupRow = ((RightOfGroupRow)(this.NewRow()));
            rowRightOfGroupRow["GroupID"] = groupID;
            rowRightOfGroupRow["FunctionID"] = functionID;
            rowRightOfGroupRow["FunctionType"] = functionType;
            this.Rows.Add(rowRightOfGroupRow);
            return rowRightOfGroupRow;
        }
        public RightOfGroupRow FindByPrimaryKey(byte groupID, string functionID, byte functionType)
        {
            return (RightOfGroupRow)(Rows.Find(new object[] { groupID, functionID, functionType }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RightOfGroupRow(builder);
        }
        public int GetListByGroupID(byte groupID, int functionType)
        {
            SqlCommand sqlCommand = new SqlCommand("RightOfGroup_GetListByGroupID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt).Value = groupID;
            sqlCommand.Parameters.Add("@FunctionType", SqlDbType.Int).Value = functionType;

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
        #endregion
    }

    public class RightOfGroupRow : DataRow
    {
        private RightOfGroupTable _tableRightOfGroup;

        internal RightOfGroupRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRightOfGroup = ((RightOfGroupTable)(this.Table));
        }

        #region Properties
        public byte GroupID
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableRightOfGroup.GroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value GroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRightOfGroup.GroupIDColumn] = value;
            }
        }
        public bool IsGroupIDNull()
        {
            return this.IsNull(_tableRightOfGroup.GroupIDColumn);
        }
        public void SetGroupIDNull()
        {
            this[_tableRightOfGroup.GroupIDColumn] = Convert.DBNull;
        }
        public string FunctionID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRightOfGroup.FunctionIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FunctionID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRightOfGroup.FunctionIDColumn] = value;
            }
        }
        public bool IsFunctionIDNull()
        {
            return this.IsNull(_tableRightOfGroup.FunctionIDColumn);
        }
        public void SetFunctionIDNull()
        {
            this[_tableRightOfGroup.FunctionIDColumn] = Convert.DBNull;
        }
        public byte FunctionType
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableRightOfGroup.FunctionTypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FunctionType because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRightOfGroup.FunctionTypeColumn] = value;
            }
        }
        public bool IsFunctionTypeNull()
        {
            return this.IsNull(_tableRightOfGroup.FunctionTypeColumn);
        }
        public void SetFunctionTypeNull()
        {
            this[_tableRightOfGroup.FunctionTypeColumn] = Convert.DBNull;
        }
        #endregion
    }
}