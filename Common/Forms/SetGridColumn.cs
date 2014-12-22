using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace Common.Forms
{
    public partial class SetGridColumn : XtraForm
    {
        private GridColumn grc;
        private IGridViewParent parent;

        public SetGridColumn()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public SetGridColumn(GridColumn grc, IGridViewParent parent)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.grc = grc;
            this.parent = parent;
        }

        private void FillData()
        {
            txtCaption.Text = grc.Caption;
            switch (grc.AppearanceCell.HAlignment)
            {
                case DevExpress.Utils.HorzAlignment.Near:
                    cboAlignment.SelectedIndex = 0;
                    break;
                case DevExpress.Utils.HorzAlignment.Center:
                    cboAlignment.SelectedIndex = 1;
                    break;
                case DevExpress.Utils.HorzAlignment.Far:
                    cboAlignment.SelectedIndex = 2;
                    break;
            }
        }

        public void FillData(GridColumn gridColumn)
        {
            grc = gridColumn;
            txtCaption.Text = grc.Caption;
            switch (grc.AppearanceCell.TextOptions.HAlignment)
            {
                case DevExpress.Utils.HorzAlignment.Near:
                    cboAlignment.SelectedIndex = 0;
                    break;
                case DevExpress.Utils.HorzAlignment.Center:
                    cboAlignment.SelectedIndex = 1;
                    break;
                case DevExpress.Utils.HorzAlignment.Far:
                    cboAlignment.SelectedIndex = 2;
                    break;
            }

            txtCaption.Focus();
        }

        private void SaveData()
        {
            grc.Caption = txtCaption.Text;
            grc.AppearanceCell.TextOptions.HAlignment = GetAlignmentFromIndex(cboAlignment.SelectedIndex);
            parent.NextGridColumn();
        }

        private DevExpress.Utils.HorzAlignment GetAlignmentFromIndex(int index)
        {
            DevExpress.Utils.HorzAlignment alignment = DevExpress.Utils.HorzAlignment.Default;
            switch (index)
            {
                case 0:
                    alignment = DevExpress.Utils.HorzAlignment.Near;
                    break;
                case 1:
                    alignment = DevExpress.Utils.HorzAlignment.Center;
                    break;
                case 2:
                    alignment = DevExpress.Utils.HorzAlignment.Far;
                    break;
            }
            return alignment;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void SetGridColumn_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();

            Stream s = new MemoryStream();
            ((GridView)grc.View).SaveLayoutToStream(s);
            s.Position = 0;
            StreamReader r = new StreamReader(s);

            LayoutTable layout = new LayoutTable();
            LayoutRow lr;
            layout.GetContent();
            lr = layout.FindByPrimaryKey(parent.GetName(), 0, 0, Constant.language);
            if (lr == null)
            {
                layout.AddLayoutRow(parent.GetName(), 0, 0, Constant.language, r.ReadToEnd());
                if (layout.Insert())
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lr.Value = r.ReadToEnd();
                if (layout.Update())
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtCaption.Text != grc.Caption);
        }

        private void cboAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (GetAlignmentFromIndex(cboAlignment.SelectedIndex) != grc.AppearanceCell.TextOptions.HAlignment);
        }
    }
}
