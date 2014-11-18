using System;

namespace SistemaZoologico.Dominio.Entidades
{
    public class Animal : IEntidad
    {
        public virtual string Nombre { get; set; }
        public virtual int Edad { get; set; }
        public virtual DateTime FechaIngreso { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual Especie Especie { get; set; }
        public virtual Origen Origen { get; set; }
        public virtual int Id { get; set; }
    }
}