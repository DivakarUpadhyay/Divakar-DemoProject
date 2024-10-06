using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ICRA_API.DAL;
using ICRA_API.Models;

namespace ICRA_API.BLL
{
	public class AboutUsBLL
	{
        AboutUsDAL crd = new AboutUsDAL();
        Common cmn = new Common();
        public AboutUs GetAboutUsDetails(string Section = null)
        {
            AboutUs tDetails = new AboutUs();
            AboutUs_Section1 as1 = new AboutUs_Section1();
            AboutUs_Section2 as2 = new AboutUs_Section2();

            try
            {
                DataSet ds = crd.GetAboutUsDetails(Section);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        as1.Section =Convert.ToString(ds.Tables[0].Rows[0]["Section"]);
                        as1.AboutusBanner_Id = Convert.ToInt32(ds.Tables[0].Rows[0]["AboutusBanner_Id"]);
                        as1.Title1 = Convert.ToString(ds.Tables[0].Rows[0]["Title1"]);
                        as1.Title2 = Convert.ToString(ds.Tables[0].Rows[0]["Title2"]);
                        as1.desktop_image = Convert.ToString(ds.Tables[0].Rows[0]["desktop_image"]);
                        as1.responsive_image = Convert.ToString(ds.Tables[0].Rows[0]["responsive_image"]);
                        tDetails.AboutUs_Section1 = as1;
                    }
                    if (ds.Tables[1].Rows.Count>0)
					{
                        tDetails.AboutUs_Section2 = cmn.ConvertToList<AboutUs_Section2>(ds.Tables[1]);
					}
					
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        tDetails.AboutUs_Section3 = cmn.ConvertToList<AboutUs_Section3>(ds.Tables[2]);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        tDetails.AboutUs_Section4 = cmn.ConvertToList<AboutUs_Section4>(ds.Tables[3]);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        tDetails.AboutUs_Section5 = cmn.ConvertToList<AboutUs_Section5>(ds.Tables[4]);
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