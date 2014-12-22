using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Database;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.Utils.Commands;

namespace Personnel.Forms
{
    public partial class ContractForm : RibbonForm
    {
        FormTable form = new FormTable();
        FormRow fr;
        string type;

        public ContractForm(string type)
        {
            InitializeComponent();
            bdcMain.LookAndFeel.SkinName = Constant.skin;
            this.type = type;
            Utility.SetSkin(this);
        }

        private void FormOfContract_Load(object sender, EventArgs e)
        {
            recFormOfLabourContract.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A4;
            recFormOfLabourContract.Document.Sections[0].Margins.Left = 200;
            recFormOfLabourContract.Document.Sections[0].Margins.Right = 200;

            form.GetContent();
            fr = form.FindByPrimaryKey(type);
            if (fr != null) recFormOfLabourContract.RtfText = fr.Value;
        }

        private void beiFontFamily_EditValueChanged(object sender, EventArgs e)
        {
            //Document doc = recFormOfLabourContract.Document;
            //DocumentRange range = doc.Selection;
            //Paragraph paragraph = doc.GetParagraph(doc.CaretPosition);
            //CharacterProperties cp = doc.BeginUpdateCharacters(range);
            //cp.FontName = beiFontFamily.EditValue.ToString();
            //doc.EndUpdateCharacters(cp);
            //recFormOfLabourContract.Focus();
        }

        private void bciBold_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            //DevExpress.XtraRichEdit.Commands.ToggleFontBoldCommand bold = new DevExpress.XtraRichEdit.Commands.ToggleFontBoldCommand(recFormOfLabourContract);
            //bold.Execute();
        }

