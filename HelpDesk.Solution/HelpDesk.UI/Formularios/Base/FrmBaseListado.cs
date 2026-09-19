
using HelpDesk.UI.Helpers;
using System.Xml.Serialization;

namespace HelpDesk.UI.Formularios.Base
{
    public partial class FrmBaseListado : Form
    {
        protected int PaginaActual = 1;
        protected int TamPagina = 10;
        protected int TotalRegistros = 0;
        protected int TotalPaginas = 0;

        public FrmBaseListado()
        {
            InitializeComponent();
        }

        #region Métodos virtuales

        protected virtual bool MostrarBotonPrincipal => true;
        protected virtual bool MostrarBotonSecundario => true;
        protected virtual bool MostrarBotonTerciario => true;

        protected virtual Task MostrarDatosAsync(int pagina, int tamPagina, string? buscar = null)
        {
            return Task.CompletedTask;
        }

        protected void ActualizarBotonesPaginacion()
        {
            // Sin registros
            if (TotalRegistros <= 0)
            {
                buttonPrimero.Enabled = false;
                buttonAnterior.Enabled = false;
                buttonSiguiente.Enabled = false;
                buttonUltimo.Enabled = false;

                return;
            }

            // Primera página
            buttonPrimero.Enabled = PaginaActual > 1;
            buttonAnterior.Enabled = PaginaActual > 1;

            // Última página
            buttonSiguiente.Enabled = PaginaActual < TotalPaginas;
            buttonUltimo.Enabled = PaginaActual < TotalPaginas;
        }

        protected void ActualizarPaginacion()
        {
            if (TotalRegistros == 0)
            {
                lblPagina.Text = "Página 0 de 0";
                lblTotalRegistros.Text = "Total registros: 0";

                ActualizarBotonesPaginacion();
                return;
            }

            lblPagina.Text = $"Página {PaginaActual} de {TotalPaginas}";
            lblTotalRegistros.Text = $"Total registros: {TotalRegistros}";

            ActualizarBotonesPaginacion();
        }

        protected virtual Form? CrearFormularioAccionPrincipal()
        {
            return null;
        }

        protected virtual Form? CrearFormularioAccionSecundaria(int id)
        {
            return null;
        }

        protected virtual int? ObtenerIdSeleccionado()
        {
            return null;
        }

        protected virtual Task DesactivarAsync()
        {
            return Task.CompletedTask;
        }

        protected virtual void FormatearCelda(DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name != "Estado")
                return;

            GridColorHelper.FormatearActivoInactivo(e);
        }

        protected void AjustarColumnas(params string[] columnas)
        {
            foreach (string columna in columnas)
            {
                if (!dgvListado.Columns.Contains(columna))
                    continue;

                dgvListado.Columns[columna]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        #endregion

        #region Personalizar el formulario

        protected void MostrarEstadoVacio(bool tieneDatos)
        {
            dgvListado.Visible = tieneDatos;
            pictureEmpty.Visible = !tieneDatos;
        }
        #endregion

        private async void FrmBaseListado_Load(object sender, EventArgs e)
        {
            buttonAgregar.Visible = MostrarBotonPrincipal;
            buttonEditar.Visible = MostrarBotonSecundario;
            buttonDesactivar.Visible = MostrarBotonTerciario;

            GridDashboardHelper.Personalizar(dgvListado);

            await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            PaginaActual = 1;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatearCelda(e);
        }

        private void FrmBaseListado_Shown(object sender, EventArgs e)
        {
            RedondearControlHelper.RedondearControl(panelContenido, 20);
            RedondearControlHelper.RedondearControl(panelPaginacion, 20);

            RedondearControlHelper.RedondearControl(buttonAgregar, 12);
            RedondearControlHelper.RedondearControl(buttonEditar, 12);
            RedondearControlHelper.RedondearControl(buttonDesactivar, 12);

            RedondearControlHelper.RedondearControl(dgvListado, 15);
            RedondearControlHelper.RedondearControl(pictureEmpty, 15);
            RedondearControlHelper.RedondearControl(panelBuscar, 15);
        }

        private async void buttonPrimero_Click(object sender, EventArgs e)
        {
            PaginaActual = 1;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }

        private async void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (PaginaActual <= 1)
                return;

            PaginaActual--;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }

        private async void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (PaginaActual >= TotalPaginas)
                return;

            PaginaActual++;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }

        private async void buttonUltimo_Click(object sender, EventArgs e)
        {
            PaginaActual = TotalPaginas;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }
    }
}
