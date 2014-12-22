namespace Common.Forms
{
    partial class ExpressionEditor
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
            this.recValue = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lbcCategory = new DevExpress.XtraEditors.ListBoxControl();
            this.lbcDetail = new DevExpress.XtraEditors.ListBoxControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lbcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // recValue
            // 
            this.recValue.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recValue.Appearance.Text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recValue.Appearance.Text.Options.UseFont = true;
            this.recValue.Location = new System.Drawing.Point(12, 12);
            this.recValue.LookAndFeel.UseDefaultLookAndFeel = false;
            this.recValue.Margin = new System.Windows.Forms.Padding(0);
            this.recValue.Name = "recValue";
            this.recValue.Size = new System.Drawing.Size(588, 136);
            this.recValue.TabIndex = 56;
            this.recValue.Views.SimpleView.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(524, 332);
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(440, 332);
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 58;
            this.btnOK.Text = "Chấp nhận";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbcCategory
            // 
            this.lbcCategory.Items.AddRange(new object[] {
            "Các hàm",
            "Các phép toán"});
            this.lbcCategory.Location = new System.Drawing.Point(12, 160);
            this.lbcCategory.Name = "lbcCategory";
            this.lbcCategory.Size = new System.Drawing.Size(176, 164);
            this.lbcCategory.TabIndex = 59;
            this.lbcCategory.SelectedIndexChanged += new System.EventHandler(this.lbcCategory_SelectedIndexChanged);
            // 
            // lbcDetail
            // 
            this.lbcDetail.Location = new System.Drawing.Point(200, 160);
            this.lbcDetail.Name = "lbcDetail";
            this.lbcDetail.Size = new System.Drawing.Size(176, 164);
            this.lbcDetail.TabIndex = 60;
            this.lbcDetail.DoubleClick += new System.EventHandler(this.lbcDetail_DoubleClick);
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Options.UseTextOptions = true;
            this.lblDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDescription.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblDescription.Location = new System.Drawing.Point(388, 160);
            this.lblDescription.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(212, 164);
            this.lblDescription.TabIndex = 61;
            // 
            // ExpressionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbcDetail);
            this.Controls.Add(this.lbcCategory);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.recValue);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpressionEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo công thức";
            this.Load += new System.EventHandler(this.ExpressionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl recValue;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.ListBoxControl lbcCategory;
        private DevExpress.XtraEditors.ListBoxControl lbcDetail;
        private DevExpress.XtraEditors.LabelControl lblDescription;
    }
}