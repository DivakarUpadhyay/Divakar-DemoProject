using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class CSR
	{
		public CSR_Section1 CSR_Section1 { get; set; }
		public List<CSR_Section2> CSR_Section2 { get; set; }
		public List<CSR_Section3> CSR_Section3 { get; set; }

		public List<CSR_Section4> CSR_Section4 { get; set; }
		public List<CSR_Section5> CSR_Section5 { get; set; }
		public List<CSR_Section6> CSR_Section6 { get; set; }


		public List<CSR_Section7> CSR_Section7 { get; set; }
		public List<CSR_Section8> CSR_Section8 { get; set; }
	}
	public class CSR_Section1
	{
		public string Section { get; set; }
		public int CSRBanner_Id { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string desktop_image { get; set; }
		public string responsive_image { get; set; }

	}
	public class CSR_Section2
	{
		public string Section { get; set; }
		public int CSRBannersec2_Id { get; set; }
		public string Title { get; set; }
		public string Short_Description { get; set; }
		public string Long_Description { get; set; }		
		public string Image { get; set; }
	}
	public class CSR_Section3
	{
		public string Section { get; set; }
		public int CSRBannersec3_Id { get; set; }		
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
	}
	public class CSR_Section4
	{
		public string Section { get; set; }
		public int Id { get; set; }
		public string Annual_Report_Category_Name { get; set; }
		
	}
	public class CSR_Section5
	{
		public string Section { get; set; }
		public int Id { get; set; }
		public int Category_Id { get; set; }
		public string Annual_Report_Year { get; set; }
		public string Title { get; set; }
		public string Report { get; set; }		
	}
	public class CSR_Section6
	{
		public string Section { get; set; }
		public int Id { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }	
	}
	public class CSR_Section7
	{
		public string Section { get; set; }
		public int Id { get; set; }
		public string Title { get; set; }
		public int Count { get; set; }
		public string Image { get; set; }
	}

	public class CSR_Section8
	{
		public string Section { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
	}
}