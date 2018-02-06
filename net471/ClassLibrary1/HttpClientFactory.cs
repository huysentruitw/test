using System.Net.Http;

namespace ClassLibrary1
{
    public class HttpClientFactory
    {
        public static HttpClient CreateClient() => new HttpClient();
    }
}
