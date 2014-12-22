using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class AbsenceTable : DataTable, IEnumerable, IListTable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnCompany;
        private DataColumn _columnSI;

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

            _columnCompany = new DataColumn("Company", typeof(bool));
            _columnCompany.AllowDBNull = true;
            _columnCompany.Caption = "Company";
            _columnCompany.Unique = false;
            _columnCompany.DefaultValue = Convert.DBNull;
            _columnCompany.ExtendedProperties.Add("IsKey", "false");
            _columnCompany.ExtendedProperties.Add("ReadOnly", "false");
            _columnCompany.ExtendedProperties.Add("Description", "Company");
            _columnCompany.ExtendedProperties.Add("Decimals", "0");
            _columnCompany.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCompany);

            _columnSI = new DataColumn("SI", typeof(bool));
            _columnSI.AllowDBNull = true;
            _columnSI.Caption = "SI";
            _columnSI.Unique = false;
            _columnSI.DefaultValue = Convert.DBNull;
            _columnSI.ExtendedProperties.Add("IsKey", "false");
            _columnSI.ExtendedProperties.Add("ReadOnly", "false");
            _columnSI.ExtendedProperties.Add("Description", "SI");
            _columnSI.ExtendedProperties.Add("Decimals", "0");
            _columnSI.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSI);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public AbsenceTable()
            : base("Absence")
        {
            this.InitClass();
        }
        public AbsenceTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Absence_GetContent", Connection.GetConnection());
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
        public static AbsenceTable GetContentTable()
        {
            AbsenceTable absenceTable = new AbsenceTable();
            absenceTable.GetContent();
            return absenceTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Absence_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Company", SqlDbType.Bit, 1, "Company");
            sqlCommand.Parameters.Add("@SI", SqlDbType.Bit, 1, "SI");

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
            SqlCommand sqlCommand = new SqlCommand("Absence_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            sqlCommand.Parameters.Add("@Company", SqlDbType.Bit, 1, "Company");
            sqlCommand.Parameters.Add("@SI", SqlDbType.Bit, 1, "SI");

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
            SqlCommand sqlCommand = new SqlCommand("Absence_Delete", Connection.GetConnection());
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

            AbsenceRow row = FindByPrimaryKey(iD);
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
        public DataColumn CompanyColumn
        {
            get
            {
                return _columnCompany;
            }
        }
        public DataColumn SIColumn
        {
            get
            {
                return _columnSI;
            }
        }
        public AbsenceRow this[int index]
        {
            get
            {
                return ((AbsenceRow)(this.Rows[index]));
            }
        }
        public void AddAbsenceRow(AbsenceRow row)
        {
            this.Rows.Add(row);
        }
        public AbsenceRow AddAbsenceRow(string iD, string name, bool company, bool sI)
        {
            AbsenceRow rowAbsenceRow = ((AbsenceRow)(this.NewRow()));
            rowAbsenceRow["ID"] = iD;
            rowAbsenceRow["Name"] = name;
            rowAbsenceRow["Company"] = company;
            rowAbsenceRow["SI"] = sI;
            this.Rows.Add(rowAbsenceRow);
            return rowAbsenceRow;
        }
        public AbsenceRow FindByPrimaryKey(string iD)
        {
            return (AbsenceRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AbsenceRow(builder);
        }
        public DataColumnCollection GetColumns()
        {
            return Columns;
        }
        #endregion
    }

    public class AbsenceRow : DataRow
    {
        private AbsenceTable _tableAbsence;

        internal AbsenceRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableAbsence = ((AbsenceTable)(this.Table));
        }

        #region Properties
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAbsence.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAbsence.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableAbsence.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableAbsence.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableAbsence.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAbsence.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableAbsence.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableAbsence.NameColumn] = Convert.DBNull;
        }
        public bool Company
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableAbsence.CompanyColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Company because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAbsence.CompanyColumn] = value;
            }
        }
        public bool IsCompanyNull()
        {
            return this.IsNull(_tableAbsence.CompanyColumn);
        }
        public void SetCompanyNull()
        {
            this[_tableAbsence.CompanyColumn] = Convert.DBNull;
        }
        public bool SI
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableAbsence.SIColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SI because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableAbsence.SIColumn] = value;
            }
        }
        public bool IsSINull()
        {
            return this.IsNull(_tableAbsence.SIColumn);
        }
        public void SetSINull()
        {
            this[_tableAbsence.SIColumn] = Convert.DBNull;
        }
        #endregion
    }
}
