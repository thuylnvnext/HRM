namespace Common
{
    partial class SetGridBand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGridBand));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.cleBackColor = new DevExpress.XtraEditors.ColorEdit();
            this.txtWidth = new DevExpress.XtraEditors.TextEdit();
            this.txtRowCount = new DevExpress.XtraEditors.TextEdit();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cleBackColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(12, 16);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(42, 13);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Tiêu đề";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(12, 40);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(46, 13);
            this.lblRowCount.TabIndex = 2;
            this.lblRowCount.Text = "Số dòng";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(128, 40);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Độ rộng";
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(12, 64);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(48, 13);
            this.lblBackColor.TabIndex = 8;
            this.lblBackColor.Text = "Mầu nền";
            // 
            // cleBackColor
            // 
            this.cleBackColor.EditValue = System.Drawing.Color.Empty;
            this.cleBackColor.Location = new System.Drawing.Point(64, 60);
            this.cleBackColor.Name = "cleBackColor";
            this.cleBackColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cleBackColor.Size = new System.Drawing.Size(52, 20);
            this.cleBackColor.TabIndex = 9;
            this.cleBackColor.EditValueChanged += new System.EventHandler(this.cleBackColor_EditValueChanged);
            this.cleBackColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cleBackColor_KeyDown);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(180, 36);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Properties.Appearance.Options.UseTextOptions = true;
            this.txtWidth.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtWidth.Size = new System.Drawing.Size(80, 20);
            this.txtWidth.TabIndex = 198;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtRowCount
            // 
            this.txtRowCount.Location = new System.Drawing.Point(64, 36);
            this.txtRowCount.Name = "txtRowCount";
            this.txtRowCount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRowCount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRowCount.Size = new System.Drawing.Size(52, 20);
            this.txtRowCount.TabIndex = 197;
            this.txtRowCount.TextChanged += new System.EventHandler(this.txtRowCount_TextChanged);
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(64, 12);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(196, 20);
            this.txtCaption.TabIndex = 196;
            this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(56, 92);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 199;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(144, 92);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 200;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SetGridBand
            // 
            this.AcceptButton = this.btnSave;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 132);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtRowCount);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.cleBackColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblRowCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetGridBand";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập cột tham số";
            this.Load += new System.EventHandler(this.SetGridBand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cleBackColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblBackColor;
        private DevExpress.XtraEditors.ColorEdit cleBackColor;
        private DevExpress.XtraEditors.TextEdit txtWidth;
        private DevExpress.XtraEditors.TextEdit txtRowCount;
        private DevExpress.XtraEditors.TextEdit txtCaption;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;

    }
}