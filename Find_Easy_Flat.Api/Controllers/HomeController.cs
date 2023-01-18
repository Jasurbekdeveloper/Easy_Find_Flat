using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Find_Easy_Flat.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello Everyone");
    }
}
