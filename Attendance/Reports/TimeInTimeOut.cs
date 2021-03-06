using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using Database;
using Common;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;
using System.Data;

namespace Attendance.Reports
{
    public partial class TimeInTimeOut : DevExpress.XtraReports.UI.XtraReport
    {
        private BandedGridView bgv;
        private DateTime fromDate, toDate;
        private int recordNumber = 0, beginSummary = 0, endSummary = 0;
        private bool firstRecord = true;
        private decimal rate = 1m;
        private XRLabel xrlLastBand1, xrlLastBand2, xrlLastColumn, xrlLastSummary;
        private ShiftTable shift = new ShiftTable();

        public TimeInTimeOut()
        {
            InitializeComponent();
        }

        public TimeInTimeOut(BandedGridView bgv, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.bgv = bgv;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        private XRLabel CreateLabel(string name, string caption, int x, int y, int w, int h, FontStyle fontStyle, Color backColor, BorderSide borderSide, TextAlignment alignment, string band)
        {
            XRLabel xrlHeader = new XRLabel();
            xrlHeader.Name = name;
            xrlHeader.Font = new Font(Font.FontFamily, 9, fontStyle);
            xrlHeader.Multiline = true;
            xrlHeader.CanGrow = false;
            xrlHeader.Text = caption;
            xrlHeader.Location = new Point(x, y);
            xrlHeader.Size = new Size(w, h);
            xrlHeader.Borders = borderSide;
            xrlHeader.BackColor = backColor;
            xrlHeader.WordWrap = true;
            xrlHeader.TextAlignment = alignment;

            Bands[band].Controls.Add(xrlHeader);

            return xrlHeader;
        }

        private void CreateCalculatedField(string name, string expression)
        {
            CalculatedField cf = new CalculatedField();
            CalculatedFields.Add(cf);
            cf.DataSource = DataSource;
            cf.DataMember = DataMember;
            cf.FieldType = FieldType.Decimal;
            cf.Name = name;
            cf.Expression = expression;
        }

        private XRLabel CreateField(GridColumn col, int x, int y, int w, int h)
        {
            TextAlignment alignment = TextAlignment.MiddleLeft;
            int leftMargin = 0, rightMargin = 0;
            switch (col.AppearanceCell.TextOptions.HAlignment)
            {
                case DevExpress.Utils.HorzAlignment.Near:
                    alignment = TextAlignment.MiddleLeft;
                    leftMargin = 1;
                    break;
                case DevExpress.Utils.HorzAlignment.Center:
                    alignment = TextAlignment.MiddleCenter;
                    break;
                case DevExpress.Utils.HorzAlignment.Far:
                    alignment = TextAlignment.MiddleRight;
                    rightMargin = 1;
                    break;
            }
            XRLabel xrlField = CreateLabel(col.Name, col.Caption, x, y, w, h, FontStyle.Regular, Color.Transparent, BorderSide.Left | BorderSide.Top, alignment, "Detail");
            //if (col.UnboundType == DevExpress.Data.UnboundColumnType.Decimal && col.Tag != null) CreateCalculatedField(col.FieldName, col.Tag.ToString());
            if (col.UnboundType == DevExpress.Data.UnboundColumnType.Bound)
                xrlField.DataBindings.Add(new XRBinding("Text", ((ReportData)DataSource).TimeInTimeOut, col.FieldName, "{0:" + col.DisplayFormat.FormatString + "}"));
            else
                xrlField.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrlField_BeforePrint);
            xrlField.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);

            return xrlField;
        }

