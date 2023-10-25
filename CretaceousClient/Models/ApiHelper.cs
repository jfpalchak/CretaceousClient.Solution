using System.Threading.Tasks;
using RestSharp;

namespace CretaceousClient.Models;

public class ApiHelper
{
  public static async Task<string> GetAll()
  { // When pushed to production, revert back to HTTPS and change the url to the APIs host site
    RestClient client = new RestClient("http://localhost:5000/");
    RestRequest request = new RestRequest($"api/animals", Method.Get);
    RestResponse response = await client.GetAsync(request);

    return response.Content;
  }
}