using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    { 
        return Ok(1111);
    }
}