using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class ResearchDetails
	{
		public List<ResearchDeatails_Section1> ResearchDeatails_Section1 { get; set; }
		public List<ResearchDeatails_Section2> ResearchDeatails_Section2 { get; set; }
		public List<ResearchDeatails_Section3> ResearchDeatails_Section3 { get; set; }
		public List<ResearchDeatails_Section4> ResearchDeatails_Section4 { get; set; }
	}
	public class ResearchDeatails_Section1
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
	public class ResearchDeatails_Section2
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
	public class ResearchDeatails_Section3
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

		public string ResearchViewReport { get; set; }
	}
	public class ResearchDeatails_Section4
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
	public class ResearchDetailsRequest
	{
		public int Report_Id { get; set; }
		public int Industry_Id { get; set; }

	}

}