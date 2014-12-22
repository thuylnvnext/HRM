using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class ResignationTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnDepartmentID;
        private DataColumn _columnPositionID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnDecision;
        private DataColumn _columnResignationReasonID;
        private DataColumn _columnAllowance;
        private DataColumn _columnContractIndemnity;
        private DataColumn _columnOther;
        private DataColumn _columnReturnHealthIns;
        private DataColumn _columnNotes;

        private void InitClass()
        {
            _columnEmployeeID = new DataColumn("EmployeeID", typeof(int));
            _columnEmployeeID.AllowDBNull = false;
            _columnEmployeeID.Caption = "Employee ID";
            _columnEmployeeID.Unique = false;
            _columnEmployeeID.DefaultValue = Convert.DBNull;
            _columnEmployeeID.ExtendedProperties.Add("IsKey", "true");
            _columnEmployeeID.ExtendedProperties.Add("ReadOnly", "false");
            _columnEmployeeID.ExtendedProperties.Add("Description", "Employee ID");
            _columnEmployeeID.ExtendedProperties.Add("Decimals", "0");
            _columnEmployeeID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnEmployeeID);

            _columnDepartmentID = new DataColumn("DepartmentID", typeof(string));
            _columnDepartmentID.AllowDBNull = true;
            _columnDepartmentID.Caption = "Department ID";
            _columnDepartmentID.MaxLength = 20;
            _columnDepartmentID.Unique = false;
            _columnDepartmentID.DefaultValue = Convert.DBNull;
            _columnDepartmentID.ExtendedProperties.Add("IsKey", "false");
            _columnDepartmentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnDepartmentID.ExtendedProperties.Add("Description", "Department ID");
            _columnDepartmentID.ExtendedProperties.Add("Length", "20");
            _columnDepartmentID.ExtendedProperties.Add("Decimals", "0");
            _columnDepartmentID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDepartmentID);

            _columnPositionID = new DataColumn("PositionID", typeof(string));
            _columnPositionID.AllowDBNull = true;
            _columnPositionID.Caption = "Position ID";
            _columnPositionID.MaxLength = 10;
            _columnPositionID.Unique = false;
            _columnPositionID.DefaultValue = Convert.DBNull;
            _columnPositionID.ExtendedProperties.Add("IsKey", "false");
            _columnPositionID.ExtendedProperties.Add("ReadOnly", "false");
            _columnPositionID.ExtendedProperties.Add("Description", "Position ID");
            _columnPositionID.ExtendedProperties.Add("Length", "10");
            _columnPositionID.ExtendedProperties.Add("Decimals", "0");
            _columnPositionID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPositionID);

            _columnFromDate = new DataColumn("FromDate", typeof(DateTime));
            _columnFromDate.AllowDBNull = false;
            _columnFromDate.Caption = "From Date";
            _columnFromDate.Unique = false;
            _columnFromDate.DefaultValue = Convert.DBNull;
            _columnFromDate.ExtendedProperties.Add("IsKey", "true");
            _columnFromDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnFromDate.ExtendedProperties.Add("Description", "From Date");
            _columnFromDate.ExtendedProperties.Add("Decimals", "0");
            _columnFromDate.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFromDate);

            _columnToDate = new DataColumn("ToDate", typeof(DateTime));
            _columnToDate.AllowDBNull = true;
            _columnToDate.Caption = "To Date";
            _columnToDate.Unique = false;
            _columnToDate.DefaultValue = Convert.DBNull;
            _columnToDate.ExtendedProperties.Add("IsKey", "false");
            _columnToDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnToDate.ExtendedProperties.Add("Description", "To Date");
            _columnToDate.ExtendedProperties.Add("Decimals", "0");
            _columnToDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnToDate);

            _columnDecision= new DataColumn("Decision", typeof(string));
            _columnDecision.AllowDBNull = true;
            _columnDecision.Caption = "Decision";
            _columnDecision.MaxLength = 50;
            _columnDecision.Unique = false;
            _columnDecision.DefaultValue = Convert.DBNull;
            _columnDecision.ExtendedProperties.Add("IsKey", "false");
            _columnDecision.ExtendedProperties.Add("ReadOnly", "false");
            _columnDecision.ExtendedProperties.Add("Description", "Decision");
            _columnDecision.ExtendedProperties.Add("Length", "50");
            _columnDecision.ExtendedProperties.Add("Decimals", "0");
            _columnDecision.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDecision);

            _columnResignationReasonID = new DataColumn("ResignationReasonID", typeof(string));
            _columnResignationReasonID.AllowDBNull = true;
            _columnResignationReasonID.Caption = "Resignation Reason ID";
            _columnResignationReasonID.MaxLength = 10;
            _columnResignationReasonID.Unique = false;
            _columnResignationReasonID.DefaultValue = Convert.DBNull;
            _columnResignationReasonID.ExtendedProperties.Add("IsKey", "false");
            _columnResignationReasonID.ExtendedProperties.Add("ReadOnly", "false");
            _columnResignationReasonID.ExtendedProperties.Add("Description", "Resignation Reason ID");
            _columnResignationReasonID.ExtendedProperties.Add("Length", "10");
            _columnResignationReasonID.ExtendedProperties.Add("Decimals", "0");
            _columnResignationReasonID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnResignationReasonID);

            _columnAllowance = new DataColumn("Allowance", typeof(decimal));
            _columnAllowance.AllowDBNull = true;
            _columnAllowance.Caption = "Allowance";
            _columnAllowance.Unique = false;
            _columnAllowance.DefaultValue = Convert.DBNull;
            _columnAllowance.ExtendedProperties.Add("IsKey", "false");
            _columnAllowance.ExtendedProperties.Add("ReadOnly", "false");
            _columnAllowance.ExtendedProperties.Add("Description", "Allowance");
            _columnAllowance.ExtendedProperties.Add("Decimals", "0");
            _columnAllowance.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnAllowance);

            _columnContractIndemnity = new DataColumn("ContractIndemnity", typeof(decimal));
            _columnContractIndemnity.AllowDBNull = true;
            _columnContractIndemnity.Caption = "Contract Indemnity";
            _columnContractIndemnity.Unique = false;
            _columnContractIndemnity.DefaultValue = Convert.DBNull;
            _columnContractIndemnity.ExtendedProperties.Add("IsKey", "false");
            _columnContractIndemnity.ExtendedProperties.Add("ReadOnly", "false");
            _columnContractIndemnity.ExtendedProperties.Add("Description", "Contract Indemnity");
            _columnContractIndemnity.ExtendedProperties.Add("Decimals", "0");
            _columnContractIndemnity.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnContractIndemnity);

            _columnOther = new DataColumn("Other", typeof(decimal));
            _columnOther.AllowDBNull = true;
            _columnOther.Caption = "Other";
            _columnOther.Unique = false;
            _columnOther.DefaultValue = Convert.DBNull;
            _columnOther.ExtendedProperties.Add("IsKey", "false");
            _columnOther.ExtendedProperties.Add("ReadOnly", "false");
            _columnOther.ExtendedProperties.Add("Description", "Other");
            _columnOther.ExtendedProperties.Add("Decimals", "0");
            _columnOther.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnOther);

            _columnReturnHealthIns = new DataColumn("ReturnHealthIns", typeof(bool));
            _columnReturnHealthIns.AllowDBNull = true;
            _columnReturnHealthIns.Caption = "Return Health Ins";
            _columnReturnHealthIns.Unique = false;
            _columnReturnHealthIns.DefaultValue = Convert.DBNull;
            _columnReturnHealthIns.ExtendedProperties.Add("IsKey", "false");
            _columnReturnHealthIns.ExtendedProperties.Add("ReadOnly", "false");
            _columnReturnHealthIns.ExtendedProperties.Add("Description", "Return Health Ins");
            _columnReturnHealthIns.ExtendedProperties.Add("Decimals", "0");
            _columnReturnHealthIns.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnReturnHealthIns);

            _columnNotes = new DataColumn("Notes", typeof(string));
            _columnNotes.AllowDBNull = true;
            _columnNotes.Caption = "Notes";
            _columnNotes.MaxLength = 250;
            _columnNotes.Unique = false;
            _columnNotes.DefaultValue = Convert.DBNull;
            _columnNotes.ExtendedProperties.Add("IsKey", "false");
            _columnNotes.ExtendedProperties.Add("ReadOnly", "false");
            _columnNotes.ExtendedProperties.Add("Description", "Notes");
            _columnNotes.ExtendedProperties.Add("Length", "250");
            _columnNotes.ExtendedProperties.Add("Decimals", "0");
            _columnNotes.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNotes);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"] };
        }
        #endregion

        #region Constructors
        public ResignationTable()
            : base("Resignation")
        {
            this.InitClass();
        }
        public ResignationTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Resignation_GetContent", Connection.GetConnection());
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
        public static ResignationTable GetContentTable()
        {
            ResignationTable resignationTable = new ResignationTable();
            resignationTable.GetContent();
            return resignationTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Resignation_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");
            sqlCommand.Parameters.Add("@PositionID", SqlDbType.VarChar, 10, "PositionID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Decision", SqlDbType.NVarChar, 50, "Decision");
            sqlCommand.Parameters.Add("@ResignationReasonID", SqlDbType.VarChar, 10, "ResignationReasonID");
            sqlCommand.Parameters.Add("@Allowance", SqlDbType.Money, 8, "Allowance");
            sqlCommand.Parameters.Add("@ContractIndemnity", SqlDbType.Money, 8, "ContractIndemnity");
            sqlCommand.Parameters.Add("@Other", SqlDbType.Money, 8, "Other");
            sqlCommand.Parameters.Add("@ReturnHealthIns", SqlDbType.Bit, 1, "ReturnHealthIns");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 250, "Notes");

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
            SqlCommand sqlCommand = new SqlCommand("Resignation_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.VarChar, 20, "DepartmentID");
            sqlCommand.Parameters.Add("@PositionID", SqlDbType.VarChar, 10, "PositionID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Decision", SqlDbType.NVarChar, 50, "Decision");
            sqlCommand.Parameters.Add("@ResignationReasonID", SqlDbType.VarChar, 10, "ResignationReasonID");
            sqlCommand.Parameters.Add("@Allowance", SqlDbType.Money, 8, "Allowance");
            sqlCommand.Parameters.Add("@ContractIndemnity", SqlDbType.Money, 8, "ContractIndemnity");
            sqlCommand.Parameters.Add("@Other", SqlDbType.Money, 8, "Other");
            sqlCommand.Parameters.Add("@ReturnHealthIns", SqlDbType.Bit, 1, "ReturnHealthIns");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 250, "Notes");

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
            SqlCommand sqlCommand = new SqlCommand("Resignation_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");

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
        public bool Delete(int employeeID, DateTime fromDate)
        {
            bool retVal;

            ResignationRow row = FindByPrimaryKey(employeeID, fromDate);
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
        public DataColumn DepartmentIDColumn
        {
            get
            {
                return _columnDepartmentID;
            }
        }
        public DataColumn PositionIDColumn
        {
            get
            {
                return _columnPositionID;
            }
        }
        public DataColumn FromDateColumn
        {
            get
            {
                return _columnFromDate;
            }
        }
        public DataColumn ToDateColumn
        {
            get
            {
                return _columnToDate;
            }
        }
        public DataColumn DecisionColumn
        {
            get
            {
                return _columnDecision;
            }
        }
        public DataColumn ResignationReasonIDColumn
        {
            get
            {
                return _columnResignationReasonID;
            }
        }
        public DataColumn AllowanceColumn
        {
            get
            {
                return _columnAllowance;
            }
        }
        public DataColumn ContractIndemnityColumn
        {
            get
            {
                return _columnContractIndemnity;
            }
        }
        public DataColumn OtherColumn
        {
            get
            {
                return _columnOther;
            }
        }
        public DataColumn ReturnHealthInsColumn
        {
            get
            {
                return _columnReturnHealthIns;
            }
        }
        public DataColumn NotesColumn
        {
            get
            {
                return _columnNotes;
            }
        }
        public ResignationRow this[int index]
        {
            get
            {
                return ((ResignationRow)(this.Rows[index]));
            }
        }
        public void AddResignationRow(ResignationRow row)
        {
            this.Rows.Add(row);
        }
        public ResignationRow AddResignationRow(int employeeID, string departmentID, string positionID, DateTime fromDate, DateTime toDate, string decision, string resignationReasonID, decimal allowance, decimal contractIndemnity, decimal other, bool returnHealthIns, string notes)
        {
            ResignationRow rowResignationRow = ((ResignationRow)(this.NewRow()));
            rowResignationRow["EmployeeID"] = employeeID;
            rowResignationRow["DepartmentID"] = departmentID;
            rowResignationRow["PositionID"] = positionID;
            rowResignationRow["FromDate"] = fromDate;
            rowResignationRow["ToDate"] = toDate;
            rowResignationRow["Decision"] = decision;
            rowResignationRow["ResignationReasonID"] = resignationReasonID;
            rowResignationRow["Allowance"] = allowance;
            rowResignationRow["ContractIndemnity"] = contractIndemnity;
            rowResignationRow["Other"] = other;
            rowResignationRow["ReturnHealthIns"] = returnHealthIns;
            rowResignationRow["Notes"] = notes;
            this.Rows.Add(rowResignationRow);
            return rowResignationRow;
        }
        public ResignationRow FindByPrimaryKey(int employeeID, DateTime fromDate)
        {
            return (ResignationRow)(Rows.Find(new object[] { employeeID, fromDate }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ResignationRow(builder);
        }
        public int GetListByDepartmentID(string departmentIDList, DateTime fromDate, DateTime toDate, int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("Resignation_GetListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;

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

            return Count;
        }
        public void DeleteByDepartmentID(string departmentIDList)
        {
            foreach (ResignationRow rr in this)
            {
                if (departmentIDList.IndexOf("[" + rr.DepartmentID + "]") >= 0) rr.Delete();
            }
            AcceptChanges();
        }
        public static bool ReturnToWork(int employeeID, DateTime fromDate)
        {
            bool retVal = true;
            SqlCommand sqlCommand = new SqlCommand("Resignation_ReturnToWork", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;

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
        public static DateTime CheckExist(int employeeID)
        {
            DateTime retVal;
            SqlCommand sqlCommand = new SqlCommand("Resignation_CheckExist", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;

            try
            {
                Connection.Open();
                retVal = Convert.ToDateTime(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = new DateTime(9999, 12, 31);
            }
            finally
            {
                Connection.Close();
            }

            return retVal;
        }
        public int GetTerminationOfEmployment(string employeeIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("Resignation_GetTerminationOfEmployment", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;

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

            return Count;
        }
        #endregion
    }

    public class ResignationRow : DataRow
    {
        private ResignationTable _tableResignation;

        internal ResignationRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableResignation = ((ResignationTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableResignation.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableResignation.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableResignation.EmployeeIDColumn] = Convert.DBNull;
        }
        public string DepartmentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableResignation.DepartmentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DepartmentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.DepartmentIDColumn] = value;
            }
        }
        public bool IsDepartmentIDNull()
        {
            return this.IsNull(_tableResignation.DepartmentIDColumn);
        }
        public void SetDepartmentIDNull()
        {
            this[_tableResignation.DepartmentIDColumn] = Convert.DBNull;
        }
        public string PositionID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableResignation.PositionIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PositionID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.PositionIDColumn] = value;
            }
        }
        public bool IsPositionIDNull()
        {
            return this.IsNull(_tableResignation.PositionIDColumn);
        }
        public void SetPositionIDNull()
        {
            this[_tableResignation.PositionIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableResignation.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableResignation.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableResignation.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableResignation.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableResignation.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableResignation.ToDateColumn] = Convert.DBNull;
        }
        public string Decision
        {
            get
            {
                try
                {
                    return ((string)(this[_tableResignation.DecisionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Decision because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.DecisionColumn] = value;
            }
        }
        public bool IsDecisionNull()
        {
            return this.IsNull(_tableResignation.DecisionColumn);
        }
        public void SetDecisionNull()
        {
            this[_tableResignation.DecisionColumn] = Convert.DBNull;
        }
        public string ResignationReasonID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableResignation.ResignationReasonIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ResignationReasonID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.ResignationReasonIDColumn] = value;
            }
        }
        public bool IsResignationReasonIDNull()
        {
            return this.IsNull(_tableResignation.ResignationReasonIDColumn);
        }
        public void SetResignationReasonIDNull()
        {
            this[_tableResignation.ResignationReasonIDColumn] = Convert.DBNull;
        }
        public decimal Allowance
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableResignation.AllowanceColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Allowance because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.AllowanceColumn] = value;
            }
        }
        public bool IsAllowanceNull()
        {
            return this.IsNull(_tableResignation.AllowanceColumn);
        }
        public void SetAllowanceNull()
        {
            this[_tableResignation.AllowanceColumn] = Convert.DBNull;
        }
        public decimal ContractIndemnity
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableResignation.ContractIndemnityColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ContractIndemnity because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.ContractIndemnityColumn] = value;
            }
        }
        public bool IsContractIndemnityNull()
        {
            return this.IsNull(_tableResignation.ContractIndemnityColumn);
        }
        public void SetContractIndemnityNull()
        {
            this[_tableResignation.ContractIndemnityColumn] = Convert.DBNull;
        }
        public decimal Other
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableResignation.OtherColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Other because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.OtherColumn] = value;
            }
        }
        public bool IsOtherNull()
        {
            return this.IsNull(_tableResignation.OtherColumn);
        }
        public void SetOtherNull()
        {
            this[_tableResignation.OtherColumn] = Convert.DBNull;
        }
        public bool ReturnHealthIns
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableResignation.ReturnHealthInsColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ReturnHealthIns because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.ReturnHealthInsColumn] = value;
            }
        }
        public bool IsReturnHealthInsNull()
        {
            return this.IsNull(_tableResignation.ReturnHealthInsColumn);
        }
        public void SetReturnHealthInsNull()
        {
            this[_tableResignation.ReturnHealthInsColumn] = Convert.DBNull;
        }
        public string Notes
        {
            get
            {
                try
                {
                    return ((string)(this[_tableResignation.NotesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Notes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableResignation.NotesColumn] = value;
            }
        }
        public bool IsNotesNull()
        {
            return this.IsNull(_tableResignation.NotesColumn);
        }
        public void SetNotesNull()
        {
            this[_tableResignation.NotesColumn] = Convert.DBNull;
        }
        #endregion
    }
}
