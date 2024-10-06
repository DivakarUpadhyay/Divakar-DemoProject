using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICRA.Models
{

    public class ResearchSection1
    {
        public string section { get; set; }
        public int ResearchBanner_Id { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string desktop_image { get; set; }
        public string responsive_image { get; set; }
        public string Description { get; set; }
    }

    public class ResearchSection2
    {
        public string section { get; set; }
        public int industry_Id { get; set; }
        public string industry_Name { get; set; }
    }

    public class ResearchSection3
    {
        public string section { get; set; }
        public int industry_Id { get; set; }
        public int research_Sector_Id { get; set; }
        public string sector_Name { get; set; }
        public string image { get; set; }
    }
    public class ResearchSection4
    {
        public string Section { get; set; }
		public int Research_Category_Id { get; set; }
		public string Research_Category_Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }

    }
    public class ResearchSection5
    {
        public string Section { get; set; }
        public int Type_Id { get; set; }
        public string Type { get; set; }

    }
    public class ResearchSection6
    {
        public string Section { get; set; }

        public int Report_Id { get; set; }
        public int Industry_Id { get; set; }
        
        public int Research_Sector_id { get; set; }

        public int Analyst_Id { get; set; }

        public string Report_Title { get; set; }

        public string Report_Date { get; set; }

        public string Summary_Report_Name { get; set; }

        public string Full_Report_Name { get; set; }

        public Boolean Is_Highlighted { get; set; }

        public string Highlighted_Image { get; set; }

        public Boolean Is_Special_Comments { get; set; }

        public Boolean IsActive { get; set; }

        public string QuartelryCategory { get; set; }

        public Boolean IsTrending { get; set; }
        public Boolean IsPremium { get; set; }
    }
    public class ResearchSection7
    {
        public string Section { get; set; }

        public int Report_Id { get; set; }
        public int Industry_Id { get; set; }
        public int Research_Sector_id { get; set; }

        public int Analyst_Id { get; set; }

        public string Report_Title { get; set; }

        public string Report_Date { get; set; }

        public string Summary_Report_Name { get; set; }

        public string Full_Report_Name { get; set; }

        public Boolean Is_Highlighted { get; set; }

        public string Highlighted_Image { get; set; }

        public Boolean Is_Special_Comments { get; set; }

        public Boolean IsActive { get; set; }

        public string QuartelryCategory { get; set; }

        public Boolean IsTrending { get; set; }
        public Boolean IsPremium { get; set; }
    }

    public class ResearchSection8
    {
        public string Section { get; set; }
        public int Research_Category_Id { get; set; }
        public string Research_Category_Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }

    }

    public class ResearchSection9
    {
        public string Section { get; set; }

        public int Report_Id { get; set; }
        public int Industry_Id { get; set; }
        public int Research_Sector_id { get; set; }

        public int Analyst_Id { get; set; }

        public string Report_Title { get; set; }

        public string Report_Date { get; set; }

        public string Summary_Report_Name { get; set; }

        public string Full_Report_Name { get; set; }

        public Boolean Is_Highlighted { get; set; }

        public string Highlighted_Image { get; set; }

        public Boolean Is_Special_Comments { get; set; }

        public Boolean IsActive { get; set; }

        public string QuartelryCategory { get; set; }

        public Boolean IsTrending { get; set; }
        public Boolean IsPremium { get; set; }
    }
    public class ResearchSection10
    {
        public string Section { get; set; }

        public int Report_Id { get; set; }
        public int Industry_Id { get; set; }
        public int Research_Sector_id { get; set; }

        public int Analyst_Id { get; set; }

        public string Report_Title { get; set; }

        public string Report_Date { get; set; }

        public string Summary_Report_Name { get; set; }

        public string Full_Report_Name { get; set; }

        public Boolean Is_Highlighted { get; set; }

        public string Highlighted_Image { get; set; }

        public Boolean Is_Special_Comments { get; set; }

        public Boolean IsActive { get; set; }

        public string QuartelryCategory { get; set; }

        public Boolean IsTrending { get; set; }
        public Boolean IsPremium { get; set; }
    }


    public class ResearchSection11
    {
        public string Section { get; set; }

        public int Report_Id { get; set; }
        public int Industry_Id { get; set; }
        public int Research_Sector_id { get; set; }

        public int Analyst_Id { get; set; }

        public string Report_Title { get; set; }

        public string Report_Date { get; set; }

        public string Summary_Report_Name { get; set; }

        public string Full_Report_Name { get; set; }

        public Boolean Is_Highlighted { get; set; }

        public string Highlighted_Image { get; set; }

        public Boolean Is_Special_Comments { get; set; }

        public Boolean IsActive { get; set; }

        public string QuartelryCategory { get; set; }

        public Boolean IsTrending { get; set; }
        public Boolean IsPremium { get; set; }
    }
    public class ResearchResponse
    {
        public ResearchSection1 research_Section1 { get; set; }
        public ParentPage Page { get; set; }
        public List<ResearchSection2> research_Section2 { get; set; }
        public List<ResearchSection3> research_Section3 { get; set; }
        public List<ResearchSection4> research_Section4 { get; set; }
        public List<ResearchSection5> research_Section5 { get; set; }
        public List<ResearchSection6> research_Section6 { get; set; }
        public List<ResearchSection7> research_Section7 { get; set; }
        public List<ResearchSection8> research_Section8 { get; set; }

        public List<ResearchSection9> research_Section9 { get; set; }
        public List<ResearchSection10> research_Section10 { get; set; }
        public List<ResearchSection11> research_Section11 { get; set; }
        public List<SelectListItem> ListItemsCat { get; set; }
        public List<SelectListItem> ListItemsSector { get; set; }
        public List<SelectListItem> ListItemsReportType { get; set; }
    }
    public class ParentPage
	{
		public string PageName { get; set; }
	}

    public class ResearchRequest
    {
        public int id { get; set; }
        public int Industry_Id { get; set; }

    }

    
    }