using System;
using System.Windows.Forms;
using SistemaZoologico.VentaBoletos;

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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var tipo = new CrearTipoBoletos())
            {
                tipo.ShowDialog();
            }
        }
    }
}