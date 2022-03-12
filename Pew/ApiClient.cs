using RestSharp;
using System.Net.Http.Json;

namespace Pew
{
    public static class ApiClient
    {
        public async static Task<T?> Execute<T>(Method method, string uri)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest
            {
                Method = method,
                Resource = uri
            };

            try
            {
                RestResponse<T> response = await client.ExecuteAsync<T>(request);
                return response.Data;
            }
            catch
            {
                return default;
            }
        }
    }
}