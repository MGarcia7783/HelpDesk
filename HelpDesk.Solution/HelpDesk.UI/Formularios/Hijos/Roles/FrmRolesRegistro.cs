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

namespace HelpDesk.UI.Formularios.Hijos.Roles
{
    public partial class FrmRolesRegistro : Form
    {
        private readonly RolBll _rolBll;
        private readonly int? _idRol;
        private RolEntity? _rol;

        private bool EsEdicion => _idRol.HasValue;

        public FrmRolesRegistro(RolBll rolBll)
        {
            InitializeComponent();
            _rolBll = rolBll;
            _idRol = null;

            lblTitulo.Text = "Nuevo Rol";
            lblDescripcion.Text = "Complete la información del rol.";
        }

        public FrmRolesRegistro(RolBll rolBll, int idRol)
        {
            InitializeComponent();
            _rolBll = rolBll;
            _idRol = idRol;

            lblTitulo.Text = "Editar Rol";
            lblDescripcion.Text = "Modifique la información del rol.";
        }

        #region Métodos

        private async Task CargarDatosAsync()
        {
            try
            {
                _rol = await _rolBll.ObtenerPorIdAsync(_idRol!.Value);

                if (_rol is null)
                {
                    MessageBox.Show("No se encontró el rol.");
                    DialogResult = DialogResult.Cancel;

                    Close();
                    return;
                }

                txtRol.Text = _rol.NombreRol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK);
            }
        }

        private bool ValidarControles()
        {
            errorIcon.Clear();

            return ValidationHelper.Requerido(txtRol, errorIcon, "Ingrese el nombre del rol.");
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private async void FrmRolesRegistro_Load(object sender, EventArgs e)
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
                    RolEntity nuevoRol = new();

                    nuevoRol.CambiarNombre(txtRol.Text);
                    await _rolBll.AgregarAsync(nuevoRol, UsuarioSesion.NombreUsuario);
                }
                else
                {
                    RolEntity rolEditado = new();

                    rolEditado.AsignarId(_idRol!.Value);
                    rolEditado.CambiarNombre(txtRol.Text);

                    await _rolBll.ActualizarAsync(rolEditado, UsuarioSesion.NombreUsuario);
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

        private void FrmRolesRegistro_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(this, 25);
            RedondearControlHelper.RedondearControl(panelContenido, 25);
            RedondearControlHelper.RedondearControl(panelNombre, 15);
        }
    }
}
