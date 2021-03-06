using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using Common;

namespace Attendance.Reports
{
    public partial class MonthWorking : DevExpress.XtraReports.UI.XtraReport
    {
        private BandedGridView bgv;
        private byte month;
        private short year;
        private int beginSummary = 0, endSummary = 0;
        private decimal rate = 1.5m;
        private XRLabel xrlLastBand1, xrlLastBand2, xrlLastColumn, xrlLastSummary;

        public MonthWorking()
        {
            InitializeComponent();
        }

        public MonthWorking(BandedGridView bgv, byte month, short year)
        {
            InitializeComponent();
            
            this.bgv = bgv;
            this.month = month;
            this.year = year;

            grhDepartmentName.GroupFields.Add(new GroupField("DepartmentName", XRColumnSortOrder.Ascending));
            grhDepartmentName.RepeatEveryPage = true;            
        }

        private XRLabel CreateLabel(string name, string caption, int x, int y, int w, int h, FontStyle fontStyle, Color backColor, BorderSide borderSide, TextAlignment alignment, string band)
        {
            XRLabel xrlHeader = new XRLabel();
            xrlHeader.Name = name;
            xrlHeader.Font = new Font(Font.FontFamily, 7, fontStyle);
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
            if (col.UnboundType == DevExpress.Data.UnboundColumnType.Decimal && col.Tag != null) CreateCalculatedField(col.FieldName, col.Tag.ToString());
            xrlField.DataBindings.Add(new XRBinding("Text", null, col.FieldName, "{0:" + col.DisplayFormat.FormatString + "}"));
            xrlField.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);

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

            return xrlField;
        }

        private void CreateSummary(GridColumn col, int x, int y, int w, int h)
        {
            int leftMargin = 0, rightMargin = 1;
            XRLabel xrlGroupSummary = CreateLabel("group" + col.Name, col.Caption, x, y, w, h, FontStyle.Bold, Color.Transparent, BorderSide.Left | BorderSide.Top | BorderSide.Bottom, TextAlignment.MiddleRight, "grfDepartmentName");
            xrlGroupSummary.DataBindings.Add(new XRBinding("Text", null, col.FieldName));
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
            if (band.Visible)
            {
                if (band.HasChildren)
                {
                    int x1 = x;
                    foreach (GridBand b in band.Children) CreateHeader(b, ref x, y + 20 * band.RowCount, ref w);
                    xrlLastBand1 = CreateLabel(band.Name, band.Caption, x1, y, w - x1, 20 * band.RowCount, FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "grhDepartmentName");
                }
                else
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

        private void grhDepartmentName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (PrintingSystem.Document.PageCount != 0 && GetCurrentColumnValue("DepartmentName").ToString() == GetPreviousColumnValue("DepartmentName").ToString())
            {
                xrlCompanyName.Text = string.Empty;
                xrlTitle.Text = string.Empty;
                xrlMonthYear.Text = string.Empty;
                xrlDepartmentName.Text = string.Empty;
            }
            else
            {
                xrlCompanyName.Text = TitleTable.GetValue(CompanyTable.GetDefaultInfo().ID, Constant.language);
                xrlTitle.Text = TitleTable.GetValue("MonthWorking.xrlTitle", Constant.language);
                xrlMonthYear.Text = string.Format(TitleTable.GetValue("MonthYear", Constant.language), month, year);

                //if (GetCurrentColumnValue("DepartmentName") != null) xrlDepartmentName.Text = TitleTable.GetValue("Department", Constant.language) + GetCurrentColumnValue("DepartmentName").ToString().Substring(3);
                if (GetCurrentColumnValue("DepartmentName") != null) xrlDepartmentName.Text = TitleTable.GetValue("Department", Constant.language) + GetCurrentColumnValue("DepartmentName").ToString();
            }
        }

        private void MonthWorking_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int x = 0, y = 105, w = 0, h = 25;

            w = (int)(bgv.Bands[0].Width / rate);
            CreateLabel(bgv.Bands[0].Name, bgv.Bands[0].Caption, x, y, w, 20 * bgv.Bands[0].RowCount, FontStyle.Bold, bgv.Bands[0].AppearanceHeader.BackColor, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "grhDepartmentName");
            x = (int)(bgv.Bands[0].Width / rate);
            XRLabel xrlNo = CreateLabel("xrlNo", string.Empty, 0, 0, w, h, FontStyle.Regular, Color.Transparent, BorderSide.Left | BorderSide.Top, TextAlignment.MiddleCenter, "Detail");
            XRSummary xrSummary = new XRSummary(SummaryRunning.Group, SummaryFunc.RecordNumber, "{0:#}");
            xrlNo.Summary = xrSummary;
            for (int i = 1; i < bgv.Bands.Count; i++)
            {
                CreateHeader(bgv.Bands[i], ref x, y, ref w);
            }
            xrlLastBand1.Borders = xrlLastBand1.Borders | BorderSide.Right;
            xrlLastBand2.Borders = xrlLastBand2.Borders | BorderSide.Right;
            xrlLastColumn.Borders = xrlLastColumn.Borders | BorderSide.Right;
            xrlLastSummary.Borders = xrlLastSummary.Borders | BorderSide.Right;
            CreateLabel("xrlGroupSummary1", TitleTable.GetValue("TOTAL", Constant.language), 0, 0, beginSummary, 25, FontStyle.Bold, Color.Transparent, BorderSide.Left | BorderSide.Top | BorderSide.Bottom, TextAlignment.MiddleCenter, "grfDepartmentName");
        }
    }
}
