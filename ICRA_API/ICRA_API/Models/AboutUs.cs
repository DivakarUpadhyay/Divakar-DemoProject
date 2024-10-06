using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class AboutUs
	{
		public AboutUs_Section1 AboutUs_Section1 { get; set; }
		public List<AboutUs_Section2> AboutUs_Section2 { get; set; }
		public List<AboutUs_Section3> AboutUs_Section3 { get; set; }
		public List<AboutUs_Section4> AboutUs_Section4 { get; set; }
		public List<AboutUs_Section5> AboutUs_Section5 { get; set; }
	}

	public class AboutUs_Section1
	{
		public string Section { get; set; }
		public int AboutusBanner_Id { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string desktop_image { get; set; }
		public string responsive_image { get; set; }

	}

	public class AboutUs_Section2
	{
		public string Section { get; set; }
		public int AboutusId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
	}
	public class AboutUs_Section3
	{
		public string Section { get; set; }
		public int AboutusTimelineId { get; set; }
		public int Year { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}

	public class AboutUs_Section4
	{
		public string Section { get; set; }
		public int LeaderShipId { get; set; }
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string Name { get; set; }
		public string Designation { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }

	}
	public class AboutUs_Section5
	{
		public string Section { get; set; }
		public int AboutusGroupId { get; set; }
		public string Group_Name { get; set; }
		public string Logo { get; set; }
		public string Background_Image { get; set; }
		public string Description { get; set; }
		public string URL { get; set; }

	}
	public class SectionType
	{
		public string Section { get; set; }
	}
}