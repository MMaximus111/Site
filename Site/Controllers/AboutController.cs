using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class AboutController : Controller
{
    public AboutController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}