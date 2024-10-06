using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA.Models
{
	
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AboutUsSection1
    {
        public string section { get; set; }
        public int aboutusBanner_Id { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string desktop_image { get; set; }
        public string responsive_image { get; set; }
    }

    public class AboutUsSection2
    {
        public string section { get; set; }
        public int aboutusId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class AboutUsSection3
    {
        public string section { get; set; }
        public int aboutusTimelineId { get; set; }
        public object year { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class AboutUsSection4
    {
        public string section { get; set; }
        public int LeaderShipId { get; set; }
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class AboutUsSection5
    {
        public string section { get; set; }
        public int aboutusGroupId { get; set; }
        public string group_Name { get; set; }
        public string logo { get; set; }
        public string background_Image { get; set; }
        public string description { get; set; }
        public string url { get; set; }
    }

    public class AboutUsResponse
    {
        public AboutUsSection1 aboutUs_Section1 { get; set; }
        public List<AboutUsSection2> aboutUs_Section2 { get; set; }
        public List<AboutUsSection3> aboutUs_Section3 { get; set; }
        public List<AboutUsSection4> aboutUs_Section4 { get; set; }
        public List<AboutUsSection5> aboutUs_Section5 { get; set; }
    }


}