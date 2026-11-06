using System;
using System.Collections.Generic;
using System.Text;

namespace HelpHesk.Entities.Dto
{
    public class DashboardResumenDto
    {
        public int TicketsCreadosHoy { get; set; }
        public int TicketsSinAsignar { get; set; }
        public int TicketsCriticos { get; set; }
        public int PromedioMinutos{ get; set; }
        public int TicketsCerradosHoy { get; set; }
    }
}
