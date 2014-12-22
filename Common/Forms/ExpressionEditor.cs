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

namespace Common.Forms
{
    public partial class ExpressionEditor : XtraForm
    {
        private string value;
        private List<Operator> operators;
        private List<Function> functions;

        public ExpressionEditor(string value, List<Operator> operators, List<Function> functions)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.value = value;
            this.operators = operators;
            this.functions = functions;
        }

        public string GetValue
        {
            get
            {
                return recValue.Text;
            }
        }

        private void ShowList(int index)
        {
            if (index == 0)
                lbcDetail.DataSource = functions;
            else
                lbcDetail.DataSource = operators;

            lbcDetail.ValueMember = "ID";
            lbcDetail.DisplayMember = "Name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void ExpressionEditor_Load(object sender, EventArgs e)
        {
            recValue.Text = value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void lbcCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowList(lbcCategory.SelectedIndex);
        }

        private void lbcDetail_DoubleClick(object sender, EventArgs e)
        {
            if (lbcCategory.SelectedIndex == 0)
            {
                int oldPos = recValue.Document.CaretPosition.ToInt(), newPos;
                string value = lbcDetail.SelectedValue.ToString();

                newPos = oldPos + value.IndexOf('(') + 1;
                recValue.Document.InsertText(recValue.Document.CreatePosition(oldPos), value);
                recValue.Document.CaretPosition = recValue.Document.CreatePosition(newPos);
            }
            else
            {
                recValue.Document.InsertText(recValue.Document.CaretPosition, lbcDetail.SelectedValue.ToString());
            }
            recValue.Focus();
        }
    }
}
