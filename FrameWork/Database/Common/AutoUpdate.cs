using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AutoUpdateTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnFile;

        private void InitClass()
        {
            _columnFile = new DataColumn("File", typeof(string));
            _columnFile.AllowDBNull = false;
            _columnFile.Caption = "File";
            _columnFile.MaxLength = 100;
            _columnFile.Unique = true;
            _columnFile.DefaultValue = Convert.DBNull;
            _columnFile.ExtendedProperties.Add("IsKey", "true");
            _columnFile.ExtendedProperties.Add("ReadOnly", "false");
            _columnFile.ExtendedProperties.Add("Description", "File");
            _columnFile.ExtendedProperties.Add("Length", "100");
            _columnFile.ExtendedProperties.Add("Decimals", "0");
            _columnFile.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFile);

            this.PrimaryKey = new DataColumn[] { this.Columns["File"] };
        }
        #endregion

        #region Constructors
        public AutoUpdateTable()
            : base("AutoUpdate")
        {
            this.InitClass();
        }
        public AutoUpdateTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("AutoUpdate_GetContent", Connection.GetConnection());
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
        public static AutoUpdateTable GetContentTable()
        {
            AutoUpdateTable autoUpdateTable = new AutoUpdateTable();
            autoUpdateTable.GetContent();
            return autoUpdateTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("AutoUpdate_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@File", SqlDbType.NVarChar, 100, "File");

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
            SqlCommand sqlCommand = new SqlCommand("AutoUpdate_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalFile", SqlDbType.NVarChar, 100, "File").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@File", SqlDbType.NVarChar, 100, "File");

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
            SqlCommand sqlCommand = new SqlCommand("AutoUpdate_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@File", SqlDbType.NVarChar, 100, "File");

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
        public bool Delete(string file)
        {
            bool retVal;

            AutoUpdateRow row = FindByPrimaryKey(file);
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
        public DataColumn FileColumn
        {
            get
            {
                return _columnFile;
            }
        }
        public AutoUpdateRow this[int index]
        {
            get
            {
                return ((AutoUpdateRow)(this.Rows[index]));
            }
        }
        public void AddAutoUpdateRow(AutoUpdateRow row)
        {
            this.Rows.Add(row);
        }
        public AutoUpdateRow AddAutoUpdateRow(string file)
        {
            AutoUpdateRow rowAutoUpdateRow = ((AutoUpdateRow)(this.NewRow()));
            rowAutoUpdateRow["File"] = file;
            this.Rows.Add(rowAutoUpdateRow);
            return rowAutoUpdateRow;
        }
        public AutoUpdateRow FindByPrimaryKey(string file)
        {
            return (AutoUpdateRow)(Rows.Find(new object[] { file }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AutoUpdateRow(builder);
        }
        #endregion
    }

    public class AutoUpdateRow : DataRow
    {
        private AutoUpdateTable _tableAutoUpdate;

        internal AutoUpdateRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAutoUpdate = ((AutoUpdateTable)(this.Table));
        }

        #region Properties
        public string File
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAutoUpdate.FileColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value File because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAutoUpdate.FileColumn] = value;
            }
        }
        public bool IsFileNull()
        {
            return this.IsNull(_tableAutoUpdate.FileColumn);
        }
        public void SetFileNull()
        {
            this[_tableAutoUpdate.FileColumn] = Convert.DBNull;
        }
        #endregion
    }
}
