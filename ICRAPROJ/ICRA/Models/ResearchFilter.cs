using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA.Models
{
	public class ResearchFilter
	{
		public List<FilterResponse> FilterResponse { get; set; }
	}

	//-------------Filter----------------------
	public class ResearchSectorDropRequest
	{
		public int Industry_Id { get; set; }
		public int Category_Id { get; set; }

	}
	public class ResearchSectorDropDown
	{
		public List<SectorDropResponse> SectorDropResponse { get; set; }
	}
	public class SectorDropResponse
	{
		public int Research_Sector_Id { get; set; }
		public string Sector_Name { get; set; }

	}
	public class FilterRequest
	{
		public int Industry_Id { get; set; }
		public int Research_Category_Id { get; set; }
		public int Research_Sector_id { get; set; }
		public int Type_Id { get; set; }
		public string FROM_DATE { get; set; }
		public string To_DATE { get; set; }
		public string SearcText { get; set; }
	}

	public class FilterResponse
	{
		public string Section { get; set; }
		public int Report_Id { get; set; }
		public string Report_Date { get; set; }
		public string Report_Title { get; set; }
		public string Type { get; set; }
		public string Summary_Report_Name { get; set; }
		public Boolean Is_Special_Comments { get; set; }
		public string Full_Report_Name { get; set; }
		public int Industry_Id { get; set; }
	}
}