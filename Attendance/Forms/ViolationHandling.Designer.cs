namespace Attendance.Forms
{
    partial class ViolationHandling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViolationHandling));
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.sfdExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.grdViolationHandling = new DevExpress.XtraGrid.GridControl();
            this.bgvViolationHandling = new Common.CustomBandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbNumberOfEmployees = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNumberOfTimes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoDaysForViolation = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoIndividual = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCollective = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViolationHandling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvViolationHandling)).BeginInit();
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
            // grdViolationHandling
            // 
            this.grdViolationHandling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdViolationHandling.Location = new System.Drawing.Point(0, 36);
            this.grdViolationHandling.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdViolationHandling.MainView = this.bgvViolationHandling;
            this.grdViolationHandling.Name = "grdViolationHandling";
            this.grdViolationHandling.Size = new System.Drawing.Size(994, 362);
            this.grdViolationHandling.TabIndex = 1;
            this.grdViolationHandling.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvViolationHandling});
            // 
            // bgvViolationHandling
            // 
            this.bgvViolationHandling.AllowFilter = false;
            this.bgvViolationHandling.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bgvViolationHandling.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvViolationHandling.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvViolationHandling.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.Appearance.GroupRow.Options.UseFont = true;
            this.bgvViolationHandling.AppearancePrint.BandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bgvViolationHandling.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.AppearancePrint.BandPanel.Options.UseBackColor = true;
            this.bgvViolationHandling.AppearancePrint.BandPanel.Options.UseFont = true;
            this.bgvViolationHandling.AppearancePrint.BandPanel.Options.UseTextOptions = true;
            this.bgvViolationHandling.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgvViolationHandling.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bgvViolationHandling.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.bgvViolationHandling.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.bgvViolationHandling.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvViolationHandling.AppearancePrint.GroupRow.Options.UseFont = true;
            this.bgvViolationHandling.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbDepartmentName,
            this.gridBand1,
            this.grbNumberOfEmployees,
            this.gridBand3,
            this.gridBand5,
            this.gridBand7});
            this.bgvViolationHandling.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoName,
            this.bcoNumberOfTimes,
            this.bcoDaysForViolation,
            this.bcoIndividual,
            this.bcoCollective,
            this.bcoNotes});
            this.bgvViolationHandling.Data = null;
            this.bgvViolationHandling.FixedLineWidth = 1;
            this.bgvViolationHandling.GridControl = this.grdViolationHandling;
            this.bgvViolationHandling.GroupFormat = "[#image]{1} {2}";
            this.bgvViolationHandling.HorzScrollStep = 30;
            this.bgvViolationHandling.LevelIndent = 0;
            this.bgvViolationHandling.Name = "bgvViolationHandling";
            this.bgvViolationHandling.OptionsCustomization.AllowFilter = false;
            this.bgvViolationHandling.OptionsCustomization.AllowGroup = false;
            this.bgvViolationHandling.OptionsCustomization.AllowSort = false;
            this.bgvViolationHandling.OptionsLayout.Columns.StoreAllOptions = true;
            this.bgvViolationHandling.OptionsLayout.Columns.StoreAppearance = true;
            this.bgvViolationHandling.OptionsLayout.StoreAllOptions = true;
            this.bgvViolationHandling.OptionsLayout.StoreAppearance = true;
            this.bgvViolationHandling.OptionsPrint.AutoWidth = false;
            this.bgvViolationHandling.OptionsPrint.PrintHeader = false;
            this.bgvViolationHandling.OptionsPrint.UsePrintStyles = true;
            this.bgvViolationHandling.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvViolationHandling.OptionsView.ColumnAutoWidth = false;
            this.bgvViolationHandling.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvViolationHandling.OptionsView.EnableAppearanceOddRow = true;
            this.bgvViolationHandling.OptionsView.ShowAutoFilterRow = true;
            this.bgvViolationHandling.OptionsView.ShowColumnHeaders = false;
            this.bgvViolationHandling.OptionsView.ShowDetailButtons = false;
            this.bgvViolationHandling.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvViolationHandling.OptionsView.ShowFooter = true;
            this.bgvViolationHandling.OptionsView.ShowGroupPanel = false;
            this.bgvViolationHandling.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.bgvViolationHandling_CustomSummaryCalculate);
            this.bgvViolationHandling.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.bgvViolationHandling_RowStyle);
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
            // grbNumberOfEmployees
            // 
            this.grbNumberOfEmployees.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbNumberOfEmployees.AppearanceHeader.Options.UseFont = true;
            this.grbNumberOfEmployees.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNumberOfEmployees.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNumberOfEmployees.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grbNumberOfEmployees.Caption = "Số lần vi phạm";
            this.grbNumberOfEmployees.Columns.Add(this.bcoNumberOfTimes);
            this.grbNumberOfEmployees.Name = "grbNumberOfEmployees";
            this.grbNumberOfEmployees.RowCount = 2;
            this.grbNumberOfEmployees.Width = 75;
            // 
            // bcoNumberOfTimes
            // 
            this.bcoNumberOfTimes.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNumberOfTimes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoNumberOfTimes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoNumberOfTimes.AppearanceHeader.Options.UseFont = true;
            this.bcoNumberOfTimes.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNumberOfTimes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNumberOfTimes.Caption = "Số lần vi phạm";
            this.bcoNumberOfTimes.FieldName = "NumberOfTimes";
            this.bcoNumberOfTimes.Name = "bcoNumberOfTimes";
            this.bcoNumberOfTimes.OptionsColumn.AllowEdit = false;
            this.bcoNumberOfTimes.OptionsColumn.ReadOnly = true;
            this.bcoNumberOfTimes.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand3.Caption = "Các ngày vi phạm";
            this.gridBand3.Columns.Add(this.bcoDaysForViolation);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 75;
            // 
            // bcoDaysForViolation
            // 
            this.bcoDaysForViolation.AppearanceCell.Options.UseTextOptions = true;
            this.bcoDaysForViolation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoDaysForViolation.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bcoDaysForViolation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoDaysForViolation.AppearanceHeader.Options.UseFont = true;
            this.bcoDaysForViolation.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoDaysForViolation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoDaysForViolation.Caption = "Các ngày vi phạm";
            this.bcoDaysForViolation.FieldName = "DaysForViolation";
            this.bcoDaysForViolation.Name = "bcoDaysForViolation";
            this.bcoDaysForViolation.OptionsColumn.AllowEdit = false;
            this.bcoDaysForViolation.OptionsColumn.ReadOnly = true;
            this.bcoDaysForViolation.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand5.Caption = "Chế tài xử lý";
            this.gridBand5.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand6});
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand2.Caption = "Cá nhân";
            this.gridBand2.Columns.Add(this.bcoIndividual);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 75;
            // 
            // bcoIndividual
            // 
            this.bcoIndividual.AppearanceCell.Options.UseTextOptions = true;
            this.bcoIndividual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoIndividual.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoIndividual.AppearanceHeader.Options.UseFont = true;
            this.bcoIndividual.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoIndividual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoIndividual.Caption = "Cá nhân";
            this.bcoIndividual.FieldName = "Individual";
            this.bcoIndividual.Name = "bcoIndividual";
            this.bcoIndividual.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Tập thể";
            this.gridBand6.Columns.Add(this.bcoCollective);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 75;
            // 
            // bcoCollective
            // 
            this.bcoCollective.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCollective.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoCollective.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoCollective.AppearanceHeader.Options.UseFont = true;
            this.bcoCollective.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCollective.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCollective.Caption = "Tập thể";
            this.bcoCollective.FieldName = "Collective";
            this.bcoCollective.Name = "bcoCollective";
            this.bcoCollective.Visible = true;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
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
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Ô";
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Width = 75;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand9.AppearanceHeader.Options.UseFont = true;
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "KL";
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Width = 75;
            // 
            // gridBand10
            // 
            this.gridBand10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand10.AppearanceHeader.Options.UseFont = true;
            this.gridBand10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand10.Caption = "CT";
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.Width = 75;
            // 
            // gridBand11
            // 
            this.gridBand11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand11.AppearanceHeader.Options.UseFont = true;
            this.gridBand11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand11.Caption = "Không chấm";
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.RowCount = 2;
            this.gridBand11.Width = 75;
            // 
            // gridBand12
            // 
            this.gridBand12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand12.AppearanceHeader.Options.UseFont = true;
            this.gridBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand12.Caption = "Khác";
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.Width = 75;
            // 
            // ViolationHandling
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 398);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdViolationHandling);
            this.KeyPreview = true;
            this.Name = "ViolationHandling";
            this.Text = "Xử lý vi phạm";
            this.Load += new System.EventHandler(this.ViolationHandling_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViolationHandling_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViolationHandling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvViolationHandling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlFunction;
        private System.Windows.Forms.SaveFileDialog sfdExportToExcel;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        protected DevExpress.XtraEditors.DateEdit dedFromDate;
        protected System.Windows.Forms.Label lblFromDate;
        private DevExpress.XtraGrid.GridControl grdViolationHandling;
        protected Common.CustomBandedGridView bgvViolationHandling;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDepartmentName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNumberOfTimes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoDaysForViolation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoIndividual;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNotes;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNumberOfEmployees;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCollective;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private System.Windows.Forms.Label lblToDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;

    }
}
