using Microsoft.AspNetCore.Mvc;
using WebApplication5.Database;

namespace WebApplication5.Controllers;

public class HomeController : Controller
{
    private readonly NestDbContext _context;

    public HomeController(NestDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        return View();
    }
}