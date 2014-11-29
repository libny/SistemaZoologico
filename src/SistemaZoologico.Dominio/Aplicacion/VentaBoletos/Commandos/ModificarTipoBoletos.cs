namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos
{
    public class ModificarTipoBoletos
    {
        public ModificarTipoBoletos(int id, string descripcion, float precio)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
    }
}