using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Database
{
    public class DailyManpowerDataSet : DataSet
    {
        private DepartmentTable tableDepartment;
        private RegisterAbsenceTable tableRegisterAbsence;

        public DepartmentTable Department
        {
            get
            {
                return this.tableDepartment;
            }
        }
        public RegisterAbsenceTable RegisterAbsence
        {
            get
            {
                return this.tableRegisterAbsence;
            }
        }
        public DailyManpowerDataSet()
        {
            this.InitClass();
        }
        private void InitClass()
        {
            this.DataSetName = "DailyManpowerDataSet";
            tableDepartment = new DepartmentTable();
            tableRegisterAbsence = new RegisterAbsenceTable();
            tableRegisterAbsence.Columns.Add("DepartmentID", typeof(string));
            this.Tables.AddRange(new DataTable[] { tableDepartment, tableRegisterAbsence });
            this.Relations.Add("FK_Department_RegisterAbsence", tableDepartment.IDColumn, tableRegisterAbsence.Columns["DepartmentID"]);
        }
    }
}
