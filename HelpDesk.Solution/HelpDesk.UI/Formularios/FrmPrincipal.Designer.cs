namespace HelpDesk.UI.Formularios
{
    partial class FrmPrincipal
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
            sidebar = new Panel();
            panel2 = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnUsuario = new FontAwesome.Sharp.IconButton();
            btnRol = new FontAwesome.Sharp.IconButton();
            btnTicket = new FontAwesome.Sharp.IconButton();
            btnCategoria = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            iconAdmin = new FontAwesome.Sharp.IconPictureBox();
            statusStrip1 = new StatusStrip();
            toolUsuario = new ToolStripStatusLabel();
            toolRol = new ToolStripStatusLabel();
            panelContenedor = new Panel();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAdmin).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 42, 68);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnUsuario);
            sidebar.Controls.Add(btnRol);
            sidebar.Controls.Add(btnTicket);
            sidebar.Controls.Add(btnCategoria);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(202, 681);
            sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 597);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 84);
            panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(200, 50);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "  Cerrar sesión";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnUsuario.IconColor = Color.White;
            btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuario.IconSize = 30;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(3, 399);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(10, 0, 0, 0);
            btnUsuario.Size = new Size(195, 50);
            btnUsuario.TabIndex = 5;
            btnUsuario.Text = "   Listado Usuarios";
            btnUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnRol
            // 
            btnRol.Cursor = Cursors.Hand;
            btnRol.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnRol.FlatAppearance.BorderSize = 0;
            btnRol.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnRol.FlatStyle = FlatStyle.Flat;
            btnRol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRol.ForeColor = Color.White;
            btnRol.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            btnRol.IconColor = Color.White;
            btnRol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRol.IconSize = 30;
            btnRol.ImageAlign = ContentAlignment.MiddleLeft;
            btnRol.Location = new Point(3, 346);
            btnRol.Name = "btnRol";
            btnRol.Padding = new Padding(10, 0, 0, 0);
            btnRol.Size = new Size(195, 50);
            btnRol.TabIndex = 4;
            btnRol.Text = "   Listado Roles";
            btnRol.TextAlign = ContentAlignment.MiddleRight;
            btnRol.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRol.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            btnTicket.Cursor = Cursors.Hand;
            btnTicket.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnTicket.FlatAppearance.BorderSize = 0;
            btnTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnTicket.FlatStyle = FlatStyle.Flat;
            btnTicket.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTicket.ForeColor = Color.White;
            btnTicket.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            btnTicket.IconColor = Color.White;
            btnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTicket.IconSize = 30;
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(3, 293);
            btnTicket.Name = "btnTicket";
            btnTicket.Padding = new Padding(10, 0, 0, 0);
            btnTicket.Size = new Size(195, 50);
            btnTicket.TabIndex = 3;
            btnTicket.Text = "   Gestión Tickets";
            btnTicket.TextAlign = ContentAlignment.MiddleRight;
            btnTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTicket.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategoria.ForeColor = Color.White;
            btnCategoria.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnCategoria.IconColor = Color.White;
            btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategoria.IconSize = 30;
            btnCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategoria.Location = new Point(3, 240);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Padding = new Padding(10, 0, 0, 0);
            btnCategoria.Size = new Size(195, 50);
            btnCategoria.TabIndex = 2;
            btnCategoria.Text = "   Categorías";
            btnCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 30;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 187);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(195, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 168);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 127);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 2;
            label2.Text = "Sistema de Soporte";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 87);
            label1.Name = "label1";
            label1.Size = new Size(184, 38);
            label1.TabIndex = 1;
            label1.Text = "HelpDesk";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconAdmin
            // 
            iconAdmin.BackColor = Color.FromArgb(31, 42, 68);
            iconAdmin.IconChar = FontAwesome.Sharp.IconChar.Headset;
            iconAdmin.IconColor = Color.White;
            iconAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAdmin.IconSize = 70;
            iconAdmin.Location = new Point(65, 16);
            iconAdmin.Name = "iconAdmin";
            iconAdmin.Size = new Size(70, 70);
            iconAdmin.SizeMode = PictureBoxSizeMode.AutoSize;
            iconAdmin.TabIndex = 0;
            iconAdmin.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.BackColor = Color.FromArgb(229, 231, 235);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolUsuario, toolRol });
            statusStrip1.Location = new Point(202, 641);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1062, 40);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolUsuario
            // 
            toolUsuario.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolUsuario.Name = "toolUsuario";
            toolUsuario.Padding = new Padding(8, 6, 8, 6);
            toolUsuario.Size = new Size(77, 35);
            toolUsuario.Text = "Usuario:";
            // 
            // toolRol
            // 
            toolRol.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolRol.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolRol.Name = "toolRol";
            toolRol.Padding = new Padding(8, 6, 8, 6);
            toolRol.Size = new Size(50, 35);
            toolRol.Text = "Rol:";
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Location = new Point(202, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1062, 638);
            panelContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContenedor);
            Controls.Add(statusStrip1);
            Controls.Add(sidebar);
            MinimumSize = new Size(1280, 720);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Administrativo";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmPrincipal_FormClosing;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAdmin).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconAdmin;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnRol;
        private FontAwesome.Sharp.IconButton btnTicket;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSalir;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolUsuario;
        private ToolStripStatusLabel toolRol;
        private Panel panelContenedor;
    }
}