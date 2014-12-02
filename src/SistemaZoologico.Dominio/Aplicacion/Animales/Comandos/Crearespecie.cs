using System;

namespace SistemaZoologico.Dominio.Aplicacion.Animales.Comandos
{
    public class Crearespecie
    {
        public Crearespecie(String nombre, String nombrecientifico, string descripcion)
        {
            Nombre = nombre;
            Nombrecientifico = nombrecientifico;
            Descripcion = descripcion;
        }

        public String Nombre { get; set; }
        public String  Nombrecientifico { get; set; }
        public String  Descripcion { get; set; }
    }
}