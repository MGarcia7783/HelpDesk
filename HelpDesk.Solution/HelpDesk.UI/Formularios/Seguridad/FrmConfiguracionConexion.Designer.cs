namespace HelpDesk.UI.Formularios.Seguridad
{
    partial class FrmConfiguracionConexion
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
            panelContenido = new Panel();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnProbar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureCerrar = new PictureBox();
            label5 = new Label();
            lblTitulo = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelContra = new Panel();
            txtClave = new TextBox();
            label4 = new Label();
            panelUser = new Panel();
            txtUsuarioSql = new TextBox();
            label3 = new Label();
            panelBD = new Panel();
            txtBaseDatos = new TextBox();
            label2 = new Label();
            panelServidor = new Panel();
            txtServidor = new TextBox();
            label1 = new Label();
            errorIcon = new ErrorProvider(components);
            panelContenido.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelContra.SuspendLayout();
            panelUser.SuspendLayout();
            panelBD.SuspendLayout();
            panelServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(panel3);
            panelContenido.Controls.Add(panel2);
            panelContenido.Controls.Add(panelContra);
            panelContenido.Controls.Add(label4);
            panelContenido.Controls.Add(panelUser);
            panelContenido.Controls.Add(label3);
            panelContenido.Controls.Add(panelBD);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(panelServidor);
            panelContenido.Controls.Add(label1);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(481, 394);
            panelContenido.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(481, 70);
            panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 0);
            tableLayoutPanel1.Controls.Add(btnProbar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(481, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Top;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.FromArgb(220, 53, 69);
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 28;
            btnCancelar.Location = new Point(342, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 50);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Canelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnProbar
            // 
            btnProbar.Cursor = Cursors.Hand;
            btnProbar.Dock = DockStyle.Top;
            btnProbar.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnProbar.IconColor = Color.FromArgb(37, 99, 235);
            btnProbar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProbar.IconSize = 24;
            btnProbar.Location = new Point(41, 3);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(173, 49);
            btnProbar.TabIndex = 0;
            btnProbar.Text = "Probar conexión";
            btnProbar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Top;
            btnGuardar.Enabled = false;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.FromArgb(37, 99, 235);
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 24;
            btnGuardar.Location = new Point(220, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 50);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureCerrar);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 86);
            panel2.TabIndex = 8;
            // 
            // pictureCerrar
            // 
            pictureCerrar.Image = Properties.Resources.cerrar24;
            pictureCerrar.Location = new Point(439, 14);
            pictureCerrar.Name = "pictureCerrar";
            pictureCerrar.Size = new Size(24, 24);
            pictureCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureCerrar.TabIndex = 11;
            pictureCerrar.TabStop = false;
            pictureCerrar.Click += pictureCerrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(87, 42);
            label5.Name = "label5";
            label5.Size = new Size(263, 20);
            label5.TabIndex = 10;
            label5.Text = "Complete la información del registro.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(87, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 32);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Conexión al Servidor";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Server;
            iconPictureBox1.IconColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(20, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(55, 55);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panelContra
            // 
            panelContra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContra.BackColor = Color.White;
            panelContra.Controls.Add(txtClave);
            panelContra.Location = new Point(139, 264);
            panelContra.Name = "panelContra";
            panelContra.Padding = new Padding(4, 0, 10, 0);
            panelContra.Size = new Size(319, 40);
            panelContra.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Location = new Point(11, 10);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(287, 20);
            txtClave.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 264);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // panelUser
            // 
            panelUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUser.BackColor = Color.White;
            panelUser.Controls.Add(txtUsuarioSql);
            panelUser.Location = new Point(139, 212);
            panelUser.Name = "panelUser";
            panelUser.Padding = new Padding(4, 0, 10, 0);
            panelUser.Size = new Size(319, 40);
            panelUser.TabIndex = 5;
            // 
            // txtUsuarioSql
            // 
            txtUsuarioSql.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuarioSql.BorderStyle = BorderStyle.None;
            txtUsuarioSql.Location = new Point(11, 10);
            txtUsuarioSql.Name = "txtUsuarioSql";
            txtUsuarioSql.Size = new Size(287, 20);
            txtUsuarioSql.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 212);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Usuario Sql";
            // 
            // panelBD
            // 
            panelBD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBD.BackColor = Color.White;
            panelBD.Controls.Add(txtBaseDatos);
            panelBD.Location = new Point(139, 161);
            panelBD.Name = "panelBD";
            panelBD.Padding = new Padding(4, 0, 10, 0);
            panelBD.Size = new Size(319, 40);
            panelBD.TabIndex = 3;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaseDatos.BorderStyle = BorderStyle.None;
            txtBaseDatos.Location = new Point(11, 10);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(287, 20);
            txtBaseDatos.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 161);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Base de Datos";
            // 
            // panelServidor
            // 
            panelServidor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelServidor.BackColor = Color.White;
            panelServidor.Controls.Add(txtServidor);
            panelServidor.Location = new Point(139, 112);
            panelServidor.Name = "panelServidor";
            panelServidor.Padding = new Padding(4, 0, 10, 0);
            panelServidor.Size = new Size(319, 40);
            panelServidor.TabIndex = 1;
            // 
            // txtServidor
            // 
            txtServidor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtServidor.BorderStyle = BorderStyle.None;
            txtServidor.Location = new Point(7, 10);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(291, 20);
            txtServidor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 112);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmConfiguracionConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 394);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguracionConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfiguracionConexion";
            Shown += FrmConfiguracionConexion_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelContra.ResumeLayout(false);
            panelContra.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panelBD.ResumeLayout(false);
            panelBD.PerformLayout();
            panelServidor.ResumeLayout(false);
            panelServidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Panel panelServidor;
        private TextBox txtServidor;
        private Label label1;
        private Panel panelContra;
        private TextBox txtClave;
        private Label label4;
        private Panel panelUser;
        private TextBox txtUsuarioSql;
        private Label label3;
        private Panel panelBD;
        private TextBox txtBaseDatos;
        private Label label2;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblTitulo;
        private PictureBox pictureCerrar;
        private Label label5;
        private Panel panel3;
        private ErrorProvider errorIcon;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnProbar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}