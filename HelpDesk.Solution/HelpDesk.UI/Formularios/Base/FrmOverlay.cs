using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDesk.UI.Formularios.Base
{
    public partial class FrmOverlay : Form
    {
        public FrmOverlay(Form formularioPadre)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;

            // Mismo tamaño y posición del formulario principal
            Location = formularioPadre.PointToScreen(Point.Empty);
            Size = formularioPadre.ClientSize;

            BackColor = Color.FromArgb(30, 41, 59);
            Opacity = 0.45;

            ShowInTaskbar = false;

            TopMost = false;
        }
    }
}
