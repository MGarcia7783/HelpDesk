using HelpDesk.UI.Formularios.Base;
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
    public partial class FrmPrincipal : Form
    {

        private Form? formularioActivo;
        private bool _cerrandoSesion = false;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Sidebar

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }

        #endregion

        #region Métodos

        public void CerrarSesion()
        {
            _cerrandoSesion = true;
            DialogResult = DialogResult.Retry;
            Close();
        }

        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cerrandoSesion)
                return;

            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmBaseListado(), panelContenedor, ref formularioActivo, btnDashboard);
        }
    }
}
