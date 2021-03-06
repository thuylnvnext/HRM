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
    public partial class DecisionOfRecruiment : DevExpress.XtraReports.UI.XtraReport
    {
        private string _rTF, decision;
        private DateTime effectiveDate;

        public DecisionOfRecruiment(string decision, DateTime effectiveDate)
        {
            InitializeComponent();
            _rTF = xrtContent.Rtf;
            this.decision = decision;
            this.effectiveDate = effectiveDate;
        }

        private void xrtContent_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataRowView er = (DataRowView)GetCurrentRow();
            string[] values = new string[] {    
            effectiveDate.ToString("dd/MM/yyyy"),
            effectiveDate.Month.ToString("00"), 
            effectiveDate.Year.ToString(),
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

        private void xrlDecision_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlDecision.Text = string.Format("Số: {0}/QĐ/APTH", decision);
        }

        private void xrlCompany_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlCompany.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language);
        }

        private void DecisionOfRecruiment_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRSummary no = new XRSummary();
            no.Func = SummaryFunc.RecordNumber;
            no.Running = SummaryRunning.Report;
            xrlNo.Summary = no;

            xrlEmployeeCode.DataBindings.Add(new XRBinding("Text", null, "EmployeeCode"));
            xrlFullName.DataBindings.Add(new XRBinding("Text", null, "FullName"));
            xrlBookNumber.DataBindings.Add(new XRBinding("Text", null, "BookNumber"));
            xrlBirthDate.DataBindings.Add(new XRBinding("Text", null, "BirthDate", "{0:dd/MM/yyyy}"));
            xrlPositionName.DataBindings.Add(new XRBinding("Text", null, "PositionName"));
            xrlBasicSalary.DataBindings.Add(new XRBinding("Text", null, "BasicSalary", "{0:#,##0.#;;}"));

            xrlTotalBasicSalary.DataBindings.Add(new XRBinding("Text", null, "BasicSalary"));
            XRSummary total = new XRSummary();
            total.Func = SummaryFunc.Sum;
            total.FormatString = "{0:#,##0;;0}";
            total.Running = SummaryRunning.Report;
            xrlTotalBasicSalary.Summary = total;
        }
    }
}
