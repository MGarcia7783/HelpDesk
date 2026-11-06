using System;
using System.Collections.Generic;
using System.Text;

namespace HelpHesk.Entities.Dto
{
    public class DashboardCriticoDto
    {
        public string NumeroTicket { get; set; } = string.Empty;
        public string Asunto { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Tecnico { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string TiempoPendiente { get; set; } = string.Empty;
    }
}
