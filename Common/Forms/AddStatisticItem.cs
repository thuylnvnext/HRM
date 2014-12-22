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
    public partial class AddStatisticItem : XtraForm
    {
        private string parentID;
        private StatisticItem parent;
        private StatisticItemT statisticItem;
        private ItemT item;

        public AddStatisticItem(StatisticItem parent, ItemT item, StatisticItemT statisticItem, string parentID)
        {
            InitializeComponent();
            this.parent = parent;
            this.item = item;
            this.statisticItem = statisticItem;
            this.parentID = parentID;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            StatisticItemR tir = statisticItem.AddStatisticItemRow(parentID, statisticItem.GetNewID(), txtName.Text, ccbValue.EditValue.ToString(), ccbValue.EditValue.ToString() != string.Empty ? cboFunction.SelectedIndex == 0 ? "S" : "C" : mmeComputedValue.Text);
            if (statisticItem.Insert())
            {
                if (item != null)
                    parent.AddColumn(tir, false);
                else
                    parent.AddBand(tir.ID, tir.Name);
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void AddStatisticItem_Load(object sender, EventArgs e)
        {
            if (item != null)
            {
                ShowItem();
                cboFunction.SelectedIndex = 0;
            }
            else
            {
                ccbValue.Enabled = false;
                mmeComputedValue.Enabled = false;
            }
        }
    }
}
