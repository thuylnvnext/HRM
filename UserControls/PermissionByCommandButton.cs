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
    public partial class PermissionByCommandButton : XtraUserControl
    {
        private RightOfGroupTable rightOfGroup;
        private byte groupID;

        public PermissionByCommandButton()
        {
            InitializeComponent();
        }

        private bool IsExists(TreeNode[] tn, string parentName)
        {
            bool retVal = false;

            for (int i = 0; i < tn.Length; i++)
            {
                if (tn[i].Parent == null || tn[i].Parent.Name == parentName)
                {
                    retVal = true;
                    break;
                }
            }

            return retVal;
        }

        private void ShowCommandButton()
        {
            CommandButtonTable commandButton = new CommandButtonTable();
            TreeNode[] tn;
            CommandButtonRow _cbr;
            TreeNode root;
            NodeList nodeList = new NodeList();
            string[] iD;
            string owner;
            int count;

            tvwCommandButton.BeginUpdate();
            tvwCommandButton.Nodes.Clear();

            commandButton.GetContent();
            foreach (CommandButtonRow cbr in commandButton)
            {
                tn = tvwCommandButton.Nodes.Find(cbr.Name, true);
                owner = cbr.IsOwnerNull() ? string.Empty : cbr.Owner;
                if (!IsExists(tn, owner))
                {
                    if (cbr.IsOwnerNull())
                    {
                        root = tvwCommandButton.Nodes.Add(cbr.Name, cbr.Text, 2, 2);
                        if (rightOfGroup.FindByPrimaryKey(groupID, cbr.Name + "|" + owner, 2) != null) root.Checked = true;
                    }
                    else
                    {
                        tn = tvwCommandButton.Nodes.Find(cbr.Owner, true);
                        if (tn.Length == 0)
                        {
                            _cbr = cbr;
                            owner = _cbr.IsOwnerNull() ? string.Empty : _cbr.Owner;
                            nodeList.Add(new Node(_cbr.Name + "|" + owner, _cbr.Text, true));
                            do
                            {
                                if (!_cbr.IsOwnerNull())
                                {
                                    _cbr = commandButton.GetInfoByOwner(_cbr.Owner);
                                    tn = tvwCommandButton.Nodes.Find(_cbr.Name, true);
                                }
                                else
                                {
                                    tn = tvwCommandButton.Nodes.Find(_cbr.Name, true);
                                    break;
                                }
                                owner = _cbr.IsOwnerNull() ? string.Empty : _cbr.Owner;
                                if (!IsExists(tn, owner)) nodeList.Add(new Node(_cbr.Name + "|" + owner, _cbr.Text, true));
                            } while (!IsExists(tn, owner));

                            if (IsExists(tn, owner))
                            {
                                root = tn[0];
                                for (int i = nodeList.Count - 1; i >= 0; i--)
                                {
                                    iD = nodeList[i].ID.Split('|');
                                    root = root.Nodes.Add(iD[0], nodeList[i].Name, 2, 2);
                                    root.NodeFont = new Font(tvwCommandButton.Font, FontStyle.Regular);
                                    if (rightOfGroup.FindByPrimaryKey(groupID, nodeList[i].ID, 2) != null) root.Checked = true;
                                }
                            }
                            else
                            {
                                count = nodeList.Count - 1;
                                iD = nodeList[count].ID.Split('|');
                                root = tvwCommandButton.Nodes.Add(iD[0], nodeList[count].Name, 2, 2);
                                if (rightOfGroup.FindByPrimaryKey(groupID, nodeList[count].ID, 2) != null) root.Checked = true;
                                for (int i = count - 1; i >= 0; i--)
                                {
                                    iD = nodeList[i].ID.Split('|');
                                    root = root.Nodes.Add(iD[0], nodeList[i].Name, 2, 2);
                                    root.NodeFont = new Font(tvwCommandButton.Font, FontStyle.Regular);
                                    if (rightOfGroup.FindByPrimaryKey(groupID, nodeList[i].ID, 2) != null) root.Checked = true;
                                }
                            }
                            nodeList.Clear();
                        }
                        else
                        {
                            root = tn[0].Nodes.Add(cbr.Name, cbr.Text, 2, 2);
                            root.NodeFont = new Font(tvwCommandButton.Font, FontStyle.Regular);
                            if (rightOfGroup.FindByPrimaryKey(groupID, cbr.Name + "|" + owner, 2) != null) root.Checked = true;
                        }
                    }
                }
            }

            for (int i = tvwCommandButton.Nodes.Count - 1; i >= 0; i--)
            {
                tvwCommandButton.Nodes[i].Expand();
            }
            tvwCommandButton.EndUpdate();
        }

        private void Permission(TreeNodeCollection tnc)
        {
            string parentName;

            foreach (TreeNode tn in tnc)
            {
                parentName = tn.Parent == null ? string.Empty : tn.Parent.Name;
                if (tn.Checked)
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, tn.Name + "|" + parentName, 2) == null)
                    {
                        rightOfGroup.AddRightOfGroupRow(groupID, tn.Name + "|" + parentName, 2);
                        rightOfGroup.Insert();
                    }
                }
                else
                {
                    if (rightOfGroup.FindByPrimaryKey(groupID, tn.Name + "|" + parentName, 2) != null)
                    {
                        rightOfGroup.Delete(groupID, tn.Name + "|" + parentName, 2);
                        rightOfGroup.Delete();
                    }
                }
                Permission(tn.Nodes);
            }
        }

        private void PermissionByCommandButton_Load(object sender, EventArgs e)
        {
            try
            {
                rightOfGroup = ((Forms.Permission)ParentForm).RightOfGroup;
                groupID = ((Forms.Permission)ParentForm).GroupID;
            }
            catch
            {
            }

            ShowCommandButton();    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Permission(tvwCommandButton.Nodes);
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("PERMISSION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tvwCommandButton_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode tn in e.Node.Nodes)
            {
                tn.Checked = e.Node.Checked;
            }
        }

    }
}
