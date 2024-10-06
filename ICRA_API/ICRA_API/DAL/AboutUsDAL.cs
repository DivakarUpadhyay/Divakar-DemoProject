using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
namespace ICRA_API.DAL
{
	public class AboutUsDAL
	{
        SqlCommand sqlcmd;
        public DataSet GetAboutUsDetails(string Section=null)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "Proc_AboutUs";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@Section", SqlDbType.VarChar).Value = Section;
                    sqlad.Fill(ds);
                   
                }
            }
            return ds;

        }
    }
}