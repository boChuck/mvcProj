using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Models;
using MvcApplication1.Services;
using Newtonsoft.Json;

namespace unitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var course = new GolfCourse( "remuera golf club" );
            string json = GoogleAPI.FetchGoogleData( course );

            var location = JsonConvert.DeserializeObject<Location>(json);


            Assert.IsNotNull(location.results.First().formatted_address);
        }
        [TestMethod]
        public void TestWeatherAPI()
        {
            
            string json = WeatherForcastAPI.FetchWeatherData("taupo");

            var weather = JsonConvert.DeserializeObject<WeatherInfo>(json);


            Assert.IsNotNull(weather.weather.First().description);
        }
    }
}
