namespace Attendance.Forms
{
    partial class ScheduleForGetData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForGetData));
            this.grdScheduleForGetData = new DevExpress.XtraGrid.GridControl();
            this.grvScheduleForGetData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ite = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdScheduleForGetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheduleForGetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).BeginInit();
            this.SuspendLayout();
            // 
            // grdScheduleForGetData
            // 
            this.grdScheduleForGetData.Location = new System.Drawing.Point(12, 12);
            this.grdScheduleForGetData.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdScheduleForGetData.MainView = this.grvScheduleForGetData;
            this.grdScheduleForGetData.Name = "grdScheduleForGetData";
            this.grdScheduleForGetData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ite});
            this.grdScheduleForGetData.Size = new System.Drawing.Size(232, 116);
            this.grdScheduleForGetData.TabIndex = 210;
            this.grdScheduleForGetData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvScheduleForGetData});
            this.grdScheduleForGetData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdScheduleForGetData_KeyDown);
            // 
            // grvScheduleForGetData
            // 
            this.grvScheduleForGetData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvScheduleForGetData.Appearance.GroupRow.Options.UseFont = true;
            this.grvScheduleForGetData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colTime});
            this.grvScheduleForGetData.FixedLineWidth = 1;
            this.grvScheduleForGetData.GridControl = this.grdScheduleForGetData;
            this.grvScheduleForGetData.HorzScrollStep = 30;
            this.grvScheduleForGetData.Name = "grvScheduleForGetData";
            this.grvScheduleForGetData.OptionsCustomization.AllowFilter = false;
            this.grvScheduleForGetData.OptionsCustomization.AllowGroup = false;
            this.grvScheduleForGetData.OptionsCustomization.AllowSort = false;
            this.grvScheduleForGetData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvScheduleForGetData.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvScheduleForGetData.OptionsSelection.MultiSelect = true;
            this.grvScheduleForGetData.OptionsView.ColumnAutoWidth = false;
            this.grvScheduleForGetData.OptionsView.EnableAppearanceEvenRow = true;
            this.grvScheduleForGetData.OptionsView.EnableAppearanceOddRow = true;
            this.grvScheduleForGetData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvScheduleForGetData.OptionsView.ShowDetailButtons = false;
            this.grvScheduleForGetData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvScheduleForGetData.OptionsView.ShowGroupPanel = false;
            this.grvScheduleForGetData.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.grvScheduleForGetData_CustomUnboundColumnData);
            this.grvScheduleForGetData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvScheduleForGetData_InitNewRow);
            this.grvScheduleForGetData.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvScheduleForGetData_CellValueChanging);
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
            this.colNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colTime
            // 
            this.colTime.AppearanceCell.Options.UseTextOptions = true;
            this.colTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTime.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTime.AppearanceHeader.Options.UseFont = true;
            this.colTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTime.Caption = "Thời gian";
            this.colTime.ColumnEdit = this.ite;
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 1;
            // 
            // ite
            // 
            this.ite.AutoHeight = false;
            this.ite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ite.Name = "ite";
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(131, 140);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 212;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imlButton;
            this.btnSave.Location = new System.Drawing.Point(44, 140);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 211;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ScheduleForGetData
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 178);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdScheduleForGetData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleForGetData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thời gian nhận dữ liệu";
            this.Load += new System.EventHandler(this.ScheduleForGetData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScheduleForGetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheduleForGetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdScheduleForGetData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvScheduleForGetData;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit ite;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.ImageList imlButton;
    }
}