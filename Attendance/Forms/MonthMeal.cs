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
    public partial class MonthMeal : MonthWorking
    {
        public MonthMeal()
        {
            InitializeComponent();
        }

        private void MonthMeal_Load(object sender, EventArgs e)
        {
            InitGridView("bgvMonthMeal", "[M]", "[4]", TitleTable.GetValue("MONTHMEAL_PAGECATEGORY", Constant.language));
        }
    }
}
