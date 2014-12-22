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

namespace Personnel.Forms
{
    public partial class ReturnToWork : XtraForm
    {
        private int employeeID;

        public ReturnToWork()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public ReturnToWork(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            if (ResignationTable.ReturnToWork(employeeID, dedFromDate.DateTime))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("RETURN_TO_WORK_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("RETURN_TO_WORK_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ReturnToWork_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = DateTime.Today;
        }
    }
}
