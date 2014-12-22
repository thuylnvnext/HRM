using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Microsoft.Win32;
using Common;

namespace HRMplus.Forms
{
    public partial class Options : DevExpress.XtraEditors.XtraForm
    {
        public Options()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void Options_Load(object sender, EventArgs e)
        {
            Utility.SetPermission(this);
        }     
    }
}
