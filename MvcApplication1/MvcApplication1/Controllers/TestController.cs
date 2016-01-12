using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Services;
using MvcApplication1.ViewModels;
using Newtonsoft.Json;

namespace MvcApplication1.Controllers
{
    
    public class TestController : Controller
    {

        public Location GetLocation(string clubName)
        {
            var course = new GolfCourse(clubName);
            var json = GoogleAPI.FetchGoogleData(course);

            return JsonConvert.DeserializeObject<Location>(json);
        }

        public WeatherInfo GetWeatherInfo( string lat, string lon )
        {
            var json = WeatherForcastAPI.FetchWeatherData(lat, lon);

            return JsonConvert.DeserializeObject<WeatherInfo>(json);

        }


        public ActionResult GetView()
        {

            var vmGolf = new GolfCourseViewModel();
            var location = GetLocation("remuera golf club");
            var weather = GetWeatherInfo("-36.8815954", "174.8313767");
            vmGolf.Name = location.ClubName();
            vmGolf.Address = location.Address();
            vmGolf.WeatherDescription = weather.WeatherDescripion();

            return View("MyView", vmGolf);
        }
    }
}
