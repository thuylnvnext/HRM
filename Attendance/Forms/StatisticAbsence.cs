using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Preview;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Common;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;

namespace Attendance.Forms
{
    public partial class StatisticAbsence : Common.Forms.StatisticItem, IShowData
    {
        private RegisterAbsenceTable registerAbsence = new RegisterAbsenceTable();
        private DateTime workingDay;

        public StatisticAbsence()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public override void ShowData(string departmentIDList, bool check)
        {
            WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
            waitDialog.Show();
            Application.DoEvents();
            bgvStatisticItem.BeginDataUpdate();
            if (check)
                registerAbsence.GetDailyStatistic(departmentIDList, workingDay);
            else
                registerAbsence.DeleteByDepartmentID(departmentIDList);
            bgvStatisticItem.EndDataUpdate();
            bgvStatisticItem.ExpandAllGroups();
            waitDialog.Close();
        }

        private void StatisticAbsence_Load(object sender, EventArgs e)
        {
            bgvStatisticItem.AddColumn("EmployeeCode", "Mã NV", Type.GetType("System.String"), bgvStatisticItem.Bands, true, false, HorzAlignment.Center);
            bgvStatisticItem.AddColumn("FullName", "Họ và tên", Type.GetType("System.String"), bgvStatisticItem.Bands, true, false, HorzAlignment.Near);
            statisticItem = StatisticAbsenceItemTable.GetContentTable();
            item = AttendanceItemTable.GetContentTable();
            InitGridView("bgvTotalAbsenceItem", registerAbsence, "BÁO CÁO NHÂN LỰC THEO NGÀY", true, false);
            bgvStatisticItem.AddColumn("Notes", "Ghi chú", Type.GetType("System.String"), bgvStatisticItem.Bands, false, true, HorzAlignment.Near);

            dedWorkingDay.DateTime = DateTime.Today;
        }

        private void StatisticAbsence_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void dedWorkingDay_EditValueChanged(object sender, EventArgs e)
        {
            workingDay = dedWorkingDay.DateTime;
            ShowData(Constant.departmentIDList, true);
        }
    }
}
