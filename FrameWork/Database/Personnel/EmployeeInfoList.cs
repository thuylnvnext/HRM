using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class EmployeeInfoListTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnFieldName;
        private DataColumn _columnCaption;
        private DataColumn _columnDataType;
        private DataColumn _columnVisibleIndex;
        private DataColumn _columnAlignment;

        private void InitClass()
        {
            _columnFieldName = new DataColumn("FieldName", typeof(string));
            _columnFieldName.AllowDBNull = false;
            _columnFieldName.Caption = "Field Name";
            _columnFieldName.MaxLength = 50;
            _columnFieldName.Unique = true;
            _columnFieldName.DefaultValue = Convert.DBNull;
            _columnFieldName.ExtendedProperties.Add("IsKey", "true");
            _columnFieldName.ExtendedProperties.Add("ReadOnly", "false");
            _columnFieldName.ExtendedProperties.Add("Description", "Field Name");
            _columnFieldName.ExtendedProperties.Add("Length", "20");
            _columnFieldName.ExtendedProperties.Add("Decimals", "0");
            _columnFieldName.ExtendedProperties.Add("AllowDBNulls", "false");
            this.Columns.Add(_columnFieldName);

            _columnCaption = new DataColumn("Caption", typeof(string));
            _columnCaption.AllowDBNull = true;
            _columnCaption.Caption = "Caption";
            _columnCaption.MaxLength = 50;
            _columnCaption.Unique = false;
            _columnCaption.DefaultValue = Convert.DBNull;
            _columnCaption.ExtendedProperties.Add("IsKey", "false");
            _columnCaption.ExtendedProperties.Add("ReadOnly", "false");
            _columnCaption.ExtendedProperties.Add("Description", "Caption");
            _columnCaption.ExtendedProperties.Add("Length", "20");
            _columnCaption.ExtendedProperties.Add("Decimals", "0");
            _columnCaption.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnCaption);

            _columnDataType = new DataColumn("DataType", typeof(string));
            _columnDataType.AllowDBNull = true;
            _columnDataType.Caption = "Data Type";
            _columnDataType.MaxLength = 20;
            _columnDataType.Unique = false;
            _columnDataType.DefaultValue = Convert.DBNull;
            _columnDataType.ExtendedProperties.Add("IsKey", "false");
            _columnDataType.ExtendedProperties.Add("ReadOnly", "false");
            _columnDataType.ExtendedProperties.Add("Description", "Data Type");
            _columnDataType.ExtendedProperties.Add("Length", "20");
            _columnDataType.ExtendedProperties.Add("Decimals", "0");
            _columnDataType.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnDataType);

            _columnVisibleIndex = new DataColumn("VisibleIndex", typeof(short));
            _columnVisibleIndex.AllowDBNull = true;
            _columnVisibleIndex.Caption = "Visible Index";
            _columnVisibleIndex.Unique = false;
            _columnVisibleIndex.DefaultValue = Convert.DBNull;
            _columnVisibleIndex.ExtendedProperties.Add("IsKey", "false");
            _columnVisibleIndex.ExtendedProperties.Add("ReadOnly", "false");
            _columnVisibleIndex.ExtendedProperties.Add("Description", "Visible Index");
            _columnVisibleIndex.ExtendedProperties.Add("Decimals", "0");
            _columnVisibleIndex.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnVisibleIndex);

            _columnAlignment = new DataColumn("Alignment", typeof(byte));
            _columnAlignment.AllowDBNull = true;
            _columnAlignment.Caption = "Alignment";
            _columnAlignment.Unique = false;
            _columnAlignment.DefaultValue = Convert.DBNull;
            _columnAlignment.ExtendedProperties.Add("IsKey", "false");
            _columnAlignment.ExtendedProperties.Add("ReadOnly", "false");
            _columnAlignment.ExtendedProperties.Add("Description", "Alignment");
            _columnAlignment.ExtendedProperties.Add("Decimals", "0");
            _columnAlignment.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnAlignment);

            this.PrimaryKey = new DataColumn[] { this.Columns["FieldName"] };
        }
        #endregion

        #region Constructors
        public EmployeeInfoListTable()
            : base("EmployeeInfoList")
        {
            this.InitClass();
        }
        public EmployeeInfoListTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeInfoList_GetContent", Connection.GetConnection());
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
        public static EmployeeInfoListTable GetContentTable()
        {
            EmployeeInfoListTable employeeInfoListTable = new EmployeeInfoListTable();
            employeeInfoListTable.GetContent();
            return employeeInfoListTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeInfoList_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@FieldName", SqlDbType.VarChar, 50, "FieldName");
            sqlCommand.Parameters.Add("@Caption", SqlDbType.NVarChar, 50, "Caption");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@VisibleIndex", SqlDbType.SmallInt, 2, "VisibleIndex");
            sqlCommand.Parameters.Add("@Alignment", SqlDbType.TinyInt, 1, "Alignment");

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
            SqlCommand sqlCommand = new SqlCommand("EmployeeInfoList_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalFieldName", SqlDbType.VarChar, 50, "FieldName").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@FieldName", SqlDbType.VarChar, 50, "FieldName");
            sqlCommand.Parameters.Add("@Caption", SqlDbType.NVarChar, 50, "Caption");
            sqlCommand.Parameters.Add("@DataType", SqlDbType.NVarChar, 20, "DataType");
            sqlCommand.Parameters.Add("@VisibleIndex", SqlDbType.SmallInt, 2, "VisibleIndex");
            sqlCommand.Parameters.Add("@Alignment", SqlDbType.TinyInt, 1, "Alignment");

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
            SqlCommand sqlCommand = new SqlCommand("EmployeeInfoList_Delete", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@FieldName", SqlDbType.VarChar, 50, "FieldName");

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
        public bool Delete(string fieldName)
        {
            bool retVal;

            EmployeeInfoListRow row = FindByPrimaryKey(fieldName);
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
        public DataColumn FieldNameColumn
        {
            get
            {
                return _columnFieldName;
            }
        }
        public DataColumn CaptionColumn
        {
            get
            {
                return _columnCaption;
            }
        }
        public DataColumn DataTypeColumn
        {
            get
            {
                return _columnDataType;
            }
        }
        public DataColumn VisibleIndexColumn
        {
            get
            {
                return _columnVisibleIndex;
            }
        }
        public DataColumn AlignmentColumn
        {
            get
            {
                return _columnAlignment;
            }
        }
        public EmployeeInfoListRow this[int index]
        {
            get
            {
                return ((EmployeeInfoListRow)(this.Rows[index]));
            }
        }
        public void AddEmployeeInfoListRow(EmployeeInfoListRow row)
        {
            this.Rows.Add(row);
        }
        public EmployeeInfoListRow AddEmployeeInfoListRow(string fieldName, string caption, string dataType, short visibleIndex, byte alignment)
        {
            EmployeeInfoListRow rowEmployeeInfoListRow = ((EmployeeInfoListRow)(this.NewRow()));
            rowEmployeeInfoListRow["FieldName"] = fieldName;
            rowEmployeeInfoListRow["Caption"] = caption;
            rowEmployeeInfoListRow["DataType"] = dataType;
            rowEmployeeInfoListRow["VisibleIndex"] = visibleIndex;
            rowEmployeeInfoListRow["Alignment"] = alignment;
            this.Rows.Add(rowEmployeeInfoListRow);
            return rowEmployeeInfoListRow;
        }
        public EmployeeInfoListRow FindByPrimaryKey(string fieldName)
        {
            return (EmployeeInfoListRow)(Rows.Find(new object[] { fieldName }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new EmployeeInfoListRow(builder);
        }
        #endregion
    }

    public class EmployeeInfoListRow : DataRow
    {
        private EmployeeInfoListTable _tableEmployeeInfoList;

        internal EmployeeInfoListRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableEmployeeInfoList = ((EmployeeInfoListTable)(this.Table));
        }

        #region Properties
        public string FieldName
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployeeInfoList.FieldNameColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value FieldName because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeInfoList.FieldNameColumn] = value;
            }
        }
        public bool IsFieldNameNull()
        {
            return this.IsNull(_tableEmployeeInfoList.FieldNameColumn);
        }
        public void SetFieldNameNull()
        {
            this[_tableEmployeeInfoList.FieldNameColumn] = Convert.DBNull;
        }
        public string Caption
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployeeInfoList.CaptionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Caption because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeInfoList.CaptionColumn] = value;
            }
        }
        public bool IsCaptionNull()
        {
            return this.IsNull(_tableEmployeeInfoList.CaptionColumn);
        }
        public void SetCaptionNull()
        {
            this[_tableEmployeeInfoList.CaptionColumn] = Convert.DBNull;
        }
        public string DataType
        {
            get
            {
                try
                {
                    return ((string)(this[_tableEmployeeInfoList.DataTypeColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value DataType because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeInfoList.DataTypeColumn] = value;
            }
        }
        public bool IsDataTypeNull()
        {
            return this.IsNull(_tableEmployeeInfoList.DataTypeColumn);
        }
        public void SetDataTypeNull()
        {
            this[_tableEmployeeInfoList.DataTypeColumn] = Convert.DBNull;
        }
        public short VisibleIndex
        {
            get
            {
                try
                {
                    return ((short)(this[_tableEmployeeInfoList.VisibleIndexColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value VisibleIndex because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeInfoList.VisibleIndexColumn] = value;
            }
        }
        public bool IsVisibleIndexNull()
        {
            return this.IsNull(_tableEmployeeInfoList.VisibleIndexColumn);
        }
        public void SetVisibleIndexNull()
        {
            this[_tableEmployeeInfoList.VisibleIndexColumn] = Convert.DBNull;
        }
        public byte Alignment
        {
            get
            {
                try
                {
                    return ((byte)(this[_tableEmployeeInfoList.AlignmentColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Alignment because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableEmployeeInfoList.AlignmentColumn] = value;
            }
        }
        public bool IsAlignmentNull()
        {
            return this.IsNull(_tableEmployeeInfoList.AlignmentColumn);
        }
        public void SetAlignmentNull()
        {
            this[_tableEmployeeInfoList.AlignmentColumn] = Convert.DBNull;
        }
        #endregion
    }
}
