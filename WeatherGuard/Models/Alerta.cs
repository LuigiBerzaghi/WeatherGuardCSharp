using System;

namespace WeatherGuard.Models
{
    public class Alerta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
