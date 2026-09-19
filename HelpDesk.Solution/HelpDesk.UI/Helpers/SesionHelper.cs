using HelpDesk.UI.Formularios;
using HelpDesk.UI.Seguridad;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.UI.Helpers
{
    public class SesionHelper
    {
        public static void CargarDatosSesion(ToolStripStatusLabel lblUsuario, ToolStripStatusLabel lblRol)
        {
            lblUsuario.Text = $"Bienvenido, {UsuarioSesion.NombreCompleto}";
            lblRol.Text = $"Rol: {UsuarioSesion.NombreRol}";
        }

        /// <summary>
        /// Cerrar la sesión del usuario.
        /// </summary>
        public static bool CerrarSesion(Form formularioActual)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return false;

           if (formularioActual is FrmPrincipal principal)
                principal.CerrarSesion();
            /*else if (formularioActual is FrmPanelUsuario panel)
                panel.CerrarSesion();*/
            else
                formularioActual.Close();

            return true;
        }
    }
}
