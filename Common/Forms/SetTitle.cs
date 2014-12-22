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
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;

namespace Common.Forms
{
    public partial class SetTitle : XtraForm
    {
        private object ctl;
        private string path = string.Empty;

        public SetTitle()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public SetTitle(object ctl)
        {
            InitializeComponent();            
            this.ctl = ctl;
            Utility.SetSkin(this);
        }

        public SetTitle(object ctl, string path)
        {
            InitializeComponent();
            this.ctl = ctl;
            this.path = path;
            Utility.SetSkin(this);
        }

        private void FillData()
        {
            //txtCaption.Text = grc.Caption;
            //switch (grc.AppearanceCell.HAlignment)
            //{
            //    case DevExpress.Utils.HorzAlignment.Near:
            //        cboLanguage.SelectedIndex = 0;
            //        break;
            //    case DevExpress.Utils.HorzAlignment.Center:
            //        cboLanguage.SelectedIndex = 1;
            //        break;
            //    case DevExpress.Utils.HorzAlignment.Far:
            //        cboLanguage.SelectedIndex = 2;
            //        break;
            //}
        }

        public void FillData(GridColumn gridColumn)
        {
            //grc = gridColumn;
            //txtCaption.Text = grc.Caption;
            //switch (grc.AppearanceCell.TextOptions.HAlignment)
            //{
            //    case DevExpress.Utils.HorzAlignment.Near:
            //        cboLanguage.SelectedIndex = 0;
            //        break;
            //    case DevExpress.Utils.HorzAlignment.Center:
            //        cboLanguage.SelectedIndex = 1;
            //        break;
            //    case DevExpress.Utils.HorzAlignment.Far:
            //        cboLanguage.SelectedIndex = 2;
            //        break;
            //}

            //txtCaption.Focus();
        }

        private void SaveData()
        {
            //grc.Caption = txtCaption.Text;
            //grc.AppearanceCell.TextOptions.HAlignment = GetAlignmentFromIndex(cboLanguage.SelectedIndex);
            //parent.NextGridColumn();
            TitleTable title = new TitleTable();
            title.GetContent();
            string name = string.Empty;
            if (ctl is XtraForm) name = ((XtraForm)ctl).Name;
            if (ctl is RibbonPage) name = ((RibbonPage)ctl).Name;
            if (ctl is RibbonPageGroup) name = ((RibbonPageGroup)ctl).Name;
            if (ctl is BarButtonItemLink) name = ((BarButtonItemLink)ctl).Item.Name;
            if (ctl is Label) name = ((Label)ctl).Name;
            if (ctl is CheckEdit) name = ((CheckEdit)ctl).Name;
            if (ctl is GroupControl) name = ((GroupControl)ctl).Name;
            if (ctl is SimpleButton) name = ((SimpleButton)ctl).Name;
            if (ctl is DockPanel) name = ((DockPanel)ctl).Name;
            if (ctl is RadioGroup) name = ((RadioGroup)ctl).Name + "." + ((RadioGroup)ctl).SelectedIndex.ToString();

            TitleRow tr = title.FindByPrimaryKey(path == string.Empty ? name : path + "." + name, cboLanguage.Text);
            if (tr != null)
            {
                tr.Value = txtCaption.Text;
                title.Update();
            }
            else
            {
                tr = (TitleRow)title.NewRow();
                if (path == string.Empty)
                    tr.Item = name;
                else
                    tr.Item = path + "." + name;
                tr.Language = cboLanguage.Text;
                tr.Value = txtCaption.Text;
                title.AddTitleRow(tr);
                title.Insert();
            }
            if (ctl is XtraForm) ((XtraForm)ctl).Text = txtCaption.Text;
            if (ctl is RibbonPage) ((RibbonPage)ctl).Text = txtCaption.Text;
            if (ctl is RibbonPageGroup) ((RibbonPageGroup)ctl).Text = txtCaption.Text;
            if (ctl is BarButtonItemLink) ((BarButtonItemLink)ctl).Caption = txtCaption.Text;
            if (ctl is Label) ((Label)ctl).Text = txtCaption.Text;
            if (ctl is CheckEdit) ((CheckEdit)ctl).Text = txtCaption.Text;
            if (ctl is GroupControl) ((GroupControl)ctl).Text = txtCaption.Text;
            if (ctl is SimpleButton) ((SimpleButton)ctl).Text = txtCaption.Text;
            if (ctl is DockPanel) ((DockPanel)ctl).Text = txtCaption.Text;
            if (ctl is RadioGroup) ((RadioGroup)ctl).Properties.Items[((RadioGroup)ctl).SelectedIndex].Description = txtCaption.Text;
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

        private void SetTitle_Load(object sender, EventArgs e)
        {
            foreach (TitleRow tr in TitleTable.GetLanguages())
            {
                cboLanguage.Properties.Items.Add(tr.Language);
            }
            cboLanguage.Text = Constant.language;
            if (ctl is XtraForm) txtCaption.Text = ((XtraForm)ctl).Text;
            if (ctl is RibbonPage) txtCaption.Text = ((RibbonPage)ctl).Text;
            if (ctl is RibbonPageGroup) txtCaption.Text = ((RibbonPageGroup)ctl).Text;
            if (ctl is BarButtonItemLink) txtCaption.Text = ((BarButtonItemLink)ctl).Caption;
            if (ctl is Label) txtCaption.Text = ((Label)ctl).Text;
            if (ctl is CheckEdit) txtCaption.Text = ((CheckEdit)ctl).Text;
            if (ctl is GroupControl) txtCaption.Text = ((GroupControl)ctl).Text;
            if (ctl is SimpleButton) txtCaption.Text = ((SimpleButton)ctl).Text;
            if (ctl is DockPanel) txtCaption.Text = ((DockPanel)ctl).Text;
            if (ctl is RadioGroup) txtCaption.Text = ((RadioGroup)ctl).Properties.Items[((RadioGroup)ctl).SelectedIndex].Description;
            //FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();

            //Stream s = new MemoryStream();
            //((GridView)grc.View).SaveLayoutToStream(s);
            //s.Position = 0;
            //StreamReader r = new StreamReader(s);

            //LayoutTable layout = new LayoutTable();
            //LayoutRow lr;
            //layout.GetContent();
            //lr = layout.FindByPrimaryKey(parent.GetName(), 0, 0, Constant.language);
            //if (lr == null)
            //{
            //    layout.AddLayoutRow(parent.GetName(), 0, 0, Constant.language, r.ReadToEnd());
            //    if (layout.Insert())
            //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    lr.Value = r.ReadToEnd();
            //    if (layout.Update())
            //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("LAYOUT_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            //btnSave.Enabled = (txtCaption.Text != ctl.Text);
        }

        private void cboAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnSave.Enabled = (GetAlignmentFromIndex(cboLanguage.SelectedIndex) != grc.AppearanceCell.TextOptions.HAlignment);
        }
    }
}
