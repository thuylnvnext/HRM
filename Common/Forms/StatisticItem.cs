using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Preview;
using Common;
using System.IO;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Data;

namespace Common.Forms
{
    public partial class StatisticItem : XtraForm, IBandedGridViewParent
    {
        protected StatisticItemT statisticItem;
        protected ItemT item;
        private EditStatisticItem editStatisticItem;
        private string title = string.Empty;
        private BandedGridColumn column;
        private GridBand band;
        private int maxLevel = 0, level = 0;
        private bool group, landscape;
        private SetGridBand setGridBand;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        public StatisticItem()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        protected void InitGridView(string name, DataTable data, string title, bool group, bool landscape)
        {
            bgvStatisticItem.Name = name;
            bgvStatisticItem.Data = data;
            this.title = title;
            //for (int i = bgvStatisticItem.Bands.Count - 1; i > 1; i--)
            //{
            //    bgvStatisticItem.RemoveBand(bgvStatisticItem.Bands[i]);
            //}
            this.group = group;            
            this.landscape = landscape;
            statisticItem.GetContent();
            foreach (StatisticItemR tir in statisticItem)
            {
                if (tir.Value != string.Empty || tir.ComputedValue != string.Empty)
                {
                    level = AddColumn(tir, false);
                    if (level > maxLevel) maxLevel = level;
                }
                else
                    if (tir.ID != "0") AddBand(tir.ID, tir.Name);
            }
            grdStatisticItem.DataSource = bgvStatisticItem.Data;
            bgvStatisticItem.RestoreLayout(0, 0, Constant.language);
            if (!group)
            {
                grbDepartmentName.Visible = true;
                bcoDepartmentName.GroupIndex = -1;
                bcoDepartmentName.ColumnEdit = null;
                bcoDepartmentName.AppearanceCell.Options.UseFont = true;
                bcoDepartmentName.AppearanceCell.Font = new Font(bcoDepartmentName.AppearanceCell.Font, FontStyle.Regular);
            }
        }

        public void NextGridBand()
        {
            if (band.ParentBand != null)
            {
                if (band.Index + 1 < band.ParentBand.Children.Count)
                {
                    band = band.ParentBand.Children[band.Index + 1];
                    setGridBand.FillData(band);
                }
            }
            else
            {
                if (band.Index + 1 < bgvStatisticItem.Bands.Count)
                {
                    band = bgvStatisticItem.Bands[band.Index + 1];
                    setGridBand.FillData(band);
                }
            }
        }

        public virtual void ShowData(string departmentIDList, bool check)
        {
        }

        public int AddColumn(StatisticItemR tir, bool edit)
        {
            StatisticItemR tir_;
            GridBand gridBand, parentBand;
            GridBandCollection gbc = new GridBandCollection(bgvStatisticItem, bgvStatisticItem.Bands[0]);
            DataColumn dc;
            int level = 0;

            if (bgvStatisticItem.Bands[tir.ParentID] == null)
            {
                tir_ = statisticItem.FindByID(tir.ParentID);
                do
                {
                    parentBand = bgvStatisticItem.FindByName(bgvStatisticItem.Bands, tir_.ID);
                    if (parentBand != null) break;
                    if (!tir_.IsParentIDNull() && tir_.ParentID != "0")
                    {
                        gbc.Add(bgvStatisticItem.AddBand(tir_.ID, tir_.Name, string.Empty, 1));
                        tir_ = statisticItem.FindByID(tir_.ParentID);
                    }
                } while (!tir_.IsParentIDNull() && tir_.ParentID != "0");
                if (parentBand == null)
                {
                    parentBand = bgvStatisticItem.FindByName(bgvStatisticItem.Bands, tir_.ID);
                    if (parentBand == null && !tir_.IsParentIDNull()) parentBand = bgvStatisticItem.AddBand(tir_.ID, tir_.Name, string.Empty, 1, bgvStatisticItem.Bands);
                }
                level = gbc.Count + 1;
                for (int i = gbc.Count - 1; i >= 0; i--)
                {
                    parentBand = parentBand.Children.Add(gbc[i]);
                }
            }
            else
                parentBand = bgvStatisticItem.Bands[tir.ParentID];
            if (maxLevel < level) maxLevel = level;
            gridBand = bgvStatisticItem.AddBand(tir.ID, tir.Name, tir.IsValueNull() ? string.Empty : tir.Value, 1, parentBand == null ? bgvStatisticItem.Bands : parentBand.Children);

            BandedGridColumn column = new BandedGridColumn();
            column.Name = tir.ID;
            column.FieldName = tir.ID;
            column.Caption = tir.Name;
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
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "#,##0.#;-#,##0; ";
            if (bgvStatisticItem.Data != null && bgvStatisticItem.Data.Columns[tir.ID] == null)
            {
                dc = new DataColumn(tir.ID, Type.GetType("System.Decimal"));
                bgvStatisticItem.Data.Columns.Add(dc);
            }    
            GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
            summaryItem.ShowInGroupColumnFooter = column;
            summaryItem.FieldName = tir.ID;
            summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            summaryItem.DisplayFormat = "{0:#,##0;;}";
            bgvStatisticItem.GroupSummary.Add(summaryItem);

            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.FieldName = tir.ID;
            column.SummaryItem.DisplayFormat = "{0:#,##0;;}";

            return level;
        }

