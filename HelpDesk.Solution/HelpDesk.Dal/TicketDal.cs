using HelpDesk.Dal.Common;
using HelpHesk.Entities.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HelpDesk.Dal
{
    public class TicketDal
    {
        public async Task<PaginacionEntity<TicketEntity>> MostrarAsync(int pagina = 1, int tamPagina = 10, string? buscar = null, int? idUsuarioSolicitante = null, bool modoAdmin = false)
        {
            try
            {
                PaginacionEntity<TicketEntity> resultado = new();

                using SqlConnection cn = Conexion.ObtenerConexion();
                await cn.OpenAsync();

                // Total de registros
                using SqlCommand cmdTotal = new("sp_ContarTickets", cn);
                cmdTotal.CommandType = CommandType.StoredProcedure;

                cmdTotal.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());
                cmdTotal.Parameters.AddWithValue("@idUsuarioSolicitante", idUsuarioSolicitante.HasValue ? idUsuarioSolicitante.Value : DBNull.Value);
                cmdTotal.Parameters.AddWithValue("@modoAdmin", modoAdmin);

                resultado.TotalRegistros = Convert.ToInt32(await cmdTotal.ExecuteScalarAsync());

                // Mostrar registros
                using SqlCommand cmd = new("sp_MostrarTickets", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());
                cmd.Parameters.AddWithValue("@idUsuarioSolicitante", idUsuarioSolicitante.HasValue ? idUsuarioSolicitante.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@modoAdmin", modoAdmin);
                cmd.Parameters.AddWithValue("@pagina", pagina);
                cmd.Parameters.AddWithValue("@tamPagina", tamPagina);

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    TicketEntity ticket = new();

                    ticket.AsignarId(Convert.ToInt32(dr["idTicket"]));
                    ticket.CambiarNumeroTicket(dr["numeroTicket"].ToString()!);
                    ticket.CambiarFechaCreacion(Convert.ToDateTime(dr["fechaCreacion"].ToString()!));
                    ticket.CambiarAsunto(dr["asunto"].ToString()!);
                    ticket.CambiarNombreSolicitante(dr["solicitante"].ToString()!);

                    if (dr["tecnico"] != DBNull.Value)
                        ticket.CambiarNombreTecnico(dr["tecnico"].ToString()!);

                    ticket.CambiarNombreCategoria(dr["nombreCategoria"].ToString()!);
                    ticket.CambiarPrioridad(dr["prioridad"].ToString()!);
                    ticket.CambiarEstado(dr["estado"].ToString()!);

                    resultado.Registros.Add(ticket);
                }

                resultado.PaginaActual = pagina;
                resultado.TamPagina = tamPagina;

                return resultado;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }

        public async Task<string> AgregarAsync(TicketEntity ticket, string usuarioApp)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_AgregarTicket", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@asunto", ticket.Asunto);
                cmd.Parameters.AddWithValue("@descripcion", ticket.Descripcion);
                cmd.Parameters.AddWithValue("@idUsuarioSolicitante", ticket.IdUsuarioSolicitante);
                cmd.Parameters.AddWithValue("@idCategoria", ticket.IdCategoria);
                cmd.Parameters.AddWithValue("@prioridad", ticket.Prioridad);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                return Convert.ToString(await cmd.ExecuteScalarAsync())!;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }
    }
}
