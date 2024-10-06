using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ICRA.Models;
using System.Web.Configuration;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
namespace ICRA.Controllers
{
	public class ICRAController : Controller
	{
		#region Divakar Upadhyay Date: 8th January 2021 Start 
		string BaseUrl = WebConfigurationManager.AppSettings["ICRABaseURL"];

		//---------------About Us start--------------------------------------
		public ActionResult AboutUs()
		{
			AboutUsResponse abresponse = new AboutUsResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetAboutUsDetails";
			string postData = @"{" + "\n" + @"    ""Section"":""""" + "\n" + @"}";
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, postData, headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			abresponse = JsonConvert.DeserializeObject<AboutUsResponse>(responseValue);
			return View(abresponse);
		}
		public ActionResult AboutbodUs(int LeaderShipId)
		{
			AboutUsResponse abresponse = new AboutUsResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetAboutUsDetails";
			string postData = @"{" + "\n" + @"    ""Section"":""""" + "\n" + @"}";
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, postData, headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			abresponse = JsonConvert.DeserializeObject<AboutUsResponse>(responseValue);
			AboutUsSection4 abtus4 = new AboutUsSection4();
			foreach (var item in abresponse.aboutUs_Section4)
			{
				if (item.LeaderShipId == LeaderShipId)
				{
					abtus4.LeaderShipId = LeaderShipId;
					abtus4.image = item.image;
					abtus4.description = item.description;
					abtus4.name = item.name;
					abtus4.designation = item.designation;
				}
			}

			return View(abtus4);
		}
		//---------------About Us End----------------------------------------
		//---------------CSR start--------------------------------------
		public ActionResult CSR()
		{
			CSResponse abresponse = new CSResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetCSRDetails";
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, null, headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			abresponse = JsonConvert.DeserializeObject<CSResponse>(responseValue);
			List<SelectListItem> items = new List<SelectListItem>();
			if (abresponse.csR_Section5 != null)
			{
				foreach (var catitem in abresponse.csR_Section5.Where(m => m.Category_Id == 1))
				{
					items.Add(new SelectListItem
					{
						Text = catitem.Annual_Report_Year,
						Value = catitem.Id.ToString()

					}); ;
				}
			}

			abresponse.ListItemsAnnualReportYear = items;
			return View(abresponse);
		}
		public ActionResult csrrlcpopup(int Id)
		{
			CSResponse abresponse = new CSResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetCSRDetails";
			//string postData = @"{" + "\n" + @"    ""Section"":""""" + "\n" + @"}";
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, null, headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			abresponse = JsonConvert.DeserializeObject<CSResponse>(responseValue);
			CsRSection2 csr2 = new CsRSection2();
			foreach (var item in abresponse.csR_Section2)
			{
				if (item.csrBannersec2_Id == Id)
				{
					csr2.csrBannersec2_Id = Id;
					csr2.title = item.title;
					csr2.long_Description = item.long_Description;

				}
			}
			return View(csr2);
		}
		//---------------CSR End--------------------------------------
		//---------------Research start--------------------------------------
		public ActionResult Research()
		{
			ResearchRequest resreq = new ResearchRequest();
			resreq.id = 5;
			resreq.Industry_Id = 0;
			ResearchResponse ab = new ResearchResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetResearch";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<ResearchResponse>(responseValue);
			ParentPage parentp = new ParentPage();
			parentp.PageName = "Research";
			ab.Page = parentp;
			return View(ab);

		}
		[Route("ResearchSector")]
		public ActionResult ResearchCorporateSector(int? Industry_Id)
		{
			ResearchRequest resreq = new ResearchRequest();

			if (Industry_Id == 4)
			{
				resreq.id = 6;
				resreq.Industry_Id = Convert.ToInt32(Industry_Id);
			}
			if (Industry_Id == 1)
			{
				resreq.id = 7;
				resreq.Industry_Id = Convert.ToInt32(Industry_Id);
			}
			if (Industry_Id == 2)
			{
				resreq.id = 8;
				resreq.Industry_Id = Convert.ToInt32(Industry_Id);
			}
			if (Industry_Id == 3)
			{
				resreq.id = 9;
				resreq.Industry_Id = Convert.ToInt32(Industry_Id);

			}
			ResearchResponse ab = new ResearchResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetResearch";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<ResearchResponse>(responseValue);

			//-----------Dropdownlist------
			List<SelectListItem> items = new List<SelectListItem>();
			if (ab.research_Section4 != null)
			{
				foreach (var catitem in ab.research_Section4)
				{
					items.Add(new SelectListItem
					{
						Text = catitem.Research_Category_Name,
						Value = catitem.Research_Category_Id.ToString()

					}); ;
				}

			}
			ab.ListItemsCat = items;
			List<SelectListItem> itemssector = new List<SelectListItem>();
			if (ab.research_Section3 != null)
			{
				foreach (var catitem in ab.research_Section3)
				{
					itemssector.Add(new SelectListItem
					{
						Text = catitem.sector_Name,
						Value = catitem.research_Sector_Id.ToString()

					}); ;
				}
			}

			ab.ListItemsSector = itemssector;
			List<SelectListItem> itemsReporttype = new List<SelectListItem>();
			if (ab.research_Section5 != null)
			{
				foreach (var catitem in ab.research_Section5)
				{
					itemsReporttype.Add(new SelectListItem
					{
						Text = catitem.Type,
						Value = catitem.Type_Id.ToString()

					}); ;
				}
			}
			ab.ListItemsReportType = itemsReporttype;
			ParentPage parentp = new ParentPage();
			parentp.PageName = "Research";
			ab.Page = parentp;
			//-------------DropdownList end------------------------
			return View(ab);
		}
		public ActionResult Researchdetail(int? Report_Id, int? Industry_Id)
		{
			int Resportid = Convert.ToInt32(Report_Id);
			ResearchDetailsRequest resreq = new ResearchDetailsRequest();
			resreq.Report_Id = Resportid;
			resreq.Industry_Id = Convert.ToInt32(Industry_Id);
			ResearchDetail ab = new ResearchDetail();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetResearchDetails";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<ResearchDetail>(responseValue);
			ParentPage parentp = new ParentPage();
			parentp.PageName = "Research";
			ab.Page = parentp;
			return View(ab);
		}

