using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class EmployeeTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnCode;
        private DataColumn _columnFullName;
        private DataColumn _columnAlias;
        private DataColumn _columnBirthDate;
        private DataColumn _columnSex;
        private DataColumn _columnNationalityID;
        private DataColumn _columnEthnicGroupID;
        private DataColumn _columnReligionID;
        private DataColumn _columnMarriageStatusID;
        private DataColumn _columnCultureLevel;
        private DataColumn _columnUnionEnrollingDate;
        private DataColumn _columnUnionEnrollingPlace;
        private DataColumn _columnPartyEnrollingDate;
        private DataColumn _columnPartyEnrollingPlace;
        private DataColumn _columnEnlistingDate;
        private DataColumn _columnDischargeDate;
        private DataColumn _columnReason;
        private DataColumn _columnEmail;
        private DataColumn _columnPhoto;
        private DataColumn _columnNotes;
        private DataColumn _columnType;
        private DataColumn _columnChangeTypeDate;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(int));
            _columnID.AllowDBNull = false;
            _columnID.Caption = "ID";
            _columnID.Unique = true;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "true");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
            _columnID.ExtendedProperties.Add("Decimals", "0");
            _columnID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnID);

            _columnCode = new DataColumn("Code", typeof(string));
            _columnCode.AllowDBNull = true;
            _columnCode.Caption = "Code";
            _columnCode.MaxLength = 256;
            _columnCode.Unique = false;
            _columnCode.DefaultValue = Convert.DBNull;
            _columnCode.ExtendedProperties.Add("IsKey", "false");
            _columnCode.ExtendedProperties.Add("ReadOnly", "false");
            _columnCode.ExtendedProperties.Add("Description", "Code");
            _columnCode.ExtendedProperties.Add("Length", "256");
            _columnCode.ExtendedProperties.Add("Decimals", "0");
            _columnCode.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCode);

            _columnFullName = new DataColumn("FullName", typeof(string));
            _columnFullName.AllowDBNull = false;
            _columnFullName.Caption = "Full Name";
            _columnFullName.MaxLength = 256;
            _columnFullName.Unique = false;
            _columnFullName.DefaultValue = Convert.DBNull;
            _columnFullName.ExtendedProperties.Add("IsKey", "false");
            _columnFullName.ExtendedProperties.Add("ReadOnly", "false");
            _columnFullName.ExtendedProperties.Add("Description", "Full Name");
            _columnFullName.ExtendedProperties.Add("Length", "256");
            _columnFullName.ExtendedProperties.Add("Decimals", "0");
            _columnFullName.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFullName);

            _columnAlias = new DataColumn("Alias", typeof(string));
            _columnAlias.AllowDBNull = true;
            _columnAlias.Caption = "Alias";
            _columnAlias.MaxLength = 256;
            _columnAlias.Unique = false;
            _columnAlias.DefaultValue = Convert.DBNull;
            _columnAlias.ExtendedProperties.Add("IsKey", "false");
            _columnAlias.ExtendedProperties.Add("ReadOnly", "false");
            _columnAlias.ExtendedProperties.Add("Description", "Alias");
            _columnAlias.ExtendedProperties.Add("Length", "256");
            _columnAlias.ExtendedProperties.Add("Decimals", "0");
            _columnAlias.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnAlias);

            _columnBirthDate = new DataColumn("BirthDate", typeof(DateTime));
            _columnBirthDate.AllowDBNull = true;
            _columnBirthDate.Caption = "Birth Date";
            _columnBirthDate.Unique = false;
            _columnBirthDate.DefaultValue = Convert.DBNull;
            _columnBirthDate.ExtendedProperties.Add("IsKey", "false");
            _columnBirthDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnBirthDate.ExtendedProperties.Add("Description", "Birth Date");
            _columnBirthDate.ExtendedProperties.Add("Decimals", "0");
            _columnBirthDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnBirthDate);

            _columnSex = new DataColumn("Sex", typeof(bool));
            _columnSex.AllowDBNull = true;
            _columnSex.Caption = "Sex";
            _columnSex.Unique = false;
            _columnSex.DefaultValue = Convert.DBNull;
            _columnSex.ExtendedProperties.Add("IsKey", "false");
            _columnSex.ExtendedProperties.Add("ReadOnly", "false");
            _columnSex.ExtendedProperties.Add("Description", "Sex");
            _columnSex.ExtendedProperties.Add("Decimals", "0");
            _columnSex.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSex);

            _columnNationalityID = new DataColumn("NationalityID", typeof(string));
            _columnNationalityID.AllowDBNull = true;
            _columnNationalityID.Caption = "Nationality ID";
            _columnNationalityID.MaxLength = 10;
            _columnNationalityID.Unique = false;
            _columnNationalityID.DefaultValue = Convert.DBNull;
            _columnNationalityID.ExtendedProperties.Add("IsKey", "false");
            _columnNationalityID.ExtendedProperties.Add("ReadOnly", "false");
            _columnNationalityID.ExtendedProperties.Add("Description", "Nationality ID");
            _columnNationalityID.ExtendedProperties.Add("Length", "10");
            _columnNationalityID.ExtendedProperties.Add("Decimals", "0");
            _columnNationalityID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNationalityID);

            _columnEthnicGroupID = new DataColumn("EthnicGroupID", typeof(string));
            _columnEthnicGroupID.AllowDBNull = true;
            _columnEthnicGroupID.Caption = "Ethnic Group ID";
            _columnEthnicGroupID.MaxLength = 10;
            _columnEthnicGroupID.Unique = false;
            _columnEthnicGroupID.DefaultValue = Convert.DBNull;
            _columnEthnicGroupID.ExtendedProperties.Add("IsKey", "false");
            _columnEthnicGroupID.ExtendedProperties.Add("ReadOnly", "false");
            _columnEthnicGroupID.ExtendedProperties.Add("Description", "Ethnic Group ID");
            _columnEthnicGroupID.ExtendedProperties.Add("Length", "10");
            _columnEthnicGroupID.ExtendedProperties.Add("Decimals", "0");
            _columnEthnicGroupID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnEthnicGroupID);

            _columnReligionID = new DataColumn("ReligionID", typeof(string));
            _columnReligionID.AllowDBNull = true;
            _columnReligionID.Caption = "Religion ID";
            _columnReligionID.MaxLength = 10;
            _columnReligionID.Unique = false;
            _columnReligionID.DefaultValue = Convert.DBNull;
            _columnReligionID.ExtendedProperties.Add("IsKey", "false");
            _columnReligionID.ExtendedProperties.Add("ReadOnly", "false");
            _columnReligionID.ExtendedProperties.Add("Description", "Religion ID");
            _columnReligionID.ExtendedProperties.Add("Length", "10");
            _columnReligionID.ExtendedProperties.Add("Decimals", "0");
            _columnReligionID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnReligionID);

            _columnMarriageStatusID = new DataColumn("MarriageStatusID", typeof(string));
            _columnMarriageStatusID.AllowDBNull = true;
            _columnMarriageStatusID.Caption = "Marriage Status ID";
            _columnMarriageStatusID.MaxLength = 10;
            _columnMarriageStatusID.Unique = false;
            _columnMarriageStatusID.DefaultValue = Convert.DBNull;
            _columnMarriageStatusID.ExtendedProperties.Add("IsKey", "false");
            _columnMarriageStatusID.ExtendedProperties.Add("ReadOnly", "false");
            _columnMarriageStatusID.ExtendedProperties.Add("Description", "Marriage Status ID");
            _columnMarriageStatusID.ExtendedProperties.Add("Length", "10");
            _columnMarriageStatusID.ExtendedProperties.Add("Decimals", "0");
            _columnMarriageStatusID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnMarriageStatusID);

            _columnCultureLevel = new DataColumn("CultureLevel", typeof(string));
            _columnCultureLevel.AllowDBNull = true;
            _columnCultureLevel.Caption = "Culture Level";
            _columnCultureLevel.MaxLength = 50;
            _columnCultureLevel.Unique = false;
            _columnCultureLevel.DefaultValue = Convert.DBNull;
            _columnCultureLevel.ExtendedProperties.Add("IsKey", "false");
            _columnCultureLevel.ExtendedProperties.Add("ReadOnly", "false");
            _columnCultureLevel.ExtendedProperties.Add("Description", "Culture Level");
            _columnCultureLevel.ExtendedProperties.Add("Length", "50");
            _columnCultureLevel.ExtendedProperties.Add("Decimals", "0");
            _columnCultureLevel.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCultureLevel);

            _columnUnionEnrollingDate = new DataColumn("UnionEnrollingDate", typeof(DateTime));
            _columnUnionEnrollingDate.AllowDBNull = true;
            _columnUnionEnrollingDate.Caption = "Union Enrolling Date";
            _columnUnionEnrollingDate.Unique = false;
            _columnUnionEnrollingDate.DefaultValue = Convert.DBNull;
            _columnUnionEnrollingDate.ExtendedProperties.Add("IsKey", "false");
            _columnUnionEnrollingDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnUnionEnrollingDate.ExtendedProperties.Add("Description", "Union Enrolling Date");
            _columnUnionEnrollingDate.ExtendedProperties.Add("Decimals", "0");
            _columnUnionEnrollingDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnUnionEnrollingDate);

            _columnUnionEnrollingPlace = new DataColumn("UnionEnrollingPlace", typeof(string));
            _columnUnionEnrollingPlace.AllowDBNull = true;
            _columnUnionEnrollingPlace.Caption = "Union Enrolling Place";
            _columnUnionEnrollingPlace.MaxLength = 100;
            _columnUnionEnrollingPlace.Unique = false;
            _columnUnionEnrollingPlace.DefaultValue = Convert.DBNull;
            _columnUnionEnrollingPlace.ExtendedProperties.Add("IsKey", "false");
            _columnUnionEnrollingPlace.ExtendedProperties.Add("ReadOnly", "false");
            _columnUnionEnrollingPlace.ExtendedProperties.Add("Description", "Union Enrolling Place");
            _columnUnionEnrollingPlace.ExtendedProperties.Add("Length", "100");
            _columnUnionEnrollingPlace.ExtendedProperties.Add("Decimals", "0");
            _columnUnionEnrollingPlace.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnUnionEnrollingPlace);

            _columnPartyEnrollingDate = new DataColumn("PartyEnrollingDate", typeof(DateTime));
            _columnPartyEnrollingDate.AllowDBNull = true;
            _columnPartyEnrollingDate.Caption = "Party Enrolling Date";
            _columnPartyEnrollingDate.Unique = false;
            _columnPartyEnrollingDate.DefaultValue = Convert.DBNull;
            _columnPartyEnrollingDate.ExtendedProperties.Add("IsKey", "false");
            _columnPartyEnrollingDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnPartyEnrollingDate.ExtendedProperties.Add("Description", "Party Enrolling Date");
            _columnPartyEnrollingDate.ExtendedProperties.Add("Decimals", "0");
            _columnPartyEnrollingDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPartyEnrollingDate);

            _columnPartyEnrollingPlace = new DataColumn("PartyEnrollingPlace", typeof(string));
            _columnPartyEnrollingPlace.AllowDBNull = true;
            _columnPartyEnrollingPlace.Caption = "Party Enrolling Place";
            _columnPartyEnrollingPlace.MaxLength = 100;
            _columnPartyEnrollingPlace.Unique = false;
            _columnPartyEnrollingPlace.DefaultValue = Convert.DBNull;
            _columnPartyEnrollingPlace.ExtendedProperties.Add("IsKey", "false");
            _columnPartyEnrollingPlace.ExtendedProperties.Add("ReadOnly", "false");
            _columnPartyEnrollingPlace.ExtendedProperties.Add("Description", "Party Enrolling Place");
            _columnPartyEnrollingPlace.ExtendedProperties.Add("Length", "100");
            _columnPartyEnrollingPlace.ExtendedProperties.Add("Decimals", "0");
            _columnPartyEnrollingPlace.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPartyEnrollingPlace);

            _columnEnlistingDate = new DataColumn("EnlistingDate", typeof(DateTime));
            _columnEnlistingDate.AllowDBNull = true;
            _columnEnlistingDate.Caption = "Enlisting Date";
            _columnEnlistingDate.Unique = false;
            _columnEnlistingDate.DefaultValue = Convert.DBNull;
            _columnEnlistingDate.ExtendedProperties.Add("IsKey", "false");
            _columnEnlistingDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnEnlistingDate.ExtendedProperties.Add("Description", "Enlisting Date");
            _columnEnlistingDate.ExtendedProperties.Add("Decimals", "0");
            _columnEnlistingDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnEnlistingDate);

            _columnDischargeDate = new DataColumn("DischargeDate", typeof(DateTime));
            _columnDischargeDate.AllowDBNull = true;
            _columnDischargeDate.Caption = "Discharge Date";
            _columnDischargeDate.Unique = false;
            _columnDischargeDate.DefaultValue = Convert.DBNull;
            _columnDischargeDate.ExtendedProperties.Add("IsKey", "false");
            _columnDischargeDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnDischargeDate.ExtendedProperties.Add("Description", "Discharge Date");
            _columnDischargeDate.ExtendedProperties.Add("Decimals", "0");
            _columnDischargeDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDischargeDate);

            _columnReason = new DataColumn("Reason", typeof(string));
            _columnReason.AllowDBNull = true;
            _columnReason.Caption = "Reason";
            _columnReason.MaxLength = 100;
            _columnReason.Unique = false;
            _columnReason.DefaultValue = Convert.DBNull;
            _columnReason.ExtendedProperties.Add("IsKey", "false");
            _columnReason.ExtendedProperties.Add("ReadOnly", "false");
            _columnReason.ExtendedProperties.Add("Description", "Reason");
            _columnReason.ExtendedProperties.Add("Length", "100");
            _columnReason.ExtendedProperties.Add("Decimals", "0");
            _columnReason.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnReason);

            _columnEmail = new DataColumn("Email", typeof(string));
            _columnEmail.AllowDBNull = true;
            _columnEmail.Caption = "Email";
            _columnEmail.MaxLength = 100;
            _columnEmail.Unique = false;
            _columnEmail.DefaultValue = Convert.DBNull;
            _columnEmail.ExtendedProperties.Add("IsKey", "false");
            _columnEmail.ExtendedProperties.Add("ReadOnly", "false");
            _columnEmail.ExtendedProperties.Add("Description", "Email");
            _columnEmail.ExtendedProperties.Add("Length", "100");
            _columnEmail.ExtendedProperties.Add("Decimals", "0");
            _columnEmail.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnEmail);

            _columnPhoto = new DataColumn("Photo", typeof(string));
            _columnPhoto.AllowDBNull = true;
            _columnPhoto.Caption = "Photo";
            _columnPhoto.MaxLength = 250;
            _columnPhoto.Unique = false;
            _columnPhoto.DefaultValue = Convert.DBNull;
            _columnPhoto.ExtendedProperties.Add("IsKey", "false");
            _columnPhoto.ExtendedProperties.Add("ReadOnly", "false");
            _columnPhoto.ExtendedProperties.Add("Description", "Photo");
            _columnPhoto.ExtendedProperties.Add("Length", "250");
            _columnPhoto.ExtendedProperties.Add("Decimals", "0");
            _columnPhoto.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPhoto);

            _columnNotes = new DataColumn("Notes", typeof(string));
            _columnNotes.AllowDBNull = true;
            _columnNotes.Caption = "Notes";
            _columnNotes.MaxLength = 500;
            _columnNotes.Unique = false;
            _columnNotes.DefaultValue = Convert.DBNull;
            _columnNotes.ExtendedProperties.Add("IsKey", "false");
            _columnNotes.ExtendedProperties.Add("ReadOnly", "false");
            _columnNotes.ExtendedProperties.Add("Description", "Notes");
            _columnNotes.ExtendedProperties.Add("Length", "500");
            _columnNotes.ExtendedProperties.Add("Decimals", "0");
            _columnNotes.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNotes);


            _columnType = new DataColumn("Type", typeof(int));
            _columnType.AllowDBNull = false;
            _columnType.Caption = "Type";
            _columnType.Unique = false;
            _columnType.DefaultValue = Convert.DBNull;
            _columnType.ExtendedProperties.Add("IsKey", "false");
            _columnType.ExtendedProperties.Add("ReadOnly", "false");
            _columnType.ExtendedProperties.Add("Description", "Type");
            _columnType.ExtendedProperties.Add("Decimals", "0");
            _columnType.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnType);

            _columnChangeTypeDate = new DataColumn("ChangeTypeDate", typeof(DateTime));
            _columnChangeTypeDate.AllowDBNull = true;
            _columnChangeTypeDate.Caption = "ChangeTypeDate";
            _columnChangeTypeDate.Unique = false;
            _columnChangeTypeDate.DefaultValue = Convert.DBNull;
            _columnChangeTypeDate.ExtendedProperties.Add("IsKey", "false");
            _columnChangeTypeDate.ExtendedProperties.Add("ReadOnly", "false");
            _columnChangeTypeDate.ExtendedProperties.Add("Description", "ChangeTypeDate");
            _columnChangeTypeDate.ExtendedProperties.Add("Decimals", "0");
            _columnChangeTypeDate.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnChangeTypeDate);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public EmployeeTable()
            : base("Employee")
        {
            this.InitClass();
        }
        public EmployeeTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent(string userName)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetContent", Connection.GetConnection());
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 30).Value = userName;
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
        public static EmployeeTable GetContentTable(string userName)
        {
            EmployeeTable employeeTable = new EmployeeTable();
            employeeTable.GetContent(userName);
            return employeeTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            sqlCommand.Parameters.Add("@Code", SqlDbType.VarChar, 256, "Code");
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 30, "FullName");
            sqlCommand.Parameters.Add("@Alias", SqlDbType.NVarChar, 30, "Alias");
            sqlCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8, "BirthDate");
            sqlCommand.Parameters.Add("@Sex", SqlDbType.Bit, 1, "Sex");
            sqlCommand.Parameters.Add("@NationalityID", SqlDbType.VarChar, 10, "NationalityID");
            sqlCommand.Parameters.Add("@EthnicGroupID", SqlDbType.VarChar, 10, "EthnicGroupID");
            sqlCommand.Parameters.Add("@ReligionID", SqlDbType.VarChar, 10, "ReligionID");
            sqlCommand.Parameters.Add("@MarriageStatusID", SqlDbType.VarChar, 10, "MarriageStatusID");
            sqlCommand.Parameters.Add("@CultureLevel", SqlDbType.VarChar, 50, "CultureLevel");
            sqlCommand.Parameters.Add("@UnionEnrollingDate", SqlDbType.DateTime, 8, "UnionEnrollingDate");
            sqlCommand.Parameters.Add("@UnionEnrollingPlace", SqlDbType.NVarChar, 100, "UnionEnrollingPlace");
            sqlCommand.Parameters.Add("@PartyEnrollingDate", SqlDbType.DateTime, 8, "PartyEnrollingDate");
            sqlCommand.Parameters.Add("@PartyEnrollingPlace", SqlDbType.NVarChar, 100, "PartyEnrollingPlace");
            sqlCommand.Parameters.Add("@EnlistingDate", SqlDbType.DateTime, 8, "EnlistingDate");
            sqlCommand.Parameters.Add("@DischargeDate", SqlDbType.DateTime, 8, "DischargeDate");
            sqlCommand.Parameters.Add("@Reason", SqlDbType.NVarChar, 100, "Reason");
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
            sqlCommand.Parameters.Add("@Photo", SqlDbType.NVarChar, 250, "Photo");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 500, "Notes");

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
            SqlCommand sqlCommand = new SqlCommand("Employee_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.Int, 4, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            sqlCommand.Parameters.Add("@Code", SqlDbType.VarChar, 256, "Code");
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 30, "FullName");
            sqlCommand.Parameters.Add("@Alias", SqlDbType.NVarChar, 30, "Alias");
            sqlCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8, "BirthDate");
            sqlCommand.Parameters.Add("@Sex", SqlDbType.Bit, 1, "Sex");
            sqlCommand.Parameters.Add("@NationalityID", SqlDbType.VarChar, 10, "NationalityID");
            sqlCommand.Parameters.Add("@EthnicGroupID", SqlDbType.VarChar, 10, "EthnicGroupID");
            sqlCommand.Parameters.Add("@ReligionID", SqlDbType.VarChar, 10, "ReligionID");
            sqlCommand.Parameters.Add("@MarriageStatusID", SqlDbType.VarChar, 10, "MarriageStatusID");
            sqlCommand.Parameters.Add("@CultureLevel", SqlDbType.VarChar, 50, "CultureLevel");
            sqlCommand.Parameters.Add("@UnionEnrollingDate", SqlDbType.DateTime, 8, "UnionEnrollingDate");
            sqlCommand.Parameters.Add("@UnionEnrollingPlace", SqlDbType.NVarChar, 100, "UnionEnrollingPlace");
            sqlCommand.Parameters.Add("@PartyEnrollingDate", SqlDbType.DateTime, 8, "PartyEnrollingDate");
            sqlCommand.Parameters.Add("@PartyEnrollingPlace", SqlDbType.NVarChar, 100, "PartyEnrollingPlace");
            sqlCommand.Parameters.Add("@EnlistingDate", SqlDbType.DateTime, 8, "EnlistingDate");
            sqlCommand.Parameters.Add("@DischargeDate", SqlDbType.DateTime, 8, "DischargeDate");
            sqlCommand.Parameters.Add("@Reason", SqlDbType.NVarChar, 100, "Reason");
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
            sqlCommand.Parameters.Add("@Photo", SqlDbType.NVarChar, 250, "Photo");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 500, "Notes");

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
            SqlCommand sqlCommand = new SqlCommand("Employee_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");

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
        public bool Delete(int iD)
        {
            bool retVal;

            EmployeeRow row = FindByPrimaryKey(iD);
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
        public DataColumn CodeColumn
        {
            get
            {
                return _columnCode;
            }
        }
        public DataColumn FullNameColumn
        {
            get
            {
                return _columnFullName;
            }
        }
        public DataColumn AliasColumn
        {
            get
            {
                return _columnAlias;
            }
        }
        public DataColumn BirthDateColumn
        {
            get
            {
                return _columnBirthDate;
            }
        }
        public DataColumn SexColumn
        {
            get
            {
                return _columnSex;
            }
        }
        public DataColumn NationalityIDColumn
        {
            get
            {
                return _columnNationalityID;
            }
        }
        public DataColumn EthnicGroupIDColumn
        {
            get
            {
                return _columnEthnicGroupID;
            }
        }
        public DataColumn ReligionIDColumn
        {
            get
            {
                return _columnReligionID;
            }
        }
        public DataColumn MarriageStatusIDColumn
        {
            get
            {
                return _columnMarriageStatusID;
            }
        }
        public DataColumn CultureLevelColumn
        {
            get
            {
                return _columnCultureLevel;
            }
        }
        public DataColumn UnionEnrollingDateColumn
        {
            get
            {
                return _columnUnionEnrollingDate;
            }
        }
        public DataColumn UnionEnrollingPlaceColumn
        {
            get
            {
                return _columnUnionEnrollingPlace;
            }
        }
        public DataColumn PartyEnrollingDateColumn
        {
            get
            {
                return _columnPartyEnrollingDate;
            }
        }
        public DataColumn PartyEnrollingPlaceColumn
        {
            get
            {
                return _columnPartyEnrollingPlace;
            }
        }
        public DataColumn EnlistingDateColumn
        {
            get
            {
                return _columnEnlistingDate;
            }
        }
        public DataColumn DischargeDateColumn
        {
            get
            {
                return _columnDischargeDate;
            }
        }
        public DataColumn ReasonColumn
        {
            get
            {
                return _columnReason;
            }
        }
        public DataColumn EmailColumn
        {
            get
            {
                return _columnEmail;
            }
        }
        public DataColumn PhotoColumn
        {
            get
            {
                return _columnPhoto;
            }
        }
        public DataColumn NotesColumn
        {
            get
            {
                return _columnNotes;
            }
        }

        public DataColumn TypeColumn
        {
            get
            {
                return _columnType;
            }
        }

        public DataColumn ChangeTypeDateColumn
        {
            get
            {
                return _columnChangeTypeDate;
            }
        }
        public EmployeeRow this[int index]
        {
            get
            {
                return ((EmployeeRow)(this.Rows[index]));
            }
        }
        public void AddEmployeeRow(EmployeeRow row)
        {
            this.Rows.Add(row);
        }
        public EmployeeRow AddEmployeeRow(int iD, string code, string fullName, string alias, DateTime birthDate, bool sex, string nationalityID, string ethnicGroupID, string religionID, string marriageStatusID, string cultureLevel, DateTime unionEnrollingDate, string unionEnrollingPlace, DateTime partyEnrollingDate, string partyEnrollingPlace, DateTime enlistingDate, DateTime dischargeDate, string reason, string email, string photo, string notes, int type, DateTime changeTypeDate)
        {
            EmployeeRow rowEmployeeRow = ((EmployeeRow)(this.NewRow()));
            rowEmployeeRow["ID"] = iD;
            rowEmployeeRow["Code"] = code;
            rowEmployeeRow["FullName"] = fullName;
            rowEmployeeRow["Alias"] = alias;
            rowEmployeeRow["BirthDate"] = birthDate;
            rowEmployeeRow["Sex"] = sex;
            rowEmployeeRow["NationalityID"] = nationalityID;
            rowEmployeeRow["EthnicGroupID"] = ethnicGroupID;
            rowEmployeeRow["ReligionID"] = religionID;
            rowEmployeeRow["MarriageStatusID"] = marriageStatusID;
            rowEmployeeRow["CultureLevel"] = cultureLevel;
            rowEmployeeRow["UnionEnrollingDate"] = unionEnrollingDate;
            rowEmployeeRow["UnionEnrollingPlace"] = unionEnrollingPlace;
            rowEmployeeRow["PartyEnrollingDate"] = partyEnrollingDate;
            rowEmployeeRow["PartyEnrollingPlace"] = partyEnrollingPlace;
            rowEmployeeRow["EnlistingDate"] = enlistingDate;
            rowEmployeeRow["DischargeDate"] = dischargeDate;
            rowEmployeeRow["Reason"] = reason;
            rowEmployeeRow["Email"] = email;
            rowEmployeeRow["Photo"] = photo;
            rowEmployeeRow["Notes"] = notes;
            rowEmployeeRow["Type"] = type;
            rowEmployeeRow["ChangeTypeDate"] = changeTypeDate;
            this.Rows.Add(rowEmployeeRow);
            return rowEmployeeRow;
        }
        public EmployeeRow FindByPrimaryKey(int iD)
        {
            return (EmployeeRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new EmployeeRow(builder);
        }
        public static int GetNewID()
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetNewID", Connection.GetConnection());
            int retVal = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                Connection.Open();
                retVal = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = 0;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }

        public static bool ChangeType(int ID)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_ChangeType", Connection.GetConnection());
            int retVal = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4).Value = ID;
            try
            {
                Connection.Open();
                retVal = sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                retVal = 0;
            }
            finally
            {
                Connection.Close();
            }
            return retVal < 0;
        }

        public int GetListBirthdayByDepartmentID(string departmentIDList, DateTime workingDay, int month)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetListBirthdayByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@Month", SqlDbType.Int, 4).Value = month;

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

        public int GetListByDepartmentID(string departmentIDList, DateTime workingDay, int iD, string userName)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetListByDepartmentID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4).Value = iD;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = userName;

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
        public int GetListByDepartmentIDAndDuration(string departmentIDList, DateTime fromDate, string iDs)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetListByDepartmentIDAndDuration", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            sqlCommand.Parameters.Add("@IDs", SqlDbType.VarChar, (int)Math.Pow(2, 31) - 1).Value = iDs;

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
        public int GetListByID(int iD)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetListByID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4).Value = iD;

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
        public static EmployeeRow GetInfoByID(int iD)
        {
            EmployeeTable employee = new EmployeeTable();
            SqlCommand sqlCommand = new SqlCommand("Employee_GetListByID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4).Value = iD;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(employee);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return employee.FindByPrimaryKey(iD);
        }
        public int FindByFullName(string name, DateTime workingDay, string userName)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_FindByFullName", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Value", SqlDbType.NVarChar, 30).Value = name;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = workingDay;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = userName;

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
        public int AdvancedSearch(string criteria, DateTime workingDay)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_AdvancedSearch", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Criteria", SqlDbType.NVarChar, 500).Value = criteria;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;

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
        public void DeleteByDepartmentID(string departmentIDList)
        {
            foreach (EmployeeRow er in this)
            {
                if (departmentIDList.IndexOf("[" + er["DepartmentID"].ToString() + "]") >= 0) er.Delete();
            }
            AcceptChanges();
        }
        public static int GetIDByCode(string code)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetIDByCode", Connection.GetConnection());
            int retVal = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Code", SqlDbType.VarChar, 15).Value = code;

            try
            {
                Connection.Open();
                retVal = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                retVal = 0;
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
        public static string GetLastNameByID(int iD)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetLastNameByID", Connection.GetConnection());
            string retVal = string.Empty;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4).Value = iD;

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
        public bool Insert(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_Insert", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            sqlCommand.Parameters.Add("@Code", SqlDbType.VarChar, 15, "Code");
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 30, "FullName");
            sqlCommand.Parameters.Add("@Alias", SqlDbType.NVarChar, 30, "Alias");
            sqlCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8, "BirthDate");
            sqlCommand.Parameters.Add("@Sex", SqlDbType.Bit, 1, "Sex");
            sqlCommand.Parameters.Add("@NationalityID", SqlDbType.VarChar, 10, "NationalityID");
            sqlCommand.Parameters.Add("@EthnicGroupID", SqlDbType.VarChar, 10, "EthnicGroupID");
            sqlCommand.Parameters.Add("@ReligionID", SqlDbType.VarChar, 10, "ReligionID");
            sqlCommand.Parameters.Add("@MarriageStatusID", SqlDbType.VarChar, 10, "MarriageStatusID");
            sqlCommand.Parameters.Add("@CultureLevel", SqlDbType.VarChar, 50, "CultureLevel");
            sqlCommand.Parameters.Add("@UnionEnrollingDate", SqlDbType.DateTime, 8, "UnionEnrollingDate");
            sqlCommand.Parameters.Add("@UnionEnrollingPlace", SqlDbType.NVarChar, 100, "UnionEnrollingPlace");
            sqlCommand.Parameters.Add("@PartyEnrollingDate", SqlDbType.DateTime, 8, "PartyEnrollingDate");
            sqlCommand.Parameters.Add("@PartyEnrollingPlace", SqlDbType.NVarChar, 100, "PartyEnrollingPlace");
            sqlCommand.Parameters.Add("@EnlistingDate", SqlDbType.DateTime, 8, "EnlistingDate");
            sqlCommand.Parameters.Add("@DischargeDate", SqlDbType.DateTime, 8, "DischargeDate");
            sqlCommand.Parameters.Add("@Reason", SqlDbType.NVarChar, 100, "Reason");
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
            sqlCommand.Parameters.Add("@Photo", SqlDbType.NVarChar, 250, "Photo");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 500, "Notes");
            sqlCommand.Parameters.Add("@Type", SqlDbType.TinyInt, 4, "Type");
            sqlCommand.Parameters.Add("@ChangeTypeDate", SqlDbType.DateTime, 8, "ChangeTypeDate");

            sqlDataAdapter.InsertCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Update(this);
            }
            catch
            {
                retVal = false;
            }
            finally
            {
            }
            return retVal;
        }
        public int LabourContract(string employeeIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_LabourContract", Connection.GetConnection());
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
        public int LimitLabourContract(string employeeIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_LimitLabourContract", Connection.GetConnection());
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
        public int PermanetLabourContract(string employeeIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_PermanentLabourContract", Connection.GetConnection());
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
        public int GetHasInsurance(byte month, short year)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_GetHasInsurance", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Month", SqlDbType.TinyInt, 1).Value = month;
            sqlCommand.Parameters.Add("@Year", SqlDbType.SmallInt, 2).Value = year;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            Clear();
            try
            {
                Clear();
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
        public int InsuranceDeclaration(string employeeIDList)
        {
            SqlCommand sqlCommand = new SqlCommand("Employee_InsuranceDeclaration", Connection.GetConnection());
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
        public static int GetNumberEmployees(DateTime workingDay, bool gender)
        {
            int retVal = 0;
            SqlCommand sqlCommand = new SqlCommand("Employee_GetNumberOfEmployees", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime, 8).Value = workingDay;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.Bit, 1).Value = gender;
            try
            {
                Connection.Open();
                retVal = (int)sqlCommand.ExecuteScalar();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }        
        #endregion
    }

    public class EmployeeRow : DataRow
    {
        private EmployeeTable _tableEmployee;

        internal EmployeeRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableEmployee = ((EmployeeTable)(this.Table));
        }

        #region Properties
        public int ID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableEmployee.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableEmployee.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableEmployee.IDColumn] = Convert.DBNull;
        }
        public string Code
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.CodeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Code because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.CodeColumn] = value;
            }
        }
        public bool IsCodeNull()
        {
            return this.IsNull(_tableEmployee.CodeColumn);
        }
        public void SetCodeNull()
        {
            this[_tableEmployee.CodeColumn] = Convert.DBNull;
        }
        public string FullName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.FullNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FullName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.FullNameColumn] = value;
            }
        }
        public bool IsFullNameNull()
        {
            return this.IsNull(_tableEmployee.FullNameColumn);
        }
        public void SetFullNameNull()
        {
            this[_tableEmployee.FullNameColumn] = Convert.DBNull;
        }
        public string Alias
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.AliasColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Alias because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.AliasColumn] = value;
            }
        }
        public bool IsAliasNull()
        {
            return this.IsNull(_tableEmployee.AliasColumn);
        }
        public void SetAliasNull()
        {
            this[_tableEmployee.AliasColumn] = Convert.DBNull;
        }
        public DateTime BirthDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployee.BirthDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BirthDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.BirthDateColumn] = value;
            }
        }
        public bool IsBirthDateNull()
        {
            return this.IsNull(_tableEmployee.BirthDateColumn);
        }
        public void SetBirthDateNull()
        {
            this[_tableEmployee.BirthDateColumn] = Convert.DBNull;
        }
        public bool Sex
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableEmployee.SexColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Sex because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.SexColumn] = value;
            }
        }
        public bool IsSexNull()
        {
            return this.IsNull(_tableEmployee.SexColumn);
        }
        public void SetSexNull()
        {
            this[_tableEmployee.SexColumn] = Convert.DBNull;
        }
        public string NationalityID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.NationalityIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value NationalityID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.NationalityIDColumn] = value;
            }
        }
        public bool IsNationalityIDNull()
        {
            return this.IsNull(_tableEmployee.NationalityIDColumn);
        }
        public void SetNationalityIDNull()
        {
            this[_tableEmployee.NationalityIDColumn] = Convert.DBNull;
        }
        public string EthnicGroupID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.EthnicGroupIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EthnicGroupID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.EthnicGroupIDColumn] = value;
            }
        }
        public bool IsEthnicGroupIDNull()
        {
            return this.IsNull(_tableEmployee.EthnicGroupIDColumn);
        }
        public void SetEthnicGroupIDNull()
        {
            this[_tableEmployee.EthnicGroupIDColumn] = Convert.DBNull;
        }
        public string ReligionID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.ReligionIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ReligionID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.ReligionIDColumn] = value;
            }
        }
        public bool IsReligionIDNull()
        {
            return this.IsNull(_tableEmployee.ReligionIDColumn);
        }
        public void SetReligionIDNull()
        {
            this[_tableEmployee.ReligionIDColumn] = Convert.DBNull;
        }
        public string MarriageStatusID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.MarriageStatusIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value MarriageStatusID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.MarriageStatusIDColumn] = value;
            }
        }
        public bool IsMarriageStatusIDNull()
        {
            return this.IsNull(_tableEmployee.MarriageStatusIDColumn);
        }
        public void SetMarriageStatusIDNull()
        {
            this[_tableEmployee.MarriageStatusIDColumn] = Convert.DBNull;
        }
        public string CultureLevel
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.CultureLevelColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CultureLevel because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.CultureLevelColumn] = value;
            }
        }
        public bool IsCultureLevelNull()
        {
            return this.IsNull(_tableEmployee.CultureLevelColumn);
        }
        public void SetCultureLevelNull()
        {
            this[_tableEmployee.CultureLevelColumn] = Convert.DBNull;
        }
        public DateTime UnionEnrollingDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployee.UnionEnrollingDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value UnionEnrollingDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.UnionEnrollingDateColumn] = value;
            }
        }
        public bool IsUnionEnrollingDateNull()
        {
            return this.IsNull(_tableEmployee.UnionEnrollingDateColumn);
        }
        public void SetUnionEnrollingDateNull()
        {
            this[_tableEmployee.UnionEnrollingDateColumn] = Convert.DBNull;
        }
        public string UnionEnrollingPlace
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.UnionEnrollingPlaceColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value UnionEnrollingPlace because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.UnionEnrollingPlaceColumn] = value;
            }
        }
        public bool IsUnionEnrollingPlaceNull()
        {
            return this.IsNull(_tableEmployee.UnionEnrollingPlaceColumn);
        }
        public void SetUnionEnrollingPlaceNull()
        {
            this[_tableEmployee.UnionEnrollingPlaceColumn] = Convert.DBNull;
        }
        public DateTime PartyEnrollingDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployee.PartyEnrollingDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PartyEnrollingDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.PartyEnrollingDateColumn] = value;
            }
        }
        public bool IsPartyEnrollingDateNull()
        {
            return this.IsNull(_tableEmployee.PartyEnrollingDateColumn);
        }
        public void SetPartyEnrollingDateNull()
        {
            this[_tableEmployee.PartyEnrollingDateColumn] = Convert.DBNull;
        }
        public string PartyEnrollingPlace
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.PartyEnrollingPlaceColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value PartyEnrollingPlace because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.PartyEnrollingPlaceColumn] = value;
            }
        }
        public bool IsPartyEnrollingPlaceNull()
        {
            return this.IsNull(_tableEmployee.PartyEnrollingPlaceColumn);
        }
        public void SetPartyEnrollingPlaceNull()
        {
            this[_tableEmployee.PartyEnrollingPlaceColumn] = Convert.DBNull;
        }
        public DateTime EnlistingDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployee.EnlistingDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EnlistingDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.EnlistingDateColumn] = value;
            }
        }
        public bool IsEnlistingDateNull()
        {
            return this.IsNull(_tableEmployee.EnlistingDateColumn);
        }
        public void SetEnlistingDateNull()
        {
            this[_tableEmployee.EnlistingDateColumn] = Convert.DBNull;
        }
        public DateTime DischargeDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployee.DischargeDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DischargeDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.DischargeDateColumn] = value;
            }
        }
        public bool IsDischargeDateNull()
        {
            return this.IsNull(_tableEmployee.DischargeDateColumn);
        }
        public void SetDischargeDateNull()
        {
            this[_tableEmployee.DischargeDateColumn] = Convert.DBNull;
        }
        public string Reason
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.ReasonColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Reason because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.ReasonColumn] = value;
            }
        }
        public bool IsReasonNull()
        {
            return this.IsNull(_tableEmployee.ReasonColumn);
        }
        public void SetReasonNull()
        {
            this[_tableEmployee.ReasonColumn] = Convert.DBNull;
        }
        public string Email
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.EmailColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Email because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.EmailColumn] = value;
            }
        }
        public bool IsEmailNull()
        {
            return this.IsNull(_tableEmployee.EmailColumn);
        }
        public void SetEmailNull()
        {
            this[_tableEmployee.EmailColumn] = Convert.DBNull;
        }
        public string Photo
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.PhotoColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Photo because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.PhotoColumn] = value;
            }
        }
        public bool IsPhotoNull()
        {
            return this.IsNull(_tableEmployee.PhotoColumn);
        }
        public void SetPhotoNull()
        {
            this[_tableEmployee.PhotoColumn] = Convert.DBNull;
        }
        public string Notes
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployee.NotesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Notes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.NotesColumn] = value;
            }
        }
        public bool IsNotesNull()
        {
            return this.IsNull(_tableEmployee.NotesColumn);
        }
        public void SetNotesNull()
        {
            this[_tableEmployee.NotesColumn] = Convert.DBNull;
        }

        public int Type
        {
            get
            {
                try
                {
                    return ((int)(this[_tableEmployee.TypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Type because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.TypeColumn] = value;
            }
        }
        public bool IsTypeNull()
        {
            return this.IsNull(_tableEmployee.TypeColumn);
        }
        public void SetTypeNull()
        {
            this[_tableEmployee.TypeColumn] = Convert.DBNull;
        }


        public DateTime ChangeTypeDate
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableEmployee.ChangeTypeDateColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ChangeTypeDate because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployee.ChangeTypeDateColumn] = value;
            }
        }
        public bool IsChangeTypeDateNull()
        {
            return this.IsNull(_tableEmployee.ChangeTypeDateColumn);
        }
        public void SetChangeTypeDateNull()
        {
            this[_tableEmployee.ChangeTypeDateColumn] = Convert.DBNull;
        }
        #endregion
    }
}
