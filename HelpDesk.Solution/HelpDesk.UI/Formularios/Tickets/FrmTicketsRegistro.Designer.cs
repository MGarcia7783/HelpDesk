namespace HelpDesk.UI.Formularios.Tickets
{
    partial class FrmTicketsRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicketsRegistro));
            panelContenido = new Panel();
            pictureBox2 = new PictureBox();
            panelDescripcion = new Panel();
            txtDescripcion = new TextBox();
            panelPrioridad = new Panel();
            cboPrioridad = new ComboBox();
            panelCategoria = new Panel();
            cboCategoria = new ComboBox();
            panelAsunto = new Panel();
            txtAsunto = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancelar = new FontAwesome.Sharp.IconButton();
            buttonGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            iconTitulo = new FontAwesome.Sharp.IconPictureBox();
            lblDescripcion = new Label();
            lblTitulo = new Label();
            errorIcon = new ErrorProvider(components);
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDescripcion.SuspendLayout();
            panelPrioridad.SuspendLayout();
            panelCategoria.SuspendLayout();
            panelAsunto.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(pictureBox2);
            panelContenido.Controls.Add(panelDescripcion);
            panelContenido.Controls.Add(panelPrioridad);
            panelContenido.Controls.Add(panelCategoria);
            panelContenido.Controls.Add(panelAsunto);
            panelContenido.Controls.Add(label3);
            panelContenido.Controls.Add(label5);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(label1);
            panelContenido.Controls.Add(tableLayoutPanel2);
            panelContenido.Controls.Add(panel1);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(560, 555);
            panelContenido.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(0, 483);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(920, 1);
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // panelDescripcion
            // 
            panelDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDescripcion.BackColor = Color.White;
            panelDescripcion.Controls.Add(txtDescripcion);
            panelDescripcion.Location = new Point(24, 301);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(4, 0, 10, 0);
            panelDescripcion.Size = new Size(513, 157);
            panelDescripcion.TabIndex = 29;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtDescripcion.Location = new Point(7, 10);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(486, 130);
            txtDescripcion.TabIndex = 38;
            // 
            // panelPrioridad
            // 
            panelPrioridad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPrioridad.BackColor = Color.White;
            panelPrioridad.Controls.Add(cboPrioridad);
            panelPrioridad.Location = new Point(300, 217);
            panelPrioridad.Name = "panelPrioridad";
            panelPrioridad.Padding = new Padding(4, 0, 10, 0);
            panelPrioridad.Size = new Size(237, 40);
            panelPrioridad.TabIndex = 28;
            // 
            // cboPrioridad
            // 
            cboPrioridad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPrioridad.FlatStyle = FlatStyle.Flat;
            cboPrioridad.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cboPrioridad.FormattingEnabled = true;
            cboPrioridad.Items.AddRange(new object[] { "Baja", "Media", "Alta", "Crítica" });
            cboPrioridad.Location = new Point(7, 6);
            cboPrioridad.Name = "cboPrioridad";
            cboPrioridad.Size = new Size(210, 28);
            cboPrioridad.TabIndex = 38;
            // 
            // panelCategoria
            // 
            panelCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCategoria.BackColor = Color.White;
            panelCategoria.Controls.Add(cboCategoria);
            panelCategoria.Location = new Point(24, 217);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Padding = new Padding(4, 0, 10, 0);
            panelCategoria.Size = new Size(237, 40);
            panelCategoria.TabIndex = 27;
            // 
            // cboCategoria
            // 
            cboCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FlatStyle = FlatStyle.Flat;
            cboCategoria.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(7, 6);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(209, 28);
            cboCategoria.TabIndex = 38;
            // 
            // panelAsunto
            // 
            panelAsunto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelAsunto.BackColor = Color.White;
            panelAsunto.Controls.Add(txtAsunto);
            panelAsunto.Location = new Point(24, 135);
            panelAsunto.Name = "panelAsunto";
            panelAsunto.Padding = new Padding(4, 0, 10, 0);
            panelAsunto.Size = new Size(513, 40);
            panelAsunto.TabIndex = 26;
            // 
            // txtAsunto
            // 
            txtAsunto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAsunto.BorderStyle = BorderStyle.None;
            txtAsunto.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAsunto.Location = new Point(7, 10);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(490, 20);
            txtAsunto.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(300, 192);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 25;
            label3.Text = "Prioridad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(21, 276);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 24;
            label5.Text = "Descripción del problema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(21, 192);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 23;
            label2.Text = "Categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(21, 110);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 22;
            label1.Text = "Asunto";
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
            tableLayoutPanel2.Location = new Point(0, 485);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(560, 70);
            tableLayoutPanel2.TabIndex = 21;
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
            buttonCancelar.Location = new Point(421, 10);
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
            buttonGuardar.Location = new Point(299, 10);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(116, 50);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
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
            panel1.Size = new Size(560, 86);
            panel1.TabIndex = 2;
            // 
            // pictureCerrar
            // 
            pictureCerrar.Image = (Image)resources.GetObject("pictureCerrar.Image");
            pictureCerrar.Location = new Point(519, 14);
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
            pictureBox1.Size = new Size(560, 1);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // iconTitulo
            // 
            iconTitulo.Anchor = AnchorStyles.None;
            iconTitulo.BackColor = Color.White;
            iconTitulo.ForeColor = Color.FromArgb(37, 99, 235);
            iconTitulo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconTitulo.IconColor = Color.FromArgb(37, 99, 235);
            iconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTitulo.IconSize = 55;
            iconTitulo.Location = new Point(24, 14);
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
            lblDescripcion.Location = new Point(85, 49);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(263, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Complete la información del registro.";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(85, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Nuevo registro";
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmTicketsRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 555);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTicketsRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTicketsRegistro";
            Load += FrmTicketsRegistro_Load;
            Shown += FrmTicketsRegistro_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelDescripcion.PerformLayout();
            panelPrioridad.ResumeLayout(false);
            panelCategoria.ResumeLayout(false);
            panelAsunto.ResumeLayout(false);
            panelAsunto.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private PictureBox pictureBox2;
        private Panel panelDescripcion;
        private TextBox txtDescripcion;
        private Panel panelPrioridad;
        private ComboBox cboPrioridad;
        private Panel panelCategoria;
        private ComboBox cboCategoria;
        private Panel panelAsunto;
        private TextBox txtAsunto;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        public FontAwesome.Sharp.IconButton buttonCancelar;
        public FontAwesome.Sharp.IconButton buttonGuardar;
        private Panel panel1;
        private PictureBox pictureCerrar;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconTitulo;
        protected Label lblDescripcion;
        public Label lblTitulo;
        private ErrorProvider errorIcon;
    }
}