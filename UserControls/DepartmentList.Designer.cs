namespace HRMplus.UserControls
{
    partial class DepartmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentList));
            this.tvwDepartment = new System.Windows.Forms.TreeView();
            this.cmsDepartment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNightWork = new System.Windows.Forms.ToolStripMenuItem();
            this.imlDepartment = new System.Windows.Forms.ImageList(this.components);
            this.txtFind = new DevExpress.XtraEditors.TextEdit();
            this.cmsDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwDepartment
            // 
            this.tvwDepartment.AllowDrop = true;
            this.tvwDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwDepartment.CheckBoxes = true;
            this.tvwDepartment.ContextMenuStrip = this.cmsDepartment;
            this.tvwDepartment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwDepartment.HideSelection = false;
            this.tvwDepartment.ImageIndex = 0;
            this.tvwDepartment.ImageList = this.imlDepartment;
            this.tvwDepartment.Location = new System.Drawing.Point(0, 0);
            this.tvwDepartment.Name = "tvwDepartment";
            this.tvwDepartment.SelectedImageIndex = 0;
            this.tvwDepartment.Size = new System.Drawing.Size(150, 128);
            this.tvwDepartment.TabIndex = 14;
            this.tvwDepartment.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwDepartment_AfterCheck);
            this.tvwDepartment.DragLeave += new System.EventHandler(this.tvwDepartment_DragLeave);
            this.tvwDepartment.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvwDepartment_DragDrop);
            this.tvwDepartment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tvwDepartment_MouseMove);
            this.tvwDepartment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvwDepartment_MouseDown);
            this.tvwDepartment.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvwDepartment_DragEnter);
            this.tvwDepartment.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDepartment_NodeMouseClick);
            this.tvwDepartment.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvwDepartment_ItemDrag);
            this.tvwDepartment.DragOver += new System.Windows.Forms.DragEventHandler(this.tvwDepartment_DragOver);
            // 
            // cmsDepartment
            // 
            this.cmsDepartment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuEdit,
            this.mnuDelete,
            this.mnuShowAll,
            this.toolStripSeparator1,
            this.mnuCollapse,
            this.mnuExpand,
            this.toolStripSeparator3,
            this.mnuNightWork});
            this.cmsDepartment.Name = "cmsDepartment";
            this.cmsDepartment.Size = new System.Drawing.Size(149, 170);
            this.cmsDepartment.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDepartment_Opening);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdd.Image")));
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(148, 22);
            this.mnuAdd.Text = "Thêm mới...";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = ((System.Drawing.Image)(resources.GetObject("mnuEdit.Image")));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(148, 22);
            this.mnuEdit.Text = "Sửa đổi...";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelete.Image")));
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(148, 22);
            this.mnuDelete.Text = "Xóa";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuShowAll
            // 
            this.mnuShowAll.Name = "mnuShowAll";
            this.mnuShowAll.Size = new System.Drawing.Size(148, 22);
            this.mnuShowAll.Text = "Hiển thị tất cả";
            this.mnuShowAll.Click += new System.EventHandler(this.mnuShowAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // mnuCollapse
            // 
            this.mnuCollapse.Image = ((System.Drawing.Image)(resources.GetObject("mnuCollapse.Image")));
            this.mnuCollapse.Name = "mnuCollapse";
            this.mnuCollapse.Size = new System.Drawing.Size(148, 22);
            this.mnuCollapse.Text = "Thu gọn";
            this.mnuCollapse.Click += new System.EventHandler(this.mnuCollapse_Click);
            // 
            // mnuExpand
            // 
            this.mnuExpand.Image = ((System.Drawing.Image)(resources.GetObject("mnuExpand.Image")));
            this.mnuExpand.Name = "mnuExpand";
            this.mnuExpand.Size = new System.Drawing.Size(148, 22);
            this.mnuExpand.Text = "Mở rộng";
            this.mnuExpand.Click += new System.EventHandler(this.mnuExpand_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // mnuNightWork
            // 
            this.mnuNightWork.Image = ((System.Drawing.Image)(resources.GetObject("mnuNightWork.Image")));
            this.mnuNightWork.Name = "mnuNightWork";
            this.mnuNightWork.Size = new System.Drawing.Size(148, 22);
            this.mnuNightWork.Text = "Giờ làm đêm";
            this.mnuNightWork.Click += new System.EventHandler(this.mnuNightWork_Click);
            // 
            // imlDepartment
            // 
            this.imlDepartment.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlDepartment.ImageStream")));
            this.imlDepartment.TransparentColor = System.Drawing.Color.Transparent;
            this.imlDepartment.Images.SetKeyName(0, "1352299539_go-home.png");
            this.imlDepartment.Images.SetKeyName(1, "1352299848_edit_group.png");
            // 
            // txtFind
            // 
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFind.Location = new System.Drawing.Point(0, 130);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(150, 20);
            this.txtFind.TabIndex = 15;
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress);
            // 
            // DepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.tvwDepartment);
            this.Name = "DepartmentList";
            this.Load += new System.EventHandler(this.DepartmentList_Load);
            this.cmsDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TreeView tvwDepartment;
        internal System.Windows.Forms.ImageList imlDepartment;
        private System.Windows.Forms.ContextMenuStrip cmsDepartment;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuShowAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.TextEdit txtFind;
        private System.Windows.Forms.ToolStripMenuItem mnuCollapse;
        private System.Windows.Forms.ToolStripMenuItem mnuExpand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuNightWork;

    }
}
