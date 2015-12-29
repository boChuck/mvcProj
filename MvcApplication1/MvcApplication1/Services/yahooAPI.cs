using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace MvcApplication1.Services
{
    public class yahooAPI
    {
        private const string BASE_URL = "https://maps.googleapis.com/maps/api/geocode/json?address=";
        private const string KEY = "key=AIzaSyDrmXBif4-NYHjuIEx2mrAIJ2ZwiUFsZ98";

        public static string FetchGoogleData(string address)
        {
            var r =
                WebRequest.Create(
                    new Uri(
                        "https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "key=AIzaSyDrmXBif4-NYHjuIEx2mrAIJ2ZwiUFsZ98"));

            return new StreamReader(r.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }
}