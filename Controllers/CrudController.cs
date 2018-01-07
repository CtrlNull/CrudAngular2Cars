using System;
using Microsoft.AspNetCore.Mvc;

namespace CrudAngular2Cars
{
    [Route("api/[Controller]")]
    public class CrudController : Controller
    {
        [HttpGet]
        public IActionResult Greetings() {
            return Ok("Hello from ASP.NET Core Web API.");
        }
    }
}