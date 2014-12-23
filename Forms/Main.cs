using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Win32;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Common;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using wyDay.Controls;
using MyUtility;

namespace HRMplus.Forms
{
    public partial class Main : RibbonForm, IMdiParent
    {
        private Form childForm;
        private AxSFC3KPCLib.AxSFC3KPC reader;
        public Main()
        {
            InitializeComponent();
            bdcMain.LookAndFeel.SkinName = Constant.skin;
            Utility.SetSkin(this);
            this.LoadAuTranslation();
        }
        private void LoadAuTranslation()
        {

            //
            String UpdateType = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\AutoUpdate", "UpdateType", null);
            if (String.IsNullOrEmpty(UpdateType))
                UpdateType = "Automatic";

            UpdateType uType = (UpdateType)Enum.Parse(typeof(UpdateType), UpdateType, true);
            automaticUpdater.UpdateType = uType;
            

            //
            AUTranslation auTranslation = new AUTranslation();
            
            auTranslation.SkinName = Constant.skin;

            auTranslation.CheckForUpdatesMenu = "&Kiểm tra bản cập nhật";//TitleTable.GetValue("CheckForUpdatesMenu", Constant.language);
            auTranslation.DownloadUpdateMenu = "&Tải về và cập nhật";//TitleTable.GetValue("DownloadUpdateMenu", Constant.language); ;
            auTranslation.InstallUpdateMenu = "&Cài đặt cập nhật ngay";
            auTranslation.CancelUpdatingMenu = "&Hủy bỏ cập nhật";
            auTranslation.CancelCheckingMenu = "&Hủy bỏ kiểm tra cập nhật";


            auTranslation.HideMenu = "Ẩn";
            auTranslation.ViewChangesMenu = "Xem danh sách cập nhật cho phiên bản %version%";

            auTranslation.PrematureExitTitle = "Hệ thống cập nhật kết thúc trước";
            auTranslation.PrematureExitMessage = "Hệ thống cập nhật kết thúc trước khi bước cập nhật hiện tại có thể được hoàn thành.";

            auTranslation.StopChecking = "Dừng kiểm tra cập nhật ngay";
            auTranslation.StopDownloading = "Dừng tải cập nhật ngay";
            auTranslation.StopExtracting = "Dừng chiết xuất bản cập nhật ngay";

            auTranslation.TryAgainLater = "Thử lại sau";
            auTranslation.TryAgainNow = "Thử lại";
            auTranslation.ViewError = "Xem chi tiết lỗi";

            auTranslation.CloseButton = "Đóng";
            auTranslation.ErrorTitle = "Lỗi";

            auTranslation.UpdateNowButton = "Cập nhật ngay";
            auTranslation.ChangesInVersion = "Danh sách cập nhật cho phiên bản %version%";

            auTranslation.FailedToCheck = "Không thể kiểm tra cập nhật.";
            auTranslation.FailedToDownload = "Không thể tải bản cập nhật.";
            auTranslation.FailedToExtract = "Không thể chiết xuất bản cập nhật.";

            auTranslation.Checking = "Kiểm tra bản cập nhật";
            auTranslation.Downloading = "Tải bản cập nhật";
            auTranslation.Extracting = "Đang chiết xuất cập nhật";
            auTranslation.UpdateAvailable = "Cập nhật đã sẵn sàng để được cài đặt.";
            auTranslation.InstallOnNextStart = "Cập nhật sẽ được cài đặt cho lần sử dụng chương trình tiếp theo.";

            auTranslation.AlreadyUpToDate = "Phiên bản đang sử dụng là phiên bản mới nhất.";
            auTranslation.SuccessfullyUpdated = "Cập nhật thành công phiên bản %version%";
            auTranslation.UpdateFailed = "Cập nhật không để cài đặt.";

            automaticUpdater.Translation = auTranslation;

            if(automaticUpdater.UpdateType != wyDay.Controls.UpdateType.DoNothing)
                automaticUpdater.ForceCheckForUpdate(true);
        }

        public void SetBarItem(string name, bool status)
        {
            rbcMain.Items[name].Enabled = status;
        }

