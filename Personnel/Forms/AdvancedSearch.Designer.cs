namespace Personnel.Forms
{
    partial class AdvancedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSearch));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grdSearchInfo = new DevExpress.XtraGrid.GridControl();
            this.bgvSearchInfo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbCheck = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCaption = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSearchResult = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoAnd = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoOr = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoFormatType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ibeDateTime = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvSearchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibeDateTime)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "female-user-search16.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // grdSearchInfo
            // 
            this.grdSearchInfo.Location = new System.Drawing.Point(12, 12);
            this.grdSearchInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdSearchInfo.MainView = this.bgvSearchInfo;
            this.grdSearchInfo.Name = "grdSearchInfo";
            this.grdSearchInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ibeDateTime});
            this.grdSearchInfo.Size = new System.Drawing.Size(572, 244);
            this.grdSearchInfo.TabIndex = 89;
            this.grdSearchInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvSearchInfo});
            // 
            // bgvSearchInfo
            // 
            this.bgvSearchInfo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbCheck,
            this.gridBand4,
            this.gridBand1});
            this.bgvSearchInfo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoCaption,
            this.bcoFormatType,
            this.bcoSearchResult,
            this.bcoAnd,
            this.bcoOr});
            this.bgvSearchInfo.FixedLineWidth = 1;
            this.bgvSearchInfo.GridControl = this.grdSearchInfo;
            this.bgvSearchInfo.HorzScrollStep = 10;
            this.bgvSearchInfo.Name = "bgvSearchInfo";
            this.bgvSearchInfo.OptionsCustomization.AllowFilter = false;
            this.bgvSearchInfo.OptionsCustomization.AllowGroup = false;
            this.bgvSearchInfo.OptionsCustomization.AllowSort = false;
            this.bgvSearchInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvSearchInfo.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvSearchInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvSearchInfo.OptionsView.EnableAppearanceOddRow = true;
            this.bgvSearchInfo.OptionsView.ShowColumnHeaders = false;
            this.bgvSearchInfo.OptionsView.ShowDetailButtons = false;
            this.bgvSearchInfo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvSearchInfo.OptionsView.ShowGroupPanel = false;
            this.bgvSearchInfo.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.bgvSearchInfo_CustomRowCellEdit);
            // 
            // grbCheck
            // 
            this.grbCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbCheck.AppearanceHeader.Options.UseFont = true;
            this.grbCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.grbCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbCheck.Caption = "Tiêu chí";
            this.grbCheck.Columns.Add(this.bcoCaption);
            this.grbCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.grbCheck.ImageIndex = 1;
            this.grbCheck.Name = "grbCheck";
            this.grbCheck.Width = 105;
            // 
            // bcoCaption
            // 
            this.bcoCaption.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCaption.AppearanceCell.Options.UseFont = true;
            this.bcoCaption.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCaption.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoCaption.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCaption.AppearanceHeader.Options.UseFont = true;
            this.bcoCaption.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCaption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCaption.Caption = "Tiêu chí";
            this.bcoCaption.FieldName = "Caption";
            this.bcoCaption.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.bcoCaption.ImageIndex = 1;
            this.bcoCaption.Name = "bcoCaption";
            this.bcoCaption.OptionsColumn.AllowEdit = false;
            this.bcoCaption.OptionsColumn.ReadOnly = true;
            this.bcoCaption.Visible = true;
            this.bcoCaption.Width = 105;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Tìm kết quả";
            this.gridBand4.Columns.Add(this.bcoSearchResult);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 75;
            // 
            // bcoSearchResult
            // 
            this.bcoSearchResult.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSearchResult.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoSearchResult.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoSearchResult.AppearanceHeader.Options.UseFont = true;
            this.bcoSearchResult.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSearchResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSearchResult.Caption = "Tìm kết quả";
            this.bcoSearchResult.FieldName = "SearchResult";
            this.bcoSearchResult.Name = "bcoSearchResult";
            this.bcoSearchResult.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Giá trị";
            this.gridBand1.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand3});
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 300;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Và";
            this.gridBand2.Columns.Add(this.bcoAnd);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 150;
            // 
            // bcoAnd
            // 
            this.bcoAnd.AppearanceCell.Options.UseTextOptions = true;
            this.bcoAnd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoAnd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoAnd.AppearanceHeader.Options.UseFont = true;
            this.bcoAnd.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoAnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoAnd.Caption = "Và";
            this.bcoAnd.FieldName = "And";
            this.bcoAnd.Name = "bcoAnd";
            this.bcoAnd.Visible = true;
            this.bcoAnd.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Hoặc";
            this.gridBand3.Columns.Add(this.bcoOr);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 150;
            // 
            // bcoOr
            // 
            this.bcoOr.AppearanceCell.Options.UseTextOptions = true;
            this.bcoOr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoOr.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoOr.AppearanceHeader.Options.UseFont = true;
            this.bcoOr.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoOr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOr.Caption = "Hoặc";
            this.bcoOr.FieldName = "Or";
            this.bcoOr.Name = "bcoOr";
            this.bcoOr.Visible = true;
            this.bcoOr.Width = 150;
            // 
            // bcoFormatType
            // 
            this.bcoFormatType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoFormatType.AppearanceHeader.Options.UseFont = true;
            this.bcoFormatType.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoFormatType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFormatType.Caption = "Kiểu định dạng";
            this.bcoFormatType.FieldName = "FormatType";
            this.bcoFormatType.Name = "bcoFormatType";
            // 
            // ibeDateTime
            // 
            this.ibeDateTime.AutoHeight = false;
            this.ibeDateTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ibeDateTime.Name = "ibeDateTime";
            this.ibeDateTime.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ibeDateTime_ButtonClick);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imlButton;
            this.btnSearch.Location = new System.Drawing.Point(215, 268);
            this.btnSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 28);
            this.btnSearch.TabIndex = 197;
            this.btnSearch.Text = "&Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(307, 268);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 198;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AdvancedSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(598, 306);
            this.Controls.Add(this.grdSearchInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nâng cao";
            this.Load += new System.EventHandler(this.AdvancedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvSearchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibeDateTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSearchInfo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvSearchInfo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCaption;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoAnd;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoOr;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFormatType;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ibeDateTime;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSearchResult;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}