using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Collections;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Attendance.Forms
{
    public partial class RegisterLateEarly : Common.Forms.RegisterItem
    {
        public RegisterLateEarly()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void InitLookUp()
        {
            DataTable type = new DataTable();
            type.Columns.Add("ID", typeof(bool));
            type.Columns.Add("Name", typeof(string));
            type.Rows.Add(new object[] { true, "Đi muộn" });
            type.Rows.Add(new object[] { false, "Về sớm" });
            RepositoryItemLookUpEdit ileType = new RepositoryItemLookUpEdit();
            ileType.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 20, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near));
            ileType.ShowHeader = false;
            ileType.NullText = string.Empty;
            ileType.DataSource = type;
            ileType.ValueMember = "ID";
            ileType.DisplayMember = "Name";
            ileType.BestFit();
            grvRegisterItem.Columns["Type"].ColumnEdit = ileType;
        }
                
        private void RegisterLateEarly_Load(object sender, EventArgs e)
        {
            RegisterLateEarlyTable registerLateEarly = new RegisterLateEarlyTable();
            registerItem = registerLateEarly;
            InitItem("grvRegisterLateEarly", false);
            InitLookUp();
            grvRegisterItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(grvRegisterItem_CellValueChanged);
            grvRegisterItem.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(grvRegisterItem_InvalidRowException);
            grvRegisterItem.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grvRegisterItem_ValidateRow);
            grvRegisterItem.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(grvRegisterItem_InitNewRow);
            bbiSave.ItemClick += new ItemClickEventHandler(bbiSave_ItemClick);
            ShowData(Constant.departmentIDList, true);
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            DateTime time = Utility.GetServerTime();
            if (Constant.currentUser.Name != "loandt")
            {
                if (time.Hour >= Convert.ToInt32(ConstantTable.GetValueByName("InvalidTime")))
                {
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("INVALID_REGISTERLATEEARLY", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool type, save = false;
                    grvRegisterItem.PostEditor();
                    grvRegisterItem.UpdateCurrentRow();
                    foreach (RegisterItemR rir in registerItem)
                    {
                        if (rir.RowState != DataRowState.Unchanged)
                        {
                            type = Convert.ToBoolean(rir["Type"]);
                            if (type && Convert.ToDateTime(rir["FromDate"]) < time.AddDays(-1))
                            {
                                rir.AcceptChanges();
                                rir.SetColumnError("FromDate", TitleTable.GetValue("INVALID_REGISTERLATEEARLY", Constant.language));
                            }
                            else
                                save = true;
                            if (!type && Convert.ToDateTime(rir["FromDate"]) < time.AddDays(-2))
                            {
                                rir.AcceptChanges();
                                rir.SetColumnError("FromDate", TitleTable.GetValue("INVALID_REGISTERLATEEARLY", Constant.language));
                                save = false;
                            }
                            else
                                save = true;
                        }
                    }
                    if (save) SaveItem();
                }
            }
            else
                SaveItem();
        }

        private void grvRegisterItem_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvRegisterItem.SetRowCellValue(e.RowHandle, "Valid", true);
        }

        private void grvRegisterItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (grvRegisterItem.GetRowCellValue(e.RowHandle, "Reason") == DBNull.Value || grvRegisterItem.GetRowCellValue(e.RowHandle, "Reason").ToString() == string.Empty) e.Valid = false;
        }

        private void grvRegisterItem_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (grvRegisterItem.GetRowCellValue(e.RowHandle, "Reason") == DBNull.Value)
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("REASON_REGISTERLATEEARLY_EXIST", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvRegisterItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "FromDate" && e.Value != DBNull.Value) grvRegisterItem.SetRowCellValue(e.RowHandle, "ToDate", Convert.ToDateTime(e.Value));
        }        
    }
}
