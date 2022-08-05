using Microsoft.AspNetCore.Mvc;

namespace Try.Abp.Plugin.Bar;

[ApiController]
[Route("[controller]")]
public class BarController : ControllerBase
{
    [HttpGet(Name = "bar")]
    public ActionResult<string> Get()
    {
        return "Bar";
    }
}