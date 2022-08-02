using Microsoft.AspNetCore.Mvc;

namespace Try.Abp.Plugin.Bar;

[ApiController]
[Route("bar")]
public class BarController : ControllerBase
{
    [HttpGet(Name = "")]
    public ActionResult<string> Get()
    {
        return "Bar";
    }
}