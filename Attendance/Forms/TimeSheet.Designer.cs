namespace Attendance.Forms
{
    partial class TimeSheet
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
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTableGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeSheet
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 346);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TimeSheet";
            this.Text = "Đi muộn, về sớm";
            this.Load += new System.EventHandler(this.TimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTableGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}