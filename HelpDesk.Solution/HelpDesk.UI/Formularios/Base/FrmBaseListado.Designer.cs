namespace HelpDesk.UI.Formularios.Base
{
    partial class FrmBaseListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenido = new Panel();
            pictureEmpty = new PictureBox();
            panelPaginacion = new TableLayoutPanel();
            buttonUltimo = new FontAwesome.Sharp.IconButton();
            buttonSiguiente = new FontAwesome.Sharp.IconButton();
            buttonPrimero = new FontAwesome.Sharp.IconButton();
            lblTotalRegistros = new Label();
            lblPagina = new Label();
            buttonAnterior = new FontAwesome.Sharp.IconButton();
            dgvListado = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonEditar = new FontAwesome.Sharp.IconButton();
            buttonDesactivar = new FontAwesome.Sharp.IconButton();
            buttonAgregar = new FontAwesome.Sharp.IconButton();
            panelBuscar = new Panel();
            txtBuscar = new TextBox();
            iconBuscar = new FontAwesome.Sharp.IconPictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblTitulo = new Label();
            iconTitulo = new FontAwesome.Sharp.IconPictureBox();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEmpty).BeginInit();
            panelPaginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(pictureEmpty);
            panelContenido.Controls.Add(panelPaginacion);
            panelContenido.Controls.Add(dgvListado);
            panelContenido.Controls.Add(tableLayoutPanel1);
            panelContenido.Controls.Add(panelBuscar);
            panelContenido.Controls.Add(pictureBox1);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(iconTitulo);
            panelContenido.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelContenido.Location = new Point(55, 49);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(865, 372);
            panelContenido.TabIndex = 0;
            // 
            // pictureEmpty
            // 
            pictureEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureEmpty.BackColor = Color.White;
            pictureEmpty.Image = Properties.Resources.empty;
            pictureEmpty.Location = new Point(37, 159);
            pictureEmpty.Name = "pictureEmpty";
            pictureEmpty.Size = new Size(793, 118);
            pictureEmpty.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureEmpty.TabIndex = 27;
            pictureEmpty.TabStop = false;
            pictureEmpty.Visible = false;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPaginacion.BackColor = Color.White;
            panelPaginacion.ColumnCount = 6;
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPaginacion.Controls.Add(buttonUltimo, 5, 0);
            panelPaginacion.Controls.Add(buttonSiguiente, 4, 0);
            panelPaginacion.Controls.Add(buttonPrimero, 1, 0);
            panelPaginacion.Controls.Add(lblTotalRegistros, 0, 0);
            panelPaginacion.Controls.Add(lblPagina, 3, 0);
            panelPaginacion.Controls.Add(buttonAnterior, 2, 0);
            panelPaginacion.Location = new Point(37, 296);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(6, 4, 8, 4);
            panelPaginacion.RowCount = 1;
            panelPaginacion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelPaginacion.Size = new Size(793, 57);
            panelPaginacion.TabIndex = 28;
            // 
            // buttonUltimo
            // 
            buttonUltimo.BackColor = Color.FromArgb(248, 250, 252);
            buttonUltimo.Cursor = Cursors.Hand;
            buttonUltimo.Dock = DockStyle.Fill;
            buttonUltimo.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            buttonUltimo.IconColor = Color.Black;
            buttonUltimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonUltimo.IconSize = 20;
            buttonUltimo.Location = new Point(748, 7);
            buttonUltimo.Name = "buttonUltimo";
            buttonUltimo.Padding = new Padding(0, 2, 0, 0);
            buttonUltimo.Size = new Size(34, 43);
            buttonUltimo.TabIndex = 12;
            buttonUltimo.UseVisualStyleBackColor = false;
            buttonUltimo.Click += buttonUltimo_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.FromArgb(248, 250, 252);
            buttonSiguiente.Cursor = Cursors.Hand;
            buttonSiguiente.Dock = DockStyle.Fill;
            buttonSiguiente.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            buttonSiguiente.IconColor = Color.Black;
            buttonSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonSiguiente.IconSize = 20;
            buttonSiguiente.Location = new Point(708, 7);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Padding = new Padding(0, 2, 0, 0);
            buttonSiguiente.Size = new Size(34, 43);
            buttonSiguiente.TabIndex = 13;
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // buttonPrimero
            // 
            buttonPrimero.BackColor = Color.FromArgb(248, 250, 252);
            buttonPrimero.Cursor = Cursors.Hand;
            buttonPrimero.Dock = DockStyle.Fill;
            buttonPrimero.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            buttonPrimero.IconColor = Color.Black;
            buttonPrimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonPrimero.IconSize = 20;
            buttonPrimero.Location = new Point(508, 7);
            buttonPrimero.Name = "buttonPrimero";
            buttonPrimero.Padding = new Padding(0, 2, 0, 0);
            buttonPrimero.Size = new Size(34, 43);
            buttonPrimero.TabIndex = 10;
            buttonPrimero.UseVisualStyleBackColor = false;
            buttonPrimero.Click += buttonPrimero_Click;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalRegistros.Location = new Point(9, 18);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(121, 20);
            lblTotalRegistros.TabIndex = 16;
            lblTotalRegistros.Text = "Total registros: 0";
            lblTotalRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.None;
            lblPagina.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPagina.Location = new Point(588, 16);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(114, 25);
            lblPagina.TabIndex = 14;
            lblPagina.Text = "Página 0 de 0";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAnterior
            // 
            buttonAnterior.BackColor = Color.FromArgb(248, 250, 252);
            buttonAnterior.Cursor = Cursors.Hand;
            buttonAnterior.Dock = DockStyle.Fill;
            buttonAnterior.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            buttonAnterior.IconColor = Color.Black;
            buttonAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonAnterior.IconSize = 20;
            buttonAnterior.Location = new Point(548, 7);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Padding = new Padding(0, 2, 0, 0);
            buttonAnterior.Size = new Size(34, 43);
            buttonAnterior.TabIndex = 11;
            buttonAnterior.UseVisualStyleBackColor = false;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // dgvListado
            // 
            dgvListado.AllowUserToAddRows = false;
            dgvListado.AllowUserToDeleteRows = false;
            dgvListado.AllowUserToOrderColumns = true;
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.BackgroundColor = SystemColors.ButtonHighlight;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(37, 159);
            dgvListado.Name = "dgvListado";
            dgvListado.ReadOnly = true;
            dgvListado.RowHeadersWidth = 51;
            dgvListado.RowTemplate.Height = 31;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.Size = new Size(793, 118);
            dgvListado.TabIndex = 26;
            dgvListado.CellFormatting += dgvListado_CellFormatting;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonEditar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonDesactivar, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonAgregar, 0, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(439, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(391, 60);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(248, 250, 252);
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.Dock = DockStyle.Fill;
            buttonEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            buttonEditar.IconColor = Color.FromArgb(22, 163, 74);
            buttonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonEditar.IconSize = 30;
            buttonEditar.Location = new Point(133, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(124, 54);
            buttonEditar.TabIndex = 8;
            buttonEditar.Text = "Editar";
            buttonEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonDesactivar
            // 
            buttonDesactivar.BackColor = Color.FromArgb(248, 250, 252);
            buttonDesactivar.Cursor = Cursors.Hand;
            buttonDesactivar.Dock = DockStyle.Fill;
            buttonDesactivar.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            buttonDesactivar.IconColor = Color.FromArgb(168, 85, 247);
            buttonDesactivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonDesactivar.IconSize = 36;
            buttonDesactivar.Location = new Point(263, 3);
            buttonDesactivar.Name = "buttonDesactivar";
            buttonDesactivar.Size = new Size(125, 54);
            buttonDesactivar.TabIndex = 7;
            buttonDesactivar.Text = "Estado";
            buttonDesactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDesactivar.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(248, 250, 252);
            buttonAgregar.Cursor = Cursors.Hand;
            buttonAgregar.Dock = DockStyle.Fill;
            buttonAgregar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 255);
            buttonAgregar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonAgregar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            buttonAgregar.IconColor = Color.FromArgb(37, 99, 235);
            buttonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonAgregar.IconSize = 30;
            buttonAgregar.Location = new Point(3, 3);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(124, 54);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Nuevo";
            buttonAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Controls.Add(iconBuscar);
            panelBuscar.Location = new Point(37, 100);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(382, 40);
            panelBuscar.TabIndex = 24;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Location = new Point(39, 10);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar registro";
            txtBuscar.Size = new Size(331, 20);
            txtBuscar.TabIndex = 44;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // iconBuscar
            // 
            iconBuscar.Anchor = AnchorStyles.Left;
            iconBuscar.BackColor = Color.White;
            iconBuscar.ForeColor = Color.DimGray;
            iconBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconBuscar.IconColor = Color.DimGray;
            iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscar.IconSize = 25;
            iconBuscar.Location = new Point(5, 8);
            iconBuscar.Name = "iconBuscar";
            iconBuscar.Size = new Size(30, 25);
            iconBuscar.SizeMode = PictureBoxSizeMode.CenterImage;
            iconBuscar.TabIndex = 43;
            iconBuscar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(37, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(793, 1);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(98, 56);
            label2.Name = "label2";
            label2.Size = new Size(312, 20);
            label2.TabIndex = 22;
            label2.Text = "Consulte, administre y gestione los registros.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(98, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(92, 32);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Listado";
            // 
            // iconTitulo
            // 
            iconTitulo.BackColor = Color.FromArgb(230, 236, 243);
            iconTitulo.ForeColor = Color.FromArgb(37, 99, 235);
            iconTitulo.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconTitulo.IconColor = Color.FromArgb(37, 99, 235);
            iconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTitulo.IconSize = 55;
            iconTitulo.Location = new Point(37, 21);
            iconTitulo.Name = "iconTitulo";
            iconTitulo.Size = new Size(55, 55);
            iconTitulo.SizeMode = PictureBoxSizeMode.CenterImage;
            iconTitulo.TabIndex = 1;
            iconTitulo.TabStop = false;
            // 
            // FrmBaseListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(978, 463);
            Controls.Add(panelContenido);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(993, 500);
            Name = "FrmBaseListado";
            Text = "FrmBaseListado";
            Load += FrmBaseListado_Load;
            Shown += FrmBaseListado_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEmpty).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelContenido;
        private Panel panelBuscar;
        private PictureBox pictureBox1;
        protected Label label2;
        public Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconTitulo;
        public TableLayoutPanel panelPaginacion;
        public FontAwesome.Sharp.IconButton buttonUltimo;
        public FontAwesome.Sharp.IconButton buttonSiguiente;
        public FontAwesome.Sharp.IconButton buttonPrimero;
        public Label lblTotalRegistros;
        public Label lblPagina;
        public FontAwesome.Sharp.IconButton buttonAnterior;
        public PictureBox pictureEmpty;
        public DataGridView dgvListado;
        public TableLayoutPanel tableLayoutPanel1;
        public FontAwesome.Sharp.IconButton buttonEditar;
        public FontAwesome.Sharp.IconButton buttonDesactivar;
        public FontAwesome.Sharp.IconButton buttonAgregar;
        public TextBox txtBuscar;
        private FontAwesome.Sharp.IconPictureBox iconBuscar;
    }
}