using System;
using System.ComponentModel;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.VentaBoletos
{
    public partial class VentaBoletos : Form
    {
        private readonly BindingList<DatosDetalleVenta> _listaDetalle = new BindingList<DatosDetalleVenta>();
        private readonly ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();

        public VentaBoletos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboxtipodeboleto.DataSource = _servicioVentaBoletos.ObtenerTipoBoletos();
            dtgDetalleVenta.DataSource = _listaDetalle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tipo = (TipoBoleto) comboxtipodeboleto.SelectedItem;
            _listaDetalle.Add(new DatosDetalleVenta(tipo.Id, tipo.Nombre, 1, tipo.Precio));

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double total = 0.0;
            foreach (DatosDetalleVenta datosDetalleVenta in _listaDetalle)
            {
                total += datosDetalleVenta.CalcularTotal();
            }

            lblTotal.Text = "Total " + total;
        }

        private void dtgDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _servicioVentaBoletos.CrearVenta(new CrearVenta(txtNombre.Text, txtApellido.Text, txtTelefono.Text,
                _listaDetalle));

            Close();
        }
    }
}