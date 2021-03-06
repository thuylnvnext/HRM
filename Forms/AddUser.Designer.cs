namespace HRMplus.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grcUser = new DevExpress.XtraEditors.GroupControl();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblVirtualData = new System.Windows.Forms.Label();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.lblMemberOf = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lueMemberOf = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRetypePassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.chkVirtualData = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.grcUserDetails = new DevExpress.XtraEditors.GroupControl();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtIDNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.dedBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).BeginInit();
            this.grcUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMemberOf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetypePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVirtualData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUserDetails)).BeginInit();
            this.grcUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedBirthDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedBirthDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "useradd.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // grcUser
            // 
            this.grcUser.Controls.Add(this.lblActive);
            this.grcUser.Controls.Add(this.lblVirtualData);
            this.grcUser.Controls.Add(this.chkActive);
            this.grcUser.Controls.Add(this.lblMemberOf);
            this.grcUser.Controls.Add(this.lblRetypePassword);
            this.grcUser.Controls.Add(this.lblName);
            this.grcUser.Controls.Add(this.lblPassword);
            this.grcUser.Controls.Add(this.lueMemberOf);
            this.grcUser.Controls.Add(this.txtRetypePassword);
            this.grcUser.Controls.Add(this.txtPassword);
            this.grcUser.Controls.Add(this.txtName);
            this.grcUser.Controls.Add(this.chkVirtualData);
            this.grcUser.Location = new System.Drawing.Point(12, 12);
            this.grcUser.Name = "grcUser";
            this.grcUser.Size = new System.Drawing.Size(276, 160);
            this.grcUser.TabIndex = 26;
            this.grcUser.Text = "Người sử dụng";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(188, 132);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(51, 13);
            this.lblActive.TabIndex = 211;
            this.lblActive.Text = "Kích hoạt";
            // 
            // lblVirtualData
            // 
            this.lblVirtualData.AutoSize = true;
            this.lblVirtualData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirtualData.Location = new System.Drawing.Point(12, 132);
            this.lblVirtualData.Name = "lblVirtualData";
            this.lblVirtualData.Size = new System.Drawing.Size(55, 13);
            this.lblVirtualData.TabIndex = 210;
            this.lblVirtualData.Text = "Dữ liệu ảo";
            // 
            // chkActive
            // 
            this.chkActive.EditValue = true;
            this.chkActive.Location = new System.Drawing.Point(248, 132);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.AutoWidth = true;
            this.chkActive.Properties.Caption = "";
            this.chkActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkActive.Size = new System.Drawing.Size(19, 19);
            this.chkActive.TabIndex = 209;
            // 
            // lblMemberOf
            // 
            this.lblMemberOf.AutoSize = true;
            this.lblMemberOf.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberOf.Location = new System.Drawing.Point(12, 108);
            this.lblMemberOf.Name = "lblMemberOf";
            this.lblMemberOf.Size = new System.Drawing.Size(65, 13);
            this.lblMemberOf.TabIndex = 19;
            this.lblMemberOf.Text = "Thuộc nhóm";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.Location = new System.Drawing.Point(12, 84);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(92, 13);
            this.lblRetypePassword.TabIndex = 17;
            this.lblRetypePassword.Text = "Nhập lại mật khẩu";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lueMemberOf
            // 
            this.lueMemberOf.Location = new System.Drawing.Point(108, 104);
            this.lueMemberOf.Name = "lueMemberOf";
            this.lueMemberOf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMemberOf.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueMemberOf.Properties.NullText = "";
            this.lueMemberOf.Properties.ShowHeader = false;
            this.lueMemberOf.Size = new System.Drawing.Size(156, 20);
            this.lueMemberOf.TabIndex = 207;
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Location = new System.Drawing.Point(108, 80);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtRetypePassword.Properties.PasswordChar = '*';
            this.txtRetypePassword.Size = new System.Drawing.Size(156, 20);
            this.txtRetypePassword.TabIndex = 206;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 205;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 32);
            this.txtName.Name = "txtName";
            this.txtName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 204;
            // 
            // chkVirtualData
            // 
            this.chkVirtualData.Location = new System.Drawing.Point(105, 132);
            this.chkVirtualData.Margin = new System.Windows.Forms.Padding(0);
            this.chkVirtualData.Name = "chkVirtualData";
            this.chkVirtualData.Properties.AutoWidth = true;
            this.chkVirtualData.Properties.Caption = "";
            this.chkVirtualData.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkVirtualData.Size = new System.Drawing.Size(19, 19);
            this.chkVirtualData.TabIndex = 208;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 211;
            this.label1.Text = "Dữ liệu ảo";
            // 
            // grcUserDetails
            // 
            this.grcUserDetails.Controls.Add(this.lblEmail);
            this.grcUserDetails.Controls.Add(this.lblPhone);
            this.grcUserDetails.Controls.Add(this.lblAddress);
            this.grcUserDetails.Controls.Add(this.lblIDNumber);
            this.grcUserDetails.Controls.Add(this.lblFullName);
            this.grcUserDetails.Controls.Add(this.lblBirthDate);
            this.grcUserDetails.Controls.Add(this.txtEmail);
            this.grcUserDetails.Controls.Add(this.txtPhone);
            this.grcUserDetails.Controls.Add(this.txtAddress);
            this.grcUserDetails.Controls.Add(this.txtIDNumber);
            this.grcUserDetails.Controls.Add(this.txtFullName);
            this.grcUserDetails.Controls.Add(this.dedBirthDate);
            this.grcUserDetails.Location = new System.Drawing.Point(12, 184);
            this.grcUserDetails.Name = "grcUserDetails";
            this.grcUserDetails.Size = new System.Drawing.Size(276, 184);
            this.grcUserDetails.TabIndex = 27;
            this.grcUserDetails.Text = "Chi tiết người sử dụng";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 13);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 108);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(12, 84);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(51, 13);
            this.lblIDNumber.TabIndex = 25;
            this.lblIDNumber.Text = "Số CMND";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 36);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 13);
            this.lblFullName.TabIndex = 23;
            this.lblFullName.Text = "Tên đầy đủ";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(12, 60);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 24;
            this.lblBirthDate.Text = "Ngày sinh";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 209;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 128);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPhone.Size = new System.Drawing.Size(176, 20);
            this.txtPhone.TabIndex = 208;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 104);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtAddress.Size = new System.Drawing.Size(176, 20);
            this.txtAddress.TabIndex = 207;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(88, 80);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtIDNumber.Size = new System.Drawing.Size(80, 20);
            this.txtIDNumber.TabIndex = 206;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(88, 32);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtFullName.Size = new System.Drawing.Size(176, 20);
            this.txtFullName.TabIndex = 205;
            // 
            // dedBirthDate
            // 
            this.dedBirthDate.EditValue = null;
            this.dedBirthDate.Location = new System.Drawing.Point(88, 56);
            this.dedBirthDate.Name = "dedBirthDate";
            this.dedBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedBirthDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedBirthDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedBirthDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedBirthDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedBirthDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedBirthDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedBirthDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedBirthDate.Size = new System.Drawing.Size(80, 20);
            this.dedBirthDate.TabIndex = 210;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(156, 380);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 212;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imlButton;
            this.btnAdd.Location = new System.Drawing.Point(68, 380);
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 28);
            this.btnAdd.TabIndex = 211;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUser
            // 
            this.AcceptButton = this.btnAdd;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(301, 419);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grcUserDetails);
            this.Controls.Add(this.grcUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm người sử dụng";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).EndInit();
            this.grcUser.ResumeLayout(false);
            this.grcUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMemberOf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetypePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVirtualData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUserDetails)).EndInit();
            this.grcUserDetails.ResumeLayout(false);
            this.grcUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedBirthDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedBirthDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.GroupControl grcUser;
        internal System.Windows.Forms.Label lblMemberOf;
        internal System.Windows.Forms.Label lblRetypePassword;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblPassword;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtRetypePassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LookUpEdit lueMemberOf;
        private DevExpress.XtraEditors.CheckEdit chkVirtualData;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblVirtualData;
        internal System.Windows.Forms.Label lblActive;
        private DevExpress.XtraEditors.GroupControl grcUserDetails;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.Label lblAddress;
        internal System.Windows.Forms.Label lblIDNumber;
        internal System.Windows.Forms.Label lblFullName;
        internal System.Windows.Forms.Label lblBirthDate;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtIDNumber;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.DateEdit dedBirthDate;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}