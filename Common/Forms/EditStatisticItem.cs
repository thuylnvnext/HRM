using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Common;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace Common.Forms
{
    public partial class EditStatisticItem : XtraForm
    {
        private StatisticItem parent;
        private BandedGridColumn col;
        private GridBand grb;
        private StatisticItemT statisticItem;
        private StatisticItemR tir;
        private ItemT item;

        public EditStatisticItem(StatisticItem parent, ItemT item, StatisticItemT statisticItem)
        {
            InitializeComponent();
            this.parent = parent;
            this.item = item;
            this.statisticItem = statisticItem;
            Utility.SetSkin(this);
        }

        private void ShowItem()
        {
            item.GetContent();
            item.DefaultView.RowFilter = "Status = 1";
            foreach (ItemR ir in item)
            {
                ir.ID = "[" + ir.ID + "]";
            }
            ccbValue.Properties.DataSource = item;
            ccbValue.Properties.ValueMember = "ID";
            ccbValue.Properties.DisplayMember = "Name";
            ccbValue.Properties.GetItems();
        }

        public void ShowStatisticItem(BandedGridColumn col, GridBand grb)
        {
            this.col = col;
            this.grb = grb;
            if (col != null) 
            {
                txtName.Text = col.Caption;
                tir = statisticItem.FindByID(col.FieldName);
                if (tir != null)
                {
                    if (tir.Value == string.Empty)
                    {
                        cboFunction.SelectedIndex = -1;
                        string text = tir.ComputedValue;
                        string[] values = text.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string value in values)
                        {
                            text = text.Replace(value, "[" + Convert(value.Substring(1, value.Length - 2), false) + "]");
                        }
                        mmeComputedValue.Text = text;
                    }
                    else
                    {
                        mmeComputedValue.Text = string.Empty;
                        cboFunction.SelectedIndex = (tir.ComputedValue == "S" ? 0 : 1);
                    }
                }
                ccbValue.SetEditValue(tir.Value);
            }
            if (grb != null)
            {
                txtName.Text = grb.Caption;
                ccbValue.SetEditValue(string.Empty);
                cboFunction.SelectedIndex = -1;
                mmeComputedValue.Text = string.Empty;
                tir = statisticItem.FindByID(grb.Name);
                ccbValue.Enabled = false;
                cboFunction.Enabled = false;
                mmeComputedValue.Enabled = false;
            }
            else
            {
                ccbValue.Enabled = true;
                cboFunction.Enabled = true;
                mmeComputedValue.Enabled = true;
            }

        }

        public void SetComputedValue(string value)
        {
            mmeComputedValue.Text += "[" + value + "]";
        }

        private string Convert(string value, bool nameToID)
        {
            string retVal = string.Empty;
            if (nameToID)
            {
                foreach (StatisticItemR tir in statisticItem)
                {
                    if (tir.Name == value)
                    {
                        retVal = tir.ID;
                        break;
                    }
                }
            }
            else
            {
                foreach (StatisticItemR tir in statisticItem)
                {
                    if (tir.ID == value)
                    {
                        retVal = tir.Name;
                        break;
                    }
                }
            }
            return retVal;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tir.Name != txtName.Text)
            {
                tir.Name = txtName.Text;
                if (col != null)
                {
                    col.Caption = txtName.Text;
                    col.OwnerBand.Caption = txtName.Text;
                }
                if (grb != null) grb.Caption = txtName.Text;
            }
            if (col != null)
            {
                if (tir.Value != ccbValue.EditValue.ToString()) tir.Value = ccbValue.EditValue.ToString();
                if (ccbValue.EditValue.ToString() != string.Empty && tir.ComputedValue != (cboFunction.SelectedIndex == 0 ? "S" : "C")) tir.ComputedValue = cboFunction.SelectedIndex == 0 ? "S" : "C";
                if (ccbValue.EditValue.ToString() == string.Empty)
                {
                    string[] values = mmeComputedValue.Text.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string text = mmeComputedValue.Text;
                    foreach (string value in values)
                    {
                        text = text.Replace(value, "[" + Convert(value.Substring(1, value.Length - 2), true) + "]");
                    }
                    if (tir.ComputedValue != text) tir.ComputedValue = text;
                }
            }
            if (statisticItem.Update())
            {
                parent.ShowData(Constant.departmentIDList, true);
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("EDIT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("EDIT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void EditStatisticItem_Load(object sender, EventArgs e)
        {
            if (item != null) ShowItem();            
        }
    }
}
