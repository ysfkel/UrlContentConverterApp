
using System.Threading.Tasks;

namespace ResponseConvetter.Utillities
{
   public interface ICrypto
   {
       Task<string> GetHttpContentHashAsync(string url);
   }
}