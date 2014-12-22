namespace HRMplus.UserControls
{
    partial class PermissionByMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionByMenu));
            this.tvwMenu = new System.Windows.Forms.TreeView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.chkDisable = new DevExpress.XtraEditors.CheckEdit();
            this.chkEnable = new DevExpress.XtraEditors.CheckEdit();
            this.imlPermission = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chkDisable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwMenu
            // 
            this.tvwMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwMenu.CheckBoxes = true;
            this.tvwMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwMenu.Location = new System.Drawing.Point(12, 12);
            this.tvwMenu.Name = "tvwMenu";
            this.tvwMenu.Size = new System.Drawing.Size(396, 328);
            this.tvwMenu.TabIndex = 17;
            this.tvwMenu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwMenu_AfterCheck);
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
            this.chkDisable.EditValue = true;
            this.chkDisable.Location = new System.Drawing.Point(132, 356);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Properties.Caption = "Không được phép";
            this.chkDisable.Size = new System.Drawing.Size(112, 19);
            this.chkDisable.TabIndex = 172;
            // 
            // chkEnable
            // 
            this.chkEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // PermissionByMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDisable);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.tvwMenu);
            this.Name = "PermissionByMenu";
            this.Size = new System.Drawing.Size(419, 391);
            this.Load += new System.EventHandler(this.PermissionByMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkDisable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TreeView tvwMenu;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckEdit chkDisable;
        private DevExpress.XtraEditors.CheckEdit chkEnable;
        internal System.Windows.Forms.ImageList imlButton;
        internal System.Windows.Forms.ImageList imlPermission;
    }
}