        public RibbonControl GetRibbonControl
        {
            get
            {
                return Ribbon;
            }
        }

        private Form GetChildForm(string name)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == name) return f;
            }
            return null;
        }

        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void SetPermission()
        {
            bbiLogOff.Caption += Constant.currentUser.Name;

            RightOfGroupTable rightOfGroup = new RightOfGroupTable();
            BarItem bi;
            RibbonPage rp;
            rightOfGroup.GetListByGroupID(Constant.currentUser.GroupID, 1);
            foreach (RightOfGroupRow rgr in rightOfGroup)
            {
                bi = Ribbon.Items[rgr.FunctionID];
                //if (bi != null) bi.Enabled = false;
                if (bi != null) bi.Visibility = BarItemVisibility.Never;
                if (Utility.IsNumeric(rgr.FunctionID))
                {
                    rp = Ribbon.Pages[Convert.ToInt32(rgr.FunctionID)];
                    if (rp != null) rp.Visible = false;
                }
            }
        }

        private void SetVisibility()
        {
            string visibility = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\DockPanel", "Visibility", "AutoHide");
            if (visibility == null) visibility = "AutoHide";
            switch (visibility)
            {
                case "AutoHide":
                    dockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
                    break;
                case "Hidden":
                    dockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    break;
                case "Visible":
                    dockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                    break;
            }
        }

        private void SetStatus()
        {
            Ribbon.Items["bsiUserName"].Caption += Constant.currentUser.Name;
            Ribbon.Items["bsiToday"].Caption += DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void SetPage()
        {
            switch (Constant.currentUser.GroupID)
            {
                case 3:
                    rbcMain.SelectedPage = rbpAttendance;
                    break;
                case 5:
                    rbcMain.SelectedPage = rbpPersonnel;
                    break;
            }
        }

        private void SetTextForItem(RibbonPage item, TitleTable title)
        {
            TitleRow tr = title.FindByPrimaryKey(item.Name, Constant.language);
            if (tr != null) item.Text = tr.Value;
            foreach (RibbonPageGroup subItem in item.Groups)
            {
                tr = title.FindByPrimaryKey(subItem.Name, Constant.language);
                if (tr != null) subItem.Text = tr.Value;
            }
        }

        private void InitLanguage()
        {
            TitleTable title = new TitleTable();
            TitleRow tr;
            title.GetContent();//.GetListByForm("Main", Constant.language);
            tr = title.FindByPrimaryKey("Main", Constant.language);
            if (tr != null) Text = tr.Value;
            foreach (RibbonPage item in rbcMain.Pages)
            {
                SetTextForItem(item, title);
            }
            foreach (BarItem item in rbcMain.Items)
            {
                tr = title.FindByPrimaryKey(item.Name, Constant.language);
                if (tr != null) item.Caption = tr.Value;
            }
            tr = title.FindByPrimaryKey("btnOption", Constant.language);
            if (tr != null) btnOption.Text = tr.Value;
            tr = title.FindByPrimaryKey("btnExit", Constant.language);
            if (tr != null) btnExit.Text = tr.Value;

            tr = title.FindByPrimaryKey("dockPanel", Constant.language);
            if (tr != null) dockPanel.Text = tr.Value;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            tmmMain.MdiParent = this;
            InitLanguage();
            SetPage();
            SetVisibility();
            SetStatus();
            SetPermission();
        }

        private void bbiDailyStatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Personnel.Forms.DailyStatistic().ShowDialog();
        }

        private void bbiDefineShift_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Attendance.Forms.DefineShift().ShowDialog();
        }

        private void bbiDefineAbsence_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Common.Forms.DefineList(new AbsenceTable(), TitleTable.GetValue("DEFINE_ABSENCE", Constant.language)).ShowDialog();
        }

        private void bbiDefineVacation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Attendance.Forms.DefineVacation().ShowDialog();
        }

        private void bbiDailyAttending_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("DailyAttending");
            if (childForm == null)
            {
                Attendance.Forms.DailyAttending dailyAttending = new Attendance.Forms.DailyAttending();
                dailyAttending.MdiParent = this;
                dailyAttending.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiMonthAttendance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("MonthAttendance");
            if (childForm == null)
            {
                Attendance.Forms.MonthAttendance monthAttendance = new Attendance.Forms.MonthAttendance();
                monthAttendance.MdiParent = this;
                monthAttendance.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiTimeInTimeOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("TimeInTimeOut");
            if (childForm == null)
            {
                Attendance.Forms.TimeInTimeOut timeInTimeOut = new Attendance.Forms.TimeInTimeOut();
                timeInTimeOut.MdiParent = this;
                timeInTimeOut.Show();
            }
            else
                childForm.Activate();
            //childForm = GetChildForm("DayOff");
            //if (childForm == null)
            //{
            //    Attendance.Forms.DayOff dayOff = new Attendance.Forms.DayOff();
            //    dayOff.MdiParent = this;
            //    dayOff.Show();
            //}
            //else
            //    childForm.Activate();
            //new Attendance.Forms.DayOff().ShowDialog();
        }

        private void bbiConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.DoEvents();
            Forms.ConnectDatabase connectDatabase = new Forms.ConnectDatabase();
            if (connectDatabase.ShowDialog() == DialogResult.OK) departmentList.ShowDepartment();
        }

        private void bbiRegisterShift_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("RegisterShift");
            if (childForm == null)
            {
                Attendance.Forms.RegisterShift registerShift = new Attendance.Forms.RegisterShift();
                registerShift.MdiParent = this;
                registerShift.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiChangeShift_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //childForm = GetChildForm("ChangeShift");
            //if (childForm == null)
            //{
            //    Attendance.Forms.ChangeShift changeShift = new Attendance.Forms.ChangeShift();
            //    changeShift.MdiParent = this;
            //    changeShift.Show();
            //}
            //else
            //    childForm.Activate();
        }

        private void bbiGetRawData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RawDataTable rawData = new RawDataTable(), _rawData = new RawDataTable();
            DataView dv;
            ReaderTable _reader = new ReaderTable();
            RightOfGroupTable rightOfGroup = new RightOfGroupTable();
            bool used;
            double totalSeconds;
            int enrollNumber = 0, granted = 0, method = 0, doorMode = 0, funNumber = 0, sensor = 0, year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0, validInterval = Convert.ToInt32(ConstantTable.GetValueByName("ValidInterval"));
            DateTime swipedDate = DateTime.MinValue, lastRecord;
            WaitDialogForm waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));

            waitDialog.Show();
            Application.DoEvents();
            _reader.GetContent();
            rightOfGroup.GetListByGroupID(Constant.currentUser.GroupID, 3);
            try
            {
                if (reader == null)
                {
                    reader = new AxSFC3KPCLib.AxSFC3KPC();
                    reader.CreateControl();
                }
                foreach (ReaderRow rr in _reader)
                {
                    if (rr.Used && rightOfGroup.FindByPrimaryKey(Constant.currentUser.GroupID, rr.ID.ToString(), 3) != null)
                    {
                        if (reader.ConnectTcpip(1, rr.IPAddress, Convert.ToInt32(rr.CommPort), Convert.ToInt32(rr.CommPassword)))
                        {
                            reader.DotNET();
                            lastRecord = rr.LastRecord;
                            reader.StartReadGeneralLogData(1);
                            reader.EnableDevice(1, 0); //Working....
                            if (reader.ReadGeneralLogData(1))
                            {
                                while (reader.GetGeneralLogData(1, ref enrollNumber, ref granted, ref method, ref doorMode, ref funNumber, ref sensor, ref year, ref month, ref day,  ref hour, ref minute, ref second))
                                {
                                    swipedDate = new DateTime(year, month, day, hour, minute, second);
                                    if (swipedDate > lastRecord)
                                    {
                                        used = true;
                                        foreach (RawDataRow rdr in rawData)
                                        {
                                            totalSeconds = swipedDate.Subtract(rdr.SwipedDate).TotalSeconds;
                                            if (rdr.EnrollNumber == enrollNumber && totalSeconds >= 0 && totalSeconds < validInterval)
                                            {
                                                used = false;
                                                break;
                                            }
                                        }
                                        
                                        if (enrollNumber == -1) used = false; //Mã không truy nhập

                                        if (used)
                                        {
                                            rawData.AddRawDataRow(rr.IPAddress, enrollNumber, swipedDate, rr.In, used);
                                            try
                                            {
                                                MyLogfile.WriteLogData(String.Format("{0} {1} {2} {3} {4}", rr.IPAddress, enrollNumber, swipedDate, rr.In, used));
                                            }
                                            catch
                                            {
                                            }
                                        }
                                    }
                                }
                                if (swipedDate > lastRecord) rr.LastRecord = swipedDate;
                            }
                        }
                        else
                        {
                            waitDialog.Close();
                            DialogResult retVal = XtraMessageBox.Show(bdcMain.LookAndFeel, string.Format(TitleTable.GetValue("READER_ERROR", Constant.language), rr.IPAddress), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (retVal == DialogResult.No)
                                break;
                            else
                            {
                                waitDialog = new WaitDialogForm(string.Empty, TitleTable.GetValue("WAITING", Constant.language));
                                waitDialog.Show();
                            }
                        }
                        reader.EnableDevice(1, 1); //Done
                        reader.Disconnect(1);
                    }
                }
                dv = rawData.DefaultView;
                dv.Sort = "EnrollNumber, SwipedDate";
                _rawData.Merge(dv.ToTable());
                if (_rawData.Insert()) _reader.Update();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            waitDialog.Close();

        }

        private void bbiEmployeeDiscipline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //childForm = GetChildForm("EmployeeDiscipline");
            //if (childForm == null)
            //{
            //    Personnel.Forms.EmployeeDiscipline employeeDiscipline = new Personnel.Forms.EmployeeDiscipline();
            //    employeeDiscipline.MdiParent = this;
            //    employeeDiscipline.Show();
            //}
            //else
            //    childForm.Activate();
        }

        private void bbiRegisterAbsence_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("RegisterAbsence");
            if (childForm == null)
            {
                Attendance.Forms.RegisterAbsence registerAbsence = new Attendance.Forms.RegisterAbsence();
                registerAbsence.MdiParent = this;
                registerAbsence.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiAnnualLeave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("AnnualLeave");
            if (childForm == null)
            {
                Personnel.Forms.AnnualLeave annualLeave = new Personnel.Forms.AnnualLeave();
                annualLeave.MdiParent = this;
                annualLeave.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiRegisterNoFullAttendance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiRegisterStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiChangeDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //childForm = GetChildForm("ChangeDepartment");
            //if (childForm == null)
            //{
            //    Personnel.Forms.ChangeDepartment changeDepartment = new Personnel.Forms.ChangeDepartment();
            //    changeDepartment.MdiParent = this;
            //    changeDepartment.Show();
            //}
            //else
            //    childForm.Activate();
        }

        private void bbiBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sfdBackUpDatabase.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string PATH = @"HKEY_CURRENT_USER\Software\HRMplus\Database";
                    Server srvSql;
                    ServerConnection srvConn = new ServerConnection((string)Registry.GetValue(PATH, "Server", null));
                    srvConn.LoginSecure = false;
                    srvConn.Login = (string)Registry.GetValue(PATH, "UserID", null);
                    srvConn.Password = Security.DecryptData((string)Registry.GetValue(PATH, "Password", null));
                    srvSql = new Server(srvConn);

                    Backup bkpDatabase = new Backup();
                    bkpDatabase.Action = BackupActionType.Database;
                    bkpDatabase.Database = (string)Registry.GetValue(PATH, "Database", null);

                    BackupDeviceItem bkpDevice = new BackupDeviceItem(sfdBackUpDatabase.FileName, DeviceType.File);
                    bkpDatabase.Devices.Add(bkpDevice);
                    bkpDatabase.SqlBackup(srvSql);
                }
                catch
                {
                    XtraMessageBox.Show(bdcMain.LookAndFeel, TitleTable.GetValue("BACKUPDATABASE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                XtraMessageBox.Show(bdcMain.LookAndFeel, TitleTable.GetValue("BACKUPDATABASE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bbiDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockPanel.Show();
        }

        private void bbiViolationHandling_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("ViolationHandling");
            if (childForm == null)
            {
                Attendance.Forms.ViolationHandling violationHandling = new Attendance.Forms.ViolationHandling();
                violationHandling.MdiParent = this;
                violationHandling.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiDailyManpower_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm = GetChildForm("DailyManpower");
            if (childForm == null)
            {
                Attendance.Forms.DailyManpower dailyManpower = new Attendance.Forms.DailyManpower();
                dailyManpower.MdiParent = this;
                dailyManpower.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiUserGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.UserGroupDetails().ShowDialog();
        }

        private void bbiUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.UserDetails().ShowDialog();
        }

        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.ChangePassword().ShowDialog();
        }

        private void bbiLogOff_ItemClick(object sender, ItemClickEventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\LogOff", "LogOff", "T");
            Application.Restart();
        }

        private void bbiContractInfo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void dockPanel_VisibilityChanged(object sender, DevExpress.XtraBars.Docking.VisibilityChangedEventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\HRMplus\DockPanel", "Visibility", e.Visibility.ToString());
        }

        private void bbiChangeSalary_ItemClick(object sender, ItemClickEventArgs e)
        {
            //childForm = GetChildForm("ChangeSalary");
            //if (childForm == null)
            //{
            //    Personnel.Forms.ChangeSalary changeSalary = new Personnel.Forms.ChangeSalary();
            //    changeSalary.MdiParent = this;
            //    changeSalary.Show();
            //}
            //else
            //    childForm.Activate();
        }

        private void bbiDefinePosition_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Common.Forms.DefineList(new PositionTable(), TitleTable.GetValue("DEFINE_POSITION", Constant.language)).ShowDialog();
        }

        private void bbiJob_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Common.Forms.DefineList(new JobTable(), TitleTable.GetValue("DEFINE_JOB", Constant.language)).ShowDialog();
        }

        private void bbiOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Forms.Options().ShowDialog();
        }

        private void bbiLateComingEarlyReturning_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("LateComingEarlyReturning");
            if (childForm == null)
            {
                Attendance.Forms.LateComingEarlyReturning lateComingEarlyReturning = new Attendance.Forms.LateComingEarlyReturning();
                lateComingEarlyReturning.MdiParent = this;
                lateComingEarlyReturning.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiDefineAttendanceTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Attendance.Forms.DefineAttendanceTable().ShowDialog();
        }

        private void bbiRegisterOvertime_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("RegisterOvertime");
            if (childForm == null)
            {
                Attendance.Forms.RegisterOvertime registerOvertime = new Attendance.Forms.RegisterOvertime();
                registerOvertime.MdiParent = this;
                registerOvertime.Show();
            }
            else
                childForm.Activate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            apmMain.Manager.CloseMenus();
            new Forms.Options().ShowDialog();
        }

        private void bbiAttendanceItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Attendance.Forms.DefineAttendanceItem().ShowDialog();
        }

        private void bbiDayOff_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("RegisterDayOffGroup");
            if (childForm == null)
            {
                Attendance.Forms.RegisterDayOffGroup registerDayOffGroup = new Attendance.Forms.RegisterDayOffGroup();
                registerDayOffGroup.MdiParent = this;
                registerDayOffGroup.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiRegisterRequirement_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is RibbonControl)
                {
                    Point point = rbcMain.PointToClient(Control.MousePosition);
                    RibbonHitInfo hitInfo = rbcMain.CalcHitInfo(point);

                    switch (hitInfo.HitTest)
                    {
                        case RibbonHitTest.PageHeader:
                            new Common.Forms.SetTitle(hitInfo.Page).ShowDialog();
                            break;
                        case RibbonHitTest.PageGroupCaption:
                            new Common.Forms.SetTitle(hitInfo.PageGroup).ShowDialog();
                            break;
                        case RibbonHitTest.Item:
                            new Common.Forms.SetTitle(hitInfo.Item).ShowDialog();
                            break;
                    }
                }
                else
                    new Common.Forms.SetTitle(sender).ShowDialog();
            }
        }

        private void bbiRegisterAttendanceItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("RegisterAttendanceItem");
            if (childForm == null)
            {
                Attendance.Forms.RegisterAttendanceItem registerAttendanceItem = new Attendance.Forms.RegisterAttendanceItem();
                registerAttendanceItem.MdiParent = this;
                registerAttendanceItem.Show();
            }
            else
                childForm.Activate();
        }

        private void rbcMain_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e)
        {
            e.ShowCustomizationMenu = false;
        }

        private void tmmMain_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right) new Common.Forms.SetTitle(tmmMain.SelectedPage.MdiChild).ShowDialog();
            }
            catch
            {

            }
        }

        private void bbiDecisionOfRecruiment_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void tmmMain_SelectedPageChanged(object sender, EventArgs e)
        {
            foreach (PageCategory pcg in Ribbon.PageCategories)
            {
                if (pcg.Text == tmmMain.SelectedPage.MdiChild.Text)
                {
                    pcg.Visible = true;
                    Ribbon.SelectedPage = pcg.Pages[0];
                }
                else
                    pcg.Visible = false;
            }
        }

        private void bbiDefineShiftGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Common.Forms.DefineList(new ShiftGroupTable(), TitleTable.GetValue("DEFINE_SHIFTGROUP", Constant.language)).ShowDialog();
        }

        private void bbiRegisterShiftGroup_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiEmployeeInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("EmployeeInfo");
            if (childForm == null)
            {
                Personnel.Forms.EmployeeInfo employeeInfo = new Personnel.Forms.EmployeeInfo();
                employeeInfo.MdiParent = this;
                employeeInfo.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiRegisterLateEarly_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("RegisterLateEarly");
            if (childForm == null)
            {
                Attendance.Forms.RegisterLateEarly registerLateEarly = new Attendance.Forms.RegisterLateEarly();
                registerLateEarly.MdiParent = this;
                registerLateEarly.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiMonthOvertime_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("MonthOT");
            if (childForm == null)
            {
                Attendance.Forms.MonthOT monthOvertime = new Attendance.Forms.MonthOT();
                monthOvertime.MdiParent = this;
                monthOvertime.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            automaticUpdater.ForceCheckForUpdate(true);
        }

        private void bbiCheckUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            automaticUpdater.ForceCheckForUpdate(true);
        }

        private void bbiTimeInTimeOutFix_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("TimeInTimeOutFix");
            if (childForm == null)
            {
                Attendance.Forms.TimeInTimeOutFix timeInTimeOutFix = new Attendance.Forms.TimeInTimeOutFix();
                timeInTimeOutFix.MdiParent = this;
                timeInTimeOutFix.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiResignation_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("ResignationList");
            if (childForm == null)
            {
                Personnel.Forms.ResignationList resignationList = new Personnel.Forms.ResignationList();
                resignationList.MdiParent = this;
                resignationList.Show();
            }
            else
                childForm.Activate();
        }

        private void automaticUpdater_ReadyToBeInstalled(object sender, EventArgs e)
        {
            try
            {
                if (automaticUpdater.UpdateType != wyDay.Controls.UpdateType.Automatic)
                    automaticUpdater.InstallNow();
            }
            catch
            { 
            
            }
        }

        private void bbiTimeInDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("TimeInDM");
            if (childForm == null)
            {
                Attendance.Forms.TimeInDM timeInDM = new Attendance.Forms.TimeInDM();
                timeInDM.MdiParent = this;
                timeInDM.Show();
            }
            else
                childForm.Activate();
        }

        private void bbiTimeInVS_ItemClick(object sender, ItemClickEventArgs e)
        {
            childForm = GetChildForm("TimeInVS");
            if (childForm == null)
            {
                Attendance.Forms.TimeInVS timeInVS = new Attendance.Forms.TimeInVS();
                timeInVS.MdiParent = this;
                timeInVS.Show();
            }
            else
                childForm.Activate();
        }
    }
}
