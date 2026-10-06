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

namespace HelpDesk.UI.Formularios.Hijos.Usuarios
{
    public partial class FrmUsuariosRegistro : Form
    {
        private readonly UsuarioBll _usuarioBll;
        private readonly RolBll _rolBll;
        private readonly int? _idUsuario;

        private UsuarioEntity? _usuario;

        private bool EsEdicion => _idUsuario.HasValue;

        #region Constructores

        // Constructor para nuevo registro
        public FrmUsuariosRegistro(UsuarioBll usuarioBll, RolBll rolBll)
        {
            InitializeComponent();
            _usuarioBll = usuarioBll;
            _rolBll = rolBll;
            _idUsuario = null;

            lblTitulo.Text = "Nuevo Usuario";
            lblDescripcion.Text = "Complete la información del usuario.";
        }

        // Constructor para edición
        public FrmUsuariosRegistro(UsuarioBll usuarioBll, RolBll rolBll, int idUsuario)
        {
            InitializeComponent();
            _usuarioBll = usuarioBll;
            _rolBll = rolBll;
            _idUsuario = idUsuario;

            txtUsuario.Enabled = false;
            txtContra.Enabled = false;

            lblTitulo.Text = "Editar Usuario";
            lblDescripcion.Text = "Complete la información del usuario.";
        }

        #endregion

        #region Métodos

        private async Task CargarRolesAsync()
        {
            var roles = await _rolBll.MostrarRolesActivosAsync();

            cboRoles.DataSource = roles;
            cboRoles.DisplayMember = "NombreRol";
            cboRoles.ValueMember = "Id";
            cboRoles.SelectedIndex = -1;
        }

        private async Task CargarDatosAsync()
        {
            try
            {
                if (!_idUsuario.HasValue)
                    return;

                _usuario = await _usuarioBll.ObtenerPorIdAsync(_idUsuario!.Value);

                if (_usuario is null)
                {
                    MessageBox.Show("No se encontró el usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Cancel;

                    Close();
                    return;
                }

                txtNombreCompleto.Text = _usuario.NombreCompleto;
                txtUsuario.Text = _usuario.NombreUsuario;
                txtCorreo.Text = _usuario.CorreoElectronico;
                cboRoles.SelectedValue = _usuario.IdRol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarControles()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!ValidationHelper.Requerido(txtNombreCompleto, errorIcon, "Ingrese el nombre completo."))
                valido = false;

            if (!EsEdicion)
            {
                if (!ValidationHelper.Requerido(txtUsuario, errorIcon, "Ingrese el nombre de usuario."))
                    valido = false;
            }

            if (!ValidationHelper.Requerido(txtCorreo, errorIcon, "Ingrese el correo electrónico."))
                valido = false;

            if (!ValidationHelper.EmailValido(txtCorreo, errorIcon))
                valido = false;

            if (!EsEdicion)
            {
                if (!ValidationHelper.Requerido(txtContra, errorIcon, "Ingrese la contraseña."))
                    valido = false;
            }

            return valido;
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region Eventos

        private async void FrmUsuariosRegistro_Load(object sender, EventArgs e)
        {
            await CargarRolesAsync();

            if (EsEdicion)
                await CargarDatosAsync();
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarControles())
                return;

            try
            {
                string usuarioApp = UsuarioSesion.NombreUsuario;

                if (!EsEdicion)
                {
                    UsuarioEntity nuevoUsuario = new();

                    nuevoUsuario.CambiarNombreCompleto(txtNombreCompleto.Text);
                    nuevoUsuario.CambiarNombreUsuario(txtUsuario.Text);
                    nuevoUsuario.CambiarCorreo(txtCorreo.Text);
                    nuevoUsuario.CambiarRol(Convert.ToInt32(cboRoles.SelectedValue));

                    await _usuarioBll.AgregarAsync(nuevoUsuario, txtContra.Text, usuarioApp);
                }
                else
                {
                    UsuarioEntity usuarioEditado = new();

                    usuarioEditado.AsignarId(_idUsuario!.Value);
                    usuarioEditado.CambiarNombreCompleto(txtNombreCompleto.Text);
                    usuarioEditado.CambiarCorreo(txtCorreo.Text);
                    usuarioEditado.CambiarRol(Convert.ToInt32(cboRoles.SelectedValue));

                    await _usuarioBll.ActualizarAsync(usuarioEditado, usuarioApp);
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

        private void FrmUsuariosRegistro_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(this, 25);
            RedondearControlHelper.RedondearControl(panelContenido, 25);
            RedondearControlHelper.RedondearControl(panelNombre, 15);
            RedondearControlHelper.RedondearControl(panelUsuario, 15);
            RedondearControlHelper.RedondearControl(panelCorreo, 15);
            RedondearControlHelper.RedondearControl(panelRol, 15);
            RedondearControlHelper.RedondearControl(panelContra, 15);
        }

        #endregion
    }
}
