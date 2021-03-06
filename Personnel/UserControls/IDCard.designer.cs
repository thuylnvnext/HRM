namespace Personnel.UserControls
{
    partial class IDCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDCard));
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblIssuedPlace = new System.Windows.Forms.Label();
            this.dedIssuedDate = new DevExpress.XtraEditors.DateEdit();
            this.dedExpiredDate = new DevExpress.XtraEditors.DateEdit();
            this.dedPassportIssuedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblExpiredDate = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblPassportIssuedDate = new System.Windows.Forms.Label();
            this.lblPassportIssuedPlace = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grcIDCard = new DevExpress.XtraEditors.GroupControl();
            this.txtIssuedPlace = new DevExpress.XtraEditors.TextEdit();
            this.txtIDNumber = new DevExpress.XtraEditors.TextEdit();
            this.grcPassport = new DevExpress.XtraEditors.GroupControl();
            this.txtPassportIssuedPlace = new DevExpress.XtraEditors.TextEdit();
            this.txtPassportNumber = new DevExpress.XtraEditors.TextEdit();
            this.grcBankAccount = new DevExpress.XtraEditors.GroupControl();
            this.grdBankAccount = new DevExpress.XtraGrid.GridControl();
            this.grvBankAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileBankID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iteAccountNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSaveInitialInfo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dedIssuedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedIssuedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedExpiredDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedExpiredDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedPassportIssuedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedPassportIssuedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcIDCard)).BeginInit();
            this.grcIDCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuedPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPassport)).BeginInit();
            this.grcPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassportIssuedPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassportNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBankAccount)).BeginInit();
            this.grcBankAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileBankID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteAccountNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(12, 32);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(51, 13);
            this.lblIDNumber.TabIndex = 2;
            this.lblIDNumber.Text = "Số CMND";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDate.Location = new System.Drawing.Point(12, 56);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(52, 13);
            this.lblIssuedDate.TabIndex = 6;
            this.lblIssuedDate.Text = "Ngày cấp";
            // 
            // lblIssuedPlace
            // 
            this.lblIssuedPlace.AutoSize = true;
            this.lblIssuedPlace.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedPlace.Location = new System.Drawing.Point(12, 80);
            this.lblIssuedPlace.Name = "lblIssuedPlace";
            this.lblIssuedPlace.Size = new System.Drawing.Size(42, 13);
            this.lblIssuedPlace.TabIndex = 45;
            this.lblIssuedPlace.Text = "Nơi cấp";
            // 
            // dedIssuedDate
            // 
            this.dedIssuedDate.EditValue = null;
            this.dedIssuedDate.Location = new System.Drawing.Point(80, 52);
            this.dedIssuedDate.Name = "dedIssuedDate";
            this.dedIssuedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedIssuedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedIssuedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedIssuedDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedIssuedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedIssuedDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedIssuedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedIssuedDate.Size = new System.Drawing.Size(84, 20);
            this.dedIssuedDate.TabIndex = 165;
            // 
            // dedExpiredDate
            // 
            this.dedExpiredDate.EditValue = null;
            this.dedExpiredDate.Location = new System.Drawing.Point(248, 52);
            this.dedExpiredDate.Name = "dedExpiredDate";
            this.dedExpiredDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedExpiredDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedExpiredDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedExpiredDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedExpiredDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedExpiredDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedExpiredDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedExpiredDate.Size = new System.Drawing.Size(84, 20);
            this.dedExpiredDate.TabIndex = 166;
            // 
            // dedPassportIssuedDate
            // 
            this.dedPassportIssuedDate.EditValue = null;
            this.dedPassportIssuedDate.Location = new System.Drawing.Point(80, 52);
            this.dedPassportIssuedDate.Name = "dedPassportIssuedDate";
            this.dedPassportIssuedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedPassportIssuedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedPassportIssuedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedPassportIssuedDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedPassportIssuedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedPassportIssuedDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedPassportIssuedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedPassportIssuedDate.Size = new System.Drawing.Size(84, 20);
            this.dedPassportIssuedDate.TabIndex = 165;
            // 
            // lblExpiredDate
            // 
            this.lblExpiredDate.AutoSize = true;
            this.lblExpiredDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredDate.Location = new System.Drawing.Point(172, 56);
            this.lblExpiredDate.Name = "lblExpiredDate";
            this.lblExpiredDate.Size = new System.Drawing.Size(72, 13);
            this.lblExpiredDate.TabIndex = 56;
            this.lblExpiredDate.Text = "Ngày hết hạn";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportNumber.Location = new System.Drawing.Point(12, 32);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(62, 13);
            this.lblPassportNumber.TabIndex = 2;
            this.lblPassportNumber.Text = "Số hộ chiếu";
            // 
            // lblPassportIssuedDate
            // 
            this.lblPassportIssuedDate.AutoSize = true;
            this.lblPassportIssuedDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportIssuedDate.Location = new System.Drawing.Point(12, 56);
            this.lblPassportIssuedDate.Name = "lblPassportIssuedDate";
            this.lblPassportIssuedDate.Size = new System.Drawing.Size(52, 13);
            this.lblPassportIssuedDate.TabIndex = 6;
            this.lblPassportIssuedDate.Text = "Ngày cấp";
            // 
            // lblPassportIssuedPlace
            // 
            this.lblPassportIssuedPlace.AutoSize = true;
            this.lblPassportIssuedPlace.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportIssuedPlace.Location = new System.Drawing.Point(12, 80);
            this.lblPassportIssuedPlace.Name = "lblPassportIssuedPlace";
            this.lblPassportIssuedPlace.Size = new System.Drawing.Size(42, 13);
            this.lblPassportIssuedPlace.TabIndex = 45;
            this.lblPassportIssuedPlace.Text = "Nơi cấp";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "saveHS.png");
            // 
            // grcIDCard
            // 
            this.grcIDCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcIDCard.Controls.Add(this.dedIssuedDate);
            this.grcIDCard.Controls.Add(this.lblIssuedPlace);
            this.grcIDCard.Controls.Add(this.lblIDNumber);
            this.grcIDCard.Controls.Add(this.lblIssuedDate);
            this.grcIDCard.Controls.Add(this.txtIssuedPlace);
            this.grcIDCard.Controls.Add(this.txtIDNumber);
            this.grcIDCard.Location = new System.Drawing.Point(12, 12);
            this.grcIDCard.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grcIDCard.Name = "grcIDCard";
            this.grcIDCard.Size = new System.Drawing.Size(696, 108);
            this.grcIDCard.TabIndex = 86;
            this.grcIDCard.Text = "Thông tin CMND";
            // 
            // txtIssuedPlace
            // 
            this.txtIssuedPlace.Location = new System.Drawing.Point(80, 76);
            this.txtIssuedPlace.Name = "txtIssuedPlace";
            this.txtIssuedPlace.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtIssuedPlace.Size = new System.Drawing.Size(252, 20);
            this.txtIssuedPlace.TabIndex = 185;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(80, 28);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtIDNumber.Size = new System.Drawing.Size(84, 20);
            this.txtIDNumber.TabIndex = 184;
            // 
            // grcPassport
            // 
            this.grcPassport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcPassport.Controls.Add(this.dedExpiredDate);
            this.grcPassport.Controls.Add(this.dedPassportIssuedDate);
            this.grcPassport.Controls.Add(this.lblPassportIssuedDate);
            this.grcPassport.Controls.Add(this.lblPassportNumber);
            this.grcPassport.Controls.Add(this.lblPassportIssuedPlace);
            this.grcPassport.Controls.Add(this.lblExpiredDate);
            this.grcPassport.Controls.Add(this.txtPassportIssuedPlace);
            this.grcPassport.Controls.Add(this.txtPassportNumber);
            this.grcPassport.Location = new System.Drawing.Point(12, 256);
            this.grcPassport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grcPassport.Name = "grcPassport";
            this.grcPassport.Size = new System.Drawing.Size(696, 108);
            this.grcPassport.TabIndex = 88;
            this.grcPassport.Text = "Thông tin hộ chiếu";
            this.grcPassport.Visible = false;
            // 
            // txtPassportIssuedPlace
            // 
            this.txtPassportIssuedPlace.Location = new System.Drawing.Point(80, 76);
            this.txtPassportIssuedPlace.Name = "txtPassportIssuedPlace";
            this.txtPassportIssuedPlace.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPassportIssuedPlace.Size = new System.Drawing.Size(252, 20);
            this.txtPassportIssuedPlace.TabIndex = 185;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(80, 28);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPassportNumber.Size = new System.Drawing.Size(84, 20);
            this.txtPassportNumber.TabIndex = 184;
            // 
            // grcBankAccount
            // 
            this.grcBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcBankAccount.Controls.Add(this.grdBankAccount);
            this.grcBankAccount.Location = new System.Drawing.Point(12, 126);
            this.grcBankAccount.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grcBankAccount.Name = "grcBankAccount";
            this.grcBankAccount.Size = new System.Drawing.Size(696, 124);
            this.grcBankAccount.TabIndex = 89;
            this.grcBankAccount.Text = "Thông tin tài khoản";
            // 
            // grdBankAccount
            // 
            this.grdBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBankAccount.Location = new System.Drawing.Point(12, 28);
            this.grdBankAccount.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdBankAccount.MainView = this.grvBankAccount;
            this.grdBankAccount.Name = "grdBankAccount";
            this.grdBankAccount.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.iteAccountNumber,
            this.ileBankID});
            this.grdBankAccount.Size = new System.Drawing.Size(672, 84);
            this.grdBankAccount.TabIndex = 22;
            this.grdBankAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBankAccount});
            // 
            // grvBankAccount
            // 
            this.grvBankAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colEmployeeID,
            this.colBankID,
            this.colAccountNumber,
            this.colNote});
            this.grvBankAccount.FixedLineWidth = 1;
            this.grvBankAccount.GridControl = this.grdBankAccount;
            this.grvBankAccount.HorzScrollStep = 10;
            this.grvBankAccount.Name = "grvBankAccount";
            this.grvBankAccount.OptionsCustomization.AllowFilter = false;
            this.grvBankAccount.OptionsCustomization.AllowGroup = false;
            this.grvBankAccount.OptionsCustomization.AllowSort = false;
            this.grvBankAccount.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvBankAccount.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvBankAccount.OptionsView.EnableAppearanceEvenRow = true;
            this.grvBankAccount.OptionsView.EnableAppearanceOddRow = true;
            this.grvBankAccount.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvBankAccount.OptionsView.ShowDetailButtons = false;
            this.grvBankAccount.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvBankAccount.OptionsView.ShowGroupPanel = false;
            this.grvBankAccount.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvBankAccount_InitNewRow);
            this.grvBankAccount.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvBankAccount_CustomUnboundColumnData);
            this.grvBankAccount.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.grvBankAccount_ValidatingEditor);
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
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 40;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.Caption = "Mã NV";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colBankID
            // 
            this.colBankID.AppearanceCell.Options.UseTextOptions = true;
            this.colBankID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colBankID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBankID.AppearanceHeader.Options.UseFont = true;
            this.colBankID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankID.Caption = "Tên ngân hàng";
            this.colBankID.ColumnEdit = this.ileBankID;
            this.colBankID.FieldName = "BankID";
            this.colBankID.Name = "colBankID";
            this.colBankID.Visible = true;
            this.colBankID.VisibleIndex = 1;
            this.colBankID.Width = 203;
            // 
            // ileBankID
            // 
            this.ileBankID.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileBankID.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileBankID.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ileBankID.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ileBankID.AutoHeight = false;
            this.ileBankID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileBankID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên ngân hàng", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileBankID.Name = "ileBankID";
            this.ileBankID.NullText = "";
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAccountNumber.AppearanceHeader.Options.UseFont = true;
            this.colAccountNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountNumber.Caption = "Số tài khoản";
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.VisibleIndex = 2;
            this.colAccountNumber.Width = 119;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Options.UseTextOptions = true;
            this.colNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote.Caption = "Ghi chú";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 3;
            this.colNote.Width = 282;
            // 
            // iteAccountNumber
            // 
            this.iteAccountNumber.AutoHeight = false;
            this.iteAccountNumber.DisplayFormat.FormatString = "0000000000000";
            this.iteAccountNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.iteAccountNumber.EditFormat.FormatString = "0000000000000";
            this.iteAccountNumber.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.iteAccountNumber.Mask.EditMask = "0000000000000";
            this.iteAccountNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.iteAccountNumber.Mask.SaveLiteral = false;
            this.iteAccountNumber.Name = "iteAccountNumber";
            // 
            // btnSaveInitialInfo
            // 
            this.btnSaveInitialInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveInitialInfo.ImageIndex = 0;
            this.btnSaveInitialInfo.ImageList = this.imlButton;
            this.btnSaveInitialInfo.Location = new System.Drawing.Point(322, 384);
            this.btnSaveInitialInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSaveInitialInfo.Name = "btnSaveInitialInfo";
            this.btnSaveInitialInfo.Size = new System.Drawing.Size(76, 28);
            this.btnSaveInitialInfo.TabIndex = 183;
            this.btnSaveInitialInfo.Text = "Lưu";
            this.btnSaveInitialInfo.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IDCard
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveInitialInfo);
            this.Controls.Add(this.grcPassport);
            this.Controls.Add(this.grcIDCard);
            this.Controls.Add(this.grcBankAccount);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "IDCard";
            this.Size = new System.Drawing.Size(721, 424);
            this.Load += new System.EventHandler(this.IDCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedIssuedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedIssuedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedExpiredDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedExpiredDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedPassportIssuedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedPassportIssuedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcIDCard)).EndInit();
            this.grcIDCard.ResumeLayout(false);
            this.grcIDCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuedPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPassport)).EndInit();
            this.grcPassport.ResumeLayout(false);
            this.grcPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassportIssuedPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassportNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBankAccount)).EndInit();
            this.grcBankAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBankAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBankAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileBankID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteAccountNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Label lblIssuedPlace;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblPassportIssuedDate;
        private System.Windows.Forms.Label lblPassportIssuedPlace;
        private System.Windows.Forms.Label lblExpiredDate;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.DateEdit dedIssuedDate;
        private DevExpress.XtraEditors.DateEdit dedExpiredDate;
        private DevExpress.XtraEditors.DateEdit dedPassportIssuedDate;
        private DevExpress.XtraEditors.GroupControl grcIDCard;
        private DevExpress.XtraEditors.GroupControl grcPassport;
        private DevExpress.XtraEditors.GroupControl grcBankAccount;
        private DevExpress.XtraGrid.GridControl grdBankAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colBankID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileBankID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit iteAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.SimpleButton btnSaveInitialInfo;
        private DevExpress.XtraEditors.TextEdit txtIssuedPlace;
        private DevExpress.XtraEditors.TextEdit txtIDNumber;
        private DevExpress.XtraEditors.TextEdit txtPassportIssuedPlace;
        private DevExpress.XtraEditors.TextEdit txtPassportNumber;
    }
}
