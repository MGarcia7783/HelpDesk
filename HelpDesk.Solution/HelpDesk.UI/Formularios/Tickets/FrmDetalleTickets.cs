using HelpDesk.Bll;
using HelpDesk.UI.Helpers;
using HelpDesk.UI.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Tickets
{
    public partial class FrmDetalleTickets : Form
    {
        private readonly TicketBll _ticketBll;
        private readonly CategoriaBll _categoriaBll;
        private readonly int _idTicket;
        private string _estadoActual = string.Empty;

        public FrmDetalleTickets(TicketBll ticketBll, CategoriaBll categoriaBll, int idTicket)
        {
            InitializeComponent();

            _ticketBll = ticketBll;
            _categoriaBll = categoriaBll;
            _idTicket = idTicket;
        }

        #region Métodos

        private async Task CargarTecnicoAsync()
        {
            var tecnicos = await _ticketBll.ObtenerTecnicosAsync();

            cboTecnicos.DataSource = tecnicos;
            cboTecnicos.DisplayMember = "NombreCompleto";
            cboTecnicos.ValueMember = "Id";
            cboTecnicos.SelectedIndex = -1;
        }

        private async Task CargarDatosAsync()
        {
            try
            {
                var ticket = await _ticketBll.ObtenerPorIdAsync(_idTicket);

                if (ticket is null)
                {
                    MessageBox.Show("No se encontró la ticket.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                Ticket.Text = ticket.NumeroTicket;
                FechaCreacion.Text = ticket.FechaCreacion.ToString("dd/MM/yyyy");
                EstadoActual.Text = ticket.Estado;
                _estadoActual = ticket.Estado;
                Prioridad.Text = ticket.Prioridad;
                Solicitante.Text = ticket.NombreSolicitante;
                Categoria.Text = ticket.NombreCategoria;

                TecnicoAsignado.Text = string.IsNullOrWhiteSpace(ticket.NombreTecnico)
                    ? "Sin asignar"
                    : ticket.NombreTecnico;

                FechaCierre.Text = ticket.FechaCierre?.ToString("dd/MM/yyyy") ?? "Pendiente";

                txtAsunto.Text = ticket.Asunto;
                txtDescripcion.Text = ticket.Descripcion;

                if (ticket.IdTecnicoAsignado > 0)
                    cboTecnicos.SelectedValue = ticket.IdTecnicoAsignado;
                else
                    cboTecnicos.SelectedIndex = -1;

                cboEstado.Text = ticket.Estado;

                // Ticket finalizados
                if (ticket.Estado == "Cerrado" || ticket.Estado == "Cancelado")
                {
                    cboTecnicos.Enabled = false;
                    cboEstado.Enabled = false;
                    base.Enabled = false;

                    panelTecnico.BackColor = SystemColors.Control;
                    panelEstado.BackColor = SystemColors.Control;
                }
                else
                {
                    cboTecnicos.Enabled = true;
                    cboEstado.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool EstadoValido(string estadoActual, string nuevoEstado)
        {
            return estadoActual switch
            {
                //Abierto:

                "Abierto" =>
                    nuevoEstado is "Abierto"
                    or "En proceso"
                    or "Cancelado",

                // En proceso:
                "En proceso" =>
                    nuevoEstado is "En proceso"
                    or "Cerrado"
                    or "Cancelado",

                // Un ticket cerrado ya no puede modificarse
                "Cerrado" =>
                    nuevoEstado is "Cerrado",

                // Un ticket cancelado ya no puede modificarse
                "Cancelado" =>
                    nuevoEstado is "Cancelado",

                _ => false
            };
        }

        private bool ValidarControles()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!ValidationHelper.Requerido(cboEstado, errorIcon, "Seleccione un estado."))
                valido = false;

            if (cboEstado.Text == "En proceso" || cboEstado.Text == "Cerrado")
            {
                if (!ValidationHelper.Requerido(cboTecnicos, errorIcon, "Debe asignar un técnico."))
                    valido = false;
            }

            if (!EstadoValido(_estadoActual, cboEstado.Text))
            {
                MessageBox.Show("No es posible realizar ese cambio de estado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void FrmDetalleTickets_Load(object sender, EventArgs e)
        {
            cboEstado.Enabled = false;

            await CargarTecnicoAsync();
            await CargarDatosAsync();
        }

        private void FrmDetalleTickets_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(this, 25);
            RedondearControlHelper.RedondearControl(panelAsunto, 15);
            RedondearControlHelper.RedondearControl(panelDescripcion, 15);
            RedondearControlHelper.RedondearControl(panelTecnico, 15);
            RedondearControlHelper.RedondearControl(panelEstado, 15);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarControles())
                    return;

                int? idTecnico = null;

                if (cboTecnicos.SelectedValue != null)
                    idTecnico = Convert.ToInt32(cboTecnicos.SelectedValue);

                string nuevoEstado = cboEstado.Text;

                // Validar transición de estados
                if(!EstadoValido(_estadoActual, nuevoEstado))
                {
                    MessageBox.Show($"No es posible cambiar un ticket de '{EstadoActual.Text}' a '{nuevoEstado}'", "Estado no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Si pasa a En proceso o Cerrado, debe existir un tecnico asignado
                if((nuevoEstado == "En proceso" || nuevoEstado == "Cerrado") && idTecnico is null)
                {
                    MessageBox.Show("Debe asignar un técnico antes de continuar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    cboTecnicos.Focus();
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Desea guardar los cambios realizados al ticket?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                    return;

                await _ticketBll.GestionarAsync(_idTicket, idTecnico, nuevoEstado, UsuarioSesion.NombreUsuario);

                MessageBox.Show("El ticekt fue actualizado correctamente", "Información", MessageBoxButtons.OK);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
