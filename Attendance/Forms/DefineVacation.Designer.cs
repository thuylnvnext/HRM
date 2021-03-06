namespace Attendance.Forms
{
    partial class DefineVacation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineVacation));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grdVacation = new DevExpress.XtraGrid.GridControl();
            this.bgvVacation = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbID = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ide = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoHasWages = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).BeginInit();
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
            // grdVacation
            // 
            this.grdVacation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVacation.Location = new System.Drawing.Point(12, 12);
            this.grdVacation.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdVacation.MainView = this.bgvVacation;
            this.grdVacation.Name = "grdVacation";
            this.grdVacation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ide});
            this.grdVacation.Size = new System.Drawing.Size(520, 320);
            this.grdVacation.TabIndex = 161;
            this.grdVacation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvVacation});
            this.grdVacation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVacation_KeyDown);
            // 
            // bgvVacation
            // 
            this.bgvVacation.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbID,
            this.gridBand1,
            this.grbName});
            this.bgvVacation.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoID,
            this.bcoHasWages,
            this.bcoNotes});
            this.bgvVacation.FixedLineWidth = 1;
            this.bgvVacation.GridControl = this.grdVacation;
            this.bgvVacation.HorzScrollStep = 10;
            this.bgvVacation.Name = "bgvVacation";
            this.bgvVacation.OptionsCustomization.AllowFilter = false;
            this.bgvVacation.OptionsCustomization.AllowGroup = false;
            this.bgvVacation.OptionsCustomization.AllowSort = false;
            this.bgvVacation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvVacation.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvVacation.OptionsView.ColumnAutoWidth = false;
            this.bgvVacation.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvVacation.OptionsView.EnableAppearanceOddRow = true;
            this.bgvVacation.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.bgvVacation.OptionsView.ShowColumnHeaders = false;
            this.bgvVacation.OptionsView.ShowDetailButtons = false;
            this.bgvVacation.OptionsView.ShowGroupPanel = false;
            this.bgvVacation.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvVacation_CustomUnboundColumnData);
            this.bgvVacation.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvVacation_CellValueChanging);
            // 
            // grbNo
            // 
            this.grbNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbNo.AppearanceHeader.Options.UseFont = true;
            this.grbNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNo.Caption = "STT";
            this.grbNo.Columns.Add(this.bcoNo);
            this.grbNo.Name = "grbNo";
            this.grbNo.Width = 75;
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
            // 
            // grbID
            // 
            this.grbID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbID.AppearanceHeader.Options.UseFont = true;
            this.grbID.AppearanceHeader.Options.UseTextOptions = true;
            this.grbID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbID.Caption = "Ngày";
            this.grbID.Columns.Add(this.bcoID);
            this.grbID.Name = "grbID";
            this.grbID.Width = 75;
            // 
            // bcoID
            // 
            this.bcoID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoID.AppearanceHeader.Options.UseFont = true;
            this.bcoID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoID.Caption = "Ngày";
            this.bcoID.ColumnEdit = this.ide;
            this.bcoID.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bcoID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bcoID.FieldName = "ID";
            this.bcoID.Name = "bcoID";
            this.bcoID.Visible = true;
            // 
            // ide
            // 
            this.ide.AutoHeight = false;
            this.ide.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ide.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ide.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ide.EditFormat.FormatString = "dd/MM/yyyy";
            this.ide.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ide.Mask.EditMask = "dd/MM/yyyy";
            this.ide.Name = "ide";
            this.ide.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Có lương";
            this.gridBand1.Columns.Add(this.bcoHasWages);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
            // 
            // bcoHasWages
            // 
            this.bcoHasWages.AppearanceCell.Options.UseTextOptions = true;
            this.bcoHasWages.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoHasWages.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoHasWages.AppearanceHeader.Options.UseFont = true;
            this.bcoHasWages.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoHasWages.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoHasWages.Caption = "Có lương";
            this.bcoHasWages.FieldName = "HasWages";
            this.bcoHasWages.Name = "bcoHasWages";
            this.bcoHasWages.Visible = true;
            // 
            // grbName
            // 
            this.grbName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbName.AppearanceHeader.Options.UseFont = true;
            this.grbName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbName.Caption = "Ghi chú";
            this.grbName.Columns.Add(this.bcoNotes);
            this.grbName.Name = "grbName";
            this.grbName.Width = 75;
            // 
            // bcoNotes
            // 
            this.bcoNotes.AppearanceCell.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoNotes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoNotes.AppearanceHeader.Options.UseFont = true;
            this.bcoNotes.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoNotes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoNotes.Caption = "Ghi chú";
            this.bcoNotes.FieldName = "Notes";
            this.bcoNotes.Name = "bcoNotes";
            this.bcoNotes.Visible = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 3;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(360, 344);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 175;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(108, 344);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(192, 344);
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 173;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Enabled = false;
            this.btnUndo.ImageIndex = 2;
            this.btnUndo.ImageList = this.imlButton;
            this.btnUndo.Location = new System.Drawing.Point(276, 344);
            this.btnUndo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(76, 28);
            this.btnUndo.TabIndex = 174;
            this.btnUndo.Text = "&Hủy";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // DefineVacation
            // 
            this.AcceptButton = this.btnSave;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(544, 382);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.grdVacation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefineVacation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa các ngày nghỉ trong năm";
            this.Load += new System.EventHandler(this.DefineVacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdVacation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvVacation;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNotes;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoHasWages;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ide;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
    }
}