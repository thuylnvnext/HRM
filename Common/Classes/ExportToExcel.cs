using System;
using System.Collections.Generic;
using System.Text;
using Database;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Drawing;

namespace Common
{
    public class ExportToExcel
    {
        protected Application application;
        protected Workbooks workbooks;
        protected Workbook workbook;
        protected Worksheet worksheet;

        public Worksheet Worksheet
        {
            get
            {
                return worksheet;
            }
        }
        protected ExportToExcel(string sheetName, string fontName)
        {
            application = new Application();
            application.DisplayAlerts = false;
            workbooks = application.Workbooks;
            workbook = workbooks.Add(Type.Missing);
            worksheet = (Worksheet)workbook.Sheets[1];
            worksheet.Name = sheetName;
            worksheet.Cells.Font.Name = fontName;            
            //application.Visible = true;
        }
        public Range GetRange(object cell1, object cell2)
        {
            return worksheet.get_Range(cell1, cell2);
        }
        protected string GetColumnNameFromIndex(int index)
        {
            string endColumn = string.Empty;
            int f, s;

            f = (int)((index - 1) / 26) + 64;
            s = (index - 1) % 26 + 65;

            if (f > 64) endColumn = ((char)f).ToString();
            endColumn += ((char)s).ToString();

            return endColumn;
        }
        public void FormatCells(string cell1, string cell2, float width, string numberFormat, XlHAlign horizontal, XlVAlign vertical, int fontSize)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (width != 0) r.ColumnWidth = width;
            if (numberFormat != string.Empty)
                r.NumberFormat = numberFormat;
            else
                r.NumberFormat = "@";
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Font.Size = fontSize;
        }
        public void FormatCells(string cell1, string cell2, float width, string numberFormat, Color backColor, XlHAlign horizontal, XlVAlign vertical, int fontSize)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (width != 0) r.ColumnWidth = width;
            if (numberFormat != string.Empty)
                r.NumberFormat = numberFormat;
            else
                r.NumberFormat = "@";
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Font.Size = fontSize;
        }
        public void FormatCells(string cell1, string cell2, string numberFormat, XlHAlign horizontal, XlVAlign vertical, int fontSize, bool bold)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (numberFormat != string.Empty)
                r.NumberFormat = numberFormat;
            else
                r.NumberFormat = "@";
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Font.Size = fontSize;
            r.Font.Bold = bold;
        }

        public void SetRowHeight(string cell1, string cell2, float RowHeight)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.RowHeight = RowHeight;
        }

        public void SetBorders(string cell1, string cell2, bool all)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            if (r.Rows.Count > 1) r.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            if (r.Columns.Count > 1) r.Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            if (r.Columns.Count > 4 && !all) worksheet.get_Range(r.Cells[1, 5], r.Cells[r.Rows.Count, 5]).Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        public void SetBorders(string cell1, string cell2, XlLineStyle lineStyle)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            if (r.Rows.Count > 1)
            {
                r.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = lineStyle;
                r.Borders[XlBordersIndex.xlInsideHorizontal].Weight = XlBorderWeight.xlHairline;
            }
            if (r.Columns.Count > 1) r.Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            if (r.Columns.Count > 4) worksheet.get_Range(r.Cells[1, 5], r.Cells[r.Rows.Count, 5]).Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        public void SetBorders(string cell1, string cell2, XlLineStyle lineStyle, bool all)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            if (r.Rows.Count > 1)
            {
                r.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = lineStyle;
                r.Borders[XlBordersIndex.xlInsideHorizontal].Weight = XlBorderWeight.xlHairline;
            }
            if (r.Columns.Count > 1) r.Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            if (r.Columns.Count > 5 && !all) worksheet.get_Range(r.Cells[1, 6], r.Cells[r.Rows.Count, 6]).Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        public void SetBorders(Range r)
        {
            r.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            r.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            if (r.Rows.Count > 1) r.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            if (r.Columns.Count > 1) r.Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
        }
        public void SetText(object cell, int width, bool wrapText, int fontSize, bool bold, object backColor, XlHAlign horizontal, XlVAlign vertical, string value)
        {
            Range r = worksheet.get_Range(cell, cell);
            if (width != 0) r.ColumnWidth = width;
            r.WrapText = wrapText;
            r.Font.Size = fontSize;
            r.Font.Bold = bold;
            r.Interior.ColorIndex = backColor;
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
        }
        public void SetText(object cell, int width, bool wrapText, int fontSize, bool bold, object backColor, XlHAlign horizontal, XlVAlign vertical, string value, float rowHeight)
        {
            Range r = worksheet.get_Range(cell, cell);
            if (width != 0) r.ColumnWidth = width;
            r.WrapText = wrapText;
            r.Font.Size = fontSize;
            r.Font.Bold = bold;
            r.Interior.ColorIndex = backColor;
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
            r.RowHeight = rowHeight;
        }
        public void SetText(object cell, string fontStyle, Color backColor, string value)
        {
            Range r = worksheet.get_Range(cell, cell);
            r.Font.FontStyle = fontStyle;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.Value2 = value;
        }

        public void SetText(object cell, string fontStyle, Color backColor, string value, int size)
        {
            Range r = worksheet.get_Range(cell, cell);
            r.Font.FontStyle = fontStyle;
            r.Font.Size = size;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.Value2 = value;
        }

        public void SetText(object cell, string fontStyle, Color backColor, string value, float rowHeight)
        {
            Range r = worksheet.get_Range(cell, cell);
            r.Font.FontStyle = fontStyle;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.Value2 = value;
            r.RowHeight = rowHeight;
        }
        public void SetText(object cell, string fontStyle, bool italic, Color backColor, string value)
        {
            Range r = worksheet.get_Range(cell, cell);
            r.Font.FontStyle = fontStyle;
            r.Font.Italic = italic;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.Value2 = value;
        }

        public void SetText(object cell1, object cell2, string fontStyle, int fontSize, XlHAlign horizontal, XlVAlign vertical, string value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Merge(false);
            r.Font.FontStyle = fontStyle;
            r.Font.Size = fontSize;
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
        }
        public void SetText(object cell1, object cell2, int width, bool wrapText, int fontSize, bool bold, object backColor, XlHAlign horizontal, XlVAlign vertical, string value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (width != 0) r.ColumnWidth = width;
            r.WrapText = wrapText;
            r.Merge(false);
            r.Font.Size = fontSize;
            r.Font.Bold = bold;            
            r.Interior.ColorIndex = backColor;
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
        }
        public void SetText(object cell1, object cell2, int width, bool wrapText, int fontSize, bool bold, bool italic, object backColor, XlHAlign horizontal, XlVAlign vertical, string value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (width != 0) r.ColumnWidth = width;
            r.WrapText = wrapText;
            r.Merge(false);
            r.Font.Size = fontSize;
            r.Font.Bold = bold;
            r.Font.Italic = italic;
            r.Interior.ColorIndex = backColor;
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
        }
        public void SetText(object cell1, object cell2, int width, bool wrapText, int fontSize, bool bold, Color backColor, XlHAlign horizontal, XlVAlign vertical, string value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (width != 0) r.ColumnWidth = width;
            r.WrapText = wrapText;
            r.Merge(false);
            r.Font.Size = fontSize;
            r.Font.Bold = bold;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
        }
        public void SetText(object cell1, object cell2, int width, bool wrapText, int fontSize, bool bold, Color backColor, XlHAlign horizontal, XlVAlign vertical, string value, float rowHeight)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            if (width != 0) r.ColumnWidth = width;
            r.WrapText = wrapText;
            r.Merge(false);
            r.Font.Size = fontSize;
            r.Font.Bold = bold;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.HorizontalAlignment = horizontal;
            r.VerticalAlignment = vertical;
            r.Value2 = value;
            r.RowHeight = rowHeight;
        }
        public void SetText(object cell1, object cell2, bool bold, Color backColor, XlHAlign horizontal, string value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Merge(false);
            r.Font.Bold = bold;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.HorizontalAlignment = horizontal;
            r.Value2 = value;
        }
        public void SetText(object cell1, object cell2, bool bold, Color backColor, XlHAlign horizontal, string value, float rowHeight)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Merge(false);
            r.Font.Bold = bold;
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.HorizontalAlignment = horizontal;
            r.Value2 = value;
            r.RowHeight = rowHeight;
        }
        public void SetText(object cell1, object cell2, object[] value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.set_Value(Missing.Value, value);
        }

        public void SetText(object cell1, object cell2, object[] value, float rowHeight)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.set_Value(Missing.Value, value);
            r.RowHeight = rowHeight;

            //
            Range rc = (Range)r.Cells[1, 4];
            rc.WrapText = true;
            rc = (Range)r.Cells[1, 5];
            rc.WrapText = true;
            rc = (Range)r.Cells[1, 6];
            rc.WrapText = true;

            //Width
            rc = (Range)r.Cells[1, 1];
            rc.ColumnWidth = 4.57f;
            rc = (Range)r.Cells[1, 2];
            rc.ColumnWidth = 11.43f;
            rc = (Range)r.Cells[1, 3];
            rc.ColumnWidth = 15.86f;
            rc = (Range)r.Cells[1, 4];
            rc.ColumnWidth = 22f;
            rc = (Range)r.Cells[1, 6];
            rc.ColumnWidth = 11.57f;

            //15.71
            rc = (Range)r.Cells[1, r.Columns.Count];
            rc.ColumnWidth = 17.29f;
        }

        public void SetText(object cell1, object cell2, Color backColor, object[] value)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.Interior.Color = ColorTranslator.ToOle(backColor);
            r.set_Value(Missing.Value, value);
        }

        public void SetText(object cell1, object cell2, object[] color, object[] value, float rowHeight, int startColumn)
        {
            Range r = worksheet.get_Range(cell1, cell2);
            r.set_Value(Missing.Value, value);
            r.RowHeight = rowHeight;
            for (int rowIndex = 0; rowIndex < r.Rows.Count; rowIndex++)
            {
                for (int colIndex = 1; colIndex <= r.Columns.Count - startColumn; colIndex++)
                {
                   Range rx = (Range)r.Cells[rowIndex + 1, colIndex + startColumn];
                   Color rcolor = (Color)color[colIndex - 1];
                   if (rcolor != null)
                       rx.Interior.Color = ColorTranslator.ToOle(rcolor); 
                }
            }
            //
            Range rc = (Range) r.Cells[1, 4];
            rc.WrapText = true;
            rc = (Range)r.Cells[1, 5];
            rc.WrapText = true;
            rc = (Range)r.Cells[1, 6];
            rc.WrapText = true;

            //Width
            rc = (Range)r.Cells[1, 1];
            rc.ColumnWidth = 5f;
            rc = (Range)r.Cells[1, 2];
            rc.ColumnWidth = 12.86f;
            rc = (Range)r.Cells[1, 3];
            rc.ColumnWidth = 16.43f;
            rc = (Range)r.Cells[1, 4];
            rc.ColumnWidth = 21.57f;
            rc = (Range)r.Cells[1, 6];
            rc.ColumnWidth = 10.86f;

            //15.71
            rc = (Range)r.Cells[1, r.Columns.Count];
            rc.ColumnWidth = 15.71f;
        }

        public void FormatText(object cell, int position, int length, string fontStyle)
        {
            Range r = worksheet.get_Range(cell, cell);
            Characters chars = r.get_Characters(position, length);
            chars.Font.FontStyle = fontStyle;
        }
    }
}
