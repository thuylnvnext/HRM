namespace Attendance.Forms
{
    partial class DefineAttendanceItem
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
            this.SuspendLayout();
            // 
            // tvwItemGroup
            // 
            this.tvwItemGroup.LineColor = System.Drawing.Color.Black;
            // 
            // DefineAttendanceItem
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1093, 512);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "DefineAttendanceItem";
            this.Text = "Định nghĩa mục chấm công";
            this.Load += new System.EventHandler(this.DefineAttendanceItem_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
