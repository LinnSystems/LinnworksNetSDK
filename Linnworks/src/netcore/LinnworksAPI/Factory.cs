using System;
using System.Collections.Concurrent;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class Factory
    {
        private static ConcurrentDictionary<Guid, HttpClient> Clients = new ConcurrentDictionary<Guid, HttpClient>();

        private static HttpClient GetClient(Guid token)
        {
            HttpClient client = null;

            if (!Clients.TryGetValue(token, out client))
            {
                lock(typeof(HttpClient))
                {
                    client = new HttpClient();
                    client.Timeout = new TimeSpan(0, 10, 0);

                    if (token != Guid.Empty)
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.ToString());

                    Clients.TryAdd(token, client);
                }
            }

            return client;
        }

        public static async Task<string> GetResponseAsync(string extension, string body, Guid token, string server)
        {
            try
            {
                var client = GetClient(token);

                var response = await client.PostAsync(new Uri(server + extension), new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded"));
                   
                string responseResult = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return responseResult;
                }
                else
                {
                    var error = JsonFormatter.ConvertFromJson<ApiError>(responseResult);
                    throw new Exception(error.Message);
                }

            }
            catch (HttpRequestException)
            {
                throw ;
            }
        }

        public class ApiError
        {
            public string Message { get; set; }
        }
    }
}
