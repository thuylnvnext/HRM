using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using Common;
using DevExpress.XtraEditors;

namespace HRMplus.Forms
{
    public partial class Permission : XtraForm
    {
        private RightOfGroupTable rightOfGroup = new RightOfGroupTable(); 
        private byte groupID;
   
        public Permission()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public Permission(byte groupID)
        {            
            InitializeComponent();
            this.groupID = groupID;
            rightOfGroup.GetListByGroupID(groupID, -1);
            Utility.SetSkin(this);            
        }

        public RightOfGroupTable RightOfGroup
        {
            get
            {
                return rightOfGroup;
            }
        }

        public byte GroupID
        {
            get
            {
                return groupID;
            }
        }

        private void Permission_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);
        }
              
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}