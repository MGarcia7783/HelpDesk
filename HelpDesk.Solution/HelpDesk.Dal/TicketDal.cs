using HelpDesk.Dal.Common;
using HelpHesk.Entities.Dto;
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

        /// <summary>
        /// Obtiene un registro por Id
        /// </summary>
        public async Task<TicketEntity?> ObtenerPorIdAsync(int id)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();

                using SqlCommand cmd = new("sp_ObtenerTicketPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                if (!await dr.ReadAsync())
                    return null;

                TicketEntity ticket = new();

                ticket.AsignarId(Convert.ToInt32(dr["idTicket"]));
                ticket.CambiarNumeroTicket(dr["numeroTicket"].ToString()!);

                ticket.CambiarFechaCreacion(
                    Convert.ToDateTime(dr["fechaCreacion"]));

                if (dr["fechaUltimaActualizacion"] != DBNull.Value)
                    ticket.CambiarFechaUltimaActualizacion(Convert.ToDateTime(dr["fechaUltimaActualizacion"]));

                ticket.CambiarAsunto(dr["asunto"].ToString()!);
                ticket.CambiarDescripcion(dr["descripcion"].ToString()!);
                ticket.CambiarUsuarioSolicitante(Convert.ToInt32(dr["idUsuarioSolicitante"]));
                ticket.CambiarNombreSolicitante(dr["nombreSolicitante"].ToString()!);
                ticket.CambiarCategoria(Convert.ToInt32(dr["idCategoria"]));
                ticket.CambiarNombreCategoria(dr["nombreCategoria"].ToString()!);
                ticket.CambiarCategoria(Convert.ToInt32(dr["idCategoria"]));

                if (dr["idTecnicoAsignado"] != DBNull.Value)
                    ticket.CambiarTecnicoAsignado(Convert.ToInt32(dr["idTecnicoAsignado"]));

                if (dr["nombreTecnico"] != DBNull.Value)
                    ticket.CambiarNombreTecnico(dr["nombreTecnico"].ToString()!);

                ticket.CambiarPrioridad(dr["prioridad"].ToString()!);
                ticket.CambiarEstado(dr["estado"].ToString()!);

                if (dr["fechaCierre"] != DBNull.Value)
                    ticket.CambiarFechaCierre(Convert.ToDateTime(dr["fechaCierre"]));

                return ticket;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }


        /// <summary>
        /// Obtener técnicos activos
        /// </summary>
        public async Task<List<UsuarioEntity>> ObtenerTecnicosActivosAsync()
        {
            try
            {
                List<UsuarioEntity> lista = [];

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_MostrarTecnicosActivos", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    UsuarioEntity usuario = new();

                    usuario.AsignarId(Convert.ToInt32(dr["Id"]));
                    usuario.CambiarNombreCompleto(dr["nombreCompleto"].ToString()!);

                    lista.Add(usuario);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }


        /// <summary>
        /// Gestionar un ticket (Asignar técnico y cambiar estado)
        /// </summary>
        public async Task GestionarAsync(int idTicket, int? idTecnicoAsignado, string estado, string usuarioApp)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_GestionarTicket", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idTicket);
                cmd.Parameters.AddWithValue("@idTecnicoAsignado", idTecnicoAsignado.HasValue
                    ? idTecnicoAsignado.Value
                    : DBNull.Value);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }

        public async Task<DashboardAdminDto> ObtenerDashboardAdminAsync()
        {
            try
            {
                DashboardAdminDto dashboard = new();

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_DashboardAdmin", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                await cn.OpenAsync();
                
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                // Tickets por estado
                while(await dr.ReadAsync())
                {
                    dashboard.TicketsPorEstado.Add(new DashboardEstadoDto
                    {
                        Estado = dr["estado"].ToString()!,
                        Total = Convert.ToInt32(dr["total"])
                    });
                }

                // Tickets por técnico
                await dr.NextResultAsync();

                while(await dr.ReadAsync())
                {
                    dashboard.TicketsPorTecnico.Add(new DashboardTecnicoDto
                    {
                        Tecnico = dr["tecnico"].ToString()!,
                        TotalTickets = Convert.ToInt32(dr["totalTickets"])
                    });
                }

                // Tickets críticos
                await dr.NextResultAsync();

                while(await dr.ReadAsync())
                {
                    dashboard.TicketsCriticos.Add(new DashboardCriticoDto
                    {
                        NumeroTicket = dr["numeroTicket"].ToString()!,
                        Asunto = dr["asunto"].ToString()!,
                        Categoria = dr["categoria"].ToString()!,
                        Tecnico = dr["tecnico"].ToString()!,
                        Estado = dr["estado"].ToString()!,
                        FechaCreacion = Convert.ToDateTime(dr["fechaCreacion"].ToString())!,
                        TiempoPendiente = dr["tiempoPendiente"].ToString()!,
                    });
                }

                // Resumen del día
                await dr.NextResultAsync();

                while(await dr.ReadAsync())
                {
                    dashboard.Indicadores = new DashboardResumenDto
                    {
                        TicketsCreadosHoy = Convert.ToInt32(dr["ticketsCreadosHoy"].ToString())!,
                        TicketsSinAsignar = Convert.ToInt32(dr["ticketsSinAsignar"].ToString())!,
                        TicketsCriticos = Convert.ToInt32(dr["ticketsCriticos"].ToString())!,
                        TicketsCerradosHoy = Convert.ToInt32(dr["ticketsCerradosHoy"].ToString())!
                    };
                }

                return dashboard;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }
    }
}