        private void xrlField_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel xrl = (XRLabel)sender;
            if (xrl.Name == "bcoDuration")
            {
                string interval = GetCurrentColumnValue("Interval").ToString();
                if (interval != string.Empty) xrl.Text = interval.Substring(0, interval.IndexOf(" "));
            }
            if (xrl.Name == "bcoRest")
            {
                string interval = GetCurrentColumnValue("Interval").ToString();
                if (interval != string.Empty)
                {
                    UInt16 rest = Convert.ToUInt16(interval.Substring(interval.IndexOf(" ") + 1));
                    xrl.Text = ((UInt16)(rest / 60)).ToString("00") + ":" + (rest % 60).ToString("00");
                }
            }
        }

        private XRLabel CreateField(GridColumn col, int x, int y, int w, int h, BorderSide borderSide)
        {
            TextAlignment alignment = TextAlignment.MiddleLeft;
            int leftMargin = 0, rightMargin = 0;
            switch (col.AppearanceCell.TextOptions.HAlignment)
            {
                case DevExpress.Utils.HorzAlignment.Near:
                    alignment = TextAlignment.MiddleLeft;
                    leftMargin = 1;
                    break;
                case DevExpress.Utils.HorzAlignment.Center:
                    alignment = TextAlignment.MiddleCenter;
                    break;
                case DevExpress.Utils.HorzAlignment.Far:
                    alignment = TextAlignment.MiddleRight;
                    rightMargin = 1;
                    break;
            }
            XRLabel xrlField = CreateLabel(col.Name, col.Caption, x, y, w, h, FontStyle.Regular, Color.Transparent, borderSide, alignment, "Detail");
            //xrlField.DataBindings.Add(new XRBinding("Text", null, col.FieldName, "{0:" + col.DisplayFormat.FormatString + "}"));
            xrlField.DataBindings.Add(new XRBinding("Text", ((ReportData)DataSource).TimeInTimeOut, col.FieldName, "{0:" + col.DisplayFormat.FormatString + "}"));
            xrlField.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);

            return xrlField;
        }

        private void CreateSummary(GridColumn col, int x, int y, int w, int h)
        {
            int leftMargin = 0, rightMargin = 1;
            XRLabel xrlGroupSummary = CreateLabel("group" + col.Name, col.Caption, x, y, w, h, FontStyle.Bold, Color.Transparent, BorderSide.Left | BorderSide.Top | BorderSide.Bottom, TextAlignment.MiddleRight, "grfDepartmentName");
            xrlGroupSummary.DataBindings.Add(new XRBinding("Text", ((ReportData)DataSource).TimeInTimeOut, col.FieldName));
            xrlGroupSummary.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);
            XRSummary summary = new XRSummary();
            summary.Func = SummaryFunc.Sum;
            summary.FormatString = "{0:" + col.DisplayFormat.FormatString + "}";
            summary.Running = SummaryRunning.Group;
            xrlGroupSummary.Summary = summary;
            xrlLastSummary = xrlGroupSummary;
        }

        private void CreateHeader(GridBand band, ref int x, int y, ref int w)
        {
            int w1 = (int)(band.Width / rate);
            if (band.HasChildren)
            {
                int x1 = x;
                foreach (GridBand b in band.Children) CreateHeader(b, ref x, y + 20 * band.RowCount, ref w);
                xrlLastBand1 = CreateLabel(band.Name, band.Caption, x1, y, w - x1, 20 * band.RowCount, FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "grhDepartmentName");
            }
            else
            {
                if (band.Visible)
                {
                    xrlLastBand2 = CreateLabel(band.Name, band.Caption, x, y, w1, 20 * band.RowCount, FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "grhDepartmentName");
                    int x2 = x;
                    BandedGridColumn bgc;
                    for (int col = 0; col < band.Columns.Count; col++)
                    {
                        bgc = band.Columns[col];
                        if (col == 0)
                        {
                            xrlLastColumn = CreateField(bgc, x2, 0, (int)(bgc.Width / rate), 25);
                            w += w1;
                            x += w1;
                        }
                        else
                            xrlLastColumn = CreateField(bgc, x2, 0, (int)(bgc.Width / rate), 25, BorderSide.Top);

                        if (bgc.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None && bgc.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.Custom)
                        {
                            CreateSummary(bgc, x2, 0, (int)(bgc.Width / rate), 25);
                            if (beginSummary == 0)
                                beginSummary = x2;
                            else
                                endSummary = x2 + (int)(bgc.Width / rate);
                        }
                        x2 += (int)(bgc.Width / rate);
                    }
                }
            }
        } 

        private void TimeInTimeOut_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //DetailReport.DataMember = "TimeInTimeOut.TimeInTimeOut_BreakOutBreakIn";            
            grhDepartmentName.GroupFields.Add(new GroupField("DepartmentName", XRColumnSortOrder.Ascending));
            grhDepartmentName.RepeatEveryPage = true; 

            int x = 0, y = 150, w = 0, h = 25;
            w = 30;
            CreateLabel(bgv.Bands[0].Name, bgv.Bands[0].Caption, x, y, w, 20 * bgv.Bands[0].RowCount, FontStyle.Bold, bgv.Bands[0].AppearanceHeader.BackColor, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "grhDepartmentName");
            x = 30;// (int)(bgv.Bands[0].Width / rate);
            XRLabel xrlNo = CreateLabel("xrlNo", string.Empty, 0, 0, w, h, FontStyle.Regular, Color.Transparent, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "Detail");
            XRSummary xrSummary = new XRSummary(SummaryRunning.Group, SummaryFunc.RecordNumber, "{0:#}");
            xrlNo.Summary = xrSummary;
            for (int i = 1; i < bgv.Bands.Count; i++)
            {
                CreateHeader(bgv.Bands[i], ref x, y, ref w);
            }
            if (xrlLastBand1.Location.X + xrlLastBand1.Width == x) xrlLastBand1.Borders = xrlLastBand1.Borders | BorderSide.Right;
            xrlLastBand2.Borders = xrlLastBand2.Borders | BorderSide.Right;
            xrlLastColumn.Borders = xrlLastColumn.Borders | BorderSide.Right;
            //xrlLastSummary.Borders = xrlLastSummary.Borders | BorderSide.Right;
            CreateLabel("xrlGroupSummary1", TitleTable.GetValue("TOTAL", Constant.language), 0, 0, beginSummary, 25, FontStyle.Bold, Color.Transparent, BorderSide.Left | BorderSide.Top | BorderSide.Bottom, TextAlignment.MiddleCenter, "grfDepartmentName");
            //xrlBreakOut.DataBindings.Add(new XRBinding("Text", null, "TimeInTimeOut.TimeInTimeOut_BreakOutBreakIn.BreakOut", "{0:HH:mm}"));
            //xrlBreakIn.DataBindings.Add(new XRBinding("Text", null, "TimeInTimeOut.TimeInTimeOut_BreakOutBreakIn.BreakIn", "{0:HH:mm}"));
            shift.GetContent();
            Bands["Detail"].Controls["bcoShiftID"].BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrlShiftID_BeforePrint);
        }

        private void grhDepartmentName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (PrintingSystem.Document.PageCount != 0 && GetCurrentColumnValue("DepartmentName").ToString() == GetPreviousColumnValue("DepartmentName").ToString())
            {
                xrlCompanyName.Text = string.Empty;
                xrlTitle.Text = string.Empty;
                xrlTitle.CanShrink = true;
                xrlFromDateToDate.Text = string.Empty;
                xrlDepartmentName.Text = string.Empty;
            }
            else
            {
                xrlCompanyName.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language) + "\r\n" + TitleTable.GetValue("ADDRESS", Constant.language) + "\r\n" + TitleTable.GetValue("TEL", Constant.language);
                xrlTitle.Text = TitleTable.GetValue("TimeInTimeOut.xrlTitle", Constant.language);
                xrlTitle.CanShrink = false;
                xrlFromDateToDate.Text = string.Format(TitleTable.GetValue("FromDateToDate", Constant.language), fromDate.ToString("dd/MM/yyyy"), toDate.ToString("dd/MM/yyyy"));
                if (GetCurrentColumnValue("DepartmentName") != null) xrlDepartmentName.Text = TitleTable.GetValue("DEPARTMENT", Constant.language) + GetCurrentColumnValue("DepartmentName").ToString().Substring(5);
                recordNumber = 0;
            }            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //if (PrintingSystem.Document.PageCount == 0 || GetCurrentColumnValue("EmployeeCode").ToString() != GetPreviousColumnValue("EmployeeCode").ToString()) recordNumber++;
        }

        private void xrlShiftID_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRLabel)sender).Text = shift.FindByPrimaryKey(GetCurrentColumnValue("ShiftID").ToString()).Name;
        }

        private void xrlLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRLabel xrlLabel = (XRLabel)sender;
            //if (xrlLabel.Name == "xrlNo") xrlNo.Text = recordNumber.ToString();
            //if (xrlLabel.Name != "xrlLastName")
            //    xrlLabel.Borders = BorderSide.Left | BorderSide.Top;
            //else
            //    xrlLabel.Borders = BorderSide.Top;
            //if (!firstRecord && GetCurrentColumnValue("EmployeeCode").ToString() == GetPreviousColumnValue("EmployeeCode").ToString())
            //{
            //    xrlLabel.Text = string.Empty;
            //    if (xrlLabel.Name != "xrlLastName")
            //        xrlLabel.Borders = BorderSide.Left;
            //    else
            //        xrlLabel.Borders = BorderSide.None;
            //}
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            firstRecord = false;
        }
    }
}
