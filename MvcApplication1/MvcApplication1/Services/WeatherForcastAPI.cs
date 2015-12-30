using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Services
{
    public class WeatherForcastAPI
    {
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string Appid = "appid=49e20df53ff8e436740c62f762b0ee99";

        public static string FetchWeatherData(string city)
        {
            string name = city;
            var r = WebRequest.Create(new Uri(BaseUrl + city + "&" + Appid));
            return new StreamReader(r.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }
}