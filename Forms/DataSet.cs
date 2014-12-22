using System.Data.SqlClient;
using System.Data;
using Database;
namespace HRMplus.Forms
{
    public partial class DataSet {
        public int GetList()
        {
            SqlCommand sqlCommand = new SqlCommand("Title_GetItems", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            Connection.Open();
            sqlDataAdapter.Fill(tableItem);

            sqlCommand = new SqlCommand("Title_GetLanguageValues", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            Connection.Open();
            sqlDataAdapter.Fill(tableLanguage);

            if (!Relations.Contains("Item_Language"))
            {
                Relations.Add("Item_Language", new DataColumn[] { tableItem.IDColumn }, new DataColumn[] { tableLanguage.ItemIDColumn });
            }
            Connection.Close();

            return tableItem.Count;
        }
    }
}
