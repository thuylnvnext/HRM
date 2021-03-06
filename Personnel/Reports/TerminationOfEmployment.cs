using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Database;
using Common;

namespace Personnel.Reports
{
    public partial class TerminationOfEmployment : DevExpress.XtraReports.UI.XtraReport
    {
        private string _rTF;

        public TerminationOfEmployment()
        {
            InitializeComponent();
            grhEmployeeID.GroupFields.Add(new GroupField("EmployeeID", XRColumnSortOrder.Ascending));
            _rTF = xrtContent.Rtf;
        }

        private void xrtContent_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataRowView er = (DataRowView)GetCurrentRow();
            if (er != null)
            {
                DateTime effectiveDate = Convert.ToDateTime(er["EffectiveDate"]);
                string[] values = new string[] {    
            er["No"].ToString(),
            er["No"].ToString(), 
            Utility.ConvertToRTFFormat(er["FullName"].ToString()),
            effectiveDate.Day.ToString("00"), 
            effectiveDate.Month.ToString("00"), 
            effectiveDate.Year.ToString(),
            Utility.ConvertToRTFFormat(er["FullName"].ToString()),
            effectiveDate.ToString("dd/MM/yyyy") };
                string rTF = _rTF;
                int index = 0;
                for (int i = 0; i < rTF.Length; i++)
                {
                    if (rTF[i] == '[' && index < values.Length)
                    {
                        rTF = rTF.Insert(i + 1, values[index++]);
                        rTF = rTF.Remove(i, 1);
                    }
                    if (rTF[i] == ']' && index <= values.Length)
                    {
                        rTF = rTF.Remove(i, 1);
                        if (index == values.Length) index++;
                    }
                }
                xrtContent.Rtf = rTF;
            }
        }

        private void xrlDecision_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (GetCurrentColumnValue("Decision") != null) xrlDecision.Text = "Số: " + GetCurrentColumnValue("Decision").ToString();
        }

        private void xrlCompany_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlCompany.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language);
        }
    }
}
