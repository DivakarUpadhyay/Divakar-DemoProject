using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICRA.Models
{


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ContactUsSection1
    {
        public string section { get; set; }
        public int contactusBanner_Id { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string desktop_image { get; set; }
        public string responsive_image { get; set; }
    }

    public class ContactUsSection2
    {
        public string section { get; set; }
        public int category_Id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public object boardlineDirect { get; set; }
        public string direct { get; set; }
    }

    public class ContactUsSection3
    {
        public string section { get; set; }
        public int category_Id { get; set; }
        public string category { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
    public class ContactUsSection4
    {
        public string Section { get; set; }
        public int AboutusGroupId { get; set; }
        public string Group_Name { get; set; }
        public string Logo { get; set; }
        public string Background_Image { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }

    }
    public class ContactusResponse
    {
        public ContactUsSection1 contactUs_Section1 { get; set; }
        public List<ContactUsSection2> contactUs_Section2 { get; set; }
        public List<ContactUsSection3> contactUs_Section3 { get; set; }
        public List<ContactUsSection4> contactUs_Section4 { get; set; }
    }


}