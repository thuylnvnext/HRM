namespace HRMplus.UserControls
{
    partial class ReaderOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderOption));
            this.grdReader = new DevExpress.XtraGrid.GridControl();
            this.grvReader = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReaderTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iteIPAddress = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCommPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itePassword = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblGetData = new System.Windows.Forms.Label();
            this.btnScheduleForGetData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteIPAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReader
            // 
            this.grdReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReader.Location = new System.Drawing.Point(12, 12);
            this.grdReader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdReader.MainView = this.grvReader;
            this.grdReader.Name = "grdReader";
            this.grdReader.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.iteIPAddress,
            this.itePassword});
            this.grdReader.Size = new System.Drawing.Size(396, 208);
            this.grdReader.TabIndex = 18;
            this.grdReader.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvReader});
            this.grdReader.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdReader_KeyDown);
            // 
            // grvReader
            // 
            this.grvReader.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colID,
            this.colReaderTypeID,
            this.colIPAddress,
            this.colCommPort,
            this.colCommPassword,
            this.colIn,
            this.colDescription,
            this.colUsed,
            this.colLastRecord,
            this.colDefault,
            this.colActive});
            this.grvReader.FixedLineWidth = 1;
            this.grvReader.GridControl = this.grdReader;
            this.grvReader.GroupFormat = " [#image]{1} {2}";
            this.grvReader.Name = "grvReader";
            this.grvReader.OptionsCustomization.AllowColumnMoving = false;
            this.grvReader.OptionsCustomization.AllowFilter = false;
            this.grvReader.OptionsCustomization.AllowGroup = false;
            this.grvReader.OptionsCustomization.AllowSort = false;
            this.grvReader.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvReader.OptionsView.ColumnAutoWidth = false;
            this.grvReader.OptionsView.EnableAppearanceEvenRow = true;
            this.grvReader.OptionsView.EnableAppearanceOddRow = true;
            this.grvReader.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvReader.OptionsView.ShowDetailButtons = false;
            this.grvReader.OptionsView.ShowGroupPanel = false;
            this.grvReader.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvReader_CustomUnboundColumnData);
            this.grvReader.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvReader_InitNewRow);
            this.grvReader.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvReader_CellValueChanging);
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
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Mã";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colReaderTypeID
            // 
            this.colReaderTypeID.AppearanceCell.Options.UseTextOptions = true;
            this.colReaderTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReaderTypeID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colReaderTypeID.AppearanceHeader.Options.UseFont = true;
            this.colReaderTypeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colReaderTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReaderTypeID.Caption = "Loại đầu đọc";
            this.colReaderTypeID.FieldName = "ReaderTypeID";
            this.colReaderTypeID.Name = "colReaderTypeID";
            // 
            // colIPAddress
            // 
            this.colIPAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colIPAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIPAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIPAddress.AppearanceHeader.Options.UseFont = true;
            this.colIPAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colIPAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIPAddress.Caption = "Địa chỉ";
            this.colIPAddress.ColumnEdit = this.iteIPAddress;
            this.colIPAddress.FieldName = "IPAddress";
            this.colIPAddress.Name = "colIPAddress";
            this.colIPAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIPAddress.Visible = true;
            this.colIPAddress.VisibleIndex = 1;
            // 
            // iteIPAddress
            // 
            this.iteIPAddress.AutoHeight = false;
            this.iteIPAddress.Mask.EditMask = "(([0-1]?[0-9]{1,2}\\.)|(2[0-4][0-9]\\.)|(25[0-5]\\.)){3}(([0-1]?[0-9]{1,2})|(2[0-4][" +
                "0-9])|(25[0-5]))";
            this.iteIPAddress.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.iteIPAddress.Mask.PlaceHolder = ' ';
            this.iteIPAddress.Mask.SaveLiteral = false;
            this.iteIPAddress.Name = "iteIPAddress";
            // 
            // colCommPort
            // 
            this.colCommPort.AppearanceCell.Options.UseTextOptions = true;
            this.colCommPort.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCommPort.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCommPort.AppearanceHeader.Options.UseFont = true;
            this.colCommPort.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommPort.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommPort.Caption = "Cổng";
            this.colCommPort.FieldName = "CommPort";
            this.colCommPort.Name = "colCommPort";
            this.colCommPort.Visible = true;
            this.colCommPort.VisibleIndex = 2;
            // 
            // colCommPassword
            // 
            this.colCommPassword.AppearanceCell.Options.UseTextOptions = true;
            this.colCommPassword.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCommPassword.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCommPassword.AppearanceHeader.Options.UseFont = true;
            this.colCommPassword.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommPassword.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommPassword.Caption = "Mật khẩu";
            this.colCommPassword.ColumnEdit = this.itePassword;
            this.colCommPassword.FieldName = "CommPassword";
            this.colCommPassword.Name = "colCommPassword";
            this.colCommPassword.Visible = true;
            this.colCommPassword.VisibleIndex = 3;
            // 
            // itePassword
            // 
            this.itePassword.AutoHeight = false;
            this.itePassword.Name = "itePassword";
            this.itePassword.PasswordChar = '*';
            // 
            // colIn
            // 
            this.colIn.AppearanceCell.Options.UseTextOptions = true;
            this.colIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIn.AppearanceHeader.Options.UseFont = true;
            this.colIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIn.Caption = "Nhận giờ vào";
            this.colIn.FieldName = "In";
            this.colIn.Name = "colIn";
            this.colIn.Visible = true;
            this.colIn.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colUsed
            // 
            this.colUsed.AppearanceCell.Options.UseTextOptions = true;
            this.colUsed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsed.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUsed.AppearanceHeader.Options.UseFont = true;
            this.colUsed.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsed.Caption = "Sử dụng";
            this.colUsed.FieldName = "Used";
            this.colUsed.Name = "colUsed";
            this.colUsed.Visible = true;
            this.colUsed.VisibleIndex = 6;
            // 
            // colLastRecord
            // 
            this.colLastRecord.AppearanceCell.Options.UseTextOptions = true;
            this.colLastRecord.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastRecord.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLastRecord.AppearanceHeader.Options.UseFont = true;
            this.colLastRecord.AppearanceHeader.Options.UseTextOptions = true;
            this.colLastRecord.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastRecord.Caption = "Thời gian hiệu lực";
            this.colLastRecord.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colLastRecord.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastRecord.FieldName = "LastRecord";
            this.colLastRecord.Name = "colLastRecord";
            this.colLastRecord.Visible = true;
            this.colLastRecord.VisibleIndex = 7;
            // 
            // colDefault
            // 
            this.colDefault.AppearanceCell.Options.UseTextOptions = true;
            this.colDefault.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDefault.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDefault.AppearanceHeader.Options.UseFont = true;
            this.colDefault.AppearanceHeader.Options.UseTextOptions = true;
            this.colDefault.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDefault.Caption = "Mặc định";
            this.colDefault.FieldName = "Default";
            this.colDefault.Name = "colDefault";
            // 
            // colActive
            // 
            this.colActive.AppearanceCell.Options.UseTextOptions = true;
            this.colActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colActive.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colActive.AppearanceHeader.Options.UseFont = true;
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Kích hoạt";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(244, 230);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 171;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(331, 230);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 28);
            this.btnDelete.TabIndex = 172;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGetData
            // 
            this.lblGetData.AutoSize = true;
            this.lblGetData.Location = new System.Drawing.Point(12, 240);
            this.lblGetData.Name = "lblGetData";
            this.lblGetData.Size = new System.Drawing.Size(112, 13);
            this.lblGetData.TabIndex = 198;
            this.lblGetData.Text = "Thời gian nhận dữ liệu";
            // 
            // btnScheduleForGetData
            // 
            this.btnScheduleForGetData.ImageIndex = 0;
            this.btnScheduleForGetData.Location = new System.Drawing.Point(128, 236);
            this.btnScheduleForGetData.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnScheduleForGetData.Name = "btnScheduleForGetData";
            this.btnScheduleForGetData.Size = new System.Drawing.Size(32, 20);
            this.btnScheduleForGetData.TabIndex = 199;
            this.btnScheduleForGetData.Text = "...";
            this.btnScheduleForGetData.Click += new System.EventHandler(this.btnScheduleForGetData_Click);
            // 
            // ReaderOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnScheduleForGetData);
            this.Controls.Add(this.lblGetData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdReader);
            this.Name = "ReaderOption";
            this.Size = new System.Drawing.Size(419, 270);
            this.Load += new System.EventHandler(this.Reader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteIPAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdReader;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReader;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colReaderTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colIPAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCommPort;
        private DevExpress.XtraGrid.Columns.GridColumn colCommPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUsed;
        private DevExpress.XtraGrid.Columns.GridColumn colLastRecord;
        private DevExpress.XtraGrid.Columns.GridColumn colDefault;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit iteIPAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itePassword;
        private System.Windows.Forms.Label lblGetData;
        private DevExpress.XtraEditors.SimpleButton btnScheduleForGetData;
    }
}
