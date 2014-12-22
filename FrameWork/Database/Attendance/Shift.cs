using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ShiftTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnIsDefault;
        private DataColumn _columnIsNightShift;

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
            _columnName.AllowDBNull = false;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 20;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "20");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnName);

            _columnIsDefault = new DataColumn("IsDefault", typeof(bool));
            _columnIsDefault.AllowDBNull = true;
            _columnIsDefault.Caption = "Is Default";
            _columnIsDefault.Unique = false;
            _columnIsDefault.DefaultValue = Convert.DBNull;
            _columnIsDefault.ExtendedProperties.Add("IsKey", "false");
            _columnIsDefault.ExtendedProperties.Add("ReadOnly", "false");
            _columnIsDefault.ExtendedProperties.Add("Description", "Is Default");
            _columnIsDefault.ExtendedProperties.Add("Decimals", "0");
            _columnIsDefault.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnIsDefault);

            _columnIsNightShift = new DataColumn("IsNightShift", typeof(bool));
            _columnIsNightShift.AllowDBNull = true;
            _columnIsNightShift.Caption = "Is Night Shift";
            _columnIsNightShift.Unique = false;
            _columnIsNightShift.DefaultValue = Convert.DBNull;
            _columnIsNightShift.ExtendedProperties.Add("IsKey", "false");
            _columnIsNightShift.ExtendedProperties.Add("ReadOnly", "false");
            _columnIsNightShift.ExtendedProperties.Add("Description", "Is Night Shift");
            _columnIsNightShift.ExtendedProperties.Add("Decimals", "0");
            _columnIsNightShift.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnIsNightShift);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public ShiftTable()
            : base("Shift")
        {
            this.InitClass();
        }
        public ShiftTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Shift_GetContent", Connection.GetConnection());
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
        public static ShiftTable GetContentTable()
        {
            ShiftTable shiftTable = new ShiftTable();
            shiftTable.GetContent();
            return shiftTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Shift_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 20, "Name");
            sqlCommand.Parameters.Add("@IsDefault", SqlDbType.Bit, 1, "IsDefault");
            sqlCommand.Parameters.Add("@IsNightShift", SqlDbType.Bit, 1, "IsNightShift");

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
            SqlCommand sqlCommand = new SqlCommand("Shift_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 20, "Name");
            sqlCommand.Parameters.Add("@IsDefault", SqlDbType.Bit, 1, "IsDefault");
            sqlCommand.Parameters.Add("@IsNightShift", SqlDbType.Bit, 1, "IsNightShift");

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
            SqlCommand sqlCommand = new SqlCommand("Shift_Delete", Connection.GetConnection());
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

            ShiftRow row = FindByPrimaryKey(iD);
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
        public DataColumn IsDefaultColumn
        {
            get
            {
                return _columnIsDefault;
            }
        }
        public DataColumn IsNightShiftColumn
        {
            get
            {
                return _columnIsNightShift;
            }
        }
        public ShiftRow this[int index]
        {
            get
            {
                return ((ShiftRow)(this.Rows[index]));
            }
        }
        public void AddShiftRow(ShiftRow row)
        {
            this.Rows.Add(row);
        }
        public ShiftRow AddShiftRow(string iD, string name, bool isDefault, bool isNightShift)
        {
            ShiftRow rowShiftRow = ((ShiftRow)(this.NewRow()));
            rowShiftRow["ID"] = iD;
            rowShiftRow["Name"] = name;
            rowShiftRow["IsDefault"] = isDefault;
            rowShiftRow["IsNightShift"] = isNightShift;
            this.Rows.Add(rowShiftRow);
            return rowShiftRow;
        }
        public ShiftRow FindByPrimaryKey(string iD)
        {
            return (ShiftRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ShiftRow(builder);
        }
        #endregion
    }

    public class ShiftRow : DataRow
    {
        private ShiftTable _tableShift;

        internal ShiftRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableShift = ((ShiftTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableShift.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShift.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableShift.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableShift.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableShift.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShift.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableShift.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableShift.NameColumn] = Convert.DBNull;
        }
        public bool IsDefault
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableShift.IsDefaultColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IsDefault because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShift.IsDefaultColumn] = value;
            }
        }
        public bool IsIsDefaultNull()
        {
            return this.IsNull(_tableShift.IsDefaultColumn);
        }
        public void SetIsDefaultNull()
        {
            this[_tableShift.IsDefaultColumn] = Convert.DBNull;
        }
        public bool IsNightShift
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableShift.IsNightShiftColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IsNightShift because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableShift.IsNightShiftColumn] = value;
            }
        }
        public bool IsIsNightShiftNull()
        {
            return this.IsNull(_tableShift.IsNightShiftColumn);
        }
        public void SetIsNightShiftNull()
        {
            this[_tableShift.IsNightShiftColumn] = Convert.DBNull;
        }
        #endregion
    }
}
