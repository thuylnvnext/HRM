using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Database;
using System.Globalization;
using Common;
using DevExpress.XtraEditors;

namespace Personnel.Forms
{
    public partial class AdvancedSearch : XtraForm
    {
        private EmployeeInfo employeeInfo;
        private Classes.SearchFields searchFields = new Classes.SearchFields();
        public string retVal;

        public AdvancedSearch()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public AdvancedSearch(EmployeeInfo employeeInfo)
        {
            InitializeComponent();
            this.employeeInfo = employeeInfo;
            Utility.SetSkin(this);
        }

        private void ShowSearchField()
        {
            Classes.Sexes sexes = new Classes.Sexes();
            sexes.Add(new Classes.Sex("-1", string.Empty));
            sexes.Add(new Classes.Sex("0", "Nữ"));
            sexes.Add(new Classes.Sex("1", "Nam"));

            Classes.SearchResults searchResults = new Classes.SearchResults();
            searchResults.Add(new Classes.SearchResult(1, "Có tất cả các từ"));
            searchResults.Add(new Classes.SearchResult(2, "Có cụm từ chính xác"));
            searchResults.Add(new Classes.SearchResult(3, "Có ít nhất một trong các từ"));
            searchResults.Add(new Classes.SearchResult(4, "Không có các từ"));

            searchFields.Add(new Classes.SearchField("ID", "Mã nhân viên", "Text", null));
            searchFields.Add(new Classes.SearchField("FullName", "Họ và tên", "Text", 1, searchResults));
            searchFields.Add(new Classes.SearchField("BirthDate", "Ngày sinh", "DateTime", null));
            searchFields.Add(new Classes.SearchField("Sex", "Giới tính", "LookUp", sexes));
            searchFields.Add(new Classes.SearchField("DepartmentID", "Phòng ban", "LookUp", DepartmentTable.GetContentTable(true)));
            searchFields.Add(new Classes.SearchField("PositionID", "Chức vụ", "LookUp", PositionTable.GetContentTable(true)));
            searchFields.Add(new Classes.SearchField("BirthPlace", "Nơi sinh", "Text", 1, searchResults));
            searchFields.Add(new Classes.SearchField("CurrentAddress", "Địa chỉ hiện tại", "Text", 1, searchResults));
            searchFields.Add(new Classes.SearchField("InitialDate", "Ngày vào công ty", "DateTime", null));
            searchFields.Add(new Classes.SearchField("ProbationContractEnding", "Ngày hết thử việc", "DateTime", null));
            searchFields.Add(new Classes.SearchField("1stContractEnding", "Ngày hết hợp đồng lần 1", "DateTime", null));
            searchFields.Add(new Classes.SearchField("2stContractEnding", "Ngày hết hợp đồng lần 2", "DateTime", null));

            grdSearchInfo.DataSource = searchFields;
            bgvSearchInfo.BestFitColumns();
        }

        private void Search()
        {
            string criteria = string.Empty;
            foreach (Classes.SearchField sf in searchFields)
            {
                if (!sf.IsAndNull() || !sf.IsOrNull())
                {
                    criteria += (criteria == string.Empty ? string.Empty : (!sf.IsAndNull() ? " AND " : " OR "));
                    switch (sf.FormatType)
                    {
                        case "DateTime":
                            criteria += BuildCriteria(!sf.IsAndNull() ? sf.And.ToString() : sf.Or.ToString(), sf.Name);
                            break;
                        case "Text":
                            switch (sf.SearchResult)
                            {
                                case 0:
                                case 1:
                                    criteria += sf.Name + " = '" + (!sf.IsAndNull() ? sf.And.ToString() : sf.Or.ToString()) + "'";
                                    break;
                                case 2:
                                    criteria += sf.Name + " LIKE N'%" + (!sf.IsAndNull() ? sf.And.ToString() : sf.Or.ToString()) + "%'";
                                    break;
                                case 3:
                                    criteria += sf.Name + " LIKE N'%[" + (!sf.IsAndNull() ? sf.And.ToString() : sf.Or.ToString()) + "]%'";
                                    break;
                                case 4:
                                    criteria += sf.Name + " NOT LIKE N'%" + (!sf.IsAndNull() ? sf.And.ToString() : sf.Or.ToString()) + "%'";
                                    break;
                            }
                            break;
                        case "LookUp":
                            criteria += sf.Name + " = '" + (!sf.IsAndNull() ? sf.And.ToString() : sf.Or.ToString()) + "'";
                            break;
                    }
                }
            }
            employeeInfo.ShowEmployee(criteria, DateTime.Today);
        }

