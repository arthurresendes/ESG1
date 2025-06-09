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

    public IActionResult Login()
    {
        return View();
    }
    [HttpGet]
    public IActionResult CadastroProfi()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CadastroProfi(CadastroCrud form)
    {

        if (form.registerSpecialization == "Nutricao")
        {
            RepositorioForms.AddFormulario(form);
            return RedirectToAction("ProfiNutricao");
        }
        else if (form.registerSpecialization == "Fisico")
        {
            RepositorioForms.AddFormulario(form);
            return RedirectToAction("ProfiFisico");
        }
        else if (form.registerSpecialization == "Mental")
        {
            RepositorioForms.AddFormulario(form);
            return RedirectToAction("ProfiMental");
        }
        else if (form.registerSpecialization == "Financeiro")
        {
            RepositorioForms.AddFormulario(form);
            return RedirectToAction("ProfiFinanceiro");
        }

        return Redirect("Index");


    }
    [HttpPost]
    public IActionResult Excluir(int id)
    {
        RepositorioForms.RemoveFormulario(id);
        return RedirectToAction("Index");

    }

    public IActionResult Fisico()
    {
        return View();
    }
    public IActionResult Financeiro()
    {
        return View();
    }
    public IActionResult Mental()
    {
        return View();
    }
    public IActionResult Nutricao()
    {
        return View();
    }
    public IActionResult ProfiFisico()
    {
        return View(RepositorioForms.Formularios);
    }
    public IActionResult ProfiFinanceiro()
    {
        return View(RepositorioForms.Formularios);
    }
    public IActionResult ProfiMental()
    {
        return View(RepositorioForms.Formularios);
    }
    public IActionResult ProfiNutricao()
    {
        return View(RepositorioForms.Formularios);
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
