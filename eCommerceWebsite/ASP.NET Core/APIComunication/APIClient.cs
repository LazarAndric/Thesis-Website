using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ASP.NET_Core.APIComunication
{
    public class APIClient
    {
        private static string WebAPIURL = "https://localhost:5001/api/Product";


        public static string SetAPIClient()
        {
            using HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            using HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.18363");
            client.Timeout = TimeSpan.FromMinutes(3.0);
            using HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(WebAPIURL)
            };
            using HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
            using HttpContent content = response.Content;
            byte[] buffer = content.ReadAsByteArrayAsync().GetAwaiter().GetResult().ToArray();
            string html = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            return HttpUtility.HtmlDecode(html);
        }
    }
}
