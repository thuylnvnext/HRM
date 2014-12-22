using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;

namespace Common.Forms
{
    public partial class DefineItem : XtraForm, IGridViewParent
    {
        protected ItemGroupT itemGroup;
        protected ItemT item;
        private SetGridColumn setGridColumn;
        private GridColumn column;
        private string itemGroupIDList = string.Empty;

        public DefineItem()
        {
            InitializeComponent();
        }

        protected void ShowItemGroup()
        {
            ItemGroupR _igr;
            TreeNode root;
            TreeNode[] tn;
            NodeList nodeList = new NodeList();
            int count;

            tvwItemGroup.BeginUpdate();

            itemGroup.GetContent();
            foreach (ItemGroupR igr in itemGroup)
            {
                if (igr.IsParentIDNull())
                {
                    tvwItemGroup.Nodes.Add(igr.ID, igr.Name, 0, 0);
                    tvwItemGroup.Nodes[igr.ID].NodeFont = new Font(tvwItemGroup.Font, FontStyle.Bold);
                }
                else
                {
                    if (igr.ParentID == "ROOT")
                    {
                        tn = tvwItemGroup.Nodes.Find("ROOT", true);
                        if (tvwItemGroup.Nodes.Find(igr.ID, true).Length == 0) tn[0].Nodes.Add(igr.ID, igr.Name, 0, 0);
                    }
                    else
                    {
                        tn = tvwItemGroup.Nodes.Find(igr.ParentID, true);
                        if (tn.Length == 0)
                        {
                            _igr = igr;
                            nodeList.Add(new Node(_igr.ID, _igr.Name, true));
                            do
                            {
                                if (_igr.ParentID != "ROOT")
                                {
                                    _igr = itemGroup.FindByID(_igr.ParentID);
                                    if (_igr != null) tn = tvwItemGroup.Nodes.Find(_igr.ID, true);
                                }
                                else
                                {
                                    if (_igr != null) tn = tvwItemGroup.Nodes.Find("ROOT", true);
                                    break;
                                }
                                if (tn.Length == 0 && _igr != null) nodeList.Add(new Node(_igr.ID, _igr.Name, true));
                            } while (tn.Length == 0);

                            if (tn.Length > 0)
                            {
                                root = tn[0];
                                for (int i = nodeList.Count - 1; i >= 0; i--)
                                {
                                    if (tvwItemGroup.Nodes.Find(nodeList[i].ID, true).Length == 0) root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 0, 0);
                                }
                            }
                            else
                            {
                                if (_igr != null)
                                {
                                    count = nodeList.Count - 1;
                                    root = tvwItemGroup.Nodes.Add(nodeList[count].ID, nodeList[count].Name, 0, 0);
                                    for (int i = nodeList.Count - 1; i >= 0; i--)
                                    {
                                        if (tvwItemGroup.Nodes.Find(nodeList[i].ID, true).Length == 0) root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 0, 0);
                                    }
                                }
                            }
                            nodeList.Clear();
                        }
                        else
                            if (tvwItemGroup.Nodes.Find(igr.ID, true).Length == 0) tn[0].Nodes.Add(igr.ID, igr.Name, 0, 0); ;
                    }
                }
            }

