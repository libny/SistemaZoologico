using System;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Aplicacion.Animales.Comandos
{
    public class ModificarAnimales
    {
        public ModificarAnimales(int idAnimal, string nombre, int edad, DateTime fechIngreso, DateTime fechaNacimiento,
            Origen origenAnimal,
            int idEspecie)
        {
            IdAnimal = idAnimal;
            Nombre = nombre;
            Edad = edad;
            FechaIngreso = fechIngreso;
            FechaNacimiento = fechaNacimiento;
            OrigenAnimal = origenAnimal;
            IdEspecie = idEspecie;
        }

        public int IdAnimal { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public int IdEspecie { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Origen OrigenAnimal { get; set; }
    }
}