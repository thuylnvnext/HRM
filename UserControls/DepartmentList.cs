using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using Common;
using DevExpress.XtraEditors;

namespace HRMplus.UserControls
{
    public partial class DepartmentList : XtraUserControl
    {
        private DepartmentTable department = new DepartmentTable();
        private string nodeList = string.Empty, foundDepartment = string.Empty;
        private int index = 0;
        private List<string> departmentList = new List<string>();
        private TreeNode currentNode, oldNode;

        public void ShowDepartment()
        {
            CompanyTable company = new CompanyTable();
            CompanyRow cr;
            DepartmentRow _dr;
            TreeNode root, node;
            TreeNode[] tn;
            NodeList nodeList = new NodeList();

            tvwDepartment.BeginUpdate();
            tvwDepartment.Nodes.Clear();

            company.GetContent();


            department.GetListByUserName(Constant.currentUser.Name, mnuShowAll.Checked);


            if (company.Rows.Count == 0)
                return;

            if (department.Rows.Count == 0)
            {
                cr = company[0];
                tvwDepartment.Nodes.Add(cr.ID, TitleTable.GetValue("COMPANY_NAME", Constant.language), 0, 0);
                tvwDepartment.Nodes[cr.ID].NodeFont = new Font(tvwDepartment.Font, FontStyle.Bold);

                tvwDepartment.ExpandAll();
                tvwDepartment.EndUpdate();

                Constant.departmentIDList = string.Empty;
                return;
            }



            foreach (DepartmentRow dr in department)
            {
                tn = tvwDepartment.Nodes.Find(dr.ID, true);
                if (tn.Length == 0)
                {
                    if (dr.ParentID == string.Empty)
                    {
                        tn = tvwDepartment.Nodes.Find(dr.CompanyID, true);
                        if (tn.Length == 0)
                        {
                            cr = company.FindByPrimaryKey(dr.CompanyID);
                            tvwDepartment.Nodes.Add(cr.ID, TitleTable.GetValue("COMPANY_NAME", Constant.language), 0, 0);
                            tvwDepartment.Nodes[cr.ID].NodeFont = new Font(tvwDepartment.Font, FontStyle.Bold);

                            node = tvwDepartment.Nodes[cr.ID].Nodes.Add(dr.ID, dr.Name, 1, 1);
                            if (!dr.Active) node.ForeColor = Color.Red;
                        }
                        else
                        {
                            node = tn[0].Nodes.Add(dr.ID, dr.Name, 1, 1);
                            if (!dr.Active) node.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        tn = tvwDepartment.Nodes.Find(dr.ParentID, true);
                        if (tn.Length == 0)
                        {
                            _dr = dr;
                            nodeList.Add(new Node(_dr.ID, _dr.Name, _dr.Active));
                            do
                            {
                                if (_dr != null && _dr.ParentID != string.Empty)
                                {
                                    _dr = department.FindByPrimaryKey(_dr.ParentID);
                                    if (_dr != null) tn = tvwDepartment.Nodes.Find(_dr.ID, true);
                                }
                                else
                                {
                                    if (_dr != null) tn = tvwDepartment.Nodes.Find(_dr.CompanyID, true);
                                    break;
                                }
                                if (tn.Length == 0 && _dr != null) nodeList.Add(new Node(_dr.ID, _dr.Name, _dr.Active));
                            } while (tn.Length == 0);

                            if (tn.Length > 0)
                            {
                                root = tn[0];
                                for (int i = nodeList.Count - 1; i >= 0; i--)
                                {
                                    root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 1, 1);
                                    if (!nodeList[i].Active) root.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                if (_dr != null)
                                {
                                    cr = company.FindByPrimaryKey(_dr.CompanyID);
                                    root = tvwDepartment.Nodes.Add(cr.ID, cr.Name, 0, 0);
                                    tvwDepartment.Nodes[cr.ID].NodeFont = new Font(tvwDepartment.Font, FontStyle.Bold);
                                    for (int i = nodeList.Count - 1; i >= 0; i--)
                                    {
                                        root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 1, 1);
                                        if (!nodeList[i].Active) root.ForeColor = Color.Red;
                                    }
                                }
                            }
                            nodeList.Clear();
                        }
                        else
                        {
                            node = tn[0].Nodes.Add(dr.ID, dr.Name, 1, 1);
                            if (!dr.Active) node.ForeColor = Color.Red;
                        }
                    }
                }
            }

            tvwDepartment.ExpandAll();
            tvwDepartment.EndUpdate();

            Constant.departmentIDList = string.Empty;
        }

