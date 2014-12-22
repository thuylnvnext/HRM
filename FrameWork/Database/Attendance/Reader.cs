using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
	public class ReaderTable : DataTable, IEnumerable
	{
		#region Private
		private DataColumn _columnID;
		private DataColumn _columnReaderTypeID;
		private DataColumn _columnIPAddress;
		private DataColumn _columnCommPort;
        private DataColumn _columnCommPassword;	
		private DataColumn _columnPollingTime;
		private DataColumn _columnCompress;
		private DataColumn _columnLastRecord;
		private DataColumn _columnDescription;
        private DataColumn _columnIn;
        private DataColumn _columnUsed;
		
		private void InitClass()
		{
			_columnID = new DataColumn("ID", typeof(byte));
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
			
			_columnReaderTypeID = new DataColumn("ReaderTypeID", typeof(string));
			_columnReaderTypeID.AllowDBNull = true;
			_columnReaderTypeID.Caption = "Reader Type ID";
			_columnReaderTypeID.MaxLength = 10;
			_columnReaderTypeID.Unique = false;
			_columnReaderTypeID.DefaultValue = Convert.DBNull;
			_columnReaderTypeID.ExtendedProperties.Add("IsKey", "false");
			_columnReaderTypeID.ExtendedProperties.Add("ReadOnly", "false");
			_columnReaderTypeID.ExtendedProperties.Add("Description", "Reader Type ID");
			_columnReaderTypeID.ExtendedProperties.Add("Length", "10");
			_columnReaderTypeID.ExtendedProperties.Add("Decimals", "0");
			_columnReaderTypeID.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnReaderTypeID);			
			
			_columnIPAddress = new DataColumn("IPAddress", typeof(string));
			_columnIPAddress.AllowDBNull = true;
			_columnIPAddress.Caption = "I P Address";
			_columnIPAddress.MaxLength = 20;
			_columnIPAddress.Unique = false;
			_columnIPAddress.DefaultValue = Convert.DBNull;
			_columnIPAddress.ExtendedProperties.Add("IsKey", "false");
			_columnIPAddress.ExtendedProperties.Add("ReadOnly", "false");
			_columnIPAddress.ExtendedProperties.Add("Description", "I P Address");
			_columnIPAddress.ExtendedProperties.Add("Length", "20");
			_columnIPAddress.ExtendedProperties.Add("Decimals", "0");
			_columnIPAddress.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnIPAddress);			
			
			_columnCommPort = new DataColumn("CommPort", typeof(string));
			_columnCommPort.AllowDBNull = true;
			_columnCommPort.Caption = "Comm Port";
			_columnCommPort.MaxLength = 5;
			_columnCommPort.Unique = false;
			_columnCommPort.DefaultValue = Convert.DBNull;
			_columnCommPort.ExtendedProperties.Add("IsKey", "false");
			_columnCommPort.ExtendedProperties.Add("ReadOnly", "false");
			_columnCommPort.ExtendedProperties.Add("Description", "Comm Port");
			_columnCommPort.ExtendedProperties.Add("Length", "5");
			_columnCommPort.ExtendedProperties.Add("Decimals", "0");
			_columnCommPort.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnCommPort);

            _columnCommPassword = new DataColumn("CommPassword", typeof(int));
            _columnCommPassword.AllowDBNull = true;
            _columnCommPassword.Caption = "Comm Password";
            _columnCommPassword.Unique = false;
            _columnCommPassword.DefaultValue = Convert.DBNull;
            _columnCommPassword.ExtendedProperties.Add("IsKey", "false");
            _columnCommPassword.ExtendedProperties.Add("ReadOnly", "false");
            _columnCommPassword.ExtendedProperties.Add("Description", "Comm Password");
            _columnCommPassword.ExtendedProperties.Add("Decimals", "0");
            _columnCommPassword.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCommPassword);

			_columnPollingTime = new DataColumn("PollingTime", typeof(int));
			_columnPollingTime.AllowDBNull = true;
			_columnPollingTime.Caption = "Polling Time";
			_columnPollingTime.Unique = false;
			_columnPollingTime.DefaultValue = Convert.DBNull;
			_columnPollingTime.ExtendedProperties.Add("IsKey", "false");
			_columnPollingTime.ExtendedProperties.Add("ReadOnly", "false");
			_columnPollingTime.ExtendedProperties.Add("Description", "Polling Time");
			_columnPollingTime.ExtendedProperties.Add("Decimals", "0");
			_columnPollingTime.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnPollingTime);			
			
			_columnCompress = new DataColumn("Compress", typeof(bool));
			_columnCompress.AllowDBNull = true;
			_columnCompress.Caption = "Compress";
			_columnCompress.Unique = false;
			_columnCompress.DefaultValue = Convert.DBNull;
			_columnCompress.ExtendedProperties.Add("IsKey", "false");
			_columnCompress.ExtendedProperties.Add("ReadOnly", "false");
			_columnCompress.ExtendedProperties.Add("Description", "Compress");
			_columnCompress.ExtendedProperties.Add("Decimals", "0");
			_columnCompress.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnCompress);			
			
			_columnLastRecord = new DataColumn("LastRecord", typeof(DateTime));
			_columnLastRecord.AllowDBNull = true;
			_columnLastRecord.Caption = "Last Record";
			_columnLastRecord.Unique = false;
			_columnLastRecord.DefaultValue = Convert.DBNull;
			_columnLastRecord.ExtendedProperties.Add("IsKey", "false");
			_columnLastRecord.ExtendedProperties.Add("ReadOnly", "false");
			_columnLastRecord.ExtendedProperties.Add("Description", "Last Record");
			_columnLastRecord.ExtendedProperties.Add("Decimals", "0");
			_columnLastRecord.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnLastRecord);			
			
			_columnDescription = new DataColumn("Description", typeof(string));
			_columnDescription.AllowDBNull = true;
			_columnDescription.Caption = "Description";
			_columnDescription.MaxLength = 250;
			_columnDescription.Unique = false;
			_columnDescription.DefaultValue = Convert.DBNull;
			_columnDescription.ExtendedProperties.Add("IsKey", "false");
			_columnDescription.ExtendedProperties.Add("ReadOnly", "false");
			_columnDescription.ExtendedProperties.Add("Description", "Description");
			_columnDescription.ExtendedProperties.Add("Length", "250");
			_columnDescription.ExtendedProperties.Add("Decimals", "0");
			_columnDescription.ExtendedProperties.Add("AllowDBNulls", "true");
			this.Columns.Add(_columnDescription);

            _columnIn = new DataColumn("In", typeof(bool));
            _columnIn.AllowDBNull = true;
            _columnIn.Caption = "In";
            _columnIn.Unique = false;
            _columnIn.DefaultValue = Convert.DBNull;
            _columnIn.ExtendedProperties.Add("IsKey", "false");
            _columnIn.ExtendedProperties.Add("ReadOnly", "false");
            _columnIn.ExtendedProperties.Add("Description", "In");
            _columnIn.ExtendedProperties.Add("Decimals", "0");
            _columnIn.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnIn);

            _columnUsed = new DataColumn("Used", typeof(bool));
            _columnUsed.AllowDBNull = true;
            _columnUsed.Caption = "Used";
            _columnUsed.Unique = false;
            _columnUsed.DefaultValue = Convert.DBNull;
            _columnUsed.ExtendedProperties.Add("IsKey", "false");
            _columnUsed.ExtendedProperties.Add("ReadOnly", "false");
            _columnUsed.ExtendedProperties.Add("Description", "Used");
            _columnUsed.ExtendedProperties.Add("Decimals", "0");
            _columnUsed.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnUsed);

			this.PrimaryKey = new DataColumn[] {this.Columns["ID"]};
		}
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            e.Status = UpdateStatus.Continue;
        }
		#endregion		
		
		#region Constructors
		public ReaderTable() : base("Reader") 
		{
			this.InitClass();
		}
		public ReaderTable(string tableName) : base(tableName) 
		{
			this.InitClass();
		}
		#endregion
		
		#region Methods
		public void GetContent()
		{
			SqlCommand sqlCommand = new SqlCommand("Reader_GetContent", Connection.GetConnection());
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
		public static ReaderTable GetContentTable()
		{
			ReaderTable readerTable = new ReaderTable();
			readerTable.GetContent();
			return readerTable;
		}
		public bool Insert()
		{
			SqlCommand sqlCommand = new SqlCommand("Reader_Insert", Connection.GetConnection());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			bool retVal = true;

            sqlDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
			sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.TinyInt, 1, "ID");
			sqlCommand.Parameters.Add("@ReaderTypeID", SqlDbType.VarChar, 10, "ReaderTypeID"); 
			sqlCommand.Parameters.Add("@IPAddress", SqlDbType.VarChar, 20, "IPAddress"); 
			sqlCommand.Parameters.Add("@CommPort", SqlDbType.VarChar, 5, "CommPort");
            sqlCommand.Parameters.Add("@CommPassword", SqlDbType.Int, 4, "CommPassword"); 
			sqlCommand.Parameters.Add("@PollingTime", SqlDbType.Int, 4, "PollingTime"); 
			sqlCommand.Parameters.Add("@Compress", SqlDbType.Bit, 1, "Compress"); 
			sqlCommand.Parameters.Add("@LastRecord", SqlDbType.DateTime, 8, "LastRecord"); 
			sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 250, "Description");
            sqlCommand.Parameters.Add("@In", SqlDbType.Bit, 1, "In");
            sqlCommand.Parameters.Add("@Used", SqlDbType.Bit, 1, "Used"); 
			
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
			SqlCommand sqlCommand = new SqlCommand("Reader_Update", Connection.GetConnection());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			bool retVal = true;
			
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add("@ID", SqlDbType.TinyInt, 1, "ID");
			sqlCommand.Parameters.Add("@ReaderTypeID", SqlDbType.VarChar, 10, "ReaderTypeID");
			sqlCommand.Parameters.Add("@IPAddress", SqlDbType.VarChar, 20, "IPAddress");
			sqlCommand.Parameters.Add("@CommPort", SqlDbType.VarChar, 5, "CommPort");
            sqlCommand.Parameters.Add("@CommPassword", SqlDbType.Int, 4, "CommPassword");
			sqlCommand.Parameters.Add("@PollingTime", SqlDbType.Int, 4, "PollingTime");
			sqlCommand.Parameters.Add("@Compress", SqlDbType.Bit, 1, "Compress");
			sqlCommand.Parameters.Add("@LastRecord", SqlDbType.DateTime, 8, "LastRecord");
			sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 250, "Description");
            sqlCommand.Parameters.Add("@In", SqlDbType.Bit, 1, "In");
            sqlCommand.Parameters.Add("@Used", SqlDbType.Bit, 1, "Used"); 
			
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
			SqlCommand sqlCommand = new SqlCommand("Reader_Delete", Connection.GetConnection());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			bool retVal = true;
			
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add("@ID", SqlDbType.TinyInt, 1, "ID");
			
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
		public bool Delete(byte iD)
		{
			bool retVal;
			
			ReaderRow row = FindByPrimaryKey(iD);
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
		public DataColumn ReaderTypeIDColumn
		{
			get
			{
				return _columnReaderTypeID;
			}
		}			
		public DataColumn IPAddressColumn
		{
			get
			{
				return _columnIPAddress;
			}
		}			
		public DataColumn CommPortColumn
		{
			get
			{
				return _columnCommPort;
			}
		}			
		public DataColumn CommPassword
		{
			get
			{
				return _columnCommPassword;
			}
		}			
		public DataColumn PollingTimeColumn
		{
			get
			{
				return _columnPollingTime;
			}
		}			
		public DataColumn CompressColumn
		{
			get
			{
				return _columnCompress;
			}
		}			
		public DataColumn LastRecordColumn
		{
			get
			{
				return _columnLastRecord;
			}
		}			
		public DataColumn DescriptionColumn
		{
			get
			{
				return _columnDescription;
			}
		}
        public DataColumn InColumn
        {
            get
            {
                return _columnIn;
            }
        }
        public DataColumn UsedColumn
        {
            get
            {
                return _columnUsed;
            }
        }
		public ReaderRow this[int index]
		{
			get
			{
				return ((ReaderRow)(this.Rows[index]));
			}
		}
		public void AddReaderRow(ReaderRow row)
		{
			this.Rows.Add(row);
		}
		public ReaderRow AddReaderRow(byte iD, string readerTypeID, string iPAddress, string commPort, int _commPassword, int pollingTime, bool compress, DateTime lastRecord, string description, bool _in, bool used)
		{
			ReaderRow rowReaderRow = ((ReaderRow)(this.NewRow()));
			rowReaderRow["ID"] = iD;
			rowReaderRow["ReaderTypeID"] = readerTypeID;
			rowReaderRow["IPAddress"] = iPAddress;
			rowReaderRow["CommPort"] = commPort;
			rowReaderRow["CommPassword"] = _commPassword;
			rowReaderRow["PollingTime"] = pollingTime;
			rowReaderRow["Compress"] = compress;
			rowReaderRow["LastRecord"] = lastRecord;
			rowReaderRow["Description"] = description;
            rowReaderRow["In"] = _in;
            rowReaderRow["Used"] = used;
			this.Rows.Add(rowReaderRow);
			return rowReaderRow;
		}
		public ReaderRow FindByPrimaryKey(byte iD)
		{
			return (ReaderRow)(Rows.Find(new object[] {iD}));
		}	
		public IEnumerator GetEnumerator()
		{
			return this.Rows.GetEnumerator();
		}
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ReaderRow(builder);
		}
        public void GetContent(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("Reader_GetContent", conn, tran);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                sqlDataAdapter.Fill(this);
            }
            catch
            {
            }
            finally
            {
            }
        }
        public static byte GetNewID()
        {
            byte retVal = 0;
            SqlCommand sqlCommand = new SqlCommand("Reader_GetNewID", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                Connection.Open();
                retVal = (byte)sqlCommand.ExecuteScalar();
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
	
	public class ReaderRow : DataRow
	{
		private ReaderTable _tableReader;
			
		internal ReaderRow(DataRowBuilder rb): base(rb)
		{
			_tableReader = ((ReaderTable)(this.Table));
		}
		
		#region Properties
		public byte ID
		{
			get
			{
				try
				{
					return ((byte)(this[_tableReader.IDColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value ID because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.IDColumn] = value;
			}
		}		
		public bool IsIDNull()
		{
			return this.IsNull(_tableReader.IDColumn);
		}		
		public void SetIDNull()
		{
			this[_tableReader.IDColumn] = Convert.DBNull;
		}		
		public string ReaderTypeID
		{
			get
			{
				try
				{
					return ((string)(this[_tableReader.ReaderTypeIDColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value ReaderTypeID because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.ReaderTypeIDColumn] = value;
			}
		}		
		public bool IsReaderTypeIDNull()
		{
			return this.IsNull(_tableReader.ReaderTypeIDColumn);
		}		
		public void SetReaderTypeIDNull()
		{
			this[_tableReader.ReaderTypeIDColumn] = Convert.DBNull;
		}		
		public string IPAddress
		{
			get
			{
				try
				{
					return ((string)(this[_tableReader.IPAddressColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value IPAddress because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.IPAddressColumn] = value;
			}
		}		
		public bool IsIPAddressNull()
		{
			return this.IsNull(_tableReader.IPAddressColumn);
		}		
		public void SetIPAddressNull()
		{
			this[_tableReader.IPAddressColumn] = Convert.DBNull;
		}		
		public string CommPort
		{
			get
			{
				try
				{
					return ((string)(this[_tableReader.CommPortColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value CommPort because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.CommPortColumn] = value;
			}
		}		
		public bool IsCommPortNull()
		{
			return this.IsNull(_tableReader.CommPortColumn);
		}		
		public void SetCommPortNull()
		{
			this[_tableReader.CommPortColumn] = Convert.DBNull;
		}		
		public int CommPassword
		{
			get
			{
				try
				{
					return ((int)(this[_tableReader.CommPassword]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Comm Password because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.CommPassword] = value;
			}
		}		
		public bool IsCommPasswordNull()
		{
			return this.IsNull(_tableReader.CommPassword);
		}		
		public void SetCommPasswordNull()
		{
			this[_tableReader.CommPassword] = Convert.DBNull;
		}		
		public int PollingTime
		{
			get
			{
				try
				{
					return ((int)(this[_tableReader.PollingTimeColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value PollingTime because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.PollingTimeColumn] = value;
			}
		}		
		public bool IsPollingTimeNull()
		{
			return this.IsNull(_tableReader.PollingTimeColumn);
		}		
		public void SetPollingTimeNull()
		{
			this[_tableReader.PollingTimeColumn] = Convert.DBNull;
		}		
		public bool Compress
		{
			get
			{
				try
				{
					return ((bool)(this[_tableReader.CompressColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Compress because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.CompressColumn] = value;
			}
		}		
		public bool IsCompressNull()
		{
			return this.IsNull(_tableReader.CompressColumn);
		}		
		public void SetCompressNull()
		{
			this[_tableReader.CompressColumn] = Convert.DBNull;
		}		
		public DateTime LastRecord
		{
			get
			{
				try
				{
					return ((DateTime)(this[_tableReader.LastRecordColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value LastRecord because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.LastRecordColumn] = value;
			}
		}		
		public bool IsLastRecordNull()
		{
			return this.IsNull(_tableReader.LastRecordColumn);
		}		
		public void SetLastRecordNull()
		{
			this[_tableReader.LastRecordColumn] = Convert.DBNull;
		}		
		public string Description
		{
			get
			{
				try
				{
					return ((string)(this[_tableReader.DescriptionColumn]));
				}
				catch (InvalidCastException exception)
				{
					throw new StrongTypingException("Cannot get value Description because it is DBNull", exception);
				}
			}
			set
			{
				this[_tableReader.DescriptionColumn] = value;
			}
		}		
		public bool IsDescriptionNull()
		{
			return this.IsNull(_tableReader.DescriptionColumn);
		}		
		public void SetDescriptionNull()
		{
			this[_tableReader.DescriptionColumn] = Convert.DBNull;
		}
        public bool In
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableReader.InColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value In because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableReader.InColumn] = value;
            }
        }
        public bool IsInNull()
        {
            return this.IsNull(_tableReader.InColumn);
        }
        public void SetInNull()
        {
            this[_tableReader.InColumn] = Convert.DBNull;
        }
        public bool Used
        {
            get
            {
                try
                {
                    return ((bool)(this[_tableReader.UsedColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Used because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableReader.UsedColumn] = value;
            }
        }
        public bool IsUsedNull()
        {
            return this.IsNull(_tableReader.UsedColumn);
        }
        public void SetUsedNull()
        {
            this[_tableReader.UsedColumn] = Convert.DBNull;
        }
		#endregion
	}
}
