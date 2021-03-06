namespace Personnel.UserControls
{
    partial class Address
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Address));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grdAddress = new DevExpress.XtraGrid.GridControl();
            this.grvAddress = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ileAddressType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileAddressType)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "saveHS.png");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            // 
            // grdAddress
            // 
            this.grdAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAddress.Location = new System.Drawing.Point(12, 12);
            this.grdAddress.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdAddress.MainView = this.grvAddress;
            this.grdAddress.Name = "grdAddress";
            this.grdAddress.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ileAddressType});
            this.grdAddress.Size = new System.Drawing.Size(696, 320);
            this.grdAddress.TabIndex = 89;
            this.grdAddress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAddress});
            // 
            // grvAddress
            // 
            this.grvAddress.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colEmployeeID,
            this.colAddressType,
            this.colName});
            this.grvAddress.FixedLineWidth = 1;
            this.grvAddress.GridControl = this.grdAddress;
            this.grvAddress.HorzScrollStep = 10;
            this.grvAddress.Name = "grvAddress";
            this.grvAddress.OptionsCustomization.AllowFilter = false;
            this.grvAddress.OptionsCustomization.AllowGroup = false;
            this.grvAddress.OptionsCustomization.AllowSort = false;
            this.grvAddress.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvAddress.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvAddress.OptionsView.EnableAppearanceEvenRow = true;
            this.grvAddress.OptionsView.EnableAppearanceOddRow = true;
            this.grvAddress.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvAddress.OptionsView.ShowDetailButtons = false;
            this.grvAddress.OptionsView.ShowGroupPanel = false;
            this.grvAddress.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvAddress_CustomUnboundColumnData);
            this.grvAddress.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvAddress_InitNewRow);
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
            this.colEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.Caption = "Mã NV";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colAddressType
            // 
            this.colAddressType.AppearanceCell.Options.UseTextOptions = true;
            this.colAddressType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAddressType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAddressType.AppearanceHeader.Options.UseFont = true;
            this.colAddressType.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressType.Caption = "Loại địa chỉ";
            this.colAddressType.ColumnEdit = this.ileAddressType;
            this.colAddressType.FieldName = "AddressTypeID";
            this.colAddressType.Name = "colAddressType";
            this.colAddressType.Visible = true;
            this.colAddressType.VisibleIndex = 1;
            // 
            // ileAddressType
            // 
            this.ileAddressType.AppearanceDropDown.Options.UseTextOptions = true;
            this.ileAddressType.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ileAddressType.AutoHeight = false;
            this.ileAddressType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileAddressType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.ileAddressType.Name = "ileAddressType";
            this.ileAddressType.NullText = "";
            this.ileAddressType.ShowHeader = false;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Options.UseTextOptions = true;
            this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "Địa chỉ";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
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
            this.btnSave.TabIndex = 161;
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
            this.btnDelete.TabIndex = 162;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Address
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Address";
            this.Size = new System.Drawing.Size(721, 384);
            this.Load += new System.EventHandler(this.Address_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileAddressType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.GridControl grdAddress;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileAddressType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}
