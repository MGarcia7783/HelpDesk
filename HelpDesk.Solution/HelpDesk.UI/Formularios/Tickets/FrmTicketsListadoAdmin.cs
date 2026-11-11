using FontAwesome.Sharp;
using HelpDesk.Bll;
using HelpDesk.Dal;
using HelpDesk.UI.Formularios.Base;
using HelpDesk.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Tickets
{
    public partial class FrmTicketsListadoAdmin : FrmBaseListado
    {
        private readonly TicketBll _ticketBll;
        private readonly CategoriaBll _categoriaBll;

        public FrmTicketsListadoAdmin()
        {
            InitializeComponent();

            IconoTitulo = IconChar.Ticket;

            TextoBotonPrincipal = "Detalle";
            IconoBotonPrincipal = IconChar.Eye;

            _ticketBll = new TicketBll(new TicketDal());
            _categoriaBll = new CategoriaBll(new CategoriaDal());
        }

        protected override bool MostrarBotonSecundario => false;
        protected override bool MostrarBotonTerciario => false;

        protected override async Task MostrarDatosAsync(int pagina, int tamPagina, string? buscar = null)
        {
            try
            {
                var resultado = await _ticketBll.MostrarAsync(pagina, tamPagina, buscar, null, true);

                dgvListado.DataSource = null;
                dgvListado.DataSource = resultado.Registros;

                PaginaActual = resultado.PaginaActual;
                TamPagina = resultado.TamPagina;
                TotalRegistros = resultado.TotalRegistros;
                TotalPaginas = resultado.TotalPaginas;

                ActualizarPaginacion();
                MostrarEstadoVacio(resultado.Registros.Count > 0);

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dgvListado.Columns.Count == 0)
                return;

            dgvListado.Columns["Id"]!.Visible = false;
            dgvListado.Columns["FechaUltimaActualizacion"]!.Visible = false;
            dgvListado.Columns["Descripcion"]!.Visible = false;
            dgvListado.Columns["IdUsuarioSolicitante"]!.Visible = false;
            dgvListado.Columns["IdTecnicoAsignado"]!.Visible = false;
            dgvListado.Columns["NombreTecnico"]!.Visible = false;
            dgvListado.Columns["IdCategoria"]!.Visible = false;
            dgvListado.Columns["FechaCierre"]!.Visible = false;

            // Encabezados
            dgvListado.Columns["NumeroTicket"]!.HeaderText = "Ticket";
            dgvListado.Columns["Asunto"]!.HeaderText = "Asunto";
            dgvListado.Columns["NombreCategoria"]!.HeaderText = "Categoría";
            dgvListado.Columns["NombreSolicitante"]!.HeaderText = "Solicitante";
            dgvListado.Columns["Prioridad"]!.HeaderText = "Prioridad";
            dgvListado.Columns["Estado"]!.HeaderText = "Estado";
            dgvListado.Columns["FechaCreacion"]!.HeaderText = "Fecha Creación";
            dgvListado.Columns["FechaCreacion"]!.DefaultCellStyle.Format = "dd/MM/yyyy";


            AjustarColumnas("NumeroTicket", "FechaCreacion", "Prioridad", "Estado", "Asunto");
        }

        protected override void FormatearCelda(DataGridViewCellFormattingEventArgs e)
        {
            string columna = dgvListado.Columns[e.ColumnIndex].Name;

            switch(columna)
            {
                case "Estado":
                    GridColorHelper.FormatearEstadoTicket(e);
                    break;

                case "Prioridad":
                    GridColorHelper.FormatearPrioridadTicket(e);
                    break;
            }
        }

        protected override Form? CrearFormularioAccionPrincipal()
        {
            int? id = ObtenerIdSeleccionado();

            if(id == null)
            {
                MessageBox.Show("Seleccione un ticket.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return new FrmDetalleTickets(_ticketBll, _categoriaBll, id.Value);
        }

        protected override int? ObtenerIdSeleccionado()
        {
            if (dgvListado.CurrentRow == null)
                return null;

            return Convert.ToInt32(dgvListado.CurrentRow.Cells["Id"].Value);
        }
    }
}
