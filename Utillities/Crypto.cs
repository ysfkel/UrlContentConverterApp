using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using ResponseConvetter.WWWHelpers;
using ResponseConvetter.ExtensionMethods;

namespace ResponseConvetter.Utillities
{
   public class Crypto:ICrypto
   {
       private IHttpHelper http;
       public Crypto(IHttpHelper http)
       {
         this.http=http;
       }

       //makes a http call to retrieve the provided url
       //gets the md5 hash of the content of the html response
       //returns  the hash
       public async Task<string> GetHttpContentHashAsync(string url)
       {
            var result = await http.GetPageContentAsync(url);
            byte[] hash = ComputeHash(result);
            return hash.GetString();
       }

        //Converts the input string to a byte and returns the 
        //md5 hash
        private static byte[] ComputeHash(string input)
        {
            byte[] resultByte = Encoding.ASCII.GetBytes(input);
            return MD5.Create().ComputeHash(resultByte);
        }
   }
}