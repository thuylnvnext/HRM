namespace HRMplus.UserControls
{
    partial class SystemOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemOption));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.chkAutoUpdate = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(180, 124);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 170;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.Location = new System.Drawing.Point(12, 12);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Properties.Caption = "Tự động cập nhật phiên bản mới";
            this.chkAutoUpdate.Size = new System.Drawing.Size(184, 19);
            this.chkAutoUpdate.TabIndex = 171;
            // 
            // SystemOption
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "SystemOption";
            this.Size = new System.Drawing.Size(266, 161);
            this.Load += new System.EventHandler(this.SystemOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoUpdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.CheckEdit chkAutoUpdate;
    }
}
