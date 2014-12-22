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
    public partial class RegisterNightWork : XtraForm
    {
        private RegisterNightWorkTable registerNightWork = new RegisterNightWorkTable();
        private string[] departmentIDList;

        public RegisterNightWork()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void RegisterNightWork_Load(object sender, EventArgs e)
        {
            registerNightWork.GetContent();
            departmentIDList = Constant.departmentIDList.Split(new char[] { '[' }, StringSplitOptions.RemoveEmptyEntries);
            RegisterNightWorkRow rnwr = RegisterNightWorkTable.GetListByDepartmentID(Constant.departmentIDList, departmentIDList.Length);
            if (rnwr != null)
            {
                tedFrom.EditValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, (int)rnwr.From / 60, rnwr.From % 60, 0);
                tedTo.EditValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, (int)rnwr.To / 60, rnwr.To % 60, 0);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RegisterNightWorkRow rnwr;
            DateTime from = (DateTime)tedFrom.EditValue, to = (DateTime)tedTo.EditValue;
            foreach (string departmentID in departmentIDList)
            {
                rnwr = registerNightWork.FindByPrimaryKey(departmentID.Substring(0, departmentID.Length - 1));
                if (rnwr == null)
                    registerNightWork.AddRegisterNightWorkRow(departmentID, from.Hour * 60 + from.Minute, to.Hour * 60 + to.Minute);
                else
                {
                    rnwr.From = from.Hour * 60 + from.Minute;
                    rnwr.To = to.Hour * 60 + to.Minute;
                    if (rnwr.From == rnwr.To) rnwr.Delete();
                }
            }
            if (registerNightWork.Insert() && registerNightWork.Update() && registerNightWork.Delete())
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("REGISTER_NIGHTWORK_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("REGISTER_NIGHTWORK_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            Dispose(true);
        }
    }
}
