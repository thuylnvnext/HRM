using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars; 

namespace Common.Forms
{
    public partial class RegisterItem : XtraForm, IShowData, IGridViewParent
    {
        protected RegisterItemT registerItem;
        private EmployeeTable employee = new EmployeeTable();        
        protected List<int> checkedRows = new List<int>();
        private SetGridColumn setGridColumn;
        private GridColumn column;
        private string IDs = string.Empty;
        private bool show = false, save = true;
        private RibbonControl ribbon;
        protected PageCategory pageCategory;
        private RibbonPage selectedPage;
        protected BarButtonItem bbiSave, bbiDelete;

        public RegisterItem()
        {
            InitializeComponent();            
            Utility.SetSkin(this);
        }

        private void AddPageCategory()
        {
            string text = TitleTable.GetValue(Name, Constant.language);
            if (text != string.Empty) Text = text;
            pageCategory = new PageCategory(text, Color.YellowGreen);
            pageCategory.AddPage(new string[] { "REGISTERITEM_PAGE" }, new string[] { TitleTable.GetValue("REGISTERITEM_PAGE", Constant.language) });
            pageCategory.AddPageGroup(pageCategory.Pages[0], new string[] { "UPDATE_PAGEGROUP" }, new string[] { TitleTable.GetValue("UPDATE_PAGEGROUP", Constant.language) });
            bbiSave = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "SAVE", imlFunction.Images[0], TitleTable.GetValue("SAVE", Constant.language), new ItemClickEventHandler(bbiSave_ItemClick));
            bbiDelete = pageCategory.AddBarButtonItem(pageCategory.Pages[0].Groups[0], "DELETE", imlFunction.Images[1], TitleTable.GetValue("DELETE", Constant.language), new ItemClickEventHandler(bbiDelete_ItemClick));

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

        private GridColumn AddColumn(DataColumn dc)
        {
            GridColumn column = new GridColumn();

            grvRegisterItem.Columns.Add(column);
            column.Name = dc.ColumnName;
            column.FieldName = dc.ColumnName;
            column.Caption = dc.Caption;
            column.OptionsColumn.AllowEdit = true;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.OptionsFilter.AllowFilter = false;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            return column;
        }

        private void RestoreLayout()
        {
            string d = LayoutTable.GetValueByItem(grvRegisterItem.Name, 0, 0, Constant.language);
            if (d != string.Empty)
            {
                Stream s = new MemoryStream();
                StreamWriter w = new StreamWriter(s);
                w.AutoFlush = true;
                w.Write(d);
                s.Position = 0;
                grvRegisterItem.RestoreLayoutFromStream(s);
            }
        }

        public void NextGridColumn()
        {
            if (column.AbsoluteIndex + 1 < grvRegisterItem.Columns.Count)
            {
                column = grvRegisterItem.Columns[column.AbsoluteIndex + 1];
                setGridColumn.FillData(column);
            }
        }

        public string GetName()
        {
            return grvRegisterItem.Name;
        }

