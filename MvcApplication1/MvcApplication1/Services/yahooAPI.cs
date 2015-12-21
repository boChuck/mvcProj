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
        public static string FetchGoogleData()
        {
            var r =
                WebRequest.Create(
                    new Uri(
                        "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22AAPL%22)%0A%09%09&format=json&diagnostics=true&env=http%3A%2F%2Fdatatables.org%2Falltables.env&callback="));

            return new StreamReader(r.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }
}