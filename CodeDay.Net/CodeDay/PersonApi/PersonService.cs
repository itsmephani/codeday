using CodeDay.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodeDay.PersonApi
{
  class PersonService
  {
    static string API_BASE_URL = "https://randomuser.me/api/";
    static HttpClient client = new HttpClient();

    public static async Task<string> GetPerson()
    {
      string result = "";
      HttpResponseMessage response = await client.GetAsync(API_BASE_URL);
      if (response.IsSuccessStatusCode)
      {
        result = await response.Content.ReadAsStringAsync();
      }

      return result;
    }

  }

}
