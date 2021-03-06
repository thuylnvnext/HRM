namespace HRMplus.Forms
{
    partial class Permission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permission));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.xtcPermission = new DevExpress.XtraTab.XtraTabControl();
            this.xtpDepartment = new DevExpress.XtraTab.XtraTabPage();
            this.permissionByDepartment1 = new HRMplus.UserControls.PermissionByDepartment();
            this.xtpMenu = new DevExpress.XtraTab.XtraTabPage();
            this.permissionByMenu1 = new HRMplus.UserControls.PermissionByMenu();
            this.xtpCommandButton = new DevExpress.XtraTab.XtraTabPage();
            this.permissionByCommandButton1 = new HRMplus.UserControls.PermissionByCommandButton();
            this.xtpReader = new DevExpress.XtraTab.XtraTabPage();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.permissionByReader1 = new HRMplus.UserControls.PermissionByReader();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPermission)).BeginInit();
            this.xtcPermission.SuspendLayout();
            this.xtpDepartment.SuspendLayout();
            this.xtpMenu.SuspendLayout();
            this.xtpCommandButton.SuspendLayout();
            this.xtpReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "Windows-Close-Program-icon.png");
            // 
            // xtcPermission
            // 
            this.xtcPermission.Location = new System.Drawing.Point(12, 12);
            this.xtcPermission.Name = "xtcPermission";
            this.xtcPermission.SelectedTabPage = this.xtpDepartment;
            this.xtcPermission.Size = new System.Drawing.Size(432, 416);
            this.xtcPermission.TabIndex = 16;
            this.xtcPermission.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpDepartment,
            this.xtpMenu,
            this.xtpCommandButton,
            this.xtpReader});
            // 
            // xtpDepartment
            // 
            this.xtpDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtpDepartment.Controls.Add(this.permissionByDepartment1);
            this.xtpDepartment.Name = "xtpDepartment";
            this.xtpDepartment.Size = new System.Drawing.Size(423, 385);
            this.xtpDepartment.Text = "Theo phòng ban";
            // 
            // permissionByDepartment1
            // 
            this.permissionByDepartment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionByDepartment1.Location = new System.Drawing.Point(0, 0);
            this.permissionByDepartment1.Name = "permissionByDepartment1";
            this.permissionByDepartment1.Size = new System.Drawing.Size(423, 385);
            this.permissionByDepartment1.TabIndex = 0;
            // 
            // xtpMenu
            // 
            this.xtpMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtpMenu.Controls.Add(this.permissionByMenu1);
            this.xtpMenu.Name = "xtpMenu";
            this.xtpMenu.Size = new System.Drawing.Size(423, 385);
            this.xtpMenu.Text = "Theo thực đơn";
            // 
            // permissionByMenu1
            // 
            this.permissionByMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionByMenu1.Location = new System.Drawing.Point(0, 0);
            this.permissionByMenu1.Name = "permissionByMenu1";
            this.permissionByMenu1.Size = new System.Drawing.Size(423, 385);
            this.permissionByMenu1.TabIndex = 0;
            // 
            // xtpCommandButton
            // 
            this.xtpCommandButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtpCommandButton.Controls.Add(this.permissionByCommandButton1);
            this.xtpCommandButton.Name = "xtpCommandButton";
            this.xtpCommandButton.Size = new System.Drawing.Size(423, 385);
            this.xtpCommandButton.Text = "Theo nút lệnh";
            // 
            // permissionByCommandButton1
            // 
            this.permissionByCommandButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionByCommandButton1.Location = new System.Drawing.Point(0, 0);
            this.permissionByCommandButton1.Name = "permissionByCommandButton1";
            this.permissionByCommandButton1.Size = new System.Drawing.Size(423, 385);
            this.permissionByCommandButton1.TabIndex = 0;
            // 
            // xtpReader
            // 
            this.xtpReader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtpReader.Controls.Add(this.permissionByReader1);
            this.xtpReader.Name = "xtpReader";
            this.xtpReader.Size = new System.Drawing.Size(423, 385);
            this.xtpReader.Text = "Theo đầu đọc";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(189, 440);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 178;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // permissionByReader1
            // 
            this.permissionByReader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionByReader1.Location = new System.Drawing.Point(0, 0);
            this.permissionByReader1.Name = "permissionByReader1";
            this.permissionByReader1.Size = new System.Drawing.Size(423, 385);
            this.permissionByReader1.TabIndex = 0;
            // 
            // Permission
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.xtcPermission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Permission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.Permission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtcPermission)).EndInit();
            this.xtcPermission.ResumeLayout(false);
            this.xtpDepartment.ResumeLayout(false);
            this.xtpMenu.ResumeLayout(false);
            this.xtpCommandButton.ResumeLayout(false);
            this.xtpReader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraTab.XtraTabControl xtcPermission;
        private DevExpress.XtraTab.XtraTabPage xtpDepartment;
        private DevExpress.XtraTab.XtraTabPage xtpMenu;
        private DevExpress.XtraTab.XtraTabPage xtpCommandButton;
        private HRMplus.UserControls.PermissionByDepartment permissionByDepartment1;
        private HRMplus.UserControls.PermissionByMenu permissionByMenu1;
        private HRMplus.UserControls.PermissionByCommandButton permissionByCommandButton1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraTab.XtraTabPage xtpReader;
        private HRMplus.UserControls.PermissionByReader permissionByReader1;
    }
}