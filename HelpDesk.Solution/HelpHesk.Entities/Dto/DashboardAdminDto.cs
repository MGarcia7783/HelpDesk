using System;
using System.Collections.Generic;
using System.Text;

namespace HelpHesk.Entities.Dto
{
    public class DashboardAdminDto
    {
        public List<DashboardEstadoDto> TicketsPorEstado { get; set; } = [];
        public List<DashboardTecnicoDto> TicketsPorTecnico { get; set; } = [];
        public List<DashboardCriticoDto> TicketsCriticos { get; set; } = [];
        public DashboardResumenDto Indicadores { get; set; } = new();
    }
}