		public ActionResult Allresearchreports()
		{
			ResearchRequest resreq = new ResearchRequest();
			resreq.id =15;
			resreq.Industry_Id = Convert.ToInt32(0);
			ResearchResponse ab = new ResearchResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetResearch";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<ResearchResponse>(responseValue);

			//-----------Dropdownlist------
			List<SelectListItem> items = new List<SelectListItem>();
			if (ab.research_Section4 != null)
			{
				foreach (var catitem in ab.research_Section4)
				{
					items.Add(new SelectListItem
					{
						Text = catitem.Research_Category_Name,
						Value = catitem.Research_Category_Id.ToString()

					}); ;
				}

			}
			ab.ListItemsCat = items;
			List<SelectListItem> itemssector = new List<SelectListItem>();
			if (ab.research_Section3 != null)
			{
				foreach (var catitem in ab.research_Section3)
				{
					itemssector.Add(new SelectListItem
					{
						Text = catitem.sector_Name,
						Value = catitem.research_Sector_Id.ToString()

					}); ;
				}
			}

			ab.ListItemsSector = itemssector;
			List<SelectListItem> itemsReporttype = new List<SelectListItem>();
			if (ab.research_Section5 != null)
			{
				foreach (var catitem in ab.research_Section5)
				{
					itemsReporttype.Add(new SelectListItem
					{
						Text = catitem.Type,
						Value = catitem.Type_Id.ToString()

					}); ;
				}
			}
			ab.ListItemsReportType = itemsReporttype;
			ParentPage parentp = new ParentPage();
			parentp.PageName = "Research";
			ab.Page = parentp;
			//-------------DropdownList end------------------------
			return View(ab);

		}

