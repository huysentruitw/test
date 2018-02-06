using System.Net.Http;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = HttpClientFactory.CreateClient();
            client.Dispose();
        }
    }
}
