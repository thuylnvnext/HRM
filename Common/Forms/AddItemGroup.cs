using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraEditors;

namespace Common.Forms
{
    public partial class AddItemGroup : XtraForm
    {
        private TreeNode parent;
        private ItemGroupT itemGroup;

        public AddItemGroup()
        {
            InitializeComponent();            
        }

        public AddItemGroup(TreeNode parent, ItemGroupT itemGroup)
        {
            InitializeComponent();            
            this.parent = parent;
            this.itemGroup = itemGroup;
            Utility.SetSkin(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ItemGroupR igr = (ItemGroupR)itemGroup.NewRow();
            igr.ParentID = (parent.Parent == null ? "ROOT" : parent.Name);
            igr.ID = txtID.Text;
            igr.Name = txtName.Text;
            igr.SortOrder = Utility.IsNumeric(txtSortOrder.Text) ? Convert.ToByte(txtSortOrder.Text) : Convert.ToByte(0);
            itemGroup.AddItemGroupRow(igr);
            if (itemGroup.Insert())
            {
                parent.Nodes.Add(txtID.Text, txtName.Text, 0, 0);
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEMGROUP_ADD_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEMGROUP_ADD_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtID.Text != string.Empty);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (itemGroup.FindByID(txtID.Text) != null)
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEMGROUP_EXSIT", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }
    }
}