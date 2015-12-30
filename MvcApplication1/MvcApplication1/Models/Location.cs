using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Location
    {
        public string status { get; set; }
        public results[] results { get; set; }
    }
    public class results
    {
        public string formatted_address { get; set; }
        public geometry geometry { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public opening_hours opening_hours { get; set; }
        public photos[] photos { get; set; }
        public string place_id { get; set; }
        public string[] types { get; set; }
        
    }

    public class geometry
    {
        public location location { get; set; }
    }

    public class location
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
    public class opening_hours
    {
        public Boolean open_now { get; set; }
        public string[] weekday_text { get; set; }
    }

    public class photos
    {
        public string height { get; set; }
        public string[] html_attributions { get; set; }
        public string width { get; set; }
    }
}