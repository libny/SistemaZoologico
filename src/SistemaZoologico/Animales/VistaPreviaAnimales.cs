using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SistemaZoologico.Dominio.Aplicacion.Animales;

namespace SistemaZoologico.Animales
{
    public partial class VistaPreviaAnimales : Form
    {
        readonly ServiciosAnimales _serviciosAnimales = new ServiciosAnimales();

        public VistaPreviaAnimales()
        {
            InitializeComponent();
        }

        void VistaPreviaAnimales_Load(object sender, EventArgs e)
        {
            IEnumerable<ReporteAnimales> animales =
                _serviciosAnimales.ObtenerAnimales()
                                  .Select(
                                      animal =>
                                      new ReporteAnimales
                                          {
                                              Especie = animal.Especie.Descripcion,
                                              FechaIngreso = animal.FechaIngreso,
                                              FechaNacimiento = animal.FechaNacimiento,
                                              Id = animal.Id,
                                              Nombre = animal.Nombre,
                                              Origen = animal.Origen.Descripcion
                                          });

            var binding = (BindingSource)reportViewer1.LocalReport.DataSources[0].Value;
            foreach (var reporteAnimalese in animales)
            {
                binding.Add(reporteAnimalese);
            }
            reportViewer1.RefreshReport();
        }
    }
}