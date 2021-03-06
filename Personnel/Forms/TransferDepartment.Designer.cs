namespace Personnel.Forms
{
    partial class TransferDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferDepartment));
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grdAvailableEmployee = new DevExpress.XtraGrid.GridControl();
            this.bgvAvailableEmployee = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbCheck = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.imlHeader = new System.Windows.Forms.ImageList(this.components);
            this.grdSelectedEmployee = new DevExpress.XtraGrid.GridControl();
            this.bgvSelectedEmployee = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSelectedNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbSelectedCheck = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSelectedCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSelectedID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSelectedFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lueFrom = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTo = new DevExpress.XtraEditors.LookUpEdit();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackward = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvAvailableEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectedEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvSelectedEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 16);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(20, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Từ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(332, 16);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "Đến";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "GoLtrHS.png");
            this.imlButton.Images.SetKeyName(1, "GoRtlHS.png");
            this.imlButton.Images.SetKeyName(2, "Windows-Close-Program-icon.png");
            // 
            // grdAvailableEmployee
            // 
            this.grdAvailableEmployee.Location = new System.Drawing.Point(12, 44);
            this.grdAvailableEmployee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdAvailableEmployee.MainView = this.bgvAvailableEmployee;
            this.grdAvailableEmployee.Name = "grdAvailableEmployee";
            this.grdAvailableEmployee.Size = new System.Drawing.Size(260, 304);
            this.grdAvailableEmployee.TabIndex = 2;
            this.grdAvailableEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvAvailableEmployee});
            // 
            // bgvAvailableEmployee
            // 
            this.bgvAvailableEmployee.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbCheck,
            this.gridBand1,
            this.gridBand5});
            this.bgvAvailableEmployee.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoCheck,
            this.bcoID,
            this.bcoCode,
            this.bcoFullName});
            this.bgvAvailableEmployee.FixedLineWidth = 1;
            this.bgvAvailableEmployee.GridControl = this.grdAvailableEmployee;
            this.bgvAvailableEmployee.HorzScrollStep = 10;
            this.bgvAvailableEmployee.Images = this.imlHeader;
            this.bgvAvailableEmployee.Name = "bgvAvailableEmployee";
            this.bgvAvailableEmployee.OptionsCustomization.AllowFilter = false;
            this.bgvAvailableEmployee.OptionsCustomization.AllowGroup = false;
            this.bgvAvailableEmployee.OptionsCustomization.AllowSort = false;
            this.bgvAvailableEmployee.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvAvailableEmployee.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvAvailableEmployee.OptionsView.ColumnAutoWidth = false;
            this.bgvAvailableEmployee.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvAvailableEmployee.OptionsView.EnableAppearanceOddRow = true;
            this.bgvAvailableEmployee.OptionsView.ShowAutoFilterRow = true;
            this.bgvAvailableEmployee.OptionsView.ShowColumnHeaders = false;
            this.bgvAvailableEmployee.OptionsView.ShowDetailButtons = false;
            this.bgvAvailableEmployee.OptionsView.ShowGroupPanel = false;
            this.bgvAvailableEmployee.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvAvailableEmployee_CustomUnboundColumnData);
            this.bgvAvailableEmployee.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvAvailableEmployee_CellValueChanging);
            this.bgvAvailableEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bgvAvailableEmployee_MouseDown);
            // 
            // grbNo
            // 
            this.grbNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbNo.AppearanceHeader.Options.UseFont = true;
            this.grbNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoNo.Visible = true;
            // 
            // grbCheck
            // 
            this.grbCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbCheck.AppearanceHeader.Options.UseFont = true;
            this.grbCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.grbCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbCheck.Columns.Add(this.bcoCheck);
            this.grbCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.grbCheck.ImageIndex = 1;
            this.grbCheck.Name = "grbCheck";
            this.grbCheck.OptionsBand.FixedWidth = true;
            this.grbCheck.Width = 30;
            // 
            // bcoCheck
            // 
            this.bcoCheck.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCheck.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCheck.AppearanceHeader.Options.UseFont = true;
            this.bcoCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCheck.Caption = "Check";
            this.bcoCheck.FieldName = "Check";
            this.bcoCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.bcoCheck.ImageIndex = 1;
            this.bcoCheck.Name = "bcoCheck";
            this.bcoCheck.OptionsColumn.FixedWidth = true;
            this.bcoCheck.Visible = true;
            this.bcoCheck.Width = 30;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Mã";
            this.gridBand1.Columns.Add(this.bcoCode);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
            // 
            // bcoCode
            // 
            this.bcoCode.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCode.AppearanceHeader.Options.UseFont = true;
            this.bcoCode.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCode.Caption = "Mã";
            this.bcoCode.FieldName = "Code";
            this.bcoCode.Name = "bcoCode";
            this.bcoCode.OptionsColumn.AllowEdit = false;
            this.bcoCode.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Họ và tên";
            this.gridBand5.Columns.Add(this.bcoFullName);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 75;
            // 
            // bcoFullName
            // 
            this.bcoFullName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoFullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoFullName.AppearanceHeader.Options.UseFont = true;
            this.bcoFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoFullName.Caption = "Họ và tên";
            this.bcoFullName.FieldName = "FullName";
            this.bcoFullName.Name = "bcoFullName";
            this.bcoFullName.OptionsColumn.AllowEdit = false;
            this.bcoFullName.Visible = true;
            // 
            // bcoID
            // 
            this.bcoID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoID.AppearanceHeader.Options.UseFont = true;
            this.bcoID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoID.FieldName = "ID";
            this.bcoID.Name = "bcoID";
            // 
            // imlHeader
            // 
            this.imlHeader.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlHeader.ImageStream")));
            this.imlHeader.TransparentColor = System.Drawing.Color.Transparent;
            this.imlHeader.Images.SetKeyName(0, "checked.gif");
            this.imlHeader.Images.SetKeyName(1, "unchecked.gif");
            // 
            // grdSelectedEmployee
            // 
            this.grdSelectedEmployee.Location = new System.Drawing.Point(336, 44);
            this.grdSelectedEmployee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdSelectedEmployee.MainView = this.bgvSelectedEmployee;
            this.grdSelectedEmployee.Name = "grdSelectedEmployee";
            this.grdSelectedEmployee.Size = new System.Drawing.Size(260, 304);
            this.grdSelectedEmployee.TabIndex = 7;
            this.grdSelectedEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvSelectedEmployee});
            // 
            // bgvSelectedEmployee
            // 
            this.bgvSelectedEmployee.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.grbSelectedCheck,
            this.gridBand4,
            this.gridBand6});
            this.bgvSelectedEmployee.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoSelectedNo,
            this.bcoSelectedCheck,
            this.bcoSelectedID,
            this.bcoSelectedFullName});
            this.bgvSelectedEmployee.FixedLineWidth = 1;
            this.bgvSelectedEmployee.GridControl = this.grdSelectedEmployee;
            this.bgvSelectedEmployee.HorzScrollStep = 10;
            this.bgvSelectedEmployee.Images = this.imlHeader;
            this.bgvSelectedEmployee.Name = "bgvSelectedEmployee";
            this.bgvSelectedEmployee.OptionsCustomization.AllowFilter = false;
            this.bgvSelectedEmployee.OptionsCustomization.AllowGroup = false;
            this.bgvSelectedEmployee.OptionsCustomization.AllowSort = false;
            this.bgvSelectedEmployee.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvSelectedEmployee.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvSelectedEmployee.OptionsView.ColumnAutoWidth = false;
            this.bgvSelectedEmployee.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvSelectedEmployee.OptionsView.EnableAppearanceOddRow = true;
            this.bgvSelectedEmployee.OptionsView.ShowAutoFilterRow = true;
            this.bgvSelectedEmployee.OptionsView.ShowColumnHeaders = false;
            this.bgvSelectedEmployee.OptionsView.ShowDetailButtons = false;
            this.bgvSelectedEmployee.OptionsView.ShowGroupPanel = false;
            this.bgvSelectedEmployee.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvSelectedEmployee_CustomUnboundColumnData);
            this.bgvSelectedEmployee.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvSelectedEmployee_CellValueChanging);
            this.bgvSelectedEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bgvSelectedEmployee_MouseDown);
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "STT";
            this.gridBand2.Columns.Add(this.bcoSelectedNo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 75;
            // 
            // bcoSelectedNo
            // 
            this.bcoSelectedNo.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSelectedNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSelectedNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoSelectedNo.AppearanceHeader.Options.UseFont = true;
            this.bcoSelectedNo.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSelectedNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSelectedNo.Caption = "STT";
            this.bcoSelectedNo.FieldName = "No";
            this.bcoSelectedNo.Name = "bcoSelectedNo";
            this.bcoSelectedNo.OptionsColumn.AllowEdit = false;
            this.bcoSelectedNo.OptionsColumn.ReadOnly = true;
            this.bcoSelectedNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoSelectedNo.Visible = true;
            // 
            // grbSelectedCheck
            // 
            this.grbSelectedCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbSelectedCheck.AppearanceHeader.Options.UseFont = true;
            this.grbSelectedCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.grbSelectedCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbSelectedCheck.Columns.Add(this.bcoSelectedCheck);
            this.grbSelectedCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.grbSelectedCheck.ImageIndex = 1;
            this.grbSelectedCheck.Name = "grbSelectedCheck";
            this.grbSelectedCheck.OptionsBand.FixedWidth = true;
            this.grbSelectedCheck.Width = 30;
            // 
            // bcoSelectedCheck
            // 
            this.bcoSelectedCheck.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSelectedCheck.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoSelectedCheck.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoSelectedCheck.AppearanceHeader.Options.UseFont = true;
            this.bcoSelectedCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSelectedCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSelectedCheck.Caption = "Check";
            this.bcoSelectedCheck.FieldName = "Check";
            this.bcoSelectedCheck.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.bcoSelectedCheck.ImageIndex = 1;
            this.bcoSelectedCheck.Name = "bcoSelectedCheck";
            this.bcoSelectedCheck.OptionsColumn.FixedWidth = true;
            this.bcoSelectedCheck.Visible = true;
            this.bcoSelectedCheck.Width = 30;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Mã";
            this.gridBand4.Columns.Add(this.bcoSelectedID);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 75;
            // 
            // bcoSelectedID
            // 
            this.bcoSelectedID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSelectedID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSelectedID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoSelectedID.AppearanceHeader.Options.UseFont = true;
            this.bcoSelectedID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSelectedID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSelectedID.Caption = "Mã";
            this.bcoSelectedID.FieldName = "ID";
            this.bcoSelectedID.Name = "bcoSelectedID";
            this.bcoSelectedID.OptionsColumn.AllowEdit = false;
            this.bcoSelectedID.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Họ và tên";
            this.gridBand6.Columns.Add(this.bcoSelectedFullName);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 75;
            // 
            // bcoSelectedFullName
            // 
            this.bcoSelectedFullName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSelectedFullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoSelectedFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoSelectedFullName.AppearanceHeader.Options.UseFont = true;
            this.bcoSelectedFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSelectedFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSelectedFullName.Caption = "Họ và tên";
            this.bcoSelectedFullName.FieldName = "FullName";
            this.bcoSelectedFullName.Name = "bcoSelectedFullName";
            this.bcoSelectedFullName.OptionsColumn.AllowEdit = false;
            this.bcoSelectedFullName.Visible = true;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(332, 360);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(384, 356);
            this.dedFromDate.Name = "dedFromDate";
            this.dedFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedFromDate.Size = new System.Drawing.Size(80, 20);
            this.dedFromDate.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.ImageIndex = 0;
            this.btnOK.ImageList = this.imlButton;
            this.btnOK.Location = new System.Drawing.Point(12, 372);
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&Chuyển";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 2;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(100, 372);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lueFrom
            // 
            this.lueFrom.Location = new System.Drawing.Point(44, 12);
            this.lueFrom.Name = "lueFrom";
            this.lueFrom.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFrom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullPath", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueFrom.Properties.DropDownRows = 20;
            this.lueFrom.Properties.NullText = "";
            this.lueFrom.Properties.ShowHeader = false;
            this.lueFrom.Size = new System.Drawing.Size(224, 20);
            this.lueFrom.TabIndex = 1;
            this.lueFrom.EditValueChanged += new System.EventHandler(this.lueFrom_EditValueChanged);
            // 
            // lueTo
            // 
            this.lueTo.Location = new System.Drawing.Point(364, 12);
            this.lueTo.Name = "lueTo";
            this.lueTo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullPath", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueTo.Properties.DropDownRows = 20;
            this.lueTo.Properties.NullText = "";
            this.lueTo.Properties.ShowHeader = false;
            this.lueTo.Size = new System.Drawing.Size(228, 20);
            this.lueTo.TabIndex = 6;
            this.lueTo.EditValueChanged += new System.EventHandler(this.lueTo_EditValueChanged);
            // 
            // btnForward
            // 
            this.btnForward.ImageIndex = 0;
            this.btnForward.ImageList = this.imlButton;
            this.btnForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForward.Location = new System.Drawing.Point(284, 168);
            this.btnForward.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 28);
            this.btnForward.TabIndex = 3;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.ImageIndex = 1;
            this.btnBackward.ImageList = this.imlButton;
            this.btnBackward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBackward.Location = new System.Drawing.Point(284, 204);
            this.btnBackward.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(40, 28);
            this.btnBackward.TabIndex = 4;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // TransferDepartment
            // 
            this.AcceptButton = this.btnOK;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(609, 412);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.grdSelectedEmployee);
            this.Controls.Add(this.grdAvailableEmployee);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lueTo);
            this.Controls.Add(this.lueFrom);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển phòng ban";
            this.Load += new System.EventHandler(this.TransferDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvAvailableEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectedEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvSelectedEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.GridControl grdAvailableEmployee;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvAvailableEmployee;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCode;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoFullName;
        internal System.Windows.Forms.ImageList imlHeader;
        private DevExpress.XtraGrid.GridControl grdSelectedEmployee;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvSelectedEmployee;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSelectedNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbSelectedCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSelectedCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSelectedID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSelectedFullName;
        private System.Windows.Forms.Label lblFromDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoID;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LookUpEdit lueFrom;
        private DevExpress.XtraEditors.LookUpEdit lueTo;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.SimpleButton btnBackward;

    }
}