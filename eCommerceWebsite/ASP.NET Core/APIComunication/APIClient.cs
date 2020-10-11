using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public static string Token { get; set; } = String.Empty;
        public static string BaseAdress { get; set; } = "https://localhost:5001/api/";

        public static string SetAPIClient<T>(string endPoint,T jsonContent, string jwtToken, HttpMethod method)
        {
            using HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            using HttpClient client = new HttpClient(handler);
            //client.DefaultRequestHeaders.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.18363");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
            //client.Timeout = TimeSpan.FromMinutes(3.0);
            var json = JsonConvert.SerializeObject(jsonContent);
            var content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            using HttpRequestMessage request = new HttpRequestMessage
            {
                Method = method,
                Content = content,
                RequestUri = new Uri(BaseAdress+endPoint)
            };
            using HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                using HttpContent httpContent = response.Content;
                byte[] buffer = httpContent.ReadAsByteArrayAsync().GetAwaiter().GetResult().ToArray();
                string html = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                return HttpUtility.HtmlDecode(html);
            }
            return null;
        }

        public static string SetAPIClient(string endPoint, string data, string jwtToken, HttpMethod method)
        {
            using HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            using HttpClient client = new HttpClient(handler);
            //client.DefaultRequestHeaders.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.18363");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
            //client.Timeout = TimeSpan.FromMinutes(3.0);
            using HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(BaseAdress + endPoint+data)
            };
            using HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
            if (response.StatusCode != HttpStatusCode.NotFound)
            {
                using HttpContent content = response.Content;
                byte[] buffer = content.ReadAsByteArrayAsync().GetAwaiter().GetResult().ToArray();
                string html = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                return HttpUtility.HtmlDecode(html);
            }
            return null;
        }
        public static string SetAPIClient<T>(string endPoint, T jsonContent, HttpMethod method)
        {
            using HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            using HttpClient client = new HttpClient(handler);
            var json = JsonConvert.SerializeObject(jsonContent);
            var content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            using HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                Content = content,
                RequestUri = new Uri(BaseAdress + endPoint)
            };
            using HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
            if (response.StatusCode != HttpStatusCode.NotFound)
            {
                using HttpContent httpContent = response.Content;
                byte[] buffer = httpContent.ReadAsByteArrayAsync().GetAwaiter().GetResult().ToArray();
                string html = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                return HttpUtility.HtmlDecode(html);
            }
            return null;
        }
    }
}
