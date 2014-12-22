using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class LeaveTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnValid;

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

            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = true;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 50;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "50");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            _columnValid = new DataColumn("Valid", typeof(bool));
            _columnValid.AllowDBNull = true;
            _columnValid.Caption = "Valid";
            _columnValid.Unique = false;
            _columnValid.DefaultValue = Convert.DBNull;
            _columnValid.ExtendedProperties.Add("IsKey", "false");
            _columnValid.ExtendedProperties.Add("ReadOnly", "false");
            _columnValid.ExtendedProperties.Add("Description", "Valid");
            _columnValid.ExtendedProperties.Add("Decimals", "0");
            _columnValid.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValid);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public LeaveTable()
            : base("Leave")
        {
            this.InitClass();
        }
        public LeaveTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Leave_GetContent", Connection.GetConnection());
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
        public static LeaveTable GetContentTable()
        {
            LeaveTable leaveTable = new LeaveTable();
            leaveTable.GetContent();
            return leaveTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Leave_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Valid", SqlDbType.Bit, 1, "Valid");

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
            SqlCommand sqlCommand = new SqlCommand("Leave_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Valid", SqlDbType.Bit, 1, "Valid");

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
            SqlCommand sqlCommand = new SqlCommand("Leave_Delete", Connection.GetConnection());
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

            LeaveRow row = FindByPrimaryKey(iD);
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
        public DataColumn NameColumn
        {
            get
            {
                return _columnName;
            }
        }
        public DataColumn ValidColumn
        {
            get
            {
                return _columnValid;
            }
        }
        public LeaveRow this[int index]
        {
            get
            {
                return ((LeaveRow)(this.Rows[index]));
            }
        }
        public void AddLeaveRow(LeaveRow row)
        {
            this.Rows.Add(row);
        }
        public LeaveRow AddLeaveRow(string iD, string name, bool valid)
        {
            LeaveRow rowLeaveRow = ((LeaveRow)(this.NewRow()));
            rowLeaveRow["ID"] = iD;
            rowLeaveRow["Name"] = name;
            rowLeaveRow["Valid"] = valid;
            this.Rows.Add(rowLeaveRow);
            return rowLeaveRow;
        }
        public LeaveRow FindByPrimaryKey(string iD)
        {
            return (LeaveRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new LeaveRow(builder);
        }
        #endregion
    }

    public class LeaveRow : DataRow
    {
        private LeaveTable _tableLeave;

        internal LeaveRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableLeave = ((LeaveTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableLeave.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLeave.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableLeave.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableLeave.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableLeave.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLeave.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableLeave.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableLeave.NameColumn] = Convert.DBNull;
        }
        public bool Valid
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableLeave.ValidColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Valid because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLeave.ValidColumn] = value;
            }
        }
        public bool IsValidNull()
        {
            return this.IsNull(_tableLeave.ValidColumn);
        }
        public void SetValidNull()
        {
            this[_tableLeave.ValidColumn] = Convert.DBNull;
        }
        #endregion
    }
}
