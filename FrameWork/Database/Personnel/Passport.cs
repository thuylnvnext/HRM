using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class PassportTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnNo;
        private DataColumn _columnIssuedDate;
        private DataColumn _columnExpiredDate;
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
            _columnNo.MaxLength = 20;
            _columnNo.Unique = false;
            _columnNo.DefaultValue = Convert.DBNull;
            _columnNo.ExtendedProperties.Add("IsKey", "false");
            _columnNo.ExtendedProperties.Add("ReadOnly", "false");
            _columnNo.ExtendedProperties.Add("Description", "No");
            _columnNo.ExtendedProperties.Add("Length", "20");
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

            _columnExpiredDate = new DataColumn("ExpiredDate", typeof(DateTime));
            _columnExpiredDate.AllowDBNull = true;
            _columnExpiredDate.Caption = "Expired Date";
            _columnExpiredDate.Unique = false;
            _columnExpiredDate.DefaultValue = Convert.DBNull;
            _columnExpiredDate.ExtendedProperties.Add("IsKey", "false");
            _columnExpiredDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnExpiredDate.ExtendedProperties.Add("Description", "Expired Date");
            _columnExpiredDate.ExtendedProperties.Add("Decimals", "0");
            _columnExpiredDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnExpiredDate);

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
        public PassportTable()
            : base("Passport")
        {
            this.InitClass();
        }
        public PassportTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Passport_GetContent", Connection.GetConnection());
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
        public static PassportTable GetContentTable()
        {
            PassportTable passportTable = new PassportTable();
            passportTable.GetContent();
            return passportTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Passport_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@No", SqlDbType.VarChar, 20, "No");
            sqlCommand.Parameters.Add("@IssuedDate", SqlDbType.DateTime, 8, "IssuedDate");
            sqlCommand.Parameters.Add("@ExpiredDate", SqlDbType.DateTime, 8, "ExpiredDate");
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
            SqlCommand sqlCommand = new SqlCommand("Passport_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@No", SqlDbType.VarChar, 20, "No");
            sqlCommand.Parameters.Add("@IssuedDate", SqlDbType.DateTime, 8, "IssuedDate");
            sqlCommand.Parameters.Add("@ExpiredDate", SqlDbType.DateTime, 8, "ExpiredDate");
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
            SqlCommand sqlCommand = new SqlCommand("Passport_Delete", Connection.GetConnection());
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

            PassportRow row = FindByPrimaryKey(employeeID);
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
        public DataColumn ExpiredDateColumn
        {
            get
            {
                return _columnExpiredDate;
            }
        }
        public DataColumn IssuedPlaceColumn
        {
            get
            {
                return _columnIssuedPlace;
            }
        }
        public PassportRow this[int index]
        {
            get
            {
                return ((PassportRow)(this.Rows[index]));
            }
        }
        public void AddPassportRow(PassportRow row)
        {
            this.Rows.Add(row);
        }
        public PassportRow AddPassportRow(int employeeID, string no, DateTime issuedDate, DateTime expiredDate, string issuedPlace)
        {
            PassportRow rowPassportRow = ((PassportRow)(this.NewRow()));
            rowPassportRow["EmployeeID"] = employeeID;
            rowPassportRow["No"] = no;
            rowPassportRow["IssuedDate"] = issuedDate;
            rowPassportRow["ExpiredDate"] = expiredDate;
            rowPassportRow["IssuedPlace"] = issuedPlace;
            this.Rows.Add(rowPassportRow);
            return rowPassportRow;
        }
        public PassportRow FindByPrimaryKey(int employeeID)
        {
            return (PassportRow)(Rows.Find(new object[] { employeeID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new PassportRow(builder);
        }        
        #endregion
    }

    public class PassportRow : DataRow
    {
        private PassportTable _tablePassport;

        internal PassportRow(DataRowBuilder rb)
            : base(rb)
        {
            _tablePassport = ((PassportTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tablePassport.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePassport.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tablePassport.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tablePassport.EmployeeIDColumn] = Convert.DBNull;
        }
        public string No
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePassport.NoColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value No because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePassport.NoColumn] = value;
            }
        }
        public bool IsNoNull()
        {
            return this.IsNull(_tablePassport.NoColumn);
        }
        public void SetNoNull()
        {
            this[_tablePassport.NoColumn] = Convert.DBNull;
        }
        public DateTime IssuedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tablePassport.IssuedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IssuedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePassport.IssuedDateColumn] = value;
            }
        }
        public bool IsIssuedDateNull()
        {
            return this.IsNull(_tablePassport.IssuedDateColumn);
        }
        public void SetIssuedDateNull()
        {
            this[_tablePassport.IssuedDateColumn] = Convert.DBNull;
        }
        public DateTime ExpiredDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tablePassport.ExpiredDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ExpiredDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePassport.ExpiredDateColumn] = value;
            }
        }
        public bool IsExpiredDateNull()
        {
            return this.IsNull(_tablePassport.ExpiredDateColumn);
        }
        public void SetExpiredDateNull()
        {
            this[_tablePassport.ExpiredDateColumn] = Convert.DBNull;
        }
        public string IssuedPlace
        {
            get
            {
                try
                {
                    return ((string)(this[_tablePassport.IssuedPlaceColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value IssuedPlace because it is DBNull", exception);
                }
            }
            set
            {
                this[_tablePassport.IssuedPlaceColumn] = value;
            }
        }
        public bool IsIssuedPlaceNull()
        {
            return this.IsNull(_tablePassport.IssuedPlaceColumn);
        }
        public void SetIssuedPlaceNull()
        {
            this[_tablePassport.IssuedPlaceColumn] = Convert.DBNull;
        }
        #endregion
    }
}
