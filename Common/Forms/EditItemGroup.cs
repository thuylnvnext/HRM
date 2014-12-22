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
    public partial class EditItemGroup : XtraForm
    {
        private TreeNode selectedNode;
        private ItemGroupT itemGroup;
        private ItemGroupR igr;

        public EditItemGroup()
        {
            InitializeComponent();
        }

        public EditItemGroup(ItemGroupT itemGroup, TreeNode selectedNode)
        {
            InitializeComponent();            
            this.itemGroup = itemGroup;
            this.selectedNode = selectedNode;
            Utility.SetSkin(this);
        }

        private void FillItemGroup()
        {
            igr = itemGroup.FindByID(selectedNode.Name);
            txtID.Text = igr.ID;
            txtName.Text = igr.Name;
            if (!igr.IsSortOrderNull()) txtSortOrder.Text = igr.SortOrder.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            igr.ID = txtID.Text;
            igr.Name = txtName.Text;
            if (Utility.IsNumeric(txtSortOrder.Text)) igr.SortOrder = Convert.ToByte(txtSortOrder.Text);
            if (itemGroup.Update())
            {
                if (selectedNode.Text != txtName.Text) selectedNode.Text = txtName.Text;
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEMGROUP_EDIT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ITEMGROUP_EDIT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditItemGroup_Load(object sender, EventArgs e)
        {
            itemGroup.GetContent();
            FillItemGroup();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtID.Text != string.Empty && txtID.Text != igr.ID);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtName.Text != string.Empty && txtName.Text != igr.Name);
        }

        private void txtSortOrder_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtSortOrder.Text != igr.SortOrder.ToString());
        }
    }
}