using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;
using System;
using System.Collections.Generic;

namespace ICRA_API.BLL
{
	public class ResearchBLL
    {
        ResearchDAL crd = new ResearchDAL();
        Common cmn = new Common();
        Research tDetails = new Research();
        Research_Section1 as1 = new Research_Section1();
        ResearchFilter tDetailsFilter = new ResearchFilter();
        ResearchSectorDropDown tDetailsDrop = new ResearchSectorDropDown();
        ResearchDetails ResearchDetails = new ResearchDetails();
        public Research GetResearch(ResearchRequest resreq)
        {
            try
            {
                DataSet ds = crd.GetResearch(resreq);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        as1.Section = Convert.ToString(ds.Tables[0].Rows[0]["Section"]);
                        as1.ResearchBanner_Id = Convert.ToInt32(ds.Tables[0].Rows[0]["ResearchBanner_Id"]);
                        as1.Title1 = Convert.ToString(ds.Tables[0].Rows[0]["Title1"]);
                        as1.Title2 = Convert.ToString(ds.Tables[0].Rows[0]["Title2"]);
                        as1.desktop_image = Convert.ToString(ds.Tables[0].Rows[0]["desktop_image"]);
                        as1.responsive_image = Convert.ToString(ds.Tables[0].Rows[0]["responsive_image"]);
                        as1.Description = Convert.ToString(ds.Tables[0].Rows[0]["Description"]);
                        tDetails.Research_Section1 = as1;
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        tDetails.Research_Section2 = cmn.ConvertToList<Research_Section2>(ds.Tables[1]);
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        tDetails.Research_Section3 = cmn.ConvertToList<Research_Section3>(ds.Tables[2]);
                    }

                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        tDetails.Research_Section4 = cmn.ConvertToList<Research_Section4>(ds.Tables[3]);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        tDetails.Research_Section5 = cmn.ConvertToList<Research_Section5>(ds.Tables[4]);
                    }

                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        tDetails.Research_Section6 = cmn.ConvertToList<Research_Section6>(ds.Tables[5]);
                    }
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        tDetails.Research_Section7 = cmn.ConvertToList<Research_Section7>(ds.Tables[6]);
                    }

                    if (ds.Tables[7].Rows.Count > 0)
                    {
                        tDetails.Research_Section8 = cmn.ConvertToList<Research_Section8>(ds.Tables[7]);
                    }

                    if (ds.Tables[8].Rows.Count > 0)
                    {
                        tDetails.Research_Section9 = cmn.ConvertToList<Research_Section9>(ds.Tables[8]);
                    }

                    if (ds.Tables[9].Rows.Count > 0)
                    {
                        tDetails.Research_Section10 = cmn.ConvertToList<Research_Section10>(ds.Tables[9]);
                    }

                    if (ds.Tables[10].Rows.Count > 0)
                    {
                        tDetails.Research_Section11 = cmn.ConvertToList<Research_Section11>(ds.Tables[10]);
                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return tDetails;
        }


        public ResearchFilter FilterResearch(FilterRequest resreq)
        {
            try
            {

                DataSet ds = crd.FilterResearch(resreq);
                if (ds.Tables.Count > 0)
                {                    
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        tDetailsFilter.FilterResponse = cmn.ConvertToList<FilterResponse>(ds.Tables[0]);
					}
					else
					{
                        tDetailsFilter.FilterResponse = new List<FilterResponse>();

                    }                  
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return tDetailsFilter;
        }


        public ResearchDetails GetResearchDetails(ResearchDetailsRequest resreq)
        {
            try
            {

                DataSet ds = crd.GetResearchDetails(resreq);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ResearchDetails.ResearchDeatails_Section1 = cmn.ConvertToList<ResearchDeatails_Section1>(ds.Tables[0]);
                    }
                    else
                    {
                        ResearchDetails.ResearchDeatails_Section1 = new List<ResearchDeatails_Section1>();

                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        ResearchDetails.ResearchDeatails_Section2 = cmn.ConvertToList<ResearchDeatails_Section2>(ds.Tables[1]);
                    }
                    else
                    {
                        ResearchDetails.ResearchDeatails_Section2 = new List<ResearchDeatails_Section2>();

                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        ResearchDetails.ResearchDeatails_Section3 = cmn.ConvertToList<ResearchDeatails_Section3>(ds.Tables[2]);
                    }
                    else
                    {
                        ResearchDetails.ResearchDeatails_Section3 = new List<ResearchDeatails_Section3>();

                    }

                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        ResearchDetails.ResearchDeatails_Section4 = cmn.ConvertToList<ResearchDeatails_Section4>(ds.Tables[3]);
                    }
                    else
                    {
                        ResearchDetails.ResearchDeatails_Section4 = new List<ResearchDeatails_Section4>();

                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return ResearchDetails;
        }



        public ResearchSectorDropDown GetResearchSectorDrop(ResearchSectorDropRequest resreq)
        {
            try
            {

                DataSet ds = crd.GetResearchSectorDrop(resreq);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        tDetailsDrop.SectorDropResponse = cmn.ConvertToList<SectorDropResponse>(ds.Tables[0]);
                    }
                    else
                    {
                        tDetailsDrop.SectorDropResponse = new List<SectorDropResponse>();

                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return tDetailsDrop;
        }

    }
}