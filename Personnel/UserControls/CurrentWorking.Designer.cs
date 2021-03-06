namespace Personnel.UserControls
{
    partial class CurrentWorking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentWorking));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grcWorkingProcess = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveEmployeePosition = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteEmployeePosition = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveEmployeeDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteEmployeeDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.grdEmployeePosition = new DevExpress.XtraGrid.GridControl();
            this.grvEmployeePosition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idePosition = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ilePosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIobID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileJob = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdEmployeeDepartment = new DevExpress.XtraGrid.GridControl();
            this.grvEmployeeDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ideDepartment = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileDepartment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grcgrbInitialInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveInitialInfo = new DevExpress.XtraEditors.SimpleButton();
            this.dedSigningDate = new DevExpress.XtraEditors.DateEdit();
            this.lblSigningDate = new System.Windows.Forms.Label();
            this.dedInitialDate = new DevExpress.XtraEditors.DateEdit();
            this.lblRecruitingOfficer = new System.Windows.Forms.Label();
            this.lblInterviewer = new System.Windows.Forms.Label();
            this.lblPresentPerson = new System.Windows.Forms.Label();
            this.lblBySource = new System.Windows.Forms.Label();
            this.lblInitialDate = new System.Windows.Forms.Label();
            this.txtRecruitingOfficer = new DevExpress.XtraEditors.TextEdit();
            this.txtPresentPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtBySource = new DevExpress.XtraEditors.TextEdit();
            this.txtInterviewer = new DevExpress.XtraEditors.TextEdit();
            this.chkHasHealthIns = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcWorkingProcess)).BeginInit();
            this.grcWorkingProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idePosition.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideDepartment.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcgrbInitialInfo)).BeginInit();
            this.grcgrbInitialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedSigningDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedSigningDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedInitialDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedInitialDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecruitingOfficer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBySource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterviewer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHasHealthIns.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "saveHS.png");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            // 
            // grcWorkingProcess
            // 
            this.grcWorkingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcWorkingProcess.Controls.Add(this.btnSaveEmployeePosition);
            this.grcWorkingProcess.Controls.Add(this.btnDeleteEmployeePosition);
            this.grcWorkingProcess.Controls.Add(this.btnSaveEmployeeDepartment);
            this.grcWorkingProcess.Controls.Add(this.btnDeleteEmployeeDepartment);
            this.grcWorkingProcess.Controls.Add(this.grdEmployeePosition);
            this.grcWorkingProcess.Controls.Add(this.grdEmployeeDepartment);
            this.grcWorkingProcess.Location = new System.Drawing.Point(12, 12);
            this.grcWorkingProcess.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grcWorkingProcess.Name = "grcWorkingProcess";
            this.grcWorkingProcess.Size = new System.Drawing.Size(696, 268);
            this.grcWorkingProcess.TabIndex = 115;
            this.grcWorkingProcess.Text = "Quá trình làm việc";
            // 
            // btnSaveEmployeePosition
            // 
            this.btnSaveEmployeePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEmployeePosition.ImageIndex = 0;
            this.btnSaveEmployeePosition.ImageList = this.imlButton;
            this.btnSaveEmployeePosition.Location = new System.Drawing.Point(608, 168);
            this.btnSaveEmployeePosition.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSaveEmployeePosition.Name = "btnSaveEmployeePosition";
            this.btnSaveEmployeePosition.Size = new System.Drawing.Size(76, 28);
            this.btnSaveEmployeePosition.TabIndex = 167;
            this.btnSaveEmployeePosition.Text = "Lưu";
            this.btnSaveEmployeePosition.Click += new System.EventHandler(this.btnSaveEmployeePosition_Click);
            // 
            // btnDeleteEmployeePosition
            // 
            this.btnDeleteEmployeePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployeePosition.ImageIndex = 1;
            this.btnDeleteEmployeePosition.ImageList = this.imlButton;
            this.btnDeleteEmployeePosition.Location = new System.Drawing.Point(608, 204);
            this.btnDeleteEmployeePosition.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDeleteEmployeePosition.Name = "btnDeleteEmployeePosition";
            this.btnDeleteEmployeePosition.Size = new System.Drawing.Size(76, 28);
            this.btnDeleteEmployeePosition.TabIndex = 168;
            this.btnDeleteEmployeePosition.Text = "Xóa";
            this.btnDeleteEmployeePosition.Click += new System.EventHandler(this.btnDeleteEmployeePosition_Click);
            // 
            // btnSaveEmployeeDepartment
            // 
            this.btnSaveEmployeeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEmployeeDepartment.ImageIndex = 0;
            this.btnSaveEmployeeDepartment.ImageList = this.imlButton;
            this.btnSaveEmployeeDepartment.Location = new System.Drawing.Point(608, 52);
            this.btnSaveEmployeeDepartment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSaveEmployeeDepartment.Name = "btnSaveEmployeeDepartment";
            this.btnSaveEmployeeDepartment.Size = new System.Drawing.Size(76, 28);
            this.btnSaveEmployeeDepartment.TabIndex = 165;
            this.btnSaveEmployeeDepartment.Text = "Lưu";
            this.btnSaveEmployeeDepartment.Click += new System.EventHandler(this.btnSaveEmployeeDepartment_Click);
            // 
            // btnDeleteEmployeeDepartment
            // 
            this.btnDeleteEmployeeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployeeDepartment.ImageIndex = 1;
            this.btnDeleteEmployeeDepartment.ImageList = this.imlButton;
            this.btnDeleteEmployeeDepartment.Location = new System.Drawing.Point(608, 88);
            this.btnDeleteEmployeeDepartment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDeleteEmployeeDepartment.Name = "btnDeleteEmployeeDepartment";
            this.btnDeleteEmployeeDepartment.Size = new System.Drawing.Size(76, 28);
            this.btnDeleteEmployeeDepartment.TabIndex = 166;
            this.btnDeleteEmployeeDepartment.Text = "Xóa";
            this.btnDeleteEmployeeDepartment.Click += new System.EventHandler(this.btnDeleteEmployeeDepartment_Click);
            // 
            // grdEmployeePosition
            // 
            this.grdEmployeePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEmployeePosition.Location = new System.Drawing.Point(12, 148);
            this.grdEmployeePosition.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdEmployeePosition.MainView = this.grvEmployeePosition;
            this.grdEmployeePosition.Name = "grdEmployeePosition";
            this.grdEmployeePosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ileJob,
            this.ilePosition,
            this.idePosition});
            this.grdEmployeePosition.Size = new System.Drawing.Size(584, 108);
            this.grdEmployeePosition.TabIndex = 123;
            this.grdEmployeePosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployeePosition});
            // 
            // grvEmployeePosition
            // 
            this.grvEmployeePosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPNo,
            this.colPEmployeeID,
            this.colPFromDate,
            this.colPToDate,
            this.colPositionID,
            this.colIobID});
            this.grvEmployeePosition.FixedLineWidth = 1;
            this.grvEmployeePosition.GridControl = this.grdEmployeePosition;
            this.grvEmployeePosition.HorzScrollStep = 10;
            this.grvEmployeePosition.Name = "grvEmployeePosition";
            this.grvEmployeePosition.OptionsCustomization.AllowFilter = false;
            this.grvEmployeePosition.OptionsCustomization.AllowGroup = false;
            this.grvEmployeePosition.OptionsCustomization.AllowSort = false;
            this.grvEmployeePosition.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvEmployeePosition.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvEmployeePosition.OptionsView.EnableAppearanceEvenRow = true;
            this.grvEmployeePosition.OptionsView.EnableAppearanceOddRow = true;
            this.grvEmployeePosition.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvEmployeePosition.OptionsView.ShowDetailButtons = false;
            this.grvEmployeePosition.OptionsView.ShowGroupPanel = false;
            this.grvEmployeePosition.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvCurrentWorking_CustomDrawCell);
            this.grvEmployeePosition.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvCurrentWorking_InitNewRow);
            this.grvEmployeePosition.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvCurrentWorking_CellValueChanging);
            this.grvEmployeePosition.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.grvCurrentWorking_InvalidRowException);
            this.grvEmployeePosition.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvCurrentWorking_ValidateRow);
            this.grvEmployeePosition.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvCurrentWorking_CustomUnboundColumnData);
            this.grvEmployeePosition.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.grvCurrentWorking_ValidatingEditor);
            // 
            // colPNo
            // 
            this.colPNo.AppearanceCell.Options.UseTextOptions = true;
            this.colPNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPNo.AppearanceHeader.Options.UseFont = true;
            this.colPNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPNo.Caption = "STT";
            this.colPNo.FieldName = "No";
            this.colPNo.Name = "colPNo";
            this.colPNo.OptionsColumn.AllowEdit = false;
            this.colPNo.OptionsColumn.ReadOnly = true;
            this.colPNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colPNo.Visible = true;
            this.colPNo.VisibleIndex = 0;
            // 
            // colPEmployeeID
            // 
            this.colPEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.colPEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colPEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPEmployeeID.Caption = "Mã NV";
            this.colPEmployeeID.FieldName = "EmployeeID";
            this.colPEmployeeID.Name = "colPEmployeeID";
            // 
            // colPFromDate
            // 
            this.colPFromDate.AppearanceCell.Options.UseTextOptions = true;
            this.colPFromDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPFromDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPFromDate.AppearanceHeader.Options.UseFont = true;
            this.colPFromDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colPFromDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPFromDate.Caption = "Từ ngày";
            this.colPFromDate.ColumnEdit = this.idePosition;
            this.colPFromDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPFromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPFromDate.FieldName = "FromDate";
            this.colPFromDate.Name = "colPFromDate";
            this.colPFromDate.Visible = true;
            this.colPFromDate.VisibleIndex = 1;
            // 
            // idePosition
            // 
            this.idePosition.AutoHeight = false;
            this.idePosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idePosition.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.idePosition.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.idePosition.EditFormat.FormatString = "dd/MM/yyyy";
            this.idePosition.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.idePosition.Mask.EditMask = "dd/MM/yyyy";
            this.idePosition.Name = "idePosition";
            this.idePosition.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colPToDate
            // 
            this.colPToDate.AppearanceCell.Options.UseTextOptions = true;
            this.colPToDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPToDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPToDate.AppearanceHeader.Options.UseFont = true;
            this.colPToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colPToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPToDate.Caption = "Đến ngày";
            this.colPToDate.ColumnEdit = this.idePosition;
            this.colPToDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPToDate.FieldName = "ToDate";
            this.colPToDate.Name = "colPToDate";
            this.colPToDate.Visible = true;
            this.colPToDate.VisibleIndex = 2;
            // 
            // colPositionID
            // 
            this.colPositionID.AppearanceCell.Options.UseTextOptions = true;
            this.colPositionID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPositionID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPositionID.AppearanceHeader.Options.UseFont = true;
            this.colPositionID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPositionID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPositionID.Caption = "Chức vụ";
            this.colPositionID.ColumnEdit = this.ilePosition;
            this.colPositionID.FieldName = "PositionID";
            this.colPositionID.Name = "colPositionID";
            this.colPositionID.Visible = true;
            this.colPositionID.VisibleIndex = 3;
            // 
            // ilePosition
            // 
            this.ilePosition.AppearanceDropDown.Options.UseTextOptions = true;
            this.ilePosition.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ilePosition.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.ilePosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilePosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.ilePosition.DropDownRows = 20;
            this.ilePosition.Name = "ilePosition";
            this.ilePosition.NullText = "";
            this.ilePosition.ShowHeader = false;
            // 
            // colIobID
            // 
            this.colIobID.AppearanceCell.Options.UseTextOptions = true;
            this.colIobID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIobID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIobID.AppearanceHeader.Options.UseFont = true;
            this.colIobID.AppearanceHeader.Options.UseTextOptions = true;
            this.colIobID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIobID.Caption = "Công việc";
            this.colIobID.ColumnEdit = this.ileJob;
            this.colIobID.FieldName = "JobID";
            this.colIobID.Name = "colIobID";
            // 
            // ileJob
            // 
            this.ileJob.AppearanceDropDown.Options.UseTextOptions = true;
            this.ileJob.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ileJob.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.ileJob.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileJob.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.ileJob.DropDownRows = 20;
            this.ileJob.Name = "ileJob";
            this.ileJob.NullText = "";
            this.ileJob.ShowHeader = false;
            // 
            // grdEmployeeDepartment
            // 
            this.grdEmployeeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEmployeeDepartment.Location = new System.Drawing.Point(12, 28);
            this.grdEmployeeDepartment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdEmployeeDepartment.MainView = this.grvEmployeeDepartment;
            this.grdEmployeeDepartment.Name = "grdEmployeeDepartment";
            this.grdEmployeeDepartment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ileDepartment,
            this.ideDepartment});
            this.grdEmployeeDepartment.Size = new System.Drawing.Size(584, 108);
            this.grdEmployeeDepartment.TabIndex = 100;
            this.grdEmployeeDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployeeDepartment});
            // 
            // grvEmployeeDepartment
            // 
            this.grvEmployeeDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colEmployeeID,
            this.colFromDate,
            this.colToDate,
            this.colDepartmentID});
            this.grvEmployeeDepartment.FixedLineWidth = 1;
            this.grvEmployeeDepartment.GridControl = this.grdEmployeeDepartment;
            this.grvEmployeeDepartment.HorzScrollStep = 10;
            this.grvEmployeeDepartment.Name = "grvEmployeeDepartment";
            this.grvEmployeeDepartment.OptionsCustomization.AllowFilter = false;
            this.grvEmployeeDepartment.OptionsCustomization.AllowGroup = false;
            this.grvEmployeeDepartment.OptionsCustomization.AllowSort = false;
            this.grvEmployeeDepartment.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvEmployeeDepartment.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvEmployeeDepartment.OptionsView.EnableAppearanceEvenRow = true;
            this.grvEmployeeDepartment.OptionsView.EnableAppearanceOddRow = true;
            this.grvEmployeeDepartment.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvEmployeeDepartment.OptionsView.ShowDetailButtons = false;
            this.grvEmployeeDepartment.OptionsView.ShowGroupPanel = false;
            this.grvEmployeeDepartment.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvCurrentWorking_CustomDrawCell);
            this.grvEmployeeDepartment.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvCurrentWorking_InitNewRow);
            this.grvEmployeeDepartment.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvCurrentWorking_CellValueChanging);
            this.grvEmployeeDepartment.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.grvCurrentWorking_InvalidRowException);
            this.grvEmployeeDepartment.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvCurrentWorking_ValidateRow);
            this.grvEmployeeDepartment.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvCurrentWorking_CustomUnboundColumnData);
            this.grvEmployeeDepartment.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.grvCurrentWorking_ValidatingEditor);
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
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
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
            this.colFromDate.ColumnEdit = this.ideDepartment;
            this.colFromDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colFromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 1;
            // 
            // ideDepartment
            // 
            this.ideDepartment.AutoHeight = false;
            this.ideDepartment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ideDepartment.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ideDepartment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ideDepartment.EditFormat.FormatString = "dd/MM/yyyy";
            this.ideDepartment.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ideDepartment.Mask.EditMask = "dd/MM/yyyy";
            this.ideDepartment.Name = "ideDepartment";
            this.ideDepartment.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            this.colToDate.ColumnEdit = this.ideDepartment;
            this.colToDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 2;
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartmentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDepartmentID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDepartmentID.AppearanceHeader.Options.UseFont = true;
            this.colDepartmentID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartmentID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartmentID.Caption = "Bộ phận";
            this.colDepartmentID.ColumnEdit = this.ileDepartment;
            this.colDepartmentID.FieldName = "DepartmentID";
            this.colDepartmentID.Name = "colDepartmentID";
            this.colDepartmentID.Visible = true;
            this.colDepartmentID.VisibleIndex = 3;
            // 
            // ileDepartment
            // 
            this.ileDepartment.AppearanceDropDown.Options.UseTextOptions = true;
            this.ileDepartment.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ileDepartment.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.ileDepartment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileDepartment.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullPath", "Name")});
            this.ileDepartment.DropDownRows = 20;
            this.ileDepartment.Name = "ileDepartment";
            this.ileDepartment.NullText = "";
            this.ileDepartment.ShowHeader = false;
            // 
            // grcgrbInitialInfo
            // 
            this.grcgrbInitialInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcgrbInitialInfo.Controls.Add(this.btnSaveInitialInfo);
            this.grcgrbInitialInfo.Controls.Add(this.dedSigningDate);
            this.grcgrbInitialInfo.Controls.Add(this.lblSigningDate);
            this.grcgrbInitialInfo.Controls.Add(this.dedInitialDate);
            this.grcgrbInitialInfo.Controls.Add(this.lblRecruitingOfficer);
            this.grcgrbInitialInfo.Controls.Add(this.lblInterviewer);
            this.grcgrbInitialInfo.Controls.Add(this.lblPresentPerson);
            this.grcgrbInitialInfo.Controls.Add(this.lblBySource);
            this.grcgrbInitialInfo.Controls.Add(this.lblInitialDate);
            this.grcgrbInitialInfo.Controls.Add(this.txtRecruitingOfficer);
            this.grcgrbInitialInfo.Controls.Add(this.txtPresentPerson);
            this.grcgrbInitialInfo.Controls.Add(this.txtBySource);
            this.grcgrbInitialInfo.Controls.Add(this.txtInterviewer);
            this.grcgrbInitialInfo.Controls.Add(this.chkHasHealthIns);
            this.grcgrbInitialInfo.Location = new System.Drawing.Point(12, 292);
            this.grcgrbInitialInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grcgrbInitialInfo.Name = "grcgrbInitialInfo";
            this.grcgrbInitialInfo.Size = new System.Drawing.Size(696, 148);
            this.grcgrbInitialInfo.TabIndex = 116;
            this.grcgrbInitialInfo.Text = "Thông tin ban đầu";
            // 
            // btnSaveInitialInfo
            // 
            this.btnSaveInitialInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveInitialInfo.ImageIndex = 0;
            this.btnSaveInitialInfo.ImageList = this.imlButton;
            this.btnSaveInitialInfo.Location = new System.Drawing.Point(310, 108);
            this.btnSaveInitialInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSaveInitialInfo.Name = "btnSaveInitialInfo";
            this.btnSaveInitialInfo.Size = new System.Drawing.Size(76, 28);
            this.btnSaveInitialInfo.TabIndex = 182;
            this.btnSaveInitialInfo.Text = "Lưu";
            this.btnSaveInitialInfo.Click += new System.EventHandler(this.btnSaveInitialInfo_Click);
            // 
            // dedSigningDate
            // 
            this.dedSigningDate.EditValue = null;
            this.dedSigningDate.Location = new System.Drawing.Point(288, 28);
            this.dedSigningDate.Name = "dedSigningDate";
            this.dedSigningDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedSigningDate.Properties.Appearance.Options.UseFont = true;
            this.dedSigningDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedSigningDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedSigningDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedSigningDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedSigningDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedSigningDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedSigningDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedSigningDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedSigningDate.Size = new System.Drawing.Size(84, 20);
            this.dedSigningDate.TabIndex = 181;
            // 
            // lblSigningDate
            // 
            this.lblSigningDate.AutoSize = true;
            this.lblSigningDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigningDate.Location = new System.Drawing.Point(204, 32);
            this.lblSigningDate.Name = "lblSigningDate";
            this.lblSigningDate.Size = new System.Drawing.Size(77, 13);
            this.lblSigningDate.TabIndex = 180;
            this.lblSigningDate.Text = "Ngày ký HĐLĐ";
            // 
            // dedInitialDate
            // 
            this.dedInitialDate.EditValue = null;
            this.dedInitialDate.Location = new System.Drawing.Point(108, 28);
            this.dedInitialDate.Name = "dedInitialDate";
            this.dedInitialDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedInitialDate.Properties.Appearance.Options.UseFont = true;
            this.dedInitialDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedInitialDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedInitialDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedInitialDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedInitialDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedInitialDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedInitialDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedInitialDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedInitialDate.Size = new System.Drawing.Size(84, 20);
            this.dedInitialDate.TabIndex = 179;
            // 
            // lblRecruitingOfficer
            // 
            this.lblRecruitingOfficer.AutoSize = true;
            this.lblRecruitingOfficer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecruitingOfficer.Location = new System.Drawing.Point(388, 56);
            this.lblRecruitingOfficer.Name = "lblRecruitingOfficer";
            this.lblRecruitingOfficer.Size = new System.Drawing.Size(93, 13);
            this.lblRecruitingOfficer.TabIndex = 176;
            this.lblRecruitingOfficer.Text = "Người tuyển dụng";
            // 
            // lblInterviewer
            // 
            this.lblInterviewer.AutoSize = true;
            this.lblInterviewer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewer.Location = new System.Drawing.Point(388, 32);
            this.lblInterviewer.Name = "lblInterviewer";
            this.lblInterviewer.Size = new System.Drawing.Size(89, 13);
            this.lblInterviewer.TabIndex = 174;
            this.lblInterviewer.Text = "Người phỏng vấn";
            // 
            // lblPresentPerson
            // 
            this.lblPresentPerson.AutoSize = true;
            this.lblPresentPerson.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentPerson.Location = new System.Drawing.Point(12, 80);
            this.lblPresentPerson.Name = "lblPresentPerson";
            this.lblPresentPerson.Size = new System.Drawing.Size(81, 13);
            this.lblPresentPerson.TabIndex = 172;
            this.lblPresentPerson.Text = "Người giới thiệu";
            // 
            // lblBySource
            // 
            this.lblBySource.AutoSize = true;
            this.lblBySource.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBySource.Location = new System.Drawing.Point(12, 56);
            this.lblBySource.Name = "lblBySource";
            this.lblBySource.Size = new System.Drawing.Size(84, 13);
            this.lblBySource.TabIndex = 170;
            this.lblBySource.Text = "Nguồn thông tin";
            // 
            // lblInitialDate
            // 
            this.lblInitialDate.AutoSize = true;
            this.lblInitialDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialDate.Location = new System.Drawing.Point(12, 32);
            this.lblInitialDate.Name = "lblInitialDate";
            this.lblInitialDate.Size = new System.Drawing.Size(92, 13);
            this.lblInitialDate.TabIndex = 169;
            this.lblInitialDate.Text = "Ngày vào công ty";
            // 
            // txtRecruitingOfficer
            // 
            this.txtRecruitingOfficer.Location = new System.Drawing.Point(488, 52);
            this.txtRecruitingOfficer.Name = "txtRecruitingOfficer";
            this.txtRecruitingOfficer.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtRecruitingOfficer.Size = new System.Drawing.Size(196, 20);
            this.txtRecruitingOfficer.TabIndex = 186;
            // 
            // txtPresentPerson
            // 
            this.txtPresentPerson.Location = new System.Drawing.Point(108, 76);
            this.txtPresentPerson.Name = "txtPresentPerson";
            this.txtPresentPerson.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPresentPerson.Size = new System.Drawing.Size(264, 20);
            this.txtPresentPerson.TabIndex = 185;
            // 
            // txtBySource
            // 
            this.txtBySource.Location = new System.Drawing.Point(108, 52);
            this.txtBySource.Name = "txtBySource";
            this.txtBySource.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtBySource.Size = new System.Drawing.Size(264, 20);
            this.txtBySource.TabIndex = 184;
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(488, 28);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtInterviewer.Size = new System.Drawing.Size(196, 20);
            this.txtInterviewer.TabIndex = 183;
            // 
            // chkHasHealthIns
            // 
            this.chkHasHealthIns.Location = new System.Drawing.Point(388, 76);
            this.chkHasHealthIns.Name = "chkHasHealthIns";
            this.chkHasHealthIns.Properties.Caption = "Có thẻ BHXH";
            this.chkHasHealthIns.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkHasHealthIns.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkHasHealthIns.Size = new System.Drawing.Size(116, 19);
            this.chkHasHealthIns.TabIndex = 187;
            // 
            // CurrentWorking
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcgrbInitialInfo);
            this.Controls.Add(this.grcWorkingProcess);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "CurrentWorking";
            this.Size = new System.Drawing.Size(721, 455);
            this.Load += new System.EventHandler(this.CurrentWorking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcWorkingProcess)).EndInit();
            this.grcWorkingProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idePosition.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideDepartment.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcgrbInitialInfo)).EndInit();
            this.grcgrbInitialInfo.ResumeLayout(false);
            this.grcgrbInitialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedSigningDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedSigningDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedInitialDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedInitialDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecruitingOfficer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBySource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterviewer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHasHealthIns.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.GroupControl grcWorkingProcess;
        private DevExpress.XtraGrid.GridControl grdEmployeePosition;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployeePosition;
        private DevExpress.XtraGrid.Columns.GridColumn colPNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colPFromDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit idePosition;
        private DevExpress.XtraGrid.Columns.GridColumn colPToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ilePosition;
        private DevExpress.XtraGrid.Columns.GridColumn colIobID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileJob;
        private DevExpress.XtraGrid.GridControl grdEmployeeDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployeeDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ideDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileDepartment;
        private DevExpress.XtraEditors.SimpleButton btnSaveEmployeeDepartment;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEmployeeDepartment;
        private DevExpress.XtraEditors.SimpleButton btnSaveEmployeePosition;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEmployeePosition;
        private DevExpress.XtraEditors.GroupControl grcgrbInitialInfo;
        private DevExpress.XtraEditors.SimpleButton btnSaveInitialInfo;
        private DevExpress.XtraEditors.DateEdit dedSigningDate;
        private System.Windows.Forms.Label lblSigningDate;
        private DevExpress.XtraEditors.DateEdit dedInitialDate;
        private System.Windows.Forms.Label lblRecruitingOfficer;
        private System.Windows.Forms.Label lblInterviewer;
        private System.Windows.Forms.Label lblPresentPerson;
        private System.Windows.Forms.Label lblBySource;
        private System.Windows.Forms.Label lblInitialDate;
        private DevExpress.XtraEditors.TextEdit txtInterviewer;
        private DevExpress.XtraEditors.TextEdit txtRecruitingOfficer;
        private DevExpress.XtraEditors.TextEdit txtPresentPerson;
        private DevExpress.XtraEditors.TextEdit txtBySource;
        private DevExpress.XtraEditors.CheckEdit chkHasHealthIns;
    }
}
