using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraEditors;

namespace Personnel.Forms
{
    public partial class DisplayOptions : XtraForm
    {
        private EmployeeInfoListTable displayOptions = new EmployeeInfoListTable();

        public DisplayOptions()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void InitLookUp()
        {
            Classes.Alignments alignments = new Classes.Alignments();
            alignments.Add(new Classes.Alignment(1, "Trái"));
            alignments.Add(new Classes.Alignment(2, "Giữa"));
            alignments.Add(new Classes.Alignment(3, "Phải"));
            ileAlignment.DataSource = alignments;
            ileAlignment.ValueMember = "ID";
            ileAlignment.DisplayMember = "Name";
            ileAlignment.BestFit();
        }

        private void FillDisplayOptions()
        {
            InitLookUp();
            displayOptions.GetContent();
            grdDisplayOptions.DataSource = displayOptions;
            grvDisplayOptions.BestFitColumns();
        }

        private void DisplayOptions_Load(object sender, EventArgs e)
        {
            FillDisplayOptions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void grvDisplayOptions_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData) e.Value = e.RowHandle + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (displayOptions.Update())
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DISPLAYOPTIONS_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DISPLAYOPTIONS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
