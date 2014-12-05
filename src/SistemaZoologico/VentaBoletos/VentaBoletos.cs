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
        readonly BindingList<DatosDetalleVenta> _listaDetalle = new BindingList<DatosDetalleVenta>();

        readonly ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();

        public VentaBoletos()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            comboxtipodeboleto.DataSource = _servicioVentaBoletos.ObtenerTipoBoletos();
            dtgDetalleVenta.DataSource = _listaDetalle;
        }

        void button1_Click(object sender, EventArgs e)
        {
            var tipo = (TipoBoleto)comboxtipodeboleto.SelectedItem;
            _listaDetalle.Add(new DatosDetalleVenta(tipo.Id, tipo.Descripcion, 1, tipo.Precio));

            CalcularTotal();
        }

        void CalcularTotal()
        {
            double total = 0.0;
            foreach (DatosDetalleVenta datosDetalleVenta in _listaDetalle)
            {
                total += datosDetalleVenta.CalcularTotal();
            }

            lblTotal.Text = "Total " + total;
        }

        void dtgDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
        }

        void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            int id =
                _servicioVentaBoletos.CrearVenta(
                    new CrearVenta(txtNombre.Text, txtApellido.Text, txtTelefono.Text, _listaDetalle));

            using (var imprimir = new ReporteVenta(id))
            {
                imprimir.ShowDialog();
            }

            Close();
        }
    }
}