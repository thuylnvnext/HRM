using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Database;
using Common;
using DevExpress.XtraPrinting;
using System.Data;

namespace Personnel.Reports
{
    public partial class LabourContract : DevExpress.XtraReports.UI.XtraReport
    {
        public LabourContract()
        {
            InitializeComponent();

            grhEmployeeID.GroupFields.Add(new GroupField("ID", XRColumnSortOrder.Ascending));
            PrintingSystem.AfterMarginsChange += new DevExpress.XtraPrinting.MarginsChangeEventHandler(PrintingSystem_AfterMarginsChange);
            PrintingSystem.PageSettingsChanged += new EventHandler(PrintingSystem_PageSettingsChanged);
        }

        private void ChangeReportSettings(object sender)
        {
            PrintingSystem ps = sender as PrintingSystem;
            bool isLocationChanged = false;
            int newPageWidth = ps.PageBounds.Width - ps.PageMargins.Left - ps.PageMargins.Right;
            int currentPageWidth = this.PageWidth - this.Margins.Left - this.Margins.Right;
            int shift = currentPageWidth - newPageWidth;

            foreach (Band _band in base.Bands)
            {
                foreach (XRControl _control in _band.Controls)
                {
                    isLocationChanged = true;
                    //_control.Location = new Point((_control.Location.X - Math.Abs(shift)), _control.Location.Y);
                    _control.Width = _control.Width - shift;
                }
            }

            if (isLocationChanged == true)
            {
                Margins.Top = ps.PageMargins.Top;
                Margins.Bottom = ps.PageMargins.Bottom;
                Margins.Left = ps.PageMargins.Left;
                Margins.Right = ps.PageMargins.Right;
                PaperKind = ps.PageSettings.PaperKind;
                PaperName = ps.PageSettings.PaperName;
                Landscape = ps.PageSettings.Landscape;
                CreateDocument();
            }
        }

        private void PrintingSystem_PageSettingsChanged(object sender, EventArgs e)
        {
            ChangeReportSettings(sender);
        }

        private void PrintingSystem_AfterMarginsChange(object sender, DevExpress.XtraPrinting.MarginsChangeEventArgs e)
        {
            ChangeReportSettings(sender);
        }

        private void LabourContract_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlCompany.Text = TitleTable.GetValue("COMPANY_NAME", "Việt Nam");
            xrlCompanyE.Text = TitleTable.GetValue("COMPANY_NAME", "English");
        }

        private void xrtContent_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormTable form = new FormTable();
            FormRow fr;
            DataRowView er = (DataRowView)GetCurrentRow();
            DateTime madeAt = Convert.ToDateTime(er["FromDate"]);
            string[] values = new string[] {    
            er["EmployeeCode"].ToString(),
            madeAt.Day.ToString("00"), 
            madeAt.Month.ToString("00"), 
            madeAt.Year.ToString(), 
            madeAt.ToString("dd/MM/yyyy"), 
            madeAt.ToString("dd/MM/yyyy"), 
            Utility.ConvertToRTFFormat(er["FullName"].ToString()), 
            Utility.RemoveSign(er["FullName"].ToString()), 
            er["IDNumber"].ToString(), 
            er["IDNumber"].ToString(), 
            er["JobName"].ToString(), 
            er["JobName"].ToString(), 
            ((DateTime)GetCurrentColumnValue("BirthDate")).ToString("dd/MM/yyyy"), 
            ((DateTime)GetCurrentColumnValue("BirthDate")).ToString("dd/MM/yyyy"), 
            GetCurrentColumnValue("CurrentAddress").ToString(), 
            GetCurrentColumnValue("CurrentAddress").ToString(),
            madeAt.ToString("dd/MM/yyyy"),
            madeAt.ToString("dd/MM/yyyy"),
            Utility.ConvertToRTFFormat(Utility.MoneyToText(((decimal)er["BasicSalary"]))),
            ((decimal)er["BasicSalary"]).ToString("N0"),
            Utility.ConvertToRTFFormat(Utility.NumberToText(Convert.ToInt32(er["BasicSalary"]))),
            ((decimal)er["BasicSalary"]).ToString("N0") };
            
            form.GetContent();
            fr = form.FindByPrimaryKey("LabourContract");
            if (fr != null)
            {
                string rTF = fr.Value;
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

        private void xrlOperationsManager_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlOperationsManager.Text = ConstantTable.GetValueByName("RepresentativeName");
        }

        private void xrlEmployee_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlEmployee.Text = GetCurrentColumnValue("FullName").ToString();
        }
    }
}
