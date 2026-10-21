namespace HelpDesk.UI.Formularios.Seguridad
{
    partial class FrmInicioSesion
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
            panelClave = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconClave = new FontAwesome.Sharp.IconPictureBox();
            txtClave = new TextBox();
            panelServidor = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            txtUsuario = new TextBox();
            iconUsuario = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            iconHelp = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            buttonIngresar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label7 = new Label();
            errorIcon = new ErrorProvider(components);
            panelContenido.SuspendLayout();
            panelClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconClave).BeginInit();
            panelServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.Controls.Add(panelClave);
            panelContenido.Controls.Add(panelServidor);
            panelContenido.Controls.Add(panel2);
            panelContenido.Controls.Add(panel1);
            panelContenido.Controls.Add(buttonIngresar);
            panelContenido.Controls.Add(label5);
            panelContenido.Controls.Add(label7);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Font = new Font("Segoe UI Semibold", 11F);
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(414, 421);
            panelContenido.TabIndex = 10;
            // 
            // panelClave
            // 
            panelClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelClave.BackColor = Color.White;
            panelClave.Controls.Add(iconPictureBox3);
            panelClave.Controls.Add(iconClave);
            panelClave.Controls.Add(txtClave);
            panelClave.Location = new Point(25, 215);
            panelClave.Name = "panelClave";
            panelClave.Padding = new Padding(4, 0, 10, 0);
            panelClave.Size = new Size(364, 40);
            panelClave.TabIndex = 58;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.None;
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = Color.DimGray;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox3.IconColor = Color.DimGray;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 22;
            iconPictureBox3.Location = new Point(8, 9);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(22, 22);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox3.TabIndex = 53;
            iconPictureBox3.TabStop = false;
            // 
            // iconClave
            // 
            iconClave.Anchor = AnchorStyles.None;
            iconClave.BackColor = Color.White;
            iconClave.ForeColor = Color.DimGray;
            iconClave.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconClave.IconColor = Color.DimGray;
            iconClave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClave.IconSize = 22;
            iconClave.Location = new Point(87, -21);
            iconClave.Name = "iconClave";
            iconClave.Size = new Size(22, 22);
            iconClave.SizeMode = PictureBoxSizeMode.AutoSize;
            iconClave.TabIndex = 48;
            iconClave.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Location = new Point(36, 10);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "Ingrese su contraseña";
            txtClave.Size = new Size(307, 20);
            txtClave.TabIndex = 52;
            // 
            // panelServidor
            // 
            panelServidor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelServidor.BackColor = Color.White;
            panelServidor.Controls.Add(iconPictureBox2);
            panelServidor.Controls.Add(txtUsuario);
            panelServidor.Controls.Add(iconUsuario);
            panelServidor.Location = new Point(26, 132);
            panelServidor.Name = "panelServidor";
            panelServidor.Padding = new Padding(4, 0, 10, 0);
            panelServidor.Size = new Size(364, 40);
            panelServidor.TabIndex = 57;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.None;
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.DimGray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = Color.DimGray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 22;
            iconPictureBox2.Location = new Point(7, 9);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(22, 22);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox2.TabIndex = 52;
            iconPictureBox2.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(35, 10);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(307, 20);
            txtUsuario.TabIndex = 51;
            // 
            // iconUsuario
            // 
            iconUsuario.Anchor = AnchorStyles.None;
            iconUsuario.BackColor = Color.White;
            iconUsuario.ForeColor = Color.DimGray;
            iconUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            iconUsuario.IconColor = Color.DimGray;
            iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuario.IconSize = 22;
            iconUsuario.Location = new Point(86, -21);
            iconUsuario.Name = "iconUsuario";
            iconUsuario.Size = new Size(22, 22);
            iconUsuario.SizeMode = PictureBoxSizeMode.AutoSize;
            iconUsuario.TabIndex = 41;
            iconUsuario.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconHelp);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 351);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 70);
            panel2.TabIndex = 56;
            // 
            // iconHelp
            // 
            iconHelp.Anchor = AnchorStyles.None;
            iconHelp.BackColor = Color.White;
            iconHelp.ForeColor = Color.FromArgb(37, 99, 235);
            iconHelp.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
            iconHelp.IconColor = Color.FromArgb(37, 99, 235);
            iconHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHelp.IconSize = 25;
            iconHelp.Location = new Point(123, 28);
            iconHelp.Name = "iconHelp";
            iconHelp.Size = new Size(29, 25);
            iconHelp.SizeMode = PictureBoxSizeMode.CenterImage;
            iconHelp.TabIndex = 58;
            iconHelp.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.ForeColor = Color.FromArgb(37, 99, 235);
            label3.Location = new Point(149, 27);
            label3.Name = "label3";
            label3.Size = new Size(240, 19);
            label3.TabIndex = 59;
            label3.Text = "¿No tienes cuenta? Registrar usuario.";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(414, 1);
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 86);
            panel1.TabIndex = 55;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Headset;
            iconPictureBox1.IconColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(25, 15);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(55, 55);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 47;
            iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(86, 50);
            label4.Name = "label4";
            label4.Size = new Size(277, 20);
            label4.TabIndex = 49;
            label4.Text = "Ingrese sus credenciales para continuar";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(86, 15);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 48;
            label6.Text = "Bienvenido";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Location = new Point(0, 85);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(414, 1);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonIngresar.BackColor = Color.FromArgb(37, 99, 235);
            buttonIngresar.Cursor = Cursors.Hand;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonIngresar.ForeColor = Color.White;
            buttonIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            buttonIngresar.IconColor = Color.FromArgb(25, 135, 84);
            buttonIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonIngresar.IconSize = 28;
            buttonIngresar.Location = new Point(26, 280);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(363, 50);
            buttonIngresar.TabIndex = 41;
            buttonIngresar.Text = "Iniciar sesión";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(25, 189);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 31;
            label5.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.Location = new Point(25, 106);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 26;
            label7.Text = "Usuario:";
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 421);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInicioSesion";
            Shown += FrmInicioSesion_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panelClave.ResumeLayout(false);
            panelClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconClave).EndInit();
            panelServidor.ResumeLayout(false);
            panelServidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelContenido;
        private Panel panelClave;
        private FontAwesome.Sharp.IconPictureBox iconClave;
        private TextBox txtClave;
        private Panel panelServidor;
        private TextBox txtUsuario;
        private FontAwesome.Sharp.IconPictureBox iconUsuario;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconHelp;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        protected Label label4;
        public Label label6;
        private PictureBox pictureBox3;
        public FontAwesome.Sharp.IconButton buttonIngresar;
        private Label label5;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private ErrorProvider errorIcon;
    }
}