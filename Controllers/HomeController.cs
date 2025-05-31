using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Take.Models;

namespace Projeto_Take.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Contato()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Servicos()
    {
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
