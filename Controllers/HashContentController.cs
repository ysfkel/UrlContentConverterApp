using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ResponseConvetter.Models;
using ResponseConvetter.Utillities;

namespace ResponseConvetter.Controllers
{
    [Route("api/hash")]
     public class HashContentController:Controller
     {
         private ICrypto crypto;
         public HashContentController(ICrypto crypto)
         {
             this.crypto=crypto;
         }
         [HttpPost]
         public async Task<IActionResult> Post([FromBody]DataItem data)
         {
             if(!ModelState.IsValid)
             {
               return  BadRequest(ModelState);
             }
             //get the md5 hash of the content  of the response
             var hash=await crypto.GetHttpContentHashAsync(data.Url);
             return StatusCode(200,new {hash=hash});
         
         } 

     }
}