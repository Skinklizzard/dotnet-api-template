using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class HealthController :ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Healthy");
}