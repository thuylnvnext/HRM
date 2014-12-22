using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraEditors.Repository;
using Common;
using DevExpress.XtraEditors;

namespace Attendance.Forms
{
    public partial class DefineAttendanceTable : Common.Forms.DefineItem
    {
        private List<Operator> operators = new List<Operator>();
        private List<Function> functions = new List<Function>();

        public DefineAttendanceTable()
        {
            InitializeComponent();
            cmsItemGroup.Opening += new CancelEventHandler(cmsItemGroup_Opening);
            Utility.SetSkin(this);            
        }

        private void cmsItemGroup_Opening(object sender, CancelEventArgs e)
        {
            if (tvwItemGroup.SelectedNode.Name == "1")
            {
                cmsItemGroup.Items["mnuAdd"].Enabled = false;
                cmsItemGroup.Items["mnuDelete"].Enabled = false;
            }
            else
            {
                cmsItemGroup.Items["mnuAdd"].Enabled = true;
                cmsItemGroup.Items["mnuDelete"].Enabled = true;
            }
        }

        private void InitLookUp()
        {
            RepositoryItemLookUpEdit ileItemGroup = new RepositoryItemLookUpEdit();
            ileItemGroup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileItemGroup.ShowHeader = false;
            ileItemGroup.NullText = string.Empty;
            ileItemGroup.DataSource = itemGroup;
            ileItemGroup.ValueMember = "ID";
            ileItemGroup.DisplayMember = "Name";
            vgcItem.Rows["edrAttendanceTableGroupID"].Properties.RowEdit = ileItemGroup;

            List<DataType> dataTypes = new List<DataType>();
            dataTypes.Add(new DataType("Number", "Số"));
            dataTypes.Add(new DataType("Text", "Chuỗi"));
            RepositoryItemLookUpEdit ileDataType = new RepositoryItemLookUpEdit();
            ileDataType.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileDataType.ShowHeader = false;
            ileDataType.NullText = string.Empty;
            ileDataType.DataSource = dataTypes;
            ileDataType.ValueMember = "ID";
            ileDataType.DisplayMember = "Name";
            vgcItem.Rows["edrDataType"].Properties.RowEdit = ileDataType;
            grvDefineItem.Columns["DataType"].DisplayFormat.Format = new DataTypeFormatter(dataTypes);

            List<ItemType> itemTypes = new List<ItemType>();
            itemTypes.Add(new ItemType(1, "Mọi mức"));
            itemTypes.Add(new ItemType(2, "Mức cuối/ Tính tổng"));
            itemTypes.Add(new ItemType(3, "Mức cuối/ Không tính tổng"));
            RepositoryItemLookUpEdit ileItemType = new RepositoryItemLookUpEdit();
            ileItemType.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileItemType.ShowHeader = false;
            ileItemType.NullText = string.Empty;
            ileItemType.DataSource = itemTypes;
            ileItemType.ValueMember = "ID";
            ileItemType.DisplayMember = "Name";
            vgcItem.Rows["edrType"].Properties.RowEdit = ileItemType;
            grvDefineItem.Columns["Type"].DisplayFormat.Format = new ItemTypeFormatter(itemTypes);

            List<BooleanType> status = new List<BooleanType>();
            status.Add(new BooleanType(true, "Hiện"));
            status.Add(new BooleanType(false, "Ẩn"));
            RepositoryItemLookUpEdit ileStatus = new RepositoryItemLookUpEdit();
            ileStatus.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileStatus.ShowHeader = false;
            ileStatus.NullText = string.Empty;
            ileStatus.DataSource = status;
            ileStatus.ValueMember = "ID";
            ileStatus.DisplayMember = "Name";
            vgcItem.Rows["edrStatus"].Properties.RowEdit = ileStatus;

            RepositoryItemButtonEdit ibeValue = new RepositoryItemButtonEdit();
            vgcItem.Rows["edrValue"].Properties.RowEdit = ibeValue;
            ibeValue.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(ibeValue_ButtonClick);
        }

        private void FormatLogicValue()
        {
            RepositoryItemTextEdit ite = new RepositoryItemTextEdit();
            grvDefineItem.Columns["Status"].ColumnEdit = ite;
            grvDefineItem.Columns["Status"].DisplayFormat.Format = new BooleanFormatter("Hiện", "Ẩn");
        }

        private void InitOperators()
        {
            operators.Add(new Operator("+", "Cong (x + y)"));
            operators.Add(new Operator("-", "Tru (x - y)"));
            operators.Add(new Operator("*", "Nhan (x * y)"));
            operators.Add(new Operator("/", "Chia (x / y)"));
            operators.Add(new Operator("|", "LayPhanDu (x | y)"));
            operators.Add(new Operator("^", "LuyThua (x ^ y)"));
            operators.Add(new Operator("PhuDinh", "PhuDinh (PhuDinh x)"));
            operators.Add(new Operator("Va", "Va (x Va y)"));
            operators.Add(new Operator("Hoac", "Hoac (x Hoac y)"));
            operators.Add(new Operator("=", "Bang (x = y)"));
            operators.Add(new Operator("<>", "Khac (x <> y)"));
            operators.Add(new Operator(">", "LonHon (x > y)"));
            operators.Add(new Operator(">=", "LonHonHoacBang (x >= y)"));
            operators.Add(new Operator("<", "NhoHon (x < y)"));
            operators.Add(new Operator("<=", "NhoHonHoacBang (x <= y)"));
        }

        private void InitFunctions()
        {
            functions.Add(new Function("LuaChon(, , )", "LuaChon(bieu_thuc_logic, bieu_thuc_1, bieu_thuc_2)"));
            functions.Add(new Function("LamTron(, )", "LamTron(bieu_thuc, so_chu_so_thap_phan)"));
            functions.Add(new Function("NgayCongChuan()", "NgayCongChuan()"));
            functions.Add(new Function("DongBaoHiem()", "DongBaoHiem()"));
        }

        private void DefineAttendanceTable_Load(object sender, EventArgs e)
        {
            AttendanceTableGroupTable attendanceTableGroup = new AttendanceTableGroupTable();
            AttendanceTableTable attendanceTable = new AttendanceTableTable();
            attendanceTableGroup.GetContent();
            itemGroup = attendanceTableGroup;
            item = attendanceTable;

            ShowItemGroup();
            InitItem("grvDefineAttendanceTable");       
            InitLookUp();
            FormatLogicValue();
            grvDefineItem.Columns["AttendanceTableGroupID"].Visible = false;
            XtraMessageBox.Show(LookAndFeel, "Chức năng này dùng để cấu hình bảng chấm công theo ý muốn. Bạn hãy lưu ý khi sử dụng vì có thể làm sai lệch dữ liệu. Hãy liên hệ với người quản trị để sử dụng tính năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ibeValue_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Common.Forms.ExpressionEditor expressionEditor = new Common.Forms.ExpressionEditor(vgcItem.GetCellValue(vgcItem.FocusedRow, vgcItem.FocusedRecord).ToString(), operators, functions);
            if (expressionEditor.ShowDialog() == DialogResult.OK)
            {
                DevExpress.XtraEditors.ButtonEdit buttonEdit = (DevExpress.XtraEditors.ButtonEdit)vgcItem.ActiveEditor;
                buttonEdit.EditValue = expressionEditor.GetValue;
            }
        }
    }
}
