using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;

namespace Common.Forms
{
    public partial class DefineList : XtraForm, IGridViewParent
    {
        private IListTable list;
        private bool isEdit = false;
        private SetGridColumn setGridColumn;
        private GridColumn column;

        public DefineList(IListTable list, string text)
        {
            InitializeComponent();            
            this.list = list;
            Text = text;
            InitList();
            Utility.SetSkin(this);
        }

        public GridView GetGridView
        {
            get
            {
                return grvDefineList;
            }
        }

        private void AddColumn(DataColumn dc)
        {
            GridColumn column = new GridColumn();

            grvDefineList.Columns.Add(column);
            column.Name = dc.ColumnName;
            column.FieldName = dc.ColumnName;
            column.Caption = dc.Caption;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;                        
        }

        private void InitList()
        {
            list.GetContent();
            foreach (DataColumn dc in list.GetColumns())
            {
                AddColumn(dc);
            }
        }

        private void FillList()
        {            
            grdDefineList.DataSource = list;
            RestoreLayout();
            grvDefineList.BestFitColumns();
        }

        private void DeleteList()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_ITEM", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes) list.Delete(grvDefineList.GetFocusedRowCellValue("ID").ToString());
        }

        private void RestoreLayout()
        {
            string d = LayoutTable.GetValueByItem("grvDefineList", 0, 0, Constant.language);
            if (d != string.Empty)
            {
                Stream s = new MemoryStream();
                StreamWriter w = new StreamWriter(s);
                w.AutoFlush = true;
                w.Write(d);
                s.Position = 0;
                grvDefineList.RestoreLayoutFromStream(s);
            }
        }

        public void NextGridColumn()
        {
            if (column.VisibleIndex + 1 < grvDefineList.Columns.Count)
            {
                column = grvDefineList.Columns[column.VisibleIndex + 1];
                setGridColumn.FillData(column);
            }
        }

        public string GetName()
        {
            return grvDefineList.Name;
        }

        private void DefineList_Load(object sender, EventArgs e)
        {            
            FillList();
        }

        private void grvDefineList_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (list.Insert() && list.Update())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LIST_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnUndo.Enabled = false;
                isEdit = false;
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LIST_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteList();
        }

        private void grvDefineList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isEdit)
            {
                btnSave.Enabled = true;
                btnUndo.Enabled = true;
                isEdit = true;
            }
        }

        private void grdDefineList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteList();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void grvDefineList_DoubleClick(object sender, EventArgs e)
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
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
