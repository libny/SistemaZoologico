namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos
{
    public class CrearTipoBoleto
    {
        public CrearTipoBoleto(string descripcion, float precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public string Descripcion { get; set; }
        public float Precio { get; set; }
    }
}