        private void bciCenter_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            
        }

        private void recFormOfLabourContract_SelectionChanged(object sender, EventArgs e)
        {
            Document doc = recFormOfLabourContract.Document;
            DocumentRange range = doc.Selection;
            if (range.Start == range.End) range = doc.CreateRange(doc.CaretPosition, 1);
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            beiFontFamily.EditValue = cp.FontName;
            beiFontSize.EditValue = cp.FontSize;
            if (cp.Bold != null)
                bciBold.Checked = cp.Bold.Value;
            else
                bciBold.Checked = false;
            if (cp.Italic != null)
                bciItalic.Checked = cp.Italic.Value;
            else
                bciItalic.Checked = false;
            if (cp.Underline != null)
                bciUnderline.Checked = (cp.Underline.Value == UnderlineType.Single ? true : false);
            else
                bciUnderline.Checked = false;
            doc.EndUpdateCharacters(cp);

            ParagraphProperties pp = doc.BeginUpdateParagraphs(doc.GetParagraph(doc.CaretPosition).Range);
            if (pp.Alignment.HasValue)
            {
                switch (pp.Alignment.Value)
                {
                    case ParagraphAlignment.Left:
                        bciLeft.Checked = true;
                        bciCenter.Checked = false;
                        bciRight.Checked = false;
                        bciJustify.Checked = false;
                        break;
                    case ParagraphAlignment.Center:
                        bciLeft.Checked = false;
                        bciCenter.Checked = true;
                        bciRight.Checked = false;
                        bciJustify.Checked = false;
                        break;
                    case ParagraphAlignment.Right:
                        bciLeft.Checked = false;
                        bciCenter.Checked = false;
                        bciRight.Checked = true;
                        bciJustify.Checked = false;
                        break;
                    case ParagraphAlignment.Justify:
                        bciLeft.Checked = false;
                        bciCenter.Checked = false;
                        bciRight.Checked = false;
                        bciJustify.Checked = true;
                        break;
                }
            }
            doc.EndUpdateParagraphs(pp);
        }

        private void bciBold_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToggleFontBoldCommand bold = new ToggleFontBoldCommand(recFormOfLabourContract);
            bold.Execute();
            recFormOfLabourContract.Focus();
        }

        private void bciItalic_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToggleFontItalicCommand italic = new ToggleFontItalicCommand(recFormOfLabourContract);
            italic.Execute();
            recFormOfLabourContract.Focus();
        }

        private void bciUnderline_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToggleFontUnderlineCommand underline = new ToggleFontUnderlineCommand(recFormOfLabourContract);
            underline.Execute();
            recFormOfLabourContract.Focus();
        }

        private void icbFontSize_EditValueChanged(object sender, EventArgs e)
        {
            Ribbon.Manager.ActiveEditItemLink.PostEditor();
            //ChangeFontSizeCommand command = new ChangeFontSizeCommand(recFormOfLabourContract, Convert.ToInt32(beiFontSize.EditValue));
            ChangeFontSizeCommand command = new ChangeFontSizeCommand(recFormOfLabourContract);
            command.Execute();
            recFormOfLabourContract.Focus();
        }

        private void ifeFontFamily_EditValueChanged(object sender, EventArgs e)
        {
            Ribbon.Manager.ActiveEditItemLink.PostEditor();
            //ChangeFontNameCommand command = new ChangeFontNameCommand(recFormOfLabourContract, beiFontFamily.EditValue.ToString());
            ChangeFontSizeCommand command = new ChangeFontSizeCommand(recFormOfLabourContract);
            command.Execute();
            recFormOfLabourContract.Focus();
        }

        private void bciJustify_CheckedChanged(object sender, ItemClickEventArgs e)
        {
        }

        private void bciJustify_ItemClick(object sender, ItemClickEventArgs e)
        {
            Document doc = recFormOfLabourContract.Document;
            DocumentRange range = doc.Selection;
            ParagraphProperties pp = doc.BeginUpdateParagraphs(range);
            pp.Alignment = ParagraphAlignment.Justify;
            doc.EndUpdateParagraphs(pp);

            BarCheckItem checkItem = (BarCheckItem)e.Item;
            if (checkItem.Checked)
            {
                foreach (BarCheckItemLink bci in bbgAlignment.ItemLinks)
                {
                    if ((BarCheckItem)bci.Item != checkItem) ((BarCheckItem)bci.Item).Checked = false;
                }
            }
            else
                checkItem.Checked = true;
        }

        private void bciCenter_ItemClick(object sender, ItemClickEventArgs e)
        {
            Document doc = recFormOfLabourContract.Document;
            DocumentRange range = doc.Selection;
            ParagraphProperties pp = doc.BeginUpdateParagraphs(range);
            pp.Alignment = ParagraphAlignment.Center;
            doc.EndUpdateParagraphs(pp);

            BarCheckItem checkItem = (BarCheckItem)e.Item;
            if (checkItem.Checked)
            {
                foreach (BarCheckItemLink bci in bbgAlignment.ItemLinks)
                {
                    if ((BarCheckItem)bci.Item != checkItem) ((BarCheckItem)bci.Item).Checked = false;
                }
            }
            else
                checkItem.Checked = true;
        }

        private void bciLeft_ItemClick(object sender, ItemClickEventArgs e)
        {
            Document doc = recFormOfLabourContract.Document;
            DocumentRange range = doc.Selection;
            ParagraphProperties pp = doc.BeginUpdateParagraphs(range);
            pp.Alignment = ParagraphAlignment.Left;
            doc.EndUpdateParagraphs(pp);

            BarCheckItem checkItem = (BarCheckItem)e.Item;
            if (checkItem.Checked)
            {
                foreach (BarCheckItemLink bci in bbgAlignment.ItemLinks)
                {
                    if ((BarCheckItem)bci.Item != checkItem) ((BarCheckItem)bci.Item).Checked = false;
                }
            }
            else
                checkItem.Checked = true;
        }

        private void bciRight_ItemClick(object sender, ItemClickEventArgs e)
        {
            Document doc = recFormOfLabourContract.Document;
            DocumentRange range = doc.Selection;
            ParagraphProperties pp = doc.BeginUpdateParagraphs(range);
            pp.Alignment = ParagraphAlignment.Right;
            doc.EndUpdateParagraphs(pp);

            BarCheckItem checkItem = (BarCheckItem)e.Item;
            if (checkItem.Checked)
            {
                foreach (BarCheckItemLink bci in bbgAlignment.ItemLinks)
                {
                    if ((BarCheckItem)bci.Item != checkItem) ((BarCheckItem)bci.Item).Checked = false;
                }
            }
            else
                checkItem.Checked = true;
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {            
            bool retVal1, retVal2;

            fr = form.FindByPrimaryKey(type);
            if (fr != null)
                fr.Value = recFormOfLabourContract.RtfText;
            else
                form.AddFormRow(type, recFormOfLabourContract.RtfText);
            retVal1 = form.Insert();
            retVal2 = form.Update();
            if (retVal1 && retVal2)
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("FORM_SAVE_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("FORM_SAVE_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
