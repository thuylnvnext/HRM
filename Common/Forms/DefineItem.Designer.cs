namespace Common.Forms
{
    partial class DefineItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineItem));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.ileStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ileDataType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ileDisplay = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ibeValue = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ileType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.grdDefineItem = new DevExpress.XtraGrid.GridControl();
            this.grvDefineItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tvwItemGroup = new System.Windows.Forms.TreeView();
            this.cmsItemGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imlItemGroup = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.vgcItem = new DevExpress.XtraVerticalGrid.VGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDataType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDefineItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDefineItem)).BeginInit();
            this.cmsItemGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vgcItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageIndex = 5;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(1004, 472);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "NewDocumentHS.png");
            this.imlButton.Images.SetKeyName(1, "EditInformationHS.png");
            this.imlButton.Images.SetKeyName(2, "saveHS.png");
            this.imlButton.Images.SetKeyName(3, "Edit_UndoHS.png");
            this.imlButton.Images.SetKeyName(4, "DeleteHS.png");
            this.imlButton.Images.SetKeyName(5, "Windows-Close-Program-icon.png");
            // 
            // ileStatus
            // 
            this.ileStatus.AutoHeight = false;
            this.ileStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileStatus.Name = "ileStatus";
            this.ileStatus.NullText = "";
            this.ileStatus.ShowHeader = false;
            // 
            // ileDataType
            // 
            this.ileDataType.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileDataType.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileDataType.AutoHeight = false;
            this.ileDataType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileDataType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileDataType.Name = "ileDataType";
            this.ileDataType.NullText = "";
            this.ileDataType.ShowHeader = false;
            // 
            // ileDisplay
            // 
            this.ileDisplay.AutoHeight = false;
            this.ileDisplay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileDisplay.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileDisplay.Name = "ileDisplay";
            this.ileDisplay.NullText = "";
            this.ileDisplay.ShowHeader = false;
            // 
            // ibeValue
            // 
            this.ibeValue.AutoHeight = false;
            this.ibeValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ibeValue.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ibeValue.Name = "ibeValue";
            // 
            // ileType
            // 
            this.ileType.AutoHeight = false;
            this.ileType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileType.Name = "ileType";
            this.ileType.NullText = "";
            this.ileType.ShowHeader = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageIndex = 4;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(920, 472);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 2;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(752, 472);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Enabled = false;
            this.btnUndo.ImageIndex = 3;
            this.btnUndo.ImageList = this.imlButton;
            this.btnUndo.Location = new System.Drawing.Point(836, 472);
            this.btnUndo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(76, 28);
            this.btnUndo.TabIndex = 86;
            this.btnUndo.Text = "&Hủy";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // grdDefineItem
            // 
            this.grdDefineItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDefineItem.Location = new System.Drawing.Point(240, 12);
            this.grdDefineItem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDefineItem.MainView = this.grvDefineItem;
            this.grdDefineItem.Name = "grdDefineItem";
            this.grdDefineItem.Size = new System.Drawing.Size(839, 224);
            this.grdDefineItem.TabIndex = 83;
            this.grdDefineItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDefineItem});
            // 
            // grvDefineItem
            // 
            this.grvDefineItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo});
            this.grvDefineItem.FixedLineWidth = 1;
            this.grvDefineItem.GridControl = this.grdDefineItem;
            this.grvDefineItem.HorzScrollStep = 10;
            this.grvDefineItem.Name = "grvDefineItem";
            this.grvDefineItem.OptionsCustomization.AllowGroup = false;
            this.grvDefineItem.OptionsLayout.Columns.StoreAllOptions = true;
            this.grvDefineItem.OptionsLayout.Columns.StoreAppearance = true;
            this.grvDefineItem.OptionsLayout.StoreAllOptions = true;
            this.grvDefineItem.OptionsLayout.StoreAppearance = true;
            this.grvDefineItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDefineItem.OptionsView.ColumnAutoWidth = false;
            this.grvDefineItem.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDefineItem.OptionsView.EnableAppearanceOddRow = true;
            this.grvDefineItem.OptionsView.ShowAutoFilterRow = true;
            this.grvDefineItem.OptionsView.ShowDetailButtons = false;
            this.grvDefineItem.OptionsView.ShowGroupPanel = false;
            this.grvDefineItem.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvDefineItem_CustomUnboundColumnData);
            this.grvDefineItem.DoubleClick += new System.EventHandler(this.grvDefineItem_DoubleClick);
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
            this.colNo.OptionsFilter.AllowFilter = false;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // tvwItemGroup
            // 
            this.tvwItemGroup.AllowDrop = true;
            this.tvwItemGroup.ContextMenuStrip = this.cmsItemGroup;
            this.tvwItemGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwItemGroup.HideSelection = false;
            this.tvwItemGroup.ImageIndex = 0;
            this.tvwItemGroup.ImageList = this.imlItemGroup;
            this.tvwItemGroup.Location = new System.Drawing.Point(12, 12);
            this.tvwItemGroup.Name = "tvwItemGroup";
            this.tvwItemGroup.SelectedImageIndex = 0;
            this.tvwItemGroup.Size = new System.Drawing.Size(216, 488);
            this.tvwItemGroup.TabIndex = 82;
            this.tvwItemGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwItemGroup_AfterSelect);
            this.tvwItemGroup.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwItemGroup_NodeMouseClick);
            // 
            // cmsItemGroup
            // 
            this.cmsItemGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuEdit,
            this.mnuDelete});
            this.cmsItemGroup.Name = "cmsDepartment";
            this.cmsItemGroup.Size = new System.Drawing.Size(139, 70);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdd.Image")));
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(138, 22);
            this.mnuAdd.Text = "Thêm mới...";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = ((System.Drawing.Image)(resources.GetObject("mnuEdit.Image")));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(138, 22);
            this.mnuEdit.Text = "Sửa đổi...";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelete.Image")));
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(138, 22);
            this.mnuDelete.Text = "Xóa";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // imlItemGroup
            // 
            this.imlItemGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlItemGroup.ImageStream")));
            this.imlItemGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlItemGroup.Images.SetKeyName(0, "FormulaEvaluatorHS.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imlButton;
            this.btnAdd.Location = new System.Drawing.Point(668, 472);
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 28);
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vgcItem
            // 
            this.vgcItem.Appearance.RowHeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vgcItem.Appearance.RowHeaderPanel.Options.UseFont = true;
            this.vgcItem.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vgcItem.Location = new System.Drawing.Point(240, 248);
            this.vgcItem.Name = "vgcItem";
            this.vgcItem.OptionsBehavior.AutoFocusNewRecord = true;
            this.vgcItem.OptionsView.AutoScaleBands = true;
            this.vgcItem.OptionsView.FixRowHeaderPanelWidth = true;
            this.vgcItem.RecordWidth = 176;
            this.vgcItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ileDataType,
            this.ibeValue,
            this.ileType,
            this.ileDisplay,
            this.ileStatus});
            this.vgcItem.RowHeaderWidth = 24;
            this.vgcItem.Size = new System.Drawing.Size(840, 212);
            this.vgcItem.TabIndex = 84;
            this.vgcItem.InvalidRecordException += new DevExpress.XtraVerticalGrid.Events.InvalidRecordExceptionEventHandler(this.vgcItem_InvalidRecordException);
            // 
            // DefineItem
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 512);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.grdDefineItem);
            this.Controls.Add(this.tvwItemGroup);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.vgcItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefineItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa bảng chấm công";
            this.Load += new System.EventHandler(this.DefineItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDataType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDefineItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDefineItem)).EndInit();
            this.cmsItemGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vgcItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileDataType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileDisplay;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ibeValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileType;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        internal System.Windows.Forms.ImageList imlItemGroup;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        protected DevExpress.XtraGrid.GridControl grdDefineItem;
        protected System.Windows.Forms.TreeView tvwItemGroup;
        protected DevExpress.XtraVerticalGrid.VGridControl vgcItem;
        protected DevExpress.XtraGrid.Views.Grid.GridView grvDefineItem;
        protected System.Windows.Forms.ContextMenuStrip cmsItemGroup;
    }
}