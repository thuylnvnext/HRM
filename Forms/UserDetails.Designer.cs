namespace HRMplus.Forms
{
    partial class UserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grcAvailableUsers = new DevExpress.XtraEditors.GroupControl();
            this.lbcAvailableUsers = new DevExpress.XtraEditors.ListBoxControl();
            this.grcMemberOf = new DevExpress.XtraEditors.GroupControl();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcAvailableUsers)).BeginInit();
            this.grcAvailableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAvailableUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMemberOf)).BeginInit();
            this.grcMemberOf.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "NewDocumentHS.png");
            this.imlButton.Images.SetKeyName(1, "EditInformationHS.png");
            this.imlButton.Images.SetKeyName(2, "");
            this.imlButton.Images.SetKeyName(3, "Windows-Close-Program-icon.png");
            // 
            // grcAvailableUsers
            // 
            this.grcAvailableUsers.Controls.Add(this.lbcAvailableUsers);
            this.grcAvailableUsers.Location = new System.Drawing.Point(12, 12);
            this.grcAvailableUsers.Name = "grcAvailableUsers";
            this.grcAvailableUsers.Size = new System.Drawing.Size(196, 188);
            this.grcAvailableUsers.TabIndex = 29;
            this.grcAvailableUsers.Text = "Danh sách người sử dụng";
            // 
            // lbcAvailableUsers
            // 
            this.lbcAvailableUsers.Location = new System.Drawing.Point(12, 32);
            this.lbcAvailableUsers.Name = "lbcAvailableUsers";
            this.lbcAvailableUsers.Size = new System.Drawing.Size(172, 144);
            this.lbcAvailableUsers.TabIndex = 0;
            this.lbcAvailableUsers.SelectedIndexChanged += new System.EventHandler(this.lbcAvailableUsers_SelectedIndexChanged);
            // 
            // grcMemberOf
            // 
            this.grcMemberOf.Controls.Add(this.lblGroup);
            this.grcMemberOf.Location = new System.Drawing.Point(12, 212);
            this.grcMemberOf.Name = "grcMemberOf";
            this.grcMemberOf.Size = new System.Drawing.Size(196, 56);
            this.grcMemberOf.TabIndex = 30;
            this.grcMemberOf.Text = "Thuộc nhóm";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(12, 32);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Nhóm";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imlButton;
            this.btnAdd.Location = new System.Drawing.Point(220, 64);
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 28);
            this.btnAdd.TabIndex = 207;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.ImageList = this.imlButton;
            this.btnEdit.Location = new System.Drawing.Point(220, 100);
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 28);
            this.btnEdit.TabIndex = 208;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(220, 136);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 209;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 3;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(220, 172);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 210;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UserDetails
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 281);
            this.Controls.Add(this.grcMemberOf);
            this.Controls.Add(this.grcAvailableUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người sử dụng";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcAvailableUsers)).EndInit();
            this.grcAvailableUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcAvailableUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMemberOf)).EndInit();
            this.grcMemberOf.ResumeLayout(false);
            this.grcMemberOf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.GroupControl grcAvailableUsers;
        private DevExpress.XtraEditors.ListBoxControl lbcAvailableUsers;
        private DevExpress.XtraEditors.GroupControl grcMemberOf;
        internal System.Windows.Forms.Label lblGroup;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}