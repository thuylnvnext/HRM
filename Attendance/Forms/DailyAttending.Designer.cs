namespace Attendance.Forms
{
    partial class DailyAttending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyAttending));
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.colChildEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChildWorkingDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIOTimes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBreakOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBreakIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReasonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChildDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentWorkingDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDailyAttending = new DevExpress.XtraGrid.GridControl();
            this.bgvDailyAttending = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbEmployeeID = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoEmployeeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbFullName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbShiftName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoShiftName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbAttending = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoAttending = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.icbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.dedWorkingDay = new DevExpress.XtraEditors.DateEdit();
            this.lblWorkingDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDailyAttending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvDailyAttending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "Windows-Close-Program-icon.png");
            this.imlButton.Images.SetKeyName(1, "PrintPreviewHS.png");
            // 
            // colChildEmployeeID
            // 
            this.colChildEmployeeID.Name = "colChildEmployeeID";
            // 
            // colChildWorkingDay
            // 
            this.colChildWorkingDay.Name = "colChildWorkingDay";
            // 
            // colIOTimes
            // 
            this.colIOTimes.Name = "colIOTimes";
            // 
            // colBreakOut
            // 
            this.colBreakOut.Name = "colBreakOut";
            // 
            // colBreakIn
            // 
            this.colBreakIn.Name = "colBreakIn";
            // 
            // colReasonID
            // 
            this.colReasonID.Name = "colReasonID";
            // 
            // colParentEmployeeID
            // 
            this.colParentEmployeeID.Name = "colParentEmployeeID";
            // 
            // colFullName
            // 
            this.colFullName.Name = "colFullName";
            // 
            // colChildDepartmentID
            // 
            this.colChildDepartmentID.Name = "colChildDepartmentID";
            // 
            // colParentWorkingDay
            // 
            this.colParentWorkingDay.Name = "colParentWorkingDay";
            // 
            // colShiftID
            // 
            this.colShiftID.Name = "colShiftID";
            // 
            // colTimeIn
            // 
            this.colTimeIn.Name = "colTimeIn";
            // 
            // colTimeOut
            // 
            this.colTimeOut.Name = "colTimeOut";
            // 
            // grdDailyAttending
            // 
            this.grdDailyAttending.AllowDrop = true;
            this.grdDailyAttending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDailyAttending.Location = new System.Drawing.Point(0, 34);
            this.grdDailyAttending.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDailyAttending.MainView = this.bgvDailyAttending;
            this.grdDailyAttending.Name = "grdDailyAttending";
            this.grdDailyAttending.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.icbGroup});
            this.grdDailyAttending.Size = new System.Drawing.Size(768, 310);
            this.grdDailyAttending.TabIndex = 173;
            this.grdDailyAttending.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvDailyAttending});
            // 
            // bgvDailyAttending
            // 
            this.bgvDailyAttending.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyAttending.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Red;
            this.bgvDailyAttending.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvDailyAttending.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bgvDailyAttending.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyAttending.Appearance.GroupRow.Options.UseFont = true;
            this.bgvDailyAttending.Appearance.GroupRow.Options.UseTextOptions = true;
            this.bgvDailyAttending.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bgvDailyAttending.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbEmployeeID,
            this.grbFullName,
            this.grbShiftName,
            this.grbAttending});
            this.bgvDailyAttending.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoEmployeeCode,
            this.bcoFirstName,
            this.bcoLastName,
            this.bcoDepartmentName,
            this.bcoShiftName,
            this.bcoAttending});
            this.bgvDailyAttending.FixedLineWidth = 1;
            this.bgvDailyAttending.GridControl = this.grdDailyAttending;
            this.bgvDailyAttending.GroupCount = 1;
            this.bgvDailyAttending.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "EmployeeCode", null, "(Số nhân viên đi làm: {0})")});
            this.bgvDailyAttending.HorzScrollStep = 10;
            this.bgvDailyAttending.Name = "bgvDailyAttending";
            this.bgvDailyAttending.OptionsCustomization.AllowFilter = false;
            this.bgvDailyAttending.OptionsCustomization.AllowGroup = false;
            this.bgvDailyAttending.OptionsCustomization.AllowSort = false;
            this.bgvDailyAttending.OptionsDetail.AllowExpandEmptyDetails = true;
            this.bgvDailyAttending.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvDailyAttending.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvDailyAttending.OptionsView.ColumnAutoWidth = false;
            this.bgvDailyAttending.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvDailyAttending.OptionsView.EnableAppearanceOddRow = true;
            this.bgvDailyAttending.OptionsView.ShowColumnHeaders = false;
            this.bgvDailyAttending.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvDailyAttending.OptionsView.ShowFooter = true;
            this.bgvDailyAttending.OptionsView.ShowGroupPanel = false;
            this.bgvDailyAttending.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bcoDepartmentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bgvDailyAttending.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvDailyAttending_CustomUnboundColumnData);
            this.bgvDailyAttending.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.bgvDailyAttending_CustomSummaryCalculate);
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
            // grbEmployeeID
            // 
            this.grbEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.grbEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.grbEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbEmployeeID.Caption = "Mã NV";
            this.grbEmployeeID.Columns.Add(this.bcoEmployeeCode);
            this.grbEmployeeID.Name = "grbEmployeeID";
            this.grbEmployeeID.Width = 75;
            // 
            // bcoEmployeeCode
            // 
            this.bcoEmployeeCode.AppearanceCell.Options.UseTextOptions = true;
            this.bcoEmployeeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // grbFullName
            // 
            this.grbFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbFullName.AppearanceHeader.Options.UseFont = true;
            this.grbFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbFullName.Caption = "Họ và tên";
            this.grbFullName.Columns.Add(this.bcoFirstName);
            this.grbFullName.Columns.Add(this.bcoLastName);
            this.grbFullName.Name = "grbFullName";
            this.grbFullName.Width = 150;
            // 
            // bcoFirstName
            // 
            this.bcoFirstName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoFirstName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoFirstName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bcoLastName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // grbShiftName
            // 
            this.grbShiftName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbShiftName.AppearanceHeader.Options.UseFont = true;
            this.grbShiftName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbShiftName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbShiftName.Caption = "Ca làm việc";
            this.grbShiftName.Columns.Add(this.bcoShiftName);
            this.grbShiftName.Name = "grbShiftName";
            this.grbShiftName.Width = 75;
            // 
            // bcoShiftName
            // 
            this.bcoShiftName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoShiftName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoShiftName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoShiftName.AppearanceHeader.Options.UseFont = true;
            this.bcoShiftName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoShiftName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoShiftName.Caption = "Ca làm việc";
            this.bcoShiftName.FieldName = "ShiftName";
            this.bcoShiftName.Name = "bcoShiftName";
            this.bcoShiftName.OptionsColumn.AllowEdit = false;
            this.bcoShiftName.OptionsColumn.ReadOnly = true;
            this.bcoShiftName.SummaryItem.DisplayFormat = "Số nhân viên đi làm:";
            this.bcoShiftName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoShiftName.Visible = true;
            // 
            // grbAttending
            // 
            this.grbAttending.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbAttending.AppearanceHeader.Options.UseFont = true;
            this.grbAttending.AppearanceHeader.Options.UseTextOptions = true;
            this.grbAttending.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbAttending.Caption = "Đi làm";
            this.grbAttending.Columns.Add(this.bcoAttending);
            this.grbAttending.Name = "grbAttending";
            this.grbAttending.Width = 75;
            // 
            // bcoAttending
            // 
            this.bcoAttending.AppearanceCell.Options.UseTextOptions = true;
            this.bcoAttending.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoAttending.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoAttending.AppearanceHeader.Options.UseFont = true;
            this.bcoAttending.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoAttending.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoAttending.Caption = "Đi làm";
            this.bcoAttending.FieldName = "Attending";
            this.bcoAttending.Name = "bcoAttending";
            this.bcoAttending.OptionsColumn.AllowEdit = false;
            this.bcoAttending.OptionsColumn.ReadOnly = true;
            this.bcoAttending.SummaryItem.FieldName = "EmployeeCode";
            this.bcoAttending.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoAttending.Visible = true;
            // 
            // bcoDepartmentName
            // 
            this.bcoDepartmentName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bcoDepartmentName.AppearanceCell.Options.UseFont = true;
            this.bcoDepartmentName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.bcoDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoDepartmentName.Caption = "Phòng ban";
            this.bcoDepartmentName.ColumnEdit = this.icbGroup;
            this.bcoDepartmentName.FieldName = "DepartmentName";
            this.bcoDepartmentName.Name = "bcoDepartmentName";
            this.bcoDepartmentName.OptionsColumn.AllowEdit = false;
            this.bcoDepartmentName.OptionsColumn.ReadOnly = true;
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
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "Actions-document-preview-icon.png");
            this.imlFunction.Images.SetKeyName(1, "column-chart-icon.png");
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.dedWorkingDay);
            this.pncFilter.Controls.Add(this.lblWorkingDay);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(768, 36);
            this.pncFilter.TabIndex = 203;
            // 
            // dedWorkingDay
            // 
            this.dedWorkingDay.EditValue = null;
            this.dedWorkingDay.Location = new System.Drawing.Point(44, 8);
            this.dedWorkingDay.Name = "dedWorkingDay";
            this.dedWorkingDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedWorkingDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedWorkingDay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedWorkingDay.Size = new System.Drawing.Size(80, 20);
            this.dedWorkingDay.TabIndex = 182;
            this.dedWorkingDay.EditValueChanged += new System.EventHandler(this.dedWorkingDay_EditValueChanged);
            // 
            // lblWorkingDay
            // 
            this.lblWorkingDay.AutoSize = true;
            this.lblWorkingDay.Location = new System.Drawing.Point(8, 12);
            this.lblWorkingDay.Name = "lblWorkingDay";
            this.lblWorkingDay.Size = new System.Drawing.Size(32, 13);
            this.lblWorkingDay.TabIndex = 181;
            this.lblWorkingDay.Text = "Ngày";
            // 
            // DailyAttending
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 346);
            this.Controls.Add(this.grdDailyAttending);
            this.Controls.Add(this.pncFilter);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "DailyAttending";
            this.Text = "Nhân viên đi làm trong ngày";
            this.Load += new System.EventHandler(this.DailyAttending_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyAttending_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdDailyAttending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvDailyAttending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlGroup;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.Columns.GridColumn colChildEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colChildWorkingDay;
        private DevExpress.XtraGrid.Columns.GridColumn colIOTimes;
        private DevExpress.XtraGrid.Columns.GridColumn colBreakOut;
        private DevExpress.XtraGrid.Columns.GridColumn colBreakIn;
        private DevExpress.XtraGrid.Columns.GridColumn colReasonID;
        private DevExpress.XtraGrid.Columns.GridColumn colParentEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colChildDepartmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colParentWorkingDay;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftID;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeIn;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeOut;
        private DevExpress.XtraGrid.GridControl grdDailyAttending;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvDailyAttending;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbEmployeeID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoEmployeeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbShiftName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoShiftName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbAttending;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoAttending;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbGroup;
        internal System.Windows.Forms.ImageList imlFunction;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraEditors.DateEdit dedWorkingDay;
        private System.Windows.Forms.Label lblWorkingDay;
    }
}
