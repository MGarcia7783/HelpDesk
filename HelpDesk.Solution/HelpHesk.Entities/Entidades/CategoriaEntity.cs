using System;
using System.Collections.Generic;
using System.Text;

namespace HelpHesk.Entities.Entidades
{
    public class CategoriaEntity
    {
        public int Id { get; private set; }
        public string NombreCategoria { get; private set; } = string.Empty;
        public string Descripcion { get; private set; } = string.Empty;

        public bool Activo { get; private set; }

        public string Estado => Activo ? "Activo" : "Inactivo";

        #region Constructores

        public CategoriaEntity() { }

        public CategoriaEntity(string nombreCategoria, string descripcion)
        {
            CambiarNombre(nombreCategoria);
            CambiarDescripion(descripcion);
            Activo = true;
        }

        #endregion

        #region Métodos

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarNombre(string nombreCategoria)
        {
            if (string.IsNullOrWhiteSpace(nombreCategoria))
                throw new Exception("Debe ingresar el nombre de la categoría.");

            NombreCategoria = nombreCategoria.Trim();
        }

        public void CambiarDescripion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("Debe ingresar la descripción de la categoría.");

            Descripcion = descripcion.Trim();
        }

        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }

        #endregion
    }
}
