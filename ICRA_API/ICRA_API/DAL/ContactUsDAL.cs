using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;

namespace ICRA_API.DAL
{
	public class ContactUsDAL
	{
        SqlCommand sqlcmd;
        public DataSet GetContactUsDetails()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "Proc_ContactUs";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlad.Fill(ds);

                }
            }
            return ds;

        }


        public DataSet InsertContactUsEmail(ContactUs_EmailInsertRequest cei)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_INSERT_CONTACT_US_EMAIL";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@Category_Id", SqlDbType.Int).Value = cei.Category_Id;
                    sqlcmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = cei.Name;
                    sqlcmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = cei.Email;
                    sqlcmd.Parameters.Add("@ContactNumber", SqlDbType.VarChar).Value = cei.ContactNumber;

                    sqlcmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = cei.CompanyName;
                    sqlcmd.Parameters.Add("@WriteQuery", SqlDbType.VarChar).Value = cei.WriteQuery;
                    sqlcmd.Parameters.Add("@WebPageName", SqlDbType.VarChar).Value = cei.WebPageName;

                    sqlad.Fill(ds);
                }
            }
            return ds;

        }
    }
}