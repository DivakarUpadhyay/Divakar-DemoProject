using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;
using System;

namespace ICRA_API.BLL
{
	public class GetRatedBLL
    {
        GetRatedDAL contusdal = new GetRatedDAL();
        Common cmn = new Common();
        public GetRated_InsertResponse InsertGetRated(GetRated_InsertRequest cei)
        {
            GetRated_InsertResponse tDetails = new GetRated_InsertResponse();

            try
            {
                DataSet ds = contusdal.InsertGetRated(cei);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        tDetails.Message = ds.Tables[0].Rows[0]["Message"].ToString();
                        tDetails.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return tDetails;
        }

    }
}