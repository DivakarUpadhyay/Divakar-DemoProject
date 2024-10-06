using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;
using Dapper;
using System.Collections.Generic;
using System;

namespace ICRA_API.DAL
{
	public class RatingDAL
	{
        SqlCommand sqlcmd;
       string conn = DBHelper.GetSqlConnectionString();
        public DataSet GetRating(RatingRequest resreq)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.CreateConnectionForSql())
            {
                using (sqlcmd = new SqlCommand())
                {
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
                    sqlcmd.CommandText = "PROC_RATING_DATA";
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Connection = conn;
                    sqlcmd.Parameters.Add("@id", SqlDbType.Int).Value = resreq.id;
                    sqlcmd.Parameters.Add("@Company_Id", SqlDbType.Int).Value = resreq.Company_Id;
                    sqlcmd.Parameters.Add("@Rating_Category_Id", SqlDbType.NVarChar).Value= string.IsNullOrEmpty(resreq.Rating_Category_Id)?"":resreq.Rating_Category_Id;
                    sqlad.Fill(ds);

                }
            }
            return ds;

        }

        public List<Rating> GetRating1(RatingRequest resreq)
        {

            string sql = "PROC_RATING_DATA";
            List<Rating> Ratingdata;
            using (IDbConnection db = new SqlConnection(conn))
            {
              
                using (var results = db.QueryMultiple(sql, new { id = resreq.id, Company_Id=resreq.Company_Id, Rating_Category_Id=resreq.Rating_Category_Id}, commandType: CommandType.StoredProcedure))
                {
                    Ratingdata = results.Read<Rating>().AsList<Rating>();

                   
                }
            }
            return Ratingdata;
        }

        
    
}
}