        private string GetDepartmentIDList(TreeNode tn, bool check)
        {
            nodeList = string.Empty;
            if (tn == null)
                NodeList(tvwDepartment.Nodes[0].Nodes, check);
            else
            {
                if (tn.Checked == check /*&& tn.Nodes.Count == 0*/) nodeList += "[" + tn.Name + "]";
                if (tn.Nodes.Count > 0) NodeList(tn.Nodes, check);
            }

            return nodeList;
        }

        private void NodeList(TreeNodeCollection tnc, bool check)
        {
            foreach (TreeNode tn in tnc)
            {
                if (check)
                {
                    if (tn.Checked /*&& tn.Nodes.Count == 0*/) nodeList += "[" + tn.Name + "]";
                }
                else
                    nodeList += "[" + tn.Name + "]";
                NodeList(tn.Nodes, check);
            }
        }

        private void ShowData(string departmentID, bool check)
        {
            foreach (IShowData childForm in ((Forms.Main)ParentForm).MdiChildren)
            {
                childForm.ShowData(departmentID, check);
            }
        }

        private void FindDepartment(string foundText)
        {
            if (foundText != foundDepartment)
            {
                departmentList.Clear();
                index = 0;
                foreach (DepartmentRow dr in department)
                {
                    if (dr.Name.IndexOf(foundText, StringComparison.OrdinalIgnoreCase) > -1) departmentList.Add(dr.ID);
                }
                if (departmentList.Count > 0) tvwDepartment.SelectedNode = tvwDepartment.Nodes.Find(departmentList[index++], true)[0];
                foundDepartment = foundText;
            }
            else
                if (departmentList.Count > index) tvwDepartment.SelectedNode = tvwDepartment.Nodes.Find(departmentList[index++], true)[0];
        }

        public DepartmentList()
        {
            InitializeComponent();
        }

        private void DepartmentList_Load(object sender, EventArgs e)
        {
            try
            {
                ShowDepartment();
            }
            catch
            {
            }
        }

