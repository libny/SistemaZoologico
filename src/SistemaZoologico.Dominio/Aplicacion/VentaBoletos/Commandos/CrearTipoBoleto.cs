namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos
{
    public class CrearTipoBoleto
    {
        public CrearTipoBoleto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}