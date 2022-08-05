using Microsoft.AspNetCore.Mvc;

namespace Try.Abp.Plugin.Foo;

[ApiController]
[Route("[controller]")]
public class FooController : ControllerBase
{
    [HttpGet(Name = "foo")]
    public ActionResult<string> Get()
    {
        return "Foo";
    }
}