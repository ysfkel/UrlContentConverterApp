
using System.Threading.Tasks;
using System.Net.Http;

namespace ResponseConvetter.WWWHelpers
{
   public class HttpHelper:IHttpHelper
   {
       //Makes a http call to retrieve the provided URL
       public async Task<string> GetPageContentAsync(string url)
       {
           using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    
                    using (HttpContent content = response.Content)
                    {
                        var result = await content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
       }
   }
}




 