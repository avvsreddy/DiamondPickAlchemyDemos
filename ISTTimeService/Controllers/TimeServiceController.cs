using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISTTimeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeServiceController : ControllerBase
    {
        [HttpGet]
        public string abcd()
        {
            return System.DateTime.Now.ToString();
        }

    }
}
