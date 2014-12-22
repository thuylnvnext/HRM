namespace Personnel.Forms
{
    partial class ChangeDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDepartment));
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.txtTabMan = new System.Windows.Forms.TextBox();
            this.lblTabMan = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.crvChangeDepartment = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dedDateOfIssue = new DevExpress.XtraEditors.DateEdit();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Location = new System.Drawing.Point(196, 40);
            this.lblDateOfIssue.Name = "lblDateOfIssue";
            this.lblDateOfIssue.Size = new System.Drawing.Size(49, 13);
            this.lblDateOfIssue.TabIndex = 142;
            this.lblDateOfIssue.Text = "Ngày lập";
            // 
            // txtTabMan
            // 
            this.txtTabMan.Location = new System.Drawing.Point(252, 12);
            this.txtTabMan.Name = "txtTabMan";
            this.txtTabMan.Size = new System.Drawing.Size(160, 21);
            this.txtTabMan.TabIndex = 141;
            // 
            // lblTabMan
            // 
            this.lblTabMan.AutoSize = true;
            this.lblTabMan.Location = new System.Drawing.Point(196, 16);
            this.lblTabMan.Name = "lblTabMan";
            this.lblTabMan.Size = new System.Drawing.Size(52, 13);
            this.lblTabMan.TabIndex = 140;
            this.lblTabMan.Text = "Người lập";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ImageIndex = 0;
            this.btnPreview.ImageList = this.imlButton;
            this.btnPreview.Location = new System.Drawing.Point(652, 20);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(104, 28);
            this.btnPreview.TabIndex = 139;
            this.btnPreview.Text = "Xem báo cáo";
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "PrintPreviewHS.png");
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(12, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 135;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(12, 40);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 136;
            this.lblToDate.Text = "Đến ngày";
            // 
            // crvChangeDepartment
            // 
            this.crvChangeDepartment.ActiveViewIndex = -1;
            this.crvChangeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crvChangeDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvChangeDepartment.DisplayGroupTree = false;
            this.crvChangeDepartment.Location = new System.Drawing.Point(0, 68);
            this.crvChangeDepartment.Name = "crvChangeDepartment";
            this.crvChangeDepartment.SelectionFormula = "";
            this.crvChangeDepartment.Size = new System.Drawing.Size(769, 278);
            this.crvChangeDepartment.TabIndex = 133;
            this.crvChangeDepartment.ViewTimeSelectionFormula = "";
            // 
            // dedDateOfIssue
            // 
            this.dedDateOfIssue.EditValue = null;
            this.dedDateOfIssue.Location = new System.Drawing.Point(252, 36);
            this.dedDateOfIssue.Name = "dedDateOfIssue";
            this.dedDateOfIssue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dedDateOfIssue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedDateOfIssue.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedDateOfIssue.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedDateOfIssue.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedDateOfIssue.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedDateOfIssue.Size = new System.Drawing.Size(80, 22);
            this.dedDateOfIssue.TabIndex = 169;
            // 
            // dedToDate
            // 
            this.dedToDate.EditValue = null;
            this.dedToDate.Location = new System.Drawing.Point(72, 36);
            this.dedToDate.Name = "dedToDate";
            this.dedToDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dedToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedToDate.Size = new System.Drawing.Size(80, 22);
            this.dedToDate.TabIndex = 168;
            // 
            // dedFromDate
            // 
            this.dedFromDate.EditValue = null;
            this.dedFromDate.Location = new System.Drawing.Point(72, 12);
            this.dedFromDate.Name = "dedFromDate";
            this.dedFromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dedFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedFromDate.Size = new System.Drawing.Size(80, 22);
            this.dedFromDate.TabIndex = 167;
            // 
            // ChangeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(769, 346);
            this.Controls.Add(this.dedDateOfIssue);
            this.Controls.Add(this.dedToDate);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.lblDateOfIssue);
            this.Controls.Add(this.txtTabMan);
            this.Controls.Add(this.lblTabMan);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.crvChangeDepartment);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChangeDepartment";
            this.Text = "Nhân viên chuyển bộ phận";
            this.Load += new System.EventHandler(this.ChangeDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.TextBox txtTabMan;
        private System.Windows.Forms.Label lblTabMan;
        internal System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvChangeDepartment;
        private DevExpress.XtraEditors.DateEdit dedDateOfIssue;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
    }
}
