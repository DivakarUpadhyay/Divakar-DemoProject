using System.Web;
using ICRA_API.DAL;
using System.Data;
using System.Data.SqlClient;
using ICRA_API.Models;
using System;

namespace ICRA_API.BLL
{
	public class ContactUsBLL
	{
        ContactUsDAL contusdal = new ContactUsDAL();
        Common cmn = new Common();
        public ContactUs GetContactUsDetails()
        {
            ContactUs tDetails = new ContactUs();
            ContactUs_Section1 as1 = new ContactUs_Section1();
            try
            {
                DataSet ds = contusdal.GetContactUsDetails();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        as1.Section = Convert.ToString(ds.Tables[0].Rows[0]["Section"]);
                        as1.ContactusBanner_Id = Convert.ToInt32(ds.Tables[0].Rows[0]["ContactusBanner_Id"]);
                        as1.Title1 = Convert.ToString(ds.Tables[0].Rows[0]["Title1"]);
                        as1.Title2 = Convert.ToString(ds.Tables[0].Rows[0]["Title2"]);
                        as1.desktop_image = Convert.ToString(ds.Tables[0].Rows[0]["desktop_image"]);
                        as1.responsive_image = Convert.ToString(ds.Tables[0].Rows[0]["responsive_image"]);
                        tDetails.ContactUs_Section1 = as1;
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        tDetails.ContactUs_Section2 = cmn.ConvertToList<ContactUs_Section2>(ds.Tables[1]);
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        tDetails.ContactUs_Section3 = cmn.ConvertToList<ContactUs_Section3>(ds.Tables[2]);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        tDetails.ContactUs_Section4 = cmn.ConvertToList<ContactUs_Section4>(ds.Tables[3]);
                    }


                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return tDetails;
        }


        public ContactUs_EmailInsertResponse InsertContactUsEmail(ContactUs_EmailInsertRequest cei)
        {
            ContactUs_EmailInsertResponse tDetails = new ContactUs_EmailInsertResponse();
           
            try
            {
                DataSet ds = contusdal.InsertContactUsEmail(cei);
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