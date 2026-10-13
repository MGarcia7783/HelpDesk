using HelpDesk.Dal;
using HelpHesk.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Bll
{
    public class CategoriaBll
    {
        private readonly CategoriaDal _categoriaDal;

        public CategoriaBll(CategoriaDal categoriaDal)
        {
            _categoriaDal = categoriaDal;
        }

        public async Task<PaginacionEntity<CategoriaEntity>> MostrarAsync(int pagina, int tamPagina, string? buscar = null)
        {
            return await _categoriaDal.MostrarAsync(pagina, tamPagina, buscar);
        }

        public async Task<List<CategoriaEntity>> MostrarCategoriaesActivosAsync()
        {
            return await _categoriaDal.MostrarCategoriasActivasAsync();
        }

        public async Task<CategoriaEntity?> ObtenerPorIdAsync(int id)
        {
            return await _categoriaDal.ObtenerPorIdAsync(id);
        }

        public async Task AgregarAsync(CategoriaEntity categoria, string usuarioApp)
        {
            await _categoriaDal.AgregarAsync(categoria, usuarioApp);
        }

        public async Task ActualizarAsync(CategoriaEntity categoria, string usuarioApp)
        {
            await _categoriaDal.ActualizarAsync(categoria, usuarioApp);
        }

        public async Task CambiarEstadoAsync(int id, bool activo, string usuarioApp)
        {
            await _categoriaDal.CambiarEstadoAsync(id, activo, usuarioApp);
        }
    }
}
