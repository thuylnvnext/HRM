namespace Common.Forms
{
    partial class StatisticItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticItem));
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.grdStatisticItem = new DevExpress.XtraGrid.GridControl();
            this.bgvStatisticItem = new Common.CustomBandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.icbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.sfdExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.dedWorkingDay = new DevExpress.XtraEditors.DateEdit();
            this.lblWorkingDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStatisticItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvStatisticItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            this.imlGroup.Images.SetKeyName(1, "Actions-zoom-fit-width-icon.png");
            // 
            // grdStatisticItem
            // 
            this.grdStatisticItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStatisticItem.Location = new System.Drawing.Point(0, 36);
            this.grdStatisticItem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdStatisticItem.MainView = this.bgvStatisticItem;
            this.grdStatisticItem.Name = "grdStatisticItem";
            this.grdStatisticItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.icbGroup});
            this.grdStatisticItem.Size = new System.Drawing.Size(994, 362);
            this.grdStatisticItem.TabIndex = 0;
            this.grdStatisticItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvStatisticItem});
            // 
            // bgvStatisticItem
            // 
            this.bgvStatisticItem.AllowFilter = false;
            this.bgvStatisticItem.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bgvStatisticItem.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvStatisticItem.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvStatisticItem.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.Appearance.GroupRow.Options.UseFont = true;
            this.bgvStatisticItem.AppearancePrint.BandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bgvStatisticItem.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.AppearancePrint.BandPanel.Options.UseBackColor = true;
            this.bgvStatisticItem.AppearancePrint.BandPanel.Options.UseFont = true;
            this.bgvStatisticItem.AppearancePrint.BandPanel.Options.UseTextOptions = true;
            this.bgvStatisticItem.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgvStatisticItem.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bgvStatisticItem.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.bgvStatisticItem.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.bgvStatisticItem.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvStatisticItem.AppearancePrint.GroupRow.Options.UseFont = true;
            this.bgvStatisticItem.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbDepartmentName});
            this.bgvStatisticItem.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoDepartmentName});
            this.bgvStatisticItem.Data = null;
            this.bgvStatisticItem.FixedLineWidth = 1;
            this.bgvStatisticItem.GridControl = this.grdStatisticItem;
            this.bgvStatisticItem.GroupCount = 1;
            this.bgvStatisticItem.HorzScrollStep = 30;
            this.bgvStatisticItem.LevelIndent = 0;
            this.bgvStatisticItem.Name = "bgvStatisticItem";
            this.bgvStatisticItem.OptionsCustomization.AllowFilter = false;
            this.bgvStatisticItem.OptionsCustomization.AllowGroup = false;
            this.bgvStatisticItem.OptionsCustomization.AllowSort = false;
            this.bgvStatisticItem.OptionsLayout.Columns.StoreAllOptions = true;
            this.bgvStatisticItem.OptionsLayout.Columns.StoreAppearance = true;
            this.bgvStatisticItem.OptionsLayout.StoreAllOptions = true;
            this.bgvStatisticItem.OptionsLayout.StoreAppearance = true;
            this.bgvStatisticItem.OptionsPrint.AutoWidth = false;
            this.bgvStatisticItem.OptionsPrint.PrintHeader = false;
            this.bgvStatisticItem.OptionsPrint.UsePrintStyles = true;
            this.bgvStatisticItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvStatisticItem.OptionsView.ColumnAutoWidth = false;
            this.bgvStatisticItem.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvStatisticItem.OptionsView.EnableAppearanceOddRow = true;
            this.bgvStatisticItem.OptionsView.ShowAutoFilterRow = true;
            this.bgvStatisticItem.OptionsView.ShowColumnHeaders = false;
            this.bgvStatisticItem.OptionsView.ShowDetailButtons = false;
            this.bgvStatisticItem.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvStatisticItem.OptionsView.ShowFooter = true;
            this.bgvStatisticItem.OptionsView.ShowGroupPanel = false;
            this.bgvStatisticItem.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bcoDepartmentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bgvStatisticItem.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvStatisticItem_CustomUnboundColumnData);
            // 
            // grbNo
            // 
            this.grbNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbNo.AppearanceHeader.Options.UseFont = true;
            this.grbNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
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
            this.bcoNo.OptionsColumn.ReadOnly = true;
            this.bcoNo.SummaryItem.DisplayFormat = "Total:";
            this.bcoNo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoNo.Visible = true;
            // 
            // grbDepartmentName
            // 
            this.grbDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.grbDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDepartmentName.Caption = "Bộ phận";
            this.grbDepartmentName.Columns.Add(this.bcoDepartmentName);
            this.grbDepartmentName.Name = "grbDepartmentName";
            this.grbDepartmentName.Visible = false;
            this.grbDepartmentName.Width = 75;
            // 
            // bcoDepartmentName
            // 
            this.bcoDepartmentName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoDepartmentName.AppearanceCell.Options.UseFont = true;
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
            // sfdExportToExcel
            // 
            this.sfdExportToExcel.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "Actions-document-preview-icon.png");
            this.imlFunction.Images.SetKeyName(1, "Document-Microsoft-Excel-icon.png");
            this.imlFunction.Images.SetKeyName(2, "layer-save-icon32.png");
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.dedWorkingDay);
            this.pncFilter.Controls.Add(this.lblWorkingDay);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(994, 36);
            this.pncFilter.TabIndex = 0;
            // 
            // dedWorkingDay
            // 
            this.dedWorkingDay.EditValue = null;
            this.dedWorkingDay.Location = new System.Drawing.Point(60, 8);
            this.dedWorkingDay.Name = "dedWorkingDay";
            this.dedWorkingDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedWorkingDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedWorkingDay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedWorkingDay.Size = new System.Drawing.Size(80, 20);
            this.dedWorkingDay.TabIndex = 1;
            // 
            // lblWorkingDay
            // 
            this.lblWorkingDay.AutoSize = true;
            this.lblWorkingDay.Location = new System.Drawing.Point(8, 12);
            this.lblWorkingDay.Name = "lblWorkingDay";
            this.lblWorkingDay.Size = new System.Drawing.Size(47, 13);
            this.lblWorkingDay.TabIndex = 0;
            this.lblWorkingDay.Text = "Từ ngày";
            // 
            // StatisticItem
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 398);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdStatisticItem);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "StatisticItem";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.StatisticItem_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticItem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdStatisticItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvStatisticItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        internal System.Windows.Forms.ImageList imlGroup;
        private System.Windows.Forms.SaveFileDialog sfdExportToExcel;
        internal System.Windows.Forms.ImageList imlFunction;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        protected CustomBandedGridView bgvStatisticItem;
        private DevExpress.XtraGrid.GridControl grdStatisticItem;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDepartmentName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbGroup;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDepartmentName;
        protected DevExpress.XtraEditors.DateEdit dedWorkingDay;
        protected System.Windows.Forms.Label lblWorkingDay;

    }
}
