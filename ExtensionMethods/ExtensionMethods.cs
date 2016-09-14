
using System.Text;

namespace ResponseConvetter.ExtensionMethods
{
   public static class ExtensionMethods
   {
      public static string GetString(this byte[] hash)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
   }
}