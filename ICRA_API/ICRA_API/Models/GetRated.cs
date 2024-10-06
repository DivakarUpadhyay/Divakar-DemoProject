using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA_API.Models
{
	public class GetRated
	{
	}

	public class GetRated_InsertRequest
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string ContactNumber { get; set; }
		public string CompanyName { get; set; }
		public string Message { get; set; }
		public string WebPageName { get; set; }


	}
	public class GetRated_InsertResponse
	{
		public string Message { get; set; }
		public int Status { get; set; }

	}
}