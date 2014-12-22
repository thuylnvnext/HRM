using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class VacationTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnID;
        private DataColumn _columnHasWages;
        private DataColumn _columnNotes;

        private void InitClass()
        {
            _columnID = new DataColumn("ID", typeof(DateTime));
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

            _columnHasWages = new DataColumn("HasWages", typeof(bool));
            _columnHasWages.AllowDBNull = true;
            _columnHasWages.Caption = "Has Wages";
            _columnHasWages.Unique = false;
            _columnHasWages.DefaultValue = Convert.DBNull;
            _columnHasWages.ExtendedProperties.Add("IsKey", "false");
            _columnHasWages.ExtendedProperties.Add("ReadOnly", "false");
            _columnHasWages.ExtendedProperties.Add("Description", "Has Wages");
            _columnHasWages.ExtendedProperties.Add("Decimals", "0");
            _columnHasWages.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnHasWages);

            _columnNotes = new DataColumn("Notes", typeof(string));
            _columnNotes.AllowDBNull = true;
            _columnNotes.Caption = "Notes";
            _columnNotes.MaxLength = 50;
            _columnNotes.Unique = false;
            _columnNotes.DefaultValue = Convert.DBNull;
            _columnNotes.ExtendedProperties.Add("IsKey", "false");
            _columnNotes.ExtendedProperties.Add("ReadOnly", "false");
            _columnNotes.ExtendedProperties.Add("Description", "Notes");
            _columnNotes.ExtendedProperties.Add("Length", "50");
            _columnNotes.ExtendedProperties.Add("Decimals", "0");
            _columnNotes.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNotes);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
        #endregion

        #region Constructors
        public VacationTable()
            : base("Vacation")
        {
            this.InitClass();
        }
        public VacationTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Vacation_GetContent", Connection.GetConnection());
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
        public static VacationTable GetContentTable()
        {
            VacationTable vacationTable = new VacationTable();
            vacationTable.GetContent();
            return vacationTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Vacation_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.DateTime, 8, "ID");
            sqlCommand.Parameters.Add("@HasWages", SqlDbType.Bit, 1, "HasWages");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 50, "Notes");

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
            SqlCommand sqlCommand = new SqlCommand("Vacation_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.DateTime, 8, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ID", SqlDbType.DateTime, 8, "ID");
            sqlCommand.Parameters.Add("@HasWages", SqlDbType.Bit, 1, "HasWages");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 50, "Notes");

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
            SqlCommand sqlCommand = new SqlCommand("Vacation_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.DateTime, 8, "ID");

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
        public bool Delete(DateTime iD)
        {
            bool retVal;

            VacationRow row = FindByPrimaryKey(iD);
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
        public DataColumn HasWagesColumn
        {
            get
            {
                return _columnHasWages;
            }
        }
        public DataColumn NotesColumn
        {
            get
            {
                return _columnNotes;
            }
        }
        public VacationRow this[int index]
        {
            get
            {
                return ((VacationRow)(this.Rows[index]));
            }
        }
        public void AddVacationRow(VacationRow row)
        {
            this.Rows.Add(row);
        }
        public VacationRow AddVacationRow(DateTime iD, bool hasWages, string notes)
        {
            VacationRow rowVacationRow = ((VacationRow)(this.NewRow()));
            rowVacationRow["ID"] = iD;
            rowVacationRow["HasWages"] = hasWages;
            rowVacationRow["Notes"] = notes;
            this.Rows.Add(rowVacationRow);
            return rowVacationRow;
        }
        public VacationRow FindByPrimaryKey(DateTime iD)
        {
            return (VacationRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new VacationRow(builder);
        }
        #endregion
    }

    public class VacationRow : DataRow
    {
        private VacationTable _tableVacation;

        internal VacationRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableVacation = ((VacationTable)(this.Table));
        }

        #region Properties
        public DateTime ID
        {
            get
            {
                try
                {
                    return ((DateTime)(this[_tableVacation.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableVacation.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableVacation.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableVacation.IDColumn] = Convert.DBNull;
        }
        public bool HasWages
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableVacation.HasWagesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value HasWages because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableVacation.HasWagesColumn] = value;
            }
        }
        public bool IsHasWagesNull()
        {
            return this.IsNull(_tableVacation.HasWagesColumn);
        }
        public void SetHasWagesNull()
        {
            this[_tableVacation.HasWagesColumn] = Convert.DBNull;
        }
        public string Notes
        {
            get
            {
                try
                {
                    return ((string)(this[_tableVacation.NotesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Notes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableVacation.NotesColumn] = value;
            }
        }
        public bool IsNotesNull()
        {
            return this.IsNull(_tableVacation.NotesColumn);
        }
        public void SetNotesNull()
        {
            this[_tableVacation.NotesColumn] = Convert.DBNull;
        }
        #endregion
    }
}
