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
using DevExpress.XtraNavBar;

namespace Personnel.Forms
{
    public partial class InfoDetails : XtraForm
    {        
        private EmployeeInfo parentForm;
        private EmployeeTable employee;
        private int iD;
        private bool change = false;

        public InfoDetails()
        {
            InitializeComponent();            
        }

        public InfoDetails(EmployeeInfo parentForm, EmployeeTable employee, int iD)
        {
            InitializeComponent();
            Utility.SetSkin(this);
            this.parentForm = parentForm;
            this.employee = employee;
            this.iD = iD;
        }

        private void ShowUserControl(string name)
        {
            switch (name)
            {
                case "navBarItemGeneralInfo":
                    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("GeneralInfo"))
                    {
                        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.GeneralInfo(iD, parentForm));
                    }
                    break;
                case "navBarItemIDCard":
                    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("IDCard"))
                    {
                        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.IDCard(iD, parentForm));
                    }
                    break;
                //case "nodFamily":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Family"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Family(iD));
                //    }
                //    break;
                //case "nodAddressInfo":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Address"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Address(iD, parentForm));
                //    }
                //    break;
                //case "nodContactPhone":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Phone"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Phone(iD));
                //    }
                //    break;
                //case "nodPaper":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Paper"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Paper(iD));
                //    }
                //    break;
                //case "nodSkill":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Skill"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Skill(iD));
                //    }
                //    break;
                //case "nodOtherLevel":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("OtherLevel"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.OtherLevel(iD));
                //    }
                //    break;
                //case "nodBeforeWorking":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("BeforeWorking"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.BeforeWorking(iD));
                //    }
                //    break;
                case "navBarItemCurrentWorking":
                    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("CurrentWorking"))
                    {
                        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.CurrentWorking(iD, parentForm));
                    }
                    break;
                //case "nodSalaryProcess":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("SalaryProcess"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.SalaryProcess(iD));
                //    }
                //    break;
                //case "nodReward":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Reward"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Reward(iD));
                //    }
                //    break;
                //case "nodDiscipline":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("Discipline"))
                //    {
                //        foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        spcEmployeeInfo.Panel2.Controls.Add(new UserControls.Discipline(iD));
                //    }
                //    break;
                //case "nodLabourContract":
                //    if (!spcEmployeeInfo.Panel2.Controls.ContainsKey("LabourContract"))
                //    {
                //        //foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //        //spcEmployeeInfo.Panel2.Controls.Add(new UserControls.LabourContract(iD));
                //    }
                //    break;
            }
        }

        private void tvwInfoGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowUserControl(e.Node.Name);
        }

        private void InfoDetails_Load(object sender, EventArgs e)
        {
            lueEmployeeName.Properties.DataSource = employee;
            lueEmployeeName.Properties.ValueMember = "ID";
            lueEmployeeName.Properties.DisplayMember = "FullName";
            lueEmployeeName.EditValue = iD;
            lueEmployeeName.Properties.BestFit();

            change = true;
            Title.SetTitle(this);
            //Title.SetTitle(this, tvwInfoGroup);

            //tvwInfoGroup.ExpandAll();
            //tvwInfoGroup.SelectedNode = tvwInfoGroup.Nodes["nodPersonalInfo"].FirstNode;

            ShowUserControl("navBarItemGeneralInfo");
        }

        private void spcEmployeeInfo_Panel2_Resize(object sender, EventArgs e)
        {
            foreach (Control ct in spcEmployeeInfo.Panel2.Controls)
            {
                if (ct.Name != "LabourContract")
                    ct.Size = spcEmployeeInfo.Panel2.ClientSize;
                else
                    ct.Width = spcEmployeeInfo.Panel2.ClientSize.Width;
            }
        }

        private void lueEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            if (change && lueEmployeeName.EditValue != null)
            {
                iD = Convert.ToInt32(lueEmployeeName.EditValue);
                foreach (Control ct in spcEmployeeInfo.Panel2.Controls) spcEmployeeInfo.Panel2.Controls.Remove(ct);
                //ShowUserControl(tvwInfoGroup.SelectedNode.Name);
            }
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text.Length == Convert.ToInt32(ConstantTable.GetValueByName("CodeLength"))) lueEmployeeName.EditValue = EmployeeTable.GetIDByCode(txtEmployeeCode.Text);
        }

        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowUserControl(((NavBarItem)sender).Name);
        }
    }
}