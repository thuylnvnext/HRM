namespace Personnel.Forms
{
    partial class InfoDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDetails));
            this.imlInfoGroup = new System.Windows.Forms.ImageList(this.components);
            this.spcEmployeeInfo = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupInfo = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemGeneralInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemIDCard = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemCurrentWorking = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lueEmployeeName = new DevExpress.XtraEditors.LookUpEdit();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.imageLargeCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.spcEmployeeInfo.Panel1.SuspendLayout();
            this.spcEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargeCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // imlInfoGroup
            // 
            this.imlInfoGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlInfoGroup.ImageStream")));
            this.imlInfoGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlInfoGroup.Images.SetKeyName(0, "check-user-32x32.png");
            this.imlInfoGroup.Images.SetKeyName(1, "1352296005_user-male-information.png");
            this.imlInfoGroup.Images.SetKeyName(2, "1352296351_ID.png");
            this.imlInfoGroup.Images.SetKeyName(3, "1352296450_length-measure.png");
            this.imlInfoGroup.Images.SetKeyName(4, "1352296661_preferences-desktop-user.png");
            // 
            // spcEmployeeInfo
            // 
            this.spcEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spcEmployeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcEmployeeInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcEmployeeInfo.Location = new System.Drawing.Point(12, 44);
            this.spcEmployeeInfo.Name = "spcEmployeeInfo";
            // 
            // spcEmployeeInfo.Panel1
            // 
            this.spcEmployeeInfo.Panel1.Controls.Add(this.navBarControl1);
            // 
            // spcEmployeeInfo.Panel2
            // 
            this.spcEmployeeInfo.Panel2.AutoScroll = true;
            this.spcEmployeeInfo.Panel2.Resize += new System.EventHandler(this.spcEmployeeInfo_Panel2_Resize);
            this.spcEmployeeInfo.Size = new System.Drawing.Size(937, 472);
            this.spcEmployeeInfo.SplitterDistance = 211;
            this.spcEmployeeInfo.TabIndex = 83;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupInfo;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupInfo,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemGeneralInfo,
            this.navBarItemIDCard,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItemCurrentWorking});
            this.navBarControl1.LargeImages = this.imageLargeCollection;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 131;
            this.navBarControl1.Size = new System.Drawing.Size(209, 470);
            this.navBarControl1.SmallImages = this.imageLargeCollection;
            this.navBarControl1.TabIndex = 15;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroupInfo
            // 
            this.navBarGroupInfo.Caption = "Thông tin cá nhân";
            this.navBarGroupInfo.Expanded = true;
            this.navBarGroupInfo.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroupInfo.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroupInfo.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemGeneralInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemIDCard)});
            this.navBarGroupInfo.Name = "navBarGroupInfo";
            // 
            // navBarItemGeneralInfo
            // 
            this.navBarItemGeneralInfo.Caption = "Thông tin chung";
            this.navBarItemGeneralInfo.LargeImageIndex = 12;
            this.navBarItemGeneralInfo.Name = "navBarItemGeneralInfo";
            this.navBarItemGeneralInfo.SmallImageIndex = 12;
            this.navBarItemGeneralInfo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItemIDCard
            // 
            this.navBarItemIDCard.Caption = "Thông tin pháp lý";
            this.navBarItemIDCard.LargeImageIndex = 11;
            this.navBarItemIDCard.Name = "navBarItemIDCard";
            this.navBarItemIDCard.SmallImageIndex = 2;
            this.navBarItemIDCard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Quá trình công tác";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemCurrentWorking)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItemCurrentWorking
            // 
            this.navBarItemCurrentWorking.Caption = "Quá trình làm việc tại công ty";
            this.navBarItemCurrentWorking.LargeImageIndex = 4;
            this.navBarItemCurrentWorking.Name = "navBarItemCurrentWorking";
            this.navBarItemCurrentWorking.SmallImageIndex = 4;
            this.navBarItemCurrentWorking.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Trình độ chuyên môn";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Trình độ khác";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(12, 16);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(118, 13);
            this.lblEmployee.TabIndex = 84;
            this.lblEmployee.Text = "Thông tin nhân viên";
            // 
            // lueEmployeeName
            // 
            this.lueEmployeeName.Location = new System.Drawing.Point(192, 12);
            this.lueEmployeeName.Name = "lueEmployeeName";
            this.lueEmployeeName.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lueEmployeeName.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueEmployeeName.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.lueEmployeeName.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lueEmployeeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeeName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Họ và tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueEmployeeName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lueEmployeeName.Properties.NullText = "";
            this.lueEmployeeName.Size = new System.Drawing.Size(204, 20);
            this.lueEmployeeName.TabIndex = 190;
            this.lueEmployeeName.EditValueChanged += new System.EventHandler(this.lueEmployeeName_EditValueChanged);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(140, 12);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeCode.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtEmployeeCode.Size = new System.Drawing.Size(40, 20);
            this.txtEmployeeCode.TabIndex = 192;
            this.txtEmployeeCode.EditValueChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged);
            // 
            // imageLargeCollection
            // 
            this.imageLargeCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageLargeCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageLargeCollection.ImageStream")));
            this.imageLargeCollection.Images.SetKeyName(0, "1349626096_Login Manager.png");
            this.imageLargeCollection.Images.SetKeyName(1, "AQUA ICONS SYSTEM KEYS.png");
            this.imageLargeCollection.Images.SetKeyName(2, "LogOff2.png");
            this.imageLargeCollection.Images.SetKeyName(3, "Users.png");
            this.imageLargeCollection.Images.SetKeyName(4, "User.png");
            this.imageLargeCollection.Images.SetKeyName(5, "database.png");
            this.imageLargeCollection.Images.SetKeyName(6, "db_add.png");
            this.imageLargeCollection.Images.SetKeyName(7, "db_comit.png");
            this.imageLargeCollection.Images.SetKeyName(8, "db_remove.png");
            this.imageLargeCollection.Images.SetKeyName(9, "db_status.png");
            this.imageLargeCollection.Images.SetKeyName(10, "db_update.png");
            this.imageLargeCollection.Images.SetKeyName(11, "1349664062_preferences-contact-list.png");
            this.imageLargeCollection.Images.SetKeyName(12, "1352296661_preferences-desktop-user.png");
            // 
            // InfoDetails
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 529);
            this.Controls.Add(this.lueEmployeeName);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.spcEmployeeInfo);
            this.Controls.Add(this.txtEmployeeCode);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "InfoDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.InfoDetails_Load);
            this.spcEmployeeInfo.Panel1.ResumeLayout(false);
            this.spcEmployeeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargeCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcEmployeeInfo;
        internal System.Windows.Forms.ImageList imlInfoGroup;
        private System.Windows.Forms.Label lblEmployee;
        private DevExpress.XtraEditors.LookUpEdit lueEmployeeName;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupInfo;
        private DevExpress.XtraNavBar.NavBarItem navBarItemGeneralInfo;
        private DevExpress.XtraNavBar.NavBarItem navBarItemIDCard;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItemCurrentWorking;
        private DevExpress.Utils.ImageCollection imageLargeCollection;

    }
}