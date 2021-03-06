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
using System.Data.SqlClient;
using System.Collections;

namespace Personnel.Forms
{
    public partial class AddEmployee : XtraForm
    {
        private EmployeeTable employee = new EmployeeTable();
        private HealthStatusTable healthStatus = new HealthStatusTable();
        private CardTable card = new CardTable();        
        private EmployeeDepartmentTable employeeDepartment = new EmployeeDepartmentTable();
        private EmployeePositionTable employeePosition = new EmployeePositionTable();
        private EmployeeInfo parentForm;

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

            DepartmentTable department = new DepartmentTable();
            department.GetFullPath(Constant.currentUser.Name);
            lueDepartment.Properties.DataSource = department;
            lueDepartment.Properties.DisplayMember = "FullPath";
            lueDepartment.Properties.ValueMember = "ID";
            if (Constant.departmentIDList.Length > 0) lueDepartment.EditValue = Constant.departmentIDList.Substring(1, Constant.departmentIDList.Length - 2);
            
            luePosition.Properties.DataSource = PositionTable.GetContentTable(false);
            luePosition.Properties.DisplayMember = "Name";
            luePosition.Properties.ValueMember = "ID";

            lueJob.Properties.DataSource = JobTable.GetContentTable();
            lueJob.Properties.DisplayMember = "Name";
            lueJob.Properties.ValueMember = "ID";

            ArrayList iList = new ArrayList();
            iList.Add("Chính thức");
            iList.Add("Thử việc");

            lueType.Properties.DataSource = iList;
        }

        private void ResetData()
        {
            foreach (Control ctl in Controls)
            {
                if (ctl.GetType().Name == "TextEdit") ctl.Text = string.Empty;
                if (ctl.GetType().Name == "ComboBoxEdit") ((ComboBoxEdit)ctl).SelectedIndex = -1;                
            }
            foreach (Control ctl in grcAddedInfo.Controls)
            {
                if (ctl.GetType().Name == "TextEdit") ctl.Text = string.Empty;
                if (ctl.GetType().Name == "ComboBoxEdit") ((ComboBoxEdit)ctl).SelectedIndex = -1;
            }
            lueNationality.EditValue = "VIETNAM";
            lueEthnicGroup.EditValue = "KINH";
            lueReligion.EditValue = "NO";
            lueMarriageStatus.EditValue = "SINGLE";
            cboBloodGroup.Text = string.Empty;
            lueType.EditValue = null;
            if (Constant.departmentIDList != string.Empty) lueDepartment.EditValue = Constant.departmentIDList.Substring(1, Constant.departmentIDList.Length - 2);
            dedCardBeginDate.DateTime = DateTime.Today;
            dedDepartmentBeginDate.DateTime = DateTime.Today;

            picPhoto.Image = Properties.Resources.nophoto;

            txtEmployeeCode.Focus();

            btnLoadPhoto.Enabled = false;
            btnSave.Enabled = false;
        }

        private bool CheckCardExist()
        {
            bool retVal = false;
            if (CardTable.CheckExist(txtCardID.Text, dedCardBeginDate.DateTime)) retVal = true;

            return retVal;
        }

        public AddEmployee()
        {
            InitializeComponent();
        }

        public AddEmployee(EmployeeInfo parentForm)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.parentForm = parentForm;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Title.SetTitle(this);

