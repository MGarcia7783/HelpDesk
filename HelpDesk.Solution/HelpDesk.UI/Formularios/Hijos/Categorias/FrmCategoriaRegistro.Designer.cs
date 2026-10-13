namespace HelpDesk.UI.Formularios.Hijos.Categorias
{
    partial class FrmCategoriaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriaRegistro));
            panelContenido = new Panel();
            panelDescripcion = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            textBox2 = new TextBox();
            txtDescripcion = new TextBox();
            panelNombre = new Panel();
            txtNombreCategoria = new TextBox();
            panel1 = new Panel();
            pictureCerrar = new PictureBox();
            pictureBox3 = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblDescripcion = new Label();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancelar = new FontAwesome.Sharp.IconButton();
            buttonGuardar = new FontAwesome.Sharp.IconButton();
            errorIcon = new ErrorProvider(components);
            panelContenido.SuspendLayout();
            panelDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panelNombre.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(panelDescripcion);
            panelContenido.Controls.Add(panelNombre);
            panelContenido.Controls.Add(panel1);
            panelContenido.Controls.Add(pictureBox2);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(label1);
            panelContenido.Controls.Add(tableLayoutPanel2);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Font = new Font("Segoe UI Semibold", 11F);
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(535, 315);
            panelContenido.TabIndex = 9;
            // 
            // panelDescripcion
            // 
            panelDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDescripcion.BackColor = Color.White;
            panelDescripcion.Controls.Add(iconPictureBox2);
            panelDescripcion.Controls.Add(textBox2);
            panelDescripcion.Controls.Add(txtDescripcion);
            panelDescripcion.Location = new Point(173, 166);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(4, 0, 10, 0);
            panelDescripcion.Size = new Size(339, 57);
            panelDescripcion.TabIndex = 57;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Left;
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.DimGray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox2.IconColor = Color.DimGray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 25;
            iconPictureBox2.Location = new Point(13, -72);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 25);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 42;
            iconPictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(47, -70);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Buscar registro";
            textBox2.Size = new Size(784, 20);
            textBox2.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 11F);
            txtDescripcion.Location = new Point(11, 8);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(314, 42);
            txtDescripcion.TabIndex = 22;
            // 
            // panelNombre
            // 
            panelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNombre.BackColor = Color.White;
            panelNombre.Controls.Add(txtNombreCategoria);
            panelNombre.Location = new Point(173, 112);
            panelNombre.Name = "panelNombre";
            panelNombre.Padding = new Padding(4, 0, 10, 0);
            panelNombre.Size = new Size(339, 40);
            panelNombre.TabIndex = 56;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCategoria.BackColor = Color.White;
            txtNombreCategoria.BorderStyle = BorderStyle.None;
            txtNombreCategoria.Font = new Font("Segoe UI Semibold", 11F);
            txtNombreCategoria.Location = new Point(11, 10);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(314, 20);
            txtNombreCategoria.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureCerrar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 86);
            panel1.TabIndex = 55;
            // 
            // pictureCerrar
            // 
            pictureCerrar.Image = (Image)resources.GetObject("pictureCerrar.Image");
            pictureCerrar.Location = new Point(495, 14);
            pictureCerrar.Name = "pictureCerrar";
            pictureCerrar.Size = new Size(24, 24);
            pictureCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureCerrar.TabIndex = 47;
            pictureCerrar.TabStop = false;
            pictureCerrar.Click += pictureCerrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Location = new Point(0, 85);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(535, 1);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconPictureBox1.IconColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(21, 15);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(55, 55);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 41;
            iconPictureBox1.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 11F);
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(82, 50);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(263, 20);
            lblDescripcion.TabIndex = 43;
            lblDescripcion.Text = "Complete la información del registro.";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(82, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 32);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Nuevo registro";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(0, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(870, 1);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(21, 166);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 20;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(21, 112);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 19;
            label1.Text = "Nombre categoría:";
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
            tableLayoutPanel2.Location = new Point(0, 245);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(535, 70);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            buttonCancelar.IconColor = Color.FromArgb(220, 53, 69);
            buttonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonCancelar.IconSize = 30;
            buttonCancelar.Location = new Point(396, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(116, 50);
            buttonCancelar.TabIndex = 4;
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
            buttonGuardar.IconSize = 30;
            buttonGuardar.Location = new Point(274, 10);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(116, 50);
            buttonGuardar.TabIndex = 3;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmCategoriaRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 315);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategoriaRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategoriaRegistro";
            Load += FrmCategoriaRegistro_Load;
            Shown += FrmCategoriaRegistro_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panelDescripcion.ResumeLayout(false);
            panelDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panelNombre.ResumeLayout(false);
            panelNombre.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelContenido;
        private Panel panelDescripcion;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public TextBox textBox2;
        private TextBox txtDescripcion;
        private Panel panelNombre;
        private TextBox txtNombreCategoria;
        private Panel panel1;
        private PictureBox pictureCerrar;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        protected Label lblDescripcion;
        public Label lblTitulo;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        public FontAwesome.Sharp.IconButton buttonCancelar;
        public FontAwesome.Sharp.IconButton buttonGuardar;
        private ErrorProvider errorIcon;
    }
}