		public ActionResult Contactus()
		{
			ContactusResponse abresponse = new ContactusResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetContactUsDetails";
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, null, headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			abresponse = JsonConvert.DeserializeObject<ContactusResponse>(responseValue);
			return View(abresponse);
		}
		public JsonResult InsertContactUs_Email(ContactUs_EmailInsertRequest ceir)
		{
			try
			{
				ContactUs_EmailInsertResponse ab = new ContactUs_EmailInsertResponse();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/InsertContactUsEmail";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<ContactUs_EmailInsertResponse>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}

		public JsonResult InsertGetRated(GetRated_InsertRequest ceir)
		{
			try
			{
				GetRated_InsertResponse ab = new GetRated_InsertResponse();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/InsertGetRated";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<GetRated_InsertResponse>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}


		[HttpPost]
		public JsonResult LoadData(FilterRequest ceir)
		{
			try
			{
				ResearchFilter ab = new ResearchFilter();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/FilterResearch";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<ResearchFilter>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}
		public JsonResult FilterData(string Industry_Id, string Research_Category_Id, string Research_Sector_id, string Type_Id, string FROM_DATE, string To_DATE, string SearcText)
		{
			try
			{
				FilterRequest ceir = new FilterRequest();
				if (Industry_Id == "") { ceir.Industry_Id = 0; } else { ceir.Industry_Id = Convert.ToInt32(Industry_Id); };

				if (Research_Category_Id == "") { ceir.Research_Category_Id = 0; } else { ceir.Research_Category_Id = Convert.ToInt32(Research_Category_Id); };
				if (Research_Sector_id == "") { ceir.Research_Sector_id = 0; } else { ceir.Research_Sector_id = Convert.ToInt32(Research_Sector_id); };
				if (Type_Id == "") { ceir.Type_Id = 0; } else { ceir.Type_Id = Convert.ToInt32(Type_Id); };
				ceir.FROM_DATE = FROM_DATE;
				ceir.To_DATE = To_DATE;
				ceir.SearcText = SearcText;
				ResearchFilter ab = new ResearchFilter();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/FilterResearch";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<ResearchFilter>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}

		public JsonResult AllResearchFilterData(string Industry_Id, string Research_Category_Id, string Research_Sector_id, string Type_Id, string FROM_DATE, string To_DATE, string SearcText)
		{
			try
			{
				FilterRequest ceir = new FilterRequest();
				if (Industry_Id == "") { ceir.Industry_Id = 0; } else { ceir.Industry_Id = Convert.ToInt32(Industry_Id); };

				if (Research_Category_Id == "") { ceir.Research_Category_Id = 0; } else { ceir.Research_Category_Id = Convert.ToInt32(Research_Category_Id); };
				if (Research_Sector_id == "") { ceir.Research_Sector_id = 0; } else { ceir.Research_Sector_id = Convert.ToInt32(Research_Sector_id); };
				if (Type_Id == "") { ceir.Type_Id = 0; } else { ceir.Type_Id = Convert.ToInt32(Type_Id); };
				ceir.FROM_DATE = FROM_DATE;
				ceir.To_DATE = To_DATE;
				ceir.SearcText = SearcText;
				ResearchFilter ab = new ResearchFilter();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/GetResearch";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<ResearchFilter>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}



		[HttpPost]
		public JsonResult LoadSectorDropDown(string Industry_Id, string Category_Id)
		{
			try
			{
				ResearchSectorDropRequest ceir = new ResearchSectorDropRequest();
				ceir.Industry_Id = Convert.ToInt32(Industry_Id);
				ceir.Category_Id = Convert.ToInt32(Category_Id);
				ResearchSectorDropDown ab = new ResearchSectorDropDown();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/GetResearchSectorDrop";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<ResearchSectorDropDown>(responseValue);
				List<SelectListItem> itemssector = new List<SelectListItem>();
				if (ab.SectorDropResponse != null)
				{
					foreach (var catitem in ab.SectorDropResponse)
					{
						itemssector.Add(new SelectListItem
						{
							Text = catitem.Sector_Name,
							Value = catitem.Research_Sector_Id.ToString()

						}); ;
					}
				}
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}
		[HttpPost]
		public JsonResult AnnualYearData(string Category_id, string Id)
		{
			try
			{
				CSResponse abresponse = new CSResponse();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/GetCSRDetails";
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, null, headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				abresponse = JsonConvert.DeserializeObject<CSResponse>(responseValue);
				abresponse.csR_Section5 = abresponse.csR_Section5.Where(m => m.Category_Id == Convert.ToInt32(Category_id)).Where(m => m.Id == Convert.ToInt32(Id)).ToList();

				return Json(abresponse, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}
		public JsonResult ResearchAutoComplete(string Industry_Id, string Research_Category_Id, string Research_Sector_id, string Type_Id, string FROM_DATE, string To_DATE, string SearcText)
		{
			try
			{
				FilterRequest ceir = new FilterRequest();
				if (Industry_Id == "") { ceir.Industry_Id = 0; } else { ceir.Industry_Id = Convert.ToInt32(Industry_Id); };

				if (Research_Category_Id == "") { ceir.Research_Category_Id = 0; } else { ceir.Research_Category_Id = Convert.ToInt32(Research_Category_Id); };
				if (Research_Sector_id == "") { ceir.Research_Sector_id = 0; } else { ceir.Research_Sector_id = Convert.ToInt32(Research_Sector_id); };
				if (Type_Id == "") { ceir.Type_Id = 0; } else { ceir.Type_Id = Convert.ToInt32(Type_Id); };
				ceir.FROM_DATE = FROM_DATE;
				ceir.To_DATE = To_DATE;
				ceir.SearcText = SearcText;
				ResearchFilter ab = new ResearchFilter();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/FilterResearch";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(ceir);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<ResearchFilter>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}
		[HttpPost]
		public JsonResult CSRYEAR(string id)
		{
			CSResponse abresponse = new CSResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetCSRDetails";
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, null, headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			abresponse = JsonConvert.DeserializeObject<CSResponse>(responseValue);
			List<SelectListItem> items = new List<SelectListItem>();
			if (abresponse.csR_Section5 != null)
			{
				foreach (var catitem in abresponse.csR_Section5.Where(m => m.Category_Id == Convert.ToInt32(id)))
				{
					items.Add(new SelectListItem
					{
						Text = catitem.Annual_Report_Year,
						Value = catitem.Id.ToString()

					}); ;
				}
			}
			abresponse.ListItemsAnnualReportYear = items;
			return Json(abresponse, JsonRequestBehavior.AllowGet);
		}
		//------------------Rating Module----------------------------------------
		public ActionResult Rating(string Rating_Category_Id)
		{
			RatingRequest resreq = new RatingRequest();
			resreq.id = 14;
			resreq.Company_Id = 0;
			resreq.Rating_Category_Id = Rating_Category_Id;
				//string.IsNullOrEmpty(Rating_Category_Id) ? 0 :Convert.ToInt32(Rating_Category_Id);
			RatingResponse ab = new RatingResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetRating";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<RatingResponse>(responseValue);
			ParentPage parentp = new ParentPage();
			parentp.PageName = "Rating";
			ab.Page = parentp;
			ab.Research_Section6 = GetResearchResponse();
			return View(ab);
		}

		public ActionResult Ratingscorporatesector(string Rating_Category_Id)
		{
			RatingRequest resreq = new RatingRequest();
			if(string.IsNullOrEmpty(Rating_Category_Id)==false)
			{
				if (Convert.ToString(Rating_Category_Id) =="1")
				{
					resreq.id = 16;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;


				}
				if (Convert.ToString(Rating_Category_Id) == "2")
				{
					resreq.id = 17;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;

				}
				if (Convert.ToString(Rating_Category_Id) == "3")
				{
					resreq.id = 18;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;
				}
				if (Convert.ToString(Rating_Category_Id) == "4")
				{
					resreq.id = 19;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;
						//string.IsNullOrEmpty(Rating_Category_Id) ? 0 : Convert.ToInt32(Rating_Category_Id);

				}
				if (Convert.ToString(Rating_Category_Id) == "5")
				{
					resreq.id = 20;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;
						//string.IsNullOrEmpty(Rating_Category_Id) ? 0 : Convert.ToInt32(Rating_Category_Id);

				}
				if (Convert.ToString(Rating_Category_Id) == "6")
				{
					resreq.id = 21;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;
						//string.IsNullOrEmpty(Rating_Category_Id) ? 0 : Convert.ToInt32(Rating_Category_Id);

				}

				if (Convert.ToString(Rating_Category_Id) == "OtherRating")
				{
					resreq.id = 21;
					resreq.Company_Id = 0;
					resreq.Rating_Category_Id = Rating_Category_Id;
					//string.IsNullOrEmpty(Rating_Category_Id) ? 0 : Convert.ToInt32(Rating_Category_Id);

				}
			}
			else
			{
				resreq.id = 14;
				resreq.Company_Id = 0;
				resreq.Rating_Category_Id = Rating_Category_Id;
					//string.IsNullOrEmpty(Rating_Category_Id) ? 0 : Convert.ToInt32(Rating_Category_Id);

			}
			RatingResponse ab = new RatingResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetRating";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<RatingResponse>(responseValue);
			//if(string.IsNullOrEmpty(Rating_Category_Id)==true)
			//{
			//	Rating_Category_Id = "0";
			//}	
		 //   List<ICRA.Models.RatingSection2> final=ab.Rating_Section2.Where(m => m.Rating_Category_Id != Convert.ToInt32(Rating_Category_Id)).ToList();
			//ab.Rating_Section2 = null;
			//ab.Rating_Section2 = final;
			ab.Research_Section6 = GetResearchResponse();
			return View(ab);
		}



		public JsonResult RatingLoad(string Company_Id, string Rating_Category_Id)
		{
			try
			{
				if (Company_Id == "")
					Company_Id = "0";
				if (Rating_Category_Id == "")
					Rating_Category_Id = "0";
				RatingRequest resreq = new RatingRequest();
				resreq.id = 5;
				resreq.Company_Id = Convert.ToInt32(Company_Id);
				resreq.Rating_Category_Id = Rating_Category_Id;
					//Convert.ToInt32(Rating_Category_Id);
				RatingResponse ab = new RatingResponse();
				List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
				string address = BaseUrl + "/api/APPICRA/GetRating";
				var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
				var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
				var json = client.MakeRequest();
				string responseValue = Convert.ToString(json);
				ab = JsonConvert.DeserializeObject<RatingResponse>(responseValue);
				return Json(ab, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json(ex.Message.ToString() + "-" + ex.InnerException.ToString(), JsonRequestBehavior.AllowGet);

			}
		}


		public ActionResult RatingsDetail(string Company_Id)
		{
			RatingRequest resreq = new RatingRequest();
			string Rating_Category_Id = "";
			resreq.id = 14;
			resreq.Company_Id = string.IsNullOrEmpty(Company_Id) ? 0 : Convert.ToInt32(Company_Id);
			resreq.Rating_Category_Id = Rating_Category_Id;
				//string.IsNullOrEmpty(Rating_Category_Id) ? 0 : Convert.ToInt32(Rating_Category_Id);
			RatingResponse ab = new RatingResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetRating";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<RatingResponse>(responseValue);
			//if (string.IsNullOrEmpty(Rating_Category_Id) == true)
			//{
			//	Rating_Category_Id = "0";
			//}
			//List<ICRA.Models.RatingSection2> final = ab.Rating_Section2.Where(m => m.Rating_Category_Id != Convert.ToInt32(Rating_Category_Id)).ToList();
			//ab.Rating_Section2 = null;
			//ab.Rating_Section2 = final;
			ab.Research_Section6 = GetResearchResponse();
			return View(ab);
		}

		public ActionResult RatingLoginPopup()
		{
			return View();
		}




		//---------------Rating End--------------------------------------

		//---------------Career Start------------------------------------
		public ActionResult Career()
		{
			return View();
		}
		//---------------Career Start------------------------------------

		//---------------Analystviews Start------------------------------------
		public ActionResult Analystviews()
		{
			return View();
		}
		//---------------Analystviews End------------------------------------


		//---------------CPR Start------------------------------------
		public ActionResult CPR()
		{
			return View();
		}
		//---------------CPR End------------------------------------

		//---------------CPR Detail Start------------------------------------
		public ActionResult Cprdetail()
		{
			return View();
		}
		//---------------CPR Detail End------------------------------------

		//---------------CPR Subscription Summery cart Start------------------------------------
		public ActionResult Cprsubscriptionsummerycart()
		{
			return View();
		}
		//---------------CPR Subscription Summery cart End------------------------------------

		//---------------Index Start------------------------------------
		public ActionResult Index()
		{
			return View();
		}
		//---------------Index End------------------------------------

		//---------------Investor Start------------------------------------
		public ActionResult Investoranalystpresentation()
		{
			return View();
		}
		public ActionResult Investorannualreturn()
		{
			return View();
		}
		public ActionResult Investorboardmeetings()
		{
			return View();
		}

		public ActionResult Investorcommunication()
		{
			return View();
		}

		public ActionResult Investorcorporateannouncements()
		{
			return View();
		}

		public ActionResult Investorcorporategovernance()
		{
			return View();
		}

		public ActionResult Investordividend()
		{
			return View();
		}

		public ActionResult Investorfinancialperformance()
		{
			return View();
		}
		public ActionResult Investorrelations()
		{
			return View();
		}
		public ActionResult Investorsharebuyback()
		{
			return View();
		}
		public ActionResult Investorshareholdingpattern()
		{
			return View();
		}

		//---------------Investor End------------------------------------

		//---------------Login Popup Start-------------------------------------
		public ActionResult loginpopup()
		{
			return View();
		}
		//---------------Login Popup End-------------------------------------
		//---------------Media and events Start-------------------------------------
		public ActionResult Mediaandevents()
		{
			return View();
		}
		//---------------Media and events End-------------------------------------

		//---------------Media news Start-------------------------------------
		public ActionResult Medianews()
		{
			return View();
		}
		//---------------Media news End-------------------------------------

		//---------------Media Releases Start-------------------------------------
		public ActionResult Mediareleases()
		{
			return View();
		}
		//---------------Media Releases End-------------------------------------


		//---------------Photo Gallery Start-----------------------------------
		public ActionResult Photogallery()
		{
			return View();
		}
		//---------------Photo Gallery End-------------------------------------


		//---------------Podcasts Start-----------------------------------
		public ActionResult Podcasts()
		{
			return View();
		}
		//---------------Podcasts End-------------------------------------

		//---------------Policies Codes Start-----------------------------------
		public ActionResult Policiescodes()
		{
			return View();
		}
		//---------------Policies Codes End-------------------------------------
		//---------------Regulatory disclosures rbi Start-----------------------------------
		public ActionResult Regulatorydisclosuresrbi()
		{
			return View();
		}
		//---------------Regulatory disclosures rbi End-------------------------------------
		//---------------Regulatory disclosures sebi Start-----------------------------------
		public ActionResult Regulatorydisclosuressebi()
		{
			return View();
		}
		//---------------Regulatory disclosures sebi End-------------------------------------
		//---------------Subscription summary Start-----------------------------------
		public ActionResult Subscriptionsummary()
		{
			return View();
		}
		//---------------Subscription summary End-------------------------------------

		//---------------Template Start-----------------------------------
		public ActionResult Template()
		{
			return View();
		}
		//---------------Template End-------------------------------------
		//---------------Template Start-----------------------------------
		public ActionResult Webinarsandevents()
		{
			return View();
		}
		//---------------Template End-------------------------------------

		public ActionResult ResearchViewReport()
		{
			return View();
		}
		public ActionResult Researchsubscribereportspopup()
		{
			return View();
		}
		public ActionResult OtherRatingPopup()
		{
			return View();
		}


		public List<ResearchSection6> GetResearchResponse()
		{
			ResearchRequest resreq = new ResearchRequest();
			resreq.id = 5;
			resreq.Industry_Id = 0;
			ResearchResponse ab = new ResearchResponse();
			List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
			string address = BaseUrl + "/api/APPICRA/GetResearch";
			var body = Newtonsoft.Json.JsonConvert.SerializeObject(resreq);
			var client = new ICRA.Controllers.ServiceController.RestClient("application/json", address, HttpVerb.POST, Convert.ToString(body), headers);
			var json = client.MakeRequest();
			string responseValue = Convert.ToString(json);
			ab = JsonConvert.DeserializeObject<ResearchResponse>(responseValue);
			return ab.research_Section6;
		}


		public ActionResult researchsubscriptionsummery()
		{
			return View();
		}

		public ActionResult Webinar()
		{
			return View();
		}

		public ActionResult AllRatingRationals()
		{
			return View();
		}

		
		#endregion


	}


	public class SectionType
	{
		public string Section { get; set; }
	}
}