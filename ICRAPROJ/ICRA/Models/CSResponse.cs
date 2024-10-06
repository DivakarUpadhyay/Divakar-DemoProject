using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICRA.Models
{
	
    public class CsRSection1
    {
        public string section { get; set; }
        public int csrBanner_Id { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string desktop_image { get; set; }
        public string responsive_image { get; set; }
    }

    public class CsRSection2
    {
        public string section { get; set; }
        public int csrBannersec2_Id { get; set; }
        public string title { get; set; }
        public string short_Description { get; set; }
        public string long_Description { get; set; }
        public string image { get; set; }
    }

    public class CsRSection3
    {
        public string section { get; set; }
        public int csrBannersec3_Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object image { get; set; }
    }

    public class CsRSection4
    {

        public string Section { get; set; }
        public int Id { get; set; }
        public string Annual_Report_Category_Name { get; set; }

    }
    public class CsRSection5
    {
        public string Section { get; set; }
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Annual_Report_Year { get; set; }
        public string Title { get; set; }
        public string Report { get; set; }
    }
    public class CsRSection6
    {
        public string Section { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }


    public class CsRSection7
    {
        public string Section { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
    }
    public class CsRSection8
    {
        public string Section { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class CSResponse
    {
        public CsRSection1 csR_Section1 { get; set; }
        public List<CsRSection2> csR_Section2 { get; set; }
        public List<CsRSection3> csR_Section3 { get; set; }
        public List<CsRSection4> csR_Section4 { get; set; }
        public List<CsRSection5> csR_Section5 { get; set; }
        public List<CsRSection6> csR_Section6 { get; set; }
        public List<SelectListItem> ListItemsAnnualReportYear { get; set; }

        public List<CsRSection7> csR_Section7 { get; set; }
        public List<CsRSection8> csR_Section8 { get; set; }

    }



    public class ContactUs_EmailInsertRequest
    {
        public int Category_Id { get; set; }
        public string Name { get; set; }       
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string CompanyName { get; set; }
        public string WriteQuery { get; set; }
		public string WebPageName { get; set; }

	}
    public class ContactUs_EmailInsertResponse
    {
        public string Message { get; set; }
        public int Status { get; set; }

    }
}