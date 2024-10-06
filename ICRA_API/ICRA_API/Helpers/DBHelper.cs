using System.Data.SqlClient;

namespace ICRA_API.DAL
{
    //Created by Gyan on 12-May-2020
    public static class DBHelper
    {
        static public SqlConnection CreateConnectionForSql()
        {
            string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["ICRAConnection"];
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();//, userCredentials); //, userCredentials
            return conn;
        }

        static public string GetSqlConnectionString()
        {
            string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["ICRAConnection"];
           
            return ConnectionString;
        }
    }
}
