namespace Attendance.Forms
{
    partial class MonthAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthAttendance));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.grdMonthAttendance = new DevExpress.XtraGrid.GridControl();
            this.cmsLayout = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiBestFit = new System.Windows.Forms.ToolStripMenuItem();
            this.smiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.bgvMonthAttendance = new Common.CustomBandedGridView();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoEmployeeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoChucVu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoCMT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoInitialDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.icbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ttcNotes = new DevExpress.Utils.ToolTipController(this.components);
            this.sfdExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.chkResignation = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.cboYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblMonth = new System.Windows.Forms.Label();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.imageListEx = new System.Windows.Forms.ImageList(this.components);
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbEmployeeID = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbFullName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbChucVu = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbCMT = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthAttendance)).BeginInit();
            this.cmsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgvMonthAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkResignation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // grdMonthAttendance
            // 
            this.grdMonthAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMonthAttendance.ContextMenuStrip = this.cmsLayout;
            gridLevelNode1.RelationName = "Level1";
            this.grdMonthAttendance.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdMonthAttendance.Location = new System.Drawing.Point(0, 36);
            this.grdMonthAttendance.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdMonthAttendance.MainView = this.bgvMonthAttendance;
            this.grdMonthAttendance.Name = "grdMonthAttendance";
            this.grdMonthAttendance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.icbGroup});
            this.grdMonthAttendance.Size = new System.Drawing.Size(987, 324);
            this.grdMonthAttendance.TabIndex = 79;
            this.grdMonthAttendance.ToolTipController = this.ttcNotes;
            this.grdMonthAttendance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvMonthAttendance});
            // 
            // cmsLayout
            // 
            this.cmsLayout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiBestFit,
            this.smiFormat});
            this.cmsLayout.Name = "contextMenuStrip1";
            this.cmsLayout.Size = new System.Drawing.Size(163, 48);
            // 
            // smiBestFit
            // 
            this.smiBestFit.Image = ((System.Drawing.Image)(resources.GetObject("smiBestFit.Image")));
            this.smiBestFit.Name = "smiBestFit";
            this.smiBestFit.Size = new System.Drawing.Size(162, 22);
            this.smiBestFit.Text = "Độ rộng tốt nhất";
            this.smiBestFit.Click += new System.EventHandler(this.smiBestFit_Click);
            // 
            // smiFormat
            // 
            this.smiFormat.Name = "smiFormat";
            this.smiFormat.Size = new System.Drawing.Size(162, 22);
            this.smiFormat.Text = "Định dạng";
            this.smiFormat.Click += new System.EventHandler(this.smiFormat_Click);
            // 
            // bgvMonthAttendance
            // 
            this.bgvMonthAttendance.AllowFilter = false;
            this.bgvMonthAttendance.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvMonthAttendance.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvMonthAttendance.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.Appearance.GroupRow.Options.UseFont = true;
            this.bgvMonthAttendance.AppearancePrint.BandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bgvMonthAttendance.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.AppearancePrint.BandPanel.Options.UseBackColor = true;
            this.bgvMonthAttendance.AppearancePrint.BandPanel.Options.UseFont = true;
            this.bgvMonthAttendance.AppearancePrint.BandPanel.Options.UseTextOptions = true;
            this.bgvMonthAttendance.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgvMonthAttendance.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bgvMonthAttendance.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.bgvMonthAttendance.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.bgvMonthAttendance.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvMonthAttendance.AppearancePrint.GroupRow.Options.UseFont = true;
            this.bgvMonthAttendance.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.bgvMonthAttendance.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bgvMonthAttendance.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbEmployeeID,
            this.grbFullName,
            this.grbChucVu,
            this.grbCMT});
            this.bgvMonthAttendance.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoEmployeeCode,
            this.bcoFirstName,
            this.bcoLastName,
            this.bcoInitialDate,
            this.bcoDepartmentName,
            this.bcoCMT,
            this.bcoFullName,
            this.bcoChucVu});
            this.bgvMonthAttendance.Data = null;
            this.bgvMonthAttendance.FixedLineWidth = 1;
            this.bgvMonthAttendance.GridControl = this.grdMonthAttendance;
            this.bgvMonthAttendance.GroupCount = 1;
            this.bgvMonthAttendance.HorzScrollStep = 30;
            this.bgvMonthAttendance.LevelIndent = 0;
            this.bgvMonthAttendance.Name = "bgvMonthAttendance";
            this.bgvMonthAttendance.OptionsCustomization.AllowColumnMoving = false;
            this.bgvMonthAttendance.OptionsCustomization.AllowFilter = false;
            this.bgvMonthAttendance.OptionsCustomization.AllowGroup = false;
            this.bgvMonthAttendance.OptionsCustomization.AllowSort = false;
            this.bgvMonthAttendance.OptionsPrint.AutoWidth = false;
            this.bgvMonthAttendance.OptionsPrint.PrintFooter = false;
            this.bgvMonthAttendance.OptionsPrint.PrintGroupFooter = false;
            this.bgvMonthAttendance.OptionsPrint.PrintHeader = false;
            this.bgvMonthAttendance.OptionsPrint.UsePrintStyles = true;
            this.bgvMonthAttendance.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvMonthAttendance.OptionsView.ColumnAutoWidth = false;
            this.bgvMonthAttendance.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvMonthAttendance.OptionsView.EnableAppearanceOddRow = true;
            this.bgvMonthAttendance.OptionsView.ShowAutoFilterRow = true;
            this.bgvMonthAttendance.OptionsView.ShowColumnHeaders = false;
            this.bgvMonthAttendance.OptionsView.ShowDetailButtons = false;
            this.bgvMonthAttendance.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvMonthAttendance.OptionsView.ShowFooter = true;
            this.bgvMonthAttendance.OptionsView.ShowGroupPanel = false;
            this.bgvMonthAttendance.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bcoDepartmentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bgvMonthAttendance.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvMonthAttendance_CustomUnboundColumnData);
            this.bgvMonthAttendance.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bgvMonthAttendance_RowCellStyle);
            this.bgvMonthAttendance.DoubleClick += new System.EventHandler(this.bgvMonthAttendance_DoubleClick);
            this.bgvMonthAttendance.CustomDrawBandHeader += new DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventHandler(this.bgvMonthAttendance_CustomDrawBandHeader);
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
            // bcoEmployeeCode
            // 
            this.bcoEmployeeCode.AppearanceCell.Options.UseTextOptions = true;
            this.bcoEmployeeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoEmployeeCode.AppearanceHeader.Options.UseFont = true;
            this.bcoEmployeeCode.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoEmployeeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeCode.Caption = "MSNV";
            this.bcoEmployeeCode.FieldName = "EmployeeCode";
            this.bcoEmployeeCode.Name = "bcoEmployeeCode";
            this.bcoEmployeeCode.OptionsColumn.AllowEdit = false;
            this.bcoEmployeeCode.OptionsColumn.ReadOnly = true;
            this.bcoEmployeeCode.Visible = true;
            this.bcoEmployeeCode.Width = 122;
            // 
            // bcoFullName
            // 
            this.bcoFullName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoFullName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bcoFullName.Caption = "Họ và tên";
            this.bcoFullName.FieldName = "FullName";
            this.bcoFullName.Name = "bcoFullName";
            this.bcoFullName.OptionsColumn.AllowEdit = false;
            this.bcoFullName.OptionsColumn.ReadOnly = true;
            this.bcoFullName.Visible = true;
            this.bcoFullName.Width = 110;
            // 
            // bcoChucVu
            // 
            this.bcoChucVu.AppearanceCell.Options.UseTextOptions = true;
            this.bcoChucVu.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bcoChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoChucVu.Caption = "Chức vụ";
            this.bcoChucVu.FieldName = "ChucVu";
            this.bcoChucVu.Name = "bcoChucVu";
            this.bcoChucVu.OptionsColumn.AllowEdit = false;
            this.bcoChucVu.OptionsColumn.ReadOnly = true;
            this.bcoChucVu.Visible = true;
            this.bcoChucVu.Width = 90;
            // 
            // bcoCMT
            // 
            this.bcoCMT.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCMT.Caption = "CMT";
            this.bcoCMT.FieldName = "CMT";
            this.bcoCMT.Name = "bcoCMT";
            this.bcoCMT.OptionsColumn.AllowEdit = false;
            this.bcoCMT.OptionsColumn.ReadOnly = true;
            this.bcoCMT.Visible = true;
            this.bcoCMT.Width = 56;
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
            // bcoInitialDate
            // 
            this.bcoInitialDate.AppearanceCell.Options.UseTextOptions = true;
            this.bcoInitialDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoInitialDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoInitialDate.AppearanceHeader.Options.UseFont = true;
            this.bcoInitialDate.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoInitialDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoInitialDate.Caption = "Ngày vào";
            this.bcoInitialDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bcoInitialDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bcoInitialDate.FieldName = "InitialDate";
            this.bcoInitialDate.Name = "bcoInitialDate";
            this.bcoInitialDate.OptionsColumn.AllowEdit = false;
            this.bcoInitialDate.OptionsColumn.ReadOnly = true;
            this.bcoInitialDate.Visible = true;
            // 
            // bcoDepartmentName
            // 
            this.bcoDepartmentName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
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
            // ttcNotes
            // 
            this.ttcNotes.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.ttcNotes.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.ttcNotes_GetActiveObjectInfo);
            // 
            // sfdExportToExcel
            // 
            this.sfdExportToExcel.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.chkResignation);
            this.pncFilter.Controls.Add(this.txtEmployeeCode);
            this.pncFilter.Controls.Add(this.lblEmployeeCode);
            this.pncFilter.Controls.Add(this.cboYear);
            this.pncFilter.Controls.Add(this.lblYear);
            this.pncFilter.Controls.Add(this.cboMonth);
            this.pncFilter.Controls.Add(this.lblMonth);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(987, 36);
            this.pncFilter.TabIndex = 202;
            // 
            // chkResignation
            // 
            this.chkResignation.Location = new System.Drawing.Point(352, 9);
            this.chkResignation.Name = "chkResignation";
            this.chkResignation.Properties.AutoWidth = true;
            this.chkResignation.Properties.Caption = "Nghỉ việc";
            this.chkResignation.Properties.FullFocusRect = true;
            this.chkResignation.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkResignation.Size = new System.Drawing.Size(66, 19);
            this.chkResignation.TabIndex = 202;
            this.chkResignation.CheckedChanged += new System.EventHandler(this.chkResignation_CheckedChanged);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(268, 8);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtEmployeeCode.Size = new System.Drawing.Size(68, 20);
            this.txtEmployeeCode.TabIndex = 201;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(224, 12);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 200;
            this.lblEmployeeCode.Text = "Mã NV";
            // 
            // cboYear
            // 
            this.cboYear.Location = new System.Drawing.Point(144, 8);
            this.cboYear.Name = "cboYear";
            this.cboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboYear.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboYear.Size = new System.Drawing.Size(52, 20);
            this.cboYear.TabIndex = 170;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(112, 12);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 13);
            this.lblYear.TabIndex = 169;
            this.lblYear.Text = "Năm";
            // 
            // cboMonth
            // 
            this.cboMonth.Location = new System.Drawing.Point(52, 8);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMonth.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonth.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMonth.Size = new System.Drawing.Size(44, 20);
            this.cboMonth.TabIndex = 168;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(8, 12);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 167;
            this.lblMonth.Text = "Tháng";
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "folder-green-scheduled-tasks-icon.png");
            this.imlFunction.Images.SetKeyName(1, "file-export-icon.png");
            this.imlFunction.Images.SetKeyName(2, "Actions-document-preview-icon.png");
            this.imlFunction.Images.SetKeyName(3, "Document-Microsoft-Excel-icon.png");
            this.imlFunction.Images.SetKeyName(4, "layer-save-icon32.png");
            // 
            // imageListEx
            // 
            this.imageListEx.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEx.ImageStream")));
            this.imageListEx.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEx.Images.SetKeyName(0, "Actions-document-preview-icon.png");
            this.imageListEx.Images.SetKeyName(1, "Document-Microsoft-Excel-icon.png");
            this.imageListEx.Images.SetKeyName(2, "layer-save-icon32.png");
            this.imageListEx.Images.SetKeyName(3, "layout-add-icon.png");
            // 
            // grbNo
            // 
            this.grbNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNo.AppearanceHeader.Options.UseFont = true;
            this.grbNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNo.Caption = "TT";
            this.grbNo.Columns.Add(this.bcoNo);
            this.grbNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grbNo.Name = "grbNo";
            this.grbNo.RowCount = 2;
            this.grbNo.Width = 75;
            // 
            // grbEmployeeID
            // 
            this.grbEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.grbEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.grbEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbEmployeeID.Caption = "MSNV";
            this.grbEmployeeID.Columns.Add(this.bcoEmployeeCode);
            this.grbEmployeeID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grbEmployeeID.Name = "grbEmployeeID";
            this.grbEmployeeID.RowCount = 2;
            this.grbEmployeeID.Width = 122;
            // 
            // grbFullName
            // 
            this.grbFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFullName.AppearanceHeader.Options.UseFont = true;
            this.grbFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbFullName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grbFullName.Caption = "Họ và tên";
            this.grbFullName.Columns.Add(this.bcoFullName);
            this.grbFullName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grbFullName.Name = "grbFullName";
            this.grbFullName.RowCount = 2;
            this.grbFullName.Width = 110;
            // 
            // grbChucVu
            // 
            this.grbChucVu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucVu.AppearanceHeader.Options.UseFont = true;
            this.grbChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.grbChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbChucVu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grbChucVu.Caption = "Bộ phận";
            this.grbChucVu.Columns.Add(this.bcoChucVu);
            this.grbChucVu.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grbChucVu.Name = "grbChucVu";
            this.grbChucVu.RowCount = 2;
            this.grbChucVu.Width = 90;
            // 
            // grbCMT
            // 
            this.grbCMT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCMT.AppearanceHeader.Options.UseFont = true;
            this.grbCMT.AppearanceHeader.Options.UseTextOptions = true;
            this.grbCMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbCMT.Columns.Add(this.bcoCMT);
            this.grbCMT.Name = "grbCMT";
            this.grbCMT.RowCount = 2;
            this.grbCMT.Visible = false;
            this.grbCMT.Width = 56;
            // 
            // MonthAttendance
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 360);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdMonthAttendance);
            this.KeyPreview = true;
            this.Name = "MonthAttendance";
            this.Text = "Chấm công tháng";
            this.Load += new System.EventHandler(this.MonthAttendance_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonthAttendance_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonthAttendance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthAttendance)).EndInit();
            this.cmsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bgvMonthAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkResignation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMonth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdMonthAttendance;
        private Common.CustomBandedGridView bgvMonthAttendance;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoEmployeeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        internal System.Windows.Forms.ImageList imlGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbGroup;
        private System.Windows.Forms.SaveFileDialog sfdExportToExcel;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraEditors.CheckEdit chkResignation;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private System.Windows.Forms.Label lblEmployeeCode;
        private DevExpress.XtraEditors.ComboBoxEdit cboYear;
        private System.Windows.Forms.Label lblYear;
        private DevExpress.XtraEditors.ComboBoxEdit cboMonth;
        private System.Windows.Forms.Label lblMonth;
        internal System.Windows.Forms.ImageList imlFunction;
        private System.Windows.Forms.ContextMenuStrip cmsLayout;
        private System.Windows.Forms.ToolStripMenuItem smiBestFit;
        private System.Windows.Forms.ToolStripMenuItem smiFormat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoInitialDate;
        private DevExpress.Utils.ToolTipController ttcNotes;
        internal System.Windows.Forms.ImageList imageListEx;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCMT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoChucVu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbEmployeeID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbChucVu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbCMT;
    }
}
