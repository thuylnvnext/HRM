namespace Attendance.Forms
{
    partial class AuthorizedAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizedAbsence));
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.crvAuthorizedAbsence = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.dedDateOfIssue = new DevExpress.XtraEditors.DateEdit();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.txtTabMan = new System.Windows.Forms.TextBox();
            this.lblTabMan = new System.Windows.Forms.Label();
            this.ide = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.icbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.bgvAuthorizedAbsence = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoEmployeeID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFromDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoToDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoReasonName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grdAuthorizedAbsence = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvAuthorizedAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthorizedAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(72, 36);
            this.dedToDate.Name = "dedToDate";
            this.dedToDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dedToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedToDate.Size = new System.Drawing.Size(80, 22);
            this.dedToDate.TabIndex = 195;
            this.dedToDate.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(72, 12);
            this.dedFromDate.Name = "dedFromDate";
            this.dedFromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dedFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedFromDate.Size = new System.Drawing.Size(80, 22);
            this.dedFromDate.TabIndex = 194;
            this.dedFromDate.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(12, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 192;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(12, 40);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 193;
            this.lblToDate.Text = "Đến ngày";
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // crvAuthorizedAbsence
            // 
            this.crvAuthorizedAbsence.ActiveViewIndex = -1;
            this.crvAuthorizedAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crvAuthorizedAbsence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAuthorizedAbsence.DisplayGroupTree = false;
            this.crvAuthorizedAbsence.Location = new System.Drawing.Point(0, 68);
            this.crvAuthorizedAbsence.Name = "crvAuthorizedAbsence";
            this.crvAuthorizedAbsence.SelectionFormula = "";
            this.crvAuthorizedAbsence.Size = new System.Drawing.Size(785, 366);
            this.crvAuthorizedAbsence.TabIndex = 197;
            this.crvAuthorizedAbsence.ViewTimeSelectionFormula = "";
            this.crvAuthorizedAbsence.Visible = false;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(164, 28);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 199;
            this.lblEmployeeCode.Text = "Mã NV";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(208, 24);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(40, 21);
            this.txtEmployeeCode.TabIndex = 198;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ImageIndex = 0;
            this.btnPreview.ImageList = this.imlButton;
            this.btnPreview.Location = new System.Drawing.Point(664, 20);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(112, 28);
            this.btnPreview.TabIndex = 200;
            this.btnPreview.Text = "Xem báo cáo";
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "PrintPreviewHS.png");
            // 
            // dedDateOfIssue
            // 
            this.dedDateOfIssue.EditValue = null;
            this.dedDateOfIssue.Location = new System.Drawing.Point(456, 36);
            this.dedDateOfIssue.Name = "dedDateOfIssue";
            this.dedDateOfIssue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dedDateOfIssue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedDateOfIssue.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedDateOfIssue.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedDateOfIssue.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedDateOfIssue.Size = new System.Drawing.Size(80, 22);
            this.dedDateOfIssue.TabIndex = 204;
            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Location = new System.Drawing.Point(400, 40);
            this.lblDateOfIssue.Name = "lblDateOfIssue";
            this.lblDateOfIssue.Size = new System.Drawing.Size(49, 13);
            this.lblDateOfIssue.TabIndex = 203;
            this.lblDateOfIssue.Text = "Ngày lập";
            // 
            // txtTabMan
            // 
            this.txtTabMan.Location = new System.Drawing.Point(456, 12);
            this.txtTabMan.Name = "txtTabMan";
            this.txtTabMan.Size = new System.Drawing.Size(160, 21);
            this.txtTabMan.TabIndex = 202;
            // 
            // lblTabMan
            // 
            this.lblTabMan.AutoSize = true;
            this.lblTabMan.Location = new System.Drawing.Point(400, 16);
            this.lblTabMan.Name = "lblTabMan";
            this.lblTabMan.Size = new System.Drawing.Size(52, 13);
            this.lblTabMan.TabIndex = 201;
            this.lblTabMan.Text = "Người lập";
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
            // icbGroup
            // 
            this.icbGroup.AutoHeight = false;
            this.icbGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbGroup.Name = "icbGroup";
            this.icbGroup.SmallImages = this.imlGroup;
            // 
            // bgvAuthorizedAbsence
            // 
            this.bgvAuthorizedAbsence.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvAuthorizedAbsence.Appearance.GroupRow.Options.UseFont = true;
            this.bgvAuthorizedAbsence.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand5,
            this.gridBand6,
            this.gridBand7,
            this.gridBand8,
            this.gridBand9});
            this.bgvAuthorizedAbsence.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoEmployeeID,
            this.bcoFirstName,
            this.bcoLastName,
            this.bcoDepartmentName,
            this.bcoFromDate,
            this.bcoToDate,
            this.bcoTotal,
            this.bcoReasonName,
            this.bcoType});
            this.bgvAuthorizedAbsence.FixedLineWidth = 1;
            this.bgvAuthorizedAbsence.GridControl = this.grdAuthorizedAbsence;
            this.bgvAuthorizedAbsence.GroupCount = 1;
            this.bgvAuthorizedAbsence.HorzScrollStep = 30;
            this.bgvAuthorizedAbsence.Name = "bgvAuthorizedAbsence";
            this.bgvAuthorizedAbsence.OptionsCustomization.AllowFilter = false;
            this.bgvAuthorizedAbsence.OptionsCustomization.AllowGroup = false;
            this.bgvAuthorizedAbsence.OptionsCustomization.AllowSort = false;
            this.bgvAuthorizedAbsence.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvAuthorizedAbsence.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvAuthorizedAbsence.OptionsSelection.MultiSelect = true;
            this.bgvAuthorizedAbsence.OptionsView.ColumnAutoWidth = false;
            this.bgvAuthorizedAbsence.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvAuthorizedAbsence.OptionsView.EnableAppearanceOddRow = true;
            this.bgvAuthorizedAbsence.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.bgvAuthorizedAbsence.OptionsView.ShowAutoFilterRow = true;
            this.bgvAuthorizedAbsence.OptionsView.ShowColumnHeaders = false;
            this.bgvAuthorizedAbsence.OptionsView.ShowDetailButtons = false;
            this.bgvAuthorizedAbsence.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvAuthorizedAbsence.OptionsView.ShowGroupPanel = false;
            this.bgvAuthorizedAbsence.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bcoDepartmentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bgvAuthorizedAbsence.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvAuthorizedAbsence_CustomUnboundColumnData);
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
            this.bcoNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bcoNo.OptionsColumn.ReadOnly = true;
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoNo.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Mã NV";
            this.gridBand2.Columns.Add(this.bcoEmployeeID);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 75;
            // 
            // bcoEmployeeID
            // 
            this.bcoEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.bcoEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoEmployeeID.Caption = "Mã NV";
            this.bcoEmployeeID.FieldName = "EmployeeID";
            this.bcoEmployeeID.Name = "bcoEmployeeID";
            this.bcoEmployeeID.OptionsColumn.AllowEdit = false;
            this.bcoEmployeeID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bcoEmployeeID.OptionsColumn.ReadOnly = true;
            this.bcoEmployeeID.Visible = true;
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
            this.bcoFirstName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bcoLastName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Từ ngày";
            this.gridBand5.Columns.Add(this.bcoFromDate);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 75;
            // 
            // bcoFromDate
            // 
            this.bcoFromDate.AppearanceCell.Options.UseTextOptions = true;
            this.bcoFromDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFromDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoFromDate.AppearanceHeader.Options.UseFont = true;
            this.bcoFromDate.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoFromDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFromDate.Caption = "Từ ngày";
            this.bcoFromDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bcoFromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoFromDate.FieldName = "FromDate";
            this.bcoFromDate.Name = "bcoFromDate";
            this.bcoFromDate.OptionsColumn.AllowEdit = false;
            this.bcoFromDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bcoFromDate.OptionsColumn.ReadOnly = true;
            this.bcoFromDate.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Đến ngày";
            this.gridBand6.Columns.Add(this.bcoToDate);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 75;
            // 
            // bcoToDate
            // 
            this.bcoToDate.AppearanceCell.Options.UseTextOptions = true;
            this.bcoToDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoToDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoToDate.AppearanceHeader.Options.UseFont = true;
            this.bcoToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoToDate.Caption = "Đến ngày";
            this.bcoToDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bcoToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoToDate.FieldName = "ToDate";
            this.bcoToDate.Name = "bcoToDate";
            this.bcoToDate.OptionsColumn.AllowEdit = false;
            this.bcoToDate.OptionsColumn.ReadOnly = true;
            this.bcoToDate.Visible = true;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Số ngày";
            this.gridBand7.Columns.Add(this.bcoTotal);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.Width = 75;
            // 
            // bcoTotal
            // 
            this.bcoTotal.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTotal.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoTotal.AppearanceHeader.Options.UseFont = true;
            this.bcoTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTotal.Caption = "Số ngày";
            this.bcoTotal.DisplayFormat.FormatString = "0.#;;-";
            this.bcoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoTotal.FieldName = "Total";
            this.bcoTotal.Name = "bcoTotal";
            this.bcoTotal.OptionsColumn.AllowEdit = false;
            this.bcoTotal.OptionsColumn.ReadOnly = true;
            this.bcoTotal.Visible = true;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Lý do";
            this.gridBand8.Columns.Add(this.bcoReasonName);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Width = 75;
            // 
            // bcoReasonName
            // 
            this.bcoReasonName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoReasonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoReasonName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoReasonName.AppearanceHeader.Options.UseFont = true;
            this.bcoReasonName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoReasonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoReasonName.Caption = "Lý do";
            this.bcoReasonName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoReasonName.FieldName = "ReasonName";
            this.bcoReasonName.Name = "bcoReasonName";
            this.bcoReasonName.OptionsColumn.AllowEdit = false;
            this.bcoReasonName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.bcoReasonName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.bcoReasonName.OptionsColumn.ReadOnly = true;
            this.bcoReasonName.Visible = true;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand9.AppearanceHeader.Options.UseFont = true;
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "Loại";
            this.gridBand9.Columns.Add(this.bcoType);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Width = 75;
            // 
            // bcoType
            // 
            this.bcoType.AppearanceCell.Options.UseTextOptions = true;
            this.bcoType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoType.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoType.AppearanceHeader.Options.UseFont = true;
            this.bcoType.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoType.Caption = "Loại";
            this.bcoType.FieldName = "Type";
            this.bcoType.Name = "bcoType";
            this.bcoType.OptionsColumn.AllowEdit = false;
            this.bcoType.OptionsColumn.ReadOnly = true;
            this.bcoType.Visible = true;
            // 
            // bcoDepartmentName
            // 
            this.bcoDepartmentName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDepartmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // grdAuthorizedAbsence
            // 
            this.grdAuthorizedAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAuthorizedAbsence.Location = new System.Drawing.Point(12, 68);
            this.grdAuthorizedAbsence.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdAuthorizedAbsence.MainView = this.bgvAuthorizedAbsence;
            this.grdAuthorizedAbsence.Name = "grdAuthorizedAbsence";
            this.grdAuthorizedAbsence.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ide,
            this.icbGroup});
            this.grdAuthorizedAbsence.Size = new System.Drawing.Size(760, 352);
            this.grdAuthorizedAbsence.TabIndex = 196;
            this.grdAuthorizedAbsence.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvAuthorizedAbsence});
            // 
            // AuthorizedAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.dedDateOfIssue);
            this.Controls.Add(this.lblDateOfIssue);
            this.Controls.Add(this.txtTabMan);
            this.Controls.Add(this.lblTabMan);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.grdAuthorizedAbsence);
            this.Controls.Add(this.dedToDate);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.crvAuthorizedAbsence);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AuthorizedAbsence";
            this.Text = "Vắng mặt có phép";
            this.Load += new System.EventHandler(this.AuthorizedAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvAuthorizedAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthorizedAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dedToDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAuthorizedAbsence;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        internal System.Windows.Forms.ImageList imlGroup;
        internal System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.DateEdit dedDateOfIssue;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.TextBox txtTabMan;
        private System.Windows.Forms.Label lblTabMan;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ide;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbGroup;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvAuthorizedAbsence;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoEmployeeID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFromDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoToDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTotal;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoReasonName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoType;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        private DevExpress.XtraGrid.GridControl grdAuthorizedAbsence;
    }
}