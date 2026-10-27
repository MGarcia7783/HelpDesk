using HelpDesk.UI.Formularios.Tickets;
using HelpDesk.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios
{
    public partial class FrmPanelUsuario : Form
    {
        private Form? formularioActivo;
        private bool _cerrandoSesion = false;

        public FrmPanelUsuario()
        {
            InitializeComponent();
        }

        #region Métodos

        public void CerrarSesion()
        {
            _cerrandoSesion = true;
            DialogResult = DialogResult.Retry;
            Close();
        }

        #endregion

        #region Eventos

        private void FrmPanelUsuario_Load(object sender, EventArgs e)
        {
            SesionHelper.CargarDatosSesion(toolUsuario, toolRol);
            NavegacionHelper.AbrirFormulario(new FrmMisTickets(), panelContenedor, ref formularioActivo, btnMisTickets);
        }

        private void FrmPanelUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cerrandoSesion)
                return;

            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }

        #endregion
    }
}
