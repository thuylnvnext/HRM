using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraPrinting;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace Personnel.Forms
{
    public partial class AnnualLeave : XtraForm, IShowData
    {
        private AnnualLeaveTable annualLeave = new AnnualLeaveTable();
        private bool change = false;
        private byte month;
        private short year;
        private RibbonControl ribbon;
        private PageCategory pageCategory;
        private RibbonPage selectedPage;

        public AnnualLeave()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "ANNUALLEAVE_PAGE" }, new string[] { TitleTable.GetValue("ANNUALLEAVE_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "UPDATE_PAGEGROUP", "EXPORT_PAGEGROUP" }, new string[] { TitleTable.GetValue("UPDATE_PAGEGROUP", Constant.language), TitleTable.GetValue("EXPORT_PAGEGROUP", Constant.language) });
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "GETDAYSOFMONTH", imlFunction.Images[0], TitleTable.GetValue("GETDAYSOFMONTH", Constant.language), new ItemClickEventHandler(bbiGetDaysOfMonth_ItemClick));            
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "GETDAYSOFYEAR", imlFunction.Images[1], TitleTable.GetValue("GETDAYSOFYEAR", Constant.language), new ItemClickEventHandler(bbiGetDaysOfYear_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "SAVE", imlFunction.Images[2], TitleTable.GetValue("SAVE", Constant.language), new ItemClickEventHandler(bbiSave_ItemClick));
            pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[1], "EXPORT", imlFunction.Images[2], TitleTable.GetValue("EXPORT", Constant.language), new ItemClickEventHandler(bbiExport_ItemClick));
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

        private GridBand InsertBand(string name, string caption, int position, GridBandCollection gbc)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.Width = 50;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gridBand.AppearanceHeader.Options.UseFont = true;
            gridBand.AppearanceHeader.Font = new Font(gridBand.AppearanceHeader.Font, FontStyle.Bold);
            gbc.Insert(position, gridBand);

            return gridBand;
        }

        private BandedGridColumn InsertColumn(string name, string caption, int position, GridBandCollection gbc)
        {
            GridBand gridBand = InsertBand("grb" + name, caption, position, gbc);
            BandedGridColumn column = new BandedGridColumn();
            column.Name = "bco" + name;
            column.FieldName = name;
            column.Caption = caption;
            column.Width = 250;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
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
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "#,##0.#;;-";

            return column;
        }

        private void SetGridView()
        {            
            DateTime fromDate, toDate, d;
            int position = 8, bandCount = bgvAnnualLeave.Bands.Count - 8;

            for (int i = 1; i <= bandCount; i++)
            {
                annualLeave.Columns.Remove(bgvAnnualLeave.Bands[8].Columns[0].FieldName);
                bgvAnnualLeave.Columns.Remove(bgvAnnualLeave.Bands[8].Columns[0]);                
                bgvAnnualLeave.Bands.RemoveAt(8);                
            }

            fromDate = new DateTime(year, 1, 1);             
            toDate = new DateTime(year, month, 1);
            d = fromDate;
            while (d <= toDate)
            {
                InsertColumn(d.Month.ToString(), "T" + d.Month.ToString(), position++, bgvAnnualLeave.Bands);
                d = d.AddMonths(1);
            }
        }

        public void ShowData(string departmentIDList, bool check)
        {
            if (check)
                annualLeave.GetListByDepartmentID(departmentIDList, month, year);
            else
                annualLeave.DeleteByDepartmentID(departmentIDList);
            grdAnnualLeave.DataSource = annualLeave;
            bgvAnnualLeave.BestFitColumns();
        }

        private void AnnualLeave_Load(object sender, EventArgs e)
        {
            for (int i = 2008; i <= 2020; i++)
            {
                cboYear.Properties.Items.Add(i);
            }
            cboMonth.SelectedIndex = DateTime.Today.Month - 1;
            change = true;
            cboYear.SelectedIndex = DateTime.Today.Year - 2008;

            AddPageCategory();
        }

        private void bgvAnnualLeave_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData) e.Value = e.RowHandle + 1;
            if (e.Column.FieldName == "Used" && e.IsGetData)
            {
                decimal value = 0;
                for (int i = 1; i <= month; i++)
                {
                    value += Convert.ToDecimal(bgvAnnualLeave.GetRowCellValue(e.RowHandle, i.ToString()));
                }
                e.Value = value;
            }
            if (e.Column.FieldName == "Remain" && e.IsGetData) e.Value = Convert.ToDecimal(bgvAnnualLeave.GetRowCellValue(e.RowHandle, "0")) - Convert.ToDecimal(bgvAnnualLeave.GetRowCellValue(e.RowHandle, "Used"));
        }

        private void bbiSave_ItemClick(object sender, EventArgs e)
        {
            bool insert, update, delete;
            AnnualLeaveTable _annualLeave = new AnnualLeaveTable();
            AnnualLeaveRow alr, _alr;
            int rowCount = annualLeave.Count, r = 0;
            decimal value;

            _annualLeave.GetDaysByYear(Convert.ToInt16(cboYear.Text));
            while (r < rowCount)
            {
                alr = annualLeave[r++];
                if (alr.RowState == DataRowState.Modified)
                {
                    if (Convert.ToDecimal(alr["0"]) != 0)
                    {
                        value = Convert.ToDecimal(alr["0"]);
                        _alr = _annualLeave.GetInfoByValues(alr.EmployeeID, 0, alr.Year);
                        if (_alr != null)
                        {
                            if (_alr.IsValueNull() || _alr.Value != value) _alr.Value = value;
                        }
                        else
                            _annualLeave.AddAnnualLeaveRow(alr.EmployeeID, 0, alr.Year, value);
                    }
                    else
                    {
                        _alr = _annualLeave.GetInfoByValues(alr.EmployeeID, 0, alr.Year);
                        if (_alr != null) _alr.Delete();
                    }
                }
            }
            insert = _annualLeave.Insert();
            update = _annualLeave.Update();
            delete = _annualLeave.Delete();
            if (insert && update && delete)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_ANNUALLEAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_ANNUALLEAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bbiExport_ItemClick(object sender, EventArgs e)
        {
            if (sfdExportToExcel.ShowDialog() == DialogResult.OK) bgvAnnualLeave.ExportToXls(sfdExportToExcel.FileName, new DevExpress.XtraPrinting.XlsExportOptions(DevExpress.XtraPrinting.TextExportMode.Text, true));
        }

        private void bgvAnnualLeave_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "0") bgvAnnualLeave.SetRowCellValue(e.RowHandle, "Remain", Convert.ToDecimal(e.Value) - Convert.ToDecimal(bgvAnnualLeave.GetRowCellValue(e.RowHandle, "Used")));
        }

        private void bbiGetDaysOfMonth_ItemClick(object sender, EventArgs e)
        {
            AnnualLeaveTable.GetDaysOfMonth(Constant.departmentIDList, Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
            ShowData(Constant.departmentIDList, true);
        }

        private void bbiGetDaysOfYear_ItemClick(object sender, EventArgs e)
        {
            AnnualLeaveTable.GetDaysOfYear(Constant.departmentIDList, Convert.ToInt16(cboYear.Text));
            ShowData(Constant.departmentIDList, true);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change) 
            {
                month = Convert.ToByte(cboMonth.Text);
                year = Convert.ToInt16(cboYear.Text);
                SetGridView();
                ShowData(Constant.departmentIDList, true);
            }
        }

        private void AnnualLeave_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void AnnualLeave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                annualLeave.Clear();
                ShowData(Constant.departmentIDList, true);
            }
        }
    }
}
