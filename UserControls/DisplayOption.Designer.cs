namespace HRMplus.UserControls
{
    partial class DisplayOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOption));
            this.lblSkin = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cboLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSkin = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnChangeTitle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSkin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.BackColor = System.Drawing.Color.Transparent;
            this.lblSkin.Location = new System.Drawing.Point(12, 40);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(51, 13);
            this.lblSkin.TabIndex = 17;
            this.lblSkin.Text = "Giao diện";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Location = new System.Drawing.Point(12, 16);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(54, 13);
            this.lblLanguage.TabIndex = 16;
            this.lblLanguage.Text = "Ngôn ngữ";
            // 
            // cboLanguage
            // 
            this.cboLanguage.Location = new System.Drawing.Point(76, 12);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLanguage.Size = new System.Drawing.Size(124, 20);
            this.cboLanguage.TabIndex = 18;
            // 
            // cboSkin
            // 
            this.cboSkin.Location = new System.Drawing.Point(76, 36);
            this.cboSkin.Name = "cboSkin";
            this.cboSkin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSkin.Properties.Items.AddRange(new object[] {
            "Caramel",
            "Money Twins",
            "Lilian",
            "The Asphalt World",
            "iMaginary",
            "Black",
            "Blue",
            "Coffee",
            "Liquid Sky",
            "London Liquid Sky",
            "Glass Oceans",
            "Stardust",
            "Xmas 2008 Blue",
            "Valentine",
            "McSkin",
            "Office 2007 Blue",
            "Office 2007 Black",
            "Office 2007 Silver",
            "Office 2007 Green",
            "Office 2007 Pink"});
            this.cboSkin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSkin.Size = new System.Drawing.Size(124, 20);
            this.cboSkin.TabIndex = 19;
            this.cboSkin.SelectedValueChanged += new System.EventHandler(this.cboSkin_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(180, 124);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 170;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            // 
            // btnChangeTitle
            // 
            this.btnChangeTitle.ImageIndex = 0;
            this.btnChangeTitle.Location = new System.Drawing.Point(204, 12);
            this.btnChangeTitle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnChangeTitle.Name = "btnChangeTitle";
            this.btnChangeTitle.Size = new System.Drawing.Size(31, 20);
            this.btnChangeTitle.TabIndex = 171;
            this.btnChangeTitle.Text = "...";
            this.btnChangeTitle.Click += new System.EventHandler(this.btnChangeTitle_Click);
            // 
            // Display
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboSkin);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.lblSkin);
            this.Controls.Add(this.lblLanguage);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(266, 161);
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSkin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.Label lblLanguage;
        private DevExpress.XtraEditors.ComboBoxEdit cboLanguage;
        private DevExpress.XtraEditors.ComboBoxEdit cboSkin;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraEditors.SimpleButton btnChangeTitle;
    }
}
