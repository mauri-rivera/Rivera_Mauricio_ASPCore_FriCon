using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriCon.Models;

namespace PriCon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<Mascota> listaMascotas = _context.Mascotas.ToList();

        Mascota mascotaPerro = new Mascota()
        {
            MascotaId = 1,
            Nombre = "Tommy",
            Tipo = Tipos.Perro,
            Edad = 7,
            TienePelo = true
        };

        Mascota mascotaGato = new Mascota()
        {
            MascotaId = 2,
            Nombre = "Lupin",
            Tipo = Tipos.Gato,
            Edad = 3,
            TienePelo = true
        };

        listaMascotas.Add(mascotaPerro);
        listaMascotas.Add(mascotaGato);

        foreach (var nom in listaMascotas)
        {
            Console.WriteLine($"{nom.MascotaId} {nom.Nombre} {nom.Tipo} {nom.Edad} {nom.TienePelo}");
        }

        return View(listaMascotas);
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
}
