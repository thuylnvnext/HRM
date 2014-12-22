using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class IdentificationTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnNo;
        private DataColumn _columnIssuedDate;
        private DataColumn _columnIssuedPlace;

        private void InitClass()
        {
            _columnEmployeeID = new DataColumn("EmployeeID", typeof(int));
            _columnEmployeeID.AllowDBNull = false;
            _columnEmployeeID.Caption = "Employee ID";
            _columnEmployeeID.Unique = true;
            _columnEmployeeID.DefaultValue = Convert.DBNull;
            _columnEmployeeID.ExtendedProperties.Add("IsKey", "true");
            _columnEmployeeID.ExtendedProperties.Add("ReadOnly", "false");
            _columnEmployeeID.ExtendedProperties.Add("Description", "Employee ID");
            _columnEmployeeID.ExtendedProperties.Add("Decimals", "0");
            _columnEmployeeID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnEmployeeID);

            _columnNo = new DataColumn("No", typeof(string));
            _columnNo.AllowDBNull = false;
            _columnNo.Caption = "No";
            _columnNo.MaxLength = 9;
            _columnNo.Unique = false;
            _columnNo.DefaultValue = Convert.DBNull;
            _columnNo.ExtendedProperties.Add("IsKey", "false");
            _columnNo.ExtendedProperties.Add("ReadOnly", "false");
            _columnNo.ExtendedProperties.Add("Description", "No");
            _columnNo.ExtendedProperties.Add("Length", "9");
            _columnNo.ExtendedProperties.Add("Decimals", "0");
            _columnNo.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnNo);

            _columnIssuedDate = new DataColumn("IssuedDate", typeof(DateTime));
            _columnIssuedDate.AllowDBNull = true;
            _columnIssuedDate.Caption = "Issued Date";
            _columnIssuedDate.Unique = false;
            _columnIssuedDate.DefaultValue = Convert.DBNull;
            _columnIssuedDate.ExtendedProperties.Add("IsKey", "false");
            _columnIssuedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnIssuedDate.ExtendedProperties.Add("Description", "Issued Date");
            _columnIssuedDate.ExtendedProperties.Add("Decimals", "0");
            _columnIssuedDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnIssuedDate);

            _columnIssuedPlace = new DataColumn("IssuedPlace", typeof(string));
            _columnIssuedPlace.AllowDBNull = true;
            _columnIssuedPlace.Caption = "Issued Place";
            _columnIssuedPlace.MaxLength = 50;
            _columnIssuedPlace.Unique = false;
            _columnIssuedPlace.DefaultValue = Convert.DBNull;
            _columnIssuedPlace.ExtendedProperties.Add("IsKey", "false");
            _columnIssuedPlace.ExtendedProperties.Add("ReadOnly", "false");
            _columnIssuedPlace.ExtendedProperties.Add("Description", "Issued Place");
            _columnIssuedPlace.ExtendedProperties.Add("Length", "50");
            _columnIssuedPlace.ExtendedProperties.Add("Decimals", "0");
            _columnIssuedPlace.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnIssuedPlace);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"] };
        }
        #endregion

        #region Constructors
        public IdentificationTable()
            : base("Identification")
        {
            this.InitClass();
        }
        public IdentificationTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Identification_GetContent", Connection.GetConnection());
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
        public static IdentificationTable GetContentTable()
        {
            IdentificationTable identificationTable = new IdentificationTable();
            identificationTable.GetContent();
            return identificationTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Identification_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@No", SqlDbType.VarChar, 9, "No");
            sqlCommand.Parameters.Add("@IssuedDate", SqlDbType.DateTime, 8, "IssuedDate");
            sqlCommand.Parameters.Add("@IssuedPlace", SqlDbType.NVarChar, 50, "IssuedPlace");

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
            SqlCommand sqlCommand = new SqlCommand("Identification_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@No", SqlDbType.VarChar, 9, "No");
            sqlCommand.Parameters.Add("@IssuedDate", SqlDbType.DateTime, 8, "IssuedDate");
            sqlCommand.Parameters.Add("@IssuedPlace", SqlDbType.NVarChar, 50, "IssuedPlace");

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
            SqlCommand sqlCommand = new SqlCommand("Identification_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");

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
        public bool Delete(int employeeID)
        {
            bool retVal;

            IdentificationRow row = FindByPrimaryKey(employeeID);
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
        public DataColumn EmployeeIDColumn
        {
            get
            {
                return _columnEmployeeID;
            }
        }
        public DataColumn NoColumn
        {
            get
            {
                return _columnNo;
            }
        }
        public DataColumn IssuedDateColumn
        {
            get
            {
                return _columnIssuedDate;
            }
        }
        public DataColumn IssuedPlaceColumn
        {
            get
            {
                return _columnIssuedPlace;
            }
        }
        public IdentificationRow this[int index]
        {
            get
            {
                return ((IdentificationRow)(this.Rows[index]));
            }
        }
        public void AddIdentificationRow(IdentificationRow row)
        {
            this.Rows.Add(row);
        }
        public IdentificationRow AddIdentificationRow(int employeeID, string no, DateTime issuedDate, string issuedPlace)
        {
            IdentificationRow rowIdentificationRow = ((IdentificationRow)(this.NewRow()));
            rowIdentificationRow["EmployeeID"] = employeeID;
            rowIdentificationRow["No"] = no;
            rowIdentificationRow["IssuedDate"] = issuedDate;
            rowIdentificationRow["IssuedPlace"] = issuedPlace;
            this.Rows.Add(rowIdentificationRow);
            return rowIdentificationRow;
        }
        public IdentificationRow FindByPrimaryKey(int employeeID)
        {
            return (IdentificationRow)(Rows.Find(new object[] { employeeID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new IdentificationRow(builder);
        }
        public static IdentificationRow GetInfoByEmpployeeID(int employeeID)
        {
            IdentificationTable identification = new IdentificationTable();
            SqlCommand sqlCommand = new SqlCommand("Identification_GetInfoByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(identification);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return identification.FindByPrimaryKey(employeeID);
        }
        #endregion
    }

    public class IdentificationRow : DataRow
    {
        private IdentificationTable _tableIdentification;

        internal IdentificationRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableIdentification = ((IdentificationTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableIdentification.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableIdentification.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableIdentification.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableIdentification.EmployeeIDColumn] = Convert.DBNull;
        }
        public string No
        {
            get
            {
                try
                {
                    return ((string)(this[_tableIdentification.NoColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value No because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableIdentification.NoColumn] = value;
            }
        }
        public bool IsNoNull()
        {
            return this.IsNull(_tableIdentification.NoColumn);
        }
        public void SetNoNull()
        {
            this[_tableIdentification.NoColumn] = Convert.DBNull;
        }
        public DateTime IssuedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableIdentification.IssuedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IssuedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableIdentification.IssuedDateColumn] = value;
            }
        }
        public bool IsIssuedDateNull()
        {
            return this.IsNull(_tableIdentification.IssuedDateColumn);
        }
        public void SetIssuedDateNull()
        {
            this[_tableIdentification.IssuedDateColumn] = Convert.DBNull;
        }
        public string IssuedPlace
        {
            get
            {
                try
                {
                    return ((string)(this[_tableIdentification.IssuedPlaceColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IssuedPlace because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableIdentification.IssuedPlaceColumn] = value;
            }
        }
        public bool IsIssuedPlaceNull()
        {
            return this.IsNull(_tableIdentification.IssuedPlaceColumn);
        }
        public void SetIssuedPlaceNull()
        {
            this[_tableIdentification.IssuedPlaceColumn] = Convert.DBNull;
        }
        #endregion
    }
}
