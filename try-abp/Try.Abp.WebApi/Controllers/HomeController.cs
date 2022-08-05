using Microsoft.AspNetCore.Mvc;
using Try.Abp.PlugIn.Core;

namespace Try.Abp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IEnumerable<IPlugIn> _plugIns;

    public HomeController(IEnumerable<IPlugIn> plugIns)
    {
        _plugIns = plugIns;
    }

    [HttpGet(Name = "home")]
    public ActionResult<string> Get()
    {
        return $"plug-ins: {_plugIns.Aggregate(string.Empty, (current, plugIn) => current + $"{plugIn.Display()} ")}";
    }
}