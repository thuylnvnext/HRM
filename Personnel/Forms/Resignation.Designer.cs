namespace Personnel.Forms
{
    partial class Resignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resignation));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblResignationReason = new System.Windows.Forms.Label();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.lblContractIndemnity = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lueResignationReason = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAllowance = new DevExpress.XtraEditors.TextEdit();
            this.txtContractIndemnity = new DevExpress.XtraEditors.TextEdit();
            this.txtOther = new DevExpress.XtraEditors.TextEdit();
            this.mmeNotes = new DevExpress.XtraEditors.MemoEdit();
            this.chkReturnHealthIns = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueResignationReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractIndemnity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOther.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReturnHealthIns.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(12, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 16;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // lblResignationReason
            // 
            this.lblResignationReason.AutoSize = true;
            this.lblResignationReason.Location = new System.Drawing.Point(12, 40);
            this.lblResignationReason.Name = "lblResignationReason";
            this.lblResignationReason.Size = new System.Drawing.Size(56, 13);
            this.lblResignationReason.TabIndex = 46;
            this.lblResignationReason.Text = "Lý do nghỉ";
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Location = new System.Drawing.Point(12, 64);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(88, 13);
            this.lblAllowance.TabIndex = 47;
            this.lblAllowance.Text = "Trợ cấp nghỉ việc";
            // 
            // lblContractIndemnity
            // 
            this.lblContractIndemnity.AutoSize = true;
            this.lblContractIndemnity.Location = new System.Drawing.Point(12, 88);
            this.lblContractIndemnity.Name = "lblContractIndemnity";
            this.lblContractIndemnity.Size = new System.Drawing.Size(107, 13);
            this.lblContractIndemnity.TabIndex = 49;
            this.lblContractIndemnity.Text = "Bồi thường hợp đồng";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(12, 112);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(97, 13);
            this.lblOther.TabIndex = 51;
            this.lblOther.Text = "Tiền nghỉ việc khác";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 156);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(42, 13);
            this.lblNotes.TabIndex = 53;
            this.lblNotes.Text = "Ghi chú";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "Ok-icon.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(124, 12);
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
            this.dedFromDate.Size = new System.Drawing.Size(84, 20);
            this.dedFromDate.TabIndex = 163;
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(300, 12);
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
            this.dedToDate.Size = new System.Drawing.Size(84, 20);
            this.dedToDate.TabIndex = 167;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(240, 16);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 166;
            this.lblToDate.Text = "Đến ngày";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imlButton;
            this.btnAdd.Location = new System.Drawing.Point(115, 240);
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 28);
            this.btnAdd.TabIndex = 201;
            this.btnAdd.Text = "&Cập nhật";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(203, 240);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 202;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lueResignationReason
            // 
            this.lueResignationReason.Location = new System.Drawing.Point(124, 36);
            this.lueResignationReason.Name = "lueResignationReason";
            this.lueResignationReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueResignationReason.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueResignationReason.Properties.NullText = "";
            this.lueResignationReason.Properties.ShowHeader = false;
            this.lueResignationReason.Size = new System.Drawing.Size(260, 20);
            this.lueResignationReason.TabIndex = 203;
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(124, 60);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllowance.Properties.Appearance.Options.UseFont = true;
            this.txtAllowance.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtAllowance.Size = new System.Drawing.Size(128, 20);
            this.txtAllowance.TabIndex = 204;
            // 
            // txtContractIndemnity
            // 
            this.txtContractIndemnity.Location = new System.Drawing.Point(124, 84);
            this.txtContractIndemnity.Name = "txtContractIndemnity";
            this.txtContractIndemnity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractIndemnity.Properties.Appearance.Options.UseFont = true;
            this.txtContractIndemnity.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtContractIndemnity.Size = new System.Drawing.Size(128, 20);
            this.txtContractIndemnity.TabIndex = 205;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(124, 108);
            this.txtOther.Name = "txtOther";
            this.txtOther.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Properties.Appearance.Options.UseFont = true;
            this.txtOther.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtOther.Size = new System.Drawing.Size(128, 20);
            this.txtOther.TabIndex = 206;
            // 
            // mmeNotes
            // 
            this.mmeNotes.Location = new System.Drawing.Point(124, 152);
            this.mmeNotes.Name = "mmeNotes";
            this.mmeNotes.Size = new System.Drawing.Size(260, 76);
            this.mmeNotes.TabIndex = 207;
            // 
            // chkReturnHealthIns
            // 
            this.chkReturnHealthIns.AutoSizeInLayoutControl = true;
            this.chkReturnHealthIns.Location = new System.Drawing.Point(12, 132);
            this.chkReturnHealthIns.Name = "chkReturnHealthIns";
            this.chkReturnHealthIns.Properties.Caption = "Trả thẻ BHYT";
            this.chkReturnHealthIns.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkReturnHealthIns.Size = new System.Drawing.Size(128, 19);
            this.chkReturnHealthIns.TabIndex = 208;
            // 
            // Resignation
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 277);
            this.Controls.Add(this.dedToDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblContractIndemnity);
            this.Controls.Add(this.lblAllowance);
            this.Controls.Add(this.lblResignationReason);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lueResignationReason);
            this.Controls.Add(this.mmeNotes);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtContractIndemnity);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.chkReturnHealthIns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resignation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nghỉ việc";
            this.Load += new System.EventHandler(this.Resignation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueResignationReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractIndemnity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOther.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReturnHealthIns.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblResignationReason;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.Label lblContractIndemnity;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblNotes;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private System.Windows.Forms.Label lblToDate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LookUpEdit lueResignationReason;
        private DevExpress.XtraEditors.TextEdit txtAllowance;
        private DevExpress.XtraEditors.TextEdit txtContractIndemnity;
        private DevExpress.XtraEditors.TextEdit txtOther;
        private DevExpress.XtraEditors.MemoEdit mmeNotes;
        private DevExpress.XtraEditors.CheckEdit chkReturnHealthIns;
    }
}