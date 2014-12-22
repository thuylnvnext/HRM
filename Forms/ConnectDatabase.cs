using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Database;
using Microsoft.SqlServer.Management.Common;
using Common;
using DevExpress.XtraEditors;
using System.IO;

namespace HRMplus.Forms
{
    public partial class ConnectDatabase : XtraForm
    {
        private const string PATH = @"HKEY_CURRENT_USER\Software\HRMplus\Database";
        private bool change = false;

        public ConnectDatabase()
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        public ConnectDatabase(bool change)
        {
            InitializeComponent();
            Utility.SetSkin(this);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Registry.SetValue(PATH, "Server", cboServerName.Text);
            Registry.SetValue(PATH, "Database", cboDatabaseName.Text);
            Registry.SetValue(PATH, "Authentication", rdbWindowsAuthentication.Checked ? "Windows" : "SQLServer");
            Registry.SetValue(PATH, "UserID", txtLogin.Text);
            Registry.SetValue(PATH, "Password", Security.EncryptData(txtPassword.Text));

            Connection.Close();
            Connection.Initialize();
            Connection.GetConnection();

            DialogResult = DialogResult.OK;
            Dispose(true);
        }

        private void ChangeDatabase_Load(object sender, EventArgs e)
        {
            DataTable serverList = SmoApplication.EnumAvailableSqlServers();
            foreach (DataRow server in serverList.Rows)
            {
                cboServerName.Properties.Items.Add(server["Name"].ToString());
            }

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.cfg");
            string authentication = string.Empty, userID = string.Empty, password = string.Empty;
            if (files.Length == 0)
            {
                String ServerName = (string)Registry.GetValue(PATH, "Server", null);
                if (String.IsNullOrEmpty(ServerName))
                    ServerName = "(local)\\SQLEXPRESS";
                cboServerName.Text = ServerName;
                String DatabaseName = (string)Registry.GetValue(PATH, "Database", null);
                if (String.IsNullOrEmpty(DatabaseName))
                    DatabaseName = "HRMSHG";
                cboDatabaseName.Text = DatabaseName;
                authentication = (string)Registry.GetValue(PATH, "Authentication", null);
                if (String.IsNullOrEmpty(authentication))
                    authentication = "SQLServer";
                userID = (string)Registry.GetValue(PATH, "UserID", null);
                if (String.IsNullOrEmpty(userID))
                    userID = "sa";
                password = Security.DecryptData((string)Registry.GetValue(PATH, "Password", null));
                if (String.IsNullOrEmpty(password))
                    password = "12345678";
            }
            else
            {
                FileStream file = File.Open(files[0], FileMode.Open);
                StreamReader r = new StreamReader(file);
                file.Position = 0;
                string value = r.ReadToEnd();
                string[] values = value.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                cboServerName.Text = Security.DecryptData(values[0]);
                cboDatabaseName.Text = Security.DecryptData(values[1]);
                if (values.Length < 4) 
                    authentication = "Windows";
                else
                {
                    userID = Security.DecryptData(values[2]);
                    password = Security.DecryptData(values[3]);
                }
                file.Close();
            }
            if (authentication != null && authentication == "Windows")
            {
                rdbWindowsAuthentication.Checked = true;
                lblLogin.Enabled = false;
                txtLogin.Enabled = false;
                lblPassword.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                rdbSQLServerAuthentication.Checked = true;
                txtLogin.Text = userID;
                txtPassword.Text = password;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose(true);
        }

        private void ChangeDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) btnChange_Click(sender, e);
        }

        private void cboServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            change = true;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }

        private void rdbWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            lblLogin.Enabled = !rdbWindowsAuthentication.Checked;
            txtLogin.Enabled = !rdbWindowsAuthentication.Checked;
            lblPassword.Enabled = !rdbWindowsAuthentication.Checked;
            txtPassword.Enabled = !rdbWindowsAuthentication.Checked;
            change = true;
        }

        private void cboDatabaseName_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (change)
            {
                cboDatabaseName.Properties.Items.Clear();
                cboDatabaseName.Text = string.Empty;
                try
                {
                    Server server;
                    if (rdbWindowsAuthentication.Checked)
                    {
                        SqlConnectionInfo sci = new SqlConnectionInfo(cboDatabaseName.Text);
                        sci.UseIntegratedSecurity = true;
                        server = new Server(new ServerConnection(sci));
                    }
                    else
                    {
                        server = new Server(new ServerConnection(cboServerName.Text, txtLogin.Text, txtPassword.Text));
                    }
                    foreach (Microsoft.SqlServer.Management.Smo.Database database in server.Databases)
                    {
                        cboDatabaseName.Properties.Items.Add(database.Name);
                    }
                    change = false;
                }
                catch
                {
                }
            }
        }

        private void btnExportToFile_Click(object sender, EventArgs e)
        {
            if (sfdExportToFile.ShowDialog() == DialogResult.OK)
            {
                bool error = false;
                FileStream file = null;
                try
                {
                    file = File.Open(sfdExportToFile.FileName, FileMode.Create);
                    StreamWriter w = new StreamWriter(file);
                    w.AutoFlush = true;
                    if (rdbSQLServerAuthentication.Checked)
                        w.Write(string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", Security.EncryptData(cboServerName.Text), Security.EncryptData(cboDatabaseName.Text), Security.EncryptData(txtLogin.Text), Security.EncryptData(txtPassword.Text)));
                    else
                        w.Write(string.Format("{0}\r\n{1}", Security.EncryptData(cboServerName.Text), Security.EncryptData(cboDatabaseName.Text)));
                    file.Position = 0;                    
                }
                catch
                {
                    error = true;                    
                }
                finally
                {
                    file.Close();
                }
                if (!error)
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("EXPORT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("EXPORT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportFromFile_Click(object sender, EventArgs e)
        {
            if (ofdImportFromFile.ShowDialog() == DialogResult.OK)
            {
                bool error = false;
                string value = string.Empty;
                FileStream file = null;
                try
                {
                    file = File.Open(ofdImportFromFile.FileName, FileMode.Open);
                    StreamReader r = new StreamReader(file);
                    file.Position = 0;
                    value = r.ReadToEnd();
                }
                catch
                {
                    error = true;
                }
                finally
                {
                    file.Close();
                }
                if (!error)
                {
                    string[] values = value.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    cboServerName.EditValue = Security.DecryptData(values[0]);
                    cboDatabaseName.EditValue = Security.DecryptData(values[1]);
                    txtLogin.Text = Security.DecryptData(values[2]);
                    txtPassword.Text = Security.DecryptData(values[3]);
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("IMPORT_SUCCESS", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show(LookAndFeel, TitleTable.GetValue("IMPORT_ERROR", Constant.language), TitleTable.GetValue("MESSAGE", Constant.language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}