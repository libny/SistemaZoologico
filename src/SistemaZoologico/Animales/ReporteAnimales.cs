using System;

namespace SistemaZoologico.Animales
{
    public class ReporteAnimales
    {
        public string Nombre { get; set; }

        public int Id { get; set; }

        public string Especie { get; set; }

        public string Origen { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}