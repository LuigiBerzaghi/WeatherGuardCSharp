using Microsoft.EntityFrameworkCore;
using WeatherGuard.Models;

namespace WeatherGuard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alerta> Alertas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Alertas)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UsuarioId);
        }
    }
}
