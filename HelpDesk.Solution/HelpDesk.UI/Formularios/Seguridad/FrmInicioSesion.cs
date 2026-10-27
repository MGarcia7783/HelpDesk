using HelpDesk.Bll;
using HelpDesk.Dal;
using HelpDesk.UI.Formularios.Hijos.Usuarios;
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

namespace HelpDesk.UI.Formularios.Seguridad
{
    public partial class FrmInicioSesion : Form
    {
        private readonly UsuarioBll _usuarioBll;
        private readonly RolBll _rolBll;

        public FrmInicioSesion()
        {
            InitializeComponent();

            _usuarioBll = new UsuarioBll(new UsuarioDal());
            _rolBll = new RolBll(new RolDal());
        }

        private bool ValidarControles()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!ValidationHelper.Requerido(txtUsuario, errorIcon, "Ingrese el usuario"))
                valido = false;

            if (!ValidationHelper.Requerido(txtClave, errorIcon, "Ingrese la contraseña"))
                valido = false;

            return valido;
        }

        private void FrmInicioSesion_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(this, 25);
            RedondearControlHelper.RedondearControl(panelContenido, 25);
            RedondearControlHelper.RedondearControl(buttonIngresar, 15);
            RedondearControlHelper.RedondearControl(panelClave, 15);
            RedondearControlHelper.RedondearControl(panelServidor, 15);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Cerrar la aplicación con ESC
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }

            // Si se preciona ENTER estando en txtClave
            if (keyData == Keys.Enter && ActiveControl == txtClave)
            {
                buttonIngresar.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarControles())
                return;

            try
            {
                UsuarioEntity usuario = await _usuarioBll.AutenticarAsync(txtUsuario.Text, txtClave.Text);

                UsuarioSesion.IniciarSesion(usuario);

                Hide();

                if (usuario.NombreRol == RolesSistema.Administrador)
                {
                    using FrmPrincipal frm = new FrmPrincipal();
                    DialogResult resultado = frm.ShowDialog();

                    if (resultado == DialogResult.Retry)
                    {
                        txtClave.Clear();
                        txtClave.Focus();
                        Show();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    // Funcionalidad para iniciar como usuario del sistema
                    using FrmPanelUsuario frm = new FrmPanelUsuario();
                    DialogResult resultado = frm.ShowDialog();

                    if (resultado == DialogResult.Retry)
                    {
                        txtClave.Clear();
                        txtClave.Focus();
                        Show();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmUsuariosRegistro frm = new FrmUsuariosRegistro(_usuarioBll, _rolBll, true);
            frm.ShowDialog();
        }
    }
}
