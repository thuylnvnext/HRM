namespace HRMplus.Forms
{
    partial class ConnectDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectDatabase));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rdbWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.rdbSQLServerAuthentication = new System.Windows.Forms.RadioButton();
            this.cboServerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboDatabaseName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportFromFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToFile = new DevExpress.XtraEditors.SimpleButton();
            this.sfdExportToFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdImportFromFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cboServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "run-icon.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(12, 140);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(69, 13);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Cơ sở dữ liệu";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(12, 16);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(68, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Tên máy chủ";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 92);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // rdbWindowsAuthentication
            // 
            this.rdbWindowsAuthentication.AutoSize = true;
            this.rdbWindowsAuthentication.BackColor = System.Drawing.Color.Transparent;
            this.rdbWindowsAuthentication.Location = new System.Drawing.Point(12, 40);
            this.rdbWindowsAuthentication.Name = "rdbWindowsAuthentication";
            this.rdbWindowsAuthentication.Size = new System.Drawing.Size(178, 17);
            this.rdbWindowsAuthentication.TabIndex = 2;
            this.rdbWindowsAuthentication.Text = "Sử dụng xác nhận của Windows";
            this.rdbWindowsAuthentication.UseVisualStyleBackColor = false;
            this.rdbWindowsAuthentication.CheckedChanged += new System.EventHandler(this.rdbWindowsAuthentication_CheckedChanged);
            // 
            // rdbSQLServerAuthentication
            // 
            this.rdbSQLServerAuthentication.AutoSize = true;
            this.rdbSQLServerAuthentication.BackColor = System.Drawing.Color.Transparent;
            this.rdbSQLServerAuthentication.Checked = true;
            this.rdbSQLServerAuthentication.Location = new System.Drawing.Point(12, 64);
            this.rdbSQLServerAuthentication.Name = "rdbSQLServerAuthentication";
            this.rdbSQLServerAuthentication.Size = new System.Drawing.Size(189, 17);
            this.rdbSQLServerAuthentication.TabIndex = 3;
            this.rdbSQLServerAuthentication.TabStop = true;
            this.rdbSQLServerAuthentication.Text = "Sử dụng xác nhận của SQL Server";
            this.rdbSQLServerAuthentication.UseVisualStyleBackColor = false;
            // 
            // cboServerName
            // 
            this.cboServerName.Location = new System.Drawing.Point(92, 12);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboServerName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboServerName.Size = new System.Drawing.Size(260, 20);
            this.cboServerName.TabIndex = 1;
            this.cboServerName.SelectedIndexChanged += new System.EventHandler(this.cboServerName_SelectedIndexChanged);
            // 
            // cboDatabaseName
            // 
            this.cboDatabaseName.Location = new System.Drawing.Point(92, 136);
            this.cboDatabaseName.Name = "cboDatabaseName";
            this.cboDatabaseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDatabaseName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboDatabaseName.Size = new System.Drawing.Size(260, 20);
            this.cboDatabaseName.TabIndex = 9;
            this.cboDatabaseName.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboDatabaseName_QueryPopUp);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(92, 88);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtLogin.Size = new System.Drawing.Size(260, 20);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.ImageIndex = 0;
            this.btnChange.ImageList = this.imlButton;
            this.btnChange.Location = new System.Drawing.Point(24, 168);
            this.btnChange.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(76, 28);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "&Thiết lập";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(264, 168);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImportFromFile
            // 
            this.btnImportFromFile.ImageIndex = 0;
            this.btnImportFromFile.Location = new System.Drawing.Point(104, 168);
            this.btnImportFromFile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnImportFromFile.Name = "btnImportFromFile";
            this.btnImportFromFile.Size = new System.Drawing.Size(76, 28);
            this.btnImportFromFile.TabIndex = 11;
            this.btnImportFromFile.Text = "Nhập từ file";
            this.btnImportFromFile.Click += new System.EventHandler(this.btnImportFromFile_Click);
            // 
            // btnExportToFile
            // 
            this.btnExportToFile.ImageIndex = 0;
            this.btnExportToFile.Location = new System.Drawing.Point(184, 168);
            this.btnExportToFile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExportToFile.Name = "btnExportToFile";
            this.btnExportToFile.Size = new System.Drawing.Size(76, 28);
            this.btnExportToFile.TabIndex = 12;
            this.btnExportToFile.Text = "Xuất ra file";
            this.btnExportToFile.Click += new System.EventHandler(this.btnExportToFile_Click);
            // 
            // sfdExportToFile
            // 
            this.sfdExportToFile.Filter = "Config file (*.cfg)|*.cfg";
            // 
            // ofdImportFromFile
            // 
            this.ofdImportFromFile.Filter = "Config file (*.cfg)|*.cfg";
            // 
            // ConnectDatabase
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 205);
            this.Controls.Add(this.btnExportToFile);
            this.Controls.Add(this.btnImportFromFile);
            this.Controls.Add(this.rdbSQLServerAuthentication);
            this.Controls.Add(this.rdbWindowsAuthentication);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.cboDatabaseName);
            this.Controls.Add(this.cboServerName);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectDatabase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.ChangeDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeDatabase_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cboServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblDatabase;
        internal System.Windows.Forms.Label lblServerName;
        internal System.Windows.Forms.Label lblLogin;
        internal System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RadioButton rdbWindowsAuthentication;
        private System.Windows.Forms.RadioButton rdbSQLServerAuthentication;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.ComboBoxEdit cboServerName;
        private DevExpress.XtraEditors.ComboBoxEdit cboDatabaseName;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnImportFromFile;
        private DevExpress.XtraEditors.SimpleButton btnExportToFile;
        private System.Windows.Forms.SaveFileDialog sfdExportToFile;
        private System.Windows.Forms.OpenFileDialog ofdImportFromFile;
    }
}