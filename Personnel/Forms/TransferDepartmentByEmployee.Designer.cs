namespace Personnel.Forms
{
    partial class TransferDepartmentByEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferDepartmentByEmployee));
            this.lblNewDepartment = new System.Windows.Forms.Label();
            this.lblCurrentDepartment = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.lblNewPosition = new System.Windows.Forms.Label();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.dedCurrentDate = new DevExpress.XtraEditors.DateEdit();
            this.dedNewDate = new DevExpress.XtraEditors.DateEdit();
            this.lueCurrentDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.lueNewDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCurrentPosition = new DevExpress.XtraEditors.LookUpEdit();
            this.lueNewPosition = new DevExpress.XtraEditors.LookUpEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dedCurrentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedCurrentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedNewDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedNewDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCurrentDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNewDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCurrentPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNewPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewDepartment
            // 
            this.lblNewDepartment.AutoSize = true;
            this.lblNewDepartment.Location = new System.Drawing.Point(300, 16);
            this.lblNewDepartment.Name = "lblNewDepartment";
            this.lblNewDepartment.Size = new System.Drawing.Size(117, 13);
            this.lblNewDepartment.TabIndex = 58;
            this.lblNewDepartment.Text = "Phòng ban chuyển đến";
            // 
            // lblCurrentDepartment
            // 
            this.lblCurrentDepartment.AutoSize = true;
            this.lblCurrentDepartment.Location = new System.Drawing.Point(12, 16);
            this.lblCurrentDepartment.Name = "lblCurrentDepartment";
            this.lblCurrentDepartment.Size = new System.Drawing.Size(96, 13);
            this.lblCurrentDepartment.TabIndex = 55;
            this.lblCurrentDepartment.Text = "Phòng ban hiện tại";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(12, 40);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(53, 13);
            this.lblCurrentDate.TabIndex = 123;
            this.lblCurrentDate.Text = "Ngày vào";
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Location = new System.Drawing.Point(12, 64);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(47, 13);
            this.lblCurrentPosition.TabIndex = 125;
            this.lblCurrentPosition.Text = "Chức vụ";
            // 
            // lblNewPosition
            // 
            this.lblNewPosition.AutoSize = true;
            this.lblNewPosition.Location = new System.Drawing.Point(300, 64);
            this.lblNewPosition.Name = "lblNewPosition";
            this.lblNewPosition.Size = new System.Drawing.Size(47, 13);
            this.lblNewPosition.TabIndex = 129;
            this.lblNewPosition.Text = "Chức vụ";
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new System.Drawing.Point(300, 40);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(53, 13);
            this.lblNewDate.TabIndex = 127;
            this.lblNewDate.Text = "Ngày vào";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "GoLtrHS.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // dedCurrentDate
            // 
            this.dedCurrentDate.EditValue = null;
            this.dedCurrentDate.Enabled = false;
            this.dedCurrentDate.Location = new System.Drawing.Point(120, 36);
            this.dedCurrentDate.Name = "dedCurrentDate";
            this.dedCurrentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedCurrentDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedCurrentDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedCurrentDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedCurrentDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedCurrentDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedCurrentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedCurrentDate.Size = new System.Drawing.Size(80, 20);
            this.dedCurrentDate.TabIndex = 133;
            // 
            // dedNewDate
            // 
            this.dedNewDate.EditValue = null;
            this.dedNewDate.Location = new System.Drawing.Point(424, 36);
            this.dedNewDate.Name = "dedNewDate";
            this.dedNewDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedNewDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedNewDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedNewDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedNewDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedNewDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedNewDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedNewDate.Size = new System.Drawing.Size(80, 20);
            this.dedNewDate.TabIndex = 134;
            // 
            // lueCurrentDepartment
            // 
            this.lueCurrentDepartment.Enabled = false;
            this.lueCurrentDepartment.Location = new System.Drawing.Point(120, 12);
            this.lueCurrentDepartment.Name = "lueCurrentDepartment";
            this.lueCurrentDepartment.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueCurrentDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCurrentDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullPath", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueCurrentDepartment.Properties.DropDownRows = 20;
            this.lueCurrentDepartment.Properties.NullText = "";
            this.lueCurrentDepartment.Properties.ShowHeader = false;
            this.lueCurrentDepartment.Size = new System.Drawing.Size(164, 20);
            this.lueCurrentDepartment.TabIndex = 202;
            // 
            // lueNewDepartment
            // 
            this.lueNewDepartment.Location = new System.Drawing.Point(424, 12);
            this.lueNewDepartment.Name = "lueNewDepartment";
            this.lueNewDepartment.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueNewDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNewDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullPath", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueNewDepartment.Properties.DropDownRows = 20;
            this.lueNewDepartment.Properties.NullText = "";
            this.lueNewDepartment.Properties.ShowHeader = false;
            this.lueNewDepartment.Size = new System.Drawing.Size(164, 20);
            this.lueNewDepartment.TabIndex = 203;
            // 
            // lueCurrentPosition
            // 
            this.lueCurrentPosition.Enabled = false;
            this.lueCurrentPosition.Location = new System.Drawing.Point(120, 60);
            this.lueCurrentPosition.Name = "lueCurrentPosition";
            this.lueCurrentPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCurrentPosition.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueCurrentPosition.Properties.NullText = "";
            this.lueCurrentPosition.Properties.ShowHeader = false;
            this.lueCurrentPosition.Size = new System.Drawing.Size(164, 20);
            this.lueCurrentPosition.TabIndex = 204;
            // 
            // lueNewPosition
            // 
            this.lueNewPosition.Location = new System.Drawing.Point(424, 60);
            this.lueNewPosition.Name = "lueNewPosition";
            this.lueNewPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNewPosition.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueNewPosition.Properties.NullText = "";
            this.lueNewPosition.Properties.ShowHeader = false;
            this.lueNewPosition.Size = new System.Drawing.Size(164, 20);
            this.lueNewPosition.TabIndex = 205;
            // 
            // btnOK
            // 
            this.btnOK.ImageIndex = 0;
            this.btnOK.ImageList = this.imlButton;
            this.btnOK.Location = new System.Drawing.Point(217, 96);
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 206;
            this.btnOK.Text = "&Chuyển";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(305, 96);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 207;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TransferDepartmentByEmployee
            // 
            this.AcceptButton = this.btnOK;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(599, 136);
            this.Controls.Add(this.dedNewDate);
            this.Controls.Add(this.dedCurrentDate);
            this.Controls.Add(this.lblNewPosition);
            this.Controls.Add(this.lblNewDate);
            this.Controls.Add(this.lblCurrentPosition);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblNewDepartment);
            this.Controls.Add(this.lblCurrentDepartment);
            this.Controls.Add(this.lueNewDepartment);
            this.Controls.Add(this.lueNewPosition);
            this.Controls.Add(this.lueCurrentPosition);
            this.Controls.Add(this.lueCurrentDepartment);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferDepartmentByEmployee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển phòng ban";
            this.Load += new System.EventHandler(this.TransferDepartmentByEmployee_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dedCurrentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedCurrentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedNewDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedNewDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCurrentDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNewDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCurrentPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNewPosition.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewDepartment;
        private System.Windows.Forms.Label lblCurrentDepartment;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.Label lblNewPosition;
        private System.Windows.Forms.Label lblNewDate;
        private DevExpress.XtraEditors.DateEdit dedCurrentDate;
        private DevExpress.XtraEditors.DateEdit dedNewDate;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.LookUpEdit lueCurrentDepartment;
        private DevExpress.XtraEditors.LookUpEdit lueNewDepartment;
        private DevExpress.XtraEditors.LookUpEdit lueCurrentPosition;
        private DevExpress.XtraEditors.LookUpEdit lueNewPosition;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}