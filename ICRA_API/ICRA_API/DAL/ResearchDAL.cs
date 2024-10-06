using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;

namespace ICRA_API.DAL
{
	public class ResearchDAL
    {
        SqlCommand sqlcmd;
        public DataSet GetResearch(ResearchRequest resreq)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_RESEARCH_DATA";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@id", SqlDbType.Int).Value = resreq.id;
                    sqlcmd.Parameters.Add("@Industry_Id", SqlDbType.Int).Value = resreq.Industry_Id;
                    sqlad.Fill(ds);

                }
            }
            return ds;

        }
        public DataSet FilterResearch(FilterRequest resreq)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_RESEARCH_FILTER";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@Industry_Id", SqlDbType.Int).Value = resreq.Industry_Id;
                    sqlcmd.Parameters.Add("@Research_Category_Id", SqlDbType.Int).Value = resreq.Research_Category_Id;
                    sqlcmd.Parameters.Add("@Research_Sector_id", SqlDbType.Int).Value = resreq.Research_Sector_id;
                    sqlcmd.Parameters.Add("@Type_Id", SqlDbType.Int).Value = resreq.Type_Id;
                    sqlcmd.Parameters.Add("@FROM_DATE", SqlDbType.NVarChar).Value = resreq.FROM_DATE;
                    sqlcmd.Parameters.Add("@To_DATE", SqlDbType.NVarChar).Value = resreq.To_DATE;
                    sqlcmd.Parameters.Add("@SearcText", SqlDbType.NVarChar).Value = resreq.SearcText;

                    sqlad.Fill(ds);
                }
            }
            return ds;

        }
        public DataSet GetResearchDetails(ResearchDetailsRequest resreq)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "GET_RESEARCH_DETAILS_DATA";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@Report_Id", SqlDbType.Int).Value = resreq.Report_Id;
                    sqlcmd.Parameters.Add("@Industry_Id", SqlDbType.Int).Value = resreq.Industry_Id;

                    sqlad.Fill(ds);
                }
            }
            return ds;

        }

        public DataSet GetResearchSectorDrop(ResearchSectorDropRequest resreq)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_CASCADING_DROP_CATEORY_SECTOR";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@Category_Id", SqlDbType.Int).Value = resreq.Category_Id;
                    sqlcmd.Parameters.Add("@Industry_Id", SqlDbType.Int).Value = resreq.Industry_Id;
                    sqlad.Fill(ds);

                }
            }
            return ds;

        }
    }
}