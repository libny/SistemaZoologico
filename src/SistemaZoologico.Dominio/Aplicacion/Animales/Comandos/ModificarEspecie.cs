using System;

namespace SistemaZoologico.Dominio.Aplicacion.Animales.Comandos
{
    public class ModificarEspecie
    {
        public ModificarEspecie(int id, string nombre, string nombrecientifico, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Nombrecientifico = nombrecientifico;
            Descripcion = descripcion;
        }

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Nombrecientifico { get; set; }
        public String Descripcion { get; set; }
    }
}