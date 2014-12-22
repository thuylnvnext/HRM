namespace Common.Forms
{
    partial class DefineList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineList));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grdDefineList = new DevExpress.XtraGrid.GridControl();
            this.grvDefineList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bcoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDefineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDefineList)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "");
            this.imlButton.Images.SetKeyName(2, "");
            this.imlButton.Images.SetKeyName(3, "Windows-Close-Program-icon.png");
            // 
            // grdDefineList
            // 
            this.grdDefineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdDefineList.Location = new System.Drawing.Point(12, 12);
            this.grdDefineList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDefineList.MainView = this.grvDefineList;
            this.grdDefineList.Name = "grdDefineList";
            this.grdDefineList.Size = new System.Drawing.Size(500, 244);
            this.grdDefineList.TabIndex = 0;
            this.grdDefineList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDefineList});
            this.grdDefineList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDefineList_KeyDown);
            // 
            // grvDefineList
            // 
            this.grvDefineList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bcoNo});
            this.grvDefineList.FixedLineWidth = 1;
            this.grvDefineList.GridControl = this.grdDefineList;
            this.grvDefineList.HorzScrollStep = 10;
            this.grvDefineList.Name = "grvDefineList";
            this.grvDefineList.OptionsCustomization.AllowFilter = false;
            this.grvDefineList.OptionsCustomization.AllowGroup = false;
            this.grvDefineList.OptionsCustomization.AllowSort = false;
            this.grvDefineList.OptionsLayout.Columns.StoreAllOptions = true;
            this.grvDefineList.OptionsLayout.Columns.StoreAppearance = true;
            this.grvDefineList.OptionsLayout.StoreAllOptions = true;
            this.grvDefineList.OptionsLayout.StoreAppearance = true;
            this.grvDefineList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDefineList.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvDefineList.OptionsView.ColumnAutoWidth = false;
            this.grvDefineList.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDefineList.OptionsView.EnableAppearanceOddRow = true;
            this.grvDefineList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvDefineList.OptionsView.ShowDetailButtons = false;
            this.grvDefineList.OptionsView.ShowGroupPanel = false;
            this.grvDefineList.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvDefineList_CustomUnboundColumnData);
            this.grvDefineList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvDefineList_CellValueChanging);
            this.grvDefineList.DoubleClick += new System.EventHandler(this.grvDefineList_DoubleClick);
            // 
            // bcoNo
            // 
            this.bcoNo.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNo.AppearanceHeader.Options.UseFont = true;
            this.bcoNo.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNo.Caption = "STT";
            this.bcoNo.FieldName = "No";
            this.bcoNo.Name = "bcoNo";
            this.bcoNo.OptionsColumn.AllowEdit = false;
            this.bcoNo.OptionsColumn.ReadOnly = true;
            this.bcoNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.bcoNo.Visible = true;
            this.bcoNo.VisibleIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(182, 268);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(98, 268);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Enabled = false;
            this.btnUndo.ImageIndex = 2;
            this.btnUndo.ImageList = this.imlButton;
            this.btnUndo.Location = new System.Drawing.Point(266, 268);
            this.btnUndo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(76, 28);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "&Hủy";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 3;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(350, 268);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DefineList
            // 
            this.AcceptButton = this.btnSave;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(524, 305);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdDefineList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefineList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.DefineList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDefineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDefineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.GridControl grdDefineList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDefineList;
        private DevExpress.XtraGrid.Columns.GridColumn bcoNo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}