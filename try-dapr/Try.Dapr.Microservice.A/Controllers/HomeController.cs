using Microsoft.AspNetCore.Mvc;

namespace Try.Dapr.Microservice.A.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet("hello")]
    public ActionResult<string> Get()
    {
        Console.WriteLine("Hello, World");
        return "Hello, World";
    }
}