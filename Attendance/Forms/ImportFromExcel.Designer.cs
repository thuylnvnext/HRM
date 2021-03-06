namespace Attendance.Forms
{
    partial class ImportFromExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFromExcel));
            this.btnOpenExcelFile = new System.Windows.Forms.Button();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.lblExcelFile = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.ofdExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenExcelFile
            // 
            this.btnOpenExcelFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenExcelFile.Image")));
            this.btnOpenExcelFile.Location = new System.Drawing.Point(368, 8);
            this.btnOpenExcelFile.Name = "btnOpenExcelFile";
            this.btnOpenExcelFile.Size = new System.Drawing.Size(28, 21);
            this.btnOpenExcelFile.TabIndex = 29;
            this.btnOpenExcelFile.UseVisualStyleBackColor = true;
            this.btnOpenExcelFile.Click += new System.EventHandler(this.btnOpenExcelFile_Click);
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(56, 8);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(304, 21);
            this.txtExcelFile.TabIndex = 28;
            // 
            // lblExcelFile
            // 
            this.lblExcelFile.AutoSize = true;
            this.lblExcelFile.Location = new System.Drawing.Point(8, 12);
            this.lblExcelFile.Name = "lblExcelFile";
            this.lblExcelFile.Size = new System.Drawing.Size(44, 13);
            this.lblExcelFile.TabIndex = 27;
            this.lblExcelFile.Text = "Tên tệp";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.ImageIndex = 0;
            this.btnOK.ImageList = this.imlButton;
            this.btnOK.Location = new System.Drawing.Point(112, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 28);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "Thực hiện";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "file-export-16x16.png");
            this.imlButton.Images.SetKeyName(1, "Windows-Close-Program-icon.png");
            // 
            // ofdExcelFile
            // 
            this.ofdExcelFile.Filter = "Microsoft Office Excel (*.xls)|*.xls";
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imlButton;
            this.btnClose.Location = new System.Drawing.Point(208, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 28);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ImportFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(403, 78);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOpenExcelFile);
            this.Controls.Add(this.txtExcelFile);
            this.Controls.Add(this.lblExcelFile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportFromExcel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập dữ liệu từ Excel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportFromExcel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenExcelFile;
        private System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.Label lblExcelFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog ofdExcelFile;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.ImageList imlButton;

    }
}