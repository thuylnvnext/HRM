using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
	public class CompanyTable : DataTable, IEnumerable
	{
		#region Private
		private DataColumn _columnID;
		private DataColumn _columnCompanyTypeID;
		private DataColumn _columnName;
		private DataColumn _columnAddress;
		private DataColumn _columnPhone;
		private DataColumn _columnFax;
		private DataColumn _columnEmail;
		private DataColumn _columnWebSite;
		private DataColumn _columnSortOrder;
		private DataColumn _columnDefault;
		private DataColumn _columnActive;
		
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
			
			_columnCompanyTypeID = new DataColumn("CompanyTypeID", typeof(string));
			_columnCompanyTypeID.AllowDBNull = true;
			_columnCompanyTypeID.Caption = "Company Type ID";
			_columnCompanyTypeID.MaxLength = 10;
			_columnCompanyTypeID.Unique = false;
			_columnCompanyTypeID.DefaultValue = Convert.DBNull;
			_columnCompanyTypeID.ExtendedProperties.Add("IsKey", "false");
			_columnCompanyTypeID.ExtendedProperties.Add("ReadOnly", "false");
			_columnCompanyTypeID.ExtendedProperties.Add("Description", "Company Type ID");
			_columnCompanyTypeID.ExtendedProperties.Add("Length", "10");
			_columnCompanyTypeID.ExtendedProperties.Add("Decimals", "0");
			_columnCompanyTypeID.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnCompanyTypeID);			
			
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
			
			_columnAddress = new DataColumn("Address", typeof(string));
			_columnAddress.AllowDBNull = true;
			_columnAddress.Caption = "Address";
			_columnAddress.MaxLength = 250;
			_columnAddress.Unique = false;
			_columnAddress.DefaultValue = Convert.DBNull;
			_columnAddress.ExtendedProperties.Add("IsKey", "false");
			_columnAddress.ExtendedProperties.Add("ReadOnly", "false");
			_columnAddress.ExtendedProperties.Add("Description", "Address");
			_columnAddress.ExtendedProperties.Add("Length", "250");
			_columnAddress.ExtendedProperties.Add("Decimals", "0");
			_columnAddress.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnAddress);			
			
			_columnPhone = new DataColumn("Phone", typeof(string));
			_columnPhone.AllowDBNull = true;
			_columnPhone.Caption = "Phone";
			_columnPhone.MaxLength = 50;
			_columnPhone.Unique = false;
			_columnPhone.DefaultValue = Convert.DBNull;
			_columnPhone.ExtendedProperties.Add("IsKey", "false");
			_columnPhone.ExtendedProperties.Add("ReadOnly", "false");
			_columnPhone.ExtendedProperties.Add("Description", "Phone");
			_columnPhone.ExtendedProperties.Add("Length", "50");
			_columnPhone.ExtendedProperties.Add("Decimals", "0");
			_columnPhone.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnPhone);			
			
			_columnFax = new DataColumn("Fax", typeof(string));
			_columnFax.AllowDBNull = true;
			_columnFax.Caption = "Fax";
			_columnFax.MaxLength = 50;
			_columnFax.Unique = false;
			_columnFax.DefaultValue = Convert.DBNull;
			_columnFax.ExtendedProperties.Add("IsKey", "false");
			_columnFax.ExtendedProperties.Add("ReadOnly", "false");
			_columnFax.ExtendedProperties.Add("Description", "Fax");
			_columnFax.ExtendedProperties.Add("Length", "50");
			_columnFax.ExtendedProperties.Add("Decimals", "0");
			_columnFax.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnFax);			
			
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
			
			_columnWebSite = new DataColumn("WebSite", typeof(string));
			_columnWebSite.AllowDBNull = true;
			_columnWebSite.Caption = "Web Site";
			_columnWebSite.MaxLength = 100;
			_columnWebSite.Unique = false;
			_columnWebSite.DefaultValue = Convert.DBNull;
			_columnWebSite.ExtendedProperties.Add("IsKey", "false");
			_columnWebSite.ExtendedProperties.Add("ReadOnly", "false");
			_columnWebSite.ExtendedProperties.Add("Description", "Web Site");
			_columnWebSite.ExtendedProperties.Add("Length", "100");
			_columnWebSite.ExtendedProperties.Add("Decimals", "0");
			_columnWebSite.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnWebSite);			
			
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
			
			_columnDefault = new DataColumn("Default", typeof(bool));
			_columnDefault.AllowDBNull = true;
			_columnDefault.Caption = "Default";
			_columnDefault.Unique = false;
			_columnDefault.DefaultValue = Convert.DBNull;
			_columnDefault.ExtendedProperties.Add("IsKey", "false");
			_columnDefault.ExtendedProperties.Add("ReadOnly", "false");
			_columnDefault.ExtendedProperties.Add("Description", "Default");
			_columnDefault.ExtendedProperties.Add("Decimals", "0");
			_columnDefault.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnDefault);			
			
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
			
			this.PrimaryKey = new DataColumn[] {this.Columns["ID"]};
		}
		#endregion		
		
		#region Constructors
		public CompanyTable() : base("Company") 
		{
			this.InitClass();
		}
		public CompanyTable(string tableName) : base(tableName) 
		{
			this.InitClass();
		}
		#endregion
		
		#region Methods
		public void GetContent()
		{
			SqlCommand sqlCommand = new SqlCommand("Company_GetContent", Connection.GetConnection());
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
		public static CompanyTable GetContentTable()
		{
			CompanyTable companyTable = new CompanyTable();
			companyTable.GetContent();
			return companyTable;
		}
		public bool Insert()
		{
			SqlCommand sqlCommand = new SqlCommand("Company_Insert", Connection.GetConnection());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			bool retVal = true;
			
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID"); 
			sqlCommand.Parameters.Add("@CompanyTypeID", SqlDbType.VarChar, 10, "CompanyTypeID"); 
			sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name"); 
			sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 250, "Address"); 
			sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar, 50, "Phone"); 
			sqlCommand.Parameters.Add("@Fax", SqlDbType.VarChar, 50, "Fax"); 
			sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 100, "Email"); 
			sqlCommand.Parameters.Add("@WebSite", SqlDbType.VarChar, 100, "WebSite"); 
			sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder"); 
			sqlCommand.Parameters.Add("@Default", SqlDbType.Bit, 1, "Default"); 
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
			SqlCommand sqlCommand = new SqlCommand("Company_Update", Connection.GetConnection());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			bool retVal = true;
			
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add("@OriginalID", SqlDbType.VarChar, 10, "ID").SourceVersion = DataRowVersion.Original;
			sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10, "ID");
			sqlCommand.Parameters.Add("@CompanyTypeID", SqlDbType.VarChar, 10, "CompanyTypeID");
			sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
			sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 250, "Address");
			sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar, 50, "Phone");
			sqlCommand.Parameters.Add("@Fax", SqlDbType.VarChar, 50, "Fax");
			sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 100, "Email");
			sqlCommand.Parameters.Add("@WebSite", SqlDbType.VarChar, 100, "WebSite");
			sqlCommand.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");
			sqlCommand.Parameters.Add("@Default", SqlDbType.Bit, 1, "Default");
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
			SqlCommand sqlCommand = new SqlCommand("Company_Delete", Connection.GetConnection());
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
			
			CompanyRow row = FindByPrimaryKey(iD);
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
		public DataColumn CompanyTypeIDColumn
		{
			get
			{
				return _columnCompanyTypeID;
			}
		}			
		public DataColumn NameColumn
		{
			get
			{
				return _columnName;
			}
		}			
		public DataColumn AddressColumn
		{
			get
			{
				return _columnAddress;
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
		public DataColumn EmailColumn
		{
			get
			{
				return _columnEmail;
			}
		}			
		public DataColumn WebSiteColumn
		{
			get
			{
				return _columnWebSite;
			}
		}			
		public DataColumn SortOrderColumn
		{
			get
			{
				return _columnSortOrder;
			}
		}			
		public DataColumn DefaultColumn
		{
			get
			{
				return _columnDefault;
			}
		}			
		public DataColumn ActiveColumn
		{
			get
			{
				return _columnActive;
			}
		}			
		public CompanyRow this[int index]
		{
			get
			{
				return ((CompanyRow)(this.Rows[index]));
			}
		}
		public void AddCompanyRow(CompanyRow row)
		{
			this.Rows.Add(row);
		}
		public CompanyRow AddCompanyRow(string iD, string companyTypeID, string name, string address, string phone, string fax, string email, string webSite, int sortOrder, bool _default, bool active)
		{
			CompanyRow rowCompanyRow = ((CompanyRow)(this.NewRow()));
			rowCompanyRow["ID"] = iD;
			rowCompanyRow["CompanyTypeID"] = companyTypeID;
			rowCompanyRow["Name"] = name;
			rowCompanyRow["Address"] = address;
			rowCompanyRow["Phone"] = phone;
			rowCompanyRow["Fax"] = fax;
			rowCompanyRow["Email"] = email;
			rowCompanyRow["WebSite"] = webSite;
			rowCompanyRow["SortOrder"] = sortOrder;
			rowCompanyRow["Default"] = _default;
			rowCompanyRow["Active"] = active;
			this.Rows.Add(rowCompanyRow);
			return rowCompanyRow;
		}
		public CompanyRow FindByPrimaryKey(string iD)
		{
			return (CompanyRow)(Rows.Find(new object[] {iD}));
		}	
		public IEnumerator GetEnumerator()
		{
			return this.Rows.GetEnumerator();
		}
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new CompanyRow(builder);
		}
        public static CompanyRow GetDefaultInfo()
        {
            CompanyTable company = new CompanyTable();
            SqlCommand sqlCommand = new SqlCommand("Company_GetDefaultInfo", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                Connection.Open();
                sqlDataAdapter.Fill(company);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            if (company == null)
                return null;
            else
                return company[0];
        }
		#endregion
	}
	
	public class CompanyRow : DataRow
	{
		private CompanyTable _tableCompany;
			
		internal CompanyRow(DataRowBuilder rb): base(rb)
		{
			_tableCompany = ((CompanyTable)(this.Table));
		}
		
		#region Properties
		public string ID
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.IDColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.IDColumn] = value;
			}
		}		
		public bool IsIDNull()
		{
			return this.IsNull(_tableCompany.IDColumn);
		}		
		public void SetIDNull()
		{
			this[_tableCompany.IDColumn] = Convert.DBNull;
		}		
		public string CompanyTypeID
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.CompanyTypeIDColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value CompanyTypeID because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.CompanyTypeIDColumn] = value;
			}
		}		
		public bool IsCompanyTypeIDNull()
		{
			return this.IsNull(_tableCompany.CompanyTypeIDColumn);
		}		
		public void SetCompanyTypeIDNull()
		{
			this[_tableCompany.CompanyTypeIDColumn] = Convert.DBNull;
		}		
		public string Name
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.NameColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Name because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.NameColumn] = value;
			}
		}		
		public bool IsNameNull()
		{
			return this.IsNull(_tableCompany.NameColumn);
		}		
		public void SetNameNull()
		{
			this[_tableCompany.NameColumn] = Convert.DBNull;
		}		
		public string Address
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.AddressColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Address because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.AddressColumn] = value;
			}
		}		
		public bool IsAddressNull()
		{
			return this.IsNull(_tableCompany.AddressColumn);
		}		
		public void SetAddressNull()
		{
			this[_tableCompany.AddressColumn] = Convert.DBNull;
		}		
		public string Phone
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.PhoneColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Phone because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.PhoneColumn] = value;
			}
		}		
		public bool IsPhoneNull()
		{
			return this.IsNull(_tableCompany.PhoneColumn);
		}		
		public void SetPhoneNull()
		{
			this[_tableCompany.PhoneColumn] = Convert.DBNull;
		}		
		public string Fax
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.FaxColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Fax because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.FaxColumn] = value;
			}
		}		
		public bool IsFaxNull()
		{
			return this.IsNull(_tableCompany.FaxColumn);
		}		
		public void SetFaxNull()
		{
			this[_tableCompany.FaxColumn] = Convert.DBNull;
		}		
		public string Email
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.EmailColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Email because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.EmailColumn] = value;
			}
		}		
		public bool IsEmailNull()
		{
			return this.IsNull(_tableCompany.EmailColumn);
		}		
		public void SetEmailNull()
		{
			this[_tableCompany.EmailColumn] = Convert.DBNull;
		}		
		public string WebSite
		{
			get
			{
				try
				{
					return ((string)(this[_tableCompany.WebSiteColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value WebSite because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.WebSiteColumn] = value;
			}
		}		
		public bool IsWebSiteNull()
		{
			return this.IsNull(_tableCompany.WebSiteColumn);
		}		
		public void SetWebSiteNull()
		{
			this[_tableCompany.WebSiteColumn] = Convert.DBNull;
		}		
		public int SortOrder
		{
			get
			{
				try
				{
					return ((int)(this[_tableCompany.SortOrderColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value SortOrder because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.SortOrderColumn] = value;
			}
		}		
		public bool IsSortOrderNull()
		{
			return this.IsNull(_tableCompany.SortOrderColumn);
		}		
		public void SetSortOrderNull()
		{
			this[_tableCompany.SortOrderColumn] = Convert.DBNull;
		}		
		public bool Default
		{
			get
			{
				try
				{
					return ((bool)(this[_tableCompany.DefaultColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Default because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.DefaultColumn] = value;
			}
		}		
		public bool IsDefaultNull()
		{
			return this.IsNull(_tableCompany.DefaultColumn);
		}		
		public void SetDefaultNull()
		{
			this[_tableCompany.DefaultColumn] = Convert.DBNull;
		}		
		public bool Active
		{
			get
			{
				try
				{
					return ((bool)(this[_tableCompany.ActiveColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Active because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableCompany.ActiveColumn] = value;
			}
		}		
		public bool IsActiveNull()
		{
			return this.IsNull(_tableCompany.ActiveColumn);
		}		
		public void SetActiveNull()
		{
			this[_tableCompany.ActiveColumn] = Convert.DBNull;
		}		
		#endregion
	}
}
