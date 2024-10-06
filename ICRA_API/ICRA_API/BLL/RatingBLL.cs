using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;
using System;
using System.Collections.Generic;


namespace ICRA_API.BLL
{
	public class RatingBLL
    {
        RatingDAL crd = new RatingDAL();
        Rating_Section1 as1 = new Rating_Section1();
        Common cmn = new Common();
        Rating tDetails = new Rating();
        public Rating GetRating(RatingRequest resreq)
        {
            try
            {
                DataSet ds = crd.GetRating(resreq);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        as1.Section = Convert.ToString(ds.Tables[0].Rows[0]["Section"]);
                        as1.RatingBanner_Id = Convert.ToInt32(ds.Tables[0].Rows[0]["RatingBanner_Id"]);
                        as1.Title1 = Convert.ToString(ds.Tables[0].Rows[0]["Title1"]);
                        as1.Title2 = Convert.ToString(ds.Tables[0].Rows[0]["Title2"]);
                        as1.desktop_image = Convert.ToString(ds.Tables[0].Rows[0]["desktop_image"]);
                        as1.responsive_image = Convert.ToString(ds.Tables[0].Rows[0]["responsive_image"]);
						as1.Description = Convert.ToString(ds.Tables[0].Rows[0]["Description"]);
						tDetails.Rating_Section1 = as1;
                    }
					if (ds.Tables[1].Rows.Count > 0)
					{
						tDetails.Rating_Section2 = cmn.ConvertToList<Rating_Section2>(ds.Tables[1]);
					}

					if (ds.Tables[2].Rows.Count > 0)
					{
						tDetails.Rating_Section3 = cmn.ConvertToList<Rating_Section3>(ds.Tables[2]);
					}

					if (ds.Tables[3].Rows.Count > 0)
					{
						tDetails.Rating_Section4 = cmn.ConvertToList<Rating_Section4>(ds.Tables[3]);
					}
					if (ds.Tables[4].Rows.Count > 0)
					{
						tDetails.Rating_Section5 = cmn.ConvertToList<Rating_Section5>(ds.Tables[4]);
					}

					if (ds.Tables[5].Rows.Count > 0)
					{
						tDetails.Rating_Section6 = cmn.ConvertToList<Rating_Section6>(ds.Tables[5]);
					}
					if (ds.Tables[6].Rows.Count > 0)
					{
						tDetails.Rating_Section7 = cmn.ConvertToList<Rating_Section7>(ds.Tables[6]);
					}


					if (ds.Tables[7].Rows.Count > 0)
					{
						tDetails.Rating_Section8 = cmn.ConvertToList<Rating_Section8>(ds.Tables[7]);
					}

					//if (ds.Tables[8].Rows.Count > 0)
					//{
					//    tDetails.Research_Section9 = cmn.ConvertToList<Research_Section9>(ds.Tables[8]);
					//}

					//if (ds.Tables[9].Rows.Count > 0)
					//{
					//    tDetails.Research_Section10 = cmn.ConvertToList<Research_Section10>(ds.Tables[9]);
					//}

					//if (ds.Tables[10].Rows.Count > 0)
					//{
					//    tDetails.Research_Section11 = cmn.ConvertToList<Research_Section11>(ds.Tables[10]);
					//}
				}
            }
            catch (Exception e)
            {
                throw (e);
            }

            return tDetails;
        }

		public Rating GetResearch1(RatingRequest resreq)
		{
			try
			{
				List<Rating> ds = crd.GetRating1(resreq);	
				
			}
			catch (Exception e)
			{
				throw (e);
			}

			return tDetails;
		}

	}
}