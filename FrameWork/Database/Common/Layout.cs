using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class LayoutTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnItem;
        private DataColumn _columnMonth;
        private DataColumn _columnYear;
        private DataColumn _columnLanguage;
        private DataColumn _columnValue;

        private void InitClass()
        {
            _columnItem = new DataColumn("Item", typeof(string));
            _columnItem.AllowDBNull = false;
            _columnItem.Caption = "Item";
            _columnItem.MaxLength = 50;
            _columnItem.Unique = false;
            _columnItem.DefaultValue = Convert.DBNull;
            _columnItem.ExtendedProperties.Add("IsKey", "true");
            _columnItem.ExtendedProperties.Add("ReadOnly", "false");
            _columnItem.ExtendedProperties.Add("Description", "Item");
            _columnItem.ExtendedProperties.Add("Length", "50");
            _columnItem.ExtendedProperties.Add("Decimals", "0");
            _columnItem.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnItem);

            _columnMonth = new DataColumn("Month", typeof(byte));
            _columnMonth.AllowDBNull = false;
            _columnMonth.Caption = "Month";
            _columnMonth.Unique = false;
            _columnMonth.DefaultValue = Convert.DBNull;
            _columnMonth.ExtendedProperties.Add("IsKey", "true");
            _columnMonth.ExtendedProperties.Add("ReadOnly", "false");
            _columnMonth.ExtendedProperties.Add("Description", "Month");
            _columnMonth.ExtendedProperties.Add("Decimals", "0");
            _columnMonth.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnMonth);

            _columnYear = new DataColumn("Year", typeof(short));
            _columnYear.AllowDBNull = false;
            _columnYear.Caption = "Year";
            _columnYear.Unique = false;
            _columnYear.DefaultValue = Convert.DBNull;
            _columnYear.ExtendedProperties.Add("IsKey", "true");
            _columnYear.ExtendedProperties.Add("ReadOnly", "false");
            _columnYear.ExtendedProperties.Add("Description", "Year");
            _columnYear.ExtendedProperties.Add("Decimals", "0");
            _columnYear.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnYear);

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
            _columnValue.MaxLength = 1073741823;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "1073741823");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            this.PrimaryKey = new DataColumn[] { this.Columns["Item"], this.Columns["Month"], this.Columns["Year"], this.Columns["Language"] };
        }
        #endregion

        #region Constructors
        public LayoutTable()
            : base("Layout")
        {
            this.InitClass();
        }
        public LayoutTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Layout_GetContent", Connection.GetConnection());
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
        public static LayoutTable GetContentTable()
        {
            LayoutTable layoutTable = new LayoutTable();
            layoutTable.GetContent();
            return layoutTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Layout_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 50, "Item");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50, "Language");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, (int)Math.Pow(2, 30) - 1, "Value");
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
            SqlCommand sqlCommand = new SqlCommand("Layout_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalItem", SqlDbType.VarChar, 50, "Item").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalMonth", SqlDbType.TinyInt, 1, "Month").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalYear", SqlDbType.SmallInt, 2, "Year").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalLanguage", SqlDbType.NVarChar, 50, "Language").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 50, "Item");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50, "Language");
            sqlCommand.Parameters.Add("@Value", SqlDbType.NText, (int)Math.Pow(2, 30) - 1, "Value");

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
            SqlCommand sqlCommand = new SqlCommand("Layout_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 50, "Item");
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1, "Month");
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2, "Year");
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
        public bool Delete(string item, byte month, short year, string language)
        {
            bool retVal;

            LayoutRow row = FindByPrimaryKey(item, month, year, language);
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
        public DataColumn MonthColumn
        {
            get
            {
                return _columnMonth;
            }
        }
        public DataColumn YearColumn
        {
            get
            {
                return _columnYear;
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
        public LayoutRow this[int index]
        {
            get
            {
                return ((LayoutRow)(this.Rows[index]));
            }
        }
        public void AddLayoutRow(LayoutRow row)
        {
            this.Rows.Add(row);
        }
        public LayoutRow AddLayoutRow(string item, byte month, short year, string language, string value)
        {
            LayoutRow rowLayoutRow = ((LayoutRow)(this.NewRow()));
            rowLayoutRow["Item"] = item;
            rowLayoutRow["Month"] = month;
            rowLayoutRow["Year"] = year;
            rowLayoutRow["Language"] = language;
            rowLayoutRow["Value"] = value;
            this.Rows.Add(rowLayoutRow);
            return rowLayoutRow;
        }
        public LayoutRow FindByPrimaryKey(string item, byte month, short year, string language)
        {
            return (LayoutRow)(Rows.Find(new object[] { item, month, year, language }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new LayoutRow(builder);
        }
        public static string GetValueByItem(string item, byte month, Int16 year, string language)
        {
            SqlCommand sqlCommand = new SqlCommand("Layout_GetValueByItem", Connection.GetConnection());
            string retVal = string.Empty;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Item", SqlDbType.VarChar, 50).Value = item;
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1).Value = month;
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2).Value = year;
            sqlCommand.Parameters.Add("@Language", SqlDbType.NVarChar, 50).Value = language;

            try
            {
                Connection.Open();
                retVal = Convert.ToString(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = string.Empty;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        #endregion
    }

    public class LayoutRow : DataRow
    {
        private LayoutTable _tableLayout;

        internal LayoutRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableLayout = ((LayoutTable)(this.Table));
        }

        #region Properties
        public string Item
        {
            get
            {
                try
                {
                    return ((string)(this[_tableLayout.ItemColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Item because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLayout.ItemColumn] = value;
            }
        }
        public bool IsItemNull()
        {
            return this.IsNull(_tableLayout.ItemColumn);
        }
        public void SetItemNull()
        {
            this[_tableLayout.ItemColumn] = Convert.DBNull;
        }
        public byte Month
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableLayout.MonthColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Month because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLayout.MonthColumn] = value;
            }
        }
        public bool IsMonthNull()
        {
            return this.IsNull(_tableLayout.MonthColumn);
        }
        public void SetMonthNull()
        {
            this[_tableLayout.MonthColumn] = Convert.DBNull;
        }
        public short Year
        {
            get
            {
                try
                {
                    return ((short)(this[_tableLayout.YearColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Year because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLayout.YearColumn] = value;
            }
        }
        public bool IsYearNull()
        {
            return this.IsNull(_tableLayout.YearColumn);
        }
        public void SetYearNull()
        {
            this[_tableLayout.YearColumn] = Convert.DBNull;
        }
        public string Language
        {
            get
            {
                try
                {
                    return ((string)(this[_tableLayout.LanguageColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Language because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLayout.LanguageColumn] = value;
            }
        }
        public bool IsLanguageNull()
        {
            return this.IsNull(_tableLayout.LanguageColumn);
        }
        public void SetLanguageNull()
        {
            this[_tableLayout.LanguageColumn] = Convert.DBNull;
        }
        public string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableLayout.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableLayout.ValueColumn] = value;
            }
        }
        public bool IsValueNull()
        {
            return this.IsNull(_tableLayout.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableLayout.ValueColumn] = Convert.DBNull;
        }
        #endregion
    }
}
