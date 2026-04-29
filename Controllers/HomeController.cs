using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPpresentacionWeb.Models;

namespace TPpresentacionWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.g = grupo.devolverIntegrantes();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult SelectIntegrante(int dni)
    {
        Grupo g = new Grupo();
        ViewBag.id = dni;       
        ViewBag.I = g.getIntegrante(dni);
        return View("infoIntegrante");
    }
}
