using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraEditors;

namespace Attendance.Forms
{
    public partial class ImportAbsence : XtraForm
    {
        private int employeeID;

        public ImportAbsence(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            Utility.SetSkin(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void ImportAbsence_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dedToDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (RegisterAbsenceTable.ImportFromHR(dedFromDate.DateTime, dedToDate.DateTime, employeeID))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("IMPORT_FROM_HR_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("IMPORT_FROM_HR_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            Cursor = Cursors.Default;
            Dispose(true);
        }
    }
}
