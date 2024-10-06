using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;

namespace ICRA_API.DAL
{
	public class CSRDAL
	{
        SqlCommand sqlcmd;
        public DataSet GetCSRDetails()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_CSR";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;                   
                    sqlad.Fill(ds);

                }
            }
            return ds;

        }
    }
}