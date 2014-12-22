using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraEditors;

namespace Personnel.UserControls
{
    public partial class Phone : XtraUserControl
    {
        private int employeeID = 0;
        private PhoneTable phone = new PhoneTable();

        public Phone()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public Phone(int employeeID)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeID = employeeID;
        }

        private void InitLookUp()
        {
            ilePhoneType.DataSource = PhoneTypeTable.GetContentTable();
            ilePhoneType.DisplayMember = "Name";
            ilePhoneType.ValueMember = "ID";
            ilePhoneType.BestFit();
        }

        private void DeletePhone()
        {
            DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_INFODETAILS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                grvPhone.DeleteRow(grvPhone.FocusedRowHandle);
                phone.Delete();
            }
        }

        private void Phone_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;

            InitLookUp();

            phone.GetListByEmployeeID(employeeID);
            grdPhone.DataSource = phone;
            grvPhone.BestFitColumns();            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            retVal1 = phone.Insert();
            retVal2 = phone.Update();
            if (retVal1 && retVal2)
                MessageBox.Show(TitleTable.GetValue("SAVE_INFODETAILS_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }

        private void grvPhone_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePhone();
        }

        private void grvPhone_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvPhone.SetRowCellValue(e.RowHandle, "EmployeeID", employeeID);
        }
    }
}