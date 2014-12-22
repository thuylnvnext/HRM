using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class TitleTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnItem;
        private DataColumn _columnLanguage;
        private DataColumn _columnValue;
        private DataColumn _columnDescription;

        private void InitClass()
        {
            _columnItem = new DataColumn("Item", typeof(string));
            _columnItem.AllowDBNull = false;
            _columnItem.Caption = "Item";
            _columnItem.MaxLength = 100;
            _columnItem.Unique = false;
            _columnItem.DefaultValue = Convert.DBNull;
            _columnItem.ExtendedProperties.Add("IsKey", "true");
            _columnItem.ExtendedProperties.Add("ReadOnly", "false");
            _columnItem.ExtendedProperties.Add("Description", "Item");
            _columnItem.ExtendedProperties.Add("Length", "100");
            _columnItem.ExtendedProperties.Add("Decimals", "0");
            _columnItem.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnItem);

            _columnLanguage = new DataColumn("Language", typeof(string));
            _columnLanguage.AllowDBNull = false;
            _columnLanguage.Caption = "Language";
            _columnLanguage.MaxLength = 50;
            _columnLanguage.Unique = false;
            _columnLanguage.DefaultValue = Convert.DBNull;
            _columnLanguage.ExtendedProperties.Add("IsKey", "true");
            _columnLanguage.ExtendedProperties.Add("ReadOnly", "false");
            _columnLanguage.ExtendedProperties.Add("Description", "Language");
            _columnLanguage.ExtendedProperties.Add("Length", "50");
            _columnLanguage.ExtendedProperties.Add("Decimals", "0");
            _columnLanguage.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnLanguage);

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

            _columnDescription = new DataColumn("Description", typeof(string));
            _columnDescription.AllowDBNull = true;
            _columnDescription.Caption = "Description";
            _columnDescription.MaxLength = 100;
            _columnDescription.Unique = false;
            _columnDescription.DefaultValue = Convert.DBNull;
            _columnDescription.ExtendedProperties.Add("IsKey", "false");
            _columnDescription.ExtendedProperties.Add("ReadOnly", "false");
            _columnDescription.ExtendedProperties.Add("Description", "Description");
            _columnDescription.ExtendedProperties.Add("Length", "100");
            _columnDescription.ExtendedProperties.Add("Decimals", "0");
            _columnDescription.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDescription);

            this.PrimaryKey = new DataColumn[] { this.Columns["Item"], this.Columns["Language"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public TitleTable()
            : base("Title")
        {
            this.InitClass();
        }
        public TitleTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Title_GetContent", Connection.GetConnection());
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
        public static TitleTable GetContentTable()
        {
            TitleTable titleTable = new TitleTable();
            titleTable.GetContent();
            return titleTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Title_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100, "Item");
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50, "Language");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NVarChar, (int)Math.Pow(2, 31) - 1, "Value");
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 100, "Description");

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
            SqlCommand sqlCommand = new SqlCommand("Title_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalItem", SqlDbType.VarChar, 100, "Item").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalLanguage", SqlDbType.NVarChar, 50, "Language").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100, "Item");
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50, "Language");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NVarChar, (int)Math.Pow(2, 31) - 1, "Value");
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 100, "Description");

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
            SqlCommand sqlCommand = new SqlCommand("Title_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100, "Item");
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50, "Language");

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
        public bool Delete(string item, string language)
        {
            bool retVal;

            TitleRow row = FindByPrimaryKey(item, language);
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
        public DataColumn ItemColumn
        {
            get
            {
                return _columnItem;
            }
        }
        public DataColumn LanguageColumn
        {
            get
            {
                return _columnLanguage;
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
        public TitleRow this[int index]
        {
            get
            {
                return ((TitleRow)(this.Rows[index]));
            }
        }
        public void AddTitleRow(TitleRow row)
        {
            this.Rows.Add(row);
        }
        public TitleRow AddTitleRow(string item, string language, string value, string description)
        {
            TitleRow rowTitleRow = ((TitleRow)(this.NewRow()));
            rowTitleRow["Item"] = item;
            rowTitleRow["Language"] = language;
            rowTitleRow["Value"] = value;
            rowTitleRow["Description"] = description;
            this.Rows.Add(rowTitleRow);
            return rowTitleRow;
        }
        public TitleRow FindByPrimaryKey(string item, string language)
        {
            return (TitleRow)(Rows.Find(new object[] { item, language }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new TitleRow(builder);
        }
        public int GetListByForm(string form, string language)
        {
            SqlCommand sqlCommand = new SqlCommand("Title_GetListByForm", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Form", SqlDbType.VarChar, 50).Value = form;
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 20).Value = language;

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
        public static string GetValue(string iD, string language)
        {
            string retVal = string.Empty;
            SqlCommand sqlCommand = new SqlCommand("Title_GetValue", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = iD;
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 20).Value = language;

            try
            {
                Connection.Open();
                retVal = (string)sqlCommand.ExecuteScalar();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            if (retVal == null) retVal = string.Empty;

            return retVal;
        }
        public static TitleTable GetLanguages()
        {
            TitleTable title = new TitleTable();
            SqlCommand sqlCommand = new SqlCommand("Title_GetLanguages", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(title);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return title;
        }
        public static bool EditItem(string originalItem, string item, string description)
        {
            SqlCommand sqlCommand = new SqlCommand("Title_EditItem", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalItem", SqlDbType.VarChar, 100).Value = originalItem;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100).Value = item;
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = description;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public static bool EditValue(string item, string originalLanguage, string language, string value)
        {
            SqlCommand sqlCommand = new SqlCommand("Title_EditValue", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100).Value = item;
            sqlCommand.Parameters.Add("@OriginalLanguage", SqlDbType.NVarChar, 50).Value = originalLanguage;
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 100).Value = language;
            sqlCommand.Parameters.Add("@Value", SqlDbType.NVarChar, (int)Math.Pow(2, 31) - 1).Value = value;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public static bool Insert(string item, string language, string value, string description)
        {
            SqlCommand sqlCommand = new SqlCommand("Title_Insert", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100).Value = item;
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 100).Value = language;
            sqlCommand.Parameters.Add("@Value", SqlDbType.NVarChar, (int)Math.Pow(2, 31) - 1).Value = value;
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = description;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public static bool DeleteItem(string item)
        {
            SqlCommand sqlCommand = new SqlCommand("Title_DeleteItem", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100).Value = item;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        public static bool DeleteLanguage(string item, string language)
        {
            SqlCommand sqlCommand = new SqlCommand("Title_Delete", Connection.GetConnection());
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 100).Value = item;
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50).Value = language;
            try
            {
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        #endregion
    }

    public class TitleRow : DataRow
    {
        private TitleTable _tableTitle;

        internal TitleRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableTitle = ((TitleTable)(this.Table));
        }

        #region Properties
        public string Item
        {
            get
            {
                try
                {
                    return ((string)(this[_tableTitle.ItemColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Item because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTitle.ItemColumn] = value;
            }
        }
        public bool IsItemNull()
        {
            return this.IsNull(_tableTitle.ItemColumn);
        }
        public void SetItemNull()
        {
            this[_tableTitle.ItemColumn] = Convert.DBNull;
        }
        public string Language
        {
            get
            {
                try
                {
                    return ((string)(this[_tableTitle.LanguageColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Language because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTitle.LanguageColumn] = value;
            }
        }
        public bool IsLanguageNull()
        {
            return this.IsNull(_tableTitle.LanguageColumn);
        }
        public void SetLanguageNull()
        {
            this[_tableTitle.LanguageColumn] = Convert.DBNull;
        }
        public string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableTitle.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTitle.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableTitle.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableTitle.ValueColumn] = Convert.DBNull;
        }
        public string Description
        {
            get
            {
                try
                {
                    return ((string)(this[_tableTitle.DescriptionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Description because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableTitle.DescriptionColumn] = value;
            }
        }
        public bool IsDescriptionNull()
        {
            return this.IsNull(_tableTitle.DescriptionColumn);
        }
        public void SetDescriptionNull()
        {
            this[_tableTitle.DescriptionColumn] = Convert.DBNull;
        }
        #endregion
    }
}
