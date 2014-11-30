using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.VentaBoletos
{
    public partial class ListarTipoDeBoletos : Form
    {
        private readonly ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();

        public ListarTipoDeBoletos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListarTipoDeBoletos_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            listTipoBoleto.DataSource = _servicioVentaBoletos.ObtenerTipoBoletos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tipo = (TipoBoleto) listTipoBoleto.SelectedItem;
            using (var modificar = new ModificarTipoBoleto(tipo))
            {
                modificar.ShowDialog();
            }
            CargarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}