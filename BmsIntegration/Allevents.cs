using System;
using System.Net;
using System.Text;
using System.Web;

namespace CSHttpClientSample
{
    static class program
    {
        static void simpleMain()
        {
            //MakeRequest();
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }

        //static async void MakeRequest()
        //{
        //    var client = new HttpClient();
        //    var queryString = HttpUtility.ParseQueryString(string.Empty);

        //    // Request headers
        //    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "{subscription key}");

        //    var uri = "https://api.allevents.in/geo/city_suggestion/{city}?" + queryString;

        //    var response = await client.GetAsync(uri);
        //}
    }
}