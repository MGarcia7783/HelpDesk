using HelpDesk.Bll;
using HelpDesk.Dal;
using HelpDesk.UI.Formularios.Base;
using HelpDesk.UI.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Hijos.Roles
{
    public partial class FrmRolesListado : FrmBaseListado
    {
        private readonly RolBll _rolBll;

        public FrmRolesListado()
        {
            InitializeComponent();

            _rolBll = new RolBll(new RolDal());
        }

        protected override async Task MostrarDatosAsync(int pagina, int tamPagina, string? buscar = null)
        {
            try
            {
                var resultado = await _rolBll.MostrarAsync(pagina, tamPagina, buscar);

                dgvListado.DataSource = null;
                dgvListado.DataSource = resultado.Registros;

                PaginaActual = resultado.PaginaActual;
                TamPagina = resultado.TamPagina;
                TotalRegistros = resultado.TotalRegistros;
                TotalPaginas = resultado.TotalPaginas;

                ActualizarPaginacion();
                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvListado.Columns["Id"]!.Visible = false;
            dgvListado.Columns["NombreRol"]!.HeaderText = "Nombre del Rol";
            dgvListado.Columns["Activo"]!.Visible = false;
            dgvListado.Columns["Estado"]!.HeaderText = "Estado";
            dgvListado.Columns["NombreRol"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            AjustarColumnas("Estado");
        }

        protected override Form CrearFormularioAccionPrincipal()
        {
            return new FrmRolesRegistro(_rolBll);
        }

        protected override Form? CrearFormularioAccionSecundaria(int id)
        {
            return new FrmRolesRegistro(_rolBll, id);
        }

        protected override int? ObtenerIdSeleccionado()
        {
            if(dgvListado.CurrentRow == null)
                return null;

            return Convert.ToInt32(dgvListado.CurrentRow.Cells["Id"].Value);
        }

        protected override async Task DesactivarAsync()
        {
            int? id = ObtenerIdSeleccionado();

            if(id == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Información", MessageBoxButtons.OK);
                return;
            }

            bool activo = Convert.ToBoolean(dgvListado.CurrentRow!.Cells["Activo"].Value);

            string accion = activo ? "desactivar" : "activar";

            DialogResult respuesta = MessageBox.Show($"¿Desea {accion} este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                await _rolBll.CambiarEstadoAsync(id.Value, !activo, UsuarioSesion.NombreUsuario);
                await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
