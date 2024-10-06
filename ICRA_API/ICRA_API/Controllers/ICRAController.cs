using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ICRA_API.BLL;
using ICRA_API.Models;

namespace ICRA_API.Controllers
{
    #region Divakar Upadhyay Start Date: 7 January 2022 Start
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    [RoutePrefix("api/APPICRA")]
    public class ICRAController : ApiController
    {
        [HttpPost]
        [Route("GetAboutUsDetails")]
        public HttpResponseMessage GetAboutUsDetails(SectionType Section)
        {
            AboutUsBLL curb = new AboutUsBLL();
            HttpResponseMessage response;

            AboutUs objResult = null;

            objResult = curb.GetAboutUsDetails(Convert.ToString(Section.Section));

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }
        [HttpPost]
        [Route("GetCSRDetails")]
        public HttpResponseMessage GetCSRDetails(SectionType Section)
        {
            CSRBLL curb = new CSRBLL();
            HttpResponseMessage response;
            CSR objResult = null;
            objResult = curb.GetCSRDetails();
            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }
        [HttpPost]
        [Route("GetContactUsDetails")]
        public HttpResponseMessage GetContactusDetails()
        {
            ContactUsBLL curb = new ContactUsBLL();
            HttpResponseMessage response;
            ContactUs objResult = null;
            objResult = curb.GetContactUsDetails();

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }

        [HttpPost]
        [Route("InsertContactUsEmail")]
        public HttpResponseMessage InsertContactUsEmail(ContactUs_EmailInsertRequest cei)
        {
            ContactUsBLL curb = new ContactUsBLL();
            HttpResponseMessage response;
            ContactUs_EmailInsertResponse objResult = null;
            objResult = curb.InsertContactUsEmail(cei);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }

        [HttpPost]
        [Route("InsertGetRated")]
        public HttpResponseMessage InsertGetRated(GetRated_InsertRequest cei)
        {
            GetRatedBLL curb = new GetRatedBLL();
            HttpResponseMessage response;
            GetRated_InsertResponse objResult = null;
            objResult = curb.InsertGetRated(cei);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }


        [HttpPost]
        [Route("GetResearch")]
        public HttpResponseMessage GetResearch(ResearchRequest resreq)
        {
            ResearchBLL curb = new ResearchBLL();
            HttpResponseMessage response;
            Research objResult = null;
            objResult = curb.GetResearch(resreq);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }

        [HttpPost]
        [Route("FilterResearch")]
        public HttpResponseMessage FilterResearch(FilterRequest resreq)
        {
            ResearchBLL curb = new ResearchBLL();
            HttpResponseMessage response;
            ResearchFilter objResult = null;
            objResult = curb.FilterResearch(resreq);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }


        [HttpPost]
        [Route("GetResearchDetails")]
        public HttpResponseMessage GetResearchDetails(ResearchDetailsRequest resreq)
        {
            ResearchBLL curb = new ResearchBLL();
            HttpResponseMessage response;
            ResearchDetails objResult = null;
            objResult = curb.GetResearchDetails(resreq);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }

        [HttpPost]
        [Route("GetResearchSectorDrop")]
        public HttpResponseMessage GetResearchSectorDrop(ResearchSectorDropRequest resreq)
        {
            ResearchBLL curb = new ResearchBLL();
            HttpResponseMessage response;
            ResearchSectorDropDown objResult = null;
            objResult = curb.GetResearchSectorDrop(resreq);
            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }


        [HttpPost]
        [Route("GetRating")]
        public HttpResponseMessage GetRating(RatingRequest resreq)
        {
            RatingBLL curb = new RatingBLL();
            HttpResponseMessage response;
            Rating objResult = null;
            objResult = curb.GetRating(resreq);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }
        [HttpPost]
        [Route("GetRating1")]
        public HttpResponseMessage GetRating1(RatingRequest resreq)
        {
            RatingBLL curb = new RatingBLL();
            HttpResponseMessage response;
            Rating objResult = null;
            objResult = curb.GetResearch1(resreq);

            if (objResult != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, objResult);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "Data Empty!");
            }
            return response;
        }


    }
    #endregion
}