        private string BuildCriteria(string s, string field)
        {
            string retVal = string.Empty;
            int dash = s.IndexOf('-');
            if (dash != -1)
            {
                string fromDate, toDate;
                fromDate = "'" + Convert.ToDateTime(s.Substring(0, dash), new CultureInfo("vi-VN")).ToString() + "'";
                toDate = "'" + Convert.ToDateTime(s.Substring(dash + 1), new CultureInfo("vi-VN")).ToString() + "'";
                retVal = "(DATEDIFF(day, " + field + ", " + fromDate + ") <= 0 AND DATEDIFF(day, " + field + ", " + toDate + ") >= 0)";
            }
            else
            { 
                if (Utility.IsDateTime(s))
                {
                    retVal = "DATEDIFF(day, " + field + ", '" + Convert.ToDateTime(s, new CultureInfo("vi-VN")).ToString() + "') = 0";
                }
                else
                {
                    int divide1, divide2;
                    divide1 = s.IndexOf("/");
                    string part = s.Substring(0, divide1);
                    if (part != "*") retVal = "DAY(" + field + ") = " + part;
                    divide2 = s.IndexOf("/", divide1 + 1);
                    part = s.Substring(divide1 + 1, divide2 - divide1 - 1);
                    if (part != "*") retVal = retVal == string.Empty ? "MONTH(" + field + ") = " + part : retVal + " AND MONTH(" + field + ") = " + part;
                    part = s.Substring(divide2 + 1);
                    if (part != "*") retVal = retVal == string.Empty ? "YEAR(" + field + ") = " + part : retVal + " AND YEAR(" + field + ") = " + part;
                }
            }
            return retVal;
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            ShowSearchField();
        }

        private void bgvSearchInfo_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            string formatType = bgvSearchInfo.GetRowCellValue(e.RowHandle, "FormatType").ToString();
            if (e.Column.FieldName == "SearchResult")
            {
                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();                
                if (formatType == "Text")
                {
                    lookUp.DataSource = searchFields[e.RowHandle].Data;
                    lookUp.ValueMember = "ID";
                    lookUp.DisplayMember = "Name";
                    lookUp.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name"));
                }               
                lookUp.NullText = string.Empty;
                lookUp.DropDownRows = 4;
                lookUp.ShowHeader = false;
                lookUp.ShowFooter = false;                
                e.RepositoryItem = lookUp;
            }
            if (e.Column.FieldName == "And" || e.Column.FieldName == "Or")
            {                
                if (formatType == "DateTime")
                {
                    e.RepositoryItem = ibeDateTime;
                }
                if (formatType == "LookUp")
                {
                    DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
                    lookUp.DataSource = searchFields[e.RowHandle].Data;
                    lookUp.ValueMember = "ID";
                    lookUp.DisplayMember = "Name";
                    lookUp.NullText = string.Empty;
                    lookUp.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name"));
                    lookUp.DropDownRows = 3;
                    lookUp.ShowHeader = false;
                    lookUp.ShowFooter = false;
                    e.RepositoryItem = lookUp;
                }
            }
        }

        private void ibeDateTime_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DialogResult dialogResult = new Forms.ChooseDateTime(this).ShowDialog();
            //if (dialogResult == DialogResult.OK)
            //{
            //    bgvSearchInfo.SetFocusedValue(retVal);
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}