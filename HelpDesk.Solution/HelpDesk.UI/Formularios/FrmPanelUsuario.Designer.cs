namespace HelpDesk.UI.Formularios
{
    partial class FrmPanelUsuario
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
            btnMisTickets = new FontAwesome.Sharp.IconButton();
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
            sidebar.Controls.Add(btnMisTickets);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(202, 641);
            sidebar.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 557);
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
            // btnMisTickets
            // 
            btnMisTickets.Cursor = Cursors.Hand;
            btnMisTickets.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnMisTickets.FlatAppearance.BorderSize = 0;
            btnMisTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnMisTickets.FlatStyle = FlatStyle.Flat;
            btnMisTickets.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMisTickets.ForeColor = Color.White;
            btnMisTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            btnMisTickets.IconColor = Color.White;
            btnMisTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMisTickets.IconSize = 30;
            btnMisTickets.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisTickets.Location = new Point(3, 187);
            btnMisTickets.Name = "btnMisTickets";
            btnMisTickets.Padding = new Padding(10, 0, 0, 0);
            btnMisTickets.Size = new Size(195, 50);
            btnMisTickets.TabIndex = 1;
            btnMisTickets.Text = "   Mis Tickets";
            btnMisTickets.TextAlign = ContentAlignment.MiddleRight;
            btnMisTickets.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMisTickets.UseVisualStyleBackColor = true;
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
            statusStrip1.Location = new Point(0, 641);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1264, 40);
            statusStrip1.TabIndex = 4;
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
            panelContenedor.TabIndex = 5;
            // 
            // FrmPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(sidebar);
            Controls.Add(statusStrip1);
            Controls.Add(panelContenedor);
            MinimumSize = new Size(1280, 720);
            Name = "FrmPanelUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPanelUsuario";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmPanelUsuario_FormClosing;
            Load += FrmPanelUsuario_Load;
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
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnMisTickets;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconAdmin;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolUsuario;
        private ToolStripStatusLabel toolRol;
        private Panel panelContenedor;
    }
}