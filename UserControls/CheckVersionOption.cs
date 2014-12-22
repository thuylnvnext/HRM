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
    public partial class CheckVersionOption : XtraUserControl
    {

        private const string PATH = @"HKEY_CURRENT_USER\Software\HRMplus\AutoUpdate";
        //1: Automatic
        //2: CheckAndDownload
        //3: OnlyCheck
        //4: DoNothing
        public CheckVersionOption()
        {
            InitializeComponent();
            this.LoadConfigUpdateType();
        }

        private void LoadConfigUpdateType()
        {
            String UpdateType = (string)Registry.GetValue(PATH, "UpdateType", null);
            if (String.IsNullOrEmpty(UpdateType))
                radioGroup.EditValue = "Automatic";
            else
                radioGroup.EditValue = UpdateType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                Registry.SetValue(PATH, "UpdateType", radioGroup.EditValue);
            }
            catch
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_CHECKVERSION_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_CHECKVERSION_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

    }
}
