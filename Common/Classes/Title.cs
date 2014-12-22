using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Database;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace Common
{
    public class Title
    {
        public static void SetTitle(Form form)
        {
            TitleTable title = new TitleTable();
            int index, index1, selectedIndex;
            Control[] ct;
            title.GetListByForm(form.Name, Constant.language);            
            TitleRow tr = title.FindByPrimaryKey(form.Name, Constant.language);
            if (tr != null) form.Text = tr.Value; 
            foreach (TitleRow _tr in title)
            {
                index = _tr.Item.IndexOf('.');
                index1 = _tr.Item.IndexOf('.', index + 1);
                if (index1 >= 0)
                {
                    selectedIndex = Convert.ToInt32(_tr.Item.Substring(index1 + 1));
                    ct = form.Controls.Find(index > -1 ? _tr.Item.Substring(index + 1, index1 - index - 1) : _tr.Item, true);
                }
                else
                {
                    selectedIndex = -1;
                    ct = form.Controls.Find(index > -1 ? _tr.Item.Substring(index + 1) : _tr.Item, true);
                }
                
                if (ct.Length > 0)
                {
                    if (selectedIndex == -1)
                        ct[0].Text = _tr.Value;
                    else
                        ((RadioGroup)ct[0]).Properties.Items[selectedIndex].Description = _tr.Value;                    
                }
            }
        }

        public static void SetTitle(Form form, DevExpress.XtraGrid.Views.Grid.GridView grv)
        {
            TitleTable title = new TitleTable();
            int index;
            GridColumn grc;
            title.GetListByForm(form.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                index = tr.Item.IndexOf('.');
                grc = grv.Columns.ColumnByName(index > -1 ? tr.Item.Substring(index + 1) : tr.Item);
                if (grc != null) grc.Caption = tr.Value;
            }
        }

        public static void SetTitle(Form form, BandedGridView bgv)
        {
            TitleTable title = new TitleTable();
            GridBand grb;
            //GridColumn grc;
            title.GetListByForm(form.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                string[] items = tr.Item.Split(new char[] { '.' });
                if (items.Length > 1)
                {
                    grb = bgv.Bands[items[1]];
                    if (grb != null)
                    {
                        for (int i = 2; i < items.Length; i++)
                        {
                            grb = grb.Children[items[i]];
                        }
                        if (grb != null) grb.Caption = tr.Value;
                    }
                    //else
                    //{
                    //    grc = bgv.Columns.ColumnByName(items[items.Length - 1]);
                    //    if (grc != null) grc.Caption = tr.Value;
                    //}
                }
            }
        }

        public static void SetTitle(UserControl uc)
        {
            TitleTable title = new TitleTable();
            int index;
            Control[] ct;
            title.GetListByForm(uc.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                index = tr.Item.IndexOf('.');
                ct = uc.Controls.Find(index > -1 ? tr.Item.Substring(index + 1) : tr.Item, true);
                if (ct.Length > 0)
                {
                    ct[0].Text = tr.Value;
                }
            }
        }

        public static void SetTitle(UserControl uc, DevExpress.XtraGrid.Views.Grid.GridView grv)
        {
            TitleTable title = new TitleTable();
            int index;
            GridColumn grc;
            title.GetListByForm(uc.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                index = tr.Item.IndexOf('.');
                grc = grv.Columns.ColumnByName(index > -1 ? tr.Item.Substring(index + 1) : tr.Item);
                if (grc != null) grc.Caption = tr.Value;
            }
        }

        public static void SetTitle(UserControl uc, BandedGridView bgv)
        {
            TitleTable title = new TitleTable();
            GridBand grb;
            GridColumn grc;
            title.GetListByForm(uc.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                string[] items = tr.Item.Split(new char[] {'.'});
                if (items.Length > 1)
                {
                    grb = bgv.Bands[items[1]];
                    if (grb != null)
                    {
                        for (int i = 2; i < items.Length; i++)
                        {
                            grb = grb.Children[items[i]];
                        }
                        grb.Caption = tr.Value;
                    }
                    else
                    {
                        grc = bgv.Columns.ColumnByName(items[items.Length - 1]);
                        if (grc != null) grc.Caption = tr.Value;
                    }
                }
            }
        }

        public static void SetTitle(Form form, TreeView tvw)
        {
            TitleTable title = new TitleTable();
            int index;
            TreeNode[] tn;
            title.GetListByForm(form.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                index = tr.Item.IndexOf('.');
                tn = tvw.Nodes.Find(index > -1 ? tr.Item.Substring(index + 1) : tr.Item, true);
                if (tn.Length > 0) tn[0].Text= tr.Value;
            }
        }

        public static void SetTitle(UserControl uc, TreeView tvw)
        {
            TitleTable title = new TitleTable();
            int index;
            TreeNode[] tn;
            title.GetListByForm(uc.Name, Constant.language);
            foreach (TitleRow tr in title)
            {
                index = tr.Item.IndexOf('.');
                tn = tvw.Nodes.Find(index > -1 ? tr.Item.Substring(index + 1) : tr.Item, true);
                if (tn.Length > 0) tn[0].Text = tr.Value;
            }
        }

        public static void SetTitle(Form form, DevExpress.XtraTab.XtraTabPage tap)
        {
            TitleTable title = new TitleTable();

            title.GetListByForm(form.Name, Constant.language);
            TitleRow tr = title.FindByPrimaryKey(form.Name + "." + tap.Name, Constant.language);
            if (tr != null) tap.Text = tr.Value;
        }

        public static void SetTitle(UserControl uc, DevExpress.XtraTab.XtraTabPage tap)
        {
            TitleTable title = new TitleTable();

            title.GetListByForm(uc.Name, Constant.language);
            TitleRow tr = title.FindByPrimaryKey(uc.Name + "." + tap.Name, Constant.language);
            if (tr != null) tap.Text = tr.Value;
        }
    }
}
