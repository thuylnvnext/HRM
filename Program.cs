using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Database;
using System.IO;
using Common;
using Microsoft.Win32;
using DevExpress.XtraEditors;

namespace HRMplus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///         
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Constant.language = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\Language", "Language", null);
            if (Constant.language == null) Constant.language = "Tiếng Việt";
            Constant.skin = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\Skin", "Skin", null);

            //InstallationSQLEXPR _ins = new InstallationSQLEXPR("HRM", "(local)", "SQLEXPRESS", "HRMSHG", "12345678", "HRMSHG_Restore.bak");
            //if (_ins.IsDone == false) _ins.ShowDialog();
            //if (_ins.IsRestart == true)
            //{
            //    Application.Exit();
            //    return;
            //}

            Connection.Initialize();
            Connection.GetConnection();
            if (!Connection.Open())
            {
                Forms.ConnectDatabase connectDatabase = new Forms.ConnectDatabase();
                connectDatabase.ShowDialog();
                if (connectDatabase.DialogResult == DialogResult.Cancel) return;
            }
            else
                Connection.Close();

            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\HRMplus\AutoUpdate", "AutoUpdate", null) != "N")
            {
                AutoUpdateTable autoUpdate = new AutoUpdateTable();
                int n, r = 0;
                DateTime writeTime, updatedWriteTime;
                string[,] updatedFiles;
                autoUpdate.GetContent();
                updatedFiles = new string[2, autoUpdate.Count];
                try
                {
                    foreach (AutoUpdateRow aur in autoUpdate)
                    {
                        n = aur.File.LastIndexOf('\\');
                        writeTime = File.GetLastWriteTime(Application.StartupPath + aur.File.Substring(n, aur.File.Length - n));
                        updatedWriteTime = File.GetLastWriteTime(aur.File);
                        if (writeTime < updatedWriteTime)
                        {
                            updatedFiles[0, r] = aur.File;
                            updatedFiles[1, r++] = Application.StartupPath + aur.File.Substring(n, aur.File.Length - n);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                if (r > 0)
                {
                    DialogResult retVal = XtraMessageBox.Show(TitleTable.GetValue("UPDATE_VERSION", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.YesNo);
                    if (retVal == DialogResult.Yes)
                    {
                        for (int i = 0; i < r; i++)
                        {
                            File.Copy(updatedFiles[0, i], updatedFiles[1, i] + ".bak", true);
                            File.Replace(updatedFiles[1, i] + ".bak", updatedFiles[1, i], null);
                        }
                        try
                        {
                            string[] files = Directory.GetFiles(Application.StartupPath, "*.tmp");
                            foreach (string file in files)
                            {
                                File.Delete(file);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
            Forms.LogIn logIn = new Forms.LogIn();
            Application.Run(logIn);
            if (logIn.DialogResult == DialogResult.OK) Application.Run(new Forms.Main());
        }
    }
}