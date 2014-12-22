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
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using System.Reflection;

namespace Attendance.Forms
{
    public partial class DayOff : XtraForm
    {
        private DayOffGroupTable dayOffGroup = new DayOffGroupTable();
        private DayOffTable dayOff = new DayOffTable();
        private Classes.DayOffControl[] dayOffs = new Classes.DayOffControl[] { new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl(), new Classes.DayOffControl() };
        private bool change = false;
        private short year;

        public DayOff()
        {
            InitializeComponent();
        }

        private void InitDayOffs()
        {
            int x = 0, y = 36;
            byte month = 1;            

            for (int i = 2008; i <= 2020; i++)
            {
                cboYear.Properties.Items.Add(i);
            }
            cboYear.SelectedIndex = DateTime.Today.Year - 2008;
            change = true;

            year = Convert.ToInt16(cboYear.Text);
            foreach (Classes.DayOffControl _dayOff in dayOffs)
            {
                _dayOff.ShowTodayButton = false;
                _dayOff.ShowWeekNumbers = false;
                _dayOff.Size = _dayOff.CalcBestSize(null);
                _dayOff.DateTime = new DateTime(year, month++, 1);
                _dayOff.Multiselect = true;
                _dayOff.Selection.Clear();
                _dayOff.ContextMenuStrip = cmsDayOff;
                _dayOff.CustomDrawDayNumberCell += new CustomDrawDayNumberCellEventHandler(DayOff_CustomDrawDayNumberCell);
            }
            Controls.AddRange(new Classes.DayOffControl[] { dayOffs[0], dayOffs[1], dayOffs[2], dayOffs[3], dayOffs[4], dayOffs[5], dayOffs[6], dayOffs[7], dayOffs[8], dayOffs[9], dayOffs[10], dayOffs[11] });
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    dayOffs[4 * row + column].Location = new Point(x, y);
                    x += dayOffs[4 * row + column].Width;
                }
                x = 0;
                y += dayOffs[0].Height;
            }

            ClientSize = new Size(4 * dayOffs[0].Width, y);
            Utility.SetSkin(this);
        }

        private void ChangeYear()
        {
            byte month = 1; 

            year = Convert.ToInt16(cboYear.Text);
            foreach (Classes.DayOffControl _dayOff in dayOffs)
            {
                _dayOff.DateTime = new DateTime(year, month++, 1);
                _dayOff.Selection.Clear();
                //MethodInfo mi = typeof(DateControl).GetMethod("LayoutChanged", BindingFlags.Instance | BindingFlags.NonPublic);
                //mi.Invoke(_dayOff, null);
                _dayOff.LayoutChanged();
            }
        }

        private void DayOff_Load(object sender, EventArgs e)
        {
            InitDayOffs();            
                        
            dayOffGroup.GetContent();
            dayOff.GetContent();
            int i = 0;
            foreach (DayOffGroupRow dogr in dayOffGroup)
            {
                ToolStripMenuItem mitDayOffGroup = new ToolStripMenuItem();
                mitDayOffGroup.Name = dogr.ID;
                mitDayOffGroup.Text = dogr.Name;
                mitDayOffGroup.Click += new EventHandler(mitDayOffGroup_Click);
                cmsDayOff.Items.Insert(i++, mitDayOffGroup);
            }
        }

        private void mitDayOffGroup_Click(object sender, EventArgs e)
        {
            Classes.DayOffControl ctl = (Classes.DayOffControl)cmsDayOff.SourceControl;
            ToolStripMenuItem mit = (ToolStripMenuItem)sender;
            DayOffRow dor;
            foreach (DateTime d in ctl.Selection)
            {
                dor = dayOff.FindByPrimaryKey(d);
                if (dor == null)
                {
                    dor = (DayOffRow)dayOff.NewRow();
                    dor.ID = d;
                    dor.DayOffGroupID = mit.Name;
                    dayOff.AddDayOffRow(dor);
                }
                else
                    dor.DayOffGroupID = mit.Name;
            }
            bool insert, update;
            insert = dayOff.Insert();
            update = dayOff.Update();
            if (insert && update)
                ctl.Refresh();
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DAYOFF_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DayOff_CustomDrawDayNumberCell(object sender, CustomDrawDayNumberCellEventArgs e)
        {
            DayOffRow dor = dayOff.FindByPrimaryKey(e.Date);

            if (dor != null && e.Date.Month == ((Classes.DayOffPainter)sender).Calendar.DateTime.Month)
            {
                RectangleF rect = new RectangleF(e.Bounds.Location, e.Bounds.Size);
                Color backColor = Color.FromArgb(dayOffGroup.FindByPrimaryKey(dor.DayOffGroupID).Color);
                e.Graphics.FillRectangle(new SolidBrush(backColor), rect);
                e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font, new SolidBrush(e.Style.ForeColor), rect, e.Style.GetStringFormat());
                e.Handled = true;
            }
        }

        private void DayOff_MouseMove(object sender, MouseEventArgs e)
        {
            //CalendarHitInfo hitInfo = (sender as Classes.DayOffControl).GetHitInfo(e.Location);
            //if (hitInfo.InfoType == CalendarHitInfoType.MonthNumber) DevExpress.Utils.ToolTipController.DefaultController.ShowHint(hitInfo.HitDate.ToString());
        }

        private void dateNavigator1_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            if (e.Date == new DateTime(2011, 7, 6))
            {
                RectangleF rect = new RectangleF(e.Bounds.Location, e.Bounds.Size);
                Color backColor = Color.Red;
                e.Graphics.FillRectangle(new SolidBrush(backColor), rect);
                e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font, new SolidBrush(e.Style.ForeColor), rect, e.Style.GetStringFormat());
                e.Handled = true;
            }
        }

        private void mitDefineDayOffGroup_Click(object sender, EventArgs e)
        {
            Common.Forms.DefineList defineDayOffGroup = new Common.Forms.DefineList(new DayOffGroupTable(), TitleTable.GetValue("DEFINE_DAYOFFGROUP", Constant.language));
            GridView grv = defineDayOffGroup.GetGridView;
            RepositoryItemColorEdit color = new RepositoryItemColorEdit();
            color.StoreColorAsInteger = true;
            grv.Columns["Color"].ColumnEdit = color;
            defineDayOffGroup.ShowDialog();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change) ChangeYear();
        }

        private void mitDelete_Click(object sender, EventArgs e)
        {
            DialogResult retVal = XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("DELETE_REGISTERDAYOFF", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (retVal == DialogResult.OK)
            {
                Classes.DayOffControl ctl = (Classes.DayOffControl)cmsDayOff.SourceControl;
                foreach (DateTime d in ctl.Selection)
                {
                    dayOff.Delete(d);
                }
                ctl.Refresh();
            }
        }

        private void DayOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Dispose(true);
        }
    }
}
