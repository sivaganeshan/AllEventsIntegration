using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace BmsIntegration
{
    class Program
    {
        static void Main(string[] args)
        {

            //string subscriptionKey = "d165d9972b2241ea85457c49bf0e4202";
            //string outputText = string.Empty;
            //string uriOfRequest = @"https://api.allevents.in/geo/city_suggestion/Chennai";
            //HttpWebRequest GetTokenWebRequest = (HttpWebRequest)WebRequest.Create(uriOfRequest);
            //GetTokenWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
            //GetTokenWebRequest.ContentType = "application/json; charset=utf-8";
            //WebResponse tokenResponse = GetTokenWebRequest.GetResponse();

            //using (var sr = new StreamReader(tokenResponse.GetResponseStream()))
            //{
            //    outputText = sr.ReadToEnd();
            //}
            //TextReader tR = new TextReader
            string jsonValueofData =  "{\"city_id\":\"13147\",\"city\":\"Chennai\",\"country_id\":\"113\",\"country\":\"India\",\"country_code\":\"IN\",\"region_id\":\"2191\",\"region\":\"Tamil Nadu\",\"region_code\":\"TN\",\"latitude\":\"13.0634000000\",\"longitude\":\"80.2207000000\",\"query\":\"Chennai\",\"timezone\":\"+05:30\"}"; 
            
            Dictionary<string,string> dataValue = JsonConvert.DeserializeObject<Dictionary<string,string>>(jsonValueofData);

            Console.WriteLine(dataValue["city_id"]);

            //JsonValue val = new JsonValue
           // HttpWebResponse httpWebResponse = (HttpWebResponse)tokenResponse;

            //Console.WriteLine(outputText);



        }
    }
}
