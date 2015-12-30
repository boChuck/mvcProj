using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Services
{
    public class GoogleAPI
    {
        private const string BaseUrl = "https://maps.googleapis.com/maps/api/place/textsearch/json?query=";
        private const string KEY = "key=AIzaSyAEDkrbANqQpWifyfOWTqPwCNScyArwVmM";

        public static string FetchGoogleData(GolfCourse course)
        {
            string name = course.Name;
            var r = WebRequest.Create(new Uri(BaseUrl + name + "&" +KEY));
            return new StreamReader(r.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }
}