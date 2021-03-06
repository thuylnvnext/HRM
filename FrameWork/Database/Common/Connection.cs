using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;

namespace Database
{
    public class Connection
    {
        private static string server, database, authentication, userID, password;
        private static string PATH = @"HKEY_CURRENT_USER\Software\HRMplus\Database";
        private static string connectionString;
        private static SqlConnection sqlConnection;

        public static void Initialize()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.cfg");
            if (files.Length == 0)
            {
                server = (string)Registry.GetValue(PATH, "Server", null);
                if (String.IsNullOrEmpty(server))
                    server = "(local)\\SQLEXPRESS";
                database = (string)Registry.GetValue(PATH, "Database", null);
                if (String.IsNullOrEmpty(database))
                    database = "HRMSHG";
                authentication = (string)Registry.GetValue(PATH, "Authentication", null);
                if (String.IsNullOrEmpty(authentication))
                    authentication = "SQLServer";
                if (authentication != null && authentication == "Windows")
                    connectionString = string.Format("Data Source={0}; Initial Catalog={1}; Integrated Security = True", server, database);
                else
                {
                    userID = (string)Registry.GetValue(PATH, "UserID", null);
                    if (String.IsNullOrEmpty(userID))
                        userID = "sa";
                    password = Security.DecryptData((string)Registry.GetValue(PATH, "Password", null));
                    if (String.IsNullOrEmpty(password))
                        password = "12345678";
                    connectionString = string.Format("Data Source={0}; User ID={1}; Password={2}; Initial Catalog={3}", server, userID, password, database);
                }
            }
            else
            {
                FileStream file = File.Open(files[0], FileMode.Open);
                StreamReader r = new StreamReader(file);
                file.Position = 0;
                string value = r.ReadToEnd();
                string[] values = value.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                server = Security.DecryptData(values[0]);
                database = Security.DecryptData(values[1]);
                if (values.Length == 4)
                {
                    userID = Security.DecryptData(values[2]);
                    password = Security.DecryptData(values[3]);
                    connectionString = string.Format("Data Source={0}; User ID={1}; Password={2}; Initial Catalog={3}", server, userID, password, database);
                }
                else
                    connectionString = string.Format("Data Source={0}; Initial Catalog={1}; Integrated Security = True", server, database);
                file.Close();
            }
        }

        public static bool Open()
        {           
            try
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static ConnectionState State()
        {
            return sqlConnection.State;
        }

        public static void Close()
        {
            if (sqlConnection != null)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlConnection = null;
            }
        }

        public static SqlConnection GetConnection()
        {
            if (sqlConnection == null) sqlConnection = new SqlConnection();
            return sqlConnection;
        }
    }
} 