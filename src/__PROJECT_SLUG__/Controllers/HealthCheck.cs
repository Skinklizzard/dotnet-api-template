using Microsoft.AspNetCore.Mvc;

namespace __NAMESPACE__.Controllers
{
    


[Route("api/[controller]")]
[ApiController]

public class HealthController :ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Healthy");
}
}