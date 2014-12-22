using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Common
{
    public class PageCategory : RibbonPageCategory
    {
        public PageCategory(string text, Color color)
            : base(text, color)
        { 
        }
        public void AddPage(string[] names)
        {
            foreach (string name in names)
            {
                Pages.Add(new RibbonPage(name));
            }
        }
        public void AddPage(string[] names, string[] texts)
        {
            for (int n = 0; n < names.Length; n++)
            {
                RibbonPage rbp = new RibbonPage();
                rbp.Name = names[n];
                rbp.Text = texts[n];
                Pages.Add(rbp);
            }
        }
        public void AddPageGroup(RibbonPage page, string[] names)
        {
            foreach (string name in names)
            {
                RibbonPageGroup pageGroup = new RibbonPageGroup(name);
                pageGroup.ShowCaptionButton = false;
                page.Groups.Add(pageGroup);
            }
        }
        public void AddPageGroup(RibbonPage page, string[] names, string[] texts)
        {
            for (int n = 0; n < names.Length; n++)
            {
                RibbonPageGroup pageGroup = new RibbonPageGroup(texts[n]);
                pageGroup.Name = names[n];
                pageGroup.ShowCaptionButton = false;
                page.Groups.Add(pageGroup);
            }
        }
        public BarButtonItem AddBarButtonItem(RibbonPageGroup pageGroup, Image image, string caption, ItemClickEventHandler itemClickEventHandler)
        {
            BarButtonItem barButtonItem = new BarButtonItem();
            barButtonItem.LargeGlyph = image;
            barButtonItem.Caption = caption;
            barButtonItem.ItemClick += itemClickEventHandler;
            pageGroup.ItemLinks.Add(barButtonItem);

            return barButtonItem;
        }
        public BarButtonItem AddBarButtonItem(RibbonPageGroup pageGroup, string name, Image image, string caption, ItemClickEventHandler itemClickEventHandler)
        {
            BarButtonItem barButtonItem = new BarButtonItem();
            barButtonItem.Name = name;
            barButtonItem.LargeGlyph = image;
            barButtonItem.Caption = caption;
            barButtonItem.ItemClick += itemClickEventHandler;
            pageGroup.ItemLinks.Add(barButtonItem);

            return barButtonItem;
        }
        public BarButtonItem AddBarButtonItem(RibbonPageGroup pageGroup, Image image, string caption, PopupControlContainer popupControl, ItemClickEventHandler itemClickEventHandler)
        {
            BarButtonItem barButtonItem = new BarButtonItem();
            barButtonItem.LargeGlyph = image;
            barButtonItem.Caption = caption;
            barButtonItem.ButtonStyle = BarButtonStyle.DropDown;
            barButtonItem.DropDownControl = popupControl;
            barButtonItem.ItemClick += itemClickEventHandler;
            pageGroup.ItemLinks.Add(barButtonItem);

            return barButtonItem;
        }
        public BarButtonItem AddBarButtonItem(RibbonPageGroup pageGroup, string name, Image image, string caption, PopupControlContainer popupControl, ItemClickEventHandler itemClickEventHandler)
        {
            BarButtonItem barButtonItem = new BarButtonItem();
            barButtonItem.Name = name;
            barButtonItem.LargeGlyph = image;
            barButtonItem.Caption = caption;
            barButtonItem.ButtonStyle = BarButtonStyle.DropDown;
            barButtonItem.DropDownControl = popupControl;
            barButtonItem.ItemClick += itemClickEventHandler;
            pageGroup.ItemLinks.Add(barButtonItem);

            return barButtonItem;
        }
    }
}
