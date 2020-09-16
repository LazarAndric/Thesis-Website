using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using ASP.NET_Core.APIComunication;
using WebApplication1;

namespace ASP.NET_Core
{
    public class Program
    {
        static HttpClientHandler clientHandler = new HttpClientHandler();

        public static void Main(string[] args)
        {
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            RunAsync().GetAwaiter().GetResult();
            CreateHostBuilder(args).Build().Run();
        }
        private static async Task RunAsync()
        {
            AuthConfig config = AuthConfig.ReadJsonFromFile("appsettings.json");

            IConfidentialClientApplication app;

            app = ConfidentialClientApplicationBuilder.Create(config.ClientId)
                .WithClientSecret(config.ClientSecret)
                .WithAuthority(new Uri(config.Authority))
                .Build();

            string[] ResourceIds = new string[] { config.ResourceId };

            AuthenticationResult result = null;

            try
            {
                result = await app.AcquireTokenForClient(ResourceIds).ExecuteAsync();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(result.AccessToken);
                Console.ResetColor();
                APIClient cli= new APIClient(result, clientHandler, config);
                cli.SetAPIClient();
            }
            catch (MsalClientException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