        protected void InitItem(string name, bool save)
        {
            GridColumn grc;
            grvRegisterItem.Name = name;
            this.save = save;
            foreach (DataColumn dc in registerItem.GetColumns())
            {
                if (grvRegisterItem.Columns.ColumnByFieldName(dc.ColumnName) == null)
                {
                    grc = AddColumn(dc);
                    if (grc.FieldName == "CreatedUserName" || grc.FieldName == "CreatedDate" || grc.FieldName == "ModifiedUserName" || grc.FieldName == "ModifiedDate")
                    {
                        grc.OptionsColumn.AllowEdit = false;
                        grc.OptionsColumn.ReadOnly = true;
                    }
                    if (grc.GetType() == typeof(DateTime))
                    {
                        grc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        grc.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
                    }
                }
            }
            RestoreLayout();
            grvRegisterItem.Columns["CreatedUserName"].OptionsColumn.AllowEdit = false;
            grvRegisterItem.Columns["CreatedUserName"].OptionsColumn.ReadOnly = true;
            grvRegisterItem.Columns["CreatedDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            grvRegisterItem.Columns["CreatedDate"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            grvRegisterItem.Columns["CreatedDate"].OptionsColumn.AllowEdit = false;
            grvRegisterItem.Columns["CreatedDate"].OptionsColumn.ReadOnly = true;
            grvRegisterItem.Columns["ModifiedDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            grvRegisterItem.Columns["ModifiedDate"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            grvRegisterItem.Columns["ModifiedUserName"].OptionsColumn.AllowEdit = false;
            grvRegisterItem.Columns["ModifiedUserName"].OptionsColumn.ReadOnly = true;
            grvRegisterItem.Columns["ModifiedDate"].OptionsColumn.AllowEdit = false;
            grvRegisterItem.Columns["ModifiedDate"].OptionsColumn.ReadOnly = true;
            grdRegisterItem.DataSource = registerItem;
        }        

        public void ShowData(string departmentIDList, bool check)
        {
            if (check)
                employee.GetListByDepartmentIDAndDuration(departmentIDList, DateTime.Today, IDs);
            else
                employee.DeleteByDepartmentID(departmentIDList);            
            foreach (EmployeeRow er in employee) er["Check"] = false;
            employee.AcceptChanges();
            grdEmployee.DataSource = employee;
            bgvEmployee.ExpandAllGroups();
            bgvEmployee.BestFitColumns();

            if (employee.Count == 0)
            {
                if (registerItem != null) registerItem.Clear();
                checkedRows.Clear();
            }
            else
                bgvEmployee.FocusedRowHandle = 0;
        }

        private void ShowEmployee()
        {            
            string[] checkedItems = ccbEmployeeCode.Properties.GetCheckedItems().ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            IDs = string.Empty;
            foreach (string item in checkedItems)
            {
                IDs += string.Format("[{0}]", EmployeeTable.GetIDByCode(item));
            }
            employee.Clear();
            ShowData(Constant.departmentIDList, true);
            bgvEmployee.BeginUpdate();
            foreach (EmployeeRow er in employee)
            {
                er["Check"] = true;
            }
            bgvEmployee.EndUpdate();
        }

        private void InitGroup()
        {
            DepartmentTable department = new DepartmentTable();
            department.GetContent();
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.Name, dr.Name, 0));
            }
            EmployeeTable employeeIDs = new EmployeeTable();
            employeeIDs.GetContent(Constant.currentUser.Name);
            foreach (EmployeeRow er in employeeIDs)
            {
                er.FullName = string.Format("{0} - {1}", er.Code, er.FullName);
            }
            ccbEmployeeCode.Properties.DataSource = employeeIDs;
            ccbEmployeeCode.Properties.ValueMember = "Code";
            ccbEmployeeCode.Properties.DisplayMember = "FullName";
        }

        private void AddColumn()
        {
            employee.Columns.Add("Check", typeof(bool));
            show = true;
        }

        protected void SaveItem()
        {
            bool success = true;
            RegisterItemT _registerItem = (RegisterItemT)registerItem.Clone();
            RegisterItemR _rir;

            grvRegisterItem.PostEditor();
            grvRegisterItem.UpdateCurrentRow();
            if (checkedRows.Count == 0) checkedRows.Add(Convert.ToInt32(bgvEmployee.GetFocusedRowCellValue("ID")));
            foreach (RegisterItemR rir in registerItem)
            {
                if (rir.RowState == DataRowState.Added)
                {
                    foreach (int employeeID in checkedRows)
                    {
                        _rir = (RegisterItemR)_registerItem.NewRow();
                        _rir["EmployeeID"] = employeeID;
                        for (int i = 1; i < registerItem.Columns.Count; i++)
                        {
                            _rir[registerItem.Columns[i].ColumnName] = rir[registerItem.Columns[i].ColumnName];
                        }
                        _registerItem.AddRegisterItemRow(_rir);
                    }
                    success = _registerItem.Insert();
                    if (!success) break;
                }
                if (!success) break;
                if (rir.RowState == DataRowState.Modified)
                {
                    rir["ModifiedUserName"] = Constant.currentUser.Name;
                    foreach (int employeeID in checkedRows)
                    {
                        _rir = (RegisterItemR)_registerItem.NewRow();
                        _rir["EmployeeID"] = employeeID;
                        for (int i = 1; i < registerItem.PrimaryKey.Length; i++)
                        {
                            _rir[registerItem.PrimaryKey[i].ColumnName] = rir[registerItem.PrimaryKey[i].ColumnName, DataRowVersion.Original];
                        }
                        _registerItem.AddRegisterItemRow(_rir);
                        _rir.AcceptChanges();
                        for (int i = 1; i < registerItem.Columns.Count; i++)
                        {
                            _rir[registerItem.Columns[i].ColumnName] = rir[registerItem.Columns[i].ColumnName];
                        }
                    }
                    success = _registerItem.Update();
                    if (!success) break;
                }
                if (!success) break;
            }
            if (success)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_REGISTERITEM_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_REGISTERITEM_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (EmployeeRow er in employee)
            {
                er["Check"] = false;
            }
            bgvEmployee.Bands["grbCheck"].ImageIndex = 1;
            checkedRows.Clear();
            //registerItem.Clear();
        }

