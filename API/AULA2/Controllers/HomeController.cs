using Microsoft.AspNetCore.Mvc;

namespace AULA2.Controllers
{
    [Route("v1")] 
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Get()
        {       
            return "Hello World!";
        }
    }
} 