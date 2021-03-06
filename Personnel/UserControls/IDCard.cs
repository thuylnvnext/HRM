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
    public partial class IDCard : XtraUserControl
    {
        private int employeeID = 0;
        private Forms.EmployeeInfo parentForm;
        private IdentificationTable identification = new IdentificationTable();
        //private PassportTable passport = new PassportTable();
        private BankAccountTable bankAccount = new BankAccountTable();

        public IDCard()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public IDCard(int employeeID, Forms.EmployeeInfo parentForm)
        {
            InitializeComponent();            
            this.employeeID = employeeID;
            this.parentForm = parentForm;
            Utility.SetSkin(this);
        }

        private void InitLookUp()
        {
            ileBankID.DataSource = BankTable.GetContentTable();
            ileBankID.DisplayMember = "Name";
            ileBankID.ValueMember = "ID";
        }

        private void FillData()
        {
            IdentificationRow ir = identification.FindByPrimaryKey(employeeID);
            if (ir != null)
            {
                txtIDNumber.Text = ir.No;
                if (!ir.IsIssuedDateNull())
                    if (ir.IssuedDate.ToString("MM/dd/yyyy") == "12/31/9999")
                        dedIssuedDate.EditValue = null;
                    else
                        dedIssuedDate.DateTime = ir.IssuedDate;
                txtIssuedPlace.Text = ir.IssuedPlace;
            }
            else
            {
                txtIDNumber.Text = string.Empty;
                dedIssuedDate.EditValue = null;
                txtIssuedPlace.Text = string.Empty;
            }

            //PassportRow pr = passport.FindByPrimaryKey(employeeID);
            //if (pr != null)
            //{
            //    txtPassportNumber.Text = pr.No;
            //    if (pr.IssuedDate.ToString("MM/dd/yyyy") == "12/31/9999")
            //        dedPassportIssuedDate.EditValue = null;
            //    else
            //        dedPassportIssuedDate.DateTime = pr.IssuedDate;
            //    if (pr.ExpiredDate.ToString("MM/dd/yyyy") == "12/31/9999")
            //        dedExpiredDate.EditValue = null;
            //    else
            //        if (!pr.IsExpiredDateNull()) dedExpiredDate.DateTime = pr.ExpiredDate;
            //    txtPassportIssuedPlace.Text = pr.IssuedPlace;
            //}
            //else
            //{
            //    txtPassportNumber.Text = string.Empty;
            //    dedPassportIssuedDate.EditValue = null;
            //    dedExpiredDate.EditValue = null;
            //    txtPassportIssuedPlace.Text = string.Empty;
            //}

            bankAccount.GetListByEmployeeID(employeeID);
            grdBankAccount.DataSource = bankAccount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IdentificationRow ir = identification.FindByPrimaryKey(employeeID);
            if (ir != null)
            {
                ir.No = txtIDNumber.Text;
                if (dedIssuedDate.EditValue != null)
                    ir.IssuedDate = dedIssuedDate.DateTime;
                else
                    ir.IssuedDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
                ir.IssuedPlace = txtIssuedPlace.Text;
                if (!identification.Update()) 
                {
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (txtIDNumber.Text != string.Empty)
                {
                    ir = (IdentificationRow)identification.NewRow();
                    ir.EmployeeID = employeeID;
                    ir.No = txtIDNumber.Text;
                    if (dedIssuedDate.EditValue != null)
                        ir.IssuedDate = dedIssuedDate.DateTime;
                    else
                        ir.IssuedDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
                    ir.IssuedPlace = txtIssuedPlace.Text;
                    identification.AddIdentificationRow(ir);
                    if (!identification.Insert())
                    {
                        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //PassportRow pr = passport.FindByPrimaryKey(employeeID);
            //if (pr != null)
            //{
            //    pr.No = txtPassportNumber.Text;
            //    if (dedPassportIssuedDate.EditValue != null)
            //        pr.IssuedDate = dedPassportIssuedDate.DateTime;
            //    else
            //        pr.IssuedDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            //    if (dedExpiredDate.EditValue != null)
            //        pr.ExpiredDate = dedExpiredDate.DateTime;
            //    else
            //        pr.ExpiredDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            //    pr.IssuedPlace = txtPassportIssuedPlace.Text;
            //    if (!passport.Update())
            //    {
            //        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            //else
            //{
            //    if (txtPassportNumber.Text != string.Empty)
            //    {
            //        pr = (PassportRow)passport.NewRow();
            //        pr.EmployeeID = employeeID;
            //        pr.No = txtPassportNumber.Text;
            //        if (dedPassportIssuedDate.EditValue != null)
            //            pr.IssuedDate = dedPassportIssuedDate.DateTime;
            //        else
            //            pr.IssuedDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            //        if (dedExpiredDate.EditValue != null)
            //            pr.ExpiredDate = dedExpiredDate.DateTime;
            //        else
            //            pr.ExpiredDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            //        pr.IssuedPlace = txtPassportIssuedPlace.Text;
            //        passport.AddPassportRow(pr);
            //        if (!passport.Insert())
            //        {
            //            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }
            //}

            if (!bankAccount.Insert())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bankAccount.Update())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            parentForm.ShowData(Constant.departmentIDList, true);
            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("SAVE_INFODETAILS_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IDCard_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;

            identification.GetContent();
            //passport.GetContent();

            InitLookUp();
            FillData();
        }

        private void grvBankAccount_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void grvBankAccount_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvBankAccount.SetRowCellValue(e.RowHandle, "EmployeeID", employeeID);
        }

        private void grvBankAccount_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            e.ErrorText = "Bạn phải nhập đủ 13 chữ số";
        }
    }
}
