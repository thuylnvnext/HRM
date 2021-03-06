namespace Attendance.Forms
{
    partial class DefineLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineLeave));
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdLeave = new DevExpress.XtraGrid.GridControl();
            this.bgvLeave = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.grbNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbID = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbValid = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bcoValid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "");
            this.imlButton.Images.SetKeyName(2, "");
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ImageIndex = 2;
            this.btnUndo.ImageList = this.imlButton;
            this.btnUndo.Location = new System.Drawing.Point(321, 344);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(78, 28);
            this.btnUndo.TabIndex = 159;
            this.btnUndo.Text = "&Hủy";
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(145, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 157;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imlButton;
            this.btnDelete.Location = new System.Drawing.Point(233, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 28);
            this.btnDelete.TabIndex = 158;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdLeave
            // 
            this.grdLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLeave.EmbeddedNavigator.Name = "";
            this.grdLeave.FormsUseDefaultLookAndFeel = false;
            this.grdLeave.Location = new System.Drawing.Point(12, 12);
            this.grdLeave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdLeave.MainView = this.bgvLeave;
            this.grdLeave.Name = "grdLeave";
            this.grdLeave.Size = new System.Drawing.Size(520, 320);
            this.grdLeave.TabIndex = 156;
            this.grdLeave.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvLeave});
            this.grdLeave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdLeave_KeyDown);
            // 
            // bgvLeave
            // 
            this.bgvLeave.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbNo,
            this.grbID,
            this.grbName,
            this.grbValid});
            this.bgvLeave.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bcoNo,
            this.bcoID,
            this.bcoName,
            this.bcoValid});
            this.bgvLeave.FixedLineWidth = 1;
            this.bgvLeave.GridControl = this.grdLeave;
            this.bgvLeave.HorzScrollStep = 10;
            this.bgvLeave.Name = "bgvLeave";
            this.bgvLeave.OptionsCustomization.AllowFilter = false;
            this.bgvLeave.OptionsCustomization.AllowGroup = false;
            this.bgvLeave.OptionsCustomization.AllowSort = false;
            this.bgvLeave.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgvLeave.OptionsSelection.EnableAppearanceHideSelection = false;
            this.bgvLeave.OptionsView.EnableAppearanceEvenRow = true;
            this.bgvLeave.OptionsView.EnableAppearanceOddRow = true;
            this.bgvLeave.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.bgvLeave.OptionsView.ShowColumnHeaders = false;
            this.bgvLeave.OptionsView.ShowDetailButtons = false;
            this.bgvLeave.OptionsView.ShowGroupPanel = false;
            this.bgvLeave.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bgvLeave_CustomUnboundColumnData);
            this.bgvLeave.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgvLeave_CellValueChanging);
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
            this.grbID.Caption = "Mã lý do";
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
            this.bcoID.Caption = "Mã lý do";
            this.bcoID.FieldName = "ID";
            this.bcoID.Name = "bcoID";
            this.bcoID.Visible = true;
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
            // grbValid
            // 
            this.grbValid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbValid.AppearanceHeader.Options.UseFont = true;
            this.grbValid.AppearanceHeader.Options.UseTextOptions = true;
            this.grbValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbValid.Caption = "Hợp lệ";
            this.grbValid.Columns.Add(this.bcoValid);
            this.grbValid.Name = "grbValid";
            this.grbValid.Width = 75;
            // 
            // bcoValid
            // 
            this.bcoValid.AppearanceCell.Options.UseTextOptions = true;
            this.bcoValid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bcoValid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bcoValid.AppearanceHeader.Options.UseFont = true;
            this.bcoValid.AppearanceHeader.Options.UseTextOptions = true;
            this.bcoValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bcoValid.Caption = "Hợp lệ";
            this.bcoValid.FieldName = "Valid";
            this.bcoValid.Name = "bcoValid";
            this.bcoValid.Visible = true;
            // 
            // DefineLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(544, 382);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdLeave);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DefineLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa lý do ra ngoài";
            this.Load += new System.EventHandler(this.DefineLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvLeave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imlButton;
        internal System.Windows.Forms.Button btnUndo;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraGrid.GridControl grdLeave;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvLeave;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoID;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbValid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bcoValid;
    }
}