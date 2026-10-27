using HelpDesk.Dal;
using HelpHesk.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Bll
{
    public class TicketBll
    {
        private readonly TicketDal _ticketDal;

        public TicketBll(TicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public async Task<PaginacionEntity<TicketEntity>> MostrarAsync(int pagina = 1, int tamPagina = 10, string? buscar = null, int? idUsuarioSolicitante = null, bool modoAdmin = false)
        {
            return await _ticketDal.MostrarAsync(pagina, tamPagina, buscar, idUsuarioSolicitante, modoAdmin);
        }

        public async Task<string> AgregarAsync(TicketEntity ticket, string usuarioApp)
        {
            return await _ticketDal.AgregarAsync(ticket, usuarioApp);
        }
    }
}
