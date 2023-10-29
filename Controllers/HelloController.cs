using Microsoft.AspNetCore.Mvc;

namespace PjdTest.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string ok(){
        return "OK";
    }
}