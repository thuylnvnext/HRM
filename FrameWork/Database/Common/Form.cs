using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class FormTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnName;
        private DataColumn _columnValue;

        private void InitClass()
        {
            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = false;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 50;
            _columnName.Unique = true;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "true");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "50");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnName);

            _columnValue = new DataColumn("Value", typeof(string));
            _columnValue.AllowDBNull = true;
            _columnValue.Caption = "Value";
            _columnValue.MaxLength = 2147483647;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "2147483647");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            this.PrimaryKey = new DataColumn[] { this.Columns["Name"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public FormTable()
            : base("Form")
        {
            this.InitClass();
        }
        public FormTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Form_GetContent", Connection.GetConnection());
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
        public static FormTable GetContentTable()
        {
            FormTable formTable = new FormTable();
            formTable.GetContent();
            return formTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Form_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, (int)Math.Pow(2, 31) - 1, "Value");

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
            SqlCommand sqlCommand = new SqlCommand("Form_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalName", SqlDbType.VarChar, 50, "Name").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, (int)Math.Pow(2, 31) - 1, "Value");

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
            SqlCommand sqlCommand = new SqlCommand("Form_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");

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
        public bool Delete(string name)
        {
            bool retVal;

            FormRow row = FindByPrimaryKey(name);
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
        public FormRow this[int index]
        {
            get
            {
                return ((FormRow)(this.Rows[index]));
            }
        }
        public void AddFormRow(FormRow row)
        {
            this.Rows.Add(row);
        }
        public FormRow AddFormRow(string name, string value)
        {
            FormRow rowFormRow = ((FormRow)(this.NewRow()));
            rowFormRow["Name"] = name;
            rowFormRow["Value"] = value;
            this.Rows.Add(rowFormRow);
            return rowFormRow;
        }
        public FormRow FindByPrimaryKey(string name)
        {
            return (FormRow)(Rows.Find(new object[] { name }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new FormRow(builder);
        }
        #endregion
    }

    public class FormRow : DataRow
    {
        private FormTable _tableForm;

        internal FormRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableForm = ((FormTable)(this.Table));
        }

        #region Properties
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableForm.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableForm.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableForm.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableForm.NameColumn] = Convert.DBNull;
        }
        public string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableForm.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableForm.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableForm.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableForm.ValueColumn] = Convert.DBNull;
        }
        #endregion
    }
}
