using HelpDesk.Bll;
using HelpDesk.Dal;
using HelpDesk.UI.Helpers;
using HelpHesk.Entities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Tickets
{
    public partial class FrmDashboard : Form
    {
        private readonly TicketBll _ticketBll;

        public FrmDashboard()
        {
            InitializeComponent();

            _ticketBll = new TicketBll(new TicketDal());
        }

        #region Métodos

        private async Task CargarDashboardAsync()
        {
            try
            {
                DashboardAdminDto dashboard = await _ticketBll.ObtenerDashboardAdminAsync();

                CargarEstados(dashboard);
                CargarTecnicos(dashboard);
                CargarIndicadores(dashboard);
                CargarTicketsCriticos(dashboard);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarEstados(DashboardAdminDto dashboard)
        {
            var estados = dashboard.TicketsPorEstado
                                   .ToDictionary(x => x.Estado, x => x.Total);

            lblAbiertos.Text =
                estados.TryGetValue("Abierto", out int abiertos)
                    ? abiertos.ToString()
                    : "0";

            lblEnProceso.Text =
                estados.TryGetValue("En proceso", out int proceso)
                    ? proceso.ToString()
                    : "0";

            lblCerrados.Text =
                estados.TryGetValue("Cerrado", out int cerrado)
                    ? cerrado.ToString()
                    : "0";

            lblCancelados.Text =
                estados.TryGetValue("Cancelado", out int cancelado)
                    ? cancelado.ToString()
                    : "0";
        }

        private void CargarTecnicos(DashboardAdminDto dashboard)
        {
            Label[] lblTecnicos =
            {
                lblTecnico1,
                lblTecnico2,
                lblTecnico3,
                lblTecnico4
            };

            Label[] lblTotales =
            {
                lblTotalTecnico1,
                lblTotalTecnico2,
                lblTotalTecnico3,
                lblTotalTecnico4
            };

            // Reiniciar
            for (int i = 0; i < lblTecnicos.Length; i++)
            {
                lblTecnicos[i].Text = "-";
                lblTotales[i].Text = "0";
            }

            for (int i = 0; i < dashboard.TicketsPorTecnico.Count && i < lblTecnicos.Length; i++)
            {
                lblTecnicos[i].Text = dashboard.TicketsPorTecnico[i].Tecnico;
                lblTotales[i].Text = dashboard.TicketsPorTecnico[i].TotalTickets.ToString();
            }
        }

        private void CargarIndicadores(DashboardAdminDto dashboard)
        {
            lblTicketsHoy.Text = dashboard.Indicadores.TicketsCreadosHoy.ToString();
            lblSinAsignar.Text = dashboard.Indicadores.TicketsSinAsignar.ToString();
            lblCriticos.Text = dashboard.Indicadores.TicketsCriticos.ToString();
            lblCerradosHoy.Text = dashboard.Indicadores.TicketsCerradosHoy.ToString();
        }

        private void CargarTicketsCriticos(DashboardAdminDto dashboard)
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = dashboard.TicketsCriticos;

            if (dgvListado.Columns.Contains("NumeroTicket"))
            {
                dgvListado.Columns["NumeroTicket"]!.HeaderText = "Ticket";
                dgvListado.Columns["NumeroTicket"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (dgvListado.Columns.Contains("Asunto"))
            {
                dgvListado.Columns["Asunto"]!.HeaderText = "Asunto";
                dgvListado.Columns["Asunto"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (dgvListado.Columns.Contains("Categoria"))
                dgvListado.Columns["Categoria"]!.HeaderText = "Categoría";

            if (dgvListado.Columns.Contains("Tecnico"))
                dgvListado.Columns["Tecnico"]!.HeaderText = "Técnico";

            if (dgvListado.Columns.Contains("Estado"))
                dgvListado.Columns["Estado"]!.HeaderText = "Estado";

            if (dgvListado.Columns.Contains("TiempoPendiente"))
                dgvListado.Columns["TiempoPendiente"]!.HeaderText = "Tiempo";

            if (dgvListado.Columns.Contains("FechaCreacion"))
                dgvListado.Columns["FechaCreacion"]!.Visible = false;

            MostrarEstoCritidos(dashboard.TicketsCriticos.Any());
        }

        private void MostrarEstoCritidos(bool tieneDatos)
        {
            dgvListado.Visible = tieneDatos;
            pictureEmpty.Visible = !tieneDatos;
        }

        #endregion

        private async void FrmDashboard_Load(object sender, EventArgs e)
        {
            GridDashboardHelper.Personalizar(dgvListado);

            await CargarDashboardAsync();
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "Estado")
                GridColorHelper.FormatearEstadoTicket(e);
        }

        private void FrmDashboard_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(panelContenido, 20);
            RedondearControlHelper.RedondearControl(panelEstados, 20);
            RedondearControlHelper.RedondearControl(panelTecnicos, 20);
            RedondearControlHelper.RedondearControl(panelResumenDia, 20);
            RedondearControlHelper.RedondearControl(panelCriticos, 20);
            RedondearControlHelper.RedondearControl(dgvListado, 12);
        }
    }
}
