using System.Threading.Tasks;

namespace ResponseConvetter.WWWHelpers
{
   public interface IHttpHelper
   {
      Task<string>  GetPageContentAsync(string url);
   }
}