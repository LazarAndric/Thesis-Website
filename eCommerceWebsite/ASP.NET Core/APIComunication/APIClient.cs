using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core.APIComunication
{
    public class APIClient
    {
        public void SetAPIClient()
        {

            //if(!string.IsNullOrEmpty(result.AccessToken))
            //{
            //    var httpClient = new HttpClient(clientHandler);
            //    var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            //    if(defaultRequestHeaders.Accept == null || !defaultRequestHeaders.Accept.Any
            //        (m=> m.MediaType=="apolictaion/json"))
            //    {
            //        httpClient.DefaultRequestHeaders.Accept.Add(new
            //            MediaTypeWithQualityHeaderValue("application/json"));
            //    }

            //    defaultRequestHeaders.Authorization =
            //        new AuthenticationHeaderValue("bearer", result.AccessToken);

            //    HttpResponseMessage response = await httpClient.GetAsync(config.BaseAddress+"api/User");

            //    if (response.IsSuccessStatusCode)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        string json = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine(json);
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"Failed to call API: {response.StatusCode}");
            //        string content = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine($"Content: {content}");
            //    }
            //    Console.ResetColor();
            //}
        }
        public void Connect()
        {

        }
        public void Initialize()
        {

        }
    }
}
