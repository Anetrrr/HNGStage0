using HNGStage0.Model.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HNGStage0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicInfoController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetInfo()
        {
            var details = new PublicInfo
            {
                Email = "anetor.ataga@gmail.com",
                CurrentDateTime = DateTime.Now,
                GithubUrl = "www.github.com/anetrrr/HNGStage0",

            };

            if (details != null)
            {

                return Ok(details);

            }

            else 
                
                return StatusCode((int)HttpStatusCode.BadRequest);
                    
        }
    }
}
