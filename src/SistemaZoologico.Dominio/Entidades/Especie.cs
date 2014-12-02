using System;

namespace SistemaZoologico.Dominio.Entidades
{
    public class Especie : IEntidad
    {
        public Especie()
        {
            
        }
        public Especie(String nombre, String nombreCientifico, string descripcion)
        {
            Nombre = nombre;
            NombreCientifico = nombreCientifico;
            Descripcion = descripcion;
        }

        public virtual string Nombre { get; set; }
        public virtual string NombreCientifico { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual int Id { get; set; }
    }
}