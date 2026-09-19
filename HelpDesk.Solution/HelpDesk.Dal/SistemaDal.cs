using HelpDesk.Dal.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HelpDesk.Dal
{
    public class SistemaDal
    {
        public async Task CrearAdministradorInicialAsync()
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_CrearAdministradorInicial", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
