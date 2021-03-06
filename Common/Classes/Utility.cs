using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Database;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Common
{
    public static class Utility
    {
        public static bool IsDateTime(object dt)
        {
            if (dt == null) return false;
            try
            {
                DateTime.Parse(Convert.ToDateTime(dt, new System.Globalization.CultureInfo("vi-VN")).ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNumeric(object n)
        {
            try
            {
                Decimal.Parse(n.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string ToMonthName(DateTime d)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(d.Month);
        }

        public static string ToShortMonthName(this DateTime d)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(d.Month);
        }

        public static string GetWeekDay(DateTime d)
        {
            string weekDay = string.Empty;

            switch (d.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    weekDay = "T2";
                    break;
                case DayOfWeek.Tuesday:
                    weekDay = "T3";
                    break;
                case DayOfWeek.Wednesday:
                    weekDay = "T4";
                    break;
                case DayOfWeek.Thursday:
                    weekDay = "T5";
                    break;
                case DayOfWeek.Friday:
                    weekDay = "T6";
                    break;
                case DayOfWeek.Saturday:
                    weekDay = "T7";
                    break;
                case DayOfWeek.Sunday:
                    weekDay = "CN";
                    break;
            }
            return weekDay;
        }

        public static DateTime NearestWeekDay(DateTime d, DayOfWeek w)
        {
            DateTime retVal = new DateTime(9999, 12, 31);
            switch (w)
            {
                case DayOfWeek.Monday:
                    switch (d.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            retVal = d;
                            break;
                        case DayOfWeek.Tuesday:
                            retVal = d.AddDays(-1);
                            break;
                        case DayOfWeek.Wednesday:
                            retVal = d.AddDays(-2);
                            break;
                        case DayOfWeek.Thursday:
                            retVal = d.AddDays(-3);
                            break;
                        case DayOfWeek.Friday:
                            retVal = d.AddDays(-4);
                            break;
                        case DayOfWeek.Saturday:
                            retVal = d.AddDays(-5);
                            break;
                        case DayOfWeek.Sunday:
                            retVal = d.AddDays(-6);
                            break;
                    }
                    break;
                case DayOfWeek.Sunday:
                    switch (d.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            retVal = d;
                            break;
                        case DayOfWeek.Saturday:
                            retVal = d.AddDays(1);
                            break;
                        case DayOfWeek.Friday:
                            retVal = d.AddDays(2);
                            break;
                        case DayOfWeek.Thursday:
                            retVal = d.AddDays(3);
                            break;
                        case DayOfWeek.Wednesday:
                            retVal = d.AddDays(4);
                            break;
                        case DayOfWeek.Tuesday:
                            retVal = d.AddDays(5);
                            break;
                        case DayOfWeek.Monday:
                            retVal = d.AddDays(6);
                            break;
                    }
                    break;
            }
            return retVal;
        }

        public static bool ValidEmail(string eMail)
        {
            if (eMail == string.Empty) return false;
            if (eMail.IndexOf(" ") > 0) return false;
            if (eMail.IndexOf("@") == -1) return false;

            int length = eMail.Length;

            if (eMail.IndexOf(".") == -1) return false;
            if (eMail.IndexOf("..") != -1) return false;
            if (eMail.IndexOf("@") != eMail.LastIndexOf("@")) return false;
            if (eMail.LastIndexOf(".") == length - 1) return false;

            string s = "abcdefghikjlmnopqrstuvwxyz-@._";

            for (int i = 0; i < length; i++)
            {
                if (s.IndexOf(s.Substring(i, 1)) == -1) return false;
            }
            return true;
        }

        public static string MoneyToText(decimal number)
        {
            decimal num, t;
            ulong numberOfThousands;
            int i, hundred = 0, ten = 0, unit = 0;
            string s;
            decimal[] thousands = new decimal[6];
            string[] thousandsName = new string[] { "", " nghìn,", " triệu,", " tỷ,", " nghìn tỷ," };
            string[] digit = new string[] { " không", " một", " hai", " ba", " bốn", " năm", " sáu", " bảy", " tám", " chín" };

            if (number <= 0) return string.Empty;
            num = number;
            numberOfThousands = 0;
            while (num > 0)
            {
                t = num;
                num = (ulong)(num / 1000);
                thousands[numberOfThousands] = t - num * 1000;
                numberOfThousands++;
            }
            i = (int)numberOfThousands - 1;
            s = string.Empty;
            while (i >= 0)
            {
                num = thousands[i];
                if (num > 0)
                {
                    hundred = (int)(num / 100);
                    ten = (int)((num - hundred * 100) / 10);
                    unit = (int)((num - hundred * 100) % 10);
                    if (s != string.Empty || hundred > 0) s += digit[hundred] + " trăm";
                    if (ten > 1)
                    {
                        s += digit[ten] + " mươi";
                    }
                    else if (ten == 1)
                    {
                        s += " mười";
                    }
                    else if (s != string.Empty && ten == 0 && unit != 0)
                    {
                        s += " linh";
                    }
                    if (unit == 1 && ten != 0)
                    {
                        s += " mốt";
                    }
                    else if (unit != 5 && unit != 0)
                    {
                        s += digit[unit];
                    }
                    else if (unit == 5 && ten != 0)
                    {
                        s += " lăm";
                    }
                    else if (unit == 5 && ten == 0)
                    {
                        s += " năm";
                    }
                    s += i != 1 ? thousandsName[i] : thousandsName[i].Substring(0, thousandsName[i].Length - 1);
                }
                i--;
            }
            s = s.Substring(1, 1).ToUpper() + s.Substring(2, s.Length - 2);

            return s;
        }

        public static void SetPermission(DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroup, string pageCategoryName)
        {
            RightOfGroupTable rightOfGroup = new RightOfGroupTable();
            string[] functionID;

            rightOfGroup.GetListByGroupID(Constant.currentUser.GroupID, 2);
            foreach (RightOfGroupRow rgr in rightOfGroup)
            {
                functionID = rgr.FunctionID.Split('|');
                if (functionID[1] == pageCategoryName)
                {
                    foreach (DevExpress.XtraBars.BarItemLink itemLink in pageGroup.ItemLinks)
                    {
                        if (itemLink.Item.Name == functionID[0]) itemLink.Item.Enabled = false;
                    }
                }
            }
        }

        public static void SetPermission(System.Windows.Forms.Form form)
        {
            RightOfGroupTable rightOfGroup = new RightOfGroupTable();
            string[] functionID;
            //System.Windows.Forms.Control[] control;
            System.Windows.Forms.ToolStripItem[] tst;

            rightOfGroup.GetListByGroupID(Constant.currentUser.GroupID, 2);
            foreach (RightOfGroupRow rgr in rightOfGroup)
            {
                functionID = rgr.FunctionID.Split('|');
                if (functionID[1] == form.Name)
                {
                    foreach (System.Windows.Forms.Control ctl in form.Controls)
                    {
                        if (ctl is System.Windows.Forms.Button)
                        {
                            if (ctl.Name == functionID[0]) ctl.Enabled = false;
                        }
                        if (ctl is System.Windows.Forms.ToolStrip)
                        {
                            tst = ((System.Windows.Forms.ToolStrip)ctl).Items.Find(functionID[0], true);
                            if (tst.Length > 0) tst[0].Enabled = false;
                        }
                        if (ctl is DevExpress.XtraTab.XtraTabControl)
                        {
                            if (((DevExpress.XtraTab.XtraTabControl)ctl).TabPages[Convert.ToInt32(functionID[0])] != null) ((DevExpress.XtraTab.XtraTabControl)ctl).TabPages[Convert.ToInt32(functionID[0])].PageEnabled = false;
                        }
                    }
                }
            }
        }

        public static string GetCPUID()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    // Lấy về mã số Processor.
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        public static void SetSkin(System.Windows.Forms.Control control)
        {
            Type type = control.GetType();
            System.Reflection.PropertyInfo pi = type.GetProperty("LookAndFeel");
            if (pi != null)
            {
                DevExpress.LookAndFeel.UserLookAndFeel lookAndFeel = (DevExpress.LookAndFeel.UserLookAndFeel)pi.GetValue(control, null);
                type = lookAndFeel.GetType();
                pi = type.GetProperty("SkinName");
                if (pi != null)
                {
                    pi.SetValue(lookAndFeel, Constant.skin, null);
                }
                pi = type.GetProperty("UseDefaultLookAndFeel");
                if (pi != null)
                {
                    pi.SetValue(lookAndFeel, false, null);
                }
            }

            foreach (System.Windows.Forms.Control c in control.Controls)
            {
                SetSkin(c);
            }
        }

        public static void SetSkin(System.Windows.Forms.Control control, string skinName)
        {
            Type type = control.GetType();
            System.Reflection.PropertyInfo pi = type.GetProperty("LookAndFeel");
            if (pi != null)
            {
                DevExpress.LookAndFeel.UserLookAndFeel lookAndFeel = (DevExpress.LookAndFeel.UserLookAndFeel)pi.GetValue(control, null);
                type = lookAndFeel.GetType();
                pi = type.GetProperty("SkinName");
                if (pi != null)
                {
                    pi.SetValue(lookAndFeel, skinName, null);
                }
                pi = type.GetProperty("UseDefaultLookAndFeel");
                if (pi != null)
                {
                    pi.SetValue(lookAndFeel, false, null);
                }
            }

            foreach (System.Windows.Forms.Control c in control.Controls)
            {
                SetSkin(c, skinName);
            }
        }

        public static void SetSkin(DevExpress.XtraBars.BarManager barManager)
        {
            foreach (DevExpress.XtraBars.BarItem bar in barManager.Items)
            {
                if (bar is DevExpress.XtraBars.BarEditItem) ((DevExpress.XtraBars.BarEditItem)bar).Edit.LookAndFeel.SkinName = Constant.skin;
            }
        }

        public static DevExpress.XtraBars.PopupControlContainer CreatePopupControl()
        {
            DevExpress.XtraBars.PopupControlContainer popupControl = new DevExpress.XtraBars.PopupControlContainer();
            System.Windows.Forms.Label lblLanguage = new System.Windows.Forms.Label();
            DevExpress.XtraEditors.ComboBoxEdit comboxEdit = new DevExpress.XtraEditors.ComboBoxEdit();

            lblLanguage.Text = TitleTable.GetValue("LANGUAGE", Constant.language);
            Utility.SetSkin(comboxEdit);
            comboxEdit.Name = "cboLanguage";
            foreach (TitleRow tr in TitleTable.GetLanguages())
            {
                comboxEdit.Properties.Items.Add(tr.Language);
            }
            comboxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboxEdit.Text = Constant.language;
            popupControl.Controls.AddRange(new System.Windows.Forms.Control[] { lblLanguage, comboxEdit });
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new System.Drawing.Point(0, 2);
            comboxEdit.Location = new System.Drawing.Point(lblLanguage.Width + 3, 0);
            popupControl.Size = new System.Drawing.Size(lblLanguage.Width + 3 + comboxEdit.Width, comboxEdit.Height);

            return popupControl;
        }

        public static string GetColumnNameFromIndex(int index)
        {
            string endColumn = string.Empty;
            int f, s;

            f = (int)((index - 1) / 26) + 64;
            s = (index - 1) % 26 + 65;

            if (f > 64) endColumn = ((char)f).ToString();
            endColumn += ((char)s).ToString();

            return endColumn;    
        }

        public static int GetIndexFromColumnName(string columnName)
        {
            int index;

            if (columnName.Length == 1)
                index = (char)(columnName[0]) - 64;
            else
                index = 26 * (char)(columnName[0]) + ((char)(columnName[1]) - 64);

            return index;
        }

        public static string RemoveSign(string st)
        {
            if (st == string.Empty) return string.Empty;

            string signChars, unSignChars;
            int count, count1;

            signChars = "ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝĐ";
            unSignChars = "aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYD";

            count = 0;
            while (count < st.Length)
            {
                count1 = 0;
                while (count1 < signChars.Length)
                {
                    if (((int)signChars[count1]) == ((int)st[count]))
                    {
                        if (count == 0)
                            st = unSignChars.Substring(count1, 1) + st.Substring(count + 1, st.Length - 1);
                        else
                            st = st.Substring(0, count) + unSignChars.Substring(count1, 1) + st.Substring(count + 1, st.Length - count - 1);
                        break;
                    }
                    count1++;
                }
                count++;
            }

            return st;
        }

        public static string ConvertToRTFFormat(string st)
        {
            string retVal = string.Empty;
            
            for (int i = 0; i < st.Length; i++)
            {
                retVal += @"\u" + ((int)st[i]).ToString() + "?";
            }

            return retVal;
        }

        public static string NumberToText(int number)
        {
            if (number == 0) return "zero";
            if (number == -2147483648) return "Minus Two Billion One Hundred Forty Seven Million Four Hundred Eighty Three Thousand Six Hundred Forty Eight";
            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(); 
            if (number < 0)
            {
                sb.Append("minus ");
                number = -number;
            }
            string[] words0 = {"", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine "};
            string[] words1 = {"ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ", "nineteen "};
            string[] words2 = {"twenty ", "thirty ", "forty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety "};
            string[] words3 = { "thousand ", "million ", "billion " };
            num[0] = number % 1000;           // units
            num[1] = number / 1000;
            num[2] = number / 1000000;
            num[1] = num[1] - 1000 * num[2];  // thousands
            num[3] = number / 1000000000;     // billions
            num[2] = num[2] - 1000 * num[3];  // millions
            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10;              // ones
                t = num[i] / 10;
                h = num[i] / 100;             // hundreds
                t = t - 10 * h;               // tens
                if (h > 0) sb.Append(words0[h] + "hundred ");
                if (u > 0 || t > 0)
                {
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }
            return sb.Replace(sb[0], char.ToUpper(sb[0]), 0, 1).ToString().TrimEnd();
        }

        public static string GetQuarter(byte month)
        {
            string quarter = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    quarter = "I";
                    break;
                case 4:
                case 5:
                case 6:
                    quarter = "II";
                    break;
                case 7:
                case 8:
                case 9:
                    quarter = "III";
                    break;
                case 10:
                case 11:
                case 12:
                    quarter = "IV";
                    break;
            }
            return quarter;
        }

        public static DateTime GetServerTime()
        {
            SqlCommand sqlCommand = new SqlCommand("GetTime", Connection.GetConnection());
            DateTime retVal = DateTime.MinValue;

            sqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                Connection.Open();
                retVal = Convert.ToDateTime(sqlCommand.ExecuteScalar());
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }
            return retVal;
        }
    }
}
