using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class ContactsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}