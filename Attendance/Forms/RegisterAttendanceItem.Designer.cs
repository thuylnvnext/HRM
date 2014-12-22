namespace Attendance.Forms
{
    partial class RegisterAttendanceItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAttendanceItem));
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.imlHeader = new System.Windows.Forms.ImageList(this.components);
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // imlHeader
            // 
            this.imlHeader.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlHeader.ImageStream")));
            this.imlHeader.TransparentColor = System.Drawing.Color.Transparent;
            this.imlHeader.Images.SetKeyName(0, "checked.gif");
            this.imlHeader.Images.SetKeyName(1, "unchecked.gif");
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            this.imlButton.Images.SetKeyName(2, "Windows-Close-Program-icon.png");
            // 
            // RegisterAttendanceItem
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "RegisterAttendanceItem";
            this.Text = "Đăng ký mục chấm công bổ sung";
            this.Load += new System.EventHandler(this.RegisterAttendanceItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList imlGroup;
        internal System.Windows.Forms.ImageList imlButton;
        internal System.Windows.Forms.ImageList imlHeader;
    }
}
