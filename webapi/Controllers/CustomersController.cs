using Microsoft.AspNetCore.Mvc;
using webapi.Models.Customer;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{

    [HttpPost("register")]
    public ActionResult RegisterCustomer()
    {
        return Ok();
    }

    [HttpPost("login")]
    public ActionResult CustomerLogin(LoginCustomer customer)
    {
        return Ok();
    }

}
