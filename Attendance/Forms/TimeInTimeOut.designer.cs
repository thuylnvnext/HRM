namespace Attendance.Forms
{
    partial class TimeInTimeOut
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeInTimeOut));
            this.grvBreakOutBreakIn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIOTimes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBreakOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ite = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colBreakIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReasonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileReason = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdTimeInTimeOut = new DevExpress.XtraGrid.GridControl();
            this.cmsTimeInTimeOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDataFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitDataRawView = new System.Windows.Forms.ToolStripMenuItem();
            this.bgvTimeInTimeOut = new Common.CustomBandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCMT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbID = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbEmployeeCode = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoEmployeeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbHoTen = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.icbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.grbWorkingDay = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoWorkingDay = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbShift = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoShiftID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ileShift = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grbShiftInfo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbDuration = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoDuration = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbInterval = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoRest = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbTimeIn = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTimeIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbTimeOut = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTimeOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbOriginalTimeIn = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoOriginalTimeIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbOriginalTimeOut = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoOriginalTimeOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoChucVu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ttcEditInfo = new DevExpress.Utils.ToolTipController(this.components);
            this.colChildEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChildShiftID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.sfdExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.chkAdjustedTime = new DevExpress.XtraEditors.CheckEdit();
            this.chkLateComingEarlyReturning = new DevExpress.XtraEditors.CheckEdit();
            this.chkErrorDays = new DevExpress.XtraEditors.CheckEdit();
            this.chkAllDays = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.mitDataRawReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.grvBreakOutBreakIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimeInTimeOut)).BeginInit();
            this.cmsTimeInTimeOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgvTimeInTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdjustedTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLateComingEarlyReturning.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkErrorDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grvBreakOutBreakIn
            // 
            this.grvBreakOutBreakIn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colWorkingDay,
            this.colShiftID,
            this.colIOTimes,
            this.colBreakOut,
            this.colBreakIn,
            this.colReasonID});
            this.grvBreakOutBreakIn.GridControl = this.grdTimeInTimeOut;
            this.grvBreakOutBreakIn.HorzScrollStep = 10;
            this.grvBreakOutBreakIn.Name = "grvBreakOutBreakIn";
            this.grvBreakOutBreakIn.OptionsCustomization.AllowFilter = false;
            this.grvBreakOutBreakIn.OptionsCustomization.AllowGroup = false;
            this.grvBreakOutBreakIn.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grvBreakOutBreakIn.OptionsDetail.ShowDetailTabs = false;
            this.grvBreakOutBreakIn.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvBreakOutBreakIn.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvBreakOutBreakIn.OptionsSelection.MultiSelect = true;
            this.grvBreakOutBreakIn.OptionsView.ColumnAutoWidth = false;
            this.grvBreakOutBreakIn.OptionsView.EnableAppearanceEvenRow = true;
            this.grvBreakOutBreakIn.OptionsView.EnableAppearanceOddRow = true;
            this.grvBreakOutBreakIn.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvBreakOutBreakIn.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvBreakOutBreakIn.OptionsView.ShowGroupPanel = false;
            this.grvBreakOutBreakIn.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvBreakOutBreakIn_InitNewRow);
            this.grvBreakOutBreakIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvBreakOutBreakIn_KeyDown);
            this.grvBreakOutBreakIn.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvBreakOutBreakIn_CellValueChanging);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.Caption = "Mã NV";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.OptionsColumn.AllowEdit = false;
            this.colEmployeeID.OptionsColumn.ReadOnly = true;
            // 
            // colWorkingDay
            // 
            this.colWorkingDay.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkingDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkingDay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colWorkingDay.AppearanceHeader.Options.UseFont = true;
            this.colWorkingDay.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkingDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkingDay.Caption = "Ngày";
            this.colWorkingDay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colWorkingDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colWorkingDay.FieldName = "WorkingDay";
            this.colWorkingDay.Name = "colWorkingDay";
            this.colWorkingDay.OptionsColumn.AllowEdit = false;
            this.colWorkingDay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkingDay.OptionsColumn.ReadOnly = true;
            // 
            // colShiftID
            // 
            this.colShiftID.AppearanceCell.Options.UseTextOptions = true;
            this.colShiftID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colShiftID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colShiftID.AppearanceHeader.Options.UseFont = true;
            this.colShiftID.AppearanceHeader.Options.UseTextOptions = true;
            this.colShiftID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShiftID.Caption = "Ca làm việc";
            this.colShiftID.FieldName = "ShiftID";
            this.colShiftID.Name = "colShiftID";
            this.colShiftID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIOTimes
            // 
            this.colIOTimes.AppearanceCell.Options.UseTextOptions = true;
            this.colIOTimes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIOTimes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIOTimes.AppearanceHeader.Options.UseFont = true;
            this.colIOTimes.AppearanceHeader.Options.UseTextOptions = true;
            this.colIOTimes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIOTimes.Caption = "STT";
            this.colIOTimes.FieldName = "IOTimes";
            this.colIOTimes.Name = "colIOTimes";
            this.colIOTimes.OptionsColumn.AllowEdit = false;
            this.colIOTimes.OptionsColumn.ReadOnly = true;
            this.colIOTimes.Visible = true;
            this.colIOTimes.VisibleIndex = 0;
            // 
            // colBreakOut
            // 
            this.colBreakOut.AppearanceCell.Options.UseTextOptions = true;
            this.colBreakOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBreakOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBreakOut.AppearanceHeader.Options.UseFont = true;
            this.colBreakOut.AppearanceHeader.Options.UseTextOptions = true;
            this.colBreakOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBreakOut.Caption = "Giờ ra";
            this.colBreakOut.ColumnEdit = this.ite;
            this.colBreakOut.FieldName = "BreakOut";
            this.colBreakOut.Name = "colBreakOut";
            this.colBreakOut.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBreakOut.Visible = true;
            this.colBreakOut.VisibleIndex = 1;
            // 
            // ite
            // 
            this.ite.AutoHeight = false;
            this.ite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ite.DisplayFormat.FormatString = "HH:mm";
            this.ite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ite.EditFormat.FormatString = "HH:mm";
            this.ite.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ite.Mask.EditMask = "HH:mm";
            this.ite.Name = "ite";
            // 
            // colBreakIn
            // 
            this.colBreakIn.AppearanceCell.Options.UseTextOptions = true;
            this.colBreakIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBreakIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBreakIn.AppearanceHeader.Options.UseFont = true;
            this.colBreakIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colBreakIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBreakIn.Caption = "Giờ vào";
            this.colBreakIn.ColumnEdit = this.ite;
            this.colBreakIn.FieldName = "BreakIn";
            this.colBreakIn.Name = "colBreakIn";
            this.colBreakIn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBreakIn.Visible = true;
            this.colBreakIn.VisibleIndex = 2;
            // 
            // colReasonID
            // 
            this.colReasonID.AppearanceCell.Options.UseTextOptions = true;
            this.colReasonID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colReasonID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colReasonID.AppearanceHeader.Options.UseFont = true;
            this.colReasonID.AppearanceHeader.Options.UseTextOptions = true;
            this.colReasonID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReasonID.Caption = "Lý do";
            this.colReasonID.ColumnEdit = this.ileReason;
            this.colReasonID.FieldName = "ReasonID";
            this.colReasonID.Name = "colReasonID";
            this.colReasonID.Visible = true;
            this.colReasonID.VisibleIndex = 3;
            // 
            // ileReason
            // 
            this.ileReason.AppearanceDropDown.Options.UseTextOptions = true;
            this.ileReason.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ileReason.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileReason.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileReason.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ileReason.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ileReason.AutoHeight = false;
            this.ileReason.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileReason.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileReason.Name = "ileReason";
            this.ileReason.NullText = "";
            // 
            // grdTimeInTimeOut
            // 
            this.grdTimeInTimeOut.AllowDrop = true;
            this.grdTimeInTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTimeInTimeOut.ContextMenuStrip = this.cmsTimeInTimeOut;
            gridLevelNode1.LevelTemplate = this.grvBreakOutBreakIn;
            gridLevelNode1.RelationName = "TimeInTimeOut_BreakOutBreakIn";
            this.grdTimeInTimeOut.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdTimeInTimeOut.Location = new System.Drawing.Point(0, 36);
            this.grdTimeInTimeOut.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdTimeInTimeOut.MainView = this.bgvTimeInTimeOut;
            this.grdTimeInTimeOut.Name = "grdTimeInTimeOut";
            this.grdTimeInTimeOut.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.icbGroup,
            this.ite,
            this.ileReason,
            this.ileShift});
            this.grdTimeInTimeOut.Size = new System.Drawing.Size(1013, 310);
            this.grdTimeInTimeOut.TabIndex = 203;
            this.grdTimeInTimeOut.ToolTipController = this.ttcEditInfo;
            this.grdTimeInTimeOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvTimeInTimeOut,
            this.grvBreakOutBreakIn});
            // 
            // cmsTimeInTimeOut
            // 
            this.cmsTimeInTimeOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataFilter,
            this.toolStripSeparator1,
            this.mitDataRawView,
            this.toolStripSeparator2,
            this.mitDataRawReset});
            this.cmsTimeInTimeOut.Name = "cmsEmployee";
            this.cmsTimeInTimeOut.Size = new System.Drawing.Size(198, 104);
            // 
            // mnuDataFilter
            // 
            this.mnuDataFilter.Name = "mnuDataFilter";
            this.mnuDataFilter.Size = new System.Drawing.Size(197, 22);
            this.mnuDataFilter.Text = "Lọc dữ liệu";
            this.mnuDataFilter.Click += new System.EventHandler(this.mnuDataFilter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // mitDataRawView
            // 
            this.mitDataRawView.Image = ((System.Drawing.Image)(resources.GetObject("mitDataRawView.Image")));
            this.mitDataRawView.Name = "mitDataRawView";
            this.mitDataRawView.Size = new System.Drawing.Size(197, 22);
            this.mitDataRawView.Text = "Dữ liệu gốc";
            this.mitDataRawView.Click += new System.EventHandler(this.mitDataRawView_Click);
            // 
            // bgvTimeInTimeOut
            // 
            this.bgvTimeInTimeOut.AllowFilter = false;
            this.bgvTimeInTimeOut.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvTimeInTimeOut.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvTimeInTimeOut.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvTimeInTimeOut.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvTimeInTimeOut.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvTimeInTimeOut.Appearance.GroupRow.Options.UseFont = true;
            this.bgvTimeInTimeOut.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.gridBand1,
            this.grbID,
            this.grbEmployeeCode,
            this.grbHoTen,
            this.grbDepartmentName,
            this.grbWorkingDay,
            this.grbShift,
            this.grbShiftInfo,
            this.grbTimeIn,
            this.grbTimeOut,
            this.grbOriginalTimeIn,
            this.grbOriginalTimeOut});
            this.bgvTimeInTimeOut.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoEmployeeCode,
            this.bcoFirstName,
            this.bcoLastName,
            this.bcoDepartmentName,
            this.bcoWorkingDay,
            this.bcoShiftID,
            this.bcoDuration,
            this.bcoRest,
            this.bcoTimeIn,
            this.bcoTimeOut,
            this.bcoOriginalTimeIn,
            this.bcoOriginalTimeOut,
            this.bcoFullName,
            this.bcoCMT,
            this.bcoChucVu,
            this.bcoID});
            this.bgvTimeInTimeOut.Data = null;
            this.bgvTimeInTimeOut.FixedLineWidth = 1;
            this.bgvTimeInTimeOut.GridControl = this.grdTimeInTimeOut;
            this.bgvTimeInTimeOut.GroupCount = 1;
            this.bgvTimeInTimeOut.HorzScrollStep = 10;
            this.bgvTimeInTimeOut.Name = "bgvTimeInTimeOut";
            this.bgvTimeInTimeOut.OptionsCustomization.AllowFilter = false;
            this.bgvTimeInTimeOut.OptionsCustomization.AllowGroup = false;
            this.bgvTimeInTimeOut.OptionsCustomization.AllowSort = false;
            this.bgvTimeInTimeOut.OptionsDetail.AllowExpandEmptyDetails = true;
            this.bgvTimeInTimeOut.OptionsDetail.ShowDetailTabs = false;
            this.bgvTimeInTimeOut.OptionsLayout.Columns.StoreAllOptions = true;
            this.bgvTimeInTimeOut.OptionsLayout.Columns.StoreAppearance = true;
            this.bgvTimeInTimeOut.OptionsLayout.StoreAllOptions = true;
            this.bgvTimeInTimeOut.OptionsLayout.StoreAppearance = true;
            this.bgvTimeInTimeOut.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvTimeInTimeOut.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvTimeInTimeOut.OptionsSelection.MultiSelect = true;
            this.bgvTimeInTimeOut.OptionsView.ColumnAutoWidth = false;
            this.bgvTimeInTimeOut.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvTimeInTimeOut.OptionsView.EnableAppearanceOddRow = true;
            this.bgvTimeInTimeOut.OptionsView.ShowAutoFilterRow = true;
            this.bgvTimeInTimeOut.OptionsView.ShowColumnHeaders = false;
            this.bgvTimeInTimeOut.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvTimeInTimeOut.OptionsView.ShowFooter = true;
            this.bgvTimeInTimeOut.OptionsView.ShowGroupPanel = false;
            this.bgvTimeInTimeOut.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bcoDepartmentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bgvTimeInTimeOut.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvTimeInTimeOut_CustomUnboundColumnData);
            this.bgvTimeInTimeOut.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.bgvTimeInTimeOut_MasterRowExpanding);
            this.bgvTimeInTimeOut.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvTimeInTimeOut_CellValueChanging);
            this.bgvTimeInTimeOut.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.bgvTimeInTimeOut_CustomDrawCell);
            this.bgvTimeInTimeOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bgvTimeInTimeOut_MouseDown);
            this.bgvTimeInTimeOut.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bgvTimeInTimeOut_RowCellStyle);
            this.bgvTimeInTimeOut.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.bgvTimeInTimeOut_ShowingEditor);
            this.bgvTimeInTimeOut.DoubleClick += new System.EventHandler(this.bgvTimeInTimeOut_DoubleClick);
            this.bgvTimeInTimeOut.CustomDrawBandHeader += new DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventHandler(this.bgvTimeInTimeOut_CustomDrawBandHeader);
            // 
            // grbNo
            // 
            this.grbNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbNo.AppearanceHeader.Options.UseFont = true;
            this.grbNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNo.Caption = "STT";
            this.grbNo.Columns.Add(this.bcoNo);
            this.grbNo.Name = "grbNo";
            this.grbNo.Width = 75;
            // 
            // bcoNo
            // 
            this.bcoNo.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNo.AppearanceHeader.Options.UseFont = true;
            this.bcoNo.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNo.Caption = "STT";
            this.bcoNo.FieldName = "No";
            this.bcoNo.Name = "bcoNo";
            this.bcoNo.OptionsColumn.AllowEdit = false;
            this.bcoNo.OptionsColumn.ReadOnly = true;
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoNo.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.bcoCMT);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Visible = false;
            this.gridBand1.Width = 75;
            // 
            // bcoCMT
            // 
            this.bcoCMT.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCMT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoCMT.AppearanceHeader.Options.UseFont = true;
            this.bcoCMT.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCMT.Caption = "CMT";
            this.bcoCMT.FieldName = "CMT";
            this.bcoCMT.Name = "bcoCMT";
            this.bcoCMT.OptionsColumn.AllowEdit = false;
            this.bcoCMT.OptionsColumn.ReadOnly = true;
            // 
            // grbID
            // 
            this.grbID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbID.AppearanceHeader.Options.UseFont = true;
            this.grbID.AppearanceHeader.Options.UseTextOptions = true;
            this.grbID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbID.Caption = "ID";
            this.grbID.Columns.Add(this.bcoID);
            this.grbID.Name = "grbID";
            this.grbID.Width = 75;
            // 
            // bcoID
            // 
            this.bcoID.Caption = "ID";
            this.bcoID.FieldName = "EmployeeID";
            this.bcoID.Name = "bcoID";
            this.bcoID.OptionsColumn.AllowEdit = false;
            this.bcoID.OptionsColumn.ReadOnly = true;
            this.bcoID.Visible = true;
            // 
            // grbEmployeeCode
            // 
            this.grbEmployeeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbEmployeeCode.AppearanceHeader.Options.UseFont = true;
            this.grbEmployeeCode.AppearanceHeader.Options.UseTextOptions = true;
            this.grbEmployeeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbEmployeeCode.Caption = "MSNV";
            this.grbEmployeeCode.Columns.Add(this.bcoEmployeeCode);
            this.grbEmployeeCode.Name = "grbEmployeeCode";
            this.grbEmployeeCode.Width = 75;
            // 
            // bcoEmployeeCode
            // 
            this.bcoEmployeeCode.AppearanceCell.Options.UseTextOptions = true;
            this.bcoEmployeeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoEmployeeCode.AppearanceHeader.Options.UseFont = true;
            this.bcoEmployeeCode.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoEmployeeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeCode.Caption = "Mã NV";
            this.bcoEmployeeCode.FieldName = "EmployeeCode";
            this.bcoEmployeeCode.Name = "bcoEmployeeCode";
            this.bcoEmployeeCode.OptionsColumn.AllowEdit = false;
            this.bcoEmployeeCode.OptionsColumn.ReadOnly = true;
            this.bcoEmployeeCode.Visible = true;
            // 
            // grbHoTen
            // 
            this.grbHoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHoTen.AppearanceHeader.Options.UseFont = true;
            this.grbHoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.grbHoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbHoTen.Caption = "Họ và tên";
            this.grbHoTen.Columns.Add(this.bcoFullName);
            this.grbHoTen.Name = "grbHoTen";
            this.grbHoTen.Width = 95;
            // 
            // bcoFullName
            // 
            this.bcoFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoFullName.AppearanceHeader.Options.UseFont = true;
            this.bcoFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFullName.Caption = "Họ và tên";
            this.bcoFullName.FieldName = "FullName";
            this.bcoFullName.Name = "bcoFullName";
            this.bcoFullName.OptionsColumn.AllowEdit = false;
            this.bcoFullName.OptionsColumn.ReadOnly = true;
            this.bcoFullName.Visible = true;
            this.bcoFullName.Width = 95;
            // 
            // grbDepartmentName
            // 
            this.grbDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.grbDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDepartmentName.Caption = "Bộ phận";
            this.grbDepartmentName.Columns.Add(this.bcoDepartmentName);
            this.grbDepartmentName.Name = "grbDepartmentName";
            this.grbDepartmentName.Visible = false;
            this.grbDepartmentName.Width = 75;
            // 
            // bcoDepartmentName
            // 
            this.bcoDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.bcoDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoDepartmentName.Caption = "Bộ phận";
            this.bcoDepartmentName.ColumnEdit = this.icbGroup;
            this.bcoDepartmentName.FieldName = "DepartmentName";
            this.bcoDepartmentName.Name = "bcoDepartmentName";
            this.bcoDepartmentName.OptionsColumn.AllowEdit = false;
            this.bcoDepartmentName.OptionsColumn.ReadOnly = true;
            this.bcoDepartmentName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.bcoDepartmentName.Visible = true;
            // 
            // icbGroup
            // 
            this.icbGroup.AutoHeight = false;
            this.icbGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbGroup.Name = "icbGroup";
            this.icbGroup.SmallImages = this.imlGroup;
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // grbWorkingDay
            // 
            this.grbWorkingDay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbWorkingDay.AppearanceHeader.Options.UseFont = true;
            this.grbWorkingDay.AppearanceHeader.Options.UseTextOptions = true;
            this.grbWorkingDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbWorkingDay.Caption = "Ngày";
            this.grbWorkingDay.Columns.Add(this.bcoWorkingDay);
            this.grbWorkingDay.Name = "grbWorkingDay";
            this.grbWorkingDay.Width = 81;
            // 
            // bcoWorkingDay
            // 
            this.bcoWorkingDay.AppearanceCell.Options.UseTextOptions = true;
            this.bcoWorkingDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoWorkingDay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoWorkingDay.AppearanceHeader.Options.UseFont = true;
            this.bcoWorkingDay.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoWorkingDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoWorkingDay.Caption = "Ngày";
            this.bcoWorkingDay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bcoWorkingDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoWorkingDay.FieldName = "WorkingDay";
            this.bcoWorkingDay.Name = "bcoWorkingDay";
            this.bcoWorkingDay.OptionsColumn.AllowEdit = false;
            this.bcoWorkingDay.OptionsColumn.ReadOnly = true;
            this.bcoWorkingDay.Visible = true;
            this.bcoWorkingDay.Width = 81;
            // 
            // grbShift
            // 
            this.grbShift.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbShift.AppearanceHeader.Options.UseFont = true;
            this.grbShift.AppearanceHeader.Options.UseTextOptions = true;
            this.grbShift.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbShift.Caption = "Ca làm việc";
            this.grbShift.Columns.Add(this.bcoShiftID);
            this.grbShift.Name = "grbShift";
            this.grbShift.Width = 125;
            // 
            // bcoShiftID
            // 
            this.bcoShiftID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoShiftID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoShiftID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoShiftID.AppearanceHeader.Options.UseFont = true;
            this.bcoShiftID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoShiftID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoShiftID.Caption = "Ca làm việc";
            this.bcoShiftID.ColumnEdit = this.ileShift;
            this.bcoShiftID.FieldName = "ShiftID";
            this.bcoShiftID.Name = "bcoShiftID";
            this.bcoShiftID.Visible = true;
            this.bcoShiftID.Width = 125;
            // 
            // ileShift
            // 
            this.ileShift.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileShift.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileShift.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ileShift.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ileShift.AutoHeight = false;
            this.ileShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileShift.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileShift.Name = "ileShift";
            this.ileShift.NullText = "";
            // 
            // grbShiftInfo
            // 
            this.grbShiftInfo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbShiftInfo.AppearanceHeader.Options.UseFont = true;
            this.grbShiftInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbShiftInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbShiftInfo.Caption = "Thông tin ca";
            this.grbShiftInfo.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbDuration,
            this.grbInterval});
            this.grbShiftInfo.Name = "grbShiftInfo";
            this.grbShiftInfo.Width = 150;
            // 
            // grbDuration
            // 
            this.grbDuration.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbDuration.AppearanceHeader.Options.UseFont = true;
            this.grbDuration.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDuration.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDuration.Caption = "Thời gian";
            this.grbDuration.Columns.Add(this.bcoDuration);
            this.grbDuration.Name = "grbDuration";
            this.grbDuration.Width = 75;
            // 
            // bcoDuration
            // 
            this.bcoDuration.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDuration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoDuration.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoDuration.AppearanceHeader.Options.UseFont = true;
            this.bcoDuration.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoDuration.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoDuration.Caption = "Thời gian";
            this.bcoDuration.FieldName = "Duration";
            this.bcoDuration.Name = "bcoDuration";
            this.bcoDuration.OptionsColumn.AllowEdit = false;
            this.bcoDuration.OptionsColumn.ReadOnly = true;
            this.bcoDuration.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.bcoDuration.Visible = true;
            // 
            // grbInterval
            // 
            this.grbInterval.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbInterval.AppearanceHeader.Options.UseFont = true;
            this.grbInterval.AppearanceHeader.Options.UseTextOptions = true;
            this.grbInterval.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbInterval.Caption = "Giữa giờ";
            this.grbInterval.Columns.Add(this.bcoRest);
            this.grbInterval.Name = "grbInterval";
            this.grbInterval.Width = 75;
            // 
            // bcoRest
            // 
            this.bcoRest.AppearanceCell.Options.UseTextOptions = true;
            this.bcoRest.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoRest.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoRest.AppearanceHeader.Options.UseFont = true;
            this.bcoRest.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoRest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoRest.Caption = "Giữa giờ";
            this.bcoRest.FieldName = "Rest";
            this.bcoRest.Name = "bcoRest";
            this.bcoRest.OptionsColumn.AllowEdit = false;
            this.bcoRest.OptionsColumn.ReadOnly = true;
            this.bcoRest.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.bcoRest.Visible = true;
            // 
            // grbTimeIn
            // 
            this.grbTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbTimeIn.AppearanceHeader.Options.UseFont = true;
            this.grbTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.grbTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbTimeIn.Caption = "Vào";
            this.grbTimeIn.Columns.Add(this.bcoTimeIn);
            this.grbTimeIn.Name = "grbTimeIn";
            this.grbTimeIn.Width = 75;
            // 
            // bcoTimeIn
            // 
            this.bcoTimeIn.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTimeIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoTimeIn.AppearanceHeader.Options.UseFont = true;
            this.bcoTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeIn.Caption = "Vào";
            this.bcoTimeIn.ColumnEdit = this.ite;
            this.bcoTimeIn.DisplayFormat.FormatString = "HH:mm";
            this.bcoTimeIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoTimeIn.FieldName = "TimeIn";
            this.bcoTimeIn.Name = "bcoTimeIn";
            this.bcoTimeIn.Visible = true;
            // 
            // grbTimeOut
            // 
            this.grbTimeOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbTimeOut.AppearanceHeader.Options.UseFont = true;
            this.grbTimeOut.AppearanceHeader.Options.UseTextOptions = true;
            this.grbTimeOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbTimeOut.Caption = "Ra";
            this.grbTimeOut.Columns.Add(this.bcoTimeOut);
            this.grbTimeOut.Name = "grbTimeOut";
            this.grbTimeOut.Width = 75;
            // 
            // bcoTimeOut
            // 
            this.bcoTimeOut.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTimeOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoTimeOut.AppearanceHeader.Options.UseFont = true;
            this.bcoTimeOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTimeOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeOut.Caption = "Ra";
            this.bcoTimeOut.ColumnEdit = this.ite;
            this.bcoTimeOut.DisplayFormat.FormatString = "HH:mm";
            this.bcoTimeOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoTimeOut.FieldName = "TimeOut";
            this.bcoTimeOut.Name = "bcoTimeOut";
            this.bcoTimeOut.Visible = true;
            // 
            // grbOriginalTimeIn
            // 
            this.grbOriginalTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbOriginalTimeIn.AppearanceHeader.Options.UseFont = true;
            this.grbOriginalTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.grbOriginalTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbOriginalTimeIn.Caption = "Giờ vào (gốc)";
            this.grbOriginalTimeIn.Columns.Add(this.bcoOriginalTimeIn);
            this.grbOriginalTimeIn.Name = "grbOriginalTimeIn";
            this.grbOriginalTimeIn.Visible = false;
            this.grbOriginalTimeIn.Width = 75;
            // 
            // bcoOriginalTimeIn
            // 
            this.bcoOriginalTimeIn.AppearanceCell.Options.UseTextOptions = true;
            this.bcoOriginalTimeIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOriginalTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoOriginalTimeIn.AppearanceHeader.Options.UseFont = true;
            this.bcoOriginalTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoOriginalTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOriginalTimeIn.Caption = "Giờ vào (gốc)";
            this.bcoOriginalTimeIn.DisplayFormat.FormatString = "HH:mm";
            this.bcoOriginalTimeIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoOriginalTimeIn.FieldName = "OriginalTimeIn";
            this.bcoOriginalTimeIn.Name = "bcoOriginalTimeIn";
            this.bcoOriginalTimeIn.Visible = true;
            // 
            // grbOriginalTimeOut
            // 
            this.grbOriginalTimeOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbOriginalTimeOut.AppearanceHeader.Options.UseFont = true;
            this.grbOriginalTimeOut.AppearanceHeader.Options.UseTextOptions = true;
            this.grbOriginalTimeOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbOriginalTimeOut.Caption = "Giờ ra (gốc)";
            this.grbOriginalTimeOut.Columns.Add(this.bcoOriginalTimeOut);
            this.grbOriginalTimeOut.Name = "grbOriginalTimeOut";
            this.grbOriginalTimeOut.Visible = false;
            this.grbOriginalTimeOut.Width = 75;
            // 
            // bcoOriginalTimeOut
            // 
            this.bcoOriginalTimeOut.AppearanceCell.Options.UseTextOptions = true;
            this.bcoOriginalTimeOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOriginalTimeOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoOriginalTimeOut.AppearanceHeader.Options.UseFont = true;
            this.bcoOriginalTimeOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoOriginalTimeOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOriginalTimeOut.Caption = "Giờ ra (gốc)";
            this.bcoOriginalTimeOut.DisplayFormat.FormatString = "HH:mm";
            this.bcoOriginalTimeOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoOriginalTimeOut.FieldName = "OriginalTimeOut";
            this.bcoOriginalTimeOut.Name = "bcoOriginalTimeOut";
            this.bcoOriginalTimeOut.Visible = true;
            // 
            // bcoFirstName
            // 
            this.bcoFirstName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoFirstName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoFirstName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoFirstName.AppearanceHeader.Options.UseFont = true;
            this.bcoFirstName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoFirstName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFirstName.Caption = "Họ và đệm";
            this.bcoFirstName.FieldName = "FirstName";
            this.bcoFirstName.Name = "bcoFirstName";
            this.bcoFirstName.OptionsColumn.AllowEdit = false;
            this.bcoFirstName.OptionsColumn.ReadOnly = true;
            this.bcoFirstName.Visible = true;
            // 
            // bcoLastName
            // 
            this.bcoLastName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoLastName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoLastName.AppearanceHeader.Options.UseFont = true;
            this.bcoLastName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoLastName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoLastName.Caption = "Tên";
            this.bcoLastName.FieldName = "LastName";
            this.bcoLastName.Name = "bcoLastName";
            this.bcoLastName.OptionsColumn.AllowEdit = false;
            this.bcoLastName.OptionsColumn.ReadOnly = true;
            this.bcoLastName.Visible = true;
            // 
            // bcoChucVu
            // 
            this.bcoChucVu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoChucVu.AppearanceHeader.Options.UseFont = true;
            this.bcoChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoChucVu.Caption = "Chức vụ";
            this.bcoChucVu.FieldName = "ChucVu";
            this.bcoChucVu.Name = "bcoChucVu";
            this.bcoChucVu.OptionsColumn.AllowEdit = false;
            this.bcoChucVu.OptionsColumn.ReadOnly = true;
            this.bcoChucVu.Visible = true;
            // 
            // ttcEditInfo
            // 
            this.ttcEditInfo.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.ttcEditInfo.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.ttcEditInfo_GetActiveObjectInfo);
            // 
            // colChildEmployeeID
            // 
            this.colChildEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.colChildEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChildEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colChildEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colChildEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colChildEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChildEmployeeID.Caption = "Mã NV";
            this.colChildEmployeeID.Name = "colChildEmployeeID";
            // 
            // colChildShiftID
            // 
            this.colChildShiftID.AppearanceCell.Options.UseTextOptions = true;
            this.colChildShiftID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colChildShiftID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colChildShiftID.AppearanceHeader.Options.UseFont = true;
            this.colChildShiftID.AppearanceHeader.Options.UseTextOptions = true;
            this.colChildShiftID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChildShiftID.Caption = "Ca làm việc";
            this.colChildShiftID.FieldName = "ShiftID";
            this.colChildShiftID.Name = "colChildShiftID";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(8, 12);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 115;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(160, 12);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 116;
            this.lblToDate.Text = "Đến ngày";
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(60, 8);
            this.dedFromDate.Name = "dedFromDate";
            this.dedFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedFromDate.Size = new System.Drawing.Size(80, 20);
            this.dedFromDate.TabIndex = 190;
            this.dedFromDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateEdit_KeyPress);
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(220, 8);
            this.dedToDate.Name = "dedToDate";
            this.dedToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedToDate.Size = new System.Drawing.Size(80, 20);
            this.dedToDate.TabIndex = 191;
            this.dedToDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateEdit_KeyPress);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(336, 12);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 197;
            this.lblEmployeeCode.Text = "Mã NV";
            // 
            // sfdExportToExcel
            // 
            this.sfdExportToExcel.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.chkAdjustedTime);
            this.pncFilter.Controls.Add(this.chkLateComingEarlyReturning);
            this.pncFilter.Controls.Add(this.chkErrorDays);
            this.pncFilter.Controls.Add(this.chkAllDays);
            this.pncFilter.Controls.Add(this.txtEmployeeCode);
            this.pncFilter.Controls.Add(this.lblEmployeeCode);
            this.pncFilter.Controls.Add(this.dedToDate);
            this.pncFilter.Controls.Add(this.lblToDate);
            this.pncFilter.Controls.Add(this.dedFromDate);
            this.pncFilter.Controls.Add(this.lblFromDate);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(1013, 36);
            this.pncFilter.TabIndex = 202;
            // 
            // chkAdjustedTime
            // 
            this.chkAdjustedTime.Location = new System.Drawing.Point(828, 9);
            this.chkAdjustedTime.Name = "chkAdjustedTime";
            this.chkAdjustedTime.Properties.AutoWidth = true;
            this.chkAdjustedTime.Properties.Caption = "Giờ sửa";
            this.chkAdjustedTime.Properties.FullFocusRect = true;
            this.chkAdjustedTime.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkAdjustedTime.Size = new System.Drawing.Size(59, 19);
            this.chkAdjustedTime.TabIndex = 205;
            this.chkAdjustedTime.Visible = false;
            this.chkAdjustedTime.CheckedChanged += new System.EventHandler(this.chkAdjustedTime_CheckedChanged);
            // 
            // chkLateComingEarlyReturning
            // 
            this.chkLateComingEarlyReturning.Location = new System.Drawing.Point(712, 9);
            this.chkLateComingEarlyReturning.Name = "chkLateComingEarlyReturning";
            this.chkLateComingEarlyReturning.Properties.AutoWidth = true;
            this.chkLateComingEarlyReturning.Properties.Caption = "Đi muộn/ Về sớm";
            this.chkLateComingEarlyReturning.Properties.FullFocusRect = true;
            this.chkLateComingEarlyReturning.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkLateComingEarlyReturning.Size = new System.Drawing.Size(103, 19);
            this.chkLateComingEarlyReturning.TabIndex = 204;
            this.chkLateComingEarlyReturning.Visible = false;
            this.chkLateComingEarlyReturning.CheckedChanged += new System.EventHandler(this.chkLateComingEarlyReturning_CheckedChanged);
            // 
            // chkErrorDays
            // 
            this.chkErrorDays.Location = new System.Drawing.Point(616, 9);
            this.chkErrorDays.Name = "chkErrorDays";
            this.chkErrorDays.Properties.AutoWidth = true;
            this.chkErrorDays.Properties.Caption = "Các ngày lỗi";
            this.chkErrorDays.Properties.FullFocusRect = true;
            this.chkErrorDays.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkErrorDays.Size = new System.Drawing.Size(81, 19);
            this.chkErrorDays.TabIndex = 203;
            this.chkErrorDays.Visible = false;
            this.chkErrorDays.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // chkAllDays
            // 
            this.chkAllDays.Location = new System.Drawing.Point(504, 9);
            this.chkAllDays.Name = "chkAllDays";
            this.chkAllDays.Properties.AutoWidth = true;
            this.chkAllDays.Properties.Caption = "Tất cả các ngày";
            this.chkAllDays.Properties.FullFocusRect = true;
            this.chkAllDays.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkAllDays.Size = new System.Drawing.Size(99, 19);
            this.chkAllDays.TabIndex = 202;
            this.chkAllDays.Visible = false;
            this.chkAllDays.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(384, 8);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtEmployeeCode.Size = new System.Drawing.Size(68, 20);
            this.txtEmployeeCode.TabIndex = 201;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged);
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "database-save-icon32.png");
            this.imlFunction.Images.SetKeyName(1, "hand-property-icon.png");
            this.imlFunction.Images.SetKeyName(2, "Undo-icon.png");
            this.imlFunction.Images.SetKeyName(3, "checklist_32.png");
            this.imlFunction.Images.SetKeyName(4, "Actions-document-preview-icon.png");
            this.imlFunction.Images.SetKeyName(5, "Document-Microsoft-Excel-icon.png");
            this.imlFunction.Images.SetKeyName(6, "layer-save-icon32.png");
            this.imlFunction.Images.SetKeyName(7, "layout-add-icon.png");
            // 
            // mitDataRawReset
            // 
            this.mitDataRawReset.Name = "mitDataRawReset";
            this.mitDataRawReset.Size = new System.Drawing.Size(197, 22);
            this.mitDataRawReset.Text = "Xử lý lại dữ liệu bản ghi";
            this.mitDataRawReset.Click += new System.EventHandler(this.mitDataRawReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // TimeInTimeOut
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 346);
            this.Controls.Add(this.grdTimeInTimeOut);
            this.Controls.Add(this.pncFilter);
            this.KeyPreview = true;
            this.Name = "TimeInTimeOut";
            this.Text = "Chi tiết vào ra";
            this.Load += new System.EventHandler(this.TimeInTimeOut_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeInTimeOut_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimeInTimeOut_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvBreakOutBreakIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimeInTimeOut)).EndInit();
            this.cmsTimeInTimeOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bgvTimeInTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdjustedTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLateComingEarlyReturning.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkErrorDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        internal System.Windows.Forms.ImageList imlGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colChildEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colChildShiftID;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.SaveFileDialog sfdExportToExcel;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraEditors.CheckEdit chkAllDays;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        internal System.Windows.Forms.ImageList imlFunction;
        private DevExpress.XtraEditors.CheckEdit chkErrorDays;
        private DevExpress.XtraGrid.GridControl grdTimeInTimeOut;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBreakOutBreakIn;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingDay;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftID;
        private DevExpress.XtraGrid.Columns.GridColumn colIOTimes;
        private DevExpress.XtraGrid.Columns.GridColumn colBreakOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit ite;
        private DevExpress.XtraGrid.Columns.GridColumn colBreakIn;
        private DevExpress.XtraGrid.Columns.GridColumn colReasonID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileReason;
        private Common.CustomBandedGridView bgvTimeInTimeOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoEmployeeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbGroup;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoWorkingDay;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoShiftID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileShift;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDuration;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoRest;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTimeIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTimeOut;
        private System.Windows.Forms.ContextMenuStrip cmsTimeInTimeOut;
        private System.Windows.Forms.ToolStripMenuItem mitDataRawView;
        private DevExpress.Utils.ToolTipController ttcEditInfo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoOriginalTimeIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoOriginalTimeOut;
        private DevExpress.XtraEditors.CheckEdit chkLateComingEarlyReturning;
        private DevExpress.XtraEditors.CheckEdit chkAdjustedTime;
        private System.Windows.Forms.ToolStripMenuItem mnuDataFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCMT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoChucVu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbEmployeeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbHoTen;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDepartmentName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbWorkingDay;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbShift;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbShiftInfo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDuration;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbInterval;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbTimeIn;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbTimeOut;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbOriginalTimeIn;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbOriginalTimeOut;
        private System.Windows.Forms.ToolStripMenuItem mitDataRawReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
