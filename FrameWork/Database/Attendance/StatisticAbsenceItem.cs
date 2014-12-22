using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class StatisticAbsenceItemTable : StatisticItemT
    {
        #region Private
        private DataColumn _columnParentID;
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnValue;
        private DataColumn _columnComputedValue;

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
            _columnValue.MaxLength = 250;
            _columnValue.Unique = false;
            _columnValue.DefaultValue = Convert.DBNull;
            _columnValue.ExtendedProperties.Add("IsKey", "false");
            _columnValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnValue.ExtendedProperties.Add("Description", "Value");
            _columnValue.ExtendedProperties.Add("Length", "250");
            _columnValue.ExtendedProperties.Add("Decimals", "0");
            _columnValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnValue);

            _columnComputedValue = new DataColumn("ComputedValue", typeof(string));
            _columnComputedValue.AllowDBNull = true;
            _columnComputedValue.Caption = "Computed Value";
            _columnComputedValue.MaxLength = 250;
            _columnComputedValue.Unique = false;
            _columnComputedValue.DefaultValue = Convert.DBNull;
            _columnComputedValue.ExtendedProperties.Add("IsKey", "false");
            _columnComputedValue.ExtendedProperties.Add("ReadOnly", "false");
            _columnComputedValue.ExtendedProperties.Add("Description", "Computed Value");
            _columnComputedValue.ExtendedProperties.Add("Length", "250");
            _columnComputedValue.ExtendedProperties.Add("Decimals", "0");
            _columnComputedValue.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnComputedValue);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        #endregion

        #region Constructors
        public StatisticAbsenceItemTable()
            : base("StatisticAbsenceItem")
        {
            this.InitClass();
        }
        public StatisticAbsenceItemTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public override void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("StatisticAbsenceItem_GetContent", Connection.GetConnection());
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
        public static StatisticAbsenceItemTable GetContentTable()
        {
            StatisticAbsenceItemTable statisticAbsenceItemTable = new StatisticAbsenceItemTable();
            statisticAbsenceItemTable.GetContent();
            return statisticAbsenceItemTable;
        }
        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("StatisticAbsenceItem_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ParentID", SqlDbType.VarChar, 10, "ParentID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Value", SqlDbType.VarChar, 250, "Value");
            sqlCommand.Parameters.Add("@ComputedValue", SqlDbType.VarChar, 250, "ComputedValue");

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
            SqlCommand sqlCommand = new SqlCommand("StatisticAbsenceItem_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ParentID", SqlDbType.VarChar, 10, "ParentID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Value", SqlDbType.VarChar, 250, "Value");
            sqlCommand.Parameters.Add("@ComputedValue", SqlDbType.VarChar, 250, "ComputedValue");

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
            SqlCommand sqlCommand = new SqlCommand("StatisticAbsenceItem_Delete", Connection.GetConnection());
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

            StatisticAbsenceItemRow row = FindByPrimaryKey(iD);
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
        public DataColumn ValueColumn
        {
            get
            {
                return _columnValue;
            }
        }
        public DataColumn ComputedValueColumn
        {
            get
            {
                return _columnComputedValue;
            }
        }
        public override StatisticItemR this[int index]
        {
            get
            {
                return ((StatisticItemR)(this.Rows[index]));
            }
        }
        public void AddStatisticAbsenceItemRow(StatisticAbsenceItemRow row)
        {
            this.Rows.Add(row);
        }
        public StatisticAbsenceItemRow AddStatisticAbsenceItemRow(string parentID, string iD, string name, string value, string computedValue)
        {
            StatisticAbsenceItemRow rowStatisticAbsenceItemRow = ((StatisticAbsenceItemRow)(this.NewRow()));
            rowStatisticAbsenceItemRow["ParentID"] = parentID;
            rowStatisticAbsenceItemRow["ID"] = iD;
            rowStatisticAbsenceItemRow["Name"] = name;
            rowStatisticAbsenceItemRow["Value"] = value;
            rowStatisticAbsenceItemRow["ComputedValue"] = computedValue;
            this.Rows.Add(rowStatisticAbsenceItemRow);
            return rowStatisticAbsenceItemRow;
        }
        public override StatisticItemR AddStatisticItemRow(string parentID, string iD, string name, string value, string computedValue)
        {
            StatisticItemR rowStatisticAbsenceItemRow = ((StatisticItemR)(this.NewRow()));
            rowStatisticAbsenceItemRow["ParentID"] = parentID;
            rowStatisticAbsenceItemRow["ID"] = iD;
            rowStatisticAbsenceItemRow["Name"] = name;
            rowStatisticAbsenceItemRow["Value"] = value;
            rowStatisticAbsenceItemRow["ComputedValue"] = computedValue;
            this.Rows.Add(rowStatisticAbsenceItemRow);
            return rowStatisticAbsenceItemRow;
        }
        public StatisticAbsenceItemRow FindByPrimaryKey(string iD)
        {
            return (StatisticAbsenceItemRow)(Rows.Find(new object[] { iD }));
        }
        public override StatisticItemR FindByID(string iD)
        {
            return (StatisticItemR)(Rows.Find(new object[] { iD }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new StatisticAbsenceItemRow(builder);
        }
        public override string GetNewID()
        {
            SqlCommand sqlCommand = new SqlCommand("StatisticAbsenceItem_GetNewID", Connection.GetConnection());
            string retVal = string.Empty;

            sqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                Connection.Open();
                retVal = sqlCommand.ExecuteScalar().ToString();
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
        public override int GetListByValue()
        {
            SqlCommand sqlCommand = new SqlCommand("StatisticAbsenceItem_GetListByValue", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
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

    public class StatisticAbsenceItemRow : StatisticItemR
    {
        private StatisticAbsenceItemTable _tableStatisticAbsenceItem;

        internal StatisticAbsenceItemRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableStatisticAbsenceItem = ((StatisticAbsenceItemTable)(this.Table));
        }

        #region Properties
        public override string ParentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableStatisticAbsenceItem.ParentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ParentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableStatisticAbsenceItem.ParentIDColumn] = value;
            }
        }
        public override bool IsParentIDNull()
        {
            return this.IsNull(_tableStatisticAbsenceItem.ParentIDColumn);
        }
        public void SetParentIDNull()
        {
            this[_tableStatisticAbsenceItem.ParentIDColumn] = Convert.DBNull;
        }
        public override string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableStatisticAbsenceItem.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableStatisticAbsenceItem.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableStatisticAbsenceItem.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableStatisticAbsenceItem.IDColumn] = Convert.DBNull;
        }
        public override string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableStatisticAbsenceItem.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableStatisticAbsenceItem.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableStatisticAbsenceItem.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableStatisticAbsenceItem.NameColumn] = Convert.DBNull;
        }
        public override string Value
        {
            get
            {
                try
                {
                    return ((string)(this[_tableStatisticAbsenceItem.ValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Value because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableStatisticAbsenceItem.ValueColumn] = value;
            }
        }
        public override bool IsValueNull()
        {
            return this.IsNull(_tableStatisticAbsenceItem.ValueColumn);
        }
        public void SetValueNull()
        {
            this[_tableStatisticAbsenceItem.ValueColumn] = Convert.DBNull;
        }
        public override string ComputedValue
        {
            get
            {
                try
                {
                    return ((string)(this[_tableStatisticAbsenceItem.ComputedValueColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ComputedValue because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableStatisticAbsenceItem.ComputedValueColumn] = value;
            }
        }
        public bool IsComputedValueNull()
        {
            return this.IsNull(_tableStatisticAbsenceItem.ComputedValueColumn);
        }
        public void SetComputedValueNull()
        {
            this[_tableStatisticAbsenceItem.ComputedValueColumn] = Convert.DBNull;
        }
        #endregion
    }
}
