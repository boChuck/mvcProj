using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Services
{
    public class WeatherForcastAPI
    {
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather?";
        private const string Appid = "appid=49e20df53ff8e436740c62f762b0ee99";

        public static string FetchWeatherData(string x, string y)
        {
            string lat = "lat=" + x;
            string lon = "lon=" + y;
            var r = WebRequest.Create(new Uri(BaseUrl + lat + "&" + lon + "&" + Appid));
            return new StreamReader(r.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }
}