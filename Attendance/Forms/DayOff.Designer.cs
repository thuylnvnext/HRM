namespace Attendance.Forms
{
    partial class DayOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayOff));
            this.imlGroup = new System.Windows.Forms.ImageList(this.components);
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.cmsDayOff = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitDefineDayOffGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.imlHeader = new System.Windows.Forms.ImageList(this.components);
            this.pncFilter = new DevExpress.XtraEditors.PanelControl();
            this.cboYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmsDayOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).BeginInit();
            this.pncFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imlGroup
            // 
            this.imlGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGroup.ImageStream")));
            this.imlGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGroup.Images.SetKeyName(0, "users.gif");
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "DeleteHS.png");
            this.imlButton.Images.SetKeyName(2, "Windows-Close-Program-icon.png");
            // 
            // cmsDayOff
            // 
            this.cmsDayOff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitSeparator,
            this.mitDelete,
            this.toolStripSeparator1,
            this.mitDefineDayOffGroup});
            this.cmsDayOff.Name = "cmsEmployee";
            this.cmsDayOff.Size = new System.Drawing.Size(168, 60);
            // 
            // mitSeparator
            // 
            this.mitSeparator.Name = "mitSeparator";
            this.mitSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // mitDelete
            // 
            this.mitDelete.Image = ((System.Drawing.Image)(resources.GetObject("mitDelete.Image")));
            this.mitDelete.Name = "mitDelete";
            this.mitDelete.Size = new System.Drawing.Size(167, 22);
            this.mitDelete.Text = "Xóa";
            this.mitDelete.Click += new System.EventHandler(this.mitDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // mitDefineDayOffGroup
            // 
            this.mitDefineDayOffGroup.Name = "mitDefineDayOffGroup";
            this.mitDefineDayOffGroup.Size = new System.Drawing.Size(167, 22);
            this.mitDefineDayOffGroup.Text = "Định nghĩa nhóm";
            this.mitDefineDayOffGroup.Click += new System.EventHandler(this.mitDefineDayOffGroup_Click);
            // 
            // imlHeader
            // 
            this.imlHeader.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlHeader.ImageStream")));
            this.imlHeader.TransparentColor = System.Drawing.Color.Transparent;
            this.imlHeader.Images.SetKeyName(0, "checked.gif");
            this.imlHeader.Images.SetKeyName(1, "unchecked.gif");
            // 
            // pncFilter
            // 
            this.pncFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pncFilter.Controls.Add(this.cboYear);
            this.pncFilter.Controls.Add(this.lblYear);
            this.pncFilter.Location = new System.Drawing.Point(0, 0);
            this.pncFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pncFilter.Name = "pncFilter";
            this.pncFilter.Size = new System.Drawing.Size(650, 36);
            this.pncFilter.TabIndex = 203;
            // 
            // cboYear
            // 
            this.cboYear.Location = new System.Drawing.Point(40, 8);
            this.cboYear.Name = "cboYear";
            this.cboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboYear.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboYear.Size = new System.Drawing.Size(52, 20);
            this.cboYear.TabIndex = 172;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(8, 12);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 13);
            this.lblYear.TabIndex = 171;
            this.lblYear.Text = "Năm";
            // 
            // DayOff
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 368);
            this.Controls.Add(this.pncFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DayOff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch nghỉ luân phiên thứ 7";
            this.Load += new System.EventHandler(this.DayOff_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DayOff_KeyDown);
            this.cmsDayOff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pncFilter)).EndInit();
            this.pncFilter.ResumeLayout(false);
            this.pncFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlGroup;
        internal System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.ContextMenuStrip cmsDayOff;
        private System.Windows.Forms.ToolStripSeparator mitSeparator;
        private System.Windows.Forms.ToolStripMenuItem mitDefineDayOffGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mitDelete;
        internal System.Windows.Forms.ImageList imlHeader;
        private DevExpress.XtraEditors.PanelControl pncFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cboYear;
        private System.Windows.Forms.Label lblYear;
    }
}