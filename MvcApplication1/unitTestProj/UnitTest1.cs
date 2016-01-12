using System;
using System.Linq;
using MvcApplication1.Models;
using MvcApplication1.Services;
using Newtonsoft.Json;
using NUnit.Framework;
namespace unitTestProj
{
    [TestFixture]
    public class GoogleApi
    {
        [Test]
        public void TestGoogleData()
        {
            var course = new GolfCourse("remuera golf club");
            string json = GoogleAPI.FetchGoogleData(course);

            var location = JsonConvert.DeserializeObject<Location>(json);


            Assert.IsNotNull(location.results.First().formatted_address);
        }
    }

    [TestFixture]
    public class WeatherApi
    {
        [Test]
        public void TestWeatherData()
        {
            string json = WeatherForcastAPI.FetchWeatherData("-36.8815954", "174.8313767");
            var weather = JsonConvert.DeserializeObject<WeatherInfo>(json);
            Assert.IsNotNull(weather.weather.First().description);
        }
    }
}
