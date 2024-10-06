using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA.Models
{
	public class RatingResponse
	{
        public RatingSection1 Rating_Section1 { get; set; }
        public ParentPage Page { get; set; }
        public List<RatingSection2> Rating_Section2 { get; set; }
        public List<RatingSection3> Rating_Section3 { get; set; }
        public List<RatingSection4> Rating_Section4 { get; set; }
        public List<RatingSection5> Rating_Section5 { get; set; }
        public List<ResearchSection6> Research_Section6 { get; set; }
        public List<RatingSection6> Rating_Section6{ get; set; }
        public List<RatingSection7> Rating_Section7 { get; set; }
        public List<RatingSection8> Rating_Section8 { get; set; }

    }
   

    public class RatingSection1
    {
        public string section { get; set; }
        public int RatingBanner_Id { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string desktop_image { get; set; }
        public string responsive_image { get; set; }
        public string Description { get; set; }
    }
    public class RatingSection2
    {
        public string Section { get; set; }
        public int Rating_Category_Id { get; set; }
        public string Rating_Category_Name { get; set; }
        public string Icon { get; set; }
        public string Icon_hover { get; set; }
    }
    public class RatingSection3
    {
        public string Section { get; set; }
        public int Rating_Id { get; set; }
        public int Rating_Category_Id { get; set; }
        public string Date { get; set; }
        public string Company_Id { get; set; }
        public string EntityName { get; set; }
        public string Sector { get; set; }
        public string Instrument { get; set; }
        public string Ratings { get; set; }
        public string Downloads { get; set; }
    }

    public class RatingSection4
    {
        public string Section { get; set; }
        public int Company_Id { get; set; }
        public string Company_Name { get; set; }

    }
    public class RatingSection5
    {
        public string Section { get; set; }
        public int Rating_Id { get; set; }
        public int Rating_Category_Id { get; set; }
        public string Date { get; set; }
        public string Date_EntitySpecific { get; set; }
        public string Company_Id { get; set; }
        public string EntityName { get; set; }
        public string CompanyWithRationalTitle { get; set; }
        public string Instrument { get; set; }
        public string Ratings { get; set; }
        public string Downloads { get; set; }
    }
    public class RatingSection6
    {
        public string Section { get; set; }
        public int Company_Id { get; set; }
        public int CPR_Report_Id { get; set; }
        public string CPR_Report_Name { get; set; }
        public string Company_Name { get; set; }
        public string Report_Date { get; set; }
        public string Report_File_Name { get; set; }


    }
    public class RatingSection7
    {
        public string Section { get; set; }
        public int Rational_Id { get; set; }
        public int Company_Id { get; set; }
        public string Rational_Report_Name { get; set; }
        public string Rational_Date { get; set; }
        public string Rational_Title { get; set; }
    }

    public class RatingSection8
    {
        public string Section { get; set; }
        public int Rational_Id { get; set; }
        public int Company_Id { get; set; }
        public string Rational_Report_Name { get; set; }
        public string Rational_Date { get; set; }
        public string Rational_Title { get; set; }
    }
    public class RatingRequest
    {
        public int id { get; set; }
        public int Company_Id { get; set; }
        public string Rating_Category_Id { get; set; }
    }
}