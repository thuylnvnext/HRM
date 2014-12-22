using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class OptionTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnOptionGroupID;
        private DataColumn _columnDataType;
        private DataColumn _columnValue;
        private DataColumn _columnDescription;

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

            _columnOptionGroupID = new DataColumn("OptionGroupID", typeof(string));
            _columnOptionGroupID.AllowDBNull = true;
            _columnOptionGroupID.Caption = "Option Group ID";
            _columnOptionGroupID.MaxLength = 10;
            _columnOptionGroupID.Unique = false;
            _columnOptionGroupID.DefaultValue = Convert.DBNull;
            _columnOptionGroupID.ExtendedProperties.Add("IsKey", "false");
            _columnOptionGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnOptionGroupID.ExtendedProperties.Add("Description", "Option Group ID");
            _columnOptionGroupID.ExtendedProperties.Add("Length", "10");
            _columnOptionGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnOptionGroupID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnOptionGroupID);

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
            _columnValue.MaxLength = (int)Math.Pow(2, 31) - 1;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "(int)Math.Pow(2, 31) - 1");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            _columnDescription = new DataColumn("Description", typeof(string));
            _columnDescription.AllowDBNull = true;
            _columnDescription.Caption = "Description";
            _columnDescription.MaxLength = 250;
            _columnDescription.Unique = false;
            _columnDescription.DefaultValue = Convert.DBNull;
            _columnDescription.ExtendedProperties.Add("IsKey", "false");
            _columnDescription.ExtendedProperties.Add("ReadOnly", "false");
            _columnDescription.ExtendedProperties.Add("Description", "Description");
            _columnDescription.ExtendedProperties.Add("Length", "250");
            _columnDescription.ExtendedProperties.Add("Decimals", "0");
            _columnDescription.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDescription);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        #endregion

        #region Constructors
        public OptionTable()
            : base("Option")
        {
            this.InitClass();
        }
        public OptionTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Option_GetContent", Connection.GetConnection());
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
        public static OptionTable GetContentTable()
        {
            OptionTable optionTable = new OptionTable();
            optionTable.GetContent();
            return optionTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Option_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@OptionGroupID", SqlDbType.VarChar, 10, "OptionGroupID");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, (int)Math.Pow(2, 31) - 1, "Value");
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 250, "Description");

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
            SqlCommand sqlCommand = new SqlCommand("Option_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@OptionGroupID", SqlDbType.VarChar, 10, "OptionGroupID");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, (int)Math.Pow(2, 31) - 1, "Value");
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 250, "Description");

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
            SqlCommand sqlCommand = new SqlCommand("Option_Delete", Connection.GetConnection());
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

            OptionRow row = FindByPrimaryKey(iD);
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
        public DataColumn OptionGroupIDColumn
        {
            get
            {
                return _columnOptionGroupID;
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
        public DataColumn DescriptionColumn
        {
            get
            {
                return _columnDescription;
            }
        }
        public OptionRow this[int index]
        {
            get
            {
                return ((OptionRow)(this.Rows[index]));
            }
        }
        public void AddOptionRow(OptionRow row)
        {
            this.Rows.Add(row);
        }
        public OptionRow AddOptionRow(string iD, string name, string optionGroupID, string dataType, string value, string description)
        {
            OptionRow rowOptionRow = ((OptionRow)(this.NewRow()));
            rowOptionRow["ID"] = iD;
            rowOptionRow["Name"] = name;
            rowOptionRow["OptionGroupID"] = optionGroupID;
            rowOptionRow["DataType"] = dataType;
            rowOptionRow["Value"] = value;
            rowOptionRow["Description"] = description;
            this.Rows.Add(rowOptionRow);
            return rowOptionRow;
        }
        public OptionRow FindByPrimaryKey(string iD)
        {
            return (OptionRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new OptionRow(builder);
        }
        #endregion
    }

    public class OptionRow : DataRow
    {
        private OptionTable _tableOption;

        internal OptionRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableOption = ((OptionTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableOption.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableOption.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableOption.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableOption.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableOption.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableOption.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableOption.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableOption.NameColumn] = Convert.DBNull;
        }
        public string OptionGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableOption.OptionGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value OptionGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableOption.OptionGroupIDColumn] = value;
            }
        }
        public bool IsOptionGroupIDNull()
        {
            return this.IsNull(_tableOption.OptionGroupIDColumn);
        }
        public void SetOptionGroupIDNull()
        {
            this[_tableOption.OptionGroupIDColumn] = Convert.DBNull;
        }
        public string DataType
        {
            get
            {
                try
                {
                    return ((string)(this[_tableOption.DataTypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DataType because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableOption.DataTypeColumn] = value;
            }
        }
        public bool IsDataTypeNull()
        {
            return this.IsNull(_tableOption.DataTypeColumn);
        }
        public void SetDataTypeNull()
        {
            this[_tableOption.DataTypeColumn] = Convert.DBNull;
        }
        public string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableOption.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableOption.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableOption.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableOption.ValueColumn] = Convert.DBNull;
        }
        public string Description
        {
            get
            {
                try
                {
                    return ((string)(this[_tableOption.DescriptionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Description because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableOption.DescriptionColumn] = value;
            }
        }
        public bool IsDescriptionNull()
        {
            return this.IsNull(_tableOption.DescriptionColumn);
        }
        public void SetDescriptionNull()
        {
            this[_tableOption.DescriptionColumn] = Convert.DBNull;
        }
        #endregion
    }
}
