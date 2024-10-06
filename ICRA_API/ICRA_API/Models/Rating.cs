using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class Rating
	{
		public Rating_Section1 Rating_Section1 { get; set; }
		public List<Rating_Section2> Rating_Section2 { get; set; }
		public List<Rating_Section3> Rating_Section3 { get; set; }
		public List<Rating_Section4> Rating_Section4 { get; set; }
		public List<Rating_Section5> Rating_Section5 { get; set; }
		public List<Rating_Section6> Rating_Section6 { get; set; }
		public List<Rating_Section7> Rating_Section7 { get; set; }
		public List<Rating_Section8> Rating_Section8 { get; set; }
	}
	public class Rating_Section1
	{
		public string Section { get; set; }
		public int RatingBanner_Id { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string desktop_image { get; set; }
		public string responsive_image { get; set; }
		public string Description { get; set; }
	}
	public class Rating_Section2
	{
		public string Section { get; set; }
		public int Rating_Category_Id { get; set; }
		public string Rating_Category_Name { get; set; }
		public string Icon { get; set; }
		public string Icon_hover { get; set; }
	}

	public class Rating_Section3
	{
		public string Section { get; set; }
		public int Rating_Id { get; set; }
		public int Rating_Category_Id { get; set; }
		public string Date { get; set; }		
		public int Company_Id { get; set; }
		public string EntityName { get; set; }
		public string Sector { get; set; }
		public string Instrument { get; set; }
		public string Ratings { get; set; }
		public string Downloads { get; set; }
	}
	public class Rating_Section4
	{
		public string Section { get; set; }
		public int Company_Id { get; set; }
		public string Company_Name { get; set; }

	}
	public class Rating_Section5
	{
		public string Section { get; set; }
		public int Rating_Id { get; set; }
		public int Rating_Category_Id { get; set; }
		public string Date { get; set; }
		public string Date_EntitySpecific { get; set; }
		
		public int Company_Id { get; set; }
		public string EntityName { get; set; }
		public string CompanyWithRationalTitle { get; set; }
		public string Instrument { get; set; }
		public string Ratings { get; set; }
		public string Downloads { get; set; }
	}


	public class Rating_Section6
	{
		public string Section { get; set; }
		public int Company_Id { get; set; }
		public int CPR_Report_Id { get; set; }
		public string CPR_Report_Name { get; set; }
		public string Company_Name { get; set; }		
		public string Report_Date { get; set; }
		public string Report_File_Name { get; set; }

	}
	public class Rating_Section7
	{
		public string Section { get; set; }
		public int Rational_Id { get; set; }
		public int Company_Id { get; set; }
		public string Rational_Report_Name { get; set; }
		public string Rational_Date { get; set; }
		public string Rational_Title { get; set; }
	}

	public class Rating_Section8
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