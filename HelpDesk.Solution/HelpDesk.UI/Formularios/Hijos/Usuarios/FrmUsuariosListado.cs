using HelpDesk.Bll;
using HelpDesk.Dal;
using HelpDesk.UI.Formularios.Base;
using HelpDesk.UI.Formularios.Hijos.Roles;
using HelpDesk.UI.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Hijos.Usuarios
{
    public partial class FrmUsuariosListado : FrmBaseListado
    {
        private readonly UsuarioBll _usuarioBll;
        private readonly RolBll _rolBll;

        public FrmUsuariosListado()
        {
            InitializeComponent();

            _usuarioBll = new UsuarioBll(new UsuarioDal());
            _rolBll = new RolBll(new RolDal());
        }

        protected override async Task MostrarDatosAsync(int pagina, int tamPagina, string? buscar = null)
        {
            try
            {
                var resultado = await _usuarioBll.MostrarAsync(pagina, tamPagina, buscar);

                dgvListado.DataSource = null;
                dgvListado.DataSource = resultado.Registros;

                PaginaActual = resultado.PaginaActual;
                TamPagina = resultado.TamPagina;
                TotalRegistros = resultado.TotalRegistros;
                TotalPaginas = resultado.TotalPaginas;

                ActualizarPaginacion();
                MostrarEstadoVacio(resultado.Registros.Count > 0);

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dgvListado.Columns.Count == 0)
                return;

            // Columnas ocultas
            dgvListado.Columns["Id"]!.Visible = false;
            dgvListado.Columns["IdRol"]!.Visible = false;
            dgvListado.Columns["Activo"]!.Visible = false;

            // Encabezados
            dgvListado.Columns["NombreCompleto"]!.HeaderText = "Nombre Completo";
            dgvListado.Columns["NombreUsuario"]!.HeaderText = "Usuario";
            dgvListado.Columns["CorreoElectronico"]!.HeaderText = "Email";
            dgvListado.Columns["NombreRol"]!.HeaderText = "Rol";
            dgvListado.Columns["Estado"]!.HeaderText = "Estado";

            // Tamaños
            dgvListado.Columns["NombreCompleto"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListado.Columns["NombreUsuario"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListado.Columns["CorreoElectronico"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListado.Columns["NombreRol"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            AjustarColumnas("Estado");
        }

        protected override Form CrearFormularioAccionPrincipal()
        {
            return new FrmUsuariosRegistro(_usuarioBll, _rolBll);
        }

        protected override Form? CrearFormularioAccionSecundaria(int id)
        {
            return new FrmUsuariosRegistro(_usuarioBll, _rolBll, id);
        }

        protected override int? ObtenerIdSeleccionado()
        {
            if (dgvListado.CurrentRow == null)
                return null;

            return Convert.ToInt32(dgvListado.CurrentRow.Cells["Id"].Value);
        }

        protected override async Task DesactivarAsync()
        {
            int? id = ObtenerIdSeleccionado();

            if (id == null)
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
                await _usuarioBll.CambiarEstadoAsync(id.Value, !activo, UsuarioSesion.NombreUsuario);
                await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