        public void AddBand(string name, string caption)
        {
            bgvStatisticItem.AddBand(name, caption, string.Empty, 1, bgvStatisticItem.Bands);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "STATISTICITEM_PAGE" }, new string[] { TitleTable.GetValue("STATISTICITEM_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "EXPORT_PAGEGROUP", "OPTION_PAGEGROUP" }, new string[] { TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language), TitleTable.GetValue("OPTION_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "PREVIEW", imlFunction.Images[0], TitleTable.GetValue("PREVIEW", Constant.language), new ItemClickEventHandler(bbiPreview_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "TO_EXCEL", imlFunction.Images[1], TitleTable.GetValue("TO_EXCEL", Constant.language), new ItemClickEventHandler(bbiToExcel_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "SAVE_LAYOUT", imlFunction.Images[2], TitleTable.GetValue("SAVE_LAYOUT", Constant.language), new ItemClickEventHandler(bbiSaveLayout_ItemClick));
            IMdiParent mdiParent = (IMdiParent)MdiParent;
            ribbon = mdiParent.GetRibbonControl;
            ribbon.PageCategories.Add(pageCategory);
            selectedPage = ribbon.SelectedPage;
            ribbon.SelectedPage = pageCategory.Pages[0];
        }
        
        private void RemovePageCategory()
        {
            ribbon.PageCategories.Remove(pageCategory);
            ribbon.SelectedPage = selectedPage;
        }

        private void StatisticItem_Load(object sender, EventArgs e)
        {
            try
            {
                DepartmentTable department = new DepartmentTable();
                department.GetFullPath(Constant.currentUser.Name);
                foreach (DepartmentRow dr in department)
                {
                    icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr["FullPath"].ToString(), dr["FullPath"], 0));
                }
                AddPageCategory();
            }
            catch
            {
            }
        }

        private void bgvStatisticItem_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void bbiToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            sfdExportToExcel.FileName = "Statistic " + dedWorkingDay.DateTime.ToString("dd-MM-yyyy");
            if (sfdExportToExcel.ShowDialog() == DialogResult.OK)
            {
                WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                waitDialog.Show();
                Application.DoEvents();
                string[] departments = Constant.departmentIDList.Split(new char[] { ',' });
                Classes.StatisticItem statisticItem = new Classes.StatisticItem(sfdExportToExcel.FileName, string.Format("{0}", dedWorkingDay.DateTime.ToString("dd-MM-yyyy")), "Tahoma", bgvStatisticItem, departments.Length, title, dedWorkingDay.DateTime);
                statisticItem.FillData(maxLevel);
                waitDialog.Close();
            }
        }

