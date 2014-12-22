namespace Attendance.Forms
{
    partial class RegisterDayOffGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterDayOffGroup));
            this.grdEmployee = new DevExpress.XtraGrid.GridControl();
            this.bgvEmployee = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbCheck = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoDepartmentID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.icbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.imlHeader = new System.Windows.Forms.ImageList(this.components);
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ide = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvRegisterDayOffGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDayOffGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileDayOffGroupID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdRegisterDayOffGroup = new DevExpress.XtraGrid.GridControl();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.GroupCalendar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRegisterDayOffGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDayOffGroupID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegisterDayOffGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdEmployee.Location = new System.Drawing.Point(12, 44);
            this.grdEmployee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdEmployee.MainView = this.bgvEmployee;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.icbGroup});
            this.grdEmployee.Size = new System.Drawing.Size(308, 340);
            this.grdEmployee.TabIndex = 2;
            this.grdEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvEmployee});
            // 
            // bgvEmployee
            // 
            this.bgvEmployee.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bgvEmployee.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvEmployee.Appearance.GroupRow.Options.UseFont = true;
            this.bgvEmployee.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.gridBand3,
            this.grbCheck,
            this.gridBand4});
            this.bgvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoCheck,
            this.bcoID,
            this.bcoCode,
            this.bcoFirstName,
            this.bcoLastName,
            this.bcoDepartmentID,
            this.bcoDepartmentName});
            this.bgvEmployee.FixedLineWidth = 1;
            this.bgvEmployee.GridControl = this.grdEmployee;
            this.bgvEmployee.GroupCount = 1;
            this.bgvEmployee.HorzScrollStep = 30;
            this.bgvEmployee.Images = this.imlHeader;
            this.bgvEmployee.Name = "bgvEmployee";
            this.bgvEmployee.OptionsCustomization.AllowColumnMoving = false;
            this.bgvEmployee.OptionsCustomization.AllowFilter = false;
            this.bgvEmployee.OptionsCustomization.AllowGroup = false;
            this.bgvEmployee.OptionsCustomization.AllowSort = false;
            this.bgvEmployee.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvEmployee.OptionsView.ColumnAutoWidth = false;
            this.bgvEmployee.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvEmployee.OptionsView.EnableAppearanceOddRow = true;
            this.bgvEmployee.OptionsView.ShowAutoFilterRow = true;
            this.bgvEmployee.OptionsView.ShowColumnHeaders = false;
            this.bgvEmployee.OptionsView.ShowDetailButtons = false;
            this.bgvEmployee.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvEmployee.OptionsView.ShowGroupPanel = false;
            this.bgvEmployee.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bcoDepartmentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bgvEmployee.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvEmployee_CustomUnboundColumnData);
            this.bgvEmployee.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.bgvEmployee_FocusedRowChanged);
            this.bgvEmployee.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvEmployee_CellValueChanging);
            this.bgvEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bgvEmployee_MouseDown);
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
            this.bcoNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bcoNo.OptionsColumn.ReadOnly = true;
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoNo.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Mã NV";
            this.gridBand3.Columns.Add(this.bcoCode);
            this.gridBand3.Columns.Add(this.bcoID);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 75;
            // 
            // bcoCode
            // 
            this.bcoCode.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCode.AppearanceHeader.Options.UseFont = true;
            this.bcoCode.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCode.Caption = "Mã NV";
            this.bcoCode.FieldName = "Code";
            this.bcoCode.Name = "bcoCode";
            this.bcoCode.OptionsColumn.AllowEdit = false;
            this.bcoCode.OptionsColumn.ReadOnly = true;
            this.bcoCode.Visible = true;
            // 
            // bcoID
            // 
            this.bcoID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoID.AppearanceHeader.Options.UseFont = true;
            this.bcoID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoID.Caption = "Mã NV";
            this.bcoID.FieldName = "ID";
            this.bcoID.Name = "bcoID";
            this.bcoID.OptionsColumn.AllowEdit = false;
            this.bcoID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bcoID.OptionsColumn.ReadOnly = true;
            // 
            // grbCheck
            // 
            this.grbCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbCheck.AppearanceHeader.Options.UseFont = true;
            this.grbCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.grbCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbCheck.Columns.Add(this.bcoCheck);
            this.grbCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.grbCheck.ImageIndex = 1;
            this.grbCheck.Name = "grbCheck";
            this.grbCheck.OptionsBand.FixedWidth = true;
            this.grbCheck.Width = 30;
            // 
            // bcoCheck
            // 
            this.bcoCheck.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCheck.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCheck.AppearanceHeader.Options.UseFont = true;
            this.bcoCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCheck.Caption = "Check";
            this.bcoCheck.FieldName = "Check";
            this.bcoCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.bcoCheck.ImageIndex = 1;
            this.bcoCheck.Name = "bcoCheck";
            this.bcoCheck.OptionsColumn.FixedWidth = true;
            this.bcoCheck.Visible = true;
            this.bcoCheck.Width = 30;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Họ và tên";
            this.gridBand4.Columns.Add(this.bcoFirstName);
            this.gridBand4.Columns.Add(this.bcoLastName);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 150;
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
            this.bcoFirstName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
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
            // bcoDepartmentID
            // 
            this.bcoDepartmentID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDepartmentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoDepartmentID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoDepartmentID.AppearanceHeader.Options.UseFont = true;
            this.bcoDepartmentID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoDepartmentID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoDepartmentID.Caption = "Mã phòng ban";
            this.bcoDepartmentID.FieldName = "DepartmentID";
            this.bcoDepartmentID.Name = "bcoDepartmentID";
            // 
            // bcoDepartmentName
            // 
            this.bcoDepartmentName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.bcoDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoDepartmentName.Caption = "Phòng ban";
            this.bcoDepartmentName.ColumnEdit = this.icbGroup;
            this.bcoDepartmentName.FieldName = "DepartmentName";
            this.bcoDepartmentName.Name = "bcoDepartmentName";
            this.bcoDepartmentName.OptionsColumn.AllowEdit = false;
            this.bcoDepartmentName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.bcoDepartmentName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
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
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // imlHeader
            // 
            this.imlHeader.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlHeader.ImageStream")));
            this.imlHeader.TransparentColor = System.Drawing.Color.Transparent;
            this.imlHeader.Images.SetKeyName(0, "checked.gif");
            this.imlHeader.Images.SetKeyName(1, "unchecked.gif");
            // 
            // colFromDate
            // 
            this.colFromDate.AppearanceCell.Options.UseTextOptions = true;
            this.colFromDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFromDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFromDate.AppearanceHeader.Options.UseFont = true;
            this.colFromDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colFromDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFromDate.Caption = "Từ ngày";
            this.colFromDate.ColumnEdit = this.ide;
            this.colFromDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colFromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 1;
            // 
            // ide
            // 
            this.ide.AutoHeight = false;
            this.ide.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ide.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ide.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ide.EditFormat.FormatString = "dd/MM/yyyy";
            this.ide.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ide.Mask.EditMask = "dd/MM/yyyy";
            this.ide.Name = "ide";
            this.ide.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            this.colEmployeeID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colEmployeeID.OptionsColumn.ReadOnly = true;
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Options.UseTextOptions = true;
            this.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNo.AppearanceHeader.Options.UseFont = true;
            this.colNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.Caption = "STT";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.AllowEdit = false;
            this.colNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // grvRegisterDayOffGroup
            // 
            this.grvRegisterDayOffGroup.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvRegisterDayOffGroup.Appearance.GroupRow.Options.UseFont = true;
            this.grvRegisterDayOffGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colEmployeeID,
            this.colFromDate,
            this.colToDate,
            this.colDayOffGroupID});
            this.grvRegisterDayOffGroup.FixedLineWidth = 1;
            this.grvRegisterDayOffGroup.GridControl = this.grdRegisterDayOffGroup;
            this.grvRegisterDayOffGroup.HorzScrollStep = 30;
            this.grvRegisterDayOffGroup.Name = "grvRegisterDayOffGroup";
            this.grvRegisterDayOffGroup.OptionsCustomization.AllowColumnMoving = false;
            this.grvRegisterDayOffGroup.OptionsCustomization.AllowFilter = false;
            this.grvRegisterDayOffGroup.OptionsCustomization.AllowGroup = false;
            this.grvRegisterDayOffGroup.OptionsCustomization.AllowSort = false;
            this.grvRegisterDayOffGroup.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvRegisterDayOffGroup.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvRegisterDayOffGroup.OptionsSelection.MultiSelect = true;
            this.grvRegisterDayOffGroup.OptionsView.EnableAppearanceEvenRow = true;
            this.grvRegisterDayOffGroup.OptionsView.EnableAppearanceOddRow = true;
            this.grvRegisterDayOffGroup.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvRegisterDayOffGroup.OptionsView.ShowDetailButtons = false;
            this.grvRegisterDayOffGroup.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvRegisterDayOffGroup.OptionsView.ShowGroupPanel = false;
            this.grvRegisterDayOffGroup.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvRegisterDayOffGroup_CustomUnboundColumnData);
            this.grvRegisterDayOffGroup.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvRegisterDayOffGroup_SelectionChanged);
            this.grvRegisterDayOffGroup.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.grvRegisterDayOffGroup_ValidatingEditor);
            this.grvRegisterDayOffGroup.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvRegisterDayOffGroup_CellValueChanged);
            this.grvRegisterDayOffGroup.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvRegisterDayOffGroup_InitNewRow);
            this.grvRegisterDayOffGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvRegisterDayOffGroup_KeyDown);
            this.grvRegisterDayOffGroup.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvRegisterDayOffGroup_CustomDrawCell);
            this.grvRegisterDayOffGroup.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.grvRegisterDayOffGroup_InvalidRowException);
            // 
            // colToDate
            // 
            this.colToDate.AppearanceCell.Options.UseTextOptions = true;
            this.colToDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colToDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colToDate.AppearanceHeader.Options.UseFont = true;
            this.colToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colToDate.Caption = "Đến ngày";
            this.colToDate.ColumnEdit = this.ide;
            this.colToDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 2;
            // 
            // colDayOffGroupID
            // 
            this.colDayOffGroupID.AppearanceCell.Options.UseTextOptions = true;
            this.colDayOffGroupID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDayOffGroupID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDayOffGroupID.AppearanceHeader.Options.UseFont = true;
            this.colDayOffGroupID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDayOffGroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDayOffGroupID.Caption = "Nhóm";
            this.colDayOffGroupID.ColumnEdit = this.ileDayOffGroupID;
            this.colDayOffGroupID.FieldName = "DayOffGroupID";
            this.colDayOffGroupID.Name = "colDayOffGroupID";
            this.colDayOffGroupID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDayOffGroupID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDayOffGroupID.Visible = true;
            this.colDayOffGroupID.VisibleIndex = 3;
            // 
            // ileDayOffGroupID
            // 
            this.ileDayOffGroupID.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileDayOffGroupID.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileDayOffGroupID.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ileDayOffGroupID.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ileDayOffGroupID.AutoHeight = false;
            this.ileDayOffGroupID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileDayOffGroupID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileDayOffGroupID.Name = "ileDayOffGroupID";
            this.ileDayOffGroupID.NullText = "";
            this.ileDayOffGroupID.ShowHeader = false;
            // 
            // grdRegisterDayOffGroup
            // 
            this.grdRegisterDayOffGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRegisterDayOffGroup.Location = new System.Drawing.Point(332, 12);
            this.grdRegisterDayOffGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdRegisterDayOffGroup.MainView = this.grvRegisterDayOffGroup;
            this.grdRegisterDayOffGroup.Name = "grdRegisterDayOffGroup";
            this.grdRegisterDayOffGroup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ileDayOffGroupID,
            this.ide});
            this.grdRegisterDayOffGroup.Size = new System.Drawing.Size(440, 372);
            this.grdRegisterDayOffGroup.TabIndex = 3;
            this.grdRegisterDayOffGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRegisterDayOffGroup});
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            this.imlButton.Images.SetKeyName(2, "Actions-view-calendar-upcoming-days-icon16.png");
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(12, 16);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Mã NV";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(270, 396);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 170;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(354, 396);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 171;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(56, 12);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtEmployeeCode.Size = new System.Drawing.Size(56, 20);
            this.txtEmployeeCode.TabIndex = 202;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged);
            // 
            // GroupCalendar
            // 
            this.GroupCalendar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupCalendar.ImageIndex = 2;
            this.GroupCalendar.ImageList = this.imlButton;
            this.GroupCalendar.Location = new System.Drawing.Point(438, 396);
            this.GroupCalendar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GroupCalendar.Name = "GroupCalendar";
            this.GroupCalendar.Size = new System.Drawing.Size(76, 28);
            this.GroupCalendar.TabIndex = 203;
            this.GroupCalendar.Text = "Lịch nhóm";
            this.GroupCalendar.Click += new System.EventHandler(this.GroupCalendar_Click);
            // 
            // RegisterDayOffGroup
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.GroupCalendar);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.grdRegisterDayOffGroup);
            this.Name = "RegisterDayOffGroup";
            this.Text = "Đăng ký nghỉ luân phiên thứ 7";
            this.Load += new System.EventHandler(this.RegisterDayOffGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRegisterDayOffGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDayOffGroupID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegisterDayOffGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdEmployee;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvEmployee;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbGroup;
        internal System.Windows.Forms.ImageList imlGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRegisterDayOffGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDayOffGroupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileDayOffGroupID;
        private DevExpress.XtraGrid.GridControl grdRegisterDayOffGroup;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ide;
        internal System.Windows.Forms.ImageList imlHeader;
        private System.Windows.Forms.Label lblEmployeeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCode;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private DevExpress.XtraEditors.SimpleButton GroupCalendar;
    }
}
