using System.ComponentModel.DataAnnotations;

namespace ResponseConvetter.Models
{

   public class DataItem
   {
       [Required]
        [Url(ErrorMessage = "Invalid URL! Please enter url in the format: http://www.example.com")]
      public string Url{get;set;}
   }
}