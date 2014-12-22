using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ConstantTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnValue;
        private DataColumn _columnDescription;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(int));
            _columnID.AllowDBNull = false;
            _columnID.Caption = "ID";
            _columnID.Unique = true;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "true");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
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

            _columnValue = new DataColumn("Value", typeof(string));
            _columnValue.AllowDBNull = true;
            _columnValue.Caption = "Value";
            _columnValue.MaxLength = 16;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "16");
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
        public ConstantTable()
            : base("Constant")
        {
            this.InitClass();
        }
        public ConstantTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Constant_GetContent", Connection.GetConnection());
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
        public static ConstantTable GetContentTable()
        {
            ConstantTable constantTable = new ConstantTable();
            constantTable.GetContent();
            return constantTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Constant_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, 16, "Value");
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
            SqlCommand sqlCommand = new SqlCommand("Constant_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.Int, 4, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, 16, "Value");
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
            SqlCommand sqlCommand = new SqlCommand("Constant_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");

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
        public bool Delete(int iD)
        {
            bool retVal;

            ConstantRow row = FindByPrimaryKey(iD);
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
        public ConstantRow this[int index]
        {
            get
            {
                return ((ConstantRow)(this.Rows[index]));
            }
        }
        public void AddConstantRow(ConstantRow row)
        {
            this.Rows.Add(row);
        }
        public ConstantRow AddConstantRow(int iD, string name, string value, string description)
        {
            ConstantRow rowConstantRow = ((ConstantRow)(this.NewRow()));
            rowConstantRow["ID"] = iD;
            rowConstantRow["Name"] = name;
            rowConstantRow["Value"] = value;
            rowConstantRow["Description"] = description;
            this.Rows.Add(rowConstantRow);
            return rowConstantRow;
        }
        public ConstantRow FindByPrimaryKey(int iD)
        {
            return (ConstantRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ConstantRow(builder);
        }
        public static string GetValueByName(string name)
        {
            string value = string.Empty;

            SqlCommand sqlCommand = new SqlCommand("Constant_GetValueByName", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
            try
            {
                Connection.Open();
                value = (string)sqlCommand.ExecuteScalar();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return value;
        }
        public ConstantRow FindByName(string name)
        {
            ConstantRow cr = null;
            foreach (ConstantRow _cr in this)
            {
                if (_cr.Name == name)
                {
                    cr = _cr;
                    break;
                }
            }
            return cr;
        }
        #endregion
    }

    public class ConstantRow : DataRow
    {
        private ConstantTable _tableConstant;

        internal ConstantRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableConstant = ((ConstantTable)(this.Table));
        }

        #region Properties
        public int ID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableConstant.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableConstant.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableConstant.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableConstant.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableConstant.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableConstant.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableConstant.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableConstant.NameColumn] = Convert.DBNull;
        }
        public string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableConstant.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableConstant.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableConstant.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableConstant.ValueColumn] = Convert.DBNull;
        }
        public string Description
        {
            get
            {
                try
                {
                    return ((string)(this[_tableConstant.DescriptionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Description because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableConstant.DescriptionColumn] = value;
            }
        }
        public bool IsDescriptionNull()
        {
            return this.IsNull(_tableConstant.DescriptionColumn);
        }
        public void SetDescriptionNull()
        {
            this[_tableConstant.DescriptionColumn] = Convert.DBNull;
        }
        #endregion
    }
}