            tvwItemGroup.ExpandAll();
            tvwItemGroup.EndUpdate();
        }

        private GridColumn AddColumn(DataColumn dc)
        {
            GridColumn column = new GridColumn();

            grvDefineItem.Columns.Add(column);
            column.Name = dc.ColumnName;
            column.FieldName = dc.ColumnName;
            column.Caption = dc.Caption;
            column.OptionsColumn.AllowEdit = false;
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

        private void AddRow(GridColumn grc)
        {
            EditorRow row = new EditorRow();

            vgcItem.Rows.Add(row);
            row.Name = "edr" + grc.Name;
            row.Properties.FieldName = grc.FieldName;            
        }

        protected void InitItem(string name)
        {
            grvDefineItem.Name = name;
            GridColumn grc;
            foreach (DataColumn dc in item.GetColumns())
            {
                grc = AddColumn(dc);
                AddRow(grc);
            }
            RestoreLayout();            
            SetCaption();
            grdDefineItem.DataSource = item;
            vgcItem.DataSource = item;
        }

        public void NextGridColumn()
        {
            if (column.AbsoluteIndex + 1 < grvDefineItem.Columns.Count)
            {
                column = grvDefineItem.Columns[column.AbsoluteIndex + 1];
                setGridColumn.FillData(column);
            }
        }

        public string GetName()
        {
            return grvDefineItem.Name;
        }

        private void RestoreLayout()
        {
            string d = LayoutTable.GetValueByItem(grvDefineItem.Name, 0, 0, Constant.language);
            if (d != string.Empty)
            {
                Stream s = new MemoryStream();
                StreamWriter w = new StreamWriter(s);
                w.AutoFlush = true;
                w.Write(d);
                s.Position = 0;
                grvDefineItem.RestoreLayoutFromStream(s);
            }
        }

        private void SetCaption()
        {
            EditorRow er;
            foreach (GridColumn grc in grvDefineItem.Columns)
            {
                er = (EditorRow)vgcItem.Rows["edr" + grc.Name];
                if (er != null)
                {
                    er.Properties.Caption = grc.Caption;
                    er.Appearance.Options.UseTextOptions = true;
                    er.Appearance.TextOptions.HAlignment = grc.AppearanceCell.TextOptions.HAlignment;
                }
            }
        }

        private string GetItemGroupIDList()
        {
            itemGroupIDList = "[" + tvwItemGroup.SelectedNode.Name + "]";
            NodeList(tvwItemGroup.SelectedNode);
            return itemGroupIDList;
        }

        private void NodeList(TreeNode tn)
        {
            foreach (TreeNode n in tn.Nodes)
            {
                itemGroupIDList += "[" + n.Name + "]";
                NodeList(n);
            }
        }

        private void ShowItem()
        {
            item.GetListByItemGroupID(itemGroupIDList);            
            grvDefineItem.BestFitColumns();
            for (int r = 0; r < vgcItem.RecordCount; r++)
            {
                if (vgcItem.GetCellValue(vgcItem.Rows["edrID"], r).ToString() == grvDefineItem.GetRowCellValue(0, "ID").ToString())
                {
                    vgcItem.MakeRecordVisible(r);
                    break;
                }
            }
        }

        private void DefineItem_Load(object sender, EventArgs e)
        {
            //if (itemGroup != null) ShowItemGroup();
            //if (item != null) InitItem();
            //FillItem();
            //SetCaption();
        }

        private void grvDefineItem_DoubleClick(object sender, EventArgs e)
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

        private void tvwItemGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GetItemGroupIDList();
            ShowItem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vgcItem.AddNewRecord();
            vgcItem.SetCellValue(vgcItem.Rows["edrID"], vgcItem.FocusedRecord, item.GetNewID());
            vgcItem.SetCellValue(vgcItem.Rows["edr" + item.ItemGroupID], vgcItem.FocusedRecord, tvwItemGroup.SelectedNode.Name);
            vgcItem.Focus();
            btnUndo.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;

            retVal1 = item.Insert();
            retVal2 = item.Update();
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEM_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEM_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            new Forms.AddItemGroup(tvwItemGroup.SelectedNode, itemGroup).ShowDialog();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            new Forms.EditItemGroup(itemGroup, tvwItemGroup.SelectedNode).ShowDialog();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_ITEMGROUP", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                ItemGroupR igr = itemGroup.FindByID(tvwItemGroup.SelectedNode.Name);
                igr.Delete();
                itemGroup.Delete();
                tvwItemGroup.Nodes.Remove(tvwItemGroup.SelectedNode);
            }
        }

        private void tvwItemGroup_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvwItemGroup.SelectedNode = e.Node;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            item.RejectChanges();
            btnUndo.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult retVal;

            retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_ITEM", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                vgcItem.DeleteRecord(vgcItem.FocusedRecord);
                item.Delete();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void grvDefineItem_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void vgcItem_InvalidRecordException(object sender, DevExpress.XtraVerticalGrid.Events.InvalidRecordExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }
    }
}
