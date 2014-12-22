namespace Common.Forms
{
    partial class RegisterItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterItem));
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
            this.grvRegisterItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdRegisterItem = new DevExpress.XtraGrid.GridControl();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.ccbEmployeeCode = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFromDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRegisterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegisterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdEmployee.Location = new System.Drawing.Point(0, 36);
            this.grdEmployee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdEmployee.MainView = this.bgvEmployee;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.icbGroup});
            this.grdEmployee.Size = new System.Drawing.Size(320, 396);
            this.grdEmployee.TabIndex = 1;
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
            this.bgvEmployee.OptionsCustomization.AllowGroup = false;
            this.bgvEmployee.OptionsCustomization.AllowSort = false;
            this.bgvEmployee.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvEmployee.OptionsView.ColumnAutoWidth = false;
            this.bgvEmployee.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvEmployee.OptionsView.EnableAppearanceOddRow = true;
            this.bgvEmployee.OptionsView.ShowAutoFilterRow = true;
            this.bgvEmployee.OptionsView.ShowColumnHeaders = false;
            this.bgvEmployee.OptionsView.ShowDetailButtons = false;
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
            this.bcoDepartmentName.Caption = "Bộ phận";
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
            // grvRegisterItem
            // 
            this.grvRegisterItem.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvRegisterItem.Appearance.GroupRow.Options.UseFont = true;
            this.grvRegisterItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colEmployeeID,
            this.colFromDate,
            this.colToDate});
            this.grvRegisterItem.FixedLineWidth = 1;
            this.grvRegisterItem.GridControl = this.grdRegisterItem;
            this.grvRegisterItem.HorzScrollStep = 30;
            this.grvRegisterItem.Name = "grvRegisterItem";
            this.grvRegisterItem.OptionsCustomization.AllowFilter = false;
            this.grvRegisterItem.OptionsCustomization.AllowGroup = false;
            this.grvRegisterItem.OptionsCustomization.AllowSort = false;
            this.grvRegisterItem.OptionsLayout.Columns.StoreAllOptions = true;
            this.grvRegisterItem.OptionsLayout.Columns.StoreAppearance = true;
            this.grvRegisterItem.OptionsLayout.StoreAllOptions = true;
            this.grvRegisterItem.OptionsLayout.StoreAppearance = true;
            this.grvRegisterItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvRegisterItem.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvRegisterItem.OptionsSelection.MultiSelect = true;
            this.grvRegisterItem.OptionsView.ColumnAutoWidth = false;
            this.grvRegisterItem.OptionsView.EnableAppearanceEvenRow = true;
            this.grvRegisterItem.OptionsView.EnableAppearanceOddRow = true;
            this.grvRegisterItem.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvRegisterItem.OptionsView.ShowDetailButtons = false;
            this.grvRegisterItem.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvRegisterItem.OptionsView.ShowGroupPanel = false;
            this.grvRegisterItem.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvRegisterItem_CustomUnboundColumnData);
            this.grvRegisterItem.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvRegisterItem_SelectionChanged);
            this.grvRegisterItem.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.grvRegisterItem_ValidatingEditor);
            this.grvRegisterItem.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvRegisterItem_InitNewRow);
            this.grvRegisterItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvRegisterItem_KeyDown);
            this.grvRegisterItem.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvRegisterItem_CustomDrawCell);
            this.grvRegisterItem.DoubleClick += new System.EventHandler(this.grvRegisterItem_DoubleClick);
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
            // grdRegisterItem
            // 
            this.grdRegisterItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRegisterItem.Location = new System.Drawing.Point(332, 36);
            this.grdRegisterItem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdRegisterItem.MainView = this.grvRegisterItem;
            this.grdRegisterItem.Name = "grdRegisterItem";
            this.grdRegisterItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ide});
            this.grdRegisterItem.Size = new System.Drawing.Size(454, 396);
            this.grdRegisterItem.TabIndex = 2;
            this.grdRegisterItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRegisterItem});
            this.grdRegisterItem.Resize += new System.EventHandler(this.grdRegisterItem_Resize);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(8, 12);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Mã NV";
            // 
            // ccbEmployeeCode
            // 
            this.ccbEmployeeCode.Location = new System.Drawing.Point(52, 8);
            this.ccbEmployeeCode.Name = "ccbEmployeeCode";
            this.ccbEmployeeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbEmployeeCode.Properties.DropDownRows = 20;
            this.ccbEmployeeCode.Properties.SelectAllItemCaption = "(Chọn tất cả)";
            this.ccbEmployeeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ccbEmployeeCode.Properties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ccbEmployeeCode_Properties_KeyPress);
            this.ccbEmployeeCode.Size = new System.Drawing.Size(268, 20);
            this.ccbEmployeeCode.TabIndex = 1;
            this.ccbEmployeeCode.EditValueChanged += new System.EventHandler(this.ccbEmployeeCode_EditValueChanged);
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "database-save-icon32.png");
            this.imlFunction.Images.SetKeyName(1, "delete_32.png");
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.dedToDate);
            this.pncFilter.Controls.Add(this.ccbEmployeeCode);
            this.pncFilter.Controls.Add(this.lblToDate);
            this.pncFilter.Controls.Add(this.dedFromDate);
            this.pncFilter.Controls.Add(this.lblEmployeeCode);
            this.pncFilter.Controls.Add(this.lblFromDate);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(786, 36);
            this.pncFilter.TabIndex = 0;
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(548, 8);
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
            this.dedToDate.TabIndex = 5;
            this.dedToDate.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(488, 12);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "Đến ngày";
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(388, 8);
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
            this.dedFromDate.TabIndex = 3;
            this.dedFromDate.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(336, 12);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 2;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // RegisterItem
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.grdRegisterItem);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "RegisterItem";
            this.Load += new System.EventHandler(this.RegisterItem_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterItem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRegisterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegisterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvEmployee;
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
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ide;
        internal System.Windows.Forms.ImageList imlHeader;
        private System.Windows.Forms.Label lblEmployeeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCode;
        protected DevExpress.XtraGrid.GridControl grdRegisterItem;
        protected DevExpress.XtraGrid.Views.Grid.GridView grvRegisterItem;
        protected DevExpress.XtraGrid.GridControl grdEmployee;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbEmployeeCode;
        internal System.Windows.Forms.ImageList imlFunction;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private System.Windows.Forms.Label lblToDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        private System.Windows.Forms.Label lblFromDate;
    }
}
