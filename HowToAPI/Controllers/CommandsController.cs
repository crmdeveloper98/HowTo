using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HowToAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new [] { "This", "is", "a", "hard", "coded", "string"};
        }
    }
}
