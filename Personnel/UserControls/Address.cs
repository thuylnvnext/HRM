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
    public partial class Address : XtraUserControl
    {
        private int employeeID = 0;
        private Forms.EmployeeInfo parentForm;
        private AddressTable address = new AddressTable();

        public Address()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public Address(int employeeID, Forms.EmployeeInfo parentForm)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeID = employeeID;
            this.parentForm = parentForm;
        }

        private void InitLookUp()
        {
            ileAddressType.DataSource = AddressTypeTable.GetContentTable();
            ileAddressType.DisplayMember = "Name";
            ileAddressType.ValueMember = "ID";
            ileAddressType.BestFit();
        }

        private void DeleteAddress()
        {
            DialogResult retVal = MessageBox.Show(TitleTable.GetValue("DELETE_INFODETAILS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                grvAddress.DeleteRow(grvAddress.FocusedRowHandle);
                address.Delete();
            }
        }

        private void Address_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;

            InitLookUp();

            address.GetListByEmployeeID(employeeID);            
            grdAddress.DataSource = address;
            grvAddress.BestFitColumns();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool retVal1, retVal2;
            retVal1 = address.Insert();
            retVal2 = address.Update();
            if (retVal1 && retVal2)
            {
                parentForm.ShowData(Constant.departmentIDList, true);
                MessageBox.Show(TitleTable.GetValue("SAVE_INFODETAILS_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void grvAddress_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void grvAddress_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvAddress.SetRowCellValue(e.RowHandle, "EmployeeID", employeeID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            DeleteAddress();
        }
    }
}