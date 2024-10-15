using DemoCACQRS.External.Common.Interfaces;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DemoCACQRS.External.Common.Services
{
    public class HttpService : IHttpService
    {
        public async Task<T> SendHttpRequest<T>(string url, HttpMethod httpMethod, object body = null, string bearer = null)
        {
            try
            {
                var httpClient = new HttpClient();

                // For OAuth2.0
                if (!string.IsNullOrEmpty(bearer))
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearer);

                var httpRequestMessage = new HttpRequestMessage() { Method = httpMethod, RequestUri = new Uri(url) };

                if (body != null)
                    httpRequestMessage.Content = JsonContent.Create(body);


                var response = await httpClient.SendAsync(httpRequestMessage);

                if (response.IsSuccessStatusCode)
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex);
            }

            return default;
        }
    }
}
