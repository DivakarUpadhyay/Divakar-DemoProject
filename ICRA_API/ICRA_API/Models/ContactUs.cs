using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class ContactUs
	{
		public ContactUs_Section1 ContactUs_Section1 { get; set; }
		public List<ContactUs_Section2> ContactUs_Section2 { get; set; }
		public List<ContactUs_Section3> ContactUs_Section3 { get; set; }
		public List<ContactUs_Section4> ContactUs_Section4 { get; set; }
	}
	public class ContactUs_Section1
	{
		public string Section { get; set; }
		public int ContactusBanner_Id { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string desktop_image { get; set; }
		public string responsive_image { get; set; }

	}

	public class ContactUs_Section2
	{
		public string Section { get; set; }
		public int Category_Id { get; set; }
		public string Category { get; set; }
		public string Name { get; set; }
		public string Designation { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string BoardlineDirect { get; set; }
		public string Direct { get; set; }
	}
	public class ContactUs_Section3
	{
		public string Section { get; set; }
		public int Category_Id { get; set; }
		public string Category { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

	}

	public class ContactUs_Section4
	{
		public string Section { get; set; }
		public int AboutusGroupId { get; set; }
		public string Group_Name { get; set; }
		public string Logo { get; set; }
		public string Background_Image { get; set; }
		public string Description { get; set; }
		public string URL { get; set; }

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