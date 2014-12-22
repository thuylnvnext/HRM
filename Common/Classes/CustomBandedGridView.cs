using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.BandedGrid;
using Database;
using System.Data;
using System.Drawing;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Drawing;

namespace Common
{
    public class CustomBandedGridView : BandedGridView
    {
        private int maxLevel = 0;
        private ItemGroupT groupTable;
        private DataTable data;
        private bool allowFilter;

        public CustomBandedGridView()
            : base()
        {
            CustomDrawBandHeader += new BandHeaderCustomDrawEventHandler(CustomBandedGridView_CustomDrawBandHeader);
            MouseDown += new System.Windows.Forms.MouseEventHandler(CustomBandedGridView_MouseDown);
            ShowFilterPopupListBox += new DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventHandler(CustomBandedGridView_ShowFilterPopupListBox);
        }

        private void CustomBandedGridView_ShowFilterPopupListBox(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventArgs e)
        {
            string blanks = GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterBlanks), nonBlanks = GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterNonBlanks);
            object item;
            int i = 0;
            while (i < e.ComboBox.Items.Count)
            {
                item = e.ComboBox.Items[i++];
                if (!(item is FilterItem)) continue;
                if (((FilterItem)item).Text == blanks || ((FilterItem)item).Text == nonBlanks)
                {
                    string filterText;
                    if (((FilterItem)item).Text == blanks)
                        filterText = "[" + e.Column.FieldName + "] " + "Is Null Or " + "[" + e.Column.FieldName + "] = ''";
                    else
                        filterText = "[" + e.Column.FieldName + "] " + "Is Not Null And " + "[" + e.Column.FieldName + "] != ''";
                    ColumnFilterInfo filterInfo = new ColumnFilterInfo(ColumnFilterType.Custom, null, filterText, filterText);
                    FilterItem _item = new FilterItem(((FilterItem)item).Text, filterInfo);
                    int index = e.ComboBox.Items.IndexOf(item);
                    e.ComboBox.Items.Remove(item);
                    e.ComboBox.Items.Insert(index, _item);
                    if (((FilterItem)item).Text == nonBlanks) break;
                }
            }
        }

        public bool AllowFilter
        {
            set
            {
                allowFilter = (bool)value;
            }
            get
            {
                return allowFilter;
            }
        }

        private void CustomBandedGridView_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            if (e.Band.HasChildren || !allowFilter) return;
            for (int i = 0; i < e.Info.InnerElements.Count; i++)
            {
                if (e.Info.InnerElements[i].ElementInfo is DevExpress.XtraEditors.Drawing.GridFilterButtonInfoArgs) return;
            }

            GridSmartSkinFilterButtonPainter painter = new GridSmartSkinFilterButtonPainter(LookAndFeel);
            GridFilterButtonInfoArgs filterButtonInfo = new GridFilterButtonInfoArgs();
            filterButtonInfo.Cache = e.Cache;
            filterButtonInfo.Graphics = e.Graphics;

            DrawElementInfo elementInfo = e.Info.InnerElements.Add(painter, filterButtonInfo);
            elementInfo.RequireTotalBounds = true;
            e.Info.InnerElements.CalcBounds(e.Info, e.Cache, e.Painter.GetObjectClientRectangle(e.Info), e.Bounds);

            Rectangle captionRect = e.Info.CaptionRect;
            captionRect.Width -= elementInfo.ElementInfo.Bounds.Width;
            e.Info.CaptionRect = captionRect;
        }

        private void CustomBandedGridView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hitInfo;
            if (view == null || !allowFilter) return;
            if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
            {
                hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                GridBand band = hitInfo.Band;
                if (band != null && hitInfo.InBandPanel)
                {
                    BandedGridViewInfo viewInfo = (BandedGridViewInfo)view.GetViewInfo();
                    DevExpress.Utils.Drawing.DrawElementInfo elementInfo = viewInfo.BandsInfo.FindBand(band).InnerElements.Find(typeof(GridFilterButtonInfoArgs));
                    if (elementInfo != null)
                    {
                        GridFilterButtonInfoArgs filterButtonInfo = (GridFilterButtonInfoArgs)elementInfo.ElementInfo;
                        if (filterButtonInfo != null && filterButtonInfo.Bounds.Contains(e.Location))
                        {
                            if (band.Columns.Count == 1)
                            {
                                band.Columns[0].OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
                                view.ShowFilterPopup(band.Columns[0]);
                            }
                            else
                            {
                                view.FocusedColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
                                view.ShowFilterPopup(view.FocusedColumn);
                            }
                            DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        }
                    }
                }
            }
        }

        public ItemGroupT GroupTable
        {
            set
            {
                groupTable = value;
            }
        }

        public DataTable Data
        {
            set
            {
                data = value;
            }
            get
            {
                return data;
            }
        }

        public int BandHeight(GridBand band)
        {
            BandedGridViewInfo vInfo = GetViewInfo() as BandedGridViewInfo;
            GridBandInfoArgs grbInfoArgs = vInfo.BandsInfo.FindBand(band);
            if (grbInfoArgs == null)
            {
                if (band.Columns.Count == 0)
                    MakeColumnVisible(FindFirstColumn(band));
                else
                    MakeColumnVisible(band.Columns[0]);
                grbInfoArgs = vInfo.BandsInfo.FindBand(band);
            }
            return grbInfoArgs.Bounds.Height;
        }

        private void FindColumn(GridBand grb, ref BandedGridColumn bgc)
        {
            if (grb.Columns.Count == 0)
                FindColumn(grb.Children[0], ref bgc);
            else
                bgc = grb.Columns[0];
        }

        private BandedGridColumn FindFirstColumn(GridBand grb)
        {
            BandedGridColumn bgc = null;
            FindColumn(grb, ref bgc);

            return bgc;
        }

        private void FindGridBand(GridBandCollection gbc, string name, ref GridBand gridBand)
        {
            foreach (GridBand grb in gbc)
            {
                if (grb.Name == name) gridBand = grb;
                if (grb.Children.Count > 0) FindGridBand(grb.Children, name, ref gridBand);
            }
        }

        public GridBand FindByName(GridBandCollection gbc, string name)
        {
            GridBand grb = null;
            FindGridBand(gbc, name, ref grb);

            return grb;
        }

        public GridBand AddBand(string name, string caption, string toolTip, int rowCount, GridBandCollection gbc)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.ToolTip = toolTip;
            gridBand.RowCount = rowCount;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.Options.UseFont = true;
            gridBand.AppearanceHeader.Font = new Font(gridBand.AppearanceHeader.Font, FontStyle.Bold);
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gbc.Add(gridBand);
            return gridBand;
        }

        public GridBand AddBand(string name, string caption, string toolTip, int rowCount)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.ToolTip = toolTip;
            gridBand.RowCount = rowCount;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.Options.UseFont = true;
            gridBand.AppearanceHeader.Font = new Font(gridBand.AppearanceHeader.Font, FontStyle.Bold);
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            return gridBand;
        }

        private GridBand AddBand(string name, string caption, string toolTip, int rowCount, DevExpress.XtraGrid.Columns.FixedStyle _fixed, GridBandCollection gbc)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.ToolTip = toolTip;
            gridBand.Width = 50;
            gridBand.RowCount = rowCount;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gridBand.AppearanceHeader.Options.UseFont = true;
            gridBand.AppearanceHeader.Font = new Font(gridBand.AppearanceHeader.Font, FontStyle.Bold);
            gridBand.Fixed = _fixed;
            gbc.Add(gridBand);
            return gridBand;
        }

        public BandedGridColumn AddColumn(string name, string caption, Type type, GridBandCollection gbc, bool bound, bool allowEdit, HorzAlignment alignment)
        {
            GridBand gridBand = AddBand("grb" + name, caption, string.Empty, 1, DevExpress.XtraGrid.Columns.FixedStyle.None, gbc);
            BandedGridColumn column = new BandedGridColumn();
            DataColumn dc;
            column.Name = "bco" + name;
            column.Caption = caption;
            column.OptionsColumn.AllowEdit = true;
            column.OptionsColumn.ReadOnly = false;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            if (bound && type.Name == "Decimal")
            {
                column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
                column.FieldName = name;
                column.OptionsColumn.AllowEdit = allowEdit;
                if (data != null && data.Columns[name] == null)
                {
                    dc = new DataColumn(name, Type.GetType("System.Decimal"));
                    data.Columns.Add(dc);
                }
            }
            else
            {
                column.FieldName = name;
                column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                column.OptionsColumn.AllowEdit = allowEdit;
                column.OptionsColumn.ReadOnly = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            }
            column.OwnerBand = gridBand;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = alignment;

            if (type.Name == "Decimal")
            {
                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.ShowInGroupColumnFooter = column;
                summaryItem.FieldName = name;
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:#,##0;;}";
                GroupSummary.Add(summaryItem);

                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "#,##0;;";
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.FieldName = name;
                column.SummaryItem.DisplayFormat = "{0:#,##0;;}";
            }

            return column;
        }

        public int AddColumn(ItemR item, bool edit)
        {
            ItemGroupR igr;
            GridBand gridBand, parentBand;
            GridBandCollection gbc = new GridBandCollection(this, Bands[0]);
            DataColumn dc;
            int level = 0;

            if (Bands[item.ItemGroupID] == null)
            {
                igr = groupTable.FindByID(item.ItemGroupID);
                do
                {
                    parentBand = FindByName(Bands, igr.ID);
                    if (parentBand != null) break;
                    if (!igr.IsParentIDNull() && igr.ParentID != "ROOT")
                    {
                        gbc.Add(AddBand(igr.ID, igr.Name, string.Empty, 1));
                        igr = groupTable.FindByID(igr.ParentID);
                    }
                } while (!igr.IsParentIDNull() && igr.ParentID != "ROOT");
                if (parentBand == null)
                {
                    parentBand = FindByName(Bands, igr.ID);
                    if (parentBand == null && !igr.IsParentIDNull()) parentBand = AddBand(igr.ID, igr.Name, string.Empty, 1, Bands);

                    //edit
                    if (item.Name.Split('|').Length == 2)
                    {
                        if (parentBand != null && parentBand.Children != null)
                            parentBand = AddBand(item.Name.Split('|')[0], item.Name.Split('|')[0], item.Name.Split('|')[0], 1, parentBand.Children);
                        else
                        {
                            parentBand = FindByName(Bands, item.Name.Split('|')[0]);
                            if (parentBand == null)
                                parentBand = AddBand(item.Name.Split('|')[0], item.Name.Split('|')[0], item.Name.Split('|')[0], 1, Bands);
                        }
                    }
                }
                level = gbc.Count + 1;
                for (int i = gbc.Count - 1; i >= 0; i--)
                {
                    parentBand = parentBand.Children.Add(gbc[i]);
                }
            }
            else
            {
                parentBand = Bands[item.ItemGroupID];

                //edit
                if (item.Name.Split('|').Length == 2)
                {
                    String ID = item.Name.Split('|')[0];
                    GridBand gb = FindByName(Bands, item.Name.Split('|')[0]);
                    if (gb == null)
                        parentBand = AddBand(ID, ID, ID, 1, parentBand.Children);
                    else
                        parentBand = gb;
                }
            }
            if (maxLevel < level) maxLevel = level;
            String caption = String.Empty;
            if (item.Name.Split('|').Length == 2)
                caption = item.Name.Split('|')[1];
            else
                caption = item.Name;

            gridBand = AddBand(item.ID, caption, item.IsValueNull() ? string.Empty : item.Value, 1, parentBand == null ? Bands : parentBand.Children);

            BandedGridColumn column = new BandedGridColumn();
            column.Name = item.ID;
            column.FieldName = item.ID;
            column.Caption = item.Name;
            column.OptionsColumn.AllowEdit = edit;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = gridBand;
            column.AppearanceCell.Options.UseTextOptions = true;
            switch (item.DataType)
            {
                case "Char":
                    if (data.Columns[item.ID] == null)
                    {
                        dc = new DataColumn(item.ID, Type.GetType("System.Char"));
                        data.Columns.Add(dc);
                    }
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    break;
                case "Number":
                case "Formula":
                    if (data.Columns[item.ID] == null)
                    {
                        dc = new DataColumn(item.ID, Type.GetType("System.Decimal"));
                        data.Columns.Add(dc);
                    }
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    break;
                case "DateTime":
                    if (data.Columns[item.ID] == null)
                    {
                        dc = new DataColumn(item.ID, Type.GetType("System.DateTime"));
                        data.Columns.Add(dc);
                    }
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    break;
                case "Boolean":

                    if (data.Columns[item.ID] == null)
                    {
                        dc = new DataColumn(item.ID);
                        data.Columns.Add(dc);
                    }
                    break;
                case "Text":
                case "TextFormula":
                    if (data.Columns[item.ID] == null)
                    {
                        dc = new DataColumn(item.ID, Type.GetType("System.String"));
                        data.Columns.Add(dc);
                    }
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    break;
            }
            FormatColumn(column, item);

            return level;
        }

        public BandedGridColumn AddColumn(string name, string caption, GridBandCollection gbc)
        {
            GridBand gridBand = AddBand("grb" + name, caption, string.Empty, 1, gbc);
            BandedGridColumn column = new BandedGridColumn();
            column.Name = "bco" + name;
            column.FieldName = name;
            column.Caption = caption;
            column.OptionsColumn.AllowEdit = true;
            column.OptionsColumn.ReadOnly = false;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = gridBand;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            return column;
        }

        public void FormatColumn(BandedGridColumn column, ItemR item)
        {
            switch (item.DataType)
            {
                case "Number":
                case "Formula":
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "#,##0." + new string('#', item.Rounding > 0 ? item.Rounding : 0) + ";-#,##0;0";
                    column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    column.SummaryItem.FieldName = item.ID;
                    column.SummaryItem.DisplayFormat = "{0:#,##0." + new string('#', item.Rounding > 0 ? item.Rounding : 0) + ";-#,##0;0}";
                    GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                    summaryItem.ShowInGroupColumnFooter = column;
                    summaryItem.FieldName = item.ID;
                    summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    summaryItem.DisplayFormat = "{0:#,##0." + new string('#', item.Rounding > 0 ? item.Rounding : 0) + ";-#,##0;0}";
                    GroupSummary.Add(summaryItem);
                    break;
                case "Boolean":
                    DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                    checkEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
                    checkEdit.ValueChecked = "1";
                    checkEdit.ValueUnchecked = "0";
                    column.ColumnEdit = checkEdit;
                    break;
            }
        }

        public void RemoveBand(GridBand grb)
        {
            if (grb.Children.Count == 0)
            {
                for (int col = grb.Columns.Count - 1; col >= 0; col--)
                {
                    Columns.Remove(grb.Columns[col]);
                }
            }
            else
            {
                for (int i = grb.Children.Count - 1; i >= 0; i--)
                {
                    RemoveBand(grb.Children[i]);
                }
            }
            if (grb.ParentBand == null)
                Bands.Remove(grb);
            else
                grb.ParentBand.Children.Remove(grb);
        }

        public void RestoreLayout(string language)
        {
            string d = LayoutTable.GetValueByItem(Name, 0, 0, language);
            if (d != string.Empty)
            {
                Stream s = new MemoryStream();
                StreamWriter w = new StreamWriter(s);
                w.AutoFlush = true;
                w.Write(d);
                s.Position = 0;
                RestoreLayoutFromStream(s);
            }
        }

        public void RestoreLayout(byte month, Int16 year, string language)
        {
            string d = LayoutTable.GetValueByItem(Name, month, year, language);
            if (d != string.Empty)
            {
                Stream s = new MemoryStream();
                StreamWriter w = new StreamWriter(s);
                w.AutoFlush = true;
                w.Write(d);
                s.Position = 0;
                RestoreLayoutFromStream(s);
            }
        }

        public bool SaveLayout(string language)
        {
            bool retVal = true;
            Stream s = new MemoryStream();
            SaveLayoutToStream(s);
            s.Position = 0;
            StreamReader r = new StreamReader(s);

            LayoutTable layout = new LayoutTable();
            LayoutRow lr;
            layout.GetContent();
            lr = layout.FindByPrimaryKey(Name, 0, 0, language);
            if (lr == null)
            {
                layout.AddLayoutRow(Name, 0, 0, language, r.ReadToEnd());
                retVal = layout.Insert();
            }
            else
            {
                lr.Value = r.ReadToEnd();
                retVal = layout.Update();
            }

            return retVal;
        }

        public bool SaveLayout(byte month, Int16 year, string language)
        {
            bool retVal = true;
            Stream s = new MemoryStream();
            SaveLayoutToStream(s);
            s.Position = 0;
            StreamReader r = new StreamReader(s);

            LayoutTable layout = new LayoutTable();
            LayoutRow lr;
            layout.GetContent();
            lr = layout.FindByPrimaryKey(Name, month, year, language);
            if (lr == null)
            {
                layout.AddLayoutRow(Name, month, year, language, r.ReadToEnd());
                retVal = layout.Insert();
            }
            else
            {
                lr.Value = r.ReadToEnd();
                retVal = layout.Update();
            }

            return retVal;
        }
    }
}
