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

namespace Common.Reports
{
    public partial class StatisticItem : DevExpress.XtraReports.UI.XtraReport
    {
        private CustomBandedGridView bgv;
        private DateTime workingDay;
        private int beginSummary = 0, endSummary = 0;
        private Color backColor = Color.FromArgb(153, 204, 255);
        private decimal rate = 1;
        private string title;

        public StatisticItem()
        {
            InitializeComponent();
        }

        public StatisticItem(CustomBandedGridView bgv, DateTime workingDay, string title, bool group)
        {
            InitializeComponent();
            
            this.bgv = bgv;
            this.workingDay = workingDay;
            this.title = title;

            if (!ReferenceEquals(bgv.ActiveFilterCriteria, null)) FilterString = bgv.ActiveFilterCriteria.LegacyToString();
            if (group)
                grhDepartmentName.GroupFields.Add(new GroupField("DepartmentName", XRColumnSortOrder.Ascending));
            else
                xrlDepartmentName.Visible = false;
            grhDepartmentName.RepeatEveryPage = true;            
        }

        private XRLabel CreateLabel(string name, string caption, int x, int y, int w, int h, FontStyle fontStyle, Color backColor, BorderSide borderSide, TextAlignment alignment, string band)
        {
            XRLabel xrlLabel = new XRLabel();
            xrlLabel.Name = name;
            xrlLabel.Font = new Font(Font.FontFamily, 10, fontStyle);
            xrlLabel.Text = caption;
            xrlLabel.Location = new Point(x, y);
            xrlLabel.Size = new Size(w, h);
            xrlLabel.Borders = borderSide;
            xrlLabel.BackColor = backColor;
            xrlLabel.WordWrap = true;
            xrlLabel.CanGrow = false;
            xrlLabel.TextAlignment = alignment;

            Bands[band].Controls.Add(xrlLabel);

            return xrlLabel;
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
            XRLabel xrlGroupSummary = CreateLabel("group" + col.Name, col.Caption, x, y, w, h, FontStyle.Bold, Color.Transparent, BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleRight, "grfDepartmentName");
            xrlGroupSummary.DataBindings.Add(new XRBinding("Text", null, col.FieldName));
            xrlGroupSummary.Padding = new DevExpress.XtraPrinting.PaddingInfo(leftMargin, rightMargin, 0, 0);
            XRSummary summary = new XRSummary();
            summary.Func = SummaryFunc.Sum;
            summary.FormatString = "{0:" + col.DisplayFormat.FormatString + "}";
            summary.Running = SummaryRunning.Group;
            xrlGroupSummary.Summary = summary;
        }

        private void CreateHeader(GridBand band, ref int x, int y, ref int w)
        {
            int w1 = (int)(band.Width / rate);
            if (band.HasChildren && band.Visible)
            {
                int x1 = x;
                foreach (GridBand b in band.Children)
                {
                    CreateHeader(b, ref x, y + bgv.BandHeight(b.ParentBand), ref w);
                }
                if (band.Visible) CreateLabel(band.Name, band.Caption, x1, y, w - x1, bgv.BandHeight(band), FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Right | BorderSide.Top, TextAlignment.MiddleCenter, "grhDepartmentName");
            }
            else
            {
                if (band.Visible)
                {
                    CreateLabel(band.Name, band.Caption, x, y, w1, bgv.BandHeight(band), FontStyle.Bold, band.AppearanceHeader.BackColor, BorderSide.Right | BorderSide.Top | BorderSide.Bottom, TextAlignment.MiddleCenter, "grhDepartmentName");
                    int x2 = x;
                    BandedGridColumn bgc;
                    for (int col = 0; col < band.Columns.Count; col++)
                    {
                        bgc = band.Columns[col];
                        if (col == 0)
                        {
                            CreateField(bgc, x2, 0, (int)(bgc.Width / rate), 25);
                            w += w1;
                            x += w1;
                        }
                        else
                            CreateField(bgc, x2, 0, (int)(bgc.Width / rate), 25, BorderSide.Bottom);

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
                xrlWorkingDay.Text = string.Empty;
                xrlDepartmentName.Text = string.Empty;
            }
            else
            {
                xrlCompanyName.Location = new Point(85, 0);
                int Width = this.PageWidth - this.Margins.Left - this.Margins.Right;

                xrlCompanyName.Size = new Size(Width, 25);
                xrlCompanyName.Text = TitleTable.GetValue("COMPANY_NAME", Constant.language) + "\r\n" + TitleTable.GetValue("ADDRESS", Constant.language) + "\r\n" + TitleTable.GetValue("TEL", Constant.language);
                xrlTitle.Location = new Point(0, 25);
                xrlTitle.Size = new Size(Width, 35);
                xrlTitle.Text = title;
                xrlWorkingDay.Location = new Point(0, 60);
                xrlWorkingDay.Size = new Size(Width, 25);
                xrlWorkingDay.Text = string.Format(TitleTable.GetValue("MonthYear", Constant.language), workingDay.ToString("dd/MM/yyyy"));
                if (GetCurrentColumnValue("DepartmentName") != null)
                {
                    xrlDepartmentName.Location = new Point(0, 85);
                    xrlDepartmentName.Size = new Size(Width, 20);
                    xrlDepartmentName.Text = TitleTable.GetValue("DEPARTMENT", Constant.language) + GetCurrentColumnValue("DepartmentName").ToString().Substring(3);
                }
            }
        }

        private void StatisticItem_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int x = 0, y = 105, w = 0, h = 25;

            w = (int)(bgv.Bands[0].Width / rate);
            CreateLabel(bgv.Bands[0].Name, bgv.Bands[0].Caption, x, y, w, bgv.BandHeight(bgv.Bands[0]), FontStyle.Bold, bgv.Bands[0].AppearanceHeader.BackColor, BorderSide.All, TextAlignment.MiddleCenter, "grhDepartmentName");
            x = (int)(bgv.Bands[0].Width / rate);
            XRLabel xrlNo = CreateLabel("xrlNo", string.Empty, 0, 0, w, h, FontStyle.Regular, Color.Transparent, BorderSide.Left | BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleCenter, "Detail");
            XRSummary xrSummary = new XRSummary(SummaryRunning.Group, SummaryFunc.RecordNumber, "{0:#}");
            xrlNo.Summary = xrSummary;
            for (int i = 1; i < bgv.Bands.Count; i++)
            {
                CreateHeader(bgv.Bands[i], ref x, y, ref w);
            }

            CreateLabel("xrlGroupSummary1", "Tổng cộng:", 0, 0, beginSummary, 25, FontStyle.Bold, Color.Transparent, BorderSide.Left | BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleCenter, "grfDepartmentName");
            CreateLabel("xrlReportSummary2", string.Empty, endSummary, 0, x - endSummary, 25, FontStyle.Bold, Color.Transparent, BorderSide.Right | BorderSide.Bottom, TextAlignment.MiddleCenter, "grfDepartmentName");
        }
    }
}
