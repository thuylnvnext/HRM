namespace HRMplus.UserControls
{
    partial class PermissionByReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionByReader));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.chkDisable = new DevExpress.XtraEditors.CheckEdit();
            this.chkEnable = new DevExpress.XtraEditors.CheckEdit();
            this.imlPermission = new System.Windows.Forms.ImageList(this.components);
            this.grdReader = new DevExpress.XtraGrid.GridControl();
            this.grvReader = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRight = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ImageIndex = 0;
            this.btnOK.ImageList = this.imlButton;
            this.btnOK.Location = new System.Drawing.Point(332, 352);
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 173;
            this.btnOK.Text = "&Thiết lập";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "run-icon.png");
            // 
            // chkDisable
            // 
            this.chkDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDisable.Location = new System.Drawing.Point(132, 356);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Properties.Caption = "Không được phép";
            this.chkDisable.Size = new System.Drawing.Size(112, 19);
            this.chkDisable.TabIndex = 172;
            // 
            // chkEnable
            // 
            this.chkEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEnable.EditValue = true;
            this.chkEnable.Location = new System.Drawing.Point(12, 356);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Properties.Caption = "Được phép";
            this.chkEnable.Size = new System.Drawing.Size(80, 19);
            this.chkEnable.TabIndex = 171;
            // 
            // imlPermission
            // 
            this.imlPermission.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPermission.ImageStream")));
            this.imlPermission.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPermission.Images.SetKeyName(0, "home_24.gif");
            this.imlPermission.Images.SetKeyName(1, "icon_users_16px.gif");
            this.imlPermission.Images.SetKeyName(2, "LegendHS.png");
            // 
            // grdReader
            // 
            this.grdReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdReader.Location = new System.Drawing.Point(12, 12);
            this.grdReader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdReader.MainView = this.grvReader;
            this.grdReader.Name = "grdReader";
            this.grdReader.Size = new System.Drawing.Size(396, 328);
            this.grdReader.TabIndex = 174;
            this.grdReader.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvReader});
            // 
            // grvReader
            // 
            this.grvReader.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colID,
            this.colIPAddress,
            this.colDescription,
            this.colRight});
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
            this.grvReader.OptionsView.ShowAutoFilterRow = true;
            this.grvReader.OptionsView.ShowDetailButtons = false;
            this.grvReader.OptionsView.ShowGroupPanel = false;
            this.grvReader.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvReader_CustomUnboundColumnData);
            this.grvReader.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grvReader_RowCellStyle);
            this.grvReader.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvReader_ShowingEditor);
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
            // colIPAddress
            // 
            this.colIPAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colIPAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIPAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIPAddress.AppearanceHeader.Options.UseFont = true;
            this.colIPAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colIPAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIPAddress.Caption = "Địa chỉ";
            this.colIPAddress.FieldName = "IPAddress";
            this.colIPAddress.Name = "colIPAddress";
            this.colIPAddress.OptionsColumn.AllowEdit = false;
            this.colIPAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIPAddress.OptionsColumn.ReadOnly = true;
            this.colIPAddress.Visible = true;
            this.colIPAddress.VisibleIndex = 1;
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
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colRight
            // 
            this.colRight.AppearanceCell.Options.UseTextOptions = true;
            this.colRight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRight.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colRight.AppearanceHeader.Options.UseFont = true;
            this.colRight.AppearanceHeader.Options.UseTextOptions = true;
            this.colRight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRight.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRight.Caption = "Được phép";
            this.colRight.FieldName = "Right";
            this.colRight.Name = "colRight";
            this.colRight.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colRight.Visible = true;
            this.colRight.VisibleIndex = 3;
            // 
            // PermissionByReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdReader);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDisable);
            this.Controls.Add(this.chkEnable);
            this.Name = "PermissionByReader";
            this.Size = new System.Drawing.Size(419, 391);
            this.Load += new System.EventHandler(this.PermissionByReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkDisable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckEdit chkDisable;
        private DevExpress.XtraEditors.CheckEdit chkEnable;
        internal System.Windows.Forms.ImageList imlButton;
        internal System.Windows.Forms.ImageList imlPermission;
        private DevExpress.XtraGrid.GridControl grdReader;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReader;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIPAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRight;
    }
}
