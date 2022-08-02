using Microsoft.AspNetCore.Mvc;

namespace Try.Abp.Plugin.Foo;

[ApiController]
[Route("foo")]
public class FooController : ControllerBase
{
    [HttpGet(Name = "")]
    public ActionResult<string> Get()
    {
        return "Foo";
    }
}