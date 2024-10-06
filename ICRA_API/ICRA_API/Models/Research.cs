using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class Research
	{
		public Research_Section1 Research_Section1 { get; set; }
		public List<Research_Section2> Research_Section2 { get; set; }
		public List<Research_Section3> Research_Section3 { get; set; }
		public List<Research_Section4> Research_Section4 { get; set; }
		public List<Research_Section5> Research_Section5 { get; set; }
		public List<Research_Section6> Research_Section6 { get; set; }
		public List<Research_Section7> Research_Section7 { get; set; }
		public List<Research_Section8> Research_Section8 { get; set; }

		public List<Research_Section9> Research_Section9 { get; set; }
		public List<Research_Section10> Research_Section10 { get; set; }

		public List<Research_Section11> Research_Section11 { get; set; }
	}
	public class Research_Section1
	{
		public string Section { get; set; }
		public int ResearchBanner_Id { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string desktop_image { get; set; }
		public string responsive_image { get; set; }

		public string Description { get; set; }
		
	}

	public class Research_Section2
	{
		public string Section { get; set; }
		public int Industry_Id { get; set; }
		public string Industry_Name { get; set; }
		
	}
	public class Research_Section3
	{
		public string Section { get; set; }
		public int Industry_Id { get; set; }
		public int Research_Sector_Id { get; set; }
		public string Sector_Name { get; set; }
		public string Image { get; set; }
	}

	public class Research_Section4
	{
		public string Section { get; set; }
		public int Research_Category_Id { get; set; }		
		public string Research_Category_Name { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }
		
	}
	public class Research_Section5
	{
		public string Section { get; set; }
		public int Type_Id { get; set; }
		public string Type { get; set; }
		
	}


	public class Research_Section6
	{
		public string Section { get; set; }

		public int Report_Id { get; set; }
		public int Industry_id { get; set; }
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
	public class Research_Section7
	{
		public string Section { get; set; }

		public int Report_Id { get; set; }
		public int Industry_id { get; set; }
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

	public class Research_Section8
	{
		public string Section { get; set; }
		public int Research_Category_Id { get; set; }
		public string Research_Category_Name { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }

	}

	public class Research_Section9
	{
		public string Section { get; set; }

		public int Report_Id { get; set; }
		public int Industry_id { get; set; }
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

	public class Research_Section10
	{
		public string Section { get; set; }

		public int Report_Id { get; set; }
		public int Industry_id { get; set; }
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

	public class Research_Section11
	{
		public string Section { get; set; }

		public int Report_Id { get; set; }
		public int Industry_id { get; set; }
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
	public class ResearchRequest
	{
		public int id { get; set; }
		public int Industry_Id { get; set; }

	}
	public class ResearchSectorDropRequest
	{
		public int Industry_Id { get; set; }
		public int Category_Id { get; set; }

	}



}