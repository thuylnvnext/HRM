namespace Personnel.Forms
{
    partial class BirthdayList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirthdayList));
            this.hleEmail = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.imeCurrentAddress = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.ipePhoto = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.iteSex = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.iiePhoto = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.grdEmployeeInfo = new DevExpress.XtraGrid.GridControl();
            this.grvEmployeeInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prsEmployeeInfo = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.pclEmployeeInfo = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.chkResignation = new DevExpress.XtraEditors.CheckEdit();
            this.cmbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hleEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeCurrentAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclEmployeeInfo.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkResignation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hleEmail
            // 
            this.hleEmail.AutoHeight = false;
            this.hleEmail.Name = "hleEmail";
            this.hleEmail.SingleClick = true;
            // 
            // imeCurrentAddress
            // 
            this.imeCurrentAddress.Name = "imeCurrentAddress";
            // 
            // ipePhoto
            // 
            this.ipePhoto.CustomHeight = 151;
            this.ipePhoto.Name = "ipePhoto";
            this.ipePhoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // iteSex
            // 
            this.iteSex.AutoHeight = false;
            this.iteSex.Name = "iteSex";
            // 
            // iiePhoto
            // 
            this.iiePhoto.AutoHeight = false;
            this.iiePhoto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iiePhoto.Name = "iiePhoto";
            this.iiePhoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // grdEmployeeInfo
            // 
            this.grdEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEmployeeInfo.Location = new System.Drawing.Point(0, 36);
            this.grdEmployeeInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdEmployeeInfo.MainView = this.grvEmployeeInfo;
            this.grdEmployeeInfo.Name = "grdEmployeeInfo";
            this.grdEmployeeInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.iteSex,
            this.iiePhoto});
            this.grdEmployeeInfo.Size = new System.Drawing.Size(915, 399);
            this.grdEmployeeInfo.TabIndex = 9;
            this.grdEmployeeInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployeeInfo});
            // 
            // grvEmployeeInfo
            // 
            this.grvEmployeeInfo.ColumnPanelRowHeight = 40;
            this.grvEmployeeInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colFullName,
            this.colDepartmentName,
            this.colBirthDate,
            this.colResignation});
            this.grvEmployeeInfo.GridControl = this.grdEmployeeInfo;
            this.grvEmployeeInfo.Name = "grvEmployeeInfo";
            this.grvEmployeeInfo.OptionsCustomization.AllowGroup = false;
            this.grvEmployeeInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvEmployeeInfo.OptionsSelection.MultiSelect = true;
            this.grvEmployeeInfo.OptionsView.ColumnAutoWidth = false;
            this.grvEmployeeInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.grvEmployeeInfo.OptionsView.EnableAppearanceOddRow = true;
            this.grvEmployeeInfo.OptionsView.ShowAutoFilterRow = true;
            this.grvEmployeeInfo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvEmployeeInfo.OptionsView.ShowGroupPanel = false;
            this.grvEmployeeInfo.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvEmployeeInfo_CustomUnboundColumnData);
            this.grvEmployeeInfo.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvEmployeeInfo_CustomDrawCell);
            this.grvEmployeeInfo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grvEmployeeInfo_RowCellStyle);
            this.grvEmployeeInfo.ColumnPositionChanged += new System.EventHandler(this.grvEmployeeInfo_ColumnPositionChanged);
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Options.UseTextOptions = true;
            this.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNo.AppearanceHeader.Options.UseFont = true;
            this.colNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNo.Caption = "No";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.AllowEdit = false;
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 154;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFullName.AppearanceCell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceCell.Options.UseForeColor = true;
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFullName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFullName.Caption = "Họ tên";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 175;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.colDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartmentName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDepartmentName.Caption = "Phòng ban";
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.OptionsColumn.AllowEdit = false;
            this.colDepartmentName.OptionsColumn.ReadOnly = true;
            this.colDepartmentName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 2;
            this.colDepartmentName.Width = 364;
            // 
            // colBirthDate
            // 
            this.colBirthDate.AppearanceCell.Options.UseTextOptions = true;
            this.colBirthDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirthDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBirthDate.AppearanceHeader.Options.UseFont = true;
            this.colBirthDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirthDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirthDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBirthDate.Caption = "Ngày sinh";
            this.colBirthDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colBirthDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowEdit = false;
            this.colBirthDate.OptionsColumn.ReadOnly = true;
            this.colBirthDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 3;
            this.colBirthDate.Width = 199;
            // 
            // colResignation
            // 
            this.colResignation.AppearanceCell.Options.UseTextOptions = true;
            this.colResignation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colResignation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colResignation.AppearanceHeader.Options.UseFont = true;
            this.colResignation.AppearanceHeader.Options.UseTextOptions = true;
            this.colResignation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colResignation.Caption = "colResignation";
            this.colResignation.FieldName = "Resignation";
            this.colResignation.Name = "colResignation";
            this.colResignation.OptionsColumn.AllowEdit = false;
            this.colResignation.OptionsColumn.ReadOnly = true;
            // 
            // prsEmployeeInfo
            // 
            this.prsEmployeeInfo.Links.AddRange(new object[] {
            this.pclEmployeeInfo});
            // 
            // pclEmployeeInfo
            // 
            this.pclEmployeeInfo.Component = this.grdEmployeeInfo;
            // 
            // 
            // 
            this.pclEmployeeInfo.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("pclEmployeeInfo.ImageCollection.ImageStream")));
            this.pclEmployeeInfo.Landscape = true;
            this.pclEmployeeInfo.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);
            this.pclEmployeeInfo.MinMargins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.pclEmployeeInfo.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.pclEmployeeInfo.PrintingSystem = this.prsEmployeeInfo;
            this.pclEmployeeInfo.PrintingSystemBase = this.prsEmployeeInfo;
            this.pclEmployeeInfo.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.pclEmployeeInfo_CreateReportHeaderArea);
            this.pclEmployeeInfo.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.pclEmployeeInfo_CreateMarginalFooterArea);
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.chkResignation);
            this.pncFilter.Controls.Add(this.cmbMonth);
            this.pncFilter.Controls.Add(this.lblEmployeeCode);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(916, 36);
            this.pncFilter.TabIndex = 203;
            // 
            // chkResignation
            // 
            this.chkResignation.Location = new System.Drawing.Point(155, 8);
            this.chkResignation.Name = "chkResignation";
            this.chkResignation.Properties.AutoWidth = true;
            this.chkResignation.Properties.Caption = "Nghỉ việc";
            this.chkResignation.Properties.FullFocusRect = true;
            this.chkResignation.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkResignation.Size = new System.Drawing.Size(66, 19);
            this.chkResignation.TabIndex = 203;
            this.chkResignation.CheckedChanged += new System.EventHandler(this.chkResignation_CheckedChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(49, 7);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMonth.Properties.Items.AddRange(new object[] {
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
            this.cmbMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbMonth.Size = new System.Drawing.Size(100, 20);
            this.cmbMonth.TabIndex = 201;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(8, 12);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 200;
            this.lblEmployeeCode.Text = "Tháng";
            this.lblEmployeeCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "user-add-icon.png");
            this.imlFunction.Images.SetKeyName(1, "file-import-icon.png");
            this.imlFunction.Images.SetKeyName(2, "female-user-search-icon.png");
            this.imlFunction.Images.SetKeyName(3, "2011071603464343_easyicon_cn_32.png");
            this.imlFunction.Images.SetKeyName(4, "Contract-icon.png");
            this.imlFunction.Images.SetKeyName(5, "20110716034430128_easyicon_cn_32.png");
            this.imlFunction.Images.SetKeyName(6, "20110716034407602_easyicon_cn_32.png");
            this.imlFunction.Images.SetKeyName(7, "forward-icon.png");
            this.imlFunction.Images.SetKeyName(8, "file-export-icon.png");
            this.imlFunction.Images.SetKeyName(9, "layer-save-icon32.png");
            this.imlFunction.Images.SetKeyName(10, "bd.png");
            // 
            // BirthdayList
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 435);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdEmployeeInfo);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "BirthdayList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Danh sách sinh nhật trong tháng";
            this.Load += new System.EventHandler(this.BirthdayList_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BirthdayList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hleEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeCurrentAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclEmployeeInfo.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkResignation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit hleEmail;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit imeCurrentAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit ipePhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit iteSex;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit iiePhoto;
        private DevExpress.XtraGrid.GridControl grdEmployeeInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployeeInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraPrinting.PrintingSystem prsEmployeeInfo;
        private DevExpress.XtraPrinting.PrintableComponentLink pclEmployeeInfo;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private System.Windows.Forms.Label lblEmployeeCode;
        internal System.Windows.Forms.ImageList imlFunction;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMonth;
        private DevExpress.XtraEditors.CheckEdit chkResignation;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colResignation;
    }
}
