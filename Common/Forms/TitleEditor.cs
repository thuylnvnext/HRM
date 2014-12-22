using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraRichEdit.API.Native;
using Database;

namespace Common.Forms
{
    public partial class TitleEditor : XtraForm
    {
        private string parent, name, value;

        public TitleEditor(string parent, string name, string value)
        {
            InitializeComponent();
            this.parent = parent;
            this.name = name;
            this.value = value;
            Utility.SetSkin(this);
        }

        public string GetValue
        {
            get
            {
                return recValue.Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void TitleEditor_Load(object sender, EventArgs e)
        {
            recValue.Text = value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TitleTable title = new TitleTable();
            TitleRow tr;
            title.GetContent();
            tr = title.FindByPrimaryKey(string.Format("{0}.{1}", parent, name), Constant.language);
            if (tr == null)
            {
                tr = (TitleRow)title.NewRow();
                tr.Item = string.Format("{0}.{1}", parent, name);
                tr.Language = Constant.language;
                tr.Value = recValue.Text;
                title.AddTitleRow(tr);
            }
            else
                tr.Value = recValue.Text;
            if (title.Insert() && title.Update())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TITLE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_TITLE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) new Common.Forms.SetTitle(sender, Name).ShowDialog();
        }
    }
}
