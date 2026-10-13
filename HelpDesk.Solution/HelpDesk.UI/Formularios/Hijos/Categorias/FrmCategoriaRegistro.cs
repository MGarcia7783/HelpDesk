using HelpDesk.Bll;
using HelpDesk.UI.Helpers;
using HelpDesk.UI.Seguridad;
using HelpHesk.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Hijos.Categorias
{
    public partial class FrmCategoriaRegistro : Form
    {
        private readonly CategoriaBll _categoriaBll;
        private readonly int? _idCategoria;
        private CategoriaEntity? _categoria;

        private bool EsEdicion => _idCategoria.HasValue;

        #region Constructores

        public FrmCategoriaRegistro(CategoriaBll categoriaBll)
        {
            InitializeComponent();

            _categoriaBll = categoriaBll;

            lblTitulo.Text = "Nueva Categoría";
            lblDescripcion.Text = "Complete la información de la categoría";
        }

        public FrmCategoriaRegistro(CategoriaBll categoriaBll, int idCategoria)
        {
            InitializeComponent();

            _categoriaBll = categoriaBll;
            _idCategoria = idCategoria;

            lblTitulo.Text = "Editar Categoría";
            lblDescripcion.Text = "Modifique la información de la categoría";
        }

        #endregion

        #region Métodos

        private async Task CargarDatosAsync()
        {
            try
            {
                if (!_idCategoria.HasValue)
                    return;

                _categoria = await _categoriaBll.ObtenerPorIdAsync(_idCategoria!.Value);

                if (_categoria is null)
                {
                    MessageBox.Show("No se encontró la categoria.", "Información");
                    DialogResult = DialogResult.Cancel;

                    Close();
                    return;
                }

                txtNombreCategoria.Text = _categoria.NombreCategoria;
                txtDescripcion.Text = _categoria.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK);
            }
        }

        private bool ValidarControles()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!ValidationHelper.Requerido(txtNombreCategoria, errorIcon, "Ingrese el nombre de la categoría."))
                valido = false;

            if (!ValidationHelper.Requerido(txtDescripcion, errorIcon, "Ingrese la descripción de la categoría."))
                valido = false;

            return valido;
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region Eventos

        private async void FrmCategoriaRegistro_Load(object sender, EventArgs e)
        {
            if (EsEdicion)
                await CargarDatosAsync();
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarControles())
                return;

            try
            {
                if (!EsEdicion)
                {
                    CategoriaEntity nuevoCategoria = new();

                    nuevoCategoria.CambiarNombre(txtNombreCategoria.Text);
                    nuevoCategoria.CambiarDescripion(txtDescripcion.Text);

                    await _categoriaBll.AgregarAsync(nuevoCategoria, UsuarioSesion.NombreUsuario);
                }
                else
                {
                    CategoriaEntity categoriaEditado = new();

                    categoriaEditado.AsignarId(_idCategoria!.Value);
                    categoriaEditado.CambiarNombre(txtNombreCategoria.Text);
                    categoriaEditado.CambiarDescripion(txtDescripcion.Text);

                    await _categoriaBll.ActualizarAsync(categoriaEditado, UsuarioSesion.NombreUsuario);
                }

                MessageBox.Show("Registro guardado correctamente.", "Información", MessageBoxButtons.OK);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencíón", MessageBoxButtons.OK);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void FrmCategoriaRegistro_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(this, 25);
            RedondearControlHelper.RedondearControl(panelContenido, 25);
            RedondearControlHelper.RedondearControl(panelNombre, 15);
            RedondearControlHelper.RedondearControl(panelDescripcion, 15);
        }

        #endregion
    }
}
