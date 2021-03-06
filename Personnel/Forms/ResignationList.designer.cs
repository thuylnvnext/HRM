namespace Personnel.Forms
{
    partial class ResignationList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResignationList));
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.grdResignationList = new DevExpress.XtraGrid.GridControl();
            this.bgvResignationList = new Common.CustomBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoEmployeeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoEmployeeID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoPositionName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFromDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ide = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoToDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTerminationReasonName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTerminationAllowance = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoContractIndemnity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoOther = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoReturnHealthIns = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.imeNotes = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdResignationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvResignationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(156, 20);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 80;
            this.lblToDate.Text = "Đến ngày";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(12, 20);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 78;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // grdResignationList
            // 
            this.grdResignationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResignationList.Location = new System.Drawing.Point(12, 52);
            this.grdResignationList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdResignationList.MainView = this.bgvResignationList;
            this.grdResignationList.Name = "grdResignationList";
            this.grdResignationList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.imeNotes,
            this.ide});
            this.grdResignationList.Size = new System.Drawing.Size(856, 464);
            this.grdResignationList.TabIndex = 82;
            this.grdResignationList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvResignationList});
            // 
            // bgvResignationList
            // 
            this.bgvResignationList.AllowFilter = false;
            this.bgvResignationList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand13,
            this.gridBand7,
            this.gridBand8,
            this.gridBand9,
            this.gridBand10,
            this.gridBand11,
            this.gridBand12});
            this.bgvResignationList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoEmployeeID,
            this.bcoEmployeeCode,
            this.bcoFirstName,
            this.bcoLastName,
            this.bcoDepartmentName,
            this.bcoPositionName,
            this.bcoFromDate,
            this.bcoToDate,
            this.bcoTerminationReasonName,
            this.bcoTerminationAllowance,
            this.bcoContractIndemnity,
            this.bcoOther,
            this.bcoReturnHealthIns,
            this.bcoNotes});
            this.bgvResignationList.Data = null;
            this.bgvResignationList.FixedLineWidth = 1;
            this.bgvResignationList.GridControl = this.grdResignationList;
            this.bgvResignationList.Name = "bgvResignationList";
            this.bgvResignationList.OptionsCustomization.AllowGroup = false;
            this.bgvResignationList.OptionsCustomization.AllowSort = false;
            this.bgvResignationList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvResignationList.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvResignationList.OptionsView.EnableAppearanceOddRow = true;
            this.bgvResignationList.OptionsView.RowAutoHeight = true;
            this.bgvResignationList.OptionsView.ShowAutoFilterRow = true;
            this.bgvResignationList.OptionsView.ShowColumnHeaders = false;
            this.bgvResignationList.OptionsView.ShowDetailButtons = false;
            this.bgvResignationList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvResignationList.OptionsView.ShowGroupPanel = false;
            this.bgvResignationList.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvResignationList_CustomUnboundColumnData);
            this.bgvResignationList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.bgvResignationList_SelectionChanged);
            this.bgvResignationList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvResignationList_CellValueChanging);
            this.bgvResignationList.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.bgvResignationList_CustomDrawCell);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "STT";
            this.gridBand1.Columns.Add(this.bcoNo);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
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
            this.bcoNo.OptionsFilter.AllowAutoFilter = false;
            this.bcoNo.OptionsFilter.AllowFilter = false;
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.bcoNo.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Mã NV";
            this.gridBand2.Columns.Add(this.bcoEmployeeCode);
            this.gridBand2.Columns.Add(this.bcoEmployeeID);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 75;
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
            // bcoEmployeeID
            // 
            this.bcoEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.bcoEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeID.FieldName = "EmployeeID";
            this.bcoEmployeeID.Name = "bcoEmployeeID";
            this.bcoEmployeeID.OptionsColumn.AllowEdit = false;
            this.bcoEmployeeID.OptionsColumn.ReadOnly = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Họ và tên";
            this.gridBand3.Columns.Add(this.bcoFirstName);
            this.gridBand3.Columns.Add(this.bcoLastName);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 150;
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
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Bộ phận";
            this.gridBand4.Columns.Add(this.bcoDepartmentName);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 75;
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
            this.bcoDepartmentName.FieldName = "DepartmentName";
            this.bcoDepartmentName.Name = "bcoDepartmentName";
            this.bcoDepartmentName.OptionsColumn.AllowEdit = false;
            this.bcoDepartmentName.OptionsColumn.ReadOnly = true;
            this.bcoDepartmentName.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Chức vụ";
            this.gridBand5.Columns.Add(this.bcoPositionName);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 75;
            // 
            // bcoPositionName
            // 
            this.bcoPositionName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoPositionName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoPositionName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoPositionName.AppearanceHeader.Options.UseFont = true;
            this.bcoPositionName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoPositionName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoPositionName.Caption = "Chức vụ";
            this.bcoPositionName.FieldName = "PositionName";
            this.bcoPositionName.Name = "bcoPositionName";
            this.bcoPositionName.OptionsColumn.AllowEdit = false;
            this.bcoPositionName.OptionsColumn.ReadOnly = true;
            this.bcoPositionName.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Ngày nghỉ";
            this.gridBand6.Columns.Add(this.bcoFromDate);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 75;
            // 
            // bcoFromDate
            // 
            this.bcoFromDate.AppearanceCell.Options.UseTextOptions = true;
            this.bcoFromDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFromDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoFromDate.AppearanceHeader.Options.UseFont = true;
            this.bcoFromDate.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoFromDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFromDate.Caption = "Từ ngày";
            this.bcoFromDate.ColumnEdit = this.ide;
            this.bcoFromDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bcoFromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoFromDate.FieldName = "FromDate";
            this.bcoFromDate.Name = "bcoFromDate";
            this.bcoFromDate.Visible = true;
            // 
            // ide
            // 
            this.ide.AutoHeight = false;
            this.ide.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ide.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ide.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ide.EditFormat.FormatString = "dd/MM/yyyy";
            this.ide.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ide.Mask.EditMask = "dd/MM/yyyy";
            this.ide.Name = "ide";
            this.ide.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridBand13
            // 
            this.gridBand13.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand13.AppearanceHeader.Options.UseFont = true;
            this.gridBand13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand13.Caption = "Đến ngày";
            this.gridBand13.Columns.Add(this.bcoToDate);
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.Width = 75;
            // 
            // bcoToDate
            // 
            this.bcoToDate.AppearanceCell.Options.UseTextOptions = true;
            this.bcoToDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoToDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoToDate.AppearanceHeader.Options.UseFont = true;
            this.bcoToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoToDate.Caption = "Đến ngày";
            this.bcoToDate.ColumnEdit = this.ide;
            this.bcoToDate.FieldName = "ToDate";
            this.bcoToDate.Name = "bcoToDate";
            this.bcoToDate.Visible = true;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Lý do nghỉ";
            this.gridBand7.Columns.Add(this.bcoTerminationReasonName);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.Width = 75;
            // 
            // bcoTerminationReasonName
            // 
            this.bcoTerminationReasonName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTerminationReasonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoTerminationReasonName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoTerminationReasonName.AppearanceHeader.Options.UseFont = true;
            this.bcoTerminationReasonName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTerminationReasonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTerminationReasonName.Caption = "Lý do nghỉ";
            this.bcoTerminationReasonName.FieldName = "TerminationReasonName";
            this.bcoTerminationReasonName.Name = "bcoTerminationReasonName";
            this.bcoTerminationReasonName.Visible = true;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Phụ cấp nghỉ việc";
            this.gridBand8.Columns.Add(this.bcoTerminationAllowance);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Width = 75;
            // 
            // bcoTerminationAllowance
            // 
            this.bcoTerminationAllowance.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTerminationAllowance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoTerminationAllowance.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoTerminationAllowance.AppearanceHeader.Options.UseFont = true;
            this.bcoTerminationAllowance.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTerminationAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTerminationAllowance.Caption = "Phụ cấp nghỉ việc";
            this.bcoTerminationAllowance.FieldName = "TerminationAllowance";
            this.bcoTerminationAllowance.Name = "bcoTerminationAllowance";
            this.bcoTerminationAllowance.Visible = true;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand9.AppearanceHeader.Options.UseFont = true;
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "Bồi thường hợp đồng";
            this.gridBand9.Columns.Add(this.bcoContractIndemnity);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Width = 75;
            // 
            // bcoContractIndemnity
            // 
            this.bcoContractIndemnity.AppearanceCell.Options.UseTextOptions = true;
            this.bcoContractIndemnity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoContractIndemnity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoContractIndemnity.AppearanceHeader.Options.UseFont = true;
            this.bcoContractIndemnity.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoContractIndemnity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoContractIndemnity.Caption = "Bồi thường hợp đồng";
            this.bcoContractIndemnity.FieldName = "ContractIndemnity";
            this.bcoContractIndemnity.Name = "bcoContractIndemnity";
            this.bcoContractIndemnity.Visible = true;
            // 
            // gridBand10
            // 
            this.gridBand10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand10.AppearanceHeader.Options.UseFont = true;
            this.gridBand10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand10.Caption = "Tiền nghỉ việc khác";
            this.gridBand10.Columns.Add(this.bcoOther);
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.Width = 75;
            // 
            // bcoOther
            // 
            this.bcoOther.AppearanceCell.Options.UseTextOptions = true;
            this.bcoOther.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoOther.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoOther.AppearanceHeader.Options.UseFont = true;
            this.bcoOther.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoOther.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOther.Caption = "Tiền nghỉ việc khác";
            this.bcoOther.FieldName = "Other";
            this.bcoOther.Name = "bcoOther";
            this.bcoOther.Visible = true;
            // 
            // gridBand11
            // 
            this.gridBand11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand11.AppearanceHeader.Options.UseFont = true;
            this.gridBand11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand11.Caption = "Trả thẻ BHYT";
            this.gridBand11.Columns.Add(this.bcoReturnHealthIns);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.Width = 75;
            // 
            // bcoReturnHealthIns
            // 
            this.bcoReturnHealthIns.AppearanceCell.Options.UseTextOptions = true;
            this.bcoReturnHealthIns.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoReturnHealthIns.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoReturnHealthIns.AppearanceHeader.Options.UseFont = true;
            this.bcoReturnHealthIns.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoReturnHealthIns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoReturnHealthIns.Caption = "Trả thẻ BHYT";
            this.bcoReturnHealthIns.FieldName = "ReturnHealthIns";
            this.bcoReturnHealthIns.Name = "bcoReturnHealthIns";
            this.bcoReturnHealthIns.Visible = true;
            // 
            // gridBand12
            // 
            this.gridBand12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand12.AppearanceHeader.Options.UseFont = true;
            this.gridBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand12.Caption = "Ghi chú";
            this.gridBand12.Columns.Add(this.bcoNotes);
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.Width = 75;
            // 
            // bcoNotes
            // 
            this.bcoNotes.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoNotes.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bcoNotes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNotes.AppearanceHeader.Options.UseFont = true;
            this.bcoNotes.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNotes.Caption = "Ghi chú";
            this.bcoNotes.ColumnEdit = this.imeNotes;
            this.bcoNotes.FieldName = "Notes";
            this.bcoNotes.Name = "bcoNotes";
            this.bcoNotes.Visible = true;
            // 
            // imeNotes
            // 
            this.imeNotes.Name = "imeNotes";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "PrintPreviewHS.png");
            this.imlButton.Images.SetKeyName(1, "saveHS.png");
            this.imlButton.Images.SetKeyName(2, "Redo.png");
            this.imlButton.Images.SetKeyName(3, "Edit_UndoHS.png");
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(324, 20);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 199;
            this.lblEmployeeCode.Text = "Mã NV";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(367, 16);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtEmployeeCode.Size = new System.Drawing.Size(68, 20);
            this.txtEmployeeCode.TabIndex = 202;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged);
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(212, 16);
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
            this.dedToDate.TabIndex = 204;
            this.dedToDate.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(56, 16);
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
            this.dedFromDate.TabIndex = 203;
            this.dedFromDate.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "database-save-icon32.png");
            this.imlFunction.Images.SetKeyName(1, "1359298796_backup-restore.png");
            this.imlFunction.Images.SetKeyName(2, "Undo-icon.png");
            this.imlFunction.Images.SetKeyName(3, "Actions-document-preview-icon.png");
            this.imlFunction.Images.SetKeyName(4, "layout-add-icon.png");
            this.imlFunction.Images.SetKeyName(5, "layer-save-icon32.png");
            this.imlFunction.Images.SetKeyName(6, "hand-property-icon.png");
            this.imlFunction.Images.SetKeyName(7, "checklist_32.png");
            this.imlFunction.Images.SetKeyName(8, "Document-Microsoft-Excel-icon.png");
            // 
            // ResignationList
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 526);
            this.Controls.Add(this.dedToDate);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.grdResignationList);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ResignationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên thôi việc";
            this.Load += new System.EventHandler(this.ResignationList_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResignationList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdResignationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvResignationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private DevExpress.XtraGrid.GridControl grdResignationList;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit imeNotes;
        internal System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.Label lblEmployeeCode;
        private Common.CustomBandedGridView bgvResignationList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoEmployeeID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoPositionName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFromDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTerminationReasonName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTerminationAllowance;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoContractIndemnity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoOther;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoReturnHealthIns;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNotes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoEmployeeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ide;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoToDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        internal System.Windows.Forms.ImageList imlFunction;
    }
}