using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HelloController: Controller
{
    public IActionResult Index()
    {
        return View("HelloForm");
    }

    public IActionResult Hello(User user)
    {
        return View("HelloUser", user);
    }
}