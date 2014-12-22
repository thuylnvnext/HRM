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
    public partial class SystemOption : XtraUserControl
    {
        public SystemOption()
        {
            InitializeComponent();
        }

        private void SystemOption_Load(object sender, EventArgs e)
        {
            chkAutoUpdate.Checked = ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\AutoUpdate", "AutoUpdate", null) == "Y");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\AutoUpdate", "AutoUpdate", chkAutoUpdate.Checked ? "Y" : "N");
            }
            catch
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SYSTEM_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_SYSTEM_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
