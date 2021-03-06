using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class DepartmentTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnParentID;
        private DataColumn _columnID;
        private DataColumn _columnName;
        private DataColumn _columnCompanyID;
        private DataColumn _columnPhone;
        private DataColumn _columnFax;
        private DataColumn _columnNotes;
        private DataColumn _columnSortOrder;
        private DataColumn _columnActive;

        private void InitClass()
        {
            _columnParentID = new DataColumn("ParentID", typeof(string));
            _columnParentID.AllowDBNull = true;
            _columnParentID.Caption = "Parent ID";
            _columnParentID.MaxLength = 20;
            _columnParentID.Unique = false;
            _columnParentID.DefaultValue = Convert.DBNull;
            _columnParentID.ExtendedProperties.Add("IsKey", "false");
            _columnParentID.ExtendedProperties.Add("ReadOnly", "false");
            _columnParentID.ExtendedProperties.Add("Description", "Parent ID");
            _columnParentID.ExtendedProperties.Add("Length", "20");
            _columnParentID.ExtendedProperties.Add("Decimals", "0");
            _columnParentID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnParentID);

            _columnID = new DataColumn("ID", typeof(string));
            _columnID.AllowDBNull = false;
            _columnID.Caption = "ID";
            _columnID.MaxLength = 20;
            _columnID.Unique = true;
            _columnID.DefaultValue = Convert.DBNull;
            _columnID.ExtendedProperties.Add("IsKey", "true");
            _columnID.ExtendedProperties.Add("ReadOnly", "false");
            _columnID.ExtendedProperties.Add("Description", "ID");
            _columnID.ExtendedProperties.Add("Length", "20");
            _columnID.ExtendedProperties.Add("Decimals", "0");
            _columnID.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnID);

            _columnName = new DataColumn("Name", typeof(string));
            _columnName.AllowDBNull = true;
            _columnName.Caption = "Name";
            _columnName.MaxLength = 100;
            _columnName.Unique = false;
            _columnName.DefaultValue = Convert.DBNull;
            _columnName.ExtendedProperties.Add("IsKey", "false");
            _columnName.ExtendedProperties.Add("ReadOnly", "false");
            _columnName.ExtendedProperties.Add("Description", "Name");
            _columnName.ExtendedProperties.Add("Length", "100");
            _columnName.ExtendedProperties.Add("Decimals", "0");
            _columnName.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnName);

            _columnCompanyID = new DataColumn("CompanyID", typeof(string));
            _columnCompanyID.AllowDBNull = true;
            _columnCompanyID.Caption = "Company ID";
            _columnCompanyID.MaxLength = 10;
            _columnCompanyID.Unique = false;
            _columnCompanyID.DefaultValue = Convert.DBNull;
            _columnCompanyID.ExtendedProperties.Add("IsKey", "false");
            _columnCompanyID.ExtendedProperties.Add("ReadOnly", "false");
            _columnCompanyID.ExtendedProperties.Add("Description", "Company ID");
            _columnCompanyID.ExtendedProperties.Add("Length", "10");
            _columnCompanyID.ExtendedProperties.Add("Decimals", "0");
            _columnCompanyID.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCompanyID);

            _columnPhone = new DataColumn("Phone", typeof(string));
            _columnPhone.AllowDBNull = true;
            _columnPhone.Caption = "Phone";
            _columnPhone.MaxLength = 20;
            _columnPhone.Unique = false;
            _columnPhone.DefaultValue = Convert.DBNull;
            _columnPhone.ExtendedProperties.Add("IsKey", "false");
            _columnPhone.ExtendedProperties.Add("ReadOnly", "false");
            _columnPhone.ExtendedProperties.Add("Description", "Phone");
            _columnPhone.ExtendedProperties.Add("Length", "20");
            _columnPhone.ExtendedProperties.Add("Decimals", "0");
            _columnPhone.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnPhone);

            _columnFax = new DataColumn("Fax", typeof(string));
            _columnFax.AllowDBNull = true;
            _columnFax.Caption = "Fax";
            _columnFax.MaxLength = 20;
            _columnFax.Unique = false;
            _columnFax.DefaultValue = Convert.DBNull;
            _columnFax.ExtendedProperties.Add("IsKey", "false");
            _columnFax.ExtendedProperties.Add("ReadOnly", "false");
            _columnFax.ExtendedProperties.Add("Description", "Fax");
            _columnFax.ExtendedProperties.Add("Length", "20");
            _columnFax.ExtendedProperties.Add("Decimals", "0");
            _columnFax.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnFax);

            _columnNotes = new DataColumn("Notes", typeof(string));
            _columnNotes.AllowDBNull = true;
            _columnNotes.Caption = "Notes";
            _columnNotes.MaxLength = 100;
            _columnNotes.Unique = false;
            _columnNotes.DefaultValue = Convert.DBNull;
            _columnNotes.ExtendedProperties.Add("IsKey", "false");
            _columnNotes.ExtendedProperties.Add("ReadOnly", "false");
            _columnNotes.ExtendedProperties.Add("Description", "Notes");
            _columnNotes.ExtendedProperties.Add("Length", "100");
            _columnNotes.ExtendedProperties.Add("Decimals", "0");
            _columnNotes.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnNotes);

            _columnSortOrder = new DataColumn("SortOrder", typeof(int));
            _columnSortOrder.AllowDBNull = true;
            _columnSortOrder.Caption = "Sort Order";
            _columnSortOrder.Unique = false;
            _columnSortOrder.DefaultValue = Convert.DBNull;
            _columnSortOrder.ExtendedProperties.Add("IsKey", "false");
            _columnSortOrder.ExtendedProperties.Add("ReadOnly", "false");
            _columnSortOrder.ExtendedProperties.Add("Description", "Sort Order");
            _columnSortOrder.ExtendedProperties.Add("Decimals", "0");
            _columnSortOrder.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnSortOrder);

            _columnActive = new DataColumn("Active", typeof(bool));
            _columnActive.AllowDBNull = true;
            _columnActive.Caption = "Active";
            _columnActive.Unique = false;
            _columnActive.DefaultValue = Convert.DBNull;
            _columnActive.ExtendedProperties.Add("IsKey", "false");
            _columnActive.ExtendedProperties.Add("ReadOnly", "false");
            _columnActive.ExtendedProperties.Add("Description", "Active");
            _columnActive.ExtendedProperties.Add("Decimals", "0");
            _columnActive.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnActive);

            this.PrimaryKey = new DataColumn[] { this.Columns["ID"] };
        }
        #endregion

        #region Constructors
        public DepartmentTable()
            : base("Department")
        {
            this.InitClass();
        }
        public DepartmentTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("Department_GetContent", Connection.GetConnection());
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
        public static DepartmentTable GetContentTable(bool all)
        {
            DepartmentTable departmentTable = new DepartmentTable();
            if (all) departmentTable.AddDepartmentRow(string.Empty, "*", "(Tất cả)", string.Empty, string.Empty, string.Empty, string.Empty, 0, true);
            departmentTable.GetContent();
            return departmentTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("Department_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ParentID", SqlDbType.VarChar, 20, "ParentID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            sqlCommand.Parameters.Add("@CompanyID", SqlDbType.VarChar, 10, "CompanyID");
            sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar, 20, "Phone");
            sqlCommand.Parameters.Add("@Fax", SqlDbType.VarChar, 20, "Fax");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 100, "Notes");
            sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");
            sqlCommand.Parameters.Add("@Active", SqlDbType.Bit, 1, "Active");

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
            SqlCommand sqlCommand = new SqlCommand("Department_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 20, "ID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@ParentID", SqlDbType.VarChar, 20, "ParentID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            sqlCommand.Parameters.Add("@CompanyID", SqlDbType.VarChar, 10, "CompanyID");
            sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar, 20, "Phone");
            sqlCommand.Parameters.Add("@Fax", SqlDbType.VarChar, 20, "Fax");
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 100, "Notes");
            sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");
            sqlCommand.Parameters.Add("@Active", SqlDbType.Bit, 1, "Active");

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
            SqlCommand sqlCommand = new SqlCommand("Department_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");

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

            DepartmentRow row = FindByPrimaryKey(iD);
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
        public DataColumn CompanyIDColumn
        {
            get
            {
                return _columnCompanyID;
            }
        }
        public DataColumn PhoneColumn
        {
            get
            {
                return _columnPhone;
            }
        }
        public DataColumn FaxColumn
        {
            get
            {
                return _columnFax;
            }
        }
        public DataColumn NotesColumn
        {
            get
            {
                return _columnNotes;
            }
        }
        public DataColumn SortOrderColumn
        {
            get
            {
                return _columnSortOrder;
            }
        }
        public DataColumn ActiveColumn
        {
            get
            {
                return _columnActive;
            }
        }
        public DepartmentRow this[int index]
        {
            get
            {
                return ((DepartmentRow)(this.Rows[index]));
            }
        }
        public void AddDepartmentRow(DepartmentRow row)
        {
            this.Rows.Add(row);
        }
        public DepartmentRow AddDepartmentRow(string parentID, string iD, string name, string companyID, string phone, string fax, string notes, short sortOrder, bool active)
        {
            DepartmentRow rowDepartmentRow = ((DepartmentRow)(this.NewRow()));
            rowDepartmentRow["ParentID"] = parentID;
            rowDepartmentRow["ID"] = iD;
            rowDepartmentRow["Name"] = name;
            rowDepartmentRow["CompanyID"] = companyID;
            rowDepartmentRow["Phone"] = phone;
            rowDepartmentRow["Fax"] = fax;
            rowDepartmentRow["Notes"] = notes;
            rowDepartmentRow["SortOrder"] = sortOrder;
            rowDepartmentRow["Active"] = active;
            this.Rows.Add(rowDepartmentRow);
            return rowDepartmentRow;
        }
        public DepartmentRow FindByPrimaryKey(string iD)
        {
            return (DepartmentRow)(Rows.Find(new object[] { iD }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new DepartmentRow(builder);
        }
        public static DepartmentTable GetTreeView(byte groupID)
        {
            DepartmentTable departmentTable = new DepartmentTable();
            SqlCommand sqlCommand = new SqlCommand("Department_GetTreeView", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@GroupID", SqlDbType.TinyInt).Value = groupID;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(departmentTable);
            }
            finally
            {
                Connection.Close();
            }

            return departmentTable;
        }
        public int GetListByUserName(string userName, bool all)
        {
            SqlCommand sqlCommand = new SqlCommand("Department_GetListByUserName", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = userName;
            sqlCommand.Parameters.Add("@All", SqlDbType.Bit, 1).Value = all;

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
        public static byte GetSortOrder(string iD)
        {
            SqlCommand sqlCommand = new SqlCommand("Department_GetSortOrder", Connection.GetConnection());
            byte retVal = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = iD;

            try
            {
                Connection.Open();
                retVal = Convert.ToByte(sqlCommand.ExecuteScalar());
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
        public bool Reorder()
        {
            SqlCommand sqlCommand = new SqlCommand("Department_Reorder", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 20, "ID");
            sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");

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
        public static string GetIDByName(string name)
        {
            SqlCommand sqlCommand = new SqlCommand("Department_GetIDByName", Connection.GetConnection());
            string retVal = string.Empty;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = name;

            try
            {
                Connection.Open();
                retVal = Convert.ToString(sqlCommand.ExecuteScalar());
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
        public int GetFullPath(string userName)
        {
            SqlCommand sqlCommand = new SqlCommand("Department_GetFullPath", Connection.GetConnection());
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = userName;
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
        public int DailyManpower(string departmentIDList, DateTime fromDate, DateTime toDate, byte form)
        {
            SqlCommand sqlCommand = new SqlCommand("Department_DailyManpower", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@DepartmentIDList", SqlDbType.VarChar, 1000).Value = departmentIDList;
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime, 8).Value = fromDate;
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime, 8).Value = toDate;
            sqlCommand.Parameters.Add("@Form", SqlDbType.TinyInt, 1).Value = form;

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
            foreach (DepartmentRow dr in this)
            {
                if (departmentIDList.IndexOf("[" + dr.ID + "]") >= 0 || departmentIDList.IndexOf("[" + dr["DepartmentID"].ToString() + "]") >= 0) dr.Delete();
            }
            AcceptChanges();
        } 
        #endregion
    }

    public class DepartmentRow : DataRow
    {
        private DepartmentTable _tableDepartment;

        internal DepartmentRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableDepartment = ((DepartmentTable)(this.Table));
        }

        #region Properties
        public string ParentID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.ParentIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ParentID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.ParentIDColumn] = value;
            }
        }
        public bool IsParentIDNull()
        {
            return this.IsNull(_tableDepartment.ParentIDColumn);
        }
        public void SetParentIDNull()
        {
            this[_tableDepartment.ParentIDColumn] = Convert.DBNull;
        }
        public string ID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.IDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.IDColumn] = value;
            }
        }
        public bool IsIDNull()
        {
            return this.IsNull(_tableDepartment.IDColumn);
        }
        public void SetIDNull()
        {
            this[_tableDepartment.IDColumn] = Convert.DBNull;
        }
        public string Name
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.NameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.NameColumn] = value;
            }
        }
        public bool IsNameNull()
        {
            return this.IsNull(_tableDepartment.NameColumn);
        }
        public void SetNameNull()
        {
            this[_tableDepartment.NameColumn] = Convert.DBNull;
        }
        public string CompanyID
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.CompanyIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value CompanyID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.CompanyIDColumn] = value;
            }
        }
        public bool IsCompanyIDNull()
        {
            return this.IsNull(_tableDepartment.CompanyIDColumn);
        }
        public void SetCompanyIDNull()
        {
            this[_tableDepartment.CompanyIDColumn] = Convert.DBNull;
        }
        public string Phone
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.PhoneColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Phone because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.PhoneColumn] = value;
            }
        }
        public bool IsPhoneNull()
        {
            return this.IsNull(_tableDepartment.PhoneColumn);
        }
        public void SetPhoneNull()
        {
            this[_tableDepartment.PhoneColumn] = Convert.DBNull;
        }
        public string Fax
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.FaxColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Fax because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.FaxColumn] = value;
            }
        }
        public bool IsFaxNull()
        {
            return this.IsNull(_tableDepartment.FaxColumn);
        }
        public void SetFaxNull()
        {
            this[_tableDepartment.FaxColumn] = Convert.DBNull;
        }
        public string Notes
        {
            get
            {
                try
                {
                    return ((string)(this[_tableDepartment.NotesColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Notes because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.NotesColumn] = value;
            }
        }
        public bool IsNotesNull()
        {
            return this.IsNull(_tableDepartment.NotesColumn);
        }
        public void SetNotesNull()
        {
            this[_tableDepartment.NotesColumn] = Convert.DBNull;
        }
        public int SortOrder
        {
            get
            {
                try
                {
                    return ((int)(this[_tableDepartment.SortOrderColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value SortOrder because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.SortOrderColumn] = value;
            }
        }
        public bool IsSortOrderNull()
        {
            return this.IsNull(_tableDepartment.SortOrderColumn);
        }
        public void SetSortOrderNull()
        {
            this[_tableDepartment.SortOrderColumn] = Convert.DBNull;
        }
        public bool Active
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableDepartment.ActiveColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Active because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableDepartment.ActiveColumn] = value;
            }
        }
        public bool IsActiveNull()
        {
            return this.IsNull(_tableDepartment.ActiveColumn);
        }
        public void SetActiveNull()
        {
            this[_tableDepartment.ActiveColumn] = Convert.DBNull;
        }
        #endregion
    }
}
