namespace Attendance.Forms
{
    partial class RegisterLateEarly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterLateEarly));
            this.imlFunction = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imlFunction
            // 
            this.imlFunction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFunction.ImageStream")));
            this.imlFunction.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFunction.Images.SetKeyName(0, "checklist_32.png");
            this.imlFunction.Images.SetKeyName(1, "Ok-icon.png");
            // 
            // RegisterLateEarly
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "RegisterLateEarly";
            this.Text = "Đăng ký đi muộn, về sớm";
            this.Load += new System.EventHandler(this.RegisterLateEarly_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlFunction;

    }
}
