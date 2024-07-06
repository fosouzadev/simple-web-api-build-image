using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    private readonly ILogger<SumController> _logger;

    public SumController(ILogger<SumController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Sum/Number1/{number1}/Number2/{number2}")]
    public IActionResult Get(long number1, long number2)
    {
        long sum = number1 + number2;

        return Ok(new
        {
            Number1 = number1,
            Number2 = number2,
            Sum = sum
        });
    }
}