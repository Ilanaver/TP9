using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class Account : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}