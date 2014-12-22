namespace Attendance.Forms
{
    partial class RawDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawDataView));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.ileShift = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ide = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ite = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.grdRawDataView = new DevExpress.XtraGrid.GridControl();
            this.grvRawDataView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReaderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnrollNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSwipedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ileShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRawDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRawDataView)).BeginInit();
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
            // ileShift
            // 
            this.ileShift.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ileShift.AppearanceDropDownHeader.Options.UseFont = true;
            this.ileShift.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ileShift.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ileShift.AutoHeight = false;
            this.ileShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ileShift.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ileShift.Name = "ileShift";
            this.ileShift.NullText = "";
            // 
            // ide
            // 
            this.ide.AutoHeight = false;
            this.ide.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ide.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            this.ide.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ide.EditFormat.FormatString = "dd/MM/yyyy";
            this.ide.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ide.Mask.EditMask = "dd/MM/yyyy HH:mm:ss tt";
            this.ide.Mask.UseMaskAsDisplayFormat = true;
            this.ide.Name = "ide";
            this.ide.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            this.ide.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // ite
            // 
            this.ite.AutoHeight = false;
            this.ite.Mask.EditMask = "N1";
            this.ite.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ite.Name = "ite";
            // 
            // grdRawDataView
            // 
            this.grdRawDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRawDataView.Location = new System.Drawing.Point(12, 12);
            this.grdRawDataView.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdRawDataView.MainView = this.grvRawDataView;
            this.grdRawDataView.Name = "grdRawDataView";
            this.grdRawDataView.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ide,
            this.ileShift,
            this.ite});
            this.grdRawDataView.Size = new System.Drawing.Size(520, 320);
            this.grdRawDataView.TabIndex = 166;
            this.grdRawDataView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRawDataView});
            this.grdRawDataView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdRawDataView_KeyDown);
            // 
            // grvRawDataView
            // 
            this.grvRawDataView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colReaderID,
            this.colPosition,
            this.colEnrollNumber,
            this.colSwipedDate,
            this.colStatus,
            this.colUsed});
            this.grvRawDataView.FixedLineWidth = 1;
            this.grvRawDataView.GridControl = this.grdRawDataView;
            this.grvRawDataView.HorzScrollStep = 10;
            this.grvRawDataView.Name = "grvRawDataView";
            this.grvRawDataView.OptionsCustomization.AllowFilter = false;
            this.grvRawDataView.OptionsCustomization.AllowGroup = false;
            this.grvRawDataView.OptionsCustomization.AllowSort = false;
            this.grvRawDataView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvRawDataView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvRawDataView.OptionsView.ColumnAutoWidth = false;
            this.grvRawDataView.OptionsView.EnableAppearanceEvenRow = true;
            this.grvRawDataView.OptionsView.EnableAppearanceOddRow = true;
            this.grvRawDataView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvRawDataView.OptionsView.ShowDetailButtons = false;
            this.grvRawDataView.OptionsView.ShowGroupPanel = false;
            this.grvRawDataView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvRawDataView_CustomUnboundColumnData);
            this.grvRawDataView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvRawDataView_InitNewRow);
            this.grvRawDataView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvRawDataView_CellValueChanging);
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Options.UseTextOptions = true;
            this.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNo.AppearanceHeader.Options.UseFont = true;
            this.colNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.Caption = "STT";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.AllowEdit = false;
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colReaderID
            // 
            this.colReaderID.AppearanceCell.Options.UseTextOptions = true;
            this.colReaderID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colReaderID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colReaderID.AppearanceHeader.Options.UseFont = true;
            this.colReaderID.AppearanceHeader.Options.UseTextOptions = true;
            this.colReaderID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReaderID.Caption = "Đầu đọc";
            this.colReaderID.FieldName = "ReaderID";
            this.colReaderID.Name = "colReaderID";
            this.colReaderID.OptionsColumn.AllowEdit = false;
            this.colReaderID.OptionsColumn.ReadOnly = true;
            this.colReaderID.Visible = true;
            this.colReaderID.VisibleIndex = 1;
            // 
            // colPosition
            // 
            this.colPosition.AppearanceCell.Options.UseTextOptions = true;
            this.colPosition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPosition.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPosition.AppearanceHeader.Options.UseFont = true;
            this.colPosition.AppearanceHeader.Options.UseTextOptions = true;
            this.colPosition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPosition.Caption = "Vị trí";
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.OptionsColumn.AllowEdit = false;
            this.colPosition.OptionsColumn.ReadOnly = true;
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 2;
            // 
            // colEnrollNumber
            // 
            this.colEnrollNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colEnrollNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEnrollNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEnrollNumber.AppearanceHeader.Options.UseFont = true;
            this.colEnrollNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colEnrollNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEnrollNumber.Caption = "Mã chấm công";
            this.colEnrollNumber.FieldName = "EnrollNumber";
            this.colEnrollNumber.Name = "colEnrollNumber";
            this.colEnrollNumber.OptionsColumn.AllowEdit = false;
            this.colEnrollNumber.OptionsColumn.ReadOnly = true;
            // 
            // colSwipedDate
            // 
            this.colSwipedDate.AppearanceCell.Options.UseTextOptions = true;
            this.colSwipedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSwipedDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSwipedDate.AppearanceHeader.Options.UseFont = true;
            this.colSwipedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSwipedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSwipedDate.Caption = "Ngày/ giờ";
            this.colSwipedDate.ColumnEdit = this.ide;
            this.colSwipedDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            this.colSwipedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSwipedDate.FieldName = "SwipedDate";
            this.colSwipedDate.Name = "colSwipedDate";
            this.colSwipedDate.OptionsColumn.AllowEdit = false;
            this.colSwipedDate.OptionsColumn.ReadOnly = true;
            this.colSwipedDate.Visible = true;
            this.colSwipedDate.VisibleIndex = 3;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colStatus.AppearanceHeader.Options.UseFont = true;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.Caption = "Quẹt vào";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            this.colStatus.Width = 108;
            // 
            // colUsed
            // 
            this.colUsed.AppearanceCell.Options.UseTextOptions = true;
            this.colUsed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsed.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUsed.AppearanceHeader.Options.UseFont = true;
            this.colUsed.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsed.Caption = "Sử dụng";
            this.colUsed.FieldName = "Used";
            this.colUsed.Name = "colUsed";
            this.colUsed.Visible = true;
            this.colUsed.VisibleIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 3;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(234, 344);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 179;
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
            this.btnSave.TabIndex = 176;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Visible = false;
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
            this.btnDelete.TabIndex = 177;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Visible = false;
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
            this.btnUndo.TabIndex = 178;
            this.btnUndo.Text = "&Hủy";
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // RawDataView
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
            this.Controls.Add(this.grdRawDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RawDataView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dữ liệu gốc";
            this.Load += new System.EventHandler(this.RawDataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ileShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRawDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRawDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.GridControl grdRawDataView;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ide;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ileShift;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ite;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRawDataView;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReaderID;
        private DevExpress.XtraGrid.Columns.GridColumn colEnrollNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSwipedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colUsed;
    }
}