using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using react_integral_server.Calculate;

namespace react_integral_server.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegralSolution : ControllerBase
{
    [HttpPost("calculate")]
    public ActionResult<double> Calculate([FromHeader] double upperInt, [FromHeader] double lowerInt, [FromHeader] double stepInt)
    {
        double result;
        CalculateIntegral calculate = new CalculateIntegral();
        result = calculate.Calculate(upperInt,lowerInt,stepInt);
        return Ok(result);
    }
}