        private void StatisticItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void bbiSaveLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bgvStatisticItem.SaveLayout(0, 0, Constant.language))
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnBestFitItemClick(object sender, EventArgs e)
        {
            bgvStatisticItem.FocusedColumn.BestFit();
        }

        private void OnFormatItemClick(object sender, EventArgs e)
        {            
        }

        private void OnAddColumnItemClick(object sender, EventArgs e)
        {
            new AddStatisticItem(this, item, statisticItem, band == null ? "0" : band.Name).ShowDialog();
        }

        private void OnEditColumnItemClick(object sender, EventArgs e)
        {
            editStatisticItem = new EditStatisticItem(this, item, statisticItem);
            editStatisticItem.Show();
            Application.DoEvents();
            editStatisticItem.ShowStatisticItem(column, null);
        }

        private void OnAddBandItemClick(object sender, EventArgs e)
        {
            new AddStatisticItem(this, null, statisticItem, "0").ShowDialog();
        }

        private void OnEditBandItemClick(object sender, EventArgs e)
        {
            editStatisticItem = new EditStatisticItem(this, item, statisticItem);
            editStatisticItem.Show();
            Application.DoEvents();
            editStatisticItem.ShowStatisticItem(null, band);
        }

        private void OnDeleteColumnItemClick(object sender, EventArgs e)
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_TOTALTEM", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                StatisticItemR tir = statisticItem.FindByID(bgvStatisticItem.FocusedColumn.FieldName);
                if (tir != null)
                {
                    tir.Delete();
                    statisticItem.Delete();
                    ShowData(Constant.departmentIDList, true);
                }
            }
        }

        private void bgvStatisticItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (editStatisticItem == null && (e.Button & MouseButtons.Right) != 0)
            {
                BandedGridView view = (BandedGridView)sender;
                BandedGridHitInfo hitInfo;
                if (view == null) return;
                column = null;
                Point point = view.GridControl.PointToClient(Control.MousePosition);
                hitInfo = view.CalcHitInfo(new Point(point.X, point.Y));
                band = hitInfo.Band;
                if (band != null && hitInfo.InBandPanel && band.Columns.Count > 0)
                {
                    column = band.Columns[0];
                    bgvStatisticItem.FocusedColumn = column;
                }
                DevExpress.XtraGrid.Menu.GridViewColumnMenu menu = new DevExpress.XtraGrid.Menu.GridViewColumnMenu(view);
                menu.Init(column);
                menu.Items.Clear();
                menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Thêm cột", new EventHandler(OnAddColumnItemClick), imlGroup.Images[1]));
                menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Sửa cột", new EventHandler(OnEditColumnItemClick)));                
                menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Thêm nhóm", new EventHandler(OnAddBandItemClick)));
                menu.Items[2].BeginGroup = true;
                menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Sửa nhóm", new EventHandler(OnEditBandItemClick)));                
                menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Xóa cột", new EventHandler(OnDeleteColumnItemClick)));
                menu.Items[4].BeginGroup = true;
                menu.Show(new Point(e.X, e.Y));
            }
            if (editStatisticItem != null && (e.Button & MouseButtons.Right) != 0)
            {
                BandedGridView view = (BandedGridView)sender;
                BandedGridHitInfo hitInfo;
                if (view == null) return;
                column = null;
                Point point = view.GridControl.PointToClient(Control.MousePosition);
                hitInfo = view.CalcHitInfo(new Point(point.X, point.Y));
                band = hitInfo.Band;
                if (band != null && hitInfo.InBandPanel && band.Columns.Count > 0)
                {
                    column = band.Columns[0];
                    bgvStatisticItem.FocusedColumn = column;
                    band = null;
                }

                editStatisticItem.ShowStatisticItem(column, band);
            }
        }

        private void bgvStatisticItem_DoubleClick(object sender, EventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hitInfo;
            if (view == null) return;
            Point point = view.GridControl.PointToClient(Control.MousePosition);
            hitInfo = view.CalcHitInfo(new Point(point.X, point.Y));
            band = hitInfo.Band;
            if (band != null && hitInfo.InBandPanel && editStatisticItem != null) editStatisticItem.SetComputedValue(band.Columns[0].Caption);
            if (band != null && hitInfo.InBandPanel)
            {
                setGridBand = new SetGridBand(band, this);
                setGridBand.ShowDialog();
            }
        }

        private void bbiPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reports.StatisticItem _statisticItem = new Reports.StatisticItem(bgvStatisticItem, dedWorkingDay.DateTime, title, group);
            _statisticItem.Landscape = landscape;
            _statisticItem.DataSource = bgvStatisticItem.Data;
            _statisticItem.PrintingSystem.PreviewFormEx.LookAndFeel.UseDefaultLookAndFeel = false;
            _statisticItem.PrintingSystem.PreviewFormEx.LookAndFeel.SkinName = Constant.skin;
            _statisticItem.PrintingSystem.PreviewFormEx.Owner = this;
            _statisticItem.ShowPreview();
        }
    }
}
