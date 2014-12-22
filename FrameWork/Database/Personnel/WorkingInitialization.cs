using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class WorkingInitializationTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnInitialDate;
        private DataColumn _columnSigningDate;
        private DataColumn _columnBySource;
        private DataColumn _columnPresentPerson;
        private DataColumn _columnInterviewer;
        private DataColumn _columnRecruitingOfficer;
        private DataColumn _columnHasHealthIns;

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

            _columnInitialDate = new DataColumn("InitialDate", typeof(DateTime));
            _columnInitialDate.AllowDBNull = true;
            _columnInitialDate.Caption = "Initial Date";
            _columnInitialDate.Unique = false;
            _columnInitialDate.DefaultValue = Convert.DBNull;
            _columnInitialDate.ExtendedProperties.Add("IsKey", "false");
            _columnInitialDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnInitialDate.ExtendedProperties.Add("Description", "Initial Date");
            _columnInitialDate.ExtendedProperties.Add("Decimals", "0");
            _columnInitialDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnInitialDate);

            _columnSigningDate = new DataColumn("SigningDate", typeof(DateTime));
            _columnSigningDate.AllowDBNull = true;
            _columnSigningDate.Caption = "Signing Date";
            _columnSigningDate.Unique = false;
            _columnSigningDate.DefaultValue = Convert.DBNull;
            _columnSigningDate.ExtendedProperties.Add("IsKey", "false");
            _columnSigningDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnSigningDate.ExtendedProperties.Add("Description", "Signing Date");
            _columnSigningDate.ExtendedProperties.Add("Decimals", "0");
            _columnSigningDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSigningDate);

            _columnBySource = new DataColumn("BySource", typeof(string));
            _columnBySource.AllowDBNull = true;
            _columnBySource.Caption = "By Source";
            _columnBySource.MaxLength = 50;
            _columnBySource.Unique = false;
            _columnBySource.DefaultValue = Convert.DBNull;
            _columnBySource.ExtendedProperties.Add("IsKey", "false");
            _columnBySource.ExtendedProperties.Add("ReadOnly", "false");
            _columnBySource.ExtendedProperties.Add("Description", "By Source");
            _columnBySource.ExtendedProperties.Add("Length", "50");
            _columnBySource.ExtendedProperties.Add("Decimals", "0");
            _columnBySource.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnBySource);

            _columnPresentPerson = new DataColumn("PresentPerson", typeof(string));
            _columnPresentPerson.AllowDBNull = true;
            _columnPresentPerson.Caption = "Present Person";
            _columnPresentPerson.MaxLength = 30;
            _columnPresentPerson.Unique = false;
            _columnPresentPerson.DefaultValue = Convert.DBNull;
            _columnPresentPerson.ExtendedProperties.Add("IsKey", "false");
            _columnPresentPerson.ExtendedProperties.Add("ReadOnly", "false");
            _columnPresentPerson.ExtendedProperties.Add("Description", "Present Person");
            _columnPresentPerson.ExtendedProperties.Add("Length", "30");
            _columnPresentPerson.ExtendedProperties.Add("Decimals", "0");
            _columnPresentPerson.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPresentPerson);

            _columnInterviewer = new DataColumn("Interviewer", typeof(string));
            _columnInterviewer.AllowDBNull = true;
            _columnInterviewer.Caption = "Interviewer";
            _columnInterviewer.MaxLength = 30;
            _columnInterviewer.Unique = false;
            _columnInterviewer.DefaultValue = Convert.DBNull;
            _columnInterviewer.ExtendedProperties.Add("IsKey", "false");
            _columnInterviewer.ExtendedProperties.Add("ReadOnly", "false");
            _columnInterviewer.ExtendedProperties.Add("Description", "Interviewer");
            _columnInterviewer.ExtendedProperties.Add("Length", "30");
            _columnInterviewer.ExtendedProperties.Add("Decimals", "0");
            _columnInterviewer.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnInterviewer);

            _columnRecruitingOfficer = new DataColumn("RecruitingOfficer", typeof(string));
            _columnRecruitingOfficer.AllowDBNull = true;
            _columnRecruitingOfficer.Caption = "Recruiting Officer";
            _columnRecruitingOfficer.MaxLength = 30;
            _columnRecruitingOfficer.Unique = false;
            _columnRecruitingOfficer.DefaultValue = Convert.DBNull;
            _columnRecruitingOfficer.ExtendedProperties.Add("IsKey", "false");
            _columnRecruitingOfficer.ExtendedProperties.Add("ReadOnly", "false");
            _columnRecruitingOfficer.ExtendedProperties.Add("Description", "Recruiting Officer");
            _columnRecruitingOfficer.ExtendedProperties.Add("Length", "30");
            _columnRecruitingOfficer.ExtendedProperties.Add("Decimals", "0");
            _columnRecruitingOfficer.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnRecruitingOfficer);

            _columnHasHealthIns = new DataColumn("HasHealthIns", typeof(bool));
            _columnHasHealthIns.AllowDBNull = true;
            _columnHasHealthIns.Caption = "Has Health Ins";
            _columnHasHealthIns.Unique = false;
            _columnHasHealthIns.DefaultValue = Convert.DBNull;
            _columnHasHealthIns.ExtendedProperties.Add("IsKey", "false");
            _columnHasHealthIns.ExtendedProperties.Add("ReadOnly", "false");
            _columnHasHealthIns.ExtendedProperties.Add("Description", "Has Health Ins");
            _columnHasHealthIns.ExtendedProperties.Add("Decimals", "0");
            _columnHasHealthIns.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnHasHealthIns);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public WorkingInitializationTable()
            : base("WorkingInitialization")
        {
            this.InitClass();
        }
        public WorkingInitializationTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingInitialization_GetContent", Connection.GetConnection());
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
        public static WorkingInitializationTable GetContentTable()
        {
            WorkingInitializationTable workingInitializationTable = new WorkingInitializationTable();
            workingInitializationTable.GetContent();
            return workingInitializationTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingInitialization_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@InitialDate", SqlDbType.DateTime, 8, "InitialDate");
            sqlCommand.Parameters.Add("@SigningDate", SqlDbType.DateTime, 8, "SigningDate");
            sqlCommand.Parameters.Add("@BySource", SqlDbType.NVarChar, 50, "BySource");
            sqlCommand.Parameters.Add("@PresentPerson", SqlDbType.NVarChar, 30, "PresentPerson");
            sqlCommand.Parameters.Add("@Interviewer", SqlDbType.NVarChar, 30, "Interviewer");
            sqlCommand.Parameters.Add("@RecruitingOfficer", SqlDbType.NVarChar, 30, "RecruitingOfficer");
            sqlCommand.Parameters.Add("@HasHealthIns", SqlDbType.Bit, 1, "HasHealthIns");

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
            SqlCommand sqlCommand = new SqlCommand("WorkingInitialization_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@InitialDate", SqlDbType.DateTime, 8, "InitialDate");
            sqlCommand.Parameters.Add("@SigningDate", SqlDbType.DateTime, 8, "SigningDate");
            sqlCommand.Parameters.Add("@BySource", SqlDbType.NVarChar, 50, "BySource");
            sqlCommand.Parameters.Add("@PresentPerson", SqlDbType.NVarChar, 30, "PresentPerson");
            sqlCommand.Parameters.Add("@Interviewer", SqlDbType.NVarChar, 30, "Interviewer");
            sqlCommand.Parameters.Add("@RecruitingOfficer", SqlDbType.NVarChar, 30, "RecruitingOfficer");
            sqlCommand.Parameters.Add("@HasHealthIns", SqlDbType.Bit, 1, "HasHealthIns");

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
            SqlCommand sqlCommand = new SqlCommand("WorkingInitialization_Delete", Connection.GetConnection());
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

            WorkingInitializationRow row = FindByPrimaryKey(employeeID);
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
        public DataColumn InitialDateColumn
        {
            get
            {
                return _columnInitialDate;
            }
        }
        public DataColumn SigningDateColumn
        {
            get
            {
                return _columnSigningDate;
            }
        }
        public DataColumn BySourceColumn
        {
            get
            {
                return _columnBySource;
            }
        }
        public DataColumn PresentPersonColumn
        {
            get
            {
                return _columnPresentPerson;
            }
        }
        public DataColumn InterviewerColumn
        {
            get
            {
                return _columnInterviewer;
            }
        }
        public DataColumn RecruitingOfficerColumn
        {
            get
            {
                return _columnRecruitingOfficer;
            }
        }
        public DataColumn HasHealthInsColumn
        {
            get
            {
                return _columnHasHealthIns;
            }
        }
        public WorkingInitializationRow this[int index]
        {
            get
            {
                return ((WorkingInitializationRow)(this.Rows[index]));
            }
        }
        public void AddWorkingInitializationRow(WorkingInitializationRow row)
        {
            this.Rows.Add(row);
        }
        public WorkingInitializationRow AddWorkingInitializationRow(int employeeID, DateTime initialDate, DateTime signingDate, string bySource, string presentPerson, string interviewer, string recruitingOfficer, bool hasHealthIns)
        {
            WorkingInitializationRow rowWorkingInitializationRow = ((WorkingInitializationRow)(this.NewRow()));
            rowWorkingInitializationRow["EmployeeID"] = employeeID;
            rowWorkingInitializationRow["InitialDate"] = initialDate;
            rowWorkingInitializationRow["SigningDate"] = signingDate;
            rowWorkingInitializationRow["BySource"] = bySource;
            rowWorkingInitializationRow["PresentPerson"] = presentPerson;
            rowWorkingInitializationRow["Interviewer"] = interviewer;
            rowWorkingInitializationRow["RecruitingOfficer"] = recruitingOfficer;
            rowWorkingInitializationRow["HasHealthIns"] = hasHealthIns;
            this.Rows.Add(rowWorkingInitializationRow);
            return rowWorkingInitializationRow;
        }
        public WorkingInitializationRow FindByPrimaryKey(int employeeID)
        {
            return (WorkingInitializationRow)(Rows.Find(new object[] { employeeID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new WorkingInitializationRow(builder);
        }
        public void GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("WorkingInitialization_GetListByEmployeeID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4).Value = employeeID;
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
        }
        #endregion
    }

    public class WorkingInitializationRow : DataRow
    {
        private WorkingInitializationTable _tableWorkingInitialization;

        internal WorkingInitializationRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableWorkingInitialization = ((WorkingInitializationTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableWorkingInitialization.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableWorkingInitialization.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableWorkingInitialization.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime InitialDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableWorkingInitialization.InitialDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value InitialDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.InitialDateColumn] = value;
            }
        }
        public bool IsInitialDateNull()
        {
            return this.IsNull(_tableWorkingInitialization.InitialDateColumn);
        }
        public void SetInitialDateNull()
        {
            this[_tableWorkingInitialization.InitialDateColumn] = Convert.DBNull;
        }
        public DateTime SigningDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableWorkingInitialization.SigningDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SigningDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.SigningDateColumn] = value;
            }
        }
        public bool IsSigningDateNull()
        {
            return this.IsNull(_tableWorkingInitialization.SigningDateColumn);
        }
        public void SetSigningDateNull()
        {
            this[_tableWorkingInitialization.SigningDateColumn] = Convert.DBNull;
        }
        public string BySource
        {
            get
            {
                try
                {
                    return ((string)(this[_tableWorkingInitialization.BySourceColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BySource because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.BySourceColumn] = value;
            }
        }
        public bool IsBySourceNull()
        {
            return this.IsNull(_tableWorkingInitialization.BySourceColumn);
        }
        public void SetBySourceNull()
        {
            this[_tableWorkingInitialization.BySourceColumn] = Convert.DBNull;
        }
        public string PresentPerson
        {
            get
            {
                try
                {
                    return ((string)(this[_tableWorkingInitialization.PresentPersonColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PresentPerson because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.PresentPersonColumn] = value;
            }
        }
        public bool IsPresentPersonNull()
        {
            return this.IsNull(_tableWorkingInitialization.PresentPersonColumn);
        }
        public void SetPresentPersonNull()
        {
            this[_tableWorkingInitialization.PresentPersonColumn] = Convert.DBNull;
        }
        public string Interviewer
        {
            get
            {
                try
                {
                    return ((string)(this[_tableWorkingInitialization.InterviewerColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Interviewer because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.InterviewerColumn] = value;
            }
        }
        public bool IsInterviewerNull()
        {
            return this.IsNull(_tableWorkingInitialization.InterviewerColumn);
        }
        public void SetInterviewerNull()
        {
            this[_tableWorkingInitialization.InterviewerColumn] = Convert.DBNull;
        }
        public string RecruitingOfficer
        {
            get
            {
                try
                {
                    return ((string)(this[_tableWorkingInitialization.RecruitingOfficerColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value RecruitingOfficer because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.RecruitingOfficerColumn] = value;
            }
        }
        public bool IsRecruitingOfficerNull()
        {
            return this.IsNull(_tableWorkingInitialization.RecruitingOfficerColumn);
        }
        public void SetRecruitingOfficerNull()
        {
            this[_tableWorkingInitialization.RecruitingOfficerColumn] = Convert.DBNull;
        }
        public bool HasHealthIns
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableWorkingInitialization.HasHealthInsColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value HasHealthIns because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableWorkingInitialization.HasHealthInsColumn] = value;
            }
        }
        public bool IsHasHealthInsNull()
        {
            return this.IsNull(_tableWorkingInitialization.HasHealthInsColumn);
        }
        public void SetHasHealthInsNull()
        {
            this[_tableWorkingInitialization.HasHealthInsColumn] = Convert.DBNull;
        }
        #endregion
    }
}
