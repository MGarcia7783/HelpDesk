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

namespace HelpDesk.UI.Formularios.Tickets
{
    public partial class FrmTicketsRegistro : Form
    {
        private readonly TicketBll _ticketBll;
        private readonly CategoriaBll _categoriaBll;
        public FrmTicketsRegistro(TicketBll ticketBll, CategoriaBll categoriaBll)
        {
            InitializeComponent();

            _ticketBll = ticketBll;
            _categoriaBll = categoriaBll;

            lblTitulo.Text = "Nueva Ticket";
            lblDescripcion.Text = "Complete la información de la ticket";
        }

        #region Métodos

        private async Task CargarCategoriasAsync()
        {
            try
            {
                var categorias = await _categoriaBll.MostrarCategoriaesActivosAsync();

                cboCategoria.DataSource = categorias;
                cboCategoria.DisplayMember = "NombreCategoria";
                cboCategoria.ValueMember = "Id";
                cboCategoria.SelectedIndex = -1;
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

            if (!ValidationHelper.Requerido(txtAsunto, errorIcon, "Ingrese el asunto de la ticket."))
                valido = false;

            if (!ValidationHelper.Requerido(cboCategoria, errorIcon, "Ingrese una categoría."))
                valido = false;

            if (!ValidationHelper.Requerido(cboPrioridad, errorIcon, "Ingrese la prioridad."))
                valido = false;

            if (!ValidationHelper.Requerido(txtDescripcion, errorIcon, "Ingrese la descripción para el ticket."))
                valido = false;

            return valido;
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private async void FrmTicketsRegistro_Load(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void FrmTicketsRegistro_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(this, 25);
            RedondearControlHelper.RedondearControl(panelContenido, 25);
            RedondearControlHelper.RedondearControl(panelAsunto, 15);
            RedondearControlHelper.RedondearControl(panelCategoria, 15);
            RedondearControlHelper.RedondearControl(panelPrioridad, 15);
            RedondearControlHelper.RedondearControl(panelDescripcion, 15);
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarControles())
                return;

            try
            {
                TicketEntity nuevaTicket = new();

                nuevaTicket.CambiarAsunto(txtAsunto.Text);
                nuevaTicket.CambiarDescripcion(txtDescripcion.Text);
                nuevaTicket.CambiarUsuarioSolicitante(UsuarioSesion.IdUsuario);
                nuevaTicket.CambiarCategoria(Convert.ToInt32(cboCategoria.SelectedValue));
                nuevaTicket.CambiarPrioridad(cboPrioridad.Text);

                string numeroTicket = await _ticketBll.AgregarAsync(nuevaTicket, UsuarioSesion.NombreUsuario);

                MessageBox.Show($"Ticket: {numeroTicket}, registrada correctamente.", "Información", MessageBoxButtons.OK);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencíón", MessageBoxButtons.OK);
            }
        }
    }
}
