using Microsoft.AspNetCore.Mvc;

namespace KodotiAzureDevOps.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Running ..";
        }
    }
}
