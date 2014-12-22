namespace Personnel.Forms
{
    partial class ChangeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSalary));
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.dedToDate = new DevExpress.XtraEditors.DateEdit();
            this.dedFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.crvChangeSalary = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dedDateOfIssue = new DevExpress.XtraEditors.DateEdit();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.txtTabMan = new System.Windows.Forms.TextBox();
            this.lblTabMan = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtPersonnelManager = new System.Windows.Forms.TextBox();
            this.lblPersonnelManager = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPreview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.ImageIndex = 0;
            this.btnPrintPreview.ImageList = this.imlButton;
            this.btnPrintPreview.Location = new System.Drawing.Point(800, 20);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(104, 28);
            this.btnPrintPreview.TabIndex = 169;
            this.btnPrintPreview.Text = "Xem báo cáo";
            this.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
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
            this.dedToDate.Size = new System.Drawing.Size(84, 22);
            this.dedToDate.TabIndex = 195;
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
            this.dedFromDate.Size = new System.Drawing.Size(84, 22);
            this.dedFromDate.TabIndex = 194;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(12, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 13);
            this.lblFromDate.TabIndex = 192;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(12, 40);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 13);
            this.lblToDate.TabIndex = 193;
            this.lblToDate.Text = "Đến ngày";
            // 
            // crvChangeSalary
            // 
            this.crvChangeSalary.ActiveViewIndex = -1;
            this.crvChangeSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crvChangeSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvChangeSalary.DisplayGroupTree = false;
            this.crvChangeSalary.Location = new System.Drawing.Point(0, 68);
            this.crvChangeSalary.Name = "crvChangeSalary";
            this.crvChangeSalary.SelectionFormula = "";
            this.crvChangeSalary.Size = new System.Drawing.Size(915, 367);
            this.crvChangeSalary.TabIndex = 199;
            this.crvChangeSalary.ViewTimeSelectionFormula = "";
            // 
            // dedDateOfIssue
            // 
            this.dedDateOfIssue.EditValue = null;
            this.dedDateOfIssue.Location = new System.Drawing.Point(228, 36);
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
            this.dedDateOfIssue.TabIndex = 203;
            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Location = new System.Drawing.Point(172, 40);
            this.lblDateOfIssue.Name = "lblDateOfIssue";
            this.lblDateOfIssue.Size = new System.Drawing.Size(49, 13);
            this.lblDateOfIssue.TabIndex = 202;
            this.lblDateOfIssue.Text = "Ngày lập";
            // 
            // txtTabMan
            // 
            this.txtTabMan.Location = new System.Drawing.Point(228, 12);
            this.txtTabMan.Name = "txtTabMan";
            this.txtTabMan.Size = new System.Drawing.Size(160, 21);
            this.txtTabMan.TabIndex = 201;
            // 
            // lblTabMan
            // 
            this.lblTabMan.AutoSize = true;
            this.lblTabMan.Location = new System.Drawing.Point(172, 16);
            this.lblTabMan.Name = "lblTabMan";
            this.lblTabMan.Size = new System.Drawing.Size(52, 13);
            this.lblTabMan.TabIndex = 200;
            this.lblTabMan.Text = "Người lập";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(532, 36);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(160, 21);
            this.txtDirector.TabIndex = 207;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(408, 40);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(50, 13);
            this.lblDirector.TabIndex = 206;
            this.lblDirector.Text = "Giám đốc";
            // 
            // txtPersonnelManager
            // 
            this.txtPersonnelManager.Location = new System.Drawing.Point(532, 12);
            this.txtPersonnelManager.Name = "txtPersonnelManager";
            this.txtPersonnelManager.Size = new System.Drawing.Size(160, 21);
            this.txtPersonnelManager.TabIndex = 205;
            // 
            // lblPersonnelManager
            // 
            this.lblPersonnelManager.AutoSize = true;
            this.lblPersonnelManager.Location = new System.Drawing.Point(408, 16);
            this.lblPersonnelManager.Name = "lblPersonnelManager";
            this.lblPersonnelManager.Size = new System.Drawing.Size(117, 13);
            this.lblPersonnelManager.TabIndex = 204;
            this.lblPersonnelManager.Text = "Trưởng phòng nhân sự";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "PrintPreviewHS.png");
            // 
            // ChangeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(915, 435);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.txtPersonnelManager);
            this.Controls.Add(this.lblPersonnelManager);
            this.Controls.Add(this.dedDateOfIssue);
            this.Controls.Add(this.lblDateOfIssue);
            this.Controls.Add(this.txtTabMan);
            this.Controls.Add(this.lblTabMan);
            this.Controls.Add(this.crvChangeSalary);
            this.Controls.Add(this.dedToDate);
            this.Controls.Add(this.dedFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.btnPrintPreview);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChangeSalary";
            this.Text = "Thay đổi mức lương";
            this.Load += new System.EventHandler(this.ChangeSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateOfIssue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPrintPreview;
        private DevExpress.XtraEditors.DateEdit dedToDate;
        private DevExpress.XtraEditors.DateEdit dedFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvChangeSalary;
        private DevExpress.XtraEditors.DateEdit dedDateOfIssue;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.TextBox txtTabMan;
        private System.Windows.Forms.Label lblTabMan;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtPersonnelManager;
        private System.Windows.Forms.Label lblPersonnelManager;
        internal System.Windows.Forms.ImageList imlButton;
    }
}