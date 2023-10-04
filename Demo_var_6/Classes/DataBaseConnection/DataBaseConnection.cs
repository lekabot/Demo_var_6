using System.Data.SqlClient;
using System.Data;

namespace Demo_var_6.Classes.DataBaseConnection
{
    internal class DataBaseConnection
    {
        public static string connectionString = @"Data Source=DESKTOP-N79SNU4;Database=Trade;Integrated Security=True";

        public SqlConnection sqlConnection = new SqlConnection(connectionString);
        
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public void GetPlacesFromHalls(string quaery, DataTable result)
        {
            using (SqlCommand cmd = new SqlCommand(quaery, sqlConnection))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
            }
        }
    }
}
