using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.VentaBoletos
{
    public partial class ModificarTipoBoleto : Form
    {
        private readonly TipoBoleto _tipoBoleto;
        private  ServicioVentaBoletos  _servicioVentaBoletos = new ServicioVentaBoletos();
        public ModificarTipoBoleto(TipoBoleto tipoBoleto)
        {
            _tipoBoleto = tipoBoleto;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _servicioVentaBoletos.ModificarTipoBoleto(new ModificarTipoBoletos(_tipoBoleto.Id,txtDescripcion.Text ,Convert.ToSingle(numPercio.Value)));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarTipoBoleto_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = _tipoBoleto.Descripcion;
            numPercio.Value = Convert.ToDecimal(_tipoBoleto.Precio);

        }
    }
}