        private void DeleteItem()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_REGISTERITEM", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (retVal == DialogResult.OK)
            {
                int[] selectedItemRows = grvRegisterItem.GetSelectedRows();
                if (checkedRows.Count == 0) checkedRows.Add(Convert.ToInt32(bgvEmployee.GetFocusedRowCellValue("ID")));
                DataColumn[] primaryKey = registerItem.PrimaryKey;
                RegisterItemT _registerItem = (RegisterItemT)registerItem.Clone();
                RegisterItemR rir;
                foreach (int i in selectedItemRows)
                {                    
                    foreach (int employeeID in checkedRows)
                    {
                        rir = (RegisterItemR)_registerItem.NewRow();
                        rir["EmployeeID"] = employeeID;
                        for (int k = 1; k < primaryKey.Length; k++)
                        {
                            rir[primaryKey[k].ColumnName] = grvRegisterItem.GetRowCellValue(i, primaryKey[k].ColumnName);
                        }
                        _registerItem.AddRegisterItemRow(rir);
                        _registerItem.AcceptChanges();
                        rir.Delete();
                    }
                    grvRegisterItem.DeleteRow(i);
                }
                _registerItem.Delete();
                checkedRows.Clear();
            }
        }

        private void RegisterItem_Load(object sender, EventArgs e)
        {
            try
            {
                InitGroup();
                AddColumn();
                AddPageCategory();
                dedFromDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dedToDate.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

                SetPermissionPage(pageCategory);
            }
            catch
            {
            }
        }

        private void SetPermissionPage(PageCategory pcg)
        {
            if (pcg == null)
                return;
            if (pcg.Pages[0] == null)
                return;
            if (pcg.Pages[0].Groups.Count == 0)
                return;

            for (int i = 0; i < pcg.Pages[0].Groups.Count; i++)
            {
                Utility.SetPermission(pcg.Pages[0].Groups[i], this.Name);
            }

        }

        private void bgvEmployee_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                if (e.RowHandle > 0)
                {
                    if (bgvEmployee.GetRowCellValue(e.RowHandle - 1, "ID") != null && bgvEmployee.GetRowCellValue(e.RowHandle, "ID").ToString() == bgvEmployee.GetRowCellValue(e.RowHandle - 1, "ID").ToString())
                    {
                        e.Value = bgvEmployee.GetRowCellValue(e.RowHandle - 1, "No");
                    }
                    else
                    {
                        if (e.RowHandle == bgvEmployee.GetDataRowHandleByGroupRowHandle(bgvEmployee.GetParentRowHandle(e.RowHandle)))
                            e.Value = 1;
                        else
                            e.Value = Convert.ToInt32(bgvEmployee.GetRowCellValue(e.RowHandle - 1, "No")) + 1;
                    }
                }
                else
                {
                    e.Value = 1;
                }
            }
        }

        private void bgvEmployee_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Check" && e.Value != null && bgvEmployee.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                if ((bool)e.Value)
                    checkedRows.Add(Convert.ToInt32(bgvEmployee.GetRowCellValue(e.RowHandle, "ID")));
                else
                    checkedRows.Remove(Convert.ToInt32(bgvEmployee.GetRowCellValue(e.RowHandle, "ID")));
                string employeeIDList = string.Empty;

                foreach (int employeeID in checkedRows)
                {
                    employeeIDList += "[" + employeeID + "]";
                }
                registerItem.GetListByEmployeeID(employeeIDList, checkedRows.Count);                
                grvRegisterItem.BestFitColumns();
            }
        }

        private void grvRegisterItem_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            bbiDelete.Enabled = (grvRegisterItem.SelectedRowsCount != 0);
            pageCategory.Ribbon.Refresh();
        }

        private void bbiDelete_ItemClick(object sender, EventArgs e)
        {
            DeleteItem();    
        }

        private void bbiSave_ItemClick(object sender, EventArgs e)
        {
            if (save) SaveItem();
        }

        private void grvRegisterItem_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvRegisterItem.SetRowCellValue(e.RowHandle, "EmployeeID", 0);
            grvRegisterItem.SetRowCellValue(e.RowHandle, "CreatedUserName", Constant.currentUser.Name);
            bbiSave.Enabled = true;
            pageCategory.Ribbon.Refresh();
        }

        private void grvRegisterItem_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ToDate" && e.CellValue != DBNull.Value && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
        }

        private void grvRegisterItem_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (grvRegisterItem.FocusedColumn.FieldName == "FromDate")
            {
                if (e.Value == null)
                {
                    e.ErrorText = TitleTable.GetValue("FROMDATE_REGISTERITEM_EXIST", Constant.language);
                    e.Valid = false;
                }
            }
            if (grvRegisterItem.FocusedColumn.FieldName == "ToDate")
            {
                DateTime f, t, fromDate = DateTime.MaxValue, toDate = DateTime.MaxValue;
                if (grvRegisterItem.GetFocusedRowCellValue("FromDate") != DBNull.Value)
                    f = Convert.ToDateTime(grvRegisterItem.GetFocusedRowCellValue("FromDate"));
                else
                    f = DateTime.MaxValue;
                if (e.Value != null)
                    t = Convert.ToDateTime(e.Value);
                else
                    t = DateTime.MaxValue;
                if (e.Value != null && t < f)
                {
                    e.ErrorText = "'Đến ngày' phải nhỏ hơn hoặc bằng 'Từ ngày'";
                    e.Valid = false;
                }
                for (int i = 0; i < grvRegisterItem.DataRowCount; i++)
                {
                    if (i != grvRegisterItem.FocusedRowHandle)
                    {
                        fromDate = Convert.ToDateTime(grvRegisterItem.GetRowCellValue(i, "FromDate"));
                        toDate = Convert.ToDateTime(grvRegisterItem.GetRowCellValue(i, "ToDate"));
                        if ((f >= fromDate && f <= toDate) || (t >= fromDate && t <= toDate) || (f <= fromDate && t >= toDate))
                        {
                            e.ErrorText = "Khoảng thời gian trùng nhau";
                            e.Valid = false;
                            break;
                        }
                    }
                }
            }
        }

        private void grvRegisterItem_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle) e.Value = e.RowHandle + 1;
        }

        private void bgvEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hitInfo;
            if (view == null) return;
            if ((e.Button & MouseButtons.Left) != 0)
            {
                hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                GridBand band = hitInfo.Band;
                if (band != null && hitInfo.InBandPanel)
                {
                    if (band.Name == "grbCheck" && bgvEmployee.RowCount > 0)
                    {
                        string employeeIDList = string.Empty;
                        checkedRows.Clear();
                        if (band.ImageIndex == 0)
                        {
                            foreach (EmployeeRow er in employee)
                            {
                                er["Check"] = false;
                            }
                            band.ImageIndex = 1;
                        }
                        else
                        {
                            foreach (EmployeeRow er in employee)
                            {
                                er["Check"] = true;
                                checkedRows.Add(er.ID);
                                employeeIDList += employeeIDList == string.Empty ? "[" + er.ID + "]" : ",[" + er.ID + "]";
                            }
                            band.ImageIndex = 0;
                        }
                        registerItem.GetListByEmployeeID(employeeIDList, checkedRows.Count);
                        grdRegisterItem.DataSource = registerItem;
                        grvRegisterItem.BestFitColumns();
                    }
                }
            }
        }

        private void bgvEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (employee.Count > 0 && checkedRows.Count == 0 && e.FocusedRowHandle >= 0)
            {
                registerItem.GetListByEmployeeID("[" + bgvEmployee.GetFocusedRowCellValue("ID").ToString() + "]", 1);
                grvRegisterItem.BestFitColumns();
            }
        }

        private void grvRegisterItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteItem();
        }

        private void grvRegisterItem_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo;
            if (view == null) return;
            Point point = view.GridControl.PointToClient(Control.MousePosition);
            hitInfo = view.CalcHitInfo(new Point(point.X, point.Y));
            column = hitInfo.Column;
            if (column != null && hitInfo.InColumnPanel)
            {
                setGridColumn = new SetGridColumn(column, this);
                setGridColumn.ShowDialog();
            }
        }

        private void grdRegisterItem_Resize(object sender, EventArgs e)
        {
            GridView grv = (GridView)(((GridControl)sender).FocusedView);
            GridViewInfo gvi = (GridViewInfo)grv.GetViewInfo();
            grv.VisibleColumns[grv.VisibleColumns.Count - 1].Width += gvi.ViewRects.ColumnPanelWidth - gvi.ViewRects.ColumnTotalWidth;
        }

        private void ccbEmployeeCode_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ccbEmployeeCode.RefreshEditValue();
                ShowEmployee();
            }
        }

        private void ccbEmployeeCode_EditValueChanged(object sender, EventArgs e)
        {
            if (show) ShowEmployee();
        }

        private void RegisterItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemovePageCategory();
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            grvRegisterItem.ActiveFilterString = string.Format("(FromDate <= #{0}# AND ToDate >= #{1}#) OR (FromDate <= #{2}# AND ToDate >= #{3}#)", dedFromDate.DateTime.ToString("MM/dd/yyyy"), dedFromDate.DateTime.ToString("MM/dd/yyyy"), dedToDate.DateTime.ToString("MM/dd/yyyy"), dedToDate.DateTime.ToString("MM/dd/yyyy"));
        }
    }
}
