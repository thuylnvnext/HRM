namespace Attendance.Forms
{
    partial class DefineAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineAbsence));
            this.bcoName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.grbValid = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoCompany = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoSI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bcoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbID = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.btnUndo = new System.Windows.Forms.Button();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdAbsence = new DevExpress.XtraGrid.GridControl();
            this.bgvAbsence = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // bcoName
            // 
            this.bcoName.AppearanceCell.Options.UseTextOptions = true;
            this.bcoName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoName.AppearanceHeader.Options.UseFont = true;
            this.bcoName.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoName.Caption = "Tên lý do";
            this.bcoName.FieldName = "Name";
            this.bcoName.Name = "bcoName";
            this.bcoName.Visible = true;
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
            // grbValid
            // 
            this.grbValid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbValid.AppearanceHeader.Options.UseFont = true;
            this.grbValid.AppearanceHeader.Options.UseTextOptions = true;
            this.grbValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbValid.Caption = "Hợp lệ";
            this.grbValid.Columns.Add(this.bcoCompany);
            this.grbValid.Name = "grbValid";
            this.grbValid.Width = 75;
            // 
            // bcoCompany
            // 
            this.bcoCompany.AppearanceCell.Options.UseTextOptions = true;
            this.bcoCompany.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoCompany.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoCompany.AppearanceHeader.Options.UseFont = true;
            this.bcoCompany.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoCompany.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoCompany.Caption = "Lương công ty";
            this.bcoCompany.FieldName = "Company";
            this.bcoCompany.Name = "bcoCompany";
            this.bcoCompany.Visible = true;
            // 
            // grbName
            // 
            this.grbName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbName.AppearanceHeader.Options.UseFont = true;
            this.grbName.AppearanceHeader.Options.UseTextOptions = true;
            this.grbName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbName.Caption = "Tên lý do";
            this.grbName.Columns.Add(this.bcoName);
            this.grbName.Name = "grbName";
            this.grbName.Width = 75;
            // 
            // bcoSI
            // 
            this.bcoSI.AppearanceCell.Options.UseTextOptions = true;
            this.bcoSI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoSI.AppearanceHeader.Options.UseFont = true;
            this.bcoSI.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoSI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoSI.Caption = "Lương bảo hiểm";
            this.bcoSI.FieldName = "SI";
            this.bcoSI.Name = "bcoSI";
            this.bcoSI.Visible = true;
            // 
            // bcoID
            // 
            this.bcoID.AppearanceCell.Options.UseTextOptions = true;
            this.bcoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoID.AppearanceHeader.Options.UseFont = true;
            this.bcoID.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoID.Caption = "Mã lý do";
            this.bcoID.FieldName = "ID";
            this.bcoID.Name = "bcoID";
            this.bcoID.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Lương bảo hiểm";
            this.gridBand1.Columns.Add(this.bcoSI);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
            // 
            // grbID
            // 
            this.grbID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbID.AppearanceHeader.Options.UseFont = true;
            this.grbID.AppearanceHeader.Options.UseTextOptions = true;
            this.grbID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbID.Caption = "Mã lý do";
            this.grbID.Columns.Add(this.bcoID);
            this.grbID.Name = "grbID";
            this.grbID.Width = 75;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ImageIndex = 2;
            this.btnUndo.ImageList = this.imlButton;
            this.btnUndo.Location = new System.Drawing.Point(277, 344);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(78, 28);
            this.btnUndo.TabIndex = 164;
            this.btnUndo.Text = "&Hủy";
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
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
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(101, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 162;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(189, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 28);
            this.btnDelete.TabIndex = 163;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdAbsence
            // 
            this.grdAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAbsence.Location = new System.Drawing.Point(12, 12);
            this.grdAbsence.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdAbsence.MainView = this.bgvAbsence;
            this.grdAbsence.Name = "grdAbsence";
            this.grdAbsence.Size = new System.Drawing.Size(520, 320);
            this.grdAbsence.TabIndex = 161;
            this.grdAbsence.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvAbsence});
            this.grdAbsence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdAbsence_KeyDown);
            // 
            // bgvAbsence
            // 
            this.bgvAbsence.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbID,
            this.grbName,
            this.grbValid,
            this.gridBand1});
            this.bgvAbsence.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoID,
            this.bcoName,
            this.bcoCompany,
            this.bcoSI});
            this.bgvAbsence.FixedLineWidth = 1;
            this.bgvAbsence.GridControl = this.grdAbsence;
            this.bgvAbsence.HorzScrollStep = 10;
            this.bgvAbsence.Name = "bgvAbsence";
            this.bgvAbsence.OptionsCustomization.AllowFilter = false;
            this.bgvAbsence.OptionsCustomization.AllowGroup = false;
            this.bgvAbsence.OptionsCustomization.AllowSort = false;
            this.bgvAbsence.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvAbsence.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvAbsence.OptionsView.ColumnAutoWidth = false;
            this.bgvAbsence.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvAbsence.OptionsView.EnableAppearanceOddRow = true;
            this.bgvAbsence.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.bgvAbsence.OptionsView.ShowColumnHeaders = false;
            this.bgvAbsence.OptionsView.ShowDetailButtons = false;
            this.bgvAbsence.OptionsView.ShowGroupPanel = false;
            this.bgvAbsence.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvAbsence_CustomUnboundColumnData);
            this.bgvAbsence.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvAbsence_CellValueChanging);
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
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageIndex = 3;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(365, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 165;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DefineAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(544, 382);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdAbsence);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DefineAbsence";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa lý do vắng mặt";
            this.Load += new System.EventHandler(this.DefineAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoName;
        internal System.Windows.Forms.ImageList imlButton;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbValid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoCompany;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoSI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbID;
        internal System.Windows.Forms.Button btnUndo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraGrid.GridControl grdAbsence;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvAbsence;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        internal System.Windows.Forms.Button btnClose;
    }
}