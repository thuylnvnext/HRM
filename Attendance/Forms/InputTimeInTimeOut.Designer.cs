namespace Attendance.Forms
{
    partial class InputTimeInTimeOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputTimeInTimeOut));
            this.lblShift = new System.Windows.Forms.Label();
            this.grdTimeInTimeOut = new DevExpress.XtraGrid.GridControl();
            this.grvTimeInTimeOut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTimeIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ite = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colTimeOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lueShift = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMinute = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimeInTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTimeInTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(12, 64);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(61, 13);
            this.lblShift.TabIndex = 0;
            this.lblShift.Text = "Ca làm việc";
            // 
            // grdTimeInTimeOut
            // 
            this.grdTimeInTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTimeInTimeOut.Location = new System.Drawing.Point(12, 92);
            this.grdTimeInTimeOut.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdTimeInTimeOut.MainView = this.grvTimeInTimeOut;
            this.grdTimeInTimeOut.Name = "grdTimeInTimeOut";
            this.grdTimeInTimeOut.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ite});
            this.grdTimeInTimeOut.Size = new System.Drawing.Size(260, 112);
            this.grdTimeInTimeOut.TabIndex = 13;
            this.grdTimeInTimeOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTimeInTimeOut});
            // 
            // grvTimeInTimeOut
            // 
            this.grvTimeInTimeOut.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimeIn,
            this.colTimeOut});
            this.grvTimeInTimeOut.FixedLineWidth = 1;
            this.grvTimeInTimeOut.GridControl = this.grdTimeInTimeOut;
            this.grvTimeInTimeOut.HorzScrollStep = 10;
            this.grvTimeInTimeOut.Name = "grvTimeInTimeOut";
            this.grvTimeInTimeOut.OptionsCustomization.AllowFilter = false;
            this.grvTimeInTimeOut.OptionsCustomization.AllowGroup = false;
            this.grvTimeInTimeOut.OptionsCustomization.AllowSort = false;
            this.grvTimeInTimeOut.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grvTimeInTimeOut.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvTimeInTimeOut.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvTimeInTimeOut.OptionsView.ColumnAutoWidth = false;
            this.grvTimeInTimeOut.OptionsView.EnableAppearanceEvenRow = true;
            this.grvTimeInTimeOut.OptionsView.EnableAppearanceOddRow = true;
            this.grvTimeInTimeOut.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvTimeInTimeOut.OptionsView.ShowGroupPanel = false;
            // 
            // colTimeIn
            // 
            this.colTimeIn.AppearanceCell.Options.UseTextOptions = true;
            this.colTimeIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTimeIn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTimeIn.AppearanceHeader.Options.UseFont = true;
            this.colTimeIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colTimeIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTimeIn.Caption = "Giờ vào";
            this.colTimeIn.ColumnEdit = this.ite;
            this.colTimeIn.FieldName = "TimeIn";
            this.colTimeIn.Name = "colTimeIn";
            this.colTimeIn.Visible = true;
            this.colTimeIn.VisibleIndex = 0;
            // 
            // ite
            // 
            this.ite.AutoHeight = false;
            this.ite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ite.DisplayFormat.FormatString = "HH:mm";
            this.ite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ite.EditFormat.FormatString = "HH:mm";
            this.ite.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ite.Mask.EditMask = "HH:mm";
            this.ite.Name = "ite";
            // 
            // colTimeOut
            // 
            this.colTimeOut.AppearanceCell.Options.UseTextOptions = true;
            this.colTimeOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTimeOut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTimeOut.AppearanceHeader.Options.UseFont = true;
            this.colTimeOut.AppearanceHeader.Options.UseTextOptions = true;
            this.colTimeOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTimeOut.Caption = "Giờ ra";
            this.colTimeOut.ColumnEdit = this.ite;
            this.colTimeOut.FieldName = "TimeOut";
            this.colTimeOut.Name = "colTimeOut";
            this.colTimeOut.Visible = true;
            this.colTimeOut.VisibleIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(12, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 119;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(12, 40);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 120;
            this.lblToDate.Text = "Đến ngày";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(80, 36);
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
            this.dedToDate.TabIndex = 193;
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(80, 12);
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
            this.dedFromDate.TabIndex = 192;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(12, 216);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(131, 13);
            this.lblRandom.TabIndex = 194;
            this.lblRandom.Text = "Ngẫu nhiên trong khoảng ";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(168, 216);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(29, 13);
            this.lblMinute.TabIndex = 196;
            this.lblMinute.Text = "phút";
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(62, 244);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 197;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(146, 244);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 198;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lueShift
            // 
            this.lueShift.Location = new System.Drawing.Point(80, 60);
            this.lueShift.Name = "lueShift";
            this.lueShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueShift.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueShift.Properties.NullText = "";
            this.lueShift.Properties.ShowHeader = false;
            this.lueShift.Size = new System.Drawing.Size(108, 20);
            this.lueShift.TabIndex = 199;
            this.lueShift.EditValueChanged += new System.EventHandler(this.lueShift_EditValueChanged);
            // 
            // txtMinute
            // 
            this.txtMinute.EditValue = "0";
            this.txtMinute.Location = new System.Drawing.Point(144, 212);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMinute.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMinute.Size = new System.Drawing.Size(20, 20);
            this.txtMinute.TabIndex = 200;
            // 
            // InputTimeInTimeOut
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.dedToDate);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.grdTimeInTimeOut);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lueShift);
            this.Controls.Add(this.txtMinute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputTimeInTimeOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật giờ vào ra";
            this.Load += new System.EventHandler(this.InputTimeInTimeOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTimeInTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTimeInTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShift;
        private DevExpress.XtraGrid.GridControl grdTimeInTimeOut;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTimeInTimeOut;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeIn;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeOut;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit ite;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblMinute;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LookUpEdit lueShift;
        private DevExpress.XtraEditors.TextEdit txtMinute;
    }
}