namespace Personnel.Forms
{
    partial class EmployeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfo));
            this.hleEmail = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.imeCurrentAddress = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.ipePhoto = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.cmsEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitTransferDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.mitSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mitChangeType = new System.Windows.Forms.ToolStripMenuItem();
            this.mitPersonnalRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.iteSex = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.iiePhoto = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.grdEmployeeInfo = new DevExpress.XtraGrid.GridControl();
            this.grvEmployeeInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prsEmployeeInfo = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.pclEmployeeInfo = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.lblFullName = new System.Windows.Forms.Label();
            this.chkResignation = new DevExpress.XtraEditors.CheckEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hleEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeCurrentAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipePhoto)).BeginInit();
            this.cmsEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclEmployeeInfo.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkResignation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
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
            // cmsEmployee
            // 
            this.cmsEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitTransferDepartment,
            this.mitSeparator,
            this.mitChangeType,
            this.mitPersonnalRecord,
            this.toolStripSeparator1,
            this.mitDelete});
            this.cmsEmployee.Name = "cmsEmployee";
            this.cmsEmployee.Size = new System.Drawing.Size(231, 126);
            this.cmsEmployee.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEmployee_Opening);
            // 
            // mitTransferDepartment
            // 
            this.mitTransferDepartment.Image = ((System.Drawing.Image)(resources.GetObject("mitTransferDepartment.Image")));
            this.mitTransferDepartment.Name = "mitTransferDepartment";
            this.mitTransferDepartment.Size = new System.Drawing.Size(230, 22);
            this.mitTransferDepartment.Text = "Chuyển phòng ban";
            this.mitTransferDepartment.Click += new System.EventHandler(this.mitTransferDepartment_Click);
            // 
            // mitSeparator
            // 
            this.mitSeparator.Name = "mitSeparator";
            this.mitSeparator.Size = new System.Drawing.Size(227, 6);
            // 
            // mitChangeType
            // 
            this.mitChangeType.Enabled = false;
            this.mitChangeType.Name = "mitChangeType";
            this.mitChangeType.Size = new System.Drawing.Size(230, 22);
            this.mitChangeType.Text = "Chuyển nhân viên chính thức";
            this.mitChangeType.Click += new System.EventHandler(this.mitChangeType_Click);
            // 
            // mitPersonnalRecord
            // 
            this.mitPersonnalRecord.Name = "mitPersonnalRecord";
            this.mitPersonnalRecord.Size = new System.Drawing.Size(230, 22);
            this.mitPersonnalRecord.Text = "Hồ sơ lao động";
            this.mitPersonnalRecord.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // mitDelete
            // 
            this.mitDelete.Image = ((System.Drawing.Image)(resources.GetObject("mitDelete.Image")));
            this.mitDelete.Name = "mitDelete";
            this.mitDelete.Size = new System.Drawing.Size(230, 22);
            this.mitDelete.Text = "Xóa";
            this.mitDelete.Click += new System.EventHandler(this.mitDelete_Click);
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
            this.grdEmployeeInfo.ContextMenuStrip = this.cmsEmployee;
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
            this.grdEmployeeInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grdEmployeeInfo_MouseMove);
            this.grdEmployeeInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdEmployeeInfo_MouseDown);
            // 
            // grvEmployeeInfo
            // 
            this.grvEmployeeInfo.ColumnPanelRowHeight = 40;
            this.grvEmployeeInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo});
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
            this.grvEmployeeInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvEmployeeInfo_KeyDown);
            this.grvEmployeeInfo.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvEmployeeInfo_CustomColumnDisplayText);
            this.grvEmployeeInfo.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvEmployeeInfo_CustomDrawCell);
            this.grvEmployeeInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grvEmployeeInfo_MouseMove);
            this.grvEmployeeInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvEmployeeInfo_MouseDown);
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
            this.colNo.Width = 70;
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
            this.pncFilter.Controls.Add(this.txtFullName);
            this.pncFilter.Controls.Add(this.lblFullName);
            this.pncFilter.Controls.Add(this.chkResignation);
            this.pncFilter.Controls.Add(this.txtCode);
            this.pncFilter.Controls.Add(this.lblEmployeeCode);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(916, 36);
            this.pncFilter.TabIndex = 203;
            // 
            // txtFullName
            // 
            this.txtFullName.EditValue = "Tìm tên...";
            this.txtFullName.Location = new System.Drawing.Point(180, 8);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtFullName.Size = new System.Drawing.Size(152, 20);
            this.txtFullName.TabIndex = 204;
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(120, 12);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 203;
            this.lblFullName.Text = "Họ và tên";
            this.lblFullName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
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
            this.chkResignation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            // 
            // txtCode
            // 
            this.txtCode.EditValue = "Tìm mã...";
            this.txtCode.Location = new System.Drawing.Point(52, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtCode.Size = new System.Drawing.Size(56, 20);
            this.txtCode.TabIndex = 201;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(8, 12);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCode.TabIndex = 200;
            this.lblEmployeeCode.Text = "Mã NV";
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
            // 
            // EmployeeInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 435);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdEmployeeInfo);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "EmployeeInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hleEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeCurrentAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipePhoto)).EndInit();
            this.cmsEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iteSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclEmployeeInfo.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkResignation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsEmployee;
        private System.Windows.Forms.ToolStripMenuItem mitTransferDepartment;
        private System.Windows.Forms.ToolStripSeparator mitSeparator;
        private System.Windows.Forms.ToolStripMenuItem mitDelete;
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
        private System.Windows.Forms.ToolStripMenuItem mitPersonnalRecord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraEditors.CheckEdit chkResignation;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label lblEmployeeCode;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private System.Windows.Forms.Label lblFullName;
        internal System.Windows.Forms.ImageList imlFunction;
        private System.Windows.Forms.ToolStripMenuItem mitChangeType;
    }
}
