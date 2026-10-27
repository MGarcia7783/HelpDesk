using System;
using System.Collections.Generic;
using System.Text;

namespace HelpHesk.Entities.Entidades
{
    public class TicketEntity
    {
        public int Id { get; private set; }
        public string NumeroTicket { get; private set; } = string.Empty;
        public DateTime FechaCreacion { get; private set; }
        public DateTime? FechaUltimaActualizacion { get; private set; }
        public string Asunto { get; private set; } = string.Empty;
        public string Descripcion { get; private set; } = string.Empty;
        public int IdUsuarioSolicitante { get; private set; }
        public string NombreSolicitante { get; private set; } = string.Empty;
        public int? IdTecnicoAsignado { get; private set; }
        public string NombreTecnico { get; private set; } = string.Empty;
        public int IdCategoria { get; private set; }
        public string NombreCategoria { get; private set; } = string.Empty;
        public string Prioridad { get; private set; } = string.Empty;
        public string Estado { get; private set; } = string.Empty;
        public DateTime? FechaCierre { get; private set; }

        #region Constructores

        public TicketEntity() { }

        public TicketEntity(string asunto, string descripcion, int idUsuarioSolicitante, int idCategoria, string prioridad)
        {
            CambiarAsunto(asunto);
            CambiarDescripcion(descripcion);
            CambiarUsuarioSolicitante(idUsuarioSolicitante);
            CambiarCategoria(idCategoria);
            CambiarPrioridad(prioridad);
        }
        #endregion

        #region Métodos

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarNumeroTicket(string numeroTikect)
        {
            NumeroTicket = numeroTikect;
        }

        public void CambiarFechaCreacion(DateTime fecha)
        {
            FechaCreacion = fecha;
        }

        public void CambiarFechaUltimaActualizacion(DateTime? fecha)
        {
            FechaUltimaActualizacion = fecha;
        }

        public void CambiarAsunto(string asunto)
        {
            if (string.IsNullOrWhiteSpace(asunto))
                throw new Exception("Debe ingresar el asunto");

            Asunto = asunto.Trim();
        }

        public void CambiarDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("Debe ingresar la descripción");

            Descripcion = descripcion.Trim();
        }

        public void CambiarUsuarioSolicitante(int idUsuario)
        {
            if (idUsuario <= 0)
                throw new Exception("Debe seleccionar el usuario solicitante");

            IdUsuarioSolicitante = idUsuario;
        }

        public void CambiarNombreSolicitante(string nombre)
        {
            NombreSolicitante = nombre.Trim();
        }

        public void CambiarNombreTecnico(string nombre)
        {
            NombreTecnico = nombre.Trim();
        }

        public void CambiarTecnicoAsignado(int? idTecnico)
        {
            IdTecnicoAsignado = idTecnico;
        }

        public void CambiarCategoria(int idCategoria)
        {
            if (idCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría");

            IdCategoria = idCategoria;
        }

        public void CambiarNombreCategoria(string nombre)
        {
            NombreCategoria = nombre.Trim();
        }

        public void CambiarPrioridad(string prioridad)
        {
            string[] prioridades =
            {
                "Baja",
                "Media",
                "Alta",
                "Crítica"
            };

            if (!prioridad.Contains(prioridad))
                throw new Exception("La prioridad no es válida.");

            Prioridad = prioridad;
        }

        public void CambiarEstado(string estado)
        {
            string[] estados =
            {
                "Abierto",
                "En proceso",
                "Cerrado",
                "Cancelado"
            };

            if (!estado.Contains(estado))
                throw new Exception("El estado no es válido.");

            Estado = estado;
        }

        public void CambiarFechaCierre(DateTime? fecha)
        {
            FechaCierre = fecha;
        }

        #endregion
    }
}
