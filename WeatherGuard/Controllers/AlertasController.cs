using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherGuard.Data;
using WeatherGuard.Models;
using System;
using System.Threading.Tasks;


namespace WeatherGuard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlertasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var alertas = await _context.Alertas.Include(a => a.Usuario).ToListAsync();
            return Ok(alertas);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Alerta alerta)
        {
            alerta.DataCriacao = DateTime.Now;
            _context.Alertas.Add(alerta);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Index), new { id = alerta.Id }, alerta);
        }
    }
}
