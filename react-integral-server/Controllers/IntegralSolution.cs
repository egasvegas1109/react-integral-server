using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using react_integral_server.Calculate;
using react_integral_server.Models;

namespace react_integral_server.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegralSolution : ControllerBase
{
    [HttpPost("calculate")]
    public ActionResult<double> Calculate([FromBody] IntegralInput integralInput)
    {
        double result;
        CalculateIntegral calculate = new CalculateIntegral();
        result = calculate.Calculate(integralInput.B, integralInput.A, integralInput.N);
        return result;
    }
}

