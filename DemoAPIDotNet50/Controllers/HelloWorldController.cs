using Microsoft.AspNetCore.Mvc;

namespace DemoAPIDotNet50.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {       
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}
