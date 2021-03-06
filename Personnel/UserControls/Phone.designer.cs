namespace Personnel.UserControls
{
    partial class Phone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phone));
            this.grdPhone = new DevExpress.XtraGrid.GridControl();
            this.grvPhone = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ilePhoneType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilePhoneType)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPhone
            // 
            this.grdPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPhone.Location = new System.Drawing.Point(12, 12);
            this.grdPhone.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdPhone.MainView = this.grvPhone;
            this.grdPhone.Name = "grdPhone";
            this.grdPhone.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ilePhoneType});
            this.grdPhone.Size = new System.Drawing.Size(696, 320);
            this.grdPhone.TabIndex = 71;
            this.grdPhone.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhone});
            // 
            // grvPhone
            // 
            this.grvPhone.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colEmployeeID,
            this.colPhoneType,
            this.colNumber});
            this.grvPhone.FixedLineWidth = 1;
            this.grvPhone.GridControl = this.grdPhone;
            this.grvPhone.HorzScrollStep = 10;
            this.grvPhone.Name = "grvPhone";
            this.grvPhone.OptionsCustomization.AllowFilter = false;
            this.grvPhone.OptionsCustomization.AllowGroup = false;
            this.grvPhone.OptionsCustomization.AllowSort = false;
            this.grvPhone.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvPhone.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvPhone.OptionsView.EnableAppearanceEvenRow = true;
            this.grvPhone.OptionsView.EnableAppearanceOddRow = true;
            this.grvPhone.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvPhone.OptionsView.ShowDetailButtons = false;
            this.grvPhone.OptionsView.ShowGroupPanel = false;
            this.grvPhone.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvPhone_CustomUnboundColumnData);
            this.grvPhone.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvPhone_InitNewRow);
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
            // colPhoneType
            // 
            this.colPhoneType.AppearanceCell.Options.UseTextOptions = true;
            this.colPhoneType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPhoneType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPhoneType.AppearanceHeader.Options.UseFont = true;
            this.colPhoneType.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhoneType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhoneType.Caption = "Loại điện thoại";
            this.colPhoneType.ColumnEdit = this.ilePhoneType;
            this.colPhoneType.FieldName = "PhoneTypeID";
            this.colPhoneType.Name = "colPhoneType";
            this.colPhoneType.Visible = true;
            this.colPhoneType.VisibleIndex = 1;
            // 
            // ilePhoneType
            // 
            this.ilePhoneType.AppearanceDropDown.Options.UseTextOptions = true;
            this.ilePhoneType.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ilePhoneType.AutoHeight = false;
            this.ilePhoneType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilePhoneType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.ilePhoneType.Name = "ilePhoneType";
            this.ilePhoneType.NullText = "";
            this.ilePhoneType.ShowHeader = false;
            // 
            // colNumber
            // 
            this.colNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNumber.AppearanceHeader.Options.UseFont = true;
            this.colNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumber.Caption = "Số điện thoại";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "saveHS.png");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(276, 344);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 171;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(368, 344);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 172;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Phone
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdPhone);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Phone";
            this.Size = new System.Drawing.Size(721, 384);
            this.Load += new System.EventHandler(this.Phone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilePhoneType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPhone;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneType;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ilePhoneType;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}
