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
    public partial class PermissionByMenu : XtraUserControl
    {
        private RightOfGroupTable rightOfGroup;
        private byte groupID;

        public PermissionByMenu()
        {
            InitializeComponent();
        }        

        private void ShowMenuTree()
        {
            MenuTable menu = new MenuTable();
            TreeNode[] tn;
            MenuRow _mr;
            TreeNode root;
            NodeList nodeList = new NodeList();
            int count;

            tvwMenu.BeginUpdate();
            tvwMenu.Nodes.Clear();

            menu.GetContent();
            foreach (MenuRow mr in menu)
            {
                tn = tvwMenu.Nodes.Find(mr.ID, true);
                if (tn.Length == 0)
                {
                    if (mr.IsOwnerNull())
                    {
                        root = tvwMenu.Nodes.Add(mr.ID, mr.Name, 2, 2);
                        if (rightOfGroup.FindByPrimaryKey(groupID, mr.ID, 1) != null) root.Checked = true;
                    }
                    else
                    {
                        tn = tvwMenu.Nodes.Find(mr.Owner, true);
                        if (tn.Length == 0)
                        {
                            _mr = mr;
                            nodeList.Add(new Node(_mr.ID, _mr.Name, true));
                            do
                            {
                                if (!_mr.IsOwnerNull())
                                {
                                    _mr = menu.FindByPrimaryKey(_mr.Owner);
                                    tn = tvwMenu.Nodes.Find(_mr.ID, true);
                                }
                                else
                                {
                                    tn = tvwMenu.Nodes.Find(_mr.ID, true);
                                    break;
                                }
                                if (tn.Length == 0) nodeList.Add(new Node(_mr.ID, _mr.Name, true));
                            } while (tn.Length == 0);

                            if (tn.Length > 0)
                            {
                                root = tn[0];
                                for (int i = nodeList.Count - 1; i >= 0; i--)
                                {
                                    root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 2, 2);
                                    root.NodeFont = new Font(tvwMenu.Font, FontStyle.Regular);
                                    if (rightOfGroup.FindByPrimaryKey(groupID, nodeList[i].ID, 1) != null) root.Checked = true;
                                }
                            }
                            else
                            {
                                count = nodeList.Count - 1;
                                root = tvwMenu.Nodes.Add(nodeList[count].ID, nodeList[count].Name, 2, 2);
                                if (rightOfGroup.FindByPrimaryKey(groupID, nodeList[count].ID, 1) != null) root.Checked = true;
                                for (int i = count - 1; i >= 0; i--)
                                {
                                    root = root.Nodes.Add(nodeList[i].ID, nodeList[i].Name, 2, 2);
                                    root.NodeFont = new Font(tvwMenu.Font, FontStyle.Regular);
                                    if (rightOfGroup.FindByPrimaryKey(groupID, nodeList[i].ID, 1) != null) root.Checked = true;
                                }
                            }
                            nodeList.Clear();
                        }
                        else
                        {
                            root = tn[0].Nodes.Add(mr.ID, mr.Name, 2, 2);
                            root.NodeFont = new Font(tvwMenu.Font, FontStyle.Regular);
                            if (rightOfGroup.FindByPrimaryKey(groupID, mr.ID, 1) != null) root.Checked = true;
                        }
                    }
                }
            }
            for (int i = tvwMenu.Nodes.Count - 1; i >= 0; i--)
            {
                tvwMenu.Nodes[i].Expand();
            }
            tvwMenu.EndUpdate();
        }

        private void Permission(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Checked)
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, tn.Name, 1) == null)
                    {
                        rightOfGroup.AddRightOfGroupRow(groupID, tn.Name, 1);
                        rightOfGroup.Insert();
                    }
                }
                else
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, tn.Name, 1) != null)
                    {
                        rightOfGroup.Delete(groupID, tn.Name, 1);
                        rightOfGroup.Delete();
                    }
                }
                Permission(tn.Nodes);
            }
        }

        private void PermissionByMenu_Load(object sender, EventArgs e)
        {
            try
            {
                rightOfGroup = ((Forms.Permission)ParentForm).RightOfGroup;
                groupID = ((Forms.Permission)ParentForm).GroupID;
            }
            catch 
            {
            }

            ShowMenuTree();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Permission(tvwMenu.Nodes);
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PERMISSION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tvwMenu_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode tn in e.Node.Nodes)
            {
                tn.Checked = e.Node.Checked;
            }
        }
    }
}
