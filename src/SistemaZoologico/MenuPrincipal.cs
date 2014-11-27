using System;
using System.Windows.Forms;

namespace SistemaZoologico
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var venta = new VentaBoletos.VentaBoletos())
            {
                venta.ShowDialog();
            }
        }
    }
}