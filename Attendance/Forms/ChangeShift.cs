using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using Common;

namespace Attendance.Forms
{
    public partial class ChangeShift : Form, IShowData
    {
        private ChangeShiftTable changeShift = new ChangeShiftTable();
        private ShiftTable shift = new ShiftTable();
        private DepartmentTable department = new DepartmentTable();
        private WorkingCycleTable workingCycle = new WorkingCycleTable();
        private WorkingCycleRow wcr;
        private bool change = false;

        public ChangeShift()
        {
            InitializeComponent();
        }

        private void Init()
        {
            AddBand("grbDaysInMonth", "Ngày trong tháng", string.Empty, 1, bgvChangeShift.Bands);
            for (int d = 1; d <= 31; d++)
            {
                AddColumn(d.ToString());
            }
            SetFieldName(Convert.ToInt16(cboMonth.Text), Convert.ToInt16(cboYear.Text));
            SetColumn(Convert.ToInt16(cboMonth.Text), Convert.ToInt16(cboYear.Text));
        }

        private GridBand AddBand(string name, string caption, string toolTip, int rowCount, GridBandCollection gbc)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.ToolTip = toolTip;
            gridBand.Width = 50;
            gridBand.RowCount = rowCount;
            gridBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.Options.UseFont = true;
            gridBand.AppearanceHeader.Font = new Font(gridBand.AppearanceHeader.Font, FontStyle.Bold);
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gbc.Add(gridBand);
            return gridBand;
        }

