namespace Common.Forms
{
    partial class AddItemGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemGroup));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.lblSortOrder = new System.Windows.Forms.Label();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtSortOrder = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortOrder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên";
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // lblSortOrder
            // 
            this.lblSortOrder.AutoSize = true;
            this.lblSortOrder.Location = new System.Drawing.Point(12, 64);
            this.lblSortOrder.Name = "lblSortOrder";
            this.lblSortOrder.Size = new System.Drawing.Size(40, 13);
            this.lblSortOrder.TabIndex = 4;
            this.lblSortOrder.Text = "Thứ tự";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(56, 12);
            this.txtID.Name = "txtID";
            this.txtID.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtID.Size = new System.Drawing.Size(72, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 36);
            this.txtName.Name = "txtName";
            this.txtName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSortOrder
            // 
            this.txtSortOrder.Location = new System.Drawing.Point(56, 60);
            this.txtSortOrder.Name = "txtSortOrder";
            this.txtSortOrder.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtSortOrder.Size = new System.Drawing.Size(32, 20);
            this.txtSortOrder.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(160, 96);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(72, 96);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddItemGroup
            // 
            this.AcceptButton = this.btnSave;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(311, 133);
            this.Controls.Add(this.lblSortOrder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSortOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemGroup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới nhóm mục chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortOrder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.Label lblSortOrder;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtSortOrder;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}