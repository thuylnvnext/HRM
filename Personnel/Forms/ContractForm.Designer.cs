namespace Personnel.Forms
{
    partial class ContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractForm));
            this.rbcFormOfLabourControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bdcMain = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.beiFontFamily = new DevExpress.XtraBars.BarEditItem();
            this.ifeFontFamily = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.beiFontSize = new DevExpress.XtraBars.BarEditItem();
            this.icbFontSize = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.bciBold = new DevExpress.XtraBars.BarCheckItem();
            this.bciItalic = new DevExpress.XtraBars.BarCheckItem();
            this.bciUnderline = new DevExpress.XtraBars.BarCheckItem();
            this.bbgAlignment = new DevExpress.XtraBars.BarButtonGroup();
            this.bciLeft = new DevExpress.XtraBars.BarCheckItem();
            this.bciCenter = new DevExpress.XtraBars.BarCheckItem();
            this.bciRight = new DevExpress.XtraBars.BarCheckItem();
            this.bciJustify = new DevExpress.XtraBars.BarCheckItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.rbpEdit = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgFont = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAlignment = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.recFormOfLabourContract = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.rbcFormOfLabourControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifeFontFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcFormOfLabourControl
            // 
            this.rbcFormOfLabourControl.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("rbcFormOfLabourControl.ApplicationIcon")));
            this.rbcFormOfLabourControl.Controller = this.bdcMain;
            this.rbcFormOfLabourControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.beiFontFamily,
            this.beiFontSize,
            this.barButtonGroup1,
            this.bbgAlignment,
            this.bciBold,
            this.bciItalic,
            this.bciUnderline,
            this.bciCenter,
            this.bciLeft,
            this.bciRight,
            this.bciJustify,
            this.bbiSave});
            this.rbcFormOfLabourControl.Location = new System.Drawing.Point(0, 0);
            this.rbcFormOfLabourControl.MaxItemId = 70;
            this.rbcFormOfLabourControl.Name = "rbcFormOfLabourControl";
            this.rbcFormOfLabourControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpEdit});
            this.rbcFormOfLabourControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ifeFontFamily,
            this.icbFontSize});
            this.rbcFormOfLabourControl.SelectedPage = this.rbpEdit;
            this.rbcFormOfLabourControl.Size = new System.Drawing.Size(705, 143);
            this.rbcFormOfLabourControl.Toolbar.ItemLinks.Add(this.bbiSave);
            // 
            // bdcMain
            // 
            this.bdcMain.AppearancesRibbon.PageHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bdcMain.AppearancesRibbon.PageHeader.Options.UseFont = true;
            this.bdcMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bdcMain.PropertiesBar.AllowLinkLighting = false;
            // 
            // beiFontFamily
            // 
            this.beiFontFamily.Edit = this.ifeFontFamily;
            this.beiFontFamily.Id = 19;
            this.beiFontFamily.Name = "beiFontFamily";
            this.beiFontFamily.Width = 150;
            this.beiFontFamily.EditValueChanged += new System.EventHandler(this.beiFontFamily_EditValueChanged);
            // 
            // ifeFontFamily
            // 
            this.ifeFontFamily.AutoHeight = false;
            this.ifeFontFamily.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ifeFontFamily.Name = "ifeFontFamily";
            this.ifeFontFamily.EditValueChanged += new System.EventHandler(this.ifeFontFamily_EditValueChanged);
            // 
            // beiFontSize
            // 
            this.beiFontSize.Edit = this.icbFontSize;
            this.beiFontSize.Id = 20;
            this.beiFontSize.Name = "beiFontSize";
            // 
            // icbFontSize
            // 
            this.icbFontSize.AutoHeight = false;
            this.icbFontSize.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.icbFontSize.Name = "icbFontSize";
            this.icbFontSize.EditValueChanged += new System.EventHandler(this.icbFontSize_EditValueChanged);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 22;
            this.barButtonGroup1.ItemLinks.Add(this.bciBold);
            this.barButtonGroup1.ItemLinks.Add(this.bciItalic);
            this.barButtonGroup1.ItemLinks.Add(this.bciUnderline);
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // bciBold
            // 
            this.bciBold.Glyph = ((System.Drawing.Image)(resources.GetObject("bciBold.Glyph")));
            this.bciBold.Hint = "Chữ đậm (Ctrl+B)";
            this.bciBold.Id = 32;
            this.bciBold.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.bciBold.Name = "bciBold";
            this.bciBold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciBold_ItemClick);
            this.bciBold.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciBold_CheckedChanged);
            // 
            // bciItalic
            // 
            this.bciItalic.Glyph = ((System.Drawing.Image)(resources.GetObject("bciItalic.Glyph")));
            this.bciItalic.Hint = "Chữ nghiêng (Ctrl+I)";
            this.bciItalic.Id = 33;
            this.bciItalic.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.bciItalic.Name = "bciItalic";
            this.bciItalic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciItalic_ItemClick);
            // 
            // bciUnderline
            // 
            this.bciUnderline.Glyph = ((System.Drawing.Image)(resources.GetObject("bciUnderline.Glyph")));
            this.bciUnderline.Hint = "Chữ gạch dưới (Ctrl+U)";
            this.bciUnderline.Id = 34;
            this.bciUnderline.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.bciUnderline.Name = "bciUnderline";
            this.bciUnderline.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciUnderline_ItemClick);
            // 
            // bbgAlignment
            // 
            this.bbgAlignment.Caption = "barButtonGroup2";
            this.bbgAlignment.Id = 27;
            this.bbgAlignment.ItemLinks.Add(this.bciLeft);
            this.bbgAlignment.ItemLinks.Add(this.bciCenter);
            this.bbgAlignment.ItemLinks.Add(this.bciRight);
            this.bbgAlignment.ItemLinks.Add(this.bciJustify);
            this.bbgAlignment.Name = "bbgAlignment";
            // 
            // bciLeft
            // 
            this.bciLeft.Glyph = ((System.Drawing.Image)(resources.GetObject("bciLeft.Glyph")));
            this.bciLeft.Hint = "Căn trái (Ctrl+L)";
            this.bciLeft.Id = 66;
            this.bciLeft.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.bciLeft.Name = "bciLeft";
            this.bciLeft.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciLeft_ItemClick);
            // 
            // bciCenter
            // 
            this.bciCenter.Glyph = ((System.Drawing.Image)(resources.GetObject("bciCenter.Glyph")));
            this.bciCenter.Hint = "Căn giữa (Ctrl+E)";
            this.bciCenter.Id = 50;
            this.bciCenter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.bciCenter.Name = "bciCenter";
            this.bciCenter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciCenter_ItemClick);
            this.bciCenter.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciCenter_CheckedChanged);
            // 
            // bciRight
            // 
            this.bciRight.Glyph = ((System.Drawing.Image)(resources.GetObject("bciRight.Glyph")));
            this.bciRight.Hint = "Căn phải (Ctrl+R)";
            this.bciRight.Id = 67;
            this.bciRight.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.bciRight.Name = "bciRight";
            this.bciRight.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciRight_ItemClick);
            // 
            // bciJustify
            // 
            this.bciJustify.Glyph = ((System.Drawing.Image)(resources.GetObject("bciJustify.Glyph")));
            this.bciJustify.Hint = "Căn hai bên (Ctrl+J)";
            this.bciJustify.Id = 68;
            this.bciJustify.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J));
            this.bciJustify.Name = "bciJustify";
            this.bciJustify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bciJustify_ItemClick);
            this.bciJustify.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciJustify_CheckedChanged);
            // 
            // bbiSave
            // 
            this.bbiSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.Glyph")));
            this.bbiSave.Hint = "Lưu (Ctrl+S)";
            this.bbiSave.Id = 69;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // rbpEdit
            // 
            this.rbpEdit.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgFont,
            this.rpgAlignment});
            this.rbpEdit.Name = "rbpEdit";
            this.rbpEdit.Text = "Soạn thảo";
            // 
            // rpgFont
            // 
            this.rpgFont.ItemLinks.Add(this.beiFontFamily, false, "", "", true);
            this.rpgFont.ItemLinks.Add(this.beiFontSize, false, "", "", true);
            this.rpgFont.ItemLinks.Add(this.barButtonGroup1);
            this.rpgFont.Name = "rpgFont";
            this.rpgFont.ShowCaptionButton = false;
            this.rpgFont.Text = "Phông chữ";
            // 
            // rpgAlignment
            // 
            this.rpgAlignment.ItemLinks.Add(this.bbgAlignment, true);
            this.rpgAlignment.Name = "rpgAlignment";
            this.rpgAlignment.ShowCaptionButton = false;
            this.rpgAlignment.Text = "Căn lề";
            // 
            // recFormOfLabourContract
            // 
            this.recFormOfLabourContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recFormOfLabourContract.Location = new System.Drawing.Point(0, 143);
            this.recFormOfLabourContract.LookAndFeel.UseDefaultLookAndFeel = false;
            this.recFormOfLabourContract.MenuManager = this.rbcFormOfLabourControl;
            this.recFormOfLabourContract.Name = "recFormOfLabourContract";
            this.recFormOfLabourContract.Size = new System.Drawing.Size(705, 203);
            this.recFormOfLabourContract.TabIndex = 0;
            this.recFormOfLabourContract.SelectionChanged += new System.EventHandler(this.recFormOfLabourContract_SelectionChanged);
            // 
            // FormOfLabourContract
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 346);
            this.Controls.Add(this.recFormOfLabourContract);
            this.Controls.Add(this.rbcFormOfLabourControl);
            this.Name = "FormOfLabourContract";
            this.Ribbon = this.rbcFormOfLabourControl;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mẫu hợp đồng lao động";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOfContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbcFormOfLabourControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifeFontFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcFormOfLabourControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFont;
        private DevExpress.XtraRichEdit.RichEditControl recFormOfLabourContract;
        private DevExpress.XtraBars.BarAndDockingController bdcMain;
        private DevExpress.XtraBars.BarEditItem beiFontFamily;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit ifeFontFamily;
        private DevExpress.XtraBars.BarEditItem beiFontSize;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox icbFontSize;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAlignment;
        private DevExpress.XtraBars.BarButtonGroup bbgAlignment;
        private DevExpress.XtraBars.BarCheckItem bciBold;
        private DevExpress.XtraBars.BarCheckItem bciItalic;
        private DevExpress.XtraBars.BarCheckItem bciUnderline;
        private DevExpress.XtraBars.BarCheckItem bciCenter;
        private DevExpress.XtraBars.BarCheckItem bciLeft;
        private DevExpress.XtraBars.BarCheckItem bciRight;
        private DevExpress.XtraBars.BarCheckItem bciJustify;
        private DevExpress.XtraBars.BarButtonItem bbiSave;

    }
}
