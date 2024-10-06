using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;

namespace ICRA_API.DAL
{
	public class GetRatedDAL
    {
        SqlCommand sqlcmd;
        public DataSet InsertGetRated(GetRated_InsertRequest cei)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_INSERT_GetRated";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = cei.Name;
                    sqlcmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = cei.Email;
                    sqlcmd.Parameters.Add("@ContactNumber", SqlDbType.VarChar).Value = cei.ContactNumber;
                    sqlcmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = cei.CompanyName;
                    sqlcmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = cei.Message;
                    sqlcmd.Parameters.Add("@WebPageName", SqlDbType.VarChar).Value = cei.WebPageName;
                    sqlad.Fill(ds);
                }
            }
            return ds;

        }

    }
}