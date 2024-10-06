using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ICRA_API.DAL;
using ICRA_API.Models;

namespace ICRA_API.BLL
{
	public class CSRBLL
	{
        CSRDAL crd = new CSRDAL();
        Common cmn = new Common();
        public CSR GetCSRDetails()
        {
            CSR tDetails = new CSR();
            CSR_Section1 as1 = new CSR_Section1();          
            try
            {
                DataSet ds = crd.GetCSRDetails();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        as1.Section = Convert.ToString(ds.Tables[0].Rows[0]["Section"]);
                        as1.CSRBanner_Id = Convert.ToInt32(ds.Tables[0].Rows[0]["CSRBanner_Id"]);
                        as1.Title1 = Convert.ToString(ds.Tables[0].Rows[0]["Title1"]);
                        as1.Title2 = Convert.ToString(ds.Tables[0].Rows[0]["Title2"]);
                        as1.desktop_image = Convert.ToString(ds.Tables[0].Rows[0]["desktop_image"]);
                        as1.responsive_image = Convert.ToString(ds.Tables[0].Rows[0]["responsive_image"]);
                        tDetails.CSR_Section1 = as1;
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        tDetails.CSR_Section2 = cmn.ConvertToList<CSR_Section2>(ds.Tables[1]);
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        tDetails.CSR_Section3 = cmn.ConvertToList<CSR_Section3>(ds.Tables[2]);
                    }

                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        tDetails.CSR_Section4 = cmn.ConvertToList<CSR_Section4>(ds.Tables[3]);
                    }

                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        tDetails.CSR_Section5 = cmn.ConvertToList<CSR_Section5>(ds.Tables[4]);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        tDetails.CSR_Section6 = cmn.ConvertToList<CSR_Section6>(ds.Tables[5]);
                    }

                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        tDetails.CSR_Section7 = cmn.ConvertToList<CSR_Section7>(ds.Tables[6]);
                    }
                    if (ds.Tables[7].Rows.Count > 0)
                    {
                        tDetails.CSR_Section8 = cmn.ConvertToList<CSR_Section8>(ds.Tables[7]);
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