        private void tvwDepartment_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Application.DoEvents();
            if (currentNode == null) currentNode = e.Node;
            foreach (TreeNode tn in e.Node.Nodes) tn.Checked = e.Node.Checked;
            Constant.departmentIDList = GetDepartmentIDList(null, true);
            if (e.Node == currentNode)
            {
                if (e.Node.Checked)
                    ShowData(Constant.departmentIDList, true);
                else
                    ShowData(GetDepartmentIDList(e.Node, false), false);
                currentNode = null;
            }
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            new Personnel.Forms.AddDepartment(tvwDepartment.SelectedNode, department).ShowDialog();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            new Personnel.Forms.EditDepartment(tvwDepartment.SelectedNode).ShowDialog();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_DEPARTMENT", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                department.Delete(tvwDepartment.SelectedNode.Name);
                tvwDepartment.Nodes.Remove(tvwDepartment.SelectedNode);
            }
        }

        private void tvwDepartment_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvwDepartment.SelectedNode = e.Node;
        }

        private void mnuShowAll_Click(object sender, EventArgs e)
        {
            mnuShowAll.Checked = !mnuShowAll.Checked;
            ShowDepartment();
        }

        private void cmsDepartment_Opening(object sender, CancelEventArgs e)
        {
            mnuEdit.Enabled = (tvwDepartment.SelectedNode.Parent != null);
            mnuDelete.Enabled = (tvwDepartment.SelectedNode.Parent != null);
            mnuCollapse.Enabled = (tvwDepartment.SelectedNode.IsExpanded);
            mnuExpand.Enabled = (!tvwDepartment.SelectedNode.IsExpanded);
            mnuNightWork.Enabled = (Constant.departmentIDList != string.Empty);
        }

        private void tvwDepartment_MouseDown(object sender, MouseEventArgs e)
        {
            //hitTestInfo = tvwDepartment.HitTest(e.Location);
        }

        private void tvwDepartment_MouseMove(object sender, MouseEventArgs e)
        {
            //if (hitTestInfo != null)
            //{
            //    if (tvwDepartment.HitTest(e.Location).Node == null)
            //        tvwDepartment.AllowDrop = false;
            //    else
            //        if (tvwDepartment.HitTest(e.Location).Node != hitTestInfo.Node)
            //            tvwDepartment.AllowDrop = true;
            //        else
            //            tvwDepartment.AllowDrop = false;
            //if (hitTestInfo != null && hitTestInfo != tvwDepartment.HitTest(e.Location) && tvwDepartment.AllowDrop)
            //    tvwDepartment.DoDragDrop(hitTestInfo.Node, DragDropEffects.Copy);
            //}
        }

        private void tvwDepartment_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void tvwDepartment_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode tn1 = (TreeNode)e.Data.GetData(typeof(TreeNode)), tn2 = tvwDepartment.HitTest(tvwDepartment.PointToClient(new Point(e.X, e.Y))).Node;
            if (tn1 != null && tn2 != null)
            {
                if (department.FindByPrimaryKey(tn1.Name).SortOrder > department.FindByPrimaryKey(tn2.Name).SortOrder)
                {
                    TreeNode tn;
                    DepartmentRow dr;
                    tn = tn2;
                    while (tn != tn1)
                    {
                        dr = department.FindByPrimaryKey(tn.Name);
                        dr.SortOrder += 1;
                        tn = tn.NextNode;
                    }
                    dr = department.FindByPrimaryKey(tn1.Name);
                    dr.SortOrder = (short)(department.FindByPrimaryKey(tn2.Name).SortOrder - 1);
                    department.Reorder();
                    ShowDepartment();
                }
                else
                {
                    TreeNode tn;
                    DepartmentRow dr;
                    tn = tn2.PrevNode;
                    while (tn != tn1)
                    {
                        dr = department.FindByPrimaryKey(tn.Name);
                        dr.SortOrder -= 1;
                        tn = tn.PrevNode;
                    }
                    dr = department.FindByPrimaryKey(tn1.Name);
                    dr.SortOrder = (short)(department.FindByPrimaryKey(tn2.Name).SortOrder - 1);
                    department.Reorder();
                    ShowDepartment();
                }
            }

            EmployeeTable selectedEmployees = (EmployeeTable)e.Data.GetData(typeof(EmployeeTable));
            if (selectedEmployees.Count > 0 && selectedEmployees[0]["DepartmentID"].ToString() != tn2.Name)
            {
                new Personnel.Forms.TransferDepartmentByEmployee(selectedEmployees, tn2.Name).ShowDialog();
                ShowData(Constant.departmentIDList, true);
            }
            tn2.BackColor = SystemColors.Window;
            tn2.ForeColor = SystemColors.WindowText;
        }

        private void tvwDepartment_ItemDrag(object sender, ItemDragEventArgs e)
        {
            tvwDepartment.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void tvwDepartment_DragOver(object sender, DragEventArgs e)
        {
            Point point = tvwDepartment.PointToClient(new Point(e.X, e.Y));
            int delta = tvwDepartment.Height - point.Y;
            TreeNode tn = tvwDepartment.GetNodeAt(point.X, point.Y);

            tn.BackColor = Color.DarkBlue;
            tn.ForeColor = Color.White;
            if (oldNode != null && oldNode != tn)
            {
                oldNode.BackColor = SystemColors.Window;
                oldNode.ForeColor = SystemColors.WindowText;
            }
            if ((delta < tvwDepartment.Height / 2) && (delta > 0))
            {
                if (tn.NextVisibleNode != null) tn.NextVisibleNode.EnsureVisible();
            }

            if ((delta > tvwDepartment.Height / 2) && (delta < tvwDepartment.Height))
            {
                if (tn.PrevVisibleNode != null) tn.PrevVisibleNode.EnsureVisible();
            }
            oldNode = tn;
        }

        private void tvwDepartment_DragLeave(object sender, EventArgs e)
        {
            oldNode.BackColor = SystemColors.Window;
            oldNode.ForeColor = SystemColors.WindowText;
        }

        private void mnuExpand_Click(object sender, EventArgs e)
        {
            tvwDepartment.SelectedNode.ExpandAll();
        }

        private void mnuCollapse_Click(object sender, EventArgs e)
        {
            tvwDepartment.SelectedNode.Collapse();
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') FindDepartment(txtFind.Text);
        }

        private void mnuNightWork_Click(object sender, EventArgs e)
        {
            new Attendance.Forms.RegisterNightWork().ShowDialog();
        }
    }
}
