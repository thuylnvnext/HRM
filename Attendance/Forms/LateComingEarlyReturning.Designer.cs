namespace Attendance.Forms
{
    partial class LateComingEarlyReturning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LateComingEarlyReturning));
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.sfdExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.grdLateComingEarlyReturning = new DevExpress.XtraGrid.GridControl();
            this.bgvLateComingEarlyReturning = new Common.CustomBandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbTimeIn = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTimeIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoReasonIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoValidIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoInvalidIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoTimeOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoReasonOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoValidOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoInvalidOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLateComingEarlyReturning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvLateComingEarlyReturning)).BeginInit();
            this.SuspendLayout();
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "Actions-document-preview-icon.png");
            this.imlFunction.Images.SetKeyName(1, "Document-Microsoft-Excel-icon.png");
            this.imlFunction.Images.SetKeyName(2, "layer-save-icon32.png");
            // 
            // sfdExportToExcel
            // 
            this.sfdExportToExcel.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.dedToDate);
            this.pncFilter.Controls.Add(this.lblToDate);
            this.pncFilter.Controls.Add(this.dedFromDate);
            this.pncFilter.Controls.Add(this.lblFromDate);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(994, 36);
            this.pncFilter.TabIndex = 0;
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(220, 8);
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
            this.dedToDate.TabIndex = 3;
            this.dedToDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateEdit_KeyPress);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(160, 12);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Đến ngày";
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(60, 8);
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
            this.dedFromDate.TabIndex = 1;
            this.dedFromDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateEdit_KeyPress);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(8, 12);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // grdLateComingEarlyReturning
            // 
            this.grdLateComingEarlyReturning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLateComingEarlyReturning.Location = new System.Drawing.Point(0, 36);
            this.grdLateComingEarlyReturning.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdLateComingEarlyReturning.MainView = this.bgvLateComingEarlyReturning;
            this.grdLateComingEarlyReturning.Name = "grdLateComingEarlyReturning";
            this.grdLateComingEarlyReturning.Size = new System.Drawing.Size(994, 362);
            this.grdLateComingEarlyReturning.TabIndex = 1;
            this.grdLateComingEarlyReturning.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvLateComingEarlyReturning});
            // 
            // bgvLateComingEarlyReturning
            // 
            this.bgvLateComingEarlyReturning.AllowFilter = false;
            this.bgvLateComingEarlyReturning.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bgvLateComingEarlyReturning.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.Appearance.GroupRow.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.Options.UseBackColor = true;
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.Options.UseTextOptions = true;
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgvLateComingEarlyReturning.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bgvLateComingEarlyReturning.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvLateComingEarlyReturning.AppearancePrint.GroupRow.Options.UseFont = true;
            this.bgvLateComingEarlyReturning.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbDepartmentName,
            this.gridBand1,
            this.grbTimeIn,
            this.gridBand3,
            this.gridBand7});
            this.bgvLateComingEarlyReturning.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoName,
            this.bcoTimeIn,
            this.bcoReasonIn,
            this.bcoValidIn,
            this.bcoInvalidIn,
            this.bcoTimeOut,
            this.bcoReasonOut,
            this.bcoValidOut,
            this.bcoInvalidOut,
            this.bcoNotes});
            this.bgvLateComingEarlyReturning.Data = null;
            this.bgvLateComingEarlyReturning.FixedLineWidth = 1;
            this.bgvLateComingEarlyReturning.GridControl = this.grdLateComingEarlyReturning;
            this.bgvLateComingEarlyReturning.GroupFormat = "[#image]{1} {2}";
            this.bgvLateComingEarlyReturning.HorzScrollStep = 30;
            this.bgvLateComingEarlyReturning.LevelIndent = 0;
            this.bgvLateComingEarlyReturning.Name = "bgvLateComingEarlyReturning";
            this.bgvLateComingEarlyReturning.OptionsCustomization.AllowFilter = false;
            this.bgvLateComingEarlyReturning.OptionsCustomization.AllowGroup = false;
            this.bgvLateComingEarlyReturning.OptionsCustomization.AllowSort = false;
            this.bgvLateComingEarlyReturning.OptionsLayout.Columns.StoreAllOptions = true;
            this.bgvLateComingEarlyReturning.OptionsLayout.Columns.StoreAppearance = true;
            this.bgvLateComingEarlyReturning.OptionsLayout.StoreAllOptions = true;
            this.bgvLateComingEarlyReturning.OptionsLayout.StoreAppearance = true;
            this.bgvLateComingEarlyReturning.OptionsPrint.AutoWidth = false;
            this.bgvLateComingEarlyReturning.OptionsPrint.PrintHeader = false;
            this.bgvLateComingEarlyReturning.OptionsPrint.UsePrintStyles = true;
            this.bgvLateComingEarlyReturning.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvLateComingEarlyReturning.OptionsView.ColumnAutoWidth = false;
            this.bgvLateComingEarlyReturning.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvLateComingEarlyReturning.OptionsView.EnableAppearanceOddRow = true;
            this.bgvLateComingEarlyReturning.OptionsView.ShowAutoFilterRow = true;
            this.bgvLateComingEarlyReturning.OptionsView.ShowColumnHeaders = false;
            this.bgvLateComingEarlyReturning.OptionsView.ShowDetailButtons = false;
            this.bgvLateComingEarlyReturning.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvLateComingEarlyReturning.OptionsView.ShowFooter = true;
            this.bgvLateComingEarlyReturning.OptionsView.ShowGroupPanel = false;
            this.bgvLateComingEarlyReturning.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.bgvLateComingEarlyReturning_CustomSummaryCalculate);
            this.bgvLateComingEarlyReturning.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.bgvLateComingEarlyReturning_RowStyle);
            // 
            // grbNo
            // 
            this.grbNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbNo.AppearanceHeader.Options.UseFont = true;
            this.grbNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grbNo.Caption = "TT";
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
            this.bcoNo.Caption = "TT";
            this.bcoNo.FieldName = "No";
            this.bcoNo.Name = "bcoNo";
            this.bcoNo.OptionsColumn.AllowEdit = false;
            this.bcoNo.OptionsColumn.ReadOnly = true;
            this.bcoNo.Visible = true;
            // 
            // grbDepartmentName
            // 
            this.grbDepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbDepartmentName.AppearanceHeader.Options.UseFont = true;
            this.grbDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDepartmentName.Caption = "Bộ phận";
            this.grbDepartmentName.Name = "grbDepartmentName";
            this.grbDepartmentName.Visible = false;
            this.grbDepartmentName.Width = 75;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Đơn vị";
            this.gridBand1.Columns.Add(this.bcoName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
            // 
            // bcoName
            // 
            this.bcoName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoName.AppearanceHeader.Options.UseFont = true;
            this.bcoName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoName.Caption = "Đơn vị";
            this.bcoName.FieldName = "Name";
            this.bcoName.Name = "bcoName";
            this.bcoName.OptionsColumn.AllowEdit = false;
            this.bcoName.OptionsColumn.ReadOnly = true;
            this.bcoName.Visible = true;
            // 
            // grbTimeIn
            // 
            this.grbTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbTimeIn.AppearanceHeader.Options.UseFont = true;
            this.grbTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.grbTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbTimeIn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grbTimeIn.Caption = "Thời gian đến";
            this.grbTimeIn.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.grbTimeIn.Name = "grbTimeIn";
            this.grbTimeIn.Width = 300;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Giờ";
            this.gridBand2.Columns.Add(this.bcoTimeIn);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 75;
            // 
            // bcoTimeIn
            // 
            this.bcoTimeIn.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTimeIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoTimeIn.AppearanceHeader.Options.UseFont = true;
            this.bcoTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeIn.Caption = "Giờ";
            this.bcoTimeIn.DisplayFormat.FormatString = "HH:mm";
            this.bcoTimeIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoTimeIn.FieldName = "TimeIn";
            this.bcoTimeIn.Name = "bcoTimeIn";
            this.bcoTimeIn.OptionsColumn.AllowEdit = false;
            this.bcoTimeIn.OptionsColumn.ReadOnly = true;
            this.bcoTimeIn.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Lý do";
            this.gridBand4.Columns.Add(this.bcoReasonIn);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 75;
            // 
            // bcoReasonIn
            // 
            this.bcoReasonIn.AppearanceCell.Options.UseTextOptions = true;
            this.bcoReasonIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoReasonIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoReasonIn.AppearanceHeader.Options.UseFont = true;
            this.bcoReasonIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoReasonIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoReasonIn.Caption = "Lý do";
            this.bcoReasonIn.FieldName = "ReasonIn";
            this.bcoReasonIn.Name = "bcoReasonIn";
            this.bcoReasonIn.OptionsColumn.AllowEdit = false;
            this.bcoReasonIn.OptionsColumn.ReadOnly = true;
            this.bcoReasonIn.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand5.Caption = "Hợp lệ";
            this.gridBand5.Columns.Add(this.bcoValidIn);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 75;
            // 
            // bcoValidIn
            // 
            this.bcoValidIn.AppearanceCell.Options.UseTextOptions = true;
            this.bcoValidIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoValidIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoValidIn.AppearanceHeader.Options.UseFont = true;
            this.bcoValidIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoValidIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoValidIn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bcoValidIn.Caption = "Hợp lệ";
            this.bcoValidIn.FieldName = "ValidIn";
            this.bcoValidIn.Name = "bcoValidIn";
            this.bcoValidIn.OptionsColumn.AllowEdit = false;
            this.bcoValidIn.OptionsColumn.ReadOnly = true;
            this.bcoValidIn.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand6.Caption = "Không hợp lệ";
            this.gridBand6.Columns.Add(this.bcoInvalidIn);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.RowCount = 2;
            this.gridBand6.Width = 75;
            // 
            // bcoInvalidIn
            // 
            this.bcoInvalidIn.AppearanceCell.Options.UseTextOptions = true;
            this.bcoInvalidIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoInvalidIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoInvalidIn.AppearanceHeader.Options.UseFont = true;
            this.bcoInvalidIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoInvalidIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoInvalidIn.Caption = "Không hợp lệ";
            this.bcoInvalidIn.FieldName = "InvalidIn";
            this.bcoInvalidIn.Name = "bcoInvalidIn";
            this.bcoInvalidIn.OptionsColumn.AllowEdit = false;
            this.bcoInvalidIn.OptionsColumn.ReadOnly = true;
            this.bcoInvalidIn.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand3.Caption = "Thời gian về";
            this.gridBand3.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand8,
            this.gridBand9,
            this.gridBand10,
            this.gridBand11});
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 300;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Giờ";
            this.gridBand8.Columns.Add(this.bcoTimeOut);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Width = 75;
            // 
            // bcoTimeOut
            // 
            this.bcoTimeOut.AppearanceCell.Options.UseTextOptions = true;
            this.bcoTimeOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoTimeOut.AppearanceHeader.Options.UseFont = true;
            this.bcoTimeOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoTimeOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoTimeOut.Caption = "Giờ";
            this.bcoTimeOut.DisplayFormat.FormatString = "HH:mm";
            this.bcoTimeOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoTimeOut.FieldName = "TimeOut";
            this.bcoTimeOut.Name = "bcoTimeOut";
            this.bcoTimeOut.OptionsColumn.AllowEdit = false;
            this.bcoTimeOut.OptionsColumn.ReadOnly = true;
            this.bcoTimeOut.Visible = true;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand9.AppearanceHeader.Options.UseFont = true;
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "Lý do";
            this.gridBand9.Columns.Add(this.bcoReasonOut);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Width = 75;
            // 
            // bcoReasonOut
            // 
            this.bcoReasonOut.AppearanceCell.Options.UseTextOptions = true;
            this.bcoReasonOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoReasonOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoReasonOut.AppearanceHeader.Options.UseFont = true;
            this.bcoReasonOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoReasonOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoReasonOut.Caption = "Lý do";
            this.bcoReasonOut.FieldName = "ReasonOut";
            this.bcoReasonOut.Name = "bcoReasonOut";
            this.bcoReasonOut.OptionsColumn.AllowEdit = false;
            this.bcoReasonOut.OptionsColumn.ReadOnly = true;
            this.bcoReasonOut.Visible = true;
            // 
            // gridBand10
            // 
            this.gridBand10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand10.AppearanceHeader.Options.UseFont = true;
            this.gridBand10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand10.Caption = "Hợp lệ";
            this.gridBand10.Columns.Add(this.bcoValidOut);
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.Width = 75;
            // 
            // bcoValidOut
            // 
            this.bcoValidOut.AppearanceCell.Options.UseTextOptions = true;
            this.bcoValidOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoValidOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoValidOut.AppearanceHeader.Options.UseFont = true;
            this.bcoValidOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoValidOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoValidOut.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bcoValidOut.Caption = "Hợp lệ";
            this.bcoValidOut.FieldName = "ValidOut";
            this.bcoValidOut.Name = "bcoValidOut";
            this.bcoValidOut.OptionsColumn.AllowEdit = false;
            this.bcoValidOut.OptionsColumn.ReadOnly = true;
            this.bcoValidOut.Visible = true;
            // 
            // gridBand11
            // 
            this.gridBand11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand11.AppearanceHeader.Options.UseFont = true;
            this.gridBand11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand11.Caption = "Không hợp lệ";
            this.gridBand11.Columns.Add(this.bcoInvalidOut);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.Width = 75;
            // 
            // bcoInvalidOut
            // 
            this.bcoInvalidOut.AppearanceCell.Options.UseTextOptions = true;
            this.bcoInvalidOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoInvalidOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoInvalidOut.AppearanceHeader.Options.UseFont = true;
            this.bcoInvalidOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoInvalidOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoInvalidOut.Caption = "Không hợp lệ";
            this.bcoInvalidOut.FieldName = "InvalidOut";
            this.bcoInvalidOut.Name = "bcoInvalidOut";
            this.bcoInvalidOut.OptionsColumn.AllowEdit = false;
            this.bcoInvalidOut.OptionsColumn.ReadOnly = true;
            this.bcoInvalidOut.Visible = true;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Ghi chú";
            this.gridBand7.Columns.Add(this.bcoNotes);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.Width = 75;
            // 
            // bcoNotes
            // 
            this.bcoNotes.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoNotes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNotes.AppearanceHeader.Options.UseFont = true;
            this.bcoNotes.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNotes.Caption = "Ghi chú";
            this.bcoNotes.FieldName = "Notes";
            this.bcoNotes.Name = "bcoNotes";
            this.bcoNotes.Visible = true;
            // 
            // LateComingEarlyReturning
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 398);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdLateComingEarlyReturning);
            this.KeyPreview = true;
            this.Name = "LateComingEarlyReturning";
            this.Text = "Báo cáo đi muộn, về sớm";
            this.Load += new System.EventHandler(this.LateComingEarlyReturning_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LateComingEarlyReturning_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLateComingEarlyReturning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvLateComingEarlyReturning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlFunction;
        private System.Windows.Forms.SaveFileDialog sfdExportToExcel;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        protected DevExpress.XtraEditors.DateEdit dedFromDate;
        protected System.Windows.Forms.Label lblFromDate;
        private DevExpress.XtraGrid.GridControl grdLateComingEarlyReturning;
        protected Common.CustomBandedGridView bgvLateComingEarlyReturning;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDepartmentName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTimeIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoTimeOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoReasonIn;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoValidIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoInvalidIn;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private System.Windows.Forms.Label lblToDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbTimeIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoReasonOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoValidOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoInvalidOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNotes;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;

    }
}
