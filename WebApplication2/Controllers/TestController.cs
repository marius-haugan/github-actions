using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}