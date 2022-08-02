using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Try.Abp.PlugIn.Core;

namespace Try.Abp.WebApi.Controllers;

[ApiController]
[Route("home")]
public class HomeController : ControllerBase
{
    private readonly IEnumerable<IPlugIn> _plugIns;

    public HomeController(IEnumerable<IPlugIn> plugIns)
    {
        _plugIns = plugIns;
    }

    [HttpGet(Name = "")]
    public ActionResult<string> Get()
    {
        return _plugIns.Count().ToString();
    }
}