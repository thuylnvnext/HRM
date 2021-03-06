using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
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
    public partial class DailyManpower : DevExpress.XtraReports.UI.XtraReport
    {
        private CustomBandedGridView bgv;
        private DateTime fromDate, toDate;
        private int lastColumn = 0, beginSummary = 0, endSummary = 0, index = 0;
        private List<int> total = new List<int>();
        private decimal rate = 1m;

        public DailyManpower()
        {
            InitializeComponent();
        }

        public DailyManpower(CustomBandedGridView bgv, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.bgv = bgv;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        private XRLabel CreateLabel(string name, string caption, int x, int y, int w, int h, FontStyle fontStyle, Color backColor, BorderSide borderSide, TextAlignment alignment, string band)
        {
            XRLabel xrl = new XRLabel();
            xrl.Name = name;
            xrl.Font = new Font(Font.FontFamily, 9, fontStyle);
            xrl.Multiline = true;
            xrl.CanGrow = false;
            xrl.Text = caption;
            xrl.Location = new Point(x, y);
            xrl.Size = new Size(w, h);
            xrl.Borders = borderSide;
            xrl.BackColor = backColor;
            xrl.WordWrap = true;
            xrl.TextAlignment = alignment;

            Bands[band].Controls.Add(xrl);

            return xrl;
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
            XRLabel xrlField = CreateLabel(col.Name, col.Caption, x, y, w, h, FontStyle.Regular, Color.Transparent, BorderSide.Right | BorderSide.Bottom, alignment, "Detail");
            xrlField.DataBindings.Add(new XRBinding("Text", null, col.FieldName, "{0:" + col.DisplayFormat.FormatString + "}"));
            xrlField.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);
            xrlField.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrlField_BeforePrint);

            return xrlField;
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
            xrlField.DataBindings.Add(new XRBinding("Text", null, col.FieldName, "{0:" + col.DisplayFormat.FormatString + "}"));
            xrlField.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);
            xrlField.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrlField_BeforePrint);

            return xrlField;
        }


        private void xrlField_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel xrl = (XRLabel)sender;
            if (GetCurrentColumnValue("No").ToString() != string.Empty && !Utility.IsNumeric(GetCurrentColumnValue("No")))
                xrl.Font = new Font(xrl.Font, FontStyle.Bold);
            else
                xrl.Font = new Font(xrl.Font, FontStyle.Regular);
        }

        private void CreateSummary(GridColumn col, int x, int y, int w, int h)
        {
            int leftMargin = 0, rightMargin = 1;
            XRLabel xrlSummary = CreateLabel("group" + col.Name, col.Caption, x, y, w, h, FontStyle.Bold, Color.Transparent, BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleRight, "ReportFooter");
            xrlSummary.DataBindings.Add(new XRBinding("Text", null, col.FieldName));
            xrlSummary.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);
            xrlSummary.Tag = col.FieldName;
            XRSummary summary = new XRSummary();
            summary.Func = SummaryFunc.Custom;            
            summary.FormatString = "{0:" + col.DisplayFormat.FormatString + "}";
            summary.Running = SummaryRunning.Report;
            xrlSummary.Summary = summary;
            //xrlSummary.SummaryReset += new EventHandler(xrlSummary_SummaryReset);
            //xrlSummary.SummaryCalculated += new TextFormatEventHandler(xrlSummary_SummaryCalculated);
            xrlSummary.SummaryRowChanged += new EventHandler(xrlSummary_SummaryRowChanged);
            xrlSummary.SummaryGetResult += new SummaryGetResultHandler(xrlSummary_SummaryGetResult);
            total.Add(0);           
        }

        void xrlSummary_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            //total += Convert.ToInt32(e.Value);
        }

        private void xrlSummary_SummaryReset(object sender, EventArgs e)
        {
            //total[Index] = 0;
        }

        private void xrlSummary_SummaryRowChanged(object sender, EventArgs e)
        {
            if (GetCurrentColumnValue("No").ToString() != string.Empty && !Utility.IsNumeric(GetCurrentColumnValue("No"))) total[index++] += Convert.ToInt32(GetCurrentColumnValue(((XRLabel)sender).Tag.ToString()));
            if (index % total.Count == 0) index = 0;
        }

        private void xrlSummary_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = total[index++];
            e.Handled = true;
        }

        private void CreateHeader(GridBand band, ref int x, int y, ref int w)
        {
            int w1 = (int)(band.Width / rate);
            if (band.HasChildren)
            {
                int x1 = x;
                foreach (GridBand b in band.Children) CreateHeader(b, ref x, y + bgv.BandHeight(band), ref w);
                CreateLabel(band.Name, band.Caption, x1, y, w - x1, bgv.BandHeight(band), FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Right | BorderSide.Top, TextAlignment.MiddleCenter, "PageHeader");
            }
            else
            {
                if (band.Visible)
                {
                    CreateLabel(band.Name, band.Caption, x, y, w1, bgv.BandHeight(band), FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Right | BorderSide.Top | BorderSide.Bottom, TextAlignment.MiddleCenter, "PageHeader");
                    int x2 = x;
                    BandedGridColumn bgc;
                    for (int col = 0; col < band.Columns.Count; col++)
                    {
                        bgc = band.Columns[col];
                        lastColumn = (int)(bgc.Width / rate);
                        if (col == 0)
                        {
                            CreateField(bgc, x2, 0, lastColumn, 25);
                            w += w1;
                            x += w1;
                        }
                        else
                            CreateField(bgc, x2, 0, lastColumn, 25, BorderSide.Bottom);

                        if (bgc.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
                        {
                            CreateSummary(bgc, x2, 0, lastColumn, 25);
                            if (beginSummary == 0)
                                beginSummary = x2;
                            else
                                endSummary = x2 + lastColumn;
                        }
                        x2 += lastColumn;
                    }
                }
            }
        } 

        private void DailyManpower_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //DetailReport.DataMember = "TimeInTimeOut.TimeInTimeOut_BreakOutBreakIn";            
            //xrlHeader.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language) + "\r\n" + TitleTable.GetValue("ADDRESS", Constant.language) + "\r\n" + TitleTable.GetValue("TEL", Constant.language);
            xrlFromDateToDate.Text = string.Format(TitleTable.GetValue("FromDateToDate", Constant.language), fromDate.ToString("dd/MM/yyyy"), toDate.ToString("dd/MM/yyyy"));
            int x = 0, y = 0, w = 0, h = 25;
            w = (int)(bgv.Bands[0].Width / rate);
            CreateLabel(bgv.Bands[0].Name, bgv.Bands[0].Caption, x, y, w, bgv.BandHeight(bgv.Bands[0]), FontStyle.Bold, bgv.Bands[0].AppearanceHeader.BackColor, BorderSide.All, TextAlignment.MiddleCenter, "PageHeader");       
            XRLabel xrlNo = CreateField(bgv.Columns[0], 0, 0, w, h, BorderSide.Left | BorderSide.Right | BorderSide.Bottom);
            x = w;
            for (int i = 1; i < bgv.Bands.Count; i++)
            {
                CreateHeader(bgv.Bands[i], ref x, y, ref w);
            }
            CreateLabel("xrlGroupSummary1", TitleTable.GetValue("TOTAL", Constant.language), 0, 0, beginSummary, h, FontStyle.Bold, Color.Transparent, BorderSide.Left | BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleCenter, "ReportFooter");
            CreateLabel("xrlGroupSummary2", string.Empty, endSummary, 0, lastColumn, h, FontStyle.Bold, Color.Transparent, BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleCenter, "ReportFooter");
        }

        private void xRLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel xrl = (XRLabel)sender;
            string text = TitleTable.GetValue(string.Format("{0}.{1}", "DailyManpower", xrl.Name), Constant.language);
            if (text != string.Empty) xrl.Text = text;
        }

        private void xRLabel_PreviewDoubleClick(object sender, PreviewMouseEventArgs e)
        {
            XRLabel xrl = (XRLabel)sender;
            Common.Forms.TitleEditor titleEditor = new Common.Forms.TitleEditor("DailyManpower", xrl.Name, xrl.Text);
            if (titleEditor.ShowDialog() == System.Windows.Forms.DialogResult.OK) CreateDocument(true);
        }
    }
}
