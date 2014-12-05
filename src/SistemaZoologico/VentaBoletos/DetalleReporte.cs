namespace SistemaZoologico.VentaBoletos
{
    public class DetalleReporte
    {
        public string NombreCliente { get; set; }
        public double Total { get; set; }
        public string DescripcionTipoBoleto { get; set; }
        public string Cantidad { get; set; }
        public double SubTotal { get; set; }
    }
}