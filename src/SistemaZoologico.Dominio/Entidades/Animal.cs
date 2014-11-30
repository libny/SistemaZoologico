using System;

namespace SistemaZoologico.Dominio.Entidades
{
    public class Animal : IEntidad
    {
        public Animal()
        {
            
        }
        public Animal(String nombre, int edad, Especie especie, DateTime fechaIngreso, DateTime fechaNacimiento,
            Origen origenDeAnimal)
        {
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
            FechaIngreso = fechaIngreso;
            FechaNacimiento = fechaNacimiento;
            Origen = origenDeAnimal;
        }

        public virtual string Nombre { get; set; }
        public virtual int Edad { get; set; }
        public virtual DateTime FechaIngreso { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        
        public virtual Especie Especie { get; set; }
        public virtual Origen Origen { get; set; }
        public virtual int Id { get; set; }
    }
}