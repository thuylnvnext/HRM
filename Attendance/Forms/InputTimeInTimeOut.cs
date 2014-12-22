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
    public partial class InputTimeInTimeOut : XtraForm
    {
        private int[] employeeIDs;
        private TimeInTimeOut parentForm;
        private DataTable timeInTimeOut = new DataTable();
        private DateTime fromDate, toDate;

        public InputTimeInTimeOut(int[] employeeIDs, DateTime fromDate, DateTime toDate, TimeInTimeOut parentForm)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeIDs = employeeIDs;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.parentForm = parentForm;
            timeInTimeOut.Columns.Add("TimeIn", typeof(DateTime));
            timeInTimeOut.Columns.Add("TimeOut", typeof(DateTime));
        }

        private void InputTimeInTimeOut_Load(object sender, EventArgs e)
        {
            dedFromDate.DateTime = fromDate;
            dedToDate.DateTime = toDate;
            ShiftTable shift = new ShiftTable();
            shift.GetContent();
            shift.AddShiftRow(string.Empty, string.Empty, false, false);
            lueShift.Properties.DataSource = shift;
            lueShift.Properties.ValueMember = "ID";
            lueShift.Properties.DisplayMember = "Name";
            grdTimeInTimeOut.DataSource = timeInTimeOut;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool noError = true;
            DateTime d = dedFromDate.DateTime, timeIn = DateTime.Today, timeOut = DateTime.Today;
            int maxMinute = Convert.ToInt32(txtMinute.Text) + 1;

            while (d <= dedToDate.DateTime)
            {
                foreach (int employeeID in employeeIDs)
                {                    
                    if (timeInTimeOut.Rows.Count == 0)
                    {
                        TimeInTimeOutTable.DeleteValue(employeeID, d, lueShift.EditValue.ToString());
                        noError = RawDataTable.Delete(employeeID, d, true);
                    }
                    else
                    {
                        foreach (DataRow dr in timeInTimeOut.Rows)
                        {
                            DateTime t, _timeIn, _timeOut;
                            t = (DateTime)dr["TimeIn"];
                            _timeIn = TimeInTimeOutTable.GetTime(employeeID, d, true);
                            _timeOut = TimeInTimeOutTable.GetTime(employeeID, d, false);
                            if (t.Hour != 0 || t.Minute != 0)
                            {
                                DateTime time = TimeInTimeOutTable.GetTime(employeeID, d, true);
                                TimeInTimeOutTable.DeleteValue(employeeID, d, lueShift.EditValue.ToString());
                                timeIn = new DateTime(d.Year, d.Month, d.Day, t.Hour, t.Minute, t.Second);
                                if (maxMinute > 1)
                                {
                                    Random r = new Random();
                                    timeIn = timeIn.AddMinutes(-r.Next(maxMinute));
                                }
                                noError = RawDataTable.InsertValue(employeeID, _timeIn, timeIn, true, true);
                            }
                            if (!noError) break;
                            t = (DateTime)dr["TimeOut"];
                            if (t.Hour != 0 || t.Minute != 0)
                            {
                                DateTime time = TimeInTimeOutTable.GetTime(employeeID, d, false);
                                TimeInTimeOutTable.DeleteValue(employeeID, d, lueShift.EditValue.ToString());
                                timeOut = new DateTime(d.Year, d.Month, d.Day, t.Hour, t.Minute, t.Second);
                                if (maxMinute > 1)
                                {
                                    Random r = new Random();
                                    timeOut = timeOut.AddMinutes(r.Next(maxMinute));
                                }
                                noError = RawDataTable.InsertValue(employeeID, _timeOut, timeOut, true, true);
                            }
                            if (!noError) break;
                        }
                    }
                    if (!noError) break;
                }
                if (!noError) break;
                d = d.AddDays(1);
            }
            if (noError)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TIMEINTIMEOUT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentForm.ShowData(Constant.departmentIDList, true);
            }
            else
            {                
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TIMEINTIMEOUT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lueShift_EditValueChanged(object sender, EventArgs e)
        {
            ShiftDetailRow sdr = ShiftDetailTable.GetListByShiftID(lueShift.EditValue.ToString(), dedFromDate.DateTime);
            if (sdr != null)
            {
                DataRow dr;
                dr = timeInTimeOut.NewRow();
                dr["TimeIn"] = (DateTime)sdr["TimeIn"];
                dr["TimeOut"] = (DateTime)sdr["TimeOut"];
                timeInTimeOut.Rows.Add(dr);
            }
            else
                timeInTimeOut.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
