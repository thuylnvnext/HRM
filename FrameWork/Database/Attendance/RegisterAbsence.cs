using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class RegisterAbsenceTable : RegisterItemT
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnFromDate;
        private DataColumn _columnToDate;
        private DataColumn _columnUnit;
        private DataColumn _columnAbsenceID;
        private DataColumn _columnCreatedUserName;
        private DataColumn _columnCreatedDate;
        private DataColumn _columnModifiedUserName;
        private DataColumn _columnModifiedDate;

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

            _columnUnit = new DataColumn("Unit", typeof(decimal));
            _columnUnit.AllowDBNull = true;
            _columnUnit.Caption = "Unit";
            _columnUnit.Unique = false;
            _columnUnit.DefaultValue = Convert.DBNull;
            _columnUnit.ExtendedProperties.Add("IsKey", "false");
            _columnUnit.ExtendedProperties.Add("ReadOnly", "false");
            _columnUnit.ExtendedProperties.Add("Description", "Unit");
            _columnUnit.ExtendedProperties.Add("Length", "9");
            _columnUnit.ExtendedProperties.Add("Decimals", "0");
            _columnUnit.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnUnit);

            _columnAbsenceID = new DataColumn("AbsenceID", typeof(string));
            _columnAbsenceID.AllowDBNull = false;
            _columnAbsenceID.Caption = "Absence ID";
            _columnAbsenceID.MaxLength = 10;
            _columnAbsenceID.Unique = false;
            _columnAbsenceID.DefaultValue = Convert.DBNull;
            _columnAbsenceID.ExtendedProperties.Add("IsKey", "true");
            _columnAbsenceID.ExtendedProperties.Add("ReadOnly", "false");
            _columnAbsenceID.ExtendedProperties.Add("Description", "Absence ID");
            _columnAbsenceID.ExtendedProperties.Add("Length", "10");
            _columnAbsenceID.ExtendedProperties.Add("Decimals", "0");
            _columnAbsenceID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnAbsenceID);

            _columnCreatedUserName = new DataColumn("CreatedUserName", typeof(string));
            _columnCreatedUserName.AllowDBNull = true;
            _columnCreatedUserName.Caption = "Created User Name";
            _columnCreatedUserName.MaxLength = 15;
            _columnCreatedUserName.Unique = false;
            _columnCreatedUserName.DefaultValue = Convert.DBNull;
            _columnCreatedUserName.ExtendedProperties.Add("IsKey", "false");
            _columnCreatedUserName.ExtendedProperties.Add("ReadOnly", "false");
            _columnCreatedUserName.ExtendedProperties.Add("Description", "Created User Name");
            _columnCreatedUserName.ExtendedProperties.Add("Length", "15");
            _columnCreatedUserName.ExtendedProperties.Add("Decimals", "0");
            _columnCreatedUserName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCreatedUserName);

            _columnCreatedDate = new DataColumn("CreatedDate", typeof(DateTime));
            _columnCreatedDate.AllowDBNull = true;
            _columnCreatedDate.Caption = "Created Date";
            _columnCreatedDate.Unique = false;
            _columnCreatedDate.DefaultValue = Convert.DBNull;
            _columnCreatedDate.ExtendedProperties.Add("IsKey", "false");
            _columnCreatedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnCreatedDate.ExtendedProperties.Add("Description", "Created Date");
            _columnCreatedDate.ExtendedProperties.Add("Decimals", "0");
            _columnCreatedDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCreatedDate);

            _columnModifiedUserName = new DataColumn("ModifiedUserName", typeof(string));
            _columnModifiedUserName.AllowDBNull = true;
            _columnModifiedUserName.Caption = "Modified User Name";
            _columnModifiedUserName.MaxLength = 15;
            _columnModifiedUserName.Unique = false;
            _columnModifiedUserName.DefaultValue = Convert.DBNull;
            _columnModifiedUserName.ExtendedProperties.Add("IsKey", "false");
            _columnModifiedUserName.ExtendedProperties.Add("ReadOnly", "false");
            _columnModifiedUserName.ExtendedProperties.Add("Description", "Modified User Name");
            _columnModifiedUserName.ExtendedProperties.Add("Length", "15");
            _columnModifiedUserName.ExtendedProperties.Add("Decimals", "0");
            _columnModifiedUserName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnModifiedUserName);

            _columnModifiedDate = new DataColumn("ModifiedDate", typeof(DateTime));
            _columnModifiedDate.AllowDBNull = true;
            _columnModifiedDate.Caption = "Modified Date";
            _columnModifiedDate.Unique = false;
            _columnModifiedDate.DefaultValue = Convert.DBNull;
            _columnModifiedDate.ExtendedProperties.Add("IsKey", "false");
            _columnModifiedDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnModifiedDate.ExtendedProperties.Add("Description", "Modified Date");
            _columnModifiedDate.ExtendedProperties.Add("Decimals", "0");
            _columnModifiedDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnModifiedDate);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"], this.Columns["FromDate"], this.Columns["AbsenceID"] };
        }
        #endregion

        #region Constructors
        public RegisterAbsenceTable()
            : base("RegisterAbsence")
        {
            this.InitClass();
        }
        public RegisterAbsenceTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_GetContent", Connection.GetConnection());
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
        public static RegisterAbsenceTable GetContentTable()
        {
            RegisterAbsenceTable registerAbsenceTable = new RegisterAbsenceTable();
            registerAbsenceTable.GetContent();
            return registerAbsenceTable;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public int GetListByDuration(DateTime fromDate, DateTime toDate)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_GetListByDuration", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
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

        public override bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Unit", SqlDbType.Decimal, 9, "Unit");
            sqlCommand.Parameters.Add("@AbsenceID", SqlDbType.NVarChar, 10, "AbsenceID");
            sqlCommand.Parameters.Add("@CreatedUserName", SqlDbType.NVarChar, 15, "CreatedUserName");
            sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime, 8, "CreatedDate");
            sqlCommand.Parameters.Add("@ModifiedUserName", SqlDbType.NVarChar, 15, "ModifiedUserName");
            sqlCommand.Parameters.Add("@ModifiedDate", SqlDbType.DateTime, 8, "ModifiedDate");

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
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalFromDate", SqlDbType.DateTime, 8, "FromDate").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@OriginalAbsenceID", SqlDbType.NVarChar, 10, "AbsenceID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8, "ToDate");
            sqlCommand.Parameters.Add("@Unit", SqlDbType.Decimal, 9, "Unit");
            sqlCommand.Parameters.Add("@AbsenceID", SqlDbType.NVarChar, 10, "AbsenceID");
            sqlCommand.Parameters.Add("@CreatedUserName", SqlDbType.NVarChar, 15, "CreatedUserName");
            sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime, 8, "CreatedDate");
            sqlCommand.Parameters.Add("@ModifiedUserName", SqlDbType.NVarChar, 15, "ModifiedUserName");
            sqlCommand.Parameters.Add("@ModifiedDate", SqlDbType.DateTime, 8, "ModifiedDate");

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
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8, "FromDate");
            sqlCommand.Parameters.Add("@AbsenceID", SqlDbType.NVarChar, 10, "AbsenceID");

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
        public bool Delete(int employeeID, DateTime fromDate, string absenceID)
        {
            bool retVal;

            RegisterAbsenceRow row = FindByPrimaryKey(employeeID, fromDate, absenceID);
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
        public DataColumn UnitColumn
        {
            get
            {
                return _columnUnit;
            }
        }
        public DataColumn AbsenceIDColumn
        {
            get
            {
                return _columnAbsenceID;
            }
        }
        public DataColumn CreatedUserNameColumn
        {
            get
            {
                return _columnCreatedUserName;
            }
        }
        public DataColumn CreatedDateColumn
        {
            get
            {
                return _columnCreatedDate;
            }
        }
        public DataColumn ModifiedUserNameColumn
        {
            get
            {
                return _columnModifiedUserName;
            }
        }
        public DataColumn ModifiedDateColumn
        {
            get
            {
                return _columnModifiedDate;
            }
        }
        public override RegisterItemR this[int index]
        {
            get
            {
                return ((RegisterItemR)(this.Rows[index]));
            }
        }
        public void AddRegisterAbsenceRow(RegisterAbsenceRow row)
        {
            this.Rows.Add(row);
        }
        public override void AddRegisterItemRow(RegisterItemR r)
        {
            this.Rows.Add(r);
        }
        public RegisterAbsenceRow AddRegisterAbsenceRow(int employeeID, DateTime fromDate, DateTime toDate, decimal unit, string absenceID, string createdUserName, DateTime createdDate, string modifiedUserName, DateTime modifiedDate)
        {
            RegisterAbsenceRow rowRegisterAbsenceRow = ((RegisterAbsenceRow)(this.NewRow()));
            rowRegisterAbsenceRow["EmployeeID"] = employeeID;
            rowRegisterAbsenceRow["FromDate"] = fromDate;
            rowRegisterAbsenceRow["ToDate"] = toDate;
            rowRegisterAbsenceRow["Unit"] = unit;
            rowRegisterAbsenceRow["AbsenceID"] = absenceID;
            rowRegisterAbsenceRow["CreatedUserName"] = createdUserName;
            rowRegisterAbsenceRow["CreatedDate"] = createdDate;
            rowRegisterAbsenceRow["ModifiedUserName"] = modifiedUserName;
            rowRegisterAbsenceRow["ModifiedDate"] = modifiedDate;
            this.Rows.Add(rowRegisterAbsenceRow);
            return rowRegisterAbsenceRow;
        }
        public RegisterAbsenceRow FindByPrimaryKey(int employeeID, DateTime fromDate, string absenceID)
        {
            return (RegisterAbsenceRow)(Rows.Find(new object[] { employeeID, fromDate, absenceID }));
        }
        public override IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RegisterAbsenceRow(builder);
        }
        public override int GetListByEmployeeID(string employeeIDList, int count)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_GetListByEmployeeID", Connection.GetConnection());

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = employeeIDList;
            sqlCommand.Parameters.Add("@Count", SqlDbType.Int, 4).Value = count;

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
        public override DataColumnCollection GetColumns()
        {
            return Columns;
        }
        public int GetDailyStatistic(string departmentIDList, DateTime workingDay)
        {
            SqlCommand sqlCommand = new SqlCommand("RegisterAbsence_GetDailyStatistic", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 500).Value = departmentIDList;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.CommandTimeout = 0;

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

            return Rows.Count;
        }
        public void DeleteByDepartmentID(string departmentIDList)
        {
            foreach (RegisterAbsenceRow rar in this)
            {
                if (departmentIDList.IndexOf("[" + rar["DepartmentID"].ToString() + "]") >= 0) rar.Delete();
            }
            AcceptChanges();
        }
        #endregion
    }

    public class RegisterAbsenceRow : RegisterItemR
    {
        private RegisterAbsenceTable _tableRegisterAbsence;

        internal RegisterAbsenceRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableRegisterAbsence = ((RegisterAbsenceTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableRegisterAbsence.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableRegisterAbsence.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableRegisterAbsence.EmployeeIDColumn] = Convert.DBNull;
        }
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAbsence.FromDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FromDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.FromDateColumn] = value;
            }
        }
        public bool IsFromDateNull()
        {
            return this.IsNull(_tableRegisterAbsence.FromDateColumn);
        }
        public void SetFromDateNull()
        {
            this[_tableRegisterAbsence.FromDateColumn] = Convert.DBNull;
        }
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAbsence.ToDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ToDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.ToDateColumn] = value;
            }
        }
        public bool IsToDateNull()
        {
            return this.IsNull(_tableRegisterAbsence.ToDateColumn);
        }
        public void SetToDateNull()
        {
            this[_tableRegisterAbsence.ToDateColumn] = Convert.DBNull;
        }
        public decimal Unit
        {
            get
            {
                try
                {
                    return ((decimal)(this[_tableRegisterAbsence.UnitColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Unit because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.UnitColumn] = value;
            }
        }
        public bool IsUnitNull()
        {
            return this.IsNull(_tableRegisterAbsence.UnitColumn);
        }
        public void SetUnitNull()
        {
            this[_tableRegisterAbsence.UnitColumn] = Convert.DBNull;
        }
        public string AbsenceID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAbsence.AbsenceIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value AbsenceID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.AbsenceIDColumn] = value;
            }
        }
        public bool IsAbsenceIDNull()
        {
            return this.IsNull(_tableRegisterAbsence.AbsenceIDColumn);
        }
        public void SetAbsenceIDNull()
        {
            this[_tableRegisterAbsence.AbsenceIDColumn] = Convert.DBNull;
        }
        public string CreatedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAbsence.CreatedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.CreatedUserNameColumn] = value;
            }
        }
        public bool IsCreatedUserNameNull()
        {
            return this.IsNull(_tableRegisterAbsence.CreatedUserNameColumn);
        }
        public void SetCreatedUserNameNull()
        {
            this[_tableRegisterAbsence.CreatedUserNameColumn] = Convert.DBNull;
        }
        public DateTime CreatedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAbsence.CreatedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CreatedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.CreatedDateColumn] = value;
            }
        }
        public bool IsCreatedDateNull()
        {
            return this.IsNull(_tableRegisterAbsence.CreatedDateColumn);
        }
        public void SetCreatedDateNull()
        {
            this[_tableRegisterAbsence.CreatedDateColumn] = Convert.DBNull;
        }
        public string ModifiedUserName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableRegisterAbsence.ModifiedUserNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedUserName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.ModifiedUserNameColumn] = value;
            }
        }
        public bool IsModifiedUserNameNull()
        {
            return this.IsNull(_tableRegisterAbsence.ModifiedUserNameColumn);
        }
        public void SetModifiedUserNameNull()
        {
            this[_tableRegisterAbsence.ModifiedUserNameColumn] = Convert.DBNull;
        }
        public DateTime ModifiedDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableRegisterAbsence.ModifiedDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ModifiedDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableRegisterAbsence.ModifiedDateColumn] = value;
            }
        }
        public bool IsModifiedDateNull()
        {
            return this.IsNull(_tableRegisterAbsence.ModifiedDateColumn);
        }
        public void SetModifiedDateNull()
        {
            this[_tableRegisterAbsence.ModifiedDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
