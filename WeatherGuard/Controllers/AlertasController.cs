using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherGuard.Data;
using WeatherGuard.Models;

namespace WeatherGuard.Controllers
{
    public class AlertasController : Controller
    {
        private readonly AppDbContext _context;

        public AlertasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var alertas = await _context.Alertas.Include(a => a.Usuario).ToListAsync();
            return View(alertas);
        }

        public IActionResult Create()
        {
            ViewBag.Usuarios = _context.Usuarios.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Alerta alerta)
        {
            if (ModelState.IsValid)
            {
                alerta.DataCriacao = DateTime.Now;
                _context.Add(alerta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Usuarios = _context.Usuarios.ToList();
            return View(alerta);
        }
    }
}
