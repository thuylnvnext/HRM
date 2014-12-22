namespace HRMplus.Forms
{
    partial class ChangeTitle
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTitle));
            this.grvLanguage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdChangeTitle = new DevExpress.XtraGrid.GridControl();
            this.grvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton1btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLanguage
            // 
            this.grvLanguage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colItemID,
            this.colValue});
            this.grvLanguage.GridControl = this.grdChangeTitle;
            this.grvLanguage.Name = "grvLanguage";
            this.grvLanguage.OptionsCustomization.AllowColumnMoving = false;
            this.grvLanguage.OptionsCustomization.AllowFilter = false;
            this.grvLanguage.OptionsCustomization.AllowGroup = false;
            this.grvLanguage.OptionsCustomization.AllowSort = false;
            this.grvLanguage.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvLanguage.OptionsSelection.MultiSelect = true;
            this.grvLanguage.OptionsView.EnableAppearanceEvenRow = true;
            this.grvLanguage.OptionsView.EnableAppearanceOddRow = true;
            this.grvLanguage.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvLanguage.OptionsView.ShowGroupPanel = false;
            this.grvLanguage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvLanguage_KeyDown);
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Ngôn ngữ";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colItemID
            // 
            this.colItemID.AppearanceCell.Options.UseTextOptions = true;
            this.colItemID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItemID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colItemID.AppearanceHeader.Options.UseFont = true;
            this.colItemID.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemID.Caption = "Mục";
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            // 
            // colValue
            // 
            this.colValue.AppearanceCell.Options.UseTextOptions = true;
            this.colValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colValue.AppearanceHeader.Options.UseFont = true;
            this.colValue.AppearanceHeader.Options.UseTextOptions = true;
            this.colValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValue.Caption = "Giá trị";
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 1;
            // 
            // grdChangeTitle
            // 
            gridLevelNode1.LevelTemplate = this.grvLanguage;
            gridLevelNode1.RelationName = "Item_Language";
            this.grdChangeTitle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdChangeTitle.Location = new System.Drawing.Point(12, 12);
            this.grdChangeTitle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdChangeTitle.MainView = this.grvItem;
            this.grdChangeTitle.Name = "grdChangeTitle";
            this.grdChangeTitle.Size = new System.Drawing.Size(904, 468);
            this.grdChangeTitle.TabIndex = 18;
            this.grdChangeTitle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItem,
            this.grvLanguage});
            // 
            // grvItem
            // 
            this.grvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colItem,
            this.colDescription});
            this.grvItem.FixedLineWidth = 1;
            this.grvItem.GridControl = this.grdChangeTitle;
            this.grvItem.GroupFormat = " [#image]{1} {2}";
            this.grvItem.Name = "grvItem";
            this.grvItem.OptionsCustomization.AllowColumnMoving = false;
            this.grvItem.OptionsCustomization.AllowFilter = false;
            this.grvItem.OptionsCustomization.AllowGroup = false;
            this.grvItem.OptionsCustomization.AllowSort = false;
            this.grvItem.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grvItem.OptionsDetail.ShowDetailTabs = false;
            this.grvItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvItem.OptionsSelection.MultiSelect = true;
            this.grvItem.OptionsView.ColumnAutoWidth = false;
            this.grvItem.OptionsView.EnableAppearanceEvenRow = true;
            this.grvItem.OptionsView.EnableAppearanceOddRow = true;
            this.grvItem.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvItem.OptionsView.ShowAutoFilterRow = true;
            this.grvItem.OptionsView.ShowGroupPanel = false;
            this.grvItem.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvItem_CustomUnboundColumnData);
            this.grvItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvItem_KeyDown);
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
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colItem
            // 
            this.colItem.AppearanceCell.Options.UseTextOptions = true;
            this.colItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colItem.AppearanceHeader.Options.UseFont = true;
            this.colItem.AppearanceHeader.Options.UseTextOptions = true;
            this.colItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItem.Caption = "Mục";
            this.colItem.FieldName = "ID";
            this.colItem.Name = "colItem";
            this.colItem.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // simpleButton1btnClose
            // 
            this.simpleButton1btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1btnClose.ImageIndex = 1;
            this.simpleButton1btnClose.ImageList = this.imlButton;
            this.simpleButton1btnClose.Location = new System.Drawing.Point(467, 492);
            this.simpleButton1btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1btnClose.Name = "simpleButton1btnClose";
            this.simpleButton1btnClose.Size = new System.Drawing.Size(76, 28);
            this.simpleButton1btnClose.TabIndex = 168;
            this.simpleButton1btnClose.Text = "Đóng";
            this.simpleButton1btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(383, 492);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 167;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangeTitle
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 531);
            this.Controls.Add(this.simpleButton1btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdChangeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeTitle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi tiêu đề";
            this.Load += new System.EventHandler(this.ChangeTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdChangeTitle;
        private DevExpress.XtraGrid.Views.Grid.GridView grvItem;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLanguage;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}