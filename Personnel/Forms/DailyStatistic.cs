using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Common;
using Database;

namespace Personnel.Forms
{
    public partial class DailyStatistic : XtraForm
    {
        private EmployeeTable employee = new EmployeeTable();
        private Reports.DailyManpower dailyManpower;

        public DailyStatistic()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }
        private void DailyStatistic_Load(object sender, EventArgs e)
        {
            cboStatisticType.SelectedIndex = 0;
            dedWorkingDay.DateTime = DateTime.Today;
            dedDateOfIssue.DateTime = DateTime.Today;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //dailyManpower = new Reports.DailyManpower(dedWorkingDay.DateTime, txtTabMan.Text, dedDateOfIssue.DateTime);
            //employee.DailyManpower(dedWorkingDay.DateTime);
            //dailyManpower.DataSource = employee;
            //dailyManpower.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            //dailyManpower.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            //dailyManpower.PrintingSystem.PreviewFormEx.Owner = this;
            //dailyManpower.ShowPreview();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
