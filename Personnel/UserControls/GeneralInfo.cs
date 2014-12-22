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
using System.Data.SqlClient;
using System.Collections;

namespace Personnel.UserControls
{
    public partial class GeneralInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private int employeeID = 0;
        private EmployeeTable employee = new EmployeeTable();
        private HealthStatusTable healthStatus = new HealthStatusTable();
        private CardTable card = new CardTable();
        private Forms.EmployeeInfo parentForm;
        private bool expand = true;

        public GeneralInfo()
        {
            InitializeComponent();
        }

        public GeneralInfo(int employeeID, Forms.EmployeeInfo parentForm)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.employeeID = employeeID;
            this.parentForm = parentForm;            
        }

        private void InitLookUp()
        {
            lueNationality.Properties.DataSource = NationalityTable.GetContentTable();
            lueNationality.Properties.DisplayMember = "Name";
            lueNationality.Properties.ValueMember = "ID";

            lueEthnicGroup.Properties.DataSource = EthnicGroupTable.GetContentTable();
            lueEthnicGroup.Properties.DisplayMember = "Name";
            lueEthnicGroup.Properties.ValueMember = "ID";

            lueReligion.Properties.DataSource = ReligionTable.GetContentTable();
            lueReligion.Properties.DisplayMember = "Name";
            lueReligion.Properties.ValueMember = "ID";

            lueMarriageStatus.Properties.DataSource = MarriageStatusTable.GetContentTable();
            lueMarriageStatus.Properties.DisplayMember = "Name";
            lueMarriageStatus.Properties.ValueMember = "ID";

            ArrayList iList = new ArrayList();
            iList.Add("Chính thức");
            iList.Add("Thử việc");

            lueType.Properties.DataSource = iList;
        }

        private void InitDateEdit()
        {
            dedBirthDate.DateTime = DateTime.Today;
            dedBirthDate.EditValue = null;
            dedDischargeDate.DateTime = DateTime.Today;
            dedDischargeDate.EditValue = null;
            dedEnlistingDate.DateTime = DateTime.Today;
            dedEnlistingDate.EditValue = null;
            dedPartyEnrollingDate.DateTime = DateTime.Today;
            dedPartyEnrollingDate.EditValue = null;
            dedUnionEnrollingDate.DateTime = DateTime.Today;
            dedUnionEnrollingDate.EditValue = null;
        }

        private void FillData()
        {
            InitLookUp();

            employee.GetListByID(employeeID);
            if (employee.Count > 0)
            {
                EmployeeRow er = employee[0];

                txtEmployeeCode.Text = er.Code;
                txtFullName.Text = er.FullName;
                if (!er.IsAliasNull()) txtAlias.Text = er.Alias;
                if (er.IsBirthDateNull() || er.BirthDate.ToString("dd/MM/yyyy") == "31/12/9999")
                    dedBirthDate.EditValue = null;
                else
                    dedBirthDate.DateTime = er.BirthDate;

                lueType.EditValue = er.Type == 1 ? "Chính thức" : "Thử việc";

                if (!er.IsSexNull()) rdgGender.SelectedIndex = (er.Sex ? 0 : 1);
                if (!er.IsNationalityIDNull()) lueNationality.EditValue = er.NationalityID;
                if (!er.IsEthnicGroupIDNull()) lueEthnicGroup.EditValue = er.EthnicGroupID;
                if (!er.IsReligionIDNull()) lueReligion.EditValue = er.ReligionID;
                if (!er.IsMarriageStatusIDNull()) lueMarriageStatus.EditValue = er.MarriageStatusID;
                if (!er.IsCultureLevelNull()) txtCultureLevel.Text = er.CultureLevel;
                if (er.IsUnionEnrollingDateNull() || er.UnionEnrollingDate.ToString("dd/MM/yyyy") == "31/12/9999")
                    dedUnionEnrollingDate.EditValue = null;
                else
                    dedUnionEnrollingDate.DateTime = er.UnionEnrollingDate;
                if (!er.IsUnionEnrollingPlaceNull()) txtUnionEnrollingPlace.Text = er.UnionEnrollingPlace;
                if (er.IsPartyEnrollingDateNull() || er.PartyEnrollingDate.ToString("dd/MM/yyyy") == "31/12/9999")
                    dedPartyEnrollingDate.EditValue = null;
                else
                    dedPartyEnrollingDate.DateTime = er.PartyEnrollingDate;
                if (!er.IsPartyEnrollingPlaceNull()) txtPartyEnrollingPlace.Text = er.PartyEnrollingPlace;
                if (er.IsEnlistingDateNull() || er.EnlistingDate.ToString("dd/MM/yyyy") == "31/12/9999")
                    dedEnlistingDate.EditValue = null;
                else
                    dedEnlistingDate.DateTime = er.EnlistingDate;
                if (er.IsDischargeDateNull() || er.DischargeDate.ToString("dd/MM/yyyy") == "31/12/9999")
                    dedDischargeDate.EditValue = null;
                else
                    dedDischargeDate.DateTime = er.DischargeDate;
                if (!er.IsReasonNull()) txtReason.Text = er.Reason;
                if (!er.IsEmailNull()) txtEmail.Text = er.Email;
                if (!er.IsNotesNull()) txtNotes.Text = er.Notes;
                if (!er.IsPhotoNull()) picPhoto.ImageLocation = er.Photo;

                healthStatus.GetListByEmployeeID(employeeID);
                if (healthStatus.Count > 0)
                {
                    txtHeight.Text = healthStatus[0].Height.ToString();
                    txtWeight.Text = healthStatus[0].Weight.ToString();
                    txtLeftVision.Text = healthStatus[0].LeftVision;
                    txtRightVision.Text = healthStatus[0].RightVision;
                    cboBloodGroup.Text = healthStatus[0].BloodGroup;
                }
                else
                {
                    txtHeight.Text = string.Empty;
                    txtWeight.Text = string.Empty;
                    txtLeftVision.Text = string.Empty;
                    txtRightVision.Text = string.Empty;
                    cboBloodGroup.Text = string.Empty;
                }
                card.Columns.Add(new DataColumn("Status", typeof(bool)));
                card.GetListByEmployeeID(employeeID);
                grdCardInfo.DataSource = card;
                grvCardInfo.BestFitColumns();
            }
        }

        private void DeleteCard()
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_CARD", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retVal == DialogResult.Yes)
            {
                Connection.GetConnection();
                Connection.Open();
                SqlTransaction tran = Connection.GetConnection().BeginTransaction();
                int enrollNumber = (int)grvCardInfo.GetFocusedRowCellValue("EnrollNumber");
                if (grvCardInfo.FocusedRowHandle > 0)
                {
                    CardRow cr = card[grvCardInfo.FocusedRowHandle - 1];
                    if (cr != null) cr.ToDate = card[grvCardInfo.FocusedRowHandle].ToDate;
                    card.Update(Connection.GetConnection(), tran);
                }
                if (card.Delete(Connection.GetConnection(), tran, (int)grvCardInfo.GetFocusedRowCellValue("EmployeeID"), (DateTime)grvCardInfo.GetFocusedRowCellValue("FromDate")))
                {
                    tran.Commit();
                    //Application.DoEvents();
                    //if (Reader.DeleteCard(enrollNumber, Connection.GetConnection(), tran))
                    //    tran.Commit();
                    //else
                    //{
                    //    tran.Rollback();
                    //    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_CARD_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                    tran.Rollback();
                Connection.Close();
            }
        }

        private bool CheckCardExist()
        {
            bool retVal = false;
            for (int i = 0; i < grvCardInfo.DataRowCount; i++)
            {
                if (grvCardInfo.GetRowCellValue(i, "ID") == DBNull.Value || grvCardInfo.GetRowCellValue(i, "ID").ToString() == string.Empty)
                {
                    break;
                }
                else
                {
                    if (card[i].RowState == DataRowState.Added && CardTable.CheckExist(grvCardInfo.GetRowCellValue(i, "ID").ToString(), Convert.ToDateTime(grvCardInfo.GetRowCellValue(i, "FromDate"))))
                    {
                        retVal = true;
                        break;
                    }
                    if (card[i].RowState != DataRowState.Added && card[i]["ID"] != card[i]["ID", DataRowVersion.Original] && CardTable.CheckExist(grvCardInfo.GetRowCellValue(i, "ID").ToString(), Convert.ToDateTime(grvCardInfo.GetRowCellValue(i, "FromDate"))))
                    {
                        retVal = true;
                        break;
                    }
                }
            }

            return retVal;
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            ofdLoadPhoto.ShowDialog();
            picPhoto.ImageLocation = ofdLoadPhoto.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeRow er = employee[0];
            bool retVal1, retVal2, retVal3;

            er.Code = txtEmployeeCode.Text;
            er.FullName = txtFullName.Text;
            er.Alias = txtAlias.Text;
            if (dedBirthDate.EditValue != null)
                er.BirthDate = Convert.ToDateTime(dedBirthDate.DateTime);
            else
                er.BirthDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            er.Sex = (rdgGender.SelectedIndex == 0);
            if (lueNationality.EditValue != null) er.NationalityID = lueNationality.EditValue.ToString();
            if (lueEthnicGroup.EditValue != null) er.EthnicGroupID = lueEthnicGroup.EditValue.ToString();
            if (lueReligion.EditValue != null) er.ReligionID = lueReligion.EditValue.ToString();
            if (lueMarriageStatus.EditValue != null) er.MarriageStatusID = lueMarriageStatus.EditValue.ToString();
            er.CultureLevel = txtCultureLevel.Text;
            if (dedUnionEnrollingDate.EditValue != null)
                er.UnionEnrollingDate = Convert.ToDateTime(dedUnionEnrollingDate.DateTime);
            else
                er.UnionEnrollingDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            er.UnionEnrollingPlace = txtUnionEnrollingPlace.Text;
            if (dedPartyEnrollingDate.EditValue != null)
                er.PartyEnrollingDate = Convert.ToDateTime(dedPartyEnrollingDate.DateTime);
            else
                er.PartyEnrollingDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            er.PartyEnrollingPlace = txtPartyEnrollingPlace.Text;
            if (dedEnlistingDate.EditValue != null)
                er.EnlistingDate = Convert.ToDateTime(dedEnlistingDate.DateTime);
            else
                er.EnlistingDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            if (dedDischargeDate.EditValue != null)
                er.DischargeDate = Convert.ToDateTime(dedDischargeDate.DateTime);
            else
                er.DischargeDate = Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN"));
            er.Reason = txtReason.Text;
            er.Email = txtEmail.Text;
            er.Notes = txtNotes.Text;
            er.Photo = picPhoto.ImageLocation;
            
            if (CheckCardExist())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("EXISTCARD", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                retVal1 = employee.Update();
                grvCardInfo.UpdateCurrentRow();
                //if (chkUploadToReader.Checked)
                //{
                //    Application.DoEvents();
                //    foreach (CardRow cr in card)
                //    {
                //        if (cr["Status"] != DBNull.Value && (bool)cr["Status"])
                //        {
                //            if (ragUploadToReader.SelectedIndex == 0)
                //                Reader.AddCard(cr.EnrollNumber, cr.ID, EmployeeTable.GetLastNameByID(employeeID));
                //            else
                //                Reader.AddCard((int)cr["EnrollNumber", DataRowVersion.Original], cr.EnrollNumber, cr.ID, EmployeeTable.GetLastNameByID(employeeID));
                //        }
                //    }
                //}
                retVal2 = card.Insert();
                retVal3 = card.Update();
                if (retVal1 && retVal2 && retVal3)
                {
                    parentForm.ShowData(Constant.departmentIDList, true);
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("UPDATE_EMPLOYEE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("UPDATE_EMPLOYEE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GeneralInfo_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;
            Title.SetTitle(this);
            Title.SetTitle(this, grvCardInfo);

            InitDateEdit();
            FillData();
            picCardInfo.Image = Properties.Resources.Expand_large;
        }

        private void picCardInfo_Click(object sender, EventArgs e)
        {
            if (expand)
            {
                picCardInfo.Image = Properties.Resources.Collapse_large;
                grdCardInfo.Visible = false;
                expand = false;
            }
            else
            {
                picCardInfo.Image = Properties.Resources.Expand_large;
                grdCardInfo.Visible = true;
                expand = true;
            }
        }

        private void grvCardInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ToDate" && Convert.ToDateTime(e.CellValue).ToString("dd/MM/yyyy") == "31/12/9999") e.DisplayText = string.Empty;
        }

        private void grvCardInfo_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvCardInfo.SetRowCellValue(e.RowHandle, "EmployeeID", employeeID);
            grvCardInfo.SetRowCellValue(e.RowHandle, "ToDate", new DateTime(9999, 12, 31));
        }

        private void grdCardInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteCard();
        }

        private void grvCardInfo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int r;
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1)
                r = grvCardInfo.RowCount - 2;
            else
                r = e.RowHandle - 1;
            if (r > -1)
            {
                if (e.Row != null) grvCardInfo.SetRowCellValue(r, "ToDate", Convert.ToDateTime(((DataRowView)e.Row)["FromDate"]).AddDays(-1));
            }
        }

        private void chkUploadToReader_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUploadToReader.Checked)
            {
                ragUploadToReader.Enabled = true;
                ragUploadToReader.SelectedIndex = 0;
            }
            else
            {
                ragUploadToReader.Enabled = false;
                ragUploadToReader.SelectedIndex = -1;
            }
        }

        private void grvCardInfo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate") grvCardInfo.SetRowCellValue(e.RowHandle, "EnrollNumber", CardTable.GetNewEnrollNumber((DateTime)grvCardInfo.GetRowCellValue(e.RowHandle, "FromDate")));
        }
    }
}
