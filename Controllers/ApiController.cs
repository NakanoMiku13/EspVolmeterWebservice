using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VolmeterWebService.Models;

namespace VolmeterWebService.Controllers;
[ApiController]
[Route("api/")]
public class ApiController : ControllerBase
{
    private readonly ILogger<ApiController> _logger;

    public ApiController(ILogger<ApiController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [Route("Test")]
    public IActionResult GetOutput(){
        Console.WriteLine("Here");
        return Ok("This is a test");
    }
}
