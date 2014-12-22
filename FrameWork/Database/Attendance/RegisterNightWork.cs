using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterNightWorkTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnDepartmentID;
        private DataColumn _columnFrom;
        private DataColumn _columnTo;

        private void InitClass()
        {
            _columnDepartmentID = new DataColumn("DepartmentID", typeof(string));
            _columnDepartmentID.AllowDBNull = false;
            _columnDepartmentID.Caption = "Department ID";
            _columnDepartmentID.MaxLength = 20;
            _columnDepartmentID.Unique = true;
            _columnDepartmentID.DefaultValue = Convert.DBNull;
            _columnDepartmentID.ExtendedProperties.Add("IsKey", "true");
            _columnDepartmentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDepartmentID.ExtendedProperties.Add("Description", "Department ID");
            _columnDepartmentID.ExtendedProperties.Add("Length", "20");
            _columnDepartmentID.ExtendedProperties.Add("Decimals", "0");
            _columnDepartmentID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnDepartmentID);

            _columnFrom = new DataColumn("From", typeof(int));
            _columnFrom.AllowDBNull = true;
            _columnFrom.Caption = "From";
            _columnFrom.Unique = false;
            _columnFrom.DefaultValue = Convert.DBNull;
            _columnFrom.ExtendedProperties.Add("IsKey", "false");
            _columnFrom.ExtendedProperties.Add("ReadOnly", "false");
            _columnFrom.ExtendedProperties.Add("Description", "From");
            _columnFrom.ExtendedProperties.Add("Decimals", "0");
            _columnFrom.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnFrom);

            _columnTo = new DataColumn("To", typeof(int));
            _columnTo.AllowDBNull = true;
            _columnTo.Caption = "To";
            _columnTo.Unique = false;
            _columnTo.DefaultValue = Convert.DBNull;
            _columnTo.ExtendedProperties.Add("IsKey", "false");
            _columnTo.ExtendedProperties.Add("ReadOnly", "false");
            _columnTo.ExtendedProperties.Add("Description", "To");
            _columnTo.ExtendedProperties.Add("Decimals", "0");
            _columnTo.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnTo);

            this.PrimaryKey = new DataColumn[] { this.Columns["DepartmentID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public RegisterNightWorkTable()
            : base("RegisterNightWork")
        {
            this.InitClass();
        }
        public RegisterNightWorkTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterNightWork_GetContent", Connection.GetConnection());
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
        public static RegisterNightWorkTable GetContentTable()
        {
            RegisterNightWorkTable registerNightWorkTable = new RegisterNightWorkTable();
            registerNightWorkTable.GetContent();
            return registerNightWorkTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterNightWork_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");
            sqlCommand.Parameters.Add("@From", SqlDbType.Int, 4, "From");
            sqlCommand.Parameters.Add("@To", SqlDbType.Int, 4, "To");

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
            SqlCommand sqlCommand = new SqlCommand("RegisterNightWork_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalDepartmentID", SqlDbType.VarChar, 20, "DepartmentID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");
            sqlCommand.Parameters.Add("@From", SqlDbType.Int, 4, "From");
            sqlCommand.Parameters.Add("@To", SqlDbType.Int, 4, "To");

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
            SqlCommand sqlCommand = new SqlCommand("RegisterNightWork_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");

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
        public bool Delete(string departmentID)
        {
            bool retVal;

            RegisterNightWorkRow row = FindByPrimaryKey(departmentID);
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
        public DataColumn DepartmentIDColumn
        {
            get
            {
                return _columnDepartmentID;
            }
        }
        public DataColumn FromColumn
        {
            get
            {
                return _columnFrom;
            }
        }
        public DataColumn ToColumn
        {
            get
            {
                return _columnTo;
            }
        }
        public RegisterNightWorkRow this[int index]
        {
            get
            {
                return ((RegisterNightWorkRow)(this.Rows[index]));
            }
        }
        public void AddRegisterNightWorkRow(RegisterNightWorkRow row)
        {
            this.Rows.Add(row);
        }
        public RegisterNightWorkRow AddRegisterNightWorkRow(string departmentID, int from, int to)
        {
            RegisterNightWorkRow rowRegisterNightWorkRow = ((RegisterNightWorkRow)(this.NewRow()));
            rowRegisterNightWorkRow["DepartmentID"] = departmentID;
            rowRegisterNightWorkRow["From"] = from;
            rowRegisterNightWorkRow["To"] = to;
            this.Rows.Add(rowRegisterNightWorkRow);
            return rowRegisterNightWorkRow;
        }
        public RegisterNightWorkRow FindByPrimaryKey(string departmentID)
        {
            return (RegisterNightWorkRow)(Rows.Find(new object[] { departmentID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterNightWorkRow(builder);
        }
        public static RegisterNightWorkRow GetListByDepartmentID(string departmentIDList, int count)
        {
            RegisterNightWorkTable registerNightWork = new RegisterNightWorkTable();
            RegisterNightWorkRow rnwr = null;
            SqlCommand sqlCommand = new SqlCommand("RegisterNightWork_GetListByDepartmentID", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@Count", SqlDbType.Int, 4).Value = count;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(registerNightWork);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            if (registerNightWork.Count > 0) rnwr = registerNightWork[0];
            return rnwr;
        }
        #endregion
    }

    public class RegisterNightWorkRow : DataRow
    {
        private RegisterNightWorkTable _tableRegisterNightWork;

        internal RegisterNightWorkRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterNightWork = ((RegisterNightWorkTable)(this.Table));
        }

        #region Properties
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterNightWork.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterNightWork.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableRegisterNightWork.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableRegisterNightWork.DepartmentIDColumn] = Convert.DBNull;
        }
        public int From
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterNightWork.FromColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value From because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterNightWork.FromColumn] = value;
            }
        }
        public bool IsFromNull()
        {
            return this.IsNull(_tableRegisterNightWork.FromColumn);
        }
        public void SetFromNull()
        {
            this[_tableRegisterNightWork.FromColumn] = Convert.DBNull;
        }
        public int To
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterNightWork.ToColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value To because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterNightWork.ToColumn] = value;
            }
        }
        public bool IsToNull()
        {
            return this.IsNull(_tableRegisterNightWork.ToColumn);
        }
        public void SetToNull()
        {
            this[_tableRegisterNightWork.ToColumn] = Convert.DBNull;
        }
        #endregion
    }
}
