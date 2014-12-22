using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Database
{
    public class HealthStatusTable : DataTable, IEnumerable
    {
        #region Private
        private DataColumn _columnEmployeeID;
        private DataColumn _columnHeight;
        private DataColumn _columnWeight;
        private DataColumn _columnLeftVision;
        private DataColumn _columnRightVision;
        private DataColumn _columnBloodGroup;

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

            _columnHeight = new DataColumn("Height", typeof(int));
            _columnHeight.AllowDBNull = true;
            _columnHeight.Caption = "Height";
            _columnHeight.Unique = false;
            _columnHeight.DefaultValue = Convert.DBNull;
            _columnHeight.ExtendedProperties.Add("IsKey", "false");
            _columnHeight.ExtendedProperties.Add("ReadOnly", "false");
            _columnHeight.ExtendedProperties.Add("Description", "Height");
            _columnHeight.ExtendedProperties.Add("Decimals", "0");
            _columnHeight.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnHeight);

            _columnWeight = new DataColumn("Weight", typeof(int));
            _columnWeight.AllowDBNull = true;
            _columnWeight.Caption = "Weight";
            _columnWeight.Unique = false;
            _columnWeight.DefaultValue = Convert.DBNull;
            _columnWeight.ExtendedProperties.Add("IsKey", "false");
            _columnWeight.ExtendedProperties.Add("ReadOnly", "false");
            _columnWeight.ExtendedProperties.Add("Description", "Weight");
            _columnWeight.ExtendedProperties.Add("Decimals", "0");
            _columnWeight.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnWeight);

            _columnLeftVision = new DataColumn("LeftVision", typeof(string));
            _columnLeftVision.AllowDBNull = true;
            _columnLeftVision.Caption = "Left Vision";
            _columnLeftVision.MaxLength = 5;
            _columnLeftVision.Unique = false;
            _columnLeftVision.DefaultValue = Convert.DBNull;
            _columnLeftVision.ExtendedProperties.Add("IsKey", "false");
            _columnLeftVision.ExtendedProperties.Add("ReadOnly", "false");
            _columnLeftVision.ExtendedProperties.Add("Description", "Left Vision");
            _columnLeftVision.ExtendedProperties.Add("Length", "5");
            _columnLeftVision.ExtendedProperties.Add("Decimals", "0");
            _columnLeftVision.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnLeftVision);

            _columnRightVision = new DataColumn("RightVision", typeof(string));
            _columnRightVision.AllowDBNull = true;
            _columnRightVision.Caption = "Right Vision";
            _columnRightVision.MaxLength = 5;
            _columnRightVision.Unique = false;
            _columnRightVision.DefaultValue = Convert.DBNull;
            _columnRightVision.ExtendedProperties.Add("IsKey", "false");
            _columnRightVision.ExtendedProperties.Add("ReadOnly", "false");
            _columnRightVision.ExtendedProperties.Add("Description", "Right Vision");
            _columnRightVision.ExtendedProperties.Add("Length", "5");
            _columnRightVision.ExtendedProperties.Add("Decimals", "0");
            _columnRightVision.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnRightVision);

            _columnBloodGroup = new DataColumn("BloodGroup", typeof(string));
            _columnBloodGroup.AllowDBNull = true;
            _columnBloodGroup.Caption = "Blood Group";
            _columnBloodGroup.MaxLength = 2;
            _columnBloodGroup.Unique = false;
            _columnBloodGroup.DefaultValue = Convert.DBNull;
            _columnBloodGroup.ExtendedProperties.Add("IsKey", "false");
            _columnBloodGroup.ExtendedProperties.Add("ReadOnly", "false");
            _columnBloodGroup.ExtendedProperties.Add("Description", "Blood Group");
            _columnBloodGroup.ExtendedProperties.Add("Length", "2");
            _columnBloodGroup.ExtendedProperties.Add("Decimals", "0");
            _columnBloodGroup.ExtendedProperties.Add("AllowDBNulls", "true");
            this.Columns.Add(_columnBloodGroup);

            this.PrimaryKey = new DataColumn[] { this.Columns["EmployeeID"] };
        }
        #endregion

        #region Constructors
        public HealthStatusTable()
            : base("HealthStatus")
        {
            this.InitClass();
        }
        public HealthStatusTable(string tableName)
            : base(tableName)
        {
            this.InitClass();
        }
        #endregion

        #region Methods
        public void GetContent()
        {
            SqlCommand sqlCommand = new SqlCommand("HealthStatus_GetContent", Connection.GetConnection());
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
        public static HealthStatusTable GetContentTable()
        {
            HealthStatusTable healthStatusTable = new HealthStatusTable();
            healthStatusTable.GetContent();
            return healthStatusTable;
        }
        public bool Insert()
        {
            SqlCommand sqlCommand = new SqlCommand("HealthStatus_Insert", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Height", SqlDbType.Int, 4, "Height");
            sqlCommand.Parameters.Add("@Weight", SqlDbType.Int, 4, "Weight");
            sqlCommand.Parameters.Add("@LeftVision", SqlDbType.VarChar, 5, "LeftVision");
            sqlCommand.Parameters.Add("@RightVision", SqlDbType.VarChar, 5, "RightVision");
            sqlCommand.Parameters.Add("@BloodGroup", SqlDbType.VarChar, 2, "BloodGroup");

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
            SqlCommand sqlCommand = new SqlCommand("HealthStatus_Update", Connection.GetConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@OriginalEmployeeID", SqlDbType.Int, 4, "EmployeeID").SourceVersion = DataRowVersion.Original;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Height", SqlDbType.Int, 4, "Height");
            sqlCommand.Parameters.Add("@Weight", SqlDbType.Int, 4, "Weight");
            sqlCommand.Parameters.Add("@LeftVision", SqlDbType.VarChar, 5, "LeftVision");
            sqlCommand.Parameters.Add("@RightVision", SqlDbType.VarChar, 5, "RightVision");
            sqlCommand.Parameters.Add("@BloodGroup", SqlDbType.VarChar, 2, "BloodGroup");

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
            SqlCommand sqlCommand = new SqlCommand("HealthStatus_Delete", Connection.GetConnection());
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

            HealthStatusRow row = FindByPrimaryKey(employeeID);
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
        public DataColumn HeightColumn
        {
            get
            {
                return _columnHeight;
            }
        }
        public DataColumn WeightColumn
        {
            get
            {
                return _columnWeight;
            }
        }
        public DataColumn LeftVisionColumn
        {
            get
            {
                return _columnLeftVision;
            }
        }
        public DataColumn RightVisionColumn
        {
            get
            {
                return _columnRightVision;
            }
        }
        public DataColumn BloodGroupColumn
        {
            get
            {
                return _columnBloodGroup;
            }
        }
        public HealthStatusRow this[int index]
        {
            get
            {
                return ((HealthStatusRow)(this.Rows[index]));
            }
        }
        public void AddHealthStatusRow(HealthStatusRow row)
        {
            this.Rows.Add(row);
        }
        public HealthStatusRow AddHealthStatusRow(int employeeID, int height, int weight, string leftVision, string rightVision, string bloodGroup)
        {
            HealthStatusRow rowHealthStatusRow = ((HealthStatusRow)(this.NewRow()));
            rowHealthStatusRow["EmployeeID"] = employeeID;
            rowHealthStatusRow["Height"] = height;
            rowHealthStatusRow["Weight"] = weight;
            rowHealthStatusRow["LeftVision"] = leftVision;
            rowHealthStatusRow["RightVision"] = rightVision;
            rowHealthStatusRow["BloodGroup"] = bloodGroup;
            this.Rows.Add(rowHealthStatusRow);
            return rowHealthStatusRow;
        }
        public HealthStatusRow FindByPrimaryKey(int employeeID)
        {
            return (HealthStatusRow)(Rows.Find(new object[] { employeeID }));
        }
        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new HealthStatusRow(builder);
        }
        public int GetListByEmployeeID(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("HealthStatus_GetListByEmployeeID", Connection.GetConnection());
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

            return Count;
        }
        public bool Insert(SqlConnection conn, SqlTransaction tran)
        {
            SqlCommand sqlCommand = new SqlCommand("HealthStatus_Insert", conn, tran);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            bool retVal = true;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
            sqlCommand.Parameters.Add("@Height", SqlDbType.Int, 4, "Height");
            sqlCommand.Parameters.Add("@Weight", SqlDbType.Int, 4, "Weight");
            sqlCommand.Parameters.Add("@LeftVision", SqlDbType.VarChar, 5, "LeftVision");
            sqlCommand.Parameters.Add("@RightVision", SqlDbType.VarChar, 5, "RightVision");
            sqlCommand.Parameters.Add("@BloodGroup", SqlDbType.VarChar, 2, "BloodGroup");

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
        #endregion
    }

    public class HealthStatusRow : DataRow
    {
        private HealthStatusTable _tableHealthStatus;

        internal HealthStatusRow(DataRowBuilder rb)
            : base(rb)
        {
            _tableHealthStatus = ((HealthStatusTable)(this.Table));
        }

        #region Properties
        public int EmployeeID
        {
            get
            {
                try
                {
                    return ((int)(this[_tableHealthStatus.EmployeeIDColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value EmployeeID because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableHealthStatus.EmployeeIDColumn] = value;
            }
        }
        public bool IsEmployeeIDNull()
        {
            return this.IsNull(_tableHealthStatus.EmployeeIDColumn);
        }
        public void SetEmployeeIDNull()
        {
            this[_tableHealthStatus.EmployeeIDColumn] = Convert.DBNull;
        }
        public int Height
        {
            get
            {
                try
                {
                    return ((int)(this[_tableHealthStatus.HeightColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Height because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableHealthStatus.HeightColumn] = value;
            }
        }
        public bool IsHeightNull()
        {
            return this.IsNull(_tableHealthStatus.HeightColumn);
        }
        public void SetHeightNull()
        {
            this[_tableHealthStatus.HeightColumn] = Convert.DBNull;
        }
        public int Weight
        {
            get
            {
                try
                {
                    return ((int)(this[_tableHealthStatus.WeightColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value Weight because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableHealthStatus.WeightColumn] = value;
            }
        }
        public bool IsWeightNull()
        {
            return this.IsNull(_tableHealthStatus.WeightColumn);
        }
        public void SetWeightNull()
        {
            this[_tableHealthStatus.WeightColumn] = Convert.DBNull;
        }
        public string LeftVision
        {
            get
            {
                try
                {
                    return ((string)(this[_tableHealthStatus.LeftVisionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value LeftVision because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableHealthStatus.LeftVisionColumn] = value;
            }
        }
        public bool IsLeftVisionNull()
        {
            return this.IsNull(_tableHealthStatus.LeftVisionColumn);
        }
        public void SetLeftVisionNull()
        {
            this[_tableHealthStatus.LeftVisionColumn] = Convert.DBNull;
        }
        public string RightVision
        {
            get
            {
                try
                {
                    return ((string)(this[_tableHealthStatus.RightVisionColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value RightVision because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableHealthStatus.RightVisionColumn] = value;
            }
        }
        public bool IsRightVisionNull()
        {
            return this.IsNull(_tableHealthStatus.RightVisionColumn);
        }
        public void SetRightVisionNull()
        {
            this[_tableHealthStatus.RightVisionColumn] = Convert.DBNull;
        }
        public string BloodGroup
        {
            get
            {
                try
                {
                    return ((string)(this[_tableHealthStatus.BloodGroupColumn]));
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Cannot get value BloodGroup because it is DBNull", exception);
                }
            }
            set
            {
                this[_tableHealthStatus.BloodGroupColumn] = value;
            }
        }
        public bool IsBloodGroupNull()
        {
            return this.IsNull(_tableHealthStatus.BloodGroupColumn);
        }
        public void SetBloodGroupNull()
        {
            this[_tableHealthStatus.BloodGroupColumn] = Convert.DBNull;
        }
        #endregion
    }
}
