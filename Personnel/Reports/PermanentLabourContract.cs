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
    public partial class PermanentLabourContract : DevExpress.XtraReports.UI.XtraReport
    {
        public PermanentLabourContract()
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

        private void xrtContent_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormTable form = new FormTable();
            FormRow fr;
            DataRowView er = (DataRowView)GetCurrentRow();
            DateTime signingDate = Convert.ToDateTime(er["SigningDate"]);
            string[] values = new string[] {    
            er["EmployeeCode"].ToString().Substring(1),
            signingDate.ToString("dd MMMM yyyy"), 
            Utility.RemoveSign(er["FullName"].ToString()),
            er["EmployeeCode"].ToString(),
            er["DepartmentName"].ToString(),             
            er["Gender"].ToString()== "F" ? "Ms" : "Mr",
            Utility.RemoveSign(er["LastName"].ToString()),
            signingDate.ToString("dd-MMMM-yyyy"), 
            signingDate.Day.ToString("00"), 
            signingDate.Month.ToString("00"), 
            signingDate.Year.ToString(),
            er["PositionNameE"].ToString(), 
            Utility.ConvertToRTFFormat(er["PositionName"].ToString()), 
            (Convert.ToDecimal(er["BasicSalary"])).ToString("N0"),
            (Convert.ToDecimal(er["BasicSalary"])).ToString("N0"),
            er["EmployeeCode"].ToString().Substring(1),
            signingDate.AddYears(-1).ToString("dd MMMM yyyy"),
            er["EmployeeCode"].ToString().Substring(1),
            signingDate.Day.ToString("00"), 
            signingDate.Month.ToString("00"), 
            (signingDate.Year - 2).ToString() };
            
            form.GetContent();
            fr = form.FindByPrimaryKey("LimitLabourContract");
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
    }
}
