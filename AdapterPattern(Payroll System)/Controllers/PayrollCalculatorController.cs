using AdapterPattern_Payroll_System_.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdapterPattern_Payroll_System_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<decimal> Calculate(Employee employee) {
        var calculator=new PayrollCalculator();
            return Ok(calculator.Calculate(employee));
        }
    }
}
