using HelpDesk.Dal.Common;
using HelpHesk.Entities.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HelpDesk.Dal
{
    public class CategoriaDal
    {
        public async Task<PaginacionEntity<CategoriaEntity>> MostrarAsync(int pagina, int tamPagina, string? buscar = null)
        {
            try
            {
                PaginacionEntity<CategoriaEntity> resultado = new();

                using SqlConnection cn = Conexion.ObtenerConexion();

                // Total de registros
                using SqlCommand cmdTotal = new("sp_ContarCategorias", cn);

                cmdTotal.CommandType = CommandType.StoredProcedure;
                cmdTotal.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());

                await cn.OpenAsync();

                resultado.TotalRegistros = Convert.ToInt32(await cmdTotal.ExecuteScalarAsync());

                // Mostrar registros
                using SqlCommand cmd = new("sp_MostrarCategorias", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());
                cmd.Parameters.AddWithValue("pagina", pagina);
                cmd.Parameters.AddWithValue("tamPagina", tamPagina);

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    CategoriaEntity categoria = new();

                    categoria.AsignarId(Convert.ToInt32(dr["Id"]));
                    categoria.CambiarNombre(dr["nombreCategoria"].ToString()!);
                    categoria.CambiarDescripion(dr["descripcion"].ToString()!);
                    categoria.CambiarEstado(Convert.ToBoolean(dr["activo"]));

                    resultado.Registros.Add(categoria);
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

        public async Task<List<CategoriaEntity>> MostrarCategoriasActivasAsync()
        {
            try
            {
                List<CategoriaEntity> lista = [];

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_MostrarCategoriasActivas", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    CategoriaEntity categoria = new();

                    categoria.AsignarId(Convert.ToInt32(dr["Id"]));
                    categoria.CambiarNombre(dr["nombreCategoria"].ToString()!);

                    lista.Add(categoria);
                }
                return lista;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }

        public async Task<CategoriaEntity?> ObtenerPorIdAsync(int id)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_ObtenerCategoriaPorId", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                if (!await dr.ReadAsync())
                    return null;

                CategoriaEntity categoria = new();

                categoria.AsignarId(Convert.ToInt32(dr["Id"]));
                categoria.CambiarNombre(dr["nombreCategoria"].ToString()!);
                categoria.CambiarDescripion(dr["descripcion"].ToString()!);
                categoria.CambiarEstado(Convert.ToBoolean(dr["activo"]));

                return categoria;
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }

        public async Task AgregarAsync(CategoriaEntity categoria, string usuarioApp)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_AgregarCategoria", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd.ExecuteReaderAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }

        public async Task ActualizarAsync(CategoriaEntity categoria, string usuarioApp)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_ActualizarCategoria", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", categoria.Id);
                cmd.Parameters.AddWithValue("@nombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd.ExecuteReaderAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }

        public async Task CambiarEstadoAsync(int id, bool activo, string usuarioApp)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_CambiarEstadoCategoria", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd.ExecuteReaderAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelper.TraducirError(ex);
            }
        }
    }
}
