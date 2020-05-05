using Microsoft.AspNetCore.Mvc;
using System;

namespace KodotiAzureDevOps.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        private static DateTime? ReleaseDate { get; set; }

        [HttpGet]
        public IActionResult Get()
        {
            if (ReleaseDate == null) 
            {
                ReleaseDate = DateTime.UtcNow;
            }

            return Ok(
                new
                {
                    Enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"),
                    ReleaseDate
                }
            );
        }
    }
}
