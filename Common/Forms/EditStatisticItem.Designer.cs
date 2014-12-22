namespace Common.Forms
{
    partial class EditStatisticItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStatisticItem));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblValue = new System.Windows.Forms.Label();
            this.ccbValue = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.mmeComputedValue = new DevExpress.XtraEditors.MemoEdit();
            this.cboFunction = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeComputedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFunction.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 40);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(35, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Giá trị";
            // 
            // ccbValue
            // 
            this.ccbValue.EditValue = "";
            this.ccbValue.Location = new System.Drawing.Point(52, 36);
            this.ccbValue.Name = "ccbValue";
            this.ccbValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbValue.Properties.SelectAllItemCaption = "(Chọn tất cả)";
            this.ccbValue.Size = new System.Drawing.Size(144, 20);
            this.ccbValue.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(146, 124);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(62, 124);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mmeComputedValue
            // 
            this.mmeComputedValue.Location = new System.Drawing.Point(52, 60);
            this.mmeComputedValue.Name = "mmeComputedValue";
            this.mmeComputedValue.Size = new System.Drawing.Size(220, 52);
            this.mmeComputedValue.TabIndex = 5;
            // 
            // cboFunction
            // 
            this.cboFunction.Location = new System.Drawing.Point(204, 36);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFunction.Properties.Items.AddRange(new object[] {
            "Tổng",
            "Đếm"});
            this.cboFunction.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFunction.Size = new System.Drawing.Size(68, 20);
            this.cboFunction.TabIndex = 4;
            // 
            // EditStatisticItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.cboFunction);
            this.Controls.Add(this.mmeComputedValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.ccbValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStatisticItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditStatisticItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeComputedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFunction.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label lblValue;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbValue;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.MemoEdit mmeComputedValue;
        protected DevExpress.XtraEditors.ComboBoxEdit cboFunction;
    }
}