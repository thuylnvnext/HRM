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
    public partial class MonthOvertime : MonthWorking
    {
        public MonthOvertime()
        {
            InitializeComponent();
            base.pageCategoryText = TitleTable.GetValue("MONTHOVERTIME_PAGECATEGORY", Constant.language);
            base.Name = this.Name;
        }

        private void MonthOvertime_Load(object sender, EventArgs e)
        {
            InitGridView("bgvMonthOvertime", "[]", "[3]", TitleTable.GetValue("MONTHOVERTIME_PAGECATEGORY", Constant.language));
        }
    }
}
