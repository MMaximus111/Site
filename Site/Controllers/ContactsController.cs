namespace Site.Controllers;

public class ContactsController : Controller
{
    public ContactsController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}