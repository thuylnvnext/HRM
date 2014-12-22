namespace HRMplus.UserControls
{
    partial class PermissionByDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionByDepartment));
            this.chkEnable = new DevExpress.XtraEditors.CheckEdit();
            this.chkDisable = new DevExpress.XtraEditors.CheckEdit();
            this.imlPermission = new System.Windows.Forms.ImageList(this.components);
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.tvwDepartment = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEnable
            // 
            this.chkEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEnable.EditValue = true;
            this.chkEnable.Location = new System.Drawing.Point(12, 356);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Properties.Caption = "Được phép";
            this.chkEnable.Size = new System.Drawing.Size(80, 19);
            this.chkEnable.TabIndex = 22;
            // 
            // chkDisable
            // 
            this.chkDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDisable.Location = new System.Drawing.Point(132, 356);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Properties.Caption = "Không được phép";
            this.chkDisable.Size = new System.Drawing.Size(112, 19);
            this.chkDisable.TabIndex = 23;
            // 
            // imlPermission
            // 
            this.imlPermission.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPermission.ImageStream")));
            this.imlPermission.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPermission.Images.SetKeyName(0, "home_24.gif");
            this.imlPermission.Images.SetKeyName(1, "icon_users_16px.gif");
            this.imlPermission.Images.SetKeyName(2, "LegendHS.png");
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "run-icon.png");
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
            this.btnOK.TabIndex = 170;
            this.btnOK.Text = "&Thiết lập";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tvwDepartment
            // 
            this.tvwDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwDepartment.CheckBoxes = true;
            this.tvwDepartment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwDepartment.ImageIndex = 0;
            this.tvwDepartment.ImageList = this.imlPermission;
            this.tvwDepartment.Location = new System.Drawing.Point(12, 12);
            this.tvwDepartment.Name = "tvwDepartment";
            this.tvwDepartment.SelectedImageIndex = 0;
            this.tvwDepartment.Size = new System.Drawing.Size(396, 328);
            this.tvwDepartment.TabIndex = 171;
            this.tvwDepartment.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwDepartment_AfterCheck);
            // 
            // PermissionByDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvwDepartment);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDisable);
            this.Controls.Add(this.chkEnable);
            this.Name = "PermissionByDepartment";
            this.Size = new System.Drawing.Size(419, 391);
            this.Load += new System.EventHandler(this.PermissionByDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkEnable;
        private DevExpress.XtraEditors.CheckEdit chkDisable;
        internal System.Windows.Forms.ImageList imlPermission;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        internal System.Windows.Forms.TreeView tvwDepartment;
    }
}
