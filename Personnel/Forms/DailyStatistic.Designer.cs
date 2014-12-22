namespace Personnel.Forms
{
    partial class DailyStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyStatistic));
            this.lblWorkingDay = new System.Windows.Forms.Label();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.lblTabMan = new System.Windows.Forms.Label();
            this.lblStatisticType = new System.Windows.Forms.Label();
            this.dedWorkingDay = new DevExpress.XtraEditors.DateEdit();
            this.dedDateOfIssue = new DevExpress.XtraEditors.DateEdit();
            this.cboStatisticType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTabMan = new DevExpress.XtraEditors.TextEdit();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatisticType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTabMan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorkingDay
            // 
            this.lblWorkingDay.AutoSize = true;
            this.lblWorkingDay.Location = new System.Drawing.Point(12, 40);
            this.lblWorkingDay.Name = "lblWorkingDay";
            this.lblWorkingDay.Size = new System.Drawing.Size(32, 13);
            this.lblWorkingDay.TabIndex = 120;
            this.lblWorkingDay.Text = "Ngày";
            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Location = new System.Drawing.Point(244, 16);
            this.lblDateOfIssue.Name = "lblDateOfIssue";
            this.lblDateOfIssue.Size = new System.Drawing.Size(49, 13);
            this.lblDateOfIssue.TabIndex = 127;
            this.lblDateOfIssue.Text = "Ngày lập";
            // 
            // lblTabMan
            // 
            this.lblTabMan.AutoSize = true;
            this.lblTabMan.Location = new System.Drawing.Point(244, 40);
            this.lblTabMan.Name = "lblTabMan";
            this.lblTabMan.Size = new System.Drawing.Size(52, 13);
            this.lblTabMan.TabIndex = 125;
            this.lblTabMan.Text = "Người lập";
            // 
            // lblStatisticType
            // 
            this.lblStatisticType.AutoSize = true;
            this.lblStatisticType.Location = new System.Drawing.Point(12, 16);
            this.lblStatisticType.Name = "lblStatisticType";
            this.lblStatisticType.Size = new System.Drawing.Size(26, 13);
            this.lblStatisticType.TabIndex = 129;
            this.lblStatisticType.Text = "Loại";
            // 
            // dedWorkingDay
            // 
            this.dedWorkingDay.EditValue = null;
            this.dedWorkingDay.Location = new System.Drawing.Point(48, 36);
            this.dedWorkingDay.Name = "dedWorkingDay";
            this.dedWorkingDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedWorkingDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedWorkingDay.Size = new System.Drawing.Size(80, 20);
            this.dedWorkingDay.TabIndex = 166;
            // 
            // dedDateOfIssue
            // 
            this.dedDateOfIssue.EditValue = null;
            this.dedDateOfIssue.Location = new System.Drawing.Point(300, 12);
            this.dedDateOfIssue.Name = "dedDateOfIssue";
            this.dedDateOfIssue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedDateOfIssue.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedDateOfIssue.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedDateOfIssue.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedDateOfIssue.Size = new System.Drawing.Size(80, 20);
            this.dedDateOfIssue.TabIndex = 167;
            // 
            // cboStatisticType
            // 
            this.cboStatisticType.Location = new System.Drawing.Point(48, 12);
            this.cboStatisticType.Name = "cboStatisticType";
            this.cboStatisticType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatisticType.Properties.Items.AddRange(new object[] {
            "Nhân lực hằng ngày"});
            this.cboStatisticType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboStatisticType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatisticType.Size = new System.Drawing.Size(184, 20);
            this.cboStatisticType.TabIndex = 169;
            // 
            // txtTabMan
            // 
            this.txtTabMan.Location = new System.Drawing.Point(300, 36);
            this.txtTabMan.Name = "txtTabMan";
            this.txtTabMan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabMan.Properties.Appearance.Options.UseFont = true;
            this.txtTabMan.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTabMan.Size = new System.Drawing.Size(172, 20);
            this.txtTabMan.TabIndex = 170;
            // 
            // btnPreview
            // 
            this.btnPreview.ImageIndex = 0;
            this.btnPreview.ImageList = this.imlButton;
            this.btnPreview.Location = new System.Drawing.Point(161, 69);
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(76, 28);
            this.btnPreview.TabIndex = 174;
            this.btnPreview.Text = "&Xem";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "PrintPreviewHS.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(245, 69);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 175;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DailyStatistic
            // 
            this.AcceptButton = this.btnPreview;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(482, 107);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTabMan);
            this.Controls.Add(this.lblStatisticType);
            this.Controls.Add(this.cboStatisticType);
            this.Controls.Add(this.lblTabMan);
            this.Controls.Add(this.lblWorkingDay);
            this.Controls.Add(this.dedDateOfIssue);
            this.Controls.Add(this.dedWorkingDay);
            this.Controls.Add(this.lblDateOfIssue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyStatistic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hàng ngày";
            this.Load += new System.EventHandler(this.DailyStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatisticType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTabMan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkingDay;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.Label lblTabMan;
        private System.Windows.Forms.Label lblStatisticType;
        private DevExpress.XtraEditors.DateEdit dedWorkingDay;
        private DevExpress.XtraEditors.DateEdit dedDateOfIssue;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatisticType;
        private DevExpress.XtraEditors.TextEdit txtTabMan;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        internal System.Windows.Forms.ImageList imlButton;
    }
}
