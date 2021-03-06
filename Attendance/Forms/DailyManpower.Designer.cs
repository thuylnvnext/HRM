namespace Attendance.Forms
{
    partial class DailyManpower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyManpower));
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.sfdExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.cboForm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblForm = new System.Windows.Forms.Label();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.grdDailyManpower = new DevExpress.XtraGrid.GridControl();
            this.bgvDailyManpower = new Common.CustomBandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbDepartmentName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbNumberOfEmployees = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNumberOfEmployees = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoPresent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoAbsent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoAnnual = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoMaternity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSick = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoUnpaid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoBusiness = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNonPresent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoOther = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDailyManpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvDailyManpower)).BeginInit();
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
            this.pncFilter.Controls.Add(this.cboForm);
            this.pncFilter.Controls.Add(this.lblForm);
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
            // cboForm
            // 
            this.cboForm.Location = new System.Drawing.Point(364, 8);
            this.cboForm.Name = "cboForm";
            this.cboForm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboForm.Properties.Items.AddRange(new object[] {
            "02A",
            "02B"});
            this.cboForm.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboForm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboForm.Size = new System.Drawing.Size(44, 20);
            this.cboForm.TabIndex = 5;
            this.cboForm.SelectedIndexChanged += new System.EventHandler(this.cboForm_SelectedIndexChanged);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Location = new System.Drawing.Point(332, 12);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(27, 13);
            this.lblForm.TabIndex = 4;
            this.lblForm.Text = "Mẫu";
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
            // grdDailyManpower
            // 
            this.grdDailyManpower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDailyManpower.Location = new System.Drawing.Point(0, 36);
            this.grdDailyManpower.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDailyManpower.MainView = this.bgvDailyManpower;
            this.grdDailyManpower.Name = "grdDailyManpower";
            this.grdDailyManpower.Size = new System.Drawing.Size(994, 362);
            this.grdDailyManpower.TabIndex = 1;
            this.grdDailyManpower.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvDailyManpower});
            // 
            // bgvDailyManpower
            // 
            this.bgvDailyManpower.AllowFilter = false;
            this.bgvDailyManpower.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bgvDailyManpower.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvDailyManpower.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvDailyManpower.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.Appearance.GroupRow.Options.UseFont = true;
            this.bgvDailyManpower.AppearancePrint.BandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bgvDailyManpower.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.AppearancePrint.BandPanel.Options.UseBackColor = true;
            this.bgvDailyManpower.AppearancePrint.BandPanel.Options.UseFont = true;
            this.bgvDailyManpower.AppearancePrint.BandPanel.Options.UseTextOptions = true;
            this.bgvDailyManpower.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgvDailyManpower.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bgvDailyManpower.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.bgvDailyManpower.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.bgvDailyManpower.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bgvDailyManpower.AppearancePrint.GroupRow.Options.UseFont = true;
            this.bgvDailyManpower.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbDepartmentName,
            this.gridBand1,
            this.grbNumberOfEmployees,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand7});
            this.bgvDailyManpower.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoName,
            this.bcoNumberOfEmployees,
            this.bcoPresent,
            this.bcoAbsent,
            this.bcoAnnual,
            this.bcoMaternity,
            this.bcoSick,
            this.bcoUnpaid,
            this.bcoBusiness,
            this.bcoNonPresent,
            this.bcoOther,
            this.bcoNotes});
            this.bgvDailyManpower.Data = null;
            this.bgvDailyManpower.FixedLineWidth = 1;
            this.bgvDailyManpower.GridControl = this.grdDailyManpower;
            this.bgvDailyManpower.GroupFormat = "[#image]{1} {2}";
            this.bgvDailyManpower.HorzScrollStep = 30;
            this.bgvDailyManpower.LevelIndent = 0;
            this.bgvDailyManpower.Name = "bgvDailyManpower";
            this.bgvDailyManpower.OptionsCustomization.AllowFilter = false;
            this.bgvDailyManpower.OptionsCustomization.AllowGroup = false;
            this.bgvDailyManpower.OptionsCustomization.AllowSort = false;
            this.bgvDailyManpower.OptionsLayout.Columns.StoreAllOptions = true;
            this.bgvDailyManpower.OptionsLayout.Columns.StoreAppearance = true;
            this.bgvDailyManpower.OptionsLayout.StoreAllOptions = true;
            this.bgvDailyManpower.OptionsLayout.StoreAppearance = true;
            this.bgvDailyManpower.OptionsPrint.AutoWidth = false;
            this.bgvDailyManpower.OptionsPrint.PrintHeader = false;
            this.bgvDailyManpower.OptionsPrint.UsePrintStyles = true;
            this.bgvDailyManpower.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvDailyManpower.OptionsView.ColumnAutoWidth = false;
            this.bgvDailyManpower.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvDailyManpower.OptionsView.EnableAppearanceOddRow = true;
            this.bgvDailyManpower.OptionsView.ShowAutoFilterRow = true;
            this.bgvDailyManpower.OptionsView.ShowColumnHeaders = false;
            this.bgvDailyManpower.OptionsView.ShowDetailButtons = false;
            this.bgvDailyManpower.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.bgvDailyManpower.OptionsView.ShowFooter = true;
            this.bgvDailyManpower.OptionsView.ShowGroupPanel = false;
            this.bgvDailyManpower.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.bgvDailyManpower_CustomSummaryCalculate);
            this.bgvDailyManpower.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.bgvDailyManpower_RowStyle);
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
            this.grbNumberOfEmployees.Caption = "Tổng quân số";
            this.grbNumberOfEmployees.Columns.Add(this.bcoNumberOfEmployees);
            this.grbNumberOfEmployees.Name = "grbNumberOfEmployees";
            this.grbNumberOfEmployees.RowCount = 2;
            this.grbNumberOfEmployees.Width = 75;
            // 
            // bcoNumberOfEmployees
            // 
            this.bcoNumberOfEmployees.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNumberOfEmployees.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoNumberOfEmployees.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoNumberOfEmployees.AppearanceHeader.Options.UseFont = true;
            this.bcoNumberOfEmployees.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNumberOfEmployees.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNumberOfEmployees.Caption = "Tổng quân số";
            this.bcoNumberOfEmployees.FieldName = "NumberOfEmployees";
            this.bcoNumberOfEmployees.Name = "bcoNumberOfEmployees";
            this.bcoNumberOfEmployees.OptionsColumn.AllowEdit = false;
            this.bcoNumberOfEmployees.OptionsColumn.ReadOnly = true;
            this.bcoNumberOfEmployees.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoNumberOfEmployees.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand3.Caption = "Có mặt";
            this.gridBand3.Columns.Add(this.bcoPresent);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 75;
            // 
            // bcoPresent
            // 
            this.bcoPresent.AppearanceCell.Options.UseTextOptions = true;
            this.bcoPresent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoPresent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoPresent.AppearanceHeader.Options.UseFont = true;
            this.bcoPresent.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoPresent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoPresent.Caption = "Có mặt";
            this.bcoPresent.FieldName = "Present";
            this.bcoPresent.Name = "bcoPresent";
            this.bcoPresent.OptionsColumn.AllowEdit = false;
            this.bcoPresent.OptionsColumn.ReadOnly = true;
            this.bcoPresent.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoPresent.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand4.Caption = "Vắng mặt";
            this.gridBand4.Columns.Add(this.bcoAbsent);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 75;
            // 
            // bcoAbsent
            // 
            this.bcoAbsent.AppearanceCell.Options.UseTextOptions = true;
            this.bcoAbsent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoAbsent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoAbsent.AppearanceHeader.Options.UseFont = true;
            this.bcoAbsent.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoAbsent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoAbsent.Caption = "Vắng mặt";
            this.bcoAbsent.FieldName = "Absent";
            this.bcoAbsent.Name = "bcoAbsent";
            this.bcoAbsent.OptionsColumn.AllowEdit = false;
            this.bcoAbsent.OptionsColumn.ReadOnly = true;
            this.bcoAbsent.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoAbsent.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand5.Caption = "Trong đó";
            this.gridBand5.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand6,
            this.gridBand8,
            this.gridBand9,
            this.gridBand10,
            this.gridBand11,
            this.gridBand12});
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 525;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand2.Caption = "P";
            this.gridBand2.Columns.Add(this.bcoAnnual);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 75;
            // 
            // bcoAnnual
            // 
            this.bcoAnnual.AppearanceCell.Options.UseTextOptions = true;
            this.bcoAnnual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoAnnual.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoAnnual.AppearanceHeader.Options.UseFont = true;
            this.bcoAnnual.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoAnnual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoAnnual.Caption = "P";
            this.bcoAnnual.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoAnnual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoAnnual.FieldName = "Annual";
            this.bcoAnnual.Name = "bcoAnnual";
            this.bcoAnnual.OptionsColumn.AllowEdit = false;
            this.bcoAnnual.OptionsColumn.ReadOnly = true;
            this.bcoAnnual.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoAnnual.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "TS";
            this.gridBand6.Columns.Add(this.bcoMaternity);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 75;
            // 
            // bcoMaternity
            // 
            this.bcoMaternity.AppearanceCell.Options.UseTextOptions = true;
            this.bcoMaternity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoMaternity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoMaternity.AppearanceHeader.Options.UseFont = true;
            this.bcoMaternity.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoMaternity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoMaternity.Caption = "TS";
            this.bcoMaternity.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoMaternity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoMaternity.FieldName = "Maternity";
            this.bcoMaternity.Name = "bcoMaternity";
            this.bcoMaternity.OptionsColumn.AllowEdit = false;
            this.bcoMaternity.OptionsColumn.ReadOnly = true;
            this.bcoMaternity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoMaternity.Visible = true;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Ô";
            this.gridBand8.Columns.Add(this.bcoSick);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Width = 75;
            // 
            // bcoSick
            // 
            this.bcoSick.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSick.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoSick.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoSick.AppearanceHeader.Options.UseFont = true;
            this.bcoSick.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSick.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSick.Caption = "Ô";
            this.bcoSick.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoSick.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoSick.FieldName = "Sick";
            this.bcoSick.Name = "bcoSick";
            this.bcoSick.OptionsColumn.AllowEdit = false;
            this.bcoSick.OptionsColumn.ReadOnly = true;
            this.bcoSick.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoSick.Visible = true;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand9.AppearanceHeader.Options.UseFont = true;
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "KL";
            this.gridBand9.Columns.Add(this.bcoUnpaid);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Width = 75;
            // 
            // bcoUnpaid
            // 
            this.bcoUnpaid.AppearanceCell.Options.UseTextOptions = true;
            this.bcoUnpaid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoUnpaid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoUnpaid.AppearanceHeader.Options.UseFont = true;
            this.bcoUnpaid.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoUnpaid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoUnpaid.Caption = "KL";
            this.bcoUnpaid.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoUnpaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoUnpaid.FieldName = "Unpaid";
            this.bcoUnpaid.Name = "bcoUnpaid";
            this.bcoUnpaid.OptionsColumn.AllowEdit = false;
            this.bcoUnpaid.OptionsColumn.ReadOnly = true;
            this.bcoUnpaid.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoUnpaid.Visible = true;
            // 
            // gridBand10
            // 
            this.gridBand10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand10.AppearanceHeader.Options.UseFont = true;
            this.gridBand10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand10.Caption = "CT";
            this.gridBand10.Columns.Add(this.bcoBusiness);
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.Width = 75;
            // 
            // bcoBusiness
            // 
            this.bcoBusiness.AppearanceCell.Options.UseTextOptions = true;
            this.bcoBusiness.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoBusiness.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoBusiness.AppearanceHeader.Options.UseFont = true;
            this.bcoBusiness.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoBusiness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoBusiness.Caption = "CT";
            this.bcoBusiness.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoBusiness.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoBusiness.FieldName = "Business";
            this.bcoBusiness.Name = "bcoBusiness";
            this.bcoBusiness.OptionsColumn.AllowEdit = false;
            this.bcoBusiness.OptionsColumn.ReadOnly = true;
            this.bcoBusiness.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.bcoBusiness.Visible = true;
            // 
            // gridBand11
            // 
            this.gridBand11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand11.AppearanceHeader.Options.UseFont = true;
            this.gridBand11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand11.Caption = "Không chấm";
            this.gridBand11.Columns.Add(this.bcoNonPresent);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.RowCount = 2;
            this.gridBand11.Width = 75;
            // 
            // bcoNonPresent
            // 
            this.bcoNonPresent.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNonPresent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoNonPresent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNonPresent.AppearanceHeader.Options.UseFont = true;
            this.bcoNonPresent.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNonPresent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNonPresent.Caption = "Không chấm";
            this.bcoNonPresent.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoNonPresent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoNonPresent.FieldName = "NonPresent";
            this.bcoNonPresent.Name = "bcoNonPresent";
            this.bcoNonPresent.OptionsColumn.AllowEdit = false;
            this.bcoNonPresent.OptionsColumn.ReadOnly = true;
            this.bcoNonPresent.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoNonPresent.Visible = true;
            // 
            // gridBand12
            // 
            this.gridBand12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand12.AppearanceHeader.Options.UseFont = true;
            this.gridBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand12.Caption = "Khác";
            this.gridBand12.Columns.Add(this.bcoOther);
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.Width = 75;
            // 
            // bcoOther
            // 
            this.bcoOther.AppearanceCell.Options.UseTextOptions = true;
            this.bcoOther.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoOther.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoOther.AppearanceHeader.Options.UseFont = true;
            this.bcoOther.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoOther.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoOther.Caption = "Khác";
            this.bcoOther.DisplayFormat.FormatString = "#,##0.#;; ";
            this.bcoOther.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bcoOther.FieldName = "Other";
            this.bcoOther.Name = "bcoOther";
            this.bcoOther.OptionsColumn.AllowEdit = false;
            this.bcoOther.OptionsColumn.ReadOnly = true;
            this.bcoOther.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.bcoOther.Visible = true;
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
            this.bcoNotes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bcoNotes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNotes.AppearanceHeader.Options.UseFont = true;
            this.bcoNotes.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNotes.Caption = "Ghi chú";
            this.bcoNotes.FieldName = "Notes";
            this.bcoNotes.Name = "bcoNotes";
            this.bcoNotes.OptionsColumn.AllowEdit = false;
            this.bcoNotes.OptionsColumn.ReadOnly = true;
            this.bcoNotes.Visible = true;
            // 
            // DailyManpower
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 398);
            this.Controls.Add(this.pncFilter);
            this.Controls.Add(this.grdDailyManpower);
            this.KeyPreview = true;
            this.Name = "DailyManpower";
            this.Text = "Báo cáo nhân lực hàng ngày";
            this.Load += new System.EventHandler(this.DailyManpower_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyManpower_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDailyManpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvDailyManpower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlFunction;
        private System.Windows.Forms.SaveFileDialog sfdExportToExcel;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        protected DevExpress.XtraEditors.DateEdit dedFromDate;
        protected System.Windows.Forms.Label lblFromDate;
        private DevExpress.XtraGrid.GridControl grdDailyManpower;
        protected Common.CustomBandedGridView bgvDailyManpower;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDepartmentName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNumberOfEmployees;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoPresent;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoAbsent;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNotes;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNumberOfEmployees;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoAnnual;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoMaternity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSick;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoUnpaid;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private System.Windows.Forms.Label lblToDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboForm;
        private System.Windows.Forms.Label lblForm;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoBusiness;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNonPresent;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoOther;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;

    }
}
