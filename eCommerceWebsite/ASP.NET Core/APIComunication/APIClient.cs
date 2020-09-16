using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplication1;

namespace ASP.NET_Core.APIComunication
{
    public class APIClient
    {
        public static APIClient Instance;
        public AuthenticationResult result { get; set; }
        public HttpClientHandler clientHandler { get; set; }
        public AuthConfig config { get; set; }
        public APIClient(AuthenticationResult result, HttpClientHandler clientHandler, AuthConfig config)
        {
            Instance = this;
            this.result = result;
            this.clientHandler = clientHandler;
            this.config = config;
        }
        public async void SetAPIClient()
        {

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                var httpClient = new HttpClient(clientHandler);
                var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

                if (defaultRequestHeaders.Accept == null || !defaultRequestHeaders.Accept.Any
                    (m => m.MediaType == "apolictaion/json"))
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new
                        MediaTypeWithQualityHeaderValue("application/json"));
                }

                defaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("bearer", result.AccessToken);

                HttpResponseMessage response = await httpClient.GetAsync(config.BaseAddress + "api/User");

                if (response.IsSuccessStatusCode)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(json);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Failed to call API: {response.StatusCode}");
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Content: {content}");
                }
                Console.ResetColor();
            }
        }
        public void Connect()
        {

        }
        public void Initialize()
        {

        }
    }
}
