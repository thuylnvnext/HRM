namespace Common.Forms
{
    partial class TitleEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleEditor));
            this.recValue = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // recValue
            // 
            this.recValue.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.recValue.Appearance.Text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recValue.Appearance.Text.Options.UseFont = true;
            this.recValue.Location = new System.Drawing.Point(12, 12);
            this.recValue.LookAndFeel.UseDefaultLookAndFeel = false;
            this.recValue.Margin = new System.Windows.Forms.Padding(0);
            this.recValue.Name = "recValue";
            this.recValue.Size = new System.Drawing.Size(388, 131);
            this.recValue.TabIndex = 0;
            this.recValue.Views.SimpleView.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(210, 155);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // btnOK
            // 
            this.btnOK.ImageIndex = 0;
            this.btnOK.ImageList = this.imlButton;
            this.btnOK.Location = new System.Drawing.Point(126, 155);
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Lưu";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            // 
            // TitleEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.recValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TitleEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi tên";
            this.Load += new System.EventHandler(this.TitleEditor_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl recValue;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        internal System.Windows.Forms.ImageList imlButton;
    }
}