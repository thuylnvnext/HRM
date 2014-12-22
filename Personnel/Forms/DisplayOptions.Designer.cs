namespace Personnel.Forms
{
    partial class DisplayOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOptions));
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisibleIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDisplayOptions = new DevExpress.XtraGrid.GridControl();
            this.grvDisplayOptions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAlignment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileAlignment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDisplayOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileAlignment)).BeginInit();
            this.SuspendLayout();
            // 
            // colFieldName
            // 
            this.colFieldName.AppearanceCell.Options.UseTextOptions = true;
            this.colFieldName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFieldName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFieldName.AppearanceHeader.Options.UseFont = true;
            this.colFieldName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFieldName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFieldName.Caption = "Tên cột";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFieldName.OptionsFilter.AllowAutoFilter = false;
            this.colFieldName.OptionsFilter.AllowFilter = false;
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // colCaption
            // 
            this.colCaption.AppearanceCell.Options.UseTextOptions = true;
            this.colCaption.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCaption.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCaption.AppearanceHeader.Options.UseFont = true;
            this.colCaption.AppearanceHeader.Options.UseTextOptions = true;
            this.colCaption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCaption.Caption = "Tiêu đề";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCaption.OptionsFilter.AllowAutoFilter = false;
            this.colCaption.OptionsFilter.AllowFilter = false;
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 1;
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
            this.colNo.OptionsFilter.AllowAutoFilter = false;
            this.colNo.OptionsFilter.AllowFilter = false;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colVisibleIndex
            // 
            this.colVisibleIndex.AppearanceCell.Options.UseTextOptions = true;
            this.colVisibleIndex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colVisibleIndex.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colVisibleIndex.AppearanceHeader.Options.UseFont = true;
            this.colVisibleIndex.AppearanceHeader.Options.UseTextOptions = true;
            this.colVisibleIndex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVisibleIndex.Caption = "Thứ tự";
            this.colVisibleIndex.FieldName = "VisibleIndex";
            this.colVisibleIndex.Name = "colVisibleIndex";
            this.colVisibleIndex.OptionsFilter.AllowAutoFilter = false;
            this.colVisibleIndex.OptionsFilter.AllowFilter = false;
            this.colVisibleIndex.Visible = true;
            this.colVisibleIndex.VisibleIndex = 2;
            // 
            // grdDisplayOptions
            // 
            this.grdDisplayOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDisplayOptions.Location = new System.Drawing.Point(12, 12);
            this.grdDisplayOptions.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDisplayOptions.MainView = this.grvDisplayOptions;
            this.grdDisplayOptions.Name = "grdDisplayOptions";
            this.grdDisplayOptions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ileAlignment});
            this.grdDisplayOptions.Size = new System.Drawing.Size(395, 344);
            this.grdDisplayOptions.TabIndex = 177;
            this.grdDisplayOptions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDisplayOptions});
            // 
            // grvDisplayOptions
            // 
            this.grvDisplayOptions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colFieldName,
            this.colCaption,
            this.colVisibleIndex,
            this.colAlignment});
            this.grvDisplayOptions.FixedLineWidth = 1;
            this.grvDisplayOptions.GridControl = this.grdDisplayOptions;
            this.grvDisplayOptions.Name = "grvDisplayOptions";
            this.grvDisplayOptions.OptionsCustomization.AllowColumnMoving = false;
            this.grvDisplayOptions.OptionsCustomization.AllowGroup = false;
            this.grvDisplayOptions.OptionsCustomization.AllowSort = false;
            this.grvDisplayOptions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDisplayOptions.OptionsView.ColumnAutoWidth = false;
            this.grvDisplayOptions.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDisplayOptions.OptionsView.EnableAppearanceOddRow = true;
            this.grvDisplayOptions.OptionsView.ShowDetailButtons = false;
            this.grvDisplayOptions.OptionsView.ShowGroupPanel = false;
            this.grvDisplayOptions.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvDisplayOptions_CustomUnboundColumnData);
            // 
            // colAlignment
            // 
            this.colAlignment.AppearanceCell.Options.UseTextOptions = true;
            this.colAlignment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAlignment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAlignment.AppearanceHeader.Options.UseFont = true;
            this.colAlignment.AppearanceHeader.Options.UseTextOptions = true;
            this.colAlignment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlignment.Caption = "Căn lề";
            this.colAlignment.ColumnEdit = this.ileAlignment;
            this.colAlignment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAlignment.FieldName = "Alignment";
            this.colAlignment.Name = "colAlignment";
            this.colAlignment.OptionsFilter.AllowAutoFilter = false;
            this.colAlignment.OptionsFilter.AllowFilter = false;
            this.colAlignment.Visible = true;
            this.colAlignment.VisibleIndex = 3;
            // 
            // ileAlignment
            // 
            this.ileAlignment.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileAlignment.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileAlignment.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ileAlignment.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ileAlignment.AutoHeight = false;
            this.ileAlignment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileAlignment.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileAlignment.Name = "ileAlignment";
            this.ileAlignment.NullText = "";
            this.ileAlignment.ShowHeader = false;
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(127, 368);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 201;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(215, 368);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 202;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DisplayOptions
            // 
            this.AcceptButton = this.btnSave;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(418, 406);
            this.Controls.Add(this.grdDisplayOptions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn hiển thị";
            this.Load += new System.EventHandler(this.DisplayOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDisplayOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileAlignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVisibleIndex;
        private DevExpress.XtraGrid.GridControl grdDisplayOptions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDisplayOptions;
        private DevExpress.XtraGrid.Columns.GridColumn colAlignment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileAlignment;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}