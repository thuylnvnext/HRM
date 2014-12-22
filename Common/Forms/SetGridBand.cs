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
using DevExpress.XtraEditors;

namespace Common
{
    public partial class SetGridBand : XtraForm
    {
        private GridBand grb;
        private IBandedGridViewParent parent;

        public SetGridBand()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public SetGridBand(GridBand grb, IBandedGridViewParent parent)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.grb = grb;
            this.parent = parent;
        }

        private void FillData()
        {
            txtCaption.Text = grb.Caption;
            txtRowCount.Text = grb.RowCount.ToString();
            txtWidth.Text = grb.Width.ToString();
            cleBackColor.Color = grb.AppearanceHeader.BackColor;
        }

        public void FillData(GridBand gridBand)
        {
            grb = gridBand;
            txtCaption.Text = grb.Caption;
            txtRowCount.Text = grb.RowCount.ToString();
            txtWidth.Text = grb.Width.ToString();
            cleBackColor.Color = grb.AppearanceHeader.BackColor;

            txtCaption.Focus();
        }

        private void SaveData()
        {
            grb.Caption = txtCaption.Text;
            grb.RowCount = Convert.ToInt32(txtRowCount.Text);
            grb.Width = Convert.ToInt32(txtWidth.Text);
            grb.AppearanceHeader.BackColor = cleBackColor.Color;
            parent.NextGridBand();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void SetGridBand_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void txtRowCount_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtRowCount.Text != grb.RowCount.ToString());
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtCaption.Text != grb.Caption);
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtWidth.Text != grb.Width.ToString());
        }

        private void cleBackColor_EditValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (cleBackColor.Color != grb.AppearanceHeader.BackColor);
        }

        private void cleBackColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) cleBackColor.Color = new Color();
        }
    }
}
