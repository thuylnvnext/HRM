using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;

namespace Attendance.Forms
{
    public partial class TimeSheet : MonthWorking
    {
        public TimeSheet()
        {
            InitializeComponent();
        }

        private void TimeSheet_Load(object sender, EventArgs e)
        {
            InitGridView("bgvTimeSheet", "[W]", "[ROOT][2]", TitleTable.GetValue("TIMESHEET_PAGECATEGORY", Constant.language));
        }
    }
}
