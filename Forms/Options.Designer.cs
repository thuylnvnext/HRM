namespace HRMplus.Forms
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtpCompany = new DevExpress.XtraTab.XtraTabPage();
            this.company1 = new HRMplus.UserControls.CompanyOption();
            this.xtpReader = new DevExpress.XtraTab.XtraTabPage();
            this.readerOption1 = new HRMplus.UserControls.ReaderOption();
            this.xtpDisplay = new DevExpress.XtraTab.XtraTabPage();
            this.display1 = new HRMplus.UserControls.DisplayOption();
            this.xtcOptions = new DevExpress.XtraTab.XtraTabControl();
            this.xtpSystem = new DevExpress.XtraTab.XtraTabPage();
            this.systemOption1 = new HRMplus.UserControls.SystemOption();
            this.xtpCheckVersion = new DevExpress.XtraTab.XtraTabPage();
            this.checkVersionOption = new HRMplus.UserControls.CheckVersionOption();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtpCompany.SuspendLayout();
            this.xtpReader.SuspendLayout();
            this.xtpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcOptions)).BeginInit();
            this.xtcOptions.SuspendLayout();
            this.xtpSystem.SuspendLayout();
            this.xtpCheckVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "Windows-Close-Program-icon.png");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(275, 322);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 169;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // xtpCompany
            // 
            this.xtpCompany.Controls.Add(this.company1);
            this.xtpCompany.Name = "xtpCompany";
            this.xtpCompany.Size = new System.Drawing.Size(597, 271);
            this.xtpCompany.Text = "Công ty";
            // 
            // company1
            // 
            this.company1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.company1.Location = new System.Drawing.Point(0, 0);
            this.company1.Name = "company1";
            this.company1.Size = new System.Drawing.Size(597, 271);
            this.company1.TabIndex = 0;
            // 
            // xtpReader
            // 
            this.xtpReader.Controls.Add(this.readerOption1);
            this.xtpReader.Name = "xtpReader";
            this.xtpReader.Size = new System.Drawing.Size(597, 271);
            this.xtpReader.Text = "Đầu đọc";
            // 
            // readerOption1
            // 
            this.readerOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerOption1.Location = new System.Drawing.Point(0, 0);
            this.readerOption1.Name = "readerOption1";
            this.readerOption1.Size = new System.Drawing.Size(597, 271);
            this.readerOption1.TabIndex = 0;
            // 
            // xtpDisplay
            // 
            this.xtpDisplay.Controls.Add(this.display1);
            this.xtpDisplay.Name = "xtpDisplay";
            this.xtpDisplay.Size = new System.Drawing.Size(597, 271);
            this.xtpDisplay.Text = "Hiển thị";
            // 
            // display1
            // 
            this.display1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display1.Appearance.Options.UseFont = true;
            this.display1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display1.Location = new System.Drawing.Point(0, 0);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(597, 271);
            this.display1.TabIndex = 0;
            // 
            // xtcOptions
            // 
            this.xtcOptions.Location = new System.Drawing.Point(12, 12);
            this.xtcOptions.Name = "xtcOptions";
            this.xtcOptions.SelectedTabPage = this.xtpDisplay;
            this.xtcOptions.Size = new System.Drawing.Size(604, 300);
            this.xtcOptions.TabIndex = 170;
            this.xtcOptions.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpSystem,
            this.xtpDisplay,
            this.xtpReader,
            this.xtpCompany,
            this.xtpCheckVersion});
            // 
            // xtpSystem
            // 
            this.xtpSystem.Controls.Add(this.systemOption1);
            this.xtpSystem.Name = "xtpSystem";
            this.xtpSystem.Size = new System.Drawing.Size(597, 271);
            this.xtpSystem.Text = "Hệ thống";
            // 
            // systemOption1
            // 
            this.systemOption1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemOption1.Appearance.Options.UseFont = true;
            this.systemOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemOption1.Location = new System.Drawing.Point(0, 0);
            this.systemOption1.Name = "systemOption1";
            this.systemOption1.Size = new System.Drawing.Size(597, 271);
            this.systemOption1.TabIndex = 0;
            // 
            // xtpCheckVersion
            // 
            this.xtpCheckVersion.Controls.Add(this.checkVersionOption);
            this.xtpCheckVersion.Name = "xtpCheckVersion";
            this.xtpCheckVersion.Size = new System.Drawing.Size(597, 271);
            this.xtpCheckVersion.Text = "Cập nhật phiên bản";
            // 
            // checkVersionOption
            // 
            this.checkVersionOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkVersionOption.Location = new System.Drawing.Point(0, 0);
            this.checkVersionOption.Name = "checkVersionOption";
            this.checkVersionOption.Size = new System.Drawing.Size(597, 271);
            this.checkVersionOption.TabIndex = 0;
            // 
            // popupMenu
            // 
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.MaxItemId = 0;
            // 
            // Options
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 360);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.xtcOptions);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtpCompany.ResumeLayout(false);
            this.xtpReader.ResumeLayout(false);
            this.xtpDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcOptions)).EndInit();
            this.xtcOptions.ResumeLayout(false);
            this.xtpSystem.ResumeLayout(false);
            this.xtpCheckVersion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtpCompany;
        private DevExpress.XtraTab.XtraTabPage xtpReader;
        private DevExpress.XtraTab.XtraTabPage xtpDisplay;
        private HRMplus.UserControls.DisplayOption display1;
        private DevExpress.XtraTab.XtraTabControl xtcOptions;
        private HRMplus.UserControls.CompanyOption company1;
        private HRMplus.UserControls.ReaderOption readerOption1;
        private DevExpress.XtraTab.XtraTabPage xtpSystem;
        private HRMplus.UserControls.SystemOption systemOption1;
        private DevExpress.XtraTab.XtraTabPage xtpCheckVersion;
        private HRMplus.UserControls.CheckVersionOption checkVersionOption;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;

    }
}