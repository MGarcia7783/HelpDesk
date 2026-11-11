namespace HelpDesk.UI.Formularios.Tickets
{
    partial class FrmDetalleTickets
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleTickets));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Solicitante = new Label();
            Categoria = new Label();
            TecnicoAsignado = new Label();
            FechaCierre = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            Ticket = new Label();
            FechaCreacion = new Label();
            EstadoActual = new Label();
            Prioridad = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtAsunto = new TextBox();
            errorIcon = new ErrorProvider(components);
            panelDescripcion = new Panel();
            txtDescripcion = new TextBox();
            panelAsunto = new Panel();
            panelContenido = new Panel();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            panelEstado = new Panel();
            cboEstado = new ComboBox();
            label13 = new Label();
            panelTecnico = new Panel();
            cboTecnicos = new ComboBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            pictureCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            iconTitulo = new FontAwesome.Sharp.IconPictureBox();
            lblDescripcion = new Label();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancelar = new FontAwesome.Sharp.IconButton();
            buttonGuardar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            panelDescripcion.SuspendLayout();
            panelAsunto.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            panelEstado.SuspendLayout();
            panelTecnico.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI Semibold", 11F);
            groupBox1.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox1.Location = new Point(20, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(945, 164);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información General";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Solicitante, 0, 3);
            tableLayoutPanel1.Controls.Add(Categoria, 1, 3);
            tableLayoutPanel1.Controls.Add(TecnicoAsignado, 2, 3);
            tableLayoutPanel1.Controls.Add(FechaCierre, 3, 3);
            tableLayoutPanel1.Controls.Add(label19, 0, 2);
            tableLayoutPanel1.Controls.Add(label20, 1, 2);
            tableLayoutPanel1.Controls.Add(label21, 2, 2);
            tableLayoutPanel1.Controls.Add(label22, 3, 2);
            tableLayoutPanel1.Controls.Add(Ticket, 0, 1);
            tableLayoutPanel1.Controls.Add(FechaCreacion, 1, 1);
            tableLayoutPanel1.Controls.Add(EstadoActual, 2, 1);
            tableLayoutPanel1.Controls.Add(Prioridad, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(16, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(910, 100);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // Solicitante
            // 
            Solicitante.Dock = DockStyle.Fill;
            Solicitante.Font = new Font("Segoe UI Semibold", 11F);
            Solicitante.ForeColor = SystemColors.ControlDarkDark;
            Solicitante.Location = new Point(4, 70);
            Solicitante.Name = "Solicitante";
            Solicitante.Size = new Size(220, 29);
            Solicitante.TabIndex = 37;
            Solicitante.Text = "Solicitante";
            Solicitante.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Categoria
            // 
            Categoria.Dock = DockStyle.Fill;
            Categoria.Font = new Font("Segoe UI Semibold", 11F);
            Categoria.ForeColor = SystemColors.ControlDarkDark;
            Categoria.Location = new Point(231, 70);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(220, 29);
            Categoria.TabIndex = 38;
            Categoria.Text = "Categoria";
            Categoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TecnicoAsignado
            // 
            TecnicoAsignado.Dock = DockStyle.Fill;
            TecnicoAsignado.Font = new Font("Segoe UI Semibold", 11F);
            TecnicoAsignado.ForeColor = SystemColors.ControlDarkDark;
            TecnicoAsignado.Location = new Point(458, 70);
            TecnicoAsignado.Name = "TecnicoAsignado";
            TecnicoAsignado.Size = new Size(220, 29);
            TecnicoAsignado.TabIndex = 39;
            TecnicoAsignado.Text = "Técnico asignado";
            TecnicoAsignado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FechaCierre
            // 
            FechaCierre.Dock = DockStyle.Fill;
            FechaCierre.Font = new Font("Segoe UI Semibold", 11F);
            FechaCierre.ForeColor = SystemColors.ControlDarkDark;
            FechaCierre.Location = new Point(685, 70);
            FechaCierre.Name = "FechaCierre";
            FechaCierre.Size = new Size(221, 29);
            FechaCierre.TabIndex = 36;
            FechaCierre.Text = "Fecha cierre";
            FechaCierre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI Semibold", 11F);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(4, 50);
            label19.Name = "label19";
            label19.Size = new Size(220, 19);
            label19.TabIndex = 33;
            label19.Text = "Solicitante";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI Semibold", 11F);
            label20.ForeColor = SystemColors.ControlText;
            label20.Location = new Point(231, 50);
            label20.Name = "label20";
            label20.Size = new Size(220, 19);
            label20.TabIndex = 34;
            label20.Text = "Categoría";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Segoe UI Semibold", 11F);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(458, 50);
            label21.Name = "label21";
            label21.Size = new Size(220, 19);
            label21.TabIndex = 35;
            label21.Text = "Técnico asignado";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI Semibold", 11F);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(685, 50);
            label22.Name = "label22";
            label22.Size = new Size(221, 19);
            label22.TabIndex = 32;
            label22.Text = "Fecha cierre";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Ticket
            // 
            Ticket.Dock = DockStyle.Fill;
            Ticket.Font = new Font("Segoe UI Semibold", 11F);
            Ticket.ForeColor = SystemColors.ControlDarkDark;
            Ticket.Location = new Point(4, 21);
            Ticket.Name = "Ticket";
            Ticket.Size = new Size(220, 28);
            Ticket.TabIndex = 29;
            Ticket.Text = "Ticket";
            Ticket.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FechaCreacion
            // 
            FechaCreacion.Dock = DockStyle.Fill;
            FechaCreacion.Font = new Font("Segoe UI Semibold", 11F);
            FechaCreacion.ForeColor = SystemColors.ControlDarkDark;
            FechaCreacion.Location = new Point(231, 21);
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.Size = new Size(220, 28);
            FechaCreacion.TabIndex = 30;
            FechaCreacion.Text = "Fecha creación";
            FechaCreacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EstadoActual
            // 
            EstadoActual.Dock = DockStyle.Fill;
            EstadoActual.Font = new Font("Segoe UI Semibold", 11F);
            EstadoActual.ForeColor = SystemColors.ControlDarkDark;
            EstadoActual.Location = new Point(458, 21);
            EstadoActual.Name = "EstadoActual";
            EstadoActual.Size = new Size(220, 28);
            EstadoActual.TabIndex = 31;
            EstadoActual.Text = "Estado actual";
            EstadoActual.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Prioridad
            // 
            Prioridad.Dock = DockStyle.Fill;
            Prioridad.Font = new Font("Segoe UI Semibold", 11F);
            Prioridad.ForeColor = SystemColors.ControlDarkDark;
            Prioridad.Location = new Point(685, 21);
            Prioridad.Name = "Prioridad";
            Prioridad.Size = new Size(221, 28);
            Prioridad.TabIndex = 28;
            Prioridad.Text = "Prioridad";
            Prioridad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(231, 1);
            label3.Name = "label3";
            label3.Size = new Size(220, 19);
            label3.TabIndex = 25;
            label3.Text = "Fecha creación";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(458, 1);
            label4.Name = "label4";
            label4.Size = new Size(220, 19);
            label4.TabIndex = 26;
            label4.Text = "Estado actual";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(685, 1);
            label5.Name = "label5";
            label5.Size = new Size(221, 19);
            label5.TabIndex = 27;
            label5.Text = "Prioridad";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(4, 1);
            label2.Name = "label2";
            label2.Size = new Size(220, 19);
            label2.TabIndex = 24;
            label2.Text = "Ticket";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAsunto
            // 
            txtAsunto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAsunto.BackColor = Color.White;
            txtAsunto.BorderStyle = BorderStyle.None;
            txtAsunto.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAsunto.ForeColor = SystemColors.ControlDark;
            txtAsunto.Location = new Point(9, 10);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.ReadOnly = true;
            txtAsunto.Size = new Size(481, 20);
            txtAsunto.TabIndex = 0;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // panelDescripcion
            // 
            panelDescripcion.BackColor = Color.White;
            panelDescripcion.Controls.Add(txtDescripcion);
            panelDescripcion.Location = new Point(19, 141);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(4, 0, 10, 0);
            panelDescripcion.Size = new Size(513, 157);
            panelDescripcion.TabIndex = 45;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtDescripcion.ForeColor = SystemColors.ControlDark;
            txtDescripcion.Location = new Point(9, 12);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(480, 130);
            txtDescripcion.TabIndex = 38;
            // 
            // panelAsunto
            // 
            panelAsunto.BackColor = Color.White;
            panelAsunto.Controls.Add(txtAsunto);
            panelAsunto.Location = new Point(19, 59);
            panelAsunto.Name = "panelAsunto";
            panelAsunto.Padding = new Padding(4, 0, 10, 0);
            panelAsunto.Size = new Size(513, 40);
            panelAsunto.TabIndex = 42;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(pictureBox2);
            panelContenido.Controls.Add(groupBox3);
            panelContenido.Controls.Add(groupBox2);
            panelContenido.Controls.Add(groupBox1);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 86);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(992, 566);
            panelContenido.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(0, 565);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1784, 1);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panelEstado);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(panelTecnico);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Segoe UI Semibold", 11F);
            groupBox3.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox3.Location = new Point(589, 218);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 321);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gestión del ticket";
            // 
            // panelEstado
            // 
            panelEstado.BackColor = Color.White;
            panelEstado.Controls.Add(cboEstado);
            panelEstado.Location = new Point(23, 141);
            panelEstado.Name = "panelEstado";
            panelEstado.Padding = new Padding(4, 0, 10, 0);
            panelEstado.Size = new Size(327, 40);
            panelEstado.TabIndex = 45;
            // 
            // cboEstado
            // 
            cboEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Abierto", "En proceso", "Cerrado", "Cancelado" });
            cboEstado.Location = new Point(9, 6);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(292, 28);
            cboEstado.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(20, 116);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 44;
            label13.Text = "Cambiar estado";
            // 
            // panelTecnico
            // 
            panelTecnico.BackColor = Color.White;
            panelTecnico.Controls.Add(cboTecnicos);
            panelTecnico.Location = new Point(20, 59);
            panelTecnico.Name = "panelTecnico";
            panelTecnico.Padding = new Padding(4, 0, 10, 0);
            panelTecnico.Size = new Size(330, 40);
            panelTecnico.TabIndex = 43;
            // 
            // cboTecnicos
            // 
            cboTecnicos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboTecnicos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTecnicos.FlatStyle = FlatStyle.Flat;
            cboTecnicos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cboTecnicos.FormattingEnabled = true;
            cboTecnicos.Location = new Point(9, 6);
            cboTecnicos.Name = "cboTecnicos";
            cboTecnicos.Size = new Size(301, 28);
            cboTecnicos.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(17, 34);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 42;
            label12.Text = "Asignar técnico";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelDescripcion);
            groupBox2.Controls.Add(panelAsunto);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Segoe UI Semibold", 11F);
            groupBox2.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox2.Location = new Point(20, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 321);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del ticket";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(16, 116);
            label8.Name = "label8";
            label8.Size = new Size(184, 20);
            label8.TabIndex = 40;
            label8.Text = "Descripción del problema";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(16, 34);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 38;
            label10.Text = "Asunto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureCerrar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(iconTitulo);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 86);
            panel1.TabIndex = 40;
            // 
            // pictureCerrar
            // 
            pictureCerrar.Image = (Image)resources.GetObject("pictureCerrar.Image");
            pictureCerrar.Location = new Point(947, 14);
            pictureCerrar.Name = "pictureCerrar";
            pictureCerrar.Size = new Size(24, 24);
            pictureCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureCerrar.TabIndex = 45;
            pictureCerrar.TabStop = false;
            pictureCerrar.Click += pictureCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(992, 1);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // iconTitulo
            // 
            iconTitulo.Anchor = AnchorStyles.None;
            iconTitulo.BackColor = Color.White;
            iconTitulo.ForeColor = Color.FromArgb(37, 99, 235);
            iconTitulo.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            iconTitulo.IconColor = Color.FromArgb(37, 99, 235);
            iconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTitulo.IconSize = 55;
            iconTitulo.Location = new Point(38, 14);
            iconTitulo.Name = "iconTitulo";
            iconTitulo.Size = new Size(55, 55);
            iconTitulo.SizeMode = PictureBoxSizeMode.CenterImage;
            iconTitulo.TabIndex = 41;
            iconTitulo.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 11F);
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(99, 49);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(288, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Información completa y gestión del caso.";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(99, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(203, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Detalle del Ticket";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(buttonCancelar, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonGuardar, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 652);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(992, 70);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            buttonCancelar.IconColor = Color.FromArgb(220, 53, 69);
            buttonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonCancelar.IconSize = 28;
            buttonCancelar.Location = new Point(853, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(116, 50);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            buttonGuardar.Cursor = Cursors.Hand;
            buttonGuardar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            buttonGuardar.IconColor = Color.FromArgb(37, 99, 235);
            buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonGuardar.IconSize = 28;
            buttonGuardar.Location = new Point(731, 10);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(116, 50);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // FrmDetalleTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 722);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDetalleTickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDetalleTickets";
            Load += FrmDetalleTickets_Load;
            Shown += FrmDetalleTickets_Shown;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelDescripcion.PerformLayout();
            panelAsunto.ResumeLayout(false);
            panelAsunto.PerformLayout();
            panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelEstado.ResumeLayout(false);
            panelTecnico.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Solicitante;
        private Label Categoria;
        private Label TecnicoAsignado;
        private Label FechaCierre;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label Ticket;
        private Label FechaCreacion;
        private Label EstadoActual;
        private Label Prioridad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private TextBox txtAsunto;
        private ErrorProvider errorIcon;
        private Panel panelContenido;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private Panel panelEstado;
        private ComboBox cboEstado;
        private Label label13;
        private Panel panelTecnico;
        private ComboBox cboTecnicos;
        private Label label12;
        private GroupBox groupBox2;
        private Panel panelDescripcion;
        private TextBox txtDescripcion;
        private Panel panelAsunto;
        private Label label8;
        private Label label10;
        private Panel panel1;
        private PictureBox pictureCerrar;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconTitulo;
        protected Label lblDescripcion;
        public Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        public FontAwesome.Sharp.IconButton buttonCancelar;
        public FontAwesome.Sharp.IconButton buttonGuardar;
    }
}