        private void AddColumn(string name)
        {
            GridBand gridBand = AddBand(name, string.Empty, string.Empty, 2, bgvChangeShift.Bands["grbDaysInMonth"].Children);
            BandedGridColumn column = new BandedGridColumn();
            column.Name = name;
            column.OptionsColumn.AllowEdit = true;
            column.OptionsColumn.AllowFocus = true;
            column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            column.OwnerBand = gridBand;
            column.AppearanceHeader.Options.UseFont = true;
            column.AppearanceHeader.Font = new Font(column.AppearanceHeader.Font, FontStyle.Bold);
            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void SetColumn(int month, int year)
        {
            bool stop = false;
            int days = DateTime.DaysInMonth(year, month);
            DateTime d = new DateTime(year, month, 1);
            GridBandCollection gbc = bgvChangeShift.Bands["grbDaysInMonth"].Children;
            for (int i = 0; i < days; i++)
            {
                gbc[i].Caption = d.Day.ToString() + '\n' + Utility.GetWeekDay(d);
                gbc[i].Columns[0].Caption = string.Empty.PadLeft(5, ' ');
                if (d.DayOfWeek == DayOfWeek.Sunday)
                {
                    gbc[i].Columns[0].AppearanceCell.Options.UseBackColor = true;
                    gbc[i].Columns[0].AppearanceCell.BackColor = Color.Red;
                }
                else
                {
                    gbc[i].Columns[0].AppearanceCell.BackColor = Color.Empty;
                }
                d = d.AddDays(1);
            }
            for (int i = days; i < 31; i++)
            {
                bgvChangeShift.Bands["grbDaysInMonth"].Children[i].Visible = false;
            }

            int _d = days - 1;
            while (!stop)
            {
                if (!bgvChangeShift.Bands["grbDaysInMonth"].Children[_d].Visible)
                {
                    bgvChangeShift.Bands["grbDaysInMonth"].Children[_d].Visible = true;
                    _d--;
                }
                else
                {
                    stop = true;
                }
            }
        }

        private void SetFieldName(int month, int year)
        {
            int days = DateTime.DaysInMonth(year, month);
            DateTime d = new DateTime(year, month, 1);
            GridBandCollection gbc = bgvChangeShift.Bands["grbDaysInMonth"].Children;
            for (int i = 0; i < days; i++)
            {
                gbc[i].Columns[0].FieldName = d.Day.ToString();
                d = d.AddDays(1);
            }
        }

        public void ShowData(string departmentIDList, bool check)
        {
            if (check)
            {
                wcr = workingCycle.GetInfo(Convert.ToByte(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                if (wcr != null) changeShift.GetListByDepartmentID(departmentIDList, wcr.FromDate, wcr.ToDate);
            }
            else
            {
                changeShift.DeleteByDepartmentID(departmentIDList);
            } 
            if (changeShift.Count > 0) grdChangeShift.DataSource = changeShift;
            bgvChangeShift.BestFitColumns();
            bgvChangeShift.ExpandAllGroups();
            btnSave.Enabled = false;
        }

        private void InitLookUp()
        {
            shift.AddShiftRow(string.Empty, "(Bỏ chọn)", true, false);
            shift.GetContent();
            ileShift.DataSource = shift;
            ileShift.ValueMember = "ID";
            ileShift.DisplayMember = "ID";
            ileShift.BestFit();
        }

        private bool SaveData()
        {
            ChangeShiftTable _changeShift = new ChangeShiftTable();
            ChangeShiftRow _csr;
            int d, month = Convert.ToInt16(cboMonth.Text), year = Convert.ToInt16(cboYear.Text), daysInMonth = DateTime.DaysInMonth(year, month);
            string _d;
            string[] shift;
            bool iRetVal = true, uRetVal = true, dRetVal = true;
            _changeShift.GetHListByDepartmentID(Constant.departmentIDList, wcr.FromDate, wcr.ToDate);
            foreach (ChangeShiftRow csr in changeShift)
            {
                d = 1;
                while (d <= daysInMonth)
                {
                    _d = d.ToString();
                    if (csr[_d] != DBNull.Value && csr[_d].ToString() != string.Empty)
                    {
                        shift = csr[_d].ToString().Split(new char[] { ',' });
                        _csr = _changeShift.GetInfoByValues(csr.EmployeeID, new DateTime(year, month, d));
                        if (_csr != null)
                        {
                            foreach (string s in shift)
                            {
                                if (_csr.ShiftID != s) _csr.ShiftID = s;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < shift.Length; i++)
                            {
                                _changeShift.AddChangeShiftRow(csr.EmployeeID, csr.DepartmentID, new DateTime(year, month, d), shift[i]);
                            }
                        }
                    }
                    else
                    {
                        _csr = _changeShift.GetInfoByValues(csr.EmployeeID, new DateTime(year, month, d));
                        if (_csr != null)
                        {
                            _csr.Delete();
                            dRetVal = _changeShift.Delete();
                            if (!dRetVal) break;
                        }
                    }
                    d++;
                }
            }
            iRetVal = _changeShift.Insert();
            uRetVal = _changeShift.Update();
            return (iRetVal && uRetVal && dRetVal);
        }

        private void ChangeShift_Load(object sender, EventArgs e)
        {
            Size = Parent.ClientSize;

            department.GetContent();
            foreach (DepartmentRow dr in department)
            {
                icbGroup.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.Name, dr.Name, 0));
            }

            Title.SetTitle(this);            

            for (int i = 1; i < 13; i++)
            {
                cboMonth.Items.Add(i);
            }
            cboMonth.Text = DateTime.Today.Month.ToString();
            for (int i = 2009; i < 2021; i++)
            {
                cboYear.Items.Add(i);
            }
            cboYear.Text = DateTime.Today.Year.ToString();
            change = true;

            InitLookUp();
            Init();
            ShowData(Constant.departmentIDList, true);
            Title.SetTitle(this, bgvChangeShift);
        }

        private void ComboxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change)
            {
                changeShift.Clear();
                SetColumn(Convert.ToInt16(cboMonth.Text), Convert.ToInt16(cboYear.Text));
                ShowData(Constant.departmentIDList, true);
            }
        }
        
        private void bgvChangeShift_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "No" && e.IsGetData && e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle + 1) e.Value = e.RowHandle + 1;
        }

        private void bgvChangeShift_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.VisibleIndex > 3 && bgvChangeShift.GetRowCellValue(e.RowHandle, e.Column) != null)
            {
                if ((bgvChangeShift.GetRowCellValue(e.RowHandle, e.Column).ToString() == string.Empty) || (shift.FindByPrimaryKey(bgvChangeShift.GetRowCellValue(e.RowHandle, e.Column).ToString()) != null)) e.RepositoryItem = ileShift;
            }
        }

        private void bgvChangeShift_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridCell[] selectedCells = bgvChangeShift.GetSelectedCells();
            foreach (GridCell gc in selectedCells)
            {
                bgvChangeShift.SetRowCellValue(gc.RowHandle, gc.Column, e.Value);
            }
            if (!btnSave.Enabled) btnSave.Enabled = true;
        }

        private void bgvChangeShift_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            GridBand gridBand = e.Band;
            if (gridBand.Caption.IndexOf("CN") > 0)
            {
                Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Red, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
                Rectangle r = e.Bounds;
                ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
                r.Inflate(0, -1);
                e.Graphics.FillRectangle(brush, r);
                r.Inflate(0, 0);
                e.Appearance.DrawString(e.Cache, e.Info.Caption, r);
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
                MessageBox.Show(TitleTable.GetValue("REGISTER_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(TitleTable.GetValue("REGISTER_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;
        }
    }
}
