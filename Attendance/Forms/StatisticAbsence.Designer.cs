namespace Attendance.Forms
{
    partial class StatisticAbsence
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
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dedWorkingDay
            // 
            this.dedWorkingDay.EditValue = null;
            this.dedWorkingDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dedWorkingDay.Properties.LookAndFeel.SkinName = "";
            this.dedWorkingDay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dedWorkingDay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dedWorkingDay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedWorkingDay.EditValueChanged += new System.EventHandler(this.dedWorkingDay_EditValueChanged);
            // 
            // StatisticAbsence
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 398);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "StatisticAbsence";
            this.Text = "Báo cáo nhân lực theo ngày";
            this.Load += new System.EventHandler(this.StatisticAbsence_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatisticAbsence_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedWorkingDay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
