using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using Microsoft.Win32;
using DevExpress.XtraEditors;

namespace HRMplus.UserControls
{
    public partial class DisplayOption : XtraUserControl
    {
        public DisplayOption()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            foreach (TitleRow tr in TitleTable.GetLanguages())
            {
                cboLanguage.Properties.Items.Add(tr.Language);
            }
            cboLanguage.Text = Constant.language;
            cboSkin.Text = Constant.skin;
        }

        private void btnChangeTitle_Click(object sender, EventArgs e)
        {
            new Forms.ChangeTitle().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\Language", "Language", cboLanguage.Text);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\Skin", "Skin", cboSkin.Text);
                Constant.language = cboLanguage.Text;
                Constant.skin = cboSkin.Text;
            }
            catch
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_DISPLAY_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_DISPLAY_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retVal == DialogResult.Yes) Application.Restart();
            }
        }

        private void cboSkin_SelectedValueChanged(object sender, EventArgs e)
        {
            Utility.SetSkin(ParentForm, cboSkin.SelectedItem.ToString());
        }
    }
}
