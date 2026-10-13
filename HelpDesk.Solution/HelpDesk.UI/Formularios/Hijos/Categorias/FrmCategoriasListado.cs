using HelpDesk.Bll;
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

namespace HelpDesk.UI.Formularios.Hijos.Categorias
{
    public partial class FrmCategoriasListado : FrmBaseListado
    {
        private readonly CategoriaBll _categoriaBll;

        public FrmCategoriasListado()
        {
            InitializeComponent();

            _categoriaBll = new CategoriaBll(new Dal.CategoriaDal());
        }

        protected override async Task MostrarDatosAsync(int pagina, int tamPagina, string? buscar = null)
        {
            try
            {
                var resultado = await _categoriaBll.MostrarAsync(pagina, tamPagina, buscar);

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
            if (dgvListado.Columns.Count == 0)
                return;

            dgvListado.Columns["Id"]!.Visible = false;
            dgvListado.Columns["NombreCategoria"]!.HeaderText = "Nombre de la Categoría";
            dgvListado.Columns["descripcion"]!.HeaderText = "Descripción de la Categoría";
            dgvListado.Columns["Activo"]!.Visible = false;
            dgvListado.Columns["Estado"]!.HeaderText = "Estado";

            AjustarColumnas("NombreCategoria", "Estado");
        }

        protected override Form CrearFormularioAccionPrincipal()
        {
            return new FrmCategoriaRegistro(_categoriaBll);
        }

        protected override Form? CrearFormularioAccionSecundaria(int id)
        {
            return new FrmCategoriaRegistro(_categoriaBll, id);
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
                await _categoriaBll.CambiarEstadoAsync(id.Value, !activo, UsuarioSesion.NombreUsuario);
                await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
