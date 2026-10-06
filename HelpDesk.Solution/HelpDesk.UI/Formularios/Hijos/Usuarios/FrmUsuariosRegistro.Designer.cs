namespace HelpDesk.UI.Formularios.Hijos.Usuarios
{
    partial class FrmUsuariosRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosRegistro));
            panelContenido = new Panel();
            pictureBox2 = new PictureBox();
            panelContra = new Panel();
            txtContra = new TextBox();
            panelRol = new Panel();
            cboRoles = new ComboBox();
            panelCorreo = new Panel();
            txtCorreo = new TextBox();
            panelUsuario = new Panel();
            txtUsuario = new TextBox();
            panelNombre = new Panel();
            txtNombreCompleto = new TextBox();
            panel1 = new Panel();
            pictureCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            iconTitulo = new FontAwesome.Sharp.IconPictureBox();
            lblDescripcion = new Label();
            lblTitulo = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancelar = new FontAwesome.Sharp.IconButton();
            buttonGuardar = new FontAwesome.Sharp.IconButton();
            errorIcon = new ErrorProvider(components);
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContra.SuspendLayout();
            panelRol.SuspendLayout();
            panelCorreo.SuspendLayout();
            panelUsuario.SuspendLayout();
            panelNombre.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(pictureBox2);
            panelContenido.Controls.Add(panelContra);
            panelContenido.Controls.Add(panelRol);
            panelContenido.Controls.Add(panelCorreo);
            panelContenido.Controls.Add(panelUsuario);
            panelContenido.Controls.Add(panelNombre);
            panelContenido.Controls.Add(panel1);
            panelContenido.Controls.Add(label5);
            panelContenido.Controls.Add(label3);
            panelContenido.Controls.Add(label4);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(label1);
            panelContenido.Controls.Add(tableLayoutPanel2);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Font = new Font("Segoe UI Semibold", 11F);
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(549, 461);
            panelContenido.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(0, 389);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(898, 1);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // panelContra
            // 
            panelContra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContra.BackColor = Color.White;
            panelContra.Controls.Add(txtContra);
            panelContra.Location = new Point(173, 320);
            panelContra.Name = "panelContra";
            panelContra.Padding = new Padding(4, 0, 10, 0);
            panelContra.Size = new Size(353, 40);
            panelContra.TabIndex = 14;
            // 
            // txtContra
            // 
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Font = new Font("Segoe UI Semibold", 11F);
            txtContra.Location = new Point(7, 10);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(327, 20);
            txtContra.TabIndex = 19;
            // 
            // panelRol
            // 
            panelRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRol.BackColor = Color.White;
            panelRol.Controls.Add(cboRoles);
            panelRol.Location = new Point(173, 268);
            panelRol.Name = "panelRol";
            panelRol.Padding = new Padding(4, 0, 10, 0);
            panelRol.Size = new Size(353, 40);
            panelRol.TabIndex = 13;
            // 
            // cboRoles
            // 
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoles.FlatStyle = FlatStyle.Flat;
            cboRoles.FormattingEnabled = true;
            cboRoles.Location = new Point(7, 6);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(327, 28);
            cboRoles.TabIndex = 18;
            // 
            // panelCorreo
            // 
            panelCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCorreo.BackColor = Color.White;
            panelCorreo.Controls.Add(txtCorreo);
            panelCorreo.Location = new Point(173, 216);
            panelCorreo.Name = "panelCorreo";
            panelCorreo.Padding = new Padding(4, 0, 10, 0);
            panelCorreo.Size = new Size(353, 40);
            panelCorreo.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI Semibold", 11F);
            txtCorreo.Location = new Point(7, 10);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(327, 20);
            txtCorreo.TabIndex = 17;
            // 
            // panelUsuario
            // 
            panelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUsuario.BackColor = Color.White;
            panelUsuario.Controls.Add(txtUsuario);
            panelUsuario.Location = new Point(173, 165);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Padding = new Padding(4, 0, 10, 0);
            panelUsuario.Size = new Size(353, 40);
            panelUsuario.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI Semibold", 11F);
            txtUsuario.Location = new Point(7, 10);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(327, 20);
            txtUsuario.TabIndex = 16;
            // 
            // panelNombre
            // 
            panelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNombre.BackColor = Color.White;
            panelNombre.Controls.Add(txtNombreCompleto);
            panelNombre.Location = new Point(173, 113);
            panelNombre.Name = "panelNombre";
            panelNombre.Padding = new Padding(4, 0, 10, 0);
            panelNombre.Size = new Size(353, 40);
            panelNombre.TabIndex = 10;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCompleto.BorderStyle = BorderStyle.None;
            txtNombreCompleto.Font = new Font("Segoe UI Semibold", 11F);
            txtNombreCompleto.ForeColor = SystemColors.WindowText;
            txtNombreCompleto.Location = new Point(11, 10);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(323, 20);
            txtNombreCompleto.TabIndex = 15;
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
            panel1.Size = new Size(549, 86);
            panel1.TabIndex = 1;
            // 
            // pictureCerrar
            // 
            pictureCerrar.Image = (Image)resources.GetObject("pictureCerrar.Image");
            pictureCerrar.Location = new Point(510, 14);
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
            pictureBox1.Size = new Size(549, 1);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(21, 320);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(21, 268);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 8;
            label3.Text = "Rol de usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(21, 216);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 7;
            label4.Text = "Correo electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(21, 165);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(21, 113);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre completo:";
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
            tableLayoutPanel2.Location = new Point(0, 391);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(549, 70);
            tableLayoutPanel2.TabIndex = 20;
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
            buttonCancelar.Location = new Point(410, 10);
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
            buttonGuardar.Location = new Point(288, 10);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(116, 50);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmUsuariosRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 461);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuariosRegistro";
            Load += FrmUsuariosRegistro_Load;
            Shown += FrmUsuariosRegistro_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContra.ResumeLayout(false);
            panelContra.PerformLayout();
            panelRol.ResumeLayout(false);
            panelCorreo.ResumeLayout(false);
            panelCorreo.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panelNombre.ResumeLayout(false);
            panelNombre.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelContenido;
        private PictureBox pictureBox2;
        private Panel panelContra;
        private TextBox txtContra;
        private Panel panelRol;
        private ComboBox cboRoles;
        private Panel panelCorreo;
        private TextBox txtCorreo;
        private Panel panelUsuario;
        private TextBox txtUsuario;
        private Panel panelNombre;
        private TextBox txtNombreCompleto;
        private Panel panel1;
        private PictureBox pictureCerrar;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconTitulo;
        protected Label lblDescripcion;
        public Label lblTitulo;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        public FontAwesome.Sharp.IconButton buttonCancelar;
        public FontAwesome.Sharp.IconButton buttonGuardar;
        private ErrorProvider errorIcon;
    }
}