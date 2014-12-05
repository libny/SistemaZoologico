using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Animales;
using SistemaZoologico.Dominio.Aplicacion.Animales.Comandos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Animales
{
    public partial class ModificacionAnimales : Form
    {
        private readonly Animal _animal;
        private readonly ServiciosAnimales _serviciosAnimales = new ServiciosAnimales();

        public ModificacionAnimales(Animal animal)
        {
            _animal = _serviciosAnimales.ObtenerAnimal(animal.Id);
            InitializeComponent();
        }

        private void ModificacionAnimales_Load(object sender, EventArgs e)
        {
            combEspecie.ValueMember = "Id";
            combEspecie.DataSource = _serviciosAnimales.ObtenerEspecies();

            textNombre.Text = _animal.Nombre;
            numEdad.Value = _animal.Edad;

            combEspecie.SelectedValue = _animal.Especie.Id;
            dateFechaIn.Value = _animal.FechaIngreso;
            dateFechaNa.Value = _animal.FechaNacimiento;

            if (_animal.Origen.Descripcion == "Cautiverio")
            {
                radioCautiverio.Checked = true;
            }
            else
            {
                radioSalvaje.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var especie = (Especie) combEspecie.SelectedItem;
            Origen origen = null;

            if (radioCautiverio.Checked)
                origen = Origen.Cautiverio;
            else
            {
                origen = Origen.Salvaje;
            }
            _serviciosAnimales.ModificarAnimal(new ModificarAnimales(_animal.Id,textNombre.Text, Convert.ToInt32(numEdad.Value),
                dateFechaIn.Value, dateFechaNa.Value, origen, especie.Id));

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}