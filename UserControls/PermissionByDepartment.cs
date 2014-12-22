using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Database;
using Common;

namespace HRMplus.UserControls
{
    public partial class PermissionByDepartment : XtraUserControl
    {
        private RightOfGroupTable rightOfGroup;
        private byte groupID;

        public PermissionByDepartment()
        {
            InitializeComponent();
        }

        public PermissionByDepartment(byte groupID)
        {
            InitializeComponent();
            this.groupID = groupID;
        }

        private void ShowDepartmentTree()
        {
            CompanyTable company = new CompanyTable();
            DepartmentTable department = new DepartmentTable();
            CompanyRow cr;
            DepartmentRow _dr;
            TreeNode root, newDepartment;
            TreeNode[] tn;
            NodeList nodeList = new NodeList();

            tvwDepartment.BeginUpdate();
            tvwDepartment.Nodes.Clear();

            company.GetContent();
            department.GetContent();
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
                            tvwDepartment.Nodes.Add(cr.ID, cr.Name, 0, 0);
                            tvwDepartment.Nodes[cr.ID].NodeFont = new Font(tvwDepartment.Font, FontStyle.Bold);

                            newDepartment = tvwDepartment.Nodes[cr.ID].Nodes.Add(dr.ID, dr.Name, 1, 1);
                            if (rightOfGroup.FindByPrimaryKey(groupID, newDepartment.Name, 0) != null) newDepartment.Checked = true;
                        }
                        else
                        {
                            newDepartment = tn[0].Nodes.Add(dr.ID, dr.Name, 1, 1);
                            if (rightOfGroup.FindByPrimaryKey(groupID, newDepartment.Name, 0) != null) newDepartment.Checked = true;
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
                                    //if (department.FindByPrimaryKey(_dr.ParentID) == null)
                                    //    MessageBox.Show("OK");
                                    _dr = department.FindByPrimaryKey(_dr.ParentID);
                                    
                                    //
                                    if (_dr != null) tn = tvwDepartment.Nodes.Find(_dr.ID, true);
                                }
                                else
                                {
                                    if (_dr != null) tn = tvwDepartment.Nodes.Find(_dr.CompanyID, true);
                                    break;
                                }
                                if (tn.Length == 0 && _dr != null /*Xem lai*/) nodeList.Add(new Node(_dr.ID, _dr.Name, _dr.Active));
                            } while (tn.Length == 0);

                            if (tn.Length > 0)
                            {
                                root = tn[0];
                                for (int i = nodeList.Count - 1; i >= 0; i--)
                                {
                                    root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 1, 1);
                                    if (rightOfGroup.FindByPrimaryKey(groupID, root.Name, 0) != null) root.Checked = true;
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
                                        if (rightOfGroup.FindByPrimaryKey(groupID, root.Name, 0) != null) root.Checked = true;
                                    }
                                }
                            }
                            nodeList.Clear();
                        }
                        else
                        {
                            newDepartment = tn[0].Nodes.Add(dr.ID, dr.Name, 1, 1);
                            if (rightOfGroup.FindByPrimaryKey(groupID, newDepartment.Name, 0) != null) newDepartment.Checked = true;
                        }
                    }
                }
            }
            for (int i = tvwDepartment.Nodes.Count - 1; i >= 0; i--)
            {
                tvwDepartment.Nodes[i].Expand();
            }
            tvwDepartment.EndUpdate();
        }

        private void Permission(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Checked && tn.Parent != null)
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, tn.Name, 0) == null)
                    {
                        rightOfGroup.AddRightOfGroupRow(groupID, tn.Name, 0);
                        rightOfGroup.Insert();
                    }
                }
                else
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, tn.Name, 0) != null)
                    {
                        rightOfGroup.Delete(groupID, tn.Name, 0);
                        rightOfGroup.Delete();
                    }
                }
                Permission(tn.Nodes);
            }
        }

        private void PermissionByDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                rightOfGroup = ((Forms.Permission)ParentForm).RightOfGroup;
                groupID = ((Forms.Permission)ParentForm).GroupID;
            }
            catch
            {
            }

            ShowDepartmentTree();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Permission(tvwDepartment.Nodes);
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PERMISSION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tvwDepartment_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode tn in e.Node.Nodes)
            {
                tn.Checked = e.Node.Checked;
            }
        }
    }
}