            InitLookUp();
            ResetData();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmployeeCode.Text) || String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(lueType.Text)|| String.IsNullOrEmpty(lueDepartment.Text))
                return;

            if (txtCardID.Text != string.Empty && CheckCardExist())
            {
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("EXISTCARD", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool retVal1, retVal2 = true, retVal3, retVal4, retVal5, error = false;
                //int employeeID = Convert.ToInt32(txtEmployeeCode.Text);//EmployeeTable.GetNewID();
                int employeeID = EmployeeTable.GetNewID();
                if (EmployeeTable.GetIDByCode(txtEmployeeCode.Text) == employeeID)
                {
                    EmployeeRow er = EmployeeTable.GetInfoByID(employeeID);
                    XtraMessageBox.Show(LookAndFeel, string.Format(TitleTable.GetValue("EXIST_EMPLOYEE", Constant.language), er["DepartmentName"]), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Connection.GetConnection();
                    Connection.Open();
                    SqlTransaction tran = Connection.GetConnection().BeginTransaction();

                    int type = lueType.Text == "Chính thức" ? 1 : 0;

                    employee.AddEmployeeRow(employeeID, txtEmployeeCode.Text, txtFullName.Text, txtAlias.Text, dedBirthDate.EditValue != null ? dedBirthDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), rdgGender.SelectedIndex == 0, lueNationality.EditValue.ToString(), lueEthnicGroup.EditValue.ToString(), lueReligion.EditValue.ToString(), lueMarriageStatus.EditValue.ToString(), txtCultureLevel.Text, dedUnionEnrollingDate.EditValue != null ? dedUnionEnrollingDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), txtUnionEnrollingPlace.Text, dedPartyEnrollingDate.EditValue != null ? dedPartyEnrollingDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), txtPartyEnrollingPlace.Text, dedEnlistingDate.EditValue != null ? dedEnlistingDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), dedDischargeDate.EditValue != null ? dedDischargeDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), txtReason.Text, txtEmail.Text, picPhoto.ImageLocation == null ? string.Empty : picPhoto.ImageLocation, txtNotes.Text, type, DateTime.Now);
                    retVal1 = employee.Insert(Connection.GetConnection(), tran);
                    if (txtHeight.Text != string.Empty || txtWeight.Text != string.Empty || txtLeftVision.Text != string.Empty || txtRightVision.Text != string.Empty || cboBloodGroup.Text != string.Empty)
                    {
                        healthStatus.AddHealthStatusRow(employeeID, txtHeight.Text == string.Empty ? 0 : Convert.ToInt16(txtHeight.Text), txtWeight.Text == string.Empty ? 0 : Convert.ToInt16(txtWeight.Text), txtLeftVision.Text, txtRightVision.Text, cboBloodGroup.Text);
                        retVal2 = healthStatus.Insert(Connection.GetConnection(), tran);
                    }
                    card.AddCardRow(employeeID, txtCardID.Text, Utility.IsNumeric(txtEnrollNumber.Text) ? Convert.ToInt32(txtEnrollNumber.Text) : 0, dedCardBeginDate.EditValue != null ? dedCardBeginDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")));
                    retVal3 = card.Insert(Connection.GetConnection(), tran);
                    employeeDepartment.AddEmployeeDepartmentRow(employeeID, dedDepartmentBeginDate.EditValue != null ? dedDepartmentBeginDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), lueDepartment.EditValue.ToString());
                    retVal4 = employeeDepartment.Insert(Connection.GetConnection(), tran);
                    if (luePosition.EditValue != null)
                        if (lueJob.EditValue != null)
                            employeePosition.AddEmployeePositionRow(employeeID, dedDepartmentBeginDate.EditValue != null ? dedDepartmentBeginDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), luePosition.EditValue.ToString(), lueJob.EditValue.ToString());
                        else
                            employeePosition.AddEmployeePositionRow(employeeID, dedDepartmentBeginDate.EditValue != null ? dedDepartmentBeginDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), luePosition.EditValue.ToString(), string.Empty);
                    else
                        if (lueJob.EditValue != null)
                            employeePosition.AddEmployeePositionRow(employeeID, dedDepartmentBeginDate.EditValue != null ? dedDepartmentBeginDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), string.Empty, lueJob.EditValue.ToString());
                        else
                            employeePosition.AddEmployeePositionRow(employeeID, dedDepartmentBeginDate.EditValue != null ? dedDepartmentBeginDate.DateTime : Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), Convert.ToDateTime("31/12/9999", new System.Globalization.CultureInfo("vi-VN")), string.Empty, string.Empty);
                    retVal5 = employeePosition.Insert(Connection.GetConnection(), tran);

                    if (retVal1 && retVal2 && retVal3 && retVal4 && retVal5)
                    {
                        //if (chkUploadToReader.Checked) error = Reader.AddCard(Convert.ToInt32(txtEnrollNumber.Text), txtCardID.Text, txtAlias.Text, Connection.GetConnection(), tran);
                        if (!error)
                        {
                            tran.Commit();
                            btnSave.Enabled = false;

                            if (Constant.departmentIDList != string.Empty && lueDepartment.EditValue.ToString() == Constant.departmentIDList.Substring(1, Constant.departmentIDList.Length - 2))
                            {
                                parentForm.ShowData(Constant.departmentIDList, true);
                            }

                            DialogResult dr = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_EMPLOYEE", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes) ResetData();
                        }
                        else
                        {
                            tran.Rollback();
                            XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_CARD_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        tran.Rollback();
                        XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("ADD_EMPLOYEE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Connection.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtEmployeeCode.Text != string.Empty);
            btnLoadPhoto.Enabled = (txtEmployeeCode.Text != string.Empty);
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            ofdLoadPhoto.ShowDialog();
            if (ofdLoadPhoto.FileName != string.Empty) picPhoto.ImageLocation = ofdLoadPhoto.FileName;
        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) new Common.Forms.SetTitle(sender, Name).ShowDialog();
        